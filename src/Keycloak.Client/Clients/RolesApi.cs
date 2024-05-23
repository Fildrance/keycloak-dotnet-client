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
    public partial interface IRolesApi
    {
        /// <summary>
        ///  Delete a role by name
        /// </summary>
        /// <param name="realm">realm name (not id!)</param>
        /// <param name="id"></param>
        /// <param name="roleName">role&#39;s name (not id!)</param>
        /// <param name="ct"></param>
        /// <returns></returns>
        Task DeleteClientRole (string realm, string id, string roleName, CancellationToken ct);
        /// <summary>
        ///  Remove roles from the role’s composite
        /// </summary>
        /// <param name="realm">realm name (not id!)</param>
        /// <param name="id"></param>
        /// <param name="roleName">role&#39;s name (not id!)</param>
        /// <param name="body">RoleRepresentation</param>
        /// <param name="ct"></param>
        /// <returns></returns>
        Task DeleteClientRoleComposites (string realm, string id, string roleName, RoleRepresentation body, CancellationToken ct);
        /// <summary>
        ///  Delete a role by name
        /// </summary>
        /// <param name="realm">realm name (not id!)</param>
        /// <param name="roleName">role&#39;s name (not id!)</param>
        /// <param name="ct"></param>
        /// <returns></returns>
        Task DeleteRoleByRealmByRoleName (string realm, string roleName, CancellationToken ct);
        /// <summary>
        ///  Remove roles from the role’s composite
        /// </summary>
        /// <param name="realm">realm name (not id!)</param>
        /// <param name="roleName">role&#39;s name (not id!)</param>
        /// <param name="body">RoleRepresentation</param>
        /// <param name="ct"></param>
        /// <returns></returns>
        Task DeleteRoleCompositesByRealmByRoleName (string realm, string roleName, RoleRepresentation body, CancellationToken ct);
        /// <summary>
        ///  Get a role by name
        /// </summary>
        /// <param name="realm">realm name (not id!)</param>
        /// <param name="id"></param>
        /// <param name="roleName">role&#39;s name (not id!)</param>
        /// <param name="ct"></param>
        /// <returns>RoleRepresentation</returns>
        Task<RoleRepresentation> GetClientRole (string realm, string id, string roleName, CancellationToken ct);
        /// <summary>
        ///  Get composites of the role
        /// </summary>
        /// <param name="realm">realm name (not id!)</param>
        /// <param name="id"></param>
        /// <param name="roleName">role&#39;s name (not id!)</param>
        /// <param name="ct"></param>
        /// <returns>List&lt;RoleRepresentation&gt;</returns>
        Task<List<RoleRepresentation>> GetClientRoleComposites (string realm, string id, string roleName, CancellationToken ct);
        /// <summary>
        ///  Get client-level roles for the client that are in the role’s composite
        /// </summary>
        /// <param name="realm">realm name (not id!)</param>
        /// <param name="id"></param>
        /// <param name="roleName">role&#39;s name (not id!)</param>
        /// <param name="clientUuid"></param>
        /// <param name="ct"></param>
        /// <returns>List&lt;RoleRepresentation&gt;</returns>
        Task<List<RoleRepresentation>> GetClientRoleCompositesClient (string realm, string id, string roleName, string clientUuid, CancellationToken ct);
        /// <summary>
        ///  Get realm-level roles of the role’s composite
        /// </summary>
        /// <param name="realm">realm name (not id!)</param>
        /// <param name="id"></param>
        /// <param name="roleName">role&#39;s name (not id!)</param>
        /// <param name="ct"></param>
        /// <returns>List&lt;RoleRepresentation&gt;</returns>
        Task<List<RoleRepresentation>> GetClientRoleCompositesRealm (string realm, string id, string roleName, CancellationToken ct);
        /// <summary>
        ///  Returns a stream of groups that have the specified role name
        /// </summary>
        /// <param name="realm">realm name (not id!)</param>
        /// <param name="id"></param>
        /// <param name="roleName">the role name.</param>
        /// <param name="briefRepresentation">if false, return a full representation of the {@code GroupRepresentation} objects.</param>
        /// <param name="first">first result to return. Ignored if negative or {@code null}.</param>
        /// <param name="max">maximum number of results to return. Ignored if negative or {@code null}.</param>
        /// <param name="ct"></param>
        /// <returns>List&lt;GroupRepresentation&gt;</returns>
        Task<List<GroupRepresentation>> GetClientRoleGroups (string realm, string id, string roleName, string briefRepresentation, string first, string max, CancellationToken ct);
        /// <summary>
        ///  Return object stating whether role Authorization permissions have been initialized or not and a reference
        /// </summary>
        /// <param name="realm">realm name (not id!)</param>
        /// <param name="id"></param>
        /// <param name="roleName"></param>
        /// <param name="ct"></param>
        /// <returns>ManagementPermissionReference</returns>
        Task<ManagementPermissionReference> GetClientRoleManagementPermissions (string realm, string id, string roleName, CancellationToken ct);
        /// <summary>
        ///  Returns a stream of users that have the specified role name.
        /// </summary>
        /// <param name="realm">realm name (not id!)</param>
        /// <param name="id"></param>
        /// <param name="roleName">the role name.</param>
        /// <param name="first">first result to return. Ignored if negative or {@code null}.</param>
        /// <param name="max">maximum number of results to return. Ignored if negative or {@code null}.</param>
        /// <param name="ct"></param>
        /// <returns>List&lt;UserRepresentation&gt;</returns>
        Task<List<UserRepresentation>> GetClientRoleUsers (string realm, string id, string roleName, string first, string max, CancellationToken ct);
        /// <summary>
        ///  Get all roles for the realm or client
        /// </summary>
        /// <param name="realm">realm name (not id!)</param>
        /// <param name="id"></param>
        /// <param name="briefRepresentation"></param>
        /// <param name="first"></param>
        /// <param name="max"></param>
        /// <param name="search"></param>
        /// <param name="ct"></param>
        /// <returns>List&lt;RoleRepresentation&gt;</returns>
        Task<List<RoleRepresentation>> GetClientRoles (string realm, string id, string briefRepresentation, string first, string max, string search, CancellationToken ct);
        /// <summary>
        ///  Get a role by name
        /// </summary>
        /// <param name="realm">realm name (not id!)</param>
        /// <param name="roleName">role&#39;s name (not id!)</param>
        /// <param name="ct"></param>
        /// <returns>RoleRepresentation</returns>
        Task<RoleRepresentation> GetRoleByRealmByRoleName (string realm, string roleName, CancellationToken ct);
        /// <summary>
        ///  Get composites of the role
        /// </summary>
        /// <param name="realm">realm name (not id!)</param>
        /// <param name="roleName">role&#39;s name (not id!)</param>
        /// <param name="ct"></param>
        /// <returns>List&lt;RoleRepresentation&gt;</returns>
        Task<List<RoleRepresentation>> GetRoleCompositesByRealmByRoleName (string realm, string roleName, CancellationToken ct);
        /// <summary>
        ///  Get client-level roles for the client that are in the role’s composite
        /// </summary>
        /// <param name="realm">realm name (not id!)</param>
        /// <param name="roleName">role&#39;s name (not id!)</param>
        /// <param name="clientUuid"></param>
        /// <param name="ct"></param>
        /// <returns>List&lt;RoleRepresentation&gt;</returns>
        Task<List<RoleRepresentation>> GetRoleCompositesClientByRealmByRoleNameByClientUuid (string realm, string roleName, string clientUuid, CancellationToken ct);
        /// <summary>
        ///  Get realm-level roles of the role’s composite
        /// </summary>
        /// <param name="realm">realm name (not id!)</param>
        /// <param name="roleName">role&#39;s name (not id!)</param>
        /// <param name="ct"></param>
        /// <returns>List&lt;RoleRepresentation&gt;</returns>
        Task<List<RoleRepresentation>> GetRoleCompositesRealmByRealmByRoleName (string realm, string roleName, CancellationToken ct);
        /// <summary>
        ///  Returns a stream of groups that have the specified role name
        /// </summary>
        /// <param name="realm">realm name (not id!)</param>
        /// <param name="roleName">the role name.</param>
        /// <param name="briefRepresentation">if false, return a full representation of the {@code GroupRepresentation} objects.</param>
        /// <param name="first">first result to return. Ignored if negative or {@code null}.</param>
        /// <param name="max">maximum number of results to return. Ignored if negative or {@code null}.</param>
        /// <param name="ct"></param>
        /// <returns>List&lt;GroupRepresentation&gt;</returns>
        Task<List<GroupRepresentation>> GetRoleGroupsByRealmByRoleName (string realm, string roleName, string briefRepresentation, string first, string max, CancellationToken ct);
        /// <summary>
        ///  Return object stating whether role Authorization permissions have been initialized or not and a reference
        /// </summary>
        /// <param name="realm">realm name (not id!)</param>
        /// <param name="roleName"></param>
        /// <param name="ct"></param>
        /// <returns>ManagementPermissionReference</returns>
        Task<ManagementPermissionReference> GetRoleManagementPermissionsByRealmByRoleName (string realm, string roleName, CancellationToken ct);
        /// <summary>
        ///  Returns a stream of users that have the specified role name.
        /// </summary>
        /// <param name="realm">realm name (not id!)</param>
        /// <param name="roleName">the role name.</param>
        /// <param name="first">first result to return. Ignored if negative or {@code null}.</param>
        /// <param name="max">maximum number of results to return. Ignored if negative or {@code null}.</param>
        /// <param name="ct"></param>
        /// <returns>List&lt;UserRepresentation&gt;</returns>
        Task<List<UserRepresentation>> GetRoleUsersByRealmByRoleName (string realm, string roleName, string first, string max, CancellationToken ct);
        /// <summary>
        ///  Get all roles for the realm or client
        /// </summary>
        /// <param name="realm">realm name (not id!)</param>
        /// <param name="briefRepresentation"></param>
        /// <param name="first"></param>
        /// <param name="max"></param>
        /// <param name="search"></param>
        /// <param name="ct"></param>
        /// <returns>List&lt;RoleRepresentation&gt;</returns>
        Task<List<RoleRepresentation>> GetRolesByRealm (string realm, string briefRepresentation, string first, string max, string search, CancellationToken ct);
        /// <summary>
        ///  Add a composite to the role
        /// </summary>
        /// <param name="realm">realm name (not id!)</param>
        /// <param name="id"></param>
        /// <param name="roleName">role&#39;s name (not id!)</param>
        /// <param name="body">RoleRepresentation</param>
        /// <param name="ct"></param>
        /// <returns></returns>
        Task PostClientRoleComposites (string realm, string id, string roleName, RoleRepresentation body, CancellationToken ct);
        /// <summary>
        ///  Create a new role for the realm or client
        /// </summary>
        /// <param name="realm">realm name (not id!)</param>
        /// <param name="id"></param>
        /// <param name="body">RoleRepresentation</param>
        /// <param name="ct"></param>
        /// <returns></returns>
        Task PostClientRoles (string realm, string id, RoleRepresentation body, CancellationToken ct);
        /// <summary>
        ///  Add a composite to the role
        /// </summary>
        /// <param name="realm">realm name (not id!)</param>
        /// <param name="roleName">role&#39;s name (not id!)</param>
        /// <param name="body">RoleRepresentation</param>
        /// <param name="ct"></param>
        /// <returns></returns>
        Task PostRoleCompositesByRealmByRoleName (string realm, string roleName, RoleRepresentation body, CancellationToken ct);
        /// <summary>
        ///  Create a new role for the realm or client
        /// </summary>
        /// <param name="realm">realm name (not id!)</param>
        /// <param name="body">RoleRepresentation</param>
        /// <param name="ct"></param>
        /// <returns></returns>
        Task PostRolesByRealm (string realm, RoleRepresentation body, CancellationToken ct);
        /// <summary>
        ///  Update a role by name
        /// </summary>
        /// <param name="realm">realm name (not id!)</param>
        /// <param name="id"></param>
        /// <param name="roleName">role&#39;s name (not id!)</param>
        /// <param name="body">RoleRepresentation</param>
        /// <param name="ct"></param>
        /// <returns></returns>
        Task PutClientRole (string realm, string id, string roleName, RoleRepresentation body, CancellationToken ct);
        /// <summary>
        ///  Return object stating whether role Authorization permissions have been initialized or not and a reference
        /// </summary>
        /// <param name="realm">realm name (not id!)</param>
        /// <param name="id"></param>
        /// <param name="roleName"></param>
        /// <param name="body">ManagementPermissionReference</param>
        /// <param name="ct"></param>
        /// <returns>ManagementPermissionReference</returns>
        Task<ManagementPermissionReference> PutClientRoleManagementPermissions (string realm, string id, string roleName, ManagementPermissionReference body, CancellationToken ct);
        /// <summary>
        ///  Update a role by name
        /// </summary>
        /// <param name="realm">realm name (not id!)</param>
        /// <param name="roleName">role&#39;s name (not id!)</param>
        /// <param name="body">RoleRepresentation</param>
        /// <param name="ct"></param>
        /// <returns></returns>
        Task PutRoleByRealmByRoleName (string realm, string roleName, RoleRepresentation body, CancellationToken ct);
        /// <summary>
        ///  Return object stating whether role Authorization permissions have been initialized or not and a reference
        /// </summary>
        /// <param name="realm">realm name (not id!)</param>
        /// <param name="roleName"></param>
        /// <param name="body">ManagementPermissionReference</param>
        /// <param name="ct"></param>
        /// <returns>ManagementPermissionReference</returns>
        Task<ManagementPermissionReference> PutRoleManagementPermissionsByRealmByRoleName (string realm, string roleName, ManagementPermissionReference body, CancellationToken ct);
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>  
    [GeneratedCode("swagger-codegen", "3.0.56-SNAPSHOT")]
    public partial class RolesApi : KeycloakClientApiClientBase, IRolesApi
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="RolesApi"/> class.
        /// </summary>
        /// <param name="httpClient"> HttpClient to be used for calls. </param>
        /// <param name="basePath"> Base url to be used for calls. </param>
        public RolesApi(HttpClient httpClient, String basePath="https://keycloak.example.com/admin/realms") : base(httpClient, basePath)
        {
        }

        /// <inheritdoc />     
        public async Task DeleteClientRole(string realm, string id, string roleName, CancellationToken ct)
        {
            // verify the required parameter 'realm' is set
            if (realm == null) throw new KeycloakClientApiException(400, "Missing required parameter 'realm' when calling DeleteClientRole");
            // verify the required parameter 'id' is set
            if (id == null) throw new KeycloakClientApiException(400, "Missing required parameter 'id' when calling DeleteClientRole");
            // verify the required parameter 'roleName' is set
            if (roleName == null) throw new KeycloakClientApiException(400, "Missing required parameter 'roleName' when calling DeleteClientRole");
            
            var path_ = new StringBuilder("/{realm}/clients/{id}/roles/{role-name}"); 
            path_ = path_.Replace("{realm}", ParameterToString(realm));
            path_ = path_.Replace("{id}", ParameterToString(id));
            path_ = path_.Replace("{role-name}", ParameterToString(roleName));

            
        
            await CallApi(
                        path_.ToString(), 
                        HttpMethod.Delete,  
                        ct: ct
            );
        }

        /// <inheritdoc />     
        public async Task DeleteClientRoleComposites(string realm, string id, string roleName, RoleRepresentation body, CancellationToken ct)
        {
            // verify the required parameter 'realm' is set
            if (realm == null) throw new KeycloakClientApiException(400, "Missing required parameter 'realm' when calling DeleteClientRoleComposites");
            // verify the required parameter 'id' is set
            if (id == null) throw new KeycloakClientApiException(400, "Missing required parameter 'id' when calling DeleteClientRoleComposites");
            // verify the required parameter 'roleName' is set
            if (roleName == null) throw new KeycloakClientApiException(400, "Missing required parameter 'roleName' when calling DeleteClientRoleComposites");
            
            var path_ = new StringBuilder("/{realm}/clients/{id}/roles/{role-name}/composites"); 
            path_ = path_.Replace("{realm}", ParameterToString(realm));
            path_ = path_.Replace("{id}", ParameterToString(id));
            path_ = path_.Replace("{role-name}", ParameterToString(roleName));

            
        
            await CallApi(
                        path_.ToString(), 
                        HttpMethod.Delete,
                        body: body,   
                        ct: ct
            );
        }

        /// <inheritdoc />     
        public async Task DeleteRoleByRealmByRoleName(string realm, string roleName, CancellationToken ct)
        {
            // verify the required parameter 'realm' is set
            if (realm == null) throw new KeycloakClientApiException(400, "Missing required parameter 'realm' when calling DeleteRoleByRealmByRoleName");
            // verify the required parameter 'roleName' is set
            if (roleName == null) throw new KeycloakClientApiException(400, "Missing required parameter 'roleName' when calling DeleteRoleByRealmByRoleName");
            
            var path_ = new StringBuilder("/{realm}/roles/{role-name}"); 
            path_ = path_.Replace("{realm}", ParameterToString(realm));
            path_ = path_.Replace("{role-name}", ParameterToString(roleName));

            
        
            await CallApi(
                        path_.ToString(), 
                        HttpMethod.Delete,  
                        ct: ct
            );
        }

        /// <inheritdoc />     
        public async Task DeleteRoleCompositesByRealmByRoleName(string realm, string roleName, RoleRepresentation body, CancellationToken ct)
        {
            // verify the required parameter 'realm' is set
            if (realm == null) throw new KeycloakClientApiException(400, "Missing required parameter 'realm' when calling DeleteRoleCompositesByRealmByRoleName");
            // verify the required parameter 'roleName' is set
            if (roleName == null) throw new KeycloakClientApiException(400, "Missing required parameter 'roleName' when calling DeleteRoleCompositesByRealmByRoleName");
            
            var path_ = new StringBuilder("/{realm}/roles/{role-name}/composites"); 
            path_ = path_.Replace("{realm}", ParameterToString(realm));
            path_ = path_.Replace("{role-name}", ParameterToString(roleName));

            
        
            await CallApi(
                        path_.ToString(), 
                        HttpMethod.Delete,
                        body: body,   
                        ct: ct
            );
        }

        /// <inheritdoc />     
        public async Task<RoleRepresentation> GetClientRole(string realm, string id, string roleName, CancellationToken ct)
        {
            // verify the required parameter 'realm' is set
            if (realm == null) throw new KeycloakClientApiException(400, "Missing required parameter 'realm' when calling GetClientRole");
            // verify the required parameter 'id' is set
            if (id == null) throw new KeycloakClientApiException(400, "Missing required parameter 'id' when calling GetClientRole");
            // verify the required parameter 'roleName' is set
            if (roleName == null) throw new KeycloakClientApiException(400, "Missing required parameter 'roleName' when calling GetClientRole");
            
            var path_ = new StringBuilder("/{realm}/clients/{id}/roles/{role-name}"); 
            path_ = path_.Replace("{realm}", ParameterToString(realm));
            path_ = path_.Replace("{id}", ParameterToString(id));
            path_ = path_.Replace("{role-name}", ParameterToString(roleName));

            
        
            var response = await CallApi<RoleRepresentation>(
                        path_.ToString(), 
                        HttpMethod.Get,  
                        ct: ct
            );
            return response;
        }

        /// <inheritdoc />     
        public async Task<List<RoleRepresentation>> GetClientRoleComposites(string realm, string id, string roleName, CancellationToken ct)
        {
            // verify the required parameter 'realm' is set
            if (realm == null) throw new KeycloakClientApiException(400, "Missing required parameter 'realm' when calling GetClientRoleComposites");
            // verify the required parameter 'id' is set
            if (id == null) throw new KeycloakClientApiException(400, "Missing required parameter 'id' when calling GetClientRoleComposites");
            // verify the required parameter 'roleName' is set
            if (roleName == null) throw new KeycloakClientApiException(400, "Missing required parameter 'roleName' when calling GetClientRoleComposites");
            
            var path_ = new StringBuilder("/{realm}/clients/{id}/roles/{role-name}/composites"); 
            path_ = path_.Replace("{realm}", ParameterToString(realm));
            path_ = path_.Replace("{id}", ParameterToString(id));
            path_ = path_.Replace("{role-name}", ParameterToString(roleName));

            
        
            var response = await CallApi<List<RoleRepresentation>>(
                        path_.ToString(), 
                        HttpMethod.Get,  
                        ct: ct
            );
            return response;
        }

        /// <inheritdoc />     
        public async Task<List<RoleRepresentation>> GetClientRoleCompositesClient(string realm, string id, string roleName, string clientUuid, CancellationToken ct)
        {
            // verify the required parameter 'realm' is set
            if (realm == null) throw new KeycloakClientApiException(400, "Missing required parameter 'realm' when calling GetClientRoleCompositesClient");
            // verify the required parameter 'id' is set
            if (id == null) throw new KeycloakClientApiException(400, "Missing required parameter 'id' when calling GetClientRoleCompositesClient");
            // verify the required parameter 'roleName' is set
            if (roleName == null) throw new KeycloakClientApiException(400, "Missing required parameter 'roleName' when calling GetClientRoleCompositesClient");
            // verify the required parameter 'clientUuid' is set
            if (clientUuid == null) throw new KeycloakClientApiException(400, "Missing required parameter 'clientUuid' when calling GetClientRoleCompositesClient");
            
            var path_ = new StringBuilder("/{realm}/clients/{id}/roles/{role-name}/composites/clients/{clientUuid}"); 
            path_ = path_.Replace("{realm}", ParameterToString(realm));
            path_ = path_.Replace("{id}", ParameterToString(id));
            path_ = path_.Replace("{role-name}", ParameterToString(roleName));
            path_ = path_.Replace("{clientUuid}", ParameterToString(clientUuid));

            
        
            var response = await CallApi<List<RoleRepresentation>>(
                        path_.ToString(), 
                        HttpMethod.Get,  
                        ct: ct
            );
            return response;
        }

        /// <inheritdoc />     
        public async Task<List<RoleRepresentation>> GetClientRoleCompositesRealm(string realm, string id, string roleName, CancellationToken ct)
        {
            // verify the required parameter 'realm' is set
            if (realm == null) throw new KeycloakClientApiException(400, "Missing required parameter 'realm' when calling GetClientRoleCompositesRealm");
            // verify the required parameter 'id' is set
            if (id == null) throw new KeycloakClientApiException(400, "Missing required parameter 'id' when calling GetClientRoleCompositesRealm");
            // verify the required parameter 'roleName' is set
            if (roleName == null) throw new KeycloakClientApiException(400, "Missing required parameter 'roleName' when calling GetClientRoleCompositesRealm");
            
            var path_ = new StringBuilder("/{realm}/clients/{id}/roles/{role-name}/composites/realm"); 
            path_ = path_.Replace("{realm}", ParameterToString(realm));
            path_ = path_.Replace("{id}", ParameterToString(id));
            path_ = path_.Replace("{role-name}", ParameterToString(roleName));

            
        
            var response = await CallApi<List<RoleRepresentation>>(
                        path_.ToString(), 
                        HttpMethod.Get,  
                        ct: ct
            );
            return response;
        }

        /// <inheritdoc />     
        public async Task<List<GroupRepresentation>> GetClientRoleGroups(string realm, string id, string roleName, string briefRepresentation, string first, string max, CancellationToken ct)
        {
            // verify the required parameter 'realm' is set
            if (realm == null) throw new KeycloakClientApiException(400, "Missing required parameter 'realm' when calling GetClientRoleGroups");
            // verify the required parameter 'id' is set
            if (id == null) throw new KeycloakClientApiException(400, "Missing required parameter 'id' when calling GetClientRoleGroups");
            // verify the required parameter 'roleName' is set
            if (roleName == null) throw new KeycloakClientApiException(400, "Missing required parameter 'roleName' when calling GetClientRoleGroups");
            
            var path_ = new StringBuilder("/{realm}/clients/{id}/roles/{role-name}/groups"); 
            path_ = path_.Replace("{realm}", ParameterToString(realm));
            path_ = path_.Replace("{id}", ParameterToString(id));
            path_ = path_.Replace("{role-name}", ParameterToString(roleName));

            var queryParams = new Dictionary<string, string>();
             
            if (briefRepresentation != null) queryParams.Add("briefRepresentation", ParameterToString(briefRepresentation)); // query parameter 
            if (first != null) queryParams.Add("first", ParameterToString(first)); // query parameter 
            if (max != null) queryParams.Add("max", ParameterToString(max)); // query parameter
        
            var response = await CallApi<List<GroupRepresentation>>(
                        path_.ToString(), 
                        HttpMethod.Get,
                        queryParams: queryParams,  
                        ct: ct
            );
            return response;
        }

        /// <inheritdoc />     
        public async Task<ManagementPermissionReference> GetClientRoleManagementPermissions(string realm, string id, string roleName, CancellationToken ct)
        {
            // verify the required parameter 'realm' is set
            if (realm == null) throw new KeycloakClientApiException(400, "Missing required parameter 'realm' when calling GetClientRoleManagementPermissions");
            // verify the required parameter 'id' is set
            if (id == null) throw new KeycloakClientApiException(400, "Missing required parameter 'id' when calling GetClientRoleManagementPermissions");
            // verify the required parameter 'roleName' is set
            if (roleName == null) throw new KeycloakClientApiException(400, "Missing required parameter 'roleName' when calling GetClientRoleManagementPermissions");
            
            var path_ = new StringBuilder("/{realm}/clients/{id}/roles/{role-name}/management/permissions"); 
            path_ = path_.Replace("{realm}", ParameterToString(realm));
            path_ = path_.Replace("{id}", ParameterToString(id));
            path_ = path_.Replace("{role-name}", ParameterToString(roleName));

            
        
            var response = await CallApi<ManagementPermissionReference>(
                        path_.ToString(), 
                        HttpMethod.Get,  
                        ct: ct
            );
            return response;
        }

        /// <inheritdoc />     
        public async Task<List<UserRepresentation>> GetClientRoleUsers(string realm, string id, string roleName, string first, string max, CancellationToken ct)
        {
            // verify the required parameter 'realm' is set
            if (realm == null) throw new KeycloakClientApiException(400, "Missing required parameter 'realm' when calling GetClientRoleUsers");
            // verify the required parameter 'id' is set
            if (id == null) throw new KeycloakClientApiException(400, "Missing required parameter 'id' when calling GetClientRoleUsers");
            // verify the required parameter 'roleName' is set
            if (roleName == null) throw new KeycloakClientApiException(400, "Missing required parameter 'roleName' when calling GetClientRoleUsers");
            
            var path_ = new StringBuilder("/{realm}/clients/{id}/roles/{role-name}/users"); 
            path_ = path_.Replace("{realm}", ParameterToString(realm));
            path_ = path_.Replace("{id}", ParameterToString(id));
            path_ = path_.Replace("{role-name}", ParameterToString(roleName));

            var queryParams = new Dictionary<string, string>();
             
            if (first != null) queryParams.Add("first", ParameterToString(first)); // query parameter 
            if (max != null) queryParams.Add("max", ParameterToString(max)); // query parameter
        
            var response = await CallApi<List<UserRepresentation>>(
                        path_.ToString(), 
                        HttpMethod.Get,
                        queryParams: queryParams,  
                        ct: ct
            );
            return response;
        }

        /// <inheritdoc />     
        public async Task<List<RoleRepresentation>> GetClientRoles(string realm, string id, string briefRepresentation, string first, string max, string search, CancellationToken ct)
        {
            // verify the required parameter 'realm' is set
            if (realm == null) throw new KeycloakClientApiException(400, "Missing required parameter 'realm' when calling GetClientRoles");
            // verify the required parameter 'id' is set
            if (id == null) throw new KeycloakClientApiException(400, "Missing required parameter 'id' when calling GetClientRoles");
            
            var path_ = new StringBuilder("/{realm}/clients/{id}/roles"); 
            path_ = path_.Replace("{realm}", ParameterToString(realm));
            path_ = path_.Replace("{id}", ParameterToString(id));

            var queryParams = new Dictionary<string, string>();
             
            if (briefRepresentation != null) queryParams.Add("briefRepresentation", ParameterToString(briefRepresentation)); // query parameter 
            if (first != null) queryParams.Add("first", ParameterToString(first)); // query parameter 
            if (max != null) queryParams.Add("max", ParameterToString(max)); // query parameter 
            if (search != null) queryParams.Add("search", ParameterToString(search)); // query parameter
        
            var response = await CallApi<List<RoleRepresentation>>(
                        path_.ToString(), 
                        HttpMethod.Get,
                        queryParams: queryParams,  
                        ct: ct
            );
            return response;
        }

        /// <inheritdoc />     
        public async Task<RoleRepresentation> GetRoleByRealmByRoleName(string realm, string roleName, CancellationToken ct)
        {
            // verify the required parameter 'realm' is set
            if (realm == null) throw new KeycloakClientApiException(400, "Missing required parameter 'realm' when calling GetRoleByRealmByRoleName");
            // verify the required parameter 'roleName' is set
            if (roleName == null) throw new KeycloakClientApiException(400, "Missing required parameter 'roleName' when calling GetRoleByRealmByRoleName");
            
            var path_ = new StringBuilder("/{realm}/roles/{role-name}"); 
            path_ = path_.Replace("{realm}", ParameterToString(realm));
            path_ = path_.Replace("{role-name}", ParameterToString(roleName));

            
        
            var response = await CallApi<RoleRepresentation>(
                        path_.ToString(), 
                        HttpMethod.Get,  
                        ct: ct
            );
            return response;
        }

        /// <inheritdoc />     
        public async Task<List<RoleRepresentation>> GetRoleCompositesByRealmByRoleName(string realm, string roleName, CancellationToken ct)
        {
            // verify the required parameter 'realm' is set
            if (realm == null) throw new KeycloakClientApiException(400, "Missing required parameter 'realm' when calling GetRoleCompositesByRealmByRoleName");
            // verify the required parameter 'roleName' is set
            if (roleName == null) throw new KeycloakClientApiException(400, "Missing required parameter 'roleName' when calling GetRoleCompositesByRealmByRoleName");
            
            var path_ = new StringBuilder("/{realm}/roles/{role-name}/composites"); 
            path_ = path_.Replace("{realm}", ParameterToString(realm));
            path_ = path_.Replace("{role-name}", ParameterToString(roleName));

            
        
            var response = await CallApi<List<RoleRepresentation>>(
                        path_.ToString(), 
                        HttpMethod.Get,  
                        ct: ct
            );
            return response;
        }

        /// <inheritdoc />     
        public async Task<List<RoleRepresentation>> GetRoleCompositesClientByRealmByRoleNameByClientUuid(string realm, string roleName, string clientUuid, CancellationToken ct)
        {
            // verify the required parameter 'realm' is set
            if (realm == null) throw new KeycloakClientApiException(400, "Missing required parameter 'realm' when calling GetRoleCompositesClientByRealmByRoleNameByClientUuid");
            // verify the required parameter 'roleName' is set
            if (roleName == null) throw new KeycloakClientApiException(400, "Missing required parameter 'roleName' when calling GetRoleCompositesClientByRealmByRoleNameByClientUuid");
            // verify the required parameter 'clientUuid' is set
            if (clientUuid == null) throw new KeycloakClientApiException(400, "Missing required parameter 'clientUuid' when calling GetRoleCompositesClientByRealmByRoleNameByClientUuid");
            
            var path_ = new StringBuilder("/{realm}/roles/{role-name}/composites/clients/{clientUuid}"); 
            path_ = path_.Replace("{realm}", ParameterToString(realm));
            path_ = path_.Replace("{role-name}", ParameterToString(roleName));
            path_ = path_.Replace("{clientUuid}", ParameterToString(clientUuid));

            
        
            var response = await CallApi<List<RoleRepresentation>>(
                        path_.ToString(), 
                        HttpMethod.Get,  
                        ct: ct
            );
            return response;
        }

        /// <inheritdoc />     
        public async Task<List<RoleRepresentation>> GetRoleCompositesRealmByRealmByRoleName(string realm, string roleName, CancellationToken ct)
        {
            // verify the required parameter 'realm' is set
            if (realm == null) throw new KeycloakClientApiException(400, "Missing required parameter 'realm' when calling GetRoleCompositesRealmByRealmByRoleName");
            // verify the required parameter 'roleName' is set
            if (roleName == null) throw new KeycloakClientApiException(400, "Missing required parameter 'roleName' when calling GetRoleCompositesRealmByRealmByRoleName");
            
            var path_ = new StringBuilder("/{realm}/roles/{role-name}/composites/realm"); 
            path_ = path_.Replace("{realm}", ParameterToString(realm));
            path_ = path_.Replace("{role-name}", ParameterToString(roleName));

            
        
            var response = await CallApi<List<RoleRepresentation>>(
                        path_.ToString(), 
                        HttpMethod.Get,  
                        ct: ct
            );
            return response;
        }

        /// <inheritdoc />     
        public async Task<List<GroupRepresentation>> GetRoleGroupsByRealmByRoleName(string realm, string roleName, string briefRepresentation, string first, string max, CancellationToken ct)
        {
            // verify the required parameter 'realm' is set
            if (realm == null) throw new KeycloakClientApiException(400, "Missing required parameter 'realm' when calling GetRoleGroupsByRealmByRoleName");
            // verify the required parameter 'roleName' is set
            if (roleName == null) throw new KeycloakClientApiException(400, "Missing required parameter 'roleName' when calling GetRoleGroupsByRealmByRoleName");
            
            var path_ = new StringBuilder("/{realm}/roles/{role-name}/groups"); 
            path_ = path_.Replace("{realm}", ParameterToString(realm));
            path_ = path_.Replace("{role-name}", ParameterToString(roleName));

            var queryParams = new Dictionary<string, string>();
             
            if (briefRepresentation != null) queryParams.Add("briefRepresentation", ParameterToString(briefRepresentation)); // query parameter 
            if (first != null) queryParams.Add("first", ParameterToString(first)); // query parameter 
            if (max != null) queryParams.Add("max", ParameterToString(max)); // query parameter
        
            var response = await CallApi<List<GroupRepresentation>>(
                        path_.ToString(), 
                        HttpMethod.Get,
                        queryParams: queryParams,  
                        ct: ct
            );
            return response;
        }

        /// <inheritdoc />     
        public async Task<ManagementPermissionReference> GetRoleManagementPermissionsByRealmByRoleName(string realm, string roleName, CancellationToken ct)
        {
            // verify the required parameter 'realm' is set
            if (realm == null) throw new KeycloakClientApiException(400, "Missing required parameter 'realm' when calling GetRoleManagementPermissionsByRealmByRoleName");
            // verify the required parameter 'roleName' is set
            if (roleName == null) throw new KeycloakClientApiException(400, "Missing required parameter 'roleName' when calling GetRoleManagementPermissionsByRealmByRoleName");
            
            var path_ = new StringBuilder("/{realm}/roles/{role-name}/management/permissions"); 
            path_ = path_.Replace("{realm}", ParameterToString(realm));
            path_ = path_.Replace("{role-name}", ParameterToString(roleName));

            
        
            var response = await CallApi<ManagementPermissionReference>(
                        path_.ToString(), 
                        HttpMethod.Get,  
                        ct: ct
            );
            return response;
        }

        /// <inheritdoc />     
        public async Task<List<UserRepresentation>> GetRoleUsersByRealmByRoleName(string realm, string roleName, string first, string max, CancellationToken ct)
        {
            // verify the required parameter 'realm' is set
            if (realm == null) throw new KeycloakClientApiException(400, "Missing required parameter 'realm' when calling GetRoleUsersByRealmByRoleName");
            // verify the required parameter 'roleName' is set
            if (roleName == null) throw new KeycloakClientApiException(400, "Missing required parameter 'roleName' when calling GetRoleUsersByRealmByRoleName");
            
            var path_ = new StringBuilder("/{realm}/roles/{role-name}/users"); 
            path_ = path_.Replace("{realm}", ParameterToString(realm));
            path_ = path_.Replace("{role-name}", ParameterToString(roleName));

            var queryParams = new Dictionary<string, string>();
             
            if (first != null) queryParams.Add("first", ParameterToString(first)); // query parameter 
            if (max != null) queryParams.Add("max", ParameterToString(max)); // query parameter
        
            var response = await CallApi<List<UserRepresentation>>(
                        path_.ToString(), 
                        HttpMethod.Get,
                        queryParams: queryParams,  
                        ct: ct
            );
            return response;
        }

        /// <inheritdoc />     
        public async Task<List<RoleRepresentation>> GetRolesByRealm(string realm, string briefRepresentation, string first, string max, string search, CancellationToken ct)
        {
            // verify the required parameter 'realm' is set
            if (realm == null) throw new KeycloakClientApiException(400, "Missing required parameter 'realm' when calling GetRolesByRealm");
            
            var path_ = new StringBuilder("/{realm}/roles"); 
            path_ = path_.Replace("{realm}", ParameterToString(realm));

            var queryParams = new Dictionary<string, string>();
             
            if (briefRepresentation != null) queryParams.Add("briefRepresentation", ParameterToString(briefRepresentation)); // query parameter 
            if (first != null) queryParams.Add("first", ParameterToString(first)); // query parameter 
            if (max != null) queryParams.Add("max", ParameterToString(max)); // query parameter 
            if (search != null) queryParams.Add("search", ParameterToString(search)); // query parameter
        
            var response = await CallApi<List<RoleRepresentation>>(
                        path_.ToString(), 
                        HttpMethod.Get,
                        queryParams: queryParams,  
                        ct: ct
            );
            return response;
        }

        /// <inheritdoc />     
        public async Task PostClientRoleComposites(string realm, string id, string roleName, RoleRepresentation body, CancellationToken ct)
        {
            // verify the required parameter 'realm' is set
            if (realm == null) throw new KeycloakClientApiException(400, "Missing required parameter 'realm' when calling PostClientRoleComposites");
            // verify the required parameter 'id' is set
            if (id == null) throw new KeycloakClientApiException(400, "Missing required parameter 'id' when calling PostClientRoleComposites");
            // verify the required parameter 'roleName' is set
            if (roleName == null) throw new KeycloakClientApiException(400, "Missing required parameter 'roleName' when calling PostClientRoleComposites");
            
            var path_ = new StringBuilder("/{realm}/clients/{id}/roles/{role-name}/composites"); 
            path_ = path_.Replace("{realm}", ParameterToString(realm));
            path_ = path_.Replace("{id}", ParameterToString(id));
            path_ = path_.Replace("{role-name}", ParameterToString(roleName));

            
        
            await CallApi(
                        path_.ToString(), 
                        HttpMethod.Post,
                        body: body,   
                        ct: ct
            );
        }

        /// <inheritdoc />     
        public async Task PostClientRoles(string realm, string id, RoleRepresentation body, CancellationToken ct)
        {
            // verify the required parameter 'realm' is set
            if (realm == null) throw new KeycloakClientApiException(400, "Missing required parameter 'realm' when calling PostClientRoles");
            // verify the required parameter 'id' is set
            if (id == null) throw new KeycloakClientApiException(400, "Missing required parameter 'id' when calling PostClientRoles");
            
            var path_ = new StringBuilder("/{realm}/clients/{id}/roles"); 
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
        public async Task PostRoleCompositesByRealmByRoleName(string realm, string roleName, RoleRepresentation body, CancellationToken ct)
        {
            // verify the required parameter 'realm' is set
            if (realm == null) throw new KeycloakClientApiException(400, "Missing required parameter 'realm' when calling PostRoleCompositesByRealmByRoleName");
            // verify the required parameter 'roleName' is set
            if (roleName == null) throw new KeycloakClientApiException(400, "Missing required parameter 'roleName' when calling PostRoleCompositesByRealmByRoleName");
            
            var path_ = new StringBuilder("/{realm}/roles/{role-name}/composites"); 
            path_ = path_.Replace("{realm}", ParameterToString(realm));
            path_ = path_.Replace("{role-name}", ParameterToString(roleName));

            
        
            await CallApi(
                        path_.ToString(), 
                        HttpMethod.Post,
                        body: body,   
                        ct: ct
            );
        }

        /// <inheritdoc />     
        public async Task PostRolesByRealm(string realm, RoleRepresentation body, CancellationToken ct)
        {
            // verify the required parameter 'realm' is set
            if (realm == null) throw new KeycloakClientApiException(400, "Missing required parameter 'realm' when calling PostRolesByRealm");
            
            var path_ = new StringBuilder("/{realm}/roles"); 
            path_ = path_.Replace("{realm}", ParameterToString(realm));

            
        
            await CallApi(
                        path_.ToString(), 
                        HttpMethod.Post,
                        body: body,   
                        ct: ct
            );
        }

        /// <inheritdoc />     
        public async Task PutClientRole(string realm, string id, string roleName, RoleRepresentation body, CancellationToken ct)
        {
            // verify the required parameter 'realm' is set
            if (realm == null) throw new KeycloakClientApiException(400, "Missing required parameter 'realm' when calling PutClientRole");
            // verify the required parameter 'id' is set
            if (id == null) throw new KeycloakClientApiException(400, "Missing required parameter 'id' when calling PutClientRole");
            // verify the required parameter 'roleName' is set
            if (roleName == null) throw new KeycloakClientApiException(400, "Missing required parameter 'roleName' when calling PutClientRole");
            
            var path_ = new StringBuilder("/{realm}/clients/{id}/roles/{role-name}"); 
            path_ = path_.Replace("{realm}", ParameterToString(realm));
            path_ = path_.Replace("{id}", ParameterToString(id));
            path_ = path_.Replace("{role-name}", ParameterToString(roleName));

            
        
            await CallApi(
                        path_.ToString(), 
                        HttpMethod.Put,
                        body: body,   
                        ct: ct
            );
        }

        /// <inheritdoc />     
        public async Task<ManagementPermissionReference> PutClientRoleManagementPermissions(string realm, string id, string roleName, ManagementPermissionReference body, CancellationToken ct)
        {
            // verify the required parameter 'realm' is set
            if (realm == null) throw new KeycloakClientApiException(400, "Missing required parameter 'realm' when calling PutClientRoleManagementPermissions");
            // verify the required parameter 'id' is set
            if (id == null) throw new KeycloakClientApiException(400, "Missing required parameter 'id' when calling PutClientRoleManagementPermissions");
            // verify the required parameter 'roleName' is set
            if (roleName == null) throw new KeycloakClientApiException(400, "Missing required parameter 'roleName' when calling PutClientRoleManagementPermissions");
            
            var path_ = new StringBuilder("/{realm}/clients/{id}/roles/{role-name}/management/permissions"); 
            path_ = path_.Replace("{realm}", ParameterToString(realm));
            path_ = path_.Replace("{id}", ParameterToString(id));
            path_ = path_.Replace("{role-name}", ParameterToString(roleName));

            
        
            var response = await CallApi<ManagementPermissionReference>(
                        path_.ToString(), 
                        HttpMethod.Put,
                        body: body,   
                        ct: ct
            );
            return response;
        }

        /// <inheritdoc />     
        public async Task PutRoleByRealmByRoleName(string realm, string roleName, RoleRepresentation body, CancellationToken ct)
        {
            // verify the required parameter 'realm' is set
            if (realm == null) throw new KeycloakClientApiException(400, "Missing required parameter 'realm' when calling PutRoleByRealmByRoleName");
            // verify the required parameter 'roleName' is set
            if (roleName == null) throw new KeycloakClientApiException(400, "Missing required parameter 'roleName' when calling PutRoleByRealmByRoleName");
            
            var path_ = new StringBuilder("/{realm}/roles/{role-name}"); 
            path_ = path_.Replace("{realm}", ParameterToString(realm));
            path_ = path_.Replace("{role-name}", ParameterToString(roleName));

            
        
            await CallApi(
                        path_.ToString(), 
                        HttpMethod.Put,
                        body: body,   
                        ct: ct
            );
        }

        /// <inheritdoc />     
        public async Task<ManagementPermissionReference> PutRoleManagementPermissionsByRealmByRoleName(string realm, string roleName, ManagementPermissionReference body, CancellationToken ct)
        {
            // verify the required parameter 'realm' is set
            if (realm == null) throw new KeycloakClientApiException(400, "Missing required parameter 'realm' when calling PutRoleManagementPermissionsByRealmByRoleName");
            // verify the required parameter 'roleName' is set
            if (roleName == null) throw new KeycloakClientApiException(400, "Missing required parameter 'roleName' when calling PutRoleManagementPermissionsByRealmByRoleName");
            
            var path_ = new StringBuilder("/{realm}/roles/{role-name}/management/permissions"); 
            path_ = path_.Replace("{realm}", ParameterToString(realm));
            path_ = path_.Replace("{role-name}", ParameterToString(roleName));

            
        
            var response = await CallApi<ManagementPermissionReference>(
                        path_.ToString(), 
                        HttpMethod.Put,
                        body: body,   
                        ct: ct
            );
            return response;
        }

    }
}