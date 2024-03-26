# IO.Swagger.Api.ClientAttributeCertificateApi

All URIs are relative to *https://keycloak.example.com/admin/realms*

Method | HTTP request | Description
------------- | ------------- | -------------
[**GetCertificate**](ClientAttributeCertificateApi.md#getcertificate) | **GET** /{realm}/clients/{id}/certificates/{attr} | 
[**PostDownload**](ClientAttributeCertificateApi.md#postdownload) | **POST** /{realm}/clients/{id}/certificates/{attr}/download | 
[**PostGenerate**](ClientAttributeCertificateApi.md#postgenerate) | **POST** /{realm}/clients/{id}/certificates/{attr}/generate | 
[**PostGenerateAndDownload**](ClientAttributeCertificateApi.md#postgenerateanddownload) | **POST** /{realm}/clients/{id}/certificates/{attr}/generate-and-download | 
[**PostUpload**](ClientAttributeCertificateApi.md#postupload) | **POST** /{realm}/clients/{id}/certificates/{attr}/upload | 
[**PostUploadCertificate**](ClientAttributeCertificateApi.md#postuploadcertificate) | **POST** /{realm}/clients/{id}/certificates/{attr}/upload-certificate | 

<a name="getcertificate"></a>
# **GetCertificate**
> CertificateRepresentation GetCertificate (string realm, string id, string attr)



Get key info

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class GetCertificateExample
    {
        public void main()
        {


            var apiInstance = new ClientAttributeCertificateApi();
            var realm = realm_example;  // string | realm name (not id!)
            var id = id_example;  // string | 
            var attr = attr_example;  // string | 

            try
            {
                CertificateRepresentation result = apiInstance.GetCertificate(realm, id, attr);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ClientAttributeCertificateApi.GetCertificate: " + e.Message );
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
 **attr** | **string**|  | 

### Return type

[**CertificateRepresentation**](CertificateRepresentation.md)

### Authorization

[access_token](../README.md#access_token)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="postdownload"></a>
# **PostDownload**
> byte[] PostDownload (string realm, string id, string attr, KeyStoreConfig body)



Get a keystore file for the client, containing private key and public certificate

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class PostDownloadExample
    {
        public void main()
        {


            var apiInstance = new ClientAttributeCertificateApi();
            var realm = realm_example;  // string | realm name (not id!)
            var id = id_example;  // string | 
            var attr = attr_example;  // string | 
            var body = new KeyStoreConfig(); // KeyStoreConfig | KeyStoreConfig (optional) 

            try
            {
                byte[] result = apiInstance.PostDownload(realm, id, attr, body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ClientAttributeCertificateApi.PostDownload: " + e.Message );
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
 **attr** | **string**|  | 
 **body** | [**KeyStoreConfig**](KeyStoreConfig.md)| KeyStoreConfig | [optional] 

### Return type

**byte[]**

### Authorization

[access_token](../README.md#access_token)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/octet-stream

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="postgenerate"></a>
# **PostGenerate**
> CertificateRepresentation PostGenerate (string realm, string id, string attr)



Generate a new certificate with new key pair

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class PostGenerateExample
    {
        public void main()
        {


            var apiInstance = new ClientAttributeCertificateApi();
            var realm = realm_example;  // string | realm name (not id!)
            var id = id_example;  // string | 
            var attr = attr_example;  // string | 

            try
            {
                CertificateRepresentation result = apiInstance.PostGenerate(realm, id, attr);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ClientAttributeCertificateApi.PostGenerate: " + e.Message );
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
 **attr** | **string**|  | 

### Return type

[**CertificateRepresentation**](CertificateRepresentation.md)

### Authorization

[access_token](../README.md#access_token)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="postgenerateanddownload"></a>
# **PostGenerateAndDownload**
> byte[] PostGenerateAndDownload (string realm, string id, string attr, KeyStoreConfig body)



Generate a new keypair and certificate, and get the private key file  Generates a keypair and certificate and serves the private key in a specified keystore format. Only generated public certificate is saved in Keycloak DB - the private key is not.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class PostGenerateAndDownloadExample
    {
        public void main()
        {


            var apiInstance = new ClientAttributeCertificateApi();
            var realm = realm_example;  // string | realm name (not id!)
            var id = id_example;  // string | 
            var attr = attr_example;  // string | 
            var body = new KeyStoreConfig(); // KeyStoreConfig | KeyStoreConfig (optional) 

            try
            {
                byte[] result = apiInstance.PostGenerateAndDownload(realm, id, attr, body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ClientAttributeCertificateApi.PostGenerateAndDownload: " + e.Message );
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
 **attr** | **string**|  | 
 **body** | [**KeyStoreConfig**](KeyStoreConfig.md)| KeyStoreConfig | [optional] 

### Return type

**byte[]**

### Authorization

[access_token](../README.md#access_token)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/octet-stream

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="postupload"></a>
# **PostUpload**
> CertificateRepresentation PostUpload (string realm, string id, string attr)



Upload certificate and eventually private key

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class PostUploadExample
    {
        public void main()
        {


            var apiInstance = new ClientAttributeCertificateApi();
            var realm = realm_example;  // string | realm name (not id!)
            var id = id_example;  // string | 
            var attr = attr_example;  // string | 

            try
            {
                CertificateRepresentation result = apiInstance.PostUpload(realm, id, attr);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ClientAttributeCertificateApi.PostUpload: " + e.Message );
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
 **attr** | **string**|  | 

### Return type

[**CertificateRepresentation**](CertificateRepresentation.md)

### Authorization

[access_token](../README.md#access_token)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="postuploadcertificate"></a>
# **PostUploadCertificate**
> CertificateRepresentation PostUploadCertificate (string realm, string id, string attr)



Upload only certificate, not private key

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class PostUploadCertificateExample
    {
        public void main()
        {


            var apiInstance = new ClientAttributeCertificateApi();
            var realm = realm_example;  // string | realm name (not id!)
            var id = id_example;  // string | 
            var attr = attr_example;  // string | 

            try
            {
                CertificateRepresentation result = apiInstance.PostUploadCertificate(realm, id, attr);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ClientAttributeCertificateApi.PostUploadCertificate: " + e.Message );
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
 **attr** | **string**|  | 

### Return type

[**CertificateRepresentation**](CertificateRepresentation.md)

### Authorization

[access_token](../README.md#access_token)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

