using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading;
using System.Text;
using System.Threading.Tasks;
using System.CodeDom.Compiler;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace IO.Swagger.Api;

/// <summary>
/// Represents a collection of functions to interact with the API endpoints
/// </summary>
[GeneratedCode("swagger-codegen", "3.0.56-SNAPSHOT")]
public partial interface IKeyApi
{
    /// <summary>
    ///  
    /// </summary>
    /// <param name="realm">realm name (not id!)</param>
    /// <param name="ct"></param>
    /// <param name="ct">Operation cancellation token. </param>
    /// <returns>KeysMetadataRepresentation</returns>
    Task<KeysMetadataRepresentation> GetKeys (string realm, CancellationToken ct);
}

/// <summary>
/// Represents a collection of functions to interact with the API endpoints
/// </summary>  
[GeneratedCode("swagger-codegen", "3.0.56-SNAPSHOT")]
public partial class KeyApi : IOSwaggerClientApiClientBase, IKeyApi
{
    /// <summary>
    /// Initializes a new instance of the <see cref="KeyApi"/> class.
    /// </summary>
    /// <param name="httpClient"> HttpClient to be used for calls. </param>
    /// <param name="basePath"> Base url to be used for calls. </param>
    public KeyApi(HttpClient httpClient, String basePath="https://keycloak.example.com/admin/realms") : base(httpClient, basePath)
    {
    }

    /// <inheritdoc />     
    public async Task<KeysMetadataRepresentation> GetKeys(string realm, CancellationToken ct)
    {
        
        // verify the required parameter 'realm' is set
        if (realm == null) throw new IOSwaggerClientApiException(400, "Missing required parameter 'realm' when calling GetKeys");
        

        var path_ = new StringBuilder("/{realm}/keys");
        path_ = path_.Replace("{realm}", ParameterToString(realm));

        var queryParams = new Dictionary<string, string>();
        var headerParams = new Dictionary<string, string>();
        var formParams = new Dictionary<string, string>();
        var fileParams = new Dictionary<string, FileParameter>();
        object postBody = null;

        
        var response = await CallApi<KeysMetadataRepresentation>(path_.ToString(), HttpMethod.Get, queryParams, postBody, headerParams, formParams, fileParams, ct);
        
        return response;
    }

}
