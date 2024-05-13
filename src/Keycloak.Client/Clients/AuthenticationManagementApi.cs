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
public partial interface IAuthenticationManagementApi
{
    /// <summary>
    ///  Delete authenticator configuration
    /// </summary>
    /// <param name="realm">realm name (not id!)</param>
    /// <param name="id">Configuration id</param>
    /// <param name="ct"></param>
    /// <returns></returns>
    Task DeleteConfig (string realm, string id, CancellationToken ct);
    /// <summary>
    ///  Delete execution
    /// </summary>
    /// <param name="realm">realm name (not id!)</param>
    /// <param name="executionId"></param>
    /// <param name="ct"></param>
    /// <returns></returns>
    Task DeleteExecution (string realm, string executionId, CancellationToken ct);
    /// <summary>
    ///  Delete an authentication flow
    /// </summary>
    /// <param name="realm">realm name (not id!)</param>
    /// <param name="id"></param>
    /// <param name="ct"></param>
    /// <returns></returns>
    Task DeleteFlow (string realm, string id, CancellationToken ct);
    /// <summary>
    ///  Delete required action
    /// </summary>
    /// <param name="realm">realm name (not id!)</param>
    /// <param name="alias">Alias of required action</param>
    /// <param name="ct"></param>
    /// <returns></returns>
    Task DeleteRequiredAction (string realm, string alias, CancellationToken ct);
    /// <summary>
    ///  Get authenticator configuration
    /// </summary>
    /// <param name="realm">realm name (not id!)</param>
    /// <param name="id">Configuration id</param>
    /// <param name="ct"></param>
    /// <returns>AuthenticatorConfigRepresentation</returns>
    Task<AuthenticatorConfigRepresentation> GetAuthenticationConfig (string realm, string id, CancellationToken ct);
    /// <summary>
    ///  Get authenticator providers Returns a stream of authenticator providers.
    /// </summary>
    /// <param name="realm">realm name (not id!)</param>
    /// <param name="ct"></param>
    /// <returns>List&lt;Object&gt;</returns>
    Task<List<Object>> GetAuthenticatorProviders (string realm, CancellationToken ct);
    /// <summary>
    ///  Get client authenticator providers Returns a stream of client authenticator providers.
    /// </summary>
    /// <param name="realm">realm name (not id!)</param>
    /// <param name="ct"></param>
    /// <returns>List&lt;Object&gt;</returns>
    Task<List<Object>> GetClientAuthenticatorProviders (string realm, CancellationToken ct);
    /// <summary>
    ///  Get authenticator provider’s configuration description
    /// </summary>
    /// <param name="realm">realm name (not id!)</param>
    /// <param name="providerId"></param>
    /// <param name="ct"></param>
    /// <returns>AuthenticatorConfigInfoRepresentation</returns>
    Task<AuthenticatorConfigInfoRepresentation> GetConfigDescription (string realm, string providerId, CancellationToken ct);
    /// <summary>
    ///  Get Single Execution
    /// </summary>
    /// <param name="realm">realm name (not id!)</param>
    /// <param name="executionId"></param>
    /// <param name="ct"></param>
    /// <returns></returns>
    Task GetExecution (string realm, string executionId, CancellationToken ct);
    /// <summary>
    ///  Get execution’s configuration
    /// </summary>
    /// <param name="realm">realm name (not id!)</param>
    /// <param name="executionId">Execution id</param>
    /// <param name="id">Configuration id</param>
    /// <param name="ct"></param>
    /// <returns>AuthenticatorConfigRepresentation</returns>
    Task<AuthenticatorConfigRepresentation> GetExecutionConfig (string realm, string executionId, string id, CancellationToken ct);
    /// <summary>
    ///  Get authentication executions for a flow
    /// </summary>
    /// <param name="realm">realm name (not id!)</param>
    /// <param name="flowAlias">Flow alias</param>
    /// <param name="ct"></param>
    /// <returns></returns>
    Task GetExecutions (string realm, string flowAlias, CancellationToken ct);
    /// <summary>
    ///  Get authentication flow for id
    /// </summary>
    /// <param name="realm">realm name (not id!)</param>
    /// <param name="id"></param>
    /// <param name="ct"></param>
    /// <returns>AuthenticationFlowRepresentation</returns>
    Task<AuthenticationFlowRepresentation> GetFlow (string realm, string id, CancellationToken ct);
    /// <summary>
    ///  Get authentication flows Returns a stream of authentication flows.
    /// </summary>
    /// <param name="realm">realm name (not id!)</param>
    /// <param name="ct"></param>
    /// <returns>List&lt;AuthenticationFlowRepresentation&gt;</returns>
    Task<List<AuthenticationFlowRepresentation>> GetFlows (string realm, CancellationToken ct);
    /// <summary>
    ///  Get form action providers Returns a stream of form action providers.
    /// </summary>
    /// <param name="realm">realm name (not id!)</param>
    /// <param name="ct"></param>
    /// <returns>List&lt;Object&gt;</returns>
    Task<List<Object>> GetFormActionProviders (string realm, CancellationToken ct);
    /// <summary>
    ///  Get form providers Returns a stream of form providers.
    /// </summary>
    /// <param name="realm">realm name (not id!)</param>
    /// <param name="ct"></param>
    /// <returns>List&lt;Object&gt;</returns>
    Task<List<Object>> GetFormProviders (string realm, CancellationToken ct);
    /// <summary>
    ///  Get configuration descriptions for all clients
    /// </summary>
    /// <param name="realm">realm name (not id!)</param>
    /// <param name="ct"></param>
    /// <returns>Dictionary&lt;string, ConfigPropertyRepresentation&gt;</returns>
    Task<Dictionary<string, ConfigPropertyRepresentation>> GetPerClientConfigDescription (string realm, CancellationToken ct);
    /// <summary>
    ///  Get required action for alias
    /// </summary>
    /// <param name="realm">realm name (not id!)</param>
    /// <param name="alias">Alias of required action</param>
    /// <param name="ct"></param>
    /// <returns>RequiredActionProviderRepresentation</returns>
    Task<RequiredActionProviderRepresentation> GetRequiredAction (string realm, string alias, CancellationToken ct);
    /// <summary>
    ///  Get required actions Returns a stream of required actions.
    /// </summary>
    /// <param name="realm">realm name (not id!)</param>
    /// <param name="ct"></param>
    /// <returns>List&lt;RequiredActionProviderRepresentation&gt;</returns>
    Task<List<RequiredActionProviderRepresentation>> GetRequiredActions (string realm, CancellationToken ct);
    /// <summary>
    ///  Get unregistered required actions Returns a stream of unregistered required actions.
    /// </summary>
    /// <param name="realm">realm name (not id!)</param>
    /// <param name="ct"></param>
    /// <returns>List&lt;string&gt;</returns>
    Task<List<string>> GetUnregisteredRequiredActions (string realm, CancellationToken ct);
    /// <summary>
    ///  Create new authenticator configuration
    /// </summary>
    /// <param name="realm">realm name (not id!)</param>
    /// <param name="body">AuthenticatorConfigRepresentation</param>
    /// <param name="ct"></param>
    /// <returns></returns>
    Task PostAuthenticationConfig (string realm, AuthenticatorConfigRepresentation body, CancellationToken ct);
    /// <summary>
    ///  Copy existing authentication flow under a new name The new name is given as &#39;newName&#39; attribute of the passed JSON object
    /// </summary>
    /// <param name="realm">realm name (not id!)</param>
    /// <param name="flowAlias">name of the existing authentication flow</param>
    /// <param name="body">[string]</param>
    /// <param name="ct"></param>
    /// <returns></returns>
    Task PostCopy (string realm, string flowAlias, string body, CancellationToken ct);
    /// <summary>
    ///  Add new authentication execution to a flow
    /// </summary>
    /// <param name="realm">realm name (not id!)</param>
    /// <param name="flowAlias">Alias of parent flow</param>
    /// <param name="body">[string]</param>
    /// <param name="ct"></param>
    /// <returns></returns>
    Task PostExecution (string realm, string flowAlias, string body, CancellationToken ct);
    /// <summary>
    ///  Update execution with new configuration
    /// </summary>
    /// <param name="realm">realm name (not id!)</param>
    /// <param name="executionId">Execution id</param>
    /// <param name="body">AuthenticatorConfigRepresentation</param>
    /// <param name="ct"></param>
    /// <returns></returns>
    Task PostExecutionConfig (string realm, string executionId, AuthenticatorConfigRepresentation body, CancellationToken ct);
    /// <summary>
    ///  Lower execution’s priority
    /// </summary>
    /// <param name="realm">realm name (not id!)</param>
    /// <param name="executionId">Execution id</param>
    /// <param name="ct"></param>
    /// <returns></returns>
    Task PostExecutionLowerPriority (string realm, string executionId, CancellationToken ct);
    /// <summary>
    ///  Raise execution’s priority
    /// </summary>
    /// <param name="realm">realm name (not id!)</param>
    /// <param name="executionId">Execution id</param>
    /// <param name="ct"></param>
    /// <returns></returns>
    Task PostExecutionRaisePriority (string realm, string executionId, CancellationToken ct);
    /// <summary>
    ///  Add new authentication execution
    /// </summary>
    /// <param name="realm">realm name (not id!)</param>
    /// <param name="body">AuthenticationExecutionRepresentation</param>
    /// <param name="ct"></param>
    /// <returns></returns>
    Task PostExecutions (string realm, AuthenticationExecutionRepresentation body, CancellationToken ct);
    /// <summary>
    ///  Add new flow with new execution to existing flow
    /// </summary>
    /// <param name="realm">realm name (not id!)</param>
    /// <param name="flowAlias">Alias of parent authentication flow</param>
    /// <param name="body">[string]</param>
    /// <param name="ct"></param>
    /// <returns></returns>
    Task PostFlow (string realm, string flowAlias, string body, CancellationToken ct);
    /// <summary>
    ///  Create a new authentication flow
    /// </summary>
    /// <param name="realm">realm name (not id!)</param>
    /// <param name="body">AuthenticationFlowRepresentation</param>
    /// <param name="ct"></param>
    /// <returns></returns>
    Task PostFlows (string realm, AuthenticationFlowRepresentation body, CancellationToken ct);
    /// <summary>
    ///  Register a new required actions
    /// </summary>
    /// <param name="realm">realm name (not id!)</param>
    /// <param name="body">[string]</param>
    /// <param name="ct"></param>
    /// <returns></returns>
    Task PostRegisterRequiredAction (string realm, string body, CancellationToken ct);
    /// <summary>
    ///  Lower required action’s priority
    /// </summary>
    /// <param name="realm">realm name (not id!)</param>
    /// <param name="alias">Alias of required action</param>
    /// <param name="ct"></param>
    /// <returns></returns>
    Task PostRequiredActionLowerPriority (string realm, string alias, CancellationToken ct);
    /// <summary>
    ///  Raise required action’s priority
    /// </summary>
    /// <param name="realm">realm name (not id!)</param>
    /// <param name="alias">Alias of required action</param>
    /// <param name="ct"></param>
    /// <returns></returns>
    Task PostRequiredActionRaisePriority (string realm, string alias, CancellationToken ct);
    /// <summary>
    ///  Update authenticator configuration
    /// </summary>
    /// <param name="realm">realm name (not id!)</param>
    /// <param name="id">Configuration id</param>
    /// <param name="body">AuthenticatorConfigRepresentation</param>
    /// <param name="ct"></param>
    /// <returns></returns>
    Task PutAuthenticationConfig (string realm, string id, AuthenticatorConfigRepresentation body, CancellationToken ct);
    /// <summary>
    ///  Update authentication executions of a Flow
    /// </summary>
    /// <param name="realm">realm name (not id!)</param>
    /// <param name="flowAlias">Flow alias</param>
    /// <param name="body">AuthenticationExecutionInfoRepresentation</param>
    /// <param name="ct"></param>
    /// <returns></returns>
    Task PutExecutions (string realm, string flowAlias, AuthenticationExecutionInfoRepresentation body, CancellationToken ct);
    /// <summary>
    ///  Update an authentication flow
    /// </summary>
    /// <param name="realm">realm name (not id!)</param>
    /// <param name="id"></param>
    /// <param name="body">AuthenticationFlowRepresentation</param>
    /// <param name="ct"></param>
    /// <returns></returns>
    Task PutFlow (string realm, string id, AuthenticationFlowRepresentation body, CancellationToken ct);
    /// <summary>
    ///  Update required action
    /// </summary>
    /// <param name="realm">realm name (not id!)</param>
    /// <param name="alias">Alias of required action</param>
    /// <param name="body">RequiredActionProviderRepresentation</param>
    /// <param name="ct"></param>
    /// <returns></returns>
    Task PutRequiredAction (string realm, string alias, RequiredActionProviderRepresentation body, CancellationToken ct);
}

