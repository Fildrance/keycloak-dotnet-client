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
public partial interface IScopeMappingsApi
{
    /// <summary>
    ///  Remove client-level roles from the client’s scope.
    /// </summary>
    /// <param name="realm">realm name (not id!)</param>
    /// <param name="id"></param>
    /// <param name="_client"></param>
    /// <param name="body">RoleRepresentation</param>
    /// <param name="ct"></param>
    /// <param name="ct">Operation cancellation token. </param>
    /// <returns></returns>
    Task DeleteClientScopeMappingsClient (string realm, string id, string _client, RoleRepresentation body, CancellationToken ct);
    /// <summary>
    ///  Remove a set of realm-level roles from the client’s scope
    /// </summary>
    /// <param name="realm">realm name (not id!)</param>
    /// <param name="id"></param>
    /// <param name="body">RoleRepresentation</param>
    /// <param name="ct"></param>
    /// <param name="ct">Operation cancellation token. </param>
    /// <returns></returns>
    Task DeleteClientScopeMappingsRealm (string realm, string id, RoleRepresentation body, CancellationToken ct);
    /// <summary>
    ///  Remove client-level roles from the client’s scope.
    /// </summary>
    /// <param name="realm">realm name (not id!)</param>
    /// <param name="id"></param>
    /// <param name="_client"></param>
    /// <param name="body">RoleRepresentation</param>
    /// <param name="ct"></param>
    /// <param name="ct">Operation cancellation token. </param>
    /// <returns></returns>
    Task DeleteClientScopeScopeMappingsClient (string realm, string id, string _client, RoleRepresentation body, CancellationToken ct);
    /// <summary>
    ///  Remove a set of realm-level roles from the client’s scope
    /// </summary>
    /// <param name="realm">realm name (not id!)</param>
    /// <param name="id"></param>
    /// <param name="body">RoleRepresentation</param>
    /// <param name="ct"></param>
    /// <param name="ct">Operation cancellation token. </param>
    /// <returns></returns>
    Task DeleteClientScopeScopeMappingsRealm (string realm, string id, RoleRepresentation body, CancellationToken ct);
    /// <summary>
    ///  Remove client-level roles from the client’s scope.
    /// </summary>
    /// <param name="realm">realm name (not id!)</param>
    /// <param name="id"></param>
    /// <param name="_client"></param>
    /// <param name="body">RoleRepresentation</param>
    /// <param name="ct"></param>
    /// <param name="ct">Operation cancellation token. </param>
    /// <returns></returns>
    Task DeleteClientTemplateScopeMappingsClient (string realm, string id, string _client, RoleRepresentation body, CancellationToken ct);
    /// <summary>
    ///  Remove a set of realm-level roles from the client’s scope
    /// </summary>
    /// <param name="realm">realm name (not id!)</param>
    /// <param name="id"></param>
    /// <param name="body">RoleRepresentation</param>
    /// <param name="ct"></param>
    /// <param name="ct">Operation cancellation token. </param>
    /// <returns></returns>
    Task DeleteClientTemplateScopeMappingsRealm (string realm, string id, RoleRepresentation body, CancellationToken ct);
    /// <summary>
    ///  Get all scope mappings for the client
    /// </summary>
    /// <param name="realm">realm name (not id!)</param>
    /// <param name="id"></param>
    /// <param name="ct"></param>
    /// <param name="ct">Operation cancellation token. </param>
    /// <returns>MappingsRepresentation</returns>
    Task<MappingsRepresentation> GetClientScopeMappings (string realm, string id, CancellationToken ct);
    /// <summary>
    ///  Get the roles associated with a client’s scope Returns roles for the client.
    /// </summary>
    /// <param name="realm">realm name (not id!)</param>
    /// <param name="id"></param>
    /// <param name="_client"></param>
    /// <param name="ct"></param>
    /// <param name="ct">Operation cancellation token. </param>
    /// <returns>List&lt;RoleRepresentation&gt;</returns>
    Task<List<RoleRepresentation>> GetClientScopeMappingsClient (string realm, string id, string _client, CancellationToken ct);
    /// <summary>
    ///  The available client-level roles Returns the roles for the client that can be associated with the client’s scope
    /// </summary>
    /// <param name="realm">realm name (not id!)</param>
    /// <param name="id"></param>
    /// <param name="_client"></param>
    /// <param name="ct"></param>
    /// <param name="ct">Operation cancellation token. </param>
    /// <returns>List&lt;RoleRepresentation&gt;</returns>
    Task<List<RoleRepresentation>> GetClientScopeMappingsClientAvailable (string realm, string id, string _client, CancellationToken ct);
    /// <summary>
    ///  Get effective client roles Returns the roles for the client that are associated with the client’s scope.
    /// </summary>
    /// <param name="realm">realm name (not id!)</param>
    /// <param name="id"></param>
    /// <param name="_client"></param>
    /// <param name="briefRepresentation">if false, return roles with their attributes</param>
    /// <param name="ct"></param>
    /// <param name="ct">Operation cancellation token. </param>
    /// <returns>List&lt;RoleRepresentation&gt;</returns>
    Task<List<RoleRepresentation>> GetClientScopeMappingsClientComposite (string realm, string id, string _client, string briefRepresentation, CancellationToken ct);
    /// <summary>
    ///  Get realm-level roles associated with the client’s scope
    /// </summary>
    /// <param name="realm">realm name (not id!)</param>
    /// <param name="id"></param>
    /// <param name="ct"></param>
    /// <param name="ct">Operation cancellation token. </param>
    /// <returns>List&lt;RoleRepresentation&gt;</returns>
    Task<List<RoleRepresentation>> GetClientScopeMappingsRealm (string realm, string id, CancellationToken ct);
    /// <summary>
    ///  Get realm-level roles that are available to attach to this client’s scope
    /// </summary>
    /// <param name="realm">realm name (not id!)</param>
    /// <param name="id"></param>
    /// <param name="ct"></param>
    /// <param name="ct">Operation cancellation token. </param>
    /// <returns>List&lt;RoleRepresentation&gt;</returns>
    Task<List<RoleRepresentation>> GetClientScopeMappingsRealmAvailable (string realm, string id, CancellationToken ct);
    /// <summary>
    ///  Get effective realm-level roles associated with the client’s scope What this does is recurse any composite roles associated with the client’s scope and adds the roles to this lists.
    /// </summary>
    /// <param name="realm">realm name (not id!)</param>
    /// <param name="id"></param>
    /// <param name="briefRepresentation">if false, return roles with their attributes</param>
    /// <param name="ct"></param>
    /// <param name="ct">Operation cancellation token. </param>
    /// <returns>List&lt;RoleRepresentation&gt;</returns>
    Task<List<RoleRepresentation>> GetClientScopeMappingsRealmComposite (string realm, string id, string briefRepresentation, CancellationToken ct);
    /// <summary>
    ///  Get all scope mappings for the client
    /// </summary>
    /// <param name="realm">realm name (not id!)</param>
    /// <param name="id"></param>
    /// <param name="ct"></param>
    /// <param name="ct">Operation cancellation token. </param>
    /// <returns>MappingsRepresentation</returns>
    Task<MappingsRepresentation> GetClientScopeScopeMappings (string realm, string id, CancellationToken ct);
    /// <summary>
    ///  Get the roles associated with a client’s scope Returns roles for the client.
    /// </summary>
    /// <param name="realm">realm name (not id!)</param>
    /// <param name="id"></param>
    /// <param name="_client"></param>
    /// <param name="ct"></param>
    /// <param name="ct">Operation cancellation token. </param>
    /// <returns>List&lt;RoleRepresentation&gt;</returns>
    Task<List<RoleRepresentation>> GetClientScopeScopeMappingsClient (string realm, string id, string _client, CancellationToken ct);
    /// <summary>
    ///  The available client-level roles Returns the roles for the client that can be associated with the client’s scope
    /// </summary>
    /// <param name="realm">realm name (not id!)</param>
    /// <param name="id"></param>
    /// <param name="_client"></param>
    /// <param name="ct"></param>
    /// <param name="ct">Operation cancellation token. </param>
    /// <returns>List&lt;RoleRepresentation&gt;</returns>
    Task<List<RoleRepresentation>> GetClientScopeScopeMappingsClientAvailable (string realm, string id, string _client, CancellationToken ct);
    /// <summary>
    ///  Get effective client roles Returns the roles for the client that are associated with the client’s scope.
    /// </summary>
    /// <param name="realm">realm name (not id!)</param>
    /// <param name="id"></param>
    /// <param name="_client"></param>
    /// <param name="briefRepresentation">if false, return roles with their attributes</param>
    /// <param name="ct"></param>
    /// <param name="ct">Operation cancellation token. </param>
    /// <returns>List&lt;RoleRepresentation&gt;</returns>
    Task<List<RoleRepresentation>> GetClientScopeScopeMappingsClientComposite (string realm, string id, string _client, string briefRepresentation, CancellationToken ct);
    /// <summary>
    ///  Get realm-level roles associated with the client’s scope
    /// </summary>
    /// <param name="realm">realm name (not id!)</param>
    /// <param name="id"></param>
    /// <param name="ct"></param>
    /// <param name="ct">Operation cancellation token. </param>
    /// <returns>List&lt;RoleRepresentation&gt;</returns>
    Task<List<RoleRepresentation>> GetClientScopeScopeMappingsRealm (string realm, string id, CancellationToken ct);
    /// <summary>
    ///  Get realm-level roles that are available to attach to this client’s scope
    /// </summary>
    /// <param name="realm">realm name (not id!)</param>
    /// <param name="id"></param>
    /// <param name="ct"></param>
    /// <param name="ct">Operation cancellation token. </param>
    /// <returns>List&lt;RoleRepresentation&gt;</returns>
    Task<List<RoleRepresentation>> GetClientScopeScopeMappingsRealmAvailable (string realm, string id, CancellationToken ct);
    /// <summary>
    ///  Get effective realm-level roles associated with the client’s scope What this does is recurse any composite roles associated with the client’s scope and adds the roles to this lists.
    /// </summary>
    /// <param name="realm">realm name (not id!)</param>
    /// <param name="id"></param>
    /// <param name="briefRepresentation">if false, return roles with their attributes</param>
    /// <param name="ct"></param>
    /// <param name="ct">Operation cancellation token. </param>
    /// <returns>List&lt;RoleRepresentation&gt;</returns>
    Task<List<RoleRepresentation>> GetClientScopeScopeMappingsRealmComposite (string realm, string id, string briefRepresentation, CancellationToken ct);
    /// <summary>
    ///  Get all scope mappings for the client
    /// </summary>
    /// <param name="realm">realm name (not id!)</param>
    /// <param name="id"></param>
    /// <param name="ct"></param>
    /// <param name="ct">Operation cancellation token. </param>
    /// <returns>MappingsRepresentation</returns>
    Task<MappingsRepresentation> GetClientTemplateScopeMappings (string realm, string id, CancellationToken ct);
    /// <summary>
    ///  Get the roles associated with a client’s scope Returns roles for the client.
    /// </summary>
    /// <param name="realm">realm name (not id!)</param>
    /// <param name="id"></param>
    /// <param name="_client"></param>
    /// <param name="ct"></param>
    /// <param name="ct">Operation cancellation token. </param>
    /// <returns>List&lt;RoleRepresentation&gt;</returns>
    Task<List<RoleRepresentation>> GetClientTemplateScopeMappingsClient (string realm, string id, string _client, CancellationToken ct);
    /// <summary>
    ///  The available client-level roles Returns the roles for the client that can be associated with the client’s scope
    /// </summary>
    /// <param name="realm">realm name (not id!)</param>
    /// <param name="id"></param>
    /// <param name="_client"></param>
    /// <param name="ct"></param>
    /// <param name="ct">Operation cancellation token. </param>
    /// <returns>List&lt;RoleRepresentation&gt;</returns>
    Task<List<RoleRepresentation>> GetClientTemplateScopeMappingsClientAvailable (string realm, string id, string _client, CancellationToken ct);
    /// <summary>
    ///  Get effective client roles Returns the roles for the client that are associated with the client’s scope.
    /// </summary>
    /// <param name="realm">realm name (not id!)</param>
    /// <param name="id"></param>
    /// <param name="_client"></param>
    /// <param name="briefRepresentation">if false, return roles with their attributes</param>
    /// <param name="ct"></param>
    /// <param name="ct">Operation cancellation token. </param>
    /// <returns>List&lt;RoleRepresentation&gt;</returns>
    Task<List<RoleRepresentation>> GetClientTemplateScopeMappingsClientComposite (string realm, string id, string _client, string briefRepresentation, CancellationToken ct);
    /// <summary>
    ///  Get realm-level roles associated with the client’s scope
    /// </summary>
    /// <param name="realm">realm name (not id!)</param>
    /// <param name="id"></param>
    /// <param name="ct"></param>
    /// <param name="ct">Operation cancellation token. </param>
    /// <returns>List&lt;RoleRepresentation&gt;</returns>
    Task<List<RoleRepresentation>> GetClientTemplateScopeMappingsRealm (string realm, string id, CancellationToken ct);
    /// <summary>
    ///  Get realm-level roles that are available to attach to this client’s scope
    /// </summary>
    /// <param name="realm">realm name (not id!)</param>
    /// <param name="id"></param>
    /// <param name="ct"></param>
    /// <param name="ct">Operation cancellation token. </param>
    /// <returns>List&lt;RoleRepresentation&gt;</returns>
    Task<List<RoleRepresentation>> GetClientTemplateScopeMappingsRealmAvailable (string realm, string id, CancellationToken ct);
    /// <summary>
    ///  Get effective realm-level roles associated with the client’s scope What this does is recurse any composite roles associated with the client’s scope and adds the roles to this lists.
    /// </summary>
    /// <param name="realm">realm name (not id!)</param>
    /// <param name="id"></param>
    /// <param name="briefRepresentation">if false, return roles with their attributes</param>
    /// <param name="ct"></param>
    /// <param name="ct">Operation cancellation token. </param>
    /// <returns>List&lt;RoleRepresentation&gt;</returns>
    Task<List<RoleRepresentation>> GetClientTemplateScopeMappingsRealmComposite (string realm, string id, string briefRepresentation, CancellationToken ct);
    /// <summary>
    ///  Add client-level roles to the client’s scope
    /// </summary>
    /// <param name="realm">realm name (not id!)</param>
    /// <param name="id"></param>
    /// <param name="_client"></param>
    /// <param name="body">RoleRepresentation</param>
    /// <param name="ct"></param>
    /// <param name="ct">Operation cancellation token. </param>
    /// <returns></returns>
    Task PostClientScopeMappingsClient (string realm, string id, string _client, RoleRepresentation body, CancellationToken ct);
    /// <summary>
    ///  Add a set of realm-level roles to the client’s scope
    /// </summary>
    /// <param name="realm">realm name (not id!)</param>
    /// <param name="id"></param>
    /// <param name="body">RoleRepresentation</param>
    /// <param name="ct"></param>
    /// <param name="ct">Operation cancellation token. </param>
    /// <returns></returns>
    Task PostClientScopeMappingsRealm (string realm, string id, RoleRepresentation body, CancellationToken ct);
    /// <summary>
    ///  Add client-level roles to the client’s scope
    /// </summary>
    /// <param name="realm">realm name (not id!)</param>
    /// <param name="id"></param>
    /// <param name="_client"></param>
    /// <param name="body">RoleRepresentation</param>
    /// <param name="ct"></param>
    /// <param name="ct">Operation cancellation token. </param>
    /// <returns></returns>
    Task PostClientScopeScopeMappingsClient (string realm, string id, string _client, RoleRepresentation body, CancellationToken ct);
    /// <summary>
    ///  Add a set of realm-level roles to the client’s scope
    /// </summary>
    /// <param name="realm">realm name (not id!)</param>
    /// <param name="id"></param>
    /// <param name="body">RoleRepresentation</param>
    /// <param name="ct"></param>
    /// <param name="ct">Operation cancellation token. </param>
    /// <returns></returns>
    Task PostClientScopeScopeMappingsRealm (string realm, string id, RoleRepresentation body, CancellationToken ct);
    /// <summary>
    ///  Add client-level roles to the client’s scope
    /// </summary>
    /// <param name="realm">realm name (not id!)</param>
    /// <param name="id"></param>
    /// <param name="_client"></param>
    /// <param name="body">RoleRepresentation</param>
    /// <param name="ct"></param>
    /// <param name="ct">Operation cancellation token. </param>
    /// <returns></returns>
    Task PostClientTemplateScopeMappingsClient (string realm, string id, string _client, RoleRepresentation body, CancellationToken ct);
    /// <summary>
    ///  Add a set of realm-level roles to the client’s scope
    /// </summary>
    /// <param name="realm">realm name (not id!)</param>
    /// <param name="id"></param>
    /// <param name="body">RoleRepresentation</param>
    /// <param name="ct"></param>
    /// <param name="ct">Operation cancellation token. </param>
    /// <returns></returns>
    Task PostClientTemplateScopeMappingsRealm (string realm, string id, RoleRepresentation body, CancellationToken ct);
}

