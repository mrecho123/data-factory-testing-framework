// <auto-generated/>

#nullable disable

using Azure.Core;
using Azure.Core.Expressions.DataFactory;
using AzureDataFactory.TestingFramework.Models;
using Azure.ResourceManager.Models;

namespace Azure.ResourceManager.DataFactory
{
    /// <summary>
    /// A class representing the DataFactory data model.
    /// Factory resource type.
    /// </summary>
    public partial class DataFactoryData : TrackedResourceData
    {
        /// <summary> Initializes a new instance of DataFactoryData. </summary>
        /// <param name="location"> The location. </param>
        public DataFactoryData(AzureLocation location) : base(location)
        {
            GlobalParameters = new ChangeTrackingDictionary<string, DataFactoryGlobalParameterProperties>();
            AdditionalProperties = new ChangeTrackingDictionary<string, DataFactoryElement<string>>();
        }

        /// <summary> Initializes a new instance of DataFactoryData. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="resourceType"> The resourceType. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="tags"> The tags. </param>
        /// <param name="location"> The location. </param>
        /// <param name="identity"> Managed service identity of the factory. Current supported identity types: SystemAssigned, UserAssigned, SystemAssigned,UserAssigned. </param>
        /// <param name="provisioningState"> Factory provisioning state, example Succeeded. </param>
        /// <param name="createdOn"> Time the factory was created in ISO8601 format. </param>
        /// <param name="version"> Version of the factory. </param>
        /// <param name="purviewConfiguration"> Purview information of the factory. </param>
        /// <param name="repoConfiguration">
        /// Git repo information of the factory.
        /// Please note <see cref="FactoryRepoConfiguration"/> is the base class. According to the scenario, a derived class of the base class might need to be assigned here, or this property needs to be casted to one of the possible derived classes.
        /// The available derived classes include <see cref="FactoryGitHubConfiguration"/> and <see cref="FactoryVstsConfiguration"/>.
        /// </param>
        /// <param name="globalParameters"> List of parameters for factory. </param>
        /// <param name="encryption"> Properties to enable Customer Managed Key for the factory. </param>
        /// <param name="publicNetworkAccess"> Whether or not public network access is allowed for the data factory. </param>
        /// <param name="eTag"> Etag identifies change in the resource. </param>
        /// <param name="additionalProperties"> Additional Properties. </param>
        internal DataFactoryData(ResourceIdentifier id, string name, ResourceType resourceType, SystemData systemData, IDictionary<string, string> tags, AzureLocation location, ManagedServiceIdentity identity, string provisioningState, DateTimeOffset? createdOn, string version, DataFactoryPurviewConfiguration purviewConfiguration, FactoryRepoConfiguration repoConfiguration, IDictionary<string, DataFactoryGlobalParameterProperties> globalParameters, DataFactoryEncryptionConfiguration encryption, DataFactoryPublicNetworkAccess? publicNetworkAccess, ETag? eTag, IDictionary<string, DataFactoryElement<string>> additionalProperties) : base(id, name, resourceType, systemData, tags, location)
        {
            Identity = identity;
            ProvisioningState = provisioningState;
            CreatedOn = createdOn;
            Version = version;
            PurviewConfiguration = purviewConfiguration;
            RepoConfiguration = repoConfiguration;
            GlobalParameters = globalParameters;
            Encryption = encryption;
            PublicNetworkAccess = publicNetworkAccess;
            ETag = eTag;
            AdditionalProperties = additionalProperties;
        }

        /// <summary> Managed service identity of the factory. Current supported identity types: SystemAssigned, UserAssigned, SystemAssigned,UserAssigned. </summary>
        public ManagedServiceIdentity Identity { get; set; }
        /// <summary> Factory provisioning state, example Succeeded. </summary>
        public string ProvisioningState { get; }
        /// <summary> Time the factory was created in ISO8601 format. </summary>
        public DateTimeOffset? CreatedOn { get; }
        /// <summary> Version of the factory. </summary>
        public string Version { get; }
        /// <summary> Purview information of the factory. </summary>
        internal DataFactoryPurviewConfiguration PurviewConfiguration { get; set; }
        /// <summary> Purview resource id. </summary>
        public ResourceIdentifier PurviewResourceId
        {
            get => PurviewConfiguration is null ? default : PurviewConfiguration.PurviewResourceId;
            set
            {
                if (PurviewConfiguration is null)
                    PurviewConfiguration = new DataFactoryPurviewConfiguration();
                PurviewConfiguration.PurviewResourceId = value;
            }
        }

        /// <summary>
        /// Git repo information of the factory.
        /// Please note <see cref="FactoryRepoConfiguration"/> is the base class. According to the scenario, a derived class of the base class might need to be assigned here, or this property needs to be casted to one of the possible derived classes.
        /// The available derived classes include <see cref="FactoryGitHubConfiguration"/> and <see cref="FactoryVstsConfiguration"/>.
        /// </summary>
        public FactoryRepoConfiguration RepoConfiguration { get; set; }
        /// <summary> List of parameters for factory. </summary>
        public IDictionary<string, DataFactoryGlobalParameterProperties> GlobalParameters { get; }
        /// <summary> Properties to enable Customer Managed Key for the factory. </summary>
        public DataFactoryEncryptionConfiguration Encryption { get; set; }
        /// <summary> Whether or not public network access is allowed for the data factory. </summary>
        public DataFactoryPublicNetworkAccess? PublicNetworkAccess { get; set; }
        /// <summary> Etag identifies change in the resource. </summary>
        public ETag? ETag { get; }
        /// <summary>
        /// Additional Properties
        /// <para>
        /// To assign an object to the value of this property use <see cref="BinaryData.FromObjectAsJson{T}(T, System.Text.Json.JsonSerializerOptions?)"/>.
        /// </para>
        /// <para>
        /// To assign an already formated json string to this property use <see cref="BinaryData.FromString(string)"/>.
        /// </para>
        /// <para>
        /// Examples:
        /// <list type="bullet">
        /// <item>
        /// <term>BinaryData.FromObjectAsJson("foo")</term>
        /// <description>Creates a payload of "foo".</description>
        /// </item>
        /// <item>
        /// <term>BinaryData.FromString("\"foo\"")</term>
        /// <description>Creates a payload of "foo".</description>
        /// </item>
        /// <item>
        /// <term>BinaryData.FromObjectAsJson(new { key = "value" })</term>
        /// <description>Creates a payload of { "key": "value" }.</description>
        /// </item>
        /// <item>
        /// <term>BinaryData.FromString("{\"key\": \"value\"}")</term>
        /// <description>Creates a payload of { "key": "value" }.</description>
        /// </item>
        /// </list>
        /// </para>
        /// </summary>
        public IDictionary<string, DataFactoryElement<string>> AdditionalProperties { get; }
    }
}
