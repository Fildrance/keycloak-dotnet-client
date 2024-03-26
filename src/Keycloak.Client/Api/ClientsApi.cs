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
    public interface IClientsApi
    {
        /// <summary>
        ///  Delete the client
        /// </summary>
        /// <param name="realm">realm name (not id!)</param>
        /// <param name="id"></param>
        /// <returns></returns>
        void DeleteClientByRealmById (string realm, string id);
        /// <summary>
        ///  
        /// </summary>
        /// <param name="realm">realm name (not id!)</param>
        /// <param name="id"></param>
        /// <param name="clientScopeId"></param>
        /// <returns></returns>
        void DeleteDefaultClientScope (string realm, string id, string clientScopeId);
        /// <summary>
        ///  Unregister a cluster node from the client
        /// </summary>
        /// <param name="realm">realm name (not id!)</param>
        /// <param name="id"></param>
        /// <param name="node"></param>
        /// <returns></returns>
        void DeleteNode (string realm, string id, string node);
        /// <summary>
        ///  
        /// </summary>
        /// <param name="realm">realm name (not id!)</param>
        /// <param name="id"></param>
        /// <param name="clientScopeId"></param>
        /// <returns></returns>
        void DeleteOptionalClientScope (string realm, string id, string clientScopeId);
        /// <summary>
        ///  Invalidate the rotated secret for the client
        /// </summary>
        /// <param name="realm">realm name (not id!)</param>
        /// <param name="id"></param>
        /// <returns></returns>
        void DeleteRotated (string realm, string id);
        /// <summary>
        ///  Get representation of the client
        /// </summary>
        /// <param name="realm">realm name (not id!)</param>
        /// <param name="id"></param>
        /// <returns>ClientRepresentation</returns>
        ClientRepresentation GetClientByRealmById (string realm, string id);
        /// <summary>
        ///  Return object stating whether client Authorization permissions have been initialized or not and a reference
        /// </summary>
        /// <param name="realm">realm name (not id!)</param>
        /// <param name="id"></param>
        /// <returns>ManagementPermissionReference</returns>
        ManagementPermissionReference GetClientManagementPermissions (string realm, string id);
        /// <summary>
        ///  Get the client secret
        /// </summary>
        /// <param name="realm">realm name (not id!)</param>
        /// <param name="id"></param>
        /// <returns>CredentialRepresentation</returns>
        CredentialRepresentation GetClientSecret (string realm, string id);
        /// <summary>
        ///  Get user sessions for client Returns a list of user sessions associated with this client
        /// </summary>
        /// <param name="realm">realm name (not id!)</param>
        /// <param name="id"></param>
        /// <param name="first">Paging offset</param>
        /// <param name="max">Maximum results size (defaults to 100)</param>
        /// <returns>List&lt;UserSessionRepresentation&gt;</returns>
        List<UserSessionRepresentation> GetClientUserSessions (string realm, string id, string first, string max);
        /// <summary>
        ///  Get clients belonging to the realm.
        /// </summary>
        /// <param name="realm">realm name (not id!)</param>
        /// <param name="clientId">filter by clientId</param>
        /// <param name="first">the first result</param>
        /// <param name="max">the max results to return</param>
        /// <param name="q"></param>
        /// <param name="search">whether this is a search query or a getClientById query</param>
        /// <param name="viewableOnly">filter clients that cannot be viewed in full by admin</param>
        /// <returns>List&lt;ClientRepresentation&gt;</returns>
        List<ClientRepresentation> GetClients (string realm, string clientId, string first, string max, string q, string search, string viewableOnly);
        /// <summary>
        ///  Get default client scopes.  Only name and ids are returned.
        /// </summary>
        /// <param name="realm">realm name (not id!)</param>
        /// <param name="id"></param>
        /// <returns>List&lt;ClientScopeRepresentation&gt;</returns>
        List<ClientScopeRepresentation> GetDefaultClientScopes (string realm, string id);
        /// <summary>
        ///  Create JSON with payload of example access token
        /// </summary>
        /// <param name="realm">realm name (not id!)</param>
        /// <param name="id"></param>
        /// <param name="scope"></param>
        /// <param name="userId"></param>
        /// <returns>AccessToken</returns>
        AccessToken GetGenerateExampleAccessToken (string realm, string id, string scope, string userId);
        /// <summary>
        ///  Create JSON with payload of example id token
        /// </summary>
        /// <param name="realm">realm name (not id!)</param>
        /// <param name="id"></param>
        /// <param name="scope"></param>
        /// <param name="userId"></param>
        /// <returns>IDToken</returns>
        IDToken GetGenerateExampleIdToken (string realm, string id, string scope, string userId);
        /// <summary>
        ///  Create JSON with payload of example user info
        /// </summary>
        /// <param name="realm">realm name (not id!)</param>
        /// <param name="id"></param>
        /// <param name="scope"></param>
        /// <param name="userId"></param>
        /// <returns>Dictionary&lt;string, Object&gt;</returns>
        Dictionary<string, Object> GetGenerateExampleUserinfo (string realm, string id, string scope, string userId);
        /// <summary>
        ///  Get effective scope mapping of all roles of particular role container, which this client is defacto allowed to have in the accessToken issued for him.
        /// </summary>
        /// <param name="realm">realm name (not id!)</param>
        /// <param name="id"></param>
        /// <param name="roleContainerId">either realm name OR client UUID</param>
        /// <param name="scope"></param>
        /// <returns>List&lt;RoleRepresentation&gt;</returns>
        List<RoleRepresentation> GetGranted (string realm, string id, string roleContainerId, string scope);
        /// <summary>
        ///  
        /// </summary>
        /// <param name="realm">realm name (not id!)</param>
        /// <param name="id"></param>
        /// <param name="providerId"></param>
        /// <returns></returns>
        void GetInstallationProvider (string realm, string id, string providerId);
        /// <summary>
        ///  Get roles, which this client doesn’t have scope for and can’t have them in the accessToken issued for him.
        /// </summary>
        /// <param name="realm">realm name (not id!)</param>
        /// <param name="id"></param>
        /// <param name="roleContainerId">either realm name OR client UUID</param>
        /// <param name="scope"></param>
        /// <returns>List&lt;RoleRepresentation&gt;</returns>
        List<RoleRepresentation> GetNotGranted (string realm, string id, string roleContainerId, string scope);
        /// <summary>
        ///  Get application offline session count Returns a number of offline user sessions associated with this client { \\\&quot;count\\\&quot;: number }
        /// </summary>
        /// <param name="realm">realm name (not id!)</param>
        /// <param name="id"></param>
        /// <returns>Dictionary&lt;string, long?&gt;</returns>
        Dictionary<string, long?> GetOfflineSessionCount (string realm, string id);
        /// <summary>
        ///  Get offline sessions for client Returns a list of offline user sessions associated with this client
        /// </summary>
        /// <param name="realm">realm name (not id!)</param>
        /// <param name="id"></param>
        /// <param name="first">Paging offset</param>
        /// <param name="max">Maximum results size (defaults to 100)</param>
        /// <returns>List&lt;UserSessionRepresentation&gt;</returns>
        List<UserSessionRepresentation> GetOfflineSessions (string realm, string id, string first, string max);
        /// <summary>
        ///  Get optional client scopes.  Only name and ids are returned.
        /// </summary>
        /// <param name="realm">realm name (not id!)</param>
        /// <param name="id"></param>
        /// <returns>List&lt;ClientScopeRepresentation&gt;</returns>
        List<ClientScopeRepresentation> GetOptionalClientScopes (string realm, string id);
        /// <summary>
        ///  Return list of all protocol mappers, which will be used when generating tokens issued for particular client.
        /// </summary>
        /// <param name="realm">realm name (not id!)</param>
        /// <param name="id"></param>
        /// <param name="scope"></param>
        /// <returns>List&lt;ProtocolMapperEvaluationRepresentation&gt;</returns>
        List<ProtocolMapperEvaluationRepresentation> GetProtocolMappers (string realm, string id, string scope);
        /// <summary>
        ///  Get the rotated client secret
        /// </summary>
        /// <param name="realm">realm name (not id!)</param>
        /// <param name="id"></param>
        /// <returns>CredentialRepresentation</returns>
        CredentialRepresentation GetRotated (string realm, string id);
        /// <summary>
        ///  Get a user dedicated to the service account
        /// </summary>
        /// <param name="realm">realm name (not id!)</param>
        /// <param name="id"></param>
        /// <returns>UserRepresentation</returns>
        UserRepresentation GetServiceAccountUser (string realm, string id);
        /// <summary>
        ///  Get application session count Returns a number of user sessions associated with this client { \\\&quot;count\\\&quot;: number }
        /// </summary>
        /// <param name="realm">realm name (not id!)</param>
        /// <param name="id"></param>
        /// <returns>Dictionary&lt;string, long?&gt;</returns>
        Dictionary<string, long?> GetSessionCount (string realm, string id);
        /// <summary>
        ///  Test if registered cluster nodes are available Tests availability by sending &#x27;ping&#x27; request to all cluster nodes.
        /// </summary>
        /// <param name="realm">realm name (not id!)</param>
        /// <param name="id"></param>
        /// <returns>GlobalRequestResult</returns>
        GlobalRequestResult GetTestNodesAvailable (string realm, string id);
        /// <summary>
        ///  Push the client’s revocation policy to its admin URL If the client has an admin URL, push revocation policy to it.
        /// </summary>
        /// <param name="realm">realm name (not id!)</param>
        /// <param name="id"></param>
        /// <returns>GlobalRequestResult</returns>
        GlobalRequestResult PostClientPushRevocation (string realm, string id);
        /// <summary>
        ///  Generate a new secret for the client
        /// </summary>
        /// <param name="realm">realm name (not id!)</param>
        /// <param name="id"></param>
        /// <returns>CredentialRepresentation</returns>
        CredentialRepresentation PostClientSecret (string realm, string id);
        /// <summary>
        ///  Create a new client Client’s client_id must be unique!
        /// </summary>
        /// <param name="realm">realm name (not id!)</param>
        /// <param name="body">ClientRepresentation</param>
        /// <returns></returns>
        void PostClients (string realm, ClientRepresentation body);
        /// <summary>
        ///  Register a cluster node with the client Manually register cluster node to this client - usually it’s not needed to call this directly as adapter should handle by sending registration request to Keycloak
        /// </summary>
        /// <param name="realm">realm name (not id!)</param>
        /// <param name="id"></param>
        /// <param name="body">[string]</param>
        /// <returns></returns>
        void PostNodes (string realm, string id, string body);
        /// <summary>
        ///  Generate a new registration access token for the client
        /// </summary>
        /// <param name="realm">realm name (not id!)</param>
        /// <param name="id"></param>
        /// <returns>ClientRepresentation</returns>
        ClientRepresentation PostRegistrationAccessToken (string realm, string id);
        /// <summary>
        ///  Update the client
        /// </summary>
        /// <param name="realm">realm name (not id!)</param>
        /// <param name="id"></param>
        /// <param name="body">ClientRepresentation</param>
        /// <returns></returns>
        void PutClient (string realm, string id, ClientRepresentation body);
        /// <summary>
        ///  Return object stating whether client Authorization permissions have been initialized or not and a reference
        /// </summary>
        /// <param name="realm">realm name (not id!)</param>
        /// <param name="id"></param>
        /// <param name="body">ManagementPermissionReference</param>
        /// <returns>ManagementPermissionReference</returns>
        ManagementPermissionReference PutClientManagementPermissions (string realm, string id, ManagementPermissionReference body);
        /// <summary>
        ///  
        /// </summary>
        /// <param name="realm">realm name (not id!)</param>
        /// <param name="id"></param>
        /// <param name="clientScopeId"></param>
        /// <returns></returns>
        void PutDefaultClientScope (string realm, string id, string clientScopeId);
        /// <summary>
        ///  
        /// </summary>
        /// <param name="realm">realm name (not id!)</param>
        /// <param name="id"></param>
        /// <param name="clientScopeId"></param>
        /// <returns></returns>
        void PutOptionalClientScope (string realm, string id, string clientScopeId);
    }
  
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public class ClientsApi : IClientsApi
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ClientsApi"/> class.
        /// </summary>
        /// <param name="apiClient"> an instance of ApiClient (optional)</param>
        /// <returns></returns>
        public ClientsApi(ApiClient apiClient = null)
        {
            if (apiClient == null) // use the default one in Configuration
                this.ApiClient = Configuration.DefaultApiClient; 
            else
                this.ApiClient = apiClient;
        }
    
        /// <summary>
        /// Initializes a new instance of the <see cref="ClientsApi"/> class.
        /// </summary>
        /// <returns></returns>
        public ClientsApi(String basePath)
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
        ///  Delete the client
        /// </summary>
        /// <param name="realm">realm name (not id!)</param>
        /// <param name="id"></param>
        /// <returns></returns>
        public void DeleteClientByRealmById (string realm, string id)
        {
            // verify the required parameter 'realm' is set
            if (realm == null) throw new ApiException(400, "Missing required parameter 'realm' when calling DeleteClientByRealmById");
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling DeleteClientByRealmById");
    
            var path = "/{realm}/clients/{id}";
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
            RestResponseBase response = (RestResponseBase) ApiClient.CallApi(path, Method.Delete, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling DeleteClientByRealmById: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling DeleteClientByRealmById: " + response.ErrorMessage, response.ErrorMessage);
    
            return;
        }
    
        /// <summary>
        ///  
        /// </summary>
        /// <param name="realm">realm name (not id!)</param>
        /// <param name="id"></param>
        /// <param name="clientScopeId"></param>
        /// <returns></returns>
        public void DeleteDefaultClientScope (string realm, string id, string clientScopeId)
        {
            // verify the required parameter 'realm' is set
            if (realm == null) throw new ApiException(400, "Missing required parameter 'realm' when calling DeleteDefaultClientScope");
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling DeleteDefaultClientScope");
            // verify the required parameter 'clientScopeId' is set
            if (clientScopeId == null) throw new ApiException(400, "Missing required parameter 'clientScopeId' when calling DeleteDefaultClientScope");
    
            var path = "/{realm}/clients/{id}/default-client-scopes/{clientScopeId}";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "realm" + "}", ApiClient.ParameterToString(realm));
path = path.Replace("{" + "id" + "}", ApiClient.ParameterToString(id));
path = path.Replace("{" + "clientScopeId" + "}", ApiClient.ParameterToString(clientScopeId));
    
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
                throw new ApiException ((int)response.StatusCode, "Error calling DeleteDefaultClientScope: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling DeleteDefaultClientScope: " + response.ErrorMessage, response.ErrorMessage);
    
            return;
        }
    
        /// <summary>
        ///  Unregister a cluster node from the client
        /// </summary>
        /// <param name="realm">realm name (not id!)</param>
        /// <param name="id"></param>
        /// <param name="node"></param>
        /// <returns></returns>
        public void DeleteNode (string realm, string id, string node)
        {
            // verify the required parameter 'realm' is set
            if (realm == null) throw new ApiException(400, "Missing required parameter 'realm' when calling DeleteNode");
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling DeleteNode");
            // verify the required parameter 'node' is set
            if (node == null) throw new ApiException(400, "Missing required parameter 'node' when calling DeleteNode");
    
            var path = "/{realm}/clients/{id}/nodes/{node}";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "realm" + "}", ApiClient.ParameterToString(realm));