/// <summary>
/// Represents a collection of functions to interact with the API endpoints
/// </summary>  
[GeneratedCode("swagger-codegen", "3.0.56-SNAPSHOT")]
public partial class AuthenticationManagementApi : PetShopApiClientBase, IAuthenticationManagementApi
{
    /// <summary>
    /// Initializes a new instance of the <see cref="AuthenticationManagementApi"/> class.
    /// </summary>
    /// <param name="httpClient"> HttpClient to be used for calls. </param>
    /// <param name="basePath"> Base url to be used for calls. </param>
    public AuthenticationManagementApi(HttpClient httpClient, String basePath="https://keycloak.example.com/admin/realms") : base(httpClient, basePath)
    {
    }

    /// <inheritdoc />     
    public async Task DeleteConfig(string realm, string id, CancellationToken ct)
    {
        // verify the required parameter 'realm' is set
        if (realm == null) throw new PetShopApiException(400, "Missing required parameter 'realm' when calling DeleteConfig");
        // verify the required parameter 'id' is set
        if (id == null) throw new PetShopApiException(400, "Missing required parameter 'id' when calling DeleteConfig");
        
        var path_ = new StringBuilder("/{realm}/authentication/config/{id}"); 
        path_ = path_.Replace("{realm}", ParameterToString(realm));
        path_ = path_.Replace("{id}", ParameterToString(id));

        
        
        await CallApi(
                    path_.ToString(), 
                    HttpMethod.Delete,  
                    ct: ct
        );
    }

