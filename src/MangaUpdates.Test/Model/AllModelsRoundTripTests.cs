using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text.Json;
using MangaUpdates.Client;
using MangaUpdates.Model;
using Xunit;

namespace MangaUpdates.Test.Model
{
    /// <summary>
    /// Reflection-driven guards over the whole model surface: every DTO must survive a
    /// serialize → deserialize → serialize round-trip through <see cref="MangaUpdatesJson.Options"/>,
    /// and every enum member must round-trip through its [EnumMember] wire value.
    /// </summary>
    public class AllModelsRoundTripTests
    {
        public static IEnumerable<object[]> ModelTypes() =>
            typeof(ApiResponseV1).Assembly.GetTypes()
                .Where(t => t.Namespace == "MangaUpdates.Model"
                            && t.IsClass && !t.IsAbstract && !t.IsNested
                            // generated models expose a protected parameterless ctor
                            && t.GetConstructor(BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic,
                                binder: null, Type.EmptyTypes, modifiers: null) != null)
                .Select(t => new object[] { t });

        public static IEnumerable<object[]> EnumTypes() =>
            typeof(ApiResponseV1).Assembly.GetTypes()
                .Where(t => t.Namespace == "MangaUpdates.Model")
                .SelectMany(t => t.IsEnum ? new[] { t } : t.GetNestedTypes().Where(n => n.IsEnum))
                .Distinct()
                .Select(t => new object[] { t });

        [Theory]
        [MemberData(nameof(ModelTypes))]
        public void Model_Survives_Serialize_Deserialize_RoundTrip(Type modelType)
        {
            var instance = Activator.CreateInstance(modelType, nonPublic: true);

            var json = JsonSerializer.Serialize(instance, modelType, MangaUpdatesJson.Options);
            var back = JsonSerializer.Deserialize(json, modelType, MangaUpdatesJson.Options);
            var json2 = JsonSerializer.Serialize(back, modelType, MangaUpdatesJson.Options);

            Assert.NotNull(back);
            Assert.Equal(json, json2);
        }

        [Theory]
        [MemberData(nameof(EnumTypes))]
        public void Enum_Members_RoundTrip_Through_EnumMember_Values(Type enumType)
        {
            foreach (var value in Enum.GetValues(enumType))
            {
                var json = JsonSerializer.Serialize(value, enumType, MangaUpdatesJson.Options);
                var back = JsonSerializer.Deserialize(json, enumType, MangaUpdatesJson.Options);
                Assert.Equal(value, back);
            }
        }
    }
}
