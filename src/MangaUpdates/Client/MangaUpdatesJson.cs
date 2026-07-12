using System.Text.Json;
using System.Text.Json.Serialization;

namespace MangaUpdates.Client
{
    /// <summary>
    /// Shared <see cref="JsonSerializerOptions"/> used by the Refit clients. Property names are
    /// declared explicitly on the models via <see cref="JsonPropertyNameAttribute"/>, so only the
    /// enum handling and case-insensitive reads need to be configured here.
    /// </summary>
    public static class MangaUpdatesJson
    {
        /// <summary>
        /// The serializer options used for all requests and responses.
        /// </summary>
        public static JsonSerializerOptions Options { get; } = Create();

        private static JsonSerializerOptions Create()
        {
            var options = new JsonSerializerOptions
            {
                PropertyNameCaseInsensitive = true,
                DefaultIgnoreCondition = JsonIgnoreCondition.WhenWritingNull,
            };
            options.Converters.Add(new JsonStringEnumMemberConverter());
            return options;
        }
    }
}