/// <summary>
/// Represents a collection of functions to interact with the API endpoints
/// </summary>  
[GeneratedCode("swagger-codegen", "3.0.56-SNAPSHOT")]
public partial class ScopeMappingsApi : IOSwaggerClientApiClientBase, IScopeMappingsApi
{
    /// <summary>
    /// Initializes a new instance of the <see cref="ScopeMappingsApi"/> class.
    /// </summary>
    /// <param name="httpClient"> HttpClient to be used for calls. </param>
    /// <param name="basePath"> Base url to be used for calls. </param>
    public ScopeMappingsApi(HttpClient httpClient, String basePath="https://keycloak.example.com/admin/realms") : base(httpClient, basePath)
    {
    }

    /// <inheritdoc />     
    public async Task DeleteClientScopeMappingsClient(string realm, string id, string _client, RoleRepresentation body, CancellationToken ct)
    {
        
        // verify the required parameter 'realm' is set
        if (realm == null) throw new IOSwaggerClientApiException(400, "Missing required parameter 'realm' when calling DeleteClientScopeMappingsClient");
        
        // verify the required parameter 'id' is set
        if (id == null) throw new IOSwaggerClientApiException(400, "Missing required parameter 'id' when calling DeleteClientScopeMappingsClient");
        
        // verify the required parameter '_client' is set
        if (_client == null) throw new IOSwaggerClientApiException(400, "Missing required parameter '_client' when calling DeleteClientScopeMappingsClient");
        

        var path_ = new StringBuilder("/{realm}/clients/{id}/scope-mappings/clients/{client}");
        path_ = path_.Replace("{realm}", ParameterToString(realm));
path_ = path_.Replace("{id}", ParameterToString(id));
path_ = path_.Replace("{client}", ParameterToString(_client));

        var queryParams = new Dictionary<string, string>();
        var headerParams = new Dictionary<string, string>();
        var formParams = new Dictionary<string, string>();
        var fileParams = new Dictionary<string, FileParameter>();
        object postBody = null;

        postBody = body; // http body (model) parameter

        await CallApi(path_.ToString(), HttpMethod.Delete, queryParams, postBody, headerParams, formParams, fileParams, ct);
    }

