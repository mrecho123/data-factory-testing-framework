// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using Azure.Core;
using Azure.Core.Expressions.DataFactory;

namespace AzureDataFactory.TestingFramework.Models
{
    /// <summary> Azure Data Lake Store linked service. </summary>
    public partial class AzureDataLakeStoreLinkedService : DataFactoryLinkedServiceProperties
    {
        /// <summary> Initializes a new instance of AzureDataLakeStoreLinkedService. </summary>
        /// <param name="dataLakeStoreUri"> Data Lake Store service URI. Type: string (or Expression with resultType string). </param>
        /// <exception cref="ArgumentNullException"> <paramref name="dataLakeStoreUri"/> is null. </exception>
        public AzureDataLakeStoreLinkedService(DataFactoryElement<string> dataLakeStoreUri)
        {
            Argument.AssertNotNull(dataLakeStoreUri, nameof(dataLakeStoreUri));

            DataLakeStoreUri = dataLakeStoreUri;
            LinkedServiceType = "AzureDataLakeStore";
        }

        /// <summary> Initializes a new instance of AzureDataLakeStoreLinkedService. </summary>
        /// <param name="linkedServiceType"> Type of linked service. </param>
        /// <param name="connectVia"> The integration runtime reference. </param>
        /// <param name="description"> Linked service description. </param>
        /// <param name="parameters"> Parameters for linked service. </param>
        /// <param name="annotations"> List of tags that can be used for describing the linked service. </param>
        /// <param name="additionalProperties"> Additional Properties. </param>
        /// <param name="dataLakeStoreUri"> Data Lake Store service URI. Type: string (or Expression with resultType string). </param>
        /// <param name="servicePrincipalId"> The ID of the application used to authenticate against the Azure Data Lake Store account. Type: string (or Expression with resultType string). </param>
        /// <param name="servicePrincipalKey"> The Key of the application used to authenticate against the Azure Data Lake Store account. </param>
        /// <param name="tenant"> The name or ID of the tenant to which the service principal belongs. Type: string (or Expression with resultType string). </param>
        /// <param name="azureCloudType"> Indicates the azure cloud type of the service principle auth. Allowed values are AzurePublic, AzureChina, AzureUsGovernment, AzureGermany. Default value is the data factory regions’ cloud type. Type: string (or Expression with resultType string). </param>
        /// <param name="accountName"> Data Lake Store account name. Type: string (or Expression with resultType string). </param>
        /// <param name="subscriptionId"> Data Lake Store account subscription ID (if different from Data Factory account). Type: string (or Expression with resultType string). </param>
        /// <param name="resourceGroupName"> Data Lake Store account resource group name (if different from Data Factory account). Type: string (or Expression with resultType string). </param>
        /// <param name="encryptedCredential"> The encrypted credential used for authentication. Credentials are encrypted using the integration runtime credential manager. Type: string. </param>
        /// <param name="credential"> The credential reference containing authentication information. </param>
        internal AzureDataLakeStoreLinkedService(string linkedServiceType, IntegrationRuntimeReference connectVia, string description, IDictionary<string, EntityParameterSpecification> parameters, IList<BinaryData> annotations, IDictionary<string, DataFactoryElement<string>> additionalProperties, DataFactoryElement<string> dataLakeStoreUri, DataFactoryElement<string> servicePrincipalId, DataFactorySecretBaseDefinition servicePrincipalKey, DataFactoryElement<string> tenant, DataFactoryElement<string> azureCloudType, DataFactoryElement<string> accountName, DataFactoryElement<string> subscriptionId, DataFactoryElement<string> resourceGroupName, string encryptedCredential, DataFactoryCredentialReference credential) : base(linkedServiceType, connectVia, description, parameters, annotations, additionalProperties)
        {
            DataLakeStoreUri = dataLakeStoreUri;
            ServicePrincipalId = servicePrincipalId;
            ServicePrincipalKey = servicePrincipalKey;
            Tenant = tenant;
            AzureCloudType = azureCloudType;
            AccountName = accountName;
            SubscriptionId = subscriptionId;
            ResourceGroupName = resourceGroupName;
            EncryptedCredential = encryptedCredential;
            Credential = credential;
            LinkedServiceType = linkedServiceType ?? "AzureDataLakeStore";
        }

        /// <summary> Data Lake Store service URI. Type: string (or Expression with resultType string). </summary>
        public DataFactoryElement<string> DataLakeStoreUri { get; set; }
        /// <summary> The ID of the application used to authenticate against the Azure Data Lake Store account. Type: string (or Expression with resultType string). </summary>
        public DataFactoryElement<string> ServicePrincipalId { get; set; }
        /// <summary> The Key of the application used to authenticate against the Azure Data Lake Store account. </summary>
        public DataFactorySecretBaseDefinition ServicePrincipalKey { get; set; }
        /// <summary> The name or ID of the tenant to which the service principal belongs. Type: string (or Expression with resultType string). </summary>
        public DataFactoryElement<string> Tenant { get; set; }
        /// <summary> Indicates the azure cloud type of the service principle auth. Allowed values are AzurePublic, AzureChina, AzureUsGovernment, AzureGermany. Default value is the data factory regions’ cloud type. Type: string (or Expression with resultType string). </summary>
        public DataFactoryElement<string> AzureCloudType { get; set; }
        /// <summary> Data Lake Store account name. Type: string (or Expression with resultType string). </summary>
        public DataFactoryElement<string> AccountName { get; set; }
        /// <summary> Data Lake Store account subscription ID (if different from Data Factory account). Type: string (or Expression with resultType string). </summary>
        public DataFactoryElement<string> SubscriptionId { get; set; }
        /// <summary> Data Lake Store account resource group name (if different from Data Factory account). Type: string (or Expression with resultType string). </summary>
        public DataFactoryElement<string> ResourceGroupName { get; set; }
        /// <summary> The encrypted credential used for authentication. Credentials are encrypted using the integration runtime credential manager. Type: string. </summary>
        public string EncryptedCredential { get; set; }
        /// <summary> The credential reference containing authentication information. </summary>
        public DataFactoryCredentialReference Credential { get; set; }
    }
}