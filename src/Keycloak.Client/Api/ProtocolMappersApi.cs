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
    public interface IProtocolMappersApi
    {
        /// <summary>
        ///  Delete the mapper
        /// </summary>
        /// <param name="realm">realm name (not id!)</param>
        /// <param name="id1"></param>
        /// <param name="id2"></param>
        /// <returns></returns>
        void DeleteClientProtocolMappersModel (string realm, string id1, string id2);
        /// <summary>
        ///  Delete the mapper
        /// </summary>
        /// <param name="realm">realm name (not id!)</param>
        /// <param name="id1"></param>
        /// <param name="id2"></param>
        /// <returns></returns>
        void DeleteClientScopeProtocolMappersModel (string realm, string id1, string id2);
        /// <summary>
        ///  Delete the mapper
        /// </summary>
        /// <param name="realm">realm name (not id!)</param>
        /// <param name="id1"></param>
        /// <param name="id2"></param>
        /// <returns></returns>
        void DeleteClientTemplateProtocolMappersModel (string realm, string id1, string id2);
        /// <summary>
        ///  Get mapper by id
        /// </summary>
        /// <param name="realm">realm name (not id!)</param>
        /// <param name="id1"></param>
        /// <param name="id2"></param>
        /// <returns>ProtocolMapperRepresentation</returns>
        ProtocolMapperRepresentation GetClientProtocolMappersModel (string realm, string id1, string id2);
        /// <summary>
        ///  Get mappers
        /// </summary>
        /// <param name="realm">realm name (not id!)</param>
        /// <param name="id"></param>
        /// <returns>List&lt;ProtocolMapperRepresentation&gt;</returns>
        List<ProtocolMapperRepresentation> GetClientProtocolMappersModels (string realm, string id);
        /// <summary>
        ///  Get mappers by name for a specific protocol
        /// </summary>
        /// <param name="realm">realm name (not id!)</param>
        /// <param name="id"></param>
        /// <param name="protocol"></param>
        /// <returns>List&lt;ProtocolMapperRepresentation&gt;</returns>
        List<ProtocolMapperRepresentation> GetClientProtocolMappersProtocol (string realm, string id, string protocol);
        /// <summary>
        ///  Get mapper by id
        /// </summary>
        /// <param name="realm">realm name (not id!)</param>
        /// <param name="id1"></param>
        /// <param name="id2"></param>
        /// <returns>ProtocolMapperRepresentation</returns>
        ProtocolMapperRepresentation GetClientScopeProtocolMappersModel (string realm, string id1, string id2);
        /// <summary>
        ///  Get mappers
        /// </summary>
        /// <param name="realm">realm name (not id!)</param>
        /// <param name="id"></param>
        /// <returns>List&lt;ProtocolMapperRepresentation&gt;</returns>
        List<ProtocolMapperRepresentation> GetClientScopeProtocolMappersModels (string realm, string id);
        /// <summary>
        ///  Get mappers by name for a specific protocol
        /// </summary>
        /// <param name="realm">realm name (not id!)</param>
        /// <param name="id"></param>
        /// <param name="protocol"></param>
        /// <returns>List&lt;ProtocolMapperRepresentation&gt;</returns>
        List<ProtocolMapperRepresentation> GetClientScopeProtocolMappersProtocol (string realm, string id, string protocol);
        /// <summary>
        ///  Get mapper by id
        /// </summary>
        /// <param name="realm">realm name (not id!)</param>
        /// <param name="id1"></param>
        /// <param name="id2"></param>
        /// <returns>ProtocolMapperRepresentation</returns>
        ProtocolMapperRepresentation GetClientTemplateProtocolMappersModel (string realm, string id1, string id2);
        /// <summary>
        ///  Get mappers
        /// </summary>
        /// <param name="realm">realm name (not id!)</param>
        /// <param name="id"></param>
        /// <returns>List&lt;ProtocolMapperRepresentation&gt;</returns>
        List<ProtocolMapperRepresentation> GetClientTemplateProtocolMappersModels (string realm, string id);
        /// <summary>
        ///  Get mappers by name for a specific protocol
        /// </summary>
        /// <param name="realm">realm name (not id!)</param>
        /// <param name="id"></param>
        /// <param name="protocol"></param>
        /// <returns>List&lt;ProtocolMapperRepresentation&gt;</returns>
        List<ProtocolMapperRepresentation> GetClientTemplateProtocolMappersProtocol (string realm, string id, string protocol);
        /// <summary>
        ///  Create multiple mappers
        /// </summary>
        /// <param name="realm">realm name (not id!)</param>
        /// <param name="id"></param>
        /// <param name="body">ProtocolMapperRepresentation</param>
        /// <returns></returns>
        void PostClientProtocolMappersAddModels (string realm, string id, ProtocolMapperRepresentation body);
        /// <summary>
        ///  Create a mapper
        /// </summary>
        /// <param name="realm">realm name (not id!)</param>
        /// <param name="id"></param>
        /// <param name="body">ProtocolMapperRepresentation</param>
        /// <returns></returns>
        void PostClientProtocolMappersModels (string realm, string id, ProtocolMapperRepresentation body);
        /// <summary>
        ///  Create multiple mappers
        /// </summary>
        /// <param name="realm">realm name (not id!)</param>
        /// <param name="id"></param>
        /// <param name="body">ProtocolMapperRepresentation</param>
        /// <returns></returns>
        void PostClientScopeProtocolMappersAddModels (string realm, string id, ProtocolMapperRepresentation body);
        /// <summary>
        ///  Create a mapper
        /// </summary>
        /// <param name="realm">realm name (not id!)</param>
        /// <param name="id"></param>
        /// <param name="body">ProtocolMapperRepresentation</param>
        /// <returns></returns>
        void PostClientScopeProtocolMappersModels (string realm, string id, ProtocolMapperRepresentation body);
        /// <summary>
        ///  Create multiple mappers
        /// </summary>
        /// <param name="realm">realm name (not id!)</param>
        /// <param name="id"></param>
        /// <param name="body">ProtocolMapperRepresentation</param>
        /// <returns></returns>
        void PostClientTemplateProtocolMappersAddModels (string realm, string id, ProtocolMapperRepresentation body);
        /// <summary>
        ///  Create a mapper
        /// </summary>
        /// <param name="realm">realm name (not id!)</param>
        /// <param name="id"></param>
        /// <param name="body">ProtocolMapperRepresentation</param>
        /// <returns></returns>
        void PostClientTemplateProtocolMappersModels (string realm, string id, ProtocolMapperRepresentation body);
        /// <summary>
        ///  Update the mapper
        /// </summary>
        /// <param name="realm">realm name (not id!)</param>
        /// <param name="id1"></param>
        /// <param name="id2"></param>
        /// <param name="body">ProtocolMapperRepresentation</param>
        /// <returns></returns>
        void PutClientProtocolMappersModel (string realm, string id1, string id2, ProtocolMapperRepresentation body);
        /// <summary>
        ///  Update the mapper
        /// </summary>
        /// <param name="realm">realm name (not id!)</param>
        /// <param name="id1"></param>
        /// <param name="id2"></param>
        /// <param name="body">ProtocolMapperRepresentation</param>
        /// <returns></returns>
        void PutClientScopeProtocolMappersModel (string realm, string id1, string id2, ProtocolMapperRepresentation body);
        /// <summary>
        ///  Update the mapper
        /// </summary>
        /// <param name="realm">realm name (not id!)</param>
        /// <param name="id1"></param>
        /// <param name="id2"></param>
        /// <param name="body">ProtocolMapperRepresentation</param>
        /// <returns></returns>
        void PutClientTemplateProtocolMappersModel (string realm, string id1, string id2, ProtocolMapperRepresentation body);
    }
  
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public class ProtocolMappersApi : IProtocolMappersApi
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ProtocolMappersApi"/> class.
        /// </summary>
        /// <param name="apiClient"> an instance of ApiClient (optional)</param>
        /// <returns></returns>
        public ProtocolMappersApi(ApiClient apiClient = null)
        {
            if (apiClient == null) // use the default one in Configuration
                this.ApiClient = Configuration.DefaultApiClient; 
            else
                this.ApiClient = apiClient;
        }
    
        /// <summary>
        /// Initializes a new instance of the <see cref="ProtocolMappersApi"/> class.
        /// </summary>
        /// <returns></returns>
        public ProtocolMappersApi(String basePath)
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
        ///  Delete the mapper
        /// </summary>
        /// <param name="realm">realm name (not id!)</param>
        /// <param name="id1"></param>
        /// <param name="id2"></param>
        /// <returns></returns>
        public void DeleteClientProtocolMappersModel (string realm, string id1, string id2)
        {
            // verify the required parameter 'realm' is set
            if (realm == null) throw new ApiException(400, "Missing required parameter 'realm' when calling DeleteClientProtocolMappersModel");
            // verify the required parameter 'id1' is set
            if (id1 == null) throw new ApiException(400, "Missing required parameter 'id1' when calling DeleteClientProtocolMappersModel");
            // verify the required parameter 'id2' is set
            if (id2 == null) throw new ApiException(400, "Missing required parameter 'id2' when calling DeleteClientProtocolMappersModel");
    
            var path = "/{realm}/clients/{id1}/protocol-mappers/models/{id2}";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "realm" + "}", ApiClient.ParameterToString(realm));
