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
public partial interface IProtocolMappersApi
{
    /// <summary>
    ///  Delete the mapper
    /// </summary>
    /// <param name="realm">realm name (not id!)</param>
    /// <param name="id1"></param>
    /// <param name="id2"></param>
    /// <param name="ct"></param>
    /// <returns></returns>
    Task DeleteClientProtocolMappersModel (string realm, string id1, string id2, CancellationToken ct);
    /// <summary>
    ///  Delete the mapper
    /// </summary>
    /// <param name="realm">realm name (not id!)</param>
    /// <param name="id1"></param>
    /// <param name="id2"></param>
    /// <param name="ct"></param>
    /// <returns></returns>
    Task DeleteClientScopeProtocolMappersModel (string realm, string id1, string id2, CancellationToken ct);
    /// <summary>
    ///  Delete the mapper
    /// </summary>
    /// <param name="realm">realm name (not id!)</param>
    /// <param name="id1"></param>
    /// <param name="id2"></param>
    /// <param name="ct"></param>
    /// <returns></returns>
    Task DeleteClientTemplateProtocolMappersModel (string realm, string id1, string id2, CancellationToken ct);
    /// <summary>
    ///  Get mapper by id
    /// </summary>
    /// <param name="realm">realm name (not id!)</param>
    /// <param name="id1"></param>
    /// <param name="id2"></param>
    /// <param name="ct"></param>
    /// <returns>ProtocolMapperRepresentation</returns>
    Task<ProtocolMapperRepresentation> GetClientProtocolMappersModel (string realm, string id1, string id2, CancellationToken ct);
    /// <summary>
    ///  Get mappers
    /// </summary>
    /// <param name="realm">realm name (not id!)</param>
    /// <param name="id"></param>
    /// <param name="ct"></param>
    /// <returns>List&lt;ProtocolMapperRepresentation&gt;</returns>
    Task<List<ProtocolMapperRepresentation>> GetClientProtocolMappersModels (string realm, string id, CancellationToken ct);
    /// <summary>
    ///  Get mappers by name for a specific protocol
    /// </summary>
    /// <param name="realm">realm name (not id!)</param>
    /// <param name="id"></param>
    /// <param name="protocol"></param>
    /// <param name="ct"></param>
    /// <returns>List&lt;ProtocolMapperRepresentation&gt;</returns>
    Task<List<ProtocolMapperRepresentation>> GetClientProtocolMappersProtocol (string realm, string id, string protocol, CancellationToken ct);
    /// <summary>
    ///  Get mapper by id
    /// </summary>
    /// <param name="realm">realm name (not id!)</param>
    /// <param name="id1"></param>
    /// <param name="id2"></param>
    /// <param name="ct"></param>
    /// <returns>ProtocolMapperRepresentation</returns>
    Task<ProtocolMapperRepresentation> GetClientScopeProtocolMappersModel (string realm, string id1, string id2, CancellationToken ct);
    /// <summary>
    ///  Get mappers
    /// </summary>
    /// <param name="realm">realm name (not id!)</param>
    /// <param name="id"></param>
    /// <param name="ct"></param>
    /// <returns>List&lt;ProtocolMapperRepresentation&gt;</returns>
    Task<List<ProtocolMapperRepresentation>> GetClientScopeProtocolMappersModels (string realm, string id, CancellationToken ct);
    /// <summary>
    ///  Get mappers by name for a specific protocol
    /// </summary>
    /// <param name="realm">realm name (not id!)</param>
    /// <param name="id"></param>
    /// <param name="protocol"></param>
    /// <param name="ct"></param>
    /// <returns>List&lt;ProtocolMapperRepresentation&gt;</returns>
    Task<List<ProtocolMapperRepresentation>> GetClientScopeProtocolMappersProtocol (string realm, string id, string protocol, CancellationToken ct);
    /// <summary>
    ///  Get mapper by id
    /// </summary>
    /// <param name="realm">realm name (not id!)</param>
    /// <param name="id1"></param>
    /// <param name="id2"></param>
    /// <param name="ct"></param>
    /// <returns>ProtocolMapperRepresentation</returns>
    Task<ProtocolMapperRepresentation> GetClientTemplateProtocolMappersModel (string realm, string id1, string id2, CancellationToken ct);
    /// <summary>
    ///  Get mappers
    /// </summary>
    /// <param name="realm">realm name (not id!)</param>
    /// <param name="id"></param>
    /// <param name="ct"></param>
    /// <returns>List&lt;ProtocolMapperRepresentation&gt;</returns>
    Task<List<ProtocolMapperRepresentation>> GetClientTemplateProtocolMappersModels (string realm, string id, CancellationToken ct);
    /// <summary>
    ///  Get mappers by name for a specific protocol
    /// </summary>
    /// <param name="realm">realm name (not id!)</param>
    /// <param name="id"></param>
    /// <param name="protocol"></param>
    /// <param name="ct"></param>
    /// <returns>List&lt;ProtocolMapperRepresentation&gt;</returns>
    Task<List<ProtocolMapperRepresentation>> GetClientTemplateProtocolMappersProtocol (string realm, string id, string protocol, CancellationToken ct);
    /// <summary>
    ///  Create multiple mappers
    /// </summary>
    /// <param name="realm">realm name (not id!)</param>
    /// <param name="id"></param>
    /// <param name="body">ProtocolMapperRepresentation</param>
    /// <param name="ct"></param>
    /// <returns></returns>
    Task PostClientProtocolMappersAddModels (string realm, string id, ProtocolMapperRepresentation body, CancellationToken ct);
    /// <summary>
    ///  Create a mapper
    /// </summary>
    /// <param name="realm">realm name (not id!)</param>
    /// <param name="id"></param>
    /// <param name="body">ProtocolMapperRepresentation</param>
    /// <param name="ct"></param>
    /// <returns></returns>
    Task PostClientProtocolMappersModels (string realm, string id, ProtocolMapperRepresentation body, CancellationToken ct);
    /// <summary>
    ///  Create multiple mappers
    /// </summary>
    /// <param name="realm">realm name (not id!)</param>
    /// <param name="id"></param>
    /// <param name="body">ProtocolMapperRepresentation</param>
    /// <param name="ct"></param>
    /// <returns></returns>
    Task PostClientScopeProtocolMappersAddModels (string realm, string id, ProtocolMapperRepresentation body, CancellationToken ct);
    /// <summary>
    ///  Create a mapper
    /// </summary>
    /// <param name="realm">realm name (not id!)</param>
    /// <param name="id"></param>
    /// <param name="body">ProtocolMapperRepresentation</param>
    /// <param name="ct"></param>
    /// <returns></returns>
    Task PostClientScopeProtocolMappersModels (string realm, string id, ProtocolMapperRepresentation body, CancellationToken ct);
    /// <summary>
    ///  Create multiple mappers
    /// </summary>
    /// <param name="realm">realm name (not id!)</param>
    /// <param name="id"></param>
    /// <param name="body">ProtocolMapperRepresentation</param>
    /// <param name="ct"></param>
    /// <returns></returns>
    Task PostClientTemplateProtocolMappersAddModels (string realm, string id, ProtocolMapperRepresentation body, CancellationToken ct);
    /// <summary>
    ///  Create a mapper
    /// </summary>
    /// <param name="realm">realm name (not id!)</param>
    /// <param name="id"></param>
    /// <param name="body">ProtocolMapperRepresentation</param>
    /// <param name="ct"></param>
    /// <returns></returns>
    Task PostClientTemplateProtocolMappersModels (string realm, string id, ProtocolMapperRepresentation body, CancellationToken ct);
    /// <summary>
    ///  Update the mapper
    /// </summary>
    /// <param name="realm">realm name (not id!)</param>
    /// <param name="id1"></param>
    /// <param name="id2"></param>
    /// <param name="body">ProtocolMapperRepresentation</param>
    /// <param name="ct"></param>
    /// <returns></returns>
    Task PutClientProtocolMappersModel (string realm, string id1, string id2, ProtocolMapperRepresentation body, CancellationToken ct);
    /// <summary>
    ///  Update the mapper
    /// </summary>
    /// <param name="realm">realm name (not id!)</param>
    /// <param name="id1"></param>
    /// <param name="id2"></param>
    /// <param name="body">ProtocolMapperRepresentation</param>
    /// <param name="ct"></param>
    /// <returns></returns>
    Task PutClientScopeProtocolMappersModel (string realm, string id1, string id2, ProtocolMapperRepresentation body, CancellationToken ct);
    /// <summary>
    ///  Update the mapper
    /// </summary>
    /// <param name="realm">realm name (not id!)</param>
    /// <param name="id1"></param>
    /// <param name="id2"></param>
    /// <param name="body">ProtocolMapperRepresentation</param>
    /// <param name="ct"></param>
    /// <returns></returns>
    Task PutClientTemplateProtocolMappersModel (string realm, string id1, string id2, ProtocolMapperRepresentation body, CancellationToken ct);
}

