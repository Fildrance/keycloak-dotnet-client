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
public partial interface IClientsApi
{
    /// <summary>
    ///  Delete the client
    /// </summary>
    /// <param name="realm">realm name (not id!)</param>
    /// <param name="id"></param>
    /// <param name="ct"></param>
    /// <returns></returns>
    Task DeleteClientByRealmById (string realm, string id, CancellationToken ct);
    /// <summary>
    ///  
    /// </summary>
    /// <param name="realm">realm name (not id!)</param>
    /// <param name="id"></param>
    /// <param name="clientScopeId"></param>
    /// <param name="ct"></param>
    /// <returns></returns>
    Task DeleteDefaultClientScope (string realm, string id, string clientScopeId, CancellationToken ct);
    /// <summary>
    ///  Unregister a cluster node from the client
    /// </summary>
    /// <param name="realm">realm name (not id!)</param>
    /// <param name="id"></param>
    /// <param name="node"></param>
    /// <param name="ct"></param>
    /// <returns></returns>
    Task DeleteNode (string realm, string id, string node, CancellationToken ct);
    /// <summary>
    ///  
    /// </summary>
    /// <param name="realm">realm name (not id!)</param>
    /// <param name="id"></param>
    /// <param name="clientScopeId"></param>
    /// <param name="ct"></param>
    /// <returns></returns>
    Task DeleteOptionalClientScope (string realm, string id, string clientScopeId, CancellationToken ct);
    /// <summary>
    ///  Invalidate the rotated secret for the client
    /// </summary>
    /// <param name="realm">realm name (not id!)</param>
    /// <param name="id"></param>
    /// <param name="ct"></param>
    /// <returns></returns>
    Task DeleteRotated (string realm, string id, CancellationToken ct);
    /// <summary>
    ///  Get representation of the client
    /// </summary>
    /// <param name="realm">realm name (not id!)</param>
    /// <param name="id"></param>
    /// <param name="ct"></param>
    /// <returns>ClientRepresentation</returns>
    Task<ClientRepresentation> GetClientByRealmById (string realm, string id, CancellationToken ct);
    /// <summary>
    ///  Return object stating whether client Authorization permissions have been initialized or not and a reference
    /// </summary>
    /// <param name="realm">realm name (not id!)</param>
    /// <param name="id"></param>
    /// <param name="ct"></param>
    /// <returns>ManagementPermissionReference</returns>
    Task<ManagementPermissionReference> GetClientManagementPermissions (string realm, string id, CancellationToken ct);
    /// <summary>
    ///  Get the client secret
    /// </summary>
    /// <param name="realm">realm name (not id!)</param>
    /// <param name="id"></param>
    /// <param name="ct"></param>
    /// <returns>CredentialRepresentation</returns>
    Task<CredentialRepresentation> GetClientSecret (string realm, string id, CancellationToken ct);
    /// <summary>
    ///  Get user sessions for client Returns a list of user sessions associated with this client
    /// </summary>
    /// <param name="realm">realm name (not id!)</param>
    /// <param name="id"></param>
    /// <param name="first">Paging offset</param>
    /// <param name="max">Maximum results size (defaults to 100)</param>
    /// <param name="ct"></param>
    /// <returns>List&lt;UserSessionRepresentation&gt;</returns>
    Task<List<UserSessionRepresentation>> GetClientUserSessions (string realm, string id, string first, string max, CancellationToken ct);
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
    /// <param name="ct"></param>
    /// <returns>List&lt;ClientRepresentation&gt;</returns>
    Task<List<ClientRepresentation>> GetClients (string realm, string clientId, string first, string max, string q, string search, string viewableOnly, CancellationToken ct);
    /// <summary>
    ///  Get default client scopes.  Only name and ids are returned.
    /// </summary>
    /// <param name="realm">realm name (not id!)</param>
    /// <param name="id"></param>
    /// <param name="ct"></param>
    /// <returns>List&lt;ClientScopeRepresentation&gt;</returns>
    Task<List<ClientScopeRepresentation>> GetDefaultClientScopes (string realm, string id, CancellationToken ct);
    /// <summary>
    ///  Create JSON with payload of example access token
    /// </summary>
    /// <param name="realm">realm name (not id!)</param>
    /// <param name="id"></param>
    /// <param name="scope"></param>
    /// <param name="userId"></param>
    /// <param name="ct"></param>
    /// <returns>AccessToken</returns>
    Task<AccessToken> GetGenerateExampleAccessToken (string realm, string id, string scope, string userId, CancellationToken ct);
    /// <summary>
    ///  Create JSON with payload of example id token
    /// </summary>
    /// <param name="realm">realm name (not id!)</param>
    /// <param name="id"></param>
    /// <param name="scope"></param>
    /// <param name="userId"></param>
    /// <param name="ct"></param>
    /// <returns>IDToken</returns>
    Task<IDToken> GetGenerateExampleIdToken (string realm, string id, string scope, string userId, CancellationToken ct);
    /// <summary>
    ///  Create JSON with payload of example user info
    /// </summary>
    /// <param name="realm">realm name (not id!)</param>
    /// <param name="id"></param>
    /// <param name="scope"></param>
    /// <param name="userId"></param>
    /// <param name="ct"></param>
    /// <returns>Dictionary&lt;string, Object&gt;</returns>
    Task<Dictionary<string, Object>> GetGenerateExampleUserinfo (string realm, string id, string scope, string userId, CancellationToken ct);
    /// <summary>
    ///  Get effective scope mapping of all roles of particular role container, which this client is defacto allowed to have in the accessToken issued for him.
    /// </summary>
    /// <param name="realm">realm name (not id!)</param>
    /// <param name="id"></param>
    /// <param name="roleContainerId">either realm name OR client UUID</param>
    /// <param name="scope"></param>
    /// <param name="ct"></param>
    /// <returns>List&lt;RoleRepresentation&gt;</returns>
    Task<List<RoleRepresentation>> GetGranted (string realm, string id, string roleContainerId, string scope, CancellationToken ct);
    /// <summary>
    ///  
    /// </summary>
    /// <param name="realm">realm name (not id!)</param>
    /// <param name="id"></param>
    /// <param name="providerId"></param>
    /// <param name="ct"></param>
    /// <returns></returns>
    Task GetInstallationProvider (string realm, string id, string providerId, CancellationToken ct);
    /// <summary>
    ///  Get roles, which this client doesn’t have scope for and can’t have them in the accessToken issued for him.
    /// </summary>
    /// <param name="realm">realm name (not id!)</param>
    /// <param name="id"></param>
    /// <param name="roleContainerId">either realm name OR client UUID</param>
    /// <param name="scope"></param>
    /// <param name="ct"></param>
    /// <returns>List&lt;RoleRepresentation&gt;</returns>
    Task<List<RoleRepresentation>> GetNotGranted (string realm, string id, string roleContainerId, string scope, CancellationToken ct);
    /// <summary>
    ///  Get application offline session count Returns a number of offline user sessions associated with this client { \\\&quot;count\\\&quot;: number }
    /// </summary>
    /// <param name="realm">realm name (not id!)</param>
    /// <param name="id"></param>
    /// <param name="ct"></param>
    /// <returns>Dictionary&lt;string, long?&gt;</returns>
    Task<Dictionary<string, long?>> GetOfflineSessionCount (string realm, string id, CancellationToken ct);
    /// <summary>
    ///  Get offline sessions for client Returns a list of offline user sessions associated with this client
    /// </summary>
    /// <param name="realm">realm name (not id!)</param>
    /// <param name="id"></param>
    /// <param name="first">Paging offset</param>
    /// <param name="max">Maximum results size (defaults to 100)</param>
    /// <param name="ct"></param>
    /// <returns>List&lt;UserSessionRepresentation&gt;</returns>
    Task<List<UserSessionRepresentation>> GetOfflineSessions (string realm, string id, string first, string max, CancellationToken ct);
    /// <summary>
    ///  Get optional client scopes.  Only name and ids are returned.
    /// </summary>
    /// <param name="realm">realm name (not id!)</param>
    /// <param name="id"></param>
    /// <param name="ct"></param>
    /// <returns>List&lt;ClientScopeRepresentation&gt;</returns>
    Task<List<ClientScopeRepresentation>> GetOptionalClientScopes (string realm, string id, CancellationToken ct);
    /// <summary>
    ///  Return list of all protocol mappers, which will be used when generating tokens issued for particular client.
    /// </summary>
    /// <param name="realm">realm name (not id!)</param>
    /// <param name="id"></param>
    /// <param name="scope"></param>
    /// <param name="ct"></param>
    /// <returns>List&lt;ProtocolMapperEvaluationRepresentation&gt;</returns>
    Task<List<ProtocolMapperEvaluationRepresentation>> GetProtocolMappers (string realm, string id, string scope, CancellationToken ct);
    /// <summary>
    ///  Get the rotated client secret
    /// </summary>
    /// <param name="realm">realm name (not id!)</param>
    /// <param name="id"></param>
    /// <param name="ct"></param>
    /// <returns>CredentialRepresentation</returns>
    Task<CredentialRepresentation> GetRotated (string realm, string id, CancellationToken ct);
    /// <summary>
    ///  Get a user dedicated to the service account
    /// </summary>
    /// <param name="realm">realm name (not id!)</param>
    /// <param name="id"></param>
    /// <param name="ct"></param>
    /// <returns>UserRepresentation</returns>
    Task<UserRepresentation> GetServiceAccountUser (string realm, string id, CancellationToken ct);
    /// <summary>
    ///  Get application session count Returns a number of user sessions associated with this client { \\\&quot;count\\\&quot;: number }
    /// </summary>
    /// <param name="realm">realm name (not id!)</param>
    /// <param name="id"></param>
    /// <param name="ct"></param>
    /// <returns>Dictionary&lt;string, long?&gt;</returns>
    Task<Dictionary<string, long?>> GetSessionCount (string realm, string id, CancellationToken ct);
    /// <summary>
    ///  Test if registered cluster nodes are available Tests availability by sending &#39;ping&#39; request to all cluster nodes.
    /// </summary>
    /// <param name="realm">realm name (not id!)</param>
    /// <param name="id"></param>
    /// <param name="ct"></param>
    /// <returns>GlobalRequestResult</returns>
    Task<GlobalRequestResult> GetTestNodesAvailable (string realm, string id, CancellationToken ct);
    /// <summary>
    ///  Push the client’s revocation policy to its admin URL If the client has an admin URL, push revocation policy to it.
    /// </summary>
    /// <param name="realm">realm name (not id!)</param>
    /// <param name="id"></param>
    /// <param name="ct"></param>
    /// <returns>GlobalRequestResult</returns>
    Task<GlobalRequestResult> PostClientPushRevocation (string realm, string id, CancellationToken ct);
    /// <summary>
    ///  Generate a new secret for the client
    /// </summary>
    /// <param name="realm">realm name (not id!)</param>
    /// <param name="id"></param>
    /// <param name="ct"></param>
    /// <returns>CredentialRepresentation</returns>
    Task<CredentialRepresentation> PostClientSecret (string realm, string id, CancellationToken ct);
    /// <summary>
    ///  Create a new client Client’s client_id must be unique!
    /// </summary>
    /// <param name="realm">realm name (not id!)</param>
    /// <param name="body">ClientRepresentation</param>
    /// <param name="ct"></param>
    /// <returns></returns>
    Task PostClients (string realm, ClientRepresentation body, CancellationToken ct);
    /// <summary>
    ///  Register a cluster node with the client Manually register cluster node to this client - usually it’s not needed to call this directly as adapter should handle by sending registration request to Keycloak
    /// </summary>
    /// <param name="realm">realm name (not id!)</param>
    /// <param name="id"></param>
    /// <param name="body">[string]</param>
    /// <param name="ct"></param>
    /// <returns></returns>
    Task PostNodes (string realm, string id, string body, CancellationToken ct);
    /// <summary>
    ///  Generate a new registration access token for the client
    /// </summary>
    /// <param name="realm">realm name (not id!)</param>
    /// <param name="id"></param>
    /// <param name="ct"></param>
    /// <returns>ClientRepresentation</returns>
    Task<ClientRepresentation> PostRegistrationAccessToken (string realm, string id, CancellationToken ct);
    /// <summary>
    ///  Update the client
    /// </summary>
    /// <param name="realm">realm name (not id!)</param>
    /// <param name="id"></param>
    /// <param name="body">ClientRepresentation</param>
    /// <param name="ct"></param>
    /// <returns></returns>
    Task PutClient (string realm, string id, ClientRepresentation body, CancellationToken ct);
    /// <summary>
    ///  Return object stating whether client Authorization permissions have been initialized or not and a reference
    /// </summary>
    /// <param name="realm">realm name (not id!)</param>
    /// <param name="id"></param>
    /// <param name="body">ManagementPermissionReference</param>
    /// <param name="ct"></param>
    /// <returns>ManagementPermissionReference</returns>
    Task<ManagementPermissionReference> PutClientManagementPermissions (string realm, string id, ManagementPermissionReference body, CancellationToken ct);
    /// <summary>
    ///  
    /// </summary>
    /// <param name="realm">realm name (not id!)</param>
    /// <param name="id"></param>
    /// <param name="clientScopeId"></param>
    /// <param name="ct"></param>
    /// <returns></returns>
    Task PutDefaultClientScope (string realm, string id, string clientScopeId, CancellationToken ct);
    /// <summary>
    ///  
    /// </summary>
    /// <param name="realm">realm name (not id!)</param>
    /// <param name="id"></param>
    /// <param name="clientScopeId"></param>
    /// <param name="ct"></param>
    /// <returns></returns>
    Task PutOptionalClientScope (string realm, string id, string clientScopeId, CancellationToken ct);
}

