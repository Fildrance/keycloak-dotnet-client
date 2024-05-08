using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading;
using System.Text;
using System.Threading.Tasks;
using System.CodeDom.Compiler;
using PetShop.Models;

namespace PetShop.Clients;

/// <summary>
/// Represents a collection of functions to interact with the API endpoints
/// </summary>
[GeneratedCode("swagger-codegen", "3.0.56-SNAPSHOT")]
public partial interface IRolesByIDApi
{
    /// <summary>
    ///  Delete the role
    /// </summary>
    /// <param name="realm">realm name (not id!)</param>
    /// <param name="roleId">id of role</param>
    /// <param name="ct"></param>
    /// <returns></returns>
    Task DeleteRolesById (string realm, string roleId, CancellationToken ct);
    /// <summary>
    ///  Remove a set of roles from the role’s composite
    /// </summary>
    /// <param name="realm">realm name (not id!)</param>
    /// <param name="roleId"></param>
    /// <param name="body">RoleRepresentation</param>
    /// <param name="ct"></param>
    /// <returns></returns>
    Task DeleteRolesByIdComposites (string realm, string roleId, RoleRepresentation body, CancellationToken ct);
    /// <summary>
    ///  Get a specific role’s representation
    /// </summary>
    /// <param name="realm">realm name (not id!)</param>
    /// <param name="roleId">id of role</param>
    /// <param name="ct"></param>
    /// <returns>RoleRepresentation</returns>
    Task<RoleRepresentation> GetRolesById (string realm, string roleId, CancellationToken ct);
    /// <summary>
    ///  Get role’s children Returns a set of role’s children provided the role is a composite.
    /// </summary>
    /// <param name="realm">realm name (not id!)</param>
    /// <param name="roleId"></param>
    /// <param name="first"></param>
    /// <param name="max"></param>
    /// <param name="search"></param>
    /// <param name="ct"></param>
    /// <returns>List&lt;RoleRepresentation&gt;</returns>
    Task<List<RoleRepresentation>> GetRolesByIdComposites (string realm, string roleId, string first, string max, string search, CancellationToken ct);
    /// <summary>
    ///  Get client-level roles for the client that are in the role’s composite
    /// </summary>
    /// <param name="realm">realm name (not id!)</param>
    /// <param name="roleId"></param>
    /// <param name="clientUuid"></param>
    /// <param name="ct"></param>
    /// <returns>List&lt;RoleRepresentation&gt;</returns>
    Task<List<RoleRepresentation>> GetRolesByIdCompositesClient (string realm, string roleId, string clientUuid, CancellationToken ct);
    /// <summary>
    ///  Get realm-level roles that are in the role’s composite
    /// </summary>
    /// <param name="realm">realm name (not id!)</param>
    /// <param name="roleId"></param>
    /// <param name="ct"></param>
    /// <returns>List&lt;RoleRepresentation&gt;</returns>
    Task<List<RoleRepresentation>> GetRolesByIdCompositesRealm (string realm, string roleId, CancellationToken ct);
    /// <summary>
    ///  Return object stating whether role Authorization permissions have been initialized or not and a reference
    /// </summary>
    /// <param name="realm">realm name (not id!)</param>
    /// <param name="roleId"></param>
    /// <param name="ct"></param>
    /// <returns>ManagementPermissionReference</returns>
    Task<ManagementPermissionReference> GetRolesByIdManagementPermissions (string realm, string roleId, CancellationToken ct);
    /// <summary>
    ///  Make the role a composite role by associating some child roles
    /// </summary>
    /// <param name="realm">realm name (not id!)</param>
    /// <param name="roleId"></param>
    /// <param name="body">RoleRepresentation</param>
    /// <param name="ct"></param>
    /// <returns></returns>
    Task PostRolesByIdComposites (string realm, string roleId, RoleRepresentation body, CancellationToken ct);
    /// <summary>
    ///  Update the role
    /// </summary>
    /// <param name="realm">realm name (not id!)</param>
    /// <param name="roleId">id of role</param>
    /// <param name="body">RoleRepresentation</param>
    /// <param name="ct"></param>
    /// <returns></returns>
    Task PutRolesById (string realm, string roleId, RoleRepresentation body, CancellationToken ct);
    /// <summary>
    ///  Return object stating whether role Authorization permissions have been initialized or not and a reference
    /// </summary>
    /// <param name="realm">realm name (not id!)</param>
    /// <param name="roleId"></param>
    /// <param name="body">ManagementPermissionReference</param>
    /// <param name="ct"></param>
    /// <returns>ManagementPermissionReference</returns>
    Task<ManagementPermissionReference> PutRolesByIdManagementPermissions (string realm, string roleId, ManagementPermissionReference body, CancellationToken ct);
}

