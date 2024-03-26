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
    public interface IRolesByIDApi
    {
        /// <summary>
        ///  Delete the role
        /// </summary>
        /// <param name="realm">realm name (not id!)</param>
        /// <param name="roleId">id of role</param>
        /// <returns></returns>
        void DeleteRolesById (string realm, string roleId);
        /// <summary>
        ///  Remove a set of roles from the role’s composite
        /// </summary>
        /// <param name="realm">realm name (not id!)</param>
        /// <param name="roleId"></param>
        /// <param name="body">RoleRepresentation</param>
        /// <returns></returns>
        void DeleteRolesByIdComposites (string realm, string roleId, RoleRepresentation body);
        /// <summary>
        ///  Get a specific role’s representation
        /// </summary>
        /// <param name="realm">realm name (not id!)</param>
        /// <param name="roleId">id of role</param>
        /// <returns>RoleRepresentation</returns>
        RoleRepresentation GetRolesById (string realm, string roleId);
        /// <summary>
        ///  Get role’s children Returns a set of role’s children provided the role is a composite.
        /// </summary>
        /// <param name="realm">realm name (not id!)</param>
        /// <param name="roleId"></param>
        /// <param name="first"></param>
        /// <param name="max"></param>
        /// <param name="search"></param>
        /// <returns>List&lt;RoleRepresentation&gt;</returns>
        List<RoleRepresentation> GetRolesByIdComposites (string realm, string roleId, string first, string max, string search);
        /// <summary>
        ///  Get client-level roles for the client that are in the role’s composite
        /// </summary>
        /// <param name="realm">realm name (not id!)</param>
        /// <param name="roleId"></param>
        /// <param name="clientUuid"></param>
        /// <returns>List&lt;RoleRepresentation&gt;</returns>
        List<RoleRepresentation> GetRolesByIdCompositesClient (string realm, string roleId, string clientUuid);
        /// <summary>
        ///  Get realm-level roles that are in the role’s composite
        /// </summary>
        /// <param name="realm">realm name (not id!)</param>
        /// <param name="roleId"></param>
        /// <returns>List&lt;RoleRepresentation&gt;</returns>
        List<RoleRepresentation> GetRolesByIdCompositesRealm (string realm, string roleId);
        /// <summary>
        ///  Return object stating whether role Authorization permissions have been initialized or not and a reference
        /// </summary>
        /// <param name="realm">realm name (not id!)</param>
        /// <param name="roleId"></param>
        /// <returns>ManagementPermissionReference</returns>
        ManagementPermissionReference GetRolesByIdManagementPermissions (string realm, string roleId);
        /// <summary>
        ///  Make the role a composite role by associating some child roles
        /// </summary>
        /// <param name="realm">realm name (not id!)</param>
        /// <param name="roleId"></param>
        /// <param name="body">RoleRepresentation</param>
        /// <returns></returns>
        void PostRolesByIdComposites (string realm, string roleId, RoleRepresentation body);
        /// <summary>
        ///  Update the role
        /// </summary>
        /// <param name="realm">realm name (not id!)</param>
        /// <param name="roleId">id of role</param>
        /// <param name="body">RoleRepresentation</param>
        /// <returns></returns>
        void PutRolesById (string realm, string roleId, RoleRepresentation body);
        /// <summary>
        ///  Return object stating whether role Authorization permissions have been initialized or not and a reference
        /// </summary>
        /// <param name="realm">realm name (not id!)</param>
        /// <param name="roleId"></param>
        /// <param name="body">ManagementPermissionReference</param>
        /// <returns>ManagementPermissionReference</returns>
        ManagementPermissionReference PutRolesByIdManagementPermissions (string realm, string roleId, ManagementPermissionReference body);
    }
  
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public class RolesByIDApi : IRolesByIDApi
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="RolesByIDApi"/> class.
        /// </summary>
        /// <param name="apiClient"> an instance of ApiClient (optional)</param>
        /// <returns></returns>
        public RolesByIDApi(ApiClient apiClient = null)
        {
            if (apiClient == null) // use the default one in Configuration
                this.ApiClient = Configuration.DefaultApiClient; 
            else
                this.ApiClient = apiClient;
        }
    
        /// <summary>
        /// Initializes a new instance of the <see cref="RolesByIDApi"/> class.
        /// </summary>
        /// <returns></returns>
        public RolesByIDApi(String basePath)
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
        ///  Delete the role
        /// </summary>
        /// <param name="realm">realm name (not id!)</param>
        /// <param name="roleId">id of role</param>
        /// <returns></returns>
        public void DeleteRolesById (string realm, string roleId)
        {
            // verify the required parameter 'realm' is set
            if (realm == null) throw new ApiException(400, "Missing required parameter 'realm' when calling DeleteRolesById");
            // verify the required parameter 'roleId' is set
            if (roleId == null) throw new ApiException(400, "Missing required parameter 'roleId' when calling DeleteRolesById");
    
            var path = "/{realm}/roles-by-id/{role-id}";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "realm" + "}", ApiClient.ParameterToString(realm));