/// <summary>
/// Represents a collection of functions to interact with the API endpoints
/// </summary>  
[GeneratedCode("swagger-codegen", "3.0.56-SNAPSHOT")]
public partial class ClientsApi : PetShopApiClientBase, IClientsApi
{
    /// <summary>
    /// Initializes a new instance of the <see cref="ClientsApi"/> class.
    /// </summary>
    /// <param name="httpClient"> HttpClient to be used for calls. </param>
    /// <param name="basePath"> Base url to be used for calls. </param>
    public ClientsApi(HttpClient httpClient, String basePath="https://keycloak.example.com/admin/realms") : base(httpClient, basePath)
    {
    }

    /// <inheritdoc />     
    public async Task DeleteClientByRealmById(string realm, string id, CancellationToken ct)
    {
        // verify the required parameter 'realm' is set
        if (realm == null) throw new PetShopApiException(400, "Missing required parameter 'realm' when calling DeleteClientByRealmById");
        // verify the required parameter 'id' is set
        if (id == null) throw new PetShopApiException(400, "Missing required parameter 'id' when calling DeleteClientByRealmById");
        
        var path_ = new StringBuilder("/{realm}/clients/{id}"); 
        path_ = path_.Replace("{realm}", ParameterToString(realm));
        path_ = path_.Replace("{id}", ParameterToString(id));

        
        
        await CallApi(
                    path_.ToString(), 
                    HttpMethod.Delete,  
                    ct: ct
        );
    }

