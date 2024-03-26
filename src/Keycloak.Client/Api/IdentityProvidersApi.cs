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
    public interface IIdentityProvidersApi
    {
        /// <summary>
        ///  Delete the identity provider
        /// </summary>
        /// <param name="realm">realm name (not id!)</param>
        /// <param name="alias"></param>
        /// <returns></returns>
        void DeleteInstance (string realm, string alias);
        /// <summary>
        ///  Delete a mapper for the identity provider
        /// </summary>
        /// <param name="realm">realm name (not id!)</param>
        /// <param name="alias"></param>
        /// <param name="id">Mapper id</param>
        /// <returns></returns>
        void DeleteMapper (string realm, string alias, string id);
        /// <summary>
        ///  Export public broker configuration for identity provider
        /// </summary>
        /// <param name="realm">realm name (not id!)</param>
        /// <param name="alias"></param>
        /// <param name="format">Format to use</param>
        /// <returns></returns>
        void GetExport (string realm, string alias, string format);
        /// <summary>
        ///  Get the identity provider factory for that provider id
        /// </summary>
        /// <param name="realm">realm name (not id!)</param>
        /// <param name="providerId">The provider id to get the factory</param>
        /// <returns>Object</returns>
        Object GetIdentityProviderProvider (string realm, string providerId);
        /// <summary>
        ///  Get the identity provider
        /// </summary>
        /// <param name="realm">realm name (not id!)</param>
        /// <param name="alias"></param>
        /// <returns>IdentityProviderRepresentation</returns>
        IdentityProviderRepresentation GetInstance (string realm, string alias);
        /// <summary>
        ///  Return object stating whether client Authorization permissions have been initialized or not and a reference
        /// </summary>
        /// <param name="realm">realm name (not id!)</param>
        /// <param name="alias"></param>
        /// <returns>ManagementPermissionReference</returns>
        ManagementPermissionReference GetInstanceManagementPermissions (string realm, string alias);
        /// <summary>
        ///  List identity providers
        /// </summary>
        /// <param name="realm">realm name (not id!)</param>
        /// <param name="briefRepresentation">Boolean which defines whether brief representations are returned (default: false)</param>
        /// <param name="first">Pagination offset</param>
        /// <param name="max">Maximum results size (defaults to 100)</param>
        /// <param name="search">Filter specific providers by name. Search can be prefix (name*), contains (name) or exact (&amp;quot;name&amp;quot;). Default prefixed.</param>
        /// <returns>List&lt;IdentityProviderRepresentation&gt;</returns>
        List<IdentityProviderRepresentation> GetInstances (string realm, string briefRepresentation, string first, string max, string search);
        /// <summary>
        ///  Get mapper by id for the identity provider
        /// </summary>
        /// <param name="realm">realm name (not id!)</param>
        /// <param name="alias"></param>
        /// <param name="id">Mapper id</param>
        /// <returns>IdentityProviderMapperRepresentation</returns>
        IdentityProviderMapperRepresentation GetMapper (string realm, string alias, string id);
        /// <summary>
        ///  Get mapper types for identity provider
        /// </summary>
        /// <param name="realm">realm name (not id!)</param>
        /// <param name="alias"></param>
        /// <returns>Dictionary&lt;string, IdentityProviderMapperTypeRepresentation&gt;</returns>
        Dictionary<string, IdentityProviderMapperTypeRepresentation> GetMapperTypes (string realm, string alias);
        /// <summary>
        ///  Get mappers for identity provider
        /// </summary>
        /// <param name="realm">realm name (not id!)</param>
        /// <param name="alias"></param>
        /// <returns>List&lt;IdentityProviderMapperRepresentation&gt;</returns>
        List<IdentityProviderMapperRepresentation> GetMappers (string realm, string alias);
        /// <summary>
        ///  Import identity provider from JSON body
        /// </summary>
        /// <param name="realm">realm name (not id!)</param>
        /// <param name="body">[AnyType]</param>
        /// <returns>Dictionary&lt;string, string&gt;</returns>
        Dictionary<string, string> PostImportConfig (string realm, Object body);
        /// <summary>
        ///  Create a new identity provider
        /// </summary>
        /// <param name="realm">realm name (not id!)</param>
        /// <param name="body">IdentityProviderRepresentation</param>
        /// <returns></returns>
        void PostInstances (string realm, IdentityProviderRepresentation body);
        /// <summary>
        ///  Add a mapper to identity provider
        /// </summary>
        /// <param name="realm">realm name (not id!)</param>
        /// <param name="alias"></param>
        /// <param name="body">IdentityProviderMapperRepresentation</param>
        /// <returns></returns>
        void PostMappers (string realm, string alias, IdentityProviderMapperRepresentation body);
        /// <summary>
        ///  Update the identity provider
        /// </summary>
        /// <param name="realm">realm name (not id!)</param>
        /// <param name="alias"></param>
        /// <param name="body">IdentityProviderRepresentation</param>
        /// <returns></returns>
        void PutInstance (string realm, string alias, IdentityProviderRepresentation body);
        /// <summary>
        ///  Return object stating whether client Authorization permissions have been initialized or not and a reference
        /// </summary>
        /// <param name="realm">realm name (not id!)</param>
        /// <param name="alias"></param>
        /// <param name="body">ManagementPermissionReference</param>
        /// <returns>ManagementPermissionReference</returns>
        ManagementPermissionReference PutInstanceManagementPermissions (string realm, string alias, ManagementPermissionReference body);
        /// <summary>
        ///  Update a mapper for the identity provider
        /// </summary>
        /// <param name="realm">realm name (not id!)</param>
        /// <param name="alias"></param>
        /// <param name="id">Mapper id</param>
        /// <param name="body">IdentityProviderMapperRepresentation</param>
        /// <returns></returns>
        void PutMapper (string realm, string alias, string id, IdentityProviderMapperRepresentation body);
    }
  
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public class IdentityProvidersApi : IIdentityProvidersApi
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="IdentityProvidersApi"/> class.
        /// </summary>
        /// <param name="apiClient"> an instance of ApiClient (optional)</param>
        /// <returns></returns>
        public IdentityProvidersApi(ApiClient apiClient = null)
        {
            if (apiClient == null) // use the default one in Configuration
                this.ApiClient = Configuration.DefaultApiClient; 
            else
                this.ApiClient = apiClient;
        }
    
        /// <summary>
        /// Initializes a new instance of the <see cref="IdentityProvidersApi"/> class.
        /// </summary>
        /// <returns></returns>
        public IdentityProvidersApi(String basePath)
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
        ///  Delete the identity provider
        /// </summary>
        /// <param name="realm">realm name (not id!)</param>
        /// <param name="alias"></param>
        /// <returns></returns>
        public void DeleteInstance (string realm, string alias)
        {
            // verify the required parameter 'realm' is set
            if (realm == null) throw new ApiException(400, "Missing required parameter 'realm' when calling DeleteInstance");
            // verify the required parameter 'alias' is set
            if (alias == null) throw new ApiException(400, "Missing required parameter 'alias' when calling DeleteInstance");
    
            var path = "/{realm}/identity-provider/instances/{alias}";
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
                throw new ApiException ((int)response.StatusCode, "Error calling DeleteInstance: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling DeleteInstance: " + response.ErrorMessage, response.ErrorMessage);
    
            return;
        }
    
        /// <summary>
        ///  Delete a mapper for the identity provider
        /// </summary>
        /// <param name="realm">realm name (not id!)</param>
        /// <param name="alias"></param>
        /// <param name="id">Mapper id</param>
        /// <returns></returns>
        public void DeleteMapper (string realm, string alias, string id)
        {
            // verify the required parameter 'realm' is set
            if (realm == null) throw new ApiException(400, "Missing required parameter 'realm' when calling DeleteMapper");
            // verify the required parameter 'alias' is set
            if (alias == null) throw new ApiException(400, "Missing required parameter 'alias' when calling DeleteMapper");
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling DeleteMapper");
    
            var path = "/{realm}/identity-provider/instances/{alias}/mappers/{id}";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "realm" + "}", ApiClient.ParameterToString(realm));
