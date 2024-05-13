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
public partial interface IUsersApi
{
    /// <summary>
    ///  Revoke consent and offline tokens for particular client from user
    /// </summary>
    /// <param name="realm">realm name (not id!)</param>
    /// <param name="id"></param>
    /// <param name="_client">Client id</param>
    /// <param name="ct"></param>
    /// <returns></returns>
    Task DeleteConsent (string realm, string id, string _client, CancellationToken ct);
    /// <summary>
    ///  Remove a credential for a user
    /// </summary>
    /// <param name="realm">realm name (not id!)</param>
    /// <param name="id"></param>
    /// <param name="credentialId"></param>
    /// <param name="ct"></param>
    /// <returns></returns>
    Task DeleteCredential (string realm, string id, string credentialId, CancellationToken ct);
    /// <summary>
    ///  Remove a social login provider from user
    /// </summary>
    /// <param name="realm">realm name (not id!)</param>
    /// <param name="id"></param>
    /// <param name="provider">Social login provider id</param>
    /// <param name="ct"></param>
    /// <returns></returns>
    Task DeleteFederatedIdentity (string realm, string id, string provider, CancellationToken ct);
    /// <summary>
    ///  Delete the user
    /// </summary>
    /// <param name="realm">realm name (not id!)</param>
    /// <param name="id"></param>
    /// <param name="ct"></param>
    /// <returns></returns>
    Task DeleteUserByRealmById (string realm, string id, CancellationToken ct);
    /// <summary>
    ///  
    /// </summary>
    /// <param name="realm">realm name (not id!)</param>
    /// <param name="id"></param>
    /// <param name="groupId"></param>
    /// <param name="ct"></param>
    /// <returns></returns>
    Task DeleteUserGroup (string realm, string id, string groupId, CancellationToken ct);
    /// <summary>
    ///  Return credential types, which are provided by the user storage where user is stored.
    /// </summary>
    /// <param name="realm">realm name (not id!)</param>
    /// <param name="id"></param>
    /// <param name="ct"></param>
    /// <returns>List&lt;string&gt;</returns>
    Task<List<string>> GetConfiguredUserStorageCredentialTypes (string realm, string id, CancellationToken ct);
    /// <summary>
    ///  Get consents granted by the user
    /// </summary>
    /// <param name="realm">realm name (not id!)</param>
    /// <param name="id"></param>
    /// <param name="ct"></param>
    /// <returns>List&lt;Object&gt;</returns>
    Task<List<Object>> GetConsents (string realm, string id, CancellationToken ct);
    /// <summary>
    ///  
    /// </summary>
    /// <param name="realm">realm name (not id!)</param>
    /// <param name="id"></param>
    /// <param name="ct"></param>
    /// <returns>List&lt;CredentialRepresentation&gt;</returns>
    Task<List<CredentialRepresentation>> GetCredentials (string realm, string id, CancellationToken ct);
    /// <summary>
    ///  Get social logins associated with the user
    /// </summary>
    /// <param name="realm">realm name (not id!)</param>
    /// <param name="id"></param>
    /// <param name="ct"></param>
    /// <returns>List&lt;FederatedIdentityRepresentation&gt;</returns>
    Task<List<FederatedIdentityRepresentation>> GetFederatedIdentity (string realm, string id, CancellationToken ct);
    /// <summary>
    ///  
    /// </summary>
    /// <param name="realm">realm name (not id!)</param>
    /// <param name="ct"></param>
    /// <returns>UserProfileMetadata</returns>
    Task<UserProfileMetadata> GetMetadata (string realm, CancellationToken ct);
    /// <summary>
    ///  Get offline sessions associated with the user and client
    /// </summary>
    /// <param name="realm">realm name (not id!)</param>
    /// <param name="id"></param>
    /// <param name="clientUuid"></param>
    /// <param name="ct"></param>
    /// <returns>List&lt;UserSessionRepresentation&gt;</returns>
    Task<List<UserSessionRepresentation>> GetOfflineSession (string realm, string id, string clientUuid, CancellationToken ct);
    /// <summary>
    ///  
    /// </summary>
    /// <param name="realm">realm name (not id!)</param>
    /// <param name="ct"></param>
    /// <returns>UPConfig</returns>
    Task<UPConfig> GetProfile (string realm, CancellationToken ct);
    /// <summary>
    ///  Get sessions associated with the user
    /// </summary>
    /// <param name="realm">realm name (not id!)</param>
    /// <param name="id"></param>
    /// <param name="ct"></param>
    /// <returns>List&lt;UserSessionRepresentation&gt;</returns>
    Task<List<UserSessionRepresentation>> GetSessions (string realm, string id, CancellationToken ct);
    /// <summary>
    ///  Get representation of the user
    /// </summary>
    /// <param name="realm">realm name (not id!)</param>
    /// <param name="id"></param>
    /// <param name="userProfileMetadata">Indicates if the user profile metadata should be added to the response</param>
    /// <param name="ct"></param>
    /// <returns>UserRepresentation</returns>
    Task<UserRepresentation> GetUserByRealmById (string realm, string id, string userProfileMetadata, CancellationToken ct);
    /// <summary>
    ///  
    /// </summary>
    /// <param name="realm">realm name (not id!)</param>
    /// <param name="id"></param>
    /// <param name="briefRepresentation"></param>
    /// <param name="first"></param>
    /// <param name="max"></param>
    /// <param name="search"></param>
    /// <param name="ct"></param>
    /// <returns>List&lt;GroupRepresentation&gt;</returns>
    Task<List<GroupRepresentation>> GetUserGroups (string realm, string id, string briefRepresentation, string first, string max, string search, CancellationToken ct);
    /// <summary>
    ///  
    /// </summary>
    /// <param name="realm">realm name (not id!)</param>
    /// <param name="id"></param>
    /// <param name="search"></param>
    /// <param name="ct"></param>
    /// <returns>Dictionary&lt;string, long?&gt;</returns>
    Task<Dictionary<string, long?>> GetUserGroupsCount (string realm, string id, string search, CancellationToken ct);
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
    /// <param name="q">A query to search for custom attributes, in the format &#39;key1:value2 key2:value2&#39;</param>
    /// <param name="search">A String contained in username, first or last name, or email. Default search behavior is prefix-based (e.g., foo or foo*). Use foo for infix search and &amp;quot;foo&amp;quot; for exact search.</param>
    /// <param name="username">A String contained in username, or the complete username, if param &amp;quot;exact&amp;quot; is true</param>
    /// <param name="ct"></param>
    /// <returns>List&lt;UserRepresentation&gt;</returns>
    Task<List<UserRepresentation>> GetUsersByRealm (string realm, string briefRepresentation, string email, string emailVerified, string enabled, string exact, string first, string firstName, string idpAlias, string idpUserId, string lastName, string max, string q, string search, string username, CancellationToken ct);
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
    /// <param name="ct"></param>
    /// <returns>int?</returns>
    Task<int?> GetUsersCount (string realm, string email, string emailVerified, string enabled, string firstName, string lastName, string q, string search, string username, CancellationToken ct);
    /// <summary>
    ///  Add a social login provider to the user
    /// </summary>
    /// <param name="realm">realm name (not id!)</param>
    /// <param name="id"></param>
    /// <param name="provider">Social login provider id</param>
    /// <param name="ct"></param>
    /// <returns></returns>
    Task PostFederatedIdentity (string realm, string id, string provider, CancellationToken ct);
    /// <summary>
    ///  Impersonate the user
    /// </summary>
    /// <param name="realm">realm name (not id!)</param>
    /// <param name="id"></param>
    /// <param name="ct"></param>
    /// <returns>Dictionary&lt;string, Object&gt;</returns>
    Task<Dictionary<string, Object>> PostImpersonation (string realm, string id, CancellationToken ct);
    /// <summary>
    ///  Remove all user sessions associated with the user Also send notification to all clients that have an admin URL to invalidate the sessions for the particular user.
    /// </summary>
    /// <param name="realm">realm name (not id!)</param>
    /// <param name="id"></param>
    /// <param name="ct"></param>
    /// <returns></returns>
    Task PostLogout (string realm, string id, CancellationToken ct);
    /// <summary>
    ///  Move a credential to a position behind another credential
    /// </summary>
    /// <param name="realm">realm name (not id!)</param>
    /// <param name="id"></param>
    /// <param name="credentialId">The credential to move</param>
    /// <param name="newPreviousCredentialId">The credential that will be the previous element in the list. If set to null, the moved credential will be the first element in the list.</param>
    /// <param name="ct"></param>
    /// <returns></returns>
    Task PostMoveAfter (string realm, string id, string credentialId, string newPreviousCredentialId, CancellationToken ct);
    /// <summary>
    ///  Move a credential to a first position in the credentials list of the user
    /// </summary>
    /// <param name="realm">realm name (not id!)</param>
    /// <param name="id"></param>
    /// <param name="credentialId">The credential to move</param>
    /// <param name="ct"></param>
    /// <returns></returns>
    Task PostMoveToFirst (string realm, string id, string credentialId, CancellationToken ct);
    /// <summary>
    ///  Create a new user Username must be unique.
    /// </summary>
    /// <param name="realm">realm name (not id!)</param>
    /// <param name="body">UserRepresentation</param>
    /// <param name="ct"></param>
    /// <returns></returns>
    Task PostUsers (string realm, UserRepresentation body, CancellationToken ct);
    /// <summary>
    ///  Disable all credentials for a user of a specific type
    /// </summary>
    /// <param name="realm">realm name (not id!)</param>
    /// <param name="id"></param>
    /// <param name="body">[string]</param>
    /// <param name="ct"></param>
    /// <returns></returns>
    Task PutDisableCredentialTypes (string realm, string id, string body, CancellationToken ct);
    /// <summary>
    ///  Send an email to the user with a link they can click to execute particular actions.
    /// </summary>
    /// <param name="realm">realm name (not id!)</param>
    /// <param name="id"></param>
    /// <param name="body">[string]</param>
    /// <param name="clientId">Client id</param>
    /// <param name="lifespan">Number of seconds after which the generated token expires</param>
    /// <param name="redirectUri">Redirect uri</param>
    /// <param name="ct"></param>
    /// <returns></returns>
    Task PutExecuteActionsEmail (string realm, string id, string body, string clientId, string lifespan, string redirectUri, CancellationToken ct);
    /// <summary>
    ///  
    /// </summary>
    /// <param name="realm">realm name (not id!)</param>
    /// <param name="body">UPConfig</param>
    /// <param name="ct"></param>
    /// <returns>UPConfig</returns>
    Task<UPConfig> PutProfile (string realm, UPConfig body, CancellationToken ct);
    /// <summary>
    ///  Set up a new password for the user.
    /// </summary>
    /// <param name="realm">realm name (not id!)</param>
    /// <param name="id"></param>
    /// <param name="body">CredentialRepresentation</param>
    /// <param name="ct"></param>
    /// <returns></returns>
    Task PutResetPassword (string realm, string id, CredentialRepresentation body, CancellationToken ct);
    /// <summary>
    ///  Send an email to the user with a link they can click to reset their password.
    /// </summary>
    /// <param name="realm">realm name (not id!)</param>
    /// <param name="id"></param>
    /// <param name="clientId">client id</param>
    /// <param name="redirectUri">redirect uri</param>
    /// <param name="ct"></param>
    /// <returns></returns>
    Task PutResetPasswordEmail (string realm, string id, string clientId, string redirectUri, CancellationToken ct);
    /// <summary>
    ///  Send an email-verification email to the user An email contains a link the user can click to verify their email address.
    /// </summary>
    /// <param name="realm">realm name (not id!)</param>
    /// <param name="id"></param>
    /// <param name="clientId">Client id</param>
    /// <param name="redirectUri">Redirect uri</param>
    /// <param name="ct"></param>
    /// <returns></returns>
    Task PutSendVerifyEmail (string realm, string id, string clientId, string redirectUri, CancellationToken ct);
    /// <summary>
    ///  Update the user
    /// </summary>
    /// <param name="realm">realm name (not id!)</param>
    /// <param name="id"></param>
    /// <param name="body">UserRepresentation</param>
    /// <param name="ct"></param>
    /// <returns></returns>
    Task PutUser (string realm, string id, UserRepresentation body, CancellationToken ct);
    /// <summary>
    ///  
    /// </summary>
    /// <param name="realm">realm name (not id!)</param>
    /// <param name="id"></param>
    /// <param name="groupId"></param>
    /// <param name="ct"></param>
    /// <returns></returns>
    Task PutUserGroup (string realm, string id, string groupId, CancellationToken ct);
    /// <summary>
    ///  Update a credential label for a user
    /// </summary>
    /// <param name="realm">realm name (not id!)</param>
    /// <param name="id"></param>
    /// <param name="credentialId"></param>
    /// <param name="body">[string]</param>
    /// <param name="ct"></param>
    /// <returns></returns>
    Task PutUserLabel (string realm, string id, string credentialId, string body, CancellationToken ct);
}