/// <summary>
/// Represents a collection of functions to interact with the API endpoints
/// </summary>  
[GeneratedCode("swagger-codegen", "3.0.56-SNAPSHOT")]
public partial class ProtocolMappersApi : PetShopApiClientBase, IProtocolMappersApi
{
    /// <summary>
    /// Initializes a new instance of the <see cref="ProtocolMappersApi"/> class.
    /// </summary>
    /// <param name="httpClient"> HttpClient to be used for calls. </param>
    /// <param name="basePath"> Base url to be used for calls. </param>
    public ProtocolMappersApi(HttpClient httpClient, String basePath="https://keycloak.example.com/admin/realms") : base(httpClient, basePath)
    {
    }

    /// <inheritdoc />     
    public async Task DeleteClientProtocolMappersModel(string realm, string id1, string id2, CancellationToken ct)
    {
        // verify the required parameter 'realm' is set
        if (realm == null) throw new PetShopApiException(400, "Missing required parameter 'realm' when calling DeleteClientProtocolMappersModel");
        // verify the required parameter 'id1' is set
        if (id1 == null) throw new PetShopApiException(400, "Missing required parameter 'id1' when calling DeleteClientProtocolMappersModel");
        // verify the required parameter 'id2' is set
        if (id2 == null) throw new PetShopApiException(400, "Missing required parameter 'id2' when calling DeleteClientProtocolMappersModel");
        
        var path_ = new StringBuilder("/{realm}/clients/{id1}/protocol-mappers/models/{id2}"); 
        path_ = path_.Replace("{realm}", ParameterToString(realm));
        path_ = path_.Replace("{id1}", ParameterToString(id1));
        path_ = path_.Replace("{id2}", ParameterToString(id2));

        
        
        await CallApi(
                    path_.ToString(), 
                    HttpMethod.Delete,  
                    ct: ct
        );
    }

