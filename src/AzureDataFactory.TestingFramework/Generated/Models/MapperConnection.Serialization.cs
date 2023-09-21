// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;
using Azure.Core.Expressions.DataFactory;

namespace AzureDataFactory.TestingFramework.Models
{
    public partial class MapperConnection : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Optional.IsDefined(LinkedService))
            {
                writer.WritePropertyName("linkedService"u8);
                JsonSerializer.Serialize(writer, LinkedService);
            }
            if (Optional.IsDefined(LinkedServiceType))
            {
                writer.WritePropertyName("linkedServiceType"u8);
                writer.WriteStringValue(LinkedServiceType);
            }
            writer.WritePropertyName("type"u8);
            writer.WriteStringValue(ConnectionType.ToString());
            if (Optional.IsDefined(IsInlineDataset))
            {
                writer.WritePropertyName("isInlineDataset"u8);
                writer.WriteBooleanValue(IsInlineDataset.Value);
            }
            if (Optional.IsCollectionDefined(CommonDslConnectorProperties))
            {
                writer.WritePropertyName("commonDslConnectorProperties"u8);
                writer.WriteStartArray();
                foreach (var item in CommonDslConnectorProperties)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            writer.WriteEndObject();
        }

        internal static MapperConnection DeserializeMapperConnection(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<DataFactoryLinkedServiceReference> linkedService = default;
            Optional<string> linkedServiceType = default;
            MapperConnectionType type = default;
            Optional<bool> isInlineDataset = default;
            Optional<IList<MapperDslConnectorProperties>> commonDslConnectorProperties = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("linkedService"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    linkedService = JsonSerializer.Deserialize<DataFactoryLinkedServiceReference>(property.Value.GetRawText());
                    continue;
                }
                if (property.NameEquals("linkedServiceType"u8))
                {
                    linkedServiceType = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("type"u8))
                {
                    type = new MapperConnectionType(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("isInlineDataset"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    isInlineDataset = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("commonDslConnectorProperties"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<MapperDslConnectorProperties> array = new List<MapperDslConnectorProperties>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(MapperDslConnectorProperties.DeserializeMapperDslConnectorProperties(item));
                    }
                    commonDslConnectorProperties = array;
                    continue;
                }
            }
            return new MapperConnection(linkedService, linkedServiceType.Value, type, Optional.ToNullable(isInlineDataset), Optional.ToList(commonDslConnectorProperties));
        }
    }
}
