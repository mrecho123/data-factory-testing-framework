// <auto-generated/>

#nullable disable

namespace AzureDataFactory.TestingFramework.Models
{
    /// <summary> The status of the operation. </summary>
    public partial class SsisObjectMetadataStatusResult
    {
        /// <summary> Initializes a new instance of SsisObjectMetadataStatusResult. </summary>
        internal SsisObjectMetadataStatusResult()
        {
        }

        /// <summary> Initializes a new instance of SsisObjectMetadataStatusResult. </summary>
        /// <param name="status"> The status of the operation. </param>
        /// <param name="name"> The operation name. </param>
        /// <param name="properties"> The operation properties. </param>
        /// <param name="error"> The operation error message. </param>
        internal SsisObjectMetadataStatusResult(string status, string name, string properties, string error)
        {
            Status = status;
            Name = name;
            Properties = properties;
            Error = error;
        }

        /// <summary> The status of the operation. </summary>
        public string Status { get; }
        /// <summary> The operation name. </summary>
        public string Name { get; }
        /// <summary> The operation properties. </summary>
        public string Properties { get; }
        /// <summary> The operation error message. </summary>
        public string Error { get; }
    }
}
