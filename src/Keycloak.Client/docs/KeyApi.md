# .KeyApi

All URIs are relative to *https://keycloak.example.com/admin/realms*

Method | HTTP request | Description
------------- | ------------- | -------------
[**GetKeys**](KeyApi.md#getkeys) | **Get** /{realm}/keys | 


<a name="getkeys"></a>
# **GetKeys**
> KeysMetadataRepresentation GetKeys (string realm, CancellationToken ct)



### Example
```csharp
using System;
using System.Diagnostics;
using ;
using PetShop;
using PetShop.Models;

namespace Example
{
    public class GetKeysExample
    {
        public void main()
        {
            

            var apiInstance = new KeyApi();
            var realm = realm_example;  // string | realm name (not id!)
            var ct = new CancellationToken(); // CancellationToken |  (optional) 

            try
            {
                KeysMetadataRepresentation result = apiInstance.GetKeys(realm, ct);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling KeyApi.GetKeys: " + e.Message );
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

[**KeysMetadataRepresentation**](KeysMetadataRepresentation.md)

### Authorization

[access_token](../README.md#access_token)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

