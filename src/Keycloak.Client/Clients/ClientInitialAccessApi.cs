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
public partial interface IClientInitialAccessApi
{
    /// <summary>
    ///  
    /// </summary>
    /// <param name="realm">realm name (not id!)</param>
    /// <param name="id"></param>
    /// <param name="ct"></param>
    /// <returns></returns>
    Task DeleteClientsInitialAcces (string realm, string id, CancellationToken ct);
    /// <summary>
    ///  
    /// </summary>
    /// <param name="realm">realm name (not id!)</param>
    /// <param name="ct"></param>
    /// <returns>List&lt;ClientInitialAccessPresentation&gt;</returns>
    Task<List<ClientInitialAccessPresentation>> GetClientsInitialAccess (string realm, CancellationToken ct);
    /// <summary>
    ///  Create a new initial access token.
    /// </summary>
    /// <param name="realm">realm name (not id!)</param>
    /// <param name="body">ClientInitialAccessCreatePresentation</param>
    /// <param name="ct"></param>
    /// <returns>ClientInitialAccessPresentation</returns>
    Task<ClientInitialAccessPresentation> PostClientsInitialAccess (string realm, ClientInitialAccessCreatePresentation body, CancellationToken ct);
}

/// <summary>
/// Represents a collection of functions to interact with the API endpoints
/// </summary>  
[GeneratedCode("swagger-codegen", "3.0.56-SNAPSHOT")]
public partial class ClientInitialAccessApi : PetShopApiClientBase, IClientInitialAccessApi
{
    /// <summary>
    /// Initializes a new instance of the <see cref="ClientInitialAccessApi"/> class.
    /// </summary>
    /// <param name="httpClient"> HttpClient to be used for calls. </param>
    /// <param name="basePath"> Base url to be used for calls. </param>
    public ClientInitialAccessApi(HttpClient httpClient, String basePath="https://keycloak.example.com/admin/realms") : base(httpClient, basePath)
    {
    }

    /// <inheritdoc />     
    public async Task DeleteClientsInitialAcces(string realm, string id, CancellationToken ct)
    {
        // verify the required parameter 'realm' is set
        if (realm == null) throw new PetShopApiException(400, "Missing required parameter 'realm' when calling DeleteClientsInitialAcces");
        // verify the required parameter 'id' is set
        if (id == null) throw new PetShopApiException(400, "Missing required parameter 'id' when calling DeleteClientsInitialAcces");
        
        var path_ = new StringBuilder("/{realm}/clients-initial-access/{id}"); 
        path_ = path_.Replace("{realm}", ParameterToString(realm));
        path_ = path_.Replace("{id}", ParameterToString(id));

        
        
        await CallApi(
                    path_.ToString(), 
                    HttpMethod.Delete,  
                    ct: ct
        );
    }

    /// <inheritdoc />     
    public async Task<List<ClientInitialAccessPresentation>> GetClientsInitialAccess(string realm, CancellationToken ct)
    {
        // verify the required parameter 'realm' is set
        if (realm == null) throw new PetShopApiException(400, "Missing required parameter 'realm' when calling GetClientsInitialAccess");
        
        var path_ = new StringBuilder("/{realm}/clients-initial-access"); 
        path_ = path_.Replace("{realm}", ParameterToString(realm));

        
        
        var response = await CallApi<List<ClientInitialAccessPresentation>>(
                    path_.ToString(), 
                    HttpMethod.Get,  
                    ct: ct
        );
        return response;
    }

    /// <inheritdoc />     
    public async Task<ClientInitialAccessPresentation> PostClientsInitialAccess(string realm, ClientInitialAccessCreatePresentation body, CancellationToken ct)
    {
        // verify the required parameter 'realm' is set
        if (realm == null) throw new PetShopApiException(400, "Missing required parameter 'realm' when calling PostClientsInitialAccess");
        
        var path_ = new StringBuilder("/{realm}/clients-initial-access"); 
        path_ = path_.Replace("{realm}", ParameterToString(realm));

        
        
        var response = await CallApi<ClientInitialAccessPresentation>(
                    path_.ToString(), 
                    HttpMethod.Post,
                    body: body,   
                    ct: ct
        );
        return response;
    }

}