    /// <inheritdoc />     
    public async Task DeleteClientScopeProtocolMappersModel(string realm, string id1, string id2, CancellationToken ct)
    {
        // verify the required parameter 'realm' is set
        if (realm == null) throw new PetShopApiException(400, "Missing required parameter 'realm' when calling DeleteClientScopeProtocolMappersModel");
        // verify the required parameter 'id1' is set
        if (id1 == null) throw new PetShopApiException(400, "Missing required parameter 'id1' when calling DeleteClientScopeProtocolMappersModel");
        // verify the required parameter 'id2' is set
        if (id2 == null) throw new PetShopApiException(400, "Missing required parameter 'id2' when calling DeleteClientScopeProtocolMappersModel");
        
        var path_ = new StringBuilder("/{realm}/client-scopes/{id1}/protocol-mappers/models/{id2}"); 
        path_ = path_.Replace("{realm}", ParameterToString(realm));
        path_ = path_.Replace("{id1}", ParameterToString(id1));
        path_ = path_.Replace("{id2}", ParameterToString(id2));

        
        
        await CallApi(
                    path_.ToString(), 
                    HttpMethod.Delete,  
                    ct: ct
        );
    }

    /// <inheritdoc />     
    public async Task DeleteClientTemplateProtocolMappersModel(string realm, string id1, string id2, CancellationToken ct)
    {
        // verify the required parameter 'realm' is set
        if (realm == null) throw new PetShopApiException(400, "Missing required parameter 'realm' when calling DeleteClientTemplateProtocolMappersModel");
        // verify the required parameter 'id1' is set
        if (id1 == null) throw new PetShopApiException(400, "Missing required parameter 'id1' when calling DeleteClientTemplateProtocolMappersModel");
        // verify the required parameter 'id2' is set
        if (id2 == null) throw new PetShopApiException(400, "Missing required parameter 'id2' when calling DeleteClientTemplateProtocolMappersModel");
        
        var path_ = new StringBuilder("/{realm}/client-templates/{id1}/protocol-mappers/models/{id2}"); 
        path_ = path_.Replace("{realm}", ParameterToString(realm));
        path_ = path_.Replace("{id1}", ParameterToString(id1));
        path_ = path_.Replace("{id2}", ParameterToString(id2));

        
        
        await CallApi(
                    path_.ToString(), 
                    HttpMethod.Delete,  
                    ct: ct
        );
    }

