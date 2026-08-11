/*
 * Fixture tests: deserialization of realistic Lists payloads shaped after the
 * api/openapi-1.0.0.yaml schemas (ListsModelV1 / ListsSeriesModelV1). The spec
 * publishes no example values, so the payloads are hand-built from the schema.
 * Covers a built-in reading list with its options block, and a series-on-a-list
 * entry with reading-position status and TimeV1 time_added.
 */

using System.Text.Json;
using MangaUpdates.Client;
using MangaUpdates.Model;
using Xunit;

namespace MangaUpdates.Test.Fixtures
{
    public class ListsFixtureTests
    {
        private const string ListJson = """
        {
          "list_id": 101,
          "title": "Reading List",
          "description": "Default reading list",
          "type": "read",
          "icon": "fas fa-book-open",
          "custom": false,
          "options": {
            "public": true,
            "show_rating": true,
            "show_status": false,
            "show_per_page": 25,
            "show_latest_chapter": true
          }
        }
        """;

        [Fact]
        public void ListsModelV1_Deserializes_Full_Payload()
        {
            var list = JsonSerializer.Deserialize<ListsModelV1>(ListJson, MangaUpdatesJson.Options);

            Assert.NotNull(list);
            Assert.Equal(101, list.ListId);
            Assert.Equal("Reading List", list.Title);
            Assert.Equal(ListsModelV1.TypeEnum.Read, list.Type);   // enum via [EnumMember] value
            Assert.False(list.Custom);

            // nested options
            Assert.True(list.Options.Public);
            Assert.True(list.Options.ShowRating);
            Assert.False(list.Options.ShowStatus);
            Assert.Equal(25, list.Options.ShowPerPage);
        }

        private const string ListSeriesJson = """
        {
          "series": {
            "id": 33,
            "title": "Berserk"
          },
          "list_id": 101,
          "list_type": "read",
          "list_icon": "fas fa-book-open",
          "status": {
            "volume": 42,
            "chapter": 375
          },
          "priority": 1,
          "time_added": {
            "timestamp": 1672531200,
            "as_rfc3339": "2023-01-01T00:00:00+00:00",
            "as_string": "January 1st, 2023"
          }
        }
        """;

        [Fact]
        public void ListsSeriesModelV1_Deserializes_Full_Payload()
        {
            var entry = JsonSerializer.Deserialize<ListsSeriesModelV1>(ListSeriesJson, MangaUpdatesJson.Options);

            Assert.NotNull(entry);
            Assert.Equal(33, entry.Series.Id);
            Assert.Equal("Berserk", entry.Series.Title);
            Assert.Equal(101, entry.ListId);
            Assert.Equal("read", entry.ListType);
            Assert.Equal(1, entry.Priority);

            // reading position
            Assert.Equal(42, entry.Status.Volume);
            Assert.Equal(375, entry.Status.Chapter);

            // TimeV1
            Assert.Equal(1672531200, entry.TimeAdded.Timestamp);
            Assert.Equal(1, entry.TimeAdded.AsRfc3339.Month);
        }
    }
}
