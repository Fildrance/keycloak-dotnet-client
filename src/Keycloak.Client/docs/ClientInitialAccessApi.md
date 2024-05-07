# IO.Swagger.Api.ClientInitialAccessApi

All URIs are relative to *https://keycloak.example.com/admin/realms*

Method | HTTP request | Description
------------- | ------------- | -------------
[**DeleteClientsInitialAcces**](ClientInitialAccessApi.md#deleteclientsinitialacces) | **Delete** /{realm}/clients-initial-access/{id} | 
[**GetClientsInitialAccess**](ClientInitialAccessApi.md#getclientsinitialaccess) | **Get** /{realm}/clients-initial-access | 
[**PostClientsInitialAccess**](ClientInitialAccessApi.md#postclientsinitialaccess) | **Post** /{realm}/clients-initial-access | 


<a name="deleteclientsinitialacces"></a>
# **DeleteClientsInitialAcces**
> void DeleteClientsInitialAcces (string realm, string id, CancellationToken ct)



### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class DeleteClientsInitialAccesExample
    {
        public void main()
        {
            

            var apiInstance = new ClientInitialAccessApi();
            var realm = realm_example;  // string | realm name (not id!)
            var id = id_example;  // string | 
            var ct = new CancellationToken(); // CancellationToken |  (optional) 

            try
            {
                apiInstance.DeleteClientsInitialAcces(realm, id, ct);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ClientInitialAccessApi.DeleteClientsInitialAcces: " + e.Message );
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

<a name="getclientsinitialaccess"></a>
# **GetClientsInitialAccess**
> List<ClientInitialAccessPresentation> GetClientsInitialAccess (string realm, CancellationToken ct)



### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class GetClientsInitialAccessExample
    {
        public void main()
        {
            

            var apiInstance = new ClientInitialAccessApi();
            var realm = realm_example;  // string | realm name (not id!)
            var ct = new CancellationToken(); // CancellationToken |  (optional) 

            try
            {
                List&lt;ClientInitialAccessPresentation&gt; result = apiInstance.GetClientsInitialAccess(realm, ct);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ClientInitialAccessApi.GetClientsInitialAccess: " + e.Message );
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

[**List<ClientInitialAccessPresentation>**](ClientInitialAccessPresentation.md)

### Authorization

[access_token](../README.md#access_token)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="postclientsinitialaccess"></a>
# **PostClientsInitialAccess**
> ClientInitialAccessPresentation PostClientsInitialAccess (string realm, ClientInitialAccessCreatePresentation body, CancellationToken ct)



Create a new initial access token.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class PostClientsInitialAccessExample
    {
        public void main()
        {
            

            var apiInstance = new ClientInitialAccessApi();
            var realm = realm_example;  // string | realm name (not id!)
            var body = new ClientInitialAccessCreatePresentation(); // ClientInitialAccessCreatePresentation | ClientInitialAccessCreatePresentation (optional) 
            var ct = new CancellationToken(); // CancellationToken |  (optional) 

            try
            {
                ClientInitialAccessPresentation result = apiInstance.PostClientsInitialAccess(realm, body, ct);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ClientInitialAccessApi.PostClientsInitialAccess: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **realm** | **string**| realm name (not id!) | 
 **body** | [**ClientInitialAccessCreatePresentation**](ClientInitialAccessCreatePresentation.md)| ClientInitialAccessCreatePresentation | [optional] 
 **ct** | [**CancellationToken**](.md)|  | [optional] 

### Return type

[**ClientInitialAccessPresentation**](ClientInitialAccessPresentation.md)

### Authorization

[access_token](../README.md#access_token)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

