# IO.Swagger.Api.RolesByIDApi

All URIs are relative to *https://keycloak.example.com/admin/realms*

Method | HTTP request | Description
------------- | ------------- | -------------
[**DeleteRolesById**](RolesByIDApi.md#deleterolesbyid) | **DELETE** /{realm}/roles-by-id/{role-id} | 
[**DeleteRolesByIdComposites**](RolesByIDApi.md#deleterolesbyidcomposites) | **DELETE** /{realm}/roles-by-id/{role-id}/composites | 
[**GetRolesById**](RolesByIDApi.md#getrolesbyid) | **GET** /{realm}/roles-by-id/{role-id} | 
[**GetRolesByIdComposites**](RolesByIDApi.md#getrolesbyidcomposites) | **GET** /{realm}/roles-by-id/{role-id}/composites | 
[**GetRolesByIdCompositesClient**](RolesByIDApi.md#getrolesbyidcompositesclient) | **GET** /{realm}/roles-by-id/{role-id}/composites/clients/{clientUuid} | 
[**GetRolesByIdCompositesRealm**](RolesByIDApi.md#getrolesbyidcompositesrealm) | **GET** /{realm}/roles-by-id/{role-id}/composites/realm | 
[**GetRolesByIdManagementPermissions**](RolesByIDApi.md#getrolesbyidmanagementpermissions) | **GET** /{realm}/roles-by-id/{role-id}/management/permissions | 
[**PostRolesByIdComposites**](RolesByIDApi.md#postrolesbyidcomposites) | **POST** /{realm}/roles-by-id/{role-id}/composites | 
[**PutRolesById**](RolesByIDApi.md#putrolesbyid) | **PUT** /{realm}/roles-by-id/{role-id} | 
[**PutRolesByIdManagementPermissions**](RolesByIDApi.md#putrolesbyidmanagementpermissions) | **PUT** /{realm}/roles-by-id/{role-id}/management/permissions | 

<a name="deleterolesbyid"></a>
# **DeleteRolesById**
> void DeleteRolesById (string realm, string roleId)



Delete the role

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class DeleteRolesByIdExample
    {
        public void main()
        {


            var apiInstance = new RolesByIDApi();
            var realm = realm_example;  // string | realm name (not id!)
            var roleId = roleId_example;  // string | id of role

            try
            {
                apiInstance.DeleteRolesById(realm, roleId);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling RolesByIDApi.DeleteRolesById: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **realm** | **string**| realm name (not id!) | 
 **roleId** | **string**| id of role | 

### Return type

void (empty response body)

### Authorization

[access_token](../README.md#access_token)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="deleterolesbyidcomposites"></a>
# **DeleteRolesByIdComposites**
> void DeleteRolesByIdComposites (string realm, string roleId, RoleRepresentation body)



Remove a set of roles from the role’s composite

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class DeleteRolesByIdCompositesExample
    {
        public void main()
        {


            var apiInstance = new RolesByIDApi();
            var realm = realm_example;  // string | realm name (not id!)
            var roleId = roleId_example;  // string | 
            var body = new RoleRepresentation(); // RoleRepresentation | RoleRepresentation (optional) 

            try
            {
                apiInstance.DeleteRolesByIdComposites(realm, roleId, body);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling RolesByIDApi.DeleteRolesByIdComposites: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **realm** | **string**| realm name (not id!) | 
 **roleId** | **string**|  | 
 **body** | [**RoleRepresentation**](RoleRepresentation.md)| RoleRepresentation | [optional] 

### Return type

void (empty response body)

### Authorization

[access_token](../README.md#access_token)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getrolesbyid"></a>
# **GetRolesById**
> RoleRepresentation GetRolesById (string realm, string roleId)



Get a specific role’s representation

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class GetRolesByIdExample
    {
        public void main()
        {


            var apiInstance = new RolesByIDApi();
            var realm = realm_example;  // string | realm name (not id!)
            var roleId = roleId_example;  // string | id of role

            try
            {
                RoleRepresentation result = apiInstance.GetRolesById(realm, roleId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling RolesByIDApi.GetRolesById: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **realm** | **string**| realm name (not id!) | 
 **roleId** | **string**| id of role | 

### Return type

[**RoleRepresentation**](RoleRepresentation.md)

### Authorization

[access_token](../README.md#access_token)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getrolesbyidcomposites"></a>
# **GetRolesByIdComposites**
> List<RoleRepresentation> GetRolesByIdComposites (string realm, string roleId, string first, string max, string search)



Get role’s children Returns a set of role’s children provided the role is a composite.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class GetRolesByIdCompositesExample
    {
        public void main()
        {


            var apiInstance = new RolesByIDApi();
            var realm = realm_example;  // string | realm name (not id!)
            var roleId = roleId_example;  // string | 
            var first = first_example;  // string |  (optional) 
            var max = max_example;  // string |  (optional) 
            var search = search_example;  // string |  (optional) 

            try
            {
                List&lt;RoleRepresentation&gt; result = apiInstance.GetRolesByIdComposites(realm, roleId, first, max, search);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling RolesByIDApi.GetRolesByIdComposites: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **realm** | **string**| realm name (not id!) | 
 **roleId** | **string**|  | 
 **first** | **string**|  | [optional] 
 **max** | **string**|  | [optional] 
 **search** | **string**|  | [optional] 

### Return type

[**List<RoleRepresentation>**](RoleRepresentation.md)

### Authorization

[access_token](../README.md#access_token)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getrolesbyidcompositesclient"></a>
# **GetRolesByIdCompositesClient**
> List<RoleRepresentation> GetRolesByIdCompositesClient (string realm, string roleId, string clientUuid)



Get client-level roles for the client that are in the role’s composite

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class GetRolesByIdCompositesClientExample
    {
        public void main()
        {


            var apiInstance = new RolesByIDApi();
            var realm = realm_example;  // string | realm name (not id!)
            var roleId = roleId_example;  // string | 
            var clientUuid = clientUuid_example;  // string | 

            try
            {
                List&lt;RoleRepresentation&gt; result = apiInstance.GetRolesByIdCompositesClient(realm, roleId, clientUuid);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling RolesByIDApi.GetRolesByIdCompositesClient: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **realm** | **string**| realm name (not id!) | 
 **roleId** | **string**|  | 
 **clientUuid** | **string**|  | 

### Return type

[**List<RoleRepresentation>**](RoleRepresentation.md)

### Authorization

[access_token](../README.md#access_token)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getrolesbyidcompositesrealm"></a>
# **GetRolesByIdCompositesRealm**
> List<RoleRepresentation> GetRolesByIdCompositesRealm (string realm, string roleId)



Get realm-level roles that are in the role’s composite

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class GetRolesByIdCompositesRealmExample
    {
        public void main()
        {


            var apiInstance = new RolesByIDApi();
            var realm = realm_example;  // string | realm name (not id!)
            var roleId = roleId_example;  // string | 

            try
            {
                List&lt;RoleRepresentation&gt; result = apiInstance.GetRolesByIdCompositesRealm(realm, roleId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling RolesByIDApi.GetRolesByIdCompositesRealm: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **realm** | **string**| realm name (not id!) | 
 **roleId** | **string**|  | 

### Return type

[**List<RoleRepresentation>**](RoleRepresentation.md)

### Authorization

[access_token](../README.md#access_token)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getrolesbyidmanagementpermissions"></a>
# **GetRolesByIdManagementPermissions**
> ManagementPermissionReference GetRolesByIdManagementPermissions (string realm, string roleId)



Return object stating whether role Authorization permissions have been initialized or not and a reference

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class GetRolesByIdManagementPermissionsExample
    {
        public void main()
        {


            var apiInstance = new RolesByIDApi();
            var realm = realm_example;  // string | realm name (not id!)
            var roleId = roleId_example;  // string | 

            try
            {
                ManagementPermissionReference result = apiInstance.GetRolesByIdManagementPermissions(realm, roleId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling RolesByIDApi.GetRolesByIdManagementPermissions: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **realm** | **string**| realm name (not id!) | 
 **roleId** | **string**|  | 

### Return type

[**ManagementPermissionReference**](ManagementPermissionReference.md)

### Authorization

[access_token](../README.md#access_token)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="postrolesbyidcomposites"></a>
# **PostRolesByIdComposites**
> void PostRolesByIdComposites (string realm, string roleId, RoleRepresentation body)



Make the role a composite role by associating some child roles

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class PostRolesByIdCompositesExample
    {
        public void main()
        {


            var apiInstance = new RolesByIDApi();
            var realm = realm_example;  // string | realm name (not id!)
            var roleId = roleId_example;  // string | 
            var body = new RoleRepresentation(); // RoleRepresentation | RoleRepresentation (optional) 

            try
            {
                apiInstance.PostRolesByIdComposites(realm, roleId, body);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling RolesByIDApi.PostRolesByIdComposites: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **realm** | **string**| realm name (not id!) | 
 **roleId** | **string**|  | 
 **body** | [**RoleRepresentation**](RoleRepresentation.md)| RoleRepresentation | [optional] 

### Return type

void (empty response body)

### Authorization

[access_token](../README.md#access_token)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="putrolesbyid"></a>
# **PutRolesById**
> void PutRolesById (string realm, string roleId, RoleRepresentation body)



Update the role

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class PutRolesByIdExample
    {
        public void main()
        {


            var apiInstance = new RolesByIDApi();
            var realm = realm_example;  // string | realm name (not id!)
            var roleId = roleId_example;  // string | id of role
            var body = new RoleRepresentation(); // RoleRepresentation | RoleRepresentation (optional) 

            try
            {
                apiInstance.PutRolesById(realm, roleId, body);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling RolesByIDApi.PutRolesById: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **realm** | **string**| realm name (not id!) | 
 **roleId** | **string**| id of role | 
 **body** | [**RoleRepresentation**](RoleRepresentation.md)| RoleRepresentation | [optional] 

### Return type

void (empty response body)

### Authorization

[access_token](../README.md#access_token)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="putrolesbyidmanagementpermissions"></a>
# **PutRolesByIdManagementPermissions**
> ManagementPermissionReference PutRolesByIdManagementPermissions (string realm, string roleId, ManagementPermissionReference body)



Return object stating whether role Authorization permissions have been initialized or not and a reference

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class PutRolesByIdManagementPermissionsExample
    {
        public void main()
        {


            var apiInstance = new RolesByIDApi();
            var realm = realm_example;  // string | realm name (not id!)
            var roleId = roleId_example;  // string | 
            var body = new ManagementPermissionReference(); // ManagementPermissionReference | ManagementPermissionReference (optional) 

            try
            {
                ManagementPermissionReference result = apiInstance.PutRolesByIdManagementPermissions(realm, roleId, body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling RolesByIDApi.PutRolesByIdManagementPermissions: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **realm** | **string**| realm name (not id!) | 
 **roleId** | **string**|  | 
 **body** | [**ManagementPermissionReference**](ManagementPermissionReference.md)| ManagementPermissionReference | [optional] 

### Return type

[**ManagementPermissionReference**](ManagementPermissionReference.md)

### Authorization

[access_token](../README.md#access_token)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

