/*
 * Fixture tests: deserialization of realistic Series payloads shaped after the
 * api/openapi-1.0.0.yaml schemas (SeriesModelV1 / SeriesSearchResponseV1). The spec
 * publishes no example values, so the payloads are hand-built from the schema:
 * they exercise the nested objects (image, rank, TimeV1), arrays (genres, authors),
 * enums via [EnumMember] values, and snake_case property mapping.
 */

using System.Linq;
using System.Text.Json;
using MangaUpdates.Client;
using MangaUpdates.Model;
using Xunit;

namespace MangaUpdates.Test.Fixtures
{
    public class SeriesFixtureTests
    {
        private const string SeriesJson = """
        {
          "series_id": 33,
          "title": "Berserk",
          "url": "https://www.mangaupdates.com/series/kvbdxlx/berserk",
          "associated": [ { "title": "Berserk Prototype" } ],
          "description": "His name is Guts, the Black Swordsman.",
          "image": {
            "url": {
              "original": "https://cdn.mangaupdates.com/image/i349938.jpg",
              "thumb": "https://cdn.mangaupdates.com/image/thumb/i349938.jpg"
            },
            "height": 350,
            "width": 231
          },
          "type": "Manga",
          "year": "1989",
          "bayesian_rating": 9.32,
          "rating_votes": 10774,
          "genres": [ { "genre": "Action" }, { "genre": "Fantasy" } ],
          "latest_chapter": 375,
          "forum_id": 33,
          "status": "375/?",
          "licensed": true,
          "completed": false,
          "authors": [
            { "name": "MIURA Kentarou", "author_id": 1, "type": "Author" }
          ],
          "rank": {
            "position": { "week": 12, "month": 15, "year": 30 }
          },
          "last_updated": {
            "timestamp": 1672531200,
            "as_rfc3339": "2023-01-01T00:00:00+00:00",
            "as_string": "January 1st, 2023"
          }
        }
        """;

        [Fact]
        public void SeriesModelV1_Deserializes_Full_Payload()
        {
            var series = JsonSerializer.Deserialize<SeriesModelV1>(SeriesJson, MangaUpdatesJson.Options);

            Assert.NotNull(series);
            Assert.Equal(33, series.SeriesId);
            Assert.Equal("Berserk", series.Title);
            Assert.Equal(SeriesModelV1.TypeEnum.Manga, series.Type);   // enum via [EnumMember] value
            Assert.Equal(9.32m, series.BayesianRating);
            Assert.Equal(10774, series.RatingVotes);
            Assert.True(series.Licensed);
            Assert.False(series.Completed);

            // nested objects
            Assert.Equal("https://cdn.mangaupdates.com/image/i349938.jpg", series.Image.Url.Original);
            Assert.Equal(350, series.Image.Height);

            // arrays
            Assert.Equal(new[] { "Action", "Fantasy" }, series.Genres.Select(g => g.Genre));
            var author = Assert.Single(series.Authors);
            Assert.Equal("MIURA Kentarou", author.Name);
            Assert.Equal(1, author.AuthorId);

            // TimeV1 (timestamp + RFC3339 date + display string)
            Assert.Equal(1672531200, series.LastUpdated.Timestamp);
            Assert.Equal(2023, series.LastUpdated.AsRfc3339.Year);
            Assert.Equal("January 1st, 2023", series.LastUpdated.AsString);
        }

        private const string SearchResponseJson = """
        {
          "total_hits": 2,
          "page": 1,
          "per_page": 25,
          "results": [
            {
              "record": { "series_id": 33, "title": "Berserk", "year": "1989" },
              "hit_title": "Berserk",
              "metadata": { "user_list": null }
            },
            {
              "record": { "series_id": 116929, "title": "Berserk of Gluttony", "year": "2018" },
              "hit_title": "Berserk of Gluttony"
            }
          ]
        }
        """;

        [Fact]
        public void SeriesSearchResponseV1_Deserializes_Paged_Results()
        {
            var response = JsonSerializer.Deserialize<SeriesSearchResponseV1>(SearchResponseJson, MangaUpdatesJson.Options);

            Assert.NotNull(response);
            Assert.Equal(2, response.TotalHits);
            Assert.Equal(1, response.Page);
            Assert.Equal(25, response.PerPage);
            Assert.Equal(2, response.Results.Count);
            Assert.Equal("Berserk", response.Results[0].Record.Title);
            Assert.Equal(116929, response.Results[1].Record.SeriesId);
        }
    }
}
