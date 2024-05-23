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
    public partial interface IGroupsApi
    {
        /// <summary>
        ///  
        /// </summary>
        /// <param name="realm">realm name (not id!)</param>
        /// <param name="id"></param>
        /// <param name="ct"></param>
        /// <returns></returns>
        Task DeleteGroupByRealmById (string realm, string id, CancellationToken ct);
        /// <summary>
        ///  Return a paginated list of subgroups that have a parent group corresponding to the group on the URL
        /// </summary>
        /// <param name="realm">realm name (not id!)</param>
        /// <param name="id"></param>
        /// <param name="briefRepresentation"></param>
        /// <param name="first"></param>
        /// <param name="max"></param>
        /// <param name="ct"></param>
        /// <returns>List&lt;GroupRepresentation&gt;</returns>
        Task<List<GroupRepresentation>> GetChildren (string realm, string id, string briefRepresentation, string first, string max, CancellationToken ct);
        /// <summary>
        ///  
        /// </summary>
        /// <param name="realm">realm name (not id!)</param>
        /// <param name="id"></param>
        /// <param name="ct"></param>
        /// <returns>GroupRepresentation</returns>
        Task<GroupRepresentation> GetGroup (string realm, string id, CancellationToken ct);
        /// <summary>
        ///  Return object stating whether client Authorization permissions have been initialized or not and a reference
        /// </summary>
        /// <param name="realm">realm name (not id!)</param>
        /// <param name="id"></param>
        /// <param name="ct"></param>
        /// <returns>ManagementPermissionReference</returns>
        Task<ManagementPermissionReference> GetGroupManagementPermissions (string realm, string id, CancellationToken ct);
        /// <summary>
        ///  Get group hierarchy.  Only name and ids are returned.
        /// </summary>
        /// <param name="realm">realm name (not id!)</param>
        /// <param name="briefRepresentation"></param>
        /// <param name="exact"></param>
        /// <param name="first"></param>
        /// <param name="max"></param>
        /// <param name="populateHierarchy"></param>
        /// <param name="q"></param>
        /// <param name="search"></param>
        /// <param name="ct"></param>
        /// <returns>List&lt;GroupRepresentation&gt;</returns>
        Task<List<GroupRepresentation>> GetGroupsByRealm (string realm, string briefRepresentation, string exact, string first, string max, string populateHierarchy, string q, string search, CancellationToken ct);
        /// <summary>
        ///  Returns the groups counts.
        /// </summary>
        /// <param name="realm">realm name (not id!)</param>
        /// <param name="search"></param>
        /// <param name="top"></param>
        /// <param name="ct"></param>
        /// <returns>Dictionary&lt;string, long?&gt;</returns>
        Task<Dictionary<string, long?>> GetGroupsCountByRealm (string realm, string search, string top, CancellationToken ct);
        /// <summary>
        ///  Get users Returns a stream of users, filtered according to query parameters
        /// </summary>
        /// <param name="realm">realm name (not id!)</param>
        /// <param name="id"></param>
        /// <param name="briefRepresentation">Only return basic information (only guaranteed to return id, username, created, first and last name, email, enabled state, email verification state, federation link, and access. Note that it means that namely user attributes, required actions, and not before are not returned.)</param>
        /// <param name="first">Pagination offset</param>
        /// <param name="max">Maximum results size (defaults to 100)</param>
        /// <param name="ct"></param>
        /// <returns>List&lt;UserRepresentation&gt;</returns>
        Task<List<UserRepresentation>> GetMembers (string realm, string id, string briefRepresentation, string first, string max, CancellationToken ct);
        /// <summary>
        ///  Set or create child.
        /// </summary>
        /// <param name="realm">realm name (not id!)</param>
        /// <param name="id"></param>
        /// <param name="body">GroupRepresentation</param>
        /// <param name="ct"></param>
        /// <returns></returns>
        Task PostChildren (string realm, string id, GroupRepresentation body, CancellationToken ct);
        /// <summary>
        ///  create or add a top level realm groupSet or create child.
        /// </summary>
        /// <param name="realm">realm name (not id!)</param>
        /// <param name="body">GroupRepresentation</param>
        /// <param name="ct"></param>
        /// <returns></returns>
        Task PostGroups (string realm, GroupRepresentation body, CancellationToken ct);
        /// <summary>
        ///  Update group, ignores subgroups.
        /// </summary>
        /// <param name="realm">realm name (not id!)</param>
        /// <param name="id"></param>
        /// <param name="body">GroupRepresentation</param>
        /// <param name="ct"></param>
        /// <returns></returns>
        Task PutGroupByRealmById (string realm, string id, GroupRepresentation body, CancellationToken ct);
        /// <summary>
        ///  Return object stating whether client Authorization permissions have been initialized or not and a reference
        /// </summary>
        /// <param name="realm">realm name (not id!)</param>
        /// <param name="id"></param>
        /// <param name="body">ManagementPermissionReference</param>
        /// <param name="ct"></param>
        /// <returns>ManagementPermissionReference</returns>
        Task<ManagementPermissionReference> PutGroupManagementPermissions (string realm, string id, ManagementPermissionReference body, CancellationToken ct);
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>  
    [GeneratedCode("swagger-codegen", "3.0.56-SNAPSHOT")]
    public partial class GroupsApi : KeycloakClientApiClientBase, IGroupsApi
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="GroupsApi"/> class.
        /// </summary>
        /// <param name="httpClient"> HttpClient to be used for calls. </param>
        /// <param name="basePath"> Base url to be used for calls. </param>
        public GroupsApi(HttpClient httpClient, String basePath="https://keycloak.example.com/admin/realms") : base(httpClient, basePath)
        {
        }

        /// <inheritdoc />     
        public async Task DeleteGroupByRealmById(string realm, string id, CancellationToken ct)
        {
            // verify the required parameter 'realm' is set
            if (realm == null) throw new KeycloakClientApiException(400, "Missing required parameter 'realm' when calling DeleteGroupByRealmById");
            // verify the required parameter 'id' is set
            if (id == null) throw new KeycloakClientApiException(400, "Missing required parameter 'id' when calling DeleteGroupByRealmById");
            
            var path_ = new StringBuilder("/{realm}/groups/{id}"); 
            path_ = path_.Replace("{realm}", ParameterToString(realm));
            path_ = path_.Replace("{id}", ParameterToString(id));

            
        
            await CallApi(
                        path_.ToString(), 
                        HttpMethod.Delete,  
                        ct: ct
            );
        }

        /// <inheritdoc />     
        public async Task<List<GroupRepresentation>> GetChildren(string realm, string id, string briefRepresentation, string first, string max, CancellationToken ct)
        {
            // verify the required parameter 'realm' is set
            if (realm == null) throw new KeycloakClientApiException(400, "Missing required parameter 'realm' when calling GetChildren");
            // verify the required parameter 'id' is set
            if (id == null) throw new KeycloakClientApiException(400, "Missing required parameter 'id' when calling GetChildren");
            
            var path_ = new StringBuilder("/{realm}/groups/{id}/children"); 
            path_ = path_.Replace("{realm}", ParameterToString(realm));
            path_ = path_.Replace("{id}", ParameterToString(id));

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
        public async Task<GroupRepresentation> GetGroup(string realm, string id, CancellationToken ct)
        {
            // verify the required parameter 'realm' is set
            if (realm == null) throw new KeycloakClientApiException(400, "Missing required parameter 'realm' when calling GetGroup");
            // verify the required parameter 'id' is set
            if (id == null) throw new KeycloakClientApiException(400, "Missing required parameter 'id' when calling GetGroup");
            
            var path_ = new StringBuilder("/{realm}/groups/{id}"); 
            path_ = path_.Replace("{realm}", ParameterToString(realm));
            path_ = path_.Replace("{id}", ParameterToString(id));

            
        
            var response = await CallApi<GroupRepresentation>(
                        path_.ToString(), 
                        HttpMethod.Get,  
                        ct: ct
            );
            return response;
        }

        /// <inheritdoc />     
        public async Task<ManagementPermissionReference> GetGroupManagementPermissions(string realm, string id, CancellationToken ct)
        {
            // verify the required parameter 'realm' is set
            if (realm == null) throw new KeycloakClientApiException(400, "Missing required parameter 'realm' when calling GetGroupManagementPermissions");
            // verify the required parameter 'id' is set
            if (id == null) throw new KeycloakClientApiException(400, "Missing required parameter 'id' when calling GetGroupManagementPermissions");
            
            var path_ = new StringBuilder("/{realm}/groups/{id}/management/permissions"); 
            path_ = path_.Replace("{realm}", ParameterToString(realm));
            path_ = path_.Replace("{id}", ParameterToString(id));

            
        
            var response = await CallApi<ManagementPermissionReference>(
                        path_.ToString(), 
                        HttpMethod.Get,  
                        ct: ct
            );
            return response;
        }

        /// <inheritdoc />     
        public async Task<List<GroupRepresentation>> GetGroupsByRealm(string realm, string briefRepresentation, string exact, string first, string max, string populateHierarchy, string q, string search, CancellationToken ct)
        {
            // verify the required parameter 'realm' is set
            if (realm == null) throw new KeycloakClientApiException(400, "Missing required parameter 'realm' when calling GetGroupsByRealm");
            
            var path_ = new StringBuilder("/{realm}/groups"); 
            path_ = path_.Replace("{realm}", ParameterToString(realm));

            var queryParams = new Dictionary<string, string>();
             
            if (briefRepresentation != null) queryParams.Add("briefRepresentation", ParameterToString(briefRepresentation)); // query parameter 
            if (exact != null) queryParams.Add("exact", ParameterToString(exact)); // query parameter 
            if (first != null) queryParams.Add("first", ParameterToString(first)); // query parameter 
            if (max != null) queryParams.Add("max", ParameterToString(max)); // query parameter 
            if (populateHierarchy != null) queryParams.Add("populateHierarchy", ParameterToString(populateHierarchy)); // query parameter 
            if (q != null) queryParams.Add("q", ParameterToString(q)); // query parameter 
            if (search != null) queryParams.Add("search", ParameterToString(search)); // query parameter
        
            var response = await CallApi<List<GroupRepresentation>>(
                        path_.ToString(), 
                        HttpMethod.Get,
                        queryParams: queryParams,  
                        ct: ct
            );
            return response;
        }

        /// <inheritdoc />     
        public async Task<Dictionary<string, long?>> GetGroupsCountByRealm(string realm, string search, string top, CancellationToken ct)
        {
            // verify the required parameter 'realm' is set
            if (realm == null) throw new KeycloakClientApiException(400, "Missing required parameter 'realm' when calling GetGroupsCountByRealm");
            
            var path_ = new StringBuilder("/{realm}/groups/count"); 
            path_ = path_.Replace("{realm}", ParameterToString(realm));

            var queryParams = new Dictionary<string, string>();
             
            if (search != null) queryParams.Add("search", ParameterToString(search)); // query parameter 
            if (top != null) queryParams.Add("top", ParameterToString(top)); // query parameter
        
            var response = await CallApi<Dictionary<string, long?>>(
                        path_.ToString(), 
                        HttpMethod.Get,
                        queryParams: queryParams,  
                        ct: ct
            );
            return response;
        }

        /// <inheritdoc />     
        public async Task<List<UserRepresentation>> GetMembers(string realm, string id, string briefRepresentation, string first, string max, CancellationToken ct)
        {
            // verify the required parameter 'realm' is set
            if (realm == null) throw new KeycloakClientApiException(400, "Missing required parameter 'realm' when calling GetMembers");
            // verify the required parameter 'id' is set
            if (id == null) throw new KeycloakClientApiException(400, "Missing required parameter 'id' when calling GetMembers");
            
            var path_ = new StringBuilder("/{realm}/groups/{id}/members"); 
            path_ = path_.Replace("{realm}", ParameterToString(realm));
            path_ = path_.Replace("{id}", ParameterToString(id));

            var queryParams = new Dictionary<string, string>();
             
            if (briefRepresentation != null) queryParams.Add("briefRepresentation", ParameterToString(briefRepresentation)); // query parameter 
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
        public async Task PostChildren(string realm, string id, GroupRepresentation body, CancellationToken ct)
        {
            // verify the required parameter 'realm' is set
            if (realm == null) throw new KeycloakClientApiException(400, "Missing required parameter 'realm' when calling PostChildren");
            // verify the required parameter 'id' is set
            if (id == null) throw new KeycloakClientApiException(400, "Missing required parameter 'id' when calling PostChildren");
            
            var path_ = new StringBuilder("/{realm}/groups/{id}/children"); 
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
        public async Task PostGroups(string realm, GroupRepresentation body, CancellationToken ct)
        {
            // verify the required parameter 'realm' is set
            if (realm == null) throw new KeycloakClientApiException(400, "Missing required parameter 'realm' when calling PostGroups");
            
            var path_ = new StringBuilder("/{realm}/groups"); 
            path_ = path_.Replace("{realm}", ParameterToString(realm));

            
        
            await CallApi(
                        path_.ToString(), 
                        HttpMethod.Post,
                        body: body,   
                        ct: ct
            );
        }

        /// <inheritdoc />     
        public async Task PutGroupByRealmById(string realm, string id, GroupRepresentation body, CancellationToken ct)
        {
            // verify the required parameter 'realm' is set
            if (realm == null) throw new KeycloakClientApiException(400, "Missing required parameter 'realm' when calling PutGroupByRealmById");
            // verify the required parameter 'id' is set
            if (id == null) throw new KeycloakClientApiException(400, "Missing required parameter 'id' when calling PutGroupByRealmById");
            
            var path_ = new StringBuilder("/{realm}/groups/{id}"); 
            path_ = path_.Replace("{realm}", ParameterToString(realm));
            path_ = path_.Replace("{id}", ParameterToString(id));

            
        
            await CallApi(
                        path_.ToString(), 
                        HttpMethod.Put,
                        body: body,   
                        ct: ct
            );
        }

        /// <inheritdoc />     
        public async Task<ManagementPermissionReference> PutGroupManagementPermissions(string realm, string id, ManagementPermissionReference body, CancellationToken ct)
        {
            // verify the required parameter 'realm' is set
            if (realm == null) throw new KeycloakClientApiException(400, "Missing required parameter 'realm' when calling PutGroupManagementPermissions");
            // verify the required parameter 'id' is set
            if (id == null) throw new KeycloakClientApiException(400, "Missing required parameter 'id' when calling PutGroupManagementPermissions");
            
            var path_ = new StringBuilder("/{realm}/groups/{id}/management/permissions"); 
            path_ = path_.Replace("{realm}", ParameterToString(realm));
            path_ = path_.Replace("{id}", ParameterToString(id));

            
        
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