/// <summary>
/// Represents a collection of functions to interact with the API endpoints
/// </summary>  
[GeneratedCode("swagger-codegen", "3.0.56-SNAPSHOT")]
public partial class UsersApi : PetShopApiClientBase, IUsersApi
{
    /// <summary>
    /// Initializes a new instance of the <see cref="UsersApi"/> class.
    /// </summary>
    /// <param name="httpClient"> HttpClient to be used for calls. </param>
    /// <param name="basePath"> Base url to be used for calls. </param>
    public UsersApi(HttpClient httpClient, String basePath="https://keycloak.example.com/admin/realms") : base(httpClient, basePath)
    {
    }

    /// <inheritdoc />     
    public async Task DeleteConsent(string realm, string id, string _client, CancellationToken ct)
    {
        // verify the required parameter 'realm' is set
        if (realm == null) throw new PetShopApiException(400, "Missing required parameter 'realm' when calling DeleteConsent");
        // verify the required parameter 'id' is set
        if (id == null) throw new PetShopApiException(400, "Missing required parameter 'id' when calling DeleteConsent");
        // verify the required parameter '_client' is set
        if (_client == null) throw new PetShopApiException(400, "Missing required parameter '_client' when calling DeleteConsent");
        
        var path_ = new StringBuilder("/{realm}/users/{id}/consents/{client}"); 
        path_ = path_.Replace("{realm}", ParameterToString(realm));
        path_ = path_.Replace("{id}", ParameterToString(id));
        path_ = path_.Replace("{client}", ParameterToString(_client));

        
        
        await CallApi(
                    path_.ToString(), 
                    HttpMethod.Delete,  
                    ct: ct
        );
    }

