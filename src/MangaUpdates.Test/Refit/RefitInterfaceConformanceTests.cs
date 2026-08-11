/*
 * Structural sweep over every Refit interface in MangaUpdates.Api. For each method:
 *   - exactly one HTTP verb attribute, with a route starting at "/"
 *   - every {placeholder} in the route has a matching parameter (name or [AliasAs])
 *   - at most one [Body] parameter, and never on a [Multipart] method
 *   - the return type is Task or Task<T>
 *   - the last parameter is an optional CancellationToken (repo convention)
 * These invariants are what the hand-maintained conversion could get wrong silently;
 * the sweep makes adding a new endpoint self-checking.
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text.RegularExpressions;
using System.Threading;
using System.Threading.Tasks;
using Refit;
using Xunit;

namespace MangaUpdates.Test.Refit
{
    public class RefitInterfaceConformanceTests
    {
        public static IEnumerable<object[]> ApiInterfaces()
        {
            return typeof(MangaUpdates.Api.ISeriesApi).Assembly.GetTypes()
                .Where(t => t.IsInterface && t.Namespace == "MangaUpdates.Api")
                .Select(t => new object[] { t });
        }

        [Fact]
        public void All_Seventeen_Interfaces_Are_Present()
        {
            Assert.Equal(17, ApiInterfaces().Count());
        }

        [Theory]
        [MemberData(nameof(ApiInterfaces))]
        public void Interface_Methods_Are_Wellformed(Type apiInterface)
        {
            var methods = apiInterface.GetMethods();
            Assert.NotEmpty(methods);

            foreach (var method in methods)
            {
                var id = $"{apiInterface.Name}.{method.Name}";

                // exactly one HTTP verb attribute with a rooted route
                var http = method.GetCustomAttributes<HttpMethodAttribute>(inherit: true).ToList();
                Assert.True(http.Count == 1, $"{id}: expected exactly one HTTP verb attribute, found {http.Count}");
                var route = http[0].Path;
                Assert.True(route.StartsWith("/"), $"{id}: route '{route}' does not start with '/'");

                // every {placeholder} must be satisfiable by a parameter (name or AliasAs)
                var parameters = method.GetParameters();
                var parameterNames = parameters
                    .Select(p => p.GetCustomAttribute<AliasAsAttribute>()?.Name ?? p.Name)
                    .ToHashSet(StringComparer.Ordinal);
                foreach (Match m in Regex.Matches(route, @"\{(\w+)\}"))
                {
                    Assert.True(parameterNames.Contains(m.Groups[1].Value),
                        $"{id}: route placeholder '{{{m.Groups[1].Value}}}' has no matching parameter");
                }

                // at most one [Body], and never combined with [Multipart]
                var bodies = parameters.Where(p => p.GetCustomAttribute<BodyAttribute>() != null).ToList();
                Assert.True(bodies.Count <= 1, $"{id}: {bodies.Count} [Body] parameters");
                if (method.GetCustomAttribute<MultipartAttribute>() != null)
                {
                    Assert.True(bodies.Count == 0, $"{id}: [Multipart] method must not also have [Body]");
                }

                // async-only surface: Task or Task<T>
                Assert.True(typeof(Task).IsAssignableFrom(method.ReturnType),
                    $"{id}: return type {method.ReturnType.Name} is not Task-based");

                // repo convention: every operation takes an optional CancellationToken last
                var last = parameters.LastOrDefault();
                Assert.True(last != null && last.ParameterType == typeof(CancellationToken),
                    $"{id}: last parameter must be a CancellationToken");
                Assert.True(last.IsOptional, $"{id}: the CancellationToken must be optional");
            }
        }
    }
}