    /// <inheritdoc />     
    public async Task DeleteExecution(string realm, string executionId, CancellationToken ct)
    {
        // verify the required parameter 'realm' is set
        if (realm == null) throw new PetShopApiException(400, "Missing required parameter 'realm' when calling DeleteExecution");
        // verify the required parameter 'executionId' is set
        if (executionId == null) throw new PetShopApiException(400, "Missing required parameter 'executionId' when calling DeleteExecution");
        
        var path_ = new StringBuilder("/{realm}/authentication/executions/{executionId}"); 
        path_ = path_.Replace("{realm}", ParameterToString(realm));
        path_ = path_.Replace("{executionId}", ParameterToString(executionId));

        
        
        await CallApi(
                    path_.ToString(), 
                    HttpMethod.Delete,  
                    ct: ct
        );
    }

    /// <inheritdoc />     
    public async Task DeleteFlow(string realm, string id, CancellationToken ct)
    {
        // verify the required parameter 'realm' is set
        if (realm == null) throw new PetShopApiException(400, "Missing required parameter 'realm' when calling DeleteFlow");
        // verify the required parameter 'id' is set
        if (id == null) throw new PetShopApiException(400, "Missing required parameter 'id' when calling DeleteFlow");
        
        var path_ = new StringBuilder("/{realm}/authentication/flows/{id}"); 
        path_ = path_.Replace("{realm}", ParameterToString(realm));
        path_ = path_.Replace("{id}", ParameterToString(id));

        
        
        await CallApi(
                    path_.ToString(), 
                    HttpMethod.Delete,  
                    ct: ct
        );
    }

