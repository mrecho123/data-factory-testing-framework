// <auto-generated/>

#nullable disable

using Azure.Core;
using Azure.Core.Expressions.DataFactory;

namespace AzureDataFactory.TestingFramework.Models
{
    /// <summary>
    /// A copy activity sink.
    /// Please note <see cref="CopySink"/> is the base class. According to the scenario, a derived class of the base class might need to be assigned here, or this property needs to be casted to one of the possible derived classes.
    /// The available derived classes include <see cref="AvroSink"/>, <see cref="AzureBlobFSSink"/>, <see cref="AzureDataExplorerSink"/>, <see cref="AzureDataLakeStoreSink"/>, <see cref="AzureDatabricksDeltaLakeSink"/>, <see cref="AzureMySqlSink"/>, <see cref="AzurePostgreSqlSink"/>, <see cref="AzureQueueSink"/>, <see cref="AzureSearchIndexSink"/>, <see cref="AzureSqlSink"/>, <see cref="AzureTableSink"/>, <see cref="BinarySink"/>, <see cref="DataFactoryBlobSink"/>, <see cref="CommonDataServiceForAppsSink"/>, <see cref="CosmosDBMongoDBApiSink"/>, <see cref="CosmosDBSqlApiSink"/>, <see cref="DelimitedTextSink"/>, <see cref="DocumentDBCollectionSink"/>, <see cref="DynamicsCrmSink"/>, <see cref="DynamicsSink"/>, <see cref="FileSystemSink"/>, <see cref="InformixSink"/>, <see cref="JsonSink"/>, <see cref="MicrosoftAccessSink"/>, <see cref="MongoDBAtlasSink"/>, <see cref="MongoDBV2Sink"/>, <see cref="OdbcSink"/>, <see cref="OracleSink"/>, <see cref="OrcSink"/>, <see cref="ParquetSink"/>, <see cref="RestSink"/>, <see cref="SalesforceServiceCloudSink"/>, <see cref="SalesforceSink"/>, <see cref="SapCloudForCustomerSink"/>, <see cref="SnowflakeSink"/>, <see cref="SqlDWSink"/>, <see cref="SqlMISink"/>, <see cref="SqlServerSink"/> and <see cref="SqlSink"/>.
    /// </summary>
    public partial class CopySink
    {
        /// <summary> Initializes a new instance of CopySink. </summary>
        public CopySink()
        {
            AdditionalProperties = new ChangeTrackingDictionary<string, DataFactoryElement<string>>();
        }

        /// <summary> Initializes a new instance of CopySink. </summary>
        /// <param name="copySinkType"> Copy sink type. </param>
        /// <param name="writeBatchSize"> Write batch size. Type: integer (or Expression with resultType integer), minimum: 0. </param>
        /// <param name="writeBatchTimeout"> Write batch timeout. Type: string (or Expression with resultType string), pattern: ((\d+)\.)?(\d\d):(60|([0-5][0-9])):(60|([0-5][0-9])). </param>
        /// <param name="sinkRetryCount"> Sink retry count. Type: integer (or Expression with resultType integer). </param>
        /// <param name="sinkRetryWait"> Sink retry wait. Type: string (or Expression with resultType string), pattern: ((\d+)\.)?(\d\d):(60|([0-5][0-9])):(60|([0-5][0-9])). </param>
        /// <param name="maxConcurrentConnections"> The maximum concurrent connection count for the sink data store. Type: integer (or Expression with resultType integer). </param>
        /// <param name="disableMetricsCollection"> If true, disable data store metrics collection. Default is false. Type: boolean (or Expression with resultType boolean). </param>
        /// <param name="additionalProperties"> Additional Properties. </param>
        internal CopySink(string copySinkType, DataFactoryElement<int> writeBatchSize, DataFactoryElement<string> writeBatchTimeout, DataFactoryElement<int> sinkRetryCount, DataFactoryElement<string> sinkRetryWait, DataFactoryElement<int> maxConcurrentConnections, DataFactoryElement<bool> disableMetricsCollection, IDictionary<string, DataFactoryElement<string>> additionalProperties)
        {
            CopySinkType = copySinkType;
            WriteBatchSize = writeBatchSize;
            WriteBatchTimeout = writeBatchTimeout;
            SinkRetryCount = sinkRetryCount;
            SinkRetryWait = sinkRetryWait;
            MaxConcurrentConnections = maxConcurrentConnections;
            DisableMetricsCollection = disableMetricsCollection;
            AdditionalProperties = additionalProperties;
        }

        /// <summary> Copy sink type. </summary>
        internal string CopySinkType { get; set; }
        /// <summary> Write batch size. Type: integer (or Expression with resultType integer), minimum: 0. </summary>
        public DataFactoryElement<int> WriteBatchSize { get; set; }
        /// <summary> Write batch timeout. Type: string (or Expression with resultType string), pattern: ((\d+)\.)?(\d\d):(60|([0-5][0-9])):(60|([0-5][0-9])). </summary>
        public DataFactoryElement<string> WriteBatchTimeout { get; set; }
        /// <summary> Sink retry count. Type: integer (or Expression with resultType integer). </summary>
        public DataFactoryElement<int> SinkRetryCount { get; set; }
        /// <summary> Sink retry wait. Type: string (or Expression with resultType string), pattern: ((\d+)\.)?(\d\d):(60|([0-5][0-9])):(60|([0-5][0-9])). </summary>
        public DataFactoryElement<string> SinkRetryWait { get; set; }
        /// <summary> The maximum concurrent connection count for the sink data store. Type: integer (or Expression with resultType integer). </summary>
        public DataFactoryElement<int> MaxConcurrentConnections { get; set; }
        /// <summary> If true, disable data store metrics collection. Default is false. Type: boolean (or Expression with resultType boolean). </summary>
        public DataFactoryElement<bool> DisableMetricsCollection { get; set; }
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
