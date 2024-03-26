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
    public interface IRolesApi
    {
        /// <summary>
        ///  Delete a role by name
        /// </summary>
        /// <param name="realm">realm name (not id!)</param>
        /// <param name="id"></param>
        /// <param name="roleName">role&#x27;s name (not id!)</param>
        /// <returns></returns>
        void DeleteClientRole (string realm, string id, string roleName);
        /// <summary>
        ///  Remove roles from the role’s composite
        /// </summary>
        /// <param name="realm">realm name (not id!)</param>
        /// <param name="id"></param>
        /// <param name="roleName">role&#x27;s name (not id!)</param>
        /// <param name="body">RoleRepresentation</param>
        /// <returns></returns>
        void DeleteClientRoleComposites (string realm, string id, string roleName, RoleRepresentation body);
        /// <summary>
        ///  Delete a role by name
        /// </summary>
        /// <param name="realm">realm name (not id!)</param>
        /// <param name="roleName">role&#x27;s name (not id!)</param>
        /// <returns></returns>
        void DeleteRoleByRealmByRoleName (string realm, string roleName);
        /// <summary>
        ///  Remove roles from the role’s composite
        /// </summary>
        /// <param name="realm">realm name (not id!)</param>
        /// <param name="roleName">role&#x27;s name (not id!)</param>
        /// <param name="body">RoleRepresentation</param>
        /// <returns></returns>
        void DeleteRoleCompositesByRealmByRoleName (string realm, string roleName, RoleRepresentation body);
        /// <summary>
        ///  Get a role by name
        /// </summary>
        /// <param name="realm">realm name (not id!)</param>
        /// <param name="id"></param>
        /// <param name="roleName">role&#x27;s name (not id!)</param>
        /// <returns>RoleRepresentation</returns>
        RoleRepresentation GetClientRole (string realm, string id, string roleName);
        /// <summary>
        ///  Get composites of the role
        /// </summary>
        /// <param name="realm">realm name (not id!)</param>
        /// <param name="id"></param>
        /// <param name="roleName">role&#x27;s name (not id!)</param>
        /// <returns>List&lt;RoleRepresentation&gt;</returns>
        List<RoleRepresentation> GetClientRoleComposites (string realm, string id, string roleName);
        /// <summary>
        ///  Get client-level roles for the client that are in the role’s composite
        /// </summary>
        /// <param name="realm">realm name (not id!)</param>
        /// <param name="id"></param>
        /// <param name="roleName">role&#x27;s name (not id!)</param>
        /// <param name="clientUuid"></param>
        /// <returns>List&lt;RoleRepresentation&gt;</returns>
        List<RoleRepresentation> GetClientRoleCompositesClient (string realm, string id, string roleName, string clientUuid);
        /// <summary>
        ///  Get realm-level roles of the role’s composite
        /// </summary>
        /// <param name="realm">realm name (not id!)</param>
        /// <param name="id"></param>
        /// <param name="roleName">role&#x27;s name (not id!)</param>
        /// <returns>List&lt;RoleRepresentation&gt;</returns>
        List<RoleRepresentation> GetClientRoleCompositesRealm (string realm, string id, string roleName);
        /// <summary>
        ///  Returns a stream of groups that have the specified role name
        /// </summary>
        /// <param name="realm">realm name (not id!)</param>
        /// <param name="id"></param>
        /// <param name="roleName">the role name.</param>
        /// <param name="briefRepresentation">if false, return a full representation of the {@code GroupRepresentation} objects.</param>
        /// <param name="first">first result to return. Ignored if negative or {@code null}.</param>
        /// <param name="max">maximum number of results to return. Ignored if negative or {@code null}.</param>
        /// <returns>List&lt;GroupRepresentation&gt;</returns>
        List<GroupRepresentation> GetClientRoleGroups (string realm, string id, string roleName, string briefRepresentation, string first, string max);
        /// <summary>
        ///  Return object stating whether role Authorization permissions have been initialized or not and a reference
        /// </summary>
        /// <param name="realm">realm name (not id!)</param>
        /// <param name="id"></param>
        /// <param name="roleName"></param>
        /// <returns>ManagementPermissionReference</returns>
        ManagementPermissionReference GetClientRoleManagementPermissions (string realm, string id, string roleName);
        /// <summary>
        ///  Returns a stream of users that have the specified role name.
        /// </summary>
        /// <param name="realm">realm name (not id!)</param>
        /// <param name="id"></param>
        /// <param name="roleName">the role name.</param>
        /// <param name="first">first result to return. Ignored if negative or {@code null}.</param>
        /// <param name="max">maximum number of results to return. Ignored if negative or {@code null}.</param>
        /// <returns>List&lt;UserRepresentation&gt;</returns>
        List<UserRepresentation> GetClientRoleUsers (string realm, string id, string roleName, string first, string max);
        /// <summary>
        ///  Get all roles for the realm or client
        /// </summary>
        /// <param name="realm">realm name (not id!)</param>
        /// <param name="id"></param>
        /// <param name="briefRepresentation"></param>
        /// <param name="first"></param>
        /// <param name="max"></param>
        /// <param name="search"></param>
        /// <returns>List&lt;RoleRepresentation&gt;</returns>
        List<RoleRepresentation> GetClientRoles (string realm, string id, string briefRepresentation, string first, string max, string search);
        /// <summary>
        ///  Get a role by name
        /// </summary>
        /// <param name="realm">realm name (not id!)</param>
        /// <param name="roleName">role&#x27;s name (not id!)</param>
        /// <returns>RoleRepresentation</returns>
        RoleRepresentation GetRoleByRealmByRoleName (string realm, string roleName);
        /// <summary>
        ///  Get composites of the role
        /// </summary>
        /// <param name="realm">realm name (not id!)</param>
        /// <param name="roleName">role&#x27;s name (not id!)</param>
        /// <returns>List&lt;RoleRepresentation&gt;</returns>
        List<RoleRepresentation> GetRoleCompositesByRealmByRoleName (string realm, string roleName);
        /// <summary>
        ///  Get client-level roles for the client that are in the role’s composite
        /// </summary>
        /// <param name="realm">realm name (not id!)</param>
        /// <param name="roleName">role&#x27;s name (not id!)</param>
        /// <param name="clientUuid"></param>
        /// <returns>List&lt;RoleRepresentation&gt;</returns>
        List<RoleRepresentation> GetRoleCompositesClientByRealmByRoleNameByClientUuid (string realm, string roleName, string clientUuid);
        /// <summary>
        ///  Get realm-level roles of the role’s composite
        /// </summary>
        /// <param name="realm">realm name (not id!)</param>
        /// <param name="roleName">role&#x27;s name (not id!)</param>
        /// <returns>List&lt;RoleRepresentation&gt;</returns>
        List<RoleRepresentation> GetRoleCompositesRealmByRealmByRoleName (string realm, string roleName);
        /// <summary>
        ///  Returns a stream of groups that have the specified role name
        /// </summary>
        /// <param name="realm">realm name (not id!)</param>
        /// <param name="roleName">the role name.</param>
        /// <param name="briefRepresentation">if false, return a full representation of the {@code GroupRepresentation} objects.</param>
        /// <param name="first">first result to return. Ignored if negative or {@code null}.</param>
        /// <param name="max">maximum number of results to return. Ignored if negative or {@code null}.</param>
        /// <returns>List&lt;GroupRepresentation&gt;</returns>
        List<GroupRepresentation> GetRoleGroupsByRealmByRoleName (string realm, string roleName, string briefRepresentation, string first, string max);
        /// <summary>
        ///  Return object stating whether role Authorization permissions have been initialized or not and a reference
        /// </summary>
        /// <param name="realm">realm name (not id!)</param>
        /// <param name="roleName"></param>
        /// <returns>ManagementPermissionReference</returns>
        ManagementPermissionReference GetRoleManagementPermissionsByRealmByRoleName (string realm, string roleName);
        /// <summary>
        ///  Returns a stream of users that have the specified role name.
        /// </summary>
        /// <param name="realm">realm name (not id!)</param>
        /// <param name="roleName">the role name.</param>
        /// <param name="first">first result to return. Ignored if negative or {@code null}.</param>
        /// <param name="max">maximum number of results to return. Ignored if negative or {@code null}.</param>
        /// <returns>List&lt;UserRepresentation&gt;</returns>
        List<UserRepresentation> GetRoleUsersByRealmByRoleName (string realm, string roleName, string first, string max);
        /// <summary>
        ///  Get all roles for the realm or client
        /// </summary>
        /// <param name="realm">realm name (not id!)</param>
        /// <param name="briefRepresentation"></param>
        /// <param name="first"></param>
        /// <param name="max"></param>
        /// <param name="search"></param>
        /// <returns>List&lt;RoleRepresentation&gt;</returns>
        List<RoleRepresentation> GetRolesByRealm (string realm, string briefRepresentation, string first, string max, string search);
        /// <summary>
        ///  Add a composite to the role
        /// </summary>
        /// <param name="realm">realm name (not id!)</param>
        /// <param name="id"></param>
        /// <param name="roleName">role&#x27;s name (not id!)</param>
        /// <param name="body">RoleRepresentation</param>
        /// <returns></returns>
        void PostClientRoleComposites (string realm, string id, string roleName, RoleRepresentation body);
        /// <summary>
        ///  Create a new role for the realm or client
        /// </summary>
        /// <param name="realm">realm name (not id!)</param>
        /// <param name="id"></param>
        /// <param name="body">RoleRepresentation</param>
        /// <returns></returns>
        void PostClientRoles (string realm, string id, RoleRepresentation body);
        /// <summary>
        ///  Add a composite to the role
        /// </summary>
        /// <param name="realm">realm name (not id!)</param>
        /// <param name="roleName">role&#x27;s name (not id!)</param>
        /// <param name="body">RoleRepresentation</param>
        /// <returns></returns>
        void PostRoleCompositesByRealmByRoleName (string realm, string roleName, RoleRepresentation body);
        /// <summary>
        ///  Create a new role for the realm or client
        /// </summary>
        /// <param name="realm">realm name (not id!)</param>
        /// <param name="body">RoleRepresentation</param>
        /// <returns></returns>
        void PostRolesByRealm (string realm, RoleRepresentation body);
        /// <summary>
        ///  Update a role by name
        /// </summary>
        /// <param name="realm">realm name (not id!)</param>
        /// <param name="id"></param>
        /// <param name="roleName">role&#x27;s name (not id!)</param>
        /// <param name="body">RoleRepresentation</param>
        /// <returns></returns>
        void PutClientRole (string realm, string id, string roleName, RoleRepresentation body);
        /// <summary>
        ///  Return object stating whether role Authorization permissions have been initialized or not and a reference
        /// </summary>
        /// <param name="realm">realm name (not id!)</param>
        /// <param name="id"></param>
        /// <param name="roleName"></param>
        /// <param name="body">ManagementPermissionReference</param>
        /// <returns>ManagementPermissionReference</returns>
        ManagementPermissionReference PutClientRoleManagementPermissions (string realm, string id, string roleName, ManagementPermissionReference body);
        /// <summary>
        ///  Update a role by name
        /// </summary>
        /// <param name="realm">realm name (not id!)</param>
        /// <param name="roleName">role&#x27;s name (not id!)</param>
        /// <param name="body">RoleRepresentation</param>
        /// <returns></returns>
        void PutRoleByRealmByRoleName (string realm, string roleName, RoleRepresentation body);
        /// <summary>
        ///  Return object stating whether role Authorization permissions have been initialized or not and a reference
        /// </summary>
        /// <param name="realm">realm name (not id!)</param>
        /// <param name="roleName"></param>
        /// <param name="body">ManagementPermissionReference</param>
        /// <returns>ManagementPermissionReference</returns>
        ManagementPermissionReference PutRoleManagementPermissionsByRealmByRoleName (string realm, string roleName, ManagementPermissionReference body);
    }
  
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public class RolesApi : IRolesApi
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="RolesApi"/> class.
        /// </summary>
        /// <param name="apiClient"> an instance of ApiClient (optional)</param>
        /// <returns></returns>
        public RolesApi(ApiClient apiClient = null)
        {
            if (apiClient == null) // use the default one in Configuration
                this.ApiClient = Configuration.DefaultApiClient; 
            else
                this.ApiClient = apiClient;
        }
    
        /// <summary>
        /// Initializes a new instance of the <see cref="RolesApi"/> class.
        /// </summary>
        /// <returns></returns>
        public RolesApi(String basePath)
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
        ///  Delete a role by name
        /// </summary>
        /// <param name="realm">realm name (not id!)</param>
        /// <param name="id"></param>
        /// <param name="roleName">role&#x27;s name (not id!)</param>
        /// <returns></returns>
        public void DeleteClientRole (string realm, string id, string roleName)
        {
            // verify the required parameter 'realm' is set
            if (realm == null) throw new ApiException(400, "Missing required parameter 'realm' when calling DeleteClientRole");
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling DeleteClientRole");
            // verify the required parameter 'roleName' is set
            if (roleName == null) throw new ApiException(400, "Missing required parameter 'roleName' when calling DeleteClientRole");
    
            var path = "/{realm}/clients/{id}/roles/{role-name}";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "realm" + "}", ApiClient.ParameterToString(realm));
