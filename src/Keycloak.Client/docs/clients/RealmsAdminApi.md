# .RealmsAdminApi

All URIs are relative to *https://keycloak.example.com/admin/realms*

Method | HTTP request | Description
------------- | ------------- | -------------
[**DeleteAdminEvents**](RealmsAdminApi.md#deleteadminevents) | **Delete** /{realm}/admin-events | 
[**DeleteByRealm**](RealmsAdminApi.md#deletebyrealm) | **Delete** /{realm} | 
[**DeleteDefaultDefaultClientScope**](RealmsAdminApi.md#deletedefaultdefaultclientscope) | **Delete** /{realm}/default-default-client-scopes/{clientScopeId} | 
[**DeleteDefaultGroup**](RealmsAdminApi.md#deletedefaultgroup) | **Delete** /{realm}/default-groups/{groupId} | 
[**DeleteDefaultOptionalClientScope**](RealmsAdminApi.md#deletedefaultoptionalclientscope) | **Delete** /{realm}/default-optional-client-scopes/{clientScopeId} | 
[**DeleteEvents**](RealmsAdminApi.md#deleteevents) | **Delete** /{realm}/events | 
[**DeleteLocalizationByRealmByLocale**](RealmsAdminApi.md#deletelocalizationbyrealmbylocale) | **Delete** /{realm}/localization/{locale} | 
[**DeleteLocalizationByRealmByLocaleByKey**](RealmsAdminApi.md#deletelocalizationbyrealmbylocalebykey) | **Delete** /{realm}/localization/{locale}/{key} | 
[**DeleteSession**](RealmsAdminApi.md#deletesession) | **Delete** /{realm}/sessions/{session} | 
[**Get**](RealmsAdminApi.md#get) | **Get** / | 
[**GetAdminEvents**](RealmsAdminApi.md#getadminevents) | **Get** /{realm}/admin-events | 
[**GetByRealm**](RealmsAdminApi.md#getbyrealm) | **Get** /{realm} | 
[**GetClientSessionStats**](RealmsAdminApi.md#getclientsessionstats) | **Get** /{realm}/client-session-stats | 
[**GetCredentialRegistrators**](RealmsAdminApi.md#getcredentialregistrators) | **Get** /{realm}/credential-registrators | 
[**GetDefaultDefaultClientScopes**](RealmsAdminApi.md#getdefaultdefaultclientscopes) | **Get** /{realm}/default-default-client-scopes | 
[**GetDefaultGroups**](RealmsAdminApi.md#getdefaultgroups) | **Get** /{realm}/default-groups | 
[**GetDefaultOptionalClientScopes**](RealmsAdminApi.md#getdefaultoptionalclientscopes) | **Get** /{realm}/default-optional-client-scopes | 
[**GetEvents**](RealmsAdminApi.md#getevents) | **Get** /{realm}/events | 
[**GetEventsConfig**](RealmsAdminApi.md#geteventsconfig) | **Get** /{realm}/events/config | 
[**GetGroupByPath**](RealmsAdminApi.md#getgroupbypath) | **Get** /{realm}/group-by-path/{path} | 
[**GetLocalizationByRealm**](RealmsAdminApi.md#getlocalizationbyrealm) | **Get** /{realm}/localization | 
[**GetLocalizationByRealmByLocale**](RealmsAdminApi.md#getlocalizationbyrealmbylocale) | **Get** /{realm}/localization/{locale} | 
[**GetLocalizationByRealmByLocaleByKey**](RealmsAdminApi.md#getlocalizationbyrealmbylocalebykey) | **Get** /{realm}/localization/{locale}/{key} | 
[**GetPolicies**](RealmsAdminApi.md#getpolicies) | **Get** /{realm}/client-policies/policies | 
[**GetProfiles**](RealmsAdminApi.md#getprofiles) | **Get** /{realm}/client-policies/profiles | 
[**GetUsersManagementPermissions**](RealmsAdminApi.md#getusersmanagementpermissions) | **Get** /{realm}/users-management-permissions | 
[**Post**](RealmsAdminApi.md#post) | **Post** / | 
[**PostClientDescriptionConverter**](RealmsAdminApi.md#postclientdescriptionconverter) | **Post** /{realm}/client-description-converter | 
[**PostLocalization**](RealmsAdminApi.md#postlocalization) | **Post** /{realm}/localization/{locale} | 
[**PostLogoutAll**](RealmsAdminApi.md#postlogoutall) | **Post** /{realm}/logout-all | 
[**PostPartialExport**](RealmsAdminApi.md#postpartialexport) | **Post** /{realm}/partial-export | 
[**PostPartialImport**](RealmsAdminApi.md#postpartialimport) | **Post** /{realm}/partialImport | 
[**PostPushRevocationByRealm**](RealmsAdminApi.md#postpushrevocationbyrealm) | **Post** /{realm}/push-revocation | 
[**PostTestSmtpConnection**](RealmsAdminApi.md#posttestsmtpconnection) | **Post** /{realm}/testSMTPConnection | 
[**PutByRealm**](RealmsAdminApi.md#putbyrealm) | **Put** /{realm} | 
[**PutDefaultDefaultClientScope**](RealmsAdminApi.md#putdefaultdefaultclientscope) | **Put** /{realm}/default-default-client-scopes/{clientScopeId} | 
[**PutDefaultGroup**](RealmsAdminApi.md#putdefaultgroup) | **Put** /{realm}/default-groups/{groupId} | 
[**PutDefaultOptionalClientScope**](RealmsAdminApi.md#putdefaultoptionalclientscope) | **Put** /{realm}/default-optional-client-scopes/{clientScopeId} | 
[**PutEventsConfig**](RealmsAdminApi.md#puteventsconfig) | **Put** /{realm}/events/config | 
[**PutLocalization**](RealmsAdminApi.md#putlocalization) | **Put** /{realm}/localization/{locale}/{key} | 
[**PutPolicies**](RealmsAdminApi.md#putpolicies) | **Put** /{realm}/client-policies/policies | 
[**PutProfiles**](RealmsAdminApi.md#putprofiles) | **Put** /{realm}/client-policies/profiles | 
[**PutUsersManagementPermissions**](RealmsAdminApi.md#putusersmanagementpermissions) | **Put** /{realm}/users-management-permissions | 


<a name="deleteadminevents"></a>
# **DeleteAdminEvents**
> void DeleteAdminEvents (string realm, CancellationToken ct)



Delete all admin events

### Example
```csharp
using System;
using System.Diagnostics;
using ;
using Keycloak.Client;
using Keycloak.Client.Models;

namespace Example
{
    public class DeleteAdminEventsExample
    {
        public void main()
        {
            var apiInstance = new RealmsAdminApi(new HttpClient(), "http://my-service.srv");
            var realm = realm_example;  // string | realm name (not id!)
            var ct = new CancellationToken(); // CancellationToken |  (optional) 

            try
            {
                apiInstance.DeleteAdminEvents(realm, ct);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling RealmsAdminApi.DeleteAdminEvents: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **realm** | **string**| realm name (not id!) | 
 **ct** | [**CancellationToken**](.md)|  | [optional] 

### Return type

void (empty response body)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="deletebyrealm"></a>
# **DeleteByRealm**
> void DeleteByRealm (string realm, CancellationToken ct)



Delete the realm

### Example
```csharp
using System;
using System.Diagnostics;
using ;
using Keycloak.Client;
using Keycloak.Client.Models;

namespace Example
{
    public class DeleteByRealmExample
    {
        public void main()
        {
            var apiInstance = new RealmsAdminApi(new HttpClient(), "http://my-service.srv");
            var realm = realm_example;  // string | realm name (not id!)
            var ct = new CancellationToken(); // CancellationToken |  (optional) 

            try
            {
                apiInstance.DeleteByRealm(realm, ct);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling RealmsAdminApi.DeleteByRealm: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **realm** | **string**| realm name (not id!) | 
 **ct** | [**CancellationToken**](.md)|  | [optional] 

### Return type

void (empty response body)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="deletedefaultdefaultclientscope"></a>
# **DeleteDefaultDefaultClientScope**
> void DeleteDefaultDefaultClientScope (string realm, string clientScopeId, CancellationToken ct)



### Example
```csharp
using System;
using System.Diagnostics;
using ;
using Keycloak.Client;
using Keycloak.Client.Models;

namespace Example
{
    public class DeleteDefaultDefaultClientScopeExample
    {
        public void main()
        {
            var apiInstance = new RealmsAdminApi(new HttpClient(), "http://my-service.srv");
            var realm = realm_example;  // string | realm name (not id!)
            var clientScopeId = clientScopeId_example;  // string | 
            var ct = new CancellationToken(); // CancellationToken |  (optional) 

            try
            {
                apiInstance.DeleteDefaultDefaultClientScope(realm, clientScopeId, ct);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling RealmsAdminApi.DeleteDefaultDefaultClientScope: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **realm** | **string**| realm name (not id!) | 
 **clientScopeId** | **string**|  | 
 **ct** | [**CancellationToken**](.md)|  | [optional] 

### Return type

void (empty response body)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="deletedefaultgroup"></a>
# **DeleteDefaultGroup**
> void DeleteDefaultGroup (string realm, string groupId, CancellationToken ct)



### Example
```csharp
using System;
using System.Diagnostics;
using ;
using Keycloak.Client;
using Keycloak.Client.Models;

namespace Example
{
    public class DeleteDefaultGroupExample
    {
        public void main()
        {
            var apiInstance = new RealmsAdminApi(new HttpClient(), "http://my-service.srv");
            var realm = realm_example;  // string | realm name (not id!)
            var groupId = groupId_example;  // string | 
            var ct = new CancellationToken(); // CancellationToken |  (optional) 

            try
            {
                apiInstance.DeleteDefaultGroup(realm, groupId, ct);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling RealmsAdminApi.DeleteDefaultGroup: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **realm** | **string**| realm name (not id!) | 
 **groupId** | **string**|  | 
 **ct** | [**CancellationToken**](.md)|  | [optional] 

### Return type

void (empty response body)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="deletedefaultoptionalclientscope"></a>
# **DeleteDefaultOptionalClientScope**
> void DeleteDefaultOptionalClientScope (string realm, string clientScopeId, CancellationToken ct)



### Example
```csharp
using System;
using System.Diagnostics;
using ;
using Keycloak.Client;
using Keycloak.Client.Models;

namespace Example
{
    public class DeleteDefaultOptionalClientScopeExample
    {
        public void main()
        {
            var apiInstance = new RealmsAdminApi(new HttpClient(), "http://my-service.srv");
            var realm = realm_example;  // string | realm name (not id!)
            var clientScopeId = clientScopeId_example;  // string | 
            var ct = new CancellationToken(); // CancellationToken |  (optional) 

            try
            {
                apiInstance.DeleteDefaultOptionalClientScope(realm, clientScopeId, ct);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling RealmsAdminApi.DeleteDefaultOptionalClientScope: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **realm** | **string**| realm name (not id!) | 
 **clientScopeId** | **string**|  | 
 **ct** | [**CancellationToken**](.md)|  | [optional] 

### Return type

void (empty response body)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="deleteevents"></a>
# **DeleteEvents**
> void DeleteEvents (string realm, CancellationToken ct)



Delete all events

### Example
```csharp
using System;
using System.Diagnostics;
using ;
using Keycloak.Client;
using Keycloak.Client.Models;

namespace Example
{
    public class DeleteEventsExample
    {
        public void main()
        {
            var apiInstance = new RealmsAdminApi(new HttpClient(), "http://my-service.srv");
            var realm = realm_example;  // string | realm name (not id!)
            var ct = new CancellationToken(); // CancellationToken |  (optional) 

            try
            {
                apiInstance.DeleteEvents(realm, ct);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling RealmsAdminApi.DeleteEvents: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **realm** | **string**| realm name (not id!) | 
 **ct** | [**CancellationToken**](.md)|  | [optional] 

### Return type

void (empty response body)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="deletelocalizationbyrealmbylocale"></a>
# **DeleteLocalizationByRealmByLocale**
> void DeleteLocalizationByRealmByLocale (string realm, string locale, CancellationToken ct)



### Example
```csharp
using System;
using System.Diagnostics;
using ;
using Keycloak.Client;
using Keycloak.Client.Models;

namespace Example
{
    public class DeleteLocalizationByRealmByLocaleExample
    {
        public void main()
        {
            var apiInstance = new RealmsAdminApi(new HttpClient(), "http://my-service.srv");
            var realm = realm_example;  // string | realm name (not id!)
            var locale = locale_example;  // string | 
            var ct = new CancellationToken(); // CancellationToken |  (optional) 

            try
            {
                apiInstance.DeleteLocalizationByRealmByLocale(realm, locale, ct);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling RealmsAdminApi.DeleteLocalizationByRealmByLocale: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **realm** | **string**| realm name (not id!) | 
 **locale** | **string**|  | 
 **ct** | [**CancellationToken**](.md)|  | [optional] 

### Return type

void (empty response body)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="deletelocalizationbyrealmbylocalebykey"></a>
# **DeleteLocalizationByRealmByLocaleByKey**
> void DeleteLocalizationByRealmByLocaleByKey (string realm, string locale, string key, CancellationToken ct)



### Example
```csharp
using System;
using System.Diagnostics;
using ;
using Keycloak.Client;
using Keycloak.Client.Models;

namespace Example
{
    public class DeleteLocalizationByRealmByLocaleByKeyExample
    {
        public void main()
        {
            var apiInstance = new RealmsAdminApi(new HttpClient(), "http://my-service.srv");
            var realm = realm_example;  // string | realm name (not id!)
            var locale = locale_example;  // string | 
            var key = key_example;  // string | 
            var ct = new CancellationToken(); // CancellationToken |  (optional) 

            try
            {
                apiInstance.DeleteLocalizationByRealmByLocaleByKey(realm, locale, key, ct);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling RealmsAdminApi.DeleteLocalizationByRealmByLocaleByKey: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **realm** | **string**| realm name (not id!) | 
 **locale** | **string**|  | 
 **key** | **string**|  | 
 **ct** | [**CancellationToken**](.md)|  | [optional] 

### Return type

void (empty response body)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="deletesession"></a>
# **DeleteSession**
> void DeleteSession (string realm, string session, CancellationToken ct)



Remove a specific user session.

### Example
```csharp
using System;
using System.Diagnostics;
using ;
using Keycloak.Client;
using Keycloak.Client.Models;

namespace Example
{
    public class DeleteSessionExample
    {
        public void main()
        {
            var apiInstance = new RealmsAdminApi(new HttpClient(), "http://my-service.srv");
            var realm = realm_example;  // string | realm name (not id!)
            var session = session_example;  // string | 
            var ct = new CancellationToken(); // CancellationToken |  (optional) 

            try
            {
                apiInstance.DeleteSession(realm, session, ct);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling RealmsAdminApi.DeleteSession: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **realm** | **string**| realm name (not id!) | 
 **session** | **string**|  | 
 **ct** | [**CancellationToken**](.md)|  | [optional] 

### Return type

void (empty response body)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="get"></a>
# **Get**
> List<RealmRepresentation> Get (string briefRepresentation, CancellationToken ct)



Get accessible realms Returns a list of accessible realms. The list is filtered based on what realms the caller is allowed to view.

### Example
```csharp
using System;
using System.Diagnostics;
using ;
using Keycloak.Client;
using Keycloak.Client.Models;

namespace Example
{
    public class GetExample
    {
        public void main()
        {
            var apiInstance = new RealmsAdminApi(new HttpClient(), "http://my-service.srv");
            var briefRepresentation = briefRepresentation_example;  // string |  (optional) 
            var ct = new CancellationToken(); // CancellationToken |  (optional) 

            try
            {
                List&lt;RealmRepresentation&gt; result = apiInstance.Get(briefRepresentation, ct);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling RealmsAdminApi.Get: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **briefRepresentation** | **string**|  | [optional] 
 **ct** | [**CancellationToken**](.md)|  | [optional] 

### Return type

[**List<RealmRepresentation>**](RealmRepresentation.md)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getadminevents"></a>
# **GetAdminEvents**
> List<AdminEventRepresentation> GetAdminEvents (string realm, string authClient, string authIpAddress, string authRealm, string authUser, string dateFrom, string dateTo, string first, string max, string operationTypes, string resourcePath, string resourceTypes, CancellationToken ct)



Get admin events Returns all admin events, or filters events based on URL query parameters listed here

### Example
```csharp
using System;
using System.Diagnostics;
using ;
using Keycloak.Client;
using Keycloak.Client.Models;

namespace Example
{
    public class GetAdminEventsExample
    {
        public void main()
        {
            var apiInstance = new RealmsAdminApi(new HttpClient(), "http://my-service.srv");
            var realm = realm_example;  // string | realm name (not id!)
            var authClient = authClient_example;  // string |  (optional) 
            var authIpAddress = authIpAddress_example;  // string |  (optional) 
            var authRealm = authRealm_example;  // string |  (optional) 
            var authUser = authUser_example;  // string | user id (optional) 
            var dateFrom = dateFrom_example;  // string |  (optional) 
            var dateTo = dateTo_example;  // string |  (optional) 
            var first = first_example;  // string |  (optional) 
            var max = max_example;  // string | Maximum results size (defaults to 100) (optional) 
            var operationTypes = operationTypes_example;  // string | [String] (optional) 
            var resourcePath = resourcePath_example;  // string |  (optional) 
            var resourceTypes = resourceTypes_example;  // string | [String] (optional) 
            var ct = new CancellationToken(); // CancellationToken |  (optional) 

            try
            {
                List&lt;AdminEventRepresentation&gt; result = apiInstance.GetAdminEvents(realm, authClient, authIpAddress, authRealm, authUser, dateFrom, dateTo, first, max, operationTypes, resourcePath, resourceTypes, ct);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling RealmsAdminApi.GetAdminEvents: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **realm** | **string**| realm name (not id!) | 
 **authClient** | **string**|  | [optional] 
 **authIpAddress** | **string**|  | [optional] 
 **authRealm** | **string**|  | [optional] 
 **authUser** | **string**| user id | [optional] 
 **dateFrom** | **string**|  | [optional] 
 **dateTo** | **string**|  | [optional] 
 **first** | **string**|  | [optional] 
 **max** | **string**| Maximum results size (defaults to 100) | [optional] 
 **operationTypes** | **string**| [String] | [optional] 
 **resourcePath** | **string**|  | [optional] 
 **resourceTypes** | **string**| [String] | [optional] 
 **ct** | [**CancellationToken**](.md)|  | [optional] 

### Return type

[**List<AdminEventRepresentation>**](AdminEventRepresentation.md)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getbyrealm"></a>
# **GetByRealm**
> RealmRepresentation GetByRealm (string realm, CancellationToken ct)



Get the top-level representation of the realm It will not include nested information like User and Client representations.

### Example
```csharp
using System;
using System.Diagnostics;
using ;
using Keycloak.Client;
using Keycloak.Client.Models;

namespace Example
{
    public class GetByRealmExample
    {
        public void main()
        {
            var apiInstance = new RealmsAdminApi(new HttpClient(), "http://my-service.srv");
            var realm = realm_example;  // string | realm name (not id!)
            var ct = new CancellationToken(); // CancellationToken |  (optional) 

            try
            {
                RealmRepresentation result = apiInstance.GetByRealm(realm, ct);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling RealmsAdminApi.GetByRealm: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **realm** | **string**| realm name (not id!) | 
 **ct** | [**CancellationToken**](.md)|  | [optional] 

### Return type

[**RealmRepresentation**](RealmRepresentation.md)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getclientsessionstats"></a>
# **GetClientSessionStats**
> List<string> GetClientSessionStats (string realm, CancellationToken ct)



Get client session stats Returns a JSON map.

### Example
```csharp
using System;
using System.Diagnostics;
using ;
using Keycloak.Client;
using Keycloak.Client.Models;

namespace Example
{
    public class GetClientSessionStatsExample
    {
        public void main()
        {
            var apiInstance = new RealmsAdminApi(new HttpClient(), "http://my-service.srv");
            var realm = realm_example;  // string | realm name (not id!)
            var ct = new CancellationToken(); // CancellationToken |  (optional) 

            try
            {
                List&lt;string&gt; result = apiInstance.GetClientSessionStats(realm, ct);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling RealmsAdminApi.GetClientSessionStats: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **realm** | **string**| realm name (not id!) | 
 **ct** | [**CancellationToken**](.md)|  | [optional] 

### Return type

**List<string>**

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getcredentialregistrators"></a>
# **GetCredentialRegistrators**
> List<string> GetCredentialRegistrators (string realm, CancellationToken ct)



### Example
```csharp
using System;
using System.Diagnostics;
using ;
using Keycloak.Client;
using Keycloak.Client.Models;

namespace Example
{
    public class GetCredentialRegistratorsExample
    {
        public void main()
        {
            var apiInstance = new RealmsAdminApi(new HttpClient(), "http://my-service.srv");
            var realm = realm_example;  // string | realm name (not id!)
            var ct = new CancellationToken(); // CancellationToken |  (optional) 

            try
            {
                List&lt;string&gt; result = apiInstance.GetCredentialRegistrators(realm, ct);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling RealmsAdminApi.GetCredentialRegistrators: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **realm** | **string**| realm name (not id!) | 
 **ct** | [**CancellationToken**](.md)|  | [optional] 

### Return type

**List<string>**

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getdefaultdefaultclientscopes"></a>
# **GetDefaultDefaultClientScopes**
> List<ClientScopeRepresentation> GetDefaultDefaultClientScopes (string realm, CancellationToken ct)



Get realm default client scopes.  Only name and ids are returned.

### Example
```csharp
using System;
using System.Diagnostics;
using ;
using Keycloak.Client;
using Keycloak.Client.Models;

namespace Example
{
    public class GetDefaultDefaultClientScopesExample
    {
        public void main()
        {
            var apiInstance = new RealmsAdminApi(new HttpClient(), "http://my-service.srv");
            var realm = realm_example;  // string | realm name (not id!)
            var ct = new CancellationToken(); // CancellationToken |  (optional) 

            try
            {
                List&lt;ClientScopeRepresentation&gt; result = apiInstance.GetDefaultDefaultClientScopes(realm, ct);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling RealmsAdminApi.GetDefaultDefaultClientScopes: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **realm** | **string**| realm name (not id!) | 
 **ct** | [**CancellationToken**](.md)|  | [optional] 

### Return type

[**List<ClientScopeRepresentation>**](ClientScopeRepresentation.md)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getdefaultgroups"></a>
# **GetDefaultGroups**
> List<GroupRepresentation> GetDefaultGroups (string realm, CancellationToken ct)



Get group hierarchy.  Only name and ids are returned.

### Example
```csharp
using System;
using System.Diagnostics;
using ;
using Keycloak.Client;
using Keycloak.Client.Models;

namespace Example
{
    public class GetDefaultGroupsExample
    {
        public void main()
        {
            var apiInstance = new RealmsAdminApi(new HttpClient(), "http://my-service.srv");
            var realm = realm_example;  // string | realm name (not id!)
            var ct = new CancellationToken(); // CancellationToken |  (optional) 

            try
            {
                List&lt;GroupRepresentation&gt; result = apiInstance.GetDefaultGroups(realm, ct);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling RealmsAdminApi.GetDefaultGroups: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **realm** | **string**| realm name (not id!) | 
 **ct** | [**CancellationToken**](.md)|  | [optional] 

### Return type

[**List<GroupRepresentation>**](GroupRepresentation.md)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getdefaultoptionalclientscopes"></a>
# **GetDefaultOptionalClientScopes**
> List<ClientScopeRepresentation> GetDefaultOptionalClientScopes (string realm, CancellationToken ct)



Get realm optional client scopes.  Only name and ids are returned.

### Example
```csharp
using System;
using System.Diagnostics;
using ;
using Keycloak.Client;
using Keycloak.Client.Models;

namespace Example
{
    public class GetDefaultOptionalClientScopesExample
    {
        public void main()
        {
            var apiInstance = new RealmsAdminApi(new HttpClient(), "http://my-service.srv");
            var realm = realm_example;  // string | realm name (not id!)
            var ct = new CancellationToken(); // CancellationToken |  (optional) 

            try
            {
                List&lt;ClientScopeRepresentation&gt; result = apiInstance.GetDefaultOptionalClientScopes(realm, ct);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling RealmsAdminApi.GetDefaultOptionalClientScopes: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **realm** | **string**| realm name (not id!) | 
 **ct** | [**CancellationToken**](.md)|  | [optional] 

### Return type

[**List<ClientScopeRepresentation>**](ClientScopeRepresentation.md)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getevents"></a>
# **GetEvents**
> List<EventRepresentation> GetEvents (string realm, string _client, string dateFrom, string dateTo, string first, string ipAddress, string max, string type, string user, CancellationToken ct)



Get events Returns all events, or filters them based on URL query parameters listed here

### Example
```csharp
using System;
using System.Diagnostics;
using ;
using Keycloak.Client;
using Keycloak.Client.Models;

namespace Example
{
    public class GetEventsExample
    {
        public void main()
        {
            var apiInstance = new RealmsAdminApi(new HttpClient(), "http://my-service.srv");
            var realm = realm_example;  // string | realm name (not id!)
            var _client = _client_example;  // string | App or oauth client name (optional) 
            var dateFrom = dateFrom_example;  // string | From date (optional) 
            var dateTo = dateTo_example;  // string | To date (optional) 
            var first = first_example;  // string | Paging offset (optional) 
            var ipAddress = ipAddress_example;  // string | IP Address (optional) 
            var max = max_example;  // string | Maximum results size (defaults to 100) (optional) 
            var type = type_example;  // string | The types of events to return [String] (optional) 
            var user = user_example;  // string | User id (optional) 
            var ct = new CancellationToken(); // CancellationToken |  (optional) 

            try
            {
                List&lt;EventRepresentation&gt; result = apiInstance.GetEvents(realm, _client, dateFrom, dateTo, first, ipAddress, max, type, user, ct);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling RealmsAdminApi.GetEvents: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **realm** | **string**| realm name (not id!) | 
 **_client** | **string**| App or oauth client name | [optional] 
 **dateFrom** | **string**| From date | [optional] 
 **dateTo** | **string**| To date | [optional] 
 **first** | **string**| Paging offset | [optional] 
 **ipAddress** | **string**| IP Address | [optional] 
 **max** | **string**| Maximum results size (defaults to 100) | [optional] 
 **type** | **string**| The types of events to return [String] | [optional] 
 **user** | **string**| User id | [optional] 
 **ct** | [**CancellationToken**](.md)|  | [optional] 

### Return type

[**List<EventRepresentation>**](EventRepresentation.md)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="geteventsconfig"></a>
# **GetEventsConfig**
> RealmEventsConfigRepresentation GetEventsConfig (string realm, CancellationToken ct)



Get the events provider configuration Returns JSON object with events provider configuration

### Example
```csharp
using System;
using System.Diagnostics;
using ;
using Keycloak.Client;
using Keycloak.Client.Models;

namespace Example
{
    public class GetEventsConfigExample
    {
        public void main()
        {
            var apiInstance = new RealmsAdminApi(new HttpClient(), "http://my-service.srv");
            var realm = realm_example;  // string | realm name (not id!)
            var ct = new CancellationToken(); // CancellationToken |  (optional) 

            try
            {
                RealmEventsConfigRepresentation result = apiInstance.GetEventsConfig(realm, ct);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling RealmsAdminApi.GetEventsConfig: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **realm** | **string**| realm name (not id!) | 
 **ct** | [**CancellationToken**](.md)|  | [optional] 

### Return type

[**RealmEventsConfigRepresentation**](RealmEventsConfigRepresentation.md)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getgroupbypath"></a>
# **GetGroupByPath**
> GroupRepresentation GetGroupByPath (string realm, string path, CancellationToken ct)



### Example
```csharp
using System;
using System.Diagnostics;
using ;
using Keycloak.Client;
using Keycloak.Client.Models;

namespace Example
{
    public class GetGroupByPathExample
    {
        public void main()
        {
            var apiInstance = new RealmsAdminApi(new HttpClient(), "http://my-service.srv");
            var realm = realm_example;  // string | realm name (not id!)
            var path = path_example;  // string | PathSegment
            var ct = new CancellationToken(); // CancellationToken |  (optional) 

            try
            {
                GroupRepresentation result = apiInstance.GetGroupByPath(realm, path, ct);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling RealmsAdminApi.GetGroupByPath: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **realm** | **string**| realm name (not id!) | 
 **path** | **string**| PathSegment | 
 **ct** | [**CancellationToken**](.md)|  | [optional] 

### Return type

[**GroupRepresentation**](GroupRepresentation.md)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getlocalizationbyrealm"></a>
# **GetLocalizationByRealm**
> List<string> GetLocalizationByRealm (string realm, CancellationToken ct)



### Example
```csharp
using System;
using System.Diagnostics;
using ;
using Keycloak.Client;
using Keycloak.Client.Models;

namespace Example
{
    public class GetLocalizationByRealmExample
    {
        public void main()
        {
            var apiInstance = new RealmsAdminApi(new HttpClient(), "http://my-service.srv");
            var realm = realm_example;  // string | realm name (not id!)
            var ct = new CancellationToken(); // CancellationToken |  (optional) 

            try
            {
                List&lt;string&gt; result = apiInstance.GetLocalizationByRealm(realm, ct);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling RealmsAdminApi.GetLocalizationByRealm: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **realm** | **string**| realm name (not id!) | 
 **ct** | [**CancellationToken**](.md)|  | [optional] 

### Return type

**List<string>**

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getlocalizationbyrealmbylocale"></a>
# **GetLocalizationByRealmByLocale**
> Dictionary<string, string> GetLocalizationByRealmByLocale (string realm, string locale, string useRealmDefaultLocaleFallback, CancellationToken ct)



### Example
```csharp
using System;
using System.Diagnostics;
using ;
using Keycloak.Client;
using Keycloak.Client.Models;

namespace Example
{
    public class GetLocalizationByRealmByLocaleExample
    {
        public void main()
        {
            var apiInstance = new RealmsAdminApi(new HttpClient(), "http://my-service.srv");
            var realm = realm_example;  // string | realm name (not id!)
            var locale = locale_example;  // string | 
            var useRealmDefaultLocaleFallback = useRealmDefaultLocaleFallback_example;  // string |  (optional) 
            var ct = new CancellationToken(); // CancellationToken |  (optional) 

            try
            {
                Dictionary&lt;string, string&gt; result = apiInstance.GetLocalizationByRealmByLocale(realm, locale, useRealmDefaultLocaleFallback, ct);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling RealmsAdminApi.GetLocalizationByRealmByLocale: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **realm** | **string**| realm name (not id!) | 
 **locale** | **string**|  | 
 **useRealmDefaultLocaleFallback** | **string**|  | [optional] 
 **ct** | [**CancellationToken**](.md)|  | [optional] 

### Return type

**Dictionary<string, string>**

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getlocalizationbyrealmbylocalebykey"></a>
# **GetLocalizationByRealmByLocaleByKey**
> string GetLocalizationByRealmByLocaleByKey (string realm, string locale, string key, CancellationToken ct)



### Example
```csharp
using System;
using System.Diagnostics;
using ;
using Keycloak.Client;
using Keycloak.Client.Models;

namespace Example
{
    public class GetLocalizationByRealmByLocaleByKeyExample
    {
        public void main()
        {
            var apiInstance = new RealmsAdminApi(new HttpClient(), "http://my-service.srv");
            var realm = realm_example;  // string | realm name (not id!)
            var locale = locale_example;  // string | 
            var key = key_example;  // string | 
            var ct = new CancellationToken(); // CancellationToken |  (optional) 

            try
            {
                string result = apiInstance.GetLocalizationByRealmByLocaleByKey(realm, locale, key, ct);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling RealmsAdminApi.GetLocalizationByRealmByLocaleByKey: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **realm** | **string**| realm name (not id!) | 
 **locale** | **string**|  | 
 **key** | **string**|  | 
 **ct** | [**CancellationToken**](.md)|  | [optional] 

### Return type

**string**

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getpolicies"></a>
# **GetPolicies**
> ClientPoliciesRepresentation GetPolicies (string realm, CancellationToken ct)



### Example
```csharp
using System;
using System.Diagnostics;
using ;
using Keycloak.Client;
using Keycloak.Client.Models;

namespace Example
{
    public class GetPoliciesExample
    {
        public void main()
        {
            var apiInstance = new RealmsAdminApi(new HttpClient(), "http://my-service.srv");
            var realm = realm_example;  // string | realm name (not id!)
            var ct = new CancellationToken(); // CancellationToken |  (optional) 

            try
            {
                ClientPoliciesRepresentation result = apiInstance.GetPolicies(realm, ct);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling RealmsAdminApi.GetPolicies: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **realm** | **string**| realm name (not id!) | 
 **ct** | [**CancellationToken**](.md)|  | [optional] 

### Return type

[**ClientPoliciesRepresentation**](ClientPoliciesRepresentation.md)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getprofiles"></a>
# **GetProfiles**
> ClientProfilesRepresentation GetProfiles (string realm, string includeGlobalProfiles, CancellationToken ct)



### Example
```csharp
using System;
using System.Diagnostics;
using ;
using Keycloak.Client;
using Keycloak.Client.Models;

namespace Example
{
    public class GetProfilesExample
    {
        public void main()
        {
            var apiInstance = new RealmsAdminApi(new HttpClient(), "http://my-service.srv");
            var realm = realm_example;  // string | realm name (not id!)
            var includeGlobalProfiles = includeGlobalProfiles_example;  // string |  (optional) 
            var ct = new CancellationToken(); // CancellationToken |  (optional) 

            try
            {
                ClientProfilesRepresentation result = apiInstance.GetProfiles(realm, includeGlobalProfiles, ct);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling RealmsAdminApi.GetProfiles: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **realm** | **string**| realm name (not id!) | 
 **includeGlobalProfiles** | **string**|  | [optional] 
 **ct** | [**CancellationToken**](.md)|  | [optional] 

### Return type

[**ClientProfilesRepresentation**](ClientProfilesRepresentation.md)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getusersmanagementpermissions"></a>
# **GetUsersManagementPermissions**
> ManagementPermissionReference GetUsersManagementPermissions (string realm, CancellationToken ct)



### Example
```csharp
using System;
using System.Diagnostics;
using ;
using Keycloak.Client;
using Keycloak.Client.Models;

namespace Example
{
    public class GetUsersManagementPermissionsExample
    {
        public void main()
        {
            var apiInstance = new RealmsAdminApi(new HttpClient(), "http://my-service.srv");
            var realm = realm_example;  // string | realm name (not id!)
            var ct = new CancellationToken(); // CancellationToken |  (optional) 

            try
            {
                ManagementPermissionReference result = apiInstance.GetUsersManagementPermissions(realm, ct);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling RealmsAdminApi.GetUsersManagementPermissions: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **realm** | **string**| realm name (not id!) | 
 **ct** | [**CancellationToken**](.md)|  | [optional] 

### Return type

[**ManagementPermissionReference**](ManagementPermissionReference.md)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="post"></a>
# **Post**
> void Post (Object body, CancellationToken ct)



Import a realm. Imports a realm from a full representation of that realm.

### Example
```csharp
using System;
using System.Diagnostics;
using ;
using Keycloak.Client;
using Keycloak.Client.Models;

namespace Example
{
    public class PostExample
    {
        public void main()
        {
            var apiInstance = new RealmsAdminApi(new HttpClient(), "http://my-service.srv");
            var body = new Object(); // Object | [file] (optional) 
            var ct = new CancellationToken(); // CancellationToken |  (optional) 

            try
            {
                apiInstance.Post(body, ct);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling RealmsAdminApi.Post: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**Object**](Object.md)| [file] | [optional] 
 **ct** | [**CancellationToken**](.md)|  | [optional] 

### Return type

void (empty response body)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="postclientdescriptionconverter"></a>
# **PostClientDescriptionConverter**
> ClientRepresentation PostClientDescriptionConverter (string realm, string body, CancellationToken ct)



Base path for importing clients under this realm.

### Example
```csharp
using System;
using System.Diagnostics;
using ;
using Keycloak.Client;
using Keycloak.Client.Models;

namespace Example
{
    public class PostClientDescriptionConverterExample
    {
        public void main()
        {
            var apiInstance = new RealmsAdminApi(new HttpClient(), "http://my-service.srv");
            var realm = realm_example;  // string | realm name (not id!)
            var body = new string(); // string | [string] (optional) 
            var ct = new CancellationToken(); // CancellationToken |  (optional) 

            try
            {
                ClientRepresentation result = apiInstance.PostClientDescriptionConverter(realm, body, ct);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling RealmsAdminApi.PostClientDescriptionConverter: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **realm** | **string**| realm name (not id!) | 
 **body** | [**string**](string.md)| [string] | [optional] 
 **ct** | [**CancellationToken**](.md)|  | [optional] 

### Return type

[**ClientRepresentation**](ClientRepresentation.md)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="postlocalization"></a>
# **PostLocalization**
> void PostLocalization (string realm, string locale, string body, CancellationToken ct)



Import localization from uploaded JSON file

### Example
```csharp
using System;
using System.Diagnostics;
using ;
using Keycloak.Client;
using Keycloak.Client.Models;

namespace Example
{
    public class PostLocalizationExample
    {
        public void main()
        {
            var apiInstance = new RealmsAdminApi(new HttpClient(), "http://my-service.srv");
            var realm = realm_example;  // string | realm name (not id!)
            var locale = locale_example;  // string | 
            var body = new string(); // string | [string] (optional) 
            var ct = new CancellationToken(); // CancellationToken |  (optional) 

            try
            {
                apiInstance.PostLocalization(realm, locale, body, ct);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling RealmsAdminApi.PostLocalization: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **realm** | **string**| realm name (not id!) | 
 **locale** | **string**|  | 
 **body** | [**string**](string.md)| [string] | [optional] 
 **ct** | [**CancellationToken**](.md)|  | [optional] 

### Return type

void (empty response body)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="postlogoutall"></a>
# **PostLogoutAll**
> GlobalRequestResult PostLogoutAll (string realm, CancellationToken ct)



Removes all user sessions.

### Example
```csharp
using System;
using System.Diagnostics;
using ;
using Keycloak.Client;
using Keycloak.Client.Models;

namespace Example
{
    public class PostLogoutAllExample
    {
        public void main()
        {
            var apiInstance = new RealmsAdminApi(new HttpClient(), "http://my-service.srv");
            var realm = realm_example;  // string | realm name (not id!)
            var ct = new CancellationToken(); // CancellationToken |  (optional) 

            try
            {
                GlobalRequestResult result = apiInstance.PostLogoutAll(realm, ct);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling RealmsAdminApi.PostLogoutAll: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **realm** | **string**| realm name (not id!) | 
 **ct** | [**CancellationToken**](.md)|  | [optional] 

### Return type

[**GlobalRequestResult**](GlobalRequestResult.md)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="postpartialexport"></a>
# **PostPartialExport**
> void PostPartialExport (string realm, string exportClients, string exportGroupsAndRoles, CancellationToken ct)



Partial export of existing realm into a JSON file.

### Example
```csharp
using System;
using System.Diagnostics;
using ;
using Keycloak.Client;
using Keycloak.Client.Models;

namespace Example
{
    public class PostPartialExportExample
    {
        public void main()
        {
            var apiInstance = new RealmsAdminApi(new HttpClient(), "http://my-service.srv");
            var realm = realm_example;  // string | realm name (not id!)
            var exportClients = exportClients_example;  // string |  (optional) 
            var exportGroupsAndRoles = exportGroupsAndRoles_example;  // string |  (optional) 
            var ct = new CancellationToken(); // CancellationToken |  (optional) 

            try
            {
                apiInstance.PostPartialExport(realm, exportClients, exportGroupsAndRoles, ct);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling RealmsAdminApi.PostPartialExport: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **realm** | **string**| realm name (not id!) | 
 **exportClients** | **string**|  | [optional] 
 **exportGroupsAndRoles** | **string**|  | [optional] 
 **ct** | [**CancellationToken**](.md)|  | [optional] 

### Return type

void (empty response body)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="postpartialimport"></a>
# **PostPartialImport**
> void PostPartialImport (string realm, Object body, CancellationToken ct)



Partial import from a JSON file to an existing realm.

### Example
```csharp
using System;
using System.Diagnostics;
using ;
using Keycloak.Client;
using Keycloak.Client.Models;

namespace Example
{
    public class PostPartialImportExample
    {
        public void main()
        {
            var apiInstance = new RealmsAdminApi(new HttpClient(), "http://my-service.srv");
            var realm = realm_example;  // string | realm name (not id!)
            var body = new Object(); // Object | [file] (optional) 
            var ct = new CancellationToken(); // CancellationToken |  (optional) 

            try
            {
                apiInstance.PostPartialImport(realm, body, ct);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling RealmsAdminApi.PostPartialImport: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **realm** | **string**| realm name (not id!) | 
 **body** | [**Object**](Object.md)| [file] | [optional] 
 **ct** | [**CancellationToken**](.md)|  | [optional] 

### Return type

void (empty response body)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="postpushrevocationbyrealm"></a>
# **PostPushRevocationByRealm**
> GlobalRequestResult PostPushRevocationByRealm (string realm, CancellationToken ct)



Push the realm’s revocation policy to any client that has an admin url associated with it.

### Example
```csharp
using System;
using System.Diagnostics;
using ;
using Keycloak.Client;
using Keycloak.Client.Models;

namespace Example
{
    public class PostPushRevocationByRealmExample
    {
        public void main()
        {
            var apiInstance = new RealmsAdminApi(new HttpClient(), "http://my-service.srv");
            var realm = realm_example;  // string | realm name (not id!)
            var ct = new CancellationToken(); // CancellationToken |  (optional) 

            try
            {
                GlobalRequestResult result = apiInstance.PostPushRevocationByRealm(realm, ct);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling RealmsAdminApi.PostPushRevocationByRealm: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **realm** | **string**| realm name (not id!) | 
 **ct** | [**CancellationToken**](.md)|  | [optional] 

### Return type

[**GlobalRequestResult**](GlobalRequestResult.md)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="posttestsmtpconnection"></a>
# **PostTestSmtpConnection**
> void PostTestSmtpConnection (string realm, string body, CancellationToken ct)



Test SMTP connection with current logged in user

### Example
```csharp
using System;
using System.Diagnostics;
using ;
using Keycloak.Client;
using Keycloak.Client.Models;

namespace Example
{
    public class PostTestSmtpConnectionExample
    {
        public void main()
        {
            var apiInstance = new RealmsAdminApi(new HttpClient(), "http://my-service.srv");
            var realm = realm_example;  // string | realm name (not id!)
            var body = new string(); // string | [string] (optional) 
            var ct = new CancellationToken(); // CancellationToken |  (optional) 

            try
            {
                apiInstance.PostTestSmtpConnection(realm, body, ct);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling RealmsAdminApi.PostTestSmtpConnection: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **realm** | **string**| realm name (not id!) | 
 **body** | [**string**](string.md)| [string] | [optional] 
 **ct** | [**CancellationToken**](.md)|  | [optional] 

### Return type

void (empty response body)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="putbyrealm"></a>
# **PutByRealm**
> void PutByRealm (string realm, RealmRepresentation body, CancellationToken ct)



Update the top-level information of the realm Any user, roles or client information in the representation will be ignored.

### Example
```csharp
using System;
using System.Diagnostics;
using ;
using Keycloak.Client;
using Keycloak.Client.Models;

namespace Example
{
    public class PutByRealmExample
    {
        public void main()
        {
            var apiInstance = new RealmsAdminApi(new HttpClient(), "http://my-service.srv");
            var realm = realm_example;  // string | realm name (not id!)
            var body = new RealmRepresentation(); // RealmRepresentation | RealmRepresentation (optional) 
            var ct = new CancellationToken(); // CancellationToken |  (optional) 

            try
            {
                apiInstance.PutByRealm(realm, body, ct);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling RealmsAdminApi.PutByRealm: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **realm** | **string**| realm name (not id!) | 
 **body** | [**RealmRepresentation**](RealmRepresentation.md)| RealmRepresentation | [optional] 
 **ct** | [**CancellationToken**](.md)|  | [optional] 

### Return type

void (empty response body)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="putdefaultdefaultclientscope"></a>
# **PutDefaultDefaultClientScope**
> void PutDefaultDefaultClientScope (string realm, string clientScopeId, CancellationToken ct)



### Example
```csharp
using System;
using System.Diagnostics;
using ;
using Keycloak.Client;
using Keycloak.Client.Models;

namespace Example
{
    public class PutDefaultDefaultClientScopeExample
    {
        public void main()
        {
            var apiInstance = new RealmsAdminApi(new HttpClient(), "http://my-service.srv");
            var realm = realm_example;  // string | realm name (not id!)
            var clientScopeId = clientScopeId_example;  // string | 
            var ct = new CancellationToken(); // CancellationToken |  (optional) 

            try
            {
                apiInstance.PutDefaultDefaultClientScope(realm, clientScopeId, ct);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling RealmsAdminApi.PutDefaultDefaultClientScope: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **realm** | **string**| realm name (not id!) | 
 **clientScopeId** | **string**|  | 
 **ct** | [**CancellationToken**](.md)|  | [optional] 

### Return type

void (empty response body)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="putdefaultgroup"></a>
# **PutDefaultGroup**
> void PutDefaultGroup (string realm, string groupId, CancellationToken ct)



### Example
```csharp
using System;
using System.Diagnostics;
using ;
using Keycloak.Client;
using Keycloak.Client.Models;

namespace Example
{
    public class PutDefaultGroupExample
    {
        public void main()
        {
            var apiInstance = new RealmsAdminApi(new HttpClient(), "http://my-service.srv");
            var realm = realm_example;  // string | realm name (not id!)
            var groupId = groupId_example;  // string | 
            var ct = new CancellationToken(); // CancellationToken |  (optional) 

            try
            {
                apiInstance.PutDefaultGroup(realm, groupId, ct);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling RealmsAdminApi.PutDefaultGroup: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **realm** | **string**| realm name (not id!) | 
 **groupId** | **string**|  | 
 **ct** | [**CancellationToken**](.md)|  | [optional] 

### Return type

void (empty response body)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="putdefaultoptionalclientscope"></a>
# **PutDefaultOptionalClientScope**
> void PutDefaultOptionalClientScope (string realm, string clientScopeId, CancellationToken ct)



### Example
```csharp
using System;
using System.Diagnostics;
using ;
using Keycloak.Client;
using Keycloak.Client.Models;

namespace Example
{
    public class PutDefaultOptionalClientScopeExample
    {
        public void main()
        {
            var apiInstance = new RealmsAdminApi(new HttpClient(), "http://my-service.srv");
            var realm = realm_example;  // string | realm name (not id!)
            var clientScopeId = clientScopeId_example;  // string | 
            var ct = new CancellationToken(); // CancellationToken |  (optional) 

            try
            {
                apiInstance.PutDefaultOptionalClientScope(realm, clientScopeId, ct);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling RealmsAdminApi.PutDefaultOptionalClientScope: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **realm** | **string**| realm name (not id!) | 
 **clientScopeId** | **string**|  | 
 **ct** | [**CancellationToken**](.md)|  | [optional] 

### Return type

void (empty response body)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="puteventsconfig"></a>
# **PutEventsConfig**
> void PutEventsConfig (string realm, RealmEventsConfigRepresentation body, CancellationToken ct)



### Example
```csharp
using System;
using System.Diagnostics;
using ;
using Keycloak.Client;
using Keycloak.Client.Models;

namespace Example
{
    public class PutEventsConfigExample
    {
        public void main()
        {
            var apiInstance = new RealmsAdminApi(new HttpClient(), "http://my-service.srv");
            var realm = realm_example;  // string | realm name (not id!)
            var body = new RealmEventsConfigRepresentation(); // RealmEventsConfigRepresentation | RealmEventsConfigRepresentation (optional) 
            var ct = new CancellationToken(); // CancellationToken |  (optional) 

            try
            {
                apiInstance.PutEventsConfig(realm, body, ct);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling RealmsAdminApi.PutEventsConfig: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **realm** | **string**| realm name (not id!) | 
 **body** | [**RealmEventsConfigRepresentation**](RealmEventsConfigRepresentation.md)| RealmEventsConfigRepresentation | [optional] 
 **ct** | [**CancellationToken**](.md)|  | [optional] 

### Return type

void (empty response body)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="putlocalization"></a>
# **PutLocalization**
> void PutLocalization (string realm, string locale, string key, string body, CancellationToken ct)



### Example
```csharp
using System;
using System.Diagnostics;
using ;
using Keycloak.Client;
using Keycloak.Client.Models;

namespace Example
{
    public class PutLocalizationExample
    {
        public void main()
        {
            var apiInstance = new RealmsAdminApi(new HttpClient(), "http://my-service.srv");
            var realm = realm_example;  // string | realm name (not id!)
            var locale = locale_example;  // string | 
            var key = key_example;  // string | 
            var body = new string(); // string | [string] (optional) 
            var ct = new CancellationToken(); // CancellationToken |  (optional) 

            try
            {
                apiInstance.PutLocalization(realm, locale, key, body, ct);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling RealmsAdminApi.PutLocalization: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **realm** | **string**| realm name (not id!) | 
 **locale** | **string**|  | 
 **key** | **string**|  | 
 **body** | [**string**](string.md)| [string] | [optional] 
 **ct** | [**CancellationToken**](.md)|  | [optional] 

### Return type

void (empty response body)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="putpolicies"></a>
# **PutPolicies**
> void PutPolicies (string realm, ClientPoliciesRepresentation body, CancellationToken ct)



### Example
```csharp
using System;
using System.Diagnostics;
using ;
using Keycloak.Client;
using Keycloak.Client.Models;

namespace Example
{
    public class PutPoliciesExample
    {
        public void main()
        {
            var apiInstance = new RealmsAdminApi(new HttpClient(), "http://my-service.srv");
            var realm = realm_example;  // string | realm name (not id!)
            var body = new ClientPoliciesRepresentation(); // ClientPoliciesRepresentation | ClientPoliciesRepresentation (optional) 
            var ct = new CancellationToken(); // CancellationToken |  (optional) 

            try
            {
                apiInstance.PutPolicies(realm, body, ct);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling RealmsAdminApi.PutPolicies: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **realm** | **string**| realm name (not id!) | 
 **body** | [**ClientPoliciesRepresentation**](ClientPoliciesRepresentation.md)| ClientPoliciesRepresentation | [optional] 
 **ct** | [**CancellationToken**](.md)|  | [optional] 

### Return type

void (empty response body)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="putprofiles"></a>
# **PutProfiles**
> void PutProfiles (string realm, ClientProfilesRepresentation body, CancellationToken ct)



### Example
```csharp
using System;
using System.Diagnostics;
using ;
using Keycloak.Client;
using Keycloak.Client.Models;

namespace Example
{
    public class PutProfilesExample
    {
        public void main()
        {
            var apiInstance = new RealmsAdminApi(new HttpClient(), "http://my-service.srv");
            var realm = realm_example;  // string | realm name (not id!)
            var body = new ClientProfilesRepresentation(); // ClientProfilesRepresentation | ClientProfilesRepresentation (optional) 
            var ct = new CancellationToken(); // CancellationToken |  (optional) 

            try
            {
                apiInstance.PutProfiles(realm, body, ct);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling RealmsAdminApi.PutProfiles: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **realm** | **string**| realm name (not id!) | 
 **body** | [**ClientProfilesRepresentation**](ClientProfilesRepresentation.md)| ClientProfilesRepresentation | [optional] 
 **ct** | [**CancellationToken**](.md)|  | [optional] 

### Return type

void (empty response body)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="putusersmanagementpermissions"></a>
# **PutUsersManagementPermissions**
> ManagementPermissionReference PutUsersManagementPermissions (string realm, ManagementPermissionReference body, CancellationToken ct)



### Example
```csharp
using System;
using System.Diagnostics;
using ;
using Keycloak.Client;
using Keycloak.Client.Models;

namespace Example
{
    public class PutUsersManagementPermissionsExample
    {
        public void main()
        {
            var apiInstance = new RealmsAdminApi(new HttpClient(), "http://my-service.srv");
            var realm = realm_example;  // string | realm name (not id!)
            var body = new ManagementPermissionReference(); // ManagementPermissionReference | ManagementPermissionReference (optional) 
            var ct = new CancellationToken(); // CancellationToken |  (optional) 

            try
            {
                ManagementPermissionReference result = apiInstance.PutUsersManagementPermissions(realm, body, ct);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling RealmsAdminApi.PutUsersManagementPermissions: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **realm** | **string**| realm name (not id!) | 
 **body** | [**ManagementPermissionReference**](ManagementPermissionReference.md)| ManagementPermissionReference | [optional] 
 **ct** | [**CancellationToken**](.md)|  | [optional] 

### Return type

[**ManagementPermissionReference**](ManagementPermissionReference.md)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

