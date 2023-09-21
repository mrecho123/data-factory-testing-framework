// <auto-generated/>

#nullable disable

using Azure.Core;
using Azure.Core.Expressions.DataFactory;

namespace AzureDataFactory.TestingFramework.Models
{
    /// <summary> Linked service for Amazon Redshift. </summary>
    public partial class AmazonRedshiftLinkedService : DataFactoryLinkedServiceProperties
    {
        /// <summary> Initializes a new instance of AmazonRedshiftLinkedService. </summary>
        /// <param name="server"> The name of the Amazon Redshift server. Type: string (or Expression with resultType string). </param>
        /// <param name="database"> The database name of the Amazon Redshift source. Type: string (or Expression with resultType string). </param>
        /// <exception cref="ArgumentNullException"> <paramref name="server"/> or <paramref name="database"/> is null. </exception>
        public AmazonRedshiftLinkedService(DataFactoryElement<string> server, DataFactoryElement<string> database)
        {
            Argument.AssertNotNull(server, nameof(server));
            Argument.AssertNotNull(database, nameof(database));

            Server = server;
            Database = database;
            LinkedServiceType = "AmazonRedshift";
        }

        /// <summary> Initializes a new instance of AmazonRedshiftLinkedService. </summary>
        /// <param name="linkedServiceType"> Type of linked service. </param>
        /// <param name="connectVia"> The integration runtime reference. </param>
        /// <param name="description"> Linked service description. </param>
        /// <param name="parameters"> Parameters for linked service. </param>
        /// <param name="annotations"> List of tags that can be used for describing the linked service. </param>
        /// <param name="additionalProperties"> Additional Properties. </param>
        /// <param name="server"> The name of the Amazon Redshift server. Type: string (or Expression with resultType string). </param>
        /// <param name="username"> The username of the Amazon Redshift source. Type: string (or Expression with resultType string). </param>
        /// <param name="password"> The password of the Amazon Redshift source. </param>
        /// <param name="database"> The database name of the Amazon Redshift source. Type: string (or Expression with resultType string). </param>
        /// <param name="port"> The TCP port number that the Amazon Redshift server uses to listen for client connections. The default value is 5439. Type: integer (or Expression with resultType integer). </param>
        /// <param name="encryptedCredential"> The encrypted credential used for authentication. Credentials are encrypted using the integration runtime credential manager. Type: string. </param>
        internal AmazonRedshiftLinkedService(string linkedServiceType, IntegrationRuntimeReference connectVia, string description, IDictionary<string, EntityParameterSpecification> parameters, IList<BinaryData> annotations, IDictionary<string, DataFactoryElement<string>> additionalProperties, DataFactoryElement<string> server, DataFactoryElement<string> username, DataFactorySecretBaseDefinition password, DataFactoryElement<string> database, DataFactoryElement<int> port, string encryptedCredential) : base(linkedServiceType, connectVia, description, parameters, annotations, additionalProperties)
        {
            Server = server;
            Username = username;
            Password = password;
            Database = database;
            Port = port;
            EncryptedCredential = encryptedCredential;
            LinkedServiceType = linkedServiceType ?? "AmazonRedshift";
        }

        /// <summary> The name of the Amazon Redshift server. Type: string (or Expression with resultType string). </summary>
        public DataFactoryElement<string> Server { get; set; }
        /// <summary> The username of the Amazon Redshift source. Type: string (or Expression with resultType string). </summary>
        public DataFactoryElement<string> Username { get; set; }
        /// <summary> The password of the Amazon Redshift source. </summary>
        public DataFactorySecretBaseDefinition Password { get; set; }
        /// <summary> The database name of the Amazon Redshift source. Type: string (or Expression with resultType string). </summary>
        public DataFactoryElement<string> Database { get; set; }
        /// <summary> The TCP port number that the Amazon Redshift server uses to listen for client connections. The default value is 5439. Type: integer (or Expression with resultType integer). </summary>
        public DataFactoryElement<int> Port { get; set; }
        /// <summary> The encrypted credential used for authentication. Credentials are encrypted using the integration runtime credential manager. Type: string. </summary>
        public string EncryptedCredential { get; set; }
    }
}
