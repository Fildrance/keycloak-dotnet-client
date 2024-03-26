using System;
using System.Collections.Generic;
using RestSharp;
using IO.Swagger.Client;

namespace IO.Swagger.Api
{
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface IAttackDetectionApi
    {
        /// <summary>
        ///  Clear any user login failures for the user This can release temporary disabled user
        /// </summary>
        /// <param name="realm">realm name (not id!)</param>
        /// <param name="userId"></param>
        /// <returns></returns>
        void DeleteBruteForceUser (string realm, string userId);
        /// <summary>
        ///  Clear any user login failures for all users This can release temporary disabled users
        /// </summary>
        /// <param name="realm">realm name (not id!)</param>
        /// <returns></returns>
        void DeleteUsers (string realm);
        /// <summary>
        ///  Get status of a username in brute force detection
        /// </summary>
        /// <param name="realm">realm name (not id!)</param>
        /// <param name="userId"></param>
        /// <returns>Dictionary&lt;string, Object&gt;</returns>
        Dictionary<string, Object> GetBruteForceUser (string realm, string userId);
    }
  
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public class AttackDetectionApi : IAttackDetectionApi
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AttackDetectionApi"/> class.
        /// </summary>
        /// <param name="apiClient"> an instance of ApiClient (optional)</param>
        /// <returns></returns>
        public AttackDetectionApi(ApiClient apiClient = null)
        {
            if (apiClient == null) // use the default one in Configuration
                this.ApiClient = Configuration.DefaultApiClient; 
            else
                this.ApiClient = apiClient;
        }
    
        /// <summary>
        /// Initializes a new instance of the <see cref="AttackDetectionApi"/> class.
        /// </summary>
        /// <returns></returns>
        public AttackDetectionApi(String basePath)
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
        ///  Clear any user login failures for the user This can release temporary disabled user
        /// </summary>
        /// <param name="realm">realm name (not id!)</param>
        /// <param name="userId"></param>
        /// <returns></returns>
        public void DeleteBruteForceUser (string realm, string userId)
        {
            // verify the required parameter 'realm' is set
            if (realm == null) throw new ApiException(400, "Missing required parameter 'realm' when calling DeleteBruteForceUser");
            // verify the required parameter 'userId' is set
            if (userId == null) throw new ApiException(400, "Missing required parameter 'userId' when calling DeleteBruteForceUser");
    
            var path = "/{realm}/attack-detection/brute-force/users/{userId}";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "realm" + "}", ApiClient.ParameterToString(realm));
path = path.Replace("{" + "userId" + "}", ApiClient.ParameterToString(userId));
    
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
                throw new ApiException ((int)response.StatusCode, "Error calling DeleteBruteForceUser: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling DeleteBruteForceUser: " + response.ErrorMessage, response.ErrorMessage);
    
            return;
        }
    
        /// <summary>
        ///  Clear any user login failures for all users This can release temporary disabled users
        /// </summary>
        /// <param name="realm">realm name (not id!)</param>
        /// <returns></returns>
        public void DeleteUsers (string realm)
        {
            // verify the required parameter 'realm' is set
            if (realm == null) throw new ApiException(400, "Missing required parameter 'realm' when calling DeleteUsers");
    
            var path = "/{realm}/attack-detection/brute-force/users";
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
            RestResponseBase response = (RestResponseBase) ApiClient.CallApi(path, Method.Delete, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling DeleteUsers: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling DeleteUsers: " + response.ErrorMessage, response.ErrorMessage);
    
            return;
        }
    
        /// <summary>
        ///  Get status of a username in brute force detection
        /// </summary>
        /// <param name="realm">realm name (not id!)</param>
        /// <param name="userId"></param>
        /// <returns>Dictionary&lt;string, Object&gt;</returns>
        public Dictionary<string, Object> GetBruteForceUser (string realm, string userId)
        {
            // verify the required parameter 'realm' is set
            if (realm == null) throw new ApiException(400, "Missing required parameter 'realm' when calling GetBruteForceUser");
            // verify the required parameter 'userId' is set
            if (userId == null) throw new ApiException(400, "Missing required parameter 'userId' when calling GetBruteForceUser");
    
            var path = "/{realm}/attack-detection/brute-force/users/{userId}";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "realm" + "}", ApiClient.ParameterToString(realm));
path = path.Replace("{" + "userId" + "}", ApiClient.ParameterToString(userId));
    
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
                throw new ApiException ((int)response.StatusCode, "Error calling GetBruteForceUser: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling GetBruteForceUser: " + response.ErrorMessage, response.ErrorMessage);
    
            return (Dictionary<string, Object>) ApiClient.Deserialize(response.Content, typeof(Dictionary<string, Object>), response.Headers);
        }
    
    }
}
