// <auto-generated/>

#nullable disable

using Azure.Core.Expressions.DataFactory;

namespace AzureDataFactory.TestingFramework.Models
{
    /// <summary> A copy activity Azure Data Explorer sink. </summary>
    public partial class AzureDataExplorerSink : CopySink
    {
        /// <summary> Initializes a new instance of AzureDataExplorerSink. </summary>
        public AzureDataExplorerSink()
        {
            CopySinkType = "AzureDataExplorerSink";
        }

        /// <summary> Initializes a new instance of AzureDataExplorerSink. </summary>
        /// <param name="copySinkType"> Copy sink type. </param>
        /// <param name="writeBatchSize"> Write batch size. Type: integer (or Expression with resultType integer), minimum: 0. </param>
        /// <param name="writeBatchTimeout"> Write batch timeout. Type: string (or Expression with resultType string), pattern: ((\d+)\.)?(\d\d):(60|([0-5][0-9])):(60|([0-5][0-9])). </param>
        /// <param name="sinkRetryCount"> Sink retry count. Type: integer (or Expression with resultType integer). </param>
        /// <param name="sinkRetryWait"> Sink retry wait. Type: string (or Expression with resultType string), pattern: ((\d+)\.)?(\d\d):(60|([0-5][0-9])):(60|([0-5][0-9])). </param>
        /// <param name="maxConcurrentConnections"> The maximum concurrent connection count for the sink data store. Type: integer (or Expression with resultType integer). </param>
        /// <param name="disableMetricsCollection"> If true, disable data store metrics collection. Default is false. Type: boolean (or Expression with resultType boolean). </param>
        /// <param name="additionalProperties"> Additional Properties. </param>
        /// <param name="ingestionMappingName"> A name of a pre-created csv mapping that was defined on the target Kusto table. Type: string. </param>
        /// <param name="ingestionMappingAsJson"> An explicit column mapping description provided in a json format. Type: string. </param>
        /// <param name="flushImmediately"> If set to true, any aggregation will be skipped. Default is false. Type: boolean. </param>
        internal AzureDataExplorerSink(string copySinkType, DataFactoryElement<int> writeBatchSize, DataFactoryElement<string> writeBatchTimeout, DataFactoryElement<int> sinkRetryCount, DataFactoryElement<string> sinkRetryWait, DataFactoryElement<int> maxConcurrentConnections, DataFactoryElement<bool> disableMetricsCollection, IDictionary<string, DataFactoryElement<string>> additionalProperties, DataFactoryElement<string> ingestionMappingName, DataFactoryElement<string> ingestionMappingAsJson, DataFactoryElement<bool> flushImmediately) : base(copySinkType, writeBatchSize, writeBatchTimeout, sinkRetryCount, sinkRetryWait, maxConcurrentConnections, disableMetricsCollection, additionalProperties)
        {
            IngestionMappingName = ingestionMappingName;
            IngestionMappingAsJson = ingestionMappingAsJson;
            FlushImmediately = flushImmediately;
            CopySinkType = copySinkType ?? "AzureDataExplorerSink";
        }

        /// <summary> A name of a pre-created csv mapping that was defined on the target Kusto table. Type: string. </summary>
        public DataFactoryElement<string> IngestionMappingName { get; set; }
        /// <summary> An explicit column mapping description provided in a json format. Type: string. </summary>
        public DataFactoryElement<string> IngestionMappingAsJson { get; set; }
        /// <summary> If set to true, any aggregation will be skipped. Default is false. Type: boolean. </summary>
        public DataFactoryElement<bool> FlushImmediately { get; set; }
    }
}
