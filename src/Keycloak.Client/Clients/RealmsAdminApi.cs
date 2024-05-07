using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading;
using System.Text;
using System.Threading.Tasks;
using System.CodeDom.Compiler;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace IO.Swagger.Api;

/// <summary>
/// Represents a collection of functions to interact with the API endpoints
/// </summary>
[GeneratedCode("swagger-codegen", "3.0.56-SNAPSHOT")]
public partial interface IRealmsAdminApi
{
    /// <summary>
    ///  Delete all admin events
    /// </summary>
    /// <param name="realm">realm name (not id!)</param>
    /// <param name="ct"></param>
    /// <param name="ct">Operation cancellation token. </param>
    /// <returns></returns>
    Task DeleteAdminEvents (string realm, CancellationToken ct);
    /// <summary>
    ///  Delete the realm
    /// </summary>
    /// <param name="realm">realm name (not id!)</param>
    /// <param name="ct"></param>
    /// <param name="ct">Operation cancellation token. </param>
    /// <returns></returns>
    Task DeleteByRealm (string realm, CancellationToken ct);
    /// <summary>
    ///  
    /// </summary>
    /// <param name="realm">realm name (not id!)</param>
    /// <param name="clientScopeId"></param>
    /// <param name="ct"></param>
    /// <param name="ct">Operation cancellation token. </param>
    /// <returns></returns>
    Task DeleteDefaultDefaultClientScope (string realm, string clientScopeId, CancellationToken ct);
    /// <summary>
    ///  
    /// </summary>
    /// <param name="realm">realm name (not id!)</param>
    /// <param name="groupId"></param>
    /// <param name="ct"></param>
    /// <param name="ct">Operation cancellation token. </param>
    /// <returns></returns>
    Task DeleteDefaultGroup (string realm, string groupId, CancellationToken ct);
    /// <summary>
    ///  
    /// </summary>
    /// <param name="realm">realm name (not id!)</param>
    /// <param name="clientScopeId"></param>
    /// <param name="ct"></param>
    /// <param name="ct">Operation cancellation token. </param>
    /// <returns></returns>
    Task DeleteDefaultOptionalClientScope (string realm, string clientScopeId, CancellationToken ct);
    /// <summary>
    ///  Delete all events
    /// </summary>
    /// <param name="realm">realm name (not id!)</param>
    /// <param name="ct"></param>
    /// <param name="ct">Operation cancellation token. </param>
    /// <returns></returns>
    Task DeleteEvents (string realm, CancellationToken ct);
    /// <summary>
    ///  
    /// </summary>
    /// <param name="realm">realm name (not id!)</param>
    /// <param name="locale"></param>
    /// <param name="ct"></param>
    /// <param name="ct">Operation cancellation token. </param>
    /// <returns></returns>
    Task DeleteLocalizationByRealmByLocale (string realm, string locale, CancellationToken ct);
    /// <summary>
    ///  
    /// </summary>
    /// <param name="realm">realm name (not id!)</param>
    /// <param name="locale"></param>
    /// <param name="key"></param>
    /// <param name="ct"></param>
    /// <param name="ct">Operation cancellation token. </param>
    /// <returns></returns>
    Task DeleteLocalizationByRealmByLocaleByKey (string realm, string locale, string key, CancellationToken ct);
    /// <summary>
    ///  Remove a specific user session.
    /// </summary>
    /// <param name="realm">realm name (not id!)</param>
    /// <param name="session"></param>
    /// <param name="ct"></param>
    /// <param name="ct">Operation cancellation token. </param>
    /// <returns></returns>
    Task DeleteSession (string realm, string session, CancellationToken ct);
    /// <summary>
    ///  Get accessible realms Returns a list of accessible realms. The list is filtered based on what realms the caller is allowed to view.
    /// </summary>
    /// <param name="briefRepresentation"></param>
    /// <param name="ct"></param>
    /// <param name="ct">Operation cancellation token. </param>
    /// <returns>List&lt;RealmRepresentation&gt;</returns>
    Task<List<RealmRepresentation>> Get (string briefRepresentation, CancellationToken ct);
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
    /// <param name="ct"></param>
    /// <param name="ct">Operation cancellation token. </param>
    /// <returns>List&lt;AdminEventRepresentation&gt;</returns>
    Task<List<AdminEventRepresentation>> GetAdminEvents (string realm, string authClient, string authIpAddress, string authRealm, string authUser, string dateFrom, string dateTo, string first, string max, string operationTypes, string resourcePath, string resourceTypes, CancellationToken ct);
    /// <summary>
    ///  Get the top-level representation of the realm It will not include nested information like User and Client representations.
    /// </summary>
    /// <param name="realm">realm name (not id!)</param>
    /// <param name="ct"></param>
    /// <param name="ct">Operation cancellation token. </param>
    /// <returns>RealmRepresentation</returns>
    Task<RealmRepresentation> GetByRealm (string realm, CancellationToken ct);
    /// <summary>
    ///  Get client session stats Returns a JSON map.
    /// </summary>
    /// <param name="realm">realm name (not id!)</param>
    /// <param name="ct"></param>
    /// <param name="ct">Operation cancellation token. </param>
    /// <returns>List&lt;string&gt;</returns>
    Task<List<string>> GetClientSessionStats (string realm, CancellationToken ct);
    /// <summary>
    ///  
    /// </summary>
    /// <param name="realm">realm name (not id!)</param>
    /// <param name="ct"></param>
    /// <param name="ct">Operation cancellation token. </param>
    /// <returns>List&lt;string&gt;</returns>
    Task<List<string>> GetCredentialRegistrators (string realm, CancellationToken ct);
    /// <summary>
    ///  Get realm default client scopes.  Only name and ids are returned.
    /// </summary>
    /// <param name="realm">realm name (not id!)</param>
    /// <param name="ct"></param>
    /// <param name="ct">Operation cancellation token. </param>
    /// <returns>List&lt;ClientScopeRepresentation&gt;</returns>
    Task<List<ClientScopeRepresentation>> GetDefaultDefaultClientScopes (string realm, CancellationToken ct);
    /// <summary>
    ///  Get group hierarchy.  Only name and ids are returned.
    /// </summary>
    /// <param name="realm">realm name (not id!)</param>
    /// <param name="ct"></param>
    /// <param name="ct">Operation cancellation token. </param>
    /// <returns>List&lt;GroupRepresentation&gt;</returns>
    Task<List<GroupRepresentation>> GetDefaultGroups (string realm, CancellationToken ct);
    /// <summary>
    ///  Get realm optional client scopes.  Only name and ids are returned.
    /// </summary>
    /// <param name="realm">realm name (not id!)</param>
    /// <param name="ct"></param>
    /// <param name="ct">Operation cancellation token. </param>
    /// <returns>List&lt;ClientScopeRepresentation&gt;</returns>
    Task<List<ClientScopeRepresentation>> GetDefaultOptionalClientScopes (string realm, CancellationToken ct);
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
    /// <param name="ct"></param>
    /// <param name="ct">Operation cancellation token. </param>
    /// <returns>List&lt;EventRepresentation&gt;</returns>
    Task<List<EventRepresentation>> GetEvents (string realm, string _client, string dateFrom, string dateTo, string first, string ipAddress, string max, string type, string user, CancellationToken ct);
    /// <summary>
    ///  Get the events provider configuration Returns JSON object with events provider configuration
    /// </summary>
    /// <param name="realm">realm name (not id!)</param>
    /// <param name="ct"></param>
    /// <param name="ct">Operation cancellation token. </param>
    /// <returns>RealmEventsConfigRepresentation</returns>
    Task<RealmEventsConfigRepresentation> GetEventsConfig (string realm, CancellationToken ct);
    /// <summary>
    ///  
    /// </summary>
    /// <param name="realm">realm name (not id!)</param>
    /// <param name="path">PathSegment</param>
    /// <param name="ct"></param>
    /// <param name="ct">Operation cancellation token. </param>
    /// <returns>GroupRepresentation</returns>
    Task<GroupRepresentation> GetGroupByPath (string realm, string path, CancellationToken ct);
    /// <summary>
    ///  
    /// </summary>
    /// <param name="realm">realm name (not id!)</param>
    /// <param name="ct"></param>
    /// <param name="ct">Operation cancellation token. </param>
    /// <returns>List&lt;string&gt;</returns>
    Task<List<string>> GetLocalizationByRealm (string realm, CancellationToken ct);
    /// <summary>
    ///  
    /// </summary>
    /// <param name="realm">realm name (not id!)</param>
    /// <param name="locale"></param>
    /// <param name="useRealmDefaultLocaleFallback"></param>
    /// <param name="ct"></param>
    /// <param name="ct">Operation cancellation token. </param>
    /// <returns>Dictionary&lt;string, string&gt;</returns>
    Task<Dictionary<string, string>> GetLocalizationByRealmByLocale (string realm, string locale, string useRealmDefaultLocaleFallback, CancellationToken ct);
    /// <summary>
    ///  
    /// </summary>
    /// <param name="realm">realm name (not id!)</param>
    /// <param name="locale"></param>
    /// <param name="key"></param>
    /// <param name="ct"></param>
    /// <param name="ct">Operation cancellation token. </param>
    /// <returns>string</returns>
    Task<string> GetLocalizationByRealmByLocaleByKey (string realm, string locale, string key, CancellationToken ct);
    /// <summary>
    ///  
    /// </summary>
    /// <param name="realm">realm name (not id!)</param>
    /// <param name="ct"></param>
    /// <param name="ct">Operation cancellation token. </param>
    /// <returns>ClientPoliciesRepresentation</returns>
    Task<ClientPoliciesRepresentation> GetPolicies (string realm, CancellationToken ct);
    /// <summary>
    ///  
    /// </summary>
    /// <param name="realm">realm name (not id!)</param>
    /// <param name="includeGlobalProfiles"></param>
    /// <param name="ct"></param>
    /// <param name="ct">Operation cancellation token. </param>
    /// <returns>ClientProfilesRepresentation</returns>
    Task<ClientProfilesRepresentation> GetProfiles (string realm, string includeGlobalProfiles, CancellationToken ct);
    /// <summary>
    ///  
    /// </summary>
    /// <param name="realm">realm name (not id!)</param>
    /// <param name="ct"></param>
    /// <param name="ct">Operation cancellation token. </param>
    /// <returns>ManagementPermissionReference</returns>
    Task<ManagementPermissionReference> GetUsersManagementPermissions (string realm, CancellationToken ct);
    /// <summary>
    ///  Import a realm. Imports a realm from a full representation of that realm.
    /// </summary>
    /// <param name="body">[file]</param>
    /// <param name="ct"></param>
    /// <param name="ct">Operation cancellation token. </param>
    /// <returns></returns>
    Task Post (Object body, CancellationToken ct);
    /// <summary>
    ///  Base path for importing clients under this realm.
    /// </summary>
    /// <param name="realm">realm name (not id!)</param>
    /// <param name="body">[string]</param>
    /// <param name="ct"></param>
    /// <param name="ct">Operation cancellation token. </param>
    /// <returns>ClientRepresentation</returns>
    Task<ClientRepresentation> PostClientDescriptionConverter (string realm, string body, CancellationToken ct);
    /// <summary>
    ///  Import localization from uploaded JSON file
    /// </summary>
    /// <param name="realm">realm name (not id!)</param>
    /// <param name="locale"></param>
    /// <param name="body">[string]</param>
    /// <param name="ct"></param>
    /// <param name="ct">Operation cancellation token. </param>
    /// <returns></returns>
    Task PostLocalization (string realm, string locale, string body, CancellationToken ct);
    /// <summary>
    ///  Removes all user sessions.
    /// </summary>
    /// <param name="realm">realm name (not id!)</param>
    /// <param name="ct"></param>
    /// <param name="ct">Operation cancellation token. </param>
    /// <returns>GlobalRequestResult</returns>
    Task<GlobalRequestResult> PostLogoutAll (string realm, CancellationToken ct);
    /// <summary>
    ///  Partial export of existing realm into a JSON file.
    /// </summary>
    /// <param name="realm">realm name (not id!)</param>
    /// <param name="exportClients"></param>
    /// <param name="exportGroupsAndRoles"></param>
    /// <param name="ct"></param>
    /// <param name="ct">Operation cancellation token. </param>
    /// <returns></returns>
    Task PostPartialExport (string realm, string exportClients, string exportGroupsAndRoles, CancellationToken ct);
    /// <summary>
    ///  Partial import from a JSON file to an existing realm.
    /// </summary>
    /// <param name="realm">realm name (not id!)</param>
    /// <param name="body">[file]</param>
    /// <param name="ct"></param>
    /// <param name="ct">Operation cancellation token. </param>
    /// <returns></returns>
    Task PostPartialImport (string realm, Object body, CancellationToken ct);
    /// <summary>
    ///  Push the realm’s revocation policy to any client that has an admin url associated with it.
    /// </summary>
    /// <param name="realm">realm name (not id!)</param>
    /// <param name="ct"></param>
    /// <param name="ct">Operation cancellation token. </param>
    /// <returns>GlobalRequestResult</returns>
    Task<GlobalRequestResult> PostPushRevocationByRealm (string realm, CancellationToken ct);
    /// <summary>
    ///  Test SMTP connection with current logged in user
    /// </summary>
    /// <param name="realm">realm name (not id!)</param>
    /// <param name="body">[string]</param>
    /// <param name="ct"></param>
    /// <param name="ct">Operation cancellation token. </param>
    /// <returns></returns>
    Task PostTestSmtpConnection (string realm, string body, CancellationToken ct);
    /// <summary>
    ///  Update the top-level information of the realm Any user, roles or client information in the representation will be ignored.
    /// </summary>
    /// <param name="realm">realm name (not id!)</param>
    /// <param name="body">RealmRepresentation</param>
    /// <param name="ct"></param>
    /// <param name="ct">Operation cancellation token. </param>
    /// <returns></returns>
    Task PutByRealm (string realm, RealmRepresentation body, CancellationToken ct);
    /// <summary>
    ///  
    /// </summary>
    /// <param name="realm">realm name (not id!)</param>
    /// <param name="clientScopeId"></param>
    /// <param name="ct"></param>
    /// <param name="ct">Operation cancellation token. </param>
    /// <returns></returns>
    Task PutDefaultDefaultClientScope (string realm, string clientScopeId, CancellationToken ct);
    /// <summary>
    ///  
    /// </summary>
    /// <param name="realm">realm name (not id!)</param>
    /// <param name="groupId"></param>
    /// <param name="ct"></param>
    /// <param name="ct">Operation cancellation token. </param>
    /// <returns></returns>
    Task PutDefaultGroup (string realm, string groupId, CancellationToken ct);
    /// <summary>
    ///  
    /// </summary>
    /// <param name="realm">realm name (not id!)</param>
    /// <param name="clientScopeId"></param>
    /// <param name="ct"></param>
    /// <param name="ct">Operation cancellation token. </param>
    /// <returns></returns>
    Task PutDefaultOptionalClientScope (string realm, string clientScopeId, CancellationToken ct);
    /// <summary>
    ///  
    /// </summary>
    /// <param name="realm">realm name (not id!)</param>
    /// <param name="body">RealmEventsConfigRepresentation</param>
    /// <param name="ct"></param>
    /// <param name="ct">Operation cancellation token. </param>
    /// <returns></returns>
    Task PutEventsConfig (string realm, RealmEventsConfigRepresentation body, CancellationToken ct);
    /// <summary>
    ///  
    /// </summary>
    /// <param name="realm">realm name (not id!)</param>
    /// <param name="locale"></param>
    /// <param name="key"></param>
    /// <param name="body">[string]</param>
    /// <param name="ct"></param>
    /// <param name="ct">Operation cancellation token. </param>
    /// <returns></returns>
    Task PutLocalization (string realm, string locale, string key, string body, CancellationToken ct);
    /// <summary>
    ///  
    /// </summary>
    /// <param name="realm">realm name (not id!)</param>
    /// <param name="body">ClientPoliciesRepresentation</param>
    /// <param name="ct"></param>
    /// <param name="ct">Operation cancellation token. </param>
    /// <returns></returns>
    Task PutPolicies (string realm, ClientPoliciesRepresentation body, CancellationToken ct);
    /// <summary>
    ///  
    /// </summary>
    /// <param name="realm">realm name (not id!)</param>
    /// <param name="body">ClientProfilesRepresentation</param>
    /// <param name="ct"></param>
    /// <param name="ct">Operation cancellation token. </param>
    /// <returns></returns>
    Task PutProfiles (string realm, ClientProfilesRepresentation body, CancellationToken ct);
    /// <summary>
    ///  
    /// </summary>
    /// <param name="realm">realm name (not id!)</param>
    /// <param name="body">ManagementPermissionReference</param>
    /// <param name="ct"></param>
    /// <param name="ct">Operation cancellation token. </param>
    /// <returns>ManagementPermissionReference</returns>
    Task<ManagementPermissionReference> PutUsersManagementPermissions (string realm, ManagementPermissionReference body, CancellationToken ct);
}