    /// <inheritdoc />     
    public async Task DeleteCredential(string realm, string id, string credentialId, CancellationToken ct)
    {
        // verify the required parameter 'realm' is set
        if (realm == null) throw new PetShopApiException(400, "Missing required parameter 'realm' when calling DeleteCredential");
        // verify the required parameter 'id' is set
        if (id == null) throw new PetShopApiException(400, "Missing required parameter 'id' when calling DeleteCredential");
        // verify the required parameter 'credentialId' is set
        if (credentialId == null) throw new PetShopApiException(400, "Missing required parameter 'credentialId' when calling DeleteCredential");
        
        var path_ = new StringBuilder("/{realm}/users/{id}/credentials/{credentialId}"); 
        path_ = path_.Replace("{realm}", ParameterToString(realm));
        path_ = path_.Replace("{id}", ParameterToString(id));
        path_ = path_.Replace("{credentialId}", ParameterToString(credentialId));

        
        
        await CallApi(
                    path_.ToString(), 
                    HttpMethod.Delete,  
                    ct: ct
        );
    }

    /// <inheritdoc />     
    public async Task DeleteFederatedIdentity(string realm, string id, string provider, CancellationToken ct)
    {
        // verify the required parameter 'realm' is set
        if (realm == null) throw new PetShopApiException(400, "Missing required parameter 'realm' when calling DeleteFederatedIdentity");
        // verify the required parameter 'id' is set
        if (id == null) throw new PetShopApiException(400, "Missing required parameter 'id' when calling DeleteFederatedIdentity");
        // verify the required parameter 'provider' is set
        if (provider == null) throw new PetShopApiException(400, "Missing required parameter 'provider' when calling DeleteFederatedIdentity");
        
        var path_ = new StringBuilder("/{realm}/users/{id}/federated-identity/{provider}"); 
        path_ = path_.Replace("{realm}", ParameterToString(realm));
        path_ = path_.Replace("{id}", ParameterToString(id));
        path_ = path_.Replace("{provider}", ParameterToString(provider));

        
        
        await CallApi(
                    path_.ToString(), 
                    HttpMethod.Delete,  
                    ct: ct
        );
    }

    /// <inheritdoc />     
    public async Task DeleteUserByRealmById(string realm, string id, CancellationToken ct)
    {
        // verify the required parameter 'realm' is set
        if (realm == null) throw new PetShopApiException(400, "Missing required parameter 'realm' when calling DeleteUserByRealmById");
        // verify the required parameter 'id' is set
        if (id == null) throw new PetShopApiException(400, "Missing required parameter 'id' when calling DeleteUserByRealmById");
        
        var path_ = new StringBuilder("/{realm}/users/{id}"); 
        path_ = path_.Replace("{realm}", ParameterToString(realm));
        path_ = path_.Replace("{id}", ParameterToString(id));

        
        
        await CallApi(
                    path_.ToString(), 
                    HttpMethod.Delete,  
                    ct: ct
        );
    }

