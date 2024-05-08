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
public partial interface IIdentityProvidersApi
{
    /// <summary>
    ///  Delete the identity provider
    /// </summary>
    /// <param name="realm">realm name (not id!)</param>
    /// <param name="alias"></param>
    /// <param name="ct"></param>
    /// <returns></returns>
    Task DeleteInstance (string realm, string alias, CancellationToken ct);
    /// <summary>
    ///  Delete a mapper for the identity provider
    /// </summary>
    /// <param name="realm">realm name (not id!)</param>
    /// <param name="alias"></param>
    /// <param name="id">Mapper id</param>
    /// <param name="ct"></param>
    /// <returns></returns>
    Task DeleteMapper (string realm, string alias, string id, CancellationToken ct);
    /// <summary>
    ///  Export public broker configuration for identity provider
    /// </summary>
    /// <param name="realm">realm name (not id!)</param>
    /// <param name="alias"></param>
    /// <param name="format">Format to use</param>
    /// <param name="ct"></param>
    /// <returns></returns>
    Task GetExport (string realm, string alias, string format, CancellationToken ct);
    /// <summary>
    ///  Get the identity provider factory for that provider id
    /// </summary>
    /// <param name="realm">realm name (not id!)</param>
    /// <param name="providerId">The provider id to get the factory</param>
    /// <param name="ct"></param>
    /// <returns>Object</returns>
    Task<Object> GetIdentityProviderProvider (string realm, string providerId, CancellationToken ct);
    /// <summary>
    ///  Get the identity provider
    /// </summary>
    /// <param name="realm">realm name (not id!)</param>
    /// <param name="alias"></param>
    /// <param name="ct"></param>
    /// <returns>IdentityProviderRepresentation</returns>
    Task<IdentityProviderRepresentation> GetInstance (string realm, string alias, CancellationToken ct);
    /// <summary>
    ///  Return object stating whether client Authorization permissions have been initialized or not and a reference
    /// </summary>
    /// <param name="realm">realm name (not id!)</param>
    /// <param name="alias"></param>
    /// <param name="ct"></param>
    /// <returns>ManagementPermissionReference</returns>
    Task<ManagementPermissionReference> GetInstanceManagementPermissions (string realm, string alias, CancellationToken ct);
    /// <summary>
    ///  List identity providers
    /// </summary>
    /// <param name="realm">realm name (not id!)</param>
    /// <param name="briefRepresentation">Boolean which defines whether brief representations are returned (default: false)</param>
    /// <param name="first">Pagination offset</param>
    /// <param name="max">Maximum results size (defaults to 100)</param>
    /// <param name="search">Filter specific providers by name. Search can be prefix (name*), contains (name) or exact (&amp;quot;name&amp;quot;). Default prefixed.</param>
    /// <param name="ct"></param>
    /// <returns>List&lt;IdentityProviderRepresentation&gt;</returns>
    Task<List<IdentityProviderRepresentation>> GetInstances (string realm, string briefRepresentation, string first, string max, string search, CancellationToken ct);
    /// <summary>
    ///  Get mapper by id for the identity provider
    /// </summary>
    /// <param name="realm">realm name (not id!)</param>
    /// <param name="alias"></param>
    /// <param name="id">Mapper id</param>
    /// <param name="ct"></param>
    /// <returns>IdentityProviderMapperRepresentation</returns>
    Task<IdentityProviderMapperRepresentation> GetMapper (string realm, string alias, string id, CancellationToken ct);
    /// <summary>
    ///  Get mapper types for identity provider
    /// </summary>
    /// <param name="realm">realm name (not id!)</param>
    /// <param name="alias"></param>
    /// <param name="ct"></param>
    /// <returns>Dictionary&lt;string, IdentityProviderMapperTypeRepresentation&gt;</returns>
    Task<Dictionary<string, IdentityProviderMapperTypeRepresentation>> GetMapperTypes (string realm, string alias, CancellationToken ct);
    /// <summary>
    ///  Get mappers for identity provider
    /// </summary>
    /// <param name="realm">realm name (not id!)</param>
    /// <param name="alias"></param>
    /// <param name="ct"></param>
    /// <returns>List&lt;IdentityProviderMapperRepresentation&gt;</returns>
    Task<List<IdentityProviderMapperRepresentation>> GetMappers (string realm, string alias, CancellationToken ct);
    /// <summary>
    ///  Import identity provider from JSON body
    /// </summary>
    /// <param name="realm">realm name (not id!)</param>
    /// <param name="body">[AnyType]</param>
    /// <param name="ct"></param>
    /// <returns>Dictionary&lt;string, string&gt;</returns>
    Task<Dictionary<string, string>> PostImportConfig (string realm, Object body, CancellationToken ct);
    /// <summary>
    ///  Create a new identity provider
    /// </summary>
    /// <param name="realm">realm name (not id!)</param>
    /// <param name="body">IdentityProviderRepresentation</param>
    /// <param name="ct"></param>
    /// <returns></returns>
    Task PostInstances (string realm, IdentityProviderRepresentation body, CancellationToken ct);
    /// <summary>
    ///  Add a mapper to identity provider
    /// </summary>
    /// <param name="realm">realm name (not id!)</param>
    /// <param name="alias"></param>
    /// <param name="body">IdentityProviderMapperRepresentation</param>
    /// <param name="ct"></param>
    /// <returns></returns>
    Task PostMappers (string realm, string alias, IdentityProviderMapperRepresentation body, CancellationToken ct);
    /// <summary>
    ///  Update the identity provider
    /// </summary>
    /// <param name="realm">realm name (not id!)</param>
    /// <param name="alias"></param>
    /// <param name="body">IdentityProviderRepresentation</param>
    /// <param name="ct"></param>
    /// <returns></returns>
    Task PutInstance (string realm, string alias, IdentityProviderRepresentation body, CancellationToken ct);
    /// <summary>
    ///  Return object stating whether client Authorization permissions have been initialized or not and a reference
    /// </summary>
    /// <param name="realm">realm name (not id!)</param>
    /// <param name="alias"></param>
    /// <param name="body">ManagementPermissionReference</param>
    /// <param name="ct"></param>
    /// <returns>ManagementPermissionReference</returns>
    Task<ManagementPermissionReference> PutInstanceManagementPermissions (string realm, string alias, ManagementPermissionReference body, CancellationToken ct);
    /// <summary>
    ///  Update a mapper for the identity provider
    /// </summary>
    /// <param name="realm">realm name (not id!)</param>
    /// <param name="alias"></param>
    /// <param name="id">Mapper id</param>
    /// <param name="body">IdentityProviderMapperRepresentation</param>
    /// <param name="ct"></param>
    /// <returns></returns>
    Task PutMapper (string realm, string alias, string id, IdentityProviderMapperRepresentation body, CancellationToken ct);
}

