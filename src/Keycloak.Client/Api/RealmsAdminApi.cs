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
    public interface IRealmsAdminApi
    {
        /// <summary>
        ///  Delete all admin events
        /// </summary>
        /// <param name="realm">realm name (not id!)</param>
        /// <returns></returns>
        void DeleteAdminEvents (string realm);
        /// <summary>
        ///  Delete the realm
        /// </summary>
        /// <param name="realm">realm name (not id!)</param>
        /// <returns></returns>
        void DeleteByRealm (string realm);
        /// <summary>
        ///  
        /// </summary>
        /// <param name="realm">realm name (not id!)</param>
        /// <param name="clientScopeId"></param>
        /// <returns></returns>
        void DeleteDefaultDefaultClientScope (string realm, string clientScopeId);
        /// <summary>
        ///  
        /// </summary>
        /// <param name="realm">realm name (not id!)</param>
        /// <param name="groupId"></param>
        /// <returns></returns>
        void DeleteDefaultGroup (string realm, string groupId);
        /// <summary>
        ///  
        /// </summary>
        /// <param name="realm">realm name (not id!)</param>
        /// <param name="clientScopeId"></param>
        /// <returns></returns>
        void DeleteDefaultOptionalClientScope (string realm, string clientScopeId);
        /// <summary>
        ///  Delete all events
        /// </summary>
        /// <param name="realm">realm name (not id!)</param>
        /// <returns></returns>
        void DeleteEvents (string realm);
        /// <summary>
        ///  
        /// </summary>
        /// <param name="realm">realm name (not id!)</param>
        /// <param name="locale"></param>
        /// <returns></returns>
        void DeleteLocalizationByRealmByLocale (string realm, string locale);
        /// <summary>
        ///  
        /// </summary>
        /// <param name="realm">realm name (not id!)</param>
        /// <param name="locale"></param>
        /// <param name="key"></param>
        /// <returns></returns>
        void DeleteLocalizationByRealmByLocaleByKey (string realm, string locale, string key);
        /// <summary>
        ///  Remove a specific user session.
        /// </summary>
        /// <param name="realm">realm name (not id!)</param>
        /// <param name="session"></param>
        /// <returns></returns>
        void DeleteSession (string realm, string session);
        /// <summary>
        ///  Get accessible realms Returns a list of accessible realms. The list is filtered based on what realms the caller is allowed to view.
        /// </summary>
        /// <param name="briefRepresentation"></param>
        /// <returns>List&lt;RealmRepresentation&gt;</returns>
        List<RealmRepresentation> Get (string briefRepresentation);
        /// <summary>
        ///  Get admin events Returns all admin events, or filters events based on URL query parameters listed here
        /// </summary>
        /// <param name="realm">realm name (not id!)</param>
        /// <param name="authClient"></param>
        /// <param name="authIpAddress"></param>
        /// <param name="authRealm"></param>
        /// <param name="authUser">user id</param>
        /// <param name="dateFrom"></param>
        /// <param name="dateTo"></param>
        /// <param name="first"></param>
        /// <param name="max">Maximum results size (defaults to 100)</param>
        /// <param name="operationTypes">[String]</param>
        /// <param name="resourcePath"></param>
        /// <param name="resourceTypes">[String]</param>
        /// <returns>List&lt;AdminEventRepresentation&gt;</returns>
        List<AdminEventRepresentation> GetAdminEvents (string realm, string authClient, string authIpAddress, string authRealm, string authUser, string dateFrom, string dateTo, string first, string max, string operationTypes, string resourcePath, string resourceTypes);
        /// <summary>
        ///  Get the top-level representation of the realm It will not include nested information like User and Client representations.
        /// </summary>
        /// <param name="realm">realm name (not id!)</param>
        /// <returns>RealmRepresentation</returns>
        RealmRepresentation GetByRealm (string realm);
        /// <summary>
        ///  Get client session stats Returns a JSON map.
        /// </summary>
        /// <param name="realm">realm name (not id!)</param>
        /// <returns>List&lt;string&gt;</returns>
        List<string> GetClientSessionStats (string realm);
        /// <summary>
        ///  
        /// </summary>
        /// <param name="realm">realm name (not id!)</param>
        /// <returns>List&lt;string&gt;</returns>
        List<string> GetCredentialRegistrators (string realm);
        /// <summary>
        ///  Get realm default client scopes.  Only name and ids are returned.
        /// </summary>
        /// <param name="realm">realm name (not id!)</param>
        /// <returns>List&lt;ClientScopeRepresentation&gt;</returns>
        List<ClientScopeRepresentation> GetDefaultDefaultClientScopes (string realm);
        /// <summary>
        ///  Get group hierarchy.  Only name and ids are returned.
        /// </summary>
        /// <param name="realm">realm name (not id!)</param>
        /// <returns>List&lt;GroupRepresentation&gt;</returns>
        List<GroupRepresentation> GetDefaultGroups (string realm);
        /// <summary>
        ///  Get realm optional client scopes.  Only name and ids are returned.
        /// </summary>
        /// <param name="realm">realm name (not id!)</param>
        /// <returns>List&lt;ClientScopeRepresentation&gt;</returns>
        List<ClientScopeRepresentation> GetDefaultOptionalClientScopes (string realm);
        /// <summary>
        ///  Get events Returns all events, or filters them based on URL query parameters listed here
        /// </summary>
        /// <param name="realm">realm name (not id!)</param>
        /// <param name="_client">App or oauth client name</param>
        /// <param name="dateFrom">From date</param>
        /// <param name="dateTo">To date</param>
        /// <param name="first">Paging offset</param>
        /// <param name="ipAddress">IP Address</param>
        /// <param name="max">Maximum results size (defaults to 100)</param>
        /// <param name="type">The types of events to return [String]</param>
        /// <param name="user">User id</param>
        /// <returns>List&lt;EventRepresentation&gt;</returns>
        List<EventRepresentation> GetEvents (string realm, string _client, string dateFrom, string dateTo, string first, string ipAddress, string max, string type, string user);
        /// <summary>
        ///  Get the events provider configuration Returns JSON object with events provider configuration
        /// </summary>
        /// <param name="realm">realm name (not id!)</param>
        /// <returns>RealmEventsConfigRepresentation</returns>
        RealmEventsConfigRepresentation GetEventsConfig (string realm);
        /// <summary>
        ///  
        /// </summary>
        /// <param name="realm">realm name (not id!)</param>
        /// <param name="path">PathSegment</param>
        /// <returns>GroupRepresentation</returns>
        GroupRepresentation GetGroupByPath (string realm, string path);
        /// <summary>
        ///  
        /// </summary>
        /// <param name="realm">realm name (not id!)</param>
        /// <returns>List&lt;string&gt;</returns>
        List<string> GetLocalizationByRealm (string realm);
        /// <summary>
        ///  
        /// </summary>
        /// <param name="realm">realm name (not id!)</param>
        /// <param name="locale"></param>
        /// <param name="useRealmDefaultLocaleFallback"></param>
        /// <returns>Dictionary&lt;string, string&gt;</returns>
        Dictionary<string, string> GetLocalizationByRealmByLocale (string realm, string locale, string useRealmDefaultLocaleFallback);
        /// <summary>
        ///  
        /// </summary>
        /// <param name="realm">realm name (not id!)</param>
        /// <param name="locale"></param>
        /// <param name="key"></param>
        /// <returns>string</returns>
        string GetLocalizationByRealmByLocaleByKey (string realm, string locale, string key);
        /// <summary>
        ///  
        /// </summary>
        /// <param name="realm">realm name (not id!)</param>
        /// <returns>ClientPoliciesRepresentation</returns>
        ClientPoliciesRepresentation GetPolicies (string realm);
        /// <summary>
        ///  
        /// </summary>
        /// <param name="realm">realm name (not id!)</param>
        /// <param name="includeGlobalProfiles"></param>
        /// <returns>ClientProfilesRepresentation</returns>
        ClientProfilesRepresentation GetProfiles (string realm, string includeGlobalProfiles);
        /// <summary>
        ///  
        /// </summary>
        /// <param name="realm">realm name (not id!)</param>
        /// <returns>ManagementPermissionReference</returns>
        ManagementPermissionReference GetUsersManagementPermissions (string realm);
        /// <summary>
        ///  Import a realm. Imports a realm from a full representation of that realm.
        /// </summary>
        /// <param name="body">[file]</param>
        /// <returns></returns>
        void Post (Object body);
        /// <summary>
        ///  Base path for importing clients under this realm.
        /// </summary>
        /// <param name="realm">realm name (not id!)</param>
        /// <param name="body">[string]</param>
        /// <returns>ClientRepresentation</returns>
        ClientRepresentation PostClientDescriptionConverter (string realm, string body);
        /// <summary>
        ///  Import localization from uploaded JSON file
        /// </summary>
        /// <param name="realm">realm name (not id!)</param>
        /// <param name="locale"></param>
        /// <param name="body">[string]</param>
        /// <returns></returns>
        void PostLocalization (string realm, string locale, string body);
        /// <summary>
        ///  Removes all user sessions.
        /// </summary>
        /// <param name="realm">realm name (not id!)</param>
        /// <returns>GlobalRequestResult</returns>
        GlobalRequestResult PostLogoutAll (string realm);
        /// <summary>
        ///  Partial export of existing realm into a JSON file.
        /// </summary>
        /// <param name="realm">realm name (not id!)</param>
        /// <param name="exportClients"></param>
        /// <param name="exportGroupsAndRoles"></param>
        /// <returns></returns>
        void PostPartialExport (string realm, string exportClients, string exportGroupsAndRoles);
        /// <summary>
        ///  Partial import from a JSON file to an existing realm.
        /// </summary>
        /// <param name="realm">realm name (not id!)</param>
        /// <param name="body">[file]</param>
        /// <returns></returns>
        void PostPartialImport (string realm, Object body);
        /// <summary>
        ///  Push the realm’s revocation policy to any client that has an admin url associated with it.
        /// </summary>
        /// <param name="realm">realm name (not id!)</param>
        /// <returns>GlobalRequestResult</returns>
        GlobalRequestResult PostPushRevocationByRealm (string realm);
        /// <summary>
        ///  Test SMTP connection with current logged in user
        /// </summary>
        /// <param name="realm">realm name (not id!)</param>
        /// <param name="body">[string]</param>
        /// <returns></returns>
        void PostTestSmtpConnection (string realm, string body);
        /// <summary>
        ///  Update the top-level information of the realm Any user, roles or client information in the representation will be ignored.
        /// </summary>
        /// <param name="realm">realm name (not id!)</param>
        /// <param name="body">RealmRepresentation</param>
        /// <returns></returns>
        void PutByRealm (string realm, RealmRepresentation body);
        /// <summary>
        ///  
        /// </summary>
        /// <param name="realm">realm name (not id!)</param>
        /// <param name="clientScopeId"></param>
        /// <returns></returns>
        void PutDefaultDefaultClientScope (string realm, string clientScopeId);
        /// <summary>
        ///  
        /// </summary>
        /// <param name="realm">realm name (not id!)</param>
        /// <param name="groupId"></param>
        /// <returns></returns>
        void PutDefaultGroup (string realm, string groupId);
        /// <summary>
        ///  
        /// </summary>
        /// <param name="realm">realm name (not id!)</param>
        /// <param name="clientScopeId"></param>
        /// <returns></returns>
        void PutDefaultOptionalClientScope (string realm, string clientScopeId);
        /// <summary>
        ///  
        /// </summary>
        /// <param name="realm">realm name (not id!)</param>
        /// <param name="body">RealmEventsConfigRepresentation</param>
        /// <returns></returns>
        void PutEventsConfig (string realm, RealmEventsConfigRepresentation body);
        /// <summary>
        ///  
        /// </summary>
        /// <param name="realm">realm name (not id!)</param>
        /// <param name="locale"></param>
        /// <param name="key"></param>
        /// <param name="body">[string]</param>
        /// <returns></returns>
        void PutLocalization (string realm, string locale, string key, string body);
        /// <summary>
        ///  
        /// </summary>
        /// <param name="realm">realm name (not id!)</param>
        /// <param name="body">ClientPoliciesRepresentation</param>
        /// <returns></returns>
        void PutPolicies (string realm, ClientPoliciesRepresentation body);
        /// <summary>
        ///  
        /// </summary>
        /// <param name="realm">realm name (not id!)</param>
        /// <param name="body">ClientProfilesRepresentation</param>
        /// <returns></returns>
        void PutProfiles (string realm, ClientProfilesRepresentation body);
        /// <summary>
        ///  
        /// </summary>
        /// <param name="realm">realm name (not id!)</param>
        /// <param name="body">ManagementPermissionReference</param>
        /// <returns>ManagementPermissionReference</returns>
        ManagementPermissionReference PutUsersManagementPermissions (string realm, ManagementPermissionReference body);
    }
  
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public class RealmsAdminApi : IRealmsAdminApi
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="RealmsAdminApi"/> class.
        /// </summary>
        /// <param name="apiClient"> an instance of ApiClient (optional)</param>
        /// <returns></returns>
        public RealmsAdminApi(ApiClient apiClient = null)
        {
            if (apiClient == null) // use the default one in Configuration
                this.ApiClient = Configuration.DefaultApiClient; 
            else
                this.ApiClient = apiClient;
        }
    
        /// <summary>
        /// Initializes a new instance of the <see cref="RealmsAdminApi"/> class.
        /// </summary>
        /// <returns></returns>
        public RealmsAdminApi(String basePath)
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
        ///  Delete all admin events
        /// </summary>
        /// <param name="realm">realm name (not id!)</param>
        /// <returns></returns>
        public void DeleteAdminEvents (string realm)
        {
            // verify the required parameter 'realm' is set
            if (realm == null) throw new ApiException(400, "Missing required parameter 'realm' when calling DeleteAdminEvents");
    
            var path = "/{realm}/admin-events";
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
                throw new ApiException ((int)response.StatusCode, "Error calling DeleteAdminEvents: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling DeleteAdminEvents: " + response.ErrorMessage, response.ErrorMessage);
    
            return;
        }
    
        /// <summary>
        ///  Delete the realm
        /// </summary>
        /// <param name="realm">realm name (not id!)</param>
        /// <returns></returns>
        public void DeleteByRealm (string realm)
        {
            // verify the required parameter 'realm' is set
            if (realm == null) throw new ApiException(400, "Missing required parameter 'realm' when calling DeleteByRealm");
    
            var path = "/{realm}";
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
                throw new ApiException ((int)response.StatusCode, "Error calling DeleteByRealm: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling DeleteByRealm: " + response.ErrorMessage, response.ErrorMessage);
    
            return;
        }
    
        /// <summary>
        ///  
        /// </summary>
        /// <param name="realm">realm name (not id!)</param>
        /// <param name="clientScopeId"></param>
        /// <returns></returns>
        public void DeleteDefaultDefaultClientScope (string realm, string clientScopeId)
        {
            // verify the required parameter 'realm' is set
            if (realm == null) throw new ApiException(400, "Missing required parameter 'realm' when calling DeleteDefaultDefaultClientScope");
            // verify the required parameter 'clientScopeId' is set
            if (clientScopeId == null) throw new ApiException(400, "Missing required parameter 'clientScopeId' when calling DeleteDefaultDefaultClientScope");
    
            var path = "/{realm}/default-default-client-scopes/{clientScopeId}";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "realm" + "}", ApiClient.ParameterToString(realm));