    /// <inheritdoc />     
    public async Task DeleteDefaultClientScope(string realm, string id, string clientScopeId, CancellationToken ct)
    {
        // verify the required parameter 'realm' is set
        if (realm == null) throw new PetShopApiException(400, "Missing required parameter 'realm' when calling DeleteDefaultClientScope");
        // verify the required parameter 'id' is set
        if (id == null) throw new PetShopApiException(400, "Missing required parameter 'id' when calling DeleteDefaultClientScope");
        // verify the required parameter 'clientScopeId' is set
        if (clientScopeId == null) throw new PetShopApiException(400, "Missing required parameter 'clientScopeId' when calling DeleteDefaultClientScope");
        
        var path_ = new StringBuilder("/{realm}/clients/{id}/default-client-scopes/{clientScopeId}"); 
        path_ = path_.Replace("{realm}", ParameterToString(realm));
        path_ = path_.Replace("{id}", ParameterToString(id));
        path_ = path_.Replace("{clientScopeId}", ParameterToString(clientScopeId));

        
        
        await CallApi(
                    path_.ToString(), 
                    HttpMethod.Delete,  
                    ct: ct
        );
    }

    /// <inheritdoc />     
    public async Task DeleteNode(string realm, string id, string node, CancellationToken ct)
    {
        // verify the required parameter 'realm' is set
        if (realm == null) throw new PetShopApiException(400, "Missing required parameter 'realm' when calling DeleteNode");
        // verify the required parameter 'id' is set
        if (id == null) throw new PetShopApiException(400, "Missing required parameter 'id' when calling DeleteNode");
        // verify the required parameter 'node' is set
        if (node == null) throw new PetShopApiException(400, "Missing required parameter 'node' when calling DeleteNode");
        
        var path_ = new StringBuilder("/{realm}/clients/{id}/nodes/{node}"); 
        path_ = path_.Replace("{realm}", ParameterToString(realm));
        path_ = path_.Replace("{id}", ParameterToString(id));
        path_ = path_.Replace("{node}", ParameterToString(node));

        
        
        await CallApi(
                    path_.ToString(), 
                    HttpMethod.Delete,  
                    ct: ct
        );
    }

