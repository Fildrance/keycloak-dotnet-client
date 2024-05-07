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
public partial interface IComponentApi
{
    /// <summary>
    ///  
    /// </summary>
    /// <param name="realm">realm name (not id!)</param>
    /// <param name="id"></param>
    /// <param name="ct"></param>
    /// <param name="ct">Operation cancellation token. </param>
    /// <returns></returns>
    Task DeleteComponent (string realm, string id, CancellationToken ct);
    /// <summary>
    ///  
    /// </summary>
    /// <param name="realm">realm name (not id!)</param>
    /// <param name="id"></param>
    /// <param name="ct"></param>
    /// <param name="ct">Operation cancellation token. </param>
    /// <returns>ComponentRepresentation</returns>
    Task<ComponentRepresentation> GetComponent (string realm, string id, CancellationToken ct);
    /// <summary>
    ///  
    /// </summary>
    /// <param name="realm">realm name (not id!)</param>
    /// <param name="name"></param>
    /// <param name="parent"></param>
    /// <param name="type"></param>
    /// <param name="ct"></param>
    /// <param name="ct">Operation cancellation token. </param>
    /// <returns>List&lt;ComponentRepresentation&gt;</returns>
    Task<List<ComponentRepresentation>> GetComponents (string realm, string name, string parent, string type, CancellationToken ct);
    /// <summary>
    ///  List of subcomponent types that are available to configure for a particular parent component.
    /// </summary>
    /// <param name="realm">realm name (not id!)</param>
    /// <param name="id"></param>
    /// <param name="type"></param>
    /// <param name="ct"></param>
    /// <param name="ct">Operation cancellation token. </param>
    /// <returns>List&lt;ComponentTypeRepresentation&gt;</returns>
    Task<List<ComponentTypeRepresentation>> GetSubComponentTypes (string realm, string id, string type, CancellationToken ct);
    /// <summary>
    ///  
    /// </summary>
    /// <param name="realm">realm name (not id!)</param>
    /// <param name="body">ComponentRepresentation</param>
    /// <param name="ct"></param>
    /// <param name="ct">Operation cancellation token. </param>
    /// <returns></returns>
    Task PostComponents (string realm, ComponentRepresentation body, CancellationToken ct);
    /// <summary>
    ///  
    /// </summary>
    /// <param name="realm">realm name (not id!)</param>
    /// <param name="id"></param>
    /// <param name="body">ComponentRepresentation</param>
    /// <param name="ct"></param>
    /// <param name="ct">Operation cancellation token. </param>
    /// <returns></returns>
    Task PutComponent (string realm, string id, ComponentRepresentation body, CancellationToken ct);
}

/// <summary>
/// Represents a collection of functions to interact with the API endpoints
/// </summary>  
[GeneratedCode("swagger-codegen", "3.0.56-SNAPSHOT")]
public partial class ComponentApi : IOSwaggerClientApiClientBase, IComponentApi
{
    /// <summary>
    /// Initializes a new instance of the <see cref="ComponentApi"/> class.
    /// </summary>
    /// <param name="httpClient"> HttpClient to be used for calls. </param>
    /// <param name="basePath"> Base url to be used for calls. </param>
    public ComponentApi(HttpClient httpClient, String basePath="https://keycloak.example.com/admin/realms") : base(httpClient, basePath)
    {
    }

    /// <inheritdoc />     
    public async Task DeleteComponent(string realm, string id, CancellationToken ct)
    {
        
        // verify the required parameter 'realm' is set
        if (realm == null) throw new IOSwaggerClientApiException(400, "Missing required parameter 'realm' when calling DeleteComponent");
        
        // verify the required parameter 'id' is set
        if (id == null) throw new IOSwaggerClientApiException(400, "Missing required parameter 'id' when calling DeleteComponent");
        

        var path_ = new StringBuilder("/{realm}/components/{id}");
        path_ = path_.Replace("{realm}", ParameterToString(realm));
path_ = path_.Replace("{id}", ParameterToString(id));

        var queryParams = new Dictionary<string, string>();
        var headerParams = new Dictionary<string, string>();
        var formParams = new Dictionary<string, string>();
        var fileParams = new Dictionary<string, FileParameter>();
        object postBody = null;

        
        await CallApi(path_.ToString(), HttpMethod.Delete, queryParams, postBody, headerParams, formParams, fileParams, ct);
    }

    /// <inheritdoc />     
    public async Task<ComponentRepresentation> GetComponent(string realm, string id, CancellationToken ct)
    {
        
        // verify the required parameter 'realm' is set
        if (realm == null) throw new IOSwaggerClientApiException(400, "Missing required parameter 'realm' when calling GetComponent");
        
        // verify the required parameter 'id' is set
        if (id == null) throw new IOSwaggerClientApiException(400, "Missing required parameter 'id' when calling GetComponent");
        

        var path_ = new StringBuilder("/{realm}/components/{id}");
        path_ = path_.Replace("{realm}", ParameterToString(realm));
path_ = path_.Replace("{id}", ParameterToString(id));

        var queryParams = new Dictionary<string, string>();
        var headerParams = new Dictionary<string, string>();
        var formParams = new Dictionary<string, string>();
        var fileParams = new Dictionary<string, FileParameter>();
        object postBody = null;

        
        var response = await CallApi<ComponentRepresentation>(path_.ToString(), HttpMethod.Get, queryParams, postBody, headerParams, formParams, fileParams, ct);
        
        return response;
    }