path = path.Replace("{" + "clientScopeId" + "}", ApiClient.ParameterToString(clientScopeId));
    
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
                throw new ApiException ((int)response.StatusCode, "Error calling DeleteDefaultDefaultClientScope: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling DeleteDefaultDefaultClientScope: " + response.ErrorMessage, response.ErrorMessage);
    
            return;
        }
    
        /// <summary>
        ///  
        /// </summary>
        /// <param name="realm">realm name (not id!)</param>
        /// <param name="groupId"></param>
        /// <returns></returns>
        public void DeleteDefaultGroup (string realm, string groupId)
        {
            // verify the required parameter 'realm' is set
            if (realm == null) throw new ApiException(400, "Missing required parameter 'realm' when calling DeleteDefaultGroup");
            // verify the required parameter 'groupId' is set
            if (groupId == null) throw new ApiException(400, "Missing required parameter 'groupId' when calling DeleteDefaultGroup");
    
            var path = "/{realm}/default-groups/{groupId}";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "realm" + "}", ApiClient.ParameterToString(realm));
path = path.Replace("{" + "groupId" + "}", ApiClient.ParameterToString(groupId));
    
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
                throw new ApiException ((int)response.StatusCode, "Error calling DeleteDefaultGroup: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling DeleteDefaultGroup: " + response.ErrorMessage, response.ErrorMessage);
    
            return;
        }
    
        /// <summary>
        ///  
        /// </summary>
        /// <param name="realm">realm name (not id!)</param>
        /// <param name="clientScopeId"></param>
        /// <returns></returns>
        public void DeleteDefaultOptionalClientScope (string realm, string clientScopeId)
        {
            // verify the required parameter 'realm' is set
            if (realm == null) throw new ApiException(400, "Missing required parameter 'realm' when calling DeleteDefaultOptionalClientScope");
            // verify the required parameter 'clientScopeId' is set
            if (clientScopeId == null) throw new ApiException(400, "Missing required parameter 'clientScopeId' when calling DeleteDefaultOptionalClientScope");
    
            var path = "/{realm}/default-optional-client-scopes/{clientScopeId}";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "realm" + "}", ApiClient.ParameterToString(realm));
