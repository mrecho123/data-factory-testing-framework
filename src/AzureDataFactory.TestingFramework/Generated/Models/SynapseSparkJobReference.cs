// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using Azure.Core;

namespace AzureDataFactory.TestingFramework.Models
{
    /// <summary> Synapse spark job reference type. </summary>
    public partial class SynapseSparkJobReference
    {
        /// <summary> Initializes a new instance of SynapseSparkJobReference. </summary>
        /// <param name="sparkJobReferenceType"> Synapse spark job reference type. </param>
        /// <param name="referenceName"> Reference spark job name. Expression with resultType string. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="referenceName"/> is null. </exception>
        public SynapseSparkJobReference(SparkJobReferenceType sparkJobReferenceType, BinaryData referenceName)
        {
            Argument.AssertNotNull(referenceName, nameof(referenceName));

            SparkJobReferenceType = sparkJobReferenceType;
            ReferenceName = referenceName;
        }

        /// <summary> Synapse spark job reference type. </summary>
        public SparkJobReferenceType SparkJobReferenceType { get; set; }
        /// <summary>
        /// Reference spark job name. Expression with resultType string.
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
        public BinaryData ReferenceName { get; set; }
    }
}