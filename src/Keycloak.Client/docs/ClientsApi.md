# .ClientsApi

All URIs are relative to *https://keycloak.example.com/admin/realms*

Method | HTTP request | Description
------------- | ------------- | -------------
[**DeleteClientByRealmById**](ClientsApi.md#deleteclientbyrealmbyid) | **Delete** /{realm}/clients/{id} | 
[**DeleteDefaultClientScope**](ClientsApi.md#deletedefaultclientscope) | **Delete** /{realm}/clients/{id}/default-client-scopes/{clientScopeId} | 
[**DeleteNode**](ClientsApi.md#deletenode) | **Delete** /{realm}/clients/{id}/nodes/{node} | 
[**DeleteOptionalClientScope**](ClientsApi.md#deleteoptionalclientscope) | **Delete** /{realm}/clients/{id}/optional-client-scopes/{clientScopeId} | 
[**DeleteRotated**](ClientsApi.md#deleterotated) | **Delete** /{realm}/clients/{id}/client-secret/rotated | 
[**GetClientByRealmById**](ClientsApi.md#getclientbyrealmbyid) | **Get** /{realm}/clients/{id} | 
[**GetClientManagementPermissions**](ClientsApi.md#getclientmanagementpermissions) | **Get** /{realm}/clients/{id}/management/permissions | 
[**GetClientSecret**](ClientsApi.md#getclientsecret) | **Get** /{realm}/clients/{id}/client-secret | 
[**GetClientUserSessions**](ClientsApi.md#getclientusersessions) | **Get** /{realm}/clients/{id}/user-sessions | 
[**GetClients**](ClientsApi.md#getclients) | **Get** /{realm}/clients | 
[**GetDefaultClientScopes**](ClientsApi.md#getdefaultclientscopes) | **Get** /{realm}/clients/{id}/default-client-scopes | 
[**GetGenerateExampleAccessToken**](ClientsApi.md#getgenerateexampleaccesstoken) | **Get** /{realm}/clients/{id}/evaluate-scopes/generate-example-access-token | 
[**GetGenerateExampleIdToken**](ClientsApi.md#getgenerateexampleidtoken) | **Get** /{realm}/clients/{id}/evaluate-scopes/generate-example-id-token | 
[**GetGenerateExampleUserinfo**](ClientsApi.md#getgenerateexampleuserinfo) | **Get** /{realm}/clients/{id}/evaluate-scopes/generate-example-userinfo | 
[**GetGranted**](ClientsApi.md#getgranted) | **Get** /{realm}/clients/{id}/evaluate-scopes/scope-mappings/{roleContainerId}/granted | 
[**GetInstallationProvider**](ClientsApi.md#getinstallationprovider) | **Get** /{realm}/clients/{id}/installation/providers/{providerId} | 
[**GetNotGranted**](ClientsApi.md#getnotgranted) | **Get** /{realm}/clients/{id}/evaluate-scopes/scope-mappings/{roleContainerId}/not-granted | 
[**GetOfflineSessionCount**](ClientsApi.md#getofflinesessioncount) | **Get** /{realm}/clients/{id}/offline-session-count | 
[**GetOfflineSessions**](ClientsApi.md#getofflinesessions) | **Get** /{realm}/clients/{id}/offline-sessions | 
[**GetOptionalClientScopes**](ClientsApi.md#getoptionalclientscopes) | **Get** /{realm}/clients/{id}/optional-client-scopes | 
[**GetProtocolMappers**](ClientsApi.md#getprotocolmappers) | **Get** /{realm}/clients/{id}/evaluate-scopes/protocol-mappers | 
[**GetRotated**](ClientsApi.md#getrotated) | **Get** /{realm}/clients/{id}/client-secret/rotated | 
[**GetServiceAccountUser**](ClientsApi.md#getserviceaccountuser) | **Get** /{realm}/clients/{id}/service-account-user | 
[**GetSessionCount**](ClientsApi.md#getsessioncount) | **Get** /{realm}/clients/{id}/session-count | 
[**GetTestNodesAvailable**](ClientsApi.md#gettestnodesavailable) | **Get** /{realm}/clients/{id}/test-nodes-available | 
[**PostClientPushRevocation**](ClientsApi.md#postclientpushrevocation) | **Post** /{realm}/clients/{id}/push-revocation | 
[**PostClientSecret**](ClientsApi.md#postclientsecret) | **Post** /{realm}/clients/{id}/client-secret | 
[**PostClients**](ClientsApi.md#postclients) | **Post** /{realm}/clients | 
[**PostNodes**](ClientsApi.md#postnodes) | **Post** /{realm}/clients/{id}/nodes | 
[**PostRegistrationAccessToken**](ClientsApi.md#postregistrationaccesstoken) | **Post** /{realm}/clients/{id}/registration-access-token | 
[**PutClient**](ClientsApi.md#putclient) | **Put** /{realm}/clients/{id} | 
[**PutClientManagementPermissions**](ClientsApi.md#putclientmanagementpermissions) | **Put** /{realm}/clients/{id}/management/permissions | 
[**PutDefaultClientScope**](ClientsApi.md#putdefaultclientscope) | **Put** /{realm}/clients/{id}/default-client-scopes/{clientScopeId} | 
[**PutOptionalClientScope**](ClientsApi.md#putoptionalclientscope) | **Put** /{realm}/clients/{id}/optional-client-scopes/{clientScopeId} | 


<a name="deleteclientbyrealmbyid"></a>
# **DeleteClientByRealmById**
> void DeleteClientByRealmById (string realm, string id, CancellationToken ct)



Delete the client

### Example
```csharp
using System;
using System.Diagnostics;
using ;
using PetShop;
using PetShop.Models;

namespace Example
{
    public class DeleteClientByRealmByIdExample
    {
        public void main()
        {
            

            var apiInstance = new ClientsApi();
            var realm = realm_example;  // string | realm name (not id!)
            var id = id_example;  // string | 
            var ct = new CancellationToken(); // CancellationToken |  (optional) 

            try
            {
                apiInstance.DeleteClientByRealmById(realm, id, ct);
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
 **ct** | [**CancellationToken**](.md)|  | [optional] 

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
> void DeleteDefaultClientScope (string realm, string id, string clientScopeId, CancellationToken ct)



### Example
```csharp
using System;
using System.Diagnostics;
using ;
using PetShop;
using PetShop.Models;

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
            var ct = new CancellationToken(); // CancellationToken |  (optional) 

            try
            {
                apiInstance.DeleteDefaultClientScope(realm, id, clientScopeId, ct);
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
 **ct** | [**CancellationToken**](.md)|  | [optional] 

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
> void DeleteNode (string realm, string id, string node, CancellationToken ct)



Unregister a cluster node from the client

### Example
```csharp
using System;
using System.Diagnostics;
using ;
using PetShop;
using PetShop.Models;

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
            var ct = new CancellationToken(); // CancellationToken |  (optional) 

            try
            {
                apiInstance.DeleteNode(realm, id, node, ct);
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
 **ct** | [**CancellationToken**](.md)|  | [optional] 

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
> void DeleteOptionalClientScope (string realm, string id, string clientScopeId, CancellationToken ct)



### Example
```csharp
using System;
using System.Diagnostics;
using ;
using PetShop;
using PetShop.Models;

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
            var ct = new CancellationToken(); // CancellationToken |  (optional) 

            try
            {
                apiInstance.DeleteOptionalClientScope(realm, id, clientScopeId, ct);
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
 **ct** | [**CancellationToken**](.md)|  | [optional] 

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
> void DeleteRotated (string realm, string id, CancellationToken ct)



Invalidate the rotated secret for the client

### Example
```csharp
using System;
using System.Diagnostics;
using ;
using PetShop;
using PetShop.Models;

namespace Example
{
    public class DeleteRotatedExample
    {
        public void main()
        {
            

            var apiInstance = new ClientsApi();
            var realm = realm_example;  // string | realm name (not id!)
            var id = id_example;  // string | 
            var ct = new CancellationToken(); // CancellationToken |  (optional) 

            try
            {
                apiInstance.DeleteRotated(realm, id, ct);
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
 **ct** | [**CancellationToken**](.md)|  | [optional] 

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
> ClientRepresentation GetClientByRealmById (string realm, string id, CancellationToken ct)



Get representation of the client

### Example
```csharp
using System;
using System.Diagnostics;
using ;
using PetShop;
using PetShop.Models;

namespace Example
{
    public class GetClientByRealmByIdExample
    {
        public void main()
        {
            

            var apiInstance = new ClientsApi();
            var realm = realm_example;  // string | realm name (not id!)
            var id = id_example;  // string | 
            var ct = new CancellationToken(); // CancellationToken |  (optional) 

            try
            {
                ClientRepresentation result = apiInstance.GetClientByRealmById(realm, id, ct);
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
 **ct** | [**CancellationToken**](.md)|  | [optional] 

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
> ManagementPermissionReference GetClientManagementPermissions (string realm, string id, CancellationToken ct)



Return object stating whether client Authorization permissions have been initialized or not and a reference

### Example
```csharp
using System;
using System.Diagnostics;
using ;
using PetShop;
using PetShop.Models;

namespace Example
{
    public class GetClientManagementPermissionsExample
    {
        public void main()
        {
            

            var apiInstance = new ClientsApi();
            var realm = realm_example;  // string | realm name (not id!)
            var id = id_example;  // string | 
            var ct = new CancellationToken(); // CancellationToken |  (optional) 

            try
            {
                ManagementPermissionReference result = apiInstance.GetClientManagementPermissions(realm, id, ct);
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
 **ct** | [**CancellationToken**](.md)|  | [optional] 

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
> CredentialRepresentation GetClientSecret (string realm, string id, CancellationToken ct)



Get the client secret

### Example
```csharp
using System;
using System.Diagnostics;
using ;
using PetShop;
using PetShop.Models;

namespace Example
{
    public class GetClientSecretExample
    {
        public void main()
        {
            

            var apiInstance = new ClientsApi();
            var realm = realm_example;  // string | realm name (not id!)
            var id = id_example;  // string | 
            var ct = new CancellationToken(); // CancellationToken |  (optional) 

            try
            {
                CredentialRepresentation result = apiInstance.GetClientSecret(realm, id, ct);
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
 **ct** | [**CancellationToken**](.md)|  | [optional] 

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
> List<UserSessionRepresentation> GetClientUserSessions (string realm, string id, string first, string max, CancellationToken ct)



Get user sessions for client Returns a list of user sessions associated with this client

### Example
```csharp
using System;
using System.Diagnostics;
using ;
using PetShop;
using PetShop.Models;

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
            var ct = new CancellationToken(); // CancellationToken |  (optional) 

            try
            {
                List&lt;UserSessionRepresentation&gt; result = apiInstance.GetClientUserSessions(realm, id, first, max, ct);
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
 **ct** | [**CancellationToken**](.md)|  | [optional] 

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
> List<ClientRepresentation> GetClients (string realm, string clientId, string first, string max, string q, string search, string viewableOnly, CancellationToken ct)



Get clients belonging to the realm.

### Example
```csharp
using System;
using System.Diagnostics;
using ;
using PetShop;
using PetShop.Models;

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
            var ct = new CancellationToken(); // CancellationToken |  (optional) 

            try
            {
                List&lt;ClientRepresentation&gt; result = apiInstance.GetClients(realm, clientId, first, max, q, search, viewableOnly, ct);
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
 **ct** | [**CancellationToken**](.md)|  | [optional] 

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
> List<ClientScopeRepresentation> GetDefaultClientScopes (string realm, string id, CancellationToken ct)



Get default client scopes.  Only name and ids are returned.

### Example
```csharp
using System;
using System.Diagnostics;
using ;
using PetShop;
using PetShop.Models;

namespace Example
{
    public class GetDefaultClientScopesExample
    {
        public void main()
        {
            

            var apiInstance = new ClientsApi();
            var realm = realm_example;  // string | realm name (not id!)
            var id = id_example;  // string | 
            var ct = new CancellationToken(); // CancellationToken |  (optional) 

            try
            {
                List&lt;ClientScopeRepresentation&gt; result = apiInstance.GetDefaultClientScopes(realm, id, ct);
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
 **ct** | [**CancellationToken**](.md)|  | [optional] 

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
> AccessToken GetGenerateExampleAccessToken (string realm, string id, string scope, string userId, CancellationToken ct)



Create JSON with payload of example access token

### Example
```csharp
using System;
using System.Diagnostics;
using ;
using PetShop;
using PetShop.Models;

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
            var ct = new CancellationToken(); // CancellationToken |  (optional) 

            try
            {
                AccessToken result = apiInstance.GetGenerateExampleAccessToken(realm, id, scope, userId, ct);
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
 **ct** | [**CancellationToken**](.md)|  | [optional] 

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
> IDToken GetGenerateExampleIdToken (string realm, string id, string scope, string userId, CancellationToken ct)



Create JSON with payload of example id token

### Example
```csharp
using System;
using System.Diagnostics;
using ;
using PetShop;
using PetShop.Models;

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
            var ct = new CancellationToken(); // CancellationToken |  (optional) 

            try
            {
                IDToken result = apiInstance.GetGenerateExampleIdToken(realm, id, scope, userId, ct);
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
 **ct** | [**CancellationToken**](.md)|  | [optional] 

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
> Dictionary<string, Object> GetGenerateExampleUserinfo (string realm, string id, string scope, string userId, CancellationToken ct)



Create JSON with payload of example user info

### Example
```csharp
using System;
using System.Diagnostics;
using ;
using PetShop;
using PetShop.Models;

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
            var ct = new CancellationToken(); // CancellationToken |  (optional) 

            try
            {
                Dictionary&lt;string, Object&gt; result = apiInstance.GetGenerateExampleUserinfo(realm, id, scope, userId, ct);
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
 **ct** | [**CancellationToken**](.md)|  | [optional] 

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
> List<RoleRepresentation> GetGranted (string realm, string id, string roleContainerId, string scope, CancellationToken ct)



Get effective scope mapping of all roles of particular role container, which this client is defacto allowed to have in the accessToken issued for him.

### Example
```csharp
using System;
using System.Diagnostics;
using ;
using PetShop;
using PetShop.Models;

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
            var ct = new CancellationToken(); // CancellationToken |  (optional) 

            try
            {
                List&lt;RoleRepresentation&gt; result = apiInstance.GetGranted(realm, id, roleContainerId, scope, ct);
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
 **ct** | [**CancellationToken**](.md)|  | [optional] 

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
> void GetInstallationProvider (string realm, string id, string providerId, CancellationToken ct)



### Example
```csharp
using System;
using System.Diagnostics;
using ;
using PetShop;
using PetShop.Models;

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
            var ct = new CancellationToken(); // CancellationToken |  (optional) 

            try
            {
                apiInstance.GetInstallationProvider(realm, id, providerId, ct);
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
 **ct** | [**CancellationToken**](.md)|  | [optional] 

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
> List<RoleRepresentation> GetNotGranted (string realm, string id, string roleContainerId, string scope, CancellationToken ct)



Get roles, which this client doesn’t have scope for and can’t have them in the accessToken issued for him.

### Example
```csharp
using System;
using System.Diagnostics;
using ;
using PetShop;
using PetShop.Models;

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
            var ct = new CancellationToken(); // CancellationToken |  (optional) 

            try
            {
                List&lt;RoleRepresentation&gt; result = apiInstance.GetNotGranted(realm, id, roleContainerId, scope, ct);
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
 **ct** | [**CancellationToken**](.md)|  | [optional] 

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
> Dictionary<string, long?> GetOfflineSessionCount (string realm, string id, CancellationToken ct)



Get application offline session count Returns a number of offline user sessions associated with this client { \\\"count\\\": number }

### Example
```csharp
using System;
using System.Diagnostics;
using ;
using PetShop;
using PetShop.Models;

namespace Example
{
    public class GetOfflineSessionCountExample
    {
        public void main()
        {
            

            var apiInstance = new ClientsApi();
            var realm = realm_example;  // string | realm name (not id!)
            var id = id_example;  // string | 
            var ct = new CancellationToken(); // CancellationToken |  (optional) 

            try
            {
                Dictionary&lt;string, long?&gt; result = apiInstance.GetOfflineSessionCount(realm, id, ct);
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
 **ct** | [**CancellationToken**](.md)|  | [optional] 

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
> List<UserSessionRepresentation> GetOfflineSessions (string realm, string id, string first, string max, CancellationToken ct)



Get offline sessions for client Returns a list of offline user sessions associated with this client

### Example
```csharp
using System;
using System.Diagnostics;
using ;
using PetShop;
using PetShop.Models;

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
            var ct = new CancellationToken(); // CancellationToken |  (optional) 

            try
            {
                List&lt;UserSessionRepresentation&gt; result = apiInstance.GetOfflineSessions(realm, id, first, max, ct);
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
 **ct** | [**CancellationToken**](.md)|  | [optional] 

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
> List<ClientScopeRepresentation> GetOptionalClientScopes (string realm, string id, CancellationToken ct)



Get optional client scopes.  Only name and ids are returned.

### Example
```csharp
using System;
using System.Diagnostics;
using ;
using PetShop;
using PetShop.Models;

namespace Example
{
    public class GetOptionalClientScopesExample
    {
        public void main()
        {
            

            var apiInstance = new ClientsApi();
            var realm = realm_example;  // string | realm name (not id!)
            var id = id_example;  // string | 
            var ct = new CancellationToken(); // CancellationToken |  (optional) 

            try
            {
                List&lt;ClientScopeRepresentation&gt; result = apiInstance.GetOptionalClientScopes(realm, id, ct);
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
 **ct** | [**CancellationToken**](.md)|  | [optional] 

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
> List<ProtocolMapperEvaluationRepresentation> GetProtocolMappers (string realm, string id, string scope, CancellationToken ct)



Return list of all protocol mappers, which will be used when generating tokens issued for particular client.

### Example
```csharp
using System;
using System.Diagnostics;
using ;
using PetShop;
using PetShop.Models;

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
            var ct = new CancellationToken(); // CancellationToken |  (optional) 

            try
            {
                List&lt;ProtocolMapperEvaluationRepresentation&gt; result = apiInstance.GetProtocolMappers(realm, id, scope, ct);
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
 **ct** | [**CancellationToken**](.md)|  | [optional] 

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
> CredentialRepresentation GetRotated (string realm, string id, CancellationToken ct)



Get the rotated client secret

### Example
```csharp
using System;
using System.Diagnostics;
using ;
using PetShop;
using PetShop.Models;

namespace Example
{
    public class GetRotatedExample
    {
        public void main()
        {
            

            var apiInstance = new ClientsApi();
            var realm = realm_example;  // string | realm name (not id!)
            var id = id_example;  // string | 
            var ct = new CancellationToken(); // CancellationToken |  (optional) 

            try
            {
                CredentialRepresentation result = apiInstance.GetRotated(realm, id, ct);
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
 **ct** | [**CancellationToken**](.md)|  | [optional] 

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
> UserRepresentation GetServiceAccountUser (string realm, string id, CancellationToken ct)



Get a user dedicated to the service account

### Example
```csharp
using System;
using System.Diagnostics;
using ;
using PetShop;
using PetShop.Models;

namespace Example
{
    public class GetServiceAccountUserExample
    {
        public void main()
        {
            

            var apiInstance = new ClientsApi();
            var realm = realm_example;  // string | realm name (not id!)
            var id = id_example;  // string | 
            var ct = new CancellationToken(); // CancellationToken |  (optional) 

            try
            {
                UserRepresentation result = apiInstance.GetServiceAccountUser(realm, id, ct);
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
 **ct** | [**CancellationToken**](.md)|  | [optional] 

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
> Dictionary<string, long?> GetSessionCount (string realm, string id, CancellationToken ct)



Get application session count Returns a number of user sessions associated with this client { \\\"count\\\": number }

### Example
```csharp
using System;
using System.Diagnostics;
using ;
using PetShop;
using PetShop.Models;

namespace Example
{
    public class GetSessionCountExample
    {
        public void main()
        {
            

            var apiInstance = new ClientsApi();
            var realm = realm_example;  // string | realm name (not id!)
            var id = id_example;  // string | 
            var ct = new CancellationToken(); // CancellationToken |  (optional) 

            try
            {
                Dictionary&lt;string, long?&gt; result = apiInstance.GetSessionCount(realm, id, ct);
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
 **ct** | [**CancellationToken**](.md)|  | [optional] 

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
> GlobalRequestResult GetTestNodesAvailable (string realm, string id, CancellationToken ct)



Test if registered cluster nodes are available Tests availability by sending 'ping' request to all cluster nodes.

### Example
```csharp
using System;
using System.Diagnostics;
using ;
using PetShop;
using PetShop.Models;

namespace Example
{
    public class GetTestNodesAvailableExample
    {
        public void main()
        {
            

            var apiInstance = new ClientsApi();
            var realm = realm_example;  // string | realm name (not id!)
            var id = id_example;  // string | 
            var ct = new CancellationToken(); // CancellationToken |  (optional) 

            try
            {
                GlobalRequestResult result = apiInstance.GetTestNodesAvailable(realm, id, ct);
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
 **ct** | [**CancellationToken**](.md)|  | [optional] 

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
> GlobalRequestResult PostClientPushRevocation (string realm, string id, CancellationToken ct)



Push the client’s revocation policy to its admin URL If the client has an admin URL, push revocation policy to it.

### Example
```csharp
using System;
using System.Diagnostics;
using ;
using PetShop;
using PetShop.Models;

namespace Example
{
    public class PostClientPushRevocationExample
    {
        public void main()
        {
            

            var apiInstance = new ClientsApi();
            var realm = realm_example;  // string | realm name (not id!)
            var id = id_example;  // string | 
            var ct = new CancellationToken(); // CancellationToken |  (optional) 

            try
            {
                GlobalRequestResult result = apiInstance.PostClientPushRevocation(realm, id, ct);
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
 **ct** | [**CancellationToken**](.md)|  | [optional] 

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
> CredentialRepresentation PostClientSecret (string realm, string id, CancellationToken ct)



Generate a new secret for the client

### Example
```csharp
using System;
using System.Diagnostics;
using ;
using PetShop;
using PetShop.Models;

namespace Example
{
    public class PostClientSecretExample
    {
        public void main()
        {
            

            var apiInstance = new ClientsApi();
            var realm = realm_example;  // string | realm name (not id!)
            var id = id_example;  // string | 
            var ct = new CancellationToken(); // CancellationToken |  (optional) 

            try
            {
                CredentialRepresentation result = apiInstance.PostClientSecret(realm, id, ct);
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
 **ct** | [**CancellationToken**](.md)|  | [optional] 

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
> void PostClients (string realm, ClientRepresentation body, CancellationToken ct)



Create a new client Client’s client_id must be unique!

### Example
```csharp
using System;
using System.Diagnostics;
using ;
using PetShop;
using PetShop.Models;

namespace Example
{
    public class PostClientsExample
    {
        public void main()
        {
            

            var apiInstance = new ClientsApi();
            var realm = realm_example;  // string | realm name (not id!)
            var body = new ClientRepresentation(); // ClientRepresentation | ClientRepresentation (optional) 
            var ct = new CancellationToken(); // CancellationToken |  (optional) 

            try
            {
                apiInstance.PostClients(realm, body, ct);
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
 **ct** | [**CancellationToken**](.md)|  | [optional] 

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
> void PostNodes (string realm, string id, string body, CancellationToken ct)



Register a cluster node with the client Manually register cluster node to this client - usually it’s not needed to call this directly as adapter should handle by sending registration request to Keycloak

### Example
```csharp
using System;
using System.Diagnostics;
using ;
using PetShop;
using PetShop.Models;

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
            var ct = new CancellationToken(); // CancellationToken |  (optional) 

            try
            {
                apiInstance.PostNodes(realm, id, body, ct);
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
 **ct** | [**CancellationToken**](.md)|  | [optional] 

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
> ClientRepresentation PostRegistrationAccessToken (string realm, string id, CancellationToken ct)



Generate a new registration access token for the client

### Example
```csharp
using System;
using System.Diagnostics;
using ;
using PetShop;
using PetShop.Models;

namespace Example
{
    public class PostRegistrationAccessTokenExample
    {
        public void main()
        {
            

            var apiInstance = new ClientsApi();
            var realm = realm_example;  // string | realm name (not id!)
            var id = id_example;  // string | 
            var ct = new CancellationToken(); // CancellationToken |  (optional) 

            try
            {
                ClientRepresentation result = apiInstance.PostRegistrationAccessToken(realm, id, ct);
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
 **ct** | [**CancellationToken**](.md)|  | [optional] 

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
> void PutClient (string realm, string id, ClientRepresentation body, CancellationToken ct)



Update the client

### Example
```csharp
using System;
using System.Diagnostics;
using ;
using PetShop;
using PetShop.Models;

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
            var ct = new CancellationToken(); // CancellationToken |  (optional) 

            try
            {
                apiInstance.PutClient(realm, id, body, ct);
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
 **ct** | [**CancellationToken**](.md)|  | [optional] 

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
> ManagementPermissionReference PutClientManagementPermissions (string realm, string id, ManagementPermissionReference body, CancellationToken ct)



Return object stating whether client Authorization permissions have been initialized or not and a reference

### Example
```csharp
using System;
using System.Diagnostics;
using ;
using PetShop;
using PetShop.Models;

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
            var ct = new CancellationToken(); // CancellationToken |  (optional) 

            try
            {
                ManagementPermissionReference result = apiInstance.PutClientManagementPermissions(realm, id, body, ct);
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
 **ct** | [**CancellationToken**](.md)|  | [optional] 

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
> void PutDefaultClientScope (string realm, string id, string clientScopeId, CancellationToken ct)



### Example
```csharp
using System;
using System.Diagnostics;
using ;
using PetShop;
using PetShop.Models;

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
            var ct = new CancellationToken(); // CancellationToken |  (optional) 

            try
            {
                apiInstance.PutDefaultClientScope(realm, id, clientScopeId, ct);
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
 **ct** | [**CancellationToken**](.md)|  | [optional] 

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
> void PutOptionalClientScope (string realm, string id, string clientScopeId, CancellationToken ct)



### Example
```csharp
using System;
using System.Diagnostics;
using ;
using PetShop;
using PetShop.Models;

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
            var ct = new CancellationToken(); // CancellationToken |  (optional) 

            try
            {
                apiInstance.PutOptionalClientScope(realm, id, clientScopeId, ct);
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
 **ct** | [**CancellationToken**](.md)|  | [optional] 

### Return type

void (empty response body)

### Authorization

[access_token](../README.md#access_token)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