    /// <inheritdoc />     
    public async Task DeleteUserGroup(string realm, string id, string groupId, CancellationToken ct)
    {
        // verify the required parameter 'realm' is set
        if (realm == null) throw new PetShopApiException(400, "Missing required parameter 'realm' when calling DeleteUserGroup");
        // verify the required parameter 'id' is set
        if (id == null) throw new PetShopApiException(400, "Missing required parameter 'id' when calling DeleteUserGroup");
        // verify the required parameter 'groupId' is set
        if (groupId == null) throw new PetShopApiException(400, "Missing required parameter 'groupId' when calling DeleteUserGroup");
        
        var path_ = new StringBuilder("/{realm}/users/{id}/groups/{groupId}"); 
        path_ = path_.Replace("{realm}", ParameterToString(realm));
        path_ = path_.Replace("{id}", ParameterToString(id));
        path_ = path_.Replace("{groupId}", ParameterToString(groupId));

        
        
        await CallApi(
                    path_.ToString(), 
                    HttpMethod.Delete,  
                    ct: ct
        );
    }

    /// <inheritdoc />     
    public async Task<List<string>> GetConfiguredUserStorageCredentialTypes(string realm, string id, CancellationToken ct)
    {
        // verify the required parameter 'realm' is set
        if (realm == null) throw new PetShopApiException(400, "Missing required parameter 'realm' when calling GetConfiguredUserStorageCredentialTypes");
        // verify the required parameter 'id' is set
        if (id == null) throw new PetShopApiException(400, "Missing required parameter 'id' when calling GetConfiguredUserStorageCredentialTypes");
        
        var path_ = new StringBuilder("/{realm}/users/{id}/configured-user-storage-credential-types"); 
        path_ = path_.Replace("{realm}", ParameterToString(realm));
        path_ = path_.Replace("{id}", ParameterToString(id));

        
        
        var response = await CallApi<List<string>>(
                    path_.ToString(), 
                    HttpMethod.Get,  
                    ct: ct
        );
        return response;
    }

    /// <inheritdoc />     
    public async Task<List<Object>> GetConsents(string realm, string id, CancellationToken ct)
    {
        // verify the required parameter 'realm' is set
        if (realm == null) throw new PetShopApiException(400, "Missing required parameter 'realm' when calling GetConsents");
        // verify the required parameter 'id' is set
        if (id == null) throw new PetShopApiException(400, "Missing required parameter 'id' when calling GetConsents");
        
        var path_ = new StringBuilder("/{realm}/users/{id}/consents"); 
        path_ = path_.Replace("{realm}", ParameterToString(realm));
        path_ = path_.Replace("{id}", ParameterToString(id));

        
        
        var response = await CallApi<List<Object>>(
                    path_.ToString(), 
                    HttpMethod.Get,  
                    ct: ct
        );
        return response;
    }

    /// <inheritdoc />     
    public async Task<List<CredentialRepresentation>> GetCredentials(string realm, string id, CancellationToken ct)
    {
        // verify the required parameter 'realm' is set
        if (realm == null) throw new PetShopApiException(400, "Missing required parameter 'realm' when calling GetCredentials");
        // verify the required parameter 'id' is set
        if (id == null) throw new PetShopApiException(400, "Missing required parameter 'id' when calling GetCredentials");
        
        var path_ = new StringBuilder("/{realm}/users/{id}/credentials"); 
        path_ = path_.Replace("{realm}", ParameterToString(realm));
        path_ = path_.Replace("{id}", ParameterToString(id));

        
        
        var response = await CallApi<List<CredentialRepresentation>>(
                    path_.ToString(), 
                    HttpMethod.Get,  
                    ct: ct
        );
        return response;
    }

    /// <inheritdoc />     
    public async Task<List<FederatedIdentityRepresentation>> GetFederatedIdentity(string realm, string id, CancellationToken ct)
    {
        // verify the required parameter 'realm' is set
        if (realm == null) throw new PetShopApiException(400, "Missing required parameter 'realm' when calling GetFederatedIdentity");
        // verify the required parameter 'id' is set
        if (id == null) throw new PetShopApiException(400, "Missing required parameter 'id' when calling GetFederatedIdentity");
        
        var path_ = new StringBuilder("/{realm}/users/{id}/federated-identity"); 
        path_ = path_.Replace("{realm}", ParameterToString(realm));
        path_ = path_.Replace("{id}", ParameterToString(id));

        
        
        var response = await CallApi<List<FederatedIdentityRepresentation>>(
                    path_.ToString(), 
                    HttpMethod.Get,  
                    ct: ct
        );
        return response;
    }

    /// <inheritdoc />     
    public async Task<UserProfileMetadata> GetMetadata(string realm, CancellationToken ct)
    {
        // verify the required parameter 'realm' is set
        if (realm == null) throw new PetShopApiException(400, "Missing required parameter 'realm' when calling GetMetadata");
        
        var path_ = new StringBuilder("/{realm}/users/profile/metadata"); 
        path_ = path_.Replace("{realm}", ParameterToString(realm));

        
        
        var response = await CallApi<UserProfileMetadata>(
                    path_.ToString(), 
                    HttpMethod.Get,  
                    ct: ct
        );
        return response;
    }

