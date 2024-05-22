using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading;
using System.Text;
using System.Threading.Tasks;
using System.CodeDom.Compiler;

namespace Keycloak.Client.Clients;

/// <summary>
/// Represents a collection of functions to interact with the API endpoints
/// </summary>
[GeneratedCode("swagger-codegen", "3.0.56-SNAPSHOT")]
public partial interface IAttackDetectionApi
{
    /// <summary>
    ///  Clear any user login failures for the user This can release temporary disabled user
    /// </summary>
    /// <param name="realm">realm name (not id!)</param>
    /// <param name="userId"></param>
    /// <param name="ct"></param>
    /// <returns></returns>
    Task DeleteBruteForceUser (string realm, string userId, CancellationToken ct);
    /// <summary>
    ///  Clear any user login failures for all users This can release temporary disabled users
    /// </summary>
    /// <param name="realm">realm name (not id!)</param>
    /// <param name="ct"></param>
    /// <returns></returns>
    Task DeleteUsers (string realm, CancellationToken ct);
    /// <summary>
    ///  Get status of a username in brute force detection
    /// </summary>
    /// <param name="realm">realm name (not id!)</param>
    /// <param name="userId"></param>
    /// <param name="ct"></param>
    /// <returns>Dictionary&lt;string, Object&gt;</returns>
    Task<Dictionary<string, Object>> GetBruteForceUser (string realm, string userId, CancellationToken ct);
}

/// <summary>
/// Represents a collection of functions to interact with the API endpoints
/// </summary>  
[GeneratedCode("swagger-codegen", "3.0.56-SNAPSHOT")]
public partial class AttackDetectionApi : KeycloakClientApiClientBase, IAttackDetectionApi
{
    /// <summary>
    /// Initializes a new instance of the <see cref="AttackDetectionApi"/> class.
    /// </summary>
    /// <param name="httpClient"> HttpClient to be used for calls. </param>
    /// <param name="basePath"> Base url to be used for calls. </param>
    public AttackDetectionApi(HttpClient httpClient, String basePath="https://keycloak.example.com/admin/realms") : base(httpClient, basePath)
    {
    }

    /// <inheritdoc />     
    public async Task DeleteBruteForceUser(string realm, string userId, CancellationToken ct)
    {
        // verify the required parameter 'realm' is set
        if (realm == null) throw new KeycloakClientApiException(400, "Missing required parameter 'realm' when calling DeleteBruteForceUser");
        // verify the required parameter 'userId' is set
        if (userId == null) throw new KeycloakClientApiException(400, "Missing required parameter 'userId' when calling DeleteBruteForceUser");
        
        var path_ = new StringBuilder("/{realm}/attack-detection/brute-force/users/{userId}"); 
        path_ = path_.Replace("{realm}", ParameterToString(realm));
        path_ = path_.Replace("{userId}", ParameterToString(userId));

        
        
        await CallApi(
                    path_.ToString(), 
                    HttpMethod.Delete,  
                    ct: ct
        );
    }

    /// <inheritdoc />     
    public async Task DeleteUsers(string realm, CancellationToken ct)
    {
        // verify the required parameter 'realm' is set
        if (realm == null) throw new KeycloakClientApiException(400, "Missing required parameter 'realm' when calling DeleteUsers");
        
        var path_ = new StringBuilder("/{realm}/attack-detection/brute-force/users"); 
        path_ = path_.Replace("{realm}", ParameterToString(realm));

        
        
        await CallApi(
                    path_.ToString(), 
                    HttpMethod.Delete,  
                    ct: ct
        );
    }

    /// <inheritdoc />     
    public async Task<Dictionary<string, Object>> GetBruteForceUser(string realm, string userId, CancellationToken ct)
    {
        // verify the required parameter 'realm' is set
        if (realm == null) throw new KeycloakClientApiException(400, "Missing required parameter 'realm' when calling GetBruteForceUser");
        // verify the required parameter 'userId' is set
        if (userId == null) throw new KeycloakClientApiException(400, "Missing required parameter 'userId' when calling GetBruteForceUser");
        
        var path_ = new StringBuilder("/{realm}/attack-detection/brute-force/users/{userId}"); 
        path_ = path_.Replace("{realm}", ParameterToString(realm));
        path_ = path_.Replace("{userId}", ParameterToString(userId));

        
        
        var response = await CallApi<Dictionary<string, Object>>(
                    path_.ToString(), 
                    HttpMethod.Get,  
                    ct: ct
        );
        return response;
    }

}