path = path.Replace("{" + "id" + "}", ApiClient.ParameterToString(id));
path = path.Replace("{" + "role-name" + "}", ApiClient.ParameterToString(roleName));
    
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
                throw new ApiException ((int)response.StatusCode, "Error calling DeleteClientRole: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling DeleteClientRole: " + response.ErrorMessage, response.ErrorMessage);
    
            return;
        }
    
        /// <summary>
        ///  Remove roles from the role’s composite
        /// </summary>
        /// <param name="realm">realm name (not id!)</param>
        /// <param name="id"></param>
        /// <param name="roleName">role&#x27;s name (not id!)</param>
        /// <param name="body">RoleRepresentation</param>
        /// <returns></returns>
        public void DeleteClientRoleComposites (string realm, string id, string roleName, RoleRepresentation body)
        {
            // verify the required parameter 'realm' is set
            if (realm == null) throw new ApiException(400, "Missing required parameter 'realm' when calling DeleteClientRoleComposites");
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling DeleteClientRoleComposites");
            // verify the required parameter 'roleName' is set
            if (roleName == null) throw new ApiException(400, "Missing required parameter 'roleName' when calling DeleteClientRoleComposites");
    
            var path = "/{realm}/clients/{id}/roles/{role-name}/composites";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "realm" + "}", ApiClient.ParameterToString(realm));
