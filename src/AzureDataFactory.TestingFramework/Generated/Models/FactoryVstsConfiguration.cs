// <auto-generated/>

#nullable disable

using Azure.Core;

namespace AzureDataFactory.TestingFramework.Models
{
    /// <summary> Factory's VSTS repo information. </summary>
    public partial class FactoryVstsConfiguration : FactoryRepoConfiguration
    {
        /// <summary> Initializes a new instance of FactoryVstsConfiguration. </summary>
        /// <param name="accountName"> Account name. </param>
        /// <param name="repositoryName"> Repository name. </param>
        /// <param name="collaborationBranch"> Collaboration branch. </param>
        /// <param name="rootFolder"> Root folder. </param>
        /// <param name="projectName"> VSTS project name. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="accountName"/>, <paramref name="repositoryName"/>, <paramref name="collaborationBranch"/>, <paramref name="rootFolder"/> or <paramref name="projectName"/> is null. </exception>
        public FactoryVstsConfiguration(string accountName, string repositoryName, string collaborationBranch, string rootFolder, string projectName) : base(accountName, repositoryName, collaborationBranch, rootFolder)
        {
            Argument.AssertNotNull(accountName, nameof(accountName));
            Argument.AssertNotNull(repositoryName, nameof(repositoryName));
            Argument.AssertNotNull(collaborationBranch, nameof(collaborationBranch));
            Argument.AssertNotNull(rootFolder, nameof(rootFolder));
            Argument.AssertNotNull(projectName, nameof(projectName));

            ProjectName = projectName;
            FactoryRepoConfigurationType = "FactoryVSTSConfiguration";
        }

        /// <summary> Initializes a new instance of FactoryVstsConfiguration. </summary>
        /// <param name="factoryRepoConfigurationType"> Type of repo configuration. </param>
        /// <param name="accountName"> Account name. </param>
        /// <param name="repositoryName"> Repository name. </param>
        /// <param name="collaborationBranch"> Collaboration branch. </param>
        /// <param name="rootFolder"> Root folder. </param>
        /// <param name="lastCommitId"> Last commit id. </param>
        /// <param name="disablePublish"> Disable manual publish operation in ADF studio to favor automated publish. </param>
        /// <param name="projectName"> VSTS project name. </param>
        /// <param name="tenantId"> VSTS tenant id. </param>
        internal FactoryVstsConfiguration(string factoryRepoConfigurationType, string accountName, string repositoryName, string collaborationBranch, string rootFolder, string lastCommitId, bool? disablePublish, string projectName, Guid? tenantId) : base(factoryRepoConfigurationType, accountName, repositoryName, collaborationBranch, rootFolder, lastCommitId, disablePublish)
        {
            ProjectName = projectName;
            TenantId = tenantId;
            FactoryRepoConfigurationType = factoryRepoConfigurationType ?? "FactoryVSTSConfiguration";
        }

        /// <summary> VSTS project name. </summary>
        public string ProjectName { get; set; }
        /// <summary> VSTS tenant id. </summary>
        public Guid? TenantId { get; set; }
    }
}
