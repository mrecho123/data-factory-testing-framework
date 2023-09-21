// <auto-generated/>

#nullable disable

using Azure.Core;
using Azure.Core.Expressions.DataFactory;

namespace AzureDataFactory.TestingFramework.Models
{
    /// <summary> Web linked service. </summary>
    public partial class WebLinkedService : DataFactoryLinkedServiceProperties
    {
        /// <summary> Initializes a new instance of WebLinkedService. </summary>
        /// <param name="typeProperties">
        /// Web linked service properties.
        /// Please note <see cref="WebLinkedServiceTypeProperties"/> is the base class. According to the scenario, a derived class of the base class might need to be assigned here, or this property needs to be casted to one of the possible derived classes.
        /// The available derived classes include <see cref="WebAnonymousAuthentication"/>, <see cref="WebBasicAuthentication"/> and <see cref="WebClientCertificateAuthentication"/>.
        /// </param>
        /// <exception cref="ArgumentNullException"> <paramref name="typeProperties"/> is null. </exception>
        public WebLinkedService(WebLinkedServiceTypeProperties typeProperties)
        {
            Argument.AssertNotNull(typeProperties, nameof(typeProperties));

            TypeProperties = typeProperties;
            LinkedServiceType = "Web";
        }

        /// <summary> Initializes a new instance of WebLinkedService. </summary>
        /// <param name="linkedServiceType"> Type of linked service. </param>
        /// <param name="connectVia"> The integration runtime reference. </param>
        /// <param name="description"> Linked service description. </param>
        /// <param name="parameters"> Parameters for linked service. </param>
        /// <param name="annotations"> List of tags that can be used for describing the linked service. </param>
        /// <param name="additionalProperties"> Additional Properties. </param>
        /// <param name="typeProperties">
        /// Web linked service properties.
        /// Please note <see cref="WebLinkedServiceTypeProperties"/> is the base class. According to the scenario, a derived class of the base class might need to be assigned here, or this property needs to be casted to one of the possible derived classes.
        /// The available derived classes include <see cref="WebAnonymousAuthentication"/>, <see cref="WebBasicAuthentication"/> and <see cref="WebClientCertificateAuthentication"/>.
        /// </param>
        internal WebLinkedService(string linkedServiceType, IntegrationRuntimeReference connectVia, string description, IDictionary<string, EntityParameterSpecification> parameters, IList<BinaryData> annotations, IDictionary<string, DataFactoryElement<string>> additionalProperties, WebLinkedServiceTypeProperties typeProperties) : base(linkedServiceType, connectVia, description, parameters, annotations, additionalProperties)
        {
            TypeProperties = typeProperties;
            LinkedServiceType = linkedServiceType ?? "Web";
        }

        /// <summary>
        /// Web linked service properties.
        /// Please note <see cref="WebLinkedServiceTypeProperties"/> is the base class. According to the scenario, a derived class of the base class might need to be assigned here, or this property needs to be casted to one of the possible derived classes.
        /// The available derived classes include <see cref="WebAnonymousAuthentication"/>, <see cref="WebBasicAuthentication"/> and <see cref="WebClientCertificateAuthentication"/>.
        /// </summary>
        public WebLinkedServiceTypeProperties TypeProperties { get; set; }
    }
}
