// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core.Expressions.DataFactory;

namespace Azure.ResourceManager.DataFactory.Models
{
    /// <summary> Azure Data Lake Storage Gen2 linked service. </summary>
    public partial class AzureBlobFSLinkedService : DataFactoryLinkedServiceDefinition
    {
        /// <summary> Initializes a new instance of AzureBlobFSLinkedService. </summary>
        public AzureBlobFSLinkedService()
        {
            LinkedServiceType = "AzureBlobFS";
        }

        /// <summary> Initializes a new instance of AzureBlobFSLinkedService. </summary>
        /// <param name="linkedServiceType"> Type of linked service. </param>
        /// <param name="connectVia"> The integration runtime reference. </param>
        /// <param name="description"> Linked service description. </param>
        /// <param name="parameters"> Parameters for linked service. </param>
        /// <param name="annotations"> List of tags that can be used for describing the linked service. </param>
        /// <param name="additionalProperties"> Additional Properties. </param>
        /// <param name="uri"> Endpoint for the Azure Data Lake Storage Gen2 service. Type: string (or Expression with resultType string). </param>
        /// <param name="accountKey"> Account key for the Azure Data Lake Storage Gen2 service. Type: string (or Expression with resultType string). </param>
        /// <param name="servicePrincipalId"> The ID of the application used to authenticate against the Azure Data Lake Storage Gen2 account. Type: string (or Expression with resultType string). </param>
        /// <param name="servicePrincipalKey"> The Key of the application used to authenticate against the Azure Data Lake Storage Gen2 account. </param>
        /// <param name="tenant"> The name or ID of the tenant to which the service principal belongs. Type: string (or Expression with resultType string). </param>
        /// <param name="azureCloudType"> Indicates the azure cloud type of the service principle auth. Allowed values are AzurePublic, AzureChina, AzureUsGovernment, AzureGermany. Default value is the data factory regions’ cloud type. Type: string (or Expression with resultType string). </param>
        /// <param name="encryptedCredential"> The encrypted credential used for authentication. Credentials are encrypted using the integration runtime credential manager. Type: string. </param>
        /// <param name="credential"> The credential reference containing authentication information. </param>
        /// <param name="servicePrincipalCredentialType"> The service principal credential type to use in Server-To-Server authentication. 'ServicePrincipalKey' for key/secret, 'ServicePrincipalCert' for certificate. Type: string (or Expression with resultType string). </param>
        /// <param name="servicePrincipalCredential"> The credential of the service principal object in Azure Active Directory. If servicePrincipalCredentialType is 'ServicePrincipalKey', servicePrincipalCredential can be SecureString or AzureKeyVaultSecretReference. If servicePrincipalCredentialType is 'ServicePrincipalCert', servicePrincipalCredential can only be AzureKeyVaultSecretReference. </param>
        /// <param name="sasUri"> SAS URI of the Azure Data Lake Storage Gen2 service. Type: string, SecureString or AzureKeyVaultSecretReference. </param>
        /// <param name="sasToken"> The Azure key vault secret reference of sasToken in sas uri. </param>
        internal AzureBlobFSLinkedService(string linkedServiceType, IntegrationRuntimeReference connectVia, string description, IDictionary<string, EntityParameterSpecification> parameters, IList<BinaryData> annotations, IDictionary<string, BinaryData> additionalProperties, DataFactoryElement<string> uri, DataFactoryElement<string> accountKey, DataFactoryElement<string> servicePrincipalId, DataFactorySecretBaseDefinition servicePrincipalKey, DataFactoryElement<string> tenant, DataFactoryElement<string> azureCloudType, BinaryData encryptedCredential, DataFactoryCredentialReference credential, DataFactoryElement<string> servicePrincipalCredentialType, DataFactorySecretBaseDefinition servicePrincipalCredential, DataFactoryElement<string> sasUri, DataFactorySecretBaseDefinition sasToken) : base(linkedServiceType, connectVia, description, parameters, annotations, additionalProperties)
        {
            Uri = uri;
            AccountKey = accountKey;
            ServicePrincipalId = servicePrincipalId;
            ServicePrincipalKey = servicePrincipalKey;
            Tenant = tenant;
            AzureCloudType = azureCloudType;
            EncryptedCredential = encryptedCredential;
            Credential = credential;
            ServicePrincipalCredentialType = servicePrincipalCredentialType;
            ServicePrincipalCredential = servicePrincipalCredential;
            SasUri = sasUri;
            SasToken = sasToken;
            LinkedServiceType = linkedServiceType ?? "AzureBlobFS";
        }