path = path.Replace("{" + "role-id" + "}", ApiClient.ParameterToString(roleId));
    
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
                throw new ApiException ((int)response.StatusCode, "Error calling DeleteRolesById: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling DeleteRolesById: " + response.ErrorMessage, response.ErrorMessage);
    
            return;
        }
    
        /// <summary>
        ///  Remove a set of roles from the role’s composite
        /// </summary>
        /// <param name="realm">realm name (not id!)</param>
        /// <param name="roleId"></param>
        /// <param name="body">RoleRepresentation</param>
        /// <returns></returns>
        public void DeleteRolesByIdComposites (string realm, string roleId, RoleRepresentation body)
        {
            // verify the required parameter 'realm' is set
            if (realm == null) throw new ApiException(400, "Missing required parameter 'realm' when calling DeleteRolesByIdComposites");
            // verify the required parameter 'roleId' is set
            if (roleId == null) throw new ApiException(400, "Missing required parameter 'roleId' when calling DeleteRolesByIdComposites");
    
            var path = "/{realm}/roles-by-id/{role-id}/composites";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "realm" + "}", ApiClient.ParameterToString(realm));
path = path.Replace("{" + "role-id" + "}", ApiClient.ParameterToString(roleId));
    
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
                throw new ApiException ((int)response.StatusCode, "Error calling DeleteRolesByIdComposites: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling DeleteRolesByIdComposites: " + response.ErrorMessage, response.ErrorMessage);
    
            return;
        }
    
        /// <summary>
        ///  Get a specific role’s representation
        /// </summary>
        /// <param name="realm">realm name (not id!)</param>
        /// <param name="roleId">id of role</param>
        /// <returns>RoleRepresentation</returns>
        public RoleRepresentation GetRolesById (string realm, string roleId)
        {
            // verify the required parameter 'realm' is set
            if (realm == null) throw new ApiException(400, "Missing required parameter 'realm' when calling GetRolesById");
            // verify the required parameter 'roleId' is set
            if (roleId == null) throw new ApiException(400, "Missing required parameter 'roleId' when calling GetRolesById");
    
            var path = "/{realm}/roles-by-id/{role-id}";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "realm" + "}", ApiClient.ParameterToString(realm));
path = path.Replace("{" + "role-id" + "}", ApiClient.ParameterToString(roleId));
    
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
                throw new ApiException ((int)response.StatusCode, "Error calling GetRolesById: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling GetRolesById: " + response.ErrorMessage, response.ErrorMessage);
    
            return (RoleRepresentation) ApiClient.Deserialize(response.Content, typeof(RoleRepresentation), response.Headers);
        }
    
        /// <summary>
        ///  Get role’s children Returns a set of role’s children provided the role is a composite.
        /// </summary>
        /// <param name="realm">realm name (not id!)</param>
        /// <param name="roleId"></param>
        /// <param name="first"></param>
        /// <param name="max"></param>
        /// <param name="search"></param>
        /// <returns>List&lt;RoleRepresentation&gt;</returns>
        public List<RoleRepresentation> GetRolesByIdComposites (string realm, string roleId, string first, string max, string search)
        {
            // verify the required parameter 'realm' is set
            if (realm == null) throw new ApiException(400, "Missing required parameter 'realm' when calling GetRolesByIdComposites");
            // verify the required parameter 'roleId' is set
            if (roleId == null) throw new ApiException(400, "Missing required parameter 'roleId' when calling GetRolesByIdComposites");
    
            var path = "/{realm}/roles-by-id/{role-id}/composites";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "realm" + "}", ApiClient.ParameterToString(realm));
