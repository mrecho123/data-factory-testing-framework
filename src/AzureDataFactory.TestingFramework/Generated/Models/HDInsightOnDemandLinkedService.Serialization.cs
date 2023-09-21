// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;
using Azure.Core.Expressions.DataFactory;

namespace AzureDataFactory.TestingFramework.Models
{
    public partial class HDInsightOnDemandLinkedService : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            writer.WritePropertyName("type"u8);
            writer.WriteStringValue(LinkedServiceType);
            if (Optional.IsDefined(ConnectVia))
            {
                writer.WritePropertyName("connectVia"u8);
                writer.WriteObjectValue(ConnectVia);
            }
            if (Optional.IsDefined(Description))
            {
                writer.WritePropertyName("description"u8);
                writer.WriteStringValue(Description);
            }
            if (Optional.IsCollectionDefined(Parameters))
            {
                writer.WritePropertyName("parameters"u8);
                writer.WriteStartObject();
                foreach (var item in Parameters)
                {
                    writer.WritePropertyName(item.Key);
                    writer.WriteObjectValue(item.Value);
                }
                writer.WriteEndObject();
            }
            if (Optional.IsCollectionDefined(Annotations))
            {
                writer.WritePropertyName("annotations"u8);
                writer.WriteStartArray();
                foreach (var item in Annotations)
                {
                    if (item == null)
                    {
                        writer.WriteNullValue();
                        continue;
                    }
#if NET6_0_OR_GREATER
				writer.WriteRawValue(item);
#else
                    JsonSerializer.Serialize(writer, JsonDocument.Parse(item.ToString()).RootElement);
#endif
                }
                writer.WriteEndArray();
            }
            writer.WritePropertyName("typeProperties"u8);
            writer.WriteStartObject();
            writer.WritePropertyName("clusterSize"u8);
            JsonSerializer.Serialize(writer, ClusterSize);
            writer.WritePropertyName("timeToLive"u8);
            JsonSerializer.Serialize(writer, TimeToLiveExpression);
            writer.WritePropertyName("version"u8);
            JsonSerializer.Serialize(writer, Version);
            writer.WritePropertyName("linkedServiceName"u8);
            JsonSerializer.Serialize(writer, LinkedServiceName); writer.WritePropertyName("hostSubscriptionId"u8);
            JsonSerializer.Serialize(writer, HostSubscriptionId);
            if (Optional.IsDefined(ServicePrincipalId))
            {
                writer.WritePropertyName("servicePrincipalId"u8);
                JsonSerializer.Serialize(writer, ServicePrincipalId);
            }
            if (Optional.IsDefined(ServicePrincipalKey))
            {
                writer.WritePropertyName("servicePrincipalKey"u8);
                JsonSerializer.Serialize(writer, ServicePrincipalKey);
            }
            writer.WritePropertyName("tenant"u8);
            JsonSerializer.Serialize(writer, Tenant);
            writer.WritePropertyName("clusterResourceGroup"u8);
            JsonSerializer.Serialize(writer, ClusterResourceGroup);
            if (Optional.IsDefined(ClusterNamePrefix))
            {
                writer.WritePropertyName("clusterNamePrefix"u8);
                JsonSerializer.Serialize(writer, ClusterNamePrefix);
            }
            if (Optional.IsDefined(ClusterUserName))
            {
                writer.WritePropertyName("clusterUserName"u8);
                JsonSerializer.Serialize(writer, ClusterUserName);
            }
            if (Optional.IsDefined(ClusterPassword))
            {
                writer.WritePropertyName("clusterPassword"u8);
                JsonSerializer.Serialize(writer, ClusterPassword);
            }
            if (Optional.IsDefined(ClusterSshUserName))
            {
                writer.WritePropertyName("clusterSshUserName"u8);
                JsonSerializer.Serialize(writer, ClusterSshUserName);
            }
            if (Optional.IsDefined(ClusterSshPassword))
            {
                writer.WritePropertyName("clusterSshPassword"u8);
                JsonSerializer.Serialize(writer, ClusterSshPassword);
            }
            if (Optional.IsCollectionDefined(AdditionalLinkedServiceNames))
            {
                writer.WritePropertyName("additionalLinkedServiceNames"u8);
                writer.WriteStartArray();
                foreach (var item in AdditionalLinkedServiceNames)
                {
                    JsonSerializer.Serialize(writer, item);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsDefined(HcatalogLinkedServiceName))
            {
                writer.WritePropertyName("hcatalogLinkedServiceName"u8);
                JsonSerializer.Serialize(writer, HcatalogLinkedServiceName);
            }
            if (Optional.IsDefined(ClusterType))
            {
                writer.WritePropertyName("clusterType"u8);
                JsonSerializer.Serialize(writer, ClusterType);
            }
            if (Optional.IsDefined(SparkVersion))
            {
                writer.WritePropertyName("sparkVersion"u8);
                JsonSerializer.Serialize(writer, SparkVersion);
            }
            if (Optional.IsDefined(CoreConfiguration))
            {
                writer.WritePropertyName("coreConfiguration"u8);
#if NET6_0_OR_GREATER
				writer.WriteRawValue(CoreConfiguration);
#else
                JsonSerializer.Serialize(writer, JsonDocument.Parse(CoreConfiguration.ToString()).RootElement);
#endif
            }
            if (Optional.IsDefined(HBaseConfiguration))
            {
                writer.WritePropertyName("hBaseConfiguration"u8);
#if NET6_0_OR_GREATER
				writer.WriteRawValue(HBaseConfiguration);
#else
                JsonSerializer.Serialize(writer, JsonDocument.Parse(HBaseConfiguration.ToString()).RootElement);
#endif
            }
            if (Optional.IsDefined(HdfsConfiguration))
            {
                writer.WritePropertyName("hdfsConfiguration"u8);
#if NET6_0_OR_GREATER
				writer.WriteRawValue(HdfsConfiguration);
#else
                JsonSerializer.Serialize(writer, JsonDocument.Parse(HdfsConfiguration.ToString()).RootElement);
#endif
            }
            if (Optional.IsDefined(HiveConfiguration))
            {
                writer.WritePropertyName("hiveConfiguration"u8);
#if NET6_0_OR_GREATER
				writer.WriteRawValue(HiveConfiguration);
#else
                JsonSerializer.Serialize(writer, JsonDocument.Parse(HiveConfiguration.ToString()).RootElement);
#endif
            }
            if (Optional.IsDefined(MapReduceConfiguration))
            {
                writer.WritePropertyName("mapReduceConfiguration"u8);
#if NET6_0_OR_GREATER
				writer.WriteRawValue(MapReduceConfiguration);
#else
                JsonSerializer.Serialize(writer, JsonDocument.Parse(MapReduceConfiguration.ToString()).RootElement);
#endif
            }
            if (Optional.IsDefined(OozieConfiguration))
            {
                writer.WritePropertyName("oozieConfiguration"u8);
#if NET6_0_OR_GREATER
				writer.WriteRawValue(OozieConfiguration);
#else
                JsonSerializer.Serialize(writer, JsonDocument.Parse(OozieConfiguration.ToString()).RootElement);
#endif
            }
            if (Optional.IsDefined(StormConfiguration))
            {
                writer.WritePropertyName("stormConfiguration"u8);
#if NET6_0_OR_GREATER
				writer.WriteRawValue(StormConfiguration);
#else
                JsonSerializer.Serialize(writer, JsonDocument.Parse(StormConfiguration.ToString()).RootElement);
#endif
            }
            if (Optional.IsDefined(YarnConfiguration))
            {
                writer.WritePropertyName("yarnConfiguration"u8);
#if NET6_0_OR_GREATER
				writer.WriteRawValue(YarnConfiguration);
#else
                JsonSerializer.Serialize(writer, JsonDocument.Parse(YarnConfiguration.ToString()).RootElement);
#endif
            }
            if (Optional.IsDefined(EncryptedCredential))
            {
                writer.WritePropertyName("encryptedCredential"u8);
                writer.WriteStringValue(EncryptedCredential);
            }
            if (Optional.IsDefined(HeadNodeSize))
            {
                writer.WritePropertyName("headNodeSize"u8);
#if NET6_0_OR_GREATER
				writer.WriteRawValue(HeadNodeSize);
#else
                JsonSerializer.Serialize(writer, JsonDocument.Parse(HeadNodeSize.ToString()).RootElement);
#endif
            }
            if (Optional.IsDefined(DataNodeSize))
            {
                writer.WritePropertyName("dataNodeSize"u8);
#if NET6_0_OR_GREATER
				writer.WriteRawValue(DataNodeSize);
#else
                JsonSerializer.Serialize(writer, JsonDocument.Parse(DataNodeSize.ToString()).RootElement);
#endif
            }
            if (Optional.IsDefined(ZookeeperNodeSize))
            {
                writer.WritePropertyName("zookeeperNodeSize"u8);
#if NET6_0_OR_GREATER
				writer.WriteRawValue(ZookeeperNodeSize);
#else
                JsonSerializer.Serialize(writer, JsonDocument.Parse(ZookeeperNodeSize.ToString()).RootElement);
#endif
            }
            if (Optional.IsCollectionDefined(ScriptActions))
            {
                writer.WritePropertyName("scriptActions"u8);
                writer.WriteStartArray();
                foreach (var item in ScriptActions)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsDefined(VirtualNetworkId))
            {
                writer.WritePropertyName("virtualNetworkId"u8);
                JsonSerializer.Serialize(writer, VirtualNetworkId);
            }
            if (Optional.IsDefined(SubnetName))
            {
                writer.WritePropertyName("subnetName"u8);
                JsonSerializer.Serialize(writer, SubnetName);
            }
            if (Optional.IsDefined(Credential))
            {
                writer.WritePropertyName("credential"u8);
                writer.WriteObjectValue(Credential);
            }
            writer.WriteEndObject();
            foreach (var item in AdditionalProperties)
            {
                writer.WritePropertyName(item.Key);
#if NET6_0_OR_GREATER
				writer.WriteRawValue(item.Value);
#else
                JsonSerializer.Serialize(writer, JsonDocument.Parse(item.Value.ToString()).RootElement);
#endif
            }
            writer.WriteEndObject();
        }