    /// <inheritdoc />     
    public async Task<List<UserSessionRepresentation>> GetOfflineSession(string realm, string id, string clientUuid, CancellationToken ct)
    {
        // verify the required parameter 'realm' is set
        if (realm == null) throw new PetShopApiException(400, "Missing required parameter 'realm' when calling GetOfflineSession");
        // verify the required parameter 'id' is set
        if (id == null) throw new PetShopApiException(400, "Missing required parameter 'id' when calling GetOfflineSession");
        // verify the required parameter 'clientUuid' is set
        if (clientUuid == null) throw new PetShopApiException(400, "Missing required parameter 'clientUuid' when calling GetOfflineSession");
        
        var path_ = new StringBuilder("/{realm}/users/{id}/offline-sessions/{clientUuid}"); 
        path_ = path_.Replace("{realm}", ParameterToString(realm));
        path_ = path_.Replace("{id}", ParameterToString(id));
        path_ = path_.Replace("{clientUuid}", ParameterToString(clientUuid));

        
        
        var response = await CallApi<List<UserSessionRepresentation>>(
                    path_.ToString(), 
                    HttpMethod.Get,  
                    ct: ct
        );
        return response;
    }

    /// <inheritdoc />     
    public async Task<UPConfig> GetProfile(string realm, CancellationToken ct)
    {
        // verify the required parameter 'realm' is set
        if (realm == null) throw new PetShopApiException(400, "Missing required parameter 'realm' when calling GetProfile");
        
        var path_ = new StringBuilder("/{realm}/users/profile"); 
        path_ = path_.Replace("{realm}", ParameterToString(realm));

        
        
        var response = await CallApi<UPConfig>(
                    path_.ToString(), 
                    HttpMethod.Get,  
                    ct: ct
        );
        return response;
    }

    /// <inheritdoc />     
    public async Task<List<UserSessionRepresentation>> GetSessions(string realm, string id, CancellationToken ct)
    {
        // verify the required parameter 'realm' is set
        if (realm == null) throw new PetShopApiException(400, "Missing required parameter 'realm' when calling GetSessions");
        // verify the required parameter 'id' is set
        if (id == null) throw new PetShopApiException(400, "Missing required parameter 'id' when calling GetSessions");
        
        var path_ = new StringBuilder("/{realm}/users/{id}/sessions"); 
        path_ = path_.Replace("{realm}", ParameterToString(realm));
        path_ = path_.Replace("{id}", ParameterToString(id));

        
        
        var response = await CallApi<List<UserSessionRepresentation>>(
                    path_.ToString(), 
                    HttpMethod.Get,  
                    ct: ct
        );
        return response;
    }

    /// <inheritdoc />     
    public async Task<UserRepresentation> GetUserByRealmById(string realm, string id, string userProfileMetadata, CancellationToken ct)
    {
        // verify the required parameter 'realm' is set
        if (realm == null) throw new PetShopApiException(400, "Missing required parameter 'realm' when calling GetUserByRealmById");
        // verify the required parameter 'id' is set
        if (id == null) throw new PetShopApiException(400, "Missing required parameter 'id' when calling GetUserByRealmById");
        
        var path_ = new StringBuilder("/{realm}/users/{id}"); 
        path_ = path_.Replace("{realm}", ParameterToString(realm));
        path_ = path_.Replace("{id}", ParameterToString(id));

        var queryParams = new Dictionary<string, string>();
         
        if (userProfileMetadata != null) queryParams.Add("userProfileMetadata", ParameterToString(userProfileMetadata)); // query parameter
        
        var response = await CallApi<UserRepresentation>(
                    path_.ToString(), 
                    HttpMethod.Get,
                    queryParams: queryParams,  
                    ct: ct
        );
        return response;
    }

    /// <inheritdoc />     
    public async Task<List<GroupRepresentation>> GetUserGroups(string realm, string id, string briefRepresentation, string first, string max, string search, CancellationToken ct)
    {
        // verify the required parameter 'realm' is set
        if (realm == null) throw new PetShopApiException(400, "Missing required parameter 'realm' when calling GetUserGroups");
        // verify the required parameter 'id' is set
        if (id == null) throw new PetShopApiException(400, "Missing required parameter 'id' when calling GetUserGroups");
        
        var path_ = new StringBuilder("/{realm}/users/{id}/groups"); 
        path_ = path_.Replace("{realm}", ParameterToString(realm));
        path_ = path_.Replace("{id}", ParameterToString(id));

        var queryParams = new Dictionary<string, string>();
         
        if (briefRepresentation != null) queryParams.Add("briefRepresentation", ParameterToString(briefRepresentation)); // query parameter 
        if (first != null) queryParams.Add("first", ParameterToString(first)); // query parameter 
        if (max != null) queryParams.Add("max", ParameterToString(max)); // query parameter 
        if (search != null) queryParams.Add("search", ParameterToString(search)); // query parameter
        
        var response = await CallApi<List<GroupRepresentation>>(
                    path_.ToString(), 
                    HttpMethod.Get,
                    queryParams: queryParams,  
                    ct: ct
        );
        return response;
    }

    /// <inheritdoc />     
    public async Task<Dictionary<string, long?>> GetUserGroupsCount(string realm, string id, string search, CancellationToken ct)
    {
        // verify the required parameter 'realm' is set
        if (realm == null) throw new PetShopApiException(400, "Missing required parameter 'realm' when calling GetUserGroupsCount");
        // verify the required parameter 'id' is set
        if (id == null) throw new PetShopApiException(400, "Missing required parameter 'id' when calling GetUserGroupsCount");
        
        var path_ = new StringBuilder("/{realm}/users/{id}/groups/count"); 
        path_ = path_.Replace("{realm}", ParameterToString(realm));
        path_ = path_.Replace("{id}", ParameterToString(id));

        var queryParams = new Dictionary<string, string>();
         
        if (search != null) queryParams.Add("search", ParameterToString(search)); // query parameter
        
        var response = await CallApi<Dictionary<string, long?>>(
                    path_.ToString(), 
                    HttpMethod.Get,
                    queryParams: queryParams,  
                    ct: ct
        );
        return response;
    }

