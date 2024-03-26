using System;
using System.Collections.Generic;
using RestSharp;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace IO.Swagger.Api
{
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface IClientAttributeCertificateApi
    {
        /// <summary>
        ///  Get key info
        /// </summary>
        /// <param name="realm">realm name (not id!)</param>
        /// <param name="id"></param>
        /// <param name="attr"></param>
        /// <returns>CertificateRepresentation</returns>
        CertificateRepresentation GetCertificate (string realm, string id, string attr);
        /// <summary>
        ///  Get a keystore file for the client, containing private key and public certificate
        /// </summary>
        /// <param name="realm">realm name (not id!)</param>
        /// <param name="id"></param>
        /// <param name="attr"></param>
        /// <param name="body">KeyStoreConfig</param>
        /// <returns>byte[]</returns>
        byte[] PostDownload (string realm, string id, string attr, KeyStoreConfig body);
        /// <summary>
        ///  Generate a new certificate with new key pair
        /// </summary>
        /// <param name="realm">realm name (not id!)</param>
        /// <param name="id"></param>
        /// <param name="attr"></param>
        /// <returns>CertificateRepresentation</returns>
        CertificateRepresentation PostGenerate (string realm, string id, string attr);
        /// <summary>
        ///  Generate a new keypair and certificate, and get the private key file  Generates a keypair and certificate and serves the private key in a specified keystore format. Only generated public certificate is saved in Keycloak DB - the private key is not.
        /// </summary>
        /// <param name="realm">realm name (not id!)</param>
        /// <param name="id"></param>
        /// <param name="attr"></param>
        /// <param name="body">KeyStoreConfig</param>
        /// <returns>byte[]</returns>
        byte[] PostGenerateAndDownload (string realm, string id, string attr, KeyStoreConfig body);
        /// <summary>
        ///  Upload certificate and eventually private key
        /// </summary>
        /// <param name="realm">realm name (not id!)</param>
        /// <param name="id"></param>
        /// <param name="attr"></param>
        /// <returns>CertificateRepresentation</returns>
        CertificateRepresentation PostUpload (string realm, string id, string attr);
        /// <summary>
        ///  Upload only certificate, not private key
        /// </summary>
        /// <param name="realm">realm name (not id!)</param>
        /// <param name="id"></param>
        /// <param name="attr"></param>
        /// <returns>CertificateRepresentation</returns>
        CertificateRepresentation PostUploadCertificate (string realm, string id, string attr);
    }
  
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public class ClientAttributeCertificateApi : IClientAttributeCertificateApi
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ClientAttributeCertificateApi"/> class.
        /// </summary>
        /// <param name="apiClient"> an instance of ApiClient (optional)</param>
        /// <returns></returns>
        public ClientAttributeCertificateApi(ApiClient apiClient = null)
        {
            if (apiClient == null) // use the default one in Configuration
                this.ApiClient = Configuration.DefaultApiClient; 
            else
                this.ApiClient = apiClient;
        }
    
        /// <summary>
        /// Initializes a new instance of the <see cref="ClientAttributeCertificateApi"/> class.
        /// </summary>
        /// <returns></returns>
        public ClientAttributeCertificateApi(String basePath)
        {
            this.ApiClient = new ApiClient(basePath);
        }
    
        /// <summary>
        /// Sets the base path of the API client.
        /// </summary>
        /// <param name="basePath">The base path</param>
        /// <value>The base path</value>
        public void SetBasePath(String basePath)
        {
            this.ApiClient.BasePath = basePath;
        }
    
        /// <summary>
        /// Gets the base path of the API client.
        /// </summary>
        /// <param name="basePath">The base path</param>
        /// <value>The base path</value>
        public String GetBasePath(String basePath)
        {
            return this.ApiClient.BasePath;
        }
    
        /// <summary>
        /// Gets or sets the API client.
        /// </summary>
        /// <value>An instance of the ApiClient</value>
        public ApiClient ApiClient {get; set;}
    
        /// <summary>
        ///  Get key info
        /// </summary>
        /// <param name="realm">realm name (not id!)</param>
        /// <param name="id"></param>
        /// <param name="attr"></param>
        /// <returns>CertificateRepresentation</returns>
        public CertificateRepresentation GetCertificate (string realm, string id, string attr)
        {
            // verify the required parameter 'realm' is set
            if (realm == null) throw new ApiException(400, "Missing required parameter 'realm' when calling GetCertificate");
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling GetCertificate");
            // verify the required parameter 'attr' is set
            if (attr == null) throw new ApiException(400, "Missing required parameter 'attr' when calling GetCertificate");
    
            var path = "/{realm}/clients/{id}/certificates/{attr}";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "realm" + "}", ApiClient.ParameterToString(realm));
path = path.Replace("{" + "id" + "}", ApiClient.ParameterToString(id));
path = path.Replace("{" + "attr" + "}", ApiClient.ParameterToString(attr));
    
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
                                    
            // authentication setting, if any
            String[] authSettings = new String[] { "access_token" };
    
            // make the HTTP request
            RestResponseBase response = (RestResponseBase) ApiClient.CallApi(path, Method.Get, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling GetCertificate: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling GetCertificate: " + response.ErrorMessage, response.ErrorMessage);
    
            return (CertificateRepresentation) ApiClient.Deserialize(response.Content, typeof(CertificateRepresentation), response.Headers);
        }
    
        /// <summary>
        ///  Get a keystore file for the client, containing private key and public certificate
        /// </summary>
        /// <param name="realm">realm name (not id!)</param>
        /// <param name="id"></param>
        /// <param name="attr"></param>
        /// <param name="body">KeyStoreConfig</param>
        /// <returns>byte[]</returns>
        public byte[] PostDownload (string realm, string id, string attr, KeyStoreConfig body)
        {
            // verify the required parameter 'realm' is set
            if (realm == null) throw new ApiException(400, "Missing required parameter 'realm' when calling PostDownload");
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling PostDownload");
            // verify the required parameter 'attr' is set
            if (attr == null) throw new ApiException(400, "Missing required parameter 'attr' when calling PostDownload");
    
            var path = "/{realm}/clients/{id}/certificates/{attr}/download";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "realm" + "}", ApiClient.ParameterToString(realm));
path = path.Replace("{" + "id" + "}", ApiClient.ParameterToString(id));
path = path.Replace("{" + "attr" + "}", ApiClient.ParameterToString(attr));
    
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
                                    postBody = ApiClient.Serialize(body); // http body (model) parameter

            // authentication setting, if any
            String[] authSettings = new String[] { "access_token" };
    
            // make the HTTP request
            RestResponseBase response = (RestResponseBase) ApiClient.CallApi(path, Method.Post, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling PostDownload: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling PostDownload: " + response.ErrorMessage, response.ErrorMessage);
    
            return (byte[]) ApiClient.Deserialize(response.Content, typeof(byte[]), response.Headers);
        }
    
        /// <summary>
        ///  Generate a new certificate with new key pair
        /// </summary>
        /// <param name="realm">realm name (not id!)</param>
        /// <param name="id"></param>
        /// <param name="attr"></param>
        /// <returns>CertificateRepresentation</returns>
        public CertificateRepresentation PostGenerate (string realm, string id, string attr)
        {
            // verify the required parameter 'realm' is set
            if (realm == null) throw new ApiException(400, "Missing required parameter 'realm' when calling PostGenerate");
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling PostGenerate");
            // verify the required parameter 'attr' is set
            if (attr == null) throw new ApiException(400, "Missing required parameter 'attr' when calling PostGenerate");
    
            var path = "/{realm}/clients/{id}/certificates/{attr}/generate";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "realm" + "}", ApiClient.ParameterToString(realm));
path = path.Replace("{" + "id" + "}", ApiClient.ParameterToString(id));
path = path.Replace("{" + "attr" + "}", ApiClient.ParameterToString(attr));
    
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
                                    
            // authentication setting, if any
            String[] authSettings = new String[] { "access_token" };
    
            // make the HTTP request
            RestResponseBase response = (RestResponseBase) ApiClient.CallApi(path, Method.Post, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling PostGenerate: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling PostGenerate: " + response.ErrorMessage, response.ErrorMessage);
    
            return (CertificateRepresentation) ApiClient.Deserialize(response.Content, typeof(CertificateRepresentation), response.Headers);
        }
    
        /// <summary>
        ///  Generate a new keypair and certificate, and get the private key file  Generates a keypair and certificate and serves the private key in a specified keystore format. Only generated public certificate is saved in Keycloak DB - the private key is not.
        /// </summary>
        /// <param name="realm">realm name (not id!)</param>
        /// <param name="id"></param>
        /// <param name="attr"></param>
        /// <param name="body">KeyStoreConfig</param>
        /// <returns>byte[]</returns>
        public byte[] PostGenerateAndDownload (string realm, string id, string attr, KeyStoreConfig body)
        {
            // verify the required parameter 'realm' is set
            if (realm == null) throw new ApiException(400, "Missing required parameter 'realm' when calling PostGenerateAndDownload");
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling PostGenerateAndDownload");
            // verify the required parameter 'attr' is set
            if (attr == null) throw new ApiException(400, "Missing required parameter 'attr' when calling PostGenerateAndDownload");
    
            var path = "/{realm}/clients/{id}/certificates/{attr}/generate-and-download";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "realm" + "}", ApiClient.ParameterToString(realm));
path = path.Replace("{" + "id" + "}", ApiClient.ParameterToString(id));
path = path.Replace("{" + "attr" + "}", ApiClient.ParameterToString(attr));
    
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
                                    postBody = ApiClient.Serialize(body); // http body (model) parameter

            // authentication setting, if any
            String[] authSettings = new String[] { "access_token" };
    
            // make the HTTP request
            RestResponseBase response = (RestResponseBase) ApiClient.CallApi(path, Method.Post, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling PostGenerateAndDownload: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling PostGenerateAndDownload: " + response.ErrorMessage, response.ErrorMessage);
    
            return (byte[]) ApiClient.Deserialize(response.Content, typeof(byte[]), response.Headers);
        }
    
        /// <summary>
        ///  Upload certificate and eventually private key
        /// </summary>
        /// <param name="realm">realm name (not id!)</param>
        /// <param name="id"></param>
        /// <param name="attr"></param>
        /// <returns>CertificateRepresentation</returns>
        public CertificateRepresentation PostUpload (string realm, string id, string attr)
        {
            // verify the required parameter 'realm' is set
            if (realm == null) throw new ApiException(400, "Missing required parameter 'realm' when calling PostUpload");
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling PostUpload");
            // verify the required parameter 'attr' is set
            if (attr == null) throw new ApiException(400, "Missing required parameter 'attr' when calling PostUpload");
    
            var path = "/{realm}/clients/{id}/certificates/{attr}/upload";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "realm" + "}", ApiClient.ParameterToString(realm));
path = path.Replace("{" + "id" + "}", ApiClient.ParameterToString(id));
path = path.Replace("{" + "attr" + "}", ApiClient.ParameterToString(attr));
    
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
                                    
            // authentication setting, if any
            String[] authSettings = new String[] { "access_token" };
    
            // make the HTTP request
            RestResponseBase response = (RestResponseBase) ApiClient.CallApi(path, Method.Post, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling PostUpload: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling PostUpload: " + response.ErrorMessage, response.ErrorMessage);
    
            return (CertificateRepresentation) ApiClient.Deserialize(response.Content, typeof(CertificateRepresentation), response.Headers);
        }
    
        /// <summary>
        ///  Upload only certificate, not private key
        /// </summary>
        /// <param name="realm">realm name (not id!)</param>
        /// <param name="id"></param>
        /// <param name="attr"></param>
        /// <returns>CertificateRepresentation</returns>
        public CertificateRepresentation PostUploadCertificate (string realm, string id, string attr)
        {
            // verify the required parameter 'realm' is set
            if (realm == null) throw new ApiException(400, "Missing required parameter 'realm' when calling PostUploadCertificate");
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling PostUploadCertificate");
            // verify the required parameter 'attr' is set
            if (attr == null) throw new ApiException(400, "Missing required parameter 'attr' when calling PostUploadCertificate");
    
            var path = "/{realm}/clients/{id}/certificates/{attr}/upload-certificate";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "realm" + "}", ApiClient.ParameterToString(realm));
path = path.Replace("{" + "id" + "}", ApiClient.ParameterToString(id));
path = path.Replace("{" + "attr" + "}", ApiClient.ParameterToString(attr));
    
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
                                    
            // authentication setting, if any
            String[] authSettings = new String[] { "access_token" };
    
            // make the HTTP request
            RestResponseBase response = (RestResponseBase) ApiClient.CallApi(path, Method.Post, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling PostUploadCertificate: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling PostUploadCertificate: " + response.ErrorMessage, response.ErrorMessage);
    
            return (CertificateRepresentation) ApiClient.Deserialize(response.Content, typeof(CertificateRepresentation), response.Headers);
        }
    
    }
}