    /// <inheritdoc />     
    public async Task DeleteClientScopeMappingsRealm(string realm, string id, RoleRepresentation body, CancellationToken ct)
    {
        
        // verify the required parameter 'realm' is set
        if (realm == null) throw new IOSwaggerClientApiException(400, "Missing required parameter 'realm' when calling DeleteClientScopeMappingsRealm");
        
        // verify the required parameter 'id' is set
        if (id == null) throw new IOSwaggerClientApiException(400, "Missing required parameter 'id' when calling DeleteClientScopeMappingsRealm");
        

        var path_ = new StringBuilder("/{realm}/clients/{id}/scope-mappings/realm");
        path_ = path_.Replace("{realm}", ParameterToString(realm));
path_ = path_.Replace("{id}", ParameterToString(id));

        var queryParams = new Dictionary<string, string>();
        var headerParams = new Dictionary<string, string>();
        var formParams = new Dictionary<string, string>();
        var fileParams = new Dictionary<string, FileParameter>();
        object postBody = null;

        postBody = body; // http body (model) parameter

        await CallApi(path_.ToString(), HttpMethod.Delete, queryParams, postBody, headerParams, formParams, fileParams, ct);
    }

    /// <inheritdoc />     
    public async Task DeleteClientScopeScopeMappingsClient(string realm, string id, string _client, RoleRepresentation body, CancellationToken ct)
    {
        
        // verify the required parameter 'realm' is set
        if (realm == null) throw new IOSwaggerClientApiException(400, "Missing required parameter 'realm' when calling DeleteClientScopeScopeMappingsClient");
        
        // verify the required parameter 'id' is set
        if (id == null) throw new IOSwaggerClientApiException(400, "Missing required parameter 'id' when calling DeleteClientScopeScopeMappingsClient");
        
        // verify the required parameter '_client' is set
        if (_client == null) throw new IOSwaggerClientApiException(400, "Missing required parameter '_client' when calling DeleteClientScopeScopeMappingsClient");
        

        var path_ = new StringBuilder("/{realm}/client-scopes/{id}/scope-mappings/clients/{client}");
        path_ = path_.Replace("{realm}", ParameterToString(realm));
path_ = path_.Replace("{id}", ParameterToString(id));
path_ = path_.Replace("{client}", ParameterToString(_client));

        var queryParams = new Dictionary<string, string>();
        var headerParams = new Dictionary<string, string>();
        var formParams = new Dictionary<string, string>();
        var fileParams = new Dictionary<string, FileParameter>();
        object postBody = null;

        postBody = body; // http body (model) parameter

        await CallApi(path_.ToString(), HttpMethod.Delete, queryParams, postBody, headerParams, formParams, fileParams, ct);
    }

    /// <inheritdoc />     
    public async Task DeleteClientScopeScopeMappingsRealm(string realm, string id, RoleRepresentation body, CancellationToken ct)
    {
        
        // verify the required parameter 'realm' is set
        if (realm == null) throw new IOSwaggerClientApiException(400, "Missing required parameter 'realm' when calling DeleteClientScopeScopeMappingsRealm");
        
        // verify the required parameter 'id' is set
        if (id == null) throw new IOSwaggerClientApiException(400, "Missing required parameter 'id' when calling DeleteClientScopeScopeMappingsRealm");
        

        var path_ = new StringBuilder("/{realm}/client-scopes/{id}/scope-mappings/realm");
        path_ = path_.Replace("{realm}", ParameterToString(realm));
path_ = path_.Replace("{id}", ParameterToString(id));

        var queryParams = new Dictionary<string, string>();
        var headerParams = new Dictionary<string, string>();
        var formParams = new Dictionary<string, string>();
        var fileParams = new Dictionary<string, FileParameter>();
        object postBody = null;

        postBody = body; // http body (model) parameter

        await CallApi(path_.ToString(), HttpMethod.Delete, queryParams, postBody, headerParams, formParams, fileParams, ct);
    }

