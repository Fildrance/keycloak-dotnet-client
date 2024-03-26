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
    public interface IUsersApi
    {
        /// <summary>
        ///  Revoke consent and offline tokens for particular client from user
        /// </summary>
        /// <param name="realm">realm name (not id!)</param>
        /// <param name="id"></param>
        /// <param name="_client">Client id</param>
        /// <returns></returns>
        void DeleteConsent (string realm, string id, string _client);
        /// <summary>
        ///  Remove a credential for a user
        /// </summary>
        /// <param name="realm">realm name (not id!)</param>
        /// <param name="id"></param>
        /// <param name="credentialId"></param>
        /// <returns></returns>
        void DeleteCredential (string realm, string id, string credentialId);
        /// <summary>
        ///  Remove a social login provider from user
        /// </summary>
        /// <param name="realm">realm name (not id!)</param>
        /// <param name="id"></param>
        /// <param name="provider">Social login provider id</param>
        /// <returns></returns>
        void DeleteFederatedIdentity (string realm, string id, string provider);
        /// <summary>
        ///  Delete the user
        /// </summary>
        /// <param name="realm">realm name (not id!)</param>
        /// <param name="id"></param>
        /// <returns></returns>
        void DeleteUserByRealmById (string realm, string id);
        /// <summary>
        ///  
        /// </summary>
        /// <param name="realm">realm name (not id!)</param>
        /// <param name="id"></param>
        /// <param name="groupId"></param>
        /// <returns></returns>
        void DeleteUserGroup (string realm, string id, string groupId);
        /// <summary>
        ///  Return credential types, which are provided by the user storage where user is stored.
        /// </summary>
        /// <param name="realm">realm name (not id!)</param>
        /// <param name="id"></param>
        /// <returns>List&lt;string&gt;</returns>
        List<string> GetConfiguredUserStorageCredentialTypes (string realm, string id);
        /// <summary>
        ///  Get consents granted by the user
        /// </summary>
        /// <param name="realm">realm name (not id!)</param>
        /// <param name="id"></param>
        /// <returns>List&lt;Object&gt;</returns>
        List<Object> GetConsents (string realm, string id);
        /// <summary>
        ///  
        /// </summary>
        /// <param name="realm">realm name (not id!)</param>
        /// <param name="id"></param>
        /// <returns>List&lt;CredentialRepresentation&gt;</returns>
        List<CredentialRepresentation> GetCredentials (string realm, string id);
        /// <summary>
        ///  Get social logins associated with the user
        /// </summary>
        /// <param name="realm">realm name (not id!)</param>
        /// <param name="id"></param>
        /// <returns>List&lt;FederatedIdentityRepresentation&gt;</returns>
        List<FederatedIdentityRepresentation> GetFederatedIdentity (string realm, string id);
        /// <summary>
        ///  
        /// </summary>
        /// <param name="realm">realm name (not id!)</param>
        /// <returns>UserProfileMetadata</returns>
        UserProfileMetadata GetMetadata (string realm);
        /// <summary>
        ///  Get offline sessions associated with the user and client
        /// </summary>
        /// <param name="realm">realm name (not id!)</param>
        /// <param name="id"></param>
        /// <param name="clientUuid"></param>
        /// <returns>List&lt;UserSessionRepresentation&gt;</returns>
        List<UserSessionRepresentation> GetOfflineSession (string realm, string id, string clientUuid);
        /// <summary>
        ///  
        /// </summary>
        /// <param name="realm">realm name (not id!)</param>
        /// <returns>UPConfig</returns>
        UPConfig GetProfile (string realm);
        /// <summary>
        ///  Get sessions associated with the user
        /// </summary>
        /// <param name="realm">realm name (not id!)</param>
        /// <param name="id"></param>
        /// <returns>List&lt;UserSessionRepresentation&gt;</returns>
        List<UserSessionRepresentation> GetSessions (string realm, string id);
        /// <summary>
        ///  Get representation of the user
        /// </summary>
        /// <param name="realm">realm name (not id!)</param>
        /// <param name="id"></param>
        /// <param name="userProfileMetadata">Indicates if the user profile metadata should be added to the response</param>
        /// <returns>UserRepresentation</returns>
        UserRepresentation GetUserByRealmById (string realm, string id, string userProfileMetadata);
        /// <summary>
        ///  
        /// </summary>
        /// <param name="realm">realm name (not id!)</param>
        /// <param name="id"></param>
        /// <param name="briefRepresentation"></param>
        /// <param name="first"></param>
        /// <param name="max"></param>
        /// <param name="search"></param>
        /// <returns>List&lt;GroupRepresentation&gt;</returns>
        List<GroupRepresentation> GetUserGroups (string realm, string id, string briefRepresentation, string first, string max, string search);
        /// <summary>
        ///  
        /// </summary>
        /// <param name="realm">realm name (not id!)</param>
        /// <param name="id"></param>
        /// <param name="search"></param>
        /// <returns>Dictionary&lt;string, long?&gt;</returns>
        Dictionary<string, long?> GetUserGroupsCount (string realm, string id, string search);
        /// <summary>
        ///  Get users Returns a stream of users, filtered according to query parameters.
        /// </summary>
        /// <param name="realm">realm name (not id!)</param>
        /// <param name="briefRepresentation">Boolean which defines whether brief representations are returned (default: false)</param>
        /// <param name="email">A String contained in email, or the complete email, if param &amp;quot;exact&amp;quot; is true</param>
        /// <param name="emailVerified">whether the email has been verified</param>
        /// <param name="enabled">Boolean representing if user is enabled or not</param>
        /// <param name="exact">Boolean which defines whether the params &amp;quot;last&amp;quot;, &amp;quot;first&amp;quot;, &amp;quot;email&amp;quot; and &amp;quot;username&amp;quot; must match exactly</param>
        /// <param name="first">Pagination offset</param>
        /// <param name="firstName">A String contained in firstName, or the complete firstName, if param &amp;quot;exact&amp;quot; is true</param>
        /// <param name="idpAlias">The alias of an Identity Provider linked to the user</param>
        /// <param name="idpUserId">The userId at an Identity Provider linked to the user</param>
        /// <param name="lastName">A String contained in lastName, or the complete lastName, if param &amp;quot;exact&amp;quot; is true</param>
        /// <param name="max">Maximum results size (defaults to 100)</param>
        /// <param name="q">A query to search for custom attributes, in the format &#x27;key1:value2 key2:value2&#x27;</param>
        /// <param name="search">A String contained in username, first or last name, or email. Default search behavior is prefix-based (e.g., foo or foo*). Use foo for infix search and &amp;quot;foo&amp;quot; for exact search.</param>
        /// <param name="username">A String contained in username, or the complete username, if param &amp;quot;exact&amp;quot; is true</param>
        /// <returns>List&lt;UserRepresentation&gt;</returns>
        List<UserRepresentation> GetUsersByRealm (string realm, string briefRepresentation, string email, string emailVerified, string enabled, string exact, string first, string firstName, string idpAlias, string idpUserId, string lastName, string max, string q, string search, string username);
        /// <summary>
        ///  Returns the number of users that match the given criteria.
        /// </summary>
        /// <param name="realm">realm name (not id!)</param>
        /// <param name="email">email filter</param>
        /// <param name="emailVerified"></param>
        /// <param name="enabled">Boolean representing if user is enabled or not</param>
        /// <param name="firstName">first name filter</param>
        /// <param name="lastName">last name filter</param>
        /// <param name="q"></param>
        /// <param name="search">arbitrary search string for all the fields below. Default search behavior is prefix-based (e.g., foo or foo*). Use foo for infix search and &amp;quot;foo&amp;quot; for exact search.</param>
        /// <param name="username">username filter</param>
        /// <returns>int?</returns>
        int? GetUsersCount (string realm, string email, string emailVerified, string enabled, string firstName, string lastName, string q, string search, string username);
        /// <summary>
        ///  Add a social login provider to the user
        /// </summary>
        /// <param name="realm">realm name (not id!)</param>
        /// <param name="id"></param>
        /// <param name="provider">Social login provider id</param>
        /// <returns></returns>
        void PostFederatedIdentity (string realm, string id, string provider);
        /// <summary>
        ///  Impersonate the user
        /// </summary>
        /// <param name="realm">realm name (not id!)</param>
        /// <param name="id"></param>
        /// <returns>Dictionary&lt;string, Object&gt;</returns>
        Dictionary<string, Object> PostImpersonation (string realm, string id);
        /// <summary>
        ///  Remove all user sessions associated with the user Also send notification to all clients that have an admin URL to invalidate the sessions for the particular user.
        /// </summary>
        /// <param name="realm">realm name (not id!)</param>
        /// <param name="id"></param>
        /// <returns></returns>
        void PostLogout (string realm, string id);
        /// <summary>
        ///  Move a credential to a position behind another credential
        /// </summary>
        /// <param name="realm">realm name (not id!)</param>
        /// <param name="id"></param>
        /// <param name="credentialId">The credential to move</param>
        /// <param name="newPreviousCredentialId">The credential that will be the previous element in the list. If set to null, the moved credential will be the first element in the list.</param>
        /// <returns></returns>
        void PostMoveAfter (string realm, string id, string credentialId, string newPreviousCredentialId);
        /// <summary>
        ///  Move a credential to a first position in the credentials list of the user
        /// </summary>
        /// <param name="realm">realm name (not id!)</param>
        /// <param name="id"></param>
        /// <param name="credentialId">The credential to move</param>
        /// <returns></returns>
        void PostMoveToFirst (string realm, string id, string credentialId);
        /// <summary>
        ///  Create a new user Username must be unique.
        /// </summary>
        /// <param name="realm">realm name (not id!)</param>
        /// <param name="body">UserRepresentation</param>
        /// <returns></returns>
        void PostUsers (string realm, UserRepresentation body);
        /// <summary>
        ///  Disable all credentials for a user of a specific type
        /// </summary>
        /// <param name="realm">realm name (not id!)</param>
        /// <param name="id"></param>
        /// <param name="body">[string]</param>
        /// <returns></returns>
        void PutDisableCredentialTypes (string realm, string id, string body);
        /// <summary>
        ///  Send an email to the user with a link they can click to execute particular actions.
        /// </summary>
        /// <param name="realm">realm name (not id!)</param>
        /// <param name="id"></param>
        /// <param name="body">[string]</param>
        /// <param name="clientId">Client id</param>
        /// <param name="lifespan">Number of seconds after which the generated token expires</param>
        /// <param name="redirectUri">Redirect uri</param>
        /// <returns></returns>
        void PutExecuteActionsEmail (string realm, string id, string body, string clientId, string lifespan, string redirectUri);
        /// <summary>
        ///  
        /// </summary>
        /// <param name="realm">realm name (not id!)</param>
        /// <param name="body">UPConfig</param>
        /// <returns>UPConfig</returns>
        UPConfig PutProfile (string realm, UPConfig body);
        /// <summary>
        ///  Set up a new password for the user.
        /// </summary>
        /// <param name="realm">realm name (not id!)</param>
        /// <param name="id"></param>
        /// <param name="body">CredentialRepresentation</param>
        /// <returns></returns>
        void PutResetPassword (string realm, string id, CredentialRepresentation body);
        /// <summary>
        ///  Send an email to the user with a link they can click to reset their password.
        /// </summary>
        /// <param name="realm">realm name (not id!)</param>
        /// <param name="id"></param>
        /// <param name="clientId">client id</param>
        /// <param name="redirectUri">redirect uri</param>
        /// <returns></returns>
        void PutResetPasswordEmail (string realm, string id, string clientId, string redirectUri);
        /// <summary>
        ///  Send an email-verification email to the user An email contains a link the user can click to verify their email address.
        /// </summary>
        /// <param name="realm">realm name (not id!)</param>
        /// <param name="id"></param>
        /// <param name="clientId">Client id</param>
        /// <param name="redirectUri">Redirect uri</param>
        /// <returns></returns>
        void PutSendVerifyEmail (string realm, string id, string clientId, string redirectUri);
        /// <summary>
        ///  Update the user
        /// </summary>
        /// <param name="realm">realm name (not id!)</param>
        /// <param name="id"></param>
        /// <param name="body">UserRepresentation</param>
        /// <returns></returns>
        void PutUser (string realm, string id, UserRepresentation body);
        /// <summary>
        ///  
        /// </summary>
        /// <param name="realm">realm name (not id!)</param>
        /// <param name="id"></param>
        /// <param name="groupId"></param>
        /// <returns></returns>
        void PutUserGroup (string realm, string id, string groupId);
        /// <summary>
        ///  Update a credential label for a user
        /// </summary>
        /// <param name="realm">realm name (not id!)</param>
        /// <param name="id"></param>
        /// <param name="credentialId"></param>
        /// <param name="body">[string]</param>
        /// <returns></returns>
        void PutUserLabel (string realm, string id, string credentialId, string body);
    }
  
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public class UsersApi : IUsersApi
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="UsersApi"/> class.
        /// </summary>
        /// <param name="apiClient"> an instance of ApiClient (optional)</param>
        /// <returns></returns>
        public UsersApi(ApiClient apiClient = null)
        {
            if (apiClient == null) // use the default one in Configuration
                this.ApiClient = Configuration.DefaultApiClient; 
            else
                this.ApiClient = apiClient;
        }
    
        /// <summary>
        /// Initializes a new instance of the <see cref="UsersApi"/> class.
        /// </summary>
        /// <returns></returns>
        public UsersApi(String basePath)
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
        ///  Revoke consent and offline tokens for particular client from user
        /// </summary>
        /// <param name="realm">realm name (not id!)</param>
        /// <param name="id"></param>
        /// <param name="_client">Client id</param>
        /// <returns></returns>
        public void DeleteConsent (string realm, string id, string _client)
        {
            // verify the required parameter 'realm' is set
            if (realm == null) throw new ApiException(400, "Missing required parameter 'realm' when calling DeleteConsent");
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling DeleteConsent");
            // verify the required parameter '_client' is set
            if (_client == null) throw new ApiException(400, "Missing required parameter '_client' when calling DeleteConsent");
    
            var path = "/{realm}/users/{id}/consents/{client}";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "realm" + "}", ApiClient.ParameterToString(realm));
