# .UsersApi

All URIs are relative to *https://keycloak.example.com/admin/realms*

Method | HTTP request | Description
------------- | ------------- | -------------
[**DeleteConsent**](UsersApi.md#deleteconsent) | **Delete** /{realm}/users/{id}/consents/{client} | 
[**DeleteCredential**](UsersApi.md#deletecredential) | **Delete** /{realm}/users/{id}/credentials/{credentialId} | 
[**DeleteFederatedIdentity**](UsersApi.md#deletefederatedidentity) | **Delete** /{realm}/users/{id}/federated-identity/{provider} | 
[**DeleteUserByRealmById**](UsersApi.md#deleteuserbyrealmbyid) | **Delete** /{realm}/users/{id} | 
[**DeleteUserGroup**](UsersApi.md#deleteusergroup) | **Delete** /{realm}/users/{id}/groups/{groupId} | 
[**GetConfiguredUserStorageCredentialTypes**](UsersApi.md#getconfigureduserstoragecredentialtypes) | **Get** /{realm}/users/{id}/configured-user-storage-credential-types | 
[**GetConsents**](UsersApi.md#getconsents) | **Get** /{realm}/users/{id}/consents | 
[**GetCredentials**](UsersApi.md#getcredentials) | **Get** /{realm}/users/{id}/credentials | 
[**GetFederatedIdentity**](UsersApi.md#getfederatedidentity) | **Get** /{realm}/users/{id}/federated-identity | 
[**GetMetadata**](UsersApi.md#getmetadata) | **Get** /{realm}/users/profile/metadata | 
[**GetOfflineSession**](UsersApi.md#getofflinesession) | **Get** /{realm}/users/{id}/offline-sessions/{clientUuid} | 
[**GetProfile**](UsersApi.md#getprofile) | **Get** /{realm}/users/profile | 
[**GetSessions**](UsersApi.md#getsessions) | **Get** /{realm}/users/{id}/sessions | 
[**GetUserByRealmById**](UsersApi.md#getuserbyrealmbyid) | **Get** /{realm}/users/{id} | 
[**GetUserGroups**](UsersApi.md#getusergroups) | **Get** /{realm}/users/{id}/groups | 
[**GetUserGroupsCount**](UsersApi.md#getusergroupscount) | **Get** /{realm}/users/{id}/groups/count | 
[**GetUsersByRealm**](UsersApi.md#getusersbyrealm) | **Get** /{realm}/users | 
[**GetUsersCount**](UsersApi.md#getuserscount) | **Get** /{realm}/users/count | 
[**PostFederatedIdentity**](UsersApi.md#postfederatedidentity) | **Post** /{realm}/users/{id}/federated-identity/{provider} | 
[**PostImpersonation**](UsersApi.md#postimpersonation) | **Post** /{realm}/users/{id}/impersonation | 
[**PostLogout**](UsersApi.md#postlogout) | **Post** /{realm}/users/{id}/logout | 
[**PostMoveAfter**](UsersApi.md#postmoveafter) | **Post** /{realm}/users/{id}/credentials/{credentialId}/moveAfter/{newPreviousCredentialId} | 
[**PostMoveToFirst**](UsersApi.md#postmovetofirst) | **Post** /{realm}/users/{id}/credentials/{credentialId}/moveToFirst | 
[**PostUsers**](UsersApi.md#postusers) | **Post** /{realm}/users | 
[**PutDisableCredentialTypes**](UsersApi.md#putdisablecredentialtypes) | **Put** /{realm}/users/{id}/disable-credential-types | 
[**PutExecuteActionsEmail**](UsersApi.md#putexecuteactionsemail) | **Put** /{realm}/users/{id}/execute-actions-email | 
[**PutProfile**](UsersApi.md#putprofile) | **Put** /{realm}/users/profile | 
[**PutResetPassword**](UsersApi.md#putresetpassword) | **Put** /{realm}/users/{id}/reset-password | 
[**PutResetPasswordEmail**](UsersApi.md#putresetpasswordemail) | **Put** /{realm}/users/{id}/reset-password-email | 
[**PutSendVerifyEmail**](UsersApi.md#putsendverifyemail) | **Put** /{realm}/users/{id}/send-verify-email | 
[**PutUser**](UsersApi.md#putuser) | **Put** /{realm}/users/{id} | 
[**PutUserGroup**](UsersApi.md#putusergroup) | **Put** /{realm}/users/{id}/groups/{groupId} | 
[**PutUserLabel**](UsersApi.md#putuserlabel) | **Put** /{realm}/users/{id}/credentials/{credentialId}/userLabel | 


<a name="deleteconsent"></a>
# **DeleteConsent**
> void DeleteConsent (string realm, string id, string _client, CancellationToken ct)



Revoke consent and offline tokens for particular client from user

### Example
```csharp
using System;
using System.Diagnostics;
using ;
using Keycloak.Client;
using Keycloak.Client.Models;

namespace Example
{
    public class DeleteConsentExample
    {
        public void main()
        {
            

            var apiInstance = new UsersApi();
            var realm = realm_example;  // string | realm name (not id!)
            var id = id_example;  // string | 
            var _client = _client_example;  // string | Client id
            var ct = new CancellationToken(); // CancellationToken |  (optional) 

            try
            {
                apiInstance.DeleteConsent(realm, id, _client, ct);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling UsersApi.DeleteConsent: " + e.Message );
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
 **_client** | **string**| Client id | 
 **ct** | [**CancellationToken**](.md)|  | [optional] 

### Return type

void (empty response body)

### Authorization

[access_token](../README.md#access_token)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="deletecredential"></a>
# **DeleteCredential**
> void DeleteCredential (string realm, string id, string credentialId, CancellationToken ct)



Remove a credential for a user

### Example
```csharp
using System;
using System.Diagnostics;
using ;
using Keycloak.Client;
using Keycloak.Client.Models;

namespace Example
{
    public class DeleteCredentialExample
    {
        public void main()
        {
            

            var apiInstance = new UsersApi();
            var realm = realm_example;  // string | realm name (not id!)
            var id = id_example;  // string | 
            var credentialId = credentialId_example;  // string | 
            var ct = new CancellationToken(); // CancellationToken |  (optional) 

            try
            {
                apiInstance.DeleteCredential(realm, id, credentialId, ct);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling UsersApi.DeleteCredential: " + e.Message );
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
 **credentialId** | **string**|  | 
 **ct** | [**CancellationToken**](.md)|  | [optional] 

### Return type

void (empty response body)

### Authorization

[access_token](../README.md#access_token)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="deletefederatedidentity"></a>
# **DeleteFederatedIdentity**
> void DeleteFederatedIdentity (string realm, string id, string provider, CancellationToken ct)



Remove a social login provider from user

### Example
```csharp
using System;
using System.Diagnostics;
using ;
using Keycloak.Client;
using Keycloak.Client.Models;

namespace Example
{
    public class DeleteFederatedIdentityExample
    {
        public void main()
        {
            

            var apiInstance = new UsersApi();
            var realm = realm_example;  // string | realm name (not id!)
            var id = id_example;  // string | 
            var provider = provider_example;  // string | Social login provider id
            var ct = new CancellationToken(); // CancellationToken |  (optional) 

            try
            {
                apiInstance.DeleteFederatedIdentity(realm, id, provider, ct);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling UsersApi.DeleteFederatedIdentity: " + e.Message );
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
 **provider** | **string**| Social login provider id | 
 **ct** | [**CancellationToken**](.md)|  | [optional] 

### Return type

void (empty response body)

### Authorization

[access_token](../README.md#access_token)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="deleteuserbyrealmbyid"></a>
# **DeleteUserByRealmById**
> void DeleteUserByRealmById (string realm, string id, CancellationToken ct)



Delete the user

### Example
```csharp
using System;
using System.Diagnostics;
using ;
using Keycloak.Client;
using Keycloak.Client.Models;

namespace Example
{
    public class DeleteUserByRealmByIdExample
    {
        public void main()
        {
            

            var apiInstance = new UsersApi();
            var realm = realm_example;  // string | realm name (not id!)
            var id = id_example;  // string | 
            var ct = new CancellationToken(); // CancellationToken |  (optional) 

            try
            {
                apiInstance.DeleteUserByRealmById(realm, id, ct);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling UsersApi.DeleteUserByRealmById: " + e.Message );
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

<a name="deleteusergroup"></a>
# **DeleteUserGroup**
> void DeleteUserGroup (string realm, string id, string groupId, CancellationToken ct)



### Example
```csharp
using System;
using System.Diagnostics;
using ;
using Keycloak.Client;
using Keycloak.Client.Models;

namespace Example
{
    public class DeleteUserGroupExample
    {
        public void main()
        {
            

            var apiInstance = new UsersApi();
            var realm = realm_example;  // string | realm name (not id!)
            var id = id_example;  // string | 
            var groupId = groupId_example;  // string | 
            var ct = new CancellationToken(); // CancellationToken |  (optional) 

            try
            {
                apiInstance.DeleteUserGroup(realm, id, groupId, ct);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling UsersApi.DeleteUserGroup: " + e.Message );
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
 **groupId** | **string**|  | 
 **ct** | [**CancellationToken**](.md)|  | [optional] 

### Return type

void (empty response body)

### Authorization

[access_token](../README.md#access_token)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getconfigureduserstoragecredentialtypes"></a>
# **GetConfiguredUserStorageCredentialTypes**
> List<string> GetConfiguredUserStorageCredentialTypes (string realm, string id, CancellationToken ct)



Return credential types, which are provided by the user storage where user is stored.

### Example
```csharp
using System;
using System.Diagnostics;
using ;
using Keycloak.Client;
using Keycloak.Client.Models;

namespace Example
{
    public class GetConfiguredUserStorageCredentialTypesExample
    {
        public void main()
        {
            

            var apiInstance = new UsersApi();
            var realm = realm_example;  // string | realm name (not id!)
            var id = id_example;  // string | 
            var ct = new CancellationToken(); // CancellationToken |  (optional) 

            try
            {
                List&lt;string&gt; result = apiInstance.GetConfiguredUserStorageCredentialTypes(realm, id, ct);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling UsersApi.GetConfiguredUserStorageCredentialTypes: " + e.Message );
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

**List<string>**

### Authorization

[access_token](../README.md#access_token)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getconsents"></a>
# **GetConsents**
> List<Object> GetConsents (string realm, string id, CancellationToken ct)



Get consents granted by the user

### Example
```csharp
using System;
using System.Diagnostics;
using ;
using Keycloak.Client;
using Keycloak.Client.Models;

namespace Example
{
    public class GetConsentsExample
    {
        public void main()
        {
            

            var apiInstance = new UsersApi();
            var realm = realm_example;  // string | realm name (not id!)
            var id = id_example;  // string | 
            var ct = new CancellationToken(); // CancellationToken |  (optional) 

            try
            {
                List&lt;Object&gt; result = apiInstance.GetConsents(realm, id, ct);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling UsersApi.GetConsents: " + e.Message );
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

**List<Object>**

### Authorization

[access_token](../README.md#access_token)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getcredentials"></a>
# **GetCredentials**
> List<CredentialRepresentation> GetCredentials (string realm, string id, CancellationToken ct)



### Example
```csharp
using System;
using System.Diagnostics;
using ;
using Keycloak.Client;
using Keycloak.Client.Models;

namespace Example
{
    public class GetCredentialsExample
    {
        public void main()
        {
            

            var apiInstance = new UsersApi();
            var realm = realm_example;  // string | realm name (not id!)
            var id = id_example;  // string | 
            var ct = new CancellationToken(); // CancellationToken |  (optional) 

            try
            {
                List&lt;CredentialRepresentation&gt; result = apiInstance.GetCredentials(realm, id, ct);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling UsersApi.GetCredentials: " + e.Message );
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

[**List<CredentialRepresentation>**](CredentialRepresentation.md)

### Authorization

[access_token](../README.md#access_token)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getfederatedidentity"></a>
# **GetFederatedIdentity**
> List<FederatedIdentityRepresentation> GetFederatedIdentity (string realm, string id, CancellationToken ct)



Get social logins associated with the user

### Example
```csharp
using System;
using System.Diagnostics;
using ;
using Keycloak.Client;
using Keycloak.Client.Models;

namespace Example
{
    public class GetFederatedIdentityExample
    {
        public void main()
        {
            

            var apiInstance = new UsersApi();
            var realm = realm_example;  // string | realm name (not id!)
            var id = id_example;  // string | 
            var ct = new CancellationToken(); // CancellationToken |  (optional) 

            try
            {
                List&lt;FederatedIdentityRepresentation&gt; result = apiInstance.GetFederatedIdentity(realm, id, ct);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling UsersApi.GetFederatedIdentity: " + e.Message );
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

[**List<FederatedIdentityRepresentation>**](FederatedIdentityRepresentation.md)

### Authorization

[access_token](../README.md#access_token)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getmetadata"></a>
# **GetMetadata**
> UserProfileMetadata GetMetadata (string realm, CancellationToken ct)



### Example
```csharp
using System;
using System.Diagnostics;
using ;
using Keycloak.Client;
using Keycloak.Client.Models;

namespace Example
{
    public class GetMetadataExample
    {
        public void main()
        {
            

            var apiInstance = new UsersApi();
            var realm = realm_example;  // string | realm name (not id!)
            var ct = new CancellationToken(); // CancellationToken |  (optional) 

            try
            {
                UserProfileMetadata result = apiInstance.GetMetadata(realm, ct);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling UsersApi.GetMetadata: " + e.Message );
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

[**UserProfileMetadata**](UserProfileMetadata.md)

### Authorization

[access_token](../README.md#access_token)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getofflinesession"></a>
# **GetOfflineSession**
> List<UserSessionRepresentation> GetOfflineSession (string realm, string id, string clientUuid, CancellationToken ct)



Get offline sessions associated with the user and client

### Example
```csharp
using System;
using System.Diagnostics;
using ;
using Keycloak.Client;
using Keycloak.Client.Models;

namespace Example
{
    public class GetOfflineSessionExample
    {
        public void main()
        {
            

            var apiInstance = new UsersApi();
            var realm = realm_example;  // string | realm name (not id!)
            var id = id_example;  // string | 
            var clientUuid = clientUuid_example;  // string | 
            var ct = new CancellationToken(); // CancellationToken |  (optional) 

            try
            {
                List&lt;UserSessionRepresentation&gt; result = apiInstance.GetOfflineSession(realm, id, clientUuid, ct);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling UsersApi.GetOfflineSession: " + e.Message );
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
 **clientUuid** | **string**|  | 
 **ct** | [**CancellationToken**](.md)|  | [optional] 

### Return type

[**List<UserSessionRepresentation>**](UserSessionRepresentation.md)

### Authorization

[access_token](../README.md#access_token)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getprofile"></a>
# **GetProfile**
> UPConfig GetProfile (string realm, CancellationToken ct)



### Example
```csharp
using System;
using System.Diagnostics;
using ;
using Keycloak.Client;
using Keycloak.Client.Models;

namespace Example
{
    public class GetProfileExample
    {
        public void main()
        {
            

            var apiInstance = new UsersApi();
            var realm = realm_example;  // string | realm name (not id!)
            var ct = new CancellationToken(); // CancellationToken |  (optional) 

            try
            {
                UPConfig result = apiInstance.GetProfile(realm, ct);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling UsersApi.GetProfile: " + e.Message );
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

[**UPConfig**](UPConfig.md)

### Authorization

[access_token](../README.md#access_token)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getsessions"></a>
# **GetSessions**
> List<UserSessionRepresentation> GetSessions (string realm, string id, CancellationToken ct)



Get sessions associated with the user

### Example
```csharp
using System;
using System.Diagnostics;
using ;
using Keycloak.Client;
using Keycloak.Client.Models;

namespace Example
{
    public class GetSessionsExample
    {
        public void main()
        {
            

            var apiInstance = new UsersApi();
            var realm = realm_example;  // string | realm name (not id!)
            var id = id_example;  // string | 
            var ct = new CancellationToken(); // CancellationToken |  (optional) 

            try
            {
                List&lt;UserSessionRepresentation&gt; result = apiInstance.GetSessions(realm, id, ct);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling UsersApi.GetSessions: " + e.Message );
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

[**List<UserSessionRepresentation>**](UserSessionRepresentation.md)

### Authorization

[access_token](../README.md#access_token)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getuserbyrealmbyid"></a>
# **GetUserByRealmById**
> UserRepresentation GetUserByRealmById (string realm, string id, string userProfileMetadata, CancellationToken ct)



Get representation of the user

### Example
```csharp
using System;
using System.Diagnostics;
using ;
using Keycloak.Client;
using Keycloak.Client.Models;

namespace Example
{
    public class GetUserByRealmByIdExample
    {
        public void main()
        {
            

            var apiInstance = new UsersApi();
            var realm = realm_example;  // string | realm name (not id!)
            var id = id_example;  // string | 
            var userProfileMetadata = userProfileMetadata_example;  // string | Indicates if the user profile metadata should be added to the response (optional) 
            var ct = new CancellationToken(); // CancellationToken |  (optional) 

            try
            {
                UserRepresentation result = apiInstance.GetUserByRealmById(realm, id, userProfileMetadata, ct);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling UsersApi.GetUserByRealmById: " + e.Message );
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
 **userProfileMetadata** | **string**| Indicates if the user profile metadata should be added to the response | [optional] 
 **ct** | [**CancellationToken**](.md)|  | [optional] 

### Return type

[**UserRepresentation**](UserRepresentation.md)

### Authorization

[access_token](../README.md#access_token)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getusergroups"></a>
# **GetUserGroups**
> List<GroupRepresentation> GetUserGroups (string realm, string id, string briefRepresentation, string first, string max, string search, CancellationToken ct)



### Example
```csharp
using System;
using System.Diagnostics;
using ;
using Keycloak.Client;
using Keycloak.Client.Models;

namespace Example
{
    public class GetUserGroupsExample
    {
        public void main()
        {
            

            var apiInstance = new UsersApi();
            var realm = realm_example;  // string | realm name (not id!)
            var id = id_example;  // string | 
            var briefRepresentation = briefRepresentation_example;  // string |  (optional) 
            var first = first_example;  // string |  (optional) 
            var max = max_example;  // string |  (optional) 
            var search = search_example;  // string |  (optional) 
            var ct = new CancellationToken(); // CancellationToken |  (optional) 

            try
            {
                List&lt;GroupRepresentation&gt; result = apiInstance.GetUserGroups(realm, id, briefRepresentation, first, max, search, ct);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling UsersApi.GetUserGroups: " + e.Message );
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

[**List<GroupRepresentation>**](GroupRepresentation.md)

### Authorization

[access_token](../README.md#access_token)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getusergroupscount"></a>
# **GetUserGroupsCount**
> Dictionary<string, long?> GetUserGroupsCount (string realm, string id, string search, CancellationToken ct)



### Example
```csharp
using System;
using System.Diagnostics;
using ;
using Keycloak.Client;
using Keycloak.Client.Models;

namespace Example
{
    public class GetUserGroupsCountExample
    {
        public void main()
        {
            

            var apiInstance = new UsersApi();
            var realm = realm_example;  // string | realm name (not id!)
            var id = id_example;  // string | 
            var search = search_example;  // string |  (optional) 
            var ct = new CancellationToken(); // CancellationToken |  (optional) 

            try
            {
                Dictionary&lt;string, long?&gt; result = apiInstance.GetUserGroupsCount(realm, id, search, ct);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling UsersApi.GetUserGroupsCount: " + e.Message );
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
 **search** | **string**|  | [optional] 
 **ct** | [**CancellationToken**](.md)|  | [optional] 

### Return type

**Dictionary<string, long?>**

### Authorization

[access_token](../README.md#access_token)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getusersbyrealm"></a>
# **GetUsersByRealm**
> List<UserRepresentation> GetUsersByRealm (string realm, string briefRepresentation, string email, string emailVerified, string enabled, string exact, string first, string firstName, string idpAlias, string idpUserId, string lastName, string max, string q, string search, string username, CancellationToken ct)



Get users Returns a stream of users, filtered according to query parameters.

### Example
```csharp
using System;
using System.Diagnostics;
using ;
using Keycloak.Client;
using Keycloak.Client.Models;

namespace Example
{
    public class GetUsersByRealmExample
    {
        public void main()
        {
            

            var apiInstance = new UsersApi();
            var realm = realm_example;  // string | realm name (not id!)
            var briefRepresentation = briefRepresentation_example;  // string | Boolean which defines whether brief representations are returned (default: false) (optional) 
            var email = email_example;  // string | A String contained in email, or the complete email, if param &quot;exact&quot; is true (optional) 
            var emailVerified = emailVerified_example;  // string | whether the email has been verified (optional) 
            var enabled = enabled_example;  // string | Boolean representing if user is enabled or not (optional) 
            var exact = exact_example;  // string | Boolean which defines whether the params &quot;last&quot;, &quot;first&quot;, &quot;email&quot; and &quot;username&quot; must match exactly (optional) 
            var first = first_example;  // string | Pagination offset (optional) 
            var firstName = firstName_example;  // string | A String contained in firstName, or the complete firstName, if param &quot;exact&quot; is true (optional) 
            var idpAlias = idpAlias_example;  // string | The alias of an Identity Provider linked to the user (optional) 
            var idpUserId = idpUserId_example;  // string | The userId at an Identity Provider linked to the user (optional) 
            var lastName = lastName_example;  // string | A String contained in lastName, or the complete lastName, if param &quot;exact&quot; is true (optional) 
            var max = max_example;  // string | Maximum results size (defaults to 100) (optional) 
            var q = q_example;  // string | A query to search for custom attributes, in the format 'key1:value2 key2:value2' (optional) 
            var search = search_example;  // string | A String contained in username, first or last name, or email. Default search behavior is prefix-based (e.g., foo or foo*). Use foo for infix search and &quot;foo&quot; for exact search. (optional) 
            var username = username_example;  // string | A String contained in username, or the complete username, if param &quot;exact&quot; is true (optional) 
            var ct = new CancellationToken(); // CancellationToken |  (optional) 

            try
            {
                List&lt;UserRepresentation&gt; result = apiInstance.GetUsersByRealm(realm, briefRepresentation, email, emailVerified, enabled, exact, first, firstName, idpAlias, idpUserId, lastName, max, q, search, username, ct);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling UsersApi.GetUsersByRealm: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **realm** | **string**| realm name (not id!) | 
 **briefRepresentation** | **string**| Boolean which defines whether brief representations are returned (default: false) | [optional] 
 **email** | **string**| A String contained in email, or the complete email, if param &amp;quot;exact&amp;quot; is true | [optional] 
 **emailVerified** | **string**| whether the email has been verified | [optional] 
 **enabled** | **string**| Boolean representing if user is enabled or not | [optional] 
 **exact** | **string**| Boolean which defines whether the params &amp;quot;last&amp;quot;, &amp;quot;first&amp;quot;, &amp;quot;email&amp;quot; and &amp;quot;username&amp;quot; must match exactly | [optional] 
 **first** | **string**| Pagination offset | [optional] 
 **firstName** | **string**| A String contained in firstName, or the complete firstName, if param &amp;quot;exact&amp;quot; is true | [optional] 
 **idpAlias** | **string**| The alias of an Identity Provider linked to the user | [optional] 
 **idpUserId** | **string**| The userId at an Identity Provider linked to the user | [optional] 
 **lastName** | **string**| A String contained in lastName, or the complete lastName, if param &amp;quot;exact&amp;quot; is true | [optional] 
 **max** | **string**| Maximum results size (defaults to 100) | [optional] 
 **q** | **string**| A query to search for custom attributes, in the format &#39;key1:value2 key2:value2&#39; | [optional] 
 **search** | **string**| A String contained in username, first or last name, or email. Default search behavior is prefix-based (e.g., foo or foo*). Use foo for infix search and &amp;quot;foo&amp;quot; for exact search. | [optional] 
 **username** | **string**| A String contained in username, or the complete username, if param &amp;quot;exact&amp;quot; is true | [optional] 
 **ct** | [**CancellationToken**](.md)|  | [optional] 

### Return type

[**List<UserRepresentation>**](UserRepresentation.md)

### Authorization

[access_token](../README.md#access_token)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getuserscount"></a>
# **GetUsersCount**
> int? GetUsersCount (string realm, string email, string emailVerified, string enabled, string firstName, string lastName, string q, string search, string username, CancellationToken ct)



Returns the number of users that match the given criteria.

### Example
```csharp
using System;
using System.Diagnostics;
using ;
using Keycloak.Client;
using Keycloak.Client.Models;

namespace Example
{
    public class GetUsersCountExample
    {
        public void main()
        {
            

            var apiInstance = new UsersApi();
            var realm = realm_example;  // string | realm name (not id!)
            var email = email_example;  // string | email filter (optional) 
            var emailVerified = emailVerified_example;  // string |  (optional) 
            var enabled = enabled_example;  // string | Boolean representing if user is enabled or not (optional) 
            var firstName = firstName_example;  // string | first name filter (optional) 
            var lastName = lastName_example;  // string | last name filter (optional) 
            var q = q_example;  // string |  (optional) 
            var search = search_example;  // string | arbitrary search string for all the fields below. Default search behavior is prefix-based (e.g., foo or foo*). Use foo for infix search and &quot;foo&quot; for exact search. (optional) 
            var username = username_example;  // string | username filter (optional) 
            var ct = new CancellationToken(); // CancellationToken |  (optional) 

            try
            {
                int? result = apiInstance.GetUsersCount(realm, email, emailVerified, enabled, firstName, lastName, q, search, username, ct);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling UsersApi.GetUsersCount: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **realm** | **string**| realm name (not id!) | 
 **email** | **string**| email filter | [optional] 
 **emailVerified** | **string**|  | [optional] 
 **enabled** | **string**| Boolean representing if user is enabled or not | [optional] 
 **firstName** | **string**| first name filter | [optional] 
 **lastName** | **string**| last name filter | [optional] 
 **q** | **string**|  | [optional] 
 **search** | **string**| arbitrary search string for all the fields below. Default search behavior is prefix-based (e.g., foo or foo*). Use foo for infix search and &amp;quot;foo&amp;quot; for exact search. | [optional] 
 **username** | **string**| username filter | [optional] 
 **ct** | [**CancellationToken**](.md)|  | [optional] 

### Return type

**int?**

### Authorization

[access_token](../README.md#access_token)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="postfederatedidentity"></a>
# **PostFederatedIdentity**
> void PostFederatedIdentity (string realm, string id, string provider, CancellationToken ct)



Add a social login provider to the user

### Example
```csharp
using System;
using System.Diagnostics;
using ;
using Keycloak.Client;
using Keycloak.Client.Models;

namespace Example
{
    public class PostFederatedIdentityExample
    {
        public void main()
        {
            

            var apiInstance = new UsersApi();
            var realm = realm_example;  // string | realm name (not id!)
            var id = id_example;  // string | 
            var provider = provider_example;  // string | Social login provider id
            var ct = new CancellationToken(); // CancellationToken |  (optional) 

            try
            {
                apiInstance.PostFederatedIdentity(realm, id, provider, ct);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling UsersApi.PostFederatedIdentity: " + e.Message );
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
 **provider** | **string**| Social login provider id | 
 **ct** | [**CancellationToken**](.md)|  | [optional] 

### Return type

void (empty response body)

### Authorization

[access_token](../README.md#access_token)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="postimpersonation"></a>
# **PostImpersonation**
> Dictionary<string, Object> PostImpersonation (string realm, string id, CancellationToken ct)



Impersonate the user

### Example
```csharp
using System;
using System.Diagnostics;
using ;
using Keycloak.Client;
using Keycloak.Client.Models;

namespace Example
{
    public class PostImpersonationExample
    {
        public void main()
        {
            

            var apiInstance = new UsersApi();
            var realm = realm_example;  // string | realm name (not id!)
            var id = id_example;  // string | 
            var ct = new CancellationToken(); // CancellationToken |  (optional) 

            try
            {
                Dictionary&lt;string, Object&gt; result = apiInstance.PostImpersonation(realm, id, ct);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling UsersApi.PostImpersonation: " + e.Message );
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

**Dictionary<string, Object>**

### Authorization

[access_token](../README.md#access_token)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="postlogout"></a>
# **PostLogout**
> void PostLogout (string realm, string id, CancellationToken ct)



Remove all user sessions associated with the user Also send notification to all clients that have an admin URL to invalidate the sessions for the particular user.

### Example
```csharp
using System;
using System.Diagnostics;
using ;
using Keycloak.Client;
using Keycloak.Client.Models;

namespace Example
{
    public class PostLogoutExample
    {
        public void main()
        {
            

            var apiInstance = new UsersApi();
            var realm = realm_example;  // string | realm name (not id!)
            var id = id_example;  // string | 
            var ct = new CancellationToken(); // CancellationToken |  (optional) 

            try
            {
                apiInstance.PostLogout(realm, id, ct);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling UsersApi.PostLogout: " + e.Message );
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

<a name="postmoveafter"></a>
# **PostMoveAfter**
> void PostMoveAfter (string realm, string id, string credentialId, string newPreviousCredentialId, CancellationToken ct)



Move a credential to a position behind another credential

### Example
```csharp
using System;
using System.Diagnostics;
using ;
using Keycloak.Client;
using Keycloak.Client.Models;

namespace Example
{
    public class PostMoveAfterExample
    {
        public void main()
        {
            

            var apiInstance = new UsersApi();
            var realm = realm_example;  // string | realm name (not id!)
            var id = id_example;  // string | 
            var credentialId = credentialId_example;  // string | The credential to move
            var newPreviousCredentialId = newPreviousCredentialId_example;  // string | The credential that will be the previous element in the list. If set to null, the moved credential will be the first element in the list.
            var ct = new CancellationToken(); // CancellationToken |  (optional) 

            try
            {
                apiInstance.PostMoveAfter(realm, id, credentialId, newPreviousCredentialId, ct);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling UsersApi.PostMoveAfter: " + e.Message );
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
 **credentialId** | **string**| The credential to move | 
 **newPreviousCredentialId** | **string**| The credential that will be the previous element in the list. If set to null, the moved credential will be the first element in the list. | 
 **ct** | [**CancellationToken**](.md)|  | [optional] 

### Return type

void (empty response body)

### Authorization

[access_token](../README.md#access_token)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="postmovetofirst"></a>
# **PostMoveToFirst**
> void PostMoveToFirst (string realm, string id, string credentialId, CancellationToken ct)



Move a credential to a first position in the credentials list of the user

### Example
```csharp
using System;
using System.Diagnostics;
using ;
using Keycloak.Client;
using Keycloak.Client.Models;

namespace Example
{
    public class PostMoveToFirstExample
    {
        public void main()
        {
            

            var apiInstance = new UsersApi();
            var realm = realm_example;  // string | realm name (not id!)
            var id = id_example;  // string | 
            var credentialId = credentialId_example;  // string | The credential to move
            var ct = new CancellationToken(); // CancellationToken |  (optional) 

            try
            {
                apiInstance.PostMoveToFirst(realm, id, credentialId, ct);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling UsersApi.PostMoveToFirst: " + e.Message );
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
 **credentialId** | **string**| The credential to move | 
 **ct** | [**CancellationToken**](.md)|  | [optional] 

### Return type

void (empty response body)

### Authorization

[access_token](../README.md#access_token)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="postusers"></a>
# **PostUsers**
> void PostUsers (string realm, UserRepresentation body, CancellationToken ct)



Create a new user Username must be unique.

### Example
```csharp
using System;
using System.Diagnostics;
using ;
using Keycloak.Client;
using Keycloak.Client.Models;

namespace Example
{
    public class PostUsersExample
    {
        public void main()
        {
            

            var apiInstance = new UsersApi();
            var realm = realm_example;  // string | realm name (not id!)
            var body = new UserRepresentation(); // UserRepresentation | UserRepresentation (optional) 
            var ct = new CancellationToken(); // CancellationToken |  (optional) 

            try
            {
                apiInstance.PostUsers(realm, body, ct);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling UsersApi.PostUsers: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **realm** | **string**| realm name (not id!) | 
 **body** | [**UserRepresentation**](UserRepresentation.md)| UserRepresentation | [optional] 
 **ct** | [**CancellationToken**](.md)|  | [optional] 

### Return type

void (empty response body)

### Authorization

[access_token](../README.md#access_token)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="putdisablecredentialtypes"></a>
# **PutDisableCredentialTypes**
> void PutDisableCredentialTypes (string realm, string id, string body, CancellationToken ct)



Disable all credentials for a user of a specific type

### Example
```csharp
using System;
using System.Diagnostics;
using ;
using Keycloak.Client;
using Keycloak.Client.Models;

namespace Example
{
    public class PutDisableCredentialTypesExample
    {
        public void main()
        {
            

            var apiInstance = new UsersApi();
            var realm = realm_example;  // string | realm name (not id!)
            var id = id_example;  // string | 
            var body = new string(); // string | [string] (optional) 
            var ct = new CancellationToken(); // CancellationToken |  (optional) 

            try
            {
                apiInstance.PutDisableCredentialTypes(realm, id, body, ct);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling UsersApi.PutDisableCredentialTypes: " + e.Message );
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

<a name="putexecuteactionsemail"></a>
# **PutExecuteActionsEmail**
> void PutExecuteActionsEmail (string realm, string id, string body, string clientId, string lifespan, string redirectUri, CancellationToken ct)



Send an email to the user with a link they can click to execute particular actions.

### Example
```csharp
using System;
using System.Diagnostics;
using ;
using Keycloak.Client;
using Keycloak.Client.Models;

namespace Example
{
    public class PutExecuteActionsEmailExample
    {
        public void main()
        {
            

            var apiInstance = new UsersApi();
            var realm = realm_example;  // string | realm name (not id!)
            var id = id_example;  // string | 
            var body = new string(); // string | [string] (optional) 
            var clientId = clientId_example;  // string | Client id (optional) 
            var lifespan = lifespan_example;  // string | Number of seconds after which the generated token expires (optional) 
            var redirectUri = redirectUri_example;  // string | Redirect uri (optional) 
            var ct = new CancellationToken(); // CancellationToken |  (optional) 

            try
            {
                apiInstance.PutExecuteActionsEmail(realm, id, body, clientId, lifespan, redirectUri, ct);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling UsersApi.PutExecuteActionsEmail: " + e.Message );
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
 **clientId** | **string**| Client id | [optional] 
 **lifespan** | **string**| Number of seconds after which the generated token expires | [optional] 
 **redirectUri** | **string**| Redirect uri | [optional] 
 **ct** | [**CancellationToken**](.md)|  | [optional] 

### Return type

void (empty response body)

### Authorization

[access_token](../README.md#access_token)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="putprofile"></a>
# **PutProfile**
> UPConfig PutProfile (string realm, UPConfig body, CancellationToken ct)



### Example
```csharp
using System;
using System.Diagnostics;
using ;
using Keycloak.Client;
using Keycloak.Client.Models;

namespace Example
{
    public class PutProfileExample
    {
        public void main()
        {
            

            var apiInstance = new UsersApi();
            var realm = realm_example;  // string | realm name (not id!)
            var body = new UPConfig(); // UPConfig | UPConfig (optional) 
            var ct = new CancellationToken(); // CancellationToken |  (optional) 

            try
            {
                UPConfig result = apiInstance.PutProfile(realm, body, ct);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling UsersApi.PutProfile: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **realm** | **string**| realm name (not id!) | 
 **body** | [**UPConfig**](UPConfig.md)| UPConfig | [optional] 
 **ct** | [**CancellationToken**](.md)|  | [optional] 

### Return type

[**UPConfig**](UPConfig.md)

### Authorization

[access_token](../README.md#access_token)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="putresetpassword"></a>
# **PutResetPassword**
> void PutResetPassword (string realm, string id, CredentialRepresentation body, CancellationToken ct)



Set up a new password for the user.

### Example
```csharp
using System;
using System.Diagnostics;
using ;
using Keycloak.Client;
using Keycloak.Client.Models;

namespace Example
{
    public class PutResetPasswordExample
    {
        public void main()
        {
            

            var apiInstance = new UsersApi();
            var realm = realm_example;  // string | realm name (not id!)
            var id = id_example;  // string | 
            var body = new CredentialRepresentation(); // CredentialRepresentation | CredentialRepresentation (optional) 
            var ct = new CancellationToken(); // CancellationToken |  (optional) 

            try
            {
                apiInstance.PutResetPassword(realm, id, body, ct);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling UsersApi.PutResetPassword: " + e.Message );
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
 **body** | [**CredentialRepresentation**](CredentialRepresentation.md)| CredentialRepresentation | [optional] 
 **ct** | [**CancellationToken**](.md)|  | [optional] 

### Return type

void (empty response body)

### Authorization

[access_token](../README.md#access_token)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="putresetpasswordemail"></a>
# **PutResetPasswordEmail**
> void PutResetPasswordEmail (string realm, string id, string clientId, string redirectUri, CancellationToken ct)



Send an email to the user with a link they can click to reset their password.

### Example
```csharp
using System;
using System.Diagnostics;
using ;
using Keycloak.Client;
using Keycloak.Client.Models;

namespace Example
{
    public class PutResetPasswordEmailExample
    {
        public void main()
        {
            

            var apiInstance = new UsersApi();
            var realm = realm_example;  // string | realm name (not id!)
            var id = id_example;  // string | 
            var clientId = clientId_example;  // string | client id (optional) 
            var redirectUri = redirectUri_example;  // string | redirect uri (optional) 
            var ct = new CancellationToken(); // CancellationToken |  (optional) 

            try
            {
                apiInstance.PutResetPasswordEmail(realm, id, clientId, redirectUri, ct);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling UsersApi.PutResetPasswordEmail: " + e.Message );
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
 **clientId** | **string**| client id | [optional] 
 **redirectUri** | **string**| redirect uri | [optional] 
 **ct** | [**CancellationToken**](.md)|  | [optional] 

### Return type

void (empty response body)

### Authorization

[access_token](../README.md#access_token)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="putsendverifyemail"></a>
# **PutSendVerifyEmail**
> void PutSendVerifyEmail (string realm, string id, string clientId, string redirectUri, CancellationToken ct)



Send an email-verification email to the user An email contains a link the user can click to verify their email address.

### Example
```csharp
using System;
using System.Diagnostics;
using ;
using Keycloak.Client;
using Keycloak.Client.Models;

namespace Example
{
    public class PutSendVerifyEmailExample
    {
        public void main()
        {
            

            var apiInstance = new UsersApi();
            var realm = realm_example;  // string | realm name (not id!)
            var id = id_example;  // string | 
            var clientId = clientId_example;  // string | Client id (optional) 
            var redirectUri = redirectUri_example;  // string | Redirect uri (optional) 
            var ct = new CancellationToken(); // CancellationToken |  (optional) 

            try
            {
                apiInstance.PutSendVerifyEmail(realm, id, clientId, redirectUri, ct);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling UsersApi.PutSendVerifyEmail: " + e.Message );
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
 **clientId** | **string**| Client id | [optional] 
 **redirectUri** | **string**| Redirect uri | [optional] 
 **ct** | [**CancellationToken**](.md)|  | [optional] 

### Return type

void (empty response body)

### Authorization

[access_token](../README.md#access_token)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="putuser"></a>
# **PutUser**
> void PutUser (string realm, string id, UserRepresentation body, CancellationToken ct)



Update the user

### Example
```csharp
using System;
using System.Diagnostics;
using ;
using Keycloak.Client;
using Keycloak.Client.Models;

namespace Example
{
    public class PutUserExample
    {
        public void main()
        {
            

            var apiInstance = new UsersApi();
            var realm = realm_example;  // string | realm name (not id!)
            var id = id_example;  // string | 
            var body = new UserRepresentation(); // UserRepresentation | UserRepresentation (optional) 
            var ct = new CancellationToken(); // CancellationToken |  (optional) 

            try
            {
                apiInstance.PutUser(realm, id, body, ct);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling UsersApi.PutUser: " + e.Message );
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
 **body** | [**UserRepresentation**](UserRepresentation.md)| UserRepresentation | [optional] 
 **ct** | [**CancellationToken**](.md)|  | [optional] 

### Return type

void (empty response body)

### Authorization

[access_token](../README.md#access_token)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="putusergroup"></a>
# **PutUserGroup**
> void PutUserGroup (string realm, string id, string groupId, CancellationToken ct)



### Example
```csharp
using System;
using System.Diagnostics;
using ;
using Keycloak.Client;
using Keycloak.Client.Models;

namespace Example
{
    public class PutUserGroupExample
    {
        public void main()
        {
            

            var apiInstance = new UsersApi();
            var realm = realm_example;  // string | realm name (not id!)
            var id = id_example;  // string | 
            var groupId = groupId_example;  // string | 
            var ct = new CancellationToken(); // CancellationToken |  (optional) 

            try
            {
                apiInstance.PutUserGroup(realm, id, groupId, ct);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling UsersApi.PutUserGroup: " + e.Message );
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
 **groupId** | **string**|  | 
 **ct** | [**CancellationToken**](.md)|  | [optional] 

### Return type

void (empty response body)

### Authorization

[access_token](../README.md#access_token)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="putuserlabel"></a>
# **PutUserLabel**
> void PutUserLabel (string realm, string id, string credentialId, string body, CancellationToken ct)



Update a credential label for a user

### Example
```csharp
using System;
using System.Diagnostics;
using ;
using Keycloak.Client;
using Keycloak.Client.Models;

namespace Example
{
    public class PutUserLabelExample
    {
        public void main()
        {
            

            var apiInstance = new UsersApi();
            var realm = realm_example;  // string | realm name (not id!)
            var id = id_example;  // string | 
            var credentialId = credentialId_example;  // string | 
            var body = new string(); // string | [string] (optional) 
            var ct = new CancellationToken(); // CancellationToken |  (optional) 

            try
            {
                apiInstance.PutUserLabel(realm, id, credentialId, body, ct);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling UsersApi.PutUserLabel: " + e.Message );
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
 **credentialId** | **string**|  | 
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