    /// <inheritdoc />     
    public async Task DeleteClientTemplateScopeMappingsClient(string realm, string id, string _client, RoleRepresentation body, CancellationToken ct)
    {
        
        // verify the required parameter 'realm' is set
        if (realm == null) throw new IOSwaggerClientApiException(400, "Missing required parameter 'realm' when calling DeleteClientTemplateScopeMappingsClient");
        
        // verify the required parameter 'id' is set
        if (id == null) throw new IOSwaggerClientApiException(400, "Missing required parameter 'id' when calling DeleteClientTemplateScopeMappingsClient");
        
        // verify the required parameter '_client' is set
        if (_client == null) throw new IOSwaggerClientApiException(400, "Missing required parameter '_client' when calling DeleteClientTemplateScopeMappingsClient");
        

        var path_ = new StringBuilder("/{realm}/client-templates/{id}/scope-mappings/clients/{client}");
        path_ = path_.Replace("{realm}", ParameterToString(realm));
path_ = path_.Replace("{id}", ParameterToString(id));
path_ = path_.Replace("{client}", ParameterToString(_client));

        var queryParams = new Dictionary<string, string>();
        var headerParams = new Dictionary<string, string>();
        var formParams = new Dictionary<string, string>();
        var fileParams = new Dictionary<string, FileParameter>();
        object postBody = null;

        postBody = body; // http body (model) parameter

        await CallApi(path_.ToString(), HttpMethod.Delete, queryParams, postBody, headerParams, formParams, fileParams, ct);
    }

    /// <inheritdoc />     
    public async Task DeleteClientTemplateScopeMappingsRealm(string realm, string id, RoleRepresentation body, CancellationToken ct)
    {
        
        // verify the required parameter 'realm' is set
        if (realm == null) throw new IOSwaggerClientApiException(400, "Missing required parameter 'realm' when calling DeleteClientTemplateScopeMappingsRealm");
        
        // verify the required parameter 'id' is set
        if (id == null) throw new IOSwaggerClientApiException(400, "Missing required parameter 'id' when calling DeleteClientTemplateScopeMappingsRealm");
        

        var path_ = new StringBuilder("/{realm}/client-templates/{id}/scope-mappings/realm");
        path_ = path_.Replace("{realm}", ParameterToString(realm));
path_ = path_.Replace("{id}", ParameterToString(id));

        var queryParams = new Dictionary<string, string>();
        var headerParams = new Dictionary<string, string>();
        var formParams = new Dictionary<string, string>();
        var fileParams = new Dictionary<string, FileParameter>();
        object postBody = null;

        postBody = body; // http body (model) parameter

        await CallApi(path_.ToString(), HttpMethod.Delete, queryParams, postBody, headerParams, formParams, fileParams, ct);
    }

    /// <inheritdoc />     
    public async Task<MappingsRepresentation> GetClientScopeMappings(string realm, string id, CancellationToken ct)
    {
        
        // verify the required parameter 'realm' is set
        if (realm == null) throw new IOSwaggerClientApiException(400, "Missing required parameter 'realm' when calling GetClientScopeMappings");
        
        // verify the required parameter 'id' is set
        if (id == null) throw new IOSwaggerClientApiException(400, "Missing required parameter 'id' when calling GetClientScopeMappings");
        

        var path_ = new StringBuilder("/{realm}/clients/{id}/scope-mappings");
        path_ = path_.Replace("{realm}", ParameterToString(realm));
path_ = path_.Replace("{id}", ParameterToString(id));

        var queryParams = new Dictionary<string, string>();
        var headerParams = new Dictionary<string, string>();
        var formParams = new Dictionary<string, string>();
        var fileParams = new Dictionary<string, FileParameter>();
        object postBody = null;

        
        var response = await CallApi<MappingsRepresentation>(path_.ToString(), HttpMethod.Get, queryParams, postBody, headerParams, formParams, fileParams, ct);
        
        return response;
    }

    /// <inheritdoc />     
    public async Task<List<RoleRepresentation>> GetClientScopeMappingsClient(string realm, string id, string _client, CancellationToken ct)
    {
        
        // verify the required parameter 'realm' is set
        if (realm == null) throw new IOSwaggerClientApiException(400, "Missing required parameter 'realm' when calling GetClientScopeMappingsClient");
        
        // verify the required parameter 'id' is set
        if (id == null) throw new IOSwaggerClientApiException(400, "Missing required parameter 'id' when calling GetClientScopeMappingsClient");
        
        // verify the required parameter '_client' is set
        if (_client == null) throw new IOSwaggerClientApiException(400, "Missing required parameter '_client' when calling GetClientScopeMappingsClient");
        

        var path_ = new StringBuilder("/{realm}/clients/{id}/scope-mappings/clients/{client}");
        path_ = path_.Replace("{realm}", ParameterToString(realm));
path_ = path_.Replace("{id}", ParameterToString(id));
path_ = path_.Replace("{client}", ParameterToString(_client));

        var queryParams = new Dictionary<string, string>();
        var headerParams = new Dictionary<string, string>();
        var formParams = new Dictionary<string, string>();
        var fileParams = new Dictionary<string, FileParameter>();
        object postBody = null;

        
        var response = await CallApi<List<RoleRepresentation>>(path_.ToString(), HttpMethod.Get, queryParams, postBody, headerParams, formParams, fileParams, ct);
        
        return response;
    }

    /// <inheritdoc />     
    public async Task<List<RoleRepresentation>> GetClientScopeMappingsClientAvailable(string realm, string id, string _client, CancellationToken ct)
    {
        
        // verify the required parameter 'realm' is set
        if (realm == null) throw new IOSwaggerClientApiException(400, "Missing required parameter 'realm' when calling GetClientScopeMappingsClientAvailable");
        
        // verify the required parameter 'id' is set
        if (id == null) throw new IOSwaggerClientApiException(400, "Missing required parameter 'id' when calling GetClientScopeMappingsClientAvailable");
        
        // verify the required parameter '_client' is set
        if (_client == null) throw new IOSwaggerClientApiException(400, "Missing required parameter '_client' when calling GetClientScopeMappingsClientAvailable");
        

        var path_ = new StringBuilder("/{realm}/clients/{id}/scope-mappings/clients/{client}/available");
        path_ = path_.Replace("{realm}", ParameterToString(realm));
path_ = path_.Replace("{id}", ParameterToString(id));
path_ = path_.Replace("{client}", ParameterToString(_client));

        var queryParams = new Dictionary<string, string>();
        var headerParams = new Dictionary<string, string>();
        var formParams = new Dictionary<string, string>();
        var fileParams = new Dictionary<string, FileParameter>();
        object postBody = null;

        
        var response = await CallApi<List<RoleRepresentation>>(path_.ToString(), HttpMethod.Get, queryParams, postBody, headerParams, formParams, fileParams, ct);
        
        return response;
    }

    /// <inheritdoc />     
    public async Task<List<RoleRepresentation>> GetClientScopeMappingsClientComposite(string realm, string id, string _client, string briefRepresentation, CancellationToken ct)
    {
        
        // verify the required parameter 'realm' is set
        if (realm == null) throw new IOSwaggerClientApiException(400, "Missing required parameter 'realm' when calling GetClientScopeMappingsClientComposite");
        
        // verify the required parameter 'id' is set
        if (id == null) throw new IOSwaggerClientApiException(400, "Missing required parameter 'id' when calling GetClientScopeMappingsClientComposite");
        
        // verify the required parameter '_client' is set
        if (_client == null) throw new IOSwaggerClientApiException(400, "Missing required parameter '_client' when calling GetClientScopeMappingsClientComposite");
        

        var path_ = new StringBuilder("/{realm}/clients/{id}/scope-mappings/clients/{client}/composite");
        path_ = path_.Replace("{realm}", ParameterToString(realm));
path_ = path_.Replace("{id}", ParameterToString(id));
path_ = path_.Replace("{client}", ParameterToString(_client));

        var queryParams = new Dictionary<string, string>();
        var headerParams = new Dictionary<string, string>();
        var formParams = new Dictionary<string, string>();
        var fileParams = new Dictionary<string, FileParameter>();
        object postBody = null;

         if (briefRepresentation != null) queryParams.Add("briefRepresentation", ParameterToString(briefRepresentation)); // query parameter
        
        var response = await CallApi<List<RoleRepresentation>>(path_.ToString(), HttpMethod.Get, queryParams, postBody, headerParams, formParams, fileParams, ct);
        
        return response;
    }

