# IO.Swagger.Api.ClientsApi

All URIs are relative to *https://keycloak.example.com/admin/realms*

Method | HTTP request | Description
------------- | ------------- | -------------
[**DeleteClientByRealmById**](ClientsApi.md#deleteclientbyrealmbyid) | **DELETE** /{realm}/clients/{id} | 
[**DeleteDefaultClientScope**](ClientsApi.md#deletedefaultclientscope) | **DELETE** /{realm}/clients/{id}/default-client-scopes/{clientScopeId} | 
[**DeleteNode**](ClientsApi.md#deletenode) | **DELETE** /{realm}/clients/{id}/nodes/{node} | 
[**DeleteOptionalClientScope**](ClientsApi.md#deleteoptionalclientscope) | **DELETE** /{realm}/clients/{id}/optional-client-scopes/{clientScopeId} | 
[**DeleteRotated**](ClientsApi.md#deleterotated) | **DELETE** /{realm}/clients/{id}/client-secret/rotated | 
[**GetClientByRealmById**](ClientsApi.md#getclientbyrealmbyid) | **GET** /{realm}/clients/{id} | 
[**GetClientManagementPermissions**](ClientsApi.md#getclientmanagementpermissions) | **GET** /{realm}/clients/{id}/management/permissions | 
[**GetClientSecret**](ClientsApi.md#getclientsecret) | **GET** /{realm}/clients/{id}/client-secret | 
[**GetClientUserSessions**](ClientsApi.md#getclientusersessions) | **GET** /{realm}/clients/{id}/user-sessions | 
[**GetClients**](ClientsApi.md#getclients) | **GET** /{realm}/clients | 
[**GetDefaultClientScopes**](ClientsApi.md#getdefaultclientscopes) | **GET** /{realm}/clients/{id}/default-client-scopes | 
[**GetGenerateExampleAccessToken**](ClientsApi.md#getgenerateexampleaccesstoken) | **GET** /{realm}/clients/{id}/evaluate-scopes/generate-example-access-token | 
[**GetGenerateExampleIdToken**](ClientsApi.md#getgenerateexampleidtoken) | **GET** /{realm}/clients/{id}/evaluate-scopes/generate-example-id-token | 
[**GetGenerateExampleUserinfo**](ClientsApi.md#getgenerateexampleuserinfo) | **GET** /{realm}/clients/{id}/evaluate-scopes/generate-example-userinfo | 
[**GetGranted**](ClientsApi.md#getgranted) | **GET** /{realm}/clients/{id}/evaluate-scopes/scope-mappings/{roleContainerId}/granted | 
[**GetInstallationProvider**](ClientsApi.md#getinstallationprovider) | **GET** /{realm}/clients/{id}/installation/providers/{providerId} | 
[**GetNotGranted**](ClientsApi.md#getnotgranted) | **GET** /{realm}/clients/{id}/evaluate-scopes/scope-mappings/{roleContainerId}/not-granted | 
[**GetOfflineSessionCount**](ClientsApi.md#getofflinesessioncount) | **GET** /{realm}/clients/{id}/offline-session-count | 
[**GetOfflineSessions**](ClientsApi.md#getofflinesessions) | **GET** /{realm}/clients/{id}/offline-sessions | 
[**GetOptionalClientScopes**](ClientsApi.md#getoptionalclientscopes) | **GET** /{realm}/clients/{id}/optional-client-scopes | 
[**GetProtocolMappers**](ClientsApi.md#getprotocolmappers) | **GET** /{realm}/clients/{id}/evaluate-scopes/protocol-mappers | 
[**GetRotated**](ClientsApi.md#getrotated) | **GET** /{realm}/clients/{id}/client-secret/rotated | 
[**GetServiceAccountUser**](ClientsApi.md#getserviceaccountuser) | **GET** /{realm}/clients/{id}/service-account-user | 
[**GetSessionCount**](ClientsApi.md#getsessioncount) | **GET** /{realm}/clients/{id}/session-count | 
[**GetTestNodesAvailable**](ClientsApi.md#gettestnodesavailable) | **GET** /{realm}/clients/{id}/test-nodes-available | 
[**PostClientPushRevocation**](ClientsApi.md#postclientpushrevocation) | **POST** /{realm}/clients/{id}/push-revocation | 
[**PostClientSecret**](ClientsApi.md#postclientsecret) | **POST** /{realm}/clients/{id}/client-secret | 
[**PostClients**](ClientsApi.md#postclients) | **POST** /{realm}/clients | 
[**PostNodes**](ClientsApi.md#postnodes) | **POST** /{realm}/clients/{id}/nodes | 
[**PostRegistrationAccessToken**](ClientsApi.md#postregistrationaccesstoken) | **POST** /{realm}/clients/{id}/registration-access-token | 
[**PutClient**](ClientsApi.md#putclient) | **PUT** /{realm}/clients/{id} | 
[**PutClientManagementPermissions**](ClientsApi.md#putclientmanagementpermissions) | **PUT** /{realm}/clients/{id}/management/permissions | 
[**PutDefaultClientScope**](ClientsApi.md#putdefaultclientscope) | **PUT** /{realm}/clients/{id}/default-client-scopes/{clientScopeId} | 
[**PutOptionalClientScope**](ClientsApi.md#putoptionalclientscope) | **PUT** /{realm}/clients/{id}/optional-client-scopes/{clientScopeId} | 

<a name="deleteclientbyrealmbyid"></a>
# **DeleteClientByRealmById**
> void DeleteClientByRealmById (string realm, string id)



Delete the client

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class DeleteClientByRealmByIdExample
    {
        public void main()
        {


            var apiInstance = new ClientsApi();
            var realm = realm_example;  // string | realm name (not id!)
            var id = id_example;  // string | 

            try
            {
                apiInstance.DeleteClientByRealmById(realm, id);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ClientsApi.DeleteClientByRealmById: " + e.Message );
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

void (empty response body)

### Authorization

[access_token](../README.md#access_token)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="deletedefaultclientscope"></a>
# **DeleteDefaultClientScope**
> void DeleteDefaultClientScope (string realm, string id, string clientScopeId)



### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class DeleteDefaultClientScopeExample
    {
        public void main()
        {


            var apiInstance = new ClientsApi();
            var realm = realm_example;  // string | realm name (not id!)
            var id = id_example;  // string | 
            var clientScopeId = clientScopeId_example;  // string | 

            try
            {
                apiInstance.DeleteDefaultClientScope(realm, id, clientScopeId);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ClientsApi.DeleteDefaultClientScope: " + e.Message );
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
 **clientScopeId** | **string**|  | 

### Return type

void (empty response body)

### Authorization

[access_token](../README.md#access_token)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="deletenode"></a>
# **DeleteNode**
> void DeleteNode (string realm, string id, string node)



Unregister a cluster node from the client

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class DeleteNodeExample
    {
        public void main()
        {


            var apiInstance = new ClientsApi();
            var realm = realm_example;  // string | realm name (not id!)
            var id = id_example;  // string | 
            var node = node_example;  // string | 

            try
            {
                apiInstance.DeleteNode(realm, id, node);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ClientsApi.DeleteNode: " + e.Message );
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
 **node** | **string**|  | 

### Return type

void (empty response body)

### Authorization

[access_token](../README.md#access_token)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="deleteoptionalclientscope"></a>
# **DeleteOptionalClientScope**
> void DeleteOptionalClientScope (string realm, string id, string clientScopeId)



### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class DeleteOptionalClientScopeExample
    {
        public void main()
        {


            var apiInstance = new ClientsApi();
            var realm = realm_example;  // string | realm name (not id!)
            var id = id_example;  // string | 
            var clientScopeId = clientScopeId_example;  // string | 

            try
            {
                apiInstance.DeleteOptionalClientScope(realm, id, clientScopeId);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ClientsApi.DeleteOptionalClientScope: " + e.Message );
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
 **clientScopeId** | **string**|  | 

### Return type

void (empty response body)

### Authorization

[access_token](../README.md#access_token)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="deleterotated"></a>
# **DeleteRotated**
> void DeleteRotated (string realm, string id)



Invalidate the rotated secret for the client

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class DeleteRotatedExample
    {
        public void main()
        {


            var apiInstance = new ClientsApi();
            var realm = realm_example;  // string | realm name (not id!)
            var id = id_example;  // string | 

            try
            {
                apiInstance.DeleteRotated(realm, id);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ClientsApi.DeleteRotated: " + e.Message );
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

void (empty response body)

### Authorization

[access_token](../README.md#access_token)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getclientbyrealmbyid"></a>
# **GetClientByRealmById**
> ClientRepresentation GetClientByRealmById (string realm, string id)



Get representation of the client

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class GetClientByRealmByIdExample
    {
        public void main()
        {


            var apiInstance = new ClientsApi();
            var realm = realm_example;  // string | realm name (not id!)
            var id = id_example;  // string | 

            try
            {
                ClientRepresentation result = apiInstance.GetClientByRealmById(realm, id);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ClientsApi.GetClientByRealmById: " + e.Message );
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

[**ClientRepresentation**](ClientRepresentation.md)

### Authorization

[access_token](../README.md#access_token)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getclientmanagementpermissions"></a>
# **GetClientManagementPermissions**
> ManagementPermissionReference GetClientManagementPermissions (string realm, string id)



Return object stating whether client Authorization permissions have been initialized or not and a reference

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class GetClientManagementPermissionsExample
    {
        public void main()
        {


            var apiInstance = new ClientsApi();
            var realm = realm_example;  // string | realm name (not id!)
            var id = id_example;  // string | 

            try
            {
                ManagementPermissionReference result = apiInstance.GetClientManagementPermissions(realm, id);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ClientsApi.GetClientManagementPermissions: " + e.Message );
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

[**ManagementPermissionReference**](ManagementPermissionReference.md)

### Authorization

[access_token](../README.md#access_token)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getclientsecret"></a>
# **GetClientSecret**
> CredentialRepresentation GetClientSecret (string realm, string id)



Get the client secret

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class GetClientSecretExample
    {
        public void main()
        {


            var apiInstance = new ClientsApi();
            var realm = realm_example;  // string | realm name (not id!)
            var id = id_example;  // string | 

            try
            {
                CredentialRepresentation result = apiInstance.GetClientSecret(realm, id);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ClientsApi.GetClientSecret: " + e.Message );
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

[**CredentialRepresentation**](CredentialRepresentation.md)

### Authorization

[access_token](../README.md#access_token)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getclientusersessions"></a>
# **GetClientUserSessions**
> List<UserSessionRepresentation> GetClientUserSessions (string realm, string id, string first, string max)



Get user sessions for client Returns a list of user sessions associated with this client

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class GetClientUserSessionsExample
    {
        public void main()
        {


            var apiInstance = new ClientsApi();
            var realm = realm_example;  // string | realm name (not id!)
            var id = id_example;  // string | 
            var first = first_example;  // string | Paging offset (optional) 
            var max = max_example;  // string | Maximum results size (defaults to 100) (optional) 

            try
            {
                List&lt;UserSessionRepresentation&gt; result = apiInstance.GetClientUserSessions(realm, id, first, max);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ClientsApi.GetClientUserSessions: " + e.Message );
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
 **first** | **string**| Paging offset | [optional] 
 **max** | **string**| Maximum results size (defaults to 100) | [optional] 

### Return type

[**List<UserSessionRepresentation>**](UserSessionRepresentation.md)

### Authorization

[access_token](../README.md#access_token)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getclients"></a>
# **GetClients**
> List<ClientRepresentation> GetClients (string realm, string clientId, string first, string max, string q, string search, string viewableOnly)



Get clients belonging to the realm.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class GetClientsExample
    {
        public void main()
        {


            var apiInstance = new ClientsApi();
            var realm = realm_example;  // string | realm name (not id!)
            var clientId = clientId_example;  // string | filter by clientId (optional) 
            var first = first_example;  // string | the first result (optional) 
            var max = max_example;  // string | the max results to return (optional) 
            var q = q_example;  // string |  (optional) 
            var search = search_example;  // string | whether this is a search query or a getClientById query (optional) 
            var viewableOnly = viewableOnly_example;  // string | filter clients that cannot be viewed in full by admin (optional) 

            try
            {
                List&lt;ClientRepresentation&gt; result = apiInstance.GetClients(realm, clientId, first, max, q, search, viewableOnly);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ClientsApi.GetClients: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **realm** | **string**| realm name (not id!) | 
 **clientId** | **string**| filter by clientId | [optional] 
 **first** | **string**| the first result | [optional] 
 **max** | **string**| the max results to return | [optional] 
 **q** | **string**|  | [optional] 
 **search** | **string**| whether this is a search query or a getClientById query | [optional] 
 **viewableOnly** | **string**| filter clients that cannot be viewed in full by admin | [optional] 

### Return type

[**List<ClientRepresentation>**](ClientRepresentation.md)

### Authorization

[access_token](../README.md#access_token)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getdefaultclientscopes"></a>
# **GetDefaultClientScopes**
> List<ClientScopeRepresentation> GetDefaultClientScopes (string realm, string id)



Get default client scopes.  Only name and ids are returned.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class GetDefaultClientScopesExample
    {
        public void main()
        {


            var apiInstance = new ClientsApi();
            var realm = realm_example;  // string | realm name (not id!)
            var id = id_example;  // string | 

            try
            {
                List&lt;ClientScopeRepresentation&gt; result = apiInstance.GetDefaultClientScopes(realm, id);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ClientsApi.GetDefaultClientScopes: " + e.Message );
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

[**List<ClientScopeRepresentation>**](ClientScopeRepresentation.md)

### Authorization

[access_token](../README.md#access_token)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getgenerateexampleaccesstoken"></a>
# **GetGenerateExampleAccessToken**
> AccessToken GetGenerateExampleAccessToken (string realm, string id, string scope, string userId)



Create JSON with payload of example access token

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class GetGenerateExampleAccessTokenExample
    {
        public void main()
        {


            var apiInstance = new ClientsApi();
            var realm = realm_example;  // string | realm name (not id!)
            var id = id_example;  // string | 
            var scope = scope_example;  // string |  (optional) 
            var userId = userId_example;  // string |  (optional) 

            try
            {
                AccessToken result = apiInstance.GetGenerateExampleAccessToken(realm, id, scope, userId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ClientsApi.GetGenerateExampleAccessToken: " + e.Message );
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
 **scope** | **string**|  | [optional] 
 **userId** | **string**|  | [optional] 

### Return type

[**AccessToken**](AccessToken.md)

### Authorization

[access_token](../README.md#access_token)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getgenerateexampleidtoken"></a>
# **GetGenerateExampleIdToken**
> IDToken GetGenerateExampleIdToken (string realm, string id, string scope, string userId)



Create JSON with payload of example id token

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class GetGenerateExampleIdTokenExample
    {
        public void main()
        {


            var apiInstance = new ClientsApi();
            var realm = realm_example;  // string | realm name (not id!)
            var id = id_example;  // string | 
            var scope = scope_example;  // string |  (optional) 
            var userId = userId_example;  // string |  (optional) 

            try
            {
                IDToken result = apiInstance.GetGenerateExampleIdToken(realm, id, scope, userId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ClientsApi.GetGenerateExampleIdToken: " + e.Message );
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
 **scope** | **string**|  | [optional] 
 **userId** | **string**|  | [optional] 

### Return type

[**IDToken**](IDToken.md)

### Authorization

[access_token](../README.md#access_token)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getgenerateexampleuserinfo"></a>
# **GetGenerateExampleUserinfo**
> Dictionary<string, Object> GetGenerateExampleUserinfo (string realm, string id, string scope, string userId)



Create JSON with payload of example user info

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class GetGenerateExampleUserinfoExample
    {
        public void main()
        {


            var apiInstance = new ClientsApi();
            var realm = realm_example;  // string | realm name (not id!)
            var id = id_example;  // string | 
            var scope = scope_example;  // string |  (optional) 
            var userId = userId_example;  // string |  (optional) 

            try
            {
                Dictionary&lt;string, Object&gt; result = apiInstance.GetGenerateExampleUserinfo(realm, id, scope, userId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ClientsApi.GetGenerateExampleUserinfo: " + e.Message );
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
 **scope** | **string**|  | [optional] 
 **userId** | **string**|  | [optional] 

### Return type

**Dictionary<string, Object>**

### Authorization

[access_token](../README.md#access_token)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getgranted"></a>
# **GetGranted**
> List<RoleRepresentation> GetGranted (string realm, string id, string roleContainerId, string scope)



Get effective scope mapping of all roles of particular role container, which this client is defacto allowed to have in the accessToken issued for him.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class GetGrantedExample
    {
        public void main()
        {


            var apiInstance = new ClientsApi();
            var realm = realm_example;  // string | realm name (not id!)
            var id = id_example;  // string | 
            var roleContainerId = roleContainerId_example;  // string | either realm name OR client UUID
            var scope = scope_example;  // string |  (optional) 

            try
            {
                List&lt;RoleRepresentation&gt; result = apiInstance.GetGranted(realm, id, roleContainerId, scope);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ClientsApi.GetGranted: " + e.Message );
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
 **roleContainerId** | **string**| either realm name OR client UUID | 
 **scope** | **string**|  | [optional] 

### Return type

[**List<RoleRepresentation>**](RoleRepresentation.md)

### Authorization

[access_token](../README.md#access_token)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getinstallationprovider"></a>
# **GetInstallationProvider**
> void GetInstallationProvider (string realm, string id, string providerId)



### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class GetInstallationProviderExample
    {
        public void main()
        {


            var apiInstance = new ClientsApi();
            var realm = realm_example;  // string | realm name (not id!)
            var id = id_example;  // string | 
            var providerId = providerId_example;  // string | 

            try
            {
                apiInstance.GetInstallationProvider(realm, id, providerId);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ClientsApi.GetInstallationProvider: " + e.Message );
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
 **providerId** | **string**|  | 

### Return type

void (empty response body)

### Authorization

[access_token](../README.md#access_token)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getnotgranted"></a>
# **GetNotGranted**
> List<RoleRepresentation> GetNotGranted (string realm, string id, string roleContainerId, string scope)



Get roles, which this client doesn’t have scope for and can’t have them in the accessToken issued for him.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class GetNotGrantedExample
    {
        public void main()
        {


            var apiInstance = new ClientsApi();
            var realm = realm_example;  // string | realm name (not id!)
            var id = id_example;  // string | 
            var roleContainerId = roleContainerId_example;  // string | either realm name OR client UUID
            var scope = scope_example;  // string |  (optional) 

            try
            {
                List&lt;RoleRepresentation&gt; result = apiInstance.GetNotGranted(realm, id, roleContainerId, scope);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ClientsApi.GetNotGranted: " + e.Message );
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
 **roleContainerId** | **string**| either realm name OR client UUID | 
 **scope** | **string**|  | [optional] 

### Return type

[**List<RoleRepresentation>**](RoleRepresentation.md)

### Authorization

[access_token](../README.md#access_token)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getofflinesessioncount"></a>
# **GetOfflineSessionCount**
> Dictionary<string, long?> GetOfflineSessionCount (string realm, string id)



Get application offline session count Returns a number of offline user sessions associated with this client { \\\"count\\\": number }

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class GetOfflineSessionCountExample
    {
        public void main()
        {


            var apiInstance = new ClientsApi();
            var realm = realm_example;  // string | realm name (not id!)
            var id = id_example;  // string | 

            try
            {
                Dictionary&lt;string, long?&gt; result = apiInstance.GetOfflineSessionCount(realm, id);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ClientsApi.GetOfflineSessionCount: " + e.Message );
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

**Dictionary<string, long?>**

### Authorization

[access_token](../README.md#access_token)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getofflinesessions"></a>
# **GetOfflineSessions**
> List<UserSessionRepresentation> GetOfflineSessions (string realm, string id, string first, string max)



Get offline sessions for client Returns a list of offline user sessions associated with this client

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class GetOfflineSessionsExample
    {
        public void main()
        {


            var apiInstance = new ClientsApi();
            var realm = realm_example;  // string | realm name (not id!)
            var id = id_example;  // string | 
            var first = first_example;  // string | Paging offset (optional) 
            var max = max_example;  // string | Maximum results size (defaults to 100) (optional) 

            try
            {
                List&lt;UserSessionRepresentation&gt; result = apiInstance.GetOfflineSessions(realm, id, first, max);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ClientsApi.GetOfflineSessions: " + e.Message );
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
 **first** | **string**| Paging offset | [optional] 
 **max** | **string**| Maximum results size (defaults to 100) | [optional] 

### Return type

[**List<UserSessionRepresentation>**](UserSessionRepresentation.md)

### Authorization

[access_token](../README.md#access_token)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getoptionalclientscopes"></a>
# **GetOptionalClientScopes**
> List<ClientScopeRepresentation> GetOptionalClientScopes (string realm, string id)



Get optional client scopes.  Only name and ids are returned.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class GetOptionalClientScopesExample
    {
        public void main()
        {


            var apiInstance = new ClientsApi();
            var realm = realm_example;  // string | realm name (not id!)
            var id = id_example;  // string | 

            try
            {
                List&lt;ClientScopeRepresentation&gt; result = apiInstance.GetOptionalClientScopes(realm, id);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ClientsApi.GetOptionalClientScopes: " + e.Message );
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

[**List<ClientScopeRepresentation>**](ClientScopeRepresentation.md)

### Authorization

[access_token](../README.md#access_token)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getprotocolmappers"></a>
# **GetProtocolMappers**
> List<ProtocolMapperEvaluationRepresentation> GetProtocolMappers (string realm, string id, string scope)



Return list of all protocol mappers, which will be used when generating tokens issued for particular client.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class GetProtocolMappersExample
    {
        public void main()
        {


            var apiInstance = new ClientsApi();
            var realm = realm_example;  // string | realm name (not id!)
            var id = id_example;  // string | 
            var scope = scope_example;  // string |  (optional) 

            try
            {
                List&lt;ProtocolMapperEvaluationRepresentation&gt; result = apiInstance.GetProtocolMappers(realm, id, scope);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ClientsApi.GetProtocolMappers: " + e.Message );
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
 **scope** | **string**|  | [optional] 

### Return type

[**List<ProtocolMapperEvaluationRepresentation>**](ProtocolMapperEvaluationRepresentation.md)

### Authorization

[access_token](../README.md#access_token)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getrotated"></a>
# **GetRotated**
> CredentialRepresentation GetRotated (string realm, string id)



Get the rotated client secret

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class GetRotatedExample
    {
        public void main()
        {


            var apiInstance = new ClientsApi();
            var realm = realm_example;  // string | realm name (not id!)
            var id = id_example;  // string | 

            try
            {
                CredentialRepresentation result = apiInstance.GetRotated(realm, id);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ClientsApi.GetRotated: " + e.Message );
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

[**CredentialRepresentation**](CredentialRepresentation.md)

### Authorization

[access_token](../README.md#access_token)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getserviceaccountuser"></a>
# **GetServiceAccountUser**
> UserRepresentation GetServiceAccountUser (string realm, string id)



Get a user dedicated to the service account

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class GetServiceAccountUserExample
    {
        public void main()
        {


            var apiInstance = new ClientsApi();
            var realm = realm_example;  // string | realm name (not id!)
            var id = id_example;  // string | 

            try
            {
                UserRepresentation result = apiInstance.GetServiceAccountUser(realm, id);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ClientsApi.GetServiceAccountUser: " + e.Message );
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

[**UserRepresentation**](UserRepresentation.md)

### Authorization

[access_token](../README.md#access_token)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getsessioncount"></a>
# **GetSessionCount**
> Dictionary<string, long?> GetSessionCount (string realm, string id)



Get application session count Returns a number of user sessions associated with this client { \\\"count\\\": number }

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class GetSessionCountExample
    {
        public void main()
        {


            var apiInstance = new ClientsApi();
            var realm = realm_example;  // string | realm name (not id!)
            var id = id_example;  // string | 

            try
            {
                Dictionary&lt;string, long?&gt; result = apiInstance.GetSessionCount(realm, id);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ClientsApi.GetSessionCount: " + e.Message );
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

**Dictionary<string, long?>**

### Authorization

[access_token](../README.md#access_token)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="gettestnodesavailable"></a>
# **GetTestNodesAvailable**
> GlobalRequestResult GetTestNodesAvailable (string realm, string id)



Test if registered cluster nodes are available Tests availability by sending 'ping' request to all cluster nodes.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class GetTestNodesAvailableExample
    {
        public void main()
        {


            var apiInstance = new ClientsApi();
            var realm = realm_example;  // string | realm name (not id!)
            var id = id_example;  // string | 

            try
            {
                GlobalRequestResult result = apiInstance.GetTestNodesAvailable(realm, id);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ClientsApi.GetTestNodesAvailable: " + e.Message );
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

[**GlobalRequestResult**](GlobalRequestResult.md)

### Authorization

[access_token](../README.md#access_token)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="postclientpushrevocation"></a>
# **PostClientPushRevocation**
> GlobalRequestResult PostClientPushRevocation (string realm, string id)



Push the client’s revocation policy to its admin URL If the client has an admin URL, push revocation policy to it.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class PostClientPushRevocationExample
    {
        public void main()
        {


            var apiInstance = new ClientsApi();
            var realm = realm_example;  // string | realm name (not id!)
            var id = id_example;  // string | 

            try
            {
                GlobalRequestResult result = apiInstance.PostClientPushRevocation(realm, id);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ClientsApi.PostClientPushRevocation: " + e.Message );
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

[**GlobalRequestResult**](GlobalRequestResult.md)

### Authorization

[access_token](../README.md#access_token)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="postclientsecret"></a>
# **PostClientSecret**
> CredentialRepresentation PostClientSecret (string realm, string id)



Generate a new secret for the client

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class PostClientSecretExample
    {
        public void main()
        {


            var apiInstance = new ClientsApi();
            var realm = realm_example;  // string | realm name (not id!)
            var id = id_example;  // string | 

            try
            {
                CredentialRepresentation result = apiInstance.PostClientSecret(realm, id);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ClientsApi.PostClientSecret: " + e.Message );
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

[**CredentialRepresentation**](CredentialRepresentation.md)

### Authorization

[access_token](../README.md#access_token)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="postclients"></a>
# **PostClients**
> void PostClients (string realm, ClientRepresentation body)



Create a new client Client’s client_id must be unique!

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class PostClientsExample
    {
        public void main()
        {


            var apiInstance = new ClientsApi();
            var realm = realm_example;  // string | realm name (not id!)
            var body = new ClientRepresentation(); // ClientRepresentation | ClientRepresentation (optional) 

            try
            {
                apiInstance.PostClients(realm, body);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ClientsApi.PostClients: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **realm** | **string**| realm name (not id!) | 
 **body** | [**ClientRepresentation**](ClientRepresentation.md)| ClientRepresentation | [optional] 

### Return type

void (empty response body)

### Authorization

[access_token](../README.md#access_token)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="postnodes"></a>
# **PostNodes**
> void PostNodes (string realm, string id, string body)



Register a cluster node with the client Manually register cluster node to this client - usually it’s not needed to call this directly as adapter should handle by sending registration request to Keycloak

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class PostNodesExample
    {
        public void main()
        {


            var apiInstance = new ClientsApi();
            var realm = realm_example;  // string | realm name (not id!)
            var id = id_example;  // string | 
            var body = new string(); // string | [string] (optional) 

            try
            {
                apiInstance.PostNodes(realm, id, body);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ClientsApi.PostNodes: " + e.Message );
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
 **body** | [**string**](string.md)| [string] | [optional] 

### Return type

void (empty response body)

### Authorization

[access_token](../README.md#access_token)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="postregistrationaccesstoken"></a>
# **PostRegistrationAccessToken**
> ClientRepresentation PostRegistrationAccessToken (string realm, string id)



Generate a new registration access token for the client

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class PostRegistrationAccessTokenExample
    {
        public void main()
        {


            var apiInstance = new ClientsApi();
            var realm = realm_example;  // string | realm name (not id!)
            var id = id_example;  // string | 

            try
            {
                ClientRepresentation result = apiInstance.PostRegistrationAccessToken(realm, id);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ClientsApi.PostRegistrationAccessToken: " + e.Message );
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

[**ClientRepresentation**](ClientRepresentation.md)

### Authorization

[access_token](../README.md#access_token)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="putclient"></a>
# **PutClient**
> void PutClient (string realm, string id, ClientRepresentation body)



Update the client

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class PutClientExample
    {
        public void main()
        {


            var apiInstance = new ClientsApi();
            var realm = realm_example;  // string | realm name (not id!)
            var id = id_example;  // string | 
            var body = new ClientRepresentation(); // ClientRepresentation | ClientRepresentation (optional) 

            try
            {
                apiInstance.PutClient(realm, id, body);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ClientsApi.PutClient: " + e.Message );
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
 **body** | [**ClientRepresentation**](ClientRepresentation.md)| ClientRepresentation | [optional] 

### Return type

void (empty response body)

### Authorization

[access_token](../README.md#access_token)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="putclientmanagementpermissions"></a>
# **PutClientManagementPermissions**
> ManagementPermissionReference PutClientManagementPermissions (string realm, string id, ManagementPermissionReference body)



Return object stating whether client Authorization permissions have been initialized or not and a reference

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class PutClientManagementPermissionsExample
    {
        public void main()
        {


            var apiInstance = new ClientsApi();
            var realm = realm_example;  // string | realm name (not id!)
            var id = id_example;  // string | 
            var body = new ManagementPermissionReference(); // ManagementPermissionReference | ManagementPermissionReference (optional) 

            try
            {
                ManagementPermissionReference result = apiInstance.PutClientManagementPermissions(realm, id, body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ClientsApi.PutClientManagementPermissions: " + e.Message );
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

### Return type

[**ManagementPermissionReference**](ManagementPermissionReference.md)

### Authorization

[access_token](../README.md#access_token)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="putdefaultclientscope"></a>
# **PutDefaultClientScope**
> void PutDefaultClientScope (string realm, string id, string clientScopeId)



### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class PutDefaultClientScopeExample
    {
        public void main()
        {


            var apiInstance = new ClientsApi();
            var realm = realm_example;  // string | realm name (not id!)
            var id = id_example;  // string | 
            var clientScopeId = clientScopeId_example;  // string | 

            try
            {
                apiInstance.PutDefaultClientScope(realm, id, clientScopeId);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ClientsApi.PutDefaultClientScope: " + e.Message );
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
 **clientScopeId** | **string**|  | 

### Return type

void (empty response body)

### Authorization

[access_token](../README.md#access_token)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="putoptionalclientscope"></a>
# **PutOptionalClientScope**
> void PutOptionalClientScope (string realm, string id, string clientScopeId)



### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class PutOptionalClientScopeExample
    {
        public void main()
        {


            var apiInstance = new ClientsApi();
            var realm = realm_example;  // string | realm name (not id!)
            var id = id_example;  // string | 
            var clientScopeId = clientScopeId_example;  // string | 

            try
            {
                apiInstance.PutOptionalClientScope(realm, id, clientScopeId);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ClientsApi.PutOptionalClientScope: " + e.Message );
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
 **clientScopeId** | **string**|  | 

### Return type

void (empty response body)

### Authorization

[access_token](../README.md#access_token)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