    /// <inheritdoc />     
    public async Task DeleteRequiredAction(string realm, string alias, CancellationToken ct)
    {
        // verify the required parameter 'realm' is set
        if (realm == null) throw new PetShopApiException(400, "Missing required parameter 'realm' when calling DeleteRequiredAction");
        // verify the required parameter 'alias' is set
        if (alias == null) throw new PetShopApiException(400, "Missing required parameter 'alias' when calling DeleteRequiredAction");
        
        var path_ = new StringBuilder("/{realm}/authentication/required-actions/{alias}"); 
        path_ = path_.Replace("{realm}", ParameterToString(realm));
        path_ = path_.Replace("{alias}", ParameterToString(alias));

        
        
        await CallApi(
                    path_.ToString(), 
                    HttpMethod.Delete,  
                    ct: ct
        );
    }

    /// <inheritdoc />     
    public async Task<AuthenticatorConfigRepresentation> GetAuthenticationConfig(string realm, string id, CancellationToken ct)
    {
        // verify the required parameter 'realm' is set
        if (realm == null) throw new PetShopApiException(400, "Missing required parameter 'realm' when calling GetAuthenticationConfig");
        // verify the required parameter 'id' is set
        if (id == null) throw new PetShopApiException(400, "Missing required parameter 'id' when calling GetAuthenticationConfig");
        
        var path_ = new StringBuilder("/{realm}/authentication/config/{id}"); 
        path_ = path_.Replace("{realm}", ParameterToString(realm));
        path_ = path_.Replace("{id}", ParameterToString(id));

        
        
        var response = await CallApi<AuthenticatorConfigRepresentation>(
                    path_.ToString(), 
                    HttpMethod.Get,  
                    ct: ct
        );
        return response;
    }

    /// <inheritdoc />     
    public async Task<List<Object>> GetAuthenticatorProviders(string realm, CancellationToken ct)
    {
        // verify the required parameter 'realm' is set
        if (realm == null) throw new PetShopApiException(400, "Missing required parameter 'realm' when calling GetAuthenticatorProviders");
        
        var path_ = new StringBuilder("/{realm}/authentication/authenticator-providers"); 
        path_ = path_.Replace("{realm}", ParameterToString(realm));

        
        
        var response = await CallApi<List<Object>>(
                    path_.ToString(), 
                    HttpMethod.Get,  
                    ct: ct
        );
        return response;
    }

    /// <inheritdoc />     
    public async Task<List<Object>> GetClientAuthenticatorProviders(string realm, CancellationToken ct)
    {
        // verify the required parameter 'realm' is set
        if (realm == null) throw new PetShopApiException(400, "Missing required parameter 'realm' when calling GetClientAuthenticatorProviders");
        
        var path_ = new StringBuilder("/{realm}/authentication/client-authenticator-providers"); 
        path_ = path_.Replace("{realm}", ParameterToString(realm));

        
        
        var response = await CallApi<List<Object>>(
                    path_.ToString(), 
                    HttpMethod.Get,  
                    ct: ct
        );
        return response;
    }

    /// <inheritdoc />     
    public async Task<AuthenticatorConfigInfoRepresentation> GetConfigDescription(string realm, string providerId, CancellationToken ct)
    {
        // verify the required parameter 'realm' is set
        if (realm == null) throw new PetShopApiException(400, "Missing required parameter 'realm' when calling GetConfigDescription");
        // verify the required parameter 'providerId' is set
        if (providerId == null) throw new PetShopApiException(400, "Missing required parameter 'providerId' when calling GetConfigDescription");
        
        var path_ = new StringBuilder("/{realm}/authentication/config-description/{providerId}"); 
        path_ = path_.Replace("{realm}", ParameterToString(realm));
        path_ = path_.Replace("{providerId}", ParameterToString(providerId));

        
        
        var response = await CallApi<AuthenticatorConfigInfoRepresentation>(
                    path_.ToString(), 
                    HttpMethod.Get,  
                    ct: ct
        );
        return response;
    }

