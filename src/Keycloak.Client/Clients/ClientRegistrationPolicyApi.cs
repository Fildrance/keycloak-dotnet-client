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
public partial interface IClientRegistrationPolicyApi
{
    /// <summary>
    ///  Base path for retrieve providers with the configProperties properly filled
    /// </summary>
    /// <param name="realm">realm name (not id!)</param>
    /// <param name="ct"></param>
    /// <returns>List&lt;ComponentTypeRepresentation&gt;</returns>
    Task<List<ComponentTypeRepresentation>> GetProviders (string realm, CancellationToken ct);
}

/// <summary>
/// Represents a collection of functions to interact with the API endpoints
/// </summary>  
[GeneratedCode("swagger-codegen", "3.0.56-SNAPSHOT")]
public partial class ClientRegistrationPolicyApi : PetShopApiClientBase, IClientRegistrationPolicyApi
{
    /// <summary>
    /// Initializes a new instance of the <see cref="ClientRegistrationPolicyApi"/> class.
    /// </summary>
    /// <param name="httpClient"> HttpClient to be used for calls. </param>
    /// <param name="basePath"> Base url to be used for calls. </param>
    public ClientRegistrationPolicyApi(HttpClient httpClient, String basePath="https://keycloak.example.com/admin/realms") : base(httpClient, basePath)
    {
    }

    /// <inheritdoc />     
    public async Task<List<ComponentTypeRepresentation>> GetProviders(string realm, CancellationToken ct)
    {
        // verify the required parameter 'realm' is set
        if (realm == null) throw new PetShopApiException(400, "Missing required parameter 'realm' when calling GetProviders");
        
        var path_ = new StringBuilder("/{realm}/client-registration-policy/providers"); 
        path_ = path_.Replace("{realm}", ParameterToString(realm));

        
        
        var response = await CallApi<List<ComponentTypeRepresentation>>(
                    path_.ToString(), 
                    HttpMethod.Get,  
                    ct: ct
        );
        return response;
    }

}
