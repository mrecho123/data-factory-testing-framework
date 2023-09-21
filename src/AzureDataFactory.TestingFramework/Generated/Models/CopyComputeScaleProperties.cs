// <auto-generated/>

#nullable disable

using Azure.Core;
using Azure.Core.Expressions.DataFactory;

namespace AzureDataFactory.TestingFramework.Models
{
    /// <summary> CopyComputeScale properties for managed integration runtime. </summary>
    public partial class CopyComputeScaleProperties
    {
        /// <summary> Initializes a new instance of CopyComputeScaleProperties. </summary>
        public CopyComputeScaleProperties()
        {
            AdditionalProperties = new ChangeTrackingDictionary<string, DataFactoryElement<string>>();
        }

        /// <summary> Initializes a new instance of CopyComputeScaleProperties. </summary>
        /// <param name="dataIntegrationUnit"> DIU number setting reserved for copy activity execution. Supported values are multiples of 4 in range 4-256. </param>
        /// <param name="timeToLive"> Time to live (in minutes) setting of integration runtime which will execute copy activity. </param>
        /// <param name="additionalProperties"> Additional Properties. </param>
        internal CopyComputeScaleProperties(int? dataIntegrationUnit, int? timeToLive, IDictionary<string, DataFactoryElement<string>> additionalProperties)
        {
            DataIntegrationUnit = dataIntegrationUnit;
            TimeToLive = timeToLive;
            AdditionalProperties = additionalProperties;
        }

        /// <summary> DIU number setting reserved for copy activity execution. Supported values are multiples of 4 in range 4-256. </summary>
        public int? DataIntegrationUnit { get; set; }
        /// <summary> Time to live (in minutes) setting of integration runtime which will execute copy activity. </summary>
        public int? TimeToLive { get; set; }
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