path = path.Replace("{" + "role-id" + "}", ApiClient.ParameterToString(roleId));
    
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
             if (first != null) queryParams.Add("first", ApiClient.ParameterToString(first)); // query parameter
 if (max != null) queryParams.Add("max", ApiClient.ParameterToString(max)); // query parameter
 if (search != null) queryParams.Add("search", ApiClient.ParameterToString(search)); // query parameter
                        
            // authentication setting, if any
            String[] authSettings = new String[] { "access_token" };
    
            // make the HTTP request
            RestResponseBase response = (RestResponseBase) ApiClient.CallApi(path, Method.Get, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling GetRolesByIdComposites: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling GetRolesByIdComposites: " + response.ErrorMessage, response.ErrorMessage);
    
            return (List<RoleRepresentation>) ApiClient.Deserialize(response.Content, typeof(List<RoleRepresentation>), response.Headers);
        }
    
        /// <summary>
        ///  Get client-level roles for the client that are in the role’s composite
        /// </summary>
        /// <param name="realm">realm name (not id!)</param>
        /// <param name="roleId"></param>
        /// <param name="clientUuid"></param>
        /// <returns>List&lt;RoleRepresentation&gt;</returns>
        public List<RoleRepresentation> GetRolesByIdCompositesClient (string realm, string roleId, string clientUuid)
        {
            // verify the required parameter 'realm' is set
            if (realm == null) throw new ApiException(400, "Missing required parameter 'realm' when calling GetRolesByIdCompositesClient");
            // verify the required parameter 'roleId' is set
            if (roleId == null) throw new ApiException(400, "Missing required parameter 'roleId' when calling GetRolesByIdCompositesClient");
            // verify the required parameter 'clientUuid' is set
            if (clientUuid == null) throw new ApiException(400, "Missing required parameter 'clientUuid' when calling GetRolesByIdCompositesClient");
    
            var path = "/{realm}/roles-by-id/{role-id}/composites/clients/{clientUuid}";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "realm" + "}", ApiClient.ParameterToString(realm));
path = path.Replace("{" + "role-id" + "}", ApiClient.ParameterToString(roleId));
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
                throw new ApiException ((int)response.StatusCode, "Error calling GetRolesByIdCompositesClient: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling GetRolesByIdCompositesClient: " + response.ErrorMessage, response.ErrorMessage);
    
            return (List<RoleRepresentation>) ApiClient.Deserialize(response.Content, typeof(List<RoleRepresentation>), response.Headers);
        }
    
        /// <summary>
        ///  Get realm-level roles that are in the role’s composite
        /// </summary>
        /// <param name="realm">realm name (not id!)</param>
        /// <param name="roleId"></param>
        /// <returns>List&lt;RoleRepresentation&gt;</returns>
        public List<RoleRepresentation> GetRolesByIdCompositesRealm (string realm, string roleId)
        {
            // verify the required parameter 'realm' is set
            if (realm == null) throw new ApiException(400, "Missing required parameter 'realm' when calling GetRolesByIdCompositesRealm");
            // verify the required parameter 'roleId' is set
            if (roleId == null) throw new ApiException(400, "Missing required parameter 'roleId' when calling GetRolesByIdCompositesRealm");
    
            var path = "/{realm}/roles-by-id/{role-id}/composites/realm";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "realm" + "}", ApiClient.ParameterToString(realm));
path = path.Replace("{" + "role-id" + "}", ApiClient.ParameterToString(roleId));
    
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
                throw new ApiException ((int)response.StatusCode, "Error calling GetRolesByIdCompositesRealm: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling GetRolesByIdCompositesRealm: " + response.ErrorMessage, response.ErrorMessage);
    
            return (List<RoleRepresentation>) ApiClient.Deserialize(response.Content, typeof(List<RoleRepresentation>), response.Headers);
        }
    
        /// <summary>
        ///  Return object stating whether role Authorization permissions have been initialized or not and a reference
        /// </summary>
        /// <param name="realm">realm name (not id!)</param>
        /// <param name="roleId"></param>
        /// <returns>ManagementPermissionReference</returns>
        public ManagementPermissionReference GetRolesByIdManagementPermissions (string realm, string roleId)
        {
            // verify the required parameter 'realm' is set
            if (realm == null) throw new ApiException(400, "Missing required parameter 'realm' when calling GetRolesByIdManagementPermissions");
            // verify the required parameter 'roleId' is set
            if (roleId == null) throw new ApiException(400, "Missing required parameter 'roleId' when calling GetRolesByIdManagementPermissions");
    
            var path = "/{realm}/roles-by-id/{role-id}/management/permissions";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "realm" + "}", ApiClient.ParameterToString(realm));