path = path.Replace("{" + "id1" + "}", ApiClient.ParameterToString(id1));
path = path.Replace("{" + "id2" + "}", ApiClient.ParameterToString(id2));
    
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
                                    
            // authentication setting, if any
            String[] authSettings = new String[] { "access_token" };
    
            // make the HTTP request
            RestResponseBase response = (RestResponseBase) ApiClient.CallApi(path, Method.Delete, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling DeleteClientProtocolMappersModel: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling DeleteClientProtocolMappersModel: " + response.ErrorMessage, response.ErrorMessage);
    
            return;
        }
    
        /// <summary>
        ///  Delete the mapper
        /// </summary>
        /// <param name="realm">realm name (not id!)</param>
        /// <param name="id1"></param>
        /// <param name="id2"></param>
        /// <returns></returns>
        public void DeleteClientScopeProtocolMappersModel (string realm, string id1, string id2)
        {
            // verify the required parameter 'realm' is set
            if (realm == null) throw new ApiException(400, "Missing required parameter 'realm' when calling DeleteClientScopeProtocolMappersModel");
            // verify the required parameter 'id1' is set
            if (id1 == null) throw new ApiException(400, "Missing required parameter 'id1' when calling DeleteClientScopeProtocolMappersModel");
            // verify the required parameter 'id2' is set
            if (id2 == null) throw new ApiException(400, "Missing required parameter 'id2' when calling DeleteClientScopeProtocolMappersModel");
    
            var path = "/{realm}/client-scopes/{id1}/protocol-mappers/models/{id2}";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "realm" + "}", ApiClient.ParameterToString(realm));