    /// <inheritdoc />     
    public async Task<List<RoleRepresentation>> GetClientScopeMappingsRealm(string realm, string id, CancellationToken ct)
    {
        
        // verify the required parameter 'realm' is set
        if (realm == null) throw new IOSwaggerClientApiException(400, "Missing required parameter 'realm' when calling GetClientScopeMappingsRealm");
        
        // verify the required parameter 'id' is set
        if (id == null) throw new IOSwaggerClientApiException(400, "Missing required parameter 'id' when calling GetClientScopeMappingsRealm");
        

        var path_ = new StringBuilder("/{realm}/clients/{id}/scope-mappings/realm");
        path_ = path_.Replace("{realm}", ParameterToString(realm));
path_ = path_.Replace("{id}", ParameterToString(id));

        var queryParams = new Dictionary<string, string>();
        var headerParams = new Dictionary<string, string>();
        var formParams = new Dictionary<string, string>();
        var fileParams = new Dictionary<string, FileParameter>();
        object postBody = null;

        
        var response = await CallApi<List<RoleRepresentation>>(path_.ToString(), HttpMethod.Get, queryParams, postBody, headerParams, formParams, fileParams, ct);
        
        return response;
    }

    /// <inheritdoc />     
    public async Task<List<RoleRepresentation>> GetClientScopeMappingsRealmAvailable(string realm, string id, CancellationToken ct)
    {
        
        // verify the required parameter 'realm' is set
        if (realm == null) throw new IOSwaggerClientApiException(400, "Missing required parameter 'realm' when calling GetClientScopeMappingsRealmAvailable");
        
        // verify the required parameter 'id' is set
        if (id == null) throw new IOSwaggerClientApiException(400, "Missing required parameter 'id' when calling GetClientScopeMappingsRealmAvailable");
        

        var path_ = new StringBuilder("/{realm}/clients/{id}/scope-mappings/realm/available");
        path_ = path_.Replace("{realm}", ParameterToString(realm));
path_ = path_.Replace("{id}", ParameterToString(id));

        var queryParams = new Dictionary<string, string>();
        var headerParams = new Dictionary<string, string>();
        var formParams = new Dictionary<string, string>();
        var fileParams = new Dictionary<string, FileParameter>();
        object postBody = null;

        
        var response = await CallApi<List<RoleRepresentation>>(path_.ToString(), HttpMethod.Get, queryParams, postBody, headerParams, formParams, fileParams, ct);
        
        return response;
    }

    /// <inheritdoc />     
    public async Task<List<RoleRepresentation>> GetClientScopeMappingsRealmComposite(string realm, string id, string briefRepresentation, CancellationToken ct)
    {
        
        // verify the required parameter 'realm' is set
        if (realm == null) throw new IOSwaggerClientApiException(400, "Missing required parameter 'realm' when calling GetClientScopeMappingsRealmComposite");
        
        // verify the required parameter 'id' is set
        if (id == null) throw new IOSwaggerClientApiException(400, "Missing required parameter 'id' when calling GetClientScopeMappingsRealmComposite");
        

        var path_ = new StringBuilder("/{realm}/clients/{id}/scope-mappings/realm/composite");
        path_ = path_.Replace("{realm}", ParameterToString(realm));
path_ = path_.Replace("{id}", ParameterToString(id));

        var queryParams = new Dictionary<string, string>();
        var headerParams = new Dictionary<string, string>();
        var formParams = new Dictionary<string, string>();
        var fileParams = new Dictionary<string, FileParameter>();
        object postBody = null;

         if (briefRepresentation != null) queryParams.Add("briefRepresentation", ParameterToString(briefRepresentation)); // query parameter
        
        var response = await CallApi<List<RoleRepresentation>>(path_.ToString(), HttpMethod.Get, queryParams, postBody, headerParams, formParams, fileParams, ct);
        
        return response;
    }

    /// <inheritdoc />     
    public async Task<MappingsRepresentation> GetClientScopeScopeMappings(string realm, string id, CancellationToken ct)
    {
        
        // verify the required parameter 'realm' is set
        if (realm == null) throw new IOSwaggerClientApiException(400, "Missing required parameter 'realm' when calling GetClientScopeScopeMappings");
        
        // verify the required parameter 'id' is set
        if (id == null) throw new IOSwaggerClientApiException(400, "Missing required parameter 'id' when calling GetClientScopeScopeMappings");
        

        var path_ = new StringBuilder("/{realm}/client-scopes/{id}/scope-mappings");
        path_ = path_.Replace("{realm}", ParameterToString(realm));
path_ = path_.Replace("{id}", ParameterToString(id));

        var queryParams = new Dictionary<string, string>();
        var headerParams = new Dictionary<string, string>();
        var formParams = new Dictionary<string, string>();
        var fileParams = new Dictionary<string, FileParameter>();
        object postBody = null;

        
        var response = await CallApi<MappingsRepresentation>(path_.ToString(), HttpMethod.Get, queryParams, postBody, headerParams, formParams, fileParams, ct);
        
        return response;
    }

    /// <inheritdoc />     
    public async Task<List<RoleRepresentation>> GetClientScopeScopeMappingsClient(string realm, string id, string _client, CancellationToken ct)
    {
        
        // verify the required parameter 'realm' is set
        if (realm == null) throw new IOSwaggerClientApiException(400, "Missing required parameter 'realm' when calling GetClientScopeScopeMappingsClient");
        
        // verify the required parameter 'id' is set
        if (id == null) throw new IOSwaggerClientApiException(400, "Missing required parameter 'id' when calling GetClientScopeScopeMappingsClient");
        
        // verify the required parameter '_client' is set
        if (_client == null) throw new IOSwaggerClientApiException(400, "Missing required parameter '_client' when calling GetClientScopeScopeMappingsClient");
        

        var path_ = new StringBuilder("/{realm}/client-scopes/{id}/scope-mappings/clients/{client}");
        path_ = path_.Replace("{realm}", ParameterToString(realm));
path_ = path_.Replace("{id}", ParameterToString(id));
path_ = path_.Replace("{client}", ParameterToString(_client));

        var queryParams = new Dictionary<string, string>();
        var headerParams = new Dictionary<string, string>();
        var formParams = new Dictionary<string, string>();
        var fileParams = new Dictionary<string, FileParameter>();
        object postBody = null;

        
        var response = await CallApi<List<RoleRepresentation>>(path_.ToString(), HttpMethod.Get, queryParams, postBody, headerParams, formParams, fileParams, ct);
        
        return response;
    }

    /// <inheritdoc />     
    public async Task<List<RoleRepresentation>> GetClientScopeScopeMappingsClientAvailable(string realm, string id, string _client, CancellationToken ct)
    {
        
        // verify the required parameter 'realm' is set
        if (realm == null) throw new IOSwaggerClientApiException(400, "Missing required parameter 'realm' when calling GetClientScopeScopeMappingsClientAvailable");
        
        // verify the required parameter 'id' is set
        if (id == null) throw new IOSwaggerClientApiException(400, "Missing required parameter 'id' when calling GetClientScopeScopeMappingsClientAvailable");
        
        // verify the required parameter '_client' is set
        if (_client == null) throw new IOSwaggerClientApiException(400, "Missing required parameter '_client' when calling GetClientScopeScopeMappingsClientAvailable");
        

        var path_ = new StringBuilder("/{realm}/client-scopes/{id}/scope-mappings/clients/{client}/available");
        path_ = path_.Replace("{realm}", ParameterToString(realm));
path_ = path_.Replace("{id}", ParameterToString(id));
path_ = path_.Replace("{client}", ParameterToString(_client));

        var queryParams = new Dictionary<string, string>();
        var headerParams = new Dictionary<string, string>();
        var formParams = new Dictionary<string, string>();
        var fileParams = new Dictionary<string, FileParameter>();
        object postBody = null;

        
        var response = await CallApi<List<RoleRepresentation>>(path_.ToString(), HttpMethod.Get, queryParams, postBody, headerParams, formParams, fileParams, ct);
        
        return response;
    }