/// <summary>
/// Represents a collection of functions to interact with the API endpoints
/// </summary>  
[GeneratedCode("swagger-codegen", "3.0.56-SNAPSHOT")]
public partial class IdentityProvidersApi : PetShopApiClientBase, IIdentityProvidersApi
{
    /// <summary>
    /// Initializes a new instance of the <see cref="IdentityProvidersApi"/> class.
    /// </summary>
    /// <param name="httpClient"> HttpClient to be used for calls. </param>
    /// <param name="basePath"> Base url to be used for calls. </param>
    public IdentityProvidersApi(HttpClient httpClient, String basePath="https://keycloak.example.com/admin/realms") : base(httpClient, basePath)
    {
    }

    /// <inheritdoc />     
    public async Task DeleteInstance(string realm, string alias, CancellationToken ct)
    {
        // verify the required parameter 'realm' is set
        if (realm == null) throw new PetShopApiException(400, "Missing required parameter 'realm' when calling DeleteInstance");
        // verify the required parameter 'alias' is set
        if (alias == null) throw new PetShopApiException(400, "Missing required parameter 'alias' when calling DeleteInstance");
        
        var path_ = new StringBuilder("/{realm}/identity-provider/instances/{alias}"); 
        path_ = path_.Replace("{realm}", ParameterToString(realm));
        path_ = path_.Replace("{alias}", ParameterToString(alias));

        
        
        await CallApi(
                    path_.ToString(), 
                    HttpMethod.Delete,  
                    ct: ct
        );
    }

    /// <inheritdoc />     
    public async Task DeleteMapper(string realm, string alias, string id, CancellationToken ct)
    {
        // verify the required parameter 'realm' is set
        if (realm == null) throw new PetShopApiException(400, "Missing required parameter 'realm' when calling DeleteMapper");
        // verify the required parameter 'alias' is set
        if (alias == null) throw new PetShopApiException(400, "Missing required parameter 'alias' when calling DeleteMapper");
        // verify the required parameter 'id' is set
        if (id == null) throw new PetShopApiException(400, "Missing required parameter 'id' when calling DeleteMapper");
        
        var path_ = new StringBuilder("/{realm}/identity-provider/instances/{alias}/mappers/{id}"); 
        path_ = path_.Replace("{realm}", ParameterToString(realm));
        path_ = path_.Replace("{alias}", ParameterToString(alias));
        path_ = path_.Replace("{id}", ParameterToString(id));

        
        
        await CallApi(
                    path_.ToString(), 
                    HttpMethod.Delete,  
                    ct: ct
        );
    }