path = path.Replace("{" + "id1" + "}", ApiClient.ParameterToString(id1));
path = path.Replace("{" + "id2" + "}", ApiClient.ParameterToString(id2));
    
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
                                    
            // authentication setting, if any
            String[] authSettings = new String[] { "access_token" };
    
            // make the HTTP request
            RestResponseBase response = (RestResponseBase) ApiClient.CallApi(path, Method.Delete, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling DeleteClientScopeProtocolMappersModel: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling DeleteClientScopeProtocolMappersModel: " + response.ErrorMessage, response.ErrorMessage);
    
            return;
        }
    
        /// <summary>
        ///  Delete the mapper
        /// </summary>
        /// <param name="realm">realm name (not id!)</param>
        /// <param name="id1"></param>
        /// <param name="id2"></param>
        /// <returns></returns>
        public void DeleteClientTemplateProtocolMappersModel (string realm, string id1, string id2)
        {
            // verify the required parameter 'realm' is set
            if (realm == null) throw new ApiException(400, "Missing required parameter 'realm' when calling DeleteClientTemplateProtocolMappersModel");
            // verify the required parameter 'id1' is set
            if (id1 == null) throw new ApiException(400, "Missing required parameter 'id1' when calling DeleteClientTemplateProtocolMappersModel");
            // verify the required parameter 'id2' is set
            if (id2 == null) throw new ApiException(400, "Missing required parameter 'id2' when calling DeleteClientTemplateProtocolMappersModel");
    
            var path = "/{realm}/client-templates/{id1}/protocol-mappers/models/{id2}";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "realm" + "}", ApiClient.ParameterToString(realm));
path = path.Replace("{" + "id1" + "}", ApiClient.ParameterToString(id1));
path = path.Replace("{" + "id2" + "}", ApiClient.ParameterToString(id2));
    
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
                                    
            // authentication setting, if any
            String[] authSettings = new String[] { "access_token" };
    
            // make the HTTP request
            RestResponseBase response = (RestResponseBase) ApiClient.CallApi(path, Method.Delete, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling DeleteClientTemplateProtocolMappersModel: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling DeleteClientTemplateProtocolMappersModel: " + response.ErrorMessage, response.ErrorMessage);
    
            return;
        }
    
        /// <summary>
        ///  Get mapper by id
        /// </summary>
        /// <param name="realm">realm name (not id!)</param>
        /// <param name="id1"></param>
        /// <param name="id2"></param>
        /// <returns>ProtocolMapperRepresentation</returns>
        public ProtocolMapperRepresentation GetClientProtocolMappersModel (string realm, string id1, string id2)
        {
            // verify the required parameter 'realm' is set
            if (realm == null) throw new ApiException(400, "Missing required parameter 'realm' when calling GetClientProtocolMappersModel");
            // verify the required parameter 'id1' is set
            if (id1 == null) throw new ApiException(400, "Missing required parameter 'id1' when calling GetClientProtocolMappersModel");
            // verify the required parameter 'id2' is set
            if (id2 == null) throw new ApiException(400, "Missing required parameter 'id2' when calling GetClientProtocolMappersModel");
    
            var path = "/{realm}/clients/{id1}/protocol-mappers/models/{id2}";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "realm" + "}", ApiClient.ParameterToString(realm));