    /// <inheritdoc />     
    public async Task<List<RoleRepresentation>> GetClientScopeScopeMappingsClientComposite(string realm, string id, string _client, string briefRepresentation, CancellationToken ct)
    {
        
        // verify the required parameter 'realm' is set
        if (realm == null) throw new IOSwaggerClientApiException(400, "Missing required parameter 'realm' when calling GetClientScopeScopeMappingsClientComposite");
        
        // verify the required parameter 'id' is set
        if (id == null) throw new IOSwaggerClientApiException(400, "Missing required parameter 'id' when calling GetClientScopeScopeMappingsClientComposite");
        
        // verify the required parameter '_client' is set
        if (_client == null) throw new IOSwaggerClientApiException(400, "Missing required parameter '_client' when calling GetClientScopeScopeMappingsClientComposite");
        

        var path_ = new StringBuilder("/{realm}/client-scopes/{id}/scope-mappings/clients/{client}/composite");
        path_ = path_.Replace("{realm}", ParameterToString(realm));
path_ = path_.Replace("{id}", ParameterToString(id));
path_ = path_.Replace("{client}", ParameterToString(_client));

        var queryParams = new Dictionary<string, string>();
        var headerParams = new Dictionary<string, string>();
        var formParams = new Dictionary<string, string>();
        var fileParams = new Dictionary<string, FileParameter>();
        object postBody = null;

         if (briefRepresentation != null) queryParams.Add("briefRepresentation", ParameterToString(briefRepresentation)); // query parameter
        
        var response = await CallApi<List<RoleRepresentation>>(path_.ToString(), HttpMethod.Get, queryParams, postBody, headerParams, formParams, fileParams, ct);
        
        return response;
    }

    /// <inheritdoc />     
    public async Task<List<RoleRepresentation>> GetClientScopeScopeMappingsRealm(string realm, string id, CancellationToken ct)
    {
        
        // verify the required parameter 'realm' is set
        if (realm == null) throw new IOSwaggerClientApiException(400, "Missing required parameter 'realm' when calling GetClientScopeScopeMappingsRealm");
        
        // verify the required parameter 'id' is set
        if (id == null) throw new IOSwaggerClientApiException(400, "Missing required parameter 'id' when calling GetClientScopeScopeMappingsRealm");
        

        var path_ = new StringBuilder("/{realm}/client-scopes/{id}/scope-mappings/realm");
        path_ = path_.Replace("{realm}", ParameterToString(realm));
path_ = path_.Replace("{id}", ParameterToString(id));

        var queryParams = new Dictionary<string, string>();
        var headerParams = new Dictionary<string, string>();
        var formParams = new Dictionary<string, string>();
        var fileParams = new Dictionary<string, FileParameter>();
        object postBody = null;

        
        var response = await CallApi<List<RoleRepresentation>>(path_.ToString(), HttpMethod.Get, queryParams, postBody, headerParams, formParams, fileParams, ct);
        
        return response;
    }

    /// <inheritdoc />     
    public async Task<List<RoleRepresentation>> GetClientScopeScopeMappingsRealmAvailable(string realm, string id, CancellationToken ct)
    {
        
        // verify the required parameter 'realm' is set
        if (realm == null) throw new IOSwaggerClientApiException(400, "Missing required parameter 'realm' when calling GetClientScopeScopeMappingsRealmAvailable");
        
        // verify the required parameter 'id' is set
        if (id == null) throw new IOSwaggerClientApiException(400, "Missing required parameter 'id' when calling GetClientScopeScopeMappingsRealmAvailable");
        

        var path_ = new StringBuilder("/{realm}/client-scopes/{id}/scope-mappings/realm/available");
        path_ = path_.Replace("{realm}", ParameterToString(realm));
path_ = path_.Replace("{id}", ParameterToString(id));

        var queryParams = new Dictionary<string, string>();
        var headerParams = new Dictionary<string, string>();
        var formParams = new Dictionary<string, string>();
        var fileParams = new Dictionary<string, FileParameter>();
        object postBody = null;

        
        var response = await CallApi<List<RoleRepresentation>>(path_.ToString(), HttpMethod.Get, queryParams, postBody, headerParams, formParams, fileParams, ct);
        
        return response;
    }

    /// <inheritdoc />     
    public async Task<List<RoleRepresentation>> GetClientScopeScopeMappingsRealmComposite(string realm, string id, string briefRepresentation, CancellationToken ct)
    {
        
        // verify the required parameter 'realm' is set
        if (realm == null) throw new IOSwaggerClientApiException(400, "Missing required parameter 'realm' when calling GetClientScopeScopeMappingsRealmComposite");
        
        // verify the required parameter 'id' is set
        if (id == null) throw new IOSwaggerClientApiException(400, "Missing required parameter 'id' when calling GetClientScopeScopeMappingsRealmComposite");
        

        var path_ = new StringBuilder("/{realm}/client-scopes/{id}/scope-mappings/realm/composite");
        path_ = path_.Replace("{realm}", ParameterToString(realm));
path_ = path_.Replace("{id}", ParameterToString(id));

        var queryParams = new Dictionary<string, string>();
        var headerParams = new Dictionary<string, string>();
        var formParams = new Dictionary<string, string>();
        var fileParams = new Dictionary<string, FileParameter>();
        object postBody = null;

         if (briefRepresentation != null) queryParams.Add("briefRepresentation", ParameterToString(briefRepresentation)); // query parameter
        
        var response = await CallApi<List<RoleRepresentation>>(path_.ToString(), HttpMethod.Get, queryParams, postBody, headerParams, formParams, fileParams, ct);
        
        return response;
    }

    /// <inheritdoc />     
    public async Task<MappingsRepresentation> GetClientTemplateScopeMappings(string realm, string id, CancellationToken ct)
    {
        
        // verify the required parameter 'realm' is set
        if (realm == null) throw new IOSwaggerClientApiException(400, "Missing required parameter 'realm' when calling GetClientTemplateScopeMappings");
        
        // verify the required parameter 'id' is set
        if (id == null) throw new IOSwaggerClientApiException(400, "Missing required parameter 'id' when calling GetClientTemplateScopeMappings");
        

        var path_ = new StringBuilder("/{realm}/client-templates/{id}/scope-mappings");
        path_ = path_.Replace("{realm}", ParameterToString(realm));
path_ = path_.Replace("{id}", ParameterToString(id));

        var queryParams = new Dictionary<string, string>();
        var headerParams = new Dictionary<string, string>();
        var formParams = new Dictionary<string, string>();
        var fileParams = new Dictionary<string, FileParameter>();
        object postBody = null;

        
        var response = await CallApi<MappingsRepresentation>(path_.ToString(), HttpMethod.Get, queryParams, postBody, headerParams, formParams, fileParams, ct);
        
        return response;
    }

    /// <inheritdoc />     
    public async Task<List<RoleRepresentation>> GetClientTemplateScopeMappingsClient(string realm, string id, string _client, CancellationToken ct)
    {
        
        // verify the required parameter 'realm' is set
        if (realm == null) throw new IOSwaggerClientApiException(400, "Missing required parameter 'realm' when calling GetClientTemplateScopeMappingsClient");
        
        // verify the required parameter 'id' is set
        if (id == null) throw new IOSwaggerClientApiException(400, "Missing required parameter 'id' when calling GetClientTemplateScopeMappingsClient");
        
        // verify the required parameter '_client' is set
        if (_client == null) throw new IOSwaggerClientApiException(400, "Missing required parameter '_client' when calling GetClientTemplateScopeMappingsClient");
        

        var path_ = new StringBuilder("/{realm}/client-templates/{id}/scope-mappings/clients/{client}");
        path_ = path_.Replace("{realm}", ParameterToString(realm));
path_ = path_.Replace("{id}", ParameterToString(id));
path_ = path_.Replace("{client}", ParameterToString(_client));

        var queryParams = new Dictionary<string, string>();
        var headerParams = new Dictionary<string, string>();
        var formParams = new Dictionary<string, string>();
        var fileParams = new Dictionary<string, FileParameter>();
        object postBody = null;

        
        var response = await CallApi<List<RoleRepresentation>>(path_.ToString(), HttpMethod.Get, queryParams, postBody, headerParams, formParams, fileParams, ct);
        
        return response;
    }