    /// <inheritdoc />     
    public async Task GetExecution(string realm, string executionId, CancellationToken ct)
    {
        // verify the required parameter 'realm' is set
        if (realm == null) throw new PetShopApiException(400, "Missing required parameter 'realm' when calling GetExecution");
        // verify the required parameter 'executionId' is set
        if (executionId == null) throw new PetShopApiException(400, "Missing required parameter 'executionId' when calling GetExecution");
        
        var path_ = new StringBuilder("/{realm}/authentication/executions/{executionId}"); 
        path_ = path_.Replace("{realm}", ParameterToString(realm));
        path_ = path_.Replace("{executionId}", ParameterToString(executionId));

        
        
        await CallApi(
                    path_.ToString(), 
                    HttpMethod.Get,  
                    ct: ct
        );
    }

    /// <inheritdoc />     
    public async Task<AuthenticatorConfigRepresentation> GetExecutionConfig(string realm, string executionId, string id, CancellationToken ct)
    {
        // verify the required parameter 'realm' is set
        if (realm == null) throw new PetShopApiException(400, "Missing required parameter 'realm' when calling GetExecutionConfig");
        // verify the required parameter 'executionId' is set
        if (executionId == null) throw new PetShopApiException(400, "Missing required parameter 'executionId' when calling GetExecutionConfig");
        // verify the required parameter 'id' is set
        if (id == null) throw new PetShopApiException(400, "Missing required parameter 'id' when calling GetExecutionConfig");
        
        var path_ = new StringBuilder("/{realm}/authentication/executions/{executionId}/config/{id}"); 
        path_ = path_.Replace("{realm}", ParameterToString(realm));
        path_ = path_.Replace("{executionId}", ParameterToString(executionId));
        path_ = path_.Replace("{id}", ParameterToString(id));

        
        
        var response = await CallApi<AuthenticatorConfigRepresentation>(
                    path_.ToString(), 
                    HttpMethod.Get,  
                    ct: ct
        );
        return response;
    }

    /// <inheritdoc />     
    public async Task GetExecutions(string realm, string flowAlias, CancellationToken ct)
    {
        // verify the required parameter 'realm' is set
        if (realm == null) throw new PetShopApiException(400, "Missing required parameter 'realm' when calling GetExecutions");
        // verify the required parameter 'flowAlias' is set
        if (flowAlias == null) throw new PetShopApiException(400, "Missing required parameter 'flowAlias' when calling GetExecutions");
        
        var path_ = new StringBuilder("/{realm}/authentication/flows/{flowAlias}/executions"); 
        path_ = path_.Replace("{realm}", ParameterToString(realm));
        path_ = path_.Replace("{flowAlias}", ParameterToString(flowAlias));

        
        
        await CallApi(
                    path_.ToString(), 
                    HttpMethod.Get,  
                    ct: ct
        );
    }

    /// <inheritdoc />     
    public async Task<AuthenticationFlowRepresentation> GetFlow(string realm, string id, CancellationToken ct)
    {
        // verify the required parameter 'realm' is set
        if (realm == null) throw new PetShopApiException(400, "Missing required parameter 'realm' when calling GetFlow");
        // verify the required parameter 'id' is set
        if (id == null) throw new PetShopApiException(400, "Missing required parameter 'id' when calling GetFlow");
        
        var path_ = new StringBuilder("/{realm}/authentication/flows/{id}"); 
        path_ = path_.Replace("{realm}", ParameterToString(realm));
        path_ = path_.Replace("{id}", ParameterToString(id));

        
        
        var response = await CallApi<AuthenticationFlowRepresentation>(
                    path_.ToString(), 
                    HttpMethod.Get,  
                    ct: ct
        );
        return response;
    }

    /// <inheritdoc />     
    public async Task<List<AuthenticationFlowRepresentation>> GetFlows(string realm, CancellationToken ct)
    {
        // verify the required parameter 'realm' is set
        if (realm == null) throw new PetShopApiException(400, "Missing required parameter 'realm' when calling GetFlows");
        
        var path_ = new StringBuilder("/{realm}/authentication/flows"); 
        path_ = path_.Replace("{realm}", ParameterToString(realm));

        
        
        var response = await CallApi<List<AuthenticationFlowRepresentation>>(
                    path_.ToString(), 
                    HttpMethod.Get,  
                    ct: ct
        );
        return response;
    }

    /// <inheritdoc />     
    public async Task<List<Object>> GetFormActionProviders(string realm, CancellationToken ct)
    {
        // verify the required parameter 'realm' is set
        if (realm == null) throw new PetShopApiException(400, "Missing required parameter 'realm' when calling GetFormActionProviders");
        
        var path_ = new StringBuilder("/{realm}/authentication/form-action-providers"); 
        path_ = path_.Replace("{realm}", ParameterToString(realm));

        
        
        var response = await CallApi<List<Object>>(
                    path_.ToString(), 
                    HttpMethod.Get,  
                    ct: ct
        );
        return response;
    }

    /// <inheritdoc />     
    public async Task<List<Object>> GetFormProviders(string realm, CancellationToken ct)
    {
        // verify the required parameter 'realm' is set
        if (realm == null) throw new PetShopApiException(400, "Missing required parameter 'realm' when calling GetFormProviders");
        
        var path_ = new StringBuilder("/{realm}/authentication/form-providers"); 
        path_ = path_.Replace("{realm}", ParameterToString(realm));

        
        
        var response = await CallApi<List<Object>>(
                    path_.ToString(), 
                    HttpMethod.Get,  
                    ct: ct
        );
        return response;
    }

