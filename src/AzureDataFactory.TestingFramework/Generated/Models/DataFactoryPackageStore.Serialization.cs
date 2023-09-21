// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace AzureDataFactory.TestingFramework.Models
{
    public partial class DataFactoryPackageStore : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            writer.WritePropertyName("name"u8);
            writer.WriteStringValue(Name);
            writer.WritePropertyName("packageStoreLinkedService"u8);
            writer.WriteObjectValue(PackageStoreLinkedService);
            writer.WriteEndObject();
        }

        internal static DataFactoryPackageStore DeserializeDataFactoryPackageStore(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            string name = default;
            EntityReference packageStoreLinkedService = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("name"u8))
                {
                    name = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("packageStoreLinkedService"u8))
                {
                    packageStoreLinkedService = EntityReference.DeserializeEntityReference(property.Value);
                    continue;
                }
            }
            return new DataFactoryPackageStore(name, packageStoreLinkedService);
        }
    }
}
