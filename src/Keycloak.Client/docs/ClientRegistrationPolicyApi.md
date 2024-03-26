# IO.Swagger.Api.ClientRegistrationPolicyApi

All URIs are relative to *https://keycloak.example.com/admin/realms*

Method | HTTP request | Description
------------- | ------------- | -------------
[**GetProviders**](ClientRegistrationPolicyApi.md#getproviders) | **GET** /{realm}/client-registration-policy/providers | 

<a name="getproviders"></a>
# **GetProviders**
> List<ComponentTypeRepresentation> GetProviders (string realm)



Base path for retrieve providers with the configProperties properly filled

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class GetProvidersExample
    {
        public void main()
        {


            var apiInstance = new ClientRegistrationPolicyApi();
            var realm = realm_example;  // string | realm name (not id!)

            try
            {
                List&lt;ComponentTypeRepresentation&gt; result = apiInstance.GetProviders(realm);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ClientRegistrationPolicyApi.GetProviders: " + e.Message );
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

[**List<ComponentTypeRepresentation>**](ComponentTypeRepresentation.md)

### Authorization

[access_token](../README.md#access_token)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

