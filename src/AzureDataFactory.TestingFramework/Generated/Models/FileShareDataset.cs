// <auto-generated/>

#nullable disable

using Azure.Core;
using Azure.Core.Expressions.DataFactory;

namespace AzureDataFactory.TestingFramework.Models
{
    /// <summary> An on-premises file system dataset. </summary>
    public partial class FileShareDataset : DataFactoryDatasetProperties
    {
        /// <summary> Initializes a new instance of FileShareDataset. </summary>
        /// <param name="linkedServiceName"> Linked service reference. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="linkedServiceName"/> is null. </exception>
        public FileShareDataset(DataFactoryLinkedServiceReference linkedServiceName) : base(linkedServiceName)
        {
            Argument.AssertNotNull(linkedServiceName, nameof(linkedServiceName));

            DatasetType = "FileShare";
        }

        /// <summary> Initializes a new instance of FileShareDataset. </summary>
        /// <param name="datasetType"> Type of dataset. </param>
        /// <param name="description"> Dataset description. </param>
        /// <param name="structure"> Columns that define the structure of the dataset. Type: array (or Expression with resultType array), itemType: DatasetDataElement. </param>
        /// <param name="schema"> Columns that define the physical type schema of the dataset. Type: array (or Expression with resultType array), itemType: DatasetSchemaDataElement. </param>
        /// <param name="linkedServiceName"> Linked service reference. </param>
        /// <param name="parameters"> Parameters for dataset. </param>
        /// <param name="annotations"> List of tags that can be used for describing the Dataset. </param>
        /// <param name="folder"> The folder that this Dataset is in. If not specified, Dataset will appear at the root level. </param>
        /// <param name="additionalProperties"> Additional Properties. </param>
        /// <param name="folderPath"> The path of the on-premises file system. Type: string (or Expression with resultType string). </param>
        /// <param name="fileName"> The name of the on-premises file system. Type: string (or Expression with resultType string). </param>
        /// <param name="modifiedDatetimeStart"> The start of file's modified datetime. Type: string (or Expression with resultType string). </param>
        /// <param name="modifiedDatetimeEnd"> The end of file's modified datetime. Type: string (or Expression with resultType string). </param>
        /// <param name="format">
        /// The format of the files.
        /// Please note <see cref="DatasetStorageFormat"/> is the base class. According to the scenario, a derived class of the base class might need to be assigned here, or this property needs to be casted to one of the possible derived classes.
        /// The available derived classes include <see cref="DatasetAvroFormat"/>, <see cref="DatasetJsonFormat"/>, <see cref="DatasetOrcFormat"/>, <see cref="DatasetParquetFormat"/> and <see cref="DatasetTextFormat"/>.
        /// </param>
        /// <param name="fileFilter"> Specify a filter to be used to select a subset of files in the folderPath rather than all files. Type: string (or Expression with resultType string). </param>
        /// <param name="compression"> The data compression method used for the file system. </param>
        internal FileShareDataset(string datasetType, string description, DataFactoryElement<IList<DatasetDataElement>> structure, DataFactoryElement<IList<DatasetSchemaDataElement>> schema, DataFactoryLinkedServiceReference linkedServiceName, IDictionary<string, EntityParameterSpecification> parameters, IList<BinaryData> annotations, DatasetFolder folder, IDictionary<string, DataFactoryElement<string>> additionalProperties, DataFactoryElement<string> folderPath, DataFactoryElement<string> fileName, DataFactoryElement<string> modifiedDatetimeStart, DataFactoryElement<string> modifiedDatetimeEnd, DatasetStorageFormat format, DataFactoryElement<string> fileFilter, DatasetCompression compression) : base(datasetType, description, structure, schema, linkedServiceName, parameters, annotations, folder, additionalProperties)
        {
            FolderPath = folderPath;
            FileName = fileName;
            ModifiedDatetimeStart = modifiedDatetimeStart;
            ModifiedDatetimeEnd = modifiedDatetimeEnd;
            Format = format;
            FileFilter = fileFilter;
            Compression = compression;
            DatasetType = datasetType ?? "FileShare";
        }

        /// <summary> The path of the on-premises file system. Type: string (or Expression with resultType string). </summary>
        public DataFactoryElement<string> FolderPath { get; set; }
        /// <summary> The name of the on-premises file system. Type: string (or Expression with resultType string). </summary>
        public DataFactoryElement<string> FileName { get; set; }
        /// <summary> The start of file's modified datetime. Type: string (or Expression with resultType string). </summary>
        public DataFactoryElement<string> ModifiedDatetimeStart { get; set; }
        /// <summary> The end of file's modified datetime. Type: string (or Expression with resultType string). </summary>
        public DataFactoryElement<string> ModifiedDatetimeEnd { get; set; }
        /// <summary>
        /// The format of the files.
        /// Please note <see cref="DatasetStorageFormat"/> is the base class. According to the scenario, a derived class of the base class might need to be assigned here, or this property needs to be casted to one of the possible derived classes.
        /// The available derived classes include <see cref="DatasetAvroFormat"/>, <see cref="DatasetJsonFormat"/>, <see cref="DatasetOrcFormat"/>, <see cref="DatasetParquetFormat"/> and <see cref="DatasetTextFormat"/>.
        /// </summary>
        public DatasetStorageFormat Format { get; set; }
        /// <summary> Specify a filter to be used to select a subset of files in the folderPath rather than all files. Type: string (or Expression with resultType string). </summary>
        public DataFactoryElement<string> FileFilter { get; set; }
        /// <summary> The data compression method used for the file system. </summary>
        public DatasetCompression Compression { get; set; }
    }
}