    /// <inheritdoc />     
    public async Task<Dictionary<string, ConfigPropertyRepresentation>> GetPerClientConfigDescription(string realm, CancellationToken ct)
    {
        // verify the required parameter 'realm' is set
        if (realm == null) throw new PetShopApiException(400, "Missing required parameter 'realm' when calling GetPerClientConfigDescription");
        
        var path_ = new StringBuilder("/{realm}/authentication/per-client-config-description"); 
        path_ = path_.Replace("{realm}", ParameterToString(realm));

        
        
        var response = await CallApi<Dictionary<string, ConfigPropertyRepresentation>>(
                    path_.ToString(), 
                    HttpMethod.Get,  
                    ct: ct
        );
        return response;
    }

    /// <inheritdoc />     
    public async Task<RequiredActionProviderRepresentation> GetRequiredAction(string realm, string alias, CancellationToken ct)
    {
        // verify the required parameter 'realm' is set
        if (realm == null) throw new PetShopApiException(400, "Missing required parameter 'realm' when calling GetRequiredAction");
        // verify the required parameter 'alias' is set
        if (alias == null) throw new PetShopApiException(400, "Missing required parameter 'alias' when calling GetRequiredAction");
        
        var path_ = new StringBuilder("/{realm}/authentication/required-actions/{alias}"); 
        path_ = path_.Replace("{realm}", ParameterToString(realm));
        path_ = path_.Replace("{alias}", ParameterToString(alias));

        
        
        var response = await CallApi<RequiredActionProviderRepresentation>(
                    path_.ToString(), 
                    HttpMethod.Get,  
                    ct: ct
        );
        return response;
    }

    /// <inheritdoc />     
    public async Task<List<RequiredActionProviderRepresentation>> GetRequiredActions(string realm, CancellationToken ct)
    {
        // verify the required parameter 'realm' is set
        if (realm == null) throw new PetShopApiException(400, "Missing required parameter 'realm' when calling GetRequiredActions");
        
        var path_ = new StringBuilder("/{realm}/authentication/required-actions"); 
        path_ = path_.Replace("{realm}", ParameterToString(realm));

        
        
        var response = await CallApi<List<RequiredActionProviderRepresentation>>(
                    path_.ToString(), 
                    HttpMethod.Get,  
                    ct: ct
        );
        return response;
    }

    /// <inheritdoc />     
    public async Task<List<string>> GetUnregisteredRequiredActions(string realm, CancellationToken ct)
    {
        // verify the required parameter 'realm' is set
        if (realm == null) throw new PetShopApiException(400, "Missing required parameter 'realm' when calling GetUnregisteredRequiredActions");
        
        var path_ = new StringBuilder("/{realm}/authentication/unregistered-required-actions"); 
        path_ = path_.Replace("{realm}", ParameterToString(realm));

        
        
        var response = await CallApi<List<string>>(
                    path_.ToString(), 
                    HttpMethod.Get,  
                    ct: ct
        );
        return response;
    }

    /// <inheritdoc />     
    public async Task PostAuthenticationConfig(string realm, AuthenticatorConfigRepresentation body, CancellationToken ct)
    {
        // verify the required parameter 'realm' is set
        if (realm == null) throw new PetShopApiException(400, "Missing required parameter 'realm' when calling PostAuthenticationConfig");
        
        var path_ = new StringBuilder("/{realm}/authentication/config"); 
        path_ = path_.Replace("{realm}", ParameterToString(realm));

        
        
        await CallApi(
                    path_.ToString(), 
                    HttpMethod.Post,
                    body: body,   
                    ct: ct
        );
    }

    /// <inheritdoc />     
    public async Task PostCopy(string realm, string flowAlias, string body, CancellationToken ct)
    {
        // verify the required parameter 'realm' is set
        if (realm == null) throw new PetShopApiException(400, "Missing required parameter 'realm' when calling PostCopy");
        // verify the required parameter 'flowAlias' is set
        if (flowAlias == null) throw new PetShopApiException(400, "Missing required parameter 'flowAlias' when calling PostCopy");
        
        var path_ = new StringBuilder("/{realm}/authentication/flows/{flowAlias}/copy"); 
        path_ = path_.Replace("{realm}", ParameterToString(realm));
        path_ = path_.Replace("{flowAlias}", ParameterToString(flowAlias));

        
        
        await CallApi(
                    path_.ToString(), 
                    HttpMethod.Post,
                    body: body,   
                    ct: ct
        );
    }

    /// <inheritdoc />     
    public async Task PostExecution(string realm, string flowAlias, string body, CancellationToken ct)
    {
        // verify the required parameter 'realm' is set
        if (realm == null) throw new PetShopApiException(400, "Missing required parameter 'realm' when calling PostExecution");
        // verify the required parameter 'flowAlias' is set
        if (flowAlias == null) throw new PetShopApiException(400, "Missing required parameter 'flowAlias' when calling PostExecution");
        
        var path_ = new StringBuilder("/{realm}/authentication/flows/{flowAlias}/executions/execution"); 
        path_ = path_.Replace("{realm}", ParameterToString(realm));
        path_ = path_.Replace("{flowAlias}", ParameterToString(flowAlias));

        
        
        await CallApi(
                    path_.ToString(), 
                    HttpMethod.Post,
                    body: body,   
                    ct: ct
        );
    }

