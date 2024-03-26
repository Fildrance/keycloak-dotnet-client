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
    public interface IClientRoleMappingsApi
    {
        /// <summary>
        ///  Delete client-level roles from user role mapping
        /// </summary>
        /// <param name="realm">realm name (not id!)</param>
        /// <param name="id"></param>
        /// <param name="_client"></param>
        /// <param name="body">RoleRepresentation</param>
        /// <returns></returns>
        void DeleteGroupRoleMappingsClient (string realm, string id, string _client, RoleRepresentation body);
        /// <summary>
        ///  Delete client-level roles from user role mapping
        /// </summary>
        /// <param name="realm">realm name (not id!)</param>
        /// <param name="id"></param>
        /// <param name="_client"></param>
        /// <param name="body">RoleRepresentation</param>
        /// <returns></returns>
        void DeleteUserRoleMappingsClient (string realm, string id, string _client, RoleRepresentation body);
        /// <summary>
        ///  Get client-level role mappings for the user, and the app
        /// </summary>
        /// <param name="realm">realm name (not id!)</param>
        /// <param name="id"></param>
        /// <param name="_client"></param>
        /// <returns>List&lt;RoleRepresentation&gt;</returns>
        List<RoleRepresentation> GetGroupRoleMappingsClient (string realm, string id, string _client);
        /// <summary>
        ///  Get available client-level roles that can be mapped to the user
        /// </summary>
        /// <param name="realm">realm name (not id!)</param>
        /// <param name="id"></param>
        /// <param name="_client"></param>
        /// <returns>List&lt;RoleRepresentation&gt;</returns>
        List<RoleRepresentation> GetGroupRoleMappingsClientAvailable (string realm, string id, string _client);
        /// <summary>
        ///  Get effective client-level role mappings This recurses any composite roles
        /// </summary>
        /// <param name="realm">realm name (not id!)</param>
        /// <param name="id"></param>
        /// <param name="_client"></param>
        /// <param name="briefRepresentation">if false, return roles with their attributes</param>
        /// <returns>List&lt;RoleRepresentation&gt;</returns>
        List<RoleRepresentation> GetGroupRoleMappingsClientComposite (string realm, string id, string _client, string briefRepresentation);
        /// <summary>
        ///  Get client-level role mappings for the user, and the app
        /// </summary>
        /// <param name="realm">realm name (not id!)</param>
        /// <param name="id"></param>
        /// <param name="_client"></param>
        /// <returns>List&lt;RoleRepresentation&gt;</returns>
        List<RoleRepresentation> GetUserRoleMappingsClient (string realm, string id, string _client);
        /// <summary>
        ///  Get available client-level roles that can be mapped to the user
        /// </summary>
        /// <param name="realm">realm name (not id!)</param>
        /// <param name="id"></param>
        /// <param name="_client"></param>
        /// <returns>List&lt;RoleRepresentation&gt;</returns>
        List<RoleRepresentation> GetUserRoleMappingsClientAvailable (string realm, string id, string _client);
        /// <summary>
        ///  Get effective client-level role mappings This recurses any composite roles
        /// </summary>
        /// <param name="realm">realm name (not id!)</param>
        /// <param name="id"></param>
        /// <param name="_client"></param>
        /// <param name="briefRepresentation">if false, return roles with their attributes</param>
        /// <returns>List&lt;RoleRepresentation&gt;</returns>
        List<RoleRepresentation> GetUserRoleMappingsClientComposite (string realm, string id, string _client, string briefRepresentation);
        /// <summary>
        ///  Add client-level roles to the user role mapping
        /// </summary>
        /// <param name="realm">realm name (not id!)</param>
        /// <param name="id"></param>
        /// <param name="_client"></param>
        /// <param name="body">RoleRepresentation</param>
        /// <returns></returns>
        void PostGroupRoleMappingsClient (string realm, string id, string _client, RoleRepresentation body);
        /// <summary>
        ///  Add client-level roles to the user role mapping
        /// </summary>
        /// <param name="realm">realm name (not id!)</param>
        /// <param name="id"></param>
        /// <param name="_client"></param>
        /// <param name="body">RoleRepresentation</param>
        /// <returns></returns>
        void PostUserRoleMappingsClient (string realm, string id, string _client, RoleRepresentation body);
    }
  
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public class ClientRoleMappingsApi : IClientRoleMappingsApi
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ClientRoleMappingsApi"/> class.
        /// </summary>
        /// <param name="apiClient"> an instance of ApiClient (optional)</param>
        /// <returns></returns>
        public ClientRoleMappingsApi(ApiClient apiClient = null)
        {
            if (apiClient == null) // use the default one in Configuration
                this.ApiClient = Configuration.DefaultApiClient; 
            else
                this.ApiClient = apiClient;
        }
    
        /// <summary>
        /// Initializes a new instance of the <see cref="ClientRoleMappingsApi"/> class.
        /// </summary>
        /// <returns></returns>
        public ClientRoleMappingsApi(String basePath)
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
        ///  Delete client-level roles from user role mapping
        /// </summary>
        /// <param name="realm">realm name (not id!)</param>
        /// <param name="id"></param>
        /// <param name="_client"></param>
        /// <param name="body">RoleRepresentation</param>
        /// <returns></returns>
        public void DeleteGroupRoleMappingsClient (string realm, string id, string _client, RoleRepresentation body)
        {
            // verify the required parameter 'realm' is set
            if (realm == null) throw new ApiException(400, "Missing required parameter 'realm' when calling DeleteGroupRoleMappingsClient");
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling DeleteGroupRoleMappingsClient");
            // verify the required parameter '_client' is set
            if (_client == null) throw new ApiException(400, "Missing required parameter '_client' when calling DeleteGroupRoleMappingsClient");
    
            var path = "/{realm}/groups/{id}/role-mappings/clients/{client}";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "realm" + "}", ApiClient.ParameterToString(realm));