/// <summary>
/// Represents a collection of functions to interact with the API endpoints
/// </summary>  
[GeneratedCode("swagger-codegen", "3.0.56-SNAPSHOT")]
public partial class RealmsAdminApi : IOSwaggerClientApiClientBase, IRealmsAdminApi
{
    /// <summary>
    /// Initializes a new instance of the <see cref="RealmsAdminApi"/> class.
    /// </summary>
    /// <param name="httpClient"> HttpClient to be used for calls. </param>
    /// <param name="basePath"> Base url to be used for calls. </param>
    public RealmsAdminApi(HttpClient httpClient, String basePath="https://keycloak.example.com/admin/realms") : base(httpClient, basePath)
    {
    }

    /// <inheritdoc />     
    public async Task DeleteAdminEvents(string realm, CancellationToken ct)
    {
        
        // verify the required parameter 'realm' is set
        if (realm == null) throw new IOSwaggerClientApiException(400, "Missing required parameter 'realm' when calling DeleteAdminEvents");
        

        var path_ = new StringBuilder("/{realm}/admin-events");
        path_ = path_.Replace("{realm}", ParameterToString(realm));

        var queryParams = new Dictionary<string, string>();
        var headerParams = new Dictionary<string, string>();
        var formParams = new Dictionary<string, string>();
        var fileParams = new Dictionary<string, FileParameter>();
        object postBody = null;

        
        await CallApi(path_.ToString(), HttpMethod.Delete, queryParams, postBody, headerParams, formParams, fileParams, ct);
    }