path = path.Replace("{" + "clientScopeId" + "}", ApiClient.ParameterToString(clientScopeId));
    
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
                throw new ApiException ((int)response.StatusCode, "Error calling DeleteDefaultOptionalClientScope: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling DeleteDefaultOptionalClientScope: " + response.ErrorMessage, response.ErrorMessage);
    
            return;
        }
    
        /// <summary>
        ///  Delete all events
        /// </summary>
        /// <param name="realm">realm name (not id!)</param>
        /// <returns></returns>
        public void DeleteEvents (string realm)
        {
            // verify the required parameter 'realm' is set
            if (realm == null) throw new ApiException(400, "Missing required parameter 'realm' when calling DeleteEvents");
    
            var path = "/{realm}/events";
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
                throw new ApiException ((int)response.StatusCode, "Error calling DeleteEvents: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling DeleteEvents: " + response.ErrorMessage, response.ErrorMessage);
    
            return;
        }
    
        /// <summary>
        ///  
        /// </summary>
        /// <param name="realm">realm name (not id!)</param>
        /// <param name="locale"></param>
        /// <returns></returns>
        public void DeleteLocalizationByRealmByLocale (string realm, string locale)
        {
            // verify the required parameter 'realm' is set
            if (realm == null) throw new ApiException(400, "Missing required parameter 'realm' when calling DeleteLocalizationByRealmByLocale");
            // verify the required parameter 'locale' is set
            if (locale == null) throw new ApiException(400, "Missing required parameter 'locale' when calling DeleteLocalizationByRealmByLocale");
    
            var path = "/{realm}/localization/{locale}";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "realm" + "}", ApiClient.ParameterToString(realm));
path = path.Replace("{" + "locale" + "}", ApiClient.ParameterToString(locale));
    
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
                throw new ApiException ((int)response.StatusCode, "Error calling DeleteLocalizationByRealmByLocale: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling DeleteLocalizationByRealmByLocale: " + response.ErrorMessage, response.ErrorMessage);
    
            return;
        }
    
        /// <summary>
        ///  
        /// </summary>
        /// <param name="realm">realm name (not id!)</param>
        /// <param name="locale"></param>
        /// <param name="key"></param>
        /// <returns></returns>
        public void DeleteLocalizationByRealmByLocaleByKey (string realm, string locale, string key)
        {
            // verify the required parameter 'realm' is set
            if (realm == null) throw new ApiException(400, "Missing required parameter 'realm' when calling DeleteLocalizationByRealmByLocaleByKey");
            // verify the required parameter 'locale' is set
            if (locale == null) throw new ApiException(400, "Missing required parameter 'locale' when calling DeleteLocalizationByRealmByLocaleByKey");
            // verify the required parameter 'key' is set
            if (key == null) throw new ApiException(400, "Missing required parameter 'key' when calling DeleteLocalizationByRealmByLocaleByKey");
    
            var path = "/{realm}/localization/{locale}/{key}";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "realm" + "}", ApiClient.ParameterToString(realm));
path = path.Replace("{" + "locale" + "}", ApiClient.ParameterToString(locale));
path = path.Replace("{" + "key" + "}", ApiClient.ParameterToString(key));
    
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
                throw new ApiException ((int)response.StatusCode, "Error calling DeleteLocalizationByRealmByLocaleByKey: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling DeleteLocalizationByRealmByLocaleByKey: " + response.ErrorMessage, response.ErrorMessage);
    
            return;
        }
    
        /// <summary>
        ///  Remove a specific user session.
        /// </summary>
        /// <param name="realm">realm name (not id!)</param>
        /// <param name="session"></param>
        /// <returns></returns>
        public void DeleteSession (string realm, string session)
        {
            // verify the required parameter 'realm' is set
            if (realm == null) throw new ApiException(400, "Missing required parameter 'realm' when calling DeleteSession");
            // verify the required parameter 'session' is set
            if (session == null) throw new ApiException(400, "Missing required parameter 'session' when calling DeleteSession");
    
            var path = "/{realm}/sessions/{session}";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "realm" + "}", ApiClient.ParameterToString(realm));