/// <summary>
/// Represents a collection of functions to interact with the API endpoints
/// </summary>  
[GeneratedCode("swagger-codegen", "3.0.56-SNAPSHOT")]
public partial class RolesByIDApi : PetShopApiClientBase, IRolesByIDApi
{
    /// <summary>
    /// Initializes a new instance of the <see cref="RolesByIDApi"/> class.
    /// </summary>
    /// <param name="httpClient"> HttpClient to be used for calls. </param>
    /// <param name="basePath"> Base url to be used for calls. </param>
    public RolesByIDApi(HttpClient httpClient, String basePath="https://keycloak.example.com/admin/realms") : base(httpClient, basePath)
    {
    }

    /// <inheritdoc />     
    public async Task DeleteRolesById(string realm, string roleId, CancellationToken ct)
    {
        // verify the required parameter 'realm' is set
        if (realm == null) throw new PetShopApiException(400, "Missing required parameter 'realm' when calling DeleteRolesById");
        // verify the required parameter 'roleId' is set
        if (roleId == null) throw new PetShopApiException(400, "Missing required parameter 'roleId' when calling DeleteRolesById");
        
        var path_ = new StringBuilder("/{realm}/roles-by-id/{role-id}"); 
        path_ = path_.Replace("{realm}", ParameterToString(realm));
        path_ = path_.Replace("{role-id}", ParameterToString(roleId));

        
        
        await CallApi(
                    path_.ToString(), 
                    HttpMethod.Delete,  
                    ct: ct
        );
    }

    /// <inheritdoc />     
    public async Task DeleteRolesByIdComposites(string realm, string roleId, RoleRepresentation body, CancellationToken ct)
    {
        // verify the required parameter 'realm' is set
        if (realm == null) throw new PetShopApiException(400, "Missing required parameter 'realm' when calling DeleteRolesByIdComposites");
        // verify the required parameter 'roleId' is set
        if (roleId == null) throw new PetShopApiException(400, "Missing required parameter 'roleId' when calling DeleteRolesByIdComposites");
        
        var path_ = new StringBuilder("/{realm}/roles-by-id/{role-id}/composites"); 
        path_ = path_.Replace("{realm}", ParameterToString(realm));
        path_ = path_.Replace("{role-id}", ParameterToString(roleId));

        
        
        await CallApi(
                    path_.ToString(), 
                    HttpMethod.Delete,
                    body: body,   
                    ct: ct
        );
    }

    /// <inheritdoc />     
    public async Task<RoleRepresentation> GetRolesById(string realm, string roleId, CancellationToken ct)
    {
        // verify the required parameter 'realm' is set
        if (realm == null) throw new PetShopApiException(400, "Missing required parameter 'realm' when calling GetRolesById");
        // verify the required parameter 'roleId' is set
        if (roleId == null) throw new PetShopApiException(400, "Missing required parameter 'roleId' when calling GetRolesById");
        
        var path_ = new StringBuilder("/{realm}/roles-by-id/{role-id}"); 
        path_ = path_.Replace("{realm}", ParameterToString(realm));
        path_ = path_.Replace("{role-id}", ParameterToString(roleId));

        
        
        var response = await CallApi<RoleRepresentation>(
                    path_.ToString(), 
                    HttpMethod.Get,  
                    ct: ct
        );
        return response;
    }