    /// <inheritdoc />     
    public async Task DeleteByRealm(string realm, CancellationToken ct)
    {
        
        // verify the required parameter 'realm' is set
        if (realm == null) throw new IOSwaggerClientApiException(400, "Missing required parameter 'realm' when calling DeleteByRealm");
        

        var path_ = new StringBuilder("/{realm}");
        path_ = path_.Replace("{realm}", ParameterToString(realm));

        var queryParams = new Dictionary<string, string>();
        var headerParams = new Dictionary<string, string>();
        var formParams = new Dictionary<string, string>();
        var fileParams = new Dictionary<string, FileParameter>();
        object postBody = null;

        
        await CallApi(path_.ToString(), HttpMethod.Delete, queryParams, postBody, headerParams, formParams, fileParams, ct);
    }

    /// <inheritdoc />     
    public async Task DeleteDefaultDefaultClientScope(string realm, string clientScopeId, CancellationToken ct)
    {
        
        // verify the required parameter 'realm' is set
        if (realm == null) throw new IOSwaggerClientApiException(400, "Missing required parameter 'realm' when calling DeleteDefaultDefaultClientScope");
        
        // verify the required parameter 'clientScopeId' is set
        if (clientScopeId == null) throw new IOSwaggerClientApiException(400, "Missing required parameter 'clientScopeId' when calling DeleteDefaultDefaultClientScope");
        

        var path_ = new StringBuilder("/{realm}/default-default-client-scopes/{clientScopeId}");
        path_ = path_.Replace("{realm}", ParameterToString(realm));
path_ = path_.Replace("{clientScopeId}", ParameterToString(clientScopeId));

        var queryParams = new Dictionary<string, string>();
        var headerParams = new Dictionary<string, string>();
        var formParams = new Dictionary<string, string>();
        var fileParams = new Dictionary<string, FileParameter>();
        object postBody = null;

        
        await CallApi(path_.ToString(), HttpMethod.Delete, queryParams, postBody, headerParams, formParams, fileParams, ct);
    }

    /// <inheritdoc />     
    public async Task DeleteDefaultGroup(string realm, string groupId, CancellationToken ct)
    {
        
        // verify the required parameter 'realm' is set
        if (realm == null) throw new IOSwaggerClientApiException(400, "Missing required parameter 'realm' when calling DeleteDefaultGroup");
        
        // verify the required parameter 'groupId' is set
        if (groupId == null) throw new IOSwaggerClientApiException(400, "Missing required parameter 'groupId' when calling DeleteDefaultGroup");
        

        var path_ = new StringBuilder("/{realm}/default-groups/{groupId}");
        path_ = path_.Replace("{realm}", ParameterToString(realm));
path_ = path_.Replace("{groupId}", ParameterToString(groupId));

        var queryParams = new Dictionary<string, string>();
        var headerParams = new Dictionary<string, string>();
        var formParams = new Dictionary<string, string>();
        var fileParams = new Dictionary<string, FileParameter>();
        object postBody = null;

        
        await CallApi(path_.ToString(), HttpMethod.Delete, queryParams, postBody, headerParams, formParams, fileParams, ct);
    }

    /// <inheritdoc />     
    public async Task DeleteDefaultOptionalClientScope(string realm, string clientScopeId, CancellationToken ct)
    {
        
        // verify the required parameter 'realm' is set
        if (realm == null) throw new IOSwaggerClientApiException(400, "Missing required parameter 'realm' when calling DeleteDefaultOptionalClientScope");
        
        // verify the required parameter 'clientScopeId' is set
        if (clientScopeId == null) throw new IOSwaggerClientApiException(400, "Missing required parameter 'clientScopeId' when calling DeleteDefaultOptionalClientScope");
        

        var path_ = new StringBuilder("/{realm}/default-optional-client-scopes/{clientScopeId}");
        path_ = path_.Replace("{realm}", ParameterToString(realm));
path_ = path_.Replace("{clientScopeId}", ParameterToString(clientScopeId));

        var queryParams = new Dictionary<string, string>();
        var headerParams = new Dictionary<string, string>();
        var formParams = new Dictionary<string, string>();
        var fileParams = new Dictionary<string, FileParameter>();
        object postBody = null;

        
        await CallApi(path_.ToString(), HttpMethod.Delete, queryParams, postBody, headerParams, formParams, fileParams, ct);
    }