path = path.Replace("{" + "id" + "}", ApiClient.ParameterToString(id));
path = path.Replace("{" + "node" + "}", ApiClient.ParameterToString(node));
    
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
                throw new ApiException ((int)response.StatusCode, "Error calling DeleteNode: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling DeleteNode: " + response.ErrorMessage, response.ErrorMessage);
    
            return;
        }
    
        /// <summary>
        ///  
        /// </summary>
        /// <param name="realm">realm name (not id!)</param>
        /// <param name="id"></param>
        /// <param name="clientScopeId"></param>
        /// <returns></returns>
        public void DeleteOptionalClientScope (string realm, string id, string clientScopeId)
        {
            // verify the required parameter 'realm' is set
            if (realm == null) throw new ApiException(400, "Missing required parameter 'realm' when calling DeleteOptionalClientScope");
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling DeleteOptionalClientScope");
            // verify the required parameter 'clientScopeId' is set
            if (clientScopeId == null) throw new ApiException(400, "Missing required parameter 'clientScopeId' when calling DeleteOptionalClientScope");
    
            var path = "/{realm}/clients/{id}/optional-client-scopes/{clientScopeId}";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "realm" + "}", ApiClient.ParameterToString(realm));
path = path.Replace("{" + "id" + "}", ApiClient.ParameterToString(id));
path = path.Replace("{" + "clientScopeId" + "}", ApiClient.ParameterToString(clientScopeId));
    
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
                throw new ApiException ((int)response.StatusCode, "Error calling DeleteOptionalClientScope: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling DeleteOptionalClientScope: " + response.ErrorMessage, response.ErrorMessage);
    
            return;
        }
    
        /// <summary>
        ///  Invalidate the rotated secret for the client
        /// </summary>
        /// <param name="realm">realm name (not id!)</param>
        /// <param name="id"></param>
        /// <returns></returns>
        public void DeleteRotated (string realm, string id)
        {
            // verify the required parameter 'realm' is set
            if (realm == null) throw new ApiException(400, "Missing required parameter 'realm' when calling DeleteRotated");
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling DeleteRotated");
    
            var path = "/{realm}/clients/{id}/client-secret/rotated";
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
            RestResponseBase response = (RestResponseBase) ApiClient.CallApi(path, Method.Delete, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling DeleteRotated: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling DeleteRotated: " + response.ErrorMessage, response.ErrorMessage);
    
            return;
        }
    
        /// <summary>
        ///  Get representation of the client
        /// </summary>
        /// <param name="realm">realm name (not id!)</param>
        /// <param name="id"></param>
        /// <returns>ClientRepresentation</returns>
        public ClientRepresentation GetClientByRealmById (string realm, string id)
        {
            // verify the required parameter 'realm' is set
            if (realm == null) throw new ApiException(400, "Missing required parameter 'realm' when calling GetClientByRealmById");
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling GetClientByRealmById");
    
            var path = "/{realm}/clients/{id}";
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
                throw new ApiException ((int)response.StatusCode, "Error calling GetClientByRealmById: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling GetClientByRealmById: " + response.ErrorMessage, response.ErrorMessage);
    
            return (ClientRepresentation) ApiClient.Deserialize(response.Content, typeof(ClientRepresentation), response.Headers);
        }
    
        /// <summary>
        ///  Return object stating whether client Authorization permissions have been initialized or not and a reference
        /// </summary>
        /// <param name="realm">realm name (not id!)</param>
        /// <param name="id"></param>
        /// <returns>ManagementPermissionReference</returns>
        public ManagementPermissionReference GetClientManagementPermissions (string realm, string id)
        {
            // verify the required parameter 'realm' is set
            if (realm == null) throw new ApiException(400, "Missing required parameter 'realm' when calling GetClientManagementPermissions");
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling GetClientManagementPermissions");
    
            var path = "/{realm}/clients/{id}/management/permissions";
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
                throw new ApiException ((int)response.StatusCode, "Error calling GetClientManagementPermissions: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling GetClientManagementPermissions: " + response.ErrorMessage, response.ErrorMessage);
    
            return (ManagementPermissionReference) ApiClient.Deserialize(response.Content, typeof(ManagementPermissionReference), response.Headers);
        }
    
        /// <summary>
        ///  Get the client secret
        /// </summary>
        /// <param name="realm">realm name (not id!)</param>
        /// <param name="id"></param>
        /// <returns>CredentialRepresentation</returns>
        public CredentialRepresentation GetClientSecret (string realm, string id)
        {
            // verify the required parameter 'realm' is set
            if (realm == null) throw new ApiException(400, "Missing required parameter 'realm' when calling GetClientSecret");
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling GetClientSecret");
    
            var path = "/{realm}/clients/{id}/client-secret";
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
                throw new ApiException ((int)response.StatusCode, "Error calling GetClientSecret: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling GetClientSecret: " + response.ErrorMessage, response.ErrorMessage);
    
            return (CredentialRepresentation) ApiClient.Deserialize(response.Content, typeof(CredentialRepresentation), response.Headers);
        }
    
        /// <summary>
        ///  Get user sessions for client Returns a list of user sessions associated with this client
        /// </summary>
        /// <param name="realm">realm name (not id!)</param>
        /// <param name="id"></param>
        /// <param name="first">Paging offset</param>
        /// <param name="max">Maximum results size (defaults to 100)</param>
        /// <returns>List&lt;UserSessionRepresentation&gt;</returns>
        public List<UserSessionRepresentation> GetClientUserSessions (string realm, string id, string first, string max)
        {
            // verify the required parameter 'realm' is set
            if (realm == null) throw new ApiException(400, "Missing required parameter 'realm' when calling GetClientUserSessions");
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling GetClientUserSessions");
    
            var path = "/{realm}/clients/{id}/user-sessions";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "realm" + "}", ApiClient.ParameterToString(realm));
path = path.Replace("{" + "id" + "}", ApiClient.ParameterToString(id));
    
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
             if (first != null) queryParams.Add("first", ApiClient.ParameterToString(first)); // query parameter
 if (max != null) queryParams.Add("max", ApiClient.ParameterToString(max)); // query parameter
                        
            // authentication setting, if any
            String[] authSettings = new String[] { "access_token" };
    
            // make the HTTP request
            RestResponseBase response = (RestResponseBase) ApiClient.CallApi(path, Method.Get, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling GetClientUserSessions: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling GetClientUserSessions: " + response.ErrorMessage, response.ErrorMessage);
    
            return (List<UserSessionRepresentation>) ApiClient.Deserialize(response.Content, typeof(List<UserSessionRepresentation>), response.Headers);
        }
    
        /// <summary>
        ///  Get clients belonging to the realm.
        /// </summary>
        /// <param name="realm">realm name (not id!)</param>
        /// <param name="clientId">filter by clientId</param>
        /// <param name="first">the first result</param>
        /// <param name="max">the max results to return</param>
        /// <param name="q"></param>
        /// <param name="search">whether this is a search query or a getClientById query</param>
        /// <param name="viewableOnly">filter clients that cannot be viewed in full by admin</param>
        /// <returns>List&lt;ClientRepresentation&gt;</returns>
        public List<ClientRepresentation> GetClients (string realm, string clientId, string first, string max, string q, string search, string viewableOnly)
        {
            // verify the required parameter 'realm' is set
            if (realm == null) throw new ApiException(400, "Missing required parameter 'realm' when calling GetClients");
    
            var path = "/{realm}/clients";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "realm" + "}", ApiClient.ParameterToString(realm));
    
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
             if (clientId != null) queryParams.Add("clientId", ApiClient.ParameterToString(clientId)); // query parameter
 if (first != null) queryParams.Add("first", ApiClient.ParameterToString(first)); // query parameter
 if (max != null) queryParams.Add("max", ApiClient.ParameterToString(max)); // query parameter
 if (q != null) queryParams.Add("q", ApiClient.ParameterToString(q)); // query parameter
 if (search != null) queryParams.Add("search", ApiClient.ParameterToString(search)); // query parameter
 if (viewableOnly != null) queryParams.Add("viewableOnly", ApiClient.ParameterToString(viewableOnly)); // query parameter
                        
            // authentication setting, if any
            String[] authSettings = new String[] { "access_token" };
    
            // make the HTTP request
            RestResponseBase response = (RestResponseBase) ApiClient.CallApi(path, Method.Get, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling GetClients: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling GetClients: " + response.ErrorMessage, response.ErrorMessage);
    
            return (List<ClientRepresentation>) ApiClient.Deserialize(response.Content, typeof(List<ClientRepresentation>), response.Headers);
        }
    
        /// <summary>
        ///  Get default client scopes.  Only name and ids are returned.
        /// </summary>
        /// <param name="realm">realm name (not id!)</param>
        /// <param name="id"></param>
        /// <returns>List&lt;ClientScopeRepresentation&gt;</returns>
        public List<ClientScopeRepresentation> GetDefaultClientScopes (string realm, string id)
        {
            // verify the required parameter 'realm' is set
            if (realm == null) throw new ApiException(400, "Missing required parameter 'realm' when calling GetDefaultClientScopes");
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling GetDefaultClientScopes");
    
            var path = "/{realm}/clients/{id}/default-client-scopes";
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
                throw new ApiException ((int)response.StatusCode, "Error calling GetDefaultClientScopes: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling GetDefaultClientScopes: " + response.ErrorMessage, response.ErrorMessage);
    
            return (List<ClientScopeRepresentation>) ApiClient.Deserialize(response.Content, typeof(List<ClientScopeRepresentation>), response.Headers);
        }
    
        /// <summary>
        ///  Create JSON with payload of example access token
        /// </summary>
        /// <param name="realm">realm name (not id!)</param>
        /// <param name="id"></param>
        /// <param name="scope"></param>
        /// <param name="userId"></param>
        /// <returns>AccessToken</returns>
        public AccessToken GetGenerateExampleAccessToken (string realm, string id, string scope, string userId)
        {
            // verify the required parameter 'realm' is set
            if (realm == null) throw new ApiException(400, "Missing required parameter 'realm' when calling GetGenerateExampleAccessToken");
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling GetGenerateExampleAccessToken");
    
            var path = "/{realm}/clients/{id}/evaluate-scopes/generate-example-access-token";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "realm" + "}", ApiClient.ParameterToString(realm));
path = path.Replace("{" + "id" + "}", ApiClient.ParameterToString(id));
    
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
             if (scope != null) queryParams.Add("scope", ApiClient.ParameterToString(scope)); // query parameter
 if (userId != null) queryParams.Add("userId", ApiClient.ParameterToString(userId)); // query parameter
                        
            // authentication setting, if any
            String[] authSettings = new String[] { "access_token" };
    
            // make the HTTP request
            RestResponseBase response = (RestResponseBase) ApiClient.CallApi(path, Method.Get, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling GetGenerateExampleAccessToken: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling GetGenerateExampleAccessToken: " + response.ErrorMessage, response.ErrorMessage);
    
            return (AccessToken) ApiClient.Deserialize(response.Content, typeof(AccessToken), response.Headers);
        }
    
        /// <summary>
        ///  Create JSON with payload of example id token
        /// </summary>
        /// <param name="realm">realm name (not id!)</param>
        /// <param name="id"></param>
        /// <param name="scope"></param>
        /// <param name="userId"></param>
        /// <returns>IDToken</returns>
        public IDToken GetGenerateExampleIdToken (string realm, string id, string scope, string userId)
        {
            // verify the required parameter 'realm' is set
            if (realm == null) throw new ApiException(400, "Missing required parameter 'realm' when calling GetGenerateExampleIdToken");
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling GetGenerateExampleIdToken");
    
            var path = "/{realm}/clients/{id}/evaluate-scopes/generate-example-id-token";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "realm" + "}", ApiClient.ParameterToString(realm));
path = path.Replace("{" + "id" + "}", ApiClient.ParameterToString(id));
    
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
             if (scope != null) queryParams.Add("scope", ApiClient.ParameterToString(scope)); // query parameter
 if (userId != null) queryParams.Add("userId", ApiClient.ParameterToString(userId)); // query parameter
                        
            // authentication setting, if any
            String[] authSettings = new String[] { "access_token" };
    
            // make the HTTP request
            RestResponseBase response = (RestResponseBase) ApiClient.CallApi(path, Method.Get, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling GetGenerateExampleIdToken: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling GetGenerateExampleIdToken: " + response.ErrorMessage, response.ErrorMessage);
    
            return (IDToken) ApiClient.Deserialize(response.Content, typeof(IDToken), response.Headers);
        }
    
        /// <summary>
        ///  Create JSON with payload of example user info
        /// </summary>
        /// <param name="realm">realm name (not id!)</param>
        /// <param name="id"></param>
        /// <param name="scope"></param>
        /// <param name="userId"></param>
        /// <returns>Dictionary&lt;string, Object&gt;</returns>
        public Dictionary<string, Object> GetGenerateExampleUserinfo (string realm, string id, string scope, string userId)
        {
            // verify the required parameter 'realm' is set
            if (realm == null) throw new ApiException(400, "Missing required parameter 'realm' when calling GetGenerateExampleUserinfo");
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling GetGenerateExampleUserinfo");
    
            var path = "/{realm}/clients/{id}/evaluate-scopes/generate-example-userinfo";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "realm" + "}", ApiClient.ParameterToString(realm));
path = path.Replace("{" + "id" + "}", ApiClient.ParameterToString(id));
    
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
             if (scope != null) queryParams.Add("scope", ApiClient.ParameterToString(scope)); // query parameter
 if (userId != null) queryParams.Add("userId", ApiClient.ParameterToString(userId)); // query parameter
                        
            // authentication setting, if any
            String[] authSettings = new String[] { "access_token" };
    
            // make the HTTP request
            RestResponseBase response = (RestResponseBase) ApiClient.CallApi(path, Method.Get, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling GetGenerateExampleUserinfo: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling GetGenerateExampleUserinfo: " + response.ErrorMessage, response.ErrorMessage);
    
            return (Dictionary<string, Object>) ApiClient.Deserialize(response.Content, typeof(Dictionary<string, Object>), response.Headers);
        }
    
        /// <summary>
        ///  Get effective scope mapping of all roles of particular role container, which this client is defacto allowed to have in the accessToken issued for him.
        /// </summary>
        /// <param name="realm">realm name (not id!)</param>
        /// <param name="id"></param>
        /// <param name="roleContainerId">either realm name OR client UUID</param>
        /// <param name="scope"></param>
        /// <returns>List&lt;RoleRepresentation&gt;</returns>
        public List<RoleRepresentation> GetGranted (string realm, string id, string roleContainerId, string scope)
        {
            // verify the required parameter 'realm' is set
            if (realm == null) throw new ApiException(400, "Missing required parameter 'realm' when calling GetGranted");
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling GetGranted");
            // verify the required parameter 'roleContainerId' is set
            if (roleContainerId == null) throw new ApiException(400, "Missing required parameter 'roleContainerId' when calling GetGranted");
    
            var path = "/{realm}/clients/{id}/evaluate-scopes/scope-mappings/{roleContainerId}/granted";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "realm" + "}", ApiClient.ParameterToString(realm));
path = path.Replace("{" + "id" + "}", ApiClient.ParameterToString(id));
path = path.Replace("{" + "roleContainerId" + "}", ApiClient.ParameterToString(roleContainerId));
    
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
             if (scope != null) queryParams.Add("scope", ApiClient.ParameterToString(scope)); // query parameter
                        
            // authentication setting, if any
            String[] authSettings = new String[] { "access_token" };
    
            // make the HTTP request
            RestResponseBase response = (RestResponseBase) ApiClient.CallApi(path, Method.Get, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling GetGranted: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling GetGranted: " + response.ErrorMessage, response.ErrorMessage);
    
            return (List<RoleRepresentation>) ApiClient.Deserialize(response.Content, typeof(List<RoleRepresentation>), response.Headers);
        }
    
        /// <summary>
        ///  
        /// </summary>
        /// <param name="realm">realm name (not id!)</param>
        /// <param name="id"></param>
        /// <param name="providerId"></param>
        /// <returns></returns>
        public void GetInstallationProvider (string realm, string id, string providerId)
        {
            // verify the required parameter 'realm' is set
            if (realm == null) throw new ApiException(400, "Missing required parameter 'realm' when calling GetInstallationProvider");
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling GetInstallationProvider");
            // verify the required parameter 'providerId' is set
            if (providerId == null) throw new ApiException(400, "Missing required parameter 'providerId' when calling GetInstallationProvider");
    
            var path = "/{realm}/clients/{id}/installation/providers/{providerId}";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "realm" + "}", ApiClient.ParameterToString(realm));
path = path.Replace("{" + "id" + "}", ApiClient.ParameterToString(id));
path = path.Replace("{" + "providerId" + "}", ApiClient.ParameterToString(providerId));
    
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
                throw new ApiException ((int)response.StatusCode, "Error calling GetInstallationProvider: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling GetInstallationProvider: " + response.ErrorMessage, response.ErrorMessage);
    
            return;
        }
    
        /// <summary>
        ///  Get roles, which this client doesn’t have scope for and can’t have them in the accessToken issued for him.
        /// </summary>
        /// <param name="realm">realm name (not id!)</param>
        /// <param name="id"></param>
        /// <param name="roleContainerId">either realm name OR client UUID</param>
        /// <param name="scope"></param>
        /// <returns>List&lt;RoleRepresentation&gt;</returns>
        public List<RoleRepresentation> GetNotGranted (string realm, string id, string roleContainerId, string scope)
        {
            // verify the required parameter 'realm' is set
            if (realm == null) throw new ApiException(400, "Missing required parameter 'realm' when calling GetNotGranted");
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling GetNotGranted");
            // verify the required parameter 'roleContainerId' is set
            if (roleContainerId == null) throw new ApiException(400, "Missing required parameter 'roleContainerId' when calling GetNotGranted");
    
            var path = "/{realm}/clients/{id}/evaluate-scopes/scope-mappings/{roleContainerId}/not-granted";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "realm" + "}", ApiClient.ParameterToString(realm));