    /// <inheritdoc />     
    public async Task<List<UserRepresentation>> GetUsersByRealm(string realm, string briefRepresentation, string email, string emailVerified, string enabled, string exact, string first, string firstName, string idpAlias, string idpUserId, string lastName, string max, string q, string search, string username, CancellationToken ct)
    {
        // verify the required parameter 'realm' is set
        if (realm == null) throw new PetShopApiException(400, "Missing required parameter 'realm' when calling GetUsersByRealm");
        
        var path_ = new StringBuilder("/{realm}/users"); 
        path_ = path_.Replace("{realm}", ParameterToString(realm));

        var queryParams = new Dictionary<string, string>();
         
        if (briefRepresentation != null) queryParams.Add("briefRepresentation", ParameterToString(briefRepresentation)); // query parameter 
        if (email != null) queryParams.Add("email", ParameterToString(email)); // query parameter 
        if (emailVerified != null) queryParams.Add("emailVerified", ParameterToString(emailVerified)); // query parameter 
        if (enabled != null) queryParams.Add("enabled", ParameterToString(enabled)); // query parameter 
        if (exact != null) queryParams.Add("exact", ParameterToString(exact)); // query parameter 
        if (first != null) queryParams.Add("first", ParameterToString(first)); // query parameter 
        if (firstName != null) queryParams.Add("firstName", ParameterToString(firstName)); // query parameter 
        if (idpAlias != null) queryParams.Add("idpAlias", ParameterToString(idpAlias)); // query parameter 
        if (idpUserId != null) queryParams.Add("idpUserId", ParameterToString(idpUserId)); // query parameter 
        if (lastName != null) queryParams.Add("lastName", ParameterToString(lastName)); // query parameter 
        if (max != null) queryParams.Add("max", ParameterToString(max)); // query parameter 
        if (q != null) queryParams.Add("q", ParameterToString(q)); // query parameter 
        if (search != null) queryParams.Add("search", ParameterToString(search)); // query parameter 
        if (username != null) queryParams.Add("username", ParameterToString(username)); // query parameter
        
        var response = await CallApi<List<UserRepresentation>>(
                    path_.ToString(), 
                    HttpMethod.Get,
                    queryParams: queryParams,  
                    ct: ct
        );
        return response;
    }

    /// <inheritdoc />     
    public async Task<int?> GetUsersCount(string realm, string email, string emailVerified, string enabled, string firstName, string lastName, string q, string search, string username, CancellationToken ct)
    {
        // verify the required parameter 'realm' is set
        if (realm == null) throw new PetShopApiException(400, "Missing required parameter 'realm' when calling GetUsersCount");
        
        var path_ = new StringBuilder("/{realm}/users/count"); 
        path_ = path_.Replace("{realm}", ParameterToString(realm));

        var queryParams = new Dictionary<string, string>();
         
        if (email != null) queryParams.Add("email", ParameterToString(email)); // query parameter 
        if (emailVerified != null) queryParams.Add("emailVerified", ParameterToString(emailVerified)); // query parameter 
        if (enabled != null) queryParams.Add("enabled", ParameterToString(enabled)); // query parameter 
        if (firstName != null) queryParams.Add("firstName", ParameterToString(firstName)); // query parameter 
        if (lastName != null) queryParams.Add("lastName", ParameterToString(lastName)); // query parameter 
        if (q != null) queryParams.Add("q", ParameterToString(q)); // query parameter 
        if (search != null) queryParams.Add("search", ParameterToString(search)); // query parameter 
        if (username != null) queryParams.Add("username", ParameterToString(username)); // query parameter
        
        var response = await CallApi<int?>(
                    path_.ToString(), 
                    HttpMethod.Get,
                    queryParams: queryParams,  
                    ct: ct
        );
        return response;
    }

    /// <inheritdoc />     
    public async Task PostFederatedIdentity(string realm, string id, string provider, CancellationToken ct)
    {
        // verify the required parameter 'realm' is set
        if (realm == null) throw new PetShopApiException(400, "Missing required parameter 'realm' when calling PostFederatedIdentity");
        // verify the required parameter 'id' is set
        if (id == null) throw new PetShopApiException(400, "Missing required parameter 'id' when calling PostFederatedIdentity");
        // verify the required parameter 'provider' is set
        if (provider == null) throw new PetShopApiException(400, "Missing required parameter 'provider' when calling PostFederatedIdentity");
        
        var path_ = new StringBuilder("/{realm}/users/{id}/federated-identity/{provider}"); 
        path_ = path_.Replace("{realm}", ParameterToString(realm));
        path_ = path_.Replace("{id}", ParameterToString(id));
        path_ = path_.Replace("{provider}", ParameterToString(provider));

        
        
        await CallApi(
                    path_.ToString(), 
                    HttpMethod.Post,  
                    ct: ct
        );
    }

    /// <inheritdoc />     
    public async Task<Dictionary<string, Object>> PostImpersonation(string realm, string id, CancellationToken ct)
    {
        // verify the required parameter 'realm' is set
        if (realm == null) throw new PetShopApiException(400, "Missing required parameter 'realm' when calling PostImpersonation");
        // verify the required parameter 'id' is set
        if (id == null) throw new PetShopApiException(400, "Missing required parameter 'id' when calling PostImpersonation");
        
        var path_ = new StringBuilder("/{realm}/users/{id}/impersonation"); 
        path_ = path_.Replace("{realm}", ParameterToString(realm));
        path_ = path_.Replace("{id}", ParameterToString(id));

        
        
        var response = await CallApi<Dictionary<string, Object>>(
                    path_.ToString(), 
                    HttpMethod.Post,  
                    ct: ct
        );
        return response;
    }

