// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;
using Azure.Core.Expressions.DataFactory;

namespace AzureDataFactory.TestingFramework.Models
{
    public partial class SelfHostedIntegrationRuntimeStatus
    {
        internal static SelfHostedIntegrationRuntimeStatus DeserializeSelfHostedIntegrationRuntimeStatus(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            IntegrationRuntimeType type = default;
            Optional<string> dataFactoryName = default;
            Optional<IntegrationRuntimeState> state = default;
            Optional<DateTimeOffset> createTime = default;
            Optional<Guid> taskQueueId = default;
            Optional<IntegrationRuntimeInternalChannelEncryptionMode> internalChannelEncryption = default;
            Optional<string> version = default;
            Optional<IReadOnlyList<SelfHostedIntegrationRuntimeNode>> nodes = default;
            Optional<DateTimeOffset> scheduledUpdateDate = default;
            Optional<TimeSpan> updateDelayOffset = default;
            Optional<TimeSpan> localTimeZoneOffset = default;
            Optional<IReadOnlyDictionary<string, string>> capabilities = default;
            Optional<IReadOnlyList<Uri>> serviceUrls = default;
            Optional<IntegrationRuntimeAutoUpdateState> autoUpdate = default;
            Optional<string> versionStatus = default;
            Optional<IReadOnlyList<LinkedIntegrationRuntime>> links = default;
            Optional<string> pushedVersion = default;
            Optional<string> latestVersion = default;
            Optional<DateTimeOffset> autoUpdateEta = default;
            IReadOnlyDictionary<string, DataFactoryElement<string>> additionalProperties = default;
            Dictionary<string, DataFactoryElement<string>> additionalPropertiesDictionary = new Dictionary<string, DataFactoryElement<string>>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("type"u8))
                {
                    type = new IntegrationRuntimeType(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("dataFactoryName"u8))
                {
                    dataFactoryName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("state"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    state = new IntegrationRuntimeState(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("typeProperties"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    foreach (var property0 in property.Value.EnumerateObject())
                    {
                        if (property0.NameEquals("createTime"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            createTime = property0.Value.GetDateTimeOffset("O");
                            continue;
                        }
                        if (property0.NameEquals("taskQueueId"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            taskQueueId = property0.Value.GetGuid();
                            continue;
                        }
                        if (property0.NameEquals("internalChannelEncryption"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            internalChannelEncryption = new IntegrationRuntimeInternalChannelEncryptionMode(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("version"u8))
                        {
                            version = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("nodes"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            List<SelfHostedIntegrationRuntimeNode> array = new List<SelfHostedIntegrationRuntimeNode>();
                            foreach (var item in property0.Value.EnumerateArray())
                            {
                                array.Add(SelfHostedIntegrationRuntimeNode.DeserializeSelfHostedIntegrationRuntimeNode(item));
                            }
                            nodes = array;
                            continue;
                        }
                        if (property0.NameEquals("scheduledUpdateDate"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            scheduledUpdateDate = property0.Value.GetDateTimeOffset("O");
                            continue;
                        }
                        if (property0.NameEquals("updateDelayOffset"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            updateDelayOffset = property0.Value.GetTimeSpan("P");
                            continue;
                        }
                        if (property0.NameEquals("localTimeZoneOffset"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            localTimeZoneOffset = property0.Value.GetTimeSpan("P");
                            continue;
                        }
                        if (property0.NameEquals("capabilities"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            Dictionary<string, string> dictionary = new Dictionary<string, string>();
                            foreach (var property1 in property0.Value.EnumerateObject())
                            {
                                dictionary.Add(property1.Name, property1.Value.GetString());
                            }
                            capabilities = dictionary;
                            continue;
                        }
                        if (property0.NameEquals("serviceUrls"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            List<Uri> array = new List<Uri>();
                            foreach (var item in property0.Value.EnumerateArray())
                            {
                                if (item.ValueKind == JsonValueKind.Null)
                                {
                                    array.Add(null);
                                }
                                else
                                {
                                    array.Add(new Uri(item.GetString()));
                                }
                            }
                            serviceUrls = array;
                            continue;
                        }
                        if (property0.NameEquals("autoUpdate"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            autoUpdate = new IntegrationRuntimeAutoUpdateState(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("versionStatus"u8))
                        {
                            versionStatus = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("links"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            List<LinkedIntegrationRuntime> array = new List<LinkedIntegrationRuntime>();
                            foreach (var item in property0.Value.EnumerateArray())
                            {
                                array.Add(LinkedIntegrationRuntime.DeserializeLinkedIntegrationRuntime(item));
                            }
                            links = array;
                            continue;
                        }
                        if (property0.NameEquals("pushedVersion"u8))
                        {
                            pushedVersion = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("latestVersion"u8))
                        {
                            latestVersion = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("autoUpdateETA"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            autoUpdateEta = property0.Value.GetDateTimeOffset("O");
                            continue;
                        }
                    }
                    continue;
                }
                additionalPropertiesDictionary.Add(property.Name, JsonSerializer.Deserialize<DataFactoryElement<string>>(property.Value.GetRawText()));
            }
            additionalProperties = additionalPropertiesDictionary;
            return new SelfHostedIntegrationRuntimeStatus(type, dataFactoryName.Value, Optional.ToNullable(state), additionalProperties, Optional.ToNullable(createTime), Optional.ToNullable(taskQueueId), Optional.ToNullable(internalChannelEncryption), version.Value, Optional.ToList(nodes), Optional.ToNullable(scheduledUpdateDate), Optional.ToNullable(updateDelayOffset), Optional.ToNullable(localTimeZoneOffset), Optional.ToDictionary(capabilities), Optional.ToList(serviceUrls), Optional.ToNullable(autoUpdate), versionStatus.Value, Optional.ToList(links), pushedVersion.Value, latestVersion.Value, Optional.ToNullable(autoUpdateEta));
        }
    }
}