path = path.Replace("{" + "id" + "}", ApiClient.ParameterToString(id));
path = path.Replace("{" + "client" + "}", ApiClient.ParameterToString(_client));
    
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
                                    postBody = ApiClient.Serialize(body); // http body (model) parameter

            // authentication setting, if any
            String[] authSettings = new String[] { "access_token" };
    
            // make the HTTP request
            RestResponseBase response = (RestResponseBase) ApiClient.CallApi(path, Method.Delete, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling DeleteGroupRoleMappingsClient: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling DeleteGroupRoleMappingsClient: " + response.ErrorMessage, response.ErrorMessage);
    
            return;
        }
    
        /// <summary>
        ///  Delete client-level roles from user role mapping
        /// </summary>
        /// <param name="realm">realm name (not id!)</param>
        /// <param name="id"></param>
        /// <param name="_client"></param>
        /// <param name="body">RoleRepresentation</param>
        /// <returns></returns>
        public void DeleteUserRoleMappingsClient (string realm, string id, string _client, RoleRepresentation body)
        {
            // verify the required parameter 'realm' is set
            if (realm == null) throw new ApiException(400, "Missing required parameter 'realm' when calling DeleteUserRoleMappingsClient");
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling DeleteUserRoleMappingsClient");
            // verify the required parameter '_client' is set
            if (_client == null) throw new ApiException(400, "Missing required parameter '_client' when calling DeleteUserRoleMappingsClient");
    
            var path = "/{realm}/users/{id}/role-mappings/clients/{client}";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "realm" + "}", ApiClient.ParameterToString(realm));