    /// <inheritdoc />     
    public async Task DeleteEvents(string realm, CancellationToken ct)
    {
        
        // verify the required parameter 'realm' is set
        if (realm == null) throw new IOSwaggerClientApiException(400, "Missing required parameter 'realm' when calling DeleteEvents");
        

        var path_ = new StringBuilder("/{realm}/events");
        path_ = path_.Replace("{realm}", ParameterToString(realm));

        var queryParams = new Dictionary<string, string>();
        var headerParams = new Dictionary<string, string>();
        var formParams = new Dictionary<string, string>();
        var fileParams = new Dictionary<string, FileParameter>();
        object postBody = null;

        
        await CallApi(path_.ToString(), HttpMethod.Delete, queryParams, postBody, headerParams, formParams, fileParams, ct);
    }

    /// <inheritdoc />     
    public async Task DeleteLocalizationByRealmByLocale(string realm, string locale, CancellationToken ct)
    {
        
        // verify the required parameter 'realm' is set
        if (realm == null) throw new IOSwaggerClientApiException(400, "Missing required parameter 'realm' when calling DeleteLocalizationByRealmByLocale");
        
        // verify the required parameter 'locale' is set
        if (locale == null) throw new IOSwaggerClientApiException(400, "Missing required parameter 'locale' when calling DeleteLocalizationByRealmByLocale");
        

        var path_ = new StringBuilder("/{realm}/localization/{locale}");
        path_ = path_.Replace("{realm}", ParameterToString(realm));
path_ = path_.Replace("{locale}", ParameterToString(locale));

        var queryParams = new Dictionary<string, string>();
        var headerParams = new Dictionary<string, string>();
        var formParams = new Dictionary<string, string>();
        var fileParams = new Dictionary<string, FileParameter>();
        object postBody = null;

        
        await CallApi(path_.ToString(), HttpMethod.Delete, queryParams, postBody, headerParams, formParams, fileParams, ct);
    }

    /// <inheritdoc />     
    public async Task DeleteLocalizationByRealmByLocaleByKey(string realm, string locale, string key, CancellationToken ct)
    {
        
        // verify the required parameter 'realm' is set
        if (realm == null) throw new IOSwaggerClientApiException(400, "Missing required parameter 'realm' when calling DeleteLocalizationByRealmByLocaleByKey");
        
        // verify the required parameter 'locale' is set
        if (locale == null) throw new IOSwaggerClientApiException(400, "Missing required parameter 'locale' when calling DeleteLocalizationByRealmByLocaleByKey");
        
        // verify the required parameter 'key' is set
        if (key == null) throw new IOSwaggerClientApiException(400, "Missing required parameter 'key' when calling DeleteLocalizationByRealmByLocaleByKey");
        

        var path_ = new StringBuilder("/{realm}/localization/{locale}/{key}");
        path_ = path_.Replace("{realm}", ParameterToString(realm));
path_ = path_.Replace("{locale}", ParameterToString(locale));
path_ = path_.Replace("{key}", ParameterToString(key));

        var queryParams = new Dictionary<string, string>();
        var headerParams = new Dictionary<string, string>();
        var formParams = new Dictionary<string, string>();
        var fileParams = new Dictionary<string, FileParameter>();
        object postBody = null;

        
        await CallApi(path_.ToString(), HttpMethod.Delete, queryParams, postBody, headerParams, formParams, fileParams, ct);
    }

    /// <inheritdoc />     
    public async Task DeleteSession(string realm, string session, CancellationToken ct)
    {
        
        // verify the required parameter 'realm' is set
        if (realm == null) throw new IOSwaggerClientApiException(400, "Missing required parameter 'realm' when calling DeleteSession");
        
        // verify the required parameter 'session' is set
        if (session == null) throw new IOSwaggerClientApiException(400, "Missing required parameter 'session' when calling DeleteSession");
        

        var path_ = new StringBuilder("/{realm}/sessions/{session}");
        path_ = path_.Replace("{realm}", ParameterToString(realm));
path_ = path_.Replace("{session}", ParameterToString(session));

        var queryParams = new Dictionary<string, string>();
        var headerParams = new Dictionary<string, string>();
        var formParams = new Dictionary<string, string>();
        var fileParams = new Dictionary<string, FileParameter>();
        object postBody = null;

        
        await CallApi(path_.ToString(), HttpMethod.Delete, queryParams, postBody, headerParams, formParams, fileParams, ct);
    }

    /// <inheritdoc />     
    public async Task<List<RealmRepresentation>> Get(string briefRepresentation, CancellationToken ct)
    {
        

        var path_ = new StringBuilder("/");
        
        var queryParams = new Dictionary<string, string>();
        var headerParams = new Dictionary<string, string>();
        var formParams = new Dictionary<string, string>();
        var fileParams = new Dictionary<string, FileParameter>();
        object postBody = null;

         if (briefRepresentation != null) queryParams.Add("briefRepresentation", ParameterToString(briefRepresentation)); // query parameter
        
        var response = await CallApi<List<RealmRepresentation>>(path_.ToString(), HttpMethod.Get, queryParams, postBody, headerParams, formParams, fileParams, ct);
        
        return response;
    }

    /// <inheritdoc />     
    public async Task<List<AdminEventRepresentation>> GetAdminEvents(string realm, string authClient, string authIpAddress, string authRealm, string authUser, string dateFrom, string dateTo, string first, string max, string operationTypes, string resourcePath, string resourceTypes, CancellationToken ct)
    {
        
        // verify the required parameter 'realm' is set
        if (realm == null) throw new IOSwaggerClientApiException(400, "Missing required parameter 'realm' when calling GetAdminEvents");
        

        var path_ = new StringBuilder("/{realm}/admin-events");
        path_ = path_.Replace("{realm}", ParameterToString(realm));

        var queryParams = new Dictionary<string, string>();
        var headerParams = new Dictionary<string, string>();
        var formParams = new Dictionary<string, string>();
        var fileParams = new Dictionary<string, FileParameter>();
        object postBody = null;

         if (authClient != null) queryParams.Add("authClient", ParameterToString(authClient)); // query parameter
         if (authIpAddress != null) queryParams.Add("authIpAddress", ParameterToString(authIpAddress)); // query parameter
         if (authRealm != null) queryParams.Add("authRealm", ParameterToString(authRealm)); // query parameter
         if (authUser != null) queryParams.Add("authUser", ParameterToString(authUser)); // query parameter
         if (dateFrom != null) queryParams.Add("dateFrom", ParameterToString(dateFrom)); // query parameter
         if (dateTo != null) queryParams.Add("dateTo", ParameterToString(dateTo)); // query parameter
         if (first != null) queryParams.Add("first", ParameterToString(first)); // query parameter
         if (max != null) queryParams.Add("max", ParameterToString(max)); // query parameter
         if (operationTypes != null) queryParams.Add("operationTypes", ParameterToString(operationTypes)); // query parameter
         if (resourcePath != null) queryParams.Add("resourcePath", ParameterToString(resourcePath)); // query parameter
         if (resourceTypes != null) queryParams.Add("resourceTypes", ParameterToString(resourceTypes)); // query parameter
        
        var response = await CallApi<List<AdminEventRepresentation>>(path_.ToString(), HttpMethod.Get, queryParams, postBody, headerParams, formParams, fileParams, ct);
        
        return response;
    }

    /// <inheritdoc />     
    public async Task<RealmRepresentation> GetByRealm(string realm, CancellationToken ct)
    {
        
        // verify the required parameter 'realm' is set
        if (realm == null) throw new IOSwaggerClientApiException(400, "Missing required parameter 'realm' when calling GetByRealm");
        

        var path_ = new StringBuilder("/{realm}");
        path_ = path_.Replace("{realm}", ParameterToString(realm));

        var queryParams = new Dictionary<string, string>();
        var headerParams = new Dictionary<string, string>();
        var formParams = new Dictionary<string, string>();
        var fileParams = new Dictionary<string, FileParameter>();
        object postBody = null;

        
        var response = await CallApi<RealmRepresentation>(path_.ToString(), HttpMethod.Get, queryParams, postBody, headerParams, formParams, fileParams, ct);
        
        return response;
    }