    /// <inheritdoc />     
    public async Task PostLogout(string realm, string id, CancellationToken ct)
    {
        // verify the required parameter 'realm' is set
        if (realm == null) throw new PetShopApiException(400, "Missing required parameter 'realm' when calling PostLogout");
        // verify the required parameter 'id' is set
        if (id == null) throw new PetShopApiException(400, "Missing required parameter 'id' when calling PostLogout");
        
        var path_ = new StringBuilder("/{realm}/users/{id}/logout"); 
        path_ = path_.Replace("{realm}", ParameterToString(realm));
        path_ = path_.Replace("{id}", ParameterToString(id));

        
        
        await CallApi(
                    path_.ToString(), 
                    HttpMethod.Post,  
                    ct: ct
        );
    }

    /// <inheritdoc />     
    public async Task PostMoveAfter(string realm, string id, string credentialId, string newPreviousCredentialId, CancellationToken ct)
    {
        // verify the required parameter 'realm' is set
        if (realm == null) throw new PetShopApiException(400, "Missing required parameter 'realm' when calling PostMoveAfter");
        // verify the required parameter 'id' is set
        if (id == null) throw new PetShopApiException(400, "Missing required parameter 'id' when calling PostMoveAfter");
        // verify the required parameter 'credentialId' is set
        if (credentialId == null) throw new PetShopApiException(400, "Missing required parameter 'credentialId' when calling PostMoveAfter");
        // verify the required parameter 'newPreviousCredentialId' is set
        if (newPreviousCredentialId == null) throw new PetShopApiException(400, "Missing required parameter 'newPreviousCredentialId' when calling PostMoveAfter");
        
        var path_ = new StringBuilder("/{realm}/users/{id}/credentials/{credentialId}/moveAfter/{newPreviousCredentialId}"); 
        path_ = path_.Replace("{realm}", ParameterToString(realm));
        path_ = path_.Replace("{id}", ParameterToString(id));
        path_ = path_.Replace("{credentialId}", ParameterToString(credentialId));
        path_ = path_.Replace("{newPreviousCredentialId}", ParameterToString(newPreviousCredentialId));

        
        
        await CallApi(
                    path_.ToString(), 
                    HttpMethod.Post,  
                    ct: ct
        );
    }

    /// <inheritdoc />     
    public async Task PostMoveToFirst(string realm, string id, string credentialId, CancellationToken ct)
    {
        // verify the required parameter 'realm' is set
        if (realm == null) throw new PetShopApiException(400, "Missing required parameter 'realm' when calling PostMoveToFirst");
        // verify the required parameter 'id' is set
        if (id == null) throw new PetShopApiException(400, "Missing required parameter 'id' when calling PostMoveToFirst");
        // verify the required parameter 'credentialId' is set
        if (credentialId == null) throw new PetShopApiException(400, "Missing required parameter 'credentialId' when calling PostMoveToFirst");
        
        var path_ = new StringBuilder("/{realm}/users/{id}/credentials/{credentialId}/moveToFirst"); 
        path_ = path_.Replace("{realm}", ParameterToString(realm));
        path_ = path_.Replace("{id}", ParameterToString(id));
        path_ = path_.Replace("{credentialId}", ParameterToString(credentialId));

        
        
        await CallApi(
                    path_.ToString(), 
                    HttpMethod.Post,  
                    ct: ct
        );
    }

    /// <inheritdoc />     
    public async Task PostUsers(string realm, UserRepresentation body, CancellationToken ct)
    {
        // verify the required parameter 'realm' is set
        if (realm == null) throw new PetShopApiException(400, "Missing required parameter 'realm' when calling PostUsers");
        
        var path_ = new StringBuilder("/{realm}/users"); 
        path_ = path_.Replace("{realm}", ParameterToString(realm));

        
        
        await CallApi(
                    path_.ToString(), 
                    HttpMethod.Post,
                    body: body,   
                    ct: ct
        );
    }

