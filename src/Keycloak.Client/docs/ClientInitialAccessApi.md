# IO.Swagger.Api.ClientInitialAccessApi

All URIs are relative to *https://keycloak.example.com/admin/realms*

Method | HTTP request | Description
------------- | ------------- | -------------
[**DeleteClientsInitialAcces**](ClientInitialAccessApi.md#deleteclientsinitialacces) | **DELETE** /{realm}/clients-initial-access/{id} | 
[**GetClientsInitialAccess**](ClientInitialAccessApi.md#getclientsinitialaccess) | **GET** /{realm}/clients-initial-access | 
[**PostClientsInitialAccess**](ClientInitialAccessApi.md#postclientsinitialaccess) | **POST** /{realm}/clients-initial-access | 

<a name="deleteclientsinitialacces"></a>
# **DeleteClientsInitialAcces**
> void DeleteClientsInitialAcces (string realm, string id)



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

            try
            {
                apiInstance.DeleteClientsInitialAcces(realm, id);
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
> List<ClientInitialAccessPresentation> GetClientsInitialAccess (string realm)



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

            try
            {
                List&lt;ClientInitialAccessPresentation&gt; result = apiInstance.GetClientsInitialAccess(realm);
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
> ClientInitialAccessPresentation PostClientsInitialAccess (string realm, ClientInitialAccessCreatePresentation body)



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

            try
            {
                ClientInitialAccessPresentation result = apiInstance.PostClientsInitialAccess(realm, body);
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

### Return type

[**ClientInitialAccessPresentation**](ClientInitialAccessPresentation.md)

### Authorization

[access_token](../README.md#access_token)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