path = path.Replace("{" + "id" + "}", ApiClient.ParameterToString(id));
path = path.Replace("{" + "roleContainerId" + "}", ApiClient.ParameterToString(roleContainerId));
    
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
             if (scope != null) queryParams.Add("scope", ApiClient.ParameterToString(scope)); // query parameter
                        
            // authentication setting, if any
            String[] authSettings = new String[] { "access_token" };
    
            // make the HTTP request
            RestResponseBase response = (RestResponseBase) ApiClient.CallApi(path, Method.Get, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling GetNotGranted: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling GetNotGranted: " + response.ErrorMessage, response.ErrorMessage);
    
            return (List<RoleRepresentation>) ApiClient.Deserialize(response.Content, typeof(List<RoleRepresentation>), response.Headers);
        }
    
        /// <summary>
        ///  Get application offline session count Returns a number of offline user sessions associated with this client { \\\&quot;count\\\&quot;: number }
        /// </summary>
        /// <param name="realm">realm name (not id!)</param>
        /// <param name="id"></param>
        /// <returns>Dictionary&lt;string, long?&gt;</returns>
        public Dictionary<string, long?> GetOfflineSessionCount (string realm, string id)
        {
            // verify the required parameter 'realm' is set
            if (realm == null) throw new ApiException(400, "Missing required parameter 'realm' when calling GetOfflineSessionCount");
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling GetOfflineSessionCount");
    
            var path = "/{realm}/clients/{id}/offline-session-count";
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
                throw new ApiException ((int)response.StatusCode, "Error calling GetOfflineSessionCount: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling GetOfflineSessionCount: " + response.ErrorMessage, response.ErrorMessage);
    
            return (Dictionary<string, long?>) ApiClient.Deserialize(response.Content, typeof(Dictionary<string, long?>), response.Headers);
        }
    
        /// <summary>
        ///  Get offline sessions for client Returns a list of offline user sessions associated with this client
        /// </summary>
        /// <param name="realm">realm name (not id!)</param>
        /// <param name="id"></param>
        /// <param name="first">Paging offset</param>
        /// <param name="max">Maximum results size (defaults to 100)</param>
        /// <returns>List&lt;UserSessionRepresentation&gt;</returns>
        public List<UserSessionRepresentation> GetOfflineSessions (string realm, string id, string first, string max)
        {
            // verify the required parameter 'realm' is set
            if (realm == null) throw new ApiException(400, "Missing required parameter 'realm' when calling GetOfflineSessions");
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling GetOfflineSessions");
    
            var path = "/{realm}/clients/{id}/offline-sessions";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "realm" + "}", ApiClient.ParameterToString(realm));