path = path.Replace("{" + "id" + "}", ApiClient.ParameterToString(id));
path = path.Replace("{" + "client" + "}", ApiClient.ParameterToString(_client));
    
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
                throw new ApiException ((int)response.StatusCode, "Error calling DeleteConsent: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling DeleteConsent: " + response.ErrorMessage, response.ErrorMessage);
    
            return;
        }
    
        /// <summary>
        ///  Remove a credential for a user
        /// </summary>
        /// <param name="realm">realm name (not id!)</param>
        /// <param name="id"></param>
        /// <param name="credentialId"></param>
        /// <returns></returns>
        public void DeleteCredential (string realm, string id, string credentialId)
        {
            // verify the required parameter 'realm' is set
            if (realm == null) throw new ApiException(400, "Missing required parameter 'realm' when calling DeleteCredential");
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling DeleteCredential");
            // verify the required parameter 'credentialId' is set
            if (credentialId == null) throw new ApiException(400, "Missing required parameter 'credentialId' when calling DeleteCredential");
    
            var path = "/{realm}/users/{id}/credentials/{credentialId}";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "realm" + "}", ApiClient.ParameterToString(realm));
path = path.Replace("{" + "id" + "}", ApiClient.ParameterToString(id));
path = path.Replace("{" + "credentialId" + "}", ApiClient.ParameterToString(credentialId));
    
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
                throw new ApiException ((int)response.StatusCode, "Error calling DeleteCredential: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling DeleteCredential: " + response.ErrorMessage, response.ErrorMessage);
    
            return;
        }
    
        /// <summary>
        ///  Remove a social login provider from user
        /// </summary>
        /// <param name="realm">realm name (not id!)</param>
        /// <param name="id"></param>
        /// <param name="provider">Social login provider id</param>
        /// <returns></returns>
        public void DeleteFederatedIdentity (string realm, string id, string provider)
        {
            // verify the required parameter 'realm' is set
            if (realm == null) throw new ApiException(400, "Missing required parameter 'realm' when calling DeleteFederatedIdentity");
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling DeleteFederatedIdentity");
            // verify the required parameter 'provider' is set
            if (provider == null) throw new ApiException(400, "Missing required parameter 'provider' when calling DeleteFederatedIdentity");
    
            var path = "/{realm}/users/{id}/federated-identity/{provider}";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "realm" + "}", ApiClient.ParameterToString(realm));