    /// <inheritdoc />     
    public async Task<List<ComponentRepresentation>> GetComponents(string realm, string name, string parent, string type, CancellationToken ct)
    {
        
        // verify the required parameter 'realm' is set
        if (realm == null) throw new IOSwaggerClientApiException(400, "Missing required parameter 'realm' when calling GetComponents");
        

        var path_ = new StringBuilder("/{realm}/components");
        path_ = path_.Replace("{realm}", ParameterToString(realm));

        var queryParams = new Dictionary<string, string>();
        var headerParams = new Dictionary<string, string>();
        var formParams = new Dictionary<string, string>();
        var fileParams = new Dictionary<string, FileParameter>();
        object postBody = null;

         if (name != null) queryParams.Add("name", ParameterToString(name)); // query parameter
         if (parent != null) queryParams.Add("parent", ParameterToString(parent)); // query parameter
         if (type != null) queryParams.Add("type", ParameterToString(type)); // query parameter
        
        var response = await CallApi<List<ComponentRepresentation>>(path_.ToString(), HttpMethod.Get, queryParams, postBody, headerParams, formParams, fileParams, ct);
        
        return response;
    }

    /// <inheritdoc />     
    public async Task<List<ComponentTypeRepresentation>> GetSubComponentTypes(string realm, string id, string type, CancellationToken ct)
    {
        
        // verify the required parameter 'realm' is set
        if (realm == null) throw new IOSwaggerClientApiException(400, "Missing required parameter 'realm' when calling GetSubComponentTypes");
        
        // verify the required parameter 'id' is set
        if (id == null) throw new IOSwaggerClientApiException(400, "Missing required parameter 'id' when calling GetSubComponentTypes");
        

        var path_ = new StringBuilder("/{realm}/components/{id}/sub-component-types");
        path_ = path_.Replace("{realm}", ParameterToString(realm));
path_ = path_.Replace("{id}", ParameterToString(id));

        var queryParams = new Dictionary<string, string>();
        var headerParams = new Dictionary<string, string>();
        var formParams = new Dictionary<string, string>();
        var fileParams = new Dictionary<string, FileParameter>();
        object postBody = null;

         if (type != null) queryParams.Add("type", ParameterToString(type)); // query parameter
        
        var response = await CallApi<List<ComponentTypeRepresentation>>(path_.ToString(), HttpMethod.Get, queryParams, postBody, headerParams, formParams, fileParams, ct);
        
        return response;
    }

    /// <inheritdoc />     
    public async Task PostComponents(string realm, ComponentRepresentation body, CancellationToken ct)
    {
        
        // verify the required parameter 'realm' is set
        if (realm == null) throw new IOSwaggerClientApiException(400, "Missing required parameter 'realm' when calling PostComponents");
        

        var path_ = new StringBuilder("/{realm}/components");
        path_ = path_.Replace("{realm}", ParameterToString(realm));

        var queryParams = new Dictionary<string, string>();
        var headerParams = new Dictionary<string, string>();
        var formParams = new Dictionary<string, string>();
        var fileParams = new Dictionary<string, FileParameter>();
        object postBody = null;

        postBody = body; // http body (model) parameter

        await CallApi(path_.ToString(), HttpMethod.Post, queryParams, postBody, headerParams, formParams, fileParams, ct);
    }

    /// <inheritdoc />     
    public async Task PutComponent(string realm, string id, ComponentRepresentation body, CancellationToken ct)
    {
        
        // verify the required parameter 'realm' is set
        if (realm == null) throw new IOSwaggerClientApiException(400, "Missing required parameter 'realm' when calling PutComponent");
        
        // verify the required parameter 'id' is set
        if (id == null) throw new IOSwaggerClientApiException(400, "Missing required parameter 'id' when calling PutComponent");
        

        var path_ = new StringBuilder("/{realm}/components/{id}");
        path_ = path_.Replace("{realm}", ParameterToString(realm));
path_ = path_.Replace("{id}", ParameterToString(id));

        var queryParams = new Dictionary<string, string>();
        var headerParams = new Dictionary<string, string>();
        var formParams = new Dictionary<string, string>();
        var fileParams = new Dictionary<string, FileParameter>();
        object postBody = null;

        postBody = body; // http body (model) parameter

        await CallApi(path_.ToString(), HttpMethod.Put, queryParams, postBody, headerParams, formParams, fileParams, ct);
    }

}