        /// <summary> Endpoint for the Azure Data Lake Storage Gen2 service. Type: string (or Expression with resultType string). </summary>
        public DataFactoryElement<string> Uri { get; set; }
        /// <summary> Account key for the Azure Data Lake Storage Gen2 service. Type: string (or Expression with resultType string). </summary>
        public DataFactoryElement<string> AccountKey { get; set; }
        /// <summary> The ID of the application used to authenticate against the Azure Data Lake Storage Gen2 account. Type: string (or Expression with resultType string). </summary>
        public DataFactoryElement<string> ServicePrincipalId { get; set; }
        /// <summary> The Key of the application used to authenticate against the Azure Data Lake Storage Gen2 account. </summary>
        public DataFactorySecretBaseDefinition ServicePrincipalKey { get; set; }
        /// <summary> The name or ID of the tenant to which the service principal belongs. Type: string (or Expression with resultType string). </summary>
        public DataFactoryElement<string> Tenant { get; set; }
        /// <summary> Indicates the azure cloud type of the service principle auth. Allowed values are AzurePublic, AzureChina, AzureUsGovernment, AzureGermany. Default value is the data factory regions’ cloud type. Type: string (or Expression with resultType string). </summary>
        public DataFactoryElement<string> AzureCloudType { get; set; }
        /// <summary>
        /// The encrypted credential used for authentication. Credentials are encrypted using the integration runtime credential manager. Type: string.
        /// <para>
        /// To assign an object to this property use <see cref="BinaryData.FromObjectAsJson{T}(T, System.Text.Json.JsonSerializerOptions?)"/>.
        /// </para>
        /// <para>
        /// To assign an already formated json string to this property use <see cref="BinaryData.FromString(string)"/>.
        /// </para>
        /// <para>
        /// Examples:
        /// <list type="bullet">
        /// <item>
        /// <term>BinaryData.FromObjectAsJson("foo")</term>
        /// <description>Creates a payload of "foo".</description>
        /// </item>
        /// <item>
        /// <term>BinaryData.FromString("\"foo\"")</term>
        /// <description>Creates a payload of "foo".</description>
        /// </item>
        /// <item>
        /// <term>BinaryData.FromObjectAsJson(new { key = "value" })</term>
        /// <description>Creates a payload of { "key": "value" }.</description>
        /// </item>
        /// <item>
        /// <term>BinaryData.FromString("{\"key\": \"value\"}")</term>
        /// <description>Creates a payload of { "key": "value" }.</description>
        /// </item>
        /// </list>
        /// </para>
        /// </summary>
        public BinaryData EncryptedCredential { get; set; }
        /// <summary> The credential reference containing authentication information. </summary>
        public DataFactoryCredentialReference Credential { get; set; }
        /// <summary> The service principal credential type to use in Server-To-Server authentication. 'ServicePrincipalKey' for key/secret, 'ServicePrincipalCert' for certificate. Type: string (or Expression with resultType string). </summary>
        public DataFactoryElement<string> ServicePrincipalCredentialType { get; set; }
        /// <summary> The credential of the service principal object in Azure Active Directory. If servicePrincipalCredentialType is 'ServicePrincipalKey', servicePrincipalCredential can be SecureString or AzureKeyVaultSecretReference. If servicePrincipalCredentialType is 'ServicePrincipalCert', servicePrincipalCredential can only be AzureKeyVaultSecretReference. </summary>
        public DataFactorySecretBaseDefinition ServicePrincipalCredential { get; set; }
        /// <summary> SAS URI of the Azure Data Lake Storage Gen2 service. Type: string, SecureString or AzureKeyVaultSecretReference. </summary>
        public DataFactoryElement<string> SasUri { get; set; }
        /// <summary> The Azure key vault secret reference of sasToken in sas uri. </summary>
        public DataFactorySecretBaseDefinition SasToken { get; set; }
    }
}