    /// <inheritdoc />     
    public async Task<List<string>> GetClientSessionStats(string realm, CancellationToken ct)
    {
        
        // verify the required parameter 'realm' is set
        if (realm == null) throw new IOSwaggerClientApiException(400, "Missing required parameter 'realm' when calling GetClientSessionStats");
        

        var path_ = new StringBuilder("/{realm}/client-session-stats");
        path_ = path_.Replace("{realm}", ParameterToString(realm));

        var queryParams = new Dictionary<string, string>();
        var headerParams = new Dictionary<string, string>();
        var formParams = new Dictionary<string, string>();
        var fileParams = new Dictionary<string, FileParameter>();
        object postBody = null;

        
        var response = await CallApi<List<string>>(path_.ToString(), HttpMethod.Get, queryParams, postBody, headerParams, formParams, fileParams, ct);
        
        return response;
    }

    /// <inheritdoc />     
    public async Task<List<string>> GetCredentialRegistrators(string realm, CancellationToken ct)
    {
        
        // verify the required parameter 'realm' is set
        if (realm == null) throw new IOSwaggerClientApiException(400, "Missing required parameter 'realm' when calling GetCredentialRegistrators");
        

        var path_ = new StringBuilder("/{realm}/credential-registrators");
        path_ = path_.Replace("{realm}", ParameterToString(realm));

        var queryParams = new Dictionary<string, string>();
        var headerParams = new Dictionary<string, string>();
        var formParams = new Dictionary<string, string>();
        var fileParams = new Dictionary<string, FileParameter>();
        object postBody = null;

        
        var response = await CallApi<List<string>>(path_.ToString(), HttpMethod.Get, queryParams, postBody, headerParams, formParams, fileParams, ct);
        
        return response;
    }

    /// <inheritdoc />     
    public async Task<List<ClientScopeRepresentation>> GetDefaultDefaultClientScopes(string realm, CancellationToken ct)
    {
        
        // verify the required parameter 'realm' is set
        if (realm == null) throw new IOSwaggerClientApiException(400, "Missing required parameter 'realm' when calling GetDefaultDefaultClientScopes");
        

        var path_ = new StringBuilder("/{realm}/default-default-client-scopes");
        path_ = path_.Replace("{realm}", ParameterToString(realm));

        var queryParams = new Dictionary<string, string>();
        var headerParams = new Dictionary<string, string>();
        var formParams = new Dictionary<string, string>();
        var fileParams = new Dictionary<string, FileParameter>();
        object postBody = null;

        
        var response = await CallApi<List<ClientScopeRepresentation>>(path_.ToString(), HttpMethod.Get, queryParams, postBody, headerParams, formParams, fileParams, ct);
        
        return response;
    }

    /// <inheritdoc />     
    public async Task<List<GroupRepresentation>> GetDefaultGroups(string realm, CancellationToken ct)
    {
        
        // verify the required parameter 'realm' is set
        if (realm == null) throw new IOSwaggerClientApiException(400, "Missing required parameter 'realm' when calling GetDefaultGroups");
        

        var path_ = new StringBuilder("/{realm}/default-groups");
        path_ = path_.Replace("{realm}", ParameterToString(realm));

        var queryParams = new Dictionary<string, string>();
        var headerParams = new Dictionary<string, string>();
        var formParams = new Dictionary<string, string>();
        var fileParams = new Dictionary<string, FileParameter>();
        object postBody = null;

        
        var response = await CallApi<List<GroupRepresentation>>(path_.ToString(), HttpMethod.Get, queryParams, postBody, headerParams, formParams, fileParams, ct);
        
        return response;
    }

    /// <inheritdoc />     
    public async Task<List<ClientScopeRepresentation>> GetDefaultOptionalClientScopes(string realm, CancellationToken ct)
    {
        
        // verify the required parameter 'realm' is set
        if (realm == null) throw new IOSwaggerClientApiException(400, "Missing required parameter 'realm' when calling GetDefaultOptionalClientScopes");
        

        var path_ = new StringBuilder("/{realm}/default-optional-client-scopes");
        path_ = path_.Replace("{realm}", ParameterToString(realm));

        var queryParams = new Dictionary<string, string>();
        var headerParams = new Dictionary<string, string>();
        var formParams = new Dictionary<string, string>();
        var fileParams = new Dictionary<string, FileParameter>();
        object postBody = null;

        
        var response = await CallApi<List<ClientScopeRepresentation>>(path_.ToString(), HttpMethod.Get, queryParams, postBody, headerParams, formParams, fileParams, ct);
        
        return response;
    }

    /// <inheritdoc />     
    public async Task<List<EventRepresentation>> GetEvents(string realm, string _client, string dateFrom, string dateTo, string first, string ipAddress, string max, string type, string user, CancellationToken ct)
    {
        
        // verify the required parameter 'realm' is set
        if (realm == null) throw new IOSwaggerClientApiException(400, "Missing required parameter 'realm' when calling GetEvents");
        

        var path_ = new StringBuilder("/{realm}/events");
        path_ = path_.Replace("{realm}", ParameterToString(realm));

        var queryParams = new Dictionary<string, string>();
        var headerParams = new Dictionary<string, string>();
        var formParams = new Dictionary<string, string>();
        var fileParams = new Dictionary<string, FileParameter>();
        object postBody = null;

         if (_client != null) queryParams.Add("client", ParameterToString(_client)); // query parameter
         if (dateFrom != null) queryParams.Add("dateFrom", ParameterToString(dateFrom)); // query parameter
         if (dateTo != null) queryParams.Add("dateTo", ParameterToString(dateTo)); // query parameter
         if (first != null) queryParams.Add("first", ParameterToString(first)); // query parameter
         if (ipAddress != null) queryParams.Add("ipAddress", ParameterToString(ipAddress)); // query parameter
         if (max != null) queryParams.Add("max", ParameterToString(max)); // query parameter
         if (type != null) queryParams.Add("type", ParameterToString(type)); // query parameter
         if (user != null) queryParams.Add("user", ParameterToString(user)); // query parameter
        
        var response = await CallApi<List<EventRepresentation>>(path_.ToString(), HttpMethod.Get, queryParams, postBody, headerParams, formParams, fileParams, ct);
        
        return response;
    }

    /// <inheritdoc />     
    public async Task<RealmEventsConfigRepresentation> GetEventsConfig(string realm, CancellationToken ct)
    {
        
        // verify the required parameter 'realm' is set
        if (realm == null) throw new IOSwaggerClientApiException(400, "Missing required parameter 'realm' when calling GetEventsConfig");
        

        var path_ = new StringBuilder("/{realm}/events/config");
        path_ = path_.Replace("{realm}", ParameterToString(realm));

        var queryParams = new Dictionary<string, string>();
        var headerParams = new Dictionary<string, string>();
        var formParams = new Dictionary<string, string>();
        var fileParams = new Dictionary<string, FileParameter>();
        object postBody = null;

        
        var response = await CallApi<RealmEventsConfigRepresentation>(path_.ToString(), HttpMethod.Get, queryParams, postBody, headerParams, formParams, fileParams, ct);
        
        return response;
    }

    /// <inheritdoc />     
    public async Task<GroupRepresentation> GetGroupByPath(string realm, string path, CancellationToken ct)
    {
        
        // verify the required parameter 'realm' is set
        if (realm == null) throw new IOSwaggerClientApiException(400, "Missing required parameter 'realm' when calling GetGroupByPath");
        
        // verify the required parameter 'path' is set
        if (path == null) throw new IOSwaggerClientApiException(400, "Missing required parameter 'path' when calling GetGroupByPath");
        

        var path_ = new StringBuilder("/{realm}/group-by-path/{path}");
        path_ = path_.Replace("{realm}", ParameterToString(realm));
path_ = path_.Replace("{path}", ParameterToString(path));

        var queryParams = new Dictionary<string, string>();
        var headerParams = new Dictionary<string, string>();
        var formParams = new Dictionary<string, string>();
        var fileParams = new Dictionary<string, FileParameter>();
        object postBody = null;

        
        var response = await CallApi<GroupRepresentation>(path_.ToString(), HttpMethod.Get, queryParams, postBody, headerParams, formParams, fileParams, ct);
        
        return response;
    }