    /// <inheritdoc />     
    public async Task GetExport(string realm, string alias, string format, CancellationToken ct)
    {
        // verify the required parameter 'realm' is set
        if (realm == null) throw new PetShopApiException(400, "Missing required parameter 'realm' when calling GetExport");
        // verify the required parameter 'alias' is set
        if (alias == null) throw new PetShopApiException(400, "Missing required parameter 'alias' when calling GetExport");
        
        var path_ = new StringBuilder("/{realm}/identity-provider/instances/{alias}/export"); 
        path_ = path_.Replace("{realm}", ParameterToString(realm));
        path_ = path_.Replace("{alias}", ParameterToString(alias));

        var queryParams = new Dictionary<string, string>();
         
        if (format != null) queryParams.Add("format", ParameterToString(format)); // query parameter
        
        await CallApi(
                    path_.ToString(), 
                    HttpMethod.Get,
                    queryParams: queryParams,  
                    ct: ct
        );
    }

    /// <inheritdoc />     
    public async Task<Object> GetIdentityProviderProvider(string realm, string providerId, CancellationToken ct)
    {
        // verify the required parameter 'realm' is set
        if (realm == null) throw new PetShopApiException(400, "Missing required parameter 'realm' when calling GetIdentityProviderProvider");
        // verify the required parameter 'providerId' is set
        if (providerId == null) throw new PetShopApiException(400, "Missing required parameter 'providerId' when calling GetIdentityProviderProvider");
        
        var path_ = new StringBuilder("/{realm}/identity-provider/providers/{provider_id}"); 
        path_ = path_.Replace("{realm}", ParameterToString(realm));
        path_ = path_.Replace("{provider_id}", ParameterToString(providerId));

        
        
        var response = await CallApi<Object>(
                    path_.ToString(), 
                    HttpMethod.Get,  
                    ct: ct
        );
        return response;
    }

    /// <inheritdoc />     
    public async Task<IdentityProviderRepresentation> GetInstance(string realm, string alias, CancellationToken ct)
    {
        // verify the required parameter 'realm' is set
        if (realm == null) throw new PetShopApiException(400, "Missing required parameter 'realm' when calling GetInstance");
        // verify the required parameter 'alias' is set
        if (alias == null) throw new PetShopApiException(400, "Missing required parameter 'alias' when calling GetInstance");
        
        var path_ = new StringBuilder("/{realm}/identity-provider/instances/{alias}"); 
        path_ = path_.Replace("{realm}", ParameterToString(realm));
        path_ = path_.Replace("{alias}", ParameterToString(alias));

        
        
        var response = await CallApi<IdentityProviderRepresentation>(
                    path_.ToString(), 
                    HttpMethod.Get,  
                    ct: ct
        );
        return response;
    }

    /// <inheritdoc />     
    public async Task<ManagementPermissionReference> GetInstanceManagementPermissions(string realm, string alias, CancellationToken ct)
    {
        // verify the required parameter 'realm' is set
        if (realm == null) throw new PetShopApiException(400, "Missing required parameter 'realm' when calling GetInstanceManagementPermissions");
        // verify the required parameter 'alias' is set
        if (alias == null) throw new PetShopApiException(400, "Missing required parameter 'alias' when calling GetInstanceManagementPermissions");
        
        var path_ = new StringBuilder("/{realm}/identity-provider/instances/{alias}/management/permissions"); 
        path_ = path_.Replace("{realm}", ParameterToString(realm));
        path_ = path_.Replace("{alias}", ParameterToString(alias));

        
        
        var response = await CallApi<ManagementPermissionReference>(
                    path_.ToString(), 
                    HttpMethod.Get,  
                    ct: ct
        );
        return response;
    }