    /// <inheritdoc />     
    public async Task<ProtocolMapperRepresentation> GetClientProtocolMappersModel(string realm, string id1, string id2, CancellationToken ct)
    {
        // verify the required parameter 'realm' is set
        if (realm == null) throw new PetShopApiException(400, "Missing required parameter 'realm' when calling GetClientProtocolMappersModel");
        // verify the required parameter 'id1' is set
        if (id1 == null) throw new PetShopApiException(400, "Missing required parameter 'id1' when calling GetClientProtocolMappersModel");
        // verify the required parameter 'id2' is set
        if (id2 == null) throw new PetShopApiException(400, "Missing required parameter 'id2' when calling GetClientProtocolMappersModel");
        
        var path_ = new StringBuilder("/{realm}/clients/{id1}/protocol-mappers/models/{id2}"); 
        path_ = path_.Replace("{realm}", ParameterToString(realm));
        path_ = path_.Replace("{id1}", ParameterToString(id1));
        path_ = path_.Replace("{id2}", ParameterToString(id2));

        
        
        var response = await CallApi<ProtocolMapperRepresentation>(
                    path_.ToString(), 
                    HttpMethod.Get,  
                    ct: ct
        );
        return response;
    }

    /// <inheritdoc />     
    public async Task<List<ProtocolMapperRepresentation>> GetClientProtocolMappersModels(string realm, string id, CancellationToken ct)
    {
        // verify the required parameter 'realm' is set
        if (realm == null) throw new PetShopApiException(400, "Missing required parameter 'realm' when calling GetClientProtocolMappersModels");
        // verify the required parameter 'id' is set
        if (id == null) throw new PetShopApiException(400, "Missing required parameter 'id' when calling GetClientProtocolMappersModels");
        
        var path_ = new StringBuilder("/{realm}/clients/{id}/protocol-mappers/models"); 
        path_ = path_.Replace("{realm}", ParameterToString(realm));
        path_ = path_.Replace("{id}", ParameterToString(id));

        
        
        var response = await CallApi<List<ProtocolMapperRepresentation>>(
                    path_.ToString(), 
                    HttpMethod.Get,  
                    ct: ct
        );
        return response;
    }

