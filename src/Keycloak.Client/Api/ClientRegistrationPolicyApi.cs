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
    public interface IClientRegistrationPolicyApi
    {
        /// <summary>
        ///  Base path for retrieve providers with the configProperties properly filled
        /// </summary>
        /// <param name="realm">realm name (not id!)</param>
        /// <returns>List&lt;ComponentTypeRepresentation&gt;</returns>
        List<ComponentTypeRepresentation> GetProviders (string realm);
    }
  
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public class ClientRegistrationPolicyApi : IClientRegistrationPolicyApi
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ClientRegistrationPolicyApi"/> class.
        /// </summary>
        /// <param name="apiClient"> an instance of ApiClient (optional)</param>
        /// <returns></returns>
        public ClientRegistrationPolicyApi(ApiClient apiClient = null)
        {
            if (apiClient == null) // use the default one in Configuration
                this.ApiClient = Configuration.DefaultApiClient; 
            else
                this.ApiClient = apiClient;
        }
    
        /// <summary>
        /// Initializes a new instance of the <see cref="ClientRegistrationPolicyApi"/> class.
        /// </summary>
        /// <returns></returns>
        public ClientRegistrationPolicyApi(String basePath)
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
        ///  Base path for retrieve providers with the configProperties properly filled
        /// </summary>
        /// <param name="realm">realm name (not id!)</param>
        /// <returns>List&lt;ComponentTypeRepresentation&gt;</returns>
        public List<ComponentTypeRepresentation> GetProviders (string realm)
        {
            // verify the required parameter 'realm' is set
            if (realm == null) throw new ApiException(400, "Missing required parameter 'realm' when calling GetProviders");
    
            var path = "/{realm}/client-registration-policy/providers";
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
                throw new ApiException ((int)response.StatusCode, "Error calling GetProviders: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling GetProviders: " + response.ErrorMessage, response.ErrorMessage);
    
            return (List<ComponentTypeRepresentation>) ApiClient.Deserialize(response.Content, typeof(List<ComponentTypeRepresentation>), response.Headers);
        }
    
    }
}