path = path.Replace("{" + "id1" + "}", ApiClient.ParameterToString(id1));
path = path.Replace("{" + "id2" + "}", ApiClient.ParameterToString(id2));
    
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
                throw new ApiException ((int)response.StatusCode, "Error calling GetClientProtocolMappersModel: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling GetClientProtocolMappersModel: " + response.ErrorMessage, response.ErrorMessage);
    
            return (ProtocolMapperRepresentation) ApiClient.Deserialize(response.Content, typeof(ProtocolMapperRepresentation), response.Headers);
        }
    
        /// <summary>
        ///  Get mappers
        /// </summary>
        /// <param name="realm">realm name (not id!)</param>
        /// <param name="id"></param>
        /// <returns>List&lt;ProtocolMapperRepresentation&gt;</returns>
        public List<ProtocolMapperRepresentation> GetClientProtocolMappersModels (string realm, string id)
        {
            // verify the required parameter 'realm' is set
            if (realm == null) throw new ApiException(400, "Missing required parameter 'realm' when calling GetClientProtocolMappersModels");
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling GetClientProtocolMappersModels");
    
            var path = "/{realm}/clients/{id}/protocol-mappers/models";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "realm" + "}", ApiClient.ParameterToString(realm));
path = path.Replace("{" + "id" + "}", ApiClient.ParameterToString(id));
    
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
                throw new ApiException ((int)response.StatusCode, "Error calling GetClientProtocolMappersModels: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling GetClientProtocolMappersModels: " + response.ErrorMessage, response.ErrorMessage);
    
            return (List<ProtocolMapperRepresentation>) ApiClient.Deserialize(response.Content, typeof(List<ProtocolMapperRepresentation>), response.Headers);
        }
    
        /// <summary>
        ///  Get mappers by name for a specific protocol
        /// </summary>
        /// <param name="realm">realm name (not id!)</param>
        /// <param name="id"></param>
        /// <param name="protocol"></param>
        /// <returns>List&lt;ProtocolMapperRepresentation&gt;</returns>
        public List<ProtocolMapperRepresentation> GetClientProtocolMappersProtocol (string realm, string id, string protocol)
        {
            // verify the required parameter 'realm' is set
            if (realm == null) throw new ApiException(400, "Missing required parameter 'realm' when calling GetClientProtocolMappersProtocol");
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling GetClientProtocolMappersProtocol");
            // verify the required parameter 'protocol' is set
            if (protocol == null) throw new ApiException(400, "Missing required parameter 'protocol' when calling GetClientProtocolMappersProtocol");
    
            var path = "/{realm}/clients/{id}/protocol-mappers/protocol/{protocol}";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "realm" + "}", ApiClient.ParameterToString(realm));
path = path.Replace("{" + "id" + "}", ApiClient.ParameterToString(id));
path = path.Replace("{" + "protocol" + "}", ApiClient.ParameterToString(protocol));
    
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
                throw new ApiException ((int)response.StatusCode, "Error calling GetClientProtocolMappersProtocol: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling GetClientProtocolMappersProtocol: " + response.ErrorMessage, response.ErrorMessage);
    
            return (List<ProtocolMapperRepresentation>) ApiClient.Deserialize(response.Content, typeof(List<ProtocolMapperRepresentation>), response.Headers);
        }
    
        /// <summary>
        ///  Get mapper by id
        /// </summary>
        /// <param name="realm">realm name (not id!)</param>
        /// <param name="id1"></param>
        /// <param name="id2"></param>
        /// <returns>ProtocolMapperRepresentation</returns>
        public ProtocolMapperRepresentation GetClientScopeProtocolMappersModel (string realm, string id1, string id2)
        {
            // verify the required parameter 'realm' is set
            if (realm == null) throw new ApiException(400, "Missing required parameter 'realm' when calling GetClientScopeProtocolMappersModel");
            // verify the required parameter 'id1' is set
            if (id1 == null) throw new ApiException(400, "Missing required parameter 'id1' when calling GetClientScopeProtocolMappersModel");
            // verify the required parameter 'id2' is set
            if (id2 == null) throw new ApiException(400, "Missing required parameter 'id2' when calling GetClientScopeProtocolMappersModel");
    
            var path = "/{realm}/client-scopes/{id1}/protocol-mappers/models/{id2}";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "realm" + "}", ApiClient.ParameterToString(realm));
