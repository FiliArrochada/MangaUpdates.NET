using System;
using System.Collections.Generic;
using System.Reflection;
using System.Runtime.Serialization;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace MangaUpdates.Client
{
    /// <summary>
    /// A <see cref="JsonConverterFactory"/> that serializes enums as strings using the value
    /// declared in each member's <see cref="EnumMemberAttribute"/> (falling back to the member name).
    /// Replaces the Newtonsoft <c>StringEnumConverter</c> the generated models used, and honours
    /// values such as "N/A" that are not valid C# identifiers.
    /// </summary>
    public sealed class JsonStringEnumMemberConverter : JsonConverterFactory
    {
        /// <inheritdoc />
        public override bool CanConvert(Type typeToConvert)
        {
            var t = Nullable.GetUnderlyingType(typeToConvert) ?? typeToConvert;
            return t.IsEnum;
        }

        /// <inheritdoc />
        public override JsonConverter CreateConverter(Type typeToConvert, JsonSerializerOptions options)
        {
            var underlying = Nullable.GetUnderlyingType(typeToConvert);
            if (underlying != null)
            {
                var nullableConverterType = typeof(NullableEnumMemberConverter<>).MakeGenericType(underlying);
                return (JsonConverter)Activator.CreateInstance(nullableConverterType)!;
            }

            var converterType = typeof(EnumMemberConverter<>).MakeGenericType(typeToConvert);
            return (JsonConverter)Activator.CreateInstance(converterType)!;
        }

        private sealed class EnumMemberConverter<T> : JsonConverter<T> where T : struct, Enum
        {
            private static readonly Dictionary<string, T> ReadMap = new(StringComparer.OrdinalIgnoreCase);
            private static readonly Dictionary<T, string> WriteMap = new();

            static EnumMemberConverter()
            {
                foreach (var field in typeof(T).GetFields(BindingFlags.Public | BindingFlags.Static))
                {
                    var value = (T)field.GetValue(null)!;
                    var name = field.GetCustomAttribute<EnumMemberAttribute>()?.Value ?? field.Name;
                    WriteMap[value] = name;
                    ReadMap[name] = value;
                }
            }

            public override T Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
            {
                var s = reader.GetString();
                if (s != null && ReadMap.TryGetValue(s, out var mapped))
                {
                    return mapped;
                }

                if (s != null && Enum.TryParse<T>(s, ignoreCase: true, out var parsed))
                {
                    return parsed;
                }

                throw new JsonException($"Unable to convert \"{s}\" to enum {typeof(T)}.");
            }

            public override void Write(Utf8JsonWriter writer, T value, JsonSerializerOptions options)
            {
                if (WriteMap.TryGetValue(value, out var name))
                {
                    writer.WriteStringValue(name);
                }
                else
                {
                    writer.WriteStringValue(value.ToString());
                }
            }
        }

        private sealed class NullableEnumMemberConverter<T> : JsonConverter<T?> where T : struct, Enum
        {
            private readonly EnumMemberConverter<T> _inner = new();

            public override T? Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
            {
                if (reader.TokenType == JsonTokenType.Null)
                {
                    return null;
                }

                return _inner.Read(ref reader, typeof(T), options);
            }

            public override void Write(Utf8JsonWriter writer, T? value, JsonSerializerOptions options)
            {
                if (value.HasValue)
                {
                    _inner.Write(writer, value.Value, options);
                }
                else
                {
                    writer.WriteNullValue();
                }
            }
        }
    }
}