path = path.Replace("{" + "id" + "}", ApiClient.ParameterToString(id));
    
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
             if (first != null) queryParams.Add("first", ApiClient.ParameterToString(first)); // query parameter
 if (max != null) queryParams.Add("max", ApiClient.ParameterToString(max)); // query parameter
                        
            // authentication setting, if any
            String[] authSettings = new String[] { "access_token" };
    
            // make the HTTP request
            RestResponseBase response = (RestResponseBase) ApiClient.CallApi(path, Method.Get, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling GetOfflineSessions: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling GetOfflineSessions: " + response.ErrorMessage, response.ErrorMessage);
    
            return (List<UserSessionRepresentation>) ApiClient.Deserialize(response.Content, typeof(List<UserSessionRepresentation>), response.Headers);
        }
    
        /// <summary>
        ///  Get optional client scopes.  Only name and ids are returned.
        /// </summary>
        /// <param name="realm">realm name (not id!)</param>
        /// <param name="id"></param>
        /// <returns>List&lt;ClientScopeRepresentation&gt;</returns>
        public List<ClientScopeRepresentation> GetOptionalClientScopes (string realm, string id)
        {
            // verify the required parameter 'realm' is set
            if (realm == null) throw new ApiException(400, "Missing required parameter 'realm' when calling GetOptionalClientScopes");
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling GetOptionalClientScopes");
    
            var path = "/{realm}/clients/{id}/optional-client-scopes";
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
                throw new ApiException ((int)response.StatusCode, "Error calling GetOptionalClientScopes: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling GetOptionalClientScopes: " + response.ErrorMessage, response.ErrorMessage);
    
            return (List<ClientScopeRepresentation>) ApiClient.Deserialize(response.Content, typeof(List<ClientScopeRepresentation>), response.Headers);
        }
    
        /// <summary>
        ///  Return list of all protocol mappers, which will be used when generating tokens issued for particular client.
        /// </summary>
        /// <param name="realm">realm name (not id!)</param>
        /// <param name="id"></param>
        /// <param name="scope"></param>
        /// <returns>List&lt;ProtocolMapperEvaluationRepresentation&gt;</returns>
        public List<ProtocolMapperEvaluationRepresentation> GetProtocolMappers (string realm, string id, string scope)
        {
            // verify the required parameter 'realm' is set
            if (realm == null) throw new ApiException(400, "Missing required parameter 'realm' when calling GetProtocolMappers");
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling GetProtocolMappers");
    
            var path = "/{realm}/clients/{id}/evaluate-scopes/protocol-mappers";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "realm" + "}", ApiClient.ParameterToString(realm));