path = path.Replace("{" + "id1" + "}", ApiClient.ParameterToString(id1));
path = path.Replace("{" + "id2" + "}", ApiClient.ParameterToString(id2));
    
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
                throw new ApiException ((int)response.StatusCode, "Error calling GetClientScopeProtocolMappersModel: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling GetClientScopeProtocolMappersModel: " + response.ErrorMessage, response.ErrorMessage);
    
            return (ProtocolMapperRepresentation) ApiClient.Deserialize(response.Content, typeof(ProtocolMapperRepresentation), response.Headers);
        }
    
        /// <summary>
        ///  Get mappers
        /// </summary>
        /// <param name="realm">realm name (not id!)</param>
        /// <param name="id"></param>
        /// <returns>List&lt;ProtocolMapperRepresentation&gt;</returns>
        public List<ProtocolMapperRepresentation> GetClientScopeProtocolMappersModels (string realm, string id)
        {
            // verify the required parameter 'realm' is set
            if (realm == null) throw new ApiException(400, "Missing required parameter 'realm' when calling GetClientScopeProtocolMappersModels");
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling GetClientScopeProtocolMappersModels");
    
            var path = "/{realm}/client-scopes/{id}/protocol-mappers/models";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "realm" + "}", ApiClient.ParameterToString(realm));
path = path.Replace("{" + "id" + "}", ApiClient.ParameterToString(id));
    
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
                throw new ApiException ((int)response.StatusCode, "Error calling GetClientScopeProtocolMappersModels: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling GetClientScopeProtocolMappersModels: " + response.ErrorMessage, response.ErrorMessage);
    
            return (List<ProtocolMapperRepresentation>) ApiClient.Deserialize(response.Content, typeof(List<ProtocolMapperRepresentation>), response.Headers);
        }
    
        /// <summary>
        ///  Get mappers by name for a specific protocol
        /// </summary>
        /// <param name="realm">realm name (not id!)</param>
        /// <param name="id"></param>
        /// <param name="protocol"></param>
        /// <returns>List&lt;ProtocolMapperRepresentation&gt;</returns>
        public List<ProtocolMapperRepresentation> GetClientScopeProtocolMappersProtocol (string realm, string id, string protocol)
        {
            // verify the required parameter 'realm' is set
            if (realm == null) throw new ApiException(400, "Missing required parameter 'realm' when calling GetClientScopeProtocolMappersProtocol");
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling GetClientScopeProtocolMappersProtocol");
            // verify the required parameter 'protocol' is set
            if (protocol == null) throw new ApiException(400, "Missing required parameter 'protocol' when calling GetClientScopeProtocolMappersProtocol");
    
            var path = "/{realm}/client-scopes/{id}/protocol-mappers/protocol/{protocol}";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "realm" + "}", ApiClient.ParameterToString(realm));
path = path.Replace("{" + "id" + "}", ApiClient.ParameterToString(id));
path = path.Replace("{" + "protocol" + "}", ApiClient.ParameterToString(protocol));
    
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
                throw new ApiException ((int)response.StatusCode, "Error calling GetClientScopeProtocolMappersProtocol: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling GetClientScopeProtocolMappersProtocol: " + response.ErrorMessage, response.ErrorMessage);
    
            return (List<ProtocolMapperRepresentation>) ApiClient.Deserialize(response.Content, typeof(List<ProtocolMapperRepresentation>), response.Headers);
        }
    
        /// <summary>
        ///  Get mapper by id
        /// </summary>
        /// <param name="realm">realm name (not id!)</param>
        /// <param name="id1"></param>
        /// <param name="id2"></param>
        /// <returns>ProtocolMapperRepresentation</returns>
        public ProtocolMapperRepresentation GetClientTemplateProtocolMappersModel (string realm, string id1, string id2)
        {
            // verify the required parameter 'realm' is set
            if (realm == null) throw new ApiException(400, "Missing required parameter 'realm' when calling GetClientTemplateProtocolMappersModel");
            // verify the required parameter 'id1' is set
            if (id1 == null) throw new ApiException(400, "Missing required parameter 'id1' when calling GetClientTemplateProtocolMappersModel");
            // verify the required parameter 'id2' is set
            if (id2 == null) throw new ApiException(400, "Missing required parameter 'id2' when calling GetClientTemplateProtocolMappersModel");
    
            var path = "/{realm}/client-templates/{id1}/protocol-mappers/models/{id2}";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "realm" + "}", ApiClient.ParameterToString(realm));
path = path.Replace("{" + "id1" + "}", ApiClient.ParameterToString(id1));
path = path.Replace("{" + "id2" + "}", ApiClient.ParameterToString(id2));
    
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
                throw new ApiException ((int)response.StatusCode, "Error calling GetClientTemplateProtocolMappersModel: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling GetClientTemplateProtocolMappersModel: " + response.ErrorMessage, response.ErrorMessage);
    
            return (ProtocolMapperRepresentation) ApiClient.Deserialize(response.Content, typeof(ProtocolMapperRepresentation), response.Headers);
        }
    
        /// <summary>
        ///  Get mappers
        /// </summary>
        /// <param name="realm">realm name (not id!)</param>
        /// <param name="id"></param>
        /// <returns>List&lt;ProtocolMapperRepresentation&gt;</returns>
        public List<ProtocolMapperRepresentation> GetClientTemplateProtocolMappersModels (string realm, string id)
        {
            // verify the required parameter 'realm' is set
            if (realm == null) throw new ApiException(400, "Missing required parameter 'realm' when calling GetClientTemplateProtocolMappersModels");
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling GetClientTemplateProtocolMappersModels");
    
            var path = "/{realm}/client-templates/{id}/protocol-mappers/models";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "realm" + "}", ApiClient.ParameterToString(realm));
