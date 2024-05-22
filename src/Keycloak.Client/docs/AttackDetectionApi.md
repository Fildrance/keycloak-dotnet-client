# .AttackDetectionApi

All URIs are relative to *https://keycloak.example.com/admin/realms*

Method | HTTP request | Description
------------- | ------------- | -------------
[**DeleteBruteForceUser**](AttackDetectionApi.md#deletebruteforceuser) | **Delete** /{realm}/attack-detection/brute-force/users/{userId} | 
[**DeleteUsers**](AttackDetectionApi.md#deleteusers) | **Delete** /{realm}/attack-detection/brute-force/users | 
[**GetBruteForceUser**](AttackDetectionApi.md#getbruteforceuser) | **Get** /{realm}/attack-detection/brute-force/users/{userId} | 


<a name="deletebruteforceuser"></a>
# **DeleteBruteForceUser**
> void DeleteBruteForceUser (string realm, string userId, CancellationToken ct)



Clear any user login failures for the user This can release temporary disabled user

### Example
```csharp
using System;
using System.Diagnostics;
using ;
using Keycloak.Client;
using Keycloak.Client.Models;

namespace Example
{
    public class DeleteBruteForceUserExample
    {
        public void main()
        {
            

            var apiInstance = new AttackDetectionApi();
            var realm = realm_example;  // string | realm name (not id!)
            var userId = userId_example;  // string | 
            var ct = new CancellationToken(); // CancellationToken |  (optional) 

            try
            {
                apiInstance.DeleteBruteForceUser(realm, userId, ct);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AttackDetectionApi.DeleteBruteForceUser: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **realm** | **string**| realm name (not id!) | 
 **userId** | **string**|  | 
 **ct** | [**CancellationToken**](.md)|  | [optional] 

### Return type

void (empty response body)

### Authorization

[access_token](../README.md#access_token)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="deleteusers"></a>
# **DeleteUsers**
> void DeleteUsers (string realm, CancellationToken ct)



Clear any user login failures for all users This can release temporary disabled users

### Example
```csharp
using System;
using System.Diagnostics;
using ;
using Keycloak.Client;
using Keycloak.Client.Models;

namespace Example
{
    public class DeleteUsersExample
    {
        public void main()
        {
            

            var apiInstance = new AttackDetectionApi();
            var realm = realm_example;  // string | realm name (not id!)
            var ct = new CancellationToken(); // CancellationToken |  (optional) 

            try
            {
                apiInstance.DeleteUsers(realm, ct);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AttackDetectionApi.DeleteUsers: " + e.Message );
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

### Authorization

[access_token](../README.md#access_token)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getbruteforceuser"></a>
# **GetBruteForceUser**
> Dictionary<string, Object> GetBruteForceUser (string realm, string userId, CancellationToken ct)



Get status of a username in brute force detection

### Example
```csharp
using System;
using System.Diagnostics;
using ;
using Keycloak.Client;
using Keycloak.Client.Models;

namespace Example
{
    public class GetBruteForceUserExample
    {
        public void main()
        {
            

            var apiInstance = new AttackDetectionApi();
            var realm = realm_example;  // string | realm name (not id!)
            var userId = userId_example;  // string | 
            var ct = new CancellationToken(); // CancellationToken |  (optional) 

            try
            {
                Dictionary&lt;string, Object&gt; result = apiInstance.GetBruteForceUser(realm, userId, ct);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AttackDetectionApi.GetBruteForceUser: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **realm** | **string**| realm name (not id!) | 
 **userId** | **string**|  | 
 **ct** | [**CancellationToken**](.md)|  | [optional] 

### Return type

**Dictionary<string, Object>**

### Authorization

[access_token](../README.md#access_token)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