    /// <inheritdoc />     
    public async Task<List<ProtocolMapperRepresentation>> GetClientProtocolMappersProtocol(string realm, string id, string protocol, CancellationToken ct)
    {
        // verify the required parameter 'realm' is set
        if (realm == null) throw new PetShopApiException(400, "Missing required parameter 'realm' when calling GetClientProtocolMappersProtocol");
        // verify the required parameter 'id' is set
        if (id == null) throw new PetShopApiException(400, "Missing required parameter 'id' when calling GetClientProtocolMappersProtocol");
        // verify the required parameter 'protocol' is set
        if (protocol == null) throw new PetShopApiException(400, "Missing required parameter 'protocol' when calling GetClientProtocolMappersProtocol");
        
        var path_ = new StringBuilder("/{realm}/clients/{id}/protocol-mappers/protocol/{protocol}"); 
        path_ = path_.Replace("{realm}", ParameterToString(realm));
        path_ = path_.Replace("{id}", ParameterToString(id));
        path_ = path_.Replace("{protocol}", ParameterToString(protocol));

        
        
        var response = await CallApi<List<ProtocolMapperRepresentation>>(
                    path_.ToString(), 
                    HttpMethod.Get,  
                    ct: ct
        );
        return response;
    }

    /// <inheritdoc />     
    public async Task<ProtocolMapperRepresentation> GetClientScopeProtocolMappersModel(string realm, string id1, string id2, CancellationToken ct)
    {
        // verify the required parameter 'realm' is set
        if (realm == null) throw new PetShopApiException(400, "Missing required parameter 'realm' when calling GetClientScopeProtocolMappersModel");
        // verify the required parameter 'id1' is set
        if (id1 == null) throw new PetShopApiException(400, "Missing required parameter 'id1' when calling GetClientScopeProtocolMappersModel");
        // verify the required parameter 'id2' is set
        if (id2 == null) throw new PetShopApiException(400, "Missing required parameter 'id2' when calling GetClientScopeProtocolMappersModel");
        
        var path_ = new StringBuilder("/{realm}/client-scopes/{id1}/protocol-mappers/models/{id2}"); 
        path_ = path_.Replace("{realm}", ParameterToString(realm));
        path_ = path_.Replace("{id1}", ParameterToString(id1));
        path_ = path_.Replace("{id2}", ParameterToString(id2));

        
        
        var response = await CallApi<ProtocolMapperRepresentation>(
                    path_.ToString(), 
                    HttpMethod.Get,  
                    ct: ct
        );
        return response;
    }

    /// <inheritdoc />     
    public async Task<List<ProtocolMapperRepresentation>> GetClientScopeProtocolMappersModels(string realm, string id, CancellationToken ct)
    {
        // verify the required parameter 'realm' is set
        if (realm == null) throw new PetShopApiException(400, "Missing required parameter 'realm' when calling GetClientScopeProtocolMappersModels");
        // verify the required parameter 'id' is set
        if (id == null) throw new PetShopApiException(400, "Missing required parameter 'id' when calling GetClientScopeProtocolMappersModels");
        
        var path_ = new StringBuilder("/{realm}/client-scopes/{id}/protocol-mappers/models"); 
        path_ = path_.Replace("{realm}", ParameterToString(realm));
        path_ = path_.Replace("{id}", ParameterToString(id));

        
        
        var response = await CallApi<List<ProtocolMapperRepresentation>>(
                    path_.ToString(), 
                    HttpMethod.Get,  
                    ct: ct
        );
        return response;
    }

