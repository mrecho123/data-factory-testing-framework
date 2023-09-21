// <auto-generated/>

#nullable disable

namespace AzureDataFactory.TestingFramework.Models
{
    /// <summary> Response body with a run identifier. </summary>
    public partial class PipelineCreateRunResult
    {
        /// <summary> Initializes a new instance of PipelineCreateRunResult. </summary>
        /// <param name="runId"> Identifier of a run. </param>
        internal PipelineCreateRunResult(Guid runId)
        {
            RunId = runId;
        }

        /// <summary> Identifier of a run. </summary>
        public Guid RunId { get; }
    }
}