        internal static HDInsightOnDemandLinkedService DeserializeHDInsightOnDemandLinkedService(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            string type = default;
            Optional<IntegrationRuntimeReference> connectVia = default;
            Optional<string> description = default;
            Optional<IDictionary<string, EntityParameterSpecification>> parameters = default;
            Optional<IList<BinaryData>> annotations = default;
            DataFactoryElement<string> clusterSize = default;
            DataFactoryElement<string> timeToLive = default;
            DataFactoryElement<string> version = default;
            DataFactoryLinkedServiceReference linkedServiceName = default;
            DataFactoryElement<string> hostSubscriptionId = default;
            Optional<DataFactoryElement<string>> servicePrincipalId = default;
            Optional<DataFactorySecretBaseDefinition> servicePrincipalKey = default;
            DataFactoryElement<string> tenant = default;
            DataFactoryElement<string> clusterResourceGroup = default;
            Optional<DataFactoryElement<string>> clusterNamePrefix = default;
            Optional<DataFactoryElement<string>> clusterUserName = default;
            Optional<DataFactorySecretBaseDefinition> clusterPassword = default;
            Optional<DataFactoryElement<string>> clusterSshUserName = default;
            Optional<DataFactorySecretBaseDefinition> clusterSshPassword = default;
            Optional<IList<DataFactoryLinkedServiceReference>> additionalLinkedServiceNames = default;
            Optional<DataFactoryLinkedServiceReference> hcatalogLinkedServiceName = default;
            Optional<DataFactoryElement<string>> clusterType = default;
            Optional<DataFactoryElement<string>> sparkVersion = default;
            Optional<BinaryData> coreConfiguration = default;
            Optional<BinaryData> hBaseConfiguration = default;
            Optional<BinaryData> hdfsConfiguration = default;
            Optional<BinaryData> hiveConfiguration = default;
            Optional<BinaryData> mapReduceConfiguration = default;
            Optional<BinaryData> oozieConfiguration = default;
            Optional<BinaryData> stormConfiguration = default;
            Optional<BinaryData> yarnConfiguration = default;
            Optional<string> encryptedCredential = default;
            Optional<BinaryData> headNodeSize = default;
            Optional<BinaryData> dataNodeSize = default;
            Optional<BinaryData> zookeeperNodeSize = default;
            Optional<IList<DataFactoryScriptAction>> scriptActions = default;
            Optional<DataFactoryElement<string>> virtualNetworkId = default;
            Optional<DataFactoryElement<string>> subnetName = default;
            Optional<DataFactoryCredentialReference> credential = default;
            IDictionary<string, DataFactoryElement<string>> additionalProperties = default;
            Dictionary<string, DataFactoryElement<string>> additionalPropertiesDictionary = new Dictionary<string, DataFactoryElement<string>>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("type"u8))
                {
                    type = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("connectVia"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    connectVia = IntegrationRuntimeReference.DeserializeIntegrationRuntimeReference(property.Value);
                    continue;
                }
                if (property.NameEquals("description"u8))
                {
                    description = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("parameters"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    Dictionary<string, EntityParameterSpecification> dictionary = new Dictionary<string, EntityParameterSpecification>();
                    foreach (var property0 in property.Value.EnumerateObject())
                    {
                        dictionary.Add(property0.Name, EntityParameterSpecification.DeserializeEntityParameterSpecification(property0.Value));
                    }
                    parameters = dictionary;
                    continue;
                }
                if (property.NameEquals("annotations"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<BinaryData> array = new List<BinaryData>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        if (item.ValueKind == JsonValueKind.Null)
                        {
                            array.Add(null);
                        }
                        else
                        {
                            array.Add(BinaryData.FromString(item.GetRawText()));
                        }
                    }
                    annotations = array;
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
                        if (property0.NameEquals("clusterSize"u8))
                        {
                            clusterSize = JsonSerializer.Deserialize<DataFactoryElement<string>>(property0.Value.GetRawText());
                            continue;
                        }
                        if (property0.NameEquals("timeToLive"u8))
                        {
                            timeToLive = JsonSerializer.Deserialize<DataFactoryElement<string>>(property0.Value.GetRawText());
                            continue;
                        }
                        if (property0.NameEquals("version"u8))
                        {
                            version = JsonSerializer.Deserialize<DataFactoryElement<string>>(property0.Value.GetRawText());
                            continue;
                        }
                        if (property0.NameEquals("linkedServiceName"u8))
                        {
                            linkedServiceName = JsonSerializer.Deserialize<DataFactoryLinkedServiceReference>(property0.Value.GetRawText());
                            continue;
                        }
                        if (property0.NameEquals("hostSubscriptionId"u8))
                        {
                            hostSubscriptionId = JsonSerializer.Deserialize<DataFactoryElement<string>>(property0.Value.GetRawText());
                            continue;
                        }
                        if (property0.NameEquals("servicePrincipalId"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            servicePrincipalId = JsonSerializer.Deserialize<DataFactoryElement<string>>(property0.Value.GetRawText());
                            continue;
                        }
                        if (property0.NameEquals("servicePrincipalKey"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            servicePrincipalKey = JsonSerializer.Deserialize<DataFactorySecretBaseDefinition>(property0.Value.GetRawText());
                            continue;
                        }
                        if (property0.NameEquals("tenant"u8))
                        {
                            tenant = JsonSerializer.Deserialize<DataFactoryElement<string>>(property0.Value.GetRawText());
                            continue;
                        }
                        if (property0.NameEquals("clusterResourceGroup"u8))
                        {
                            clusterResourceGroup = JsonSerializer.Deserialize<DataFactoryElement<string>>(property0.Value.GetRawText());
                            continue;
                        }
                        if (property0.NameEquals("clusterNamePrefix"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            clusterNamePrefix = JsonSerializer.Deserialize<DataFactoryElement<string>>(property0.Value.GetRawText());
                            continue;
                        }
                        if (property0.NameEquals("clusterUserName"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            clusterUserName = JsonSerializer.Deserialize<DataFactoryElement<string>>(property0.Value.GetRawText());
                            continue;
                        }
                        if (property0.NameEquals("clusterPassword"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            clusterPassword = JsonSerializer.Deserialize<DataFactorySecretBaseDefinition>(property0.Value.GetRawText());
                            continue;
                        }
                        if (property0.NameEquals("clusterSshUserName"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            clusterSshUserName = JsonSerializer.Deserialize<DataFactoryElement<string>>(property0.Value.GetRawText());
                            continue;
                        }
                        if (property0.NameEquals("clusterSshPassword"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            clusterSshPassword = JsonSerializer.Deserialize<DataFactorySecretBaseDefinition>(property0.Value.GetRawText());
                            continue;
                        }
                        if (property0.NameEquals("additionalLinkedServiceNames"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            List<DataFactoryLinkedServiceReference> array = new List<DataFactoryLinkedServiceReference>();
                            foreach (var item in property0.Value.EnumerateArray())
                            {
                                array.Add(JsonSerializer.Deserialize<DataFactoryLinkedServiceReference>(item.GetRawText()));
                            }
                            additionalLinkedServiceNames = array;
                            continue;
                        }
                        if (property0.NameEquals("hcatalogLinkedServiceName"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            hcatalogLinkedServiceName = JsonSerializer.Deserialize<DataFactoryLinkedServiceReference>(property0.Value.GetRawText());
                            continue;
                        }
                        if (property0.NameEquals("clusterType"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            clusterType = JsonSerializer.Deserialize<DataFactoryElement<string>>(property0.Value.GetRawText());
                            continue;
                        }
                        if (property0.NameEquals("sparkVersion"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            sparkVersion = JsonSerializer.Deserialize<DataFactoryElement<string>>(property0.Value.GetRawText());
                            continue;
                        }
                        if (property0.NameEquals("coreConfiguration"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            coreConfiguration = BinaryData.FromString(property0.Value.GetRawText());
                            continue;
                        }
                        if (property0.NameEquals("hBaseConfiguration"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            hBaseConfiguration = BinaryData.FromString(property0.Value.GetRawText());
                            continue;
                        }
                        if (property0.NameEquals("hdfsConfiguration"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            hdfsConfiguration = BinaryData.FromString(property0.Value.GetRawText());
                            continue;
                        }
                        if (property0.NameEquals("hiveConfiguration"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            hiveConfiguration = BinaryData.FromString(property0.Value.GetRawText());
                            continue;
                        }
                        if (property0.NameEquals("mapReduceConfiguration"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            mapReduceConfiguration = BinaryData.FromString(property0.Value.GetRawText());
                            continue;
                        }
                        if (property0.NameEquals("oozieConfiguration"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            oozieConfiguration = BinaryData.FromString(property0.Value.GetRawText());
                            continue;
                        }
                        if (property0.NameEquals("stormConfiguration"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            stormConfiguration = BinaryData.FromString(property0.Value.GetRawText());
                            continue;
                        }
                        if (property0.NameEquals("yarnConfiguration"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            yarnConfiguration = BinaryData.FromString(property0.Value.GetRawText());
                            continue;
                        }
                        if (property0.NameEquals("encryptedCredential"u8))
                        {
                            encryptedCredential = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("headNodeSize"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            headNodeSize = BinaryData.FromString(property0.Value.GetRawText());
                            continue;
                        }
                        if (property0.NameEquals("dataNodeSize"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            dataNodeSize = BinaryData.FromString(property0.Value.GetRawText());
                            continue;
                        }
                        if (property0.NameEquals("zookeeperNodeSize"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            zookeeperNodeSize = BinaryData.FromString(property0.Value.GetRawText());
                            continue;
                        }
                        if (property0.NameEquals("scriptActions"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            List<DataFactoryScriptAction> array = new List<DataFactoryScriptAction>();
                            foreach (var item in property0.Value.EnumerateArray())
                            {
                                array.Add(DataFactoryScriptAction.DeserializeDataFactoryScriptAction(item));
                            }
                            scriptActions = array;
                            continue;
                        }
                        if (property0.NameEquals("virtualNetworkId"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            virtualNetworkId = JsonSerializer.Deserialize<DataFactoryElement<string>>(property0.Value.GetRawText());
                            continue;
                        }
                        if (property0.NameEquals("subnetName"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            subnetName = JsonSerializer.Deserialize<DataFactoryElement<string>>(property0.Value.GetRawText());
                            continue;
                        }
                        if (property0.NameEquals("credential"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            credential = DataFactoryCredentialReference.DeserializeDataFactoryCredentialReference(property0.Value);
                            continue;
                        }
                    }
                    continue;
                }
                additionalPropertiesDictionary.Add(property.Name, JsonSerializer.Deserialize<DataFactoryElement<string>>(property.Value.GetRawText()));
            }
            additionalProperties = additionalPropertiesDictionary;
            return new HDInsightOnDemandLinkedService(type, connectVia.Value, description.Value, Optional.ToDictionary(parameters), Optional.ToList(annotations), additionalProperties, clusterSize, timeToLive, version, linkedServiceName, hostSubscriptionId, servicePrincipalId.Value, servicePrincipalKey, tenant, clusterResourceGroup, clusterNamePrefix.Value, clusterUserName.Value, clusterPassword, clusterSshUserName.Value, clusterSshPassword, Optional.ToList(additionalLinkedServiceNames), hcatalogLinkedServiceName, clusterType.Value, sparkVersion.Value, coreConfiguration.Value, hBaseConfiguration.Value, hdfsConfiguration.Value, hiveConfiguration.Value, mapReduceConfiguration.Value, oozieConfiguration.Value, stormConfiguration.Value, yarnConfiguration.Value, encryptedCredential.Value, headNodeSize.Value, dataNodeSize.Value, zookeeperNodeSize.Value, Optional.ToList(scriptActions), virtualNetworkId.Value, subnetName.Value, credential.Value);
        }
    }
}