path = path.Replace("{" + "id" + "}", ApiClient.ParameterToString(id));
path = path.Replace("{" + "provider" + "}", ApiClient.ParameterToString(provider));
    
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
                throw new ApiException ((int)response.StatusCode, "Error calling DeleteFederatedIdentity: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling DeleteFederatedIdentity: " + response.ErrorMessage, response.ErrorMessage);
    
            return;
        }
    
        /// <summary>
        ///  Delete the user
        /// </summary>
        /// <param name="realm">realm name (not id!)</param>
        /// <param name="id"></param>
        /// <returns></returns>
        public void DeleteUserByRealmById (string realm, string id)
        {
            // verify the required parameter 'realm' is set
            if (realm == null) throw new ApiException(400, "Missing required parameter 'realm' when calling DeleteUserByRealmById");
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling DeleteUserByRealmById");
    
            var path = "/{realm}/users/{id}";
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
                throw new ApiException ((int)response.StatusCode, "Error calling DeleteUserByRealmById: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling DeleteUserByRealmById: " + response.ErrorMessage, response.ErrorMessage);
    
            return;
        }
    
        /// <summary>
        ///  
        /// </summary>
        /// <param name="realm">realm name (not id!)</param>
        /// <param name="id"></param>
        /// <param name="groupId"></param>
        /// <returns></returns>
        public void DeleteUserGroup (string realm, string id, string groupId)
        {
            // verify the required parameter 'realm' is set
            if (realm == null) throw new ApiException(400, "Missing required parameter 'realm' when calling DeleteUserGroup");
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling DeleteUserGroup");
            // verify the required parameter 'groupId' is set
            if (groupId == null) throw new ApiException(400, "Missing required parameter 'groupId' when calling DeleteUserGroup");
    
            var path = "/{realm}/users/{id}/groups/{groupId}";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "realm" + "}", ApiClient.ParameterToString(realm));