path = path.Replace("{" + "id" + "}", ApiClient.ParameterToString(id));
path = path.Replace("{" + "role-name" + "}", ApiClient.ParameterToString(roleName));
    
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
                throw new ApiException ((int)response.StatusCode, "Error calling DeleteClientRoleComposites: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling DeleteClientRoleComposites: " + response.ErrorMessage, response.ErrorMessage);
    
            return;
        }
    
        /// <summary>
        ///  Delete a role by name
        /// </summary>
        /// <param name="realm">realm name (not id!)</param>
        /// <param name="roleName">role&#x27;s name (not id!)</param>
        /// <returns></returns>
        public void DeleteRoleByRealmByRoleName (string realm, string roleName)
        {
            // verify the required parameter 'realm' is set
            if (realm == null) throw new ApiException(400, "Missing required parameter 'realm' when calling DeleteRoleByRealmByRoleName");
            // verify the required parameter 'roleName' is set
            if (roleName == null) throw new ApiException(400, "Missing required parameter 'roleName' when calling DeleteRoleByRealmByRoleName");
    
            var path = "/{realm}/roles/{role-name}";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "realm" + "}", ApiClient.ParameterToString(realm));
path = path.Replace("{" + "role-name" + "}", ApiClient.ParameterToString(roleName));
    
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
                throw new ApiException ((int)response.StatusCode, "Error calling DeleteRoleByRealmByRoleName: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling DeleteRoleByRealmByRoleName: " + response.ErrorMessage, response.ErrorMessage);
    
            return;
        }
    
        /// <summary>
        ///  Remove roles from the role’s composite
        /// </summary>
        /// <param name="realm">realm name (not id!)</param>
        /// <param name="roleName">role&#x27;s name (not id!)</param>
        /// <param name="body">RoleRepresentation</param>
        /// <returns></returns>
        public void DeleteRoleCompositesByRealmByRoleName (string realm, string roleName, RoleRepresentation body)
        {
            // verify the required parameter 'realm' is set
            if (realm == null) throw new ApiException(400, "Missing required parameter 'realm' when calling DeleteRoleCompositesByRealmByRoleName");
            // verify the required parameter 'roleName' is set
            if (roleName == null) throw new ApiException(400, "Missing required parameter 'roleName' when calling DeleteRoleCompositesByRealmByRoleName");
    
            var path = "/{realm}/roles/{role-name}/composites";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "realm" + "}", ApiClient.ParameterToString(realm));
path = path.Replace("{" + "role-name" + "}", ApiClient.ParameterToString(roleName));
    
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
                throw new ApiException ((int)response.StatusCode, "Error calling DeleteRoleCompositesByRealmByRoleName: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling DeleteRoleCompositesByRealmByRoleName: " + response.ErrorMessage, response.ErrorMessage);
    
            return;
        }
    
        /// <summary>
        ///  Get a role by name
        /// </summary>
        /// <param name="realm">realm name (not id!)</param>
        /// <param name="id"></param>
        /// <param name="roleName">role&#x27;s name (not id!)</param>
        /// <returns>RoleRepresentation</returns>
        public RoleRepresentation GetClientRole (string realm, string id, string roleName)
        {
            // verify the required parameter 'realm' is set
            if (realm == null) throw new ApiException(400, "Missing required parameter 'realm' when calling GetClientRole");
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling GetClientRole");
            // verify the required parameter 'roleName' is set
            if (roleName == null) throw new ApiException(400, "Missing required parameter 'roleName' when calling GetClientRole");
    
            var path = "/{realm}/clients/{id}/roles/{role-name}";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "realm" + "}", ApiClient.ParameterToString(realm));
path = path.Replace("{" + "id" + "}", ApiClient.ParameterToString(id));
path = path.Replace("{" + "role-name" + "}", ApiClient.ParameterToString(roleName));
    
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
                throw new ApiException ((int)response.StatusCode, "Error calling GetClientRole: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling GetClientRole: " + response.ErrorMessage, response.ErrorMessage);
    
            return (RoleRepresentation) ApiClient.Deserialize(response.Content, typeof(RoleRepresentation), response.Headers);
        }
    
        /// <summary>
        ///  Get composites of the role
        /// </summary>
        /// <param name="realm">realm name (not id!)</param>
        /// <param name="id"></param>
        /// <param name="roleName">role&#x27;s name (not id!)</param>
        /// <returns>List&lt;RoleRepresentation&gt;</returns>
        public List<RoleRepresentation> GetClientRoleComposites (string realm, string id, string roleName)
        {
            // verify the required parameter 'realm' is set
            if (realm == null) throw new ApiException(400, "Missing required parameter 'realm' when calling GetClientRoleComposites");
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling GetClientRoleComposites");
            // verify the required parameter 'roleName' is set
            if (roleName == null) throw new ApiException(400, "Missing required parameter 'roleName' when calling GetClientRoleComposites");
    
            var path = "/{realm}/clients/{id}/roles/{role-name}/composites";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "realm" + "}", ApiClient.ParameterToString(realm));