path = path.Replace("{" + "session" + "}", ApiClient.ParameterToString(session));
    
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
                throw new ApiException ((int)response.StatusCode, "Error calling DeleteSession: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling DeleteSession: " + response.ErrorMessage, response.ErrorMessage);
    
            return;
        }
    
        /// <summary>
        ///  Get accessible realms Returns a list of accessible realms. The list is filtered based on what realms the caller is allowed to view.
        /// </summary>
        /// <param name="briefRepresentation"></param>
        /// <returns>List&lt;RealmRepresentation&gt;</returns>
        public List<RealmRepresentation> Get (string briefRepresentation)
        {
    
            var path = "/";
            path = path.Replace("{format}", "json");
                
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
             if (briefRepresentation != null) queryParams.Add("briefRepresentation", ApiClient.ParameterToString(briefRepresentation)); // query parameter
                        
            // authentication setting, if any
            String[] authSettings = new String[] { "access_token" };
    
            // make the HTTP request
            RestResponseBase response = (RestResponseBase) ApiClient.CallApi(path, Method.Get, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling Get: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling Get: " + response.ErrorMessage, response.ErrorMessage);
    
            return (List<RealmRepresentation>) ApiClient.Deserialize(response.Content, typeof(List<RealmRepresentation>), response.Headers);
        }
    
        /// <summary>
        ///  Get admin events Returns all admin events, or filters events based on URL query parameters listed here
        /// </summary>
        /// <param name="realm">realm name (not id!)</param>
        /// <param name="authClient"></param>
        /// <param name="authIpAddress"></param>
        /// <param name="authRealm"></param>
        /// <param name="authUser">user id</param>
        /// <param name="dateFrom"></param>
        /// <param name="dateTo"></param>
        /// <param name="first"></param>
        /// <param name="max">Maximum results size (defaults to 100)</param>
        /// <param name="operationTypes">[String]</param>
        /// <param name="resourcePath"></param>
        /// <param name="resourceTypes">[String]</param>
        /// <returns>List&lt;AdminEventRepresentation&gt;</returns>
        public List<AdminEventRepresentation> GetAdminEvents (string realm, string authClient, string authIpAddress, string authRealm, string authUser, string dateFrom, string dateTo, string first, string max, string operationTypes, string resourcePath, string resourceTypes)
        {
            // verify the required parameter 'realm' is set
            if (realm == null) throw new ApiException(400, "Missing required parameter 'realm' when calling GetAdminEvents");
    
            var path = "/{realm}/admin-events";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "realm" + "}", ApiClient.ParameterToString(realm));
    
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
             if (authClient != null) queryParams.Add("authClient", ApiClient.ParameterToString(authClient)); // query parameter
 if (authIpAddress != null) queryParams.Add("authIpAddress", ApiClient.ParameterToString(authIpAddress)); // query parameter
 if (authRealm != null) queryParams.Add("authRealm", ApiClient.ParameterToString(authRealm)); // query parameter
 if (authUser != null) queryParams.Add("authUser", ApiClient.ParameterToString(authUser)); // query parameter
 if (dateFrom != null) queryParams.Add("dateFrom", ApiClient.ParameterToString(dateFrom)); // query parameter
 if (dateTo != null) queryParams.Add("dateTo", ApiClient.ParameterToString(dateTo)); // query parameter
 if (first != null) queryParams.Add("first", ApiClient.ParameterToString(first)); // query parameter
 if (max != null) queryParams.Add("max", ApiClient.ParameterToString(max)); // query parameter
 if (operationTypes != null) queryParams.Add("operationTypes", ApiClient.ParameterToString(operationTypes)); // query parameter
 if (resourcePath != null) queryParams.Add("resourcePath", ApiClient.ParameterToString(resourcePath)); // query parameter
 if (resourceTypes != null) queryParams.Add("resourceTypes", ApiClient.ParameterToString(resourceTypes)); // query parameter
                        
            // authentication setting, if any
            String[] authSettings = new String[] { "access_token" };
    
            // make the HTTP request
            RestResponseBase response = (RestResponseBase) ApiClient.CallApi(path, Method.Get, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling GetAdminEvents: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling GetAdminEvents: " + response.ErrorMessage, response.ErrorMessage);
    
            return (List<AdminEventRepresentation>) ApiClient.Deserialize(response.Content, typeof(List<AdminEventRepresentation>), response.Headers);
        }
    
        /// <summary>
        ///  Get the top-level representation of the realm It will not include nested information like User and Client representations.
        /// </summary>
        /// <param name="realm">realm name (not id!)</param>
        /// <returns>RealmRepresentation</returns>
        public RealmRepresentation GetByRealm (string realm)
        {
            // verify the required parameter 'realm' is set
            if (realm == null) throw new ApiException(400, "Missing required parameter 'realm' when calling GetByRealm");
    
            var path = "/{realm}";
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
                throw new ApiException ((int)response.StatusCode, "Error calling GetByRealm: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling GetByRealm: " + response.ErrorMessage, response.ErrorMessage);
    
            return (RealmRepresentation) ApiClient.Deserialize(response.Content, typeof(RealmRepresentation), response.Headers);
        }
    
        /// <summary>
        ///  Get client session stats Returns a JSON map.
        /// </summary>
        /// <param name="realm">realm name (not id!)</param>
        /// <returns>List&lt;string&gt;</returns>
        public List<string> GetClientSessionStats (string realm)
        {
            // verify the required parameter 'realm' is set
            if (realm == null) throw new ApiException(400, "Missing required parameter 'realm' when calling GetClientSessionStats");
    
            var path = "/{realm}/client-session-stats";
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
                throw new ApiException ((int)response.StatusCode, "Error calling GetClientSessionStats: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling GetClientSessionStats: " + response.ErrorMessage, response.ErrorMessage);
    
            return (List<string>) ApiClient.Deserialize(response.Content, typeof(List<string>), response.Headers);
        }
    
        /// <summary>
        ///  
        /// </summary>
        /// <param name="realm">realm name (not id!)</param>
        /// <returns>List&lt;string&gt;</returns>
        public List<string> GetCredentialRegistrators (string realm)
        {
            // verify the required parameter 'realm' is set
            if (realm == null) throw new ApiException(400, "Missing required parameter 'realm' when calling GetCredentialRegistrators");
    
            var path = "/{realm}/credential-registrators";
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
                throw new ApiException ((int)response.StatusCode, "Error calling GetCredentialRegistrators: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling GetCredentialRegistrators: " + response.ErrorMessage, response.ErrorMessage);
    
            return (List<string>) ApiClient.Deserialize(response.Content, typeof(List<string>), response.Headers);
        }
    
        /// <summary>
        ///  Get realm default client scopes.  Only name and ids are returned.
        /// </summary>
        /// <param name="realm">realm name (not id!)</param>
        /// <returns>List&lt;ClientScopeRepresentation&gt;</returns>
        public List<ClientScopeRepresentation> GetDefaultDefaultClientScopes (string realm)
        {
            // verify the required parameter 'realm' is set
            if (realm == null) throw new ApiException(400, "Missing required parameter 'realm' when calling GetDefaultDefaultClientScopes");
    
            var path = "/{realm}/default-default-client-scopes";
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
                throw new ApiException ((int)response.StatusCode, "Error calling GetDefaultDefaultClientScopes: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling GetDefaultDefaultClientScopes: " + response.ErrorMessage, response.ErrorMessage);
    
            return (List<ClientScopeRepresentation>) ApiClient.Deserialize(response.Content, typeof(List<ClientScopeRepresentation>), response.Headers);
        }
    
        /// <summary>
        ///  Get group hierarchy.  Only name and ids are returned.
        /// </summary>
        /// <param name="realm">realm name (not id!)</param>
        /// <returns>List&lt;GroupRepresentation&gt;</returns>
        public List<GroupRepresentation> GetDefaultGroups (string realm)
        {
            // verify the required parameter 'realm' is set
            if (realm == null) throw new ApiException(400, "Missing required parameter 'realm' when calling GetDefaultGroups");
    
            var path = "/{realm}/default-groups";
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
                throw new ApiException ((int)response.StatusCode, "Error calling GetDefaultGroups: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling GetDefaultGroups: " + response.ErrorMessage, response.ErrorMessage);
    
            return (List<GroupRepresentation>) ApiClient.Deserialize(response.Content, typeof(List<GroupRepresentation>), response.Headers);
        }
    
        /// <summary>
        ///  Get realm optional client scopes.  Only name and ids are returned.
        /// </summary>
        /// <param name="realm">realm name (not id!)</param>
        /// <returns>List&lt;ClientScopeRepresentation&gt;</returns>
        public List<ClientScopeRepresentation> GetDefaultOptionalClientScopes (string realm)
        {
            // verify the required parameter 'realm' is set
            if (realm == null) throw new ApiException(400, "Missing required parameter 'realm' when calling GetDefaultOptionalClientScopes");
    
            var path = "/{realm}/default-optional-client-scopes";
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
                throw new ApiException ((int)response.StatusCode, "Error calling GetDefaultOptionalClientScopes: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling GetDefaultOptionalClientScopes: " + response.ErrorMessage, response.ErrorMessage);
    
            return (List<ClientScopeRepresentation>) ApiClient.Deserialize(response.Content, typeof(List<ClientScopeRepresentation>), response.Headers);
        }
    
        /// <summary>
        ///  Get events Returns all events, or filters them based on URL query parameters listed here
        /// </summary>
        /// <param name="realm">realm name (not id!)</param>
        /// <param name="_client">App or oauth client name</param>
        /// <param name="dateFrom">From date</param>
        /// <param name="dateTo">To date</param>
        /// <param name="first">Paging offset</param>
        /// <param name="ipAddress">IP Address</param>
        /// <param name="max">Maximum results size (defaults to 100)</param>
        /// <param name="type">The types of events to return [String]</param>
        /// <param name="user">User id</param>
        /// <returns>List&lt;EventRepresentation&gt;</returns>
        public List<EventRepresentation> GetEvents (string realm, string _client, string dateFrom, string dateTo, string first, string ipAddress, string max, string type, string user)
        {
            // verify the required parameter 'realm' is set
            if (realm == null) throw new ApiException(400, "Missing required parameter 'realm' when calling GetEvents");
    
            var path = "/{realm}/events";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "realm" + "}", ApiClient.ParameterToString(realm));
    
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
             if (_client != null) queryParams.Add("client", ApiClient.ParameterToString(_client)); // query parameter
 if (dateFrom != null) queryParams.Add("dateFrom", ApiClient.ParameterToString(dateFrom)); // query parameter
 if (dateTo != null) queryParams.Add("dateTo", ApiClient.ParameterToString(dateTo)); // query parameter
 if (first != null) queryParams.Add("first", ApiClient.ParameterToString(first)); // query parameter
 if (ipAddress != null) queryParams.Add("ipAddress", ApiClient.ParameterToString(ipAddress)); // query parameter
 if (max != null) queryParams.Add("max", ApiClient.ParameterToString(max)); // query parameter
 if (type != null) queryParams.Add("type", ApiClient.ParameterToString(type)); // query parameter
 if (user != null) queryParams.Add("user", ApiClient.ParameterToString(user)); // query parameter
                        
            // authentication setting, if any
            String[] authSettings = new String[] { "access_token" };
    
            // make the HTTP request
            RestResponseBase response = (RestResponseBase) ApiClient.CallApi(path, Method.Get, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling GetEvents: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling GetEvents: " + response.ErrorMessage, response.ErrorMessage);
    
            return (List<EventRepresentation>) ApiClient.Deserialize(response.Content, typeof(List<EventRepresentation>), response.Headers);
        }
    
        /// <summary>
        ///  Get the events provider configuration Returns JSON object with events provider configuration
        /// </summary>
        /// <param name="realm">realm name (not id!)</param>
        /// <returns>RealmEventsConfigRepresentation</returns>
        public RealmEventsConfigRepresentation GetEventsConfig (string realm)
        {
            // verify the required parameter 'realm' is set
            if (realm == null) throw new ApiException(400, "Missing required parameter 'realm' when calling GetEventsConfig");
    
            var path = "/{realm}/events/config";
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
                throw new ApiException ((int)response.StatusCode, "Error calling GetEventsConfig: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling GetEventsConfig: " + response.ErrorMessage, response.ErrorMessage);
    
            return (RealmEventsConfigRepresentation) ApiClient.Deserialize(response.Content, typeof(RealmEventsConfigRepresentation), response.Headers);
        }

        /// <summary>
        ///  
        /// </summary>
        /// <param name="realm">realm name (not id!)</param>
        /// <param name="subPath">PathSegment</param>
        /// <returns>GroupRepresentation</returns>
        public GroupRepresentation GetGroupByPath (string realm, string subPath)
        {
            // verify the required parameter 'realm' is set
            if (realm == null) throw new ApiException(400, "Missing required parameter 'realm' when calling GetGroupByPath");
            // verify the required parameter 'path' is set
            if (subPath == null) throw new ApiException(400, "Missing required parameter 'path' when calling GetGroupByPath");
    
            var path = "/{realm}/group-by-path/{path}";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "realm" + "}", ApiClient.ParameterToString(realm));
path = path.Replace("{" + "path" + "}", ApiClient.ParameterToString(subPath));
    
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
                throw new ApiException ((int)response.StatusCode, "Error calling GetGroupByPath: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling GetGroupByPath: " + response.ErrorMessage, response.ErrorMessage);
    
            return (GroupRepresentation) ApiClient.Deserialize(response.Content, typeof(GroupRepresentation), response.Headers);
        }
    
        /// <summary>
        ///  
        /// </summary>
        /// <param name="realm">realm name (not id!)</param>
        /// <returns>List&lt;string&gt;</returns>
        public List<string> GetLocalizationByRealm (string realm)
        {
            // verify the required parameter 'realm' is set
            if (realm == null) throw new ApiException(400, "Missing required parameter 'realm' when calling GetLocalizationByRealm");
    
            var path = "/{realm}/localization";
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
                throw new ApiException ((int)response.StatusCode, "Error calling GetLocalizationByRealm: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling GetLocalizationByRealm: " + response.ErrorMessage, response.ErrorMessage);
    
            return (List<string>) ApiClient.Deserialize(response.Content, typeof(List<string>), response.Headers);
        }
    
        /// <summary>
        ///  
        /// </summary>
        /// <param name="realm">realm name (not id!)</param>
        /// <param name="locale"></param>
        /// <param name="useRealmDefaultLocaleFallback"></param>
        /// <returns>Dictionary&lt;string, string&gt;</returns>
        public Dictionary<string, string> GetLocalizationByRealmByLocale (string realm, string locale, string useRealmDefaultLocaleFallback)
        {
            // verify the required parameter 'realm' is set
            if (realm == null) throw new ApiException(400, "Missing required parameter 'realm' when calling GetLocalizationByRealmByLocale");
            // verify the required parameter 'locale' is set
            if (locale == null) throw new ApiException(400, "Missing required parameter 'locale' when calling GetLocalizationByRealmByLocale");
    
            var path = "/{realm}/localization/{locale}";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "realm" + "}", ApiClient.ParameterToString(realm));
