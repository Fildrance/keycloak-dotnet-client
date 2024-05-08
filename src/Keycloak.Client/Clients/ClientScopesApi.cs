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
public partial interface IClientScopesApi
{
    /// <summary>
    ///  Delete the client scope
    /// </summary>
    /// <param name="realm">realm name (not id!)</param>
    /// <param name="id"></param>
    /// <param name="ct"></param>
    /// <returns></returns>
    Task DeleteClientScope (string realm, string id, CancellationToken ct);
    /// <summary>
    ///  Delete the client scope
    /// </summary>
    /// <param name="realm">realm name (not id!)</param>
    /// <param name="id"></param>
    /// <param name="ct"></param>
    /// <returns></returns>
    Task DeleteClientTemplate (string realm, string id, CancellationToken ct);
    /// <summary>
    ///  Get representation of the client scope
    /// </summary>
    /// <param name="realm">realm name (not id!)</param>
    /// <param name="id"></param>
    /// <param name="ct"></param>
    /// <returns>ClientScopeRepresentation</returns>
    Task<ClientScopeRepresentation> GetClientScope (string realm, string id, CancellationToken ct);
    /// <summary>
    ///  Get client scopes belonging to the realm Returns a list of client scopes belonging to the realm
    /// </summary>
    /// <param name="realm">realm name (not id!)</param>
    /// <param name="ct"></param>
    /// <returns>List&lt;ClientScopeRepresentation&gt;</returns>
    Task<List<ClientScopeRepresentation>> GetClientScopes (string realm, CancellationToken ct);
    /// <summary>
    ///  Get representation of the client scope
    /// </summary>
    /// <param name="realm">realm name (not id!)</param>
    /// <param name="id"></param>
    /// <param name="ct"></param>
    /// <returns>ClientScopeRepresentation</returns>
    Task<ClientScopeRepresentation> GetClientTemplate (string realm, string id, CancellationToken ct);
    /// <summary>
    ///  Get client scopes belonging to the realm Returns a list of client scopes belonging to the realm
    /// </summary>
    /// <param name="realm">realm name (not id!)</param>
    /// <param name="ct"></param>
    /// <returns>List&lt;ClientScopeRepresentation&gt;</returns>
    Task<List<ClientScopeRepresentation>> GetClientTemplates (string realm, CancellationToken ct);
    /// <summary>
    ///  Create a new client scope Client Scope’s name must be unique!
    /// </summary>
    /// <param name="realm">realm name (not id!)</param>
    /// <param name="body">ClientScopeRepresentation</param>
    /// <param name="ct"></param>
    /// <returns></returns>
    Task PostClientScopes (string realm, ClientScopeRepresentation body, CancellationToken ct);
    /// <summary>
    ///  Create a new client scope Client Scope’s name must be unique!
    /// </summary>
    /// <param name="realm">realm name (not id!)</param>
    /// <param name="body">ClientScopeRepresentation</param>
    /// <param name="ct"></param>
    /// <returns></returns>
    Task PostClientTemplates (string realm, ClientScopeRepresentation body, CancellationToken ct);
    /// <summary>
    ///  Update the client scope
    /// </summary>
    /// <param name="realm">realm name (not id!)</param>
    /// <param name="id"></param>
    /// <param name="body">ClientScopeRepresentation</param>
    /// <param name="ct"></param>
    /// <returns></returns>
    Task PutClientScope (string realm, string id, ClientScopeRepresentation body, CancellationToken ct);
    /// <summary>
    ///  Update the client scope
    /// </summary>
    /// <param name="realm">realm name (not id!)</param>
    /// <param name="id"></param>
    /// <param name="body">ClientScopeRepresentation</param>
    /// <param name="ct"></param>
    /// <returns></returns>
    Task PutClientTemplate (string realm, string id, ClientScopeRepresentation body, CancellationToken ct);
}