    /// <inheritdoc />     
    public async Task<List<ProtocolMapperRepresentation>> GetClientScopeProtocolMappersProtocol(string realm, string id, string protocol, CancellationToken ct)
    {
        // verify the required parameter 'realm' is set
        if (realm == null) throw new PetShopApiException(400, "Missing required parameter 'realm' when calling GetClientScopeProtocolMappersProtocol");
        // verify the required parameter 'id' is set
        if (id == null) throw new PetShopApiException(400, "Missing required parameter 'id' when calling GetClientScopeProtocolMappersProtocol");
        // verify the required parameter 'protocol' is set
        if (protocol == null) throw new PetShopApiException(400, "Missing required parameter 'protocol' when calling GetClientScopeProtocolMappersProtocol");
        
        var path_ = new StringBuilder("/{realm}/client-scopes/{id}/protocol-mappers/protocol/{protocol}"); 
        path_ = path_.Replace("{realm}", ParameterToString(realm));
        path_ = path_.Replace("{id}", ParameterToString(id));
        path_ = path_.Replace("{protocol}", ParameterToString(protocol));

        
        
        var response = await CallApi<List<ProtocolMapperRepresentation>>(
                    path_.ToString(), 
                    HttpMethod.Get,  
                    ct: ct
        );
        return response;
    }

    /// <inheritdoc />     
    public async Task<ProtocolMapperRepresentation> GetClientTemplateProtocolMappersModel(string realm, string id1, string id2, CancellationToken ct)
    {
        // verify the required parameter 'realm' is set
        if (realm == null) throw new PetShopApiException(400, "Missing required parameter 'realm' when calling GetClientTemplateProtocolMappersModel");
        // verify the required parameter 'id1' is set
        if (id1 == null) throw new PetShopApiException(400, "Missing required parameter 'id1' when calling GetClientTemplateProtocolMappersModel");
        // verify the required parameter 'id2' is set
        if (id2 == null) throw new PetShopApiException(400, "Missing required parameter 'id2' when calling GetClientTemplateProtocolMappersModel");
        
        var path_ = new StringBuilder("/{realm}/client-templates/{id1}/protocol-mappers/models/{id2}"); 
        path_ = path_.Replace("{realm}", ParameterToString(realm));
        path_ = path_.Replace("{id1}", ParameterToString(id1));
        path_ = path_.Replace("{id2}", ParameterToString(id2));

        
        
        var response = await CallApi<ProtocolMapperRepresentation>(
                    path_.ToString(), 
                    HttpMethod.Get,  
                    ct: ct
        );
        return response;
    }

    /// <inheritdoc />     
    public async Task<List<ProtocolMapperRepresentation>> GetClientTemplateProtocolMappersModels(string realm, string id, CancellationToken ct)
    {
        // verify the required parameter 'realm' is set
        if (realm == null) throw new PetShopApiException(400, "Missing required parameter 'realm' when calling GetClientTemplateProtocolMappersModels");
        // verify the required parameter 'id' is set
        if (id == null) throw new PetShopApiException(400, "Missing required parameter 'id' when calling GetClientTemplateProtocolMappersModels");
        
        var path_ = new StringBuilder("/{realm}/client-templates/{id}/protocol-mappers/models"); 
        path_ = path_.Replace("{realm}", ParameterToString(realm));
        path_ = path_.Replace("{id}", ParameterToString(id));

        
        
        var response = await CallApi<List<ProtocolMapperRepresentation>>(
                    path_.ToString(), 
                    HttpMethod.Get,  
                    ct: ct
        );
        return response;
    }

    /// <inheritdoc />     
    public async Task<List<ProtocolMapperRepresentation>> GetClientTemplateProtocolMappersProtocol(string realm, string id, string protocol, CancellationToken ct)
    {
        // verify the required parameter 'realm' is set
        if (realm == null) throw new PetShopApiException(400, "Missing required parameter 'realm' when calling GetClientTemplateProtocolMappersProtocol");
        // verify the required parameter 'id' is set
        if (id == null) throw new PetShopApiException(400, "Missing required parameter 'id' when calling GetClientTemplateProtocolMappersProtocol");
        // verify the required parameter 'protocol' is set
        if (protocol == null) throw new PetShopApiException(400, "Missing required parameter 'protocol' when calling GetClientTemplateProtocolMappersProtocol");
        
        var path_ = new StringBuilder("/{realm}/client-templates/{id}/protocol-mappers/protocol/{protocol}"); 
        path_ = path_.Replace("{realm}", ParameterToString(realm));
        path_ = path_.Replace("{id}", ParameterToString(id));
        path_ = path_.Replace("{protocol}", ParameterToString(protocol));

        
        
        var response = await CallApi<List<ProtocolMapperRepresentation>>(
                    path_.ToString(), 
                    HttpMethod.Get,  
                    ct: ct
        );
        return response;
    }

