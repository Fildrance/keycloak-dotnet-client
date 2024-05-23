using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading;
using System.Text;
using System.Threading.Tasks;
using System.CodeDom.Compiler;
using Keycloak.Client.Models;

namespace Keycloak.Client.Clients
{
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    [GeneratedCode("swagger-codegen", "3.0.56-SNAPSHOT")]
    public partial interface IClientAttributeCertificateApi
    {
        /// <summary>
        ///  Get key info
        /// </summary>
        /// <param name="realm">realm name (not id!)</param>
        /// <param name="id"></param>
        /// <param name="attr"></param>
        /// <param name="ct"></param>
        /// <returns>CertificateRepresentation</returns>
        Task<CertificateRepresentation> GetCertificate (string realm, string id, string attr, CancellationToken ct);
        /// <summary>
        ///  Get a keystore file for the client, containing private key and public certificate
        /// </summary>
        /// <param name="realm">realm name (not id!)</param>
        /// <param name="id"></param>
        /// <param name="attr"></param>
        /// <param name="body">KeyStoreConfig</param>
        /// <param name="ct"></param>
        /// <returns>byte[]</returns>
        Task<byte[]> PostDownload (string realm, string id, string attr, KeyStoreConfig body, CancellationToken ct);
        /// <summary>
        ///  Generate a new certificate with new key pair
        /// </summary>
        /// <param name="realm">realm name (not id!)</param>
        /// <param name="id"></param>
        /// <param name="attr"></param>
        /// <param name="ct"></param>
        /// <returns>CertificateRepresentation</returns>
        Task<CertificateRepresentation> PostGenerate (string realm, string id, string attr, CancellationToken ct);
        /// <summary>
        ///  Generate a new keypair and certificate, and get the private key file  Generates a keypair and certificate and serves the private key in a specified keystore format. Only generated public certificate is saved in Keycloak DB - the private key is not.
        /// </summary>
        /// <param name="realm">realm name (not id!)</param>
        /// <param name="id"></param>
        /// <param name="attr"></param>
        /// <param name="body">KeyStoreConfig</param>
        /// <param name="ct"></param>
        /// <returns>byte[]</returns>
        Task<byte[]> PostGenerateAndDownload (string realm, string id, string attr, KeyStoreConfig body, CancellationToken ct);
        /// <summary>
        ///  Upload certificate and eventually private key
        /// </summary>
        /// <param name="realm">realm name (not id!)</param>
        /// <param name="id"></param>
        /// <param name="attr"></param>
        /// <param name="ct"></param>
        /// <returns>CertificateRepresentation</returns>
        Task<CertificateRepresentation> PostUpload (string realm, string id, string attr, CancellationToken ct);
        /// <summary>
        ///  Upload only certificate, not private key
        /// </summary>
        /// <param name="realm">realm name (not id!)</param>
        /// <param name="id"></param>
        /// <param name="attr"></param>
        /// <param name="ct"></param>
        /// <returns>CertificateRepresentation</returns>
        Task<CertificateRepresentation> PostUploadCertificate (string realm, string id, string attr, CancellationToken ct);
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>  
    [GeneratedCode("swagger-codegen", "3.0.56-SNAPSHOT")]
    public partial class ClientAttributeCertificateApi : KeycloakClientApiClientBase, IClientAttributeCertificateApi
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ClientAttributeCertificateApi"/> class.
        /// </summary>
        /// <param name="httpClient"> HttpClient to be used for calls. </param>
        /// <param name="basePath"> Base url to be used for calls. </param>
        public ClientAttributeCertificateApi(HttpClient httpClient, String basePath="https://keycloak.example.com/admin/realms") : base(httpClient, basePath)
        {
        }

        /// <inheritdoc />     
        public async Task<CertificateRepresentation> GetCertificate(string realm, string id, string attr, CancellationToken ct)
        {
            // verify the required parameter 'realm' is set
            if (realm == null) throw new KeycloakClientApiException(400, "Missing required parameter 'realm' when calling GetCertificate");
            // verify the required parameter 'id' is set
            if (id == null) throw new KeycloakClientApiException(400, "Missing required parameter 'id' when calling GetCertificate");
            // verify the required parameter 'attr' is set
            if (attr == null) throw new KeycloakClientApiException(400, "Missing required parameter 'attr' when calling GetCertificate");
            
            var path_ = new StringBuilder("/{realm}/clients/{id}/certificates/{attr}"); 
            path_ = path_.Replace("{realm}", ParameterToString(realm));
            path_ = path_.Replace("{id}", ParameterToString(id));
            path_ = path_.Replace("{attr}", ParameterToString(attr));

            
        
            var response = await CallApi<CertificateRepresentation>(
                        path_.ToString(), 
                        HttpMethod.Get,  
                        ct: ct
            );
            return response;
        }

