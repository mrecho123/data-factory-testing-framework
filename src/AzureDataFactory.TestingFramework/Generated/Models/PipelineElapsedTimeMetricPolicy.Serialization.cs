// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace AzureDataFactory.TestingFramework.Models
{
    internal partial class PipelineElapsedTimeMetricPolicy : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Optional.IsDefined(Duration))
            {
                writer.WritePropertyName("duration"u8);
#if NET6_0_OR_GREATER
				writer.WriteRawValue(Duration);
#else
                JsonSerializer.Serialize(writer, JsonDocument.Parse(Duration.ToString()).RootElement);
#endif
            }
            writer.WriteEndObject();
        }

        internal static PipelineElapsedTimeMetricPolicy DeserializePipelineElapsedTimeMetricPolicy(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<BinaryData> duration = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("duration"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    duration = BinaryData.FromString(property.Value.GetRawText());
                    continue;
                }
            }
            return new PipelineElapsedTimeMetricPolicy(duration.Value);
        }
    }
}
