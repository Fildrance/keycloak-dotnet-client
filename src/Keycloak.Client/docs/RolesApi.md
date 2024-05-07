# IO.Swagger.Api.RolesApi

All URIs are relative to *https://keycloak.example.com/admin/realms*

Method | HTTP request | Description
------------- | ------------- | -------------
[**DeleteClientRole**](RolesApi.md#deleteclientrole) | **Delete** /{realm}/clients/{id}/roles/{role-name} | 
[**DeleteClientRoleComposites**](RolesApi.md#deleteclientrolecomposites) | **Delete** /{realm}/clients/{id}/roles/{role-name}/composites | 
[**DeleteRoleByRealmByRoleName**](RolesApi.md#deleterolebyrealmbyrolename) | **Delete** /{realm}/roles/{role-name} | 
[**DeleteRoleCompositesByRealmByRoleName**](RolesApi.md#deleterolecompositesbyrealmbyrolename) | **Delete** /{realm}/roles/{role-name}/composites | 
[**GetClientRole**](RolesApi.md#getclientrole) | **Get** /{realm}/clients/{id}/roles/{role-name} | 
[**GetClientRoleComposites**](RolesApi.md#getclientrolecomposites) | **Get** /{realm}/clients/{id}/roles/{role-name}/composites | 
[**GetClientRoleCompositesClient**](RolesApi.md#getclientrolecompositesclient) | **Get** /{realm}/clients/{id}/roles/{role-name}/composites/clients/{clientUuid} | 
[**GetClientRoleCompositesRealm**](RolesApi.md#getclientrolecompositesrealm) | **Get** /{realm}/clients/{id}/roles/{role-name}/composites/realm | 
[**GetClientRoleGroups**](RolesApi.md#getclientrolegroups) | **Get** /{realm}/clients/{id}/roles/{role-name}/groups | 
[**GetClientRoleManagementPermissions**](RolesApi.md#getclientrolemanagementpermissions) | **Get** /{realm}/clients/{id}/roles/{role-name}/management/permissions | 
[**GetClientRoleUsers**](RolesApi.md#getclientroleusers) | **Get** /{realm}/clients/{id}/roles/{role-name}/users | 
[**GetClientRoles**](RolesApi.md#getclientroles) | **Get** /{realm}/clients/{id}/roles | 
[**GetRoleByRealmByRoleName**](RolesApi.md#getrolebyrealmbyrolename) | **Get** /{realm}/roles/{role-name} | 
[**GetRoleCompositesByRealmByRoleName**](RolesApi.md#getrolecompositesbyrealmbyrolename) | **Get** /{realm}/roles/{role-name}/composites | 
[**GetRoleCompositesClientByRealmByRoleNameByClientUuid**](RolesApi.md#getrolecompositesclientbyrealmbyrolenamebyclientuuid) | **Get** /{realm}/roles/{role-name}/composites/clients/{clientUuid} | 
[**GetRoleCompositesRealmByRealmByRoleName**](RolesApi.md#getrolecompositesrealmbyrealmbyrolename) | **Get** /{realm}/roles/{role-name}/composites/realm | 
[**GetRoleGroupsByRealmByRoleName**](RolesApi.md#getrolegroupsbyrealmbyrolename) | **Get** /{realm}/roles/{role-name}/groups | 
[**GetRoleManagementPermissionsByRealmByRoleName**](RolesApi.md#getrolemanagementpermissionsbyrealmbyrolename) | **Get** /{realm}/roles/{role-name}/management/permissions | 
[**GetRoleUsersByRealmByRoleName**](RolesApi.md#getroleusersbyrealmbyrolename) | **Get** /{realm}/roles/{role-name}/users | 
[**GetRolesByRealm**](RolesApi.md#getrolesbyrealm) | **Get** /{realm}/roles | 
[**PostClientRoleComposites**](RolesApi.md#postclientrolecomposites) | **Post** /{realm}/clients/{id}/roles/{role-name}/composites | 
[**PostClientRoles**](RolesApi.md#postclientroles) | **Post** /{realm}/clients/{id}/roles | 
[**PostRoleCompositesByRealmByRoleName**](RolesApi.md#postrolecompositesbyrealmbyrolename) | **Post** /{realm}/roles/{role-name}/composites | 
[**PostRolesByRealm**](RolesApi.md#postrolesbyrealm) | **Post** /{realm}/roles | 
[**PutClientRole**](RolesApi.md#putclientrole) | **Put** /{realm}/clients/{id}/roles/{role-name} | 
[**PutClientRoleManagementPermissions**](RolesApi.md#putclientrolemanagementpermissions) | **Put** /{realm}/clients/{id}/roles/{role-name}/management/permissions | 
[**PutRoleByRealmByRoleName**](RolesApi.md#putrolebyrealmbyrolename) | **Put** /{realm}/roles/{role-name} | 
[**PutRoleManagementPermissionsByRealmByRoleName**](RolesApi.md#putrolemanagementpermissionsbyrealmbyrolename) | **Put** /{realm}/roles/{role-name}/management/permissions | 


<a name="deleteclientrole"></a>
# **DeleteClientRole**
> void DeleteClientRole (string realm, string id, string roleName, CancellationToken ct)



Delete a role by name

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class DeleteClientRoleExample
    {
        public void main()
        {
            

            var apiInstance = new RolesApi();
            var realm = realm_example;  // string | realm name (not id!)
            var id = id_example;  // string | 
            var roleName = roleName_example;  // string | role's name (not id!)
            var ct = new CancellationToken(); // CancellationToken |  (optional) 

            try
            {
                apiInstance.DeleteClientRole(realm, id, roleName, ct);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling RolesApi.DeleteClientRole: " + e.Message );
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
 **roleName** | **string**| role&#39;s name (not id!) | 
 **ct** | [**CancellationToken**](.md)|  | [optional] 

### Return type

void (empty response body)

### Authorization

[access_token](../README.md#access_token)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="deleteclientrolecomposites"></a>
# **DeleteClientRoleComposites**
> void DeleteClientRoleComposites (string realm, string id, string roleName, RoleRepresentation body, CancellationToken ct)



Remove roles from the role’s composite

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class DeleteClientRoleCompositesExample
    {
        public void main()
        {
            

            var apiInstance = new RolesApi();
            var realm = realm_example;  // string | realm name (not id!)
            var id = id_example;  // string | 
            var roleName = roleName_example;  // string | role's name (not id!)
            var body = new RoleRepresentation(); // RoleRepresentation | RoleRepresentation (optional) 
            var ct = new CancellationToken(); // CancellationToken |  (optional) 

            try
            {
                apiInstance.DeleteClientRoleComposites(realm, id, roleName, body, ct);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling RolesApi.DeleteClientRoleComposites: " + e.Message );
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
 **roleName** | **string**| role&#39;s name (not id!) | 
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

<a name="deleterolebyrealmbyrolename"></a>
# **DeleteRoleByRealmByRoleName**
> void DeleteRoleByRealmByRoleName (string realm, string roleName, CancellationToken ct)



Delete a role by name

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class DeleteRoleByRealmByRoleNameExample
    {
        public void main()
        {
            

            var apiInstance = new RolesApi();
            var realm = realm_example;  // string | realm name (not id!)
            var roleName = roleName_example;  // string | role's name (not id!)
            var ct = new CancellationToken(); // CancellationToken |  (optional) 

            try
            {
                apiInstance.DeleteRoleByRealmByRoleName(realm, roleName, ct);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling RolesApi.DeleteRoleByRealmByRoleName: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **realm** | **string**| realm name (not id!) | 
 **roleName** | **string**| role&#39;s name (not id!) | 
 **ct** | [**CancellationToken**](.md)|  | [optional] 

### Return type

void (empty response body)

### Authorization

[access_token](../README.md#access_token)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="deleterolecompositesbyrealmbyrolename"></a>
# **DeleteRoleCompositesByRealmByRoleName**
> void DeleteRoleCompositesByRealmByRoleName (string realm, string roleName, RoleRepresentation body, CancellationToken ct)



Remove roles from the role’s composite

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class DeleteRoleCompositesByRealmByRoleNameExample
    {
        public void main()
        {
            

            var apiInstance = new RolesApi();
            var realm = realm_example;  // string | realm name (not id!)
            var roleName = roleName_example;  // string | role's name (not id!)
            var body = new RoleRepresentation(); // RoleRepresentation | RoleRepresentation (optional) 
            var ct = new CancellationToken(); // CancellationToken |  (optional) 

            try
            {
                apiInstance.DeleteRoleCompositesByRealmByRoleName(realm, roleName, body, ct);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling RolesApi.DeleteRoleCompositesByRealmByRoleName: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **realm** | **string**| realm name (not id!) | 
 **roleName** | **string**| role&#39;s name (not id!) | 
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

<a name="getclientrole"></a>
# **GetClientRole**
> RoleRepresentation GetClientRole (string realm, string id, string roleName, CancellationToken ct)



Get a role by name

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class GetClientRoleExample
    {
        public void main()
        {
            

            var apiInstance = new RolesApi();
            var realm = realm_example;  // string | realm name (not id!)
            var id = id_example;  // string | 
            var roleName = roleName_example;  // string | role's name (not id!)
            var ct = new CancellationToken(); // CancellationToken |  (optional) 

            try
            {
                RoleRepresentation result = apiInstance.GetClientRole(realm, id, roleName, ct);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling RolesApi.GetClientRole: " + e.Message );
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
 **roleName** | **string**| role&#39;s name (not id!) | 
 **ct** | [**CancellationToken**](.md)|  | [optional] 

### Return type

[**RoleRepresentation**](RoleRepresentation.md)

### Authorization

[access_token](../README.md#access_token)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getclientrolecomposites"></a>
# **GetClientRoleComposites**
> List<RoleRepresentation> GetClientRoleComposites (string realm, string id, string roleName, CancellationToken ct)



Get composites of the role

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class GetClientRoleCompositesExample
    {
        public void main()
        {
            

            var apiInstance = new RolesApi();
            var realm = realm_example;  // string | realm name (not id!)
            var id = id_example;  // string | 
            var roleName = roleName_example;  // string | role's name (not id!)
            var ct = new CancellationToken(); // CancellationToken |  (optional) 

            try
            {
                List&lt;RoleRepresentation&gt; result = apiInstance.GetClientRoleComposites(realm, id, roleName, ct);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling RolesApi.GetClientRoleComposites: " + e.Message );
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
 **roleName** | **string**| role&#39;s name (not id!) | 
 **ct** | [**CancellationToken**](.md)|  | [optional] 

### Return type

[**List<RoleRepresentation>**](RoleRepresentation.md)

### Authorization

[access_token](../README.md#access_token)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getclientrolecompositesclient"></a>
# **GetClientRoleCompositesClient**
> List<RoleRepresentation> GetClientRoleCompositesClient (string realm, string id, string roleName, string clientUuid, CancellationToken ct)



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
    public class GetClientRoleCompositesClientExample
    {
        public void main()
        {
            

            var apiInstance = new RolesApi();
            var realm = realm_example;  // string | realm name (not id!)
            var id = id_example;  // string | 
            var roleName = roleName_example;  // string | role's name (not id!)
            var clientUuid = clientUuid_example;  // string | 
            var ct = new CancellationToken(); // CancellationToken |  (optional) 

            try
            {
                List&lt;RoleRepresentation&gt; result = apiInstance.GetClientRoleCompositesClient(realm, id, roleName, clientUuid, ct);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling RolesApi.GetClientRoleCompositesClient: " + e.Message );
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
 **roleName** | **string**| role&#39;s name (not id!) | 
 **clientUuid** | **string**|  | 
 **ct** | [**CancellationToken**](.md)|  | [optional] 

### Return type

[**List<RoleRepresentation>**](RoleRepresentation.md)

### Authorization

[access_token](../README.md#access_token)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getclientrolecompositesrealm"></a>
# **GetClientRoleCompositesRealm**
> List<RoleRepresentation> GetClientRoleCompositesRealm (string realm, string id, string roleName, CancellationToken ct)



Get realm-level roles of the role’s composite

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class GetClientRoleCompositesRealmExample
    {
        public void main()
        {
            

            var apiInstance = new RolesApi();
            var realm = realm_example;  // string | realm name (not id!)
            var id = id_example;  // string | 
            var roleName = roleName_example;  // string | role's name (not id!)
            var ct = new CancellationToken(); // CancellationToken |  (optional) 

            try
            {
                List&lt;RoleRepresentation&gt; result = apiInstance.GetClientRoleCompositesRealm(realm, id, roleName, ct);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling RolesApi.GetClientRoleCompositesRealm: " + e.Message );
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
 **roleName** | **string**| role&#39;s name (not id!) | 
 **ct** | [**CancellationToken**](.md)|  | [optional] 

### Return type

[**List<RoleRepresentation>**](RoleRepresentation.md)

### Authorization

[access_token](../README.md#access_token)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getclientrolegroups"></a>
# **GetClientRoleGroups**
> List<GroupRepresentation> GetClientRoleGroups (string realm, string id, string roleName, string briefRepresentation, string first, string max, CancellationToken ct)



Returns a stream of groups that have the specified role name

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class GetClientRoleGroupsExample
    {
        public void main()
        {
            

            var apiInstance = new RolesApi();
            var realm = realm_example;  // string | realm name (not id!)
            var id = id_example;  // string | 
            var roleName = roleName_example;  // string | the role name.
            var briefRepresentation = briefRepresentation_example;  // string | if false, return a full representation of the {@code GroupRepresentation} objects. (optional) 
            var first = first_example;  // string | first result to return. Ignored if negative or {@code null}. (optional) 
            var max = max_example;  // string | maximum number of results to return. Ignored if negative or {@code null}. (optional) 
            var ct = new CancellationToken(); // CancellationToken |  (optional) 

            try
            {
                List&lt;GroupRepresentation&gt; result = apiInstance.GetClientRoleGroups(realm, id, roleName, briefRepresentation, first, max, ct);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling RolesApi.GetClientRoleGroups: " + e.Message );
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
 **roleName** | **string**| the role name. | 
 **briefRepresentation** | **string**| if false, return a full representation of the {@code GroupRepresentation} objects. | [optional] 
 **first** | **string**| first result to return. Ignored if negative or {@code null}. | [optional] 
 **max** | **string**| maximum number of results to return. Ignored if negative or {@code null}. | [optional] 
 **ct** | [**CancellationToken**](.md)|  | [optional] 

### Return type

[**List<GroupRepresentation>**](GroupRepresentation.md)

### Authorization

[access_token](../README.md#access_token)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getclientrolemanagementpermissions"></a>
# **GetClientRoleManagementPermissions**
> ManagementPermissionReference GetClientRoleManagementPermissions (string realm, string id, string roleName, CancellationToken ct)



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
    public class GetClientRoleManagementPermissionsExample
    {
        public void main()
        {
            

            var apiInstance = new RolesApi();
            var realm = realm_example;  // string | realm name (not id!)
            var id = id_example;  // string | 
            var roleName = roleName_example;  // string | 
            var ct = new CancellationToken(); // CancellationToken |  (optional) 

            try
            {
                ManagementPermissionReference result = apiInstance.GetClientRoleManagementPermissions(realm, id, roleName, ct);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling RolesApi.GetClientRoleManagementPermissions: " + e.Message );
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
 **roleName** | **string**|  | 
 **ct** | [**CancellationToken**](.md)|  | [optional] 

### Return type

[**ManagementPermissionReference**](ManagementPermissionReference.md)

### Authorization

[access_token](../README.md#access_token)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getclientroleusers"></a>
# **GetClientRoleUsers**
> List<UserRepresentation> GetClientRoleUsers (string realm, string id, string roleName, string first, string max, CancellationToken ct)



Returns a stream of users that have the specified role name.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class GetClientRoleUsersExample
    {
        public void main()
        {
            

            var apiInstance = new RolesApi();
            var realm = realm_example;  // string | realm name (not id!)
            var id = id_example;  // string | 
            var roleName = roleName_example;  // string | the role name.
            var first = first_example;  // string | first result to return. Ignored if negative or {@code null}. (optional) 
            var max = max_example;  // string | maximum number of results to return. Ignored if negative or {@code null}. (optional) 
            var ct = new CancellationToken(); // CancellationToken |  (optional) 

            try
            {
                List&lt;UserRepresentation&gt; result = apiInstance.GetClientRoleUsers(realm, id, roleName, first, max, ct);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling RolesApi.GetClientRoleUsers: " + e.Message );
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
 **roleName** | **string**| the role name. | 
 **first** | **string**| first result to return. Ignored if negative or {@code null}. | [optional] 
 **max** | **string**| maximum number of results to return. Ignored if negative or {@code null}. | [optional] 
 **ct** | [**CancellationToken**](.md)|  | [optional] 

### Return type

[**List<UserRepresentation>**](UserRepresentation.md)

### Authorization

[access_token](../README.md#access_token)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getclientroles"></a>
# **GetClientRoles**
> List<RoleRepresentation> GetClientRoles (string realm, string id, string briefRepresentation, string first, string max, string search, CancellationToken ct)



Get all roles for the realm or client

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class GetClientRolesExample
    {
        public void main()
        {
            

            var apiInstance = new RolesApi();
            var realm = realm_example;  // string | realm name (not id!)
            var id = id_example;  // string | 
            var briefRepresentation = briefRepresentation_example;  // string |  (optional) 
            var first = first_example;  // string |  (optional) 
            var max = max_example;  // string |  (optional) 
            var search = search_example;  // string |  (optional) 
            var ct = new CancellationToken(); // CancellationToken |  (optional) 

            try
            {
                List&lt;RoleRepresentation&gt; result = apiInstance.GetClientRoles(realm, id, briefRepresentation, first, max, search, ct);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling RolesApi.GetClientRoles: " + e.Message );
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
 **search** | **string**|  | [optional] 
 **ct** | [**CancellationToken**](.md)|  | [optional] 

### Return type

[**List<RoleRepresentation>**](RoleRepresentation.md)

### Authorization

[access_token](../README.md#access_token)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getrolebyrealmbyrolename"></a>
# **GetRoleByRealmByRoleName**
> RoleRepresentation GetRoleByRealmByRoleName (string realm, string roleName, CancellationToken ct)



Get a role by name

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class GetRoleByRealmByRoleNameExample
    {
        public void main()
        {
            

            var apiInstance = new RolesApi();
            var realm = realm_example;  // string | realm name (not id!)
            var roleName = roleName_example;  // string | role's name (not id!)
            var ct = new CancellationToken(); // CancellationToken |  (optional) 

            try
            {
                RoleRepresentation result = apiInstance.GetRoleByRealmByRoleName(realm, roleName, ct);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling RolesApi.GetRoleByRealmByRoleName: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **realm** | **string**| realm name (not id!) | 
 **roleName** | **string**| role&#39;s name (not id!) | 
 **ct** | [**CancellationToken**](.md)|  | [optional] 

### Return type

[**RoleRepresentation**](RoleRepresentation.md)

### Authorization

[access_token](../README.md#access_token)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getrolecompositesbyrealmbyrolename"></a>
# **GetRoleCompositesByRealmByRoleName**
> List<RoleRepresentation> GetRoleCompositesByRealmByRoleName (string realm, string roleName, CancellationToken ct)



Get composites of the role

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class GetRoleCompositesByRealmByRoleNameExample
    {
        public void main()
        {
            

            var apiInstance = new RolesApi();
            var realm = realm_example;  // string | realm name (not id!)
            var roleName = roleName_example;  // string | role's name (not id!)
            var ct = new CancellationToken(); // CancellationToken |  (optional) 

            try
            {
                List&lt;RoleRepresentation&gt; result = apiInstance.GetRoleCompositesByRealmByRoleName(realm, roleName, ct);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling RolesApi.GetRoleCompositesByRealmByRoleName: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **realm** | **string**| realm name (not id!) | 
 **roleName** | **string**| role&#39;s name (not id!) | 
 **ct** | [**CancellationToken**](.md)|  | [optional] 

### Return type

[**List<RoleRepresentation>**](RoleRepresentation.md)

### Authorization

[access_token](../README.md#access_token)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getrolecompositesclientbyrealmbyrolenamebyclientuuid"></a>
# **GetRoleCompositesClientByRealmByRoleNameByClientUuid**
> List<RoleRepresentation> GetRoleCompositesClientByRealmByRoleNameByClientUuid (string realm, string roleName, string clientUuid, CancellationToken ct)



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
    public class GetRoleCompositesClientByRealmByRoleNameByClientUuidExample
    {
        public void main()
        {
            

            var apiInstance = new RolesApi();
            var realm = realm_example;  // string | realm name (not id!)
            var roleName = roleName_example;  // string | role's name (not id!)
            var clientUuid = clientUuid_example;  // string | 
            var ct = new CancellationToken(); // CancellationToken |  (optional) 

            try
            {
                List&lt;RoleRepresentation&gt; result = apiInstance.GetRoleCompositesClientByRealmByRoleNameByClientUuid(realm, roleName, clientUuid, ct);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling RolesApi.GetRoleCompositesClientByRealmByRoleNameByClientUuid: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **realm** | **string**| realm name (not id!) | 
 **roleName** | **string**| role&#39;s name (not id!) | 
 **clientUuid** | **string**|  | 
 **ct** | [**CancellationToken**](.md)|  | [optional] 

### Return type

[**List<RoleRepresentation>**](RoleRepresentation.md)

### Authorization

[access_token](../README.md#access_token)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getrolecompositesrealmbyrealmbyrolename"></a>
# **GetRoleCompositesRealmByRealmByRoleName**
> List<RoleRepresentation> GetRoleCompositesRealmByRealmByRoleName (string realm, string roleName, CancellationToken ct)



Get realm-level roles of the role’s composite

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class GetRoleCompositesRealmByRealmByRoleNameExample
    {
        public void main()
        {
            

            var apiInstance = new RolesApi();
            var realm = realm_example;  // string | realm name (not id!)
            var roleName = roleName_example;  // string | role's name (not id!)
            var ct = new CancellationToken(); // CancellationToken |  (optional) 

            try
            {
                List&lt;RoleRepresentation&gt; result = apiInstance.GetRoleCompositesRealmByRealmByRoleName(realm, roleName, ct);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling RolesApi.GetRoleCompositesRealmByRealmByRoleName: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **realm** | **string**| realm name (not id!) | 
 **roleName** | **string**| role&#39;s name (not id!) | 
 **ct** | [**CancellationToken**](.md)|  | [optional] 

### Return type

[**List<RoleRepresentation>**](RoleRepresentation.md)

### Authorization

[access_token](../README.md#access_token)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getrolegroupsbyrealmbyrolename"></a>
# **GetRoleGroupsByRealmByRoleName**
> List<GroupRepresentation> GetRoleGroupsByRealmByRoleName (string realm, string roleName, string briefRepresentation, string first, string max, CancellationToken ct)



Returns a stream of groups that have the specified role name

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class GetRoleGroupsByRealmByRoleNameExample
    {
        public void main()
        {
            

            var apiInstance = new RolesApi();
            var realm = realm_example;  // string | realm name (not id!)
            var roleName = roleName_example;  // string | the role name.
            var briefRepresentation = briefRepresentation_example;  // string | if false, return a full representation of the {@code GroupRepresentation} objects. (optional) 
            var first = first_example;  // string | first result to return. Ignored if negative or {@code null}. (optional) 
            var max = max_example;  // string | maximum number of results to return. Ignored if negative or {@code null}. (optional) 
            var ct = new CancellationToken(); // CancellationToken |  (optional) 

            try
            {
                List&lt;GroupRepresentation&gt; result = apiInstance.GetRoleGroupsByRealmByRoleName(realm, roleName, briefRepresentation, first, max, ct);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling RolesApi.GetRoleGroupsByRealmByRoleName: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **realm** | **string**| realm name (not id!) | 
 **roleName** | **string**| the role name. | 
 **briefRepresentation** | **string**| if false, return a full representation of the {@code GroupRepresentation} objects. | [optional] 
 **first** | **string**| first result to return. Ignored if negative or {@code null}. | [optional] 
 **max** | **string**| maximum number of results to return. Ignored if negative or {@code null}. | [optional] 
 **ct** | [**CancellationToken**](.md)|  | [optional] 

### Return type

[**List<GroupRepresentation>**](GroupRepresentation.md)

### Authorization

[access_token](../README.md#access_token)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getrolemanagementpermissionsbyrealmbyrolename"></a>
# **GetRoleManagementPermissionsByRealmByRoleName**
> ManagementPermissionReference GetRoleManagementPermissionsByRealmByRoleName (string realm, string roleName, CancellationToken ct)



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
    public class GetRoleManagementPermissionsByRealmByRoleNameExample
    {
        public void main()
        {
            

            var apiInstance = new RolesApi();
            var realm = realm_example;  // string | realm name (not id!)
            var roleName = roleName_example;  // string | 
            var ct = new CancellationToken(); // CancellationToken |  (optional) 

            try
            {
                ManagementPermissionReference result = apiInstance.GetRoleManagementPermissionsByRealmByRoleName(realm, roleName, ct);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling RolesApi.GetRoleManagementPermissionsByRealmByRoleName: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **realm** | **string**| realm name (not id!) | 
 **roleName** | **string**|  | 
 **ct** | [**CancellationToken**](.md)|  | [optional] 

### Return type

[**ManagementPermissionReference**](ManagementPermissionReference.md)

### Authorization

[access_token](../README.md#access_token)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getroleusersbyrealmbyrolename"></a>
# **GetRoleUsersByRealmByRoleName**
> List<UserRepresentation> GetRoleUsersByRealmByRoleName (string realm, string roleName, string first, string max, CancellationToken ct)



Returns a stream of users that have the specified role name.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class GetRoleUsersByRealmByRoleNameExample
    {
        public void main()
        {
            

            var apiInstance = new RolesApi();
            var realm = realm_example;  // string | realm name (not id!)
            var roleName = roleName_example;  // string | the role name.
            var first = first_example;  // string | first result to return. Ignored if negative or {@code null}. (optional) 
            var max = max_example;  // string | maximum number of results to return. Ignored if negative or {@code null}. (optional) 
            var ct = new CancellationToken(); // CancellationToken |  (optional) 

            try
            {
                List&lt;UserRepresentation&gt; result = apiInstance.GetRoleUsersByRealmByRoleName(realm, roleName, first, max, ct);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling RolesApi.GetRoleUsersByRealmByRoleName: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **realm** | **string**| realm name (not id!) | 
 **roleName** | **string**| the role name. | 
 **first** | **string**| first result to return. Ignored if negative or {@code null}. | [optional] 
 **max** | **string**| maximum number of results to return. Ignored if negative or {@code null}. | [optional] 
 **ct** | [**CancellationToken**](.md)|  | [optional] 

### Return type

[**List<UserRepresentation>**](UserRepresentation.md)

### Authorization

[access_token](../README.md#access_token)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getrolesbyrealm"></a>
# **GetRolesByRealm**
> List<RoleRepresentation> GetRolesByRealm (string realm, string briefRepresentation, string first, string max, string search, CancellationToken ct)



Get all roles for the realm or client

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class GetRolesByRealmExample
    {
        public void main()
        {
            

            var apiInstance = new RolesApi();
            var realm = realm_example;  // string | realm name (not id!)
            var briefRepresentation = briefRepresentation_example;  // string |  (optional) 
            var first = first_example;  // string |  (optional) 
            var max = max_example;  // string |  (optional) 
            var search = search_example;  // string |  (optional) 
            var ct = new CancellationToken(); // CancellationToken |  (optional) 

            try
            {
                List&lt;RoleRepresentation&gt; result = apiInstance.GetRolesByRealm(realm, briefRepresentation, first, max, search, ct);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling RolesApi.GetRolesByRealm: " + e.Message );
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
 **first** | **string**|  | [optional] 
 **max** | **string**|  | [optional] 
 **search** | **string**|  | [optional] 
 **ct** | [**CancellationToken**](.md)|  | [optional] 

### Return type

[**List<RoleRepresentation>**](RoleRepresentation.md)

### Authorization

[access_token](../README.md#access_token)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="postclientrolecomposites"></a>
# **PostClientRoleComposites**
> void PostClientRoleComposites (string realm, string id, string roleName, RoleRepresentation body, CancellationToken ct)



Add a composite to the role

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class PostClientRoleCompositesExample
    {
        public void main()
        {
            

            var apiInstance = new RolesApi();
            var realm = realm_example;  // string | realm name (not id!)
            var id = id_example;  // string | 
            var roleName = roleName_example;  // string | role's name (not id!)
            var body = new RoleRepresentation(); // RoleRepresentation | RoleRepresentation (optional) 
            var ct = new CancellationToken(); // CancellationToken |  (optional) 

            try
            {
                apiInstance.PostClientRoleComposites(realm, id, roleName, body, ct);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling RolesApi.PostClientRoleComposites: " + e.Message );
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
 **roleName** | **string**| role&#39;s name (not id!) | 
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

<a name="postclientroles"></a>
# **PostClientRoles**
> void PostClientRoles (string realm, string id, RoleRepresentation body, CancellationToken ct)



Create a new role for the realm or client

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class PostClientRolesExample
    {
        public void main()
        {
            

            var apiInstance = new RolesApi();
            var realm = realm_example;  // string | realm name (not id!)
            var id = id_example;  // string | 
            var body = new RoleRepresentation(); // RoleRepresentation | RoleRepresentation (optional) 
            var ct = new CancellationToken(); // CancellationToken |  (optional) 

            try
            {
                apiInstance.PostClientRoles(realm, id, body, ct);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling RolesApi.PostClientRoles: " + e.Message );
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
 **ct** | [**CancellationToken**](.md)|  | [optional] 

### Return type

void (empty response body)

### Authorization

[access_token](../README.md#access_token)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="postrolecompositesbyrealmbyrolename"></a>
# **PostRoleCompositesByRealmByRoleName**
> void PostRoleCompositesByRealmByRoleName (string realm, string roleName, RoleRepresentation body, CancellationToken ct)



Add a composite to the role

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class PostRoleCompositesByRealmByRoleNameExample
    {
        public void main()
        {
            

            var apiInstance = new RolesApi();
            var realm = realm_example;  // string | realm name (not id!)
            var roleName = roleName_example;  // string | role's name (not id!)
            var body = new RoleRepresentation(); // RoleRepresentation | RoleRepresentation (optional) 
            var ct = new CancellationToken(); // CancellationToken |  (optional) 

            try
            {
                apiInstance.PostRoleCompositesByRealmByRoleName(realm, roleName, body, ct);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling RolesApi.PostRoleCompositesByRealmByRoleName: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **realm** | **string**| realm name (not id!) | 
 **roleName** | **string**| role&#39;s name (not id!) | 
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

<a name="postrolesbyrealm"></a>
# **PostRolesByRealm**
> void PostRolesByRealm (string realm, RoleRepresentation body, CancellationToken ct)



Create a new role for the realm or client

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class PostRolesByRealmExample
    {
        public void main()
        {
            

            var apiInstance = new RolesApi();
            var realm = realm_example;  // string | realm name (not id!)
            var body = new RoleRepresentation(); // RoleRepresentation | RoleRepresentation (optional) 
            var ct = new CancellationToken(); // CancellationToken |  (optional) 

            try
            {
                apiInstance.PostRolesByRealm(realm, body, ct);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling RolesApi.PostRolesByRealm: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **realm** | **string**| realm name (not id!) | 
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

<a name="putclientrole"></a>
# **PutClientRole**
> void PutClientRole (string realm, string id, string roleName, RoleRepresentation body, CancellationToken ct)



Update a role by name

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class PutClientRoleExample
    {
        public void main()
        {
            

            var apiInstance = new RolesApi();
            var realm = realm_example;  // string | realm name (not id!)
            var id = id_example;  // string | 
            var roleName = roleName_example;  // string | role's name (not id!)
            var body = new RoleRepresentation(); // RoleRepresentation | RoleRepresentation (optional) 
            var ct = new CancellationToken(); // CancellationToken |  (optional) 

            try
            {
                apiInstance.PutClientRole(realm, id, roleName, body, ct);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling RolesApi.PutClientRole: " + e.Message );
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
 **roleName** | **string**| role&#39;s name (not id!) | 
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

<a name="putclientrolemanagementpermissions"></a>
# **PutClientRoleManagementPermissions**
> ManagementPermissionReference PutClientRoleManagementPermissions (string realm, string id, string roleName, ManagementPermissionReference body, CancellationToken ct)



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
    public class PutClientRoleManagementPermissionsExample
    {
        public void main()
        {
            

            var apiInstance = new RolesApi();
            var realm = realm_example;  // string | realm name (not id!)
            var id = id_example;  // string | 
            var roleName = roleName_example;  // string | 
            var body = new ManagementPermissionReference(); // ManagementPermissionReference | ManagementPermissionReference (optional) 
            var ct = new CancellationToken(); // CancellationToken |  (optional) 

            try
            {
                ManagementPermissionReference result = apiInstance.PutClientRoleManagementPermissions(realm, id, roleName, body, ct);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling RolesApi.PutClientRoleManagementPermissions: " + e.Message );
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
 **roleName** | **string**|  | 
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

<a name="putrolebyrealmbyrolename"></a>
# **PutRoleByRealmByRoleName**
> void PutRoleByRealmByRoleName (string realm, string roleName, RoleRepresentation body, CancellationToken ct)



Update a role by name

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class PutRoleByRealmByRoleNameExample
    {
        public void main()
        {
            

            var apiInstance = new RolesApi();
            var realm = realm_example;  // string | realm name (not id!)
            var roleName = roleName_example;  // string | role's name (not id!)
            var body = new RoleRepresentation(); // RoleRepresentation | RoleRepresentation (optional) 
            var ct = new CancellationToken(); // CancellationToken |  (optional) 

            try
            {
                apiInstance.PutRoleByRealmByRoleName(realm, roleName, body, ct);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling RolesApi.PutRoleByRealmByRoleName: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **realm** | **string**| realm name (not id!) | 
 **roleName** | **string**| role&#39;s name (not id!) | 
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

<a name="putrolemanagementpermissionsbyrealmbyrolename"></a>
# **PutRoleManagementPermissionsByRealmByRoleName**
> ManagementPermissionReference PutRoleManagementPermissionsByRealmByRoleName (string realm, string roleName, ManagementPermissionReference body, CancellationToken ct)



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
    public class PutRoleManagementPermissionsByRealmByRoleNameExample
    {
        public void main()
        {
            

            var apiInstance = new RolesApi();
            var realm = realm_example;  // string | realm name (not id!)
            var roleName = roleName_example;  // string | 
            var body = new ManagementPermissionReference(); // ManagementPermissionReference | ManagementPermissionReference (optional) 
            var ct = new CancellationToken(); // CancellationToken |  (optional) 

            try
            {
                ManagementPermissionReference result = apiInstance.PutRoleManagementPermissionsByRealmByRoleName(realm, roleName, body, ct);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling RolesApi.PutRoleManagementPermissionsByRealmByRoleName: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **realm** | **string**| realm name (not id!) | 
 **roleName** | **string**|  | 
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

