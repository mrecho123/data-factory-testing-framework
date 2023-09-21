// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;
using Azure.Core.Expressions.DataFactory;

namespace AzureDataFactory.TestingFramework.Models
{
    public partial class IntegrationRuntimeCustomSetupScriptProperties : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Optional.IsDefined(BlobContainerUri))
            {
                writer.WritePropertyName("blobContainerUri"u8);
                writer.WriteStringValue(BlobContainerUri.AbsoluteUri);
            }
            if (Optional.IsDefined(SasToken))
            {
                writer.WritePropertyName("sasToken"u8);
                JsonSerializer.Serialize(writer, SasToken);
            }
            writer.WriteEndObject();
        }

        internal static IntegrationRuntimeCustomSetupScriptProperties DeserializeIntegrationRuntimeCustomSetupScriptProperties(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<Uri> blobContainerUri = default;
            Optional<DataFactorySecretString> sasToken = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("blobContainerUri"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    blobContainerUri = new Uri(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("sasToken"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    sasToken = JsonSerializer.Deserialize<DataFactorySecretString>(property.Value.GetRawText());
                    continue;
                }
            }
            return new IntegrationRuntimeCustomSetupScriptProperties(blobContainerUri.Value, sasToken);
        }
    }
}