path = path.Replace("{" + "alias" + "}", ApiClient.ParameterToString(alias));
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
                throw new ApiException ((int)response.StatusCode, "Error calling DeleteMapper: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling DeleteMapper: " + response.ErrorMessage, response.ErrorMessage);
    
            return;
        }
    
        /// <summary>
        ///  Export public broker configuration for identity provider
        /// </summary>
        /// <param name="realm">realm name (not id!)</param>
        /// <param name="alias"></param>
        /// <param name="format">Format to use</param>
        /// <returns></returns>
        public void GetExport (string realm, string alias, string format)
        {
            // verify the required parameter 'realm' is set
            if (realm == null) throw new ApiException(400, "Missing required parameter 'realm' when calling GetExport");
            // verify the required parameter 'alias' is set
            if (alias == null) throw new ApiException(400, "Missing required parameter 'alias' when calling GetExport");
    
            var path = "/{realm}/identity-provider/instances/{alias}/export";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "realm" + "}", ApiClient.ParameterToString(realm));
path = path.Replace("{" + "alias" + "}", ApiClient.ParameterToString(alias));
    
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
             if (format != null) queryParams.Add("format", ApiClient.ParameterToString(format)); // query parameter
                        
            // authentication setting, if any
            String[] authSettings = new String[] { "access_token" };
    
            // make the HTTP request
            RestResponseBase response = (RestResponseBase) ApiClient.CallApi(path, Method.Get, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling GetExport: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling GetExport: " + response.ErrorMessage, response.ErrorMessage);
    
            return;
        }
    
        /// <summary>
        ///  Get the identity provider factory for that provider id
        /// </summary>
        /// <param name="realm">realm name (not id!)</param>
        /// <param name="providerId">The provider id to get the factory</param>
        /// <returns>Object</returns>
        public Object GetIdentityProviderProvider (string realm, string providerId)
        {
            // verify the required parameter 'realm' is set
            if (realm == null) throw new ApiException(400, "Missing required parameter 'realm' when calling GetIdentityProviderProvider");
            // verify the required parameter 'providerId' is set
            if (providerId == null) throw new ApiException(400, "Missing required parameter 'providerId' when calling GetIdentityProviderProvider");
    
            var path = "/{realm}/identity-provider/providers/{provider_id}";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "realm" + "}", ApiClient.ParameterToString(realm));
