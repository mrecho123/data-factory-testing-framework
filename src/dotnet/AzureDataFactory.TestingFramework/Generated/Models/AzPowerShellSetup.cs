// <auto-generated/>

#nullable disable

using Azure.Core;

namespace AzureDataFactory.TestingFramework.Models
{
    /// <summary> The express custom setup of installing Azure PowerShell. </summary>
    public partial class AzPowerShellSetup : CustomSetupBase
    {
        /// <summary> Initializes a new instance of AzPowerShellSetup. </summary>
        /// <param name="version"> The required version of Azure PowerShell to install. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="version"/> is null. </exception>
        public AzPowerShellSetup(string version)
        {
            Argument.AssertNotNull(version, nameof(version));

            Version = version;
            CustomSetupBaseType = "AzPowerShellSetup";
        }

        /// <summary> Initializes a new instance of AzPowerShellSetup. </summary>
        /// <param name="customSetupBaseType"> The type of custom setup. </param>
        /// <param name="version"> The required version of Azure PowerShell to install. </param>
        internal AzPowerShellSetup(string customSetupBaseType, string version) : base(customSetupBaseType)
        {
            Version = version;
            CustomSetupBaseType = customSetupBaseType ?? "AzPowerShellSetup";
        }

        /// <summary> The required version of Azure PowerShell to install. </summary>
        public string Version { get; set; }
    }
}