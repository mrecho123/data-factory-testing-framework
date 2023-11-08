// <auto-generated/>

#nullable disable

using Azure.Core;
using Azure.ResourceManager.DataFactory;

namespace AzureDataFactory.TestingFramework.Models
{
    /// <summary> A list of managed Virtual Network resources. </summary>
    internal partial class DataFactoryManagedVirtualNetworkListResult
    {
        /// <summary> Initializes a new instance of DataFactoryManagedVirtualNetworkListResult. </summary>
        /// <param name="value"> List of managed Virtual Networks. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        internal DataFactoryManagedVirtualNetworkListResult(IEnumerable<DataFactoryManagedVirtualNetworkData> value)
        {
            Argument.AssertNotNull(value, nameof(value));

            Value = value.ToList();
        }

        /// <summary> Initializes a new instance of DataFactoryManagedVirtualNetworkListResult. </summary>
        /// <param name="value"> List of managed Virtual Networks. </param>
        /// <param name="nextLink"> The link to the next page of results, if any remaining results exist. </param>
        internal DataFactoryManagedVirtualNetworkListResult(IReadOnlyList<DataFactoryManagedVirtualNetworkData> value, string nextLink)
        {
            Value = value;
            NextLink = nextLink;
        }

        /// <summary> List of managed Virtual Networks. </summary>
        public IReadOnlyList<DataFactoryManagedVirtualNetworkData> Value { get; }
        /// <summary> The link to the next page of results, if any remaining results exist. </summary>
        public string NextLink { get; }
    }
}