path = path.Replace("{" + "provider_id" + "}", ApiClient.ParameterToString(providerId));
    
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
                throw new ApiException ((int)response.StatusCode, "Error calling GetIdentityProviderProvider: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling GetIdentityProviderProvider: " + response.ErrorMessage, response.ErrorMessage);
    
            return (Object) ApiClient.Deserialize(response.Content, typeof(Object), response.Headers);
        }
    
        /// <summary>
        ///  Get the identity provider
        /// </summary>
        /// <param name="realm">realm name (not id!)</param>
        /// <param name="alias"></param>
        /// <returns>IdentityProviderRepresentation</returns>
        public IdentityProviderRepresentation GetInstance (string realm, string alias)
        {
            // verify the required parameter 'realm' is set
            if (realm == null) throw new ApiException(400, "Missing required parameter 'realm' when calling GetInstance");
            // verify the required parameter 'alias' is set
            if (alias == null) throw new ApiException(400, "Missing required parameter 'alias' when calling GetInstance");
    
            var path = "/{realm}/identity-provider/instances/{alias}";
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
                throw new ApiException ((int)response.StatusCode, "Error calling GetInstance: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling GetInstance: " + response.ErrorMessage, response.ErrorMessage);
    
            return (IdentityProviderRepresentation) ApiClient.Deserialize(response.Content, typeof(IdentityProviderRepresentation), response.Headers);
        }
    
        /// <summary>
        ///  Return object stating whether client Authorization permissions have been initialized or not and a reference
        /// </summary>
        /// <param name="realm">realm name (not id!)</param>
        /// <param name="alias"></param>
        /// <returns>ManagementPermissionReference</returns>
        public ManagementPermissionReference GetInstanceManagementPermissions (string realm, string alias)
        {
            // verify the required parameter 'realm' is set
            if (realm == null) throw new ApiException(400, "Missing required parameter 'realm' when calling GetInstanceManagementPermissions");
            // verify the required parameter 'alias' is set
            if (alias == null) throw new ApiException(400, "Missing required parameter 'alias' when calling GetInstanceManagementPermissions");
    
            var path = "/{realm}/identity-provider/instances/{alias}/management/permissions";
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
                throw new ApiException ((int)response.StatusCode, "Error calling GetInstanceManagementPermissions: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling GetInstanceManagementPermissions: " + response.ErrorMessage, response.ErrorMessage);
    
            return (ManagementPermissionReference) ApiClient.Deserialize(response.Content, typeof(ManagementPermissionReference), response.Headers);
        }
    
        /// <summary>
        ///  List identity providers
        /// </summary>
        /// <param name="realm">realm name (not id!)</param>
        /// <param name="briefRepresentation">Boolean which defines whether brief representations are returned (default: false)</param>
        /// <param name="first">Pagination offset</param>
        /// <param name="max">Maximum results size (defaults to 100)</param>
        /// <param name="search">Filter specific providers by name. Search can be prefix (name*), contains (name) or exact (&amp;quot;name&amp;quot;). Default prefixed.</param>
        /// <returns>List&lt;IdentityProviderRepresentation&gt;</returns>
        public List<IdentityProviderRepresentation> GetInstances (string realm, string briefRepresentation, string first, string max, string search)
        {
            // verify the required parameter 'realm' is set
            if (realm == null) throw new ApiException(400, "Missing required parameter 'realm' when calling GetInstances");
    
            var path = "/{realm}/identity-provider/instances";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "realm" + "}", ApiClient.ParameterToString(realm));
    
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
             if (briefRepresentation != null) queryParams.Add("briefRepresentation", ApiClient.ParameterToString(briefRepresentation)); // query parameter
 if (first != null) queryParams.Add("first", ApiClient.ParameterToString(first)); // query parameter
 if (max != null) queryParams.Add("max", ApiClient.ParameterToString(max)); // query parameter
 if (search != null) queryParams.Add("search", ApiClient.ParameterToString(search)); // query parameter
                        
            // authentication setting, if any
            String[] authSettings = new String[] { "access_token" };
    
            // make the HTTP request
            RestResponseBase response = (RestResponseBase) ApiClient.CallApi(path, Method.Get, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling GetInstances: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling GetInstances: " + response.ErrorMessage, response.ErrorMessage);
    
            return (List<IdentityProviderRepresentation>) ApiClient.Deserialize(response.Content, typeof(List<IdentityProviderRepresentation>), response.Headers);
        }
    
        /// <summary>
        ///  Get mapper by id for the identity provider
        /// </summary>
        /// <param name="realm">realm name (not id!)</param>
        /// <param name="alias"></param>
        /// <param name="id">Mapper id</param>
        /// <returns>IdentityProviderMapperRepresentation</returns>
        public IdentityProviderMapperRepresentation GetMapper (string realm, string alias, string id)
        {
            // verify the required parameter 'realm' is set
            if (realm == null) throw new ApiException(400, "Missing required parameter 'realm' when calling GetMapper");
            // verify the required parameter 'alias' is set
            if (alias == null) throw new ApiException(400, "Missing required parameter 'alias' when calling GetMapper");
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling GetMapper");
    
            var path = "/{realm}/identity-provider/instances/{alias}/mappers/{id}";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "realm" + "}", ApiClient.ParameterToString(realm));