path = path.Replace("{" + "id" + "}", ApiClient.ParameterToString(id));
    
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
                throw new ApiException ((int)response.StatusCode, "Error calling GetClientTemplateProtocolMappersModels: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling GetClientTemplateProtocolMappersModels: " + response.ErrorMessage, response.ErrorMessage);
    
            return (List<ProtocolMapperRepresentation>) ApiClient.Deserialize(response.Content, typeof(List<ProtocolMapperRepresentation>), response.Headers);
        }
    
        /// <summary>
        ///  Get mappers by name for a specific protocol
        /// </summary>
        /// <param name="realm">realm name (not id!)</param>
        /// <param name="id"></param>
        /// <param name="protocol"></param>
        /// <returns>List&lt;ProtocolMapperRepresentation&gt;</returns>
        public List<ProtocolMapperRepresentation> GetClientTemplateProtocolMappersProtocol (string realm, string id, string protocol)
        {
            // verify the required parameter 'realm' is set
            if (realm == null) throw new ApiException(400, "Missing required parameter 'realm' when calling GetClientTemplateProtocolMappersProtocol");
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling GetClientTemplateProtocolMappersProtocol");
            // verify the required parameter 'protocol' is set
            if (protocol == null) throw new ApiException(400, "Missing required parameter 'protocol' when calling GetClientTemplateProtocolMappersProtocol");
    
            var path = "/{realm}/client-templates/{id}/protocol-mappers/protocol/{protocol}";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "realm" + "}", ApiClient.ParameterToString(realm));
path = path.Replace("{" + "id" + "}", ApiClient.ParameterToString(id));
path = path.Replace("{" + "protocol" + "}", ApiClient.ParameterToString(protocol));
    
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
                throw new ApiException ((int)response.StatusCode, "Error calling GetClientTemplateProtocolMappersProtocol: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling GetClientTemplateProtocolMappersProtocol: " + response.ErrorMessage, response.ErrorMessage);
    
            return (List<ProtocolMapperRepresentation>) ApiClient.Deserialize(response.Content, typeof(List<ProtocolMapperRepresentation>), response.Headers);
        }
    
        /// <summary>
        ///  Create multiple mappers
        /// </summary>
        /// <param name="realm">realm name (not id!)</param>
        /// <param name="id"></param>
        /// <param name="body">ProtocolMapperRepresentation</param>
        /// <returns></returns>
        public void PostClientProtocolMappersAddModels (string realm, string id, ProtocolMapperRepresentation body)
        {
            // verify the required parameter 'realm' is set
            if (realm == null) throw new ApiException(400, "Missing required parameter 'realm' when calling PostClientProtocolMappersAddModels");
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling PostClientProtocolMappersAddModels");
    
            var path = "/{realm}/clients/{id}/protocol-mappers/add-models";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "realm" + "}", ApiClient.ParameterToString(realm));
path = path.Replace("{" + "id" + "}", ApiClient.ParameterToString(id));
    
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
                throw new ApiException ((int)response.StatusCode, "Error calling PostClientProtocolMappersAddModels: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling PostClientProtocolMappersAddModels: " + response.ErrorMessage, response.ErrorMessage);
    
            return;
        }
    
        /// <summary>
        ///  Create a mapper
        /// </summary>
        /// <param name="realm">realm name (not id!)</param>
        /// <param name="id"></param>
        /// <param name="body">ProtocolMapperRepresentation</param>
        /// <returns></returns>
        public void PostClientProtocolMappersModels (string realm, string id, ProtocolMapperRepresentation body)
        {
            // verify the required parameter 'realm' is set
            if (realm == null) throw new ApiException(400, "Missing required parameter 'realm' when calling PostClientProtocolMappersModels");
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling PostClientProtocolMappersModels");
    
            var path = "/{realm}/clients/{id}/protocol-mappers/models";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "realm" + "}", ApiClient.ParameterToString(realm));