path = path.Replace("{" + "id" + "}", ApiClient.ParameterToString(id));
path = path.Replace("{" + "role-name" + "}", ApiClient.ParameterToString(roleName));
    
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
                throw new ApiException ((int)response.StatusCode, "Error calling GetClientRoleComposites: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling GetClientRoleComposites: " + response.ErrorMessage, response.ErrorMessage);
    
            return (List<RoleRepresentation>) ApiClient.Deserialize(response.Content, typeof(List<RoleRepresentation>), response.Headers);
        }
    
        /// <summary>
        ///  Get client-level roles for the client that are in the role’s composite
        /// </summary>
        /// <param name="realm">realm name (not id!)</param>
        /// <param name="id"></param>
        /// <param name="roleName">role&#x27;s name (not id!)</param>
        /// <param name="clientUuid"></param>
        /// <returns>List&lt;RoleRepresentation&gt;</returns>
        public List<RoleRepresentation> GetClientRoleCompositesClient (string realm, string id, string roleName, string clientUuid)
        {
            // verify the required parameter 'realm' is set
            if (realm == null) throw new ApiException(400, "Missing required parameter 'realm' when calling GetClientRoleCompositesClient");
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling GetClientRoleCompositesClient");
            // verify the required parameter 'roleName' is set
            if (roleName == null) throw new ApiException(400, "Missing required parameter 'roleName' when calling GetClientRoleCompositesClient");
            // verify the required parameter 'clientUuid' is set
            if (clientUuid == null) throw new ApiException(400, "Missing required parameter 'clientUuid' when calling GetClientRoleCompositesClient");
    
            var path = "/{realm}/clients/{id}/roles/{role-name}/composites/clients/{clientUuid}";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "realm" + "}", ApiClient.ParameterToString(realm));
path = path.Replace("{" + "id" + "}", ApiClient.ParameterToString(id));
path = path.Replace("{" + "role-name" + "}", ApiClient.ParameterToString(roleName));
path = path.Replace("{" + "clientUuid" + "}", ApiClient.ParameterToString(clientUuid));
    
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
                throw new ApiException ((int)response.StatusCode, "Error calling GetClientRoleCompositesClient: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling GetClientRoleCompositesClient: " + response.ErrorMessage, response.ErrorMessage);
    
            return (List<RoleRepresentation>) ApiClient.Deserialize(response.Content, typeof(List<RoleRepresentation>), response.Headers);
        }
    
        /// <summary>
        ///  Get realm-level roles of the role’s composite
        /// </summary>
        /// <param name="realm">realm name (not id!)</param>
        /// <param name="id"></param>
        /// <param name="roleName">role&#x27;s name (not id!)</param>
        /// <returns>List&lt;RoleRepresentation&gt;</returns>
        public List<RoleRepresentation> GetClientRoleCompositesRealm (string realm, string id, string roleName)
        {
            // verify the required parameter 'realm' is set
            if (realm == null) throw new ApiException(400, "Missing required parameter 'realm' when calling GetClientRoleCompositesRealm");
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling GetClientRoleCompositesRealm");
            // verify the required parameter 'roleName' is set
            if (roleName == null) throw new ApiException(400, "Missing required parameter 'roleName' when calling GetClientRoleCompositesRealm");
    
            var path = "/{realm}/clients/{id}/roles/{role-name}/composites/realm";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "realm" + "}", ApiClient.ParameterToString(realm));
path = path.Replace("{" + "id" + "}", ApiClient.ParameterToString(id));
path = path.Replace("{" + "role-name" + "}", ApiClient.ParameterToString(roleName));
    
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
                throw new ApiException ((int)response.StatusCode, "Error calling GetClientRoleCompositesRealm: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling GetClientRoleCompositesRealm: " + response.ErrorMessage, response.ErrorMessage);
    
            return (List<RoleRepresentation>) ApiClient.Deserialize(response.Content, typeof(List<RoleRepresentation>), response.Headers);
        }
    
        /// <summary>
        ///  Returns a stream of groups that have the specified role name
        /// </summary>
        /// <param name="realm">realm name (not id!)</param>
        /// <param name="id"></param>
        /// <param name="roleName">the role name.</param>
        /// <param name="briefRepresentation">if false, return a full representation of the {@code GroupRepresentation} objects.</param>
        /// <param name="first">first result to return. Ignored if negative or {@code null}.</param>
        /// <param name="max">maximum number of results to return. Ignored if negative or {@code null}.</param>
        /// <returns>List&lt;GroupRepresentation&gt;</returns>
        public List<GroupRepresentation> GetClientRoleGroups (string realm, string id, string roleName, string briefRepresentation, string first, string max)
        {
            // verify the required parameter 'realm' is set
            if (realm == null) throw new ApiException(400, "Missing required parameter 'realm' when calling GetClientRoleGroups");
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling GetClientRoleGroups");
            // verify the required parameter 'roleName' is set
            if (roleName == null) throw new ApiException(400, "Missing required parameter 'roleName' when calling GetClientRoleGroups");
    
            var path = "/{realm}/clients/{id}/roles/{role-name}/groups";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "realm" + "}", ApiClient.ParameterToString(realm));
path = path.Replace("{" + "id" + "}", ApiClient.ParameterToString(id));
path = path.Replace("{" + "role-name" + "}", ApiClient.ParameterToString(roleName));
    
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
             if (briefRepresentation != null) queryParams.Add("briefRepresentation", ApiClient.ParameterToString(briefRepresentation)); // query parameter
 if (first != null) queryParams.Add("first", ApiClient.ParameterToString(first)); // query parameter
 if (max != null) queryParams.Add("max", ApiClient.ParameterToString(max)); // query parameter
                        
            // authentication setting, if any
            String[] authSettings = new String[] { "access_token" };
    
            // make the HTTP request
            RestResponseBase response = (RestResponseBase) ApiClient.CallApi(path, Method.Get, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling GetClientRoleGroups: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling GetClientRoleGroups: " + response.ErrorMessage, response.ErrorMessage);
    
            return (List<GroupRepresentation>) ApiClient.Deserialize(response.Content, typeof(List<GroupRepresentation>), response.Headers);
        }
    
        /// <summary>
        ///  Return object stating whether role Authorization permissions have been initialized or not and a reference
        /// </summary>
        /// <param name="realm">realm name (not id!)</param>
        /// <param name="id"></param>
        /// <param name="roleName"></param>
        /// <returns>ManagementPermissionReference</returns>
        public ManagementPermissionReference GetClientRoleManagementPermissions (string realm, string id, string roleName)
        {
            // verify the required parameter 'realm' is set
            if (realm == null) throw new ApiException(400, "Missing required parameter 'realm' when calling GetClientRoleManagementPermissions");
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling GetClientRoleManagementPermissions");
            // verify the required parameter 'roleName' is set
            if (roleName == null) throw new ApiException(400, "Missing required parameter 'roleName' when calling GetClientRoleManagementPermissions");
    
            var path = "/{realm}/clients/{id}/roles/{role-name}/management/permissions";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "realm" + "}", ApiClient.ParameterToString(realm));