path = path.Replace("{" + "alias" + "}", ApiClient.ParameterToString(alias));
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
                throw new ApiException ((int)response.StatusCode, "Error calling GetMapper: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling GetMapper: " + response.ErrorMessage, response.ErrorMessage);
    
            return (IdentityProviderMapperRepresentation) ApiClient.Deserialize(response.Content, typeof(IdentityProviderMapperRepresentation), response.Headers);
        }
    
        /// <summary>
        ///  Get mapper types for identity provider
        /// </summary>
        /// <param name="realm">realm name (not id!)</param>
        /// <param name="alias"></param>
        /// <returns>Dictionary&lt;string, IdentityProviderMapperTypeRepresentation&gt;</returns>
        public Dictionary<string, IdentityProviderMapperTypeRepresentation> GetMapperTypes (string realm, string alias)
        {
            // verify the required parameter 'realm' is set
            if (realm == null) throw new ApiException(400, "Missing required parameter 'realm' when calling GetMapperTypes");
            // verify the required parameter 'alias' is set
            if (alias == null) throw new ApiException(400, "Missing required parameter 'alias' when calling GetMapperTypes");
    
            var path = "/{realm}/identity-provider/instances/{alias}/mapper-types";
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
                throw new ApiException ((int)response.StatusCode, "Error calling GetMapperTypes: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling GetMapperTypes: " + response.ErrorMessage, response.ErrorMessage);
    
            return (Dictionary<string, IdentityProviderMapperTypeRepresentation>) ApiClient.Deserialize(response.Content, typeof(Dictionary<string, IdentityProviderMapperTypeRepresentation>), response.Headers);
        }
    
        /// <summary>
        ///  Get mappers for identity provider
        /// </summary>
        /// <param name="realm">realm name (not id!)</param>
        /// <param name="alias"></param>
        /// <returns>List&lt;IdentityProviderMapperRepresentation&gt;</returns>
        public List<IdentityProviderMapperRepresentation> GetMappers (string realm, string alias)
        {
            // verify the required parameter 'realm' is set
            if (realm == null) throw new ApiException(400, "Missing required parameter 'realm' when calling GetMappers");
            // verify the required parameter 'alias' is set
            if (alias == null) throw new ApiException(400, "Missing required parameter 'alias' when calling GetMappers");
    
            var path = "/{realm}/identity-provider/instances/{alias}/mappers";
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
                throw new ApiException ((int)response.StatusCode, "Error calling GetMappers: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling GetMappers: " + response.ErrorMessage, response.ErrorMessage);
    
            return (List<IdentityProviderMapperRepresentation>) ApiClient.Deserialize(response.Content, typeof(List<IdentityProviderMapperRepresentation>), response.Headers);
        }
    
        /// <summary>
        ///  Import identity provider from JSON body
        /// </summary>
        /// <param name="realm">realm name (not id!)</param>
        /// <param name="body">[AnyType]</param>
        /// <returns>Dictionary&lt;string, string&gt;</returns>
        public Dictionary<string, string> PostImportConfig (string realm, Object body)
        {
            // verify the required parameter 'realm' is set
            if (realm == null) throw new ApiException(400, "Missing required parameter 'realm' when calling PostImportConfig");
    
            var path = "/{realm}/identity-provider/import-config";
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
                throw new ApiException ((int)response.StatusCode, "Error calling PostImportConfig: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling PostImportConfig: " + response.ErrorMessage, response.ErrorMessage);
    
            return (Dictionary<string, string>) ApiClient.Deserialize(response.Content, typeof(Dictionary<string, string>), response.Headers);
        }
    
        /// <summary>
        ///  Create a new identity provider
        /// </summary>
        /// <param name="realm">realm name (not id!)</param>
        /// <param name="body">IdentityProviderRepresentation</param>
        /// <returns></returns>
        public void PostInstances (string realm, IdentityProviderRepresentation body)
        {
            // verify the required parameter 'realm' is set
            if (realm == null) throw new ApiException(400, "Missing required parameter 'realm' when calling PostInstances");
    
            var path = "/{realm}/identity-provider/instances";
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
                throw new ApiException ((int)response.StatusCode, "Error calling PostInstances: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling PostInstances: " + response.ErrorMessage, response.ErrorMessage);
    
            return;
        }
    
        /// <summary>
        ///  Add a mapper to identity provider
        /// </summary>
        /// <param name="realm">realm name (not id!)</param>
        /// <param name="alias"></param>
        /// <param name="body">IdentityProviderMapperRepresentation</param>
        /// <returns></returns>
        public void PostMappers (string realm, string alias, IdentityProviderMapperRepresentation body)
        {
            // verify the required parameter 'realm' is set
            if (realm == null) throw new ApiException(400, "Missing required parameter 'realm' when calling PostMappers");
            // verify the required parameter 'alias' is set
            if (alias == null) throw new ApiException(400, "Missing required parameter 'alias' when calling PostMappers");
    
            var path = "/{realm}/identity-provider/instances/{alias}/mappers";
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
            RestResponseBase response = (RestResponseBase) ApiClient.CallApi(path, Method.Post, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling PostMappers: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling PostMappers: " + response.ErrorMessage, response.ErrorMessage);
    
            return;
        }
    
        /// <summary>
        ///  Update the identity provider
        /// </summary>
        /// <param name="realm">realm name (not id!)</param>
        /// <param name="alias"></param>
        /// <param name="body">IdentityProviderRepresentation</param>
        /// <returns></returns>
        public void PutInstance (string realm, string alias, IdentityProviderRepresentation body)
        {
            // verify the required parameter 'realm' is set
            if (realm == null) throw new ApiException(400, "Missing required parameter 'realm' when calling PutInstance");
            // verify the required parameter 'alias' is set
            if (alias == null) throw new ApiException(400, "Missing required parameter 'alias' when calling PutInstance");
    
            var path = "/{realm}/identity-provider/instances/{alias}";
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
                throw new ApiException ((int)response.StatusCode, "Error calling PutInstance: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling PutInstance: " + response.ErrorMessage, response.ErrorMessage);
    
            return;
        }
    
        /// <summary>
        ///  Return object stating whether client Authorization permissions have been initialized or not and a reference
        /// </summary>
        /// <param name="realm">realm name (not id!)</param>
        /// <param name="alias"></param>
        /// <param name="body">ManagementPermissionReference</param>
        /// <returns>ManagementPermissionReference</returns>
        public ManagementPermissionReference PutInstanceManagementPermissions (string realm, string alias, ManagementPermissionReference body)
        {
            // verify the required parameter 'realm' is set
            if (realm == null) throw new ApiException(400, "Missing required parameter 'realm' when calling PutInstanceManagementPermissions");
            // verify the required parameter 'alias' is set
            if (alias == null) throw new ApiException(400, "Missing required parameter 'alias' when calling PutInstanceManagementPermissions");
    
            var path = "/{realm}/identity-provider/instances/{alias}/management/permissions";
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
                throw new ApiException ((int)response.StatusCode, "Error calling PutInstanceManagementPermissions: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling PutInstanceManagementPermissions: " + response.ErrorMessage, response.ErrorMessage);
    
            return (ManagementPermissionReference) ApiClient.Deserialize(response.Content, typeof(ManagementPermissionReference), response.Headers);
        }
    
        /// <summary>
        ///  Update a mapper for the identity provider
        /// </summary>
        /// <param name="realm">realm name (not id!)</param>
        /// <param name="alias"></param>
        /// <param name="id">Mapper id</param>
        /// <param name="body">IdentityProviderMapperRepresentation</param>
        /// <returns></returns>
        public void PutMapper (string realm, string alias, string id, IdentityProviderMapperRepresentation body)
        {
            // verify the required parameter 'realm' is set
            if (realm == null) throw new ApiException(400, "Missing required parameter 'realm' when calling PutMapper");
            // verify the required parameter 'alias' is set
            if (alias == null) throw new ApiException(400, "Missing required parameter 'alias' when calling PutMapper");
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling PutMapper");
    
            var path = "/{realm}/identity-provider/instances/{alias}/mappers/{id}";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "realm" + "}", ApiClient.ParameterToString(realm));
path = path.Replace("{" + "alias" + "}", ApiClient.ParameterToString(alias));
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
                throw new ApiException ((int)response.StatusCode, "Error calling PutMapper: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling PutMapper: " + response.ErrorMessage, response.ErrorMessage);
    
            return;
        }
    
    }
}