path = path.Replace("{" + "id" + "}", ApiClient.ParameterToString(id));
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
                throw new ApiException ((int)response.StatusCode, "Error calling DeleteUserGroup: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling DeleteUserGroup: " + response.ErrorMessage, response.ErrorMessage);
    
            return;
        }
    
        /// <summary>
        ///  Return credential types, which are provided by the user storage where user is stored.
        /// </summary>
        /// <param name="realm">realm name (not id!)</param>
        /// <param name="id"></param>
        /// <returns>List&lt;string&gt;</returns>
        public List<string> GetConfiguredUserStorageCredentialTypes (string realm, string id)
        {
            // verify the required parameter 'realm' is set
            if (realm == null) throw new ApiException(400, "Missing required parameter 'realm' when calling GetConfiguredUserStorageCredentialTypes");
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling GetConfiguredUserStorageCredentialTypes");
    
            var path = "/{realm}/users/{id}/configured-user-storage-credential-types";
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
                throw new ApiException ((int)response.StatusCode, "Error calling GetConfiguredUserStorageCredentialTypes: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling GetConfiguredUserStorageCredentialTypes: " + response.ErrorMessage, response.ErrorMessage);
    
            return (List<string>) ApiClient.Deserialize(response.Content, typeof(List<string>), response.Headers);
        }
    
        /// <summary>
        ///  Get consents granted by the user
        /// </summary>
        /// <param name="realm">realm name (not id!)</param>
        /// <param name="id"></param>
        /// <returns>List&lt;Object&gt;</returns>
        public List<Object> GetConsents (string realm, string id)
        {
            // verify the required parameter 'realm' is set
            if (realm == null) throw new ApiException(400, "Missing required parameter 'realm' when calling GetConsents");
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling GetConsents");
    
            var path = "/{realm}/users/{id}/consents";
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
                throw new ApiException ((int)response.StatusCode, "Error calling GetConsents: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling GetConsents: " + response.ErrorMessage, response.ErrorMessage);
    
            return (List<Object>) ApiClient.Deserialize(response.Content, typeof(List<Object>), response.Headers);
        }
    
        /// <summary>
        ///  
        /// </summary>
        /// <param name="realm">realm name (not id!)</param>
        /// <param name="id"></param>
        /// <returns>List&lt;CredentialRepresentation&gt;</returns>
        public List<CredentialRepresentation> GetCredentials (string realm, string id)
        {
            // verify the required parameter 'realm' is set
            if (realm == null) throw new ApiException(400, "Missing required parameter 'realm' when calling GetCredentials");
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling GetCredentials");
    
            var path = "/{realm}/users/{id}/credentials";
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
                throw new ApiException ((int)response.StatusCode, "Error calling GetCredentials: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling GetCredentials: " + response.ErrorMessage, response.ErrorMessage);
    
            return (List<CredentialRepresentation>) ApiClient.Deserialize(response.Content, typeof(List<CredentialRepresentation>), response.Headers);
        }
    
        /// <summary>
        ///  Get social logins associated with the user
        /// </summary>
        /// <param name="realm">realm name (not id!)</param>
        /// <param name="id"></param>
        /// <returns>List&lt;FederatedIdentityRepresentation&gt;</returns>
        public List<FederatedIdentityRepresentation> GetFederatedIdentity (string realm, string id)
        {
            // verify the required parameter 'realm' is set
            if (realm == null) throw new ApiException(400, "Missing required parameter 'realm' when calling GetFederatedIdentity");
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling GetFederatedIdentity");
    
            var path = "/{realm}/users/{id}/federated-identity";
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
                throw new ApiException ((int)response.StatusCode, "Error calling GetFederatedIdentity: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling GetFederatedIdentity: " + response.ErrorMessage, response.ErrorMessage);
    
            return (List<FederatedIdentityRepresentation>) ApiClient.Deserialize(response.Content, typeof(List<FederatedIdentityRepresentation>), response.Headers);
        }
    
        /// <summary>
        ///  
        /// </summary>
        /// <param name="realm">realm name (not id!)</param>
        /// <returns>UserProfileMetadata</returns>
        public UserProfileMetadata GetMetadata (string realm)
        {
            // verify the required parameter 'realm' is set
            if (realm == null) throw new ApiException(400, "Missing required parameter 'realm' when calling GetMetadata");
    
            var path = "/{realm}/users/profile/metadata";
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
                throw new ApiException ((int)response.StatusCode, "Error calling GetMetadata: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling GetMetadata: " + response.ErrorMessage, response.ErrorMessage);
    
            return (UserProfileMetadata) ApiClient.Deserialize(response.Content, typeof(UserProfileMetadata), response.Headers);
        }
    
        /// <summary>
        ///  Get offline sessions associated with the user and client
        /// </summary>
        /// <param name="realm">realm name (not id!)</param>
        /// <param name="id"></param>
        /// <param name="clientUuid"></param>
        /// <returns>List&lt;UserSessionRepresentation&gt;</returns>
        public List<UserSessionRepresentation> GetOfflineSession (string realm, string id, string clientUuid)
        {
            // verify the required parameter 'realm' is set
            if (realm == null) throw new ApiException(400, "Missing required parameter 'realm' when calling GetOfflineSession");
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling GetOfflineSession");
            // verify the required parameter 'clientUuid' is set
            if (clientUuid == null) throw new ApiException(400, "Missing required parameter 'clientUuid' when calling GetOfflineSession");
    
            var path = "/{realm}/users/{id}/offline-sessions/{clientUuid}";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "realm" + "}", ApiClient.ParameterToString(realm));
path = path.Replace("{" + "id" + "}", ApiClient.ParameterToString(id));
path = path.Replace("{" + "clientUuid" + "}", ApiClient.ParameterToString(clientUuid));
    
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
                throw new ApiException ((int)response.StatusCode, "Error calling GetOfflineSession: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling GetOfflineSession: " + response.ErrorMessage, response.ErrorMessage);
    
            return (List<UserSessionRepresentation>) ApiClient.Deserialize(response.Content, typeof(List<UserSessionRepresentation>), response.Headers);
        }
    
        /// <summary>
        ///  
        /// </summary>
        /// <param name="realm">realm name (not id!)</param>
        /// <returns>UPConfig</returns>
        public UPConfig GetProfile (string realm)
        {
            // verify the required parameter 'realm' is set
            if (realm == null) throw new ApiException(400, "Missing required parameter 'realm' when calling GetProfile");
    
            var path = "/{realm}/users/profile";
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
                throw new ApiException ((int)response.StatusCode, "Error calling GetProfile: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling GetProfile: " + response.ErrorMessage, response.ErrorMessage);
    
            return (UPConfig) ApiClient.Deserialize(response.Content, typeof(UPConfig), response.Headers);
        }
    
        /// <summary>
        ///  Get sessions associated with the user
        /// </summary>
        /// <param name="realm">realm name (not id!)</param>
        /// <param name="id"></param>
        /// <returns>List&lt;UserSessionRepresentation&gt;</returns>
        public List<UserSessionRepresentation> GetSessions (string realm, string id)
        {
            // verify the required parameter 'realm' is set
            if (realm == null) throw new ApiException(400, "Missing required parameter 'realm' when calling GetSessions");
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling GetSessions");
    
            var path = "/{realm}/users/{id}/sessions";
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
                throw new ApiException ((int)response.StatusCode, "Error calling GetSessions: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling GetSessions: " + response.ErrorMessage, response.ErrorMessage);
    
            return (List<UserSessionRepresentation>) ApiClient.Deserialize(response.Content, typeof(List<UserSessionRepresentation>), response.Headers);
        }
    
        /// <summary>
        ///  Get representation of the user
        /// </summary>
        /// <param name="realm">realm name (not id!)</param>
        /// <param name="id"></param>
        /// <param name="userProfileMetadata">Indicates if the user profile metadata should be added to the response</param>
        /// <returns>UserRepresentation</returns>
        public UserRepresentation GetUserByRealmById (string realm, string id, string userProfileMetadata)
        {
            // verify the required parameter 'realm' is set
            if (realm == null) throw new ApiException(400, "Missing required parameter 'realm' when calling GetUserByRealmById");
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling GetUserByRealmById");
    
            var path = "/{realm}/users/{id}";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "realm" + "}", ApiClient.ParameterToString(realm));