    /// <inheritdoc />     
    public async Task PostClientProtocolMappersAddModels(string realm, string id, ProtocolMapperRepresentation body, CancellationToken ct)
    {
        // verify the required parameter 'realm' is set
        if (realm == null) throw new PetShopApiException(400, "Missing required parameter 'realm' when calling PostClientProtocolMappersAddModels");
        // verify the required parameter 'id' is set
        if (id == null) throw new PetShopApiException(400, "Missing required parameter 'id' when calling PostClientProtocolMappersAddModels");
        
        var path_ = new StringBuilder("/{realm}/clients/{id}/protocol-mappers/add-models"); 
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
    public async Task PostClientProtocolMappersModels(string realm, string id, ProtocolMapperRepresentation body, CancellationToken ct)
    {
        // verify the required parameter 'realm' is set
        if (realm == null) throw new PetShopApiException(400, "Missing required parameter 'realm' when calling PostClientProtocolMappersModels");
        // verify the required parameter 'id' is set
        if (id == null) throw new PetShopApiException(400, "Missing required parameter 'id' when calling PostClientProtocolMappersModels");
        
        var path_ = new StringBuilder("/{realm}/clients/{id}/protocol-mappers/models"); 
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
    public async Task PostClientScopeProtocolMappersAddModels(string realm, string id, ProtocolMapperRepresentation body, CancellationToken ct)
    {
        // verify the required parameter 'realm' is set
        if (realm == null) throw new PetShopApiException(400, "Missing required parameter 'realm' when calling PostClientScopeProtocolMappersAddModels");
        // verify the required parameter 'id' is set
        if (id == null) throw new PetShopApiException(400, "Missing required parameter 'id' when calling PostClientScopeProtocolMappersAddModels");
        
        var path_ = new StringBuilder("/{realm}/client-scopes/{id}/protocol-mappers/add-models"); 
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
    public async Task PostClientScopeProtocolMappersModels(string realm, string id, ProtocolMapperRepresentation body, CancellationToken ct)
    {
        // verify the required parameter 'realm' is set
        if (realm == null) throw new PetShopApiException(400, "Missing required parameter 'realm' when calling PostClientScopeProtocolMappersModels");
        // verify the required parameter 'id' is set
        if (id == null) throw new PetShopApiException(400, "Missing required parameter 'id' when calling PostClientScopeProtocolMappersModels");
        
        var path_ = new StringBuilder("/{realm}/client-scopes/{id}/protocol-mappers/models"); 
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
    public async Task PostClientTemplateProtocolMappersAddModels(string realm, string id, ProtocolMapperRepresentation body, CancellationToken ct)
    {
        // verify the required parameter 'realm' is set
        if (realm == null) throw new PetShopApiException(400, "Missing required parameter 'realm' when calling PostClientTemplateProtocolMappersAddModels");
        // verify the required parameter 'id' is set
        if (id == null) throw new PetShopApiException(400, "Missing required parameter 'id' when calling PostClientTemplateProtocolMappersAddModels");
        
        var path_ = new StringBuilder("/{realm}/client-templates/{id}/protocol-mappers/add-models"); 
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
    public async Task PostClientTemplateProtocolMappersModels(string realm, string id, ProtocolMapperRepresentation body, CancellationToken ct)
    {
        // verify the required parameter 'realm' is set
        if (realm == null) throw new PetShopApiException(400, "Missing required parameter 'realm' when calling PostClientTemplateProtocolMappersModels");
        // verify the required parameter 'id' is set
        if (id == null) throw new PetShopApiException(400, "Missing required parameter 'id' when calling PostClientTemplateProtocolMappersModels");
        
        var path_ = new StringBuilder("/{realm}/client-templates/{id}/protocol-mappers/models"); 
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
    public async Task PutClientProtocolMappersModel(string realm, string id1, string id2, ProtocolMapperRepresentation body, CancellationToken ct)
    {
        // verify the required parameter 'realm' is set
        if (realm == null) throw new PetShopApiException(400, "Missing required parameter 'realm' when calling PutClientProtocolMappersModel");
        // verify the required parameter 'id1' is set
        if (id1 == null) throw new PetShopApiException(400, "Missing required parameter 'id1' when calling PutClientProtocolMappersModel");
        // verify the required parameter 'id2' is set
        if (id2 == null) throw new PetShopApiException(400, "Missing required parameter 'id2' when calling PutClientProtocolMappersModel");
        
        var path_ = new StringBuilder("/{realm}/clients/{id1}/protocol-mappers/models/{id2}"); 
        path_ = path_.Replace("{realm}", ParameterToString(realm));
        path_ = path_.Replace("{id1}", ParameterToString(id1));
        path_ = path_.Replace("{id2}", ParameterToString(id2));

        
        
        await CallApi(
                    path_.ToString(), 
                    HttpMethod.Put,
                    body: body,   
                    ct: ct
        );
    }

    /// <inheritdoc />     
    public async Task PutClientScopeProtocolMappersModel(string realm, string id1, string id2, ProtocolMapperRepresentation body, CancellationToken ct)
    {
        // verify the required parameter 'realm' is set
        if (realm == null) throw new PetShopApiException(400, "Missing required parameter 'realm' when calling PutClientScopeProtocolMappersModel");
        // verify the required parameter 'id1' is set
        if (id1 == null) throw new PetShopApiException(400, "Missing required parameter 'id1' when calling PutClientScopeProtocolMappersModel");
        // verify the required parameter 'id2' is set
        if (id2 == null) throw new PetShopApiException(400, "Missing required parameter 'id2' when calling PutClientScopeProtocolMappersModel");
        
        var path_ = new StringBuilder("/{realm}/client-scopes/{id1}/protocol-mappers/models/{id2}"); 
        path_ = path_.Replace("{realm}", ParameterToString(realm));
        path_ = path_.Replace("{id1}", ParameterToString(id1));
        path_ = path_.Replace("{id2}", ParameterToString(id2));

        
        
        await CallApi(
                    path_.ToString(), 
                    HttpMethod.Put,
                    body: body,   
                    ct: ct
        );
    }

    /// <inheritdoc />     
    public async Task PutClientTemplateProtocolMappersModel(string realm, string id1, string id2, ProtocolMapperRepresentation body, CancellationToken ct)
    {
        // verify the required parameter 'realm' is set
        if (realm == null) throw new PetShopApiException(400, "Missing required parameter 'realm' when calling PutClientTemplateProtocolMappersModel");
        // verify the required parameter 'id1' is set
        if (id1 == null) throw new PetShopApiException(400, "Missing required parameter 'id1' when calling PutClientTemplateProtocolMappersModel");
        // verify the required parameter 'id2' is set
        if (id2 == null) throw new PetShopApiException(400, "Missing required parameter 'id2' when calling PutClientTemplateProtocolMappersModel");
        
        var path_ = new StringBuilder("/{realm}/client-templates/{id1}/protocol-mappers/models/{id2}"); 
        path_ = path_.Replace("{realm}", ParameterToString(realm));
        path_ = path_.Replace("{id1}", ParameterToString(id1));
        path_ = path_.Replace("{id2}", ParameterToString(id2));

        
        
        await CallApi(
                    path_.ToString(), 
                    HttpMethod.Put,
                    body: body,   
                    ct: ct
        );
    }

}