path = path.Replace("{" + "locale" + "}", ApiClient.ParameterToString(locale));
    
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
             if (useRealmDefaultLocaleFallback != null) queryParams.Add("useRealmDefaultLocaleFallback", ApiClient.ParameterToString(useRealmDefaultLocaleFallback)); // query parameter
                        
            // authentication setting, if any
            String[] authSettings = new String[] { "access_token" };
    
            // make the HTTP request
            RestResponseBase response = (RestResponseBase) ApiClient.CallApi(path, Method.Get, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling GetLocalizationByRealmByLocale: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling GetLocalizationByRealmByLocale: " + response.ErrorMessage, response.ErrorMessage);
    
            return (Dictionary<string, string>) ApiClient.Deserialize(response.Content, typeof(Dictionary<string, string>), response.Headers);
        }
    
        /// <summary>
        ///  
        /// </summary>
        /// <param name="realm">realm name (not id!)</param>
        /// <param name="locale"></param>
        /// <param name="key"></param>
        /// <returns>string</returns>
        public string GetLocalizationByRealmByLocaleByKey (string realm, string locale, string key)
        {
            // verify the required parameter 'realm' is set
            if (realm == null) throw new ApiException(400, "Missing required parameter 'realm' when calling GetLocalizationByRealmByLocaleByKey");
            // verify the required parameter 'locale' is set
            if (locale == null) throw new ApiException(400, "Missing required parameter 'locale' when calling GetLocalizationByRealmByLocaleByKey");
            // verify the required parameter 'key' is set
            if (key == null) throw new ApiException(400, "Missing required parameter 'key' when calling GetLocalizationByRealmByLocaleByKey");
    
            var path = "/{realm}/localization/{locale}/{key}";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "realm" + "}", ApiClient.ParameterToString(realm));