path = path.Replace("{" + "id" + "}", ApiClient.ParameterToString(id));
    
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
             if (userProfileMetadata != null) queryParams.Add("userProfileMetadata", ApiClient.ParameterToString(userProfileMetadata)); // query parameter
                        
            // authentication setting, if any
            String[] authSettings = new String[] { "access_token" };
    
            // make the HTTP request
            RestResponseBase response = (RestResponseBase) ApiClient.CallApi(path, Method.Get, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling GetUserByRealmById: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling GetUserByRealmById: " + response.ErrorMessage, response.ErrorMessage);
    
            return (UserRepresentation) ApiClient.Deserialize(response.Content, typeof(UserRepresentation), response.Headers);
        }
    
        /// <summary>
        ///  
        /// </summary>
        /// <param name="realm">realm name (not id!)</param>
        /// <param name="id"></param>
        /// <param name="briefRepresentation"></param>
        /// <param name="first"></param>
        /// <param name="max"></param>
        /// <param name="search"></param>
        /// <returns>List&lt;GroupRepresentation&gt;</returns>
        public List<GroupRepresentation> GetUserGroups (string realm, string id, string briefRepresentation, string first, string max, string search)
        {
            // verify the required parameter 'realm' is set
            if (realm == null) throw new ApiException(400, "Missing required parameter 'realm' when calling GetUserGroups");
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling GetUserGroups");
    
            var path = "/{realm}/users/{id}/groups";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "realm" + "}", ApiClient.ParameterToString(realm));
path = path.Replace("{" + "id" + "}", ApiClient.ParameterToString(id));
    
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
                throw new ApiException ((int)response.StatusCode, "Error calling GetUserGroups: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling GetUserGroups: " + response.ErrorMessage, response.ErrorMessage);
    
            return (List<GroupRepresentation>) ApiClient.Deserialize(response.Content, typeof(List<GroupRepresentation>), response.Headers);
        }
    
        /// <summary>
        ///  
        /// </summary>
        /// <param name="realm">realm name (not id!)</param>
        /// <param name="id"></param>
        /// <param name="search"></param>
        /// <returns>Dictionary&lt;string, long?&gt;</returns>
        public Dictionary<string, long?> GetUserGroupsCount (string realm, string id, string search)
        {
            // verify the required parameter 'realm' is set
            if (realm == null) throw new ApiException(400, "Missing required parameter 'realm' when calling GetUserGroupsCount");
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling GetUserGroupsCount");
    
            var path = "/{realm}/users/{id}/groups/count";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "realm" + "}", ApiClient.ParameterToString(realm));