    /// <inheritdoc />     
    public async Task PostExecutionConfig(string realm, string executionId, AuthenticatorConfigRepresentation body, CancellationToken ct)
    {
        // verify the required parameter 'realm' is set
        if (realm == null) throw new PetShopApiException(400, "Missing required parameter 'realm' when calling PostExecutionConfig");
        // verify the required parameter 'executionId' is set
        if (executionId == null) throw new PetShopApiException(400, "Missing required parameter 'executionId' when calling PostExecutionConfig");
        
        var path_ = new StringBuilder("/{realm}/authentication/executions/{executionId}/config"); 
        path_ = path_.Replace("{realm}", ParameterToString(realm));
        path_ = path_.Replace("{executionId}", ParameterToString(executionId));

        
        
        await CallApi(
                    path_.ToString(), 
                    HttpMethod.Post,
                    body: body,   
                    ct: ct
        );
    }

    /// <inheritdoc />     
    public async Task PostExecutionLowerPriority(string realm, string executionId, CancellationToken ct)
    {
        // verify the required parameter 'realm' is set
        if (realm == null) throw new PetShopApiException(400, "Missing required parameter 'realm' when calling PostExecutionLowerPriority");
        // verify the required parameter 'executionId' is set
        if (executionId == null) throw new PetShopApiException(400, "Missing required parameter 'executionId' when calling PostExecutionLowerPriority");
        
        var path_ = new StringBuilder("/{realm}/authentication/executions/{executionId}/lower-priority"); 
        path_ = path_.Replace("{realm}", ParameterToString(realm));
        path_ = path_.Replace("{executionId}", ParameterToString(executionId));

        
        
        await CallApi(
                    path_.ToString(), 
                    HttpMethod.Post,  
                    ct: ct
        );
    }

    /// <inheritdoc />     
    public async Task PostExecutionRaisePriority(string realm, string executionId, CancellationToken ct)
    {
        // verify the required parameter 'realm' is set
        if (realm == null) throw new PetShopApiException(400, "Missing required parameter 'realm' when calling PostExecutionRaisePriority");
        // verify the required parameter 'executionId' is set
        if (executionId == null) throw new PetShopApiException(400, "Missing required parameter 'executionId' when calling PostExecutionRaisePriority");
        
        var path_ = new StringBuilder("/{realm}/authentication/executions/{executionId}/raise-priority"); 
        path_ = path_.Replace("{realm}", ParameterToString(realm));
        path_ = path_.Replace("{executionId}", ParameterToString(executionId));

        
        
        await CallApi(
                    path_.ToString(), 
                    HttpMethod.Post,  
                    ct: ct
        );
    }

    /// <inheritdoc />     
    public async Task PostExecutions(string realm, AuthenticationExecutionRepresentation body, CancellationToken ct)
    {
        // verify the required parameter 'realm' is set
        if (realm == null) throw new PetShopApiException(400, "Missing required parameter 'realm' when calling PostExecutions");
        
        var path_ = new StringBuilder("/{realm}/authentication/executions"); 
        path_ = path_.Replace("{realm}", ParameterToString(realm));

        
        
        await CallApi(
                    path_.ToString(), 
                    HttpMethod.Post,
                    body: body,   
                    ct: ct
        );
    }

    /// <inheritdoc />     
    public async Task PostFlow(string realm, string flowAlias, string body, CancellationToken ct)
    {
        // verify the required parameter 'realm' is set
        if (realm == null) throw new PetShopApiException(400, "Missing required parameter 'realm' when calling PostFlow");
        // verify the required parameter 'flowAlias' is set
        if (flowAlias == null) throw new PetShopApiException(400, "Missing required parameter 'flowAlias' when calling PostFlow");
        
        var path_ = new StringBuilder("/{realm}/authentication/flows/{flowAlias}/executions/flow"); 
        path_ = path_.Replace("{realm}", ParameterToString(realm));
        path_ = path_.Replace("{flowAlias}", ParameterToString(flowAlias));

        
        
        await CallApi(
                    path_.ToString(), 
                    HttpMethod.Post,
                    body: body,   
                    ct: ct
        );
    }

    /// <inheritdoc />     
    public async Task PostFlows(string realm, AuthenticationFlowRepresentation body, CancellationToken ct)
    {
        // verify the required parameter 'realm' is set
        if (realm == null) throw new PetShopApiException(400, "Missing required parameter 'realm' when calling PostFlows");
        
        var path_ = new StringBuilder("/{realm}/authentication/flows"); 
        path_ = path_.Replace("{realm}", ParameterToString(realm));

        
        
        await CallApi(
                    path_.ToString(), 
                    HttpMethod.Post,
                    body: body,   
                    ct: ct
        );
    }