    /// <inheritdoc />     
    public async Task<List<string>> GetLocalizationByRealm(string realm, CancellationToken ct)
    {
        
        // verify the required parameter 'realm' is set
        if (realm == null) throw new IOSwaggerClientApiException(400, "Missing required parameter 'realm' when calling GetLocalizationByRealm");
        

        var path_ = new StringBuilder("/{realm}/localization");
        path_ = path_.Replace("{realm}", ParameterToString(realm));

        var queryParams = new Dictionary<string, string>();
        var headerParams = new Dictionary<string, string>();
        var formParams = new Dictionary<string, string>();
        var fileParams = new Dictionary<string, FileParameter>();
        object postBody = null;

        
        var response = await CallApi<List<string>>(path_.ToString(), HttpMethod.Get, queryParams, postBody, headerParams, formParams, fileParams, ct);
        
        return response;
    }

    /// <inheritdoc />     
    public async Task<Dictionary<string, string>> GetLocalizationByRealmByLocale(string realm, string locale, string useRealmDefaultLocaleFallback, CancellationToken ct)
    {
        
        // verify the required parameter 'realm' is set
        if (realm == null) throw new IOSwaggerClientApiException(400, "Missing required parameter 'realm' when calling GetLocalizationByRealmByLocale");
        
        // verify the required parameter 'locale' is set
        if (locale == null) throw new IOSwaggerClientApiException(400, "Missing required parameter 'locale' when calling GetLocalizationByRealmByLocale");
        

        var path_ = new StringBuilder("/{realm}/localization/{locale}");
        path_ = path_.Replace("{realm}", ParameterToString(realm));
path_ = path_.Replace("{locale}", ParameterToString(locale));

        var queryParams = new Dictionary<string, string>();
        var headerParams = new Dictionary<string, string>();
        var formParams = new Dictionary<string, string>();
        var fileParams = new Dictionary<string, FileParameter>();
        object postBody = null;

         if (useRealmDefaultLocaleFallback != null) queryParams.Add("useRealmDefaultLocaleFallback", ParameterToString(useRealmDefaultLocaleFallback)); // query parameter
        
        var response = await CallApi<Dictionary<string, string>>(path_.ToString(), HttpMethod.Get, queryParams, postBody, headerParams, formParams, fileParams, ct);
        
        return response;
    }

    /// <inheritdoc />     
    public async Task<string> GetLocalizationByRealmByLocaleByKey(string realm, string locale, string key, CancellationToken ct)
    {
        
        // verify the required parameter 'realm' is set
        if (realm == null) throw new IOSwaggerClientApiException(400, "Missing required parameter 'realm' when calling GetLocalizationByRealmByLocaleByKey");
        
        // verify the required parameter 'locale' is set
        if (locale == null) throw new IOSwaggerClientApiException(400, "Missing required parameter 'locale' when calling GetLocalizationByRealmByLocaleByKey");
        
        // verify the required parameter 'key' is set
        if (key == null) throw new IOSwaggerClientApiException(400, "Missing required parameter 'key' when calling GetLocalizationByRealmByLocaleByKey");
        

        var path_ = new StringBuilder("/{realm}/localization/{locale}/{key}");
        path_ = path_.Replace("{realm}", ParameterToString(realm));
path_ = path_.Replace("{locale}", ParameterToString(locale));
path_ = path_.Replace("{key}", ParameterToString(key));

        var queryParams = new Dictionary<string, string>();
        var headerParams = new Dictionary<string, string>();
        var formParams = new Dictionary<string, string>();
        var fileParams = new Dictionary<string, FileParameter>();
        object postBody = null;

        
        var response = await CallApi<string>(path_.ToString(), HttpMethod.Get, queryParams, postBody, headerParams, formParams, fileParams, ct);
        
        return response;
    }

    /// <inheritdoc />     
    public async Task<ClientPoliciesRepresentation> GetPolicies(string realm, CancellationToken ct)
    {
        
        // verify the required parameter 'realm' is set
        if (realm == null) throw new IOSwaggerClientApiException(400, "Missing required parameter 'realm' when calling GetPolicies");
        

        var path_ = new StringBuilder("/{realm}/client-policies/policies");
        path_ = path_.Replace("{realm}", ParameterToString(realm));

        var queryParams = new Dictionary<string, string>();
        var headerParams = new Dictionary<string, string>();
        var formParams = new Dictionary<string, string>();
        var fileParams = new Dictionary<string, FileParameter>();
        object postBody = null;

        
        var response = await CallApi<ClientPoliciesRepresentation>(path_.ToString(), HttpMethod.Get, queryParams, postBody, headerParams, formParams, fileParams, ct);
        
        return response;
    }

    /// <inheritdoc />     
    public async Task<ClientProfilesRepresentation> GetProfiles(string realm, string includeGlobalProfiles, CancellationToken ct)
    {
        
        // verify the required parameter 'realm' is set
        if (realm == null) throw new IOSwaggerClientApiException(400, "Missing required parameter 'realm' when calling GetProfiles");
        

        var path_ = new StringBuilder("/{realm}/client-policies/profiles");
        path_ = path_.Replace("{realm}", ParameterToString(realm));

        var queryParams = new Dictionary<string, string>();
        var headerParams = new Dictionary<string, string>();
        var formParams = new Dictionary<string, string>();
        var fileParams = new Dictionary<string, FileParameter>();
        object postBody = null;

         if (includeGlobalProfiles != null) queryParams.Add("include-global-profiles", ParameterToString(includeGlobalProfiles)); // query parameter
        
        var response = await CallApi<ClientProfilesRepresentation>(path_.ToString(), HttpMethod.Get, queryParams, postBody, headerParams, formParams, fileParams, ct);
        
        return response;
    }

    /// <inheritdoc />     
    public async Task<ManagementPermissionReference> GetUsersManagementPermissions(string realm, CancellationToken ct)
    {
        
        // verify the required parameter 'realm' is set
        if (realm == null) throw new IOSwaggerClientApiException(400, "Missing required parameter 'realm' when calling GetUsersManagementPermissions");
        

        var path_ = new StringBuilder("/{realm}/users-management-permissions");
        path_ = path_.Replace("{realm}", ParameterToString(realm));

        var queryParams = new Dictionary<string, string>();
        var headerParams = new Dictionary<string, string>();
        var formParams = new Dictionary<string, string>();
        var fileParams = new Dictionary<string, FileParameter>();
        object postBody = null;

        
        var response = await CallApi<ManagementPermissionReference>(path_.ToString(), HttpMethod.Get, queryParams, postBody, headerParams, formParams, fileParams, ct);
        
        return response;
    }

    /// <inheritdoc />     
    public async Task Post(Object body, CancellationToken ct)
    {
        

        var path_ = new StringBuilder("/");
        
        var queryParams = new Dictionary<string, string>();
        var headerParams = new Dictionary<string, string>();
        var formParams = new Dictionary<string, string>();
        var fileParams = new Dictionary<string, FileParameter>();
        object postBody = null;

        postBody = body; // http body (model) parameter

        await CallApi(path_.ToString(), HttpMethod.Post, queryParams, postBody, headerParams, formParams, fileParams, ct);
    }