path = path.Replace("{" + "locale" + "}", ApiClient.ParameterToString(locale));
path = path.Replace("{" + "key" + "}", ApiClient.ParameterToString(key));
    
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
                throw new ApiException ((int)response.StatusCode, "Error calling GetLocalizationByRealmByLocaleByKey: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling GetLocalizationByRealmByLocaleByKey: " + response.ErrorMessage, response.ErrorMessage);
    
            return (string) ApiClient.Deserialize(response.Content, typeof(string), response.Headers);
        }
    
        /// <summary>
        ///  
        /// </summary>
        /// <param name="realm">realm name (not id!)</param>
        /// <returns>ClientPoliciesRepresentation</returns>
        public ClientPoliciesRepresentation GetPolicies (string realm)
        {
            // verify the required parameter 'realm' is set
            if (realm == null) throw new ApiException(400, "Missing required parameter 'realm' when calling GetPolicies");
    
            var path = "/{realm}/client-policies/policies";
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
                throw new ApiException ((int)response.StatusCode, "Error calling GetPolicies: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling GetPolicies: " + response.ErrorMessage, response.ErrorMessage);
    
            return (ClientPoliciesRepresentation) ApiClient.Deserialize(response.Content, typeof(ClientPoliciesRepresentation), response.Headers);
        }
    
        /// <summary>
        ///  
        /// </summary>
        /// <param name="realm">realm name (not id!)</param>
        /// <param name="includeGlobalProfiles"></param>
        /// <returns>ClientProfilesRepresentation</returns>
        public ClientProfilesRepresentation GetProfiles (string realm, string includeGlobalProfiles)
        {
            // verify the required parameter 'realm' is set
            if (realm == null) throw new ApiException(400, "Missing required parameter 'realm' when calling GetProfiles");
    
            var path = "/{realm}/client-policies/profiles";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "realm" + "}", ApiClient.ParameterToString(realm));
    
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
             if (includeGlobalProfiles != null) queryParams.Add("include-global-profiles", ApiClient.ParameterToString(includeGlobalProfiles)); // query parameter
                        
            // authentication setting, if any
            String[] authSettings = new String[] { "access_token" };
    
            // make the HTTP request
            RestResponseBase response = (RestResponseBase) ApiClient.CallApi(path, Method.Get, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling GetProfiles: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling GetProfiles: " + response.ErrorMessage, response.ErrorMessage);
    
            return (ClientProfilesRepresentation) ApiClient.Deserialize(response.Content, typeof(ClientProfilesRepresentation), response.Headers);
        }
    
        /// <summary>
        ///  
        /// </summary>
        /// <param name="realm">realm name (not id!)</param>
        /// <returns>ManagementPermissionReference</returns>
        public ManagementPermissionReference GetUsersManagementPermissions (string realm)
        {
            // verify the required parameter 'realm' is set
            if (realm == null) throw new ApiException(400, "Missing required parameter 'realm' when calling GetUsersManagementPermissions");
    
            var path = "/{realm}/users-management-permissions";
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
                throw new ApiException ((int)response.StatusCode, "Error calling GetUsersManagementPermissions: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling GetUsersManagementPermissions: " + response.ErrorMessage, response.ErrorMessage);
    
            return (ManagementPermissionReference) ApiClient.Deserialize(response.Content, typeof(ManagementPermissionReference), response.Headers);
        }
    
        /// <summary>
        ///  Import a realm. Imports a realm from a full representation of that realm.
        /// </summary>
        /// <param name="body">[file]</param>
        /// <returns></returns>
        public void Post (Object body)
        {
    
            var path = "/";
            path = path.Replace("{format}", "json");
                
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
                throw new ApiException ((int)response.StatusCode, "Error calling Post: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling Post: " + response.ErrorMessage, response.ErrorMessage);
    
            return;
        }
    
        /// <summary>
        ///  Base path for importing clients under this realm.
        /// </summary>
        /// <param name="realm">realm name (not id!)</param>
        /// <param name="body">[string]</param>
        /// <returns>ClientRepresentation</returns>
        public ClientRepresentation PostClientDescriptionConverter (string realm, string body)
        {
            // verify the required parameter 'realm' is set
            if (realm == null) throw new ApiException(400, "Missing required parameter 'realm' when calling PostClientDescriptionConverter");
    
            var path = "/{realm}/client-description-converter";
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
                throw new ApiException ((int)response.StatusCode, "Error calling PostClientDescriptionConverter: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling PostClientDescriptionConverter: " + response.ErrorMessage, response.ErrorMessage);
    
            return (ClientRepresentation) ApiClient.Deserialize(response.Content, typeof(ClientRepresentation), response.Headers);
        }
    
        /// <summary>
        ///  Import localization from uploaded JSON file
        /// </summary>
        /// <param name="realm">realm name (not id!)</param>
        /// <param name="locale"></param>
        /// <param name="body">[string]</param>
        /// <returns></returns>
        public void PostLocalization (string realm, string locale, string body)
        {
            // verify the required parameter 'realm' is set
            if (realm == null) throw new ApiException(400, "Missing required parameter 'realm' when calling PostLocalization");
            // verify the required parameter 'locale' is set
            if (locale == null) throw new ApiException(400, "Missing required parameter 'locale' when calling PostLocalization");
    
            var path = "/{realm}/localization/{locale}";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "realm" + "}", ApiClient.ParameterToString(realm));
