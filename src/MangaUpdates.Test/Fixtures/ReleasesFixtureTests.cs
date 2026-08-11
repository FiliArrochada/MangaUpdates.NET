/*
 * Fixture tests: deserialization of realistic Release payloads shaped after the
 * api/openapi-1.0.0.yaml schemas (ReleaseModelV1), plus the generic ApiResponseV1
 * status envelope returned by mutation endpoints. The spec publishes no example
 * values, so the payloads are hand-built from the schema.
 */

using System.Text.Json;
using MangaUpdates.Client;
using MangaUpdates.Model;
using Xunit;

namespace MangaUpdates.Test.Fixtures
{
    public class ReleasesFixtureTests
    {
        private const string ReleaseJson = """
        {
          "id": 987654,
          "title": "Berserk",
          "volume": "42",
          "chapter": "375",
          "groups": [
            { "name": "Evil Genius", "group_id": 21 }
          ],
          "release_date": "2023-01-01",
          "comment": "double-length chapter",
          "time_added": {
            "timestamp": 1672560000,
            "as_rfc3339": "2023-01-01T08:00:00+00:00",
            "as_string": "January 1st, 2023"
          }
        }
        """;

        [Fact]
        public void ReleaseModelV1_Deserializes_Full_Payload()
        {
            var release = JsonSerializer.Deserialize<ReleaseModelV1>(ReleaseJson, MangaUpdatesJson.Options);

            Assert.NotNull(release);
            Assert.Equal(987654, release.Id);
            Assert.Equal("Berserk", release.Title);
            Assert.Equal("42", release.Volume);
            Assert.Equal("375", release.Chapter);
            Assert.Equal("2023-01-01", release.ReleaseDate);

            var group = Assert.Single(release.Groups);
            Assert.Equal("Evil Genius", group.Name);
            Assert.Equal(21, group.GroupId);

            Assert.Equal(1672560000, release.TimeAdded.Timestamp);
            Assert.Equal(8, release.TimeAdded.AsRfc3339.Hour);
        }

        [Fact]
        public void ApiResponseV1_Deserializes_Error_Envelope()
        {
            const string errorJson = """
            {
              "status": "failure",
              "reason": "You must be logged in to perform this action",
              "context": { "id": 33 }
            }
            """;

            var response = JsonSerializer.Deserialize<ApiResponseV1>(errorJson, MangaUpdatesJson.Options);

            Assert.NotNull(response);
            Assert.Equal("failure", response.Status);
            Assert.Equal("You must be logged in to perform this action", response.Reason);
            Assert.NotNull(response.Context);
        }
    }
}