path = path.Replace("{" + "id" + "}", ApiClient.ParameterToString(id));
path = path.Replace("{" + "role-name" + "}", ApiClient.ParameterToString(roleName));
    
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
                throw new ApiException ((int)response.StatusCode, "Error calling GetClientRoleManagementPermissions: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling GetClientRoleManagementPermissions: " + response.ErrorMessage, response.ErrorMessage);
    
            return (ManagementPermissionReference) ApiClient.Deserialize(response.Content, typeof(ManagementPermissionReference), response.Headers);
        }
    
        /// <summary>
        ///  Returns a stream of users that have the specified role name.
        /// </summary>
        /// <param name="realm">realm name (not id!)</param>
        /// <param name="id"></param>
        /// <param name="roleName">the role name.</param>
        /// <param name="first">first result to return. Ignored if negative or {@code null}.</param>
        /// <param name="max">maximum number of results to return. Ignored if negative or {@code null}.</param>
        /// <returns>List&lt;UserRepresentation&gt;</returns>
        public List<UserRepresentation> GetClientRoleUsers (string realm, string id, string roleName, string first, string max)
        {
            // verify the required parameter 'realm' is set
            if (realm == null) throw new ApiException(400, "Missing required parameter 'realm' when calling GetClientRoleUsers");
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling GetClientRoleUsers");
            // verify the required parameter 'roleName' is set
            if (roleName == null) throw new ApiException(400, "Missing required parameter 'roleName' when calling GetClientRoleUsers");
    
            var path = "/{realm}/clients/{id}/roles/{role-name}/users";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "realm" + "}", ApiClient.ParameterToString(realm));
path = path.Replace("{" + "id" + "}", ApiClient.ParameterToString(id));
path = path.Replace("{" + "role-name" + "}", ApiClient.ParameterToString(roleName));
    
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
                throw new ApiException ((int)response.StatusCode, "Error calling GetClientRoleUsers: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling GetClientRoleUsers: " + response.ErrorMessage, response.ErrorMessage);
    
            return (List<UserRepresentation>) ApiClient.Deserialize(response.Content, typeof(List<UserRepresentation>), response.Headers);
        }
    
        /// <summary>
        ///  Get all roles for the realm or client
        /// </summary>
        /// <param name="realm">realm name (not id!)</param>
        /// <param name="id"></param>
        /// <param name="briefRepresentation"></param>
        /// <param name="first"></param>
        /// <param name="max"></param>
        /// <param name="search"></param>
        /// <returns>List&lt;RoleRepresentation&gt;</returns>
        public List<RoleRepresentation> GetClientRoles (string realm, string id, string briefRepresentation, string first, string max, string search)
        {
            // verify the required parameter 'realm' is set
            if (realm == null) throw new ApiException(400, "Missing required parameter 'realm' when calling GetClientRoles");
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling GetClientRoles");
    
            var path = "/{realm}/clients/{id}/roles";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "realm" + "}", ApiClient.ParameterToString(realm));
path = path.Replace("{" + "id" + "}", ApiClient.ParameterToString(id));
    
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
             if (briefRepresentation != null) queryParams.Add("briefRepresentation", ApiClient.ParameterToString(briefRepresentation)); // query parameter
 if (first != null) queryParams.Add("first", ApiClient.ParameterToString(first)); // query parameter
 if (max != null) queryParams.Add("max", ApiClient.ParameterToString(max)); // query parameter
 if (search != null) queryParams.Add("search", ApiClient.ParameterToString(search)); // query parameter
                        
            // authentication setting, if any
            String[] authSettings = new String[] { "access_token" };
    
            // make the HTTP request
            RestResponseBase response = (RestResponseBase) ApiClient.CallApi(path, Method.Get, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling GetClientRoles: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling GetClientRoles: " + response.ErrorMessage, response.ErrorMessage);
    
            return (List<RoleRepresentation>) ApiClient.Deserialize(response.Content, typeof(List<RoleRepresentation>), response.Headers);
        }
    
        /// <summary>
        ///  Get a role by name
        /// </summary>
        /// <param name="realm">realm name (not id!)</param>
        /// <param name="roleName">role&#x27;s name (not id!)</param>
        /// <returns>RoleRepresentation</returns>
        public RoleRepresentation GetRoleByRealmByRoleName (string realm, string roleName)
        {
            // verify the required parameter 'realm' is set
            if (realm == null) throw new ApiException(400, "Missing required parameter 'realm' when calling GetRoleByRealmByRoleName");
            // verify the required parameter 'roleName' is set
            if (roleName == null) throw new ApiException(400, "Missing required parameter 'roleName' when calling GetRoleByRealmByRoleName");
    
            var path = "/{realm}/roles/{role-name}";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "realm" + "}", ApiClient.ParameterToString(realm));
path = path.Replace("{" + "role-name" + "}", ApiClient.ParameterToString(roleName));
    
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
                throw new ApiException ((int)response.StatusCode, "Error calling GetRoleByRealmByRoleName: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling GetRoleByRealmByRoleName: " + response.ErrorMessage, response.ErrorMessage);
    
            return (RoleRepresentation) ApiClient.Deserialize(response.Content, typeof(RoleRepresentation), response.Headers);
        }
    
        /// <summary>
        ///  Get composites of the role
        /// </summary>
        /// <param name="realm">realm name (not id!)</param>
        /// <param name="roleName">role&#x27;s name (not id!)</param>
        /// <returns>List&lt;RoleRepresentation&gt;</returns>
        public List<RoleRepresentation> GetRoleCompositesByRealmByRoleName (string realm, string roleName)
        {
            // verify the required parameter 'realm' is set
            if (realm == null) throw new ApiException(400, "Missing required parameter 'realm' when calling GetRoleCompositesByRealmByRoleName");
            // verify the required parameter 'roleName' is set
            if (roleName == null) throw new ApiException(400, "Missing required parameter 'roleName' when calling GetRoleCompositesByRealmByRoleName");
    
            var path = "/{realm}/roles/{role-name}/composites";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "realm" + "}", ApiClient.ParameterToString(realm));
