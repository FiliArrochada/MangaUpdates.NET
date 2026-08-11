/*
 * Fixture tests: deserialization of a realistic Member (user profile) payload shaped
 * after the api/openapi-1.0.0.yaml schema (UserModelV1). The spec publishes no example
 * values, so the payload is hand-built from the schema. Notably exercises the "N/A"
 * gender wire value — an [EnumMember] value that is not a valid C# identifier, which is
 * exactly why the custom JsonStringEnumMemberConverter exists.
 */

using System.Text.Json;
using MangaUpdates.Client;
using MangaUpdates.Model;
using Xunit;

namespace MangaUpdates.Test.Fixtures
{
    public class MembersFixtureTests
    {
        private const string MemberJson = """
        {
          "user_id": 12345,
          "username": "mangareader42",
          "url": "https://www.mangaupdates.com/member/abc123/mangareader42",
          "avatar": {
            "id": 77,
            "url": "https://cdn.mangaupdates.com/avatar/a77.png",
            "title": "Guts",
            "extension": "png",
            "height": 100,
            "width": 100
          },
          "time_joined": {
            "timestamp": 1420070400,
            "as_rfc3339": "2015-01-01T00:00:00+00:00",
            "as_string": "January 1st, 2015"
          },
          "gender": "N/A",
          "age": 30,
          "timezone": -5,
          "forum_title": "Regular",
          "folding_at_home": false,
          "stats": {
            "forum_posts": 250,
            "added_releases": 12,
            "added_series": 3
          },
          "user_group": "members",
          "user_group_name": "Members"
        }
        """;

        [Fact]
        public void UserModelV1_Deserializes_Full_Payload()
        {
            var member = JsonSerializer.Deserialize<UserModelV1>(MemberJson, MangaUpdatesJson.Options);

            Assert.NotNull(member);
            Assert.Equal(12345, member.UserId);
            Assert.Equal("mangareader42", member.Username);
            // "N/A" is not a valid C# identifier — parsed via [EnumMember] by the custom converter
            Assert.Equal(UserModelV1.GenderEnum.NA, member.Gender);
            Assert.Equal(30, member.Age);
            Assert.Equal(-5, member.Timezone);
            Assert.False(member.FoldingAtHome);

            // nested avatar
            Assert.Equal(77, member.Avatar.Id);
            Assert.Equal("https://cdn.mangaupdates.com/avatar/a77.png", member.Avatar.Url);

            // TimeV1
            Assert.Equal(1420070400, member.TimeJoined.Timestamp);
            Assert.Equal(2015, member.TimeJoined.AsRfc3339.Year);

            // nested stats
            Assert.Equal(250, member.Stats.ForumPosts);
            Assert.Equal(12, member.Stats.AddedReleases);
            Assert.Equal(3, member.Stats.AddedSeries);
        }
    }
}