path = path.Replace("{" + "locale" + "}", ApiClient.ParameterToString(locale));
    
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
                throw new ApiException ((int)response.StatusCode, "Error calling PostLocalization: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling PostLocalization: " + response.ErrorMessage, response.ErrorMessage);
    
            return;
        }
    
        /// <summary>
        ///  Removes all user sessions.
        /// </summary>
        /// <param name="realm">realm name (not id!)</param>
        /// <returns>GlobalRequestResult</returns>
        public GlobalRequestResult PostLogoutAll (string realm)
        {
            // verify the required parameter 'realm' is set
            if (realm == null) throw new ApiException(400, "Missing required parameter 'realm' when calling PostLogoutAll");
    
            var path = "/{realm}/logout-all";
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
            RestResponseBase response = (RestResponseBase) ApiClient.CallApi(path, Method.Post, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling PostLogoutAll: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling PostLogoutAll: " + response.ErrorMessage, response.ErrorMessage);
    
            return (GlobalRequestResult) ApiClient.Deserialize(response.Content, typeof(GlobalRequestResult), response.Headers);
        }
    
        /// <summary>
        ///  Partial export of existing realm into a JSON file.
        /// </summary>
        /// <param name="realm">realm name (not id!)</param>
        /// <param name="exportClients"></param>
        /// <param name="exportGroupsAndRoles"></param>
        /// <returns></returns>
        public void PostPartialExport (string realm, string exportClients, string exportGroupsAndRoles)
        {
            // verify the required parameter 'realm' is set
            if (realm == null) throw new ApiException(400, "Missing required parameter 'realm' when calling PostPartialExport");
    
            var path = "/{realm}/partial-export";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "realm" + "}", ApiClient.ParameterToString(realm));
    
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
             if (exportClients != null) queryParams.Add("exportClients", ApiClient.ParameterToString(exportClients)); // query parameter
 if (exportGroupsAndRoles != null) queryParams.Add("exportGroupsAndRoles", ApiClient.ParameterToString(exportGroupsAndRoles)); // query parameter
                        
            // authentication setting, if any
            String[] authSettings = new String[] { "access_token" };
    
            // make the HTTP request
            RestResponseBase response = (RestResponseBase) ApiClient.CallApi(path, Method.Post, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling PostPartialExport: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling PostPartialExport: " + response.ErrorMessage, response.ErrorMessage);
    
            return;
        }
    
        /// <summary>
        ///  Partial import from a JSON file to an existing realm.
        /// </summary>
        /// <param name="realm">realm name (not id!)</param>
        /// <param name="body">[file]</param>
        /// <returns></returns>
        public void PostPartialImport (string realm, Object body)
        {
            // verify the required parameter 'realm' is set
            if (realm == null) throw new ApiException(400, "Missing required parameter 'realm' when calling PostPartialImport");
    
            var path = "/{realm}/partialImport";
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
                throw new ApiException ((int)response.StatusCode, "Error calling PostPartialImport: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling PostPartialImport: " + response.ErrorMessage, response.ErrorMessage);
    
            return;
        }
    
        /// <summary>
        ///  Push the realm’s revocation policy to any client that has an admin url associated with it.
        /// </summary>
        /// <param name="realm">realm name (not id!)</param>
        /// <returns>GlobalRequestResult</returns>
        public GlobalRequestResult PostPushRevocationByRealm (string realm)
        {
            // verify the required parameter 'realm' is set
            if (realm == null) throw new ApiException(400, "Missing required parameter 'realm' when calling PostPushRevocationByRealm");
    
            var path = "/{realm}/push-revocation";
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
            RestResponseBase response = (RestResponseBase) ApiClient.CallApi(path, Method.Post, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling PostPushRevocationByRealm: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling PostPushRevocationByRealm: " + response.ErrorMessage, response.ErrorMessage);
    
            return (GlobalRequestResult) ApiClient.Deserialize(response.Content, typeof(GlobalRequestResult), response.Headers);
        }
    
        /// <summary>
        ///  Test SMTP connection with current logged in user
        /// </summary>
        /// <param name="realm">realm name (not id!)</param>
        /// <param name="body">[string]</param>
        /// <returns></returns>
        public void PostTestSmtpConnection (string realm, string body)
        {
            // verify the required parameter 'realm' is set
            if (realm == null) throw new ApiException(400, "Missing required parameter 'realm' when calling PostTestSmtpConnection");
    
            var path = "/{realm}/testSMTPConnection";
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
                throw new ApiException ((int)response.StatusCode, "Error calling PostTestSmtpConnection: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling PostTestSmtpConnection: " + response.ErrorMessage, response.ErrorMessage);
    
            return;
        }
    
        /// <summary>
        ///  Update the top-level information of the realm Any user, roles or client information in the representation will be ignored.
        /// </summary>
        /// <param name="realm">realm name (not id!)</param>
        /// <param name="body">RealmRepresentation</param>
        /// <returns></returns>
        public void PutByRealm (string realm, RealmRepresentation body)
        {
            // verify the required parameter 'realm' is set
            if (realm == null) throw new ApiException(400, "Missing required parameter 'realm' when calling PutByRealm");
    
            var path = "/{realm}";
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
            RestResponseBase response = (RestResponseBase) ApiClient.CallApi(path, Method.Put, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling PutByRealm: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling PutByRealm: " + response.ErrorMessage, response.ErrorMessage);
    
            return;
        }
    
        /// <summary>
        ///  
        /// </summary>
        /// <param name="realm">realm name (not id!)</param>
        /// <param name="clientScopeId"></param>
        /// <returns></returns>
        public void PutDefaultDefaultClientScope (string realm, string clientScopeId)
        {
            // verify the required parameter 'realm' is set
            if (realm == null) throw new ApiException(400, "Missing required parameter 'realm' when calling PutDefaultDefaultClientScope");
            // verify the required parameter 'clientScopeId' is set
            if (clientScopeId == null) throw new ApiException(400, "Missing required parameter 'clientScopeId' when calling PutDefaultDefaultClientScope");
    
            var path = "/{realm}/default-default-client-scopes/{clientScopeId}";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "realm" + "}", ApiClient.ParameterToString(realm));
path = path.Replace("{" + "clientScopeId" + "}", ApiClient.ParameterToString(clientScopeId));
    
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
                                    
            // authentication setting, if any
            String[] authSettings = new String[] { "access_token" };
    
            // make the HTTP request
            RestResponseBase response = (RestResponseBase) ApiClient.CallApi(path, Method.Put, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling PutDefaultDefaultClientScope: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling PutDefaultDefaultClientScope: " + response.ErrorMessage, response.ErrorMessage);
    
            return;
        }
    
        /// <summary>
        ///  
        /// </summary>
        /// <param name="realm">realm name (not id!)</param>
        /// <param name="groupId"></param>
        /// <returns></returns>
        public void PutDefaultGroup (string realm, string groupId)
        {
            // verify the required parameter 'realm' is set
            if (realm == null) throw new ApiException(400, "Missing required parameter 'realm' when calling PutDefaultGroup");
            // verify the required parameter 'groupId' is set
            if (groupId == null) throw new ApiException(400, "Missing required parameter 'groupId' when calling PutDefaultGroup");
    
            var path = "/{realm}/default-groups/{groupId}";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "realm" + "}", ApiClient.ParameterToString(realm));
path = path.Replace("{" + "groupId" + "}", ApiClient.ParameterToString(groupId));
    
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
                                    
            // authentication setting, if any
            String[] authSettings = new String[] { "access_token" };
    
            // make the HTTP request
            RestResponseBase response = (RestResponseBase) ApiClient.CallApi(path, Method.Put, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling PutDefaultGroup: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling PutDefaultGroup: " + response.ErrorMessage, response.ErrorMessage);
    
            return;
        }
    
        /// <summary>
        ///  
        /// </summary>
        /// <param name="realm">realm name (not id!)</param>
        /// <param name="clientScopeId"></param>
        /// <returns></returns>
        public void PutDefaultOptionalClientScope (string realm, string clientScopeId)
        {
            // verify the required parameter 'realm' is set
            if (realm == null) throw new ApiException(400, "Missing required parameter 'realm' when calling PutDefaultOptionalClientScope");
            // verify the required parameter 'clientScopeId' is set
            if (clientScopeId == null) throw new ApiException(400, "Missing required parameter 'clientScopeId' when calling PutDefaultOptionalClientScope");
    
            var path = "/{realm}/default-optional-client-scopes/{clientScopeId}";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "realm" + "}", ApiClient.ParameterToString(realm));
path = path.Replace("{" + "clientScopeId" + "}", ApiClient.ParameterToString(clientScopeId));
    
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
                                    
            // authentication setting, if any
            String[] authSettings = new String[] { "access_token" };
    
            // make the HTTP request
            RestResponseBase response = (RestResponseBase) ApiClient.CallApi(path, Method.Put, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling PutDefaultOptionalClientScope: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling PutDefaultOptionalClientScope: " + response.ErrorMessage, response.ErrorMessage);
    
            return;
        }
    
        /// <summary>
        ///  
        /// </summary>
        /// <param name="realm">realm name (not id!)</param>
        /// <param name="body">RealmEventsConfigRepresentation</param>
        /// <returns></returns>
        public void PutEventsConfig (string realm, RealmEventsConfigRepresentation body)
        {
            // verify the required parameter 'realm' is set
            if (realm == null) throw new ApiException(400, "Missing required parameter 'realm' when calling PutEventsConfig");
    
            var path = "/{realm}/events/config";
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
            RestResponseBase response = (RestResponseBase) ApiClient.CallApi(path, Method.Put, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling PutEventsConfig: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling PutEventsConfig: " + response.ErrorMessage, response.ErrorMessage);
    
            return;
        }
    
        /// <summary>
        ///  
        /// </summary>
        /// <param name="realm">realm name (not id!)</param>
        /// <param name="locale"></param>
        /// <param name="key"></param>
        /// <param name="body">[string]</param>
        /// <returns></returns>
        public void PutLocalization (string realm, string locale, string key, string body)
        {
            // verify the required parameter 'realm' is set
            if (realm == null) throw new ApiException(400, "Missing required parameter 'realm' when calling PutLocalization");
            // verify the required parameter 'locale' is set
            if (locale == null) throw new ApiException(400, "Missing required parameter 'locale' when calling PutLocalization");
            // verify the required parameter 'key' is set
            if (key == null) throw new ApiException(400, "Missing required parameter 'key' when calling PutLocalization");
    
            var path = "/{realm}/localization/{locale}/{key}";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "realm" + "}", ApiClient.ParameterToString(realm));
path = path.Replace("{" + "locale" + "}", ApiClient.ParameterToString(locale));
path = path.Replace("{" + "key" + "}", ApiClient.ParameterToString(key));
    
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
                throw new ApiException ((int)response.StatusCode, "Error calling PutLocalization: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling PutLocalization: " + response.ErrorMessage, response.ErrorMessage);
    
            return;
        }
    
        /// <summary>
        ///  
        /// </summary>
        /// <param name="realm">realm name (not id!)</param>
        /// <param name="body">ClientPoliciesRepresentation</param>
        /// <returns></returns>
        public void PutPolicies (string realm, ClientPoliciesRepresentation body)
        {
            // verify the required parameter 'realm' is set
            if (realm == null) throw new ApiException(400, "Missing required parameter 'realm' when calling PutPolicies");
    
            var path = "/{realm}/client-policies/policies";
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
            RestResponseBase response = (RestResponseBase) ApiClient.CallApi(path, Method.Put, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling PutPolicies: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling PutPolicies: " + response.ErrorMessage, response.ErrorMessage);
    
            return;
        }
    
        /// <summary>
        ///  
        /// </summary>
        /// <param name="realm">realm name (not id!)</param>
        /// <param name="body">ClientProfilesRepresentation</param>
        /// <returns></returns>
        public void PutProfiles (string realm, ClientProfilesRepresentation body)
        {
            // verify the required parameter 'realm' is set
            if (realm == null) throw new ApiException(400, "Missing required parameter 'realm' when calling PutProfiles");
    
            var path = "/{realm}/client-policies/profiles";
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
            RestResponseBase response = (RestResponseBase) ApiClient.CallApi(path, Method.Put, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling PutProfiles: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling PutProfiles: " + response.ErrorMessage, response.ErrorMessage);
    
            return;
        }
    
        /// <summary>
        ///  
        /// </summary>
        /// <param name="realm">realm name (not id!)</param>
        /// <param name="body">ManagementPermissionReference</param>
        /// <returns>ManagementPermissionReference</returns>
        public ManagementPermissionReference PutUsersManagementPermissions (string realm, ManagementPermissionReference body)
        {
            // verify the required parameter 'realm' is set
            if (realm == null) throw new ApiException(400, "Missing required parameter 'realm' when calling PutUsersManagementPermissions");
    
            var path = "/{realm}/users-management-permissions";
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
            RestResponseBase response = (RestResponseBase) ApiClient.CallApi(path, Method.Put, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling PutUsersManagementPermissions: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling PutUsersManagementPermissions: " + response.ErrorMessage, response.ErrorMessage);
    
            return (ManagementPermissionReference) ApiClient.Deserialize(response.Content, typeof(ManagementPermissionReference), response.Headers);
        }
    
    }
}