path = path.Replace("{" + "role-name" + "}", ApiClient.ParameterToString(roleName));
    
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
                throw new ApiException ((int)response.StatusCode, "Error calling GetRoleCompositesByRealmByRoleName: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling GetRoleCompositesByRealmByRoleName: " + response.ErrorMessage, response.ErrorMessage);
    
            return (List<RoleRepresentation>) ApiClient.Deserialize(response.Content, typeof(List<RoleRepresentation>), response.Headers);
        }
    
        /// <summary>
        ///  Get client-level roles for the client that are in the role’s composite
        /// </summary>
        /// <param name="realm">realm name (not id!)</param>
        /// <param name="roleName">role&#x27;s name (not id!)</param>
        /// <param name="clientUuid"></param>
        /// <returns>List&lt;RoleRepresentation&gt;</returns>
        public List<RoleRepresentation> GetRoleCompositesClientByRealmByRoleNameByClientUuid (string realm, string roleName, string clientUuid)
        {
            // verify the required parameter 'realm' is set
            if (realm == null) throw new ApiException(400, "Missing required parameter 'realm' when calling GetRoleCompositesClientByRealmByRoleNameByClientUuid");
            // verify the required parameter 'roleName' is set
            if (roleName == null) throw new ApiException(400, "Missing required parameter 'roleName' when calling GetRoleCompositesClientByRealmByRoleNameByClientUuid");
            // verify the required parameter 'clientUuid' is set
            if (clientUuid == null) throw new ApiException(400, "Missing required parameter 'clientUuid' when calling GetRoleCompositesClientByRealmByRoleNameByClientUuid");
    
            var path = "/{realm}/roles/{role-name}/composites/clients/{clientUuid}";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "realm" + "}", ApiClient.ParameterToString(realm));
path = path.Replace("{" + "role-name" + "}", ApiClient.ParameterToString(roleName));
path = path.Replace("{" + "clientUuid" + "}", ApiClient.ParameterToString(clientUuid));
    
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
                throw new ApiException ((int)response.StatusCode, "Error calling GetRoleCompositesClientByRealmByRoleNameByClientUuid: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling GetRoleCompositesClientByRealmByRoleNameByClientUuid: " + response.ErrorMessage, response.ErrorMessage);
    
            return (List<RoleRepresentation>) ApiClient.Deserialize(response.Content, typeof(List<RoleRepresentation>), response.Headers);
        }
    
        /// <summary>
        ///  Get realm-level roles of the role’s composite
        /// </summary>
        /// <param name="realm">realm name (not id!)</param>
        /// <param name="roleName">role&#x27;s name (not id!)</param>
        /// <returns>List&lt;RoleRepresentation&gt;</returns>
        public List<RoleRepresentation> GetRoleCompositesRealmByRealmByRoleName (string realm, string roleName)
        {
            // verify the required parameter 'realm' is set
            if (realm == null) throw new ApiException(400, "Missing required parameter 'realm' when calling GetRoleCompositesRealmByRealmByRoleName");
            // verify the required parameter 'roleName' is set
            if (roleName == null) throw new ApiException(400, "Missing required parameter 'roleName' when calling GetRoleCompositesRealmByRealmByRoleName");
    
            var path = "/{realm}/roles/{role-name}/composites/realm";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "realm" + "}", ApiClient.ParameterToString(realm));
path = path.Replace("{" + "role-name" + "}", ApiClient.ParameterToString(roleName));
    
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
                throw new ApiException ((int)response.StatusCode, "Error calling GetRoleCompositesRealmByRealmByRoleName: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling GetRoleCompositesRealmByRealmByRoleName: " + response.ErrorMessage, response.ErrorMessage);
    
            return (List<RoleRepresentation>) ApiClient.Deserialize(response.Content, typeof(List<RoleRepresentation>), response.Headers);
        }
    
        /// <summary>
        ///  Returns a stream of groups that have the specified role name
        /// </summary>
        /// <param name="realm">realm name (not id!)</param>
        /// <param name="roleName">the role name.</param>
        /// <param name="briefRepresentation">if false, return a full representation of the {@code GroupRepresentation} objects.</param>
        /// <param name="first">first result to return. Ignored if negative or {@code null}.</param>
        /// <param name="max">maximum number of results to return. Ignored if negative or {@code null}.</param>
        /// <returns>List&lt;GroupRepresentation&gt;</returns>
        public List<GroupRepresentation> GetRoleGroupsByRealmByRoleName (string realm, string roleName, string briefRepresentation, string first, string max)
        {
            // verify the required parameter 'realm' is set
            if (realm == null) throw new ApiException(400, "Missing required parameter 'realm' when calling GetRoleGroupsByRealmByRoleName");
            // verify the required parameter 'roleName' is set
            if (roleName == null) throw new ApiException(400, "Missing required parameter 'roleName' when calling GetRoleGroupsByRealmByRoleName");
    
            var path = "/{realm}/roles/{role-name}/groups";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "realm" + "}", ApiClient.ParameterToString(realm));
path = path.Replace("{" + "role-name" + "}", ApiClient.ParameterToString(roleName));
    
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
             if (briefRepresentation != null) queryParams.Add("briefRepresentation", ApiClient.ParameterToString(briefRepresentation)); // query parameter
 if (first != null) queryParams.Add("first", ApiClient.ParameterToString(first)); // query parameter
 if (max != null) queryParams.Add("max", ApiClient.ParameterToString(max)); // query parameter
                        
            // authentication setting, if any
            String[] authSettings = new String[] { "access_token" };
    
            // make the HTTP request
            RestResponseBase response = (RestResponseBase) ApiClient.CallApi(path, Method.Get, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling GetRoleGroupsByRealmByRoleName: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling GetRoleGroupsByRealmByRoleName: " + response.ErrorMessage, response.ErrorMessage);
    
            return (List<GroupRepresentation>) ApiClient.Deserialize(response.Content, typeof(List<GroupRepresentation>), response.Headers);
        }
    
        /// <summary>
        ///  Return object stating whether role Authorization permissions have been initialized or not and a reference
        /// </summary>
        /// <param name="realm">realm name (not id!)</param>
        /// <param name="roleName"></param>
        /// <returns>ManagementPermissionReference</returns>
        public ManagementPermissionReference GetRoleManagementPermissionsByRealmByRoleName (string realm, string roleName)
        {
            // verify the required parameter 'realm' is set
            if (realm == null) throw new ApiException(400, "Missing required parameter 'realm' when calling GetRoleManagementPermissionsByRealmByRoleName");
            // verify the required parameter 'roleName' is set
            if (roleName == null) throw new ApiException(400, "Missing required parameter 'roleName' when calling GetRoleManagementPermissionsByRealmByRoleName");
    
            var path = "/{realm}/roles/{role-name}/management/permissions";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "realm" + "}", ApiClient.ParameterToString(realm));