    /// <inheritdoc />     
    public async Task<List<RoleRepresentation>> GetClientTemplateScopeMappingsClientAvailable(string realm, string id, string _client, CancellationToken ct)
    {
        
        // verify the required parameter 'realm' is set
        if (realm == null) throw new IOSwaggerClientApiException(400, "Missing required parameter 'realm' when calling GetClientTemplateScopeMappingsClientAvailable");
        
        // verify the required parameter 'id' is set
        if (id == null) throw new IOSwaggerClientApiException(400, "Missing required parameter 'id' when calling GetClientTemplateScopeMappingsClientAvailable");
        
        // verify the required parameter '_client' is set
        if (_client == null) throw new IOSwaggerClientApiException(400, "Missing required parameter '_client' when calling GetClientTemplateScopeMappingsClientAvailable");
        

        var path_ = new StringBuilder("/{realm}/client-templates/{id}/scope-mappings/clients/{client}/available");
        path_ = path_.Replace("{realm}", ParameterToString(realm));
path_ = path_.Replace("{id}", ParameterToString(id));
path_ = path_.Replace("{client}", ParameterToString(_client));

        var queryParams = new Dictionary<string, string>();
        var headerParams = new Dictionary<string, string>();
        var formParams = new Dictionary<string, string>();
        var fileParams = new Dictionary<string, FileParameter>();
        object postBody = null;

        
        var response = await CallApi<List<RoleRepresentation>>(path_.ToString(), HttpMethod.Get, queryParams, postBody, headerParams, formParams, fileParams, ct);
        
        return response;
    }

    /// <inheritdoc />     
    public async Task<List<RoleRepresentation>> GetClientTemplateScopeMappingsClientComposite(string realm, string id, string _client, string briefRepresentation, CancellationToken ct)
    {
        
        // verify the required parameter 'realm' is set
        if (realm == null) throw new IOSwaggerClientApiException(400, "Missing required parameter 'realm' when calling GetClientTemplateScopeMappingsClientComposite");
        
        // verify the required parameter 'id' is set
        if (id == null) throw new IOSwaggerClientApiException(400, "Missing required parameter 'id' when calling GetClientTemplateScopeMappingsClientComposite");
        
        // verify the required parameter '_client' is set
        if (_client == null) throw new IOSwaggerClientApiException(400, "Missing required parameter '_client' when calling GetClientTemplateScopeMappingsClientComposite");
        

        var path_ = new StringBuilder("/{realm}/client-templates/{id}/scope-mappings/clients/{client}/composite");
        path_ = path_.Replace("{realm}", ParameterToString(realm));
path_ = path_.Replace("{id}", ParameterToString(id));
path_ = path_.Replace("{client}", ParameterToString(_client));

        var queryParams = new Dictionary<string, string>();
        var headerParams = new Dictionary<string, string>();
        var formParams = new Dictionary<string, string>();
        var fileParams = new Dictionary<string, FileParameter>();
        object postBody = null;

         if (briefRepresentation != null) queryParams.Add("briefRepresentation", ParameterToString(briefRepresentation)); // query parameter
        
        var response = await CallApi<List<RoleRepresentation>>(path_.ToString(), HttpMethod.Get, queryParams, postBody, headerParams, formParams, fileParams, ct);
        
        return response;
    }

    /// <inheritdoc />     
    public async Task<List<RoleRepresentation>> GetClientTemplateScopeMappingsRealm(string realm, string id, CancellationToken ct)
    {
        
        // verify the required parameter 'realm' is set
        if (realm == null) throw new IOSwaggerClientApiException(400, "Missing required parameter 'realm' when calling GetClientTemplateScopeMappingsRealm");
        
        // verify the required parameter 'id' is set
        if (id == null) throw new IOSwaggerClientApiException(400, "Missing required parameter 'id' when calling GetClientTemplateScopeMappingsRealm");
        

        var path_ = new StringBuilder("/{realm}/client-templates/{id}/scope-mappings/realm");
        path_ = path_.Replace("{realm}", ParameterToString(realm));
path_ = path_.Replace("{id}", ParameterToString(id));

        var queryParams = new Dictionary<string, string>();
        var headerParams = new Dictionary<string, string>();
        var formParams = new Dictionary<string, string>();
        var fileParams = new Dictionary<string, FileParameter>();
        object postBody = null;

        
        var response = await CallApi<List<RoleRepresentation>>(path_.ToString(), HttpMethod.Get, queryParams, postBody, headerParams, formParams, fileParams, ct);
        
        return response;
    }

    /// <inheritdoc />     
    public async Task<List<RoleRepresentation>> GetClientTemplateScopeMappingsRealmAvailable(string realm, string id, CancellationToken ct)
    {
        
        // verify the required parameter 'realm' is set
        if (realm == null) throw new IOSwaggerClientApiException(400, "Missing required parameter 'realm' when calling GetClientTemplateScopeMappingsRealmAvailable");
        
        // verify the required parameter 'id' is set
        if (id == null) throw new IOSwaggerClientApiException(400, "Missing required parameter 'id' when calling GetClientTemplateScopeMappingsRealmAvailable");
        

        var path_ = new StringBuilder("/{realm}/client-templates/{id}/scope-mappings/realm/available");
        path_ = path_.Replace("{realm}", ParameterToString(realm));
path_ = path_.Replace("{id}", ParameterToString(id));

        var queryParams = new Dictionary<string, string>();
        var headerParams = new Dictionary<string, string>();
        var formParams = new Dictionary<string, string>();
        var fileParams = new Dictionary<string, FileParameter>();
        object postBody = null;

        
        var response = await CallApi<List<RoleRepresentation>>(path_.ToString(), HttpMethod.Get, queryParams, postBody, headerParams, formParams, fileParams, ct);
        
        return response;
    }

    /// <inheritdoc />     
    public async Task<List<RoleRepresentation>> GetClientTemplateScopeMappingsRealmComposite(string realm, string id, string briefRepresentation, CancellationToken ct)
    {
        
        // verify the required parameter 'realm' is set
        if (realm == null) throw new IOSwaggerClientApiException(400, "Missing required parameter 'realm' when calling GetClientTemplateScopeMappingsRealmComposite");
        
        // verify the required parameter 'id' is set
        if (id == null) throw new IOSwaggerClientApiException(400, "Missing required parameter 'id' when calling GetClientTemplateScopeMappingsRealmComposite");
        

        var path_ = new StringBuilder("/{realm}/client-templates/{id}/scope-mappings/realm/composite");
        path_ = path_.Replace("{realm}", ParameterToString(realm));
path_ = path_.Replace("{id}", ParameterToString(id));

        var queryParams = new Dictionary<string, string>();
        var headerParams = new Dictionary<string, string>();
        var formParams = new Dictionary<string, string>();
        var fileParams = new Dictionary<string, FileParameter>();
        object postBody = null;

         if (briefRepresentation != null) queryParams.Add("briefRepresentation", ParameterToString(briefRepresentation)); // query parameter
        
        var response = await CallApi<List<RoleRepresentation>>(path_.ToString(), HttpMethod.Get, queryParams, postBody, headerParams, formParams, fileParams, ct);
        
        return response;
    }

