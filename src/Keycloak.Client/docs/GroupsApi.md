# .GroupsApi

All URIs are relative to *https://keycloak.example.com/admin/realms*

Method | HTTP request | Description
------------- | ------------- | -------------
[**DeleteGroupByRealmById**](GroupsApi.md#deletegroupbyrealmbyid) | **Delete** /{realm}/groups/{id} | 
[**GetChildren**](GroupsApi.md#getchildren) | **Get** /{realm}/groups/{id}/children | 
[**GetGroup**](GroupsApi.md#getgroup) | **Get** /{realm}/groups/{id} | 
[**GetGroupManagementPermissions**](GroupsApi.md#getgroupmanagementpermissions) | **Get** /{realm}/groups/{id}/management/permissions | 
[**GetGroupsByRealm**](GroupsApi.md#getgroupsbyrealm) | **Get** /{realm}/groups | 
[**GetGroupsCountByRealm**](GroupsApi.md#getgroupscountbyrealm) | **Get** /{realm}/groups/count | 
[**GetMembers**](GroupsApi.md#getmembers) | **Get** /{realm}/groups/{id}/members | 
[**PostChildren**](GroupsApi.md#postchildren) | **Post** /{realm}/groups/{id}/children | 
[**PostGroups**](GroupsApi.md#postgroups) | **Post** /{realm}/groups | 
[**PutGroupByRealmById**](GroupsApi.md#putgroupbyrealmbyid) | **Put** /{realm}/groups/{id} | 
[**PutGroupManagementPermissions**](GroupsApi.md#putgroupmanagementpermissions) | **Put** /{realm}/groups/{id}/management/permissions | 


<a name="deletegroupbyrealmbyid"></a>
# **DeleteGroupByRealmById**
> void DeleteGroupByRealmById (string realm, string id, CancellationToken ct)



### Example
```csharp
using System;
using System.Diagnostics;
using ;
using Keycloak.Client;
using Keycloak.Client.Models;

namespace Example
{
    public class DeleteGroupByRealmByIdExample
    {
        public void main()
        {
            

            var apiInstance = new GroupsApi();
            var realm = realm_example;  // string | realm name (not id!)
            var id = id_example;  // string | 
            var ct = new CancellationToken(); // CancellationToken |  (optional) 

            try
            {
                apiInstance.DeleteGroupByRealmById(realm, id, ct);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling GroupsApi.DeleteGroupByRealmById: " + e.Message );
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
 **ct** | [**CancellationToken**](.md)|  | [optional] 

### Return type

void (empty response body)

### Authorization

[access_token](../README.md#access_token)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getchildren"></a>
# **GetChildren**
> List<GroupRepresentation> GetChildren (string realm, string id, string briefRepresentation, string first, string max, CancellationToken ct)



Return a paginated list of subgroups that have a parent group corresponding to the group on the URL

### Example
```csharp
using System;
using System.Diagnostics;
using ;
using Keycloak.Client;
using Keycloak.Client.Models;

namespace Example
{
    public class GetChildrenExample
    {
        public void main()
        {
            

            var apiInstance = new GroupsApi();
            var realm = realm_example;  // string | realm name (not id!)
            var id = id_example;  // string | 
            var briefRepresentation = briefRepresentation_example;  // string |  (optional) 
            var first = first_example;  // string |  (optional) 
            var max = max_example;  // string |  (optional) 
            var ct = new CancellationToken(); // CancellationToken |  (optional) 

            try
            {
                List&lt;GroupRepresentation&gt; result = apiInstance.GetChildren(realm, id, briefRepresentation, first, max, ct);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling GroupsApi.GetChildren: " + e.Message );
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
 **briefRepresentation** | **string**|  | [optional] 
 **first** | **string**|  | [optional] 
 **max** | **string**|  | [optional] 
 **ct** | [**CancellationToken**](.md)|  | [optional] 

### Return type

[**List<GroupRepresentation>**](GroupRepresentation.md)

### Authorization

[access_token](../README.md#access_token)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getgroup"></a>
# **GetGroup**
> GroupRepresentation GetGroup (string realm, string id, CancellationToken ct)



### Example
```csharp
using System;
using System.Diagnostics;
using ;
using Keycloak.Client;
using Keycloak.Client.Models;

namespace Example
{
    public class GetGroupExample
    {
        public void main()
        {
            

            var apiInstance = new GroupsApi();
            var realm = realm_example;  // string | realm name (not id!)
            var id = id_example;  // string | 
            var ct = new CancellationToken(); // CancellationToken |  (optional) 

            try
            {
                GroupRepresentation result = apiInstance.GetGroup(realm, id, ct);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling GroupsApi.GetGroup: " + e.Message );
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
 **ct** | [**CancellationToken**](.md)|  | [optional] 

### Return type

[**GroupRepresentation**](GroupRepresentation.md)

### Authorization

[access_token](../README.md#access_token)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getgroupmanagementpermissions"></a>
# **GetGroupManagementPermissions**
> ManagementPermissionReference GetGroupManagementPermissions (string realm, string id, CancellationToken ct)



Return object stating whether client Authorization permissions have been initialized or not and a reference

### Example
```csharp
using System;
using System.Diagnostics;
using ;
using Keycloak.Client;
using Keycloak.Client.Models;

namespace Example
{
    public class GetGroupManagementPermissionsExample
    {
        public void main()
        {
            

            var apiInstance = new GroupsApi();
            var realm = realm_example;  // string | realm name (not id!)
            var id = id_example;  // string | 
            var ct = new CancellationToken(); // CancellationToken |  (optional) 

            try
            {
                ManagementPermissionReference result = apiInstance.GetGroupManagementPermissions(realm, id, ct);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling GroupsApi.GetGroupManagementPermissions: " + e.Message );
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
 **ct** | [**CancellationToken**](.md)|  | [optional] 

### Return type

[**ManagementPermissionReference**](ManagementPermissionReference.md)

### Authorization

[access_token](../README.md#access_token)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getgroupsbyrealm"></a>
# **GetGroupsByRealm**
> List<GroupRepresentation> GetGroupsByRealm (string realm, string briefRepresentation, string exact, string first, string max, string populateHierarchy, string q, string search, CancellationToken ct)



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
    public class GetGroupsByRealmExample
    {
        public void main()
        {
            

            var apiInstance = new GroupsApi();
            var realm = realm_example;  // string | realm name (not id!)
            var briefRepresentation = briefRepresentation_example;  // string |  (optional) 
            var exact = exact_example;  // string |  (optional) 
            var first = first_example;  // string |  (optional) 
            var max = max_example;  // string |  (optional) 
            var populateHierarchy = populateHierarchy_example;  // string |  (optional) 
            var q = q_example;  // string |  (optional) 
            var search = search_example;  // string |  (optional) 
            var ct = new CancellationToken(); // CancellationToken |  (optional) 

            try
            {
                List&lt;GroupRepresentation&gt; result = apiInstance.GetGroupsByRealm(realm, briefRepresentation, exact, first, max, populateHierarchy, q, search, ct);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling GroupsApi.GetGroupsByRealm: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **realm** | **string**| realm name (not id!) | 
 **briefRepresentation** | **string**|  | [optional] 
 **exact** | **string**|  | [optional] 
 **first** | **string**|  | [optional] 
 **max** | **string**|  | [optional] 
 **populateHierarchy** | **string**|  | [optional] 
 **q** | **string**|  | [optional] 
 **search** | **string**|  | [optional] 
 **ct** | [**CancellationToken**](.md)|  | [optional] 

### Return type

[**List<GroupRepresentation>**](GroupRepresentation.md)

### Authorization

[access_token](../README.md#access_token)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getgroupscountbyrealm"></a>
# **GetGroupsCountByRealm**
> Dictionary<string, long?> GetGroupsCountByRealm (string realm, string search, string top, CancellationToken ct)



Returns the groups counts.

### Example
```csharp
using System;
using System.Diagnostics;
using ;
using Keycloak.Client;
using Keycloak.Client.Models;

namespace Example
{
    public class GetGroupsCountByRealmExample
    {
        public void main()
        {
            

            var apiInstance = new GroupsApi();
            var realm = realm_example;  // string | realm name (not id!)
            var search = search_example;  // string |  (optional) 
            var top = top_example;  // string |  (optional) 
            var ct = new CancellationToken(); // CancellationToken |  (optional) 

            try
            {
                Dictionary&lt;string, long?&gt; result = apiInstance.GetGroupsCountByRealm(realm, search, top, ct);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling GroupsApi.GetGroupsCountByRealm: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **realm** | **string**| realm name (not id!) | 
 **search** | **string**|  | [optional] 
 **top** | **string**|  | [optional] 
 **ct** | [**CancellationToken**](.md)|  | [optional] 

### Return type

**Dictionary<string, long?>**

### Authorization

[access_token](../README.md#access_token)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getmembers"></a>
# **GetMembers**
> List<UserRepresentation> GetMembers (string realm, string id, string briefRepresentation, string first, string max, CancellationToken ct)



Get users Returns a stream of users, filtered according to query parameters

### Example
```csharp
using System;
using System.Diagnostics;
using ;
using Keycloak.Client;
using Keycloak.Client.Models;

namespace Example
{
    public class GetMembersExample
    {
        public void main()
        {
            

            var apiInstance = new GroupsApi();
            var realm = realm_example;  // string | realm name (not id!)
            var id = id_example;  // string | 
            var briefRepresentation = briefRepresentation_example;  // string | Only return basic information (only guaranteed to return id, username, created, first and last name, email, enabled state, email verification state, federation link, and access. Note that it means that namely user attributes, required actions, and not before are not returned.) (optional) 
            var first = first_example;  // string | Pagination offset (optional) 
            var max = max_example;  // string | Maximum results size (defaults to 100) (optional) 
            var ct = new CancellationToken(); // CancellationToken |  (optional) 

            try
            {
                List&lt;UserRepresentation&gt; result = apiInstance.GetMembers(realm, id, briefRepresentation, first, max, ct);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling GroupsApi.GetMembers: " + e.Message );
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
 **briefRepresentation** | **string**| Only return basic information (only guaranteed to return id, username, created, first and last name, email, enabled state, email verification state, federation link, and access. Note that it means that namely user attributes, required actions, and not before are not returned.) | [optional] 
 **first** | **string**| Pagination offset | [optional] 
 **max** | **string**| Maximum results size (defaults to 100) | [optional] 
 **ct** | [**CancellationToken**](.md)|  | [optional] 

### Return type

[**List<UserRepresentation>**](UserRepresentation.md)

### Authorization

[access_token](../README.md#access_token)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="postchildren"></a>
# **PostChildren**
> void PostChildren (string realm, string id, GroupRepresentation body, CancellationToken ct)



Set or create child.

### Example
```csharp
using System;
using System.Diagnostics;
using ;
using Keycloak.Client;
using Keycloak.Client.Models;

namespace Example
{
    public class PostChildrenExample
    {
        public void main()
        {
            

            var apiInstance = new GroupsApi();
            var realm = realm_example;  // string | realm name (not id!)
            var id = id_example;  // string | 
            var body = new GroupRepresentation(); // GroupRepresentation | GroupRepresentation (optional) 
            var ct = new CancellationToken(); // CancellationToken |  (optional) 

            try
            {
                apiInstance.PostChildren(realm, id, body, ct);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling GroupsApi.PostChildren: " + e.Message );
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
 **body** | [**GroupRepresentation**](GroupRepresentation.md)| GroupRepresentation | [optional] 
 **ct** | [**CancellationToken**](.md)|  | [optional] 

### Return type

void (empty response body)

### Authorization

[access_token](../README.md#access_token)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="postgroups"></a>
# **PostGroups**
> void PostGroups (string realm, GroupRepresentation body, CancellationToken ct)



create or add a top level realm groupSet or create child.

### Example
```csharp
using System;
using System.Diagnostics;
using ;
using Keycloak.Client;
using Keycloak.Client.Models;

namespace Example
{
    public class PostGroupsExample
    {
        public void main()
        {
            

            var apiInstance = new GroupsApi();
            var realm = realm_example;  // string | realm name (not id!)
            var body = new GroupRepresentation(); // GroupRepresentation | GroupRepresentation (optional) 
            var ct = new CancellationToken(); // CancellationToken |  (optional) 

            try
            {
                apiInstance.PostGroups(realm, body, ct);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling GroupsApi.PostGroups: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **realm** | **string**| realm name (not id!) | 
 **body** | [**GroupRepresentation**](GroupRepresentation.md)| GroupRepresentation | [optional] 
 **ct** | [**CancellationToken**](.md)|  | [optional] 

### Return type

void (empty response body)

### Authorization

[access_token](../README.md#access_token)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="putgroupbyrealmbyid"></a>
# **PutGroupByRealmById**
> void PutGroupByRealmById (string realm, string id, GroupRepresentation body, CancellationToken ct)



Update group, ignores subgroups.

### Example
```csharp
using System;
using System.Diagnostics;
using ;
using Keycloak.Client;
using Keycloak.Client.Models;

namespace Example
{
    public class PutGroupByRealmByIdExample
    {
        public void main()
        {
            

            var apiInstance = new GroupsApi();
            var realm = realm_example;  // string | realm name (not id!)
            var id = id_example;  // string | 
            var body = new GroupRepresentation(); // GroupRepresentation | GroupRepresentation (optional) 
            var ct = new CancellationToken(); // CancellationToken |  (optional) 

            try
            {
                apiInstance.PutGroupByRealmById(realm, id, body, ct);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling GroupsApi.PutGroupByRealmById: " + e.Message );
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
 **body** | [**GroupRepresentation**](GroupRepresentation.md)| GroupRepresentation | [optional] 
 **ct** | [**CancellationToken**](.md)|  | [optional] 

### Return type

void (empty response body)

### Authorization

[access_token](../README.md#access_token)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="putgroupmanagementpermissions"></a>
# **PutGroupManagementPermissions**
> ManagementPermissionReference PutGroupManagementPermissions (string realm, string id, ManagementPermissionReference body, CancellationToken ct)



Return object stating whether client Authorization permissions have been initialized or not and a reference

### Example
```csharp
using System;
using System.Diagnostics;
using ;
using Keycloak.Client;
using Keycloak.Client.Models;

namespace Example
{
    public class PutGroupManagementPermissionsExample
    {
        public void main()
        {
            

            var apiInstance = new GroupsApi();
            var realm = realm_example;  // string | realm name (not id!)
            var id = id_example;  // string | 
            var body = new ManagementPermissionReference(); // ManagementPermissionReference | ManagementPermissionReference (optional) 
            var ct = new CancellationToken(); // CancellationToken |  (optional) 

            try
            {
                ManagementPermissionReference result = apiInstance.PutGroupManagementPermissions(realm, id, body, ct);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling GroupsApi.PutGroupManagementPermissions: " + e.Message );
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
 **body** | [**ManagementPermissionReference**](ManagementPermissionReference.md)| ManagementPermissionReference | [optional] 
 **ct** | [**CancellationToken**](.md)|  | [optional] 

### Return type

[**ManagementPermissionReference**](ManagementPermissionReference.md)

### Authorization

[access_token](../README.md#access_token)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