    /// <inheritdoc />     
    public async Task<List<IdentityProviderRepresentation>> GetInstances(string realm, string briefRepresentation, string first, string max, string search, CancellationToken ct)
    {
        // verify the required parameter 'realm' is set
        if (realm == null) throw new PetShopApiException(400, "Missing required parameter 'realm' when calling GetInstances");
        
        var path_ = new StringBuilder("/{realm}/identity-provider/instances"); 
        path_ = path_.Replace("{realm}", ParameterToString(realm));

        var queryParams = new Dictionary<string, string>();
         
        if (briefRepresentation != null) queryParams.Add("briefRepresentation", ParameterToString(briefRepresentation)); // query parameter 
        if (first != null) queryParams.Add("first", ParameterToString(first)); // query parameter 
        if (max != null) queryParams.Add("max", ParameterToString(max)); // query parameter 
        if (search != null) queryParams.Add("search", ParameterToString(search)); // query parameter
        
        var response = await CallApi<List<IdentityProviderRepresentation>>(
                    path_.ToString(), 
                    HttpMethod.Get,
                    queryParams: queryParams,  
                    ct: ct
        );
        return response;
    }

    /// <inheritdoc />     
    public async Task<IdentityProviderMapperRepresentation> GetMapper(string realm, string alias, string id, CancellationToken ct)
    {
        // verify the required parameter 'realm' is set
        if (realm == null) throw new PetShopApiException(400, "Missing required parameter 'realm' when calling GetMapper");
        // verify the required parameter 'alias' is set
        if (alias == null) throw new PetShopApiException(400, "Missing required parameter 'alias' when calling GetMapper");
        // verify the required parameter 'id' is set
        if (id == null) throw new PetShopApiException(400, "Missing required parameter 'id' when calling GetMapper");
        
        var path_ = new StringBuilder("/{realm}/identity-provider/instances/{alias}/mappers/{id}"); 
        path_ = path_.Replace("{realm}", ParameterToString(realm));
        path_ = path_.Replace("{alias}", ParameterToString(alias));
        path_ = path_.Replace("{id}", ParameterToString(id));

        
        
        var response = await CallApi<IdentityProviderMapperRepresentation>(
                    path_.ToString(), 
                    HttpMethod.Get,  
                    ct: ct
        );
        return response;
    }

    /// <inheritdoc />     
    public async Task<Dictionary<string, IdentityProviderMapperTypeRepresentation>> GetMapperTypes(string realm, string alias, CancellationToken ct)
    {
        // verify the required parameter 'realm' is set
        if (realm == null) throw new PetShopApiException(400, "Missing required parameter 'realm' when calling GetMapperTypes");
        // verify the required parameter 'alias' is set
        if (alias == null) throw new PetShopApiException(400, "Missing required parameter 'alias' when calling GetMapperTypes");
        
        var path_ = new StringBuilder("/{realm}/identity-provider/instances/{alias}/mapper-types"); 
        path_ = path_.Replace("{realm}", ParameterToString(realm));
        path_ = path_.Replace("{alias}", ParameterToString(alias));

        
        
        var response = await CallApi<Dictionary<string, IdentityProviderMapperTypeRepresentation>>(
                    path_.ToString(), 
                    HttpMethod.Get,  
                    ct: ct
        );
        return response;
    }

    /// <inheritdoc />     
    public async Task<List<IdentityProviderMapperRepresentation>> GetMappers(string realm, string alias, CancellationToken ct)
    {
        // verify the required parameter 'realm' is set
        if (realm == null) throw new PetShopApiException(400, "Missing required parameter 'realm' when calling GetMappers");
        // verify the required parameter 'alias' is set
        if (alias == null) throw new PetShopApiException(400, "Missing required parameter 'alias' when calling GetMappers");
        
        var path_ = new StringBuilder("/{realm}/identity-provider/instances/{alias}/mappers"); 
        path_ = path_.Replace("{realm}", ParameterToString(realm));
        path_ = path_.Replace("{alias}", ParameterToString(alias));

        
        
        var response = await CallApi<List<IdentityProviderMapperRepresentation>>(
                    path_.ToString(), 
                    HttpMethod.Get,  
                    ct: ct
        );
        return response;
    }

    /// <inheritdoc />     
    public async Task<Dictionary<string, string>> PostImportConfig(string realm, Object body, CancellationToken ct)
    {
        // verify the required parameter 'realm' is set
        if (realm == null) throw new PetShopApiException(400, "Missing required parameter 'realm' when calling PostImportConfig");
        
        var path_ = new StringBuilder("/{realm}/identity-provider/import-config"); 
        path_ = path_.Replace("{realm}", ParameterToString(realm));

        
        
        var response = await CallApi<Dictionary<string, string>>(
                    path_.ToString(), 
                    HttpMethod.Post,
                    body: body,   
                    ct: ct
        );
        return response;
    }

