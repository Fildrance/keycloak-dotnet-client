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
    public partial interface IClientRoleMappingsApi
    {
        /// <summary>
        ///  Delete client-level roles from user role mapping
        /// </summary>
        /// <param name="realm">realm name (not id!)</param>
        /// <param name="id"></param>
        /// <param name="_client"></param>
        /// <param name="body">RoleRepresentation</param>
        /// <param name="ct"></param>
        /// <returns></returns>
        Task DeleteGroupRoleMappingsClient (string realm, string id, string _client, RoleRepresentation body, CancellationToken ct);
        /// <summary>
        ///  Delete client-level roles from user role mapping
        /// </summary>
        /// <param name="realm">realm name (not id!)</param>
        /// <param name="id"></param>
        /// <param name="_client"></param>
        /// <param name="body">RoleRepresentation</param>
        /// <param name="ct"></param>
        /// <returns></returns>
        Task DeleteUserRoleMappingsClient (string realm, string id, string _client, RoleRepresentation body, CancellationToken ct);
        /// <summary>
        ///  Get client-level role mappings for the user, and the app
        /// </summary>
        /// <param name="realm">realm name (not id!)</param>
        /// <param name="id"></param>
        /// <param name="_client"></param>
        /// <param name="ct"></param>
        /// <returns>List&lt;RoleRepresentation&gt;</returns>
        Task<List<RoleRepresentation>> GetGroupRoleMappingsClient (string realm, string id, string _client, CancellationToken ct);
        /// <summary>
        ///  Get available client-level roles that can be mapped to the user
        /// </summary>
        /// <param name="realm">realm name (not id!)</param>
        /// <param name="id"></param>
        /// <param name="_client"></param>
        /// <param name="ct"></param>
        /// <returns>List&lt;RoleRepresentation&gt;</returns>
        Task<List<RoleRepresentation>> GetGroupRoleMappingsClientAvailable (string realm, string id, string _client, CancellationToken ct);
        /// <summary>
        ///  Get effective client-level role mappings This recurses any composite roles
        /// </summary>
        /// <param name="realm">realm name (not id!)</param>
        /// <param name="id"></param>
        /// <param name="_client"></param>
        /// <param name="briefRepresentation">if false, return roles with their attributes</param>
        /// <param name="ct"></param>
        /// <returns>List&lt;RoleRepresentation&gt;</returns>
        Task<List<RoleRepresentation>> GetGroupRoleMappingsClientComposite (string realm, string id, string _client, string briefRepresentation, CancellationToken ct);
        /// <summary>
        ///  Get client-level role mappings for the user, and the app
        /// </summary>
        /// <param name="realm">realm name (not id!)</param>
        /// <param name="id"></param>
        /// <param name="_client"></param>
        /// <param name="ct"></param>
        /// <returns>List&lt;RoleRepresentation&gt;</returns>
        Task<List<RoleRepresentation>> GetUserRoleMappingsClient (string realm, string id, string _client, CancellationToken ct);
        /// <summary>
        ///  Get available client-level roles that can be mapped to the user
        /// </summary>
        /// <param name="realm">realm name (not id!)</param>
        /// <param name="id"></param>
        /// <param name="_client"></param>
        /// <param name="ct"></param>
        /// <returns>List&lt;RoleRepresentation&gt;</returns>
        Task<List<RoleRepresentation>> GetUserRoleMappingsClientAvailable (string realm, string id, string _client, CancellationToken ct);
        /// <summary>
        ///  Get effective client-level role mappings This recurses any composite roles
        /// </summary>
        /// <param name="realm">realm name (not id!)</param>
        /// <param name="id"></param>
        /// <param name="_client"></param>
        /// <param name="briefRepresentation">if false, return roles with their attributes</param>
        /// <param name="ct"></param>
        /// <returns>List&lt;RoleRepresentation&gt;</returns>
        Task<List<RoleRepresentation>> GetUserRoleMappingsClientComposite (string realm, string id, string _client, string briefRepresentation, CancellationToken ct);
        /// <summary>
        ///  Add client-level roles to the user role mapping
        /// </summary>
        /// <param name="realm">realm name (not id!)</param>
        /// <param name="id"></param>
        /// <param name="_client"></param>
        /// <param name="body">RoleRepresentation</param>
        /// <param name="ct"></param>
        /// <returns></returns>
        Task PostGroupRoleMappingsClient (string realm, string id, string _client, RoleRepresentation body, CancellationToken ct);
        /// <summary>
        ///  Add client-level roles to the user role mapping
        /// </summary>
        /// <param name="realm">realm name (not id!)</param>
        /// <param name="id"></param>
        /// <param name="_client"></param>
        /// <param name="body">RoleRepresentation</param>
        /// <param name="ct"></param>
        /// <returns></returns>
        Task PostUserRoleMappingsClient (string realm, string id, string _client, RoleRepresentation body, CancellationToken ct);
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>  
    [GeneratedCode("swagger-codegen", "3.0.56-SNAPSHOT")]
    public partial class ClientRoleMappingsApi : KeycloakClientApiClientBase, IClientRoleMappingsApi
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ClientRoleMappingsApi"/> class.
        /// </summary>
        /// <param name="httpClient"> HttpClient to be used for calls. </param>
        /// <param name="basePath"> Base url to be used for calls. </param>
        public ClientRoleMappingsApi(HttpClient httpClient, String basePath="https://keycloak.example.com/admin/realms") : base(httpClient, basePath)
        {
        }

        /// <inheritdoc />     
        public async Task DeleteGroupRoleMappingsClient(string realm, string id, string _client, RoleRepresentation body, CancellationToken ct)
        {
            // verify the required parameter 'realm' is set
            if (realm == null) throw new KeycloakClientApiException(400, "Missing required parameter 'realm' when calling DeleteGroupRoleMappingsClient");
            // verify the required parameter 'id' is set
            if (id == null) throw new KeycloakClientApiException(400, "Missing required parameter 'id' when calling DeleteGroupRoleMappingsClient");
            // verify the required parameter '_client' is set
            if (_client == null) throw new KeycloakClientApiException(400, "Missing required parameter '_client' when calling DeleteGroupRoleMappingsClient");
            
            var path_ = new StringBuilder("/{realm}/groups/{id}/role-mappings/clients/{client}"); 
            path_ = path_.Replace("{realm}", ParameterToString(realm));
            path_ = path_.Replace("{id}", ParameterToString(id));
            path_ = path_.Replace("{client}", ParameterToString(_client));

            
        
            await CallApi(
                        path_.ToString(), 
                        HttpMethod.Delete,
                        body: body,   
                        ct: ct
            );
        }

        /// <inheritdoc />     
        public async Task DeleteUserRoleMappingsClient(string realm, string id, string _client, RoleRepresentation body, CancellationToken ct)
        {
            // verify the required parameter 'realm' is set
            if (realm == null) throw new KeycloakClientApiException(400, "Missing required parameter 'realm' when calling DeleteUserRoleMappingsClient");
            // verify the required parameter 'id' is set
            if (id == null) throw new KeycloakClientApiException(400, "Missing required parameter 'id' when calling DeleteUserRoleMappingsClient");
            // verify the required parameter '_client' is set
            if (_client == null) throw new KeycloakClientApiException(400, "Missing required parameter '_client' when calling DeleteUserRoleMappingsClient");
            
            var path_ = new StringBuilder("/{realm}/users/{id}/role-mappings/clients/{client}"); 
            path_ = path_.Replace("{realm}", ParameterToString(realm));
            path_ = path_.Replace("{id}", ParameterToString(id));
            path_ = path_.Replace("{client}", ParameterToString(_client));

            
        
            await CallApi(
                        path_.ToString(), 
                        HttpMethod.Delete,
                        body: body,   
                        ct: ct
            );
        }

        /// <inheritdoc />     
        public async Task<List<RoleRepresentation>> GetGroupRoleMappingsClient(string realm, string id, string _client, CancellationToken ct)
        {
            // verify the required parameter 'realm' is set
            if (realm == null) throw new KeycloakClientApiException(400, "Missing required parameter 'realm' when calling GetGroupRoleMappingsClient");
            // verify the required parameter 'id' is set
            if (id == null) throw new KeycloakClientApiException(400, "Missing required parameter 'id' when calling GetGroupRoleMappingsClient");
            // verify the required parameter '_client' is set
            if (_client == null) throw new KeycloakClientApiException(400, "Missing required parameter '_client' when calling GetGroupRoleMappingsClient");
            
            var path_ = new StringBuilder("/{realm}/groups/{id}/role-mappings/clients/{client}"); 
            path_ = path_.Replace("{realm}", ParameterToString(realm));
            path_ = path_.Replace("{id}", ParameterToString(id));
            path_ = path_.Replace("{client}", ParameterToString(_client));

            
        
            var response = await CallApi<List<RoleRepresentation>>(
                        path_.ToString(), 
                        HttpMethod.Get,  
                        ct: ct
            );
            return response;
        }

        /// <inheritdoc />     
        public async Task<List<RoleRepresentation>> GetGroupRoleMappingsClientAvailable(string realm, string id, string _client, CancellationToken ct)
        {
            // verify the required parameter 'realm' is set
            if (realm == null) throw new KeycloakClientApiException(400, "Missing required parameter 'realm' when calling GetGroupRoleMappingsClientAvailable");
            // verify the required parameter 'id' is set
            if (id == null) throw new KeycloakClientApiException(400, "Missing required parameter 'id' when calling GetGroupRoleMappingsClientAvailable");
            // verify the required parameter '_client' is set
            if (_client == null) throw new KeycloakClientApiException(400, "Missing required parameter '_client' when calling GetGroupRoleMappingsClientAvailable");
            
            var path_ = new StringBuilder("/{realm}/groups/{id}/role-mappings/clients/{client}/available"); 
            path_ = path_.Replace("{realm}", ParameterToString(realm));
            path_ = path_.Replace("{id}", ParameterToString(id));
            path_ = path_.Replace("{client}", ParameterToString(_client));

            
        
            var response = await CallApi<List<RoleRepresentation>>(
                        path_.ToString(), 
                        HttpMethod.Get,  
                        ct: ct
            );
            return response;
        }

        /// <inheritdoc />     
        public async Task<List<RoleRepresentation>> GetGroupRoleMappingsClientComposite(string realm, string id, string _client, string briefRepresentation, CancellationToken ct)
        {
            // verify the required parameter 'realm' is set
            if (realm == null) throw new KeycloakClientApiException(400, "Missing required parameter 'realm' when calling GetGroupRoleMappingsClientComposite");
            // verify the required parameter 'id' is set
            if (id == null) throw new KeycloakClientApiException(400, "Missing required parameter 'id' when calling GetGroupRoleMappingsClientComposite");
            // verify the required parameter '_client' is set
            if (_client == null) throw new KeycloakClientApiException(400, "Missing required parameter '_client' when calling GetGroupRoleMappingsClientComposite");
            
            var path_ = new StringBuilder("/{realm}/groups/{id}/role-mappings/clients/{client}/composite"); 
            path_ = path_.Replace("{realm}", ParameterToString(realm));
            path_ = path_.Replace("{id}", ParameterToString(id));
            path_ = path_.Replace("{client}", ParameterToString(_client));

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
        public async Task<List<RoleRepresentation>> GetUserRoleMappingsClient(string realm, string id, string _client, CancellationToken ct)
        {
            // verify the required parameter 'realm' is set
            if (realm == null) throw new KeycloakClientApiException(400, "Missing required parameter 'realm' when calling GetUserRoleMappingsClient");
            // verify the required parameter 'id' is set
            if (id == null) throw new KeycloakClientApiException(400, "Missing required parameter 'id' when calling GetUserRoleMappingsClient");
            // verify the required parameter '_client' is set
            if (_client == null) throw new KeycloakClientApiException(400, "Missing required parameter '_client' when calling GetUserRoleMappingsClient");
            
            var path_ = new StringBuilder("/{realm}/users/{id}/role-mappings/clients/{client}"); 
            path_ = path_.Replace("{realm}", ParameterToString(realm));
            path_ = path_.Replace("{id}", ParameterToString(id));
            path_ = path_.Replace("{client}", ParameterToString(_client));

            
        
            var response = await CallApi<List<RoleRepresentation>>(
                        path_.ToString(), 
                        HttpMethod.Get,  
                        ct: ct
            );
            return response;
        }

        /// <inheritdoc />     
        public async Task<List<RoleRepresentation>> GetUserRoleMappingsClientAvailable(string realm, string id, string _client, CancellationToken ct)
        {
            // verify the required parameter 'realm' is set
            if (realm == null) throw new KeycloakClientApiException(400, "Missing required parameter 'realm' when calling GetUserRoleMappingsClientAvailable");
            // verify the required parameter 'id' is set
            if (id == null) throw new KeycloakClientApiException(400, "Missing required parameter 'id' when calling GetUserRoleMappingsClientAvailable");
            // verify the required parameter '_client' is set
            if (_client == null) throw new KeycloakClientApiException(400, "Missing required parameter '_client' when calling GetUserRoleMappingsClientAvailable");
            
            var path_ = new StringBuilder("/{realm}/users/{id}/role-mappings/clients/{client}/available"); 
            path_ = path_.Replace("{realm}", ParameterToString(realm));
            path_ = path_.Replace("{id}", ParameterToString(id));
            path_ = path_.Replace("{client}", ParameterToString(_client));

            
        
            var response = await CallApi<List<RoleRepresentation>>(
                        path_.ToString(), 
                        HttpMethod.Get,  
                        ct: ct
            );
            return response;
        }

        /// <inheritdoc />     
        public async Task<List<RoleRepresentation>> GetUserRoleMappingsClientComposite(string realm, string id, string _client, string briefRepresentation, CancellationToken ct)
        {
            // verify the required parameter 'realm' is set
            if (realm == null) throw new KeycloakClientApiException(400, "Missing required parameter 'realm' when calling GetUserRoleMappingsClientComposite");
            // verify the required parameter 'id' is set
            if (id == null) throw new KeycloakClientApiException(400, "Missing required parameter 'id' when calling GetUserRoleMappingsClientComposite");
            // verify the required parameter '_client' is set
            if (_client == null) throw new KeycloakClientApiException(400, "Missing required parameter '_client' when calling GetUserRoleMappingsClientComposite");
            
            var path_ = new StringBuilder("/{realm}/users/{id}/role-mappings/clients/{client}/composite"); 
            path_ = path_.Replace("{realm}", ParameterToString(realm));
            path_ = path_.Replace("{id}", ParameterToString(id));
            path_ = path_.Replace("{client}", ParameterToString(_client));

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
        public async Task PostGroupRoleMappingsClient(string realm, string id, string _client, RoleRepresentation body, CancellationToken ct)
        {
            // verify the required parameter 'realm' is set
            if (realm == null) throw new KeycloakClientApiException(400, "Missing required parameter 'realm' when calling PostGroupRoleMappingsClient");
            // verify the required parameter 'id' is set
            if (id == null) throw new KeycloakClientApiException(400, "Missing required parameter 'id' when calling PostGroupRoleMappingsClient");
            // verify the required parameter '_client' is set
            if (_client == null) throw new KeycloakClientApiException(400, "Missing required parameter '_client' when calling PostGroupRoleMappingsClient");
            
            var path_ = new StringBuilder("/{realm}/groups/{id}/role-mappings/clients/{client}"); 
            path_ = path_.Replace("{realm}", ParameterToString(realm));
            path_ = path_.Replace("{id}", ParameterToString(id));
            path_ = path_.Replace("{client}", ParameterToString(_client));

            
        
            await CallApi(
                        path_.ToString(), 
                        HttpMethod.Post,
                        body: body,   
                        ct: ct
            );
        }

        /// <inheritdoc />     
        public async Task PostUserRoleMappingsClient(string realm, string id, string _client, RoleRepresentation body, CancellationToken ct)
        {
            // verify the required parameter 'realm' is set
            if (realm == null) throw new KeycloakClientApiException(400, "Missing required parameter 'realm' when calling PostUserRoleMappingsClient");
            // verify the required parameter 'id' is set
            if (id == null) throw new KeycloakClientApiException(400, "Missing required parameter 'id' when calling PostUserRoleMappingsClient");
            // verify the required parameter '_client' is set
            if (_client == null) throw new KeycloakClientApiException(400, "Missing required parameter '_client' when calling PostUserRoleMappingsClient");
            
            var path_ = new StringBuilder("/{realm}/users/{id}/role-mappings/clients/{client}"); 
            path_ = path_.Replace("{realm}", ParameterToString(realm));
            path_ = path_.Replace("{id}", ParameterToString(id));
            path_ = path_.Replace("{client}", ParameterToString(_client));

            
        
            await CallApi(
                        path_.ToString(), 
                        HttpMethod.Post,
                        body: body,   
                        ct: ct
            );
        }

    }
}