path = path.Replace("{" + "id" + "}", ApiClient.ParameterToString(id));
    
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
             if (search != null) queryParams.Add("search", ApiClient.ParameterToString(search)); // query parameter
                        
            // authentication setting, if any
            String[] authSettings = new String[] { "access_token" };
    
            // make the HTTP request
            RestResponseBase response = (RestResponseBase) ApiClient.CallApi(path, Method.Get, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling GetUserGroupsCount: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling GetUserGroupsCount: " + response.ErrorMessage, response.ErrorMessage);
    
            return (Dictionary<string, long?>) ApiClient.Deserialize(response.Content, typeof(Dictionary<string, long?>), response.Headers);
        }
    
        /// <summary>
        ///  Get users Returns a stream of users, filtered according to query parameters.
        /// </summary>
        /// <param name="realm">realm name (not id!)</param>
        /// <param name="briefRepresentation">Boolean which defines whether brief representations are returned (default: false)</param>
        /// <param name="email">A String contained in email, or the complete email, if param &amp;quot;exact&amp;quot; is true</param>
        /// <param name="emailVerified">whether the email has been verified</param>
        /// <param name="enabled">Boolean representing if user is enabled or not</param>
        /// <param name="exact">Boolean which defines whether the params &amp;quot;last&amp;quot;, &amp;quot;first&amp;quot;, &amp;quot;email&amp;quot; and &amp;quot;username&amp;quot; must match exactly</param>
        /// <param name="first">Pagination offset</param>
        /// <param name="firstName">A String contained in firstName, or the complete firstName, if param &amp;quot;exact&amp;quot; is true</param>
        /// <param name="idpAlias">The alias of an Identity Provider linked to the user</param>
        /// <param name="idpUserId">The userId at an Identity Provider linked to the user</param>
        /// <param name="lastName">A String contained in lastName, or the complete lastName, if param &amp;quot;exact&amp;quot; is true</param>
        /// <param name="max">Maximum results size (defaults to 100)</param>
        /// <param name="q">A query to search for custom attributes, in the format &#x27;key1:value2 key2:value2&#x27;</param>
        /// <param name="search">A String contained in username, first or last name, or email. Default search behavior is prefix-based (e.g., foo or foo*). Use foo for infix search and &amp;quot;foo&amp;quot; for exact search.</param>
        /// <param name="username">A String contained in username, or the complete username, if param &amp;quot;exact&amp;quot; is true</param>
        /// <returns>List&lt;UserRepresentation&gt;</returns>
        public List<UserRepresentation> GetUsersByRealm (string realm, string briefRepresentation, string email, string emailVerified, string enabled, string exact, string first, string firstName, string idpAlias, string idpUserId, string lastName, string max, string q, string search, string username)
        {
            // verify the required parameter 'realm' is set
            if (realm == null) throw new ApiException(400, "Missing required parameter 'realm' when calling GetUsersByRealm");
    
            var path = "/{realm}/users";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "realm" + "}", ApiClient.ParameterToString(realm));
    
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
             if (briefRepresentation != null) queryParams.Add("briefRepresentation", ApiClient.ParameterToString(briefRepresentation)); // query parameter
 if (email != null) queryParams.Add("email", ApiClient.ParameterToString(email)); // query parameter
 if (emailVerified != null) queryParams.Add("emailVerified", ApiClient.ParameterToString(emailVerified)); // query parameter
 if (enabled != null) queryParams.Add("enabled", ApiClient.ParameterToString(enabled)); // query parameter
 if (exact != null) queryParams.Add("exact", ApiClient.ParameterToString(exact)); // query parameter
 if (first != null) queryParams.Add("first", ApiClient.ParameterToString(first)); // query parameter
 if (firstName != null) queryParams.Add("firstName", ApiClient.ParameterToString(firstName)); // query parameter
 if (idpAlias != null) queryParams.Add("idpAlias", ApiClient.ParameterToString(idpAlias)); // query parameter
 if (idpUserId != null) queryParams.Add("idpUserId", ApiClient.ParameterToString(idpUserId)); // query parameter
 if (lastName != null) queryParams.Add("lastName", ApiClient.ParameterToString(lastName)); // query parameter
 if (max != null) queryParams.Add("max", ApiClient.ParameterToString(max)); // query parameter
 if (q != null) queryParams.Add("q", ApiClient.ParameterToString(q)); // query parameter
 if (search != null) queryParams.Add("search", ApiClient.ParameterToString(search)); // query parameter
 if (username != null) queryParams.Add("username", ApiClient.ParameterToString(username)); // query parameter
                        
            // authentication setting, if any
            String[] authSettings = new String[] { "access_token" };
    
            // make the HTTP request
            RestResponseBase response = (RestResponseBase) ApiClient.CallApi(path, Method.Get, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling GetUsersByRealm: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling GetUsersByRealm: " + response.ErrorMessage, response.ErrorMessage);
    
            return (List<UserRepresentation>) ApiClient.Deserialize(response.Content, typeof(List<UserRepresentation>), response.Headers);
        }
    
        /// <summary>
        ///  Returns the number of users that match the given criteria.
        /// </summary>
        /// <param name="realm">realm name (not id!)</param>
        /// <param name="email">email filter</param>
        /// <param name="emailVerified"></param>
        /// <param name="enabled">Boolean representing if user is enabled or not</param>
        /// <param name="firstName">first name filter</param>
        /// <param name="lastName">last name filter</param>
        /// <param name="q"></param>
        /// <param name="search">arbitrary search string for all the fields below. Default search behavior is prefix-based (e.g., foo or foo*). Use foo for infix search and &amp;quot;foo&amp;quot; for exact search.</param>
        /// <param name="username">username filter</param>
        /// <returns>int?</returns>
        public int? GetUsersCount (string realm, string email, string emailVerified, string enabled, string firstName, string lastName, string q, string search, string username)
        {
            // verify the required parameter 'realm' is set
            if (realm == null) throw new ApiException(400, "Missing required parameter 'realm' when calling GetUsersCount");
    
            var path = "/{realm}/users/count";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "realm" + "}", ApiClient.ParameterToString(realm));
    
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
             if (email != null) queryParams.Add("email", ApiClient.ParameterToString(email)); // query parameter
 if (emailVerified != null) queryParams.Add("emailVerified", ApiClient.ParameterToString(emailVerified)); // query parameter
 if (enabled != null) queryParams.Add("enabled", ApiClient.ParameterToString(enabled)); // query parameter
 if (firstName != null) queryParams.Add("firstName", ApiClient.ParameterToString(firstName)); // query parameter
 if (lastName != null) queryParams.Add("lastName", ApiClient.ParameterToString(lastName)); // query parameter
 if (q != null) queryParams.Add("q", ApiClient.ParameterToString(q)); // query parameter
 if (search != null) queryParams.Add("search", ApiClient.ParameterToString(search)); // query parameter
 if (username != null) queryParams.Add("username", ApiClient.ParameterToString(username)); // query parameter
                        
            // authentication setting, if any
            String[] authSettings = new String[] { "access_token" };
    
            // make the HTTP request
            RestResponseBase response = (RestResponseBase) ApiClient.CallApi(path, Method.Get, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling GetUsersCount: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling GetUsersCount: " + response.ErrorMessage, response.ErrorMessage);
    
            return (int?) ApiClient.Deserialize(response.Content, typeof(int?), response.Headers);
        }
    
        /// <summary>
        ///  Add a social login provider to the user
        /// </summary>
        /// <param name="realm">realm name (not id!)</param>
        /// <param name="id"></param>
        /// <param name="provider">Social login provider id</param>
        /// <returns></returns>
        public void PostFederatedIdentity (string realm, string id, string provider)
        {
            // verify the required parameter 'realm' is set
            if (realm == null) throw new ApiException(400, "Missing required parameter 'realm' when calling PostFederatedIdentity");
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling PostFederatedIdentity");
            // verify the required parameter 'provider' is set
            if (provider == null) throw new ApiException(400, "Missing required parameter 'provider' when calling PostFederatedIdentity");
    
            var path = "/{realm}/users/{id}/federated-identity/{provider}";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "realm" + "}", ApiClient.ParameterToString(realm));