path = path.Replace("{" + "id" + "}", ApiClient.ParameterToString(id));
    
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
                throw new ApiException ((int)response.StatusCode, "Error calling PostClientProtocolMappersModels: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling PostClientProtocolMappersModels: " + response.ErrorMessage, response.ErrorMessage);
    
            return;
        }
    
        /// <summary>
        ///  Create multiple mappers
        /// </summary>
        /// <param name="realm">realm name (not id!)</param>
        /// <param name="id"></param>
        /// <param name="body">ProtocolMapperRepresentation</param>
        /// <returns></returns>
        public void PostClientScopeProtocolMappersAddModels (string realm, string id, ProtocolMapperRepresentation body)
        {
            // verify the required parameter 'realm' is set
            if (realm == null) throw new ApiException(400, "Missing required parameter 'realm' when calling PostClientScopeProtocolMappersAddModels");
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling PostClientScopeProtocolMappersAddModels");
    
            var path = "/{realm}/client-scopes/{id}/protocol-mappers/add-models";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "realm" + "}", ApiClient.ParameterToString(realm));
path = path.Replace("{" + "id" + "}", ApiClient.ParameterToString(id));
    
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
                throw new ApiException ((int)response.StatusCode, "Error calling PostClientScopeProtocolMappersAddModels: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling PostClientScopeProtocolMappersAddModels: " + response.ErrorMessage, response.ErrorMessage);
    
            return;
        }
    
        /// <summary>
        ///  Create a mapper
        /// </summary>
        /// <param name="realm">realm name (not id!)</param>
        /// <param name="id"></param>
        /// <param name="body">ProtocolMapperRepresentation</param>
        /// <returns></returns>
        public void PostClientScopeProtocolMappersModels (string realm, string id, ProtocolMapperRepresentation body)
        {
            // verify the required parameter 'realm' is set
            if (realm == null) throw new ApiException(400, "Missing required parameter 'realm' when calling PostClientScopeProtocolMappersModels");
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling PostClientScopeProtocolMappersModels");
    
            var path = "/{realm}/client-scopes/{id}/protocol-mappers/models";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "realm" + "}", ApiClient.ParameterToString(realm));
path = path.Replace("{" + "id" + "}", ApiClient.ParameterToString(id));
    
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
                throw new ApiException ((int)response.StatusCode, "Error calling PostClientScopeProtocolMappersModels: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling PostClientScopeProtocolMappersModels: " + response.ErrorMessage, response.ErrorMessage);
    
            return;
        }
    
        /// <summary>
        ///  Create multiple mappers
        /// </summary>
        /// <param name="realm">realm name (not id!)</param>
        /// <param name="id"></param>
        /// <param name="body">ProtocolMapperRepresentation</param>
        /// <returns></returns>
        public void PostClientTemplateProtocolMappersAddModels (string realm, string id, ProtocolMapperRepresentation body)
        {
            // verify the required parameter 'realm' is set
            if (realm == null) throw new ApiException(400, "Missing required parameter 'realm' when calling PostClientTemplateProtocolMappersAddModels");
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling PostClientTemplateProtocolMappersAddModels");
    
            var path = "/{realm}/client-templates/{id}/protocol-mappers/add-models";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "realm" + "}", ApiClient.ParameterToString(realm));
path = path.Replace("{" + "id" + "}", ApiClient.ParameterToString(id));
    
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
                throw new ApiException ((int)response.StatusCode, "Error calling PostClientTemplateProtocolMappersAddModels: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling PostClientTemplateProtocolMappersAddModels: " + response.ErrorMessage, response.ErrorMessage);
    
            return;
        }
    
        /// <summary>
        ///  Create a mapper
        /// </summary>
        /// <param name="realm">realm name (not id!)</param>
        /// <param name="id"></param>
        /// <param name="body">ProtocolMapperRepresentation</param>
        /// <returns></returns>
        public void PostClientTemplateProtocolMappersModels (string realm, string id, ProtocolMapperRepresentation body)
        {
            // verify the required parameter 'realm' is set
            if (realm == null) throw new ApiException(400, "Missing required parameter 'realm' when calling PostClientTemplateProtocolMappersModels");
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling PostClientTemplateProtocolMappersModels");
    
            var path = "/{realm}/client-templates/{id}/protocol-mappers/models";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "realm" + "}", ApiClient.ParameterToString(realm));
path = path.Replace("{" + "id" + "}", ApiClient.ParameterToString(id));
    
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
                throw new ApiException ((int)response.StatusCode, "Error calling PostClientTemplateProtocolMappersModels: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling PostClientTemplateProtocolMappersModels: " + response.ErrorMessage, response.ErrorMessage);
    
            return;
        }
    
        /// <summary>
        ///  Update the mapper
        /// </summary>
        /// <param name="realm">realm name (not id!)</param>
        /// <param name="id1"></param>
        /// <param name="id2"></param>
        /// <param name="body">ProtocolMapperRepresentation</param>
        /// <returns></returns>
        public void PutClientProtocolMappersModel (string realm, string id1, string id2, ProtocolMapperRepresentation body)
        {
            // verify the required parameter 'realm' is set
            if (realm == null) throw new ApiException(400, "Missing required parameter 'realm' when calling PutClientProtocolMappersModel");
            // verify the required parameter 'id1' is set
            if (id1 == null) throw new ApiException(400, "Missing required parameter 'id1' when calling PutClientProtocolMappersModel");
            // verify the required parameter 'id2' is set
            if (id2 == null) throw new ApiException(400, "Missing required parameter 'id2' when calling PutClientProtocolMappersModel");
    
            var path = "/{realm}/clients/{id1}/protocol-mappers/models/{id2}";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "realm" + "}", ApiClient.ParameterToString(realm));
