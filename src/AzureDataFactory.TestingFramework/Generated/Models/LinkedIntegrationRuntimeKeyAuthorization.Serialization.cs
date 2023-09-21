// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;
using Azure.Core.Expressions.DataFactory;

namespace AzureDataFactory.TestingFramework.Models
{
    public partial class LinkedIntegrationRuntimeKeyAuthorization : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            writer.WritePropertyName("key"u8);
            JsonSerializer.Serialize(writer, Key); writer.WritePropertyName("authorizationType"u8);
            writer.WriteStringValue(AuthorizationType);
            writer.WriteEndObject();
        }

        internal static LinkedIntegrationRuntimeKeyAuthorization DeserializeLinkedIntegrationRuntimeKeyAuthorization(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            DataFactorySecretString key = default;
            string authorizationType = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("key"u8))
                {
                    key = JsonSerializer.Deserialize<DataFactorySecretString>(property.Value.GetRawText());
                    continue;
                }
                if (property.NameEquals("authorizationType"u8))
                {
                    authorizationType = property.Value.GetString();
                    continue;
                }
            }
            return new LinkedIntegrationRuntimeKeyAuthorization(authorizationType, key);
        }
    }
}
