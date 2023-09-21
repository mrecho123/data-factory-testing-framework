// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;
using Azure.Core.Expressions.DataFactory;

namespace AzureDataFactory.TestingFramework.Models
{
    public partial class SkipErrorFile : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Optional.IsDefined(FileMissing))
            {
                writer.WritePropertyName("fileMissing"u8);
                JsonSerializer.Serialize(writer, FileMissing);
            }
            if (Optional.IsDefined(DataInconsistency))
            {
                writer.WritePropertyName("dataInconsistency"u8);
                JsonSerializer.Serialize(writer, DataInconsistency);
            }
            writer.WriteEndObject();
        }

        internal static SkipErrorFile DeserializeSkipErrorFile(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<DataFactoryElement<bool>> fileMissing = default;
            Optional<DataFactoryElement<bool>> dataInconsistency = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("fileMissing"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    fileMissing = JsonSerializer.Deserialize<DataFactoryElement<bool>>(property.Value.GetRawText());
                    continue;
                }
                if (property.NameEquals("dataInconsistency"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    dataInconsistency = JsonSerializer.Deserialize<DataFactoryElement<bool>>(property.Value.GetRawText());
                    continue;
                }
            }
            return new SkipErrorFile(fileMissing.Value, dataInconsistency.Value);
        }
    }
}
