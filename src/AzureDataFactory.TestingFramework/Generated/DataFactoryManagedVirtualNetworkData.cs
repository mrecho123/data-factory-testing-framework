// <auto-generated/>

#nullable disable

using Azure.Core;
using AzureDataFactory.TestingFramework.Models;
using Azure.ResourceManager.Models;

namespace Azure.ResourceManager.DataFactory
{
    /// <summary>
    /// A class representing the DataFactoryManagedVirtualNetwork data model.
    /// Managed Virtual Network resource type.
    /// </summary>
    public partial class DataFactoryManagedVirtualNetworkData : ResourceData
    {
        /// <summary> Initializes a new instance of DataFactoryManagedVirtualNetworkData. </summary>
        /// <param name="properties"> Managed Virtual Network properties. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="properties"/> is null. </exception>
        public DataFactoryManagedVirtualNetworkData(DataFactoryManagedVirtualNetworkProperties properties)
        {
            Argument.AssertNotNull(properties, nameof(properties));

            Properties = properties;
        }

        /// <summary> Initializes a new instance of DataFactoryManagedVirtualNetworkData. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="resourceType"> The resourceType. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="properties"> Managed Virtual Network properties. </param>
        /// <param name="eTag"> Etag identifies change in the resource. </param>
        internal DataFactoryManagedVirtualNetworkData(ResourceIdentifier id, string name, ResourceType resourceType, SystemData systemData, DataFactoryManagedVirtualNetworkProperties properties, ETag? eTag) : base(id, name, resourceType, systemData)
        {
            Properties = properties;
            ETag = eTag;
        }

        /// <summary> Managed Virtual Network properties. </summary>
        public DataFactoryManagedVirtualNetworkProperties Properties { get; set; }
        /// <summary> Etag identifies change in the resource. </summary>
        public ETag? ETag { get; }
    }
}