path = path.Replace("{" + "id" + "}", ApiClient.ParameterToString(id));
path = path.Replace("{" + "client" + "}", ApiClient.ParameterToString(_client));
    
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
                                    postBody = ApiClient.Serialize(body); // http body (model) parameter

            // authentication setting, if any
            String[] authSettings = new String[] { "access_token" };
    
            // make the HTTP request
            RestResponseBase response = (RestResponseBase) ApiClient.CallApi(path, Method.Delete, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling DeleteUserRoleMappingsClient: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling DeleteUserRoleMappingsClient: " + response.ErrorMessage, response.ErrorMessage);
    
            return;
        }
    
        /// <summary>
        ///  Get client-level role mappings for the user, and the app
        /// </summary>
        /// <param name="realm">realm name (not id!)</param>
        /// <param name="id"></param>
        /// <param name="_client"></param>
        /// <returns>List&lt;RoleRepresentation&gt;</returns>
        public List<RoleRepresentation> GetGroupRoleMappingsClient (string realm, string id, string _client)
        {
            // verify the required parameter 'realm' is set
            if (realm == null) throw new ApiException(400, "Missing required parameter 'realm' when calling GetGroupRoleMappingsClient");
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling GetGroupRoleMappingsClient");
            // verify the required parameter '_client' is set
            if (_client == null) throw new ApiException(400, "Missing required parameter '_client' when calling GetGroupRoleMappingsClient");
    
            var path = "/{realm}/groups/{id}/role-mappings/clients/{client}";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "realm" + "}", ApiClient.ParameterToString(realm));
path = path.Replace("{" + "id" + "}", ApiClient.ParameterToString(id));
path = path.Replace("{" + "client" + "}", ApiClient.ParameterToString(_client));
    
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
                throw new ApiException ((int)response.StatusCode, "Error calling GetGroupRoleMappingsClient: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling GetGroupRoleMappingsClient: " + response.ErrorMessage, response.ErrorMessage);
    
            return (List<RoleRepresentation>) ApiClient.Deserialize(response.Content, typeof(List<RoleRepresentation>), response.Headers);
        }
    
        /// <summary>
        ///  Get available client-level roles that can be mapped to the user
        /// </summary>
        /// <param name="realm">realm name (not id!)</param>
        /// <param name="id"></param>
        /// <param name="_client"></param>
        /// <returns>List&lt;RoleRepresentation&gt;</returns>
        public List<RoleRepresentation> GetGroupRoleMappingsClientAvailable (string realm, string id, string _client)
        {
            // verify the required parameter 'realm' is set
            if (realm == null) throw new ApiException(400, "Missing required parameter 'realm' when calling GetGroupRoleMappingsClientAvailable");
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling GetGroupRoleMappingsClientAvailable");
            // verify the required parameter '_client' is set
            if (_client == null) throw new ApiException(400, "Missing required parameter '_client' when calling GetGroupRoleMappingsClientAvailable");
    
            var path = "/{realm}/groups/{id}/role-mappings/clients/{client}/available";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "realm" + "}", ApiClient.ParameterToString(realm));
path = path.Replace("{" + "id" + "}", ApiClient.ParameterToString(id));
path = path.Replace("{" + "client" + "}", ApiClient.ParameterToString(_client));
    
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
                throw new ApiException ((int)response.StatusCode, "Error calling GetGroupRoleMappingsClientAvailable: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling GetGroupRoleMappingsClientAvailable: " + response.ErrorMessage, response.ErrorMessage);
    
            return (List<RoleRepresentation>) ApiClient.Deserialize(response.Content, typeof(List<RoleRepresentation>), response.Headers);
        }
    
        /// <summary>
        ///  Get effective client-level role mappings This recurses any composite roles
        /// </summary>
        /// <param name="realm">realm name (not id!)</param>
        /// <param name="id"></param>
        /// <param name="_client"></param>
        /// <param name="briefRepresentation">if false, return roles with their attributes</param>
        /// <returns>List&lt;RoleRepresentation&gt;</returns>
        public List<RoleRepresentation> GetGroupRoleMappingsClientComposite (string realm, string id, string _client, string briefRepresentation)
        {
            // verify the required parameter 'realm' is set
            if (realm == null) throw new ApiException(400, "Missing required parameter 'realm' when calling GetGroupRoleMappingsClientComposite");
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling GetGroupRoleMappingsClientComposite");
            // verify the required parameter '_client' is set
            if (_client == null) throw new ApiException(400, "Missing required parameter '_client' when calling GetGroupRoleMappingsClientComposite");
    
            var path = "/{realm}/groups/{id}/role-mappings/clients/{client}/composite";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "realm" + "}", ApiClient.ParameterToString(realm));