    /// <inheritdoc />     
    public async Task PostRegisterRequiredAction(string realm, string body, CancellationToken ct)
    {
        // verify the required parameter 'realm' is set
        if (realm == null) throw new PetShopApiException(400, "Missing required parameter 'realm' when calling PostRegisterRequiredAction");
        
        var path_ = new StringBuilder("/{realm}/authentication/register-required-action"); 
        path_ = path_.Replace("{realm}", ParameterToString(realm));

        
        
        await CallApi(
                    path_.ToString(), 
                    HttpMethod.Post,
                    body: body,   
                    ct: ct
        );
    }

    /// <inheritdoc />     
    public async Task PostRequiredActionLowerPriority(string realm, string alias, CancellationToken ct)
    {
        // verify the required parameter 'realm' is set
        if (realm == null) throw new PetShopApiException(400, "Missing required parameter 'realm' when calling PostRequiredActionLowerPriority");
        // verify the required parameter 'alias' is set
        if (alias == null) throw new PetShopApiException(400, "Missing required parameter 'alias' when calling PostRequiredActionLowerPriority");
        
        var path_ = new StringBuilder("/{realm}/authentication/required-actions/{alias}/lower-priority"); 
        path_ = path_.Replace("{realm}", ParameterToString(realm));
        path_ = path_.Replace("{alias}", ParameterToString(alias));

        
        
        await CallApi(
                    path_.ToString(), 
                    HttpMethod.Post,  
                    ct: ct
        );
    }

    /// <inheritdoc />     
    public async Task PostRequiredActionRaisePriority(string realm, string alias, CancellationToken ct)
    {
        // verify the required parameter 'realm' is set
        if (realm == null) throw new PetShopApiException(400, "Missing required parameter 'realm' when calling PostRequiredActionRaisePriority");
        // verify the required parameter 'alias' is set
        if (alias == null) throw new PetShopApiException(400, "Missing required parameter 'alias' when calling PostRequiredActionRaisePriority");
        
        var path_ = new StringBuilder("/{realm}/authentication/required-actions/{alias}/raise-priority"); 
        path_ = path_.Replace("{realm}", ParameterToString(realm));
        path_ = path_.Replace("{alias}", ParameterToString(alias));

        
        
        await CallApi(
                    path_.ToString(), 
                    HttpMethod.Post,  
                    ct: ct
        );
    }

    /// <inheritdoc />     
    public async Task PutAuthenticationConfig(string realm, string id, AuthenticatorConfigRepresentation body, CancellationToken ct)
    {
        // verify the required parameter 'realm' is set
        if (realm == null) throw new PetShopApiException(400, "Missing required parameter 'realm' when calling PutAuthenticationConfig");
        // verify the required parameter 'id' is set
        if (id == null) throw new PetShopApiException(400, "Missing required parameter 'id' when calling PutAuthenticationConfig");
        
        var path_ = new StringBuilder("/{realm}/authentication/config/{id}"); 
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
    public async Task PutExecutions(string realm, string flowAlias, AuthenticationExecutionInfoRepresentation body, CancellationToken ct)
    {
        // verify the required parameter 'realm' is set
        if (realm == null) throw new PetShopApiException(400, "Missing required parameter 'realm' when calling PutExecutions");
        // verify the required parameter 'flowAlias' is set
        if (flowAlias == null) throw new PetShopApiException(400, "Missing required parameter 'flowAlias' when calling PutExecutions");
        
        var path_ = new StringBuilder("/{realm}/authentication/flows/{flowAlias}/executions"); 
        path_ = path_.Replace("{realm}", ParameterToString(realm));
        path_ = path_.Replace("{flowAlias}", ParameterToString(flowAlias));

        
        
        await CallApi(
                    path_.ToString(), 
                    HttpMethod.Put,
                    body: body,   
                    ct: ct
        );
    }

    /// <inheritdoc />     
    public async Task PutFlow(string realm, string id, AuthenticationFlowRepresentation body, CancellationToken ct)
    {
        // verify the required parameter 'realm' is set
        if (realm == null) throw new PetShopApiException(400, "Missing required parameter 'realm' when calling PutFlow");
        // verify the required parameter 'id' is set
        if (id == null) throw new PetShopApiException(400, "Missing required parameter 'id' when calling PutFlow");
        
        var path_ = new StringBuilder("/{realm}/authentication/flows/{id}"); 
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
    public async Task PutRequiredAction(string realm, string alias, RequiredActionProviderRepresentation body, CancellationToken ct)
    {
        // verify the required parameter 'realm' is set
        if (realm == null) throw new PetShopApiException(400, "Missing required parameter 'realm' when calling PutRequiredAction");
        // verify the required parameter 'alias' is set
        if (alias == null) throw new PetShopApiException(400, "Missing required parameter 'alias' when calling PutRequiredAction");
        
        var path_ = new StringBuilder("/{realm}/authentication/required-actions/{alias}"); 
        path_ = path_.Replace("{realm}", ParameterToString(realm));
        path_ = path_.Replace("{alias}", ParameterToString(alias));

        
        
        await CallApi(
                    path_.ToString(), 
                    HttpMethod.Put,
                    body: body,   
                    ct: ct
        );
    }

}
