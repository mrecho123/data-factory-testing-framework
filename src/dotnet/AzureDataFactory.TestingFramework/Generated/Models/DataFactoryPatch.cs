// <auto-generated/>

#nullable disable

using Azure.Core;
using Azure.ResourceManager.Models;

namespace AzureDataFactory.TestingFramework.Models
{
    /// <summary> Parameters for updating a factory resource. </summary>
    public partial class DataFactoryPatch
    {
        /// <summary> Initializes a new instance of DataFactoryPatch. </summary>
        public DataFactoryPatch()
        {
            Tags = new ChangeTrackingDictionary<string, string>();
        }

        /// <summary> The resource tags. </summary>
        public IDictionary<string, string> Tags { get; }
        /// <summary> Managed service identity of the factory. Current supported identity types: SystemAssigned, UserAssigned, SystemAssigned,UserAssigned. </summary>
        public ManagedServiceIdentity Identity { get; set; }
        /// <summary> Whether or not public network access is allowed for the data factory. </summary>
        public DataFactoryPublicNetworkAccess? PublicNetworkAccess { get; set; }
    }
}