path = path.Replace("{" + "role-id" + "}", ApiClient.ParameterToString(roleId));
    
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
                throw new ApiException ((int)response.StatusCode, "Error calling GetRolesByIdManagementPermissions: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling GetRolesByIdManagementPermissions: " + response.ErrorMessage, response.ErrorMessage);
    
            return (ManagementPermissionReference) ApiClient.Deserialize(response.Content, typeof(ManagementPermissionReference), response.Headers);
        }
    
        /// <summary>
        ///  Make the role a composite role by associating some child roles
        /// </summary>
        /// <param name="realm">realm name (not id!)</param>
        /// <param name="roleId"></param>
        /// <param name="body">RoleRepresentation</param>
        /// <returns></returns>
        public void PostRolesByIdComposites (string realm, string roleId, RoleRepresentation body)
        {
            // verify the required parameter 'realm' is set
            if (realm == null) throw new ApiException(400, "Missing required parameter 'realm' when calling PostRolesByIdComposites");
            // verify the required parameter 'roleId' is set
            if (roleId == null) throw new ApiException(400, "Missing required parameter 'roleId' when calling PostRolesByIdComposites");
    
            var path = "/{realm}/roles-by-id/{role-id}/composites";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "realm" + "}", ApiClient.ParameterToString(realm));
path = path.Replace("{" + "role-id" + "}", ApiClient.ParameterToString(roleId));
    
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
                throw new ApiException ((int)response.StatusCode, "Error calling PostRolesByIdComposites: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling PostRolesByIdComposites: " + response.ErrorMessage, response.ErrorMessage);
    
            return;
        }
    
        /// <summary>
        ///  Update the role
        /// </summary>
        /// <param name="realm">realm name (not id!)</param>
        /// <param name="roleId">id of role</param>
        /// <param name="body">RoleRepresentation</param>
        /// <returns></returns>
        public void PutRolesById (string realm, string roleId, RoleRepresentation body)
        {
            // verify the required parameter 'realm' is set
            if (realm == null) throw new ApiException(400, "Missing required parameter 'realm' when calling PutRolesById");
            // verify the required parameter 'roleId' is set
            if (roleId == null) throw new ApiException(400, "Missing required parameter 'roleId' when calling PutRolesById");
    
            var path = "/{realm}/roles-by-id/{role-id}";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "realm" + "}", ApiClient.ParameterToString(realm));
path = path.Replace("{" + "role-id" + "}", ApiClient.ParameterToString(roleId));
    
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
                throw new ApiException ((int)response.StatusCode, "Error calling PutRolesById: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling PutRolesById: " + response.ErrorMessage, response.ErrorMessage);
    
            return;
        }
    
        /// <summary>
        ///  Return object stating whether role Authorization permissions have been initialized or not and a reference
        /// </summary>
        /// <param name="realm">realm name (not id!)</param>
        /// <param name="roleId"></param>
        /// <param name="body">ManagementPermissionReference</param>
        /// <returns>ManagementPermissionReference</returns>
        public ManagementPermissionReference PutRolesByIdManagementPermissions (string realm, string roleId, ManagementPermissionReference body)
        {
            // verify the required parameter 'realm' is set
            if (realm == null) throw new ApiException(400, "Missing required parameter 'realm' when calling PutRolesByIdManagementPermissions");
            // verify the required parameter 'roleId' is set
            if (roleId == null) throw new ApiException(400, "Missing required parameter 'roleId' when calling PutRolesByIdManagementPermissions");
    
            var path = "/{realm}/roles-by-id/{role-id}/management/permissions";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "realm" + "}", ApiClient.ParameterToString(realm));
path = path.Replace("{" + "role-id" + "}", ApiClient.ParameterToString(roleId));
    
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
                throw new ApiException ((int)response.StatusCode, "Error calling PutRolesByIdManagementPermissions: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling PutRolesByIdManagementPermissions: " + response.ErrorMessage, response.ErrorMessage);
    
            return (ManagementPermissionReference) ApiClient.Deserialize(response.Content, typeof(ManagementPermissionReference), response.Headers);
        }
    
    }
}