path = path.Replace("{" + "role-name" + "}", ApiClient.ParameterToString(roleName));
    
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
                throw new ApiException ((int)response.StatusCode, "Error calling GetRoleManagementPermissionsByRealmByRoleName: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling GetRoleManagementPermissionsByRealmByRoleName: " + response.ErrorMessage, response.ErrorMessage);
    
            return (ManagementPermissionReference) ApiClient.Deserialize(response.Content, typeof(ManagementPermissionReference), response.Headers);
        }
    
        /// <summary>
        ///  Returns a stream of users that have the specified role name.
        /// </summary>
        /// <param name="realm">realm name (not id!)</param>
        /// <param name="roleName">the role name.</param>
        /// <param name="first">first result to return. Ignored if negative or {@code null}.</param>
        /// <param name="max">maximum number of results to return. Ignored if negative or {@code null}.</param>
        /// <returns>List&lt;UserRepresentation&gt;</returns>
        public List<UserRepresentation> GetRoleUsersByRealmByRoleName (string realm, string roleName, string first, string max)
        {
            // verify the required parameter 'realm' is set
            if (realm == null) throw new ApiException(400, "Missing required parameter 'realm' when calling GetRoleUsersByRealmByRoleName");
            // verify the required parameter 'roleName' is set
            if (roleName == null) throw new ApiException(400, "Missing required parameter 'roleName' when calling GetRoleUsersByRealmByRoleName");
    
            var path = "/{realm}/roles/{role-name}/users";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "realm" + "}", ApiClient.ParameterToString(realm));
path = path.Replace("{" + "role-name" + "}", ApiClient.ParameterToString(roleName));
    
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
                throw new ApiException ((int)response.StatusCode, "Error calling GetRoleUsersByRealmByRoleName: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling GetRoleUsersByRealmByRoleName: " + response.ErrorMessage, response.ErrorMessage);
    
            return (List<UserRepresentation>) ApiClient.Deserialize(response.Content, typeof(List<UserRepresentation>), response.Headers);
        }
    
        /// <summary>
        ///  Get all roles for the realm or client
        /// </summary>
        /// <param name="realm">realm name (not id!)</param>
        /// <param name="briefRepresentation"></param>
        /// <param name="first"></param>
        /// <param name="max"></param>
        /// <param name="search"></param>
        /// <returns>List&lt;RoleRepresentation&gt;</returns>
        public List<RoleRepresentation> GetRolesByRealm (string realm, string briefRepresentation, string first, string max, string search)
        {
            // verify the required parameter 'realm' is set
            if (realm == null) throw new ApiException(400, "Missing required parameter 'realm' when calling GetRolesByRealm");
    
            var path = "/{realm}/roles";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "realm" + "}", ApiClient.ParameterToString(realm));
    
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
             if (briefRepresentation != null) queryParams.Add("briefRepresentation", ApiClient.ParameterToString(briefRepresentation)); // query parameter
 if (first != null) queryParams.Add("first", ApiClient.ParameterToString(first)); // query parameter
 if (max != null) queryParams.Add("max", ApiClient.ParameterToString(max)); // query parameter
 if (search != null) queryParams.Add("search", ApiClient.ParameterToString(search)); // query parameter
                        
            // authentication setting, if any
            String[] authSettings = new String[] { "access_token" };
    
            // make the HTTP request
            RestResponseBase response = (RestResponseBase) ApiClient.CallApi(path, Method.Get, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling GetRolesByRealm: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling GetRolesByRealm: " + response.ErrorMessage, response.ErrorMessage);
    
            return (List<RoleRepresentation>) ApiClient.Deserialize(response.Content, typeof(List<RoleRepresentation>), response.Headers);
        }
    
        /// <summary>
        ///  Add a composite to the role
        /// </summary>
        /// <param name="realm">realm name (not id!)</param>
        /// <param name="id"></param>
        /// <param name="roleName">role&#x27;s name (not id!)</param>
        /// <param name="body">RoleRepresentation</param>
        /// <returns></returns>
        public void PostClientRoleComposites (string realm, string id, string roleName, RoleRepresentation body)
        {
            // verify the required parameter 'realm' is set
            if (realm == null) throw new ApiException(400, "Missing required parameter 'realm' when calling PostClientRoleComposites");
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling PostClientRoleComposites");
            // verify the required parameter 'roleName' is set
            if (roleName == null) throw new ApiException(400, "Missing required parameter 'roleName' when calling PostClientRoleComposites");
    
            var path = "/{realm}/clients/{id}/roles/{role-name}/composites";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "realm" + "}", ApiClient.ParameterToString(realm));
path = path.Replace("{" + "id" + "}", ApiClient.ParameterToString(id));
path = path.Replace("{" + "role-name" + "}", ApiClient.ParameterToString(roleName));
    
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
                throw new ApiException ((int)response.StatusCode, "Error calling PostClientRoleComposites: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling PostClientRoleComposites: " + response.ErrorMessage, response.ErrorMessage);
    
            return;
        }
    
        /// <summary>
        ///  Create a new role for the realm or client
        /// </summary>
        /// <param name="realm">realm name (not id!)</param>
        /// <param name="id"></param>
        /// <param name="body">RoleRepresentation</param>
        /// <returns></returns>
        public void PostClientRoles (string realm, string id, RoleRepresentation body)
        {
            // verify the required parameter 'realm' is set
            if (realm == null) throw new ApiException(400, "Missing required parameter 'realm' when calling PostClientRoles");
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling PostClientRoles");
    
            var path = "/{realm}/clients/{id}/roles";
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
                throw new ApiException ((int)response.StatusCode, "Error calling PostClientRoles: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling PostClientRoles: " + response.ErrorMessage, response.ErrorMessage);
    
            return;
        }
    
        /// <summary>
        ///  Add a composite to the role
        /// </summary>
        /// <param name="realm">realm name (not id!)</param>
        /// <param name="roleName">role&#x27;s name (not id!)</param>
        /// <param name="body">RoleRepresentation</param>
        /// <returns></returns>
        public void PostRoleCompositesByRealmByRoleName (string realm, string roleName, RoleRepresentation body)
        {
            // verify the required parameter 'realm' is set
            if (realm == null) throw new ApiException(400, "Missing required parameter 'realm' when calling PostRoleCompositesByRealmByRoleName");
            // verify the required parameter 'roleName' is set
            if (roleName == null) throw new ApiException(400, "Missing required parameter 'roleName' when calling PostRoleCompositesByRealmByRoleName");
    
            var path = "/{realm}/roles/{role-name}/composites";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "realm" + "}", ApiClient.ParameterToString(realm));
