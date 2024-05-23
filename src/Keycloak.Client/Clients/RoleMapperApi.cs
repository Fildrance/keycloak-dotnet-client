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
    public partial interface IRoleMapperApi
    {
        /// <summary>
        ///  Delete realm-level role mappings
        /// </summary>
        /// <param name="realm">realm name (not id!)</param>
        /// <param name="id"></param>
        /// <param name="body">RoleRepresentation</param>
        /// <param name="ct"></param>
        /// <returns></returns>
        Task DeleteGroupRoleMappingsRealm (string realm, string id, RoleRepresentation body, CancellationToken ct);
        /// <summary>
        ///  Delete realm-level role mappings
        /// </summary>
        /// <param name="realm">realm name (not id!)</param>
        /// <param name="id"></param>
        /// <param name="body">RoleRepresentation</param>
        /// <param name="ct"></param>
        /// <returns></returns>
        Task DeleteUserRoleMappingsRealm (string realm, string id, RoleRepresentation body, CancellationToken ct);
        /// <summary>
        ///  Get role mappings
        /// </summary>
        /// <param name="realm">realm name (not id!)</param>
        /// <param name="id"></param>
        /// <param name="ct"></param>
        /// <returns>MappingsRepresentation</returns>
        Task<MappingsRepresentation> GetGroupRoleMappings (string realm, string id, CancellationToken ct);
        /// <summary>
        ///  Get realm-level role mappings
        /// </summary>
        /// <param name="realm">realm name (not id!)</param>
        /// <param name="id"></param>
        /// <param name="ct"></param>
        /// <returns>List&lt;RoleRepresentation&gt;</returns>
        Task<List<RoleRepresentation>> GetGroupRoleMappingsRealm (string realm, string id, CancellationToken ct);
        /// <summary>
        ///  Get realm-level roles that can be mapped
        /// </summary>
        /// <param name="realm">realm name (not id!)</param>
        /// <param name="id"></param>
        /// <param name="ct"></param>
        /// <returns>List&lt;RoleRepresentation&gt;</returns>
        Task<List<RoleRepresentation>> GetGroupRoleMappingsRealmAvailable (string realm, string id, CancellationToken ct);
        /// <summary>
        ///  Get effective realm-level role mappings This will recurse all composite roles to get the result.
        /// </summary>
        /// <param name="realm">realm name (not id!)</param>
        /// <param name="id"></param>
        /// <param name="briefRepresentation">if false, return roles with their attributes</param>
        /// <param name="ct"></param>
        /// <returns>List&lt;RoleRepresentation&gt;</returns>
        Task<List<RoleRepresentation>> GetGroupRoleMappingsRealmComposite (string realm, string id, string briefRepresentation, CancellationToken ct);
        /// <summary>
        ///  Get role mappings
        /// </summary>
        /// <param name="realm">realm name (not id!)</param>
        /// <param name="id"></param>
        /// <param name="ct"></param>
        /// <returns>MappingsRepresentation</returns>
        Task<MappingsRepresentation> GetUserRoleMappings (string realm, string id, CancellationToken ct);
        /// <summary>
        ///  Get realm-level role mappings
        /// </summary>
        /// <param name="realm">realm name (not id!)</param>
        /// <param name="id"></param>
        /// <param name="ct"></param>
        /// <returns>List&lt;RoleRepresentation&gt;</returns>
        Task<List<RoleRepresentation>> GetUserRoleMappingsRealm (string realm, string id, CancellationToken ct);
        /// <summary>
        ///  Get realm-level roles that can be mapped
        /// </summary>
        /// <param name="realm">realm name (not id!)</param>
        /// <param name="id"></param>
        /// <param name="ct"></param>
        /// <returns>List&lt;RoleRepresentation&gt;</returns>
        Task<List<RoleRepresentation>> GetUserRoleMappingsRealmAvailable (string realm, string id, CancellationToken ct);
        /// <summary>
        ///  Get effective realm-level role mappings This will recurse all composite roles to get the result.
        /// </summary>
        /// <param name="realm">realm name (not id!)</param>
        /// <param name="id"></param>
        /// <param name="briefRepresentation">if false, return roles with their attributes</param>
        /// <param name="ct"></param>
        /// <returns>List&lt;RoleRepresentation&gt;</returns>
        Task<List<RoleRepresentation>> GetUserRoleMappingsRealmComposite (string realm, string id, string briefRepresentation, CancellationToken ct);
        /// <summary>
        ///  Add realm-level role mappings to the user
        /// </summary>
        /// <param name="realm">realm name (not id!)</param>
        /// <param name="id"></param>
        /// <param name="body">RoleRepresentation</param>
        /// <param name="ct"></param>
        /// <returns></returns>
        Task PostGroupRoleMappingsRealm (string realm, string id, RoleRepresentation body, CancellationToken ct);
        /// <summary>
        ///  Add realm-level role mappings to the user
        /// </summary>
        /// <param name="realm">realm name (not id!)</param>
        /// <param name="id"></param>
        /// <param name="body">RoleRepresentation</param>
        /// <param name="ct"></param>
        /// <returns></returns>
        Task PostUserRoleMappingsRealm (string realm, string id, RoleRepresentation body, CancellationToken ct);
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>  
    [GeneratedCode("swagger-codegen", "3.0.56-SNAPSHOT")]
    public partial class RoleMapperApi : KeycloakClientApiClientBase, IRoleMapperApi
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="RoleMapperApi"/> class.
        /// </summary>
        /// <param name="httpClient"> HttpClient to be used for calls. </param>
        /// <param name="basePath"> Base url to be used for calls. </param>
        public RoleMapperApi(HttpClient httpClient, String basePath="https://keycloak.example.com/admin/realms") : base(httpClient, basePath)
        {
        }

        /// <inheritdoc />     
        public async Task DeleteGroupRoleMappingsRealm(string realm, string id, RoleRepresentation body, CancellationToken ct)
        {
            // verify the required parameter 'realm' is set
            if (realm == null) throw new KeycloakClientApiException(400, "Missing required parameter 'realm' when calling DeleteGroupRoleMappingsRealm");
            // verify the required parameter 'id' is set
            if (id == null) throw new KeycloakClientApiException(400, "Missing required parameter 'id' when calling DeleteGroupRoleMappingsRealm");
            
            var path_ = new StringBuilder("/{realm}/groups/{id}/role-mappings/realm"); 
            path_ = path_.Replace("{realm}", ParameterToString(realm));
            path_ = path_.Replace("{id}", ParameterToString(id));

            
        
            await CallApi(
                        path_.ToString(), 
                        HttpMethod.Delete,
                        body: body,   
                        ct: ct
            );
        }

        /// <inheritdoc />     
        public async Task DeleteUserRoleMappingsRealm(string realm, string id, RoleRepresentation body, CancellationToken ct)
        {
            // verify the required parameter 'realm' is set
            if (realm == null) throw new KeycloakClientApiException(400, "Missing required parameter 'realm' when calling DeleteUserRoleMappingsRealm");
            // verify the required parameter 'id' is set
            if (id == null) throw new KeycloakClientApiException(400, "Missing required parameter 'id' when calling DeleteUserRoleMappingsRealm");
            
            var path_ = new StringBuilder("/{realm}/users/{id}/role-mappings/realm"); 
            path_ = path_.Replace("{realm}", ParameterToString(realm));
            path_ = path_.Replace("{id}", ParameterToString(id));

            
        
            await CallApi(
                        path_.ToString(), 
                        HttpMethod.Delete,
                        body: body,   
                        ct: ct
            );
        }

        /// <inheritdoc />     
        public async Task<MappingsRepresentation> GetGroupRoleMappings(string realm, string id, CancellationToken ct)
        {
            // verify the required parameter 'realm' is set
            if (realm == null) throw new KeycloakClientApiException(400, "Missing required parameter 'realm' when calling GetGroupRoleMappings");
            // verify the required parameter 'id' is set
            if (id == null) throw new KeycloakClientApiException(400, "Missing required parameter 'id' when calling GetGroupRoleMappings");
            
            var path_ = new StringBuilder("/{realm}/groups/{id}/role-mappings"); 
            path_ = path_.Replace("{realm}", ParameterToString(realm));
            path_ = path_.Replace("{id}", ParameterToString(id));

            
        
            var response = await CallApi<MappingsRepresentation>(
                        path_.ToString(), 
                        HttpMethod.Get,  
                        ct: ct
            );
            return response;
        }

        /// <inheritdoc />     
        public async Task<List<RoleRepresentation>> GetGroupRoleMappingsRealm(string realm, string id, CancellationToken ct)
        {
            // verify the required parameter 'realm' is set
            if (realm == null) throw new KeycloakClientApiException(400, "Missing required parameter 'realm' when calling GetGroupRoleMappingsRealm");
            // verify the required parameter 'id' is set
            if (id == null) throw new KeycloakClientApiException(400, "Missing required parameter 'id' when calling GetGroupRoleMappingsRealm");
            
            var path_ = new StringBuilder("/{realm}/groups/{id}/role-mappings/realm"); 
            path_ = path_.Replace("{realm}", ParameterToString(realm));
            path_ = path_.Replace("{id}", ParameterToString(id));

            
        
            var response = await CallApi<List<RoleRepresentation>>(
                        path_.ToString(), 
                        HttpMethod.Get,  
                        ct: ct
            );
            return response;
        }

        /// <inheritdoc />     
        public async Task<List<RoleRepresentation>> GetGroupRoleMappingsRealmAvailable(string realm, string id, CancellationToken ct)
        {
            // verify the required parameter 'realm' is set
            if (realm == null) throw new KeycloakClientApiException(400, "Missing required parameter 'realm' when calling GetGroupRoleMappingsRealmAvailable");
            // verify the required parameter 'id' is set
            if (id == null) throw new KeycloakClientApiException(400, "Missing required parameter 'id' when calling GetGroupRoleMappingsRealmAvailable");
            
            var path_ = new StringBuilder("/{realm}/groups/{id}/role-mappings/realm/available"); 
            path_ = path_.Replace("{realm}", ParameterToString(realm));
            path_ = path_.Replace("{id}", ParameterToString(id));

            
        
            var response = await CallApi<List<RoleRepresentation>>(
                        path_.ToString(), 
                        HttpMethod.Get,  
                        ct: ct
            );
            return response;
        }

        /// <inheritdoc />     
        public async Task<List<RoleRepresentation>> GetGroupRoleMappingsRealmComposite(string realm, string id, string briefRepresentation, CancellationToken ct)
        {
            // verify the required parameter 'realm' is set
            if (realm == null) throw new KeycloakClientApiException(400, "Missing required parameter 'realm' when calling GetGroupRoleMappingsRealmComposite");
            // verify the required parameter 'id' is set
            if (id == null) throw new KeycloakClientApiException(400, "Missing required parameter 'id' when calling GetGroupRoleMappingsRealmComposite");
            
            var path_ = new StringBuilder("/{realm}/groups/{id}/role-mappings/realm/composite"); 
            path_ = path_.Replace("{realm}", ParameterToString(realm));
            path_ = path_.Replace("{id}", ParameterToString(id));

            var queryParams = new Dictionary<string, string>();
             
            if (briefRepresentation != null) queryParams.Add("briefRepresentation", ParameterToString(briefRepresentation)); // query parameter
        
            var response = await CallApi<List<RoleRepresentation>>(
                        path_.ToString(), 
                        HttpMethod.Get,
                        queryParams: queryParams,  
                        ct: ct
            );
            return response;
        }

        /// <inheritdoc />     
        public async Task<MappingsRepresentation> GetUserRoleMappings(string realm, string id, CancellationToken ct)
        {
            // verify the required parameter 'realm' is set
            if (realm == null) throw new KeycloakClientApiException(400, "Missing required parameter 'realm' when calling GetUserRoleMappings");
            // verify the required parameter 'id' is set
            if (id == null) throw new KeycloakClientApiException(400, "Missing required parameter 'id' when calling GetUserRoleMappings");
            
            var path_ = new StringBuilder("/{realm}/users/{id}/role-mappings"); 
            path_ = path_.Replace("{realm}", ParameterToString(realm));
            path_ = path_.Replace("{id}", ParameterToString(id));

            
        
            var response = await CallApi<MappingsRepresentation>(
                        path_.ToString(), 
                        HttpMethod.Get,  
                        ct: ct
            );
            return response;
        }

        /// <inheritdoc />     
        public async Task<List<RoleRepresentation>> GetUserRoleMappingsRealm(string realm, string id, CancellationToken ct)
        {
            // verify the required parameter 'realm' is set
            if (realm == null) throw new KeycloakClientApiException(400, "Missing required parameter 'realm' when calling GetUserRoleMappingsRealm");
            // verify the required parameter 'id' is set
            if (id == null) throw new KeycloakClientApiException(400, "Missing required parameter 'id' when calling GetUserRoleMappingsRealm");
            
            var path_ = new StringBuilder("/{realm}/users/{id}/role-mappings/realm"); 
            path_ = path_.Replace("{realm}", ParameterToString(realm));
            path_ = path_.Replace("{id}", ParameterToString(id));

            
        
            var response = await CallApi<List<RoleRepresentation>>(
                        path_.ToString(), 
                        HttpMethod.Get,  
                        ct: ct
            );
            return response;
        }

        /// <inheritdoc />     
        public async Task<List<RoleRepresentation>> GetUserRoleMappingsRealmAvailable(string realm, string id, CancellationToken ct)
        {
            // verify the required parameter 'realm' is set
            if (realm == null) throw new KeycloakClientApiException(400, "Missing required parameter 'realm' when calling GetUserRoleMappingsRealmAvailable");
            // verify the required parameter 'id' is set
            if (id == null) throw new KeycloakClientApiException(400, "Missing required parameter 'id' when calling GetUserRoleMappingsRealmAvailable");
            
            var path_ = new StringBuilder("/{realm}/users/{id}/role-mappings/realm/available"); 
            path_ = path_.Replace("{realm}", ParameterToString(realm));
            path_ = path_.Replace("{id}", ParameterToString(id));

            
        
            var response = await CallApi<List<RoleRepresentation>>(
                        path_.ToString(), 
                        HttpMethod.Get,  
                        ct: ct
            );
            return response;
        }

        /// <inheritdoc />     
        public async Task<List<RoleRepresentation>> GetUserRoleMappingsRealmComposite(string realm, string id, string briefRepresentation, CancellationToken ct)
        {
            // verify the required parameter 'realm' is set
            if (realm == null) throw new KeycloakClientApiException(400, "Missing required parameter 'realm' when calling GetUserRoleMappingsRealmComposite");
            // verify the required parameter 'id' is set
            if (id == null) throw new KeycloakClientApiException(400, "Missing required parameter 'id' when calling GetUserRoleMappingsRealmComposite");
            
            var path_ = new StringBuilder("/{realm}/users/{id}/role-mappings/realm/composite"); 
            path_ = path_.Replace("{realm}", ParameterToString(realm));
            path_ = path_.Replace("{id}", ParameterToString(id));

            var queryParams = new Dictionary<string, string>();
             
            if (briefRepresentation != null) queryParams.Add("briefRepresentation", ParameterToString(briefRepresentation)); // query parameter
        
            var response = await CallApi<List<RoleRepresentation>>(
                        path_.ToString(), 
                        HttpMethod.Get,
                        queryParams: queryParams,  
                        ct: ct
            );
            return response;
        }

        /// <inheritdoc />     
        public async Task PostGroupRoleMappingsRealm(string realm, string id, RoleRepresentation body, CancellationToken ct)
        {
            // verify the required parameter 'realm' is set
            if (realm == null) throw new KeycloakClientApiException(400, "Missing required parameter 'realm' when calling PostGroupRoleMappingsRealm");
            // verify the required parameter 'id' is set
            if (id == null) throw new KeycloakClientApiException(400, "Missing required parameter 'id' when calling PostGroupRoleMappingsRealm");
            
            var path_ = new StringBuilder("/{realm}/groups/{id}/role-mappings/realm"); 
            path_ = path_.Replace("{realm}", ParameterToString(realm));
            path_ = path_.Replace("{id}", ParameterToString(id));

            
        
            await CallApi(
                        path_.ToString(), 
                        HttpMethod.Post,
                        body: body,   
                        ct: ct
            );
        }

        /// <inheritdoc />     
        public async Task PostUserRoleMappingsRealm(string realm, string id, RoleRepresentation body, CancellationToken ct)
        {
            // verify the required parameter 'realm' is set
            if (realm == null) throw new KeycloakClientApiException(400, "Missing required parameter 'realm' when calling PostUserRoleMappingsRealm");
            // verify the required parameter 'id' is set
            if (id == null) throw new KeycloakClientApiException(400, "Missing required parameter 'id' when calling PostUserRoleMappingsRealm");
            
            var path_ = new StringBuilder("/{realm}/users/{id}/role-mappings/realm"); 
            path_ = path_.Replace("{realm}", ParameterToString(realm));
            path_ = path_.Replace("{id}", ParameterToString(id));

            
        
            await CallApi(
                        path_.ToString(), 
                        HttpMethod.Post,
                        body: body,   
                        ct: ct
            );
        }

    }
}