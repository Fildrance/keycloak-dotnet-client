# .ClientRoleMappingsApi

All URIs are relative to *https://keycloak.example.com/admin/realms*

Method | HTTP request | Description
------------- | ------------- | -------------
[**DeleteGroupRoleMappingsClient**](ClientRoleMappingsApi.md#deletegrouprolemappingsclient) | **Delete** /{realm}/groups/{id}/role-mappings/clients/{client} | 
[**DeleteUserRoleMappingsClient**](ClientRoleMappingsApi.md#deleteuserrolemappingsclient) | **Delete** /{realm}/users/{id}/role-mappings/clients/{client} | 
[**GetGroupRoleMappingsClient**](ClientRoleMappingsApi.md#getgrouprolemappingsclient) | **Get** /{realm}/groups/{id}/role-mappings/clients/{client} | 
[**GetGroupRoleMappingsClientAvailable**](ClientRoleMappingsApi.md#getgrouprolemappingsclientavailable) | **Get** /{realm}/groups/{id}/role-mappings/clients/{client}/available | 
[**GetGroupRoleMappingsClientComposite**](ClientRoleMappingsApi.md#getgrouprolemappingsclientcomposite) | **Get** /{realm}/groups/{id}/role-mappings/clients/{client}/composite | 
[**GetUserRoleMappingsClient**](ClientRoleMappingsApi.md#getuserrolemappingsclient) | **Get** /{realm}/users/{id}/role-mappings/clients/{client} | 
[**GetUserRoleMappingsClientAvailable**](ClientRoleMappingsApi.md#getuserrolemappingsclientavailable) | **Get** /{realm}/users/{id}/role-mappings/clients/{client}/available | 
[**GetUserRoleMappingsClientComposite**](ClientRoleMappingsApi.md#getuserrolemappingsclientcomposite) | **Get** /{realm}/users/{id}/role-mappings/clients/{client}/composite | 
[**PostGroupRoleMappingsClient**](ClientRoleMappingsApi.md#postgrouprolemappingsclient) | **Post** /{realm}/groups/{id}/role-mappings/clients/{client} | 
[**PostUserRoleMappingsClient**](ClientRoleMappingsApi.md#postuserrolemappingsclient) | **Post** /{realm}/users/{id}/role-mappings/clients/{client} | 


<a name="deletegrouprolemappingsclient"></a>
# **DeleteGroupRoleMappingsClient**
> void DeleteGroupRoleMappingsClient (string realm, string id, string _client, RoleRepresentation body, CancellationToken ct)



Delete client-level roles from user role mapping

### Example
```csharp
using System;
using System.Diagnostics;
using ;
using Keycloak.Client;
using Keycloak.Client.Models;

namespace Example
{
    public class DeleteGroupRoleMappingsClientExample
    {
        public void main()
        {
            

            var apiInstance = new ClientRoleMappingsApi();
            var realm = realm_example;  // string | realm name (not id!)
            var id = id_example;  // string | 
            var _client = _client_example;  // string | 
            var body = new RoleRepresentation(); // RoleRepresentation | RoleRepresentation (optional) 
            var ct = new CancellationToken(); // CancellationToken |  (optional) 

            try
            {
                apiInstance.DeleteGroupRoleMappingsClient(realm, id, _client, body, ct);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ClientRoleMappingsApi.DeleteGroupRoleMappingsClient: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **realm** | **string**| realm name (not id!) | 
 **id** | **string**|  | 
 **_client** | **string**|  | 
 **body** | [**RoleRepresentation**](RoleRepresentation.md)| RoleRepresentation | [optional] 
 **ct** | [**CancellationToken**](.md)|  | [optional] 

### Return type

void (empty response body)

### Authorization

[access_token](../README.md#access_token)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="deleteuserrolemappingsclient"></a>
# **DeleteUserRoleMappingsClient**
> void DeleteUserRoleMappingsClient (string realm, string id, string _client, RoleRepresentation body, CancellationToken ct)



Delete client-level roles from user role mapping

### Example
```csharp
using System;
using System.Diagnostics;
using ;
using Keycloak.Client;
using Keycloak.Client.Models;

namespace Example
{
    public class DeleteUserRoleMappingsClientExample
    {
        public void main()
        {
            

            var apiInstance = new ClientRoleMappingsApi();
            var realm = realm_example;  // string | realm name (not id!)
            var id = id_example;  // string | 
            var _client = _client_example;  // string | 
            var body = new RoleRepresentation(); // RoleRepresentation | RoleRepresentation (optional) 
            var ct = new CancellationToken(); // CancellationToken |  (optional) 

            try
            {
                apiInstance.DeleteUserRoleMappingsClient(realm, id, _client, body, ct);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ClientRoleMappingsApi.DeleteUserRoleMappingsClient: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **realm** | **string**| realm name (not id!) | 
 **id** | **string**|  | 
 **_client** | **string**|  | 
 **body** | [**RoleRepresentation**](RoleRepresentation.md)| RoleRepresentation | [optional] 
 **ct** | [**CancellationToken**](.md)|  | [optional] 

### Return type

void (empty response body)

### Authorization

[access_token](../README.md#access_token)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getgrouprolemappingsclient"></a>
# **GetGroupRoleMappingsClient**
> List<RoleRepresentation> GetGroupRoleMappingsClient (string realm, string id, string _client, CancellationToken ct)



Get client-level role mappings for the user, and the app

### Example
```csharp
using System;
using System.Diagnostics;
using ;
using Keycloak.Client;
using Keycloak.Client.Models;

namespace Example
{
    public class GetGroupRoleMappingsClientExample
    {
        public void main()
        {
            

            var apiInstance = new ClientRoleMappingsApi();
            var realm = realm_example;  // string | realm name (not id!)
            var id = id_example;  // string | 
            var _client = _client_example;  // string | 
            var ct = new CancellationToken(); // CancellationToken |  (optional) 

            try
            {
                List&lt;RoleRepresentation&gt; result = apiInstance.GetGroupRoleMappingsClient(realm, id, _client, ct);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ClientRoleMappingsApi.GetGroupRoleMappingsClient: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **realm** | **string**| realm name (not id!) | 
 **id** | **string**|  | 
 **_client** | **string**|  | 
 **ct** | [**CancellationToken**](.md)|  | [optional] 

### Return type

[**List<RoleRepresentation>**](RoleRepresentation.md)

### Authorization

[access_token](../README.md#access_token)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getgrouprolemappingsclientavailable"></a>
# **GetGroupRoleMappingsClientAvailable**
> List<RoleRepresentation> GetGroupRoleMappingsClientAvailable (string realm, string id, string _client, CancellationToken ct)



Get available client-level roles that can be mapped to the user

### Example
```csharp
using System;
using System.Diagnostics;
using ;
using Keycloak.Client;
using Keycloak.Client.Models;

namespace Example
{
    public class GetGroupRoleMappingsClientAvailableExample
    {
        public void main()
        {
            

            var apiInstance = new ClientRoleMappingsApi();
            var realm = realm_example;  // string | realm name (not id!)
            var id = id_example;  // string | 
            var _client = _client_example;  // string | 
            var ct = new CancellationToken(); // CancellationToken |  (optional) 

            try
            {
                List&lt;RoleRepresentation&gt; result = apiInstance.GetGroupRoleMappingsClientAvailable(realm, id, _client, ct);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ClientRoleMappingsApi.GetGroupRoleMappingsClientAvailable: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **realm** | **string**| realm name (not id!) | 
 **id** | **string**|  | 
 **_client** | **string**|  | 
 **ct** | [**CancellationToken**](.md)|  | [optional] 

### Return type

[**List<RoleRepresentation>**](RoleRepresentation.md)

### Authorization

[access_token](../README.md#access_token)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getgrouprolemappingsclientcomposite"></a>
# **GetGroupRoleMappingsClientComposite**
> List<RoleRepresentation> GetGroupRoleMappingsClientComposite (string realm, string id, string _client, string briefRepresentation, CancellationToken ct)



Get effective client-level role mappings This recurses any composite roles

### Example
```csharp
using System;
using System.Diagnostics;
using ;
using Keycloak.Client;
using Keycloak.Client.Models;

namespace Example
{
    public class GetGroupRoleMappingsClientCompositeExample
    {
        public void main()
        {
            

            var apiInstance = new ClientRoleMappingsApi();
            var realm = realm_example;  // string | realm name (not id!)
            var id = id_example;  // string | 
            var _client = _client_example;  // string | 
            var briefRepresentation = briefRepresentation_example;  // string | if false, return roles with their attributes (optional) 
            var ct = new CancellationToken(); // CancellationToken |  (optional) 

            try
            {
                List&lt;RoleRepresentation&gt; result = apiInstance.GetGroupRoleMappingsClientComposite(realm, id, _client, briefRepresentation, ct);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ClientRoleMappingsApi.GetGroupRoleMappingsClientComposite: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **realm** | **string**| realm name (not id!) | 
 **id** | **string**|  | 
 **_client** | **string**|  | 
 **briefRepresentation** | **string**| if false, return roles with their attributes | [optional] 
 **ct** | [**CancellationToken**](.md)|  | [optional] 

### Return type

[**List<RoleRepresentation>**](RoleRepresentation.md)

### Authorization

[access_token](../README.md#access_token)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getuserrolemappingsclient"></a>
# **GetUserRoleMappingsClient**
> List<RoleRepresentation> GetUserRoleMappingsClient (string realm, string id, string _client, CancellationToken ct)



Get client-level role mappings for the user, and the app

### Example
```csharp
using System;
using System.Diagnostics;
using ;
using Keycloak.Client;
using Keycloak.Client.Models;

namespace Example
{
    public class GetUserRoleMappingsClientExample
    {
        public void main()
        {
            

            var apiInstance = new ClientRoleMappingsApi();
            var realm = realm_example;  // string | realm name (not id!)
            var id = id_example;  // string | 
            var _client = _client_example;  // string | 
            var ct = new CancellationToken(); // CancellationToken |  (optional) 

            try
            {
                List&lt;RoleRepresentation&gt; result = apiInstance.GetUserRoleMappingsClient(realm, id, _client, ct);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ClientRoleMappingsApi.GetUserRoleMappingsClient: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **realm** | **string**| realm name (not id!) | 
 **id** | **string**|  | 
 **_client** | **string**|  | 
 **ct** | [**CancellationToken**](.md)|  | [optional] 

### Return type

[**List<RoleRepresentation>**](RoleRepresentation.md)

### Authorization

[access_token](../README.md#access_token)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getuserrolemappingsclientavailable"></a>
# **GetUserRoleMappingsClientAvailable**
> List<RoleRepresentation> GetUserRoleMappingsClientAvailable (string realm, string id, string _client, CancellationToken ct)



Get available client-level roles that can be mapped to the user

### Example
```csharp
using System;
using System.Diagnostics;
using ;
using Keycloak.Client;
using Keycloak.Client.Models;

namespace Example
{
    public class GetUserRoleMappingsClientAvailableExample
    {
        public void main()
        {
            

            var apiInstance = new ClientRoleMappingsApi();
            var realm = realm_example;  // string | realm name (not id!)
            var id = id_example;  // string | 
            var _client = _client_example;  // string | 
            var ct = new CancellationToken(); // CancellationToken |  (optional) 

            try
            {
                List&lt;RoleRepresentation&gt; result = apiInstance.GetUserRoleMappingsClientAvailable(realm, id, _client, ct);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ClientRoleMappingsApi.GetUserRoleMappingsClientAvailable: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **realm** | **string**| realm name (not id!) | 
 **id** | **string**|  | 
 **_client** | **string**|  | 
 **ct** | [**CancellationToken**](.md)|  | [optional] 

### Return type

[**List<RoleRepresentation>**](RoleRepresentation.md)

### Authorization

[access_token](../README.md#access_token)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getuserrolemappingsclientcomposite"></a>
# **GetUserRoleMappingsClientComposite**
> List<RoleRepresentation> GetUserRoleMappingsClientComposite (string realm, string id, string _client, string briefRepresentation, CancellationToken ct)



Get effective client-level role mappings This recurses any composite roles

### Example
```csharp
using System;
using System.Diagnostics;
using ;
using Keycloak.Client;
using Keycloak.Client.Models;

namespace Example
{
    public class GetUserRoleMappingsClientCompositeExample
    {
        public void main()
        {
            

            var apiInstance = new ClientRoleMappingsApi();
            var realm = realm_example;  // string | realm name (not id!)
            var id = id_example;  // string | 
            var _client = _client_example;  // string | 
            var briefRepresentation = briefRepresentation_example;  // string | if false, return roles with their attributes (optional) 
            var ct = new CancellationToken(); // CancellationToken |  (optional) 

            try
            {
                List&lt;RoleRepresentation&gt; result = apiInstance.GetUserRoleMappingsClientComposite(realm, id, _client, briefRepresentation, ct);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ClientRoleMappingsApi.GetUserRoleMappingsClientComposite: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **realm** | **string**| realm name (not id!) | 
 **id** | **string**|  | 
 **_client** | **string**|  | 
 **briefRepresentation** | **string**| if false, return roles with their attributes | [optional] 
 **ct** | [**CancellationToken**](.md)|  | [optional] 

### Return type

[**List<RoleRepresentation>**](RoleRepresentation.md)

### Authorization

[access_token](../README.md#access_token)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="postgrouprolemappingsclient"></a>
# **PostGroupRoleMappingsClient**
> void PostGroupRoleMappingsClient (string realm, string id, string _client, RoleRepresentation body, CancellationToken ct)



Add client-level roles to the user role mapping

### Example
```csharp
using System;
using System.Diagnostics;
using ;
using Keycloak.Client;
using Keycloak.Client.Models;

namespace Example
{
    public class PostGroupRoleMappingsClientExample
    {
        public void main()
        {
            

            var apiInstance = new ClientRoleMappingsApi();
            var realm = realm_example;  // string | realm name (not id!)
            var id = id_example;  // string | 
            var _client = _client_example;  // string | 
            var body = new RoleRepresentation(); // RoleRepresentation | RoleRepresentation (optional) 
            var ct = new CancellationToken(); // CancellationToken |  (optional) 

            try
            {
                apiInstance.PostGroupRoleMappingsClient(realm, id, _client, body, ct);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ClientRoleMappingsApi.PostGroupRoleMappingsClient: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **realm** | **string**| realm name (not id!) | 
 **id** | **string**|  | 
 **_client** | **string**|  | 
 **body** | [**RoleRepresentation**](RoleRepresentation.md)| RoleRepresentation | [optional] 
 **ct** | [**CancellationToken**](.md)|  | [optional] 

### Return type

void (empty response body)

### Authorization

[access_token](../README.md#access_token)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="postuserrolemappingsclient"></a>
# **PostUserRoleMappingsClient**
> void PostUserRoleMappingsClient (string realm, string id, string _client, RoleRepresentation body, CancellationToken ct)



Add client-level roles to the user role mapping

### Example
```csharp
using System;
using System.Diagnostics;
using ;
using Keycloak.Client;
using Keycloak.Client.Models;

namespace Example
{
    public class PostUserRoleMappingsClientExample
    {
        public void main()
        {
            

            var apiInstance = new ClientRoleMappingsApi();
            var realm = realm_example;  // string | realm name (not id!)
            var id = id_example;  // string | 
            var _client = _client_example;  // string | 
            var body = new RoleRepresentation(); // RoleRepresentation | RoleRepresentation (optional) 
            var ct = new CancellationToken(); // CancellationToken |  (optional) 

            try
            {
                apiInstance.PostUserRoleMappingsClient(realm, id, _client, body, ct);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ClientRoleMappingsApi.PostUserRoleMappingsClient: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **realm** | **string**| realm name (not id!) | 
 **id** | **string**|  | 
 **_client** | **string**|  | 
 **body** | [**RoleRepresentation**](RoleRepresentation.md)| RoleRepresentation | [optional] 
 **ct** | [**CancellationToken**](.md)|  | [optional] 

### Return type

void (empty response body)

### Authorization

[access_token](../README.md#access_token)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