path = path.Replace("{" + "id" + "}", ApiClient.ParameterToString(id));
path = path.Replace("{" + "client" + "}", ApiClient.ParameterToString(_client));
    
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
             if (briefRepresentation != null) queryParams.Add("briefRepresentation", ApiClient.ParameterToString(briefRepresentation)); // query parameter
                        
            // authentication setting, if any
            String[] authSettings = new String[] { "access_token" };
    
            // make the HTTP request
            RestResponseBase response = (RestResponseBase) ApiClient.CallApi(path, Method.Get, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling GetGroupRoleMappingsClientComposite: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling GetGroupRoleMappingsClientComposite: " + response.ErrorMessage, response.ErrorMessage);
    
            return (List<RoleRepresentation>) ApiClient.Deserialize(response.Content, typeof(List<RoleRepresentation>), response.Headers);
        }
    
        /// <summary>
        ///  Get client-level role mappings for the user, and the app
        /// </summary>
        /// <param name="realm">realm name (not id!)</param>
        /// <param name="id"></param>
        /// <param name="_client"></param>
        /// <returns>List&lt;RoleRepresentation&gt;</returns>
        public List<RoleRepresentation> GetUserRoleMappingsClient (string realm, string id, string _client)
        {
            // verify the required parameter 'realm' is set
            if (realm == null) throw new ApiException(400, "Missing required parameter 'realm' when calling GetUserRoleMappingsClient");
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling GetUserRoleMappingsClient");
            // verify the required parameter '_client' is set
            if (_client == null) throw new ApiException(400, "Missing required parameter '_client' when calling GetUserRoleMappingsClient");
    
            var path = "/{realm}/users/{id}/role-mappings/clients/{client}";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "realm" + "}", ApiClient.ParameterToString(realm));
path = path.Replace("{" + "id" + "}", ApiClient.ParameterToString(id));
path = path.Replace("{" + "client" + "}", ApiClient.ParameterToString(_client));
    
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
                throw new ApiException ((int)response.StatusCode, "Error calling GetUserRoleMappingsClient: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling GetUserRoleMappingsClient: " + response.ErrorMessage, response.ErrorMessage);
    
            return (List<RoleRepresentation>) ApiClient.Deserialize(response.Content, typeof(List<RoleRepresentation>), response.Headers);
        }
    
        /// <summary>
        ///  Get available client-level roles that can be mapped to the user
        /// </summary>
        /// <param name="realm">realm name (not id!)</param>
        /// <param name="id"></param>
        /// <param name="_client"></param>
        /// <returns>List&lt;RoleRepresentation&gt;</returns>
        public List<RoleRepresentation> GetUserRoleMappingsClientAvailable (string realm, string id, string _client)
        {
            // verify the required parameter 'realm' is set
            if (realm == null) throw new ApiException(400, "Missing required parameter 'realm' when calling GetUserRoleMappingsClientAvailable");
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling GetUserRoleMappingsClientAvailable");
            // verify the required parameter '_client' is set
            if (_client == null) throw new ApiException(400, "Missing required parameter '_client' when calling GetUserRoleMappingsClientAvailable");
    
            var path = "/{realm}/users/{id}/role-mappings/clients/{client}/available";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "realm" + "}", ApiClient.ParameterToString(realm));
path = path.Replace("{" + "id" + "}", ApiClient.ParameterToString(id));
path = path.Replace("{" + "client" + "}", ApiClient.ParameterToString(_client));
    
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
                throw new ApiException ((int)response.StatusCode, "Error calling GetUserRoleMappingsClientAvailable: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling GetUserRoleMappingsClientAvailable: " + response.ErrorMessage, response.ErrorMessage);
    
            return (List<RoleRepresentation>) ApiClient.Deserialize(response.Content, typeof(List<RoleRepresentation>), response.Headers);
        }
    
        /// <summary>
        ///  Get effective client-level role mappings This recurses any composite roles
        /// </summary>
        /// <param name="realm">realm name (not id!)</param>
        /// <param name="id"></param>
        /// <param name="_client"></param>
        /// <param name="briefRepresentation">if false, return roles with their attributes</param>
        /// <returns>List&lt;RoleRepresentation&gt;</returns>
        public List<RoleRepresentation> GetUserRoleMappingsClientComposite (string realm, string id, string _client, string briefRepresentation)
        {
            // verify the required parameter 'realm' is set
            if (realm == null) throw new ApiException(400, "Missing required parameter 'realm' when calling GetUserRoleMappingsClientComposite");
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling GetUserRoleMappingsClientComposite");
            // verify the required parameter '_client' is set
            if (_client == null) throw new ApiException(400, "Missing required parameter '_client' when calling GetUserRoleMappingsClientComposite");
    
            var path = "/{realm}/users/{id}/role-mappings/clients/{client}/composite";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "realm" + "}", ApiClient.ParameterToString(realm));