    /// <inheritdoc />     
    public async Task PostClientScopeMappingsClient(string realm, string id, string _client, RoleRepresentation body, CancellationToken ct)
    {
        
        // verify the required parameter 'realm' is set
        if (realm == null) throw new IOSwaggerClientApiException(400, "Missing required parameter 'realm' when calling PostClientScopeMappingsClient");
        
        // verify the required parameter 'id' is set
        if (id == null) throw new IOSwaggerClientApiException(400, "Missing required parameter 'id' when calling PostClientScopeMappingsClient");
        
        // verify the required parameter '_client' is set
        if (_client == null) throw new IOSwaggerClientApiException(400, "Missing required parameter '_client' when calling PostClientScopeMappingsClient");
        

        var path_ = new StringBuilder("/{realm}/clients/{id}/scope-mappings/clients/{client}");
        path_ = path_.Replace("{realm}", ParameterToString(realm));
path_ = path_.Replace("{id}", ParameterToString(id));
path_ = path_.Replace("{client}", ParameterToString(_client));

        var queryParams = new Dictionary<string, string>();
        var headerParams = new Dictionary<string, string>();
        var formParams = new Dictionary<string, string>();
        var fileParams = new Dictionary<string, FileParameter>();
        object postBody = null;

        postBody = body; // http body (model) parameter

        await CallApi(path_.ToString(), HttpMethod.Post, queryParams, postBody, headerParams, formParams, fileParams, ct);
    }

    /// <inheritdoc />     
    public async Task PostClientScopeMappingsRealm(string realm, string id, RoleRepresentation body, CancellationToken ct)
    {
        
        // verify the required parameter 'realm' is set
        if (realm == null) throw new IOSwaggerClientApiException(400, "Missing required parameter 'realm' when calling PostClientScopeMappingsRealm");
        
        // verify the required parameter 'id' is set
        if (id == null) throw new IOSwaggerClientApiException(400, "Missing required parameter 'id' when calling PostClientScopeMappingsRealm");
        

        var path_ = new StringBuilder("/{realm}/clients/{id}/scope-mappings/realm");
        path_ = path_.Replace("{realm}", ParameterToString(realm));
path_ = path_.Replace("{id}", ParameterToString(id));

        var queryParams = new Dictionary<string, string>();
        var headerParams = new Dictionary<string, string>();
        var formParams = new Dictionary<string, string>();
        var fileParams = new Dictionary<string, FileParameter>();
        object postBody = null;

        postBody = body; // http body (model) parameter

        await CallApi(path_.ToString(), HttpMethod.Post, queryParams, postBody, headerParams, formParams, fileParams, ct);
    }

    /// <inheritdoc />     
    public async Task PostClientScopeScopeMappingsClient(string realm, string id, string _client, RoleRepresentation body, CancellationToken ct)
    {
        
        // verify the required parameter 'realm' is set
        if (realm == null) throw new IOSwaggerClientApiException(400, "Missing required parameter 'realm' when calling PostClientScopeScopeMappingsClient");
        
        // verify the required parameter 'id' is set
        if (id == null) throw new IOSwaggerClientApiException(400, "Missing required parameter 'id' when calling PostClientScopeScopeMappingsClient");
        
        // verify the required parameter '_client' is set
        if (_client == null) throw new IOSwaggerClientApiException(400, "Missing required parameter '_client' when calling PostClientScopeScopeMappingsClient");
        

        var path_ = new StringBuilder("/{realm}/client-scopes/{id}/scope-mappings/clients/{client}");
        path_ = path_.Replace("{realm}", ParameterToString(realm));
path_ = path_.Replace("{id}", ParameterToString(id));
path_ = path_.Replace("{client}", ParameterToString(_client));

        var queryParams = new Dictionary<string, string>();
        var headerParams = new Dictionary<string, string>();
        var formParams = new Dictionary<string, string>();
        var fileParams = new Dictionary<string, FileParameter>();
        object postBody = null;

        postBody = body; // http body (model) parameter

        await CallApi(path_.ToString(), HttpMethod.Post, queryParams, postBody, headerParams, formParams, fileParams, ct);
    }

    /// <inheritdoc />     
    public async Task PostClientScopeScopeMappingsRealm(string realm, string id, RoleRepresentation body, CancellationToken ct)
    {
        
        // verify the required parameter 'realm' is set
        if (realm == null) throw new IOSwaggerClientApiException(400, "Missing required parameter 'realm' when calling PostClientScopeScopeMappingsRealm");
        
        // verify the required parameter 'id' is set
        if (id == null) throw new IOSwaggerClientApiException(400, "Missing required parameter 'id' when calling PostClientScopeScopeMappingsRealm");
        

        var path_ = new StringBuilder("/{realm}/client-scopes/{id}/scope-mappings/realm");
        path_ = path_.Replace("{realm}", ParameterToString(realm));
path_ = path_.Replace("{id}", ParameterToString(id));

        var queryParams = new Dictionary<string, string>();
        var headerParams = new Dictionary<string, string>();
        var formParams = new Dictionary<string, string>();
        var fileParams = new Dictionary<string, FileParameter>();
        object postBody = null;

        postBody = body; // http body (model) parameter

        await CallApi(path_.ToString(), HttpMethod.Post, queryParams, postBody, headerParams, formParams, fileParams, ct);
    }

    /// <inheritdoc />     
    public async Task PostClientTemplateScopeMappingsClient(string realm, string id, string _client, RoleRepresentation body, CancellationToken ct)
    {
        
        // verify the required parameter 'realm' is set
        if (realm == null) throw new IOSwaggerClientApiException(400, "Missing required parameter 'realm' when calling PostClientTemplateScopeMappingsClient");
        
        // verify the required parameter 'id' is set
        if (id == null) throw new IOSwaggerClientApiException(400, "Missing required parameter 'id' when calling PostClientTemplateScopeMappingsClient");
        
        // verify the required parameter '_client' is set
        if (_client == null) throw new IOSwaggerClientApiException(400, "Missing required parameter '_client' when calling PostClientTemplateScopeMappingsClient");
        

        var path_ = new StringBuilder("/{realm}/client-templates/{id}/scope-mappings/clients/{client}");
        path_ = path_.Replace("{realm}", ParameterToString(realm));
path_ = path_.Replace("{id}", ParameterToString(id));
path_ = path_.Replace("{client}", ParameterToString(_client));

        var queryParams = new Dictionary<string, string>();
        var headerParams = new Dictionary<string, string>();
        var formParams = new Dictionary<string, string>();
        var fileParams = new Dictionary<string, FileParameter>();
        object postBody = null;

        postBody = body; // http body (model) parameter

        await CallApi(path_.ToString(), HttpMethod.Post, queryParams, postBody, headerParams, formParams, fileParams, ct);
    }

    /// <inheritdoc />     
    public async Task PostClientTemplateScopeMappingsRealm(string realm, string id, RoleRepresentation body, CancellationToken ct)
    {
        
        // verify the required parameter 'realm' is set
        if (realm == null) throw new IOSwaggerClientApiException(400, "Missing required parameter 'realm' when calling PostClientTemplateScopeMappingsRealm");
        
        // verify the required parameter 'id' is set
        if (id == null) throw new IOSwaggerClientApiException(400, "Missing required parameter 'id' when calling PostClientTemplateScopeMappingsRealm");
        

        var path_ = new StringBuilder("/{realm}/client-templates/{id}/scope-mappings/realm");
        path_ = path_.Replace("{realm}", ParameterToString(realm));
path_ = path_.Replace("{id}", ParameterToString(id));

        var queryParams = new Dictionary<string, string>();
        var headerParams = new Dictionary<string, string>();
        var formParams = new Dictionary<string, string>();
        var fileParams = new Dictionary<string, FileParameter>();
        object postBody = null;

        postBody = body; // http body (model) parameter

        await CallApi(path_.ToString(), HttpMethod.Post, queryParams, postBody, headerParams, formParams, fileParams, ct);
    }

}