/// <summary>
/// Represents a collection of functions to interact with the API endpoints
/// </summary>  
[GeneratedCode("swagger-codegen", "3.0.56-SNAPSHOT")]
public partial class ClientScopesApi : PetShopApiClientBase, IClientScopesApi
{
    /// <summary>
    /// Initializes a new instance of the <see cref="ClientScopesApi"/> class.
    /// </summary>
    /// <param name="httpClient"> HttpClient to be used for calls. </param>
    /// <param name="basePath"> Base url to be used for calls. </param>
    public ClientScopesApi(HttpClient httpClient, String basePath="https://keycloak.example.com/admin/realms") : base(httpClient, basePath)
    {
    }

    /// <inheritdoc />     
    public async Task DeleteClientScope(string realm, string id, CancellationToken ct)
    {
        // verify the required parameter 'realm' is set
        if (realm == null) throw new PetShopApiException(400, "Missing required parameter 'realm' when calling DeleteClientScope");
        // verify the required parameter 'id' is set
        if (id == null) throw new PetShopApiException(400, "Missing required parameter 'id' when calling DeleteClientScope");
        
        var path_ = new StringBuilder("/{realm}/client-scopes/{id}"); 
        path_ = path_.Replace("{realm}", ParameterToString(realm));
        path_ = path_.Replace("{id}", ParameterToString(id));

        
        
        await CallApi(
                    path_.ToString(), 
                    HttpMethod.Delete,  
                    ct: ct
        );
    }

    /// <inheritdoc />     
    public async Task DeleteClientTemplate(string realm, string id, CancellationToken ct)
    {
        // verify the required parameter 'realm' is set
        if (realm == null) throw new PetShopApiException(400, "Missing required parameter 'realm' when calling DeleteClientTemplate");
        // verify the required parameter 'id' is set
        if (id == null) throw new PetShopApiException(400, "Missing required parameter 'id' when calling DeleteClientTemplate");
        
        var path_ = new StringBuilder("/{realm}/client-templates/{id}"); 
        path_ = path_.Replace("{realm}", ParameterToString(realm));
        path_ = path_.Replace("{id}", ParameterToString(id));

        
        
        await CallApi(
                    path_.ToString(), 
                    HttpMethod.Delete,  
                    ct: ct
        );
    }

    /// <inheritdoc />     
    public async Task<ClientScopeRepresentation> GetClientScope(string realm, string id, CancellationToken ct)
    {
        // verify the required parameter 'realm' is set
        if (realm == null) throw new PetShopApiException(400, "Missing required parameter 'realm' when calling GetClientScope");
        // verify the required parameter 'id' is set
        if (id == null) throw new PetShopApiException(400, "Missing required parameter 'id' when calling GetClientScope");
        
        var path_ = new StringBuilder("/{realm}/client-scopes/{id}"); 
        path_ = path_.Replace("{realm}", ParameterToString(realm));
        path_ = path_.Replace("{id}", ParameterToString(id));

        
        
        var response = await CallApi<ClientScopeRepresentation>(
                    path_.ToString(), 
                    HttpMethod.Get,  
                    ct: ct
        );
        return response;
    }

    /// <inheritdoc />     
    public async Task<List<ClientScopeRepresentation>> GetClientScopes(string realm, CancellationToken ct)
    {
        // verify the required parameter 'realm' is set
        if (realm == null) throw new PetShopApiException(400, "Missing required parameter 'realm' when calling GetClientScopes");
        
        var path_ = new StringBuilder("/{realm}/client-scopes"); 
        path_ = path_.Replace("{realm}", ParameterToString(realm));

        
        
        var response = await CallApi<List<ClientScopeRepresentation>>(
                    path_.ToString(), 
                    HttpMethod.Get,  
                    ct: ct
        );
        return response;
    }