path = path.Replace("{" + "id" + "}", ApiClient.ParameterToString(id));
    
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
             if (scope != null) queryParams.Add("scope", ApiClient.ParameterToString(scope)); // query parameter
                        
            // authentication setting, if any
            String[] authSettings = new String[] { "access_token" };
    
            // make the HTTP request
            RestResponseBase response = (RestResponseBase) ApiClient.CallApi(path, Method.Get, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling GetProtocolMappers: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling GetProtocolMappers: " + response.ErrorMessage, response.ErrorMessage);
    
            return (List<ProtocolMapperEvaluationRepresentation>) ApiClient.Deserialize(response.Content, typeof(List<ProtocolMapperEvaluationRepresentation>), response.Headers);
        }
    
        /// <summary>
        ///  Get the rotated client secret
        /// </summary>
        /// <param name="realm">realm name (not id!)</param>
        /// <param name="id"></param>
        /// <returns>CredentialRepresentation</returns>
        public CredentialRepresentation GetRotated (string realm, string id)
        {
            // verify the required parameter 'realm' is set
            if (realm == null) throw new ApiException(400, "Missing required parameter 'realm' when calling GetRotated");
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling GetRotated");
    
            var path = "/{realm}/clients/{id}/client-secret/rotated";
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
                throw new ApiException ((int)response.StatusCode, "Error calling GetRotated: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling GetRotated: " + response.ErrorMessage, response.ErrorMessage);
    
            return (CredentialRepresentation) ApiClient.Deserialize(response.Content, typeof(CredentialRepresentation), response.Headers);
        }
    
        /// <summary>
        ///  Get a user dedicated to the service account
        /// </summary>
        /// <param name="realm">realm name (not id!)</param>
        /// <param name="id"></param>
        /// <returns>UserRepresentation</returns>
        public UserRepresentation GetServiceAccountUser (string realm, string id)
        {
            // verify the required parameter 'realm' is set
            if (realm == null) throw new ApiException(400, "Missing required parameter 'realm' when calling GetServiceAccountUser");
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling GetServiceAccountUser");
    
            var path = "/{realm}/clients/{id}/service-account-user";
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
                throw new ApiException ((int)response.StatusCode, "Error calling GetServiceAccountUser: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling GetServiceAccountUser: " + response.ErrorMessage, response.ErrorMessage);
    
            return (UserRepresentation) ApiClient.Deserialize(response.Content, typeof(UserRepresentation), response.Headers);
        }
    
        /// <summary>
        ///  Get application session count Returns a number of user sessions associated with this client { \\\&quot;count\\\&quot;: number }
        /// </summary>
        /// <param name="realm">realm name (not id!)</param>
        /// <param name="id"></param>
        /// <returns>Dictionary&lt;string, long?&gt;</returns>
        public Dictionary<string, long?> GetSessionCount (string realm, string id)
        {
            // verify the required parameter 'realm' is set
            if (realm == null) throw new ApiException(400, "Missing required parameter 'realm' when calling GetSessionCount");
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling GetSessionCount");
    
            var path = "/{realm}/clients/{id}/session-count";
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
                throw new ApiException ((int)response.StatusCode, "Error calling GetSessionCount: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling GetSessionCount: " + response.ErrorMessage, response.ErrorMessage);
    
            return (Dictionary<string, long?>) ApiClient.Deserialize(response.Content, typeof(Dictionary<string, long?>), response.Headers);
        }
    
        /// <summary>
        ///  Test if registered cluster nodes are available Tests availability by sending &#x27;ping&#x27; request to all cluster nodes.
        /// </summary>
        /// <param name="realm">realm name (not id!)</param>
        /// <param name="id"></param>
        /// <returns>GlobalRequestResult</returns>
        public GlobalRequestResult GetTestNodesAvailable (string realm, string id)
        {
            // verify the required parameter 'realm' is set
            if (realm == null) throw new ApiException(400, "Missing required parameter 'realm' when calling GetTestNodesAvailable");
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling GetTestNodesAvailable");
    
            var path = "/{realm}/clients/{id}/test-nodes-available";
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
                throw new ApiException ((int)response.StatusCode, "Error calling GetTestNodesAvailable: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling GetTestNodesAvailable: " + response.ErrorMessage, response.ErrorMessage);
    
            return (GlobalRequestResult) ApiClient.Deserialize(response.Content, typeof(GlobalRequestResult), response.Headers);
        }
    
        /// <summary>
        ///  Push the client’s revocation policy to its admin URL If the client has an admin URL, push revocation policy to it.
        /// </summary>
        /// <param name="realm">realm name (not id!)</param>
        /// <param name="id"></param>
        /// <returns>GlobalRequestResult</returns>
        public GlobalRequestResult PostClientPushRevocation (string realm, string id)
        {
            // verify the required parameter 'realm' is set
            if (realm == null) throw new ApiException(400, "Missing required parameter 'realm' when calling PostClientPushRevocation");
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling PostClientPushRevocation");
    
            var path = "/{realm}/clients/{id}/push-revocation";
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
            RestResponseBase response = (RestResponseBase) ApiClient.CallApi(path, Method.Post, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling PostClientPushRevocation: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling PostClientPushRevocation: " + response.ErrorMessage, response.ErrorMessage);
    
            return (GlobalRequestResult) ApiClient.Deserialize(response.Content, typeof(GlobalRequestResult), response.Headers);
        }
    
        /// <summary>
        ///  Generate a new secret for the client
        /// </summary>
        /// <param name="realm">realm name (not id!)</param>
        /// <param name="id"></param>
        /// <returns>CredentialRepresentation</returns>
        public CredentialRepresentation PostClientSecret (string realm, string id)
        {
            // verify the required parameter 'realm' is set
            if (realm == null) throw new ApiException(400, "Missing required parameter 'realm' when calling PostClientSecret");
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling PostClientSecret");
    
            var path = "/{realm}/clients/{id}/client-secret";
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
            RestResponseBase response = (RestResponseBase) ApiClient.CallApi(path, Method.Post, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling PostClientSecret: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling PostClientSecret: " + response.ErrorMessage, response.ErrorMessage);
    
            return (CredentialRepresentation) ApiClient.Deserialize(response.Content, typeof(CredentialRepresentation), response.Headers);
        }
    
        /// <summary>
        ///  Create a new client Client’s client_id must be unique!
        /// </summary>
        /// <param name="realm">realm name (not id!)</param>
        /// <param name="body">ClientRepresentation</param>
        /// <returns></returns>
        public void PostClients (string realm, ClientRepresentation body)
        {
            // verify the required parameter 'realm' is set
            if (realm == null) throw new ApiException(400, "Missing required parameter 'realm' when calling PostClients");
    
            var path = "/{realm}/clients";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "realm" + "}", ApiClient.ParameterToString(realm));
    
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
                throw new ApiException ((int)response.StatusCode, "Error calling PostClients: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling PostClients: " + response.ErrorMessage, response.ErrorMessage);
    
            return;
        }
    
        /// <summary>
        ///  Register a cluster node with the client Manually register cluster node to this client - usually it’s not needed to call this directly as adapter should handle by sending registration request to Keycloak
        /// </summary>
        /// <param name="realm">realm name (not id!)</param>
        /// <param name="id"></param>
        /// <param name="body">[string]</param>
        /// <returns></returns>
        public void PostNodes (string realm, string id, string body)
        {
            // verify the required parameter 'realm' is set
            if (realm == null) throw new ApiException(400, "Missing required parameter 'realm' when calling PostNodes");
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling PostNodes");
    
            var path = "/{realm}/clients/{id}/nodes";
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
                throw new ApiException ((int)response.StatusCode, "Error calling PostNodes: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling PostNodes: " + response.ErrorMessage, response.ErrorMessage);
    
            return;
        }
    
        /// <summary>
        ///  Generate a new registration access token for the client
        /// </summary>
        /// <param name="realm">realm name (not id!)</param>
        /// <param name="id"></param>
        /// <returns>ClientRepresentation</returns>
        public ClientRepresentation PostRegistrationAccessToken (string realm, string id)
        {
            // verify the required parameter 'realm' is set
            if (realm == null) throw new ApiException(400, "Missing required parameter 'realm' when calling PostRegistrationAccessToken");
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling PostRegistrationAccessToken");
    
            var path = "/{realm}/clients/{id}/registration-access-token";
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
            RestResponseBase response = (RestResponseBase) ApiClient.CallApi(path, Method.Post, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling PostRegistrationAccessToken: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling PostRegistrationAccessToken: " + response.ErrorMessage, response.ErrorMessage);
    
            return (ClientRepresentation) ApiClient.Deserialize(response.Content, typeof(ClientRepresentation), response.Headers);
        }
    
        /// <summary>
        ///  Update the client
        /// </summary>
        /// <param name="realm">realm name (not id!)</param>
        /// <param name="id"></param>
        /// <param name="body">ClientRepresentation</param>
        /// <returns></returns>
        public void PutClient (string realm, string id, ClientRepresentation body)
        {
            // verify the required parameter 'realm' is set
            if (realm == null) throw new ApiException(400, "Missing required parameter 'realm' when calling PutClient");
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling PutClient");
    
            var path = "/{realm}/clients/{id}";
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
            RestResponseBase response = (RestResponseBase) ApiClient.CallApi(path, Method.Put, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling PutClient: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling PutClient: " + response.ErrorMessage, response.ErrorMessage);
    
            return;
        }
    
        /// <summary>
        ///  Return object stating whether client Authorization permissions have been initialized or not and a reference
        /// </summary>
        /// <param name="realm">realm name (not id!)</param>
        /// <param name="id"></param>
        /// <param name="body">ManagementPermissionReference</param>
        /// <returns>ManagementPermissionReference</returns>
        public ManagementPermissionReference PutClientManagementPermissions (string realm, string id, ManagementPermissionReference body)
        {
            // verify the required parameter 'realm' is set
            if (realm == null) throw new ApiException(400, "Missing required parameter 'realm' when calling PutClientManagementPermissions");
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling PutClientManagementPermissions");
    
            var path = "/{realm}/clients/{id}/management/permissions";
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
            RestResponseBase response = (RestResponseBase) ApiClient.CallApi(path, Method.Put, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling PutClientManagementPermissions: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling PutClientManagementPermissions: " + response.ErrorMessage, response.ErrorMessage);
    
            return (ManagementPermissionReference) ApiClient.Deserialize(response.Content, typeof(ManagementPermissionReference), response.Headers);
        }
    
        /// <summary>
        ///  
        /// </summary>
        /// <param name="realm">realm name (not id!)</param>
        /// <param name="id"></param>
        /// <param name="clientScopeId"></param>
        /// <returns></returns>
        public void PutDefaultClientScope (string realm, string id, string clientScopeId)
        {
            // verify the required parameter 'realm' is set
            if (realm == null) throw new ApiException(400, "Missing required parameter 'realm' when calling PutDefaultClientScope");
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling PutDefaultClientScope");
            // verify the required parameter 'clientScopeId' is set
            if (clientScopeId == null) throw new ApiException(400, "Missing required parameter 'clientScopeId' when calling PutDefaultClientScope");
    
            var path = "/{realm}/clients/{id}/default-client-scopes/{clientScopeId}";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "realm" + "}", ApiClient.ParameterToString(realm));
path = path.Replace("{" + "id" + "}", ApiClient.ParameterToString(id));
path = path.Replace("{" + "clientScopeId" + "}", ApiClient.ParameterToString(clientScopeId));
    
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
                                    
            // authentication setting, if any
            String[] authSettings = new String[] { "access_token" };
    
            // make the HTTP request
            RestResponseBase response = (RestResponseBase) ApiClient.CallApi(path, Method.Put, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling PutDefaultClientScope: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling PutDefaultClientScope: " + response.ErrorMessage, response.ErrorMessage);
    
            return;
        }
    
        /// <summary>
        ///  
        /// </summary>
        /// <param name="realm">realm name (not id!)</param>
        /// <param name="id"></param>
        /// <param name="clientScopeId"></param>
        /// <returns></returns>
        public void PutOptionalClientScope (string realm, string id, string clientScopeId)
        {
            // verify the required parameter 'realm' is set
            if (realm == null) throw new ApiException(400, "Missing required parameter 'realm' when calling PutOptionalClientScope");
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling PutOptionalClientScope");
            // verify the required parameter 'clientScopeId' is set
            if (clientScopeId == null) throw new ApiException(400, "Missing required parameter 'clientScopeId' when calling PutOptionalClientScope");
    
            var path = "/{realm}/clients/{id}/optional-client-scopes/{clientScopeId}";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "realm" + "}", ApiClient.ParameterToString(realm));
path = path.Replace("{" + "id" + "}", ApiClient.ParameterToString(id));
path = path.Replace("{" + "clientScopeId" + "}", ApiClient.ParameterToString(clientScopeId));
    
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
                                    
            // authentication setting, if any
            String[] authSettings = new String[] { "access_token" };
    
            // make the HTTP request
            RestResponseBase response = (RestResponseBase) ApiClient.CallApi(path, Method.Put, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling PutOptionalClientScope: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling PutOptionalClientScope: " + response.ErrorMessage, response.ErrorMessage);
    
            return;
        }
    
    }
}
