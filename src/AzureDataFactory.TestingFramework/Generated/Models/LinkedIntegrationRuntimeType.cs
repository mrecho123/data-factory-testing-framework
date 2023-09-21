// <auto-generated/>

#nullable disable

namespace AzureDataFactory.TestingFramework.Models
{
    /// <summary>
    /// The base definition of a linked integration runtime.
    /// Please note <see cref="LinkedIntegrationRuntimeType"/> is the base class. According to the scenario, a derived class of the base class might need to be assigned here, or this property needs to be casted to one of the possible derived classes.
    /// The available derived classes include <see cref="LinkedIntegrationRuntimeKeyAuthorization"/> and <see cref="LinkedIntegrationRuntimeRbacAuthorization"/>.
    /// </summary>
    public abstract partial class LinkedIntegrationRuntimeType
    {
        /// <summary> Initializes a new instance of LinkedIntegrationRuntimeType. </summary>
        protected LinkedIntegrationRuntimeType()
        {
        }

        /// <summary> Initializes a new instance of LinkedIntegrationRuntimeType. </summary>
        /// <param name="authorizationType"> The authorization type for integration runtime sharing. </param>
        internal LinkedIntegrationRuntimeType(string authorizationType)
        {
            AuthorizationType = authorizationType;
        }

        /// <summary> The authorization type for integration runtime sharing. </summary>
        internal string AuthorizationType { get; set; }
    }
}
