// <auto-generated/>

#nullable disable

using Azure.Core.Expressions.DataFactory;

namespace AzureDataFactory.TestingFramework.Models
{
    /// <summary> A copy activity source for SAP ODP source. </summary>
    public partial class SapOdpSource : TabularSource
    {
        /// <summary> Initializes a new instance of SapOdpSource. </summary>
        public SapOdpSource()
        {
            CopySourceType = "SapOdpSource";
        }

        /// <summary> Initializes a new instance of SapOdpSource. </summary>
        /// <param name="copySourceType"> Copy source type. </param>
        /// <param name="sourceRetryCount"> Source retry count. Type: integer (or Expression with resultType integer). </param>
        /// <param name="sourceRetryWait"> Source retry wait. Type: string (or Expression with resultType string), pattern: ((\d+)\.)?(\d\d):(60|([0-5][0-9])):(60|([0-5][0-9])). </param>
        /// <param name="maxConcurrentConnections"> The maximum concurrent connection count for the source data store. Type: integer (or Expression with resultType integer). </param>
        /// <param name="disableMetricsCollection"> If true, disable data store metrics collection. Default is false. Type: boolean (or Expression with resultType boolean). </param>
        /// <param name="additionalProperties"> Additional Properties. </param>
        /// <param name="queryTimeout"> Query timeout. Type: string (or Expression with resultType string), pattern: ((\d+)\.)?(\d\d):(60|([0-5][0-9])):(60|([0-5][0-9])). </param>
        /// <param name="additionalColumns"> Specifies the additional columns to be added to source data. Type: array of objects(AdditionalColumns) (or Expression with resultType array of objects). </param>
        /// <param name="extractionMode"> The extraction mode. Allowed value include: Full, Delta and Recovery. The default value is Full. Type: string (or Expression with resultType string). </param>
        /// <param name="subscriberProcess"> The subscriber process to manage the delta process. Type: string (or Expression with resultType string). </param>
        /// <param name="selection"> Specifies the selection conditions from source data. Type: array of objects(selection) (or Expression with resultType array of objects). </param>
        /// <param name="projection"> Specifies the columns to be selected from source data. Type: array of objects(projection) (or Expression with resultType array of objects). </param>
        internal SapOdpSource(string copySourceType, DataFactoryElement<int> sourceRetryCount, DataFactoryElement<string> sourceRetryWait, DataFactoryElement<int> maxConcurrentConnections, DataFactoryElement<bool> disableMetricsCollection, IDictionary<string, DataFactoryElement<string>> additionalProperties, DataFactoryElement<string> queryTimeout, BinaryData additionalColumns, DataFactoryElement<string> extractionMode, DataFactoryElement<string> subscriberProcess, BinaryData selection, BinaryData projection) : base(copySourceType, sourceRetryCount, sourceRetryWait, maxConcurrentConnections, disableMetricsCollection, additionalProperties, queryTimeout, additionalColumns)
        {
            ExtractionMode = extractionMode;
            SubscriberProcess = subscriberProcess;
            Selection = selection;
            Projection = projection;
            CopySourceType = copySourceType ?? "SapOdpSource";
        }

        /// <summary> The extraction mode. Allowed value include: Full, Delta and Recovery. The default value is Full. Type: string (or Expression with resultType string). </summary>
        public DataFactoryElement<string> ExtractionMode { get; set; }
        /// <summary> The subscriber process to manage the delta process. Type: string (or Expression with resultType string). </summary>
        public DataFactoryElement<string> SubscriberProcess { get; set; }
        /// <summary>
        /// Specifies the selection conditions from source data. Type: array of objects(selection) (or Expression with resultType array of objects).
        /// <para>
        /// To assign an object to this property use <see cref="BinaryData.FromObjectAsJson{T}(T, System.Text.Json.JsonSerializerOptions?)"/>.
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
        public BinaryData Selection { get; set; }
        /// <summary>
        /// Specifies the columns to be selected from source data. Type: array of objects(projection) (or Expression with resultType array of objects).
        /// <para>
        /// To assign an object to this property use <see cref="BinaryData.FromObjectAsJson{T}(T, System.Text.Json.JsonSerializerOptions?)"/>.
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
        public BinaryData Projection { get; set; }
    }
}