path = path.Replace("{" + "id" + "}", ApiClient.ParameterToString(id));
path = path.Replace("{" + "provider" + "}", ApiClient.ParameterToString(provider));
    
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
                throw new ApiException ((int)response.StatusCode, "Error calling PostFederatedIdentity: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling PostFederatedIdentity: " + response.ErrorMessage, response.ErrorMessage);
    
            return;
        }
    
        /// <summary>
        ///  Impersonate the user
        /// </summary>
        /// <param name="realm">realm name (not id!)</param>
        /// <param name="id"></param>
        /// <returns>Dictionary&lt;string, Object&gt;</returns>
        public Dictionary<string, Object> PostImpersonation (string realm, string id)
        {
            // verify the required parameter 'realm' is set
            if (realm == null) throw new ApiException(400, "Missing required parameter 'realm' when calling PostImpersonation");
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling PostImpersonation");
    
            var path = "/{realm}/users/{id}/impersonation";
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
            RestResponseBase response = (RestResponseBase) ApiClient.CallApi(path, Method.Post, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling PostImpersonation: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling PostImpersonation: " + response.ErrorMessage, response.ErrorMessage);
    
            return (Dictionary<string, Object>) ApiClient.Deserialize(response.Content, typeof(Dictionary<string, Object>), response.Headers);
        }
    
        /// <summary>
        ///  Remove all user sessions associated with the user Also send notification to all clients that have an admin URL to invalidate the sessions for the particular user.
        /// </summary>
        /// <param name="realm">realm name (not id!)</param>
        /// <param name="id"></param>
        /// <returns></returns>
        public void PostLogout (string realm, string id)
        {
            // verify the required parameter 'realm' is set
            if (realm == null) throw new ApiException(400, "Missing required parameter 'realm' when calling PostLogout");
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling PostLogout");
    
            var path = "/{realm}/users/{id}/logout";
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
            RestResponseBase response = (RestResponseBase) ApiClient.CallApi(path, Method.Post, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling PostLogout: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling PostLogout: " + response.ErrorMessage, response.ErrorMessage);
    
            return;
        }
    
        /// <summary>
        ///  Move a credential to a position behind another credential
        /// </summary>
        /// <param name="realm">realm name (not id!)</param>
        /// <param name="id"></param>
        /// <param name="credentialId">The credential to move</param>
        /// <param name="newPreviousCredentialId">The credential that will be the previous element in the list. If set to null, the moved credential will be the first element in the list.</param>
        /// <returns></returns>
        public void PostMoveAfter (string realm, string id, string credentialId, string newPreviousCredentialId)
        {
            // verify the required parameter 'realm' is set
            if (realm == null) throw new ApiException(400, "Missing required parameter 'realm' when calling PostMoveAfter");
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling PostMoveAfter");
            // verify the required parameter 'credentialId' is set
            if (credentialId == null) throw new ApiException(400, "Missing required parameter 'credentialId' when calling PostMoveAfter");
            // verify the required parameter 'newPreviousCredentialId' is set
            if (newPreviousCredentialId == null) throw new ApiException(400, "Missing required parameter 'newPreviousCredentialId' when calling PostMoveAfter");
    
            var path = "/{realm}/users/{id}/credentials/{credentialId}/moveAfter/{newPreviousCredentialId}";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "realm" + "}", ApiClient.ParameterToString(realm));
path = path.Replace("{" + "id" + "}", ApiClient.ParameterToString(id));
path = path.Replace("{" + "credentialId" + "}", ApiClient.ParameterToString(credentialId));
path = path.Replace("{" + "newPreviousCredentialId" + "}", ApiClient.ParameterToString(newPreviousCredentialId));
    
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
                throw new ApiException ((int)response.StatusCode, "Error calling PostMoveAfter: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling PostMoveAfter: " + response.ErrorMessage, response.ErrorMessage);
    
            return;
        }
    
        /// <summary>
        ///  Move a credential to a first position in the credentials list of the user
        /// </summary>
        /// <param name="realm">realm name (not id!)</param>
        /// <param name="id"></param>
        /// <param name="credentialId">The credential to move</param>
        /// <returns></returns>
        public void PostMoveToFirst (string realm, string id, string credentialId)
        {
            // verify the required parameter 'realm' is set
            if (realm == null) throw new ApiException(400, "Missing required parameter 'realm' when calling PostMoveToFirst");
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling PostMoveToFirst");
            // verify the required parameter 'credentialId' is set
            if (credentialId == null) throw new ApiException(400, "Missing required parameter 'credentialId' when calling PostMoveToFirst");
    
            var path = "/{realm}/users/{id}/credentials/{credentialId}/moveToFirst";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "realm" + "}", ApiClient.ParameterToString(realm));
path = path.Replace("{" + "id" + "}", ApiClient.ParameterToString(id));
path = path.Replace("{" + "credentialId" + "}", ApiClient.ParameterToString(credentialId));
    
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
                throw new ApiException ((int)response.StatusCode, "Error calling PostMoveToFirst: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling PostMoveToFirst: " + response.ErrorMessage, response.ErrorMessage);
    
            return;
        }
    
        /// <summary>
        ///  Create a new user Username must be unique.
        /// </summary>
        /// <param name="realm">realm name (not id!)</param>
        /// <param name="body">UserRepresentation</param>
        /// <returns></returns>
        public void PostUsers (string realm, UserRepresentation body)
        {
            // verify the required parameter 'realm' is set
            if (realm == null) throw new ApiException(400, "Missing required parameter 'realm' when calling PostUsers");
    
            var path = "/{realm}/users";
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
                throw new ApiException ((int)response.StatusCode, "Error calling PostUsers: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling PostUsers: " + response.ErrorMessage, response.ErrorMessage);
    
            return;
        }
    
        /// <summary>
        ///  Disable all credentials for a user of a specific type
        /// </summary>
        /// <param name="realm">realm name (not id!)</param>
        /// <param name="id"></param>
        /// <param name="body">[string]</param>
        /// <returns></returns>
        public void PutDisableCredentialTypes (string realm, string id, string body)
        {
            // verify the required parameter 'realm' is set
            if (realm == null) throw new ApiException(400, "Missing required parameter 'realm' when calling PutDisableCredentialTypes");
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling PutDisableCredentialTypes");
    
            var path = "/{realm}/users/{id}/disable-credential-types";
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
                throw new ApiException ((int)response.StatusCode, "Error calling PutDisableCredentialTypes: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling PutDisableCredentialTypes: " + response.ErrorMessage, response.ErrorMessage);
    
            return;
        }
    
        /// <summary>
        ///  Send an email to the user with a link they can click to execute particular actions.
        /// </summary>
        /// <param name="realm">realm name (not id!)</param>
        /// <param name="id"></param>
        /// <param name="body">[string]</param>
        /// <param name="clientId">Client id</param>
        /// <param name="lifespan">Number of seconds after which the generated token expires</param>
        /// <param name="redirectUri">Redirect uri</param>
        /// <returns></returns>
        public void PutExecuteActionsEmail (string realm, string id, string body, string clientId, string lifespan, string redirectUri)
        {
            // verify the required parameter 'realm' is set
            if (realm == null) throw new ApiException(400, "Missing required parameter 'realm' when calling PutExecuteActionsEmail");
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling PutExecuteActionsEmail");
    
            var path = "/{realm}/users/{id}/execute-actions-email";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "realm" + "}", ApiClient.ParameterToString(realm));
path = path.Replace("{" + "id" + "}", ApiClient.ParameterToString(id));
    
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
             if (clientId != null) queryParams.Add("client_id", ApiClient.ParameterToString(clientId)); // query parameter
 if (lifespan != null) queryParams.Add("lifespan", ApiClient.ParameterToString(lifespan)); // query parameter
 if (redirectUri != null) queryParams.Add("redirect_uri", ApiClient.ParameterToString(redirectUri)); // query parameter
                        postBody = ApiClient.Serialize(body); // http body (model) parameter

            // authentication setting, if any
            String[] authSettings = new String[] { "access_token" };
    
            // make the HTTP request
            RestResponseBase response = (RestResponseBase) ApiClient.CallApi(path, Method.Put, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling PutExecuteActionsEmail: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling PutExecuteActionsEmail: " + response.ErrorMessage, response.ErrorMessage);
    
            return;
        }
    
        /// <summary>
        ///  
        /// </summary>
        /// <param name="realm">realm name (not id!)</param>
        /// <param name="body">UPConfig</param>
        /// <returns>UPConfig</returns>
        public UPConfig PutProfile (string realm, UPConfig body)
        {
            // verify the required parameter 'realm' is set
            if (realm == null) throw new ApiException(400, "Missing required parameter 'realm' when calling PutProfile");
    
            var path = "/{realm}/users/profile";
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
                throw new ApiException ((int)response.StatusCode, "Error calling PutProfile: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling PutProfile: " + response.ErrorMessage, response.ErrorMessage);
    
            return (UPConfig) ApiClient.Deserialize(response.Content, typeof(UPConfig), response.Headers);
        }
    
        /// <summary>
        ///  Set up a new password for the user.
        /// </summary>
        /// <param name="realm">realm name (not id!)</param>
        /// <param name="id"></param>
        /// <param name="body">CredentialRepresentation</param>
        /// <returns></returns>
        public void PutResetPassword (string realm, string id, CredentialRepresentation body)
        {
            // verify the required parameter 'realm' is set
            if (realm == null) throw new ApiException(400, "Missing required parameter 'realm' when calling PutResetPassword");
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling PutResetPassword");
    
            var path = "/{realm}/users/{id}/reset-password";
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
                throw new ApiException ((int)response.StatusCode, "Error calling PutResetPassword: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling PutResetPassword: " + response.ErrorMessage, response.ErrorMessage);
    
            return;
        }
    
        /// <summary>
        ///  Send an email to the user with a link they can click to reset their password.
        /// </summary>
        /// <param name="realm">realm name (not id!)</param>
        /// <param name="id"></param>
        /// <param name="clientId">client id</param>
        /// <param name="redirectUri">redirect uri</param>
        /// <returns></returns>
        public void PutResetPasswordEmail (string realm, string id, string clientId, string redirectUri)
        {
            // verify the required parameter 'realm' is set
            if (realm == null) throw new ApiException(400, "Missing required parameter 'realm' when calling PutResetPasswordEmail");
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling PutResetPasswordEmail");
    
            var path = "/{realm}/users/{id}/reset-password-email";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "realm" + "}", ApiClient.ParameterToString(realm));
