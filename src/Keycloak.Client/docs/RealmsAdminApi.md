# IO.Swagger.Api.RealmsAdminApi

All URIs are relative to *https://keycloak.example.com/admin/realms*

Method | HTTP request | Description
------------- | ------------- | -------------
[**DeleteAdminEvents**](RealmsAdminApi.md#deleteadminevents) | **DELETE** /{realm}/admin-events | 
[**DeleteByRealm**](RealmsAdminApi.md#deletebyrealm) | **DELETE** /{realm} | 
[**DeleteDefaultDefaultClientScope**](RealmsAdminApi.md#deletedefaultdefaultclientscope) | **DELETE** /{realm}/default-default-client-scopes/{clientScopeId} | 
[**DeleteDefaultGroup**](RealmsAdminApi.md#deletedefaultgroup) | **DELETE** /{realm}/default-groups/{groupId} | 
[**DeleteDefaultOptionalClientScope**](RealmsAdminApi.md#deletedefaultoptionalclientscope) | **DELETE** /{realm}/default-optional-client-scopes/{clientScopeId} | 
[**DeleteEvents**](RealmsAdminApi.md#deleteevents) | **DELETE** /{realm}/events | 
[**DeleteLocalizationByRealmByLocale**](RealmsAdminApi.md#deletelocalizationbyrealmbylocale) | **DELETE** /{realm}/localization/{locale} | 
[**DeleteLocalizationByRealmByLocaleByKey**](RealmsAdminApi.md#deletelocalizationbyrealmbylocalebykey) | **DELETE** /{realm}/localization/{locale}/{key} | 
[**DeleteSession**](RealmsAdminApi.md#deletesession) | **DELETE** /{realm}/sessions/{session} | 
[**Get**](RealmsAdminApi.md#get) | **GET** / | 
[**GetAdminEvents**](RealmsAdminApi.md#getadminevents) | **GET** /{realm}/admin-events | 
[**GetByRealm**](RealmsAdminApi.md#getbyrealm) | **GET** /{realm} | 
[**GetClientSessionStats**](RealmsAdminApi.md#getclientsessionstats) | **GET** /{realm}/client-session-stats | 
[**GetCredentialRegistrators**](RealmsAdminApi.md#getcredentialregistrators) | **GET** /{realm}/credential-registrators | 
[**GetDefaultDefaultClientScopes**](RealmsAdminApi.md#getdefaultdefaultclientscopes) | **GET** /{realm}/default-default-client-scopes | 
[**GetDefaultGroups**](RealmsAdminApi.md#getdefaultgroups) | **GET** /{realm}/default-groups | 
[**GetDefaultOptionalClientScopes**](RealmsAdminApi.md#getdefaultoptionalclientscopes) | **GET** /{realm}/default-optional-client-scopes | 
[**GetEvents**](RealmsAdminApi.md#getevents) | **GET** /{realm}/events | 
[**GetEventsConfig**](RealmsAdminApi.md#geteventsconfig) | **GET** /{realm}/events/config | 
[**GetGroupByPath**](RealmsAdminApi.md#getgroupbypath) | **GET** /{realm}/group-by-path/{path} | 
[**GetLocalizationByRealm**](RealmsAdminApi.md#getlocalizationbyrealm) | **GET** /{realm}/localization | 
[**GetLocalizationByRealmByLocale**](RealmsAdminApi.md#getlocalizationbyrealmbylocale) | **GET** /{realm}/localization/{locale} | 
[**GetLocalizationByRealmByLocaleByKey**](RealmsAdminApi.md#getlocalizationbyrealmbylocalebykey) | **GET** /{realm}/localization/{locale}/{key} | 
[**GetPolicies**](RealmsAdminApi.md#getpolicies) | **GET** /{realm}/client-policies/policies | 
[**GetProfiles**](RealmsAdminApi.md#getprofiles) | **GET** /{realm}/client-policies/profiles | 
[**GetUsersManagementPermissions**](RealmsAdminApi.md#getusersmanagementpermissions) | **GET** /{realm}/users-management-permissions | 
[**Post**](RealmsAdminApi.md#post) | **POST** / | 
[**PostClientDescriptionConverter**](RealmsAdminApi.md#postclientdescriptionconverter) | **POST** /{realm}/client-description-converter | 
[**PostLocalization**](RealmsAdminApi.md#postlocalization) | **POST** /{realm}/localization/{locale} | 
[**PostLogoutAll**](RealmsAdminApi.md#postlogoutall) | **POST** /{realm}/logout-all | 
[**PostPartialExport**](RealmsAdminApi.md#postpartialexport) | **POST** /{realm}/partial-export | 
[**PostPartialImport**](RealmsAdminApi.md#postpartialimport) | **POST** /{realm}/partialImport | 
[**PostPushRevocationByRealm**](RealmsAdminApi.md#postpushrevocationbyrealm) | **POST** /{realm}/push-revocation | 
[**PostTestSmtpConnection**](RealmsAdminApi.md#posttestsmtpconnection) | **POST** /{realm}/testSMTPConnection | 
[**PutByRealm**](RealmsAdminApi.md#putbyrealm) | **PUT** /{realm} | 
[**PutDefaultDefaultClientScope**](RealmsAdminApi.md#putdefaultdefaultclientscope) | **PUT** /{realm}/default-default-client-scopes/{clientScopeId} | 
[**PutDefaultGroup**](RealmsAdminApi.md#putdefaultgroup) | **PUT** /{realm}/default-groups/{groupId} | 
[**PutDefaultOptionalClientScope**](RealmsAdminApi.md#putdefaultoptionalclientscope) | **PUT** /{realm}/default-optional-client-scopes/{clientScopeId} | 
[**PutEventsConfig**](RealmsAdminApi.md#puteventsconfig) | **PUT** /{realm}/events/config | 
[**PutLocalization**](RealmsAdminApi.md#putlocalization) | **PUT** /{realm}/localization/{locale}/{key} | 
[**PutPolicies**](RealmsAdminApi.md#putpolicies) | **PUT** /{realm}/client-policies/policies | 
[**PutProfiles**](RealmsAdminApi.md#putprofiles) | **PUT** /{realm}/client-policies/profiles | 
[**PutUsersManagementPermissions**](RealmsAdminApi.md#putusersmanagementpermissions) | **PUT** /{realm}/users-management-permissions | 

<a name="deleteadminevents"></a>
# **DeleteAdminEvents**
> void DeleteAdminEvents (string realm)



Delete all admin events

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class DeleteAdminEventsExample
    {
        public void main()
        {


            var apiInstance = new RealmsAdminApi();
            var realm = realm_example;  // string | realm name (not id!)

            try
            {
                apiInstance.DeleteAdminEvents(realm);
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

### Return type

void (empty response body)

### Authorization

[access_token](../README.md#access_token)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="deletebyrealm"></a>
# **DeleteByRealm**
> void DeleteByRealm (string realm)



Delete the realm

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class DeleteByRealmExample
    {
        public void main()
        {


            var apiInstance = new RealmsAdminApi();
            var realm = realm_example;  // string | realm name (not id!)

            try
            {
                apiInstance.DeleteByRealm(realm);
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

### Return type

void (empty response body)

### Authorization

[access_token](../README.md#access_token)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="deletedefaultdefaultclientscope"></a>
# **DeleteDefaultDefaultClientScope**
> void DeleteDefaultDefaultClientScope (string realm, string clientScopeId)



### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class DeleteDefaultDefaultClientScopeExample
    {
        public void main()
        {


            var apiInstance = new RealmsAdminApi();
            var realm = realm_example;  // string | realm name (not id!)
            var clientScopeId = clientScopeId_example;  // string | 

            try
            {
                apiInstance.DeleteDefaultDefaultClientScope(realm, clientScopeId);
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

### Return type

void (empty response body)

### Authorization

[access_token](../README.md#access_token)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="deletedefaultgroup"></a>
# **DeleteDefaultGroup**
> void DeleteDefaultGroup (string realm, string groupId)



### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class DeleteDefaultGroupExample
    {
        public void main()
        {


            var apiInstance = new RealmsAdminApi();
            var realm = realm_example;  // string | realm name (not id!)
            var groupId = groupId_example;  // string | 

            try
            {
                apiInstance.DeleteDefaultGroup(realm, groupId);
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

### Return type

void (empty response body)

### Authorization

[access_token](../README.md#access_token)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="deletedefaultoptionalclientscope"></a>
# **DeleteDefaultOptionalClientScope**
> void DeleteDefaultOptionalClientScope (string realm, string clientScopeId)



### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class DeleteDefaultOptionalClientScopeExample
    {
        public void main()
        {


            var apiInstance = new RealmsAdminApi();
            var realm = realm_example;  // string | realm name (not id!)
            var clientScopeId = clientScopeId_example;  // string | 

            try
            {
                apiInstance.DeleteDefaultOptionalClientScope(realm, clientScopeId);
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

### Return type

void (empty response body)

### Authorization

[access_token](../README.md#access_token)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="deleteevents"></a>
# **DeleteEvents**
> void DeleteEvents (string realm)



Delete all events

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class DeleteEventsExample
    {
        public void main()
        {


            var apiInstance = new RealmsAdminApi();
            var realm = realm_example;  // string | realm name (not id!)

            try
            {
                apiInstance.DeleteEvents(realm);
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

### Return type

void (empty response body)

### Authorization

[access_token](../README.md#access_token)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="deletelocalizationbyrealmbylocale"></a>
# **DeleteLocalizationByRealmByLocale**
> void DeleteLocalizationByRealmByLocale (string realm, string locale)



### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class DeleteLocalizationByRealmByLocaleExample
    {
        public void main()
        {


            var apiInstance = new RealmsAdminApi();
            var realm = realm_example;  // string | realm name (not id!)
            var locale = locale_example;  // string | 

            try
            {
                apiInstance.DeleteLocalizationByRealmByLocale(realm, locale);
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

### Return type

void (empty response body)

### Authorization

[access_token](../README.md#access_token)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="deletelocalizationbyrealmbylocalebykey"></a>
# **DeleteLocalizationByRealmByLocaleByKey**
> void DeleteLocalizationByRealmByLocaleByKey (string realm, string locale, string key)



### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class DeleteLocalizationByRealmByLocaleByKeyExample
    {
        public void main()
        {


            var apiInstance = new RealmsAdminApi();
            var realm = realm_example;  // string | realm name (not id!)
            var locale = locale_example;  // string | 
            var key = key_example;  // string | 

            try
            {
                apiInstance.DeleteLocalizationByRealmByLocaleByKey(realm, locale, key);
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

### Return type

void (empty response body)

### Authorization

[access_token](../README.md#access_token)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="deletesession"></a>
# **DeleteSession**
> void DeleteSession (string realm, string session)



Remove a specific user session.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class DeleteSessionExample
    {
        public void main()
        {


            var apiInstance = new RealmsAdminApi();
            var realm = realm_example;  // string | realm name (not id!)
            var session = session_example;  // string | 

            try
            {
                apiInstance.DeleteSession(realm, session);
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

### Return type

void (empty response body)

### Authorization

[access_token](../README.md#access_token)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="get"></a>
# **Get**
> List<RealmRepresentation> Get (string briefRepresentation)



Get accessible realms Returns a list of accessible realms. The list is filtered based on what realms the caller is allowed to view.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class GetExample
    {
        public void main()
        {


            var apiInstance = new RealmsAdminApi();
            var briefRepresentation = briefRepresentation_example;  // string |  (optional) 

            try
            {
                List&lt;RealmRepresentation&gt; result = apiInstance.Get(briefRepresentation);
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

### Return type

[**List<RealmRepresentation>**](RealmRepresentation.md)

### Authorization

[access_token](../README.md#access_token)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getadminevents"></a>
# **GetAdminEvents**
> List<AdminEventRepresentation> GetAdminEvents (string realm, string authClient, string authIpAddress, string authRealm, string authUser, string dateFrom, string dateTo, string first, string max, string operationTypes, string resourcePath, string resourceTypes)



Get admin events Returns all admin events, or filters events based on URL query parameters listed here

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class GetAdminEventsExample
    {
        public void main()
        {


            var apiInstance = new RealmsAdminApi();
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

            try
            {
                List&lt;AdminEventRepresentation&gt; result = apiInstance.GetAdminEvents(realm, authClient, authIpAddress, authRealm, authUser, dateFrom, dateTo, first, max, operationTypes, resourcePath, resourceTypes);
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

### Return type

[**List<AdminEventRepresentation>**](AdminEventRepresentation.md)

### Authorization

[access_token](../README.md#access_token)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getbyrealm"></a>
# **GetByRealm**
> RealmRepresentation GetByRealm (string realm)



Get the top-level representation of the realm It will not include nested information like User and Client representations.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class GetByRealmExample
    {
        public void main()
        {


            var apiInstance = new RealmsAdminApi();
            var realm = realm_example;  // string | realm name (not id!)

            try
            {
                RealmRepresentation result = apiInstance.GetByRealm(realm);
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

### Return type

[**RealmRepresentation**](RealmRepresentation.md)

### Authorization

[access_token](../README.md#access_token)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getclientsessionstats"></a>
# **GetClientSessionStats**
> List<string> GetClientSessionStats (string realm)



Get client session stats Returns a JSON map.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class GetClientSessionStatsExample
    {
        public void main()
        {


            var apiInstance = new RealmsAdminApi();
            var realm = realm_example;  // string | realm name (not id!)

            try
            {
                List&lt;string&gt; result = apiInstance.GetClientSessionStats(realm);
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

### Return type

**List<string>**

### Authorization

[access_token](../README.md#access_token)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getcredentialregistrators"></a>
# **GetCredentialRegistrators**
> List<string> GetCredentialRegistrators (string realm)



### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class GetCredentialRegistratorsExample
    {
        public void main()
        {


            var apiInstance = new RealmsAdminApi();
            var realm = realm_example;  // string | realm name (not id!)

            try
            {
                List&lt;string&gt; result = apiInstance.GetCredentialRegistrators(realm);
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

### Return type

**List<string>**

### Authorization

[access_token](../README.md#access_token)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getdefaultdefaultclientscopes"></a>
# **GetDefaultDefaultClientScopes**
> List<ClientScopeRepresentation> GetDefaultDefaultClientScopes (string realm)



Get realm default client scopes.  Only name and ids are returned.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class GetDefaultDefaultClientScopesExample
    {
        public void main()
        {


            var apiInstance = new RealmsAdminApi();
            var realm = realm_example;  // string | realm name (not id!)

            try
            {
                List&lt;ClientScopeRepresentation&gt; result = apiInstance.GetDefaultDefaultClientScopes(realm);
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

### Return type

[**List<ClientScopeRepresentation>**](ClientScopeRepresentation.md)

### Authorization

[access_token](../README.md#access_token)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getdefaultgroups"></a>
# **GetDefaultGroups**
> List<GroupRepresentation> GetDefaultGroups (string realm)



Get group hierarchy.  Only name and ids are returned.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class GetDefaultGroupsExample
    {
        public void main()
        {


            var apiInstance = new RealmsAdminApi();
            var realm = realm_example;  // string | realm name (not id!)

            try
            {
                List&lt;GroupRepresentation&gt; result = apiInstance.GetDefaultGroups(realm);
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

### Return type

[**List<GroupRepresentation>**](GroupRepresentation.md)

### Authorization

[access_token](../README.md#access_token)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getdefaultoptionalclientscopes"></a>
# **GetDefaultOptionalClientScopes**
> List<ClientScopeRepresentation> GetDefaultOptionalClientScopes (string realm)



Get realm optional client scopes.  Only name and ids are returned.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class GetDefaultOptionalClientScopesExample
    {
        public void main()
        {


            var apiInstance = new RealmsAdminApi();
            var realm = realm_example;  // string | realm name (not id!)

            try
            {
                List&lt;ClientScopeRepresentation&gt; result = apiInstance.GetDefaultOptionalClientScopes(realm);
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

### Return type

[**List<ClientScopeRepresentation>**](ClientScopeRepresentation.md)

### Authorization

[access_token](../README.md#access_token)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getevents"></a>
# **GetEvents**
> List<EventRepresentation> GetEvents (string realm, string _client, string dateFrom, string dateTo, string first, string ipAddress, string max, string type, string user)



Get events Returns all events, or filters them based on URL query parameters listed here

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class GetEventsExample
    {
        public void main()
        {


            var apiInstance = new RealmsAdminApi();
            var realm = realm_example;  // string | realm name (not id!)
            var _client = _client_example;  // string | App or oauth client name (optional) 
            var dateFrom = dateFrom_example;  // string | From date (optional) 
            var dateTo = dateTo_example;  // string | To date (optional) 
            var first = first_example;  // string | Paging offset (optional) 
            var ipAddress = ipAddress_example;  // string | IP Address (optional) 
            var max = max_example;  // string | Maximum results size (defaults to 100) (optional) 
            var type = type_example;  // string | The types of events to return [String] (optional) 
            var user = user_example;  // string | User id (optional) 

            try
            {
                List&lt;EventRepresentation&gt; result = apiInstance.GetEvents(realm, _client, dateFrom, dateTo, first, ipAddress, max, type, user);
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

### Return type

[**List<EventRepresentation>**](EventRepresentation.md)

### Authorization

[access_token](../README.md#access_token)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="geteventsconfig"></a>
# **GetEventsConfig**
> RealmEventsConfigRepresentation GetEventsConfig (string realm)



Get the events provider configuration Returns JSON object with events provider configuration

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class GetEventsConfigExample
    {
        public void main()
        {


            var apiInstance = new RealmsAdminApi();
            var realm = realm_example;  // string | realm name (not id!)

            try
            {
                RealmEventsConfigRepresentation result = apiInstance.GetEventsConfig(realm);
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

### Return type

[**RealmEventsConfigRepresentation**](RealmEventsConfigRepresentation.md)

### Authorization

[access_token](../README.md#access_token)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getgroupbypath"></a>
# **GetGroupByPath**
> GroupRepresentation GetGroupByPath (string realm, string path)



### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class GetGroupByPathExample
    {
        public void main()
        {


            var apiInstance = new RealmsAdminApi();
            var realm = realm_example;  // string | realm name (not id!)
            var path = path_example;  // string | PathSegment

            try
            {
                GroupRepresentation result = apiInstance.GetGroupByPath(realm, path);
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

### Return type

[**GroupRepresentation**](GroupRepresentation.md)

### Authorization

[access_token](../README.md#access_token)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getlocalizationbyrealm"></a>
# **GetLocalizationByRealm**
> List<string> GetLocalizationByRealm (string realm)



### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class GetLocalizationByRealmExample
    {
        public void main()
        {


            var apiInstance = new RealmsAdminApi();
            var realm = realm_example;  // string | realm name (not id!)

            try
            {
                List&lt;string&gt; result = apiInstance.GetLocalizationByRealm(realm);
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

### Return type

**List<string>**

### Authorization

[access_token](../README.md#access_token)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getlocalizationbyrealmbylocale"></a>
# **GetLocalizationByRealmByLocale**
> Dictionary<string, string> GetLocalizationByRealmByLocale (string realm, string locale, string useRealmDefaultLocaleFallback)



### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class GetLocalizationByRealmByLocaleExample
    {
        public void main()
        {


            var apiInstance = new RealmsAdminApi();
            var realm = realm_example;  // string | realm name (not id!)
            var locale = locale_example;  // string | 
            var useRealmDefaultLocaleFallback = useRealmDefaultLocaleFallback_example;  // string |  (optional) 

            try
            {
                Dictionary&lt;string, string&gt; result = apiInstance.GetLocalizationByRealmByLocale(realm, locale, useRealmDefaultLocaleFallback);
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

### Return type

**Dictionary<string, string>**

### Authorization

[access_token](../README.md#access_token)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getlocalizationbyrealmbylocalebykey"></a>
# **GetLocalizationByRealmByLocaleByKey**
> string GetLocalizationByRealmByLocaleByKey (string realm, string locale, string key)



### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class GetLocalizationByRealmByLocaleByKeyExample
    {
        public void main()
        {


            var apiInstance = new RealmsAdminApi();
            var realm = realm_example;  // string | realm name (not id!)
            var locale = locale_example;  // string | 
            var key = key_example;  // string | 

            try
            {
                string result = apiInstance.GetLocalizationByRealmByLocaleByKey(realm, locale, key);
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

### Return type

**string**

### Authorization

[access_token](../README.md#access_token)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getpolicies"></a>
# **GetPolicies**
> ClientPoliciesRepresentation GetPolicies (string realm)



### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class GetPoliciesExample
    {
        public void main()
        {


            var apiInstance = new RealmsAdminApi();
            var realm = realm_example;  // string | realm name (not id!)

            try
            {
                ClientPoliciesRepresentation result = apiInstance.GetPolicies(realm);
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

### Return type

[**ClientPoliciesRepresentation**](ClientPoliciesRepresentation.md)

### Authorization

[access_token](../README.md#access_token)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getprofiles"></a>
# **GetProfiles**
> ClientProfilesRepresentation GetProfiles (string realm, string includeGlobalProfiles)



### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class GetProfilesExample
    {
        public void main()
        {


            var apiInstance = new RealmsAdminApi();
            var realm = realm_example;  // string | realm name (not id!)
            var includeGlobalProfiles = includeGlobalProfiles_example;  // string |  (optional) 

            try
            {
                ClientProfilesRepresentation result = apiInstance.GetProfiles(realm, includeGlobalProfiles);
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

### Return type

[**ClientProfilesRepresentation**](ClientProfilesRepresentation.md)

### Authorization

[access_token](../README.md#access_token)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getusersmanagementpermissions"></a>
# **GetUsersManagementPermissions**
> ManagementPermissionReference GetUsersManagementPermissions (string realm)



### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class GetUsersManagementPermissionsExample
    {
        public void main()
        {


            var apiInstance = new RealmsAdminApi();
            var realm = realm_example;  // string | realm name (not id!)

            try
            {
                ManagementPermissionReference result = apiInstance.GetUsersManagementPermissions(realm);
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

### Return type

[**ManagementPermissionReference**](ManagementPermissionReference.md)

### Authorization

[access_token](../README.md#access_token)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="post"></a>
# **Post**
> void Post (Object body)



Import a realm. Imports a realm from a full representation of that realm.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class PostExample
    {
        public void main()
        {


            var apiInstance = new RealmsAdminApi();
            var body = new Object(); // Object | [file] (optional) 

            try
            {
                apiInstance.Post(body);
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
 **body** | **Object**| [file] | [optional] 

### Return type

void (empty response body)

### Authorization

[access_token](../README.md#access_token)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="postclientdescriptionconverter"></a>
# **PostClientDescriptionConverter**
> ClientRepresentation PostClientDescriptionConverter (string realm, string body)



Base path for importing clients under this realm.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class PostClientDescriptionConverterExample
    {
        public void main()
        {


            var apiInstance = new RealmsAdminApi();
            var realm = realm_example;  // string | realm name (not id!)
            var body = new string(); // string | [string] (optional) 

            try
            {
                ClientRepresentation result = apiInstance.PostClientDescriptionConverter(realm, body);
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

### Return type

[**ClientRepresentation**](ClientRepresentation.md)

### Authorization

[access_token](../README.md#access_token)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="postlocalization"></a>
# **PostLocalization**
> void PostLocalization (string realm, string locale, string body)



Import localization from uploaded JSON file

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class PostLocalizationExample
    {
        public void main()
        {


            var apiInstance = new RealmsAdminApi();
            var realm = realm_example;  // string | realm name (not id!)
            var locale = locale_example;  // string | 
            var body = new string(); // string | [string] (optional) 

            try
            {
                apiInstance.PostLocalization(realm, locale, body);
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

### Return type

void (empty response body)

### Authorization

[access_token](../README.md#access_token)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="postlogoutall"></a>
# **PostLogoutAll**
> GlobalRequestResult PostLogoutAll (string realm)



Removes all user sessions.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class PostLogoutAllExample
    {
        public void main()
        {


            var apiInstance = new RealmsAdminApi();
            var realm = realm_example;  // string | realm name (not id!)

            try
            {
                GlobalRequestResult result = apiInstance.PostLogoutAll(realm);
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

### Return type

[**GlobalRequestResult**](GlobalRequestResult.md)

### Authorization

[access_token](../README.md#access_token)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="postpartialexport"></a>
# **PostPartialExport**
> void PostPartialExport (string realm, string exportClients, string exportGroupsAndRoles)



Partial export of existing realm into a JSON file.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class PostPartialExportExample
    {
        public void main()
        {


            var apiInstance = new RealmsAdminApi();
            var realm = realm_example;  // string | realm name (not id!)
            var exportClients = exportClients_example;  // string |  (optional) 
            var exportGroupsAndRoles = exportGroupsAndRoles_example;  // string |  (optional) 

            try
            {
                apiInstance.PostPartialExport(realm, exportClients, exportGroupsAndRoles);
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

### Return type

void (empty response body)

### Authorization

[access_token](../README.md#access_token)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="postpartialimport"></a>
# **PostPartialImport**
> void PostPartialImport (string realm, Object body)



Partial import from a JSON file to an existing realm.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class PostPartialImportExample
    {
        public void main()
        {


            var apiInstance = new RealmsAdminApi();
            var realm = realm_example;  // string | realm name (not id!)
            var body = new Object(); // Object | [file] (optional) 

            try
            {
                apiInstance.PostPartialImport(realm, body);
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
 **body** | **Object**| [file] | [optional] 

### Return type

void (empty response body)

### Authorization

[access_token](../README.md#access_token)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="postpushrevocationbyrealm"></a>
# **PostPushRevocationByRealm**
> GlobalRequestResult PostPushRevocationByRealm (string realm)



Push the realm’s revocation policy to any client that has an admin url associated with it.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class PostPushRevocationByRealmExample
    {
        public void main()
        {


            var apiInstance = new RealmsAdminApi();
            var realm = realm_example;  // string | realm name (not id!)

            try
            {
                GlobalRequestResult result = apiInstance.PostPushRevocationByRealm(realm);
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

### Return type

[**GlobalRequestResult**](GlobalRequestResult.md)

### Authorization

[access_token](../README.md#access_token)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="posttestsmtpconnection"></a>
# **PostTestSmtpConnection**
> void PostTestSmtpConnection (string realm, string body)



Test SMTP connection with current logged in user

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class PostTestSmtpConnectionExample
    {
        public void main()
        {


            var apiInstance = new RealmsAdminApi();
            var realm = realm_example;  // string | realm name (not id!)
            var body = new string(); // string | [string] (optional) 

            try
            {
                apiInstance.PostTestSmtpConnection(realm, body);
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

### Return type

void (empty response body)

### Authorization

[access_token](../README.md#access_token)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="putbyrealm"></a>
# **PutByRealm**
> void PutByRealm (string realm, RealmRepresentation body)



Update the top-level information of the realm Any user, roles or client information in the representation will be ignored.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class PutByRealmExample
    {
        public void main()
        {


            var apiInstance = new RealmsAdminApi();
            var realm = realm_example;  // string | realm name (not id!)
            var body = new RealmRepresentation(); // RealmRepresentation | RealmRepresentation (optional) 

            try
            {
                apiInstance.PutByRealm(realm, body);
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

### Return type

void (empty response body)

### Authorization

[access_token](../README.md#access_token)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="putdefaultdefaultclientscope"></a>
# **PutDefaultDefaultClientScope**
> void PutDefaultDefaultClientScope (string realm, string clientScopeId)



### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class PutDefaultDefaultClientScopeExample
    {
        public void main()
        {


            var apiInstance = new RealmsAdminApi();
            var realm = realm_example;  // string | realm name (not id!)
            var clientScopeId = clientScopeId_example;  // string | 

            try
            {
                apiInstance.PutDefaultDefaultClientScope(realm, clientScopeId);
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

### Return type

void (empty response body)

### Authorization

[access_token](../README.md#access_token)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="putdefaultgroup"></a>
# **PutDefaultGroup**
> void PutDefaultGroup (string realm, string groupId)



### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class PutDefaultGroupExample
    {
        public void main()
        {


            var apiInstance = new RealmsAdminApi();
            var realm = realm_example;  // string | realm name (not id!)
            var groupId = groupId_example;  // string | 

            try
            {
                apiInstance.PutDefaultGroup(realm, groupId);
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

### Return type

void (empty response body)

### Authorization

[access_token](../README.md#access_token)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="putdefaultoptionalclientscope"></a>
# **PutDefaultOptionalClientScope**
> void PutDefaultOptionalClientScope (string realm, string clientScopeId)



### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class PutDefaultOptionalClientScopeExample
    {
        public void main()
        {


            var apiInstance = new RealmsAdminApi();
            var realm = realm_example;  // string | realm name (not id!)
            var clientScopeId = clientScopeId_example;  // string | 

            try
            {
                apiInstance.PutDefaultOptionalClientScope(realm, clientScopeId);
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

### Return type

void (empty response body)

### Authorization

[access_token](../README.md#access_token)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="puteventsconfig"></a>
# **PutEventsConfig**
> void PutEventsConfig (string realm, RealmEventsConfigRepresentation body)



### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class PutEventsConfigExample
    {
        public void main()
        {


            var apiInstance = new RealmsAdminApi();
            var realm = realm_example;  // string | realm name (not id!)
            var body = new RealmEventsConfigRepresentation(); // RealmEventsConfigRepresentation | RealmEventsConfigRepresentation (optional) 

            try
            {
                apiInstance.PutEventsConfig(realm, body);
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

### Return type

void (empty response body)

### Authorization

[access_token](../README.md#access_token)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="putlocalization"></a>
# **PutLocalization**
> void PutLocalization (string realm, string locale, string key, string body)



### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class PutLocalizationExample
    {
        public void main()
        {


            var apiInstance = new RealmsAdminApi();
            var realm = realm_example;  // string | realm name (not id!)
            var locale = locale_example;  // string | 
            var key = key_example;  // string | 
            var body = new string(); // string | [string] (optional) 

            try
            {
                apiInstance.PutLocalization(realm, locale, key, body);
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

### Return type

void (empty response body)

### Authorization

[access_token](../README.md#access_token)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="putpolicies"></a>
# **PutPolicies**
> void PutPolicies (string realm, ClientPoliciesRepresentation body)



### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class PutPoliciesExample
    {
        public void main()
        {


            var apiInstance = new RealmsAdminApi();
            var realm = realm_example;  // string | realm name (not id!)
            var body = new ClientPoliciesRepresentation(); // ClientPoliciesRepresentation | ClientPoliciesRepresentation (optional) 

            try
            {
                apiInstance.PutPolicies(realm, body);
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

### Return type

void (empty response body)

### Authorization

[access_token](../README.md#access_token)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="putprofiles"></a>
# **PutProfiles**
> void PutProfiles (string realm, ClientProfilesRepresentation body)



### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class PutProfilesExample
    {
        public void main()
        {


            var apiInstance = new RealmsAdminApi();
            var realm = realm_example;  // string | realm name (not id!)
            var body = new ClientProfilesRepresentation(); // ClientProfilesRepresentation | ClientProfilesRepresentation (optional) 

            try
            {
                apiInstance.PutProfiles(realm, body);
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

### Return type

void (empty response body)

### Authorization

[access_token](../README.md#access_token)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="putusersmanagementpermissions"></a>
# **PutUsersManagementPermissions**
> ManagementPermissionReference PutUsersManagementPermissions (string realm, ManagementPermissionReference body)



### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class PutUsersManagementPermissionsExample
    {
        public void main()
        {


            var apiInstance = new RealmsAdminApi();
            var realm = realm_example;  // string | realm name (not id!)
            var body = new ManagementPermissionReference(); // ManagementPermissionReference | ManagementPermissionReference (optional) 

            try
            {
                ManagementPermissionReference result = apiInstance.PutUsersManagementPermissions(realm, body);
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

### Return type

[**ManagementPermissionReference**](ManagementPermissionReference.md)

### Authorization

[access_token](../README.md#access_token)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

