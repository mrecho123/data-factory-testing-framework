// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;
using Azure.ResourceManager.DataFactory;

namespace AzureDataFactory.TestingFramework.Models
{
    internal partial class DataFactoryTriggerListResult
    {
        internal static DataFactoryTriggerListResult DeserializeDataFactoryTriggerListResult(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            IReadOnlyList<DataFactoryTriggerData> value = default;
            Optional<string> nextLink = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("value"u8))
                {
                    List<DataFactoryTriggerData> array = new List<DataFactoryTriggerData>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(DataFactoryTriggerData.DeserializeDataFactoryTriggerData(item));
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
            return new DataFactoryTriggerListResult(value, nextLink.Value);
        }
    }
}