path = path.Replace("{" + "id" + "}", ApiClient.ParameterToString(id));
    
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
             if (clientId != null) queryParams.Add("client_id", ApiClient.ParameterToString(clientId)); // query parameter
 if (redirectUri != null) queryParams.Add("redirect_uri", ApiClient.ParameterToString(redirectUri)); // query parameter
                        
            // authentication setting, if any
            String[] authSettings = new String[] { "access_token" };
    
            // make the HTTP request
            RestResponseBase response = (RestResponseBase) ApiClient.CallApi(path, Method.Put, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling PutResetPasswordEmail: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling PutResetPasswordEmail: " + response.ErrorMessage, response.ErrorMessage);
    
            return;
        }
    
        /// <summary>
        ///  Send an email-verification email to the user An email contains a link the user can click to verify their email address.
        /// </summary>
        /// <param name="realm">realm name (not id!)</param>
        /// <param name="id"></param>
        /// <param name="clientId">Client id</param>
        /// <param name="redirectUri">Redirect uri</param>
        /// <returns></returns>
        public void PutSendVerifyEmail (string realm, string id, string clientId, string redirectUri)
        {
            // verify the required parameter 'realm' is set
            if (realm == null) throw new ApiException(400, "Missing required parameter 'realm' when calling PutSendVerifyEmail");
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling PutSendVerifyEmail");
    
            var path = "/{realm}/users/{id}/send-verify-email";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "realm" + "}", ApiClient.ParameterToString(realm));
path = path.Replace("{" + "id" + "}", ApiClient.ParameterToString(id));
    
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
             if (clientId != null) queryParams.Add("client_id", ApiClient.ParameterToString(clientId)); // query parameter
 if (redirectUri != null) queryParams.Add("redirect_uri", ApiClient.ParameterToString(redirectUri)); // query parameter
                        
            // authentication setting, if any
            String[] authSettings = new String[] { "access_token" };
    
            // make the HTTP request
            RestResponseBase response = (RestResponseBase) ApiClient.CallApi(path, Method.Put, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling PutSendVerifyEmail: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling PutSendVerifyEmail: " + response.ErrorMessage, response.ErrorMessage);
    
            return;
        }
    
        /// <summary>
        ///  Update the user
        /// </summary>
        /// <param name="realm">realm name (not id!)</param>
        /// <param name="id"></param>
        /// <param name="body">UserRepresentation</param>
        /// <returns></returns>
        public void PutUser (string realm, string id, UserRepresentation body)
        {
            // verify the required parameter 'realm' is set
            if (realm == null) throw new ApiException(400, "Missing required parameter 'realm' when calling PutUser");
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling PutUser");
    
            var path = "/{realm}/users/{id}";
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
                throw new ApiException ((int)response.StatusCode, "Error calling PutUser: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling PutUser: " + response.ErrorMessage, response.ErrorMessage);
    
            return;
        }
    
        /// <summary>
        ///  
        /// </summary>
        /// <param name="realm">realm name (not id!)</param>
        /// <param name="id"></param>
        /// <param name="groupId"></param>
        /// <returns></returns>
        public void PutUserGroup (string realm, string id, string groupId)
        {
            // verify the required parameter 'realm' is set
            if (realm == null) throw new ApiException(400, "Missing required parameter 'realm' when calling PutUserGroup");
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling PutUserGroup");
            // verify the required parameter 'groupId' is set
            if (groupId == null) throw new ApiException(400, "Missing required parameter 'groupId' when calling PutUserGroup");
    
            var path = "/{realm}/users/{id}/groups/{groupId}";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "realm" + "}", ApiClient.ParameterToString(realm));
path = path.Replace("{" + "id" + "}", ApiClient.ParameterToString(id));
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
                throw new ApiException ((int)response.StatusCode, "Error calling PutUserGroup: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling PutUserGroup: " + response.ErrorMessage, response.ErrorMessage);
    
            return;
        }
    
        /// <summary>
        ///  Update a credential label for a user
        /// </summary>
        /// <param name="realm">realm name (not id!)</param>
        /// <param name="id"></param>
        /// <param name="credentialId"></param>
        /// <param name="body">[string]</param>
        /// <returns></returns>
        public void PutUserLabel (string realm, string id, string credentialId, string body)
        {
            // verify the required parameter 'realm' is set
            if (realm == null) throw new ApiException(400, "Missing required parameter 'realm' when calling PutUserLabel");
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling PutUserLabel");
            // verify the required parameter 'credentialId' is set
            if (credentialId == null) throw new ApiException(400, "Missing required parameter 'credentialId' when calling PutUserLabel");
    
            var path = "/{realm}/users/{id}/credentials/{credentialId}/userLabel";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "realm" + "}", ApiClient.ParameterToString(realm));
path = path.Replace("{" + "id" + "}", ApiClient.ParameterToString(id));
path = path.Replace("{" + "credentialId" + "}", ApiClient.ParameterToString(credentialId));
    
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
                throw new ApiException ((int)response.StatusCode, "Error calling PutUserLabel: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling PutUserLabel: " + response.ErrorMessage, response.ErrorMessage);
    
            return;
        }
    
    }
}
