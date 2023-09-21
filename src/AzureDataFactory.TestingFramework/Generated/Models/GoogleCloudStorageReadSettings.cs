// <auto-generated/>

#nullable disable

using Azure.Core.Expressions.DataFactory;

namespace AzureDataFactory.TestingFramework.Models
{
    /// <summary> Google Cloud Storage read settings. </summary>
    public partial class GoogleCloudStorageReadSettings : StoreReadSettings
    {
        /// <summary> Initializes a new instance of GoogleCloudStorageReadSettings. </summary>
        public GoogleCloudStorageReadSettings()
        {
            StoreReadSettingsType = "GoogleCloudStorageReadSettings";
        }

        /// <summary> Initializes a new instance of GoogleCloudStorageReadSettings. </summary>
        /// <param name="storeReadSettingsType"> The read setting type. </param>
        /// <param name="maxConcurrentConnections"> The maximum concurrent connection count for the source data store. Type: integer (or Expression with resultType integer). </param>
        /// <param name="disableMetricsCollection"> If true, disable data store metrics collection. Default is false. Type: boolean (or Expression with resultType boolean). </param>
        /// <param name="additionalProperties"> Additional Properties. </param>
        /// <param name="recursive"> If true, files under the folder path will be read recursively. Default is true. Type: boolean (or Expression with resultType boolean). </param>
        /// <param name="wildcardFolderPath"> Google Cloud Storage wildcardFolderPath. Type: string (or Expression with resultType string). </param>
        /// <param name="wildcardFileName"> Google Cloud Storage wildcardFileName. Type: string (or Expression with resultType string). </param>
        /// <param name="prefix"> The prefix filter for the Google Cloud Storage object name. Type: string (or Expression with resultType string). </param>
        /// <param name="fileListPath"> Point to a text file that lists each file (relative path to the path configured in the dataset) that you want to copy. Type: string (or Expression with resultType string). </param>
        /// <param name="enablePartitionDiscovery"> Indicates whether to enable partition discovery. Type: boolean (or Expression with resultType boolean). </param>
        /// <param name="partitionRootPath"> Specify the root path where partition discovery starts from. Type: string (or Expression with resultType string). </param>
        /// <param name="deleteFilesAfterCompletion"> Indicates whether the source files need to be deleted after copy completion. Default is false. Type: boolean (or Expression with resultType boolean). </param>
        /// <param name="modifiedDatetimeStart"> The start of file's modified datetime. Type: string (or Expression with resultType string). </param>
        /// <param name="modifiedDatetimeEnd"> The end of file's modified datetime. Type: string (or Expression with resultType string). </param>
        internal GoogleCloudStorageReadSettings(string storeReadSettingsType, DataFactoryElement<int> maxConcurrentConnections, DataFactoryElement<bool> disableMetricsCollection, IDictionary<string, DataFactoryElement<string>> additionalProperties, DataFactoryElement<bool> recursive, DataFactoryElement<string> wildcardFolderPath, DataFactoryElement<string> wildcardFileName, DataFactoryElement<string> prefix, DataFactoryElement<string> fileListPath, DataFactoryElement<bool> enablePartitionDiscovery, DataFactoryElement<string> partitionRootPath, DataFactoryElement<bool> deleteFilesAfterCompletion, DataFactoryElement<string> modifiedDatetimeStart, DataFactoryElement<string> modifiedDatetimeEnd) : base(storeReadSettingsType, maxConcurrentConnections, disableMetricsCollection, additionalProperties)
        {
            Recursive = recursive;
            WildcardFolderPath = wildcardFolderPath;
            WildcardFileName = wildcardFileName;
            Prefix = prefix;
            FileListPath = fileListPath;
            EnablePartitionDiscovery = enablePartitionDiscovery;
            PartitionRootPath = partitionRootPath;
            DeleteFilesAfterCompletion = deleteFilesAfterCompletion;
            ModifiedDatetimeStart = modifiedDatetimeStart;
            ModifiedDatetimeEnd = modifiedDatetimeEnd;
            StoreReadSettingsType = storeReadSettingsType ?? "GoogleCloudStorageReadSettings";
        }

        /// <summary> If true, files under the folder path will be read recursively. Default is true. Type: boolean (or Expression with resultType boolean). </summary>
        public DataFactoryElement<bool> Recursive { get; set; }
        /// <summary> Google Cloud Storage wildcardFolderPath. Type: string (or Expression with resultType string). </summary>
        public DataFactoryElement<string> WildcardFolderPath { get; set; }
        /// <summary> Google Cloud Storage wildcardFileName. Type: string (or Expression with resultType string). </summary>
        public DataFactoryElement<string> WildcardFileName { get; set; }
        /// <summary> The prefix filter for the Google Cloud Storage object name. Type: string (or Expression with resultType string). </summary>
        public DataFactoryElement<string> Prefix { get; set; }
        /// <summary> Point to a text file that lists each file (relative path to the path configured in the dataset) that you want to copy. Type: string (or Expression with resultType string). </summary>
        public DataFactoryElement<string> FileListPath { get; set; }
        /// <summary> Indicates whether to enable partition discovery. Type: boolean (or Expression with resultType boolean). </summary>
        public DataFactoryElement<bool> EnablePartitionDiscovery { get; set; }
        /// <summary> Specify the root path where partition discovery starts from. Type: string (or Expression with resultType string). </summary>
        public DataFactoryElement<string> PartitionRootPath { get; set; }
        /// <summary> Indicates whether the source files need to be deleted after copy completion. Default is false. Type: boolean (or Expression with resultType boolean). </summary>
        public DataFactoryElement<bool> DeleteFilesAfterCompletion { get; set; }
        /// <summary> The start of file's modified datetime. Type: string (or Expression with resultType string). </summary>
        public DataFactoryElement<string> ModifiedDatetimeStart { get; set; }
        /// <summary> The end of file's modified datetime. Type: string (or Expression with resultType string). </summary>
        public DataFactoryElement<string> ModifiedDatetimeEnd { get; set; }
    }
}