    /// <inheritdoc />     
    public async Task<ClientScopeRepresentation> GetClientTemplate(string realm, string id, CancellationToken ct)
    {
        // verify the required parameter 'realm' is set
        if (realm == null) throw new PetShopApiException(400, "Missing required parameter 'realm' when calling GetClientTemplate");
        // verify the required parameter 'id' is set
        if (id == null) throw new PetShopApiException(400, "Missing required parameter 'id' when calling GetClientTemplate");
        
        var path_ = new StringBuilder("/{realm}/client-templates/{id}"); 
        path_ = path_.Replace("{realm}", ParameterToString(realm));
        path_ = path_.Replace("{id}", ParameterToString(id));

        
        
        var response = await CallApi<ClientScopeRepresentation>(
                    path_.ToString(), 
                    HttpMethod.Get,  
                    ct: ct
        );
        return response;
    }

    /// <inheritdoc />     
    public async Task<List<ClientScopeRepresentation>> GetClientTemplates(string realm, CancellationToken ct)
    {
        // verify the required parameter 'realm' is set
        if (realm == null) throw new PetShopApiException(400, "Missing required parameter 'realm' when calling GetClientTemplates");
        
        var path_ = new StringBuilder("/{realm}/client-templates"); 
        path_ = path_.Replace("{realm}", ParameterToString(realm));

        
        
        var response = await CallApi<List<ClientScopeRepresentation>>(
                    path_.ToString(), 
                    HttpMethod.Get,  
                    ct: ct
        );
        return response;
    }

    /// <inheritdoc />     
    public async Task PostClientScopes(string realm, ClientScopeRepresentation body, CancellationToken ct)
    {
        // verify the required parameter 'realm' is set
        if (realm == null) throw new PetShopApiException(400, "Missing required parameter 'realm' when calling PostClientScopes");
        
        var path_ = new StringBuilder("/{realm}/client-scopes"); 
        path_ = path_.Replace("{realm}", ParameterToString(realm));

        
        
        await CallApi(
                    path_.ToString(), 
                    HttpMethod.Post,
                    body: body,   
                    ct: ct
        );
    }

    /// <inheritdoc />     
    public async Task PostClientTemplates(string realm, ClientScopeRepresentation body, CancellationToken ct)
    {
        // verify the required parameter 'realm' is set
        if (realm == null) throw new PetShopApiException(400, "Missing required parameter 'realm' when calling PostClientTemplates");
        
        var path_ = new StringBuilder("/{realm}/client-templates"); 
        path_ = path_.Replace("{realm}", ParameterToString(realm));

        
        
        await CallApi(
                    path_.ToString(), 
                    HttpMethod.Post,
                    body: body,   
                    ct: ct
        );
    }

    /// <inheritdoc />     
    public async Task PutClientScope(string realm, string id, ClientScopeRepresentation body, CancellationToken ct)
    {
        // verify the required parameter 'realm' is set
        if (realm == null) throw new PetShopApiException(400, "Missing required parameter 'realm' when calling PutClientScope");
        // verify the required parameter 'id' is set
        if (id == null) throw new PetShopApiException(400, "Missing required parameter 'id' when calling PutClientScope");
        
        var path_ = new StringBuilder("/{realm}/client-scopes/{id}"); 
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
    public async Task PutClientTemplate(string realm, string id, ClientScopeRepresentation body, CancellationToken ct)
    {
        // verify the required parameter 'realm' is set
        if (realm == null) throw new PetShopApiException(400, "Missing required parameter 'realm' when calling PutClientTemplate");
        // verify the required parameter 'id' is set
        if (id == null) throw new PetShopApiException(400, "Missing required parameter 'id' when calling PutClientTemplate");
        
        var path_ = new StringBuilder("/{realm}/client-templates/{id}"); 
        path_ = path_.Replace("{realm}", ParameterToString(realm));
        path_ = path_.Replace("{id}", ParameterToString(id));

        
        
        await CallApi(
                    path_.ToString(), 
                    HttpMethod.Put,
                    body: body,   
                    ct: ct
        );
    }

}
