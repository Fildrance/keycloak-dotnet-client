using System;
using System.Collections.Generic;
using RestSharp;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace IO.Swagger.Api
{
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface IAuthenticationManagementApi
    {
        /// <summary>
        ///  Delete authenticator configuration
        /// </summary>
        /// <param name="realm">realm name (not id!)</param>
        /// <param name="id">Configuration id</param>
        /// <returns></returns>
        void DeleteConfig (string realm, string id);
        /// <summary>
        ///  Delete execution
        /// </summary>
        /// <param name="realm">realm name (not id!)</param>
        /// <param name="executionId"></param>
        /// <returns></returns>
        void DeleteExecution (string realm, string executionId);
        /// <summary>
        ///  Delete an authentication flow
        /// </summary>
        /// <param name="realm">realm name (not id!)</param>
        /// <param name="id"></param>
        /// <returns></returns>
        void DeleteFlow (string realm, string id);
        /// <summary>
        ///  Delete required action
        /// </summary>
        /// <param name="realm">realm name (not id!)</param>
        /// <param name="alias">Alias of required action</param>
        /// <returns></returns>
        void DeleteRequiredAction (string realm, string alias);
        /// <summary>
        ///  Get authenticator configuration
        /// </summary>
        /// <param name="realm">realm name (not id!)</param>
        /// <param name="id">Configuration id</param>
        /// <returns>AuthenticatorConfigRepresentation</returns>
        AuthenticatorConfigRepresentation GetAuthenticationConfig (string realm, string id);
        /// <summary>
        ///  Get authenticator providers Returns a stream of authenticator providers.
        /// </summary>
        /// <param name="realm">realm name (not id!)</param>
        /// <returns>List&lt;Object&gt;</returns>
        List<Object> GetAuthenticatorProviders (string realm);
        /// <summary>
        ///  Get client authenticator providers Returns a stream of client authenticator providers.
        /// </summary>
        /// <param name="realm">realm name (not id!)</param>
        /// <returns>List&lt;Object&gt;</returns>
        List<Object> GetClientAuthenticatorProviders (string realm);
        /// <summary>
        ///  Get authenticator provider’s configuration description
        /// </summary>
        /// <param name="realm">realm name (not id!)</param>
        /// <param name="providerId"></param>
        /// <returns>AuthenticatorConfigInfoRepresentation</returns>
        AuthenticatorConfigInfoRepresentation GetConfigDescription (string realm, string providerId);
        /// <summary>
        ///  Get Single Execution
        /// </summary>
        /// <param name="realm">realm name (not id!)</param>
        /// <param name="executionId"></param>
        /// <returns></returns>
        void GetExecution (string realm, string executionId);
        /// <summary>
        ///  Get execution’s configuration
        /// </summary>
        /// <param name="realm">realm name (not id!)</param>
        /// <param name="executionId">Execution id</param>
        /// <param name="id">Configuration id</param>
        /// <returns>AuthenticatorConfigRepresentation</returns>
        AuthenticatorConfigRepresentation GetExecutionConfig (string realm, string executionId, string id);
        /// <summary>
        ///  Get authentication executions for a flow
        /// </summary>
        /// <param name="realm">realm name (not id!)</param>
        /// <param name="flowAlias">Flow alias</param>
        /// <returns></returns>
        void GetExecutions (string realm, string flowAlias);
        /// <summary>
        ///  Get authentication flow for id
        /// </summary>
        /// <param name="realm">realm name (not id!)</param>
        /// <param name="id"></param>
        /// <returns>AuthenticationFlowRepresentation</returns>
        AuthenticationFlowRepresentation GetFlow (string realm, string id);
        /// <summary>
        ///  Get authentication flows Returns a stream of authentication flows.
        /// </summary>
        /// <param name="realm">realm name (not id!)</param>
        /// <returns>List&lt;AuthenticationFlowRepresentation&gt;</returns>
        List<AuthenticationFlowRepresentation> GetFlows (string realm);
        /// <summary>
        ///  Get form action providers Returns a stream of form action providers.
        /// </summary>
        /// <param name="realm">realm name (not id!)</param>
        /// <returns>List&lt;Object&gt;</returns>
        List<Object> GetFormActionProviders (string realm);
        /// <summary>
        ///  Get form providers Returns a stream of form providers.
        /// </summary>
        /// <param name="realm">realm name (not id!)</param>
        /// <returns>List&lt;Object&gt;</returns>
        List<Object> GetFormProviders (string realm);
        /// <summary>
        ///  Get configuration descriptions for all clients
        /// </summary>
        /// <param name="realm">realm name (not id!)</param>
        /// <returns>Dictionary&lt;string, ConfigPropertyRepresentation&gt;</returns>
        Dictionary<string, ConfigPropertyRepresentation> GetPerClientConfigDescription (string realm);
        /// <summary>
        ///  Get required action for alias
        /// </summary>
        /// <param name="realm">realm name (not id!)</param>
        /// <param name="alias">Alias of required action</param>
        /// <returns>RequiredActionProviderRepresentation</returns>
        RequiredActionProviderRepresentation GetRequiredAction (string realm, string alias);
        /// <summary>
        ///  Get required actions Returns a stream of required actions.
        /// </summary>
        /// <param name="realm">realm name (not id!)</param>
        /// <returns>List&lt;RequiredActionProviderRepresentation&gt;</returns>
        List<RequiredActionProviderRepresentation> GetRequiredActions (string realm);
        /// <summary>
        ///  Get unregistered required actions Returns a stream of unregistered required actions.
        /// </summary>
        /// <param name="realm">realm name (not id!)</param>
        /// <returns>List&lt;string&gt;</returns>
        List<string> GetUnregisteredRequiredActions (string realm);
        /// <summary>
        ///  Create new authenticator configuration
        /// </summary>
        /// <param name="realm">realm name (not id!)</param>
        /// <param name="body">AuthenticatorConfigRepresentation</param>
        /// <returns></returns>
        void PostAuthenticationConfig (string realm, AuthenticatorConfigRepresentation body);
        /// <summary>
        ///  Copy existing authentication flow under a new name The new name is given as &#x27;newName&#x27; attribute of the passed JSON object
        /// </summary>
        /// <param name="realm">realm name (not id!)</param>
        /// <param name="flowAlias">name of the existing authentication flow</param>
        /// <param name="body">[string]</param>
        /// <returns></returns>
        void PostCopy (string realm, string flowAlias, string body);
        /// <summary>
        ///  Add new authentication execution to a flow
        /// </summary>
        /// <param name="realm">realm name (not id!)</param>
        /// <param name="flowAlias">Alias of parent flow</param>
        /// <param name="body">[string]</param>
        /// <returns></returns>
        void PostExecution (string realm, string flowAlias, string body);
        /// <summary>
        ///  Update execution with new configuration
        /// </summary>
        /// <param name="realm">realm name (not id!)</param>
        /// <param name="executionId">Execution id</param>
        /// <param name="body">AuthenticatorConfigRepresentation</param>
        /// <returns></returns>
        void PostExecutionConfig (string realm, string executionId, AuthenticatorConfigRepresentation body);
        /// <summary>
        ///  Lower execution’s priority
        /// </summary>
        /// <param name="realm">realm name (not id!)</param>
        /// <param name="executionId">Execution id</param>
        /// <returns></returns>
        void PostExecutionLowerPriority (string realm, string executionId);
        /// <summary>
        ///  Raise execution’s priority
        /// </summary>
        /// <param name="realm">realm name (not id!)</param>
        /// <param name="executionId">Execution id</param>
        /// <returns></returns>
        void PostExecutionRaisePriority (string realm, string executionId);
        /// <summary>
        ///  Add new authentication execution
        /// </summary>
        /// <param name="realm">realm name (not id!)</param>
        /// <param name="body">AuthenticationExecutionRepresentation</param>
        /// <returns></returns>
        void PostExecutions (string realm, AuthenticationExecutionRepresentation body);
        /// <summary>
        ///  Add new flow with new execution to existing flow
        /// </summary>
        /// <param name="realm">realm name (not id!)</param>
        /// <param name="flowAlias">Alias of parent authentication flow</param>
        /// <param name="body">[string]</param>
        /// <returns></returns>
        void PostFlow (string realm, string flowAlias, string body);
        /// <summary>
        ///  Create a new authentication flow
        /// </summary>
        /// <param name="realm">realm name (not id!)</param>
        /// <param name="body">AuthenticationFlowRepresentation</param>
        /// <returns></returns>
        void PostFlows (string realm, AuthenticationFlowRepresentation body);
        /// <summary>
        ///  Register a new required actions
        /// </summary>
        /// <param name="realm">realm name (not id!)</param>
        /// <param name="body">[string]</param>
        /// <returns></returns>
        void PostRegisterRequiredAction (string realm, string body);
        /// <summary>
        ///  Lower required action’s priority
        /// </summary>
        /// <param name="realm">realm name (not id!)</param>
        /// <param name="alias">Alias of required action</param>
        /// <returns></returns>
        void PostRequiredActionLowerPriority (string realm, string alias);
        /// <summary>
        ///  Raise required action’s priority
        /// </summary>
        /// <param name="realm">realm name (not id!)</param>
        /// <param name="alias">Alias of required action</param>
        /// <returns></returns>
        void PostRequiredActionRaisePriority (string realm, string alias);
        /// <summary>
        ///  Update authenticator configuration
        /// </summary>
        /// <param name="realm">realm name (not id!)</param>
        /// <param name="id">Configuration id</param>
        /// <param name="body">AuthenticatorConfigRepresentation</param>
        /// <returns></returns>
        void PutAuthenticationConfig (string realm, string id, AuthenticatorConfigRepresentation body);
        /// <summary>
        ///  Update authentication executions of a Flow
        /// </summary>
        /// <param name="realm">realm name (not id!)</param>
        /// <param name="flowAlias">Flow alias</param>
        /// <param name="body">AuthenticationExecutionInfoRepresentation</param>
        /// <returns></returns>
        void PutExecutions (string realm, string flowAlias, AuthenticationExecutionInfoRepresentation body);
        /// <summary>
        ///  Update an authentication flow
        /// </summary>
        /// <param name="realm">realm name (not id!)</param>
        /// <param name="id"></param>
        /// <param name="body">AuthenticationFlowRepresentation</param>
        /// <returns></returns>
        void PutFlow (string realm, string id, AuthenticationFlowRepresentation body);
        /// <summary>
        ///  Update required action
        /// </summary>
        /// <param name="realm">realm name (not id!)</param>
        /// <param name="alias">Alias of required action</param>
        /// <param name="body">RequiredActionProviderRepresentation</param>
        /// <returns></returns>
        void PutRequiredAction (string realm, string alias, RequiredActionProviderRepresentation body);
    }
  
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public class AuthenticationManagementApi : IAuthenticationManagementApi
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AuthenticationManagementApi"/> class.
        /// </summary>
        /// <param name="apiClient"> an instance of ApiClient (optional)</param>
        /// <returns></returns>
        public AuthenticationManagementApi(ApiClient apiClient = null)
        {
            if (apiClient == null) // use the default one in Configuration
                this.ApiClient = Configuration.DefaultApiClient; 
            else
                this.ApiClient = apiClient;
        }
    
        /// <summary>
        /// Initializes a new instance of the <see cref="AuthenticationManagementApi"/> class.
        /// </summary>
        /// <returns></returns>
        public AuthenticationManagementApi(String basePath)
        {
            this.ApiClient = new ApiClient(basePath);
        }
    
        /// <summary>
        /// Sets the base path of the API client.
        /// </summary>
        /// <param name="basePath">The base path</param>
        /// <value>The base path</value>
        public void SetBasePath(String basePath)
        {
            this.ApiClient.BasePath = basePath;
        }
    
        /// <summary>
        /// Gets the base path of the API client.
        /// </summary>
        /// <param name="basePath">The base path</param>
        /// <value>The base path</value>
        public String GetBasePath(String basePath)
        {
            return this.ApiClient.BasePath;
        }
    
        /// <summary>
        /// Gets or sets the API client.
        /// </summary>
        /// <value>An instance of the ApiClient</value>
        public ApiClient ApiClient {get; set;}
    
        /// <summary>
        ///  Delete authenticator configuration
        /// </summary>
        /// <param name="realm">realm name (not id!)</param>
        /// <param name="id">Configuration id</param>
        /// <returns></returns>
        public void DeleteConfig (string realm, string id)
        {
            // verify the required parameter 'realm' is set
            if (realm == null) throw new ApiException(400, "Missing required parameter 'realm' when calling DeleteConfig");
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling DeleteConfig");
    
            var path = "/{realm}/authentication/config/{id}";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "realm" + "}", ApiClient.ParameterToString(realm));
path = path.Replace("{" + "id" + "}", ApiClient.ParameterToString(id));
    
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
                                    
            // authentication setting, if any
            String[] authSettings = new String[] { "access_token" };
    
            // make the HTTP request
            RestResponseBase response = (RestResponseBase) ApiClient.CallApi(path, Method.Delete, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling DeleteConfig: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling DeleteConfig: " + response.ErrorMessage, response.ErrorMessage);
    
            return;
        }
    
        /// <summary>
        ///  Delete execution
        /// </summary>
        /// <param name="realm">realm name (not id!)</param>
        /// <param name="executionId"></param>
        /// <returns></returns>
        public void DeleteExecution (string realm, string executionId)
        {
            // verify the required parameter 'realm' is set
            if (realm == null) throw new ApiException(400, "Missing required parameter 'realm' when calling DeleteExecution");
            // verify the required parameter 'executionId' is set
            if (executionId == null) throw new ApiException(400, "Missing required parameter 'executionId' when calling DeleteExecution");
    
            var path = "/{realm}/authentication/executions/{executionId}";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "realm" + "}", ApiClient.ParameterToString(realm));
path = path.Replace("{" + "executionId" + "}", ApiClient.ParameterToString(executionId));
    
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
                                    
            // authentication setting, if any
            String[] authSettings = new String[] { "access_token" };
    
            // make the HTTP request
            RestResponseBase response = (RestResponseBase) ApiClient.CallApi(path, Method.Delete, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling DeleteExecution: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling DeleteExecution: " + response.ErrorMessage, response.ErrorMessage);
    
            return;
        }
    
        /// <summary>
        ///  Delete an authentication flow
        /// </summary>
        /// <param name="realm">realm name (not id!)</param>
        /// <param name="id"></param>
        /// <returns></returns>
        public void DeleteFlow (string realm, string id)
        {
            // verify the required parameter 'realm' is set
            if (realm == null) throw new ApiException(400, "Missing required parameter 'realm' when calling DeleteFlow");
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling DeleteFlow");
    
            var path = "/{realm}/authentication/flows/{id}";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "realm" + "}", ApiClient.ParameterToString(realm));
path = path.Replace("{" + "id" + "}", ApiClient.ParameterToString(id));
    
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
                                    
            // authentication setting, if any
            String[] authSettings = new String[] { "access_token" };
    
            // make the HTTP request
            RestResponseBase response = (RestResponseBase) ApiClient.CallApi(path, Method.Delete, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling DeleteFlow: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling DeleteFlow: " + response.ErrorMessage, response.ErrorMessage);
    
            return;
        }
    
        /// <summary>
        ///  Delete required action
        /// </summary>
        /// <param name="realm">realm name (not id!)</param>
        /// <param name="alias">Alias of required action</param>
        /// <returns></returns>
        public void DeleteRequiredAction (string realm, string alias)
        {
            // verify the required parameter 'realm' is set
            if (realm == null) throw new ApiException(400, "Missing required parameter 'realm' when calling DeleteRequiredAction");
            // verify the required parameter 'alias' is set
            if (alias == null) throw new ApiException(400, "Missing required parameter 'alias' when calling DeleteRequiredAction");
    
            var path = "/{realm}/authentication/required-actions/{alias}";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "realm" + "}", ApiClient.ParameterToString(realm));
path = path.Replace("{" + "alias" + "}", ApiClient.ParameterToString(alias));
    
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
                                    
            // authentication setting, if any
            String[] authSettings = new String[] { "access_token" };
    
            // make the HTTP request
            RestResponseBase response = (RestResponseBase) ApiClient.CallApi(path, Method.Delete, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling DeleteRequiredAction: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling DeleteRequiredAction: " + response.ErrorMessage, response.ErrorMessage);
    
            return;
        }
    
        /// <summary>
        ///  Get authenticator configuration
        /// </summary>
        /// <param name="realm">realm name (not id!)</param>
        /// <param name="id">Configuration id</param>
        /// <returns>AuthenticatorConfigRepresentation</returns>
        public AuthenticatorConfigRepresentation GetAuthenticationConfig (string realm, string id)
        {
            // verify the required parameter 'realm' is set
            if (realm == null) throw new ApiException(400, "Missing required parameter 'realm' when calling GetAuthenticationConfig");
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling GetAuthenticationConfig");
    
            var path = "/{realm}/authentication/config/{id}";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "realm" + "}", ApiClient.ParameterToString(realm));
path = path.Replace("{" + "id" + "}", ApiClient.ParameterToString(id));
    
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
                                    
            // authentication setting, if any
            String[] authSettings = new String[] { "access_token" };
    
            // make the HTTP request
            RestResponseBase response = (RestResponseBase) ApiClient.CallApi(path, Method.Get, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling GetAuthenticationConfig: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling GetAuthenticationConfig: " + response.ErrorMessage, response.ErrorMessage);
    
            return (AuthenticatorConfigRepresentation) ApiClient.Deserialize(response.Content, typeof(AuthenticatorConfigRepresentation), response.Headers);
        }
    
        /// <summary>
        ///  Get authenticator providers Returns a stream of authenticator providers.
        /// </summary>
        /// <param name="realm">realm name (not id!)</param>
        /// <returns>List&lt;Object&gt;</returns>
        public List<Object> GetAuthenticatorProviders (string realm)
        {
            // verify the required parameter 'realm' is set
            if (realm == null) throw new ApiException(400, "Missing required parameter 'realm' when calling GetAuthenticatorProviders");
    
            var path = "/{realm}/authentication/authenticator-providers";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "realm" + "}", ApiClient.ParameterToString(realm));
    
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
                                    
            // authentication setting, if any
            String[] authSettings = new String[] { "access_token" };
    
            // make the HTTP request
            RestResponseBase response = (RestResponseBase) ApiClient.CallApi(path, Method.Get, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling GetAuthenticatorProviders: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling GetAuthenticatorProviders: " + response.ErrorMessage, response.ErrorMessage);
    
            return (List<Object>) ApiClient.Deserialize(response.Content, typeof(List<Object>), response.Headers);
        }
    
        /// <summary>
        ///  Get client authenticator providers Returns a stream of client authenticator providers.
        /// </summary>
        /// <param name="realm">realm name (not id!)</param>
        /// <returns>List&lt;Object&gt;</returns>
        public List<Object> GetClientAuthenticatorProviders (string realm)
        {
            // verify the required parameter 'realm' is set
            if (realm == null) throw new ApiException(400, "Missing required parameter 'realm' when calling GetClientAuthenticatorProviders");
    
            var path = "/{realm}/authentication/client-authenticator-providers";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "realm" + "}", ApiClient.ParameterToString(realm));
    
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
                                    
            // authentication setting, if any
            String[] authSettings = new String[] { "access_token" };
    
            // make the HTTP request
            RestResponseBase response = (RestResponseBase) ApiClient.CallApi(path, Method.Get, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling GetClientAuthenticatorProviders: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling GetClientAuthenticatorProviders: " + response.ErrorMessage, response.ErrorMessage);
    
            return (List<Object>) ApiClient.Deserialize(response.Content, typeof(List<Object>), response.Headers);
        }
    
        /// <summary>
        ///  Get authenticator provider’s configuration description
        /// </summary>
        /// <param name="realm">realm name (not id!)</param>
        /// <param name="providerId"></param>
        /// <returns>AuthenticatorConfigInfoRepresentation</returns>
        public AuthenticatorConfigInfoRepresentation GetConfigDescription (string realm, string providerId)
        {
            // verify the required parameter 'realm' is set
            if (realm == null) throw new ApiException(400, "Missing required parameter 'realm' when calling GetConfigDescription");
            // verify the required parameter 'providerId' is set
            if (providerId == null) throw new ApiException(400, "Missing required parameter 'providerId' when calling GetConfigDescription");
    
            var path = "/{realm}/authentication/config-description/{providerId}";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "realm" + "}", ApiClient.ParameterToString(realm));
path = path.Replace("{" + "providerId" + "}", ApiClient.ParameterToString(providerId));
    
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
                                    
            // authentication setting, if any
            String[] authSettings = new String[] { "access_token" };
    
            // make the HTTP request
            RestResponseBase response = (RestResponseBase) ApiClient.CallApi(path, Method.Get, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling GetConfigDescription: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling GetConfigDescription: " + response.ErrorMessage, response.ErrorMessage);
    
            return (AuthenticatorConfigInfoRepresentation) ApiClient.Deserialize(response.Content, typeof(AuthenticatorConfigInfoRepresentation), response.Headers);
        }
    
        /// <summary>
        ///  Get Single Execution
        /// </summary>
        /// <param name="realm">realm name (not id!)</param>
        /// <param name="executionId"></param>
        /// <returns></returns>
        public void GetExecution (string realm, string executionId)
        {
            // verify the required parameter 'realm' is set
            if (realm == null) throw new ApiException(400, "Missing required parameter 'realm' when calling GetExecution");
            // verify the required parameter 'executionId' is set
            if (executionId == null) throw new ApiException(400, "Missing required parameter 'executionId' when calling GetExecution");
    
            var path = "/{realm}/authentication/executions/{executionId}";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "realm" + "}", ApiClient.ParameterToString(realm));
path = path.Replace("{" + "executionId" + "}", ApiClient.ParameterToString(executionId));
    
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
                                    
            // authentication setting, if any
            String[] authSettings = new String[] { "access_token" };
    
            // make the HTTP request
            RestResponseBase response = (RestResponseBase) ApiClient.CallApi(path, Method.Get, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling GetExecution: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling GetExecution: " + response.ErrorMessage, response.ErrorMessage);
    
            return;
        }
    
        /// <summary>
        ///  Get execution’s configuration
        /// </summary>
        /// <param name="realm">realm name (not id!)</param>
        /// <param name="executionId">Execution id</param>
        /// <param name="id">Configuration id</param>
        /// <returns>AuthenticatorConfigRepresentation</returns>
        public AuthenticatorConfigRepresentation GetExecutionConfig (string realm, string executionId, string id)
        {
            // verify the required parameter 'realm' is set
            if (realm == null) throw new ApiException(400, "Missing required parameter 'realm' when calling GetExecutionConfig");
            // verify the required parameter 'executionId' is set
            if (executionId == null) throw new ApiException(400, "Missing required parameter 'executionId' when calling GetExecutionConfig");
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling GetExecutionConfig");
    
            var path = "/{realm}/authentication/executions/{executionId}/config/{id}";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "realm" + "}", ApiClient.ParameterToString(realm));
path = path.Replace("{" + "executionId" + "}", ApiClient.ParameterToString(executionId));
path = path.Replace("{" + "id" + "}", ApiClient.ParameterToString(id));
    
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
                                    
            // authentication setting, if any
            String[] authSettings = new String[] { "access_token" };
    
            // make the HTTP request
            RestResponseBase response = (RestResponseBase) ApiClient.CallApi(path, Method.Get, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling GetExecutionConfig: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling GetExecutionConfig: " + response.ErrorMessage, response.ErrorMessage);
    
            return (AuthenticatorConfigRepresentation) ApiClient.Deserialize(response.Content, typeof(AuthenticatorConfigRepresentation), response.Headers);
        }
    
        /// <summary>
        ///  Get authentication executions for a flow
        /// </summary>
        /// <param name="realm">realm name (not id!)</param>
        /// <param name="flowAlias">Flow alias</param>
        /// <returns></returns>
        public void GetExecutions (string realm, string flowAlias)
        {
            // verify the required parameter 'realm' is set
            if (realm == null) throw new ApiException(400, "Missing required parameter 'realm' when calling GetExecutions");
            // verify the required parameter 'flowAlias' is set
            if (flowAlias == null) throw new ApiException(400, "Missing required parameter 'flowAlias' when calling GetExecutions");
    
            var path = "/{realm}/authentication/flows/{flowAlias}/executions";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "realm" + "}", ApiClient.ParameterToString(realm));
path = path.Replace("{" + "flowAlias" + "}", ApiClient.ParameterToString(flowAlias));
    
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
                                    
            // authentication setting, if any
            String[] authSettings = new String[] { "access_token" };
    
            // make the HTTP request
            RestResponseBase response = (RestResponseBase) ApiClient.CallApi(path, Method.Get, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling GetExecutions: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling GetExecutions: " + response.ErrorMessage, response.ErrorMessage);
    
            return;
        }
    
        /// <summary>
        ///  Get authentication flow for id
        /// </summary>
        /// <param name="realm">realm name (not id!)</param>
        /// <param name="id"></param>
        /// <returns>AuthenticationFlowRepresentation</returns>
        public AuthenticationFlowRepresentation GetFlow (string realm, string id)
        {
            // verify the required parameter 'realm' is set
            if (realm == null) throw new ApiException(400, "Missing required parameter 'realm' when calling GetFlow");
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling GetFlow");
    
            var path = "/{realm}/authentication/flows/{id}";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "realm" + "}", ApiClient.ParameterToString(realm));
path = path.Replace("{" + "id" + "}", ApiClient.ParameterToString(id));
    
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
                                    
            // authentication setting, if any
            String[] authSettings = new String[] { "access_token" };
    
            // make the HTTP request
            RestResponseBase response = (RestResponseBase) ApiClient.CallApi(path, Method.Get, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling GetFlow: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling GetFlow: " + response.ErrorMessage, response.ErrorMessage);
    
            return (AuthenticationFlowRepresentation) ApiClient.Deserialize(response.Content, typeof(AuthenticationFlowRepresentation), response.Headers);
        }
    
        /// <summary>
        ///  Get authentication flows Returns a stream of authentication flows.
        /// </summary>
        /// <param name="realm">realm name (not id!)</param>
        /// <returns>List&lt;AuthenticationFlowRepresentation&gt;</returns>
        public List<AuthenticationFlowRepresentation> GetFlows (string realm)
        {
            // verify the required parameter 'realm' is set
            if (realm == null) throw new ApiException(400, "Missing required parameter 'realm' when calling GetFlows");
    
            var path = "/{realm}/authentication/flows";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "realm" + "}", ApiClient.ParameterToString(realm));
    
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
                                    
            // authentication setting, if any
            String[] authSettings = new String[] { "access_token" };
    
            // make the HTTP request
            RestResponseBase response = (RestResponseBase) ApiClient.CallApi(path, Method.Get, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling GetFlows: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling GetFlows: " + response.ErrorMessage, response.ErrorMessage);
    
            return (List<AuthenticationFlowRepresentation>) ApiClient.Deserialize(response.Content, typeof(List<AuthenticationFlowRepresentation>), response.Headers);
        }
    
        /// <summary>
        ///  Get form action providers Returns a stream of form action providers.
        /// </summary>
        /// <param name="realm">realm name (not id!)</param>
        /// <returns>List&lt;Object&gt;</returns>
        public List<Object> GetFormActionProviders (string realm)
        {
            // verify the required parameter 'realm' is set
            if (realm == null) throw new ApiException(400, "Missing required parameter 'realm' when calling GetFormActionProviders");
    
            var path = "/{realm}/authentication/form-action-providers";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "realm" + "}", ApiClient.ParameterToString(realm));
    
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
                                    
            // authentication setting, if any
            String[] authSettings = new String[] { "access_token" };
    
            // make the HTTP request
            RestResponseBase response = (RestResponseBase) ApiClient.CallApi(path, Method.Get, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling GetFormActionProviders: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling GetFormActionProviders: " + response.ErrorMessage, response.ErrorMessage);
    
            return (List<Object>) ApiClient.Deserialize(response.Content, typeof(List<Object>), response.Headers);
        }
    
        /// <summary>
        ///  Get form providers Returns a stream of form providers.
        /// </summary>
        /// <param name="realm">realm name (not id!)</param>
        /// <returns>List&lt;Object&gt;</returns>
        public List<Object> GetFormProviders (string realm)
        {
            // verify the required parameter 'realm' is set
            if (realm == null) throw new ApiException(400, "Missing required parameter 'realm' when calling GetFormProviders");
    
            var path = "/{realm}/authentication/form-providers";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "realm" + "}", ApiClient.ParameterToString(realm));
    
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
                                    
            // authentication setting, if any
            String[] authSettings = new String[] { "access_token" };
    
            // make the HTTP request
            RestResponseBase response = (RestResponseBase) ApiClient.CallApi(path, Method.Get, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling GetFormProviders: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling GetFormProviders: " + response.ErrorMessage, response.ErrorMessage);
    
            return (List<Object>) ApiClient.Deserialize(response.Content, typeof(List<Object>), response.Headers);
        }
    
        /// <summary>
        ///  Get configuration descriptions for all clients
        /// </summary>
        /// <param name="realm">realm name (not id!)</param>
        /// <returns>Dictionary&lt;string, ConfigPropertyRepresentation&gt;</returns>
        public Dictionary<string, ConfigPropertyRepresentation> GetPerClientConfigDescription (string realm)
        {
            // verify the required parameter 'realm' is set
            if (realm == null) throw new ApiException(400, "Missing required parameter 'realm' when calling GetPerClientConfigDescription");
    
            var path = "/{realm}/authentication/per-client-config-description";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "realm" + "}", ApiClient.ParameterToString(realm));
    
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
                                    
            // authentication setting, if any
            String[] authSettings = new String[] { "access_token" };
    
            // make the HTTP request
            RestResponseBase response = (RestResponseBase) ApiClient.CallApi(path, Method.Get, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling GetPerClientConfigDescription: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling GetPerClientConfigDescription: " + response.ErrorMessage, response.ErrorMessage);
    
            return (Dictionary<string, ConfigPropertyRepresentation>) ApiClient.Deserialize(response.Content, typeof(Dictionary<string, ConfigPropertyRepresentation>), response.Headers);
        }
    
        /// <summary>
        ///  Get required action for alias
        /// </summary>
        /// <param name="realm">realm name (not id!)</param>
        /// <param name="alias">Alias of required action</param>
        /// <returns>RequiredActionProviderRepresentation</returns>
        public RequiredActionProviderRepresentation GetRequiredAction (string realm, string alias)
        {
            // verify the required parameter 'realm' is set
            if (realm == null) throw new ApiException(400, "Missing required parameter 'realm' when calling GetRequiredAction");
            // verify the required parameter 'alias' is set
            if (alias == null) throw new ApiException(400, "Missing required parameter 'alias' when calling GetRequiredAction");
    
            var path = "/{realm}/authentication/required-actions/{alias}";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "realm" + "}", ApiClient.ParameterToString(realm));
path = path.Replace("{" + "alias" + "}", ApiClient.ParameterToString(alias));
    
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
                                    
            // authentication setting, if any
            String[] authSettings = new String[] { "access_token" };
    
            // make the HTTP request
            RestResponseBase response = (RestResponseBase) ApiClient.CallApi(path, Method.Get, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling GetRequiredAction: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling GetRequiredAction: " + response.ErrorMessage, response.ErrorMessage);
    
            return (RequiredActionProviderRepresentation) ApiClient.Deserialize(response.Content, typeof(RequiredActionProviderRepresentation), response.Headers);
        }
    
        /// <summary>
        ///  Get required actions Returns a stream of required actions.
        /// </summary>
        /// <param name="realm">realm name (not id!)</param>
        /// <returns>List&lt;RequiredActionProviderRepresentation&gt;</returns>
        public List<RequiredActionProviderRepresentation> GetRequiredActions (string realm)
        {
            // verify the required parameter 'realm' is set
            if (realm == null) throw new ApiException(400, "Missing required parameter 'realm' when calling GetRequiredActions");
    
            var path = "/{realm}/authentication/required-actions";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "realm" + "}", ApiClient.ParameterToString(realm));
    
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
                                    
            // authentication setting, if any
            String[] authSettings = new String[] { "access_token" };
    
            // make the HTTP request
            RestResponseBase response = (RestResponseBase) ApiClient.CallApi(path, Method.Get, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling GetRequiredActions: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling GetRequiredActions: " + response.ErrorMessage, response.ErrorMessage);
    
            return (List<RequiredActionProviderRepresentation>) ApiClient.Deserialize(response.Content, typeof(List<RequiredActionProviderRepresentation>), response.Headers);
        }
    
        /// <summary>
        ///  Get unregistered required actions Returns a stream of unregistered required actions.
        /// </summary>
        /// <param name="realm">realm name (not id!)</param>
        /// <returns>List&lt;string&gt;</returns>
        public List<string> GetUnregisteredRequiredActions (string realm)
        {
            // verify the required parameter 'realm' is set
            if (realm == null) throw new ApiException(400, "Missing required parameter 'realm' when calling GetUnregisteredRequiredActions");
    
            var path = "/{realm}/authentication/unregistered-required-actions";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "realm" + "}", ApiClient.ParameterToString(realm));
    
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
                                    
            // authentication setting, if any
            String[] authSettings = new String[] { "access_token" };
    
            // make the HTTP request
            RestResponseBase response = (RestResponseBase) ApiClient.CallApi(path, Method.Get, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling GetUnregisteredRequiredActions: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling GetUnregisteredRequiredActions: " + response.ErrorMessage, response.ErrorMessage);
    
            return (List<string>) ApiClient.Deserialize(response.Content, typeof(List<string>), response.Headers);
        }
    
        /// <summary>
        ///  Create new authenticator configuration
        /// </summary>
        /// <param name="realm">realm name (not id!)</param>
        /// <param name="body">AuthenticatorConfigRepresentation</param>
        /// <returns></returns>
        public void PostAuthenticationConfig (string realm, AuthenticatorConfigRepresentation body)
        {
            // verify the required parameter 'realm' is set
            if (realm == null) throw new ApiException(400, "Missing required parameter 'realm' when calling PostAuthenticationConfig");
    
            var path = "/{realm}/authentication/config";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "realm" + "}", ApiClient.ParameterToString(realm));
    
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
                                    postBody = ApiClient.Serialize(body); // http body (model) parameter

            // authentication setting, if any
            String[] authSettings = new String[] { "access_token" };
    
            // make the HTTP request
            RestResponseBase response = (RestResponseBase) ApiClient.CallApi(path, Method.Post, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling PostAuthenticationConfig: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling PostAuthenticationConfig: " + response.ErrorMessage, response.ErrorMessage);
    
            return;
        }
    
        /// <summary>
        ///  Copy existing authentication flow under a new name The new name is given as &#x27;newName&#x27; attribute of the passed JSON object
        /// </summary>
        /// <param name="realm">realm name (not id!)</param>
        /// <param name="flowAlias">name of the existing authentication flow</param>
        /// <param name="body">[string]</param>
        /// <returns></returns>
        public void PostCopy (string realm, string flowAlias, string body)
        {
            // verify the required parameter 'realm' is set
            if (realm == null) throw new ApiException(400, "Missing required parameter 'realm' when calling PostCopy");
            // verify the required parameter 'flowAlias' is set
            if (flowAlias == null) throw new ApiException(400, "Missing required parameter 'flowAlias' when calling PostCopy");
    
            var path = "/{realm}/authentication/flows/{flowAlias}/copy";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "realm" + "}", ApiClient.ParameterToString(realm));
path = path.Replace("{" + "flowAlias" + "}", ApiClient.ParameterToString(flowAlias));
    
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
                                    postBody = ApiClient.Serialize(body); // http body (model) parameter

            // authentication setting, if any
            String[] authSettings = new String[] { "access_token" };
    
            // make the HTTP request
            RestResponseBase response = (RestResponseBase) ApiClient.CallApi(path, Method.Post, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling PostCopy: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling PostCopy: " + response.ErrorMessage, response.ErrorMessage);
    
            return;
        }
    
        /// <summary>
        ///  Add new authentication execution to a flow
        /// </summary>
        /// <param name="realm">realm name (not id!)</param>
        /// <param name="flowAlias">Alias of parent flow</param>
        /// <param name="body">[string]</param>
        /// <returns></returns>
        public void PostExecution (string realm, string flowAlias, string body)
        {
            // verify the required parameter 'realm' is set
            if (realm == null) throw new ApiException(400, "Missing required parameter 'realm' when calling PostExecution");
            // verify the required parameter 'flowAlias' is set
            if (flowAlias == null) throw new ApiException(400, "Missing required parameter 'flowAlias' when calling PostExecution");
    
            var path = "/{realm}/authentication/flows/{flowAlias}/executions/execution";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "realm" + "}", ApiClient.ParameterToString(realm));
path = path.Replace("{" + "flowAlias" + "}", ApiClient.ParameterToString(flowAlias));
    
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
                                    postBody = ApiClient.Serialize(body); // http body (model) parameter

            // authentication setting, if any
            String[] authSettings = new String[] { "access_token" };
    
            // make the HTTP request
            RestResponseBase response = (RestResponseBase) ApiClient.CallApi(path, Method.Post, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling PostExecution: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling PostExecution: " + response.ErrorMessage, response.ErrorMessage);
    
            return;
        }
    
        /// <summary>
        ///  Update execution with new configuration
        /// </summary>
        /// <param name="realm">realm name (not id!)</param>
        /// <param name="executionId">Execution id</param>
        /// <param name="body">AuthenticatorConfigRepresentation</param>
        /// <returns></returns>
        public void PostExecutionConfig (string realm, string executionId, AuthenticatorConfigRepresentation body)
        {
            // verify the required parameter 'realm' is set
            if (realm == null) throw new ApiException(400, "Missing required parameter 'realm' when calling PostExecutionConfig");
            // verify the required parameter 'executionId' is set
            if (executionId == null) throw new ApiException(400, "Missing required parameter 'executionId' when calling PostExecutionConfig");
    
            var path = "/{realm}/authentication/executions/{executionId}/config";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "realm" + "}", ApiClient.ParameterToString(realm));
path = path.Replace("{" + "executionId" + "}", ApiClient.ParameterToString(executionId));
    
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
                                    postBody = ApiClient.Serialize(body); // http body (model) parameter

            // authentication setting, if any
            String[] authSettings = new String[] { "access_token" };
    
            // make the HTTP request
            RestResponseBase response = (RestResponseBase) ApiClient.CallApi(path, Method.Post, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling PostExecutionConfig: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling PostExecutionConfig: " + response.ErrorMessage, response.ErrorMessage);
    
            return;
        }
    
        /// <summary>
        ///  Lower execution’s priority
        /// </summary>
        /// <param name="realm">realm name (not id!)</param>
        /// <param name="executionId">Execution id</param>
        /// <returns></returns>
        public void PostExecutionLowerPriority (string realm, string executionId)
        {
            // verify the required parameter 'realm' is set
            if (realm == null) throw new ApiException(400, "Missing required parameter 'realm' when calling PostExecutionLowerPriority");
            // verify the required parameter 'executionId' is set
            if (executionId == null) throw new ApiException(400, "Missing required parameter 'executionId' when calling PostExecutionLowerPriority");
    
            var path = "/{realm}/authentication/executions/{executionId}/lower-priority";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "realm" + "}", ApiClient.ParameterToString(realm));
path = path.Replace("{" + "executionId" + "}", ApiClient.ParameterToString(executionId));
    
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
                                    
            // authentication setting, if any
            String[] authSettings = new String[] { "access_token" };
    
            // make the HTTP request
            RestResponseBase response = (RestResponseBase) ApiClient.CallApi(path, Method.Post, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling PostExecutionLowerPriority: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling PostExecutionLowerPriority: " + response.ErrorMessage, response.ErrorMessage);
    
            return;
        }
    
        /// <summary>
        ///  Raise execution’s priority
        /// </summary>
        /// <param name="realm">realm name (not id!)</param>
        /// <param name="executionId">Execution id</param>
        /// <returns></returns>
        public void PostExecutionRaisePriority (string realm, string executionId)
        {
            // verify the required parameter 'realm' is set
            if (realm == null) throw new ApiException(400, "Missing required parameter 'realm' when calling PostExecutionRaisePriority");
            // verify the required parameter 'executionId' is set
            if (executionId == null) throw new ApiException(400, "Missing required parameter 'executionId' when calling PostExecutionRaisePriority");
    
            var path = "/{realm}/authentication/executions/{executionId}/raise-priority";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "realm" + "}", ApiClient.ParameterToString(realm));
path = path.Replace("{" + "executionId" + "}", ApiClient.ParameterToString(executionId));
    
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
                                    
            // authentication setting, if any
            String[] authSettings = new String[] { "access_token" };
    
            // make the HTTP request
            RestResponseBase response = (RestResponseBase) ApiClient.CallApi(path, Method.Post, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling PostExecutionRaisePriority: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling PostExecutionRaisePriority: " + response.ErrorMessage, response.ErrorMessage);
    
            return;
        }
    
        /// <summary>
        ///  Add new authentication execution
        /// </summary>
        /// <param name="realm">realm name (not id!)</param>
        /// <param name="body">AuthenticationExecutionRepresentation</param>
        /// <returns></returns>
        public void PostExecutions (string realm, AuthenticationExecutionRepresentation body)
        {
            // verify the required parameter 'realm' is set
            if (realm == null) throw new ApiException(400, "Missing required parameter 'realm' when calling PostExecutions");
    
            var path = "/{realm}/authentication/executions";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "realm" + "}", ApiClient.ParameterToString(realm));
    
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
                                    postBody = ApiClient.Serialize(body); // http body (model) parameter

            // authentication setting, if any
            String[] authSettings = new String[] { "access_token" };
    
            // make the HTTP request
            RestResponseBase response = (RestResponseBase) ApiClient.CallApi(path, Method.Post, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling PostExecutions: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling PostExecutions: " + response.ErrorMessage, response.ErrorMessage);
    
            return;
        }
    
        /// <summary>
        ///  Add new flow with new execution to existing flow
        /// </summary>
        /// <param name="realm">realm name (not id!)</param>
        /// <param name="flowAlias">Alias of parent authentication flow</param>
        /// <param name="body">[string]</param>
        /// <returns></returns>
        public void PostFlow (string realm, string flowAlias, string body)
        {
            // verify the required parameter 'realm' is set
            if (realm == null) throw new ApiException(400, "Missing required parameter 'realm' when calling PostFlow");
            // verify the required parameter 'flowAlias' is set
            if (flowAlias == null) throw new ApiException(400, "Missing required parameter 'flowAlias' when calling PostFlow");
    
            var path = "/{realm}/authentication/flows/{flowAlias}/executions/flow";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "realm" + "}", ApiClient.ParameterToString(realm));
path = path.Replace("{" + "flowAlias" + "}", ApiClient.ParameterToString(flowAlias));
    
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
                                    postBody = ApiClient.Serialize(body); // http body (model) parameter

            // authentication setting, if any
            String[] authSettings = new String[] { "access_token" };
    
            // make the HTTP request
            RestResponseBase response = (RestResponseBase) ApiClient.CallApi(path, Method.Post, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling PostFlow: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling PostFlow: " + response.ErrorMessage, response.ErrorMessage);
    
            return;
        }
    
        /// <summary>
        ///  Create a new authentication flow
        /// </summary>
        /// <param name="realm">realm name (not id!)</param>
        /// <param name="body">AuthenticationFlowRepresentation</param>
        /// <returns></returns>
        public void PostFlows (string realm, AuthenticationFlowRepresentation body)
        {
            // verify the required parameter 'realm' is set
            if (realm == null) throw new ApiException(400, "Missing required parameter 'realm' when calling PostFlows");
    
            var path = "/{realm}/authentication/flows";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "realm" + "}", ApiClient.ParameterToString(realm));
    
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
                                    postBody = ApiClient.Serialize(body); // http body (model) parameter

            // authentication setting, if any
            String[] authSettings = new String[] { "access_token" };
    
            // make the HTTP request
            RestResponseBase response = (RestResponseBase) ApiClient.CallApi(path, Method.Post, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling PostFlows: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling PostFlows: " + response.ErrorMessage, response.ErrorMessage);
    
            return;
        }
    
        /// <summary>
        ///  Register a new required actions
        /// </summary>
        /// <param name="realm">realm name (not id!)</param>
        /// <param name="body">[string]</param>
        /// <returns></returns>
        public void PostRegisterRequiredAction (string realm, string body)
        {
            // verify the required parameter 'realm' is set
            if (realm == null) throw new ApiException(400, "Missing required parameter 'realm' when calling PostRegisterRequiredAction");
    
            var path = "/{realm}/authentication/register-required-action";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "realm" + "}", ApiClient.ParameterToString(realm));
    
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
                                    postBody = ApiClient.Serialize(body); // http body (model) parameter

            // authentication setting, if any
            String[] authSettings = new String[] { "access_token" };
    
            // make the HTTP request
            RestResponseBase response = (RestResponseBase) ApiClient.CallApi(path, Method.Post, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling PostRegisterRequiredAction: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling PostRegisterRequiredAction: " + response.ErrorMessage, response.ErrorMessage);
    
            return;
        }
    
        /// <summary>
        ///  Lower required action’s priority
        /// </summary>
        /// <param name="realm">realm name (not id!)</param>
        /// <param name="alias">Alias of required action</param>
        /// <returns></returns>
        public void PostRequiredActionLowerPriority (string realm, string alias)
        {
            // verify the required parameter 'realm' is set
            if (realm == null) throw new ApiException(400, "Missing required parameter 'realm' when calling PostRequiredActionLowerPriority");
            // verify the required parameter 'alias' is set
            if (alias == null) throw new ApiException(400, "Missing required parameter 'alias' when calling PostRequiredActionLowerPriority");
    
            var path = "/{realm}/authentication/required-actions/{alias}/lower-priority";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "realm" + "}", ApiClient.ParameterToString(realm));
path = path.Replace("{" + "alias" + "}", ApiClient.ParameterToString(alias));
    
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
                                    
            // authentication setting, if any
            String[] authSettings = new String[] { "access_token" };
    
            // make the HTTP request
            RestResponseBase response = (RestResponseBase) ApiClient.CallApi(path, Method.Post, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling PostRequiredActionLowerPriority: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling PostRequiredActionLowerPriority: " + response.ErrorMessage, response.ErrorMessage);
    
            return;
        }
    
        /// <summary>
        ///  Raise required action’s priority
        /// </summary>
        /// <param name="realm">realm name (not id!)</param>
        /// <param name="alias">Alias of required action</param>
        /// <returns></returns>
        public void PostRequiredActionRaisePriority (string realm, string alias)
        {
            // verify the required parameter 'realm' is set
            if (realm == null) throw new ApiException(400, "Missing required parameter 'realm' when calling PostRequiredActionRaisePriority");
            // verify the required parameter 'alias' is set
            if (alias == null) throw new ApiException(400, "Missing required parameter 'alias' when calling PostRequiredActionRaisePriority");
    
            var path = "/{realm}/authentication/required-actions/{alias}/raise-priority";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "realm" + "}", ApiClient.ParameterToString(realm));
path = path.Replace("{" + "alias" + "}", ApiClient.ParameterToString(alias));
    
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
                                    
            // authentication setting, if any
            String[] authSettings = new String[] { "access_token" };
    
            // make the HTTP request
            RestResponseBase response = (RestResponseBase) ApiClient.CallApi(path, Method.Post, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling PostRequiredActionRaisePriority: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling PostRequiredActionRaisePriority: " + response.ErrorMessage, response.ErrorMessage);
    
            return;
        }
    
        /// <summary>
        ///  Update authenticator configuration
        /// </summary>
        /// <param name="realm">realm name (not id!)</param>
        /// <param name="id">Configuration id</param>
        /// <param name="body">AuthenticatorConfigRepresentation</param>
        /// <returns></returns>
        public void PutAuthenticationConfig (string realm, string id, AuthenticatorConfigRepresentation body)
        {
            // verify the required parameter 'realm' is set
            if (realm == null) throw new ApiException(400, "Missing required parameter 'realm' when calling PutAuthenticationConfig");
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling PutAuthenticationConfig");
    
            var path = "/{realm}/authentication/config/{id}";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "realm" + "}", ApiClient.ParameterToString(realm));
path = path.Replace("{" + "id" + "}", ApiClient.ParameterToString(id));
    
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
                                    postBody = ApiClient.Serialize(body); // http body (model) parameter

            // authentication setting, if any
            String[] authSettings = new String[] { "access_token" };
    
            // make the HTTP request
            RestResponseBase response = (RestResponseBase) ApiClient.CallApi(path, Method.Put, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling PutAuthenticationConfig: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling PutAuthenticationConfig: " + response.ErrorMessage, response.ErrorMessage);
    
            return;
        }
    
        /// <summary>
        ///  Update authentication executions of a Flow
        /// </summary>
        /// <param name="realm">realm name (not id!)</param>
        /// <param name="flowAlias">Flow alias</param>
        /// <param name="body">AuthenticationExecutionInfoRepresentation</param>
        /// <returns></returns>
        public void PutExecutions (string realm, string flowAlias, AuthenticationExecutionInfoRepresentation body)
        {
            // verify the required parameter 'realm' is set
            if (realm == null) throw new ApiException(400, "Missing required parameter 'realm' when calling PutExecutions");
            // verify the required parameter 'flowAlias' is set
            if (flowAlias == null) throw new ApiException(400, "Missing required parameter 'flowAlias' when calling PutExecutions");
    
            var path = "/{realm}/authentication/flows/{flowAlias}/executions";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "realm" + "}", ApiClient.ParameterToString(realm));
path = path.Replace("{" + "flowAlias" + "}", ApiClient.ParameterToString(flowAlias));
    
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
                                    postBody = ApiClient.Serialize(body); // http body (model) parameter

            // authentication setting, if any
            String[] authSettings = new String[] { "access_token" };
    
            // make the HTTP request
            RestResponseBase response = (RestResponseBase) ApiClient.CallApi(path, Method.Put, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling PutExecutions: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling PutExecutions: " + response.ErrorMessage, response.ErrorMessage);
    
            return;
        }
    
        /// <summary>
        ///  Update an authentication flow
        /// </summary>
        /// <param name="realm">realm name (not id!)</param>
        /// <param name="id"></param>
        /// <param name="body">AuthenticationFlowRepresentation</param>
        /// <returns></returns>
        public void PutFlow (string realm, string id, AuthenticationFlowRepresentation body)
        {
            // verify the required parameter 'realm' is set
            if (realm == null) throw new ApiException(400, "Missing required parameter 'realm' when calling PutFlow");
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling PutFlow");
    
            var path = "/{realm}/authentication/flows/{id}";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "realm" + "}", ApiClient.ParameterToString(realm));
path = path.Replace("{" + "id" + "}", ApiClient.ParameterToString(id));
    
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
                                    postBody = ApiClient.Serialize(body); // http body (model) parameter

            // authentication setting, if any
            String[] authSettings = new String[] { "access_token" };
    
            // make the HTTP request
            RestResponseBase response = (RestResponseBase) ApiClient.CallApi(path, Method.Put, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling PutFlow: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling PutFlow: " + response.ErrorMessage, response.ErrorMessage);
    
            return;
        }
    
        /// <summary>
        ///  Update required action
        /// </summary>
        /// <param name="realm">realm name (not id!)</param>
        /// <param name="alias">Alias of required action</param>
        /// <param name="body">RequiredActionProviderRepresentation</param>
        /// <returns></returns>
        public void PutRequiredAction (string realm, string alias, RequiredActionProviderRepresentation body)
        {
            // verify the required parameter 'realm' is set
            if (realm == null) throw new ApiException(400, "Missing required parameter 'realm' when calling PutRequiredAction");
            // verify the required parameter 'alias' is set
            if (alias == null) throw new ApiException(400, "Missing required parameter 'alias' when calling PutRequiredAction");
    
            var path = "/{realm}/authentication/required-actions/{alias}";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "realm" + "}", ApiClient.ParameterToString(realm));
path = path.Replace("{" + "alias" + "}", ApiClient.ParameterToString(alias));
    
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
                                    postBody = ApiClient.Serialize(body); // http body (model) parameter

            // authentication setting, if any
            String[] authSettings = new String[] { "access_token" };
    
            // make the HTTP request
            RestResponseBase response = (RestResponseBase) ApiClient.CallApi(path, Method.Put, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling PutRequiredAction: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling PutRequiredAction: " + response.ErrorMessage, response.ErrorMessage);
    
            return;
        }
    
    }
}