path = path.Replace("{" + "role-name" + "}", ApiClient.ParameterToString(roleName));
    
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
                throw new ApiException ((int)response.StatusCode, "Error calling PostRoleCompositesByRealmByRoleName: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling PostRoleCompositesByRealmByRoleName: " + response.ErrorMessage, response.ErrorMessage);
    
            return;
        }
    
        /// <summary>
        ///  Create a new role for the realm or client
        /// </summary>
        /// <param name="realm">realm name (not id!)</param>
        /// <param name="body">RoleRepresentation</param>
        /// <returns></returns>
        public void PostRolesByRealm (string realm, RoleRepresentation body)
        {
            // verify the required parameter 'realm' is set
            if (realm == null) throw new ApiException(400, "Missing required parameter 'realm' when calling PostRolesByRealm");
    
            var path = "/{realm}/roles";
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
                throw new ApiException ((int)response.StatusCode, "Error calling PostRolesByRealm: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling PostRolesByRealm: " + response.ErrorMessage, response.ErrorMessage);
    
            return;
        }
    
        /// <summary>
        ///  Update a role by name
        /// </summary>
        /// <param name="realm">realm name (not id!)</param>
        /// <param name="id"></param>
        /// <param name="roleName">role&#x27;s name (not id!)</param>
        /// <param name="body">RoleRepresentation</param>
        /// <returns></returns>
        public void PutClientRole (string realm, string id, string roleName, RoleRepresentation body)
        {
            // verify the required parameter 'realm' is set
            if (realm == null) throw new ApiException(400, "Missing required parameter 'realm' when calling PutClientRole");
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling PutClientRole");
            // verify the required parameter 'roleName' is set
            if (roleName == null) throw new ApiException(400, "Missing required parameter 'roleName' when calling PutClientRole");
    
            var path = "/{realm}/clients/{id}/roles/{role-name}";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "realm" + "}", ApiClient.ParameterToString(realm));
path = path.Replace("{" + "id" + "}", ApiClient.ParameterToString(id));
path = path.Replace("{" + "role-name" + "}", ApiClient.ParameterToString(roleName));
    
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
                throw new ApiException ((int)response.StatusCode, "Error calling PutClientRole: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling PutClientRole: " + response.ErrorMessage, response.ErrorMessage);
    
            return;
        }
    
        /// <summary>
        ///  Return object stating whether role Authorization permissions have been initialized or not and a reference
        /// </summary>
        /// <param name="realm">realm name (not id!)</param>
        /// <param name="id"></param>
        /// <param name="roleName"></param>
        /// <param name="body">ManagementPermissionReference</param>
        /// <returns>ManagementPermissionReference</returns>
        public ManagementPermissionReference PutClientRoleManagementPermissions (string realm, string id, string roleName, ManagementPermissionReference body)
        {
            // verify the required parameter 'realm' is set
            if (realm == null) throw new ApiException(400, "Missing required parameter 'realm' when calling PutClientRoleManagementPermissions");
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling PutClientRoleManagementPermissions");
            // verify the required parameter 'roleName' is set
            if (roleName == null) throw new ApiException(400, "Missing required parameter 'roleName' when calling PutClientRoleManagementPermissions");
    
            var path = "/{realm}/clients/{id}/roles/{role-name}/management/permissions";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "realm" + "}", ApiClient.ParameterToString(realm));
path = path.Replace("{" + "id" + "}", ApiClient.ParameterToString(id));
path = path.Replace("{" + "role-name" + "}", ApiClient.ParameterToString(roleName));
    
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
                throw new ApiException ((int)response.StatusCode, "Error calling PutClientRoleManagementPermissions: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling PutClientRoleManagementPermissions: " + response.ErrorMessage, response.ErrorMessage);
    
            return (ManagementPermissionReference) ApiClient.Deserialize(response.Content, typeof(ManagementPermissionReference), response.Headers);
        }
    
        /// <summary>
        ///  Update a role by name
        /// </summary>
        /// <param name="realm">realm name (not id!)</param>
        /// <param name="roleName">role&#x27;s name (not id!)</param>
        /// <param name="body">RoleRepresentation</param>
        /// <returns></returns>
        public void PutRoleByRealmByRoleName (string realm, string roleName, RoleRepresentation body)
        {
            // verify the required parameter 'realm' is set
            if (realm == null) throw new ApiException(400, "Missing required parameter 'realm' when calling PutRoleByRealmByRoleName");
            // verify the required parameter 'roleName' is set
            if (roleName == null) throw new ApiException(400, "Missing required parameter 'roleName' when calling PutRoleByRealmByRoleName");
    
            var path = "/{realm}/roles/{role-name}";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "realm" + "}", ApiClient.ParameterToString(realm));
path = path.Replace("{" + "role-name" + "}", ApiClient.ParameterToString(roleName));
    
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
                throw new ApiException ((int)response.StatusCode, "Error calling PutRoleByRealmByRoleName: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling PutRoleByRealmByRoleName: " + response.ErrorMessage, response.ErrorMessage);
    
            return;
        }
    
        /// <summary>
        ///  Return object stating whether role Authorization permissions have been initialized or not and a reference
        /// </summary>
        /// <param name="realm">realm name (not id!)</param>
        /// <param name="roleName"></param>
        /// <param name="body">ManagementPermissionReference</param>
        /// <returns>ManagementPermissionReference</returns>
        public ManagementPermissionReference PutRoleManagementPermissionsByRealmByRoleName (string realm, string roleName, ManagementPermissionReference body)
        {
            // verify the required parameter 'realm' is set
            if (realm == null) throw new ApiException(400, "Missing required parameter 'realm' when calling PutRoleManagementPermissionsByRealmByRoleName");
            // verify the required parameter 'roleName' is set
            if (roleName == null) throw new ApiException(400, "Missing required parameter 'roleName' when calling PutRoleManagementPermissionsByRealmByRoleName");
    
            var path = "/{realm}/roles/{role-name}/management/permissions";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "realm" + "}", ApiClient.ParameterToString(realm));
path = path.Replace("{" + "role-name" + "}", ApiClient.ParameterToString(roleName));
    
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
                throw new ApiException ((int)response.StatusCode, "Error calling PutRoleManagementPermissionsByRealmByRoleName: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling PutRoleManagementPermissionsByRealmByRoleName: " + response.ErrorMessage, response.ErrorMessage);
    
            return (ManagementPermissionReference) ApiClient.Deserialize(response.Content, typeof(ManagementPermissionReference), response.Headers);
        }
    
    }
}