    /// <inheritdoc />     
    public async Task<List<RoleRepresentation>> GetRolesByIdComposites(string realm, string roleId, string first, string max, string search, CancellationToken ct)
    {
        // verify the required parameter 'realm' is set
        if (realm == null) throw new PetShopApiException(400, "Missing required parameter 'realm' when calling GetRolesByIdComposites");
        // verify the required parameter 'roleId' is set
        if (roleId == null) throw new PetShopApiException(400, "Missing required parameter 'roleId' when calling GetRolesByIdComposites");
        
        var path_ = new StringBuilder("/{realm}/roles-by-id/{role-id}/composites"); 
        path_ = path_.Replace("{realm}", ParameterToString(realm));
        path_ = path_.Replace("{role-id}", ParameterToString(roleId));

        var queryParams = new Dictionary<string, string>();
         
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
    public async Task<List<RoleRepresentation>> GetRolesByIdCompositesClient(string realm, string roleId, string clientUuid, CancellationToken ct)
    {
        // verify the required parameter 'realm' is set
        if (realm == null) throw new PetShopApiException(400, "Missing required parameter 'realm' when calling GetRolesByIdCompositesClient");
        // verify the required parameter 'roleId' is set
        if (roleId == null) throw new PetShopApiException(400, "Missing required parameter 'roleId' when calling GetRolesByIdCompositesClient");
        // verify the required parameter 'clientUuid' is set
        if (clientUuid == null) throw new PetShopApiException(400, "Missing required parameter 'clientUuid' when calling GetRolesByIdCompositesClient");
        
        var path_ = new StringBuilder("/{realm}/roles-by-id/{role-id}/composites/clients/{clientUuid}"); 
        path_ = path_.Replace("{realm}", ParameterToString(realm));
        path_ = path_.Replace("{role-id}", ParameterToString(roleId));
        path_ = path_.Replace("{clientUuid}", ParameterToString(clientUuid));

        
        
        var response = await CallApi<List<RoleRepresentation>>(
                    path_.ToString(), 
                    HttpMethod.Get,  
                    ct: ct
        );
        return response;
    }

    /// <inheritdoc />     
    public async Task<List<RoleRepresentation>> GetRolesByIdCompositesRealm(string realm, string roleId, CancellationToken ct)
    {
        // verify the required parameter 'realm' is set
        if (realm == null) throw new PetShopApiException(400, "Missing required parameter 'realm' when calling GetRolesByIdCompositesRealm");
        // verify the required parameter 'roleId' is set
        if (roleId == null) throw new PetShopApiException(400, "Missing required parameter 'roleId' when calling GetRolesByIdCompositesRealm");
        
        var path_ = new StringBuilder("/{realm}/roles-by-id/{role-id}/composites/realm"); 
        path_ = path_.Replace("{realm}", ParameterToString(realm));
        path_ = path_.Replace("{role-id}", ParameterToString(roleId));

        
        
        var response = await CallApi<List<RoleRepresentation>>(
                    path_.ToString(), 
                    HttpMethod.Get,  
                    ct: ct
        );
        return response;
    }

    /// <inheritdoc />     
    public async Task<ManagementPermissionReference> GetRolesByIdManagementPermissions(string realm, string roleId, CancellationToken ct)
    {
        // verify the required parameter 'realm' is set
        if (realm == null) throw new PetShopApiException(400, "Missing required parameter 'realm' when calling GetRolesByIdManagementPermissions");
        // verify the required parameter 'roleId' is set
        if (roleId == null) throw new PetShopApiException(400, "Missing required parameter 'roleId' when calling GetRolesByIdManagementPermissions");
        
        var path_ = new StringBuilder("/{realm}/roles-by-id/{role-id}/management/permissions"); 
        path_ = path_.Replace("{realm}", ParameterToString(realm));
        path_ = path_.Replace("{role-id}", ParameterToString(roleId));

        
        
        var response = await CallApi<ManagementPermissionReference>(
                    path_.ToString(), 
                    HttpMethod.Get,  
                    ct: ct
        );
        return response;
    }

    /// <inheritdoc />     
    public async Task PostRolesByIdComposites(string realm, string roleId, RoleRepresentation body, CancellationToken ct)
    {
        // verify the required parameter 'realm' is set
        if (realm == null) throw new PetShopApiException(400, "Missing required parameter 'realm' when calling PostRolesByIdComposites");
        // verify the required parameter 'roleId' is set
        if (roleId == null) throw new PetShopApiException(400, "Missing required parameter 'roleId' when calling PostRolesByIdComposites");
        
        var path_ = new StringBuilder("/{realm}/roles-by-id/{role-id}/composites"); 
        path_ = path_.Replace("{realm}", ParameterToString(realm));
        path_ = path_.Replace("{role-id}", ParameterToString(roleId));

        
        
        await CallApi(
                    path_.ToString(), 
                    HttpMethod.Post,
                    body: body,   
                    ct: ct
        );
    }

    /// <inheritdoc />     
    public async Task PutRolesById(string realm, string roleId, RoleRepresentation body, CancellationToken ct)
    {
        // verify the required parameter 'realm' is set
        if (realm == null) throw new PetShopApiException(400, "Missing required parameter 'realm' when calling PutRolesById");
        // verify the required parameter 'roleId' is set
        if (roleId == null) throw new PetShopApiException(400, "Missing required parameter 'roleId' when calling PutRolesById");
        
        var path_ = new StringBuilder("/{realm}/roles-by-id/{role-id}"); 
        path_ = path_.Replace("{realm}", ParameterToString(realm));
        path_ = path_.Replace("{role-id}", ParameterToString(roleId));

        
        
        await CallApi(
                    path_.ToString(), 
                    HttpMethod.Put,
                    body: body,   
                    ct: ct
        );
    }

    /// <inheritdoc />     
    public async Task<ManagementPermissionReference> PutRolesByIdManagementPermissions(string realm, string roleId, ManagementPermissionReference body, CancellationToken ct)
    {
        // verify the required parameter 'realm' is set
        if (realm == null) throw new PetShopApiException(400, "Missing required parameter 'realm' when calling PutRolesByIdManagementPermissions");
        // verify the required parameter 'roleId' is set
        if (roleId == null) throw new PetShopApiException(400, "Missing required parameter 'roleId' when calling PutRolesByIdManagementPermissions");
        
        var path_ = new StringBuilder("/{realm}/roles-by-id/{role-id}/management/permissions"); 
        path_ = path_.Replace("{realm}", ParameterToString(realm));
        path_ = path_.Replace("{role-id}", ParameterToString(roleId));

        
        
        var response = await CallApi<ManagementPermissionReference>(
                    path_.ToString(), 
                    HttpMethod.Put,
                    body: body,   
                    ct: ct
        );
        return response;
    }

}