    /// <inheritdoc />     
    public async Task PostInstances(string realm, IdentityProviderRepresentation body, CancellationToken ct)
    {
        // verify the required parameter 'realm' is set
        if (realm == null) throw new PetShopApiException(400, "Missing required parameter 'realm' when calling PostInstances");
        
        var path_ = new StringBuilder("/{realm}/identity-provider/instances"); 
        path_ = path_.Replace("{realm}", ParameterToString(realm));

        
        
        await CallApi(
                    path_.ToString(), 
                    HttpMethod.Post,
                    body: body,   
                    ct: ct
        );
    }

    /// <inheritdoc />     
    public async Task PostMappers(string realm, string alias, IdentityProviderMapperRepresentation body, CancellationToken ct)
    {
        // verify the required parameter 'realm' is set
        if (realm == null) throw new PetShopApiException(400, "Missing required parameter 'realm' when calling PostMappers");
        // verify the required parameter 'alias' is set
        if (alias == null) throw new PetShopApiException(400, "Missing required parameter 'alias' when calling PostMappers");
        
        var path_ = new StringBuilder("/{realm}/identity-provider/instances/{alias}/mappers"); 
        path_ = path_.Replace("{realm}", ParameterToString(realm));
        path_ = path_.Replace("{alias}", ParameterToString(alias));

        
        
        await CallApi(
                    path_.ToString(), 
                    HttpMethod.Post,
                    body: body,   
                    ct: ct
        );
    }

    /// <inheritdoc />     
    public async Task PutInstance(string realm, string alias, IdentityProviderRepresentation body, CancellationToken ct)
    {
        // verify the required parameter 'realm' is set
        if (realm == null) throw new PetShopApiException(400, "Missing required parameter 'realm' when calling PutInstance");
        // verify the required parameter 'alias' is set
        if (alias == null) throw new PetShopApiException(400, "Missing required parameter 'alias' when calling PutInstance");
        
        var path_ = new StringBuilder("/{realm}/identity-provider/instances/{alias}"); 
        path_ = path_.Replace("{realm}", ParameterToString(realm));
        path_ = path_.Replace("{alias}", ParameterToString(alias));

        
        
        await CallApi(
                    path_.ToString(), 
                    HttpMethod.Put,
                    body: body,   
                    ct: ct
        );
    }

    /// <inheritdoc />     
    public async Task<ManagementPermissionReference> PutInstanceManagementPermissions(string realm, string alias, ManagementPermissionReference body, CancellationToken ct)
    {
        // verify the required parameter 'realm' is set
        if (realm == null) throw new PetShopApiException(400, "Missing required parameter 'realm' when calling PutInstanceManagementPermissions");
        // verify the required parameter 'alias' is set
        if (alias == null) throw new PetShopApiException(400, "Missing required parameter 'alias' when calling PutInstanceManagementPermissions");
        
        var path_ = new StringBuilder("/{realm}/identity-provider/instances/{alias}/management/permissions"); 
        path_ = path_.Replace("{realm}", ParameterToString(realm));
        path_ = path_.Replace("{alias}", ParameterToString(alias));

        
        
        var response = await CallApi<ManagementPermissionReference>(
                    path_.ToString(), 
                    HttpMethod.Put,
                    body: body,   
                    ct: ct
        );
        return response;
    }

    /// <inheritdoc />     
    public async Task PutMapper(string realm, string alias, string id, IdentityProviderMapperRepresentation body, CancellationToken ct)
    {
        // verify the required parameter 'realm' is set
        if (realm == null) throw new PetShopApiException(400, "Missing required parameter 'realm' when calling PutMapper");
        // verify the required parameter 'alias' is set
        if (alias == null) throw new PetShopApiException(400, "Missing required parameter 'alias' when calling PutMapper");
        // verify the required parameter 'id' is set
        if (id == null) throw new PetShopApiException(400, "Missing required parameter 'id' when calling PutMapper");
        
        var path_ = new StringBuilder("/{realm}/identity-provider/instances/{alias}/mappers/{id}"); 
        path_ = path_.Replace("{realm}", ParameterToString(realm));
        path_ = path_.Replace("{alias}", ParameterToString(alias));
        path_ = path_.Replace("{id}", ParameterToString(id));

        
        
        await CallApi(
                    path_.ToString(), 
                    HttpMethod.Put,
                    body: body,   
                    ct: ct
        );
    }

}
