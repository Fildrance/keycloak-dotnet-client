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
    public interface IClientInitialAccessApi
    {
        /// <summary>
        ///  
        /// </summary>
        /// <param name="realm">realm name (not id!)</param>
        /// <param name="id"></param>
        /// <returns></returns>
        void DeleteClientsInitialAcces (string realm, string id);
        /// <summary>
        ///  
        /// </summary>
        /// <param name="realm">realm name (not id!)</param>
        /// <returns>List&lt;ClientInitialAccessPresentation&gt;</returns>
        List<ClientInitialAccessPresentation> GetClientsInitialAccess (string realm);
        /// <summary>
        ///  Create a new initial access token.
        /// </summary>
        /// <param name="realm">realm name (not id!)</param>
        /// <param name="body">ClientInitialAccessCreatePresentation</param>
        /// <returns>ClientInitialAccessPresentation</returns>
        ClientInitialAccessPresentation PostClientsInitialAccess (string realm, ClientInitialAccessCreatePresentation body);
    }
  
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public class ClientInitialAccessApi : IClientInitialAccessApi
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ClientInitialAccessApi"/> class.
        /// </summary>
        /// <param name="apiClient"> an instance of ApiClient (optional)</param>
        /// <returns></returns>
        public ClientInitialAccessApi(ApiClient apiClient = null)
        {
            if (apiClient == null) // use the default one in Configuration
                this.ApiClient = Configuration.DefaultApiClient; 
            else
                this.ApiClient = apiClient;
        }
    
        /// <summary>
        /// Initializes a new instance of the <see cref="ClientInitialAccessApi"/> class.
        /// </summary>
        /// <returns></returns>
        public ClientInitialAccessApi(String basePath)
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
        ///  
        /// </summary>
        /// <param name="realm">realm name (not id!)</param>
        /// <param name="id"></param>
        /// <returns></returns>
        public void DeleteClientsInitialAcces (string realm, string id)
        {
            // verify the required parameter 'realm' is set
            if (realm == null) throw new ApiException(400, "Missing required parameter 'realm' when calling DeleteClientsInitialAcces");
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling DeleteClientsInitialAcces");
    
            var path = "/{realm}/clients-initial-access/{id}";
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
                throw new ApiException ((int)response.StatusCode, "Error calling DeleteClientsInitialAcces: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling DeleteClientsInitialAcces: " + response.ErrorMessage, response.ErrorMessage);
    
            return;
        }
    
        /// <summary>
        ///  
        /// </summary>
        /// <param name="realm">realm name (not id!)</param>
        /// <returns>List&lt;ClientInitialAccessPresentation&gt;</returns>
        public List<ClientInitialAccessPresentation> GetClientsInitialAccess (string realm)
        {
            // verify the required parameter 'realm' is set
            if (realm == null) throw new ApiException(400, "Missing required parameter 'realm' when calling GetClientsInitialAccess");
    
            var path = "/{realm}/clients-initial-access";
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
                throw new ApiException ((int)response.StatusCode, "Error calling GetClientsInitialAccess: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling GetClientsInitialAccess: " + response.ErrorMessage, response.ErrorMessage);
    
            return (List<ClientInitialAccessPresentation>) ApiClient.Deserialize(response.Content, typeof(List<ClientInitialAccessPresentation>), response.Headers);
        }
    
        /// <summary>
        ///  Create a new initial access token.
        /// </summary>
        /// <param name="realm">realm name (not id!)</param>
        /// <param name="body">ClientInitialAccessCreatePresentation</param>
        /// <returns>ClientInitialAccessPresentation</returns>
        public ClientInitialAccessPresentation PostClientsInitialAccess (string realm, ClientInitialAccessCreatePresentation body)
        {
            // verify the required parameter 'realm' is set
            if (realm == null) throw new ApiException(400, "Missing required parameter 'realm' when calling PostClientsInitialAccess");
    
            var path = "/{realm}/clients-initial-access";
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
                throw new ApiException ((int)response.StatusCode, "Error calling PostClientsInitialAccess: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling PostClientsInitialAccess: " + response.ErrorMessage, response.ErrorMessage);
    
            return (ClientInitialAccessPresentation) ApiClient.Deserialize(response.Content, typeof(ClientInitialAccessPresentation), response.Headers);
        }
    
    }
}
