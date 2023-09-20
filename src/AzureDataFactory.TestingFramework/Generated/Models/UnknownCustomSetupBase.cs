// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace AzureDataFactory.TestingFramework.Models
{
    /// <summary> The UnknownCustomSetupBase. </summary>
    internal partial class UnknownCustomSetupBase : CustomSetupBase
    {
        /// <summary> Initializes a new instance of UnknownCustomSetupBase. </summary>
        /// <param name="customSetupBaseType"> The type of custom setup. </param>
        internal UnknownCustomSetupBase(string customSetupBaseType) : base(customSetupBaseType)
        {
            CustomSetupBaseType = customSetupBaseType ?? "Unknown";
        }
    }
}