path = path.Replace("{" + "id" + "}", ApiClient.ParameterToString(id));
path = path.Replace("{" + "client" + "}", ApiClient.ParameterToString(_client));
    
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
             if (briefRepresentation != null) queryParams.Add("briefRepresentation", ApiClient.ParameterToString(briefRepresentation)); // query parameter
                        
            // authentication setting, if any
            String[] authSettings = new String[] { "access_token" };
    
            // make the HTTP request
            RestResponseBase response = (RestResponseBase) ApiClient.CallApi(path, Method.Get, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling GetUserRoleMappingsClientComposite: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling GetUserRoleMappingsClientComposite: " + response.ErrorMessage, response.ErrorMessage);
    
            return (List<RoleRepresentation>) ApiClient.Deserialize(response.Content, typeof(List<RoleRepresentation>), response.Headers);
        }
    
        /// <summary>
        ///  Add client-level roles to the user role mapping
        /// </summary>
        /// <param name="realm">realm name (not id!)</param>
        /// <param name="id"></param>
        /// <param name="_client"></param>
        /// <param name="body">RoleRepresentation</param>
        /// <returns></returns>
        public void PostGroupRoleMappingsClient (string realm, string id, string _client, RoleRepresentation body)
        {
            // verify the required parameter 'realm' is set
            if (realm == null) throw new ApiException(400, "Missing required parameter 'realm' when calling PostGroupRoleMappingsClient");
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling PostGroupRoleMappingsClient");
            // verify the required parameter '_client' is set
            if (_client == null) throw new ApiException(400, "Missing required parameter '_client' when calling PostGroupRoleMappingsClient");
    
            var path = "/{realm}/groups/{id}/role-mappings/clients/{client}";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "realm" + "}", ApiClient.ParameterToString(realm));
path = path.Replace("{" + "id" + "}", ApiClient.ParameterToString(id));
path = path.Replace("{" + "client" + "}", ApiClient.ParameterToString(_client));
    
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
                throw new ApiException ((int)response.StatusCode, "Error calling PostGroupRoleMappingsClient: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling PostGroupRoleMappingsClient: " + response.ErrorMessage, response.ErrorMessage);
    
            return;
        }
    
        /// <summary>
        ///  Add client-level roles to the user role mapping
        /// </summary>
        /// <param name="realm">realm name (not id!)</param>
        /// <param name="id"></param>
        /// <param name="_client"></param>
        /// <param name="body">RoleRepresentation</param>
        /// <returns></returns>
        public void PostUserRoleMappingsClient (string realm, string id, string _client, RoleRepresentation body)
        {
            // verify the required parameter 'realm' is set
            if (realm == null) throw new ApiException(400, "Missing required parameter 'realm' when calling PostUserRoleMappingsClient");
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling PostUserRoleMappingsClient");
            // verify the required parameter '_client' is set
            if (_client == null) throw new ApiException(400, "Missing required parameter '_client' when calling PostUserRoleMappingsClient");
    
            var path = "/{realm}/users/{id}/role-mappings/clients/{client}";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "realm" + "}", ApiClient.ParameterToString(realm));
path = path.Replace("{" + "id" + "}", ApiClient.ParameterToString(id));
path = path.Replace("{" + "client" + "}", ApiClient.ParameterToString(_client));
    
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
                throw new ApiException ((int)response.StatusCode, "Error calling PostUserRoleMappingsClient: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling PostUserRoleMappingsClient: " + response.ErrorMessage, response.ErrorMessage);
    
            return;
        }
    
    }
}
