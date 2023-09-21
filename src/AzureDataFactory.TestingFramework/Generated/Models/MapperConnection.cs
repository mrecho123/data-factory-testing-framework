// <auto-generated/>

#nullable disable

using Azure.Core;
using Azure.Core.Expressions.DataFactory;

namespace AzureDataFactory.TestingFramework.Models
{
    /// <summary> Source connection details. </summary>
    public partial class MapperConnection
    {
        /// <summary> Initializes a new instance of MapperConnection. </summary>
        /// <param name="connectionType"> Type of connection via linked service or dataset. </param>
        public MapperConnection(MapperConnectionType connectionType)
        {
            ConnectionType = connectionType;
            CommonDslConnectorProperties = new ChangeTrackingList<MapperDslConnectorProperties>();
        }

        /// <summary> Initializes a new instance of MapperConnection. </summary>
        /// <param name="linkedService"> Linked service reference. </param>
        /// <param name="linkedServiceType"> Type of the linked service e.g.: AzureBlobFS. </param>
        /// <param name="connectionType"> Type of connection via linked service or dataset. </param>
        /// <param name="isInlineDataset"> A boolean indicating whether linked service is of type inline dataset. Currently only inline datasets are supported. </param>
        /// <param name="commonDslConnectorProperties"> List of name/value pairs for connection properties. </param>
        internal MapperConnection(DataFactoryLinkedServiceReference linkedService, string linkedServiceType, MapperConnectionType connectionType, bool? isInlineDataset, IList<MapperDslConnectorProperties> commonDslConnectorProperties)
        {
            LinkedService = linkedService;
            LinkedServiceType = linkedServiceType;
            ConnectionType = connectionType;
            IsInlineDataset = isInlineDataset;
            CommonDslConnectorProperties = commonDslConnectorProperties;
        }

        /// <summary> Linked service reference. </summary>
        public DataFactoryLinkedServiceReference LinkedService { get; set; }
        /// <summary> Type of the linked service e.g.: AzureBlobFS. </summary>
        public string LinkedServiceType { get; set; }
        /// <summary> Type of connection via linked service or dataset. </summary>
        public MapperConnectionType ConnectionType { get; set; }
        /// <summary> A boolean indicating whether linked service is of type inline dataset. Currently only inline datasets are supported. </summary>
        public bool? IsInlineDataset { get; set; }
        /// <summary> List of name/value pairs for connection properties. </summary>
        public IList<MapperDslConnectorProperties> CommonDslConnectorProperties { get; }
    }
}
