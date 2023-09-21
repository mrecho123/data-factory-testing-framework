// <auto-generated/>

#nullable disable

using Azure.Core;
using Azure.Core.Expressions.DataFactory;

namespace AzureDataFactory.TestingFramework.Models
{
    /// <summary> Impala server linked service. </summary>
    public partial class ImpalaLinkedService : DataFactoryLinkedServiceProperties
    {
        /// <summary> Initializes a new instance of ImpalaLinkedService. </summary>
        /// <param name="host"> The IP address or host name of the Impala server. (i.e. 192.168.222.160). </param>
        /// <param name="authenticationType"> The authentication type to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="host"/> is null. </exception>
        public ImpalaLinkedService(DataFactoryElement<string> host, ImpalaAuthenticationType authenticationType)
        {
            Argument.AssertNotNull(host, nameof(host));

            Host = host;
            AuthenticationType = authenticationType;
            LinkedServiceType = "Impala";
        }

        /// <summary> Initializes a new instance of ImpalaLinkedService. </summary>
        /// <param name="linkedServiceType"> Type of linked service. </param>
        /// <param name="connectVia"> The integration runtime reference. </param>
        /// <param name="description"> Linked service description. </param>
        /// <param name="parameters"> Parameters for linked service. </param>
        /// <param name="annotations"> List of tags that can be used for describing the linked service. </param>
        /// <param name="additionalProperties"> Additional Properties. </param>
        /// <param name="host"> The IP address or host name of the Impala server. (i.e. 192.168.222.160). </param>
        /// <param name="port"> The TCP port that the Impala server uses to listen for client connections. The default value is 21050. </param>
        /// <param name="authenticationType"> The authentication type to use. </param>
        /// <param name="username"> The user name used to access the Impala server. The default value is anonymous when using SASLUsername. </param>
        /// <param name="password"> The password corresponding to the user name when using UsernameAndPassword. </param>
        /// <param name="enableSsl"> Specifies whether the connections to the server are encrypted using SSL. The default value is false. </param>
        /// <param name="trustedCertPath"> The full path of the .pem file containing trusted CA certificates for verifying the server when connecting over SSL. This property can only be set when using SSL on self-hosted IR. The default value is the cacerts.pem file installed with the IR. </param>
        /// <param name="useSystemTrustStore"> Specifies whether to use a CA certificate from the system trust store or from a specified PEM file. The default value is false. </param>
        /// <param name="allowHostNameCNMismatch"> Specifies whether to require a CA-issued SSL certificate name to match the host name of the server when connecting over SSL. The default value is false. </param>
        /// <param name="allowSelfSignedServerCert"> Specifies whether to allow self-signed certificates from the server. The default value is false. </param>
        /// <param name="encryptedCredential"> The encrypted credential used for authentication. Credentials are encrypted using the integration runtime credential manager. Type: string. </param>
        internal ImpalaLinkedService(string linkedServiceType, IntegrationRuntimeReference connectVia, string description, IDictionary<string, EntityParameterSpecification> parameters, IList<BinaryData> annotations, IDictionary<string, DataFactoryElement<string>> additionalProperties, DataFactoryElement<string> host, DataFactoryElement<int> port, ImpalaAuthenticationType authenticationType, DataFactoryElement<string> username, DataFactorySecretBaseDefinition password, DataFactoryElement<bool> enableSsl, DataFactoryElement<string> trustedCertPath, DataFactoryElement<bool> useSystemTrustStore, DataFactoryElement<bool> allowHostNameCNMismatch, DataFactoryElement<bool> allowSelfSignedServerCert, string encryptedCredential) : base(linkedServiceType, connectVia, description, parameters, annotations, additionalProperties)
        {
            Host = host;
            Port = port;
            AuthenticationType = authenticationType;
            Username = username;
            Password = password;
            EnableSsl = enableSsl;
            TrustedCertPath = trustedCertPath;
            UseSystemTrustStore = useSystemTrustStore;
            AllowHostNameCNMismatch = allowHostNameCNMismatch;
            AllowSelfSignedServerCert = allowSelfSignedServerCert;
            EncryptedCredential = encryptedCredential;
            LinkedServiceType = linkedServiceType ?? "Impala";
        }

        /// <summary> The IP address or host name of the Impala server. (i.e. 192.168.222.160). </summary>
        public DataFactoryElement<string> Host { get; set; }
        /// <summary> The TCP port that the Impala server uses to listen for client connections. The default value is 21050. </summary>
        public DataFactoryElement<int> Port { get; set; }
        /// <summary> The authentication type to use. </summary>
        public ImpalaAuthenticationType AuthenticationType { get; set; }
        /// <summary> The user name used to access the Impala server. The default value is anonymous when using SASLUsername. </summary>
        public DataFactoryElement<string> Username { get; set; }
        /// <summary> The password corresponding to the user name when using UsernameAndPassword. </summary>
        public DataFactorySecretBaseDefinition Password { get; set; }
        /// <summary> Specifies whether the connections to the server are encrypted using SSL. The default value is false. </summary>
        public DataFactoryElement<bool> EnableSsl { get; set; }
        /// <summary> The full path of the .pem file containing trusted CA certificates for verifying the server when connecting over SSL. This property can only be set when using SSL on self-hosted IR. The default value is the cacerts.pem file installed with the IR. </summary>
        public DataFactoryElement<string> TrustedCertPath { get; set; }
        /// <summary> Specifies whether to use a CA certificate from the system trust store or from a specified PEM file. The default value is false. </summary>
        public DataFactoryElement<bool> UseSystemTrustStore { get; set; }
        /// <summary> Specifies whether to require a CA-issued SSL certificate name to match the host name of the server when connecting over SSL. The default value is false. </summary>
        public DataFactoryElement<bool> AllowHostNameCNMismatch { get; set; }
        /// <summary> Specifies whether to allow self-signed certificates from the server. The default value is false. </summary>
        public DataFactoryElement<bool> AllowSelfSignedServerCert { get; set; }
        /// <summary> The encrypted credential used for authentication. Credentials are encrypted using the integration runtime credential manager. Type: string. </summary>
        public string EncryptedCredential { get; set; }
    }
}