        /// <inheritdoc />     
        public async Task<byte[]> PostDownload(string realm, string id, string attr, KeyStoreConfig body, CancellationToken ct)
        {
            // verify the required parameter 'realm' is set
            if (realm == null) throw new KeycloakClientApiException(400, "Missing required parameter 'realm' when calling PostDownload");
            // verify the required parameter 'id' is set
            if (id == null) throw new KeycloakClientApiException(400, "Missing required parameter 'id' when calling PostDownload");
            // verify the required parameter 'attr' is set
            if (attr == null) throw new KeycloakClientApiException(400, "Missing required parameter 'attr' when calling PostDownload");
            
            var path_ = new StringBuilder("/{realm}/clients/{id}/certificates/{attr}/download"); 
            path_ = path_.Replace("{realm}", ParameterToString(realm));
            path_ = path_.Replace("{id}", ParameterToString(id));
            path_ = path_.Replace("{attr}", ParameterToString(attr));

            
        
            var response = await CallApi<byte[]>(
                        path_.ToString(), 
                        HttpMethod.Post,
                        body: body,   
                        ct: ct
            );
            return response;
        }

        /// <inheritdoc />     
        public async Task<CertificateRepresentation> PostGenerate(string realm, string id, string attr, CancellationToken ct)
        {
            // verify the required parameter 'realm' is set
            if (realm == null) throw new KeycloakClientApiException(400, "Missing required parameter 'realm' when calling PostGenerate");
            // verify the required parameter 'id' is set
            if (id == null) throw new KeycloakClientApiException(400, "Missing required parameter 'id' when calling PostGenerate");
            // verify the required parameter 'attr' is set
            if (attr == null) throw new KeycloakClientApiException(400, "Missing required parameter 'attr' when calling PostGenerate");
            
            var path_ = new StringBuilder("/{realm}/clients/{id}/certificates/{attr}/generate"); 
            path_ = path_.Replace("{realm}", ParameterToString(realm));
            path_ = path_.Replace("{id}", ParameterToString(id));
            path_ = path_.Replace("{attr}", ParameterToString(attr));

            
        
            var response = await CallApi<CertificateRepresentation>(
                        path_.ToString(), 
                        HttpMethod.Post,  
                        ct: ct
            );
            return response;
        }

        /// <inheritdoc />     
        public async Task<byte[]> PostGenerateAndDownload(string realm, string id, string attr, KeyStoreConfig body, CancellationToken ct)
        {
            // verify the required parameter 'realm' is set
            if (realm == null) throw new KeycloakClientApiException(400, "Missing required parameter 'realm' when calling PostGenerateAndDownload");
            // verify the required parameter 'id' is set
            if (id == null) throw new KeycloakClientApiException(400, "Missing required parameter 'id' when calling PostGenerateAndDownload");
            // verify the required parameter 'attr' is set
            if (attr == null) throw new KeycloakClientApiException(400, "Missing required parameter 'attr' when calling PostGenerateAndDownload");
            
            var path_ = new StringBuilder("/{realm}/clients/{id}/certificates/{attr}/generate-and-download"); 
            path_ = path_.Replace("{realm}", ParameterToString(realm));
            path_ = path_.Replace("{id}", ParameterToString(id));
            path_ = path_.Replace("{attr}", ParameterToString(attr));

            
        
            var response = await CallApi<byte[]>(
                        path_.ToString(), 
                        HttpMethod.Post,
                        body: body,   
                        ct: ct
            );
            return response;
        }

        /// <inheritdoc />     
        public async Task<CertificateRepresentation> PostUpload(string realm, string id, string attr, CancellationToken ct)
        {
            // verify the required parameter 'realm' is set
            if (realm == null) throw new KeycloakClientApiException(400, "Missing required parameter 'realm' when calling PostUpload");
            // verify the required parameter 'id' is set
            if (id == null) throw new KeycloakClientApiException(400, "Missing required parameter 'id' when calling PostUpload");
            // verify the required parameter 'attr' is set
            if (attr == null) throw new KeycloakClientApiException(400, "Missing required parameter 'attr' when calling PostUpload");
            
            var path_ = new StringBuilder("/{realm}/clients/{id}/certificates/{attr}/upload"); 
            path_ = path_.Replace("{realm}", ParameterToString(realm));
            path_ = path_.Replace("{id}", ParameterToString(id));
            path_ = path_.Replace("{attr}", ParameterToString(attr));

            
        
            var response = await CallApi<CertificateRepresentation>(
                        path_.ToString(), 
                        HttpMethod.Post,  
                        ct: ct
            );
            return response;
        }

        /// <inheritdoc />     
        public async Task<CertificateRepresentation> PostUploadCertificate(string realm, string id, string attr, CancellationToken ct)
        {
            // verify the required parameter 'realm' is set
            if (realm == null) throw new KeycloakClientApiException(400, "Missing required parameter 'realm' when calling PostUploadCertificate");
            // verify the required parameter 'id' is set
            if (id == null) throw new KeycloakClientApiException(400, "Missing required parameter 'id' when calling PostUploadCertificate");
            // verify the required parameter 'attr' is set
            if (attr == null) throw new KeycloakClientApiException(400, "Missing required parameter 'attr' when calling PostUploadCertificate");
            
            var path_ = new StringBuilder("/{realm}/clients/{id}/certificates/{attr}/upload-certificate"); 
            path_ = path_.Replace("{realm}", ParameterToString(realm));
            path_ = path_.Replace("{id}", ParameterToString(id));
            path_ = path_.Replace("{attr}", ParameterToString(attr));

            
        
            var response = await CallApi<CertificateRepresentation>(
                        path_.ToString(), 
                        HttpMethod.Post,  
                        ct: ct
            );
            return response;
        }

    }
}