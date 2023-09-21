// <auto-generated/>

#nullable disable

using Azure.Core.Expressions.DataFactory;

namespace AzureDataFactory.TestingFramework.Models
{
    /// <summary> HDFS read settings. </summary>
    public partial class HdfsReadSettings : StoreReadSettings
    {
        /// <summary> Initializes a new instance of HdfsReadSettings. </summary>
        public HdfsReadSettings()
        {
            StoreReadSettingsType = "HdfsReadSettings";
        }

        /// <summary> Initializes a new instance of HdfsReadSettings. </summary>
        /// <param name="storeReadSettingsType"> The read setting type. </param>
        /// <param name="maxConcurrentConnections"> The maximum concurrent connection count for the source data store. Type: integer (or Expression with resultType integer). </param>
        /// <param name="disableMetricsCollection"> If true, disable data store metrics collection. Default is false. Type: boolean (or Expression with resultType boolean). </param>
        /// <param name="additionalProperties"> Additional Properties. </param>
        /// <param name="recursive"> If true, files under the folder path will be read recursively. Default is true. Type: boolean (or Expression with resultType boolean). </param>
        /// <param name="wildcardFolderPath"> HDFS wildcardFolderPath. Type: string (or Expression with resultType string). </param>
        /// <param name="wildcardFileName"> HDFS wildcardFileName. Type: string (or Expression with resultType string). </param>
        /// <param name="fileListPath"> Point to a text file that lists each file (relative path to the path configured in the dataset) that you want to copy. Type: string (or Expression with resultType string). </param>
        /// <param name="enablePartitionDiscovery"> Indicates whether to enable partition discovery. Type: boolean (or Expression with resultType boolean). </param>
        /// <param name="partitionRootPath"> Specify the root path where partition discovery starts from. Type: string (or Expression with resultType string). </param>
        /// <param name="modifiedDatetimeStart"> The start of file's modified datetime. Type: string (or Expression with resultType string). </param>
        /// <param name="modifiedDatetimeEnd"> The end of file's modified datetime. Type: string (or Expression with resultType string). </param>
        /// <param name="distcpSettings"> Specifies Distcp-related settings. </param>
        /// <param name="deleteFilesAfterCompletion"> Indicates whether the source files need to be deleted after copy completion. Default is false. Type: boolean (or Expression with resultType boolean). </param>
        internal HdfsReadSettings(string storeReadSettingsType, DataFactoryElement<int> maxConcurrentConnections, DataFactoryElement<bool> disableMetricsCollection, IDictionary<string, DataFactoryElement<string>> additionalProperties, DataFactoryElement<bool> recursive, DataFactoryElement<string> wildcardFolderPath, DataFactoryElement<string> wildcardFileName, DataFactoryElement<string> fileListPath, DataFactoryElement<bool> enablePartitionDiscovery, DataFactoryElement<string> partitionRootPath, DataFactoryElement<string> modifiedDatetimeStart, DataFactoryElement<string> modifiedDatetimeEnd, DistcpSettings distcpSettings, DataFactoryElement<bool> deleteFilesAfterCompletion) : base(storeReadSettingsType, maxConcurrentConnections, disableMetricsCollection, additionalProperties)
        {
            Recursive = recursive;
            WildcardFolderPath = wildcardFolderPath;
            WildcardFileName = wildcardFileName;
            FileListPath = fileListPath;
            EnablePartitionDiscovery = enablePartitionDiscovery;
            PartitionRootPath = partitionRootPath;
            ModifiedDatetimeStart = modifiedDatetimeStart;
            ModifiedDatetimeEnd = modifiedDatetimeEnd;
            DistcpSettings = distcpSettings;
            DeleteFilesAfterCompletion = deleteFilesAfterCompletion;
            StoreReadSettingsType = storeReadSettingsType ?? "HdfsReadSettings";
        }

        /// <summary> If true, files under the folder path will be read recursively. Default is true. Type: boolean (or Expression with resultType boolean). </summary>
        public DataFactoryElement<bool> Recursive { get; set; }
        /// <summary> HDFS wildcardFolderPath. Type: string (or Expression with resultType string). </summary>
        public DataFactoryElement<string> WildcardFolderPath { get; set; }
        /// <summary> HDFS wildcardFileName. Type: string (or Expression with resultType string). </summary>
        public DataFactoryElement<string> WildcardFileName { get; set; }
        /// <summary> Point to a text file that lists each file (relative path to the path configured in the dataset) that you want to copy. Type: string (or Expression with resultType string). </summary>
        public DataFactoryElement<string> FileListPath { get; set; }
        /// <summary> Indicates whether to enable partition discovery. Type: boolean (or Expression with resultType boolean). </summary>
        public DataFactoryElement<bool> EnablePartitionDiscovery { get; set; }
        /// <summary> Specify the root path where partition discovery starts from. Type: string (or Expression with resultType string). </summary>
        public DataFactoryElement<string> PartitionRootPath { get; set; }
        /// <summary> The start of file's modified datetime. Type: string (or Expression with resultType string). </summary>
        public DataFactoryElement<string> ModifiedDatetimeStart { get; set; }
        /// <summary> The end of file's modified datetime. Type: string (or Expression with resultType string). </summary>
        public DataFactoryElement<string> ModifiedDatetimeEnd { get; set; }
        /// <summary> Specifies Distcp-related settings. </summary>
        public DistcpSettings DistcpSettings { get; set; }
        /// <summary> Indicates whether the source files need to be deleted after copy completion. Default is false. Type: boolean (or Expression with resultType boolean). </summary>
        public DataFactoryElement<bool> DeleteFilesAfterCompletion { get; set; }
    }
}