    /// <inheritdoc />     
    public async Task<ClientRepresentation> PostClientDescriptionConverter(string realm, string body, CancellationToken ct)
    {
        
        // verify the required parameter 'realm' is set
        if (realm == null) throw new IOSwaggerClientApiException(400, "Missing required parameter 'realm' when calling PostClientDescriptionConverter");
        

        var path_ = new StringBuilder("/{realm}/client-description-converter");
        path_ = path_.Replace("{realm}", ParameterToString(realm));

        var queryParams = new Dictionary<string, string>();
        var headerParams = new Dictionary<string, string>();
        var formParams = new Dictionary<string, string>();
        var fileParams = new Dictionary<string, FileParameter>();
        object postBody = null;

        postBody = body; // http body (model) parameter

        var response = await CallApi<ClientRepresentation>(path_.ToString(), HttpMethod.Post, queryParams, postBody, headerParams, formParams, fileParams, ct);
        
        return response;
    }

    /// <inheritdoc />     
    public async Task PostLocalization(string realm, string locale, string body, CancellationToken ct)
    {
        
        // verify the required parameter 'realm' is set
        if (realm == null) throw new IOSwaggerClientApiException(400, "Missing required parameter 'realm' when calling PostLocalization");
        
        // verify the required parameter 'locale' is set
        if (locale == null) throw new IOSwaggerClientApiException(400, "Missing required parameter 'locale' when calling PostLocalization");
        

        var path_ = new StringBuilder("/{realm}/localization/{locale}");
        path_ = path_.Replace("{realm}", ParameterToString(realm));
path_ = path_.Replace("{locale}", ParameterToString(locale));

        var queryParams = new Dictionary<string, string>();
        var headerParams = new Dictionary<string, string>();
        var formParams = new Dictionary<string, string>();
        var fileParams = new Dictionary<string, FileParameter>();
        object postBody = null;

        postBody = body; // http body (model) parameter

        await CallApi(path_.ToString(), HttpMethod.Post, queryParams, postBody, headerParams, formParams, fileParams, ct);
    }

    /// <inheritdoc />     
    public async Task<GlobalRequestResult> PostLogoutAll(string realm, CancellationToken ct)
    {
        
        // verify the required parameter 'realm' is set
        if (realm == null) throw new IOSwaggerClientApiException(400, "Missing required parameter 'realm' when calling PostLogoutAll");
        

        var path_ = new StringBuilder("/{realm}/logout-all");
        path_ = path_.Replace("{realm}", ParameterToString(realm));

        var queryParams = new Dictionary<string, string>();
        var headerParams = new Dictionary<string, string>();
        var formParams = new Dictionary<string, string>();
        var fileParams = new Dictionary<string, FileParameter>();
        object postBody = null;

        
        var response = await CallApi<GlobalRequestResult>(path_.ToString(), HttpMethod.Post, queryParams, postBody, headerParams, formParams, fileParams, ct);
        
        return response;
    }

    /// <inheritdoc />     
    public async Task PostPartialExport(string realm, string exportClients, string exportGroupsAndRoles, CancellationToken ct)
    {
        
        // verify the required parameter 'realm' is set
        if (realm == null) throw new IOSwaggerClientApiException(400, "Missing required parameter 'realm' when calling PostPartialExport");
        

        var path_ = new StringBuilder("/{realm}/partial-export");
        path_ = path_.Replace("{realm}", ParameterToString(realm));

        var queryParams = new Dictionary<string, string>();
        var headerParams = new Dictionary<string, string>();
        var formParams = new Dictionary<string, string>();
        var fileParams = new Dictionary<string, FileParameter>();
        object postBody = null;

         if (exportClients != null) queryParams.Add("exportClients", ParameterToString(exportClients)); // query parameter
         if (exportGroupsAndRoles != null) queryParams.Add("exportGroupsAndRoles", ParameterToString(exportGroupsAndRoles)); // query parameter
        
        await CallApi(path_.ToString(), HttpMethod.Post, queryParams, postBody, headerParams, formParams, fileParams, ct);
    }

    /// <inheritdoc />     
    public async Task PostPartialImport(string realm, Object body, CancellationToken ct)
    {
        
        // verify the required parameter 'realm' is set
        if (realm == null) throw new IOSwaggerClientApiException(400, "Missing required parameter 'realm' when calling PostPartialImport");
        

        var path_ = new StringBuilder("/{realm}/partialImport");
        path_ = path_.Replace("{realm}", ParameterToString(realm));

        var queryParams = new Dictionary<string, string>();
        var headerParams = new Dictionary<string, string>();
        var formParams = new Dictionary<string, string>();
        var fileParams = new Dictionary<string, FileParameter>();
        object postBody = null;

        postBody = body; // http body (model) parameter

        await CallApi(path_.ToString(), HttpMethod.Post, queryParams, postBody, headerParams, formParams, fileParams, ct);
    }

    /// <inheritdoc />     
    public async Task<GlobalRequestResult> PostPushRevocationByRealm(string realm, CancellationToken ct)
    {
        
        // verify the required parameter 'realm' is set
        if (realm == null) throw new IOSwaggerClientApiException(400, "Missing required parameter 'realm' when calling PostPushRevocationByRealm");
        

        var path_ = new StringBuilder("/{realm}/push-revocation");
        path_ = path_.Replace("{realm}", ParameterToString(realm));

        var queryParams = new Dictionary<string, string>();
        var headerParams = new Dictionary<string, string>();
        var formParams = new Dictionary<string, string>();
        var fileParams = new Dictionary<string, FileParameter>();
        object postBody = null;

        
        var response = await CallApi<GlobalRequestResult>(path_.ToString(), HttpMethod.Post, queryParams, postBody, headerParams, formParams, fileParams, ct);
        
        return response;
    }

    /// <inheritdoc />     
    public async Task PostTestSmtpConnection(string realm, string body, CancellationToken ct)
    {
        
        // verify the required parameter 'realm' is set
        if (realm == null) throw new IOSwaggerClientApiException(400, "Missing required parameter 'realm' when calling PostTestSmtpConnection");
        

        var path_ = new StringBuilder("/{realm}/testSMTPConnection");
        path_ = path_.Replace("{realm}", ParameterToString(realm));

        var queryParams = new Dictionary<string, string>();
        var headerParams = new Dictionary<string, string>();
        var formParams = new Dictionary<string, string>();
        var fileParams = new Dictionary<string, FileParameter>();
        object postBody = null;

        postBody = body; // http body (model) parameter

        await CallApi(path_.ToString(), HttpMethod.Post, queryParams, postBody, headerParams, formParams, fileParams, ct);
    }

    /// <inheritdoc />     
    public async Task PutByRealm(string realm, RealmRepresentation body, CancellationToken ct)
    {
        
        // verify the required parameter 'realm' is set
        if (realm == null) throw new IOSwaggerClientApiException(400, "Missing required parameter 'realm' when calling PutByRealm");
        

        var path_ = new StringBuilder("/{realm}");
        path_ = path_.Replace("{realm}", ParameterToString(realm));

        var queryParams = new Dictionary<string, string>();
        var headerParams = new Dictionary<string, string>();
        var formParams = new Dictionary<string, string>();
        var fileParams = new Dictionary<string, FileParameter>();
        object postBody = null;

        postBody = body; // http body (model) parameter

        await CallApi(path_.ToString(), HttpMethod.Put, queryParams, postBody, headerParams, formParams, fileParams, ct);
    }

