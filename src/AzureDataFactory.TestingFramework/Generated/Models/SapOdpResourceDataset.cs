// <auto-generated/>

#nullable disable

using Azure.Core;
using Azure.Core.Expressions.DataFactory;

namespace AzureDataFactory.TestingFramework.Models
{
    /// <summary> SAP ODP Resource properties. </summary>
    public partial class SapOdpResourceDataset : DataFactoryDatasetProperties
    {
        /// <summary> Initializes a new instance of SapOdpResourceDataset. </summary>
        /// <param name="linkedServiceName"> Linked service reference. </param>
        /// <param name="context"> The context of the SAP ODP Object. Type: string (or Expression with resultType string). </param>
        /// <param name="objectName"> The name of the SAP ODP Object. Type: string (or Expression with resultType string). </param>
        /// <exception cref="ArgumentNullException"> <paramref name="linkedServiceName"/>, <paramref name="context"/> or <paramref name="objectName"/> is null. </exception>
        public SapOdpResourceDataset(DataFactoryLinkedServiceReference linkedServiceName, DataFactoryElement<string> context, DataFactoryElement<string> objectName) : base(linkedServiceName)
        {
            Argument.AssertNotNull(linkedServiceName, nameof(linkedServiceName));
            Argument.AssertNotNull(context, nameof(context));
            Argument.AssertNotNull(objectName, nameof(objectName));

            Context = context;
            ObjectName = objectName;
            DatasetType = "SapOdpResource";
        }

        /// <summary> Initializes a new instance of SapOdpResourceDataset. </summary>
        /// <param name="datasetType"> Type of dataset. </param>
        /// <param name="description"> Dataset description. </param>
        /// <param name="structure"> Columns that define the structure of the dataset. Type: array (or Expression with resultType array), itemType: DatasetDataElement. </param>
        /// <param name="schema"> Columns that define the physical type schema of the dataset. Type: array (or Expression with resultType array), itemType: DatasetSchemaDataElement. </param>
        /// <param name="linkedServiceName"> Linked service reference. </param>
        /// <param name="parameters"> Parameters for dataset. </param>
        /// <param name="annotations"> List of tags that can be used for describing the Dataset. </param>
        /// <param name="folder"> The folder that this Dataset is in. If not specified, Dataset will appear at the root level. </param>
        /// <param name="additionalProperties"> Additional Properties. </param>
        /// <param name="context"> The context of the SAP ODP Object. Type: string (or Expression with resultType string). </param>
        /// <param name="objectName"> The name of the SAP ODP Object. Type: string (or Expression with resultType string). </param>
        internal SapOdpResourceDataset(string datasetType, string description, DataFactoryElement<IList<DatasetDataElement>> structure, DataFactoryElement<IList<DatasetSchemaDataElement>> schema, DataFactoryLinkedServiceReference linkedServiceName, IDictionary<string, EntityParameterSpecification> parameters, IList<BinaryData> annotations, DatasetFolder folder, IDictionary<string, DataFactoryElement<string>> additionalProperties, DataFactoryElement<string> context, DataFactoryElement<string> objectName) : base(datasetType, description, structure, schema, linkedServiceName, parameters, annotations, folder, additionalProperties)
        {
            Context = context;
            ObjectName = objectName;
            DatasetType = datasetType ?? "SapOdpResource";
        }

        /// <summary> The context of the SAP ODP Object. Type: string (or Expression with resultType string). </summary>
        public DataFactoryElement<string> Context { get; set; }
        /// <summary> The name of the SAP ODP Object. Type: string (or Expression with resultType string). </summary>
        public DataFactoryElement<string> ObjectName { get; set; }
    }
}
