// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;
using Azure.ResourceManager.DataFactory;

namespace AzureDataFactory.TestingFramework.Models
{
    internal partial class DataFactoryListResult
    {
        internal static DataFactoryListResult DeserializeDataFactoryListResult(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            IReadOnlyList<DataFactoryData> value = default;
            Optional<string> nextLink = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("value"u8))
                {
                    List<DataFactoryData> array = new List<DataFactoryData>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(DataFactoryData.DeserializeDataFactoryData(item));
                    }
                    value = array;
                    continue;
                }
                if (property.NameEquals("nextLink"u8))
                {
                    nextLink = property.Value.GetString();
                    continue;
                }
            }
            return new DataFactoryListResult(value, nextLink.Value);
        }
    }
}