path = path.Replace("{" + "id1" + "}", ApiClient.ParameterToString(id1));
path = path.Replace("{" + "id2" + "}", ApiClient.ParameterToString(id2));
    
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
                                    postBody = ApiClient.Serialize(body); // http body (model) parameter

            // authentication setting, if any
            String[] authSettings = new String[] { "access_token" };
    
            // make the HTTP request
            RestResponseBase response = (RestResponseBase) ApiClient.CallApi(path, Method.Put, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling PutClientProtocolMappersModel: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling PutClientProtocolMappersModel: " + response.ErrorMessage, response.ErrorMessage);
    
            return;
        }
    
        /// <summary>
        ///  Update the mapper
        /// </summary>
        /// <param name="realm">realm name (not id!)</param>
        /// <param name="id1"></param>
        /// <param name="id2"></param>
        /// <param name="body">ProtocolMapperRepresentation</param>
        /// <returns></returns>
        public void PutClientScopeProtocolMappersModel (string realm, string id1, string id2, ProtocolMapperRepresentation body)
        {
            // verify the required parameter 'realm' is set
            if (realm == null) throw new ApiException(400, "Missing required parameter 'realm' when calling PutClientScopeProtocolMappersModel");
            // verify the required parameter 'id1' is set
            if (id1 == null) throw new ApiException(400, "Missing required parameter 'id1' when calling PutClientScopeProtocolMappersModel");
            // verify the required parameter 'id2' is set
            if (id2 == null) throw new ApiException(400, "Missing required parameter 'id2' when calling PutClientScopeProtocolMappersModel");
    
            var path = "/{realm}/client-scopes/{id1}/protocol-mappers/models/{id2}";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "realm" + "}", ApiClient.ParameterToString(realm));
path = path.Replace("{" + "id1" + "}", ApiClient.ParameterToString(id1));
path = path.Replace("{" + "id2" + "}", ApiClient.ParameterToString(id2));
    
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
                                    postBody = ApiClient.Serialize(body); // http body (model) parameter

            // authentication setting, if any
            String[] authSettings = new String[] { "access_token" };
    
            // make the HTTP request
            RestResponseBase response = (RestResponseBase) ApiClient.CallApi(path, Method.Put, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling PutClientScopeProtocolMappersModel: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling PutClientScopeProtocolMappersModel: " + response.ErrorMessage, response.ErrorMessage);
    
            return;
        }
    
        /// <summary>
        ///  Update the mapper
        /// </summary>
        /// <param name="realm">realm name (not id!)</param>
        /// <param name="id1"></param>
        /// <param name="id2"></param>
        /// <param name="body">ProtocolMapperRepresentation</param>
        /// <returns></returns>
        public void PutClientTemplateProtocolMappersModel (string realm, string id1, string id2, ProtocolMapperRepresentation body)
        {
            // verify the required parameter 'realm' is set
            if (realm == null) throw new ApiException(400, "Missing required parameter 'realm' when calling PutClientTemplateProtocolMappersModel");
            // verify the required parameter 'id1' is set
            if (id1 == null) throw new ApiException(400, "Missing required parameter 'id1' when calling PutClientTemplateProtocolMappersModel");
            // verify the required parameter 'id2' is set
            if (id2 == null) throw new ApiException(400, "Missing required parameter 'id2' when calling PutClientTemplateProtocolMappersModel");
    
            var path = "/{realm}/client-templates/{id1}/protocol-mappers/models/{id2}";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "realm" + "}", ApiClient.ParameterToString(realm));
path = path.Replace("{" + "id1" + "}", ApiClient.ParameterToString(id1));
path = path.Replace("{" + "id2" + "}", ApiClient.ParameterToString(id2));
    
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
                                    postBody = ApiClient.Serialize(body); // http body (model) parameter

            // authentication setting, if any
            String[] authSettings = new String[] { "access_token" };
    
            // make the HTTP request
            RestResponseBase response = (RestResponseBase) ApiClient.CallApi(path, Method.Put, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling PutClientTemplateProtocolMappersModel: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling PutClientTemplateProtocolMappersModel: " + response.ErrorMessage, response.ErrorMessage);
    
            return;
        }
    
    }
}