    /// <inheritdoc />     
    public async Task PutDefaultDefaultClientScope(string realm, string clientScopeId, CancellationToken ct)
    {
        
        // verify the required parameter 'realm' is set
        if (realm == null) throw new IOSwaggerClientApiException(400, "Missing required parameter 'realm' when calling PutDefaultDefaultClientScope");
        
        // verify the required parameter 'clientScopeId' is set
        if (clientScopeId == null) throw new IOSwaggerClientApiException(400, "Missing required parameter 'clientScopeId' when calling PutDefaultDefaultClientScope");
        

        var path_ = new StringBuilder("/{realm}/default-default-client-scopes/{clientScopeId}");
        path_ = path_.Replace("{realm}", ParameterToString(realm));
path_ = path_.Replace("{clientScopeId}", ParameterToString(clientScopeId));

        var queryParams = new Dictionary<string, string>();
        var headerParams = new Dictionary<string, string>();
        var formParams = new Dictionary<string, string>();
        var fileParams = new Dictionary<string, FileParameter>();
        object postBody = null;

        
        await CallApi(path_.ToString(), HttpMethod.Put, queryParams, postBody, headerParams, formParams, fileParams, ct);
    }

    /// <inheritdoc />     
    public async Task PutDefaultGroup(string realm, string groupId, CancellationToken ct)
    {
        
        // verify the required parameter 'realm' is set
        if (realm == null) throw new IOSwaggerClientApiException(400, "Missing required parameter 'realm' when calling PutDefaultGroup");
        
        // verify the required parameter 'groupId' is set
        if (groupId == null) throw new IOSwaggerClientApiException(400, "Missing required parameter 'groupId' when calling PutDefaultGroup");
        

        var path_ = new StringBuilder("/{realm}/default-groups/{groupId}");
        path_ = path_.Replace("{realm}", ParameterToString(realm));
path_ = path_.Replace("{groupId}", ParameterToString(groupId));

        var queryParams = new Dictionary<string, string>();
        var headerParams = new Dictionary<string, string>();
        var formParams = new Dictionary<string, string>();
        var fileParams = new Dictionary<string, FileParameter>();
        object postBody = null;

        
        await CallApi(path_.ToString(), HttpMethod.Put, queryParams, postBody, headerParams, formParams, fileParams, ct);
    }

    /// <inheritdoc />     
    public async Task PutDefaultOptionalClientScope(string realm, string clientScopeId, CancellationToken ct)
    {
        
        // verify the required parameter 'realm' is set
        if (realm == null) throw new IOSwaggerClientApiException(400, "Missing required parameter 'realm' when calling PutDefaultOptionalClientScope");
        
        // verify the required parameter 'clientScopeId' is set
        if (clientScopeId == null) throw new IOSwaggerClientApiException(400, "Missing required parameter 'clientScopeId' when calling PutDefaultOptionalClientScope");
        

        var path_ = new StringBuilder("/{realm}/default-optional-client-scopes/{clientScopeId}");
        path_ = path_.Replace("{realm}", ParameterToString(realm));
path_ = path_.Replace("{clientScopeId}", ParameterToString(clientScopeId));

        var queryParams = new Dictionary<string, string>();
        var headerParams = new Dictionary<string, string>();
        var formParams = new Dictionary<string, string>();
        var fileParams = new Dictionary<string, FileParameter>();
        object postBody = null;

        
        await CallApi(path_.ToString(), HttpMethod.Put, queryParams, postBody, headerParams, formParams, fileParams, ct);
    }

    /// <inheritdoc />     
    public async Task PutEventsConfig(string realm, RealmEventsConfigRepresentation body, CancellationToken ct)
    {
        
        // verify the required parameter 'realm' is set
        if (realm == null) throw new IOSwaggerClientApiException(400, "Missing required parameter 'realm' when calling PutEventsConfig");
        

        var path_ = new StringBuilder("/{realm}/events/config");
        path_ = path_.Replace("{realm}", ParameterToString(realm));

        var queryParams = new Dictionary<string, string>();
        var headerParams = new Dictionary<string, string>();
        var formParams = new Dictionary<string, string>();
        var fileParams = new Dictionary<string, FileParameter>();
        object postBody = null;

        postBody = body; // http body (model) parameter

        await CallApi(path_.ToString(), HttpMethod.Put, queryParams, postBody, headerParams, formParams, fileParams, ct);
    }

    /// <inheritdoc />     
    public async Task PutLocalization(string realm, string locale, string key, string body, CancellationToken ct)
    {
        
        // verify the required parameter 'realm' is set
        if (realm == null) throw new IOSwaggerClientApiException(400, "Missing required parameter 'realm' when calling PutLocalization");
        
        // verify the required parameter 'locale' is set
        if (locale == null) throw new IOSwaggerClientApiException(400, "Missing required parameter 'locale' when calling PutLocalization");
        
        // verify the required parameter 'key' is set
        if (key == null) throw new IOSwaggerClientApiException(400, "Missing required parameter 'key' when calling PutLocalization");
        

        var path_ = new StringBuilder("/{realm}/localization/{locale}/{key}");
        path_ = path_.Replace("{realm}", ParameterToString(realm));
path_ = path_.Replace("{locale}", ParameterToString(locale));
path_ = path_.Replace("{key}", ParameterToString(key));

        var queryParams = new Dictionary<string, string>();
        var headerParams = new Dictionary<string, string>();
        var formParams = new Dictionary<string, string>();
        var fileParams = new Dictionary<string, FileParameter>();
        object postBody = null;

        postBody = body; // http body (model) parameter

        await CallApi(path_.ToString(), HttpMethod.Put, queryParams, postBody, headerParams, formParams, fileParams, ct);
    }

    /// <inheritdoc />     
    public async Task PutPolicies(string realm, ClientPoliciesRepresentation body, CancellationToken ct)
    {
        
        // verify the required parameter 'realm' is set
        if (realm == null) throw new IOSwaggerClientApiException(400, "Missing required parameter 'realm' when calling PutPolicies");
        

        var path_ = new StringBuilder("/{realm}/client-policies/policies");
        path_ = path_.Replace("{realm}", ParameterToString(realm));

        var queryParams = new Dictionary<string, string>();
        var headerParams = new Dictionary<string, string>();
        var formParams = new Dictionary<string, string>();
        var fileParams = new Dictionary<string, FileParameter>();
        object postBody = null;

        postBody = body; // http body (model) parameter

        await CallApi(path_.ToString(), HttpMethod.Put, queryParams, postBody, headerParams, formParams, fileParams, ct);
    }

    /// <inheritdoc />     
    public async Task PutProfiles(string realm, ClientProfilesRepresentation body, CancellationToken ct)
    {
        
        // verify the required parameter 'realm' is set
        if (realm == null) throw new IOSwaggerClientApiException(400, "Missing required parameter 'realm' when calling PutProfiles");
        

        var path_ = new StringBuilder("/{realm}/client-policies/profiles");
        path_ = path_.Replace("{realm}", ParameterToString(realm));

        var queryParams = new Dictionary<string, string>();
        var headerParams = new Dictionary<string, string>();
        var formParams = new Dictionary<string, string>();
        var fileParams = new Dictionary<string, FileParameter>();
        object postBody = null;

        postBody = body; // http body (model) parameter

        await CallApi(path_.ToString(), HttpMethod.Put, queryParams, postBody, headerParams, formParams, fileParams, ct);
    }

    /// <inheritdoc />     
    public async Task<ManagementPermissionReference> PutUsersManagementPermissions(string realm, ManagementPermissionReference body, CancellationToken ct)
    {
        
        // verify the required parameter 'realm' is set
        if (realm == null) throw new IOSwaggerClientApiException(400, "Missing required parameter 'realm' when calling PutUsersManagementPermissions");
        

        var path_ = new StringBuilder("/{realm}/users-management-permissions");
        path_ = path_.Replace("{realm}", ParameterToString(realm));

        var queryParams = new Dictionary<string, string>();
        var headerParams = new Dictionary<string, string>();
        var formParams = new Dictionary<string, string>();
        var fileParams = new Dictionary<string, FileParameter>();
        object postBody = null;

        postBody = body; // http body (model) parameter

        var response = await CallApi<ManagementPermissionReference>(path_.ToString(), HttpMethod.Put, queryParams, postBody, headerParams, formParams, fileParams, ct);
        
        return response;
    }

}