    /// <inheritdoc />     
    public async Task DeleteOptionalClientScope(string realm, string id, string clientScopeId, CancellationToken ct)
    {
        // verify the required parameter 'realm' is set
        if (realm == null) throw new PetShopApiException(400, "Missing required parameter 'realm' when calling DeleteOptionalClientScope");
        // verify the required parameter 'id' is set
        if (id == null) throw new PetShopApiException(400, "Missing required parameter 'id' when calling DeleteOptionalClientScope");
        // verify the required parameter 'clientScopeId' is set
        if (clientScopeId == null) throw new PetShopApiException(400, "Missing required parameter 'clientScopeId' when calling DeleteOptionalClientScope");
        
        var path_ = new StringBuilder("/{realm}/clients/{id}/optional-client-scopes/{clientScopeId}"); 
        path_ = path_.Replace("{realm}", ParameterToString(realm));
        path_ = path_.Replace("{id}", ParameterToString(id));
        path_ = path_.Replace("{clientScopeId}", ParameterToString(clientScopeId));

        
        
        await CallApi(
                    path_.ToString(), 
                    HttpMethod.Delete,  
                    ct: ct
        );
    }

    /// <inheritdoc />     
    public async Task DeleteRotated(string realm, string id, CancellationToken ct)
    {
        // verify the required parameter 'realm' is set
        if (realm == null) throw new PetShopApiException(400, "Missing required parameter 'realm' when calling DeleteRotated");
        // verify the required parameter 'id' is set
        if (id == null) throw new PetShopApiException(400, "Missing required parameter 'id' when calling DeleteRotated");
        
        var path_ = new StringBuilder("/{realm}/clients/{id}/client-secret/rotated"); 
        path_ = path_.Replace("{realm}", ParameterToString(realm));
        path_ = path_.Replace("{id}", ParameterToString(id));

        
        
        await CallApi(
                    path_.ToString(), 
                    HttpMethod.Delete,  
                    ct: ct
        );
    }

    /// <inheritdoc />     
    public async Task<ClientRepresentation> GetClientByRealmById(string realm, string id, CancellationToken ct)
    {
        // verify the required parameter 'realm' is set
        if (realm == null) throw new PetShopApiException(400, "Missing required parameter 'realm' when calling GetClientByRealmById");
        // verify the required parameter 'id' is set
        if (id == null) throw new PetShopApiException(400, "Missing required parameter 'id' when calling GetClientByRealmById");
        
        var path_ = new StringBuilder("/{realm}/clients/{id}"); 
        path_ = path_.Replace("{realm}", ParameterToString(realm));
        path_ = path_.Replace("{id}", ParameterToString(id));

        
        
        var response = await CallApi<ClientRepresentation>(
                    path_.ToString(), 
                    HttpMethod.Get,  
                    ct: ct
        );
        return response;
    }