    /// <inheritdoc />     
    public async Task PutDisableCredentialTypes(string realm, string id, string body, CancellationToken ct)
    {
        // verify the required parameter 'realm' is set
        if (realm == null) throw new PetShopApiException(400, "Missing required parameter 'realm' when calling PutDisableCredentialTypes");
        // verify the required parameter 'id' is set
        if (id == null) throw new PetShopApiException(400, "Missing required parameter 'id' when calling PutDisableCredentialTypes");
        
        var path_ = new StringBuilder("/{realm}/users/{id}/disable-credential-types"); 
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
    public async Task PutExecuteActionsEmail(string realm, string id, string body, string clientId, string lifespan, string redirectUri, CancellationToken ct)
    {
        // verify the required parameter 'realm' is set
        if (realm == null) throw new PetShopApiException(400, "Missing required parameter 'realm' when calling PutExecuteActionsEmail");
        // verify the required parameter 'id' is set
        if (id == null) throw new PetShopApiException(400, "Missing required parameter 'id' when calling PutExecuteActionsEmail");
        
        var path_ = new StringBuilder("/{realm}/users/{id}/execute-actions-email"); 
        path_ = path_.Replace("{realm}", ParameterToString(realm));
        path_ = path_.Replace("{id}", ParameterToString(id));

        var queryParams = new Dictionary<string, string>();
         
        if (clientId != null) queryParams.Add("client_id", ParameterToString(clientId)); // query parameter 
        if (lifespan != null) queryParams.Add("lifespan", ParameterToString(lifespan)); // query parameter 
        if (redirectUri != null) queryParams.Add("redirect_uri", ParameterToString(redirectUri)); // query parameter
        
        await CallApi(
                    path_.ToString(), 
                    HttpMethod.Put,
                    queryParams: queryParams,
                    body: body,   
                    ct: ct
        );
    }

    /// <inheritdoc />     
    public async Task<UPConfig> PutProfile(string realm, UPConfig body, CancellationToken ct)
    {
        // verify the required parameter 'realm' is set
        if (realm == null) throw new PetShopApiException(400, "Missing required parameter 'realm' when calling PutProfile");
        
        var path_ = new StringBuilder("/{realm}/users/profile"); 
        path_ = path_.Replace("{realm}", ParameterToString(realm));

        
        
        var response = await CallApi<UPConfig>(
                    path_.ToString(), 
                    HttpMethod.Put,
                    body: body,   
                    ct: ct
        );
        return response;
    }

    /// <inheritdoc />     
    public async Task PutResetPassword(string realm, string id, CredentialRepresentation body, CancellationToken ct)
    {
        // verify the required parameter 'realm' is set
        if (realm == null) throw new PetShopApiException(400, "Missing required parameter 'realm' when calling PutResetPassword");
        // verify the required parameter 'id' is set
        if (id == null) throw new PetShopApiException(400, "Missing required parameter 'id' when calling PutResetPassword");
        
        var path_ = new StringBuilder("/{realm}/users/{id}/reset-password"); 
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
    public async Task PutResetPasswordEmail(string realm, string id, string clientId, string redirectUri, CancellationToken ct)
    {
        // verify the required parameter 'realm' is set
        if (realm == null) throw new PetShopApiException(400, "Missing required parameter 'realm' when calling PutResetPasswordEmail");
        // verify the required parameter 'id' is set
        if (id == null) throw new PetShopApiException(400, "Missing required parameter 'id' when calling PutResetPasswordEmail");
        
        var path_ = new StringBuilder("/{realm}/users/{id}/reset-password-email"); 
        path_ = path_.Replace("{realm}", ParameterToString(realm));
        path_ = path_.Replace("{id}", ParameterToString(id));

        var queryParams = new Dictionary<string, string>();
         
        if (clientId != null) queryParams.Add("client_id", ParameterToString(clientId)); // query parameter 
        if (redirectUri != null) queryParams.Add("redirect_uri", ParameterToString(redirectUri)); // query parameter
        
        await CallApi(
                    path_.ToString(), 
                    HttpMethod.Put,
                    queryParams: queryParams,  
                    ct: ct
        );
    }

    /// <inheritdoc />     
    public async Task PutSendVerifyEmail(string realm, string id, string clientId, string redirectUri, CancellationToken ct)
    {
        // verify the required parameter 'realm' is set
        if (realm == null) throw new PetShopApiException(400, "Missing required parameter 'realm' when calling PutSendVerifyEmail");
        // verify the required parameter 'id' is set
        if (id == null) throw new PetShopApiException(400, "Missing required parameter 'id' when calling PutSendVerifyEmail");
        
        var path_ = new StringBuilder("/{realm}/users/{id}/send-verify-email"); 
        path_ = path_.Replace("{realm}", ParameterToString(realm));
        path_ = path_.Replace("{id}", ParameterToString(id));

        var queryParams = new Dictionary<string, string>();
         
        if (clientId != null) queryParams.Add("client_id", ParameterToString(clientId)); // query parameter 
        if (redirectUri != null) queryParams.Add("redirect_uri", ParameterToString(redirectUri)); // query parameter
        
        await CallApi(
                    path_.ToString(), 
                    HttpMethod.Put,
                    queryParams: queryParams,  
                    ct: ct
        );
    }

    /// <inheritdoc />     
    public async Task PutUser(string realm, string id, UserRepresentation body, CancellationToken ct)
    {
        // verify the required parameter 'realm' is set
        if (realm == null) throw new PetShopApiException(400, "Missing required parameter 'realm' when calling PutUser");
        // verify the required parameter 'id' is set
        if (id == null) throw new PetShopApiException(400, "Missing required parameter 'id' when calling PutUser");
        
        var path_ = new StringBuilder("/{realm}/users/{id}"); 
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
    public async Task PutUserGroup(string realm, string id, string groupId, CancellationToken ct)
    {
        // verify the required parameter 'realm' is set
        if (realm == null) throw new PetShopApiException(400, "Missing required parameter 'realm' when calling PutUserGroup");
        // verify the required parameter 'id' is set
        if (id == null) throw new PetShopApiException(400, "Missing required parameter 'id' when calling PutUserGroup");
        // verify the required parameter 'groupId' is set
        if (groupId == null) throw new PetShopApiException(400, "Missing required parameter 'groupId' when calling PutUserGroup");
        
        var path_ = new StringBuilder("/{realm}/users/{id}/groups/{groupId}"); 
        path_ = path_.Replace("{realm}", ParameterToString(realm));
        path_ = path_.Replace("{id}", ParameterToString(id));
        path_ = path_.Replace("{groupId}", ParameterToString(groupId));

        
        
        await CallApi(
                    path_.ToString(), 
                    HttpMethod.Put,  
                    ct: ct
        );
    }

    /// <inheritdoc />     
    public async Task PutUserLabel(string realm, string id, string credentialId, string body, CancellationToken ct)
    {
        // verify the required parameter 'realm' is set
        if (realm == null) throw new PetShopApiException(400, "Missing required parameter 'realm' when calling PutUserLabel");
        // verify the required parameter 'id' is set
        if (id == null) throw new PetShopApiException(400, "Missing required parameter 'id' when calling PutUserLabel");
        // verify the required parameter 'credentialId' is set
        if (credentialId == null) throw new PetShopApiException(400, "Missing required parameter 'credentialId' when calling PutUserLabel");
        
        var path_ = new StringBuilder("/{realm}/users/{id}/credentials/{credentialId}/userLabel"); 
        path_ = path_.Replace("{realm}", ParameterToString(realm));
        path_ = path_.Replace("{id}", ParameterToString(id));
        path_ = path_.Replace("{credentialId}", ParameterToString(credentialId));

        
        
        await CallApi(
                    path_.ToString(), 
                    HttpMethod.Put,
                    body: body,   
                    ct: ct
        );
    }

}
