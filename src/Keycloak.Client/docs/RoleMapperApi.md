# IO.Swagger.Api.RoleMapperApi

All URIs are relative to *https://keycloak.example.com/admin/realms*

Method | HTTP request | Description
------------- | ------------- | -------------
[**DeleteGroupRoleMappingsRealm**](RoleMapperApi.md#deletegrouprolemappingsrealm) | **DELETE** /{realm}/groups/{id}/role-mappings/realm | 
[**DeleteUserRoleMappingsRealm**](RoleMapperApi.md#deleteuserrolemappingsrealm) | **DELETE** /{realm}/users/{id}/role-mappings/realm | 
[**GetGroupRoleMappings**](RoleMapperApi.md#getgrouprolemappings) | **GET** /{realm}/groups/{id}/role-mappings | 
[**GetGroupRoleMappingsRealm**](RoleMapperApi.md#getgrouprolemappingsrealm) | **GET** /{realm}/groups/{id}/role-mappings/realm | 
[**GetGroupRoleMappingsRealmAvailable**](RoleMapperApi.md#getgrouprolemappingsrealmavailable) | **GET** /{realm}/groups/{id}/role-mappings/realm/available | 
[**GetGroupRoleMappingsRealmComposite**](RoleMapperApi.md#getgrouprolemappingsrealmcomposite) | **GET** /{realm}/groups/{id}/role-mappings/realm/composite | 
[**GetUserRoleMappings**](RoleMapperApi.md#getuserrolemappings) | **GET** /{realm}/users/{id}/role-mappings | 
[**GetUserRoleMappingsRealm**](RoleMapperApi.md#getuserrolemappingsrealm) | **GET** /{realm}/users/{id}/role-mappings/realm | 
[**GetUserRoleMappingsRealmAvailable**](RoleMapperApi.md#getuserrolemappingsrealmavailable) | **GET** /{realm}/users/{id}/role-mappings/realm/available | 
[**GetUserRoleMappingsRealmComposite**](RoleMapperApi.md#getuserrolemappingsrealmcomposite) | **GET** /{realm}/users/{id}/role-mappings/realm/composite | 
[**PostGroupRoleMappingsRealm**](RoleMapperApi.md#postgrouprolemappingsrealm) | **POST** /{realm}/groups/{id}/role-mappings/realm | 
[**PostUserRoleMappingsRealm**](RoleMapperApi.md#postuserrolemappingsrealm) | **POST** /{realm}/users/{id}/role-mappings/realm | 

<a name="deletegrouprolemappingsrealm"></a>
# **DeleteGroupRoleMappingsRealm**
> void DeleteGroupRoleMappingsRealm (string realm, string id, RoleRepresentation body)



Delete realm-level role mappings

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class DeleteGroupRoleMappingsRealmExample
    {
        public void main()
        {


            var apiInstance = new RoleMapperApi();
            var realm = realm_example;  // string | realm name (not id!)
            var id = id_example;  // string | 
            var body = new RoleRepresentation(); // RoleRepresentation | RoleRepresentation (optional) 

            try
            {
                apiInstance.DeleteGroupRoleMappingsRealm(realm, id, body);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling RoleMapperApi.DeleteGroupRoleMappingsRealm: " + e.Message );
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
 **body** | [**RoleRepresentation**](RoleRepresentation.md)| RoleRepresentation | [optional] 

### Return type

void (empty response body)

### Authorization

[access_token](../README.md#access_token)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="deleteuserrolemappingsrealm"></a>
# **DeleteUserRoleMappingsRealm**
> void DeleteUserRoleMappingsRealm (string realm, string id, RoleRepresentation body)



Delete realm-level role mappings

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class DeleteUserRoleMappingsRealmExample
    {
        public void main()
        {


            var apiInstance = new RoleMapperApi();
            var realm = realm_example;  // string | realm name (not id!)
            var id = id_example;  // string | 
            var body = new RoleRepresentation(); // RoleRepresentation | RoleRepresentation (optional) 

            try
            {
                apiInstance.DeleteUserRoleMappingsRealm(realm, id, body);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling RoleMapperApi.DeleteUserRoleMappingsRealm: " + e.Message );
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
 **body** | [**RoleRepresentation**](RoleRepresentation.md)| RoleRepresentation | [optional] 

### Return type

void (empty response body)

### Authorization

[access_token](../README.md#access_token)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getgrouprolemappings"></a>
# **GetGroupRoleMappings**
> MappingsRepresentation GetGroupRoleMappings (string realm, string id)



Get role mappings

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class GetGroupRoleMappingsExample
    {
        public void main()
        {


            var apiInstance = new RoleMapperApi();
            var realm = realm_example;  // string | realm name (not id!)
            var id = id_example;  // string | 

            try
            {
                MappingsRepresentation result = apiInstance.GetGroupRoleMappings(realm, id);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling RoleMapperApi.GetGroupRoleMappings: " + e.Message );
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

### Return type

[**MappingsRepresentation**](MappingsRepresentation.md)

### Authorization

[access_token](../README.md#access_token)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getgrouprolemappingsrealm"></a>
# **GetGroupRoleMappingsRealm**
> List<RoleRepresentation> GetGroupRoleMappingsRealm (string realm, string id)



Get realm-level role mappings

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class GetGroupRoleMappingsRealmExample
    {
        public void main()
        {


            var apiInstance = new RoleMapperApi();
            var realm = realm_example;  // string | realm name (not id!)
            var id = id_example;  // string | 

            try
            {
                List&lt;RoleRepresentation&gt; result = apiInstance.GetGroupRoleMappingsRealm(realm, id);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling RoleMapperApi.GetGroupRoleMappingsRealm: " + e.Message );
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

### Return type

[**List<RoleRepresentation>**](RoleRepresentation.md)

### Authorization

[access_token](../README.md#access_token)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getgrouprolemappingsrealmavailable"></a>
# **GetGroupRoleMappingsRealmAvailable**
> List<RoleRepresentation> GetGroupRoleMappingsRealmAvailable (string realm, string id)



Get realm-level roles that can be mapped

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class GetGroupRoleMappingsRealmAvailableExample
    {
        public void main()
        {


            var apiInstance = new RoleMapperApi();
            var realm = realm_example;  // string | realm name (not id!)
            var id = id_example;  // string | 

            try
            {
                List&lt;RoleRepresentation&gt; result = apiInstance.GetGroupRoleMappingsRealmAvailable(realm, id);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling RoleMapperApi.GetGroupRoleMappingsRealmAvailable: " + e.Message );
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

### Return type

[**List<RoleRepresentation>**](RoleRepresentation.md)

### Authorization

[access_token](../README.md#access_token)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getgrouprolemappingsrealmcomposite"></a>
# **GetGroupRoleMappingsRealmComposite**
> List<RoleRepresentation> GetGroupRoleMappingsRealmComposite (string realm, string id, string briefRepresentation)



Get effective realm-level role mappings This will recurse all composite roles to get the result.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class GetGroupRoleMappingsRealmCompositeExample
    {
        public void main()
        {


            var apiInstance = new RoleMapperApi();
            var realm = realm_example;  // string | realm name (not id!)
            var id = id_example;  // string | 
            var briefRepresentation = briefRepresentation_example;  // string | if false, return roles with their attributes (optional) 

            try
            {
                List&lt;RoleRepresentation&gt; result = apiInstance.GetGroupRoleMappingsRealmComposite(realm, id, briefRepresentation);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling RoleMapperApi.GetGroupRoleMappingsRealmComposite: " + e.Message );
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
 **briefRepresentation** | **string**| if false, return roles with their attributes | [optional] 

### Return type

[**List<RoleRepresentation>**](RoleRepresentation.md)

### Authorization

[access_token](../README.md#access_token)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getuserrolemappings"></a>
# **GetUserRoleMappings**
> MappingsRepresentation GetUserRoleMappings (string realm, string id)



Get role mappings

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class GetUserRoleMappingsExample
    {
        public void main()
        {


            var apiInstance = new RoleMapperApi();
            var realm = realm_example;  // string | realm name (not id!)
            var id = id_example;  // string | 

            try
            {
                MappingsRepresentation result = apiInstance.GetUserRoleMappings(realm, id);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling RoleMapperApi.GetUserRoleMappings: " + e.Message );
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

### Return type

[**MappingsRepresentation**](MappingsRepresentation.md)

### Authorization

[access_token](../README.md#access_token)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getuserrolemappingsrealm"></a>
# **GetUserRoleMappingsRealm**
> List<RoleRepresentation> GetUserRoleMappingsRealm (string realm, string id)



Get realm-level role mappings

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class GetUserRoleMappingsRealmExample
    {
        public void main()
        {


            var apiInstance = new RoleMapperApi();
            var realm = realm_example;  // string | realm name (not id!)
            var id = id_example;  // string | 

            try
            {
                List&lt;RoleRepresentation&gt; result = apiInstance.GetUserRoleMappingsRealm(realm, id);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling RoleMapperApi.GetUserRoleMappingsRealm: " + e.Message );
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

### Return type

[**List<RoleRepresentation>**](RoleRepresentation.md)

### Authorization

[access_token](../README.md#access_token)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getuserrolemappingsrealmavailable"></a>
# **GetUserRoleMappingsRealmAvailable**
> List<RoleRepresentation> GetUserRoleMappingsRealmAvailable (string realm, string id)



Get realm-level roles that can be mapped

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class GetUserRoleMappingsRealmAvailableExample
    {
        public void main()
        {


            var apiInstance = new RoleMapperApi();
            var realm = realm_example;  // string | realm name (not id!)
            var id = id_example;  // string | 

            try
            {
                List&lt;RoleRepresentation&gt; result = apiInstance.GetUserRoleMappingsRealmAvailable(realm, id);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling RoleMapperApi.GetUserRoleMappingsRealmAvailable: " + e.Message );
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

### Return type

[**List<RoleRepresentation>**](RoleRepresentation.md)

### Authorization

[access_token](../README.md#access_token)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getuserrolemappingsrealmcomposite"></a>
# **GetUserRoleMappingsRealmComposite**
> List<RoleRepresentation> GetUserRoleMappingsRealmComposite (string realm, string id, string briefRepresentation)



Get effective realm-level role mappings This will recurse all composite roles to get the result.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class GetUserRoleMappingsRealmCompositeExample
    {
        public void main()
        {


            var apiInstance = new RoleMapperApi();
            var realm = realm_example;  // string | realm name (not id!)
            var id = id_example;  // string | 
            var briefRepresentation = briefRepresentation_example;  // string | if false, return roles with their attributes (optional) 

            try
            {
                List&lt;RoleRepresentation&gt; result = apiInstance.GetUserRoleMappingsRealmComposite(realm, id, briefRepresentation);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling RoleMapperApi.GetUserRoleMappingsRealmComposite: " + e.Message );
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
 **briefRepresentation** | **string**| if false, return roles with their attributes | [optional] 

### Return type

[**List<RoleRepresentation>**](RoleRepresentation.md)

### Authorization

[access_token](../README.md#access_token)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="postgrouprolemappingsrealm"></a>
# **PostGroupRoleMappingsRealm**
> void PostGroupRoleMappingsRealm (string realm, string id, RoleRepresentation body)



Add realm-level role mappings to the user

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class PostGroupRoleMappingsRealmExample
    {
        public void main()
        {


            var apiInstance = new RoleMapperApi();
            var realm = realm_example;  // string | realm name (not id!)
            var id = id_example;  // string | 
            var body = new RoleRepresentation(); // RoleRepresentation | RoleRepresentation (optional) 

            try
            {
                apiInstance.PostGroupRoleMappingsRealm(realm, id, body);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling RoleMapperApi.PostGroupRoleMappingsRealm: " + e.Message );
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
 **body** | [**RoleRepresentation**](RoleRepresentation.md)| RoleRepresentation | [optional] 

### Return type

void (empty response body)

### Authorization

[access_token](../README.md#access_token)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="postuserrolemappingsrealm"></a>
# **PostUserRoleMappingsRealm**
> void PostUserRoleMappingsRealm (string realm, string id, RoleRepresentation body)



Add realm-level role mappings to the user

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class PostUserRoleMappingsRealmExample
    {
        public void main()
        {


            var apiInstance = new RoleMapperApi();
            var realm = realm_example;  // string | realm name (not id!)
            var id = id_example;  // string | 
            var body = new RoleRepresentation(); // RoleRepresentation | RoleRepresentation (optional) 

            try
            {
                apiInstance.PostUserRoleMappingsRealm(realm, id, body);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling RoleMapperApi.PostUserRoleMappingsRealm: " + e.Message );
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
 **body** | [**RoleRepresentation**](RoleRepresentation.md)| RoleRepresentation | [optional] 

### Return type

void (empty response body)

### Authorization

[access_token](../README.md#access_token)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