    /// <inheritdoc />     
    public async Task<ManagementPermissionReference> GetClientManagementPermissions(string realm, string id, CancellationToken ct)
    {
        // verify the required parameter 'realm' is set
        if (realm == null) throw new PetShopApiException(400, "Missing required parameter 'realm' when calling GetClientManagementPermissions");
        // verify the required parameter 'id' is set
        if (id == null) throw new PetShopApiException(400, "Missing required parameter 'id' when calling GetClientManagementPermissions");
        
        var path_ = new StringBuilder("/{realm}/clients/{id}/management/permissions"); 
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
    public async Task<CredentialRepresentation> GetClientSecret(string realm, string id, CancellationToken ct)
    {
        // verify the required parameter 'realm' is set
        if (realm == null) throw new PetShopApiException(400, "Missing required parameter 'realm' when calling GetClientSecret");
        // verify the required parameter 'id' is set
        if (id == null) throw new PetShopApiException(400, "Missing required parameter 'id' when calling GetClientSecret");
        
        var path_ = new StringBuilder("/{realm}/clients/{id}/client-secret"); 
        path_ = path_.Replace("{realm}", ParameterToString(realm));
        path_ = path_.Replace("{id}", ParameterToString(id));

        
        
        var response = await CallApi<CredentialRepresentation>(
                    path_.ToString(), 
                    HttpMethod.Get,  
                    ct: ct
        );
        return response;
    }

    /// <inheritdoc />     
    public async Task<List<UserSessionRepresentation>> GetClientUserSessions(string realm, string id, string first, string max, CancellationToken ct)
    {
        // verify the required parameter 'realm' is set
        if (realm == null) throw new PetShopApiException(400, "Missing required parameter 'realm' when calling GetClientUserSessions");
        // verify the required parameter 'id' is set
        if (id == null) throw new PetShopApiException(400, "Missing required parameter 'id' when calling GetClientUserSessions");
        
        var path_ = new StringBuilder("/{realm}/clients/{id}/user-sessions"); 
        path_ = path_.Replace("{realm}", ParameterToString(realm));
        path_ = path_.Replace("{id}", ParameterToString(id));

        var queryParams = new Dictionary<string, string>();
         
        if (first != null) queryParams.Add("first", ParameterToString(first)); // query parameter 
        if (max != null) queryParams.Add("max", ParameterToString(max)); // query parameter
        
        var response = await CallApi<List<UserSessionRepresentation>>(
                    path_.ToString(), 
                    HttpMethod.Get,
                    queryParams: queryParams,  
                    ct: ct
        );
        return response;
    }

    /// <inheritdoc />     
    public async Task<List<ClientRepresentation>> GetClients(string realm, string clientId, string first, string max, string q, string search, string viewableOnly, CancellationToken ct)
    {
        // verify the required parameter 'realm' is set
        if (realm == null) throw new PetShopApiException(400, "Missing required parameter 'realm' when calling GetClients");
        
        var path_ = new StringBuilder("/{realm}/clients"); 
        path_ = path_.Replace("{realm}", ParameterToString(realm));

        var queryParams = new Dictionary<string, string>();
         
        if (clientId != null) queryParams.Add("clientId", ParameterToString(clientId)); // query parameter 
        if (first != null) queryParams.Add("first", ParameterToString(first)); // query parameter 
        if (max != null) queryParams.Add("max", ParameterToString(max)); // query parameter 
        if (q != null) queryParams.Add("q", ParameterToString(q)); // query parameter 
        if (search != null) queryParams.Add("search", ParameterToString(search)); // query parameter 
        if (viewableOnly != null) queryParams.Add("viewableOnly", ParameterToString(viewableOnly)); // query parameter
        
        var response = await CallApi<List<ClientRepresentation>>(
                    path_.ToString(), 
                    HttpMethod.Get,
                    queryParams: queryParams,  
                    ct: ct
        );
        return response;
    }

    /// <inheritdoc />     
    public async Task<List<ClientScopeRepresentation>> GetDefaultClientScopes(string realm, string id, CancellationToken ct)
    {
        // verify the required parameter 'realm' is set
        if (realm == null) throw new PetShopApiException(400, "Missing required parameter 'realm' when calling GetDefaultClientScopes");
        // verify the required parameter 'id' is set
        if (id == null) throw new PetShopApiException(400, "Missing required parameter 'id' when calling GetDefaultClientScopes");
        
        var path_ = new StringBuilder("/{realm}/clients/{id}/default-client-scopes"); 
        path_ = path_.Replace("{realm}", ParameterToString(realm));
        path_ = path_.Replace("{id}", ParameterToString(id));

        
        
        var response = await CallApi<List<ClientScopeRepresentation>>(
                    path_.ToString(), 
                    HttpMethod.Get,  
                    ct: ct
        );
        return response;
    }

    /// <inheritdoc />     
    public async Task<AccessToken> GetGenerateExampleAccessToken(string realm, string id, string scope, string userId, CancellationToken ct)
    {
        // verify the required parameter 'realm' is set
        if (realm == null) throw new PetShopApiException(400, "Missing required parameter 'realm' when calling GetGenerateExampleAccessToken");
        // verify the required parameter 'id' is set
        if (id == null) throw new PetShopApiException(400, "Missing required parameter 'id' when calling GetGenerateExampleAccessToken");
        
        var path_ = new StringBuilder("/{realm}/clients/{id}/evaluate-scopes/generate-example-access-token"); 
        path_ = path_.Replace("{realm}", ParameterToString(realm));
        path_ = path_.Replace("{id}", ParameterToString(id));

        var queryParams = new Dictionary<string, string>();
         
        if (scope != null) queryParams.Add("scope", ParameterToString(scope)); // query parameter 
        if (userId != null) queryParams.Add("userId", ParameterToString(userId)); // query parameter
        
        var response = await CallApi<AccessToken>(
                    path_.ToString(), 
                    HttpMethod.Get,
                    queryParams: queryParams,  
                    ct: ct
        );
        return response;
    }

    /// <inheritdoc />     
    public async Task<IDToken> GetGenerateExampleIdToken(string realm, string id, string scope, string userId, CancellationToken ct)
    {
        // verify the required parameter 'realm' is set
        if (realm == null) throw new PetShopApiException(400, "Missing required parameter 'realm' when calling GetGenerateExampleIdToken");
        // verify the required parameter 'id' is set
        if (id == null) throw new PetShopApiException(400, "Missing required parameter 'id' when calling GetGenerateExampleIdToken");
        
        var path_ = new StringBuilder("/{realm}/clients/{id}/evaluate-scopes/generate-example-id-token"); 
        path_ = path_.Replace("{realm}", ParameterToString(realm));
        path_ = path_.Replace("{id}", ParameterToString(id));

        var queryParams = new Dictionary<string, string>();
         
        if (scope != null) queryParams.Add("scope", ParameterToString(scope)); // query parameter 
        if (userId != null) queryParams.Add("userId", ParameterToString(userId)); // query parameter
        
        var response = await CallApi<IDToken>(
                    path_.ToString(), 
                    HttpMethod.Get,
                    queryParams: queryParams,  
                    ct: ct
        );
        return response;
    }

    /// <inheritdoc />     
    public async Task<Dictionary<string, Object>> GetGenerateExampleUserinfo(string realm, string id, string scope, string userId, CancellationToken ct)
    {
        // verify the required parameter 'realm' is set
        if (realm == null) throw new PetShopApiException(400, "Missing required parameter 'realm' when calling GetGenerateExampleUserinfo");
        // verify the required parameter 'id' is set
        if (id == null) throw new PetShopApiException(400, "Missing required parameter 'id' when calling GetGenerateExampleUserinfo");
        
        var path_ = new StringBuilder("/{realm}/clients/{id}/evaluate-scopes/generate-example-userinfo"); 
        path_ = path_.Replace("{realm}", ParameterToString(realm));
        path_ = path_.Replace("{id}", ParameterToString(id));

        var queryParams = new Dictionary<string, string>();
         
        if (scope != null) queryParams.Add("scope", ParameterToString(scope)); // query parameter 
        if (userId != null) queryParams.Add("userId", ParameterToString(userId)); // query parameter
        
        var response = await CallApi<Dictionary<string, Object>>(
                    path_.ToString(), 
                    HttpMethod.Get,
                    queryParams: queryParams,  
                    ct: ct
        );
        return response;
    }

    /// <inheritdoc />     
    public async Task<List<RoleRepresentation>> GetGranted(string realm, string id, string roleContainerId, string scope, CancellationToken ct)
    {
        // verify the required parameter 'realm' is set
        if (realm == null) throw new PetShopApiException(400, "Missing required parameter 'realm' when calling GetGranted");
        // verify the required parameter 'id' is set
        if (id == null) throw new PetShopApiException(400, "Missing required parameter 'id' when calling GetGranted");
        // verify the required parameter 'roleContainerId' is set
        if (roleContainerId == null) throw new PetShopApiException(400, "Missing required parameter 'roleContainerId' when calling GetGranted");
        
        var path_ = new StringBuilder("/{realm}/clients/{id}/evaluate-scopes/scope-mappings/{roleContainerId}/granted"); 
        path_ = path_.Replace("{realm}", ParameterToString(realm));
        path_ = path_.Replace("{id}", ParameterToString(id));
        path_ = path_.Replace("{roleContainerId}", ParameterToString(roleContainerId));

        var queryParams = new Dictionary<string, string>();
         
        if (scope != null) queryParams.Add("scope", ParameterToString(scope)); // query parameter
        
        var response = await CallApi<List<RoleRepresentation>>(
                    path_.ToString(), 
                    HttpMethod.Get,
                    queryParams: queryParams,  
                    ct: ct
        );
        return response;
    }

    /// <inheritdoc />     
    public async Task GetInstallationProvider(string realm, string id, string providerId, CancellationToken ct)
    {
        // verify the required parameter 'realm' is set
        if (realm == null) throw new PetShopApiException(400, "Missing required parameter 'realm' when calling GetInstallationProvider");
        // verify the required parameter 'id' is set
        if (id == null) throw new PetShopApiException(400, "Missing required parameter 'id' when calling GetInstallationProvider");
        // verify the required parameter 'providerId' is set
        if (providerId == null) throw new PetShopApiException(400, "Missing required parameter 'providerId' when calling GetInstallationProvider");
        
        var path_ = new StringBuilder("/{realm}/clients/{id}/installation/providers/{providerId}"); 
        path_ = path_.Replace("{realm}", ParameterToString(realm));
        path_ = path_.Replace("{id}", ParameterToString(id));
        path_ = path_.Replace("{providerId}", ParameterToString(providerId));

        
        
        await CallApi(
                    path_.ToString(), 
                    HttpMethod.Get,  
                    ct: ct
        );
    }

    /// <inheritdoc />     
    public async Task<List<RoleRepresentation>> GetNotGranted(string realm, string id, string roleContainerId, string scope, CancellationToken ct)
    {
        // verify the required parameter 'realm' is set
        if (realm == null) throw new PetShopApiException(400, "Missing required parameter 'realm' when calling GetNotGranted");
        // verify the required parameter 'id' is set
        if (id == null) throw new PetShopApiException(400, "Missing required parameter 'id' when calling GetNotGranted");
        // verify the required parameter 'roleContainerId' is set
        if (roleContainerId == null) throw new PetShopApiException(400, "Missing required parameter 'roleContainerId' when calling GetNotGranted");
        
        var path_ = new StringBuilder("/{realm}/clients/{id}/evaluate-scopes/scope-mappings/{roleContainerId}/not-granted"); 
        path_ = path_.Replace("{realm}", ParameterToString(realm));
        path_ = path_.Replace("{id}", ParameterToString(id));
        path_ = path_.Replace("{roleContainerId}", ParameterToString(roleContainerId));

        var queryParams = new Dictionary<string, string>();
         
        if (scope != null) queryParams.Add("scope", ParameterToString(scope)); // query parameter
        
        var response = await CallApi<List<RoleRepresentation>>(
                    path_.ToString(), 
                    HttpMethod.Get,
                    queryParams: queryParams,  
                    ct: ct
        );
        return response;
    }

    /// <inheritdoc />     
    public async Task<Dictionary<string, long?>> GetOfflineSessionCount(string realm, string id, CancellationToken ct)
    {
        // verify the required parameter 'realm' is set
        if (realm == null) throw new PetShopApiException(400, "Missing required parameter 'realm' when calling GetOfflineSessionCount");
        // verify the required parameter 'id' is set
        if (id == null) throw new PetShopApiException(400, "Missing required parameter 'id' when calling GetOfflineSessionCount");
        
        var path_ = new StringBuilder("/{realm}/clients/{id}/offline-session-count"); 
        path_ = path_.Replace("{realm}", ParameterToString(realm));
        path_ = path_.Replace("{id}", ParameterToString(id));

        
        
        var response = await CallApi<Dictionary<string, long?>>(
                    path_.ToString(), 
                    HttpMethod.Get,  
                    ct: ct
        );
        return response;
    }

    /// <inheritdoc />     
    public async Task<List<UserSessionRepresentation>> GetOfflineSessions(string realm, string id, string first, string max, CancellationToken ct)
    {
        // verify the required parameter 'realm' is set
        if (realm == null) throw new PetShopApiException(400, "Missing required parameter 'realm' when calling GetOfflineSessions");
        // verify the required parameter 'id' is set
        if (id == null) throw new PetShopApiException(400, "Missing required parameter 'id' when calling GetOfflineSessions");
        
        var path_ = new StringBuilder("/{realm}/clients/{id}/offline-sessions"); 
        path_ = path_.Replace("{realm}", ParameterToString(realm));
        path_ = path_.Replace("{id}", ParameterToString(id));

        var queryParams = new Dictionary<string, string>();
         
        if (first != null) queryParams.Add("first", ParameterToString(first)); // query parameter 
        if (max != null) queryParams.Add("max", ParameterToString(max)); // query parameter
        
        var response = await CallApi<List<UserSessionRepresentation>>(
                    path_.ToString(), 
                    HttpMethod.Get,
                    queryParams: queryParams,  
                    ct: ct
        );
        return response;
    }

    /// <inheritdoc />     
    public async Task<List<ClientScopeRepresentation>> GetOptionalClientScopes(string realm, string id, CancellationToken ct)
    {
        // verify the required parameter 'realm' is set
        if (realm == null) throw new PetShopApiException(400, "Missing required parameter 'realm' when calling GetOptionalClientScopes");
        // verify the required parameter 'id' is set
        if (id == null) throw new PetShopApiException(400, "Missing required parameter 'id' when calling GetOptionalClientScopes");
        
        var path_ = new StringBuilder("/{realm}/clients/{id}/optional-client-scopes"); 
        path_ = path_.Replace("{realm}", ParameterToString(realm));
        path_ = path_.Replace("{id}", ParameterToString(id));

        
        
        var response = await CallApi<List<ClientScopeRepresentation>>(
                    path_.ToString(), 
                    HttpMethod.Get,  
                    ct: ct
        );
        return response;
    }

    /// <inheritdoc />     
    public async Task<List<ProtocolMapperEvaluationRepresentation>> GetProtocolMappers(string realm, string id, string scope, CancellationToken ct)
    {
        // verify the required parameter 'realm' is set
        if (realm == null) throw new PetShopApiException(400, "Missing required parameter 'realm' when calling GetProtocolMappers");
        // verify the required parameter 'id' is set
        if (id == null) throw new PetShopApiException(400, "Missing required parameter 'id' when calling GetProtocolMappers");
        
        var path_ = new StringBuilder("/{realm}/clients/{id}/evaluate-scopes/protocol-mappers"); 
        path_ = path_.Replace("{realm}", ParameterToString(realm));
        path_ = path_.Replace("{id}", ParameterToString(id));

        var queryParams = new Dictionary<string, string>();
         
        if (scope != null) queryParams.Add("scope", ParameterToString(scope)); // query parameter
        
        var response = await CallApi<List<ProtocolMapperEvaluationRepresentation>>(
                    path_.ToString(), 
                    HttpMethod.Get,
                    queryParams: queryParams,  
                    ct: ct
        );
        return response;
    }

    /// <inheritdoc />     
    public async Task<CredentialRepresentation> GetRotated(string realm, string id, CancellationToken ct)
    {
        // verify the required parameter 'realm' is set
        if (realm == null) throw new PetShopApiException(400, "Missing required parameter 'realm' when calling GetRotated");
        // verify the required parameter 'id' is set
        if (id == null) throw new PetShopApiException(400, "Missing required parameter 'id' when calling GetRotated");
        
        var path_ = new StringBuilder("/{realm}/clients/{id}/client-secret/rotated"); 
        path_ = path_.Replace("{realm}", ParameterToString(realm));
        path_ = path_.Replace("{id}", ParameterToString(id));

        
        
        var response = await CallApi<CredentialRepresentation>(
                    path_.ToString(), 
                    HttpMethod.Get,  
                    ct: ct
        );
        return response;
    }

    /// <inheritdoc />     
    public async Task<UserRepresentation> GetServiceAccountUser(string realm, string id, CancellationToken ct)
    {
        // verify the required parameter 'realm' is set
        if (realm == null) throw new PetShopApiException(400, "Missing required parameter 'realm' when calling GetServiceAccountUser");
        // verify the required parameter 'id' is set
        if (id == null) throw new PetShopApiException(400, "Missing required parameter 'id' when calling GetServiceAccountUser");
        
        var path_ = new StringBuilder("/{realm}/clients/{id}/service-account-user"); 
        path_ = path_.Replace("{realm}", ParameterToString(realm));
        path_ = path_.Replace("{id}", ParameterToString(id));

        
        
        var response = await CallApi<UserRepresentation>(
                    path_.ToString(), 
                    HttpMethod.Get,  
                    ct: ct
        );
        return response;
    }

    /// <inheritdoc />     
    public async Task<Dictionary<string, long?>> GetSessionCount(string realm, string id, CancellationToken ct)
    {
        // verify the required parameter 'realm' is set
        if (realm == null) throw new PetShopApiException(400, "Missing required parameter 'realm' when calling GetSessionCount");
        // verify the required parameter 'id' is set
        if (id == null) throw new PetShopApiException(400, "Missing required parameter 'id' when calling GetSessionCount");
        
        var path_ = new StringBuilder("/{realm}/clients/{id}/session-count"); 
        path_ = path_.Replace("{realm}", ParameterToString(realm));
        path_ = path_.Replace("{id}", ParameterToString(id));

        
        
        var response = await CallApi<Dictionary<string, long?>>(
                    path_.ToString(), 
                    HttpMethod.Get,  
                    ct: ct
        );
        return response;
    }

    /// <inheritdoc />     
    public async Task<GlobalRequestResult> GetTestNodesAvailable(string realm, string id, CancellationToken ct)
    {
        // verify the required parameter 'realm' is set
        if (realm == null) throw new PetShopApiException(400, "Missing required parameter 'realm' when calling GetTestNodesAvailable");
        // verify the required parameter 'id' is set
        if (id == null) throw new PetShopApiException(400, "Missing required parameter 'id' when calling GetTestNodesAvailable");
        
        var path_ = new StringBuilder("/{realm}/clients/{id}/test-nodes-available"); 
        path_ = path_.Replace("{realm}", ParameterToString(realm));
        path_ = path_.Replace("{id}", ParameterToString(id));

        
        
        var response = await CallApi<GlobalRequestResult>(
                    path_.ToString(), 
                    HttpMethod.Get,  
                    ct: ct
        );
        return response;
    }

    /// <inheritdoc />     
    public async Task<GlobalRequestResult> PostClientPushRevocation(string realm, string id, CancellationToken ct)
    {
        // verify the required parameter 'realm' is set
        if (realm == null) throw new PetShopApiException(400, "Missing required parameter 'realm' when calling PostClientPushRevocation");
        // verify the required parameter 'id' is set
        if (id == null) throw new PetShopApiException(400, "Missing required parameter 'id' when calling PostClientPushRevocation");
        
        var path_ = new StringBuilder("/{realm}/clients/{id}/push-revocation"); 
        path_ = path_.Replace("{realm}", ParameterToString(realm));
        path_ = path_.Replace("{id}", ParameterToString(id));

        
        
        var response = await CallApi<GlobalRequestResult>(
                    path_.ToString(), 
                    HttpMethod.Post,  
                    ct: ct
        );
        return response;
    }

    /// <inheritdoc />     
    public async Task<CredentialRepresentation> PostClientSecret(string realm, string id, CancellationToken ct)
    {
        // verify the required parameter 'realm' is set
        if (realm == null) throw new PetShopApiException(400, "Missing required parameter 'realm' when calling PostClientSecret");
        // verify the required parameter 'id' is set
        if (id == null) throw new PetShopApiException(400, "Missing required parameter 'id' when calling PostClientSecret");
        
        var path_ = new StringBuilder("/{realm}/clients/{id}/client-secret"); 
        path_ = path_.Replace("{realm}", ParameterToString(realm));
        path_ = path_.Replace("{id}", ParameterToString(id));

        
        
        var response = await CallApi<CredentialRepresentation>(
                    path_.ToString(), 
                    HttpMethod.Post,  
                    ct: ct
        );
        return response;
    }

    /// <inheritdoc />     
    public async Task PostClients(string realm, ClientRepresentation body, CancellationToken ct)
    {
        // verify the required parameter 'realm' is set
        if (realm == null) throw new PetShopApiException(400, "Missing required parameter 'realm' when calling PostClients");
        
        var path_ = new StringBuilder("/{realm}/clients"); 
        path_ = path_.Replace("{realm}", ParameterToString(realm));

        
        
        await CallApi(
                    path_.ToString(), 
                    HttpMethod.Post,
                    body: body,   
                    ct: ct
        );
    }

    /// <inheritdoc />     
    public async Task PostNodes(string realm, string id, string body, CancellationToken ct)
    {
        // verify the required parameter 'realm' is set
        if (realm == null) throw new PetShopApiException(400, "Missing required parameter 'realm' when calling PostNodes");
        // verify the required parameter 'id' is set
        if (id == null) throw new PetShopApiException(400, "Missing required parameter 'id' when calling PostNodes");
        
        var path_ = new StringBuilder("/{realm}/clients/{id}/nodes"); 
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
    public async Task<ClientRepresentation> PostRegistrationAccessToken(string realm, string id, CancellationToken ct)
    {
        // verify the required parameter 'realm' is set
        if (realm == null) throw new PetShopApiException(400, "Missing required parameter 'realm' when calling PostRegistrationAccessToken");
        // verify the required parameter 'id' is set
        if (id == null) throw new PetShopApiException(400, "Missing required parameter 'id' when calling PostRegistrationAccessToken");
        
        var path_ = new StringBuilder("/{realm}/clients/{id}/registration-access-token"); 
        path_ = path_.Replace("{realm}", ParameterToString(realm));
        path_ = path_.Replace("{id}", ParameterToString(id));

        
        
        var response = await CallApi<ClientRepresentation>(
                    path_.ToString(), 
                    HttpMethod.Post,  
                    ct: ct
        );
        return response;
    }

    /// <inheritdoc />     
    public async Task PutClient(string realm, string id, ClientRepresentation body, CancellationToken ct)
    {
        // verify the required parameter 'realm' is set
        if (realm == null) throw new PetShopApiException(400, "Missing required parameter 'realm' when calling PutClient");
        // verify the required parameter 'id' is set
        if (id == null) throw new PetShopApiException(400, "Missing required parameter 'id' when calling PutClient");
        
        var path_ = new StringBuilder("/{realm}/clients/{id}"); 
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
    public async Task<ManagementPermissionReference> PutClientManagementPermissions(string realm, string id, ManagementPermissionReference body, CancellationToken ct)
    {
        // verify the required parameter 'realm' is set
        if (realm == null) throw new PetShopApiException(400, "Missing required parameter 'realm' when calling PutClientManagementPermissions");
        // verify the required parameter 'id' is set
        if (id == null) throw new PetShopApiException(400, "Missing required parameter 'id' when calling PutClientManagementPermissions");
        
        var path_ = new StringBuilder("/{realm}/clients/{id}/management/permissions"); 
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

    /// <inheritdoc />     
    public async Task PutDefaultClientScope(string realm, string id, string clientScopeId, CancellationToken ct)
    {
        // verify the required parameter 'realm' is set
        if (realm == null) throw new PetShopApiException(400, "Missing required parameter 'realm' when calling PutDefaultClientScope");
        // verify the required parameter 'id' is set
        if (id == null) throw new PetShopApiException(400, "Missing required parameter 'id' when calling PutDefaultClientScope");
        // verify the required parameter 'clientScopeId' is set
        if (clientScopeId == null) throw new PetShopApiException(400, "Missing required parameter 'clientScopeId' when calling PutDefaultClientScope");
        
        var path_ = new StringBuilder("/{realm}/clients/{id}/default-client-scopes/{clientScopeId}"); 
        path_ = path_.Replace("{realm}", ParameterToString(realm));
        path_ = path_.Replace("{id}", ParameterToString(id));
        path_ = path_.Replace("{clientScopeId}", ParameterToString(clientScopeId));

        
        
        await CallApi(
                    path_.ToString(), 
                    HttpMethod.Put,  
                    ct: ct
        );
    }

    /// <inheritdoc />     
    public async Task PutOptionalClientScope(string realm, string id, string clientScopeId, CancellationToken ct)
    {
        // verify the required parameter 'realm' is set
        if (realm == null) throw new PetShopApiException(400, "Missing required parameter 'realm' when calling PutOptionalClientScope");
        // verify the required parameter 'id' is set
        if (id == null) throw new PetShopApiException(400, "Missing required parameter 'id' when calling PutOptionalClientScope");
        // verify the required parameter 'clientScopeId' is set
        if (clientScopeId == null) throw new PetShopApiException(400, "Missing required parameter 'clientScopeId' when calling PutOptionalClientScope");
        
        var path_ = new StringBuilder("/{realm}/clients/{id}/optional-client-scopes/{clientScopeId}"); 
        path_ = path_.Replace("{realm}", ParameterToString(realm));
        path_ = path_.Replace("{id}", ParameterToString(id));
        path_ = path_.Replace("{clientScopeId}", ParameterToString(clientScopeId));

        
        
        await CallApi(
                    path_.ToString(), 
                    HttpMethod.Put,  
                    ct: ct
        );
    }

}
