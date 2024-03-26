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
    public interface IScopeMappingsApi
    {
        /// <summary>
        ///  Remove client-level roles from the client’s scope.
        /// </summary>
        /// <param name="realm">realm name (not id!)</param>
        /// <param name="id"></param>
        /// <param name="_client"></param>
        /// <param name="body">RoleRepresentation</param>
        /// <returns></returns>
        void DeleteClientScopeMappingsClient (string realm, string id, string _client, RoleRepresentation body);
        /// <summary>
        ///  Remove a set of realm-level roles from the client’s scope
        /// </summary>
        /// <param name="realm">realm name (not id!)</param>
        /// <param name="id"></param>
        /// <param name="body">RoleRepresentation</param>
        /// <returns></returns>
        void DeleteClientScopeMappingsRealm (string realm, string id, RoleRepresentation body);
        /// <summary>
        ///  Remove client-level roles from the client’s scope.
        /// </summary>
        /// <param name="realm">realm name (not id!)</param>
        /// <param name="id"></param>
        /// <param name="_client"></param>
        /// <param name="body">RoleRepresentation</param>
        /// <returns></returns>
        void DeleteClientScopeScopeMappingsClient (string realm, string id, string _client, RoleRepresentation body);
        /// <summary>
        ///  Remove a set of realm-level roles from the client’s scope
        /// </summary>
        /// <param name="realm">realm name (not id!)</param>
        /// <param name="id"></param>
        /// <param name="body">RoleRepresentation</param>
        /// <returns></returns>
        void DeleteClientScopeScopeMappingsRealm (string realm, string id, RoleRepresentation body);
        /// <summary>
        ///  Remove client-level roles from the client’s scope.
        /// </summary>
        /// <param name="realm">realm name (not id!)</param>
        /// <param name="id"></param>
        /// <param name="_client"></param>
        /// <param name="body">RoleRepresentation</param>
        /// <returns></returns>
        void DeleteClientTemplateScopeMappingsClient (string realm, string id, string _client, RoleRepresentation body);
        /// <summary>
        ///  Remove a set of realm-level roles from the client’s scope
        /// </summary>
        /// <param name="realm">realm name (not id!)</param>
        /// <param name="id"></param>
        /// <param name="body">RoleRepresentation</param>
        /// <returns></returns>
        void DeleteClientTemplateScopeMappingsRealm (string realm, string id, RoleRepresentation body);
        /// <summary>
        ///  Get all scope mappings for the client
        /// </summary>
        /// <param name="realm">realm name (not id!)</param>
        /// <param name="id"></param>
        /// <returns>MappingsRepresentation</returns>
        MappingsRepresentation GetClientScopeMappings (string realm, string id);
        /// <summary>
        ///  Get the roles associated with a client’s scope Returns roles for the client.
        /// </summary>
        /// <param name="realm">realm name (not id!)</param>
        /// <param name="id"></param>
        /// <param name="_client"></param>
        /// <returns>List&lt;RoleRepresentation&gt;</returns>
        List<RoleRepresentation> GetClientScopeMappingsClient (string realm, string id, string _client);
        /// <summary>
        ///  The available client-level roles Returns the roles for the client that can be associated with the client’s scope
        /// </summary>
        /// <param name="realm">realm name (not id!)</param>
        /// <param name="id"></param>
        /// <param name="_client"></param>
        /// <returns>List&lt;RoleRepresentation&gt;</returns>
        List<RoleRepresentation> GetClientScopeMappingsClientAvailable (string realm, string id, string _client);
        /// <summary>
        ///  Get effective client roles Returns the roles for the client that are associated with the client’s scope.
        /// </summary>
        /// <param name="realm">realm name (not id!)</param>
        /// <param name="id"></param>
        /// <param name="_client"></param>
        /// <param name="briefRepresentation">if false, return roles with their attributes</param>
        /// <returns>List&lt;RoleRepresentation&gt;</returns>
        List<RoleRepresentation> GetClientScopeMappingsClientComposite (string realm, string id, string _client, string briefRepresentation);
        /// <summary>
        ///  Get realm-level roles associated with the client’s scope
        /// </summary>
        /// <param name="realm">realm name (not id!)</param>
        /// <param name="id"></param>
        /// <returns>List&lt;RoleRepresentation&gt;</returns>
        List<RoleRepresentation> GetClientScopeMappingsRealm (string realm, string id);
        /// <summary>
        ///  Get realm-level roles that are available to attach to this client’s scope
        /// </summary>
        /// <param name="realm">realm name (not id!)</param>
        /// <param name="id"></param>
        /// <returns>List&lt;RoleRepresentation&gt;</returns>
        List<RoleRepresentation> GetClientScopeMappingsRealmAvailable (string realm, string id);
        /// <summary>
        ///  Get effective realm-level roles associated with the client’s scope What this does is recurse any composite roles associated with the client’s scope and adds the roles to this lists.
        /// </summary>
        /// <param name="realm">realm name (not id!)</param>
        /// <param name="id"></param>
        /// <param name="briefRepresentation">if false, return roles with their attributes</param>
        /// <returns>List&lt;RoleRepresentation&gt;</returns>
        List<RoleRepresentation> GetClientScopeMappingsRealmComposite (string realm, string id, string briefRepresentation);
        /// <summary>
        ///  Get all scope mappings for the client
        /// </summary>
        /// <param name="realm">realm name (not id!)</param>
        /// <param name="id"></param>
        /// <returns>MappingsRepresentation</returns>
        MappingsRepresentation GetClientScopeScopeMappings (string realm, string id);
        /// <summary>
        ///  Get the roles associated with a client’s scope Returns roles for the client.
        /// </summary>
        /// <param name="realm">realm name (not id!)</param>
        /// <param name="id"></param>
        /// <param name="_client"></param>
        /// <returns>List&lt;RoleRepresentation&gt;</returns>
        List<RoleRepresentation> GetClientScopeScopeMappingsClient (string realm, string id, string _client);
        /// <summary>
        ///  The available client-level roles Returns the roles for the client that can be associated with the client’s scope
        /// </summary>
        /// <param name="realm">realm name (not id!)</param>
        /// <param name="id"></param>
        /// <param name="_client"></param>
        /// <returns>List&lt;RoleRepresentation&gt;</returns>
        List<RoleRepresentation> GetClientScopeScopeMappingsClientAvailable (string realm, string id, string _client);
        /// <summary>
        ///  Get effective client roles Returns the roles for the client that are associated with the client’s scope.
        /// </summary>
        /// <param name="realm">realm name (not id!)</param>
        /// <param name="id"></param>
        /// <param name="_client"></param>
        /// <param name="briefRepresentation">if false, return roles with their attributes</param>
        /// <returns>List&lt;RoleRepresentation&gt;</returns>
        List<RoleRepresentation> GetClientScopeScopeMappingsClientComposite (string realm, string id, string _client, string briefRepresentation);
        /// <summary>
        ///  Get realm-level roles associated with the client’s scope
        /// </summary>
        /// <param name="realm">realm name (not id!)</param>
        /// <param name="id"></param>
        /// <returns>List&lt;RoleRepresentation&gt;</returns>
        List<RoleRepresentation> GetClientScopeScopeMappingsRealm (string realm, string id);
        /// <summary>
        ///  Get realm-level roles that are available to attach to this client’s scope
        /// </summary>
        /// <param name="realm">realm name (not id!)</param>
        /// <param name="id"></param>
        /// <returns>List&lt;RoleRepresentation&gt;</returns>
        List<RoleRepresentation> GetClientScopeScopeMappingsRealmAvailable (string realm, string id);
        /// <summary>
        ///  Get effective realm-level roles associated with the client’s scope What this does is recurse any composite roles associated with the client’s scope and adds the roles to this lists.
        /// </summary>
        /// <param name="realm">realm name (not id!)</param>
        /// <param name="id"></param>
        /// <param name="briefRepresentation">if false, return roles with their attributes</param>
        /// <returns>List&lt;RoleRepresentation&gt;</returns>
        List<RoleRepresentation> GetClientScopeScopeMappingsRealmComposite (string realm, string id, string briefRepresentation);
        /// <summary>
        ///  Get all scope mappings for the client
        /// </summary>
        /// <param name="realm">realm name (not id!)</param>
        /// <param name="id"></param>
        /// <returns>MappingsRepresentation</returns>
        MappingsRepresentation GetClientTemplateScopeMappings (string realm, string id);
        /// <summary>
        ///  Get the roles associated with a client’s scope Returns roles for the client.
        /// </summary>
        /// <param name="realm">realm name (not id!)</param>
        /// <param name="id"></param>
        /// <param name="_client"></param>
        /// <returns>List&lt;RoleRepresentation&gt;</returns>
        List<RoleRepresentation> GetClientTemplateScopeMappingsClient (string realm, string id, string _client);
        /// <summary>
        ///  The available client-level roles Returns the roles for the client that can be associated with the client’s scope
        /// </summary>
        /// <param name="realm">realm name (not id!)</param>
        /// <param name="id"></param>
        /// <param name="_client"></param>
        /// <returns>List&lt;RoleRepresentation&gt;</returns>
        List<RoleRepresentation> GetClientTemplateScopeMappingsClientAvailable (string realm, string id, string _client);
        /// <summary>
        ///  Get effective client roles Returns the roles for the client that are associated with the client’s scope.
        /// </summary>
        /// <param name="realm">realm name (not id!)</param>
        /// <param name="id"></param>
        /// <param name="_client"></param>
        /// <param name="briefRepresentation">if false, return roles with their attributes</param>
        /// <returns>List&lt;RoleRepresentation&gt;</returns>
        List<RoleRepresentation> GetClientTemplateScopeMappingsClientComposite (string realm, string id, string _client, string briefRepresentation);
        /// <summary>
        ///  Get realm-level roles associated with the client’s scope
        /// </summary>
        /// <param name="realm">realm name (not id!)</param>
        /// <param name="id"></param>
        /// <returns>List&lt;RoleRepresentation&gt;</returns>
        List<RoleRepresentation> GetClientTemplateScopeMappingsRealm (string realm, string id);
        /// <summary>
        ///  Get realm-level roles that are available to attach to this client’s scope
        /// </summary>
        /// <param name="realm">realm name (not id!)</param>
        /// <param name="id"></param>
        /// <returns>List&lt;RoleRepresentation&gt;</returns>
        List<RoleRepresentation> GetClientTemplateScopeMappingsRealmAvailable (string realm, string id);
        /// <summary>
        ///  Get effective realm-level roles associated with the client’s scope What this does is recurse any composite roles associated with the client’s scope and adds the roles to this lists.
        /// </summary>
        /// <param name="realm">realm name (not id!)</param>
        /// <param name="id"></param>
        /// <param name="briefRepresentation">if false, return roles with their attributes</param>
        /// <returns>List&lt;RoleRepresentation&gt;</returns>
        List<RoleRepresentation> GetClientTemplateScopeMappingsRealmComposite (string realm, string id, string briefRepresentation);
        /// <summary>
        ///  Add client-level roles to the client’s scope
        /// </summary>
        /// <param name="realm">realm name (not id!)</param>
        /// <param name="id"></param>
        /// <param name="_client"></param>
        /// <param name="body">RoleRepresentation</param>
        /// <returns></returns>
        void PostClientScopeMappingsClient (string realm, string id, string _client, RoleRepresentation body);
        /// <summary>
        ///  Add a set of realm-level roles to the client’s scope
        /// </summary>
        /// <param name="realm">realm name (not id!)</param>
        /// <param name="id"></param>
        /// <param name="body">RoleRepresentation</param>
        /// <returns></returns>
        void PostClientScopeMappingsRealm (string realm, string id, RoleRepresentation body);
        /// <summary>
        ///  Add client-level roles to the client’s scope
        /// </summary>
        /// <param name="realm">realm name (not id!)</param>
        /// <param name="id"></param>
        /// <param name="_client"></param>
        /// <param name="body">RoleRepresentation</param>
        /// <returns></returns>
        void PostClientScopeScopeMappingsClient (string realm, string id, string _client, RoleRepresentation body);
        /// <summary>
        ///  Add a set of realm-level roles to the client’s scope
        /// </summary>
        /// <param name="realm">realm name (not id!)</param>
        /// <param name="id"></param>
        /// <param name="body">RoleRepresentation</param>
        /// <returns></returns>
        void PostClientScopeScopeMappingsRealm (string realm, string id, RoleRepresentation body);
        /// <summary>
        ///  Add client-level roles to the client’s scope
        /// </summary>
        /// <param name="realm">realm name (not id!)</param>
        /// <param name="id"></param>
        /// <param name="_client"></param>
        /// <param name="body">RoleRepresentation</param>
        /// <returns></returns>
        void PostClientTemplateScopeMappingsClient (string realm, string id, string _client, RoleRepresentation body);
        /// <summary>
        ///  Add a set of realm-level roles to the client’s scope
        /// </summary>
        /// <param name="realm">realm name (not id!)</param>
        /// <param name="id"></param>
        /// <param name="body">RoleRepresentation</param>
        /// <returns></returns>
        void PostClientTemplateScopeMappingsRealm (string realm, string id, RoleRepresentation body);
    }
  
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public class ScopeMappingsApi : IScopeMappingsApi
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ScopeMappingsApi"/> class.
        /// </summary>
        /// <param name="apiClient"> an instance of ApiClient (optional)</param>
        /// <returns></returns>
        public ScopeMappingsApi(ApiClient apiClient = null)
        {
            if (apiClient == null) // use the default one in Configuration
                this.ApiClient = Configuration.DefaultApiClient; 
            else
                this.ApiClient = apiClient;
        }
    
        /// <summary>
        /// Initializes a new instance of the <see cref="ScopeMappingsApi"/> class.
        /// </summary>
        /// <returns></returns>
        public ScopeMappingsApi(String basePath)
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
        ///  Remove client-level roles from the client’s scope.
        /// </summary>
        /// <param name="realm">realm name (not id!)</param>
        /// <param name="id"></param>
        /// <param name="_client"></param>
        /// <param name="body">RoleRepresentation</param>
        /// <returns></returns>
        public void DeleteClientScopeMappingsClient (string realm, string id, string _client, RoleRepresentation body)
        {
            // verify the required parameter 'realm' is set
            if (realm == null) throw new ApiException(400, "Missing required parameter 'realm' when calling DeleteClientScopeMappingsClient");
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling DeleteClientScopeMappingsClient");
            // verify the required parameter '_client' is set
            if (_client == null) throw new ApiException(400, "Missing required parameter '_client' when calling DeleteClientScopeMappingsClient");
    
            var path = "/{realm}/clients/{id}/scope-mappings/clients/{client}";
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
                throw new ApiException ((int)response.StatusCode, "Error calling DeleteClientScopeMappingsClient: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling DeleteClientScopeMappingsClient: " + response.ErrorMessage, response.ErrorMessage);
    
            return;
        }
    
        /// <summary>
        ///  Remove a set of realm-level roles from the client’s scope
        /// </summary>
        /// <param name="realm">realm name (not id!)</param>
        /// <param name="id"></param>
        /// <param name="body">RoleRepresentation</param>
        /// <returns></returns>
        public void DeleteClientScopeMappingsRealm (string realm, string id, RoleRepresentation body)
        {
            // verify the required parameter 'realm' is set
            if (realm == null) throw new ApiException(400, "Missing required parameter 'realm' when calling DeleteClientScopeMappingsRealm");
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling DeleteClientScopeMappingsRealm");
    
            var path = "/{realm}/clients/{id}/scope-mappings/realm";
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
            RestResponseBase response = (RestResponseBase) ApiClient.CallApi(path, Method.Delete, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling DeleteClientScopeMappingsRealm: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling DeleteClientScopeMappingsRealm: " + response.ErrorMessage, response.ErrorMessage);
    
            return;
        }
    
        /// <summary>
        ///  Remove client-level roles from the client’s scope.
        /// </summary>
        /// <param name="realm">realm name (not id!)</param>
        /// <param name="id"></param>
        /// <param name="_client"></param>
        /// <param name="body">RoleRepresentation</param>
        /// <returns></returns>
        public void DeleteClientScopeScopeMappingsClient (string realm, string id, string _client, RoleRepresentation body)
        {
            // verify the required parameter 'realm' is set
            if (realm == null) throw new ApiException(400, "Missing required parameter 'realm' when calling DeleteClientScopeScopeMappingsClient");
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling DeleteClientScopeScopeMappingsClient");
            // verify the required parameter '_client' is set
            if (_client == null) throw new ApiException(400, "Missing required parameter '_client' when calling DeleteClientScopeScopeMappingsClient");
    
            var path = "/{realm}/client-scopes/{id}/scope-mappings/clients/{client}";
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
                throw new ApiException ((int)response.StatusCode, "Error calling DeleteClientScopeScopeMappingsClient: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling DeleteClientScopeScopeMappingsClient: " + response.ErrorMessage, response.ErrorMessage);
    
            return;
        }
    
        /// <summary>
        ///  Remove a set of realm-level roles from the client’s scope
        /// </summary>
        /// <param name="realm">realm name (not id!)</param>
        /// <param name="id"></param>
        /// <param name="body">RoleRepresentation</param>
        /// <returns></returns>
        public void DeleteClientScopeScopeMappingsRealm (string realm, string id, RoleRepresentation body)
        {
            // verify the required parameter 'realm' is set
            if (realm == null) throw new ApiException(400, "Missing required parameter 'realm' when calling DeleteClientScopeScopeMappingsRealm");
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling DeleteClientScopeScopeMappingsRealm");
    
            var path = "/{realm}/client-scopes/{id}/scope-mappings/realm";
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
            RestResponseBase response = (RestResponseBase) ApiClient.CallApi(path, Method.Delete, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling DeleteClientScopeScopeMappingsRealm: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling DeleteClientScopeScopeMappingsRealm: " + response.ErrorMessage, response.ErrorMessage);
    
            return;
        }
    
        /// <summary>
        ///  Remove client-level roles from the client’s scope.
        /// </summary>
        /// <param name="realm">realm name (not id!)</param>
        /// <param name="id"></param>
        /// <param name="_client"></param>
        /// <param name="body">RoleRepresentation</param>
        /// <returns></returns>
        public void DeleteClientTemplateScopeMappingsClient (string realm, string id, string _client, RoleRepresentation body)
        {
            // verify the required parameter 'realm' is set
            if (realm == null) throw new ApiException(400, "Missing required parameter 'realm' when calling DeleteClientTemplateScopeMappingsClient");
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling DeleteClientTemplateScopeMappingsClient");
            // verify the required parameter '_client' is set
            if (_client == null) throw new ApiException(400, "Missing required parameter '_client' when calling DeleteClientTemplateScopeMappingsClient");
    
            var path = "/{realm}/client-templates/{id}/scope-mappings/clients/{client}";
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
                throw new ApiException ((int)response.StatusCode, "Error calling DeleteClientTemplateScopeMappingsClient: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling DeleteClientTemplateScopeMappingsClient: " + response.ErrorMessage, response.ErrorMessage);
    
            return;
        }
    
        /// <summary>
        ///  Remove a set of realm-level roles from the client’s scope
        /// </summary>
        /// <param name="realm">realm name (not id!)</param>
        /// <param name="id"></param>
        /// <param name="body">RoleRepresentation</param>
        /// <returns></returns>
        public void DeleteClientTemplateScopeMappingsRealm (string realm, string id, RoleRepresentation body)
        {
            // verify the required parameter 'realm' is set
            if (realm == null) throw new ApiException(400, "Missing required parameter 'realm' when calling DeleteClientTemplateScopeMappingsRealm");
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling DeleteClientTemplateScopeMappingsRealm");
    
            var path = "/{realm}/client-templates/{id}/scope-mappings/realm";
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
            RestResponseBase response = (RestResponseBase) ApiClient.CallApi(path, Method.Delete, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling DeleteClientTemplateScopeMappingsRealm: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling DeleteClientTemplateScopeMappingsRealm: " + response.ErrorMessage, response.ErrorMessage);
    
            return;
        }
    
        /// <summary>
        ///  Get all scope mappings for the client
        /// </summary>
        /// <param name="realm">realm name (not id!)</param>
        /// <param name="id"></param>
        /// <returns>MappingsRepresentation</returns>
        public MappingsRepresentation GetClientScopeMappings (string realm, string id)
        {
            // verify the required parameter 'realm' is set
            if (realm == null) throw new ApiException(400, "Missing required parameter 'realm' when calling GetClientScopeMappings");
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling GetClientScopeMappings");
    
            var path = "/{realm}/clients/{id}/scope-mappings";
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
                throw new ApiException ((int)response.StatusCode, "Error calling GetClientScopeMappings: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling GetClientScopeMappings: " + response.ErrorMessage, response.ErrorMessage);
    
            return (MappingsRepresentation) ApiClient.Deserialize(response.Content, typeof(MappingsRepresentation), response.Headers);
        }
    
        /// <summary>
        ///  Get the roles associated with a client’s scope Returns roles for the client.
        /// </summary>
        /// <param name="realm">realm name (not id!)</param>
        /// <param name="id"></param>
        /// <param name="_client"></param>
        /// <returns>List&lt;RoleRepresentation&gt;</returns>
        public List<RoleRepresentation> GetClientScopeMappingsClient (string realm, string id, string _client)
        {
            // verify the required parameter 'realm' is set
            if (realm == null) throw new ApiException(400, "Missing required parameter 'realm' when calling GetClientScopeMappingsClient");
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling GetClientScopeMappingsClient");
            // verify the required parameter '_client' is set
            if (_client == null) throw new ApiException(400, "Missing required parameter '_client' when calling GetClientScopeMappingsClient");
    
            var path = "/{realm}/clients/{id}/scope-mappings/clients/{client}";
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
                throw new ApiException ((int)response.StatusCode, "Error calling GetClientScopeMappingsClient: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling GetClientScopeMappingsClient: " + response.ErrorMessage, response.ErrorMessage);
    
            return (List<RoleRepresentation>) ApiClient.Deserialize(response.Content, typeof(List<RoleRepresentation>), response.Headers);
        }
    
        /// <summary>
        ///  The available client-level roles Returns the roles for the client that can be associated with the client’s scope
        /// </summary>
        /// <param name="realm">realm name (not id!)</param>
        /// <param name="id"></param>
        /// <param name="_client"></param>
        /// <returns>List&lt;RoleRepresentation&gt;</returns>
        public List<RoleRepresentation> GetClientScopeMappingsClientAvailable (string realm, string id, string _client)
        {
            // verify the required parameter 'realm' is set
            if (realm == null) throw new ApiException(400, "Missing required parameter 'realm' when calling GetClientScopeMappingsClientAvailable");
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling GetClientScopeMappingsClientAvailable");
            // verify the required parameter '_client' is set
            if (_client == null) throw new ApiException(400, "Missing required parameter '_client' when calling GetClientScopeMappingsClientAvailable");
    
            var path = "/{realm}/clients/{id}/scope-mappings/clients/{client}/available";
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
                throw new ApiException ((int)response.StatusCode, "Error calling GetClientScopeMappingsClientAvailable: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling GetClientScopeMappingsClientAvailable: " + response.ErrorMessage, response.ErrorMessage);
    
            return (List<RoleRepresentation>) ApiClient.Deserialize(response.Content, typeof(List<RoleRepresentation>), response.Headers);
        }
    
        /// <summary>
        ///  Get effective client roles Returns the roles for the client that are associated with the client’s scope.
        /// </summary>
        /// <param name="realm">realm name (not id!)</param>
        /// <param name="id"></param>
        /// <param name="_client"></param>
        /// <param name="briefRepresentation">if false, return roles with their attributes</param>
        /// <returns>List&lt;RoleRepresentation&gt;</returns>
        public List<RoleRepresentation> GetClientScopeMappingsClientComposite (string realm, string id, string _client, string briefRepresentation)
        {
            // verify the required parameter 'realm' is set
            if (realm == null) throw new ApiException(400, "Missing required parameter 'realm' when calling GetClientScopeMappingsClientComposite");
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling GetClientScopeMappingsClientComposite");
            // verify the required parameter '_client' is set
            if (_client == null) throw new ApiException(400, "Missing required parameter '_client' when calling GetClientScopeMappingsClientComposite");
    
            var path = "/{realm}/clients/{id}/scope-mappings/clients/{client}/composite";
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
                throw new ApiException ((int)response.StatusCode, "Error calling GetClientScopeMappingsClientComposite: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling GetClientScopeMappingsClientComposite: " + response.ErrorMessage, response.ErrorMessage);
    
            return (List<RoleRepresentation>) ApiClient.Deserialize(response.Content, typeof(List<RoleRepresentation>), response.Headers);
        }
    
        /// <summary>
        ///  Get realm-level roles associated with the client’s scope
        /// </summary>
        /// <param name="realm">realm name (not id!)</param>
        /// <param name="id"></param>
        /// <returns>List&lt;RoleRepresentation&gt;</returns>
        public List<RoleRepresentation> GetClientScopeMappingsRealm (string realm, string id)
        {
            // verify the required parameter 'realm' is set
            if (realm == null) throw new ApiException(400, "Missing required parameter 'realm' when calling GetClientScopeMappingsRealm");
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling GetClientScopeMappingsRealm");
    
            var path = "/{realm}/clients/{id}/scope-mappings/realm";
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
                throw new ApiException ((int)response.StatusCode, "Error calling GetClientScopeMappingsRealm: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling GetClientScopeMappingsRealm: " + response.ErrorMessage, response.ErrorMessage);
    
            return (List<RoleRepresentation>) ApiClient.Deserialize(response.Content, typeof(List<RoleRepresentation>), response.Headers);
        }
    
        /// <summary>
        ///  Get realm-level roles that are available to attach to this client’s scope
        /// </summary>
        /// <param name="realm">realm name (not id!)</param>
        /// <param name="id"></param>
        /// <returns>List&lt;RoleRepresentation&gt;</returns>
        public List<RoleRepresentation> GetClientScopeMappingsRealmAvailable (string realm, string id)
        {
            // verify the required parameter 'realm' is set
            if (realm == null) throw new ApiException(400, "Missing required parameter 'realm' when calling GetClientScopeMappingsRealmAvailable");
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling GetClientScopeMappingsRealmAvailable");
    
            var path = "/{realm}/clients/{id}/scope-mappings/realm/available";
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
                throw new ApiException ((int)response.StatusCode, "Error calling GetClientScopeMappingsRealmAvailable: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling GetClientScopeMappingsRealmAvailable: " + response.ErrorMessage, response.ErrorMessage);
    
            return (List<RoleRepresentation>) ApiClient.Deserialize(response.Content, typeof(List<RoleRepresentation>), response.Headers);
        }
    
        /// <summary>
        ///  Get effective realm-level roles associated with the client’s scope What this does is recurse any composite roles associated with the client’s scope and adds the roles to this lists.
        /// </summary>
        /// <param name="realm">realm name (not id!)</param>
        /// <param name="id"></param>
        /// <param name="briefRepresentation">if false, return roles with their attributes</param>
        /// <returns>List&lt;RoleRepresentation&gt;</returns>
        public List<RoleRepresentation> GetClientScopeMappingsRealmComposite (string realm, string id, string briefRepresentation)
        {
            // verify the required parameter 'realm' is set
            if (realm == null) throw new ApiException(400, "Missing required parameter 'realm' when calling GetClientScopeMappingsRealmComposite");
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling GetClientScopeMappingsRealmComposite");
    
            var path = "/{realm}/clients/{id}/scope-mappings/realm/composite";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "realm" + "}", ApiClient.ParameterToString(realm));
path = path.Replace("{" + "id" + "}", ApiClient.ParameterToString(id));
    
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
                throw new ApiException ((int)response.StatusCode, "Error calling GetClientScopeMappingsRealmComposite: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling GetClientScopeMappingsRealmComposite: " + response.ErrorMessage, response.ErrorMessage);
    
            return (List<RoleRepresentation>) ApiClient.Deserialize(response.Content, typeof(List<RoleRepresentation>), response.Headers);
        }
    
        /// <summary>
        ///  Get all scope mappings for the client
        /// </summary>
        /// <param name="realm">realm name (not id!)</param>
        /// <param name="id"></param>
        /// <returns>MappingsRepresentation</returns>
        public MappingsRepresentation GetClientScopeScopeMappings (string realm, string id)
        {
            // verify the required parameter 'realm' is set
            if (realm == null) throw new ApiException(400, "Missing required parameter 'realm' when calling GetClientScopeScopeMappings");
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling GetClientScopeScopeMappings");
    
            var path = "/{realm}/client-scopes/{id}/scope-mappings";
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
                throw new ApiException ((int)response.StatusCode, "Error calling GetClientScopeScopeMappings: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling GetClientScopeScopeMappings: " + response.ErrorMessage, response.ErrorMessage);
    
            return (MappingsRepresentation) ApiClient.Deserialize(response.Content, typeof(MappingsRepresentation), response.Headers);
        }
    
        /// <summary>
        ///  Get the roles associated with a client’s scope Returns roles for the client.
        /// </summary>
        /// <param name="realm">realm name (not id!)</param>
        /// <param name="id"></param>
        /// <param name="_client"></param>
        /// <returns>List&lt;RoleRepresentation&gt;</returns>
        public List<RoleRepresentation> GetClientScopeScopeMappingsClient (string realm, string id, string _client)
        {
            // verify the required parameter 'realm' is set
            if (realm == null) throw new ApiException(400, "Missing required parameter 'realm' when calling GetClientScopeScopeMappingsClient");
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling GetClientScopeScopeMappingsClient");
            // verify the required parameter '_client' is set
            if (_client == null) throw new ApiException(400, "Missing required parameter '_client' when calling GetClientScopeScopeMappingsClient");
    
            var path = "/{realm}/client-scopes/{id}/scope-mappings/clients/{client}";
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
                throw new ApiException ((int)response.StatusCode, "Error calling GetClientScopeScopeMappingsClient: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling GetClientScopeScopeMappingsClient: " + response.ErrorMessage, response.ErrorMessage);
    
            return (List<RoleRepresentation>) ApiClient.Deserialize(response.Content, typeof(List<RoleRepresentation>), response.Headers);
        }
    
        /// <summary>
        ///  The available client-level roles Returns the roles for the client that can be associated with the client’s scope
        /// </summary>
        /// <param name="realm">realm name (not id!)</param>
        /// <param name="id"></param>
        /// <param name="_client"></param>
        /// <returns>List&lt;RoleRepresentation&gt;</returns>
        public List<RoleRepresentation> GetClientScopeScopeMappingsClientAvailable (string realm, string id, string _client)
        {
            // verify the required parameter 'realm' is set
            if (realm == null) throw new ApiException(400, "Missing required parameter 'realm' when calling GetClientScopeScopeMappingsClientAvailable");
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling GetClientScopeScopeMappingsClientAvailable");
            // verify the required parameter '_client' is set
            if (_client == null) throw new ApiException(400, "Missing required parameter '_client' when calling GetClientScopeScopeMappingsClientAvailable");
    
            var path = "/{realm}/client-scopes/{id}/scope-mappings/clients/{client}/available";
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
                throw new ApiException ((int)response.StatusCode, "Error calling GetClientScopeScopeMappingsClientAvailable: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling GetClientScopeScopeMappingsClientAvailable: " + response.ErrorMessage, response.ErrorMessage);
    
            return (List<RoleRepresentation>) ApiClient.Deserialize(response.Content, typeof(List<RoleRepresentation>), response.Headers);
        }
    
        /// <summary>
        ///  Get effective client roles Returns the roles for the client that are associated with the client’s scope.
        /// </summary>
        /// <param name="realm">realm name (not id!)</param>
        /// <param name="id"></param>
        /// <param name="_client"></param>
        /// <param name="briefRepresentation">if false, return roles with their attributes</param>
        /// <returns>List&lt;RoleRepresentation&gt;</returns>
        public List<RoleRepresentation> GetClientScopeScopeMappingsClientComposite (string realm, string id, string _client, string briefRepresentation)
        {
            // verify the required parameter 'realm' is set
            if (realm == null) throw new ApiException(400, "Missing required parameter 'realm' when calling GetClientScopeScopeMappingsClientComposite");
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling GetClientScopeScopeMappingsClientComposite");
            // verify the required parameter '_client' is set
            if (_client == null) throw new ApiException(400, "Missing required parameter '_client' when calling GetClientScopeScopeMappingsClientComposite");
    
            var path = "/{realm}/client-scopes/{id}/scope-mappings/clients/{client}/composite";
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
                throw new ApiException ((int)response.StatusCode, "Error calling GetClientScopeScopeMappingsClientComposite: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling GetClientScopeScopeMappingsClientComposite: " + response.ErrorMessage, response.ErrorMessage);
    
            return (List<RoleRepresentation>) ApiClient.Deserialize(response.Content, typeof(List<RoleRepresentation>), response.Headers);
        }
    
        /// <summary>
        ///  Get realm-level roles associated with the client’s scope
        /// </summary>
        /// <param name="realm">realm name (not id!)</param>
        /// <param name="id"></param>
        /// <returns>List&lt;RoleRepresentation&gt;</returns>
        public List<RoleRepresentation> GetClientScopeScopeMappingsRealm (string realm, string id)
        {
            // verify the required parameter 'realm' is set
            if (realm == null) throw new ApiException(400, "Missing required parameter 'realm' when calling GetClientScopeScopeMappingsRealm");
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling GetClientScopeScopeMappingsRealm");
    
            var path = "/{realm}/client-scopes/{id}/scope-mappings/realm";
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
                throw new ApiException ((int)response.StatusCode, "Error calling GetClientScopeScopeMappingsRealm: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling GetClientScopeScopeMappingsRealm: " + response.ErrorMessage, response.ErrorMessage);
    
            return (List<RoleRepresentation>) ApiClient.Deserialize(response.Content, typeof(List<RoleRepresentation>), response.Headers);
        }
    
        /// <summary>
        ///  Get realm-level roles that are available to attach to this client’s scope
        /// </summary>
        /// <param name="realm">realm name (not id!)</param>
        /// <param name="id"></param>
        /// <returns>List&lt;RoleRepresentation&gt;</returns>
        public List<RoleRepresentation> GetClientScopeScopeMappingsRealmAvailable (string realm, string id)
        {
            // verify the required parameter 'realm' is set
            if (realm == null) throw new ApiException(400, "Missing required parameter 'realm' when calling GetClientScopeScopeMappingsRealmAvailable");
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling GetClientScopeScopeMappingsRealmAvailable");
    
            var path = "/{realm}/client-scopes/{id}/scope-mappings/realm/available";
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
                throw new ApiException ((int)response.StatusCode, "Error calling GetClientScopeScopeMappingsRealmAvailable: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling GetClientScopeScopeMappingsRealmAvailable: " + response.ErrorMessage, response.ErrorMessage);
    
            return (List<RoleRepresentation>) ApiClient.Deserialize(response.Content, typeof(List<RoleRepresentation>), response.Headers);
        }
    
        /// <summary>
        ///  Get effective realm-level roles associated with the client’s scope What this does is recurse any composite roles associated with the client’s scope and adds the roles to this lists.
        /// </summary>
        /// <param name="realm">realm name (not id!)</param>
        /// <param name="id"></param>
        /// <param name="briefRepresentation">if false, return roles with their attributes</param>
        /// <returns>List&lt;RoleRepresentation&gt;</returns>
        public List<RoleRepresentation> GetClientScopeScopeMappingsRealmComposite (string realm, string id, string briefRepresentation)
        {
            // verify the required parameter 'realm' is set
            if (realm == null) throw new ApiException(400, "Missing required parameter 'realm' when calling GetClientScopeScopeMappingsRealmComposite");
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling GetClientScopeScopeMappingsRealmComposite");
    
            var path = "/{realm}/client-scopes/{id}/scope-mappings/realm/composite";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "realm" + "}", ApiClient.ParameterToString(realm));
path = path.Replace("{" + "id" + "}", ApiClient.ParameterToString(id));
    
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
                throw new ApiException ((int)response.StatusCode, "Error calling GetClientScopeScopeMappingsRealmComposite: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling GetClientScopeScopeMappingsRealmComposite: " + response.ErrorMessage, response.ErrorMessage);
    
            return (List<RoleRepresentation>) ApiClient.Deserialize(response.Content, typeof(List<RoleRepresentation>), response.Headers);
        }
    
        /// <summary>
        ///  Get all scope mappings for the client
        /// </summary>
        /// <param name="realm">realm name (not id!)</param>
        /// <param name="id"></param>
        /// <returns>MappingsRepresentation</returns>
        public MappingsRepresentation GetClientTemplateScopeMappings (string realm, string id)
        {
            // verify the required parameter 'realm' is set
            if (realm == null) throw new ApiException(400, "Missing required parameter 'realm' when calling GetClientTemplateScopeMappings");
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling GetClientTemplateScopeMappings");
    
            var path = "/{realm}/client-templates/{id}/scope-mappings";
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
                throw new ApiException ((int)response.StatusCode, "Error calling GetClientTemplateScopeMappings: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling GetClientTemplateScopeMappings: " + response.ErrorMessage, response.ErrorMessage);
    
            return (MappingsRepresentation) ApiClient.Deserialize(response.Content, typeof(MappingsRepresentation), response.Headers);
        }
    
        /// <summary>
        ///  Get the roles associated with a client’s scope Returns roles for the client.
        /// </summary>
        /// <param name="realm">realm name (not id!)</param>
        /// <param name="id"></param>
        /// <param name="_client"></param>
        /// <returns>List&lt;RoleRepresentation&gt;</returns>
        public List<RoleRepresentation> GetClientTemplateScopeMappingsClient (string realm, string id, string _client)
        {
            // verify the required parameter 'realm' is set
            if (realm == null) throw new ApiException(400, "Missing required parameter 'realm' when calling GetClientTemplateScopeMappingsClient");
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling GetClientTemplateScopeMappingsClient");
            // verify the required parameter '_client' is set
            if (_client == null) throw new ApiException(400, "Missing required parameter '_client' when calling GetClientTemplateScopeMappingsClient");
    
            var path = "/{realm}/client-templates/{id}/scope-mappings/clients/{client}";
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
                throw new ApiException ((int)response.StatusCode, "Error calling GetClientTemplateScopeMappingsClient: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling GetClientTemplateScopeMappingsClient: " + response.ErrorMessage, response.ErrorMessage);
    
            return (List<RoleRepresentation>) ApiClient.Deserialize(response.Content, typeof(List<RoleRepresentation>), response.Headers);
        }
    
        /// <summary>
        ///  The available client-level roles Returns the roles for the client that can be associated with the client’s scope
        /// </summary>
        /// <param name="realm">realm name (not id!)</param>
        /// <param name="id"></param>
        /// <param name="_client"></param>
        /// <returns>List&lt;RoleRepresentation&gt;</returns>
        public List<RoleRepresentation> GetClientTemplateScopeMappingsClientAvailable (string realm, string id, string _client)
        {
            // verify the required parameter 'realm' is set
            if (realm == null) throw new ApiException(400, "Missing required parameter 'realm' when calling GetClientTemplateScopeMappingsClientAvailable");
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling GetClientTemplateScopeMappingsClientAvailable");
            // verify the required parameter '_client' is set
            if (_client == null) throw new ApiException(400, "Missing required parameter '_client' when calling GetClientTemplateScopeMappingsClientAvailable");
    
            var path = "/{realm}/client-templates/{id}/scope-mappings/clients/{client}/available";
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
                throw new ApiException ((int)response.StatusCode, "Error calling GetClientTemplateScopeMappingsClientAvailable: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling GetClientTemplateScopeMappingsClientAvailable: " + response.ErrorMessage, response.ErrorMessage);
    
            return (List<RoleRepresentation>) ApiClient.Deserialize(response.Content, typeof(List<RoleRepresentation>), response.Headers);
        }
    
        /// <summary>
        ///  Get effective client roles Returns the roles for the client that are associated with the client’s scope.
        /// </summary>
        /// <param name="realm">realm name (not id!)</param>
        /// <param name="id"></param>
        /// <param name="_client"></param>
        /// <param name="briefRepresentation">if false, return roles with their attributes</param>
        /// <returns>List&lt;RoleRepresentation&gt;</returns>
        public List<RoleRepresentation> GetClientTemplateScopeMappingsClientComposite (string realm, string id, string _client, string briefRepresentation)
        {
            // verify the required parameter 'realm' is set
            if (realm == null) throw new ApiException(400, "Missing required parameter 'realm' when calling GetClientTemplateScopeMappingsClientComposite");
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling GetClientTemplateScopeMappingsClientComposite");
            // verify the required parameter '_client' is set
            if (_client == null) throw new ApiException(400, "Missing required parameter '_client' when calling GetClientTemplateScopeMappingsClientComposite");
    
            var path = "/{realm}/client-templates/{id}/scope-mappings/clients/{client}/composite";
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
                throw new ApiException ((int)response.StatusCode, "Error calling GetClientTemplateScopeMappingsClientComposite: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling GetClientTemplateScopeMappingsClientComposite: " + response.ErrorMessage, response.ErrorMessage);
    
            return (List<RoleRepresentation>) ApiClient.Deserialize(response.Content, typeof(List<RoleRepresentation>), response.Headers);
        }
    
        /// <summary>
        ///  Get realm-level roles associated with the client’s scope
        /// </summary>
        /// <param name="realm">realm name (not id!)</param>
        /// <param name="id"></param>
        /// <returns>List&lt;RoleRepresentation&gt;</returns>
        public List<RoleRepresentation> GetClientTemplateScopeMappingsRealm (string realm, string id)
        {
            // verify the required parameter 'realm' is set
            if (realm == null) throw new ApiException(400, "Missing required parameter 'realm' when calling GetClientTemplateScopeMappingsRealm");
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling GetClientTemplateScopeMappingsRealm");
    
            var path = "/{realm}/client-templates/{id}/scope-mappings/realm";
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
                throw new ApiException ((int)response.StatusCode, "Error calling GetClientTemplateScopeMappingsRealm: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling GetClientTemplateScopeMappingsRealm: " + response.ErrorMessage, response.ErrorMessage);
    
            return (List<RoleRepresentation>) ApiClient.Deserialize(response.Content, typeof(List<RoleRepresentation>), response.Headers);
        }
    
        /// <summary>
        ///  Get realm-level roles that are available to attach to this client’s scope
        /// </summary>
        /// <param name="realm">realm name (not id!)</param>
        /// <param name="id"></param>
        /// <returns>List&lt;RoleRepresentation&gt;</returns>
        public List<RoleRepresentation> GetClientTemplateScopeMappingsRealmAvailable (string realm, string id)
        {
            // verify the required parameter 'realm' is set
            if (realm == null) throw new ApiException(400, "Missing required parameter 'realm' when calling GetClientTemplateScopeMappingsRealmAvailable");
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling GetClientTemplateScopeMappingsRealmAvailable");
    
            var path = "/{realm}/client-templates/{id}/scope-mappings/realm/available";
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
                throw new ApiException ((int)response.StatusCode, "Error calling GetClientTemplateScopeMappingsRealmAvailable: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling GetClientTemplateScopeMappingsRealmAvailable: " + response.ErrorMessage, response.ErrorMessage);
    
            return (List<RoleRepresentation>) ApiClient.Deserialize(response.Content, typeof(List<RoleRepresentation>), response.Headers);
        }
    
        /// <summary>
        ///  Get effective realm-level roles associated with the client’s scope What this does is recurse any composite roles associated with the client’s scope and adds the roles to this lists.
        /// </summary>
        /// <param name="realm">realm name (not id!)</param>
        /// <param name="id"></param>
        /// <param name="briefRepresentation">if false, return roles with their attributes</param>
        /// <returns>List&lt;RoleRepresentation&gt;</returns>
        public List<RoleRepresentation> GetClientTemplateScopeMappingsRealmComposite (string realm, string id, string briefRepresentation)
        {
            // verify the required parameter 'realm' is set
            if (realm == null) throw new ApiException(400, "Missing required parameter 'realm' when calling GetClientTemplateScopeMappingsRealmComposite");
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling GetClientTemplateScopeMappingsRealmComposite");
    
            var path = "/{realm}/client-templates/{id}/scope-mappings/realm/composite";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "realm" + "}", ApiClient.ParameterToString(realm));
path = path.Replace("{" + "id" + "}", ApiClient.ParameterToString(id));
    
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
                throw new ApiException ((int)response.StatusCode, "Error calling GetClientTemplateScopeMappingsRealmComposite: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling GetClientTemplateScopeMappingsRealmComposite: " + response.ErrorMessage, response.ErrorMessage);
    
            return (List<RoleRepresentation>) ApiClient.Deserialize(response.Content, typeof(List<RoleRepresentation>), response.Headers);
        }
    
        /// <summary>
        ///  Add client-level roles to the client’s scope
        /// </summary>
        /// <param name="realm">realm name (not id!)</param>
        /// <param name="id"></param>
        /// <param name="_client"></param>
        /// <param name="body">RoleRepresentation</param>
        /// <returns></returns>
        public void PostClientScopeMappingsClient (string realm, string id, string _client, RoleRepresentation body)
        {
            // verify the required parameter 'realm' is set
            if (realm == null) throw new ApiException(400, "Missing required parameter 'realm' when calling PostClientScopeMappingsClient");
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling PostClientScopeMappingsClient");
            // verify the required parameter '_client' is set
            if (_client == null) throw new ApiException(400, "Missing required parameter '_client' when calling PostClientScopeMappingsClient");
    
            var path = "/{realm}/clients/{id}/scope-mappings/clients/{client}";
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
                throw new ApiException ((int)response.StatusCode, "Error calling PostClientScopeMappingsClient: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling PostClientScopeMappingsClient: " + response.ErrorMessage, response.ErrorMessage);
    
            return;
        }
    
        /// <summary>
        ///  Add a set of realm-level roles to the client’s scope
        /// </summary>
        /// <param name="realm">realm name (not id!)</param>
        /// <param name="id"></param>
        /// <param name="body">RoleRepresentation</param>
        /// <returns></returns>
        public void PostClientScopeMappingsRealm (string realm, string id, RoleRepresentation body)
        {
            // verify the required parameter 'realm' is set
            if (realm == null) throw new ApiException(400, "Missing required parameter 'realm' when calling PostClientScopeMappingsRealm");
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling PostClientScopeMappingsRealm");
    
            var path = "/{realm}/clients/{id}/scope-mappings/realm";
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
                throw new ApiException ((int)response.StatusCode, "Error calling PostClientScopeMappingsRealm: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling PostClientScopeMappingsRealm: " + response.ErrorMessage, response.ErrorMessage);
    
            return;
        }
    
        /// <summary>
        ///  Add client-level roles to the client’s scope
        /// </summary>
        /// <param name="realm">realm name (not id!)</param>
        /// <param name="id"></param>
        /// <param name="_client"></param>
        /// <param name="body">RoleRepresentation</param>
        /// <returns></returns>
        public void PostClientScopeScopeMappingsClient (string realm, string id, string _client, RoleRepresentation body)
        {
            // verify the required parameter 'realm' is set
            if (realm == null) throw new ApiException(400, "Missing required parameter 'realm' when calling PostClientScopeScopeMappingsClient");
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling PostClientScopeScopeMappingsClient");
            // verify the required parameter '_client' is set
            if (_client == null) throw new ApiException(400, "Missing required parameter '_client' when calling PostClientScopeScopeMappingsClient");
    
            var path = "/{realm}/client-scopes/{id}/scope-mappings/clients/{client}";
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
                throw new ApiException ((int)response.StatusCode, "Error calling PostClientScopeScopeMappingsClient: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling PostClientScopeScopeMappingsClient: " + response.ErrorMessage, response.ErrorMessage);
    
            return;
        }
    
        /// <summary>
        ///  Add a set of realm-level roles to the client’s scope
        /// </summary>
        /// <param name="realm">realm name (not id!)</param>
        /// <param name="id"></param>
        /// <param name="body">RoleRepresentation</param>
        /// <returns></returns>
        public void PostClientScopeScopeMappingsRealm (string realm, string id, RoleRepresentation body)
        {
            // verify the required parameter 'realm' is set
            if (realm == null) throw new ApiException(400, "Missing required parameter 'realm' when calling PostClientScopeScopeMappingsRealm");
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling PostClientScopeScopeMappingsRealm");
    
            var path = "/{realm}/client-scopes/{id}/scope-mappings/realm";
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
                throw new ApiException ((int)response.StatusCode, "Error calling PostClientScopeScopeMappingsRealm: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling PostClientScopeScopeMappingsRealm: " + response.ErrorMessage, response.ErrorMessage);
    
            return;
        }
    
        /// <summary>
        ///  Add client-level roles to the client’s scope
        /// </summary>
        /// <param name="realm">realm name (not id!)</param>
        /// <param name="id"></param>
        /// <param name="_client"></param>
        /// <param name="body">RoleRepresentation</param>
        /// <returns></returns>
        public void PostClientTemplateScopeMappingsClient (string realm, string id, string _client, RoleRepresentation body)
        {
            // verify the required parameter 'realm' is set
            if (realm == null) throw new ApiException(400, "Missing required parameter 'realm' when calling PostClientTemplateScopeMappingsClient");
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling PostClientTemplateScopeMappingsClient");
            // verify the required parameter '_client' is set
            if (_client == null) throw new ApiException(400, "Missing required parameter '_client' when calling PostClientTemplateScopeMappingsClient");
    
            var path = "/{realm}/client-templates/{id}/scope-mappings/clients/{client}";
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
                throw new ApiException ((int)response.StatusCode, "Error calling PostClientTemplateScopeMappingsClient: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling PostClientTemplateScopeMappingsClient: " + response.ErrorMessage, response.ErrorMessage);
    
            return;
        }
    
        /// <summary>
        ///  Add a set of realm-level roles to the client’s scope
        /// </summary>
        /// <param name="realm">realm name (not id!)</param>
        /// <param name="id"></param>
        /// <param name="body">RoleRepresentation</param>
        /// <returns></returns>
        public void PostClientTemplateScopeMappingsRealm (string realm, string id, RoleRepresentation body)
        {
            // verify the required parameter 'realm' is set
            if (realm == null) throw new ApiException(400, "Missing required parameter 'realm' when calling PostClientTemplateScopeMappingsRealm");
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling PostClientTemplateScopeMappingsRealm");
    
            var path = "/{realm}/client-templates/{id}/scope-mappings/realm";
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
                throw new ApiException ((int)response.StatusCode, "Error calling PostClientTemplateScopeMappingsRealm: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling PostClientTemplateScopeMappingsRealm: " + response.ErrorMessage, response.ErrorMessage);
    
            return;
        }
    
    }
}
