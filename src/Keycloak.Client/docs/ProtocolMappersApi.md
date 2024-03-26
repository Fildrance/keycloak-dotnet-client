# IO.Swagger.Api.ProtocolMappersApi

All URIs are relative to *https://keycloak.example.com/admin/realms*

Method | HTTP request | Description
------------- | ------------- | -------------
[**DeleteClientProtocolMappersModel**](ProtocolMappersApi.md#deleteclientprotocolmappersmodel) | **DELETE** /{realm}/clients/{id1}/protocol-mappers/models/{id2} | 
[**DeleteClientScopeProtocolMappersModel**](ProtocolMappersApi.md#deleteclientscopeprotocolmappersmodel) | **DELETE** /{realm}/client-scopes/{id1}/protocol-mappers/models/{id2} | 
[**DeleteClientTemplateProtocolMappersModel**](ProtocolMappersApi.md#deleteclienttemplateprotocolmappersmodel) | **DELETE** /{realm}/client-templates/{id1}/protocol-mappers/models/{id2} | 
[**GetClientProtocolMappersModel**](ProtocolMappersApi.md#getclientprotocolmappersmodel) | **GET** /{realm}/clients/{id1}/protocol-mappers/models/{id2} | 
[**GetClientProtocolMappersModels**](ProtocolMappersApi.md#getclientprotocolmappersmodels) | **GET** /{realm}/clients/{id}/protocol-mappers/models | 
[**GetClientProtocolMappersProtocol**](ProtocolMappersApi.md#getclientprotocolmappersprotocol) | **GET** /{realm}/clients/{id}/protocol-mappers/protocol/{protocol} | 
[**GetClientScopeProtocolMappersModel**](ProtocolMappersApi.md#getclientscopeprotocolmappersmodel) | **GET** /{realm}/client-scopes/{id1}/protocol-mappers/models/{id2} | 
[**GetClientScopeProtocolMappersModels**](ProtocolMappersApi.md#getclientscopeprotocolmappersmodels) | **GET** /{realm}/client-scopes/{id}/protocol-mappers/models | 
[**GetClientScopeProtocolMappersProtocol**](ProtocolMappersApi.md#getclientscopeprotocolmappersprotocol) | **GET** /{realm}/client-scopes/{id}/protocol-mappers/protocol/{protocol} | 
[**GetClientTemplateProtocolMappersModel**](ProtocolMappersApi.md#getclienttemplateprotocolmappersmodel) | **GET** /{realm}/client-templates/{id1}/protocol-mappers/models/{id2} | 
[**GetClientTemplateProtocolMappersModels**](ProtocolMappersApi.md#getclienttemplateprotocolmappersmodels) | **GET** /{realm}/client-templates/{id}/protocol-mappers/models | 
[**GetClientTemplateProtocolMappersProtocol**](ProtocolMappersApi.md#getclienttemplateprotocolmappersprotocol) | **GET** /{realm}/client-templates/{id}/protocol-mappers/protocol/{protocol} | 
[**PostClientProtocolMappersAddModels**](ProtocolMappersApi.md#postclientprotocolmappersaddmodels) | **POST** /{realm}/clients/{id}/protocol-mappers/add-models | 
[**PostClientProtocolMappersModels**](ProtocolMappersApi.md#postclientprotocolmappersmodels) | **POST** /{realm}/clients/{id}/protocol-mappers/models | 
[**PostClientScopeProtocolMappersAddModels**](ProtocolMappersApi.md#postclientscopeprotocolmappersaddmodels) | **POST** /{realm}/client-scopes/{id}/protocol-mappers/add-models | 
[**PostClientScopeProtocolMappersModels**](ProtocolMappersApi.md#postclientscopeprotocolmappersmodels) | **POST** /{realm}/client-scopes/{id}/protocol-mappers/models | 
[**PostClientTemplateProtocolMappersAddModels**](ProtocolMappersApi.md#postclienttemplateprotocolmappersaddmodels) | **POST** /{realm}/client-templates/{id}/protocol-mappers/add-models | 
[**PostClientTemplateProtocolMappersModels**](ProtocolMappersApi.md#postclienttemplateprotocolmappersmodels) | **POST** /{realm}/client-templates/{id}/protocol-mappers/models | 
[**PutClientProtocolMappersModel**](ProtocolMappersApi.md#putclientprotocolmappersmodel) | **PUT** /{realm}/clients/{id1}/protocol-mappers/models/{id2} | 
[**PutClientScopeProtocolMappersModel**](ProtocolMappersApi.md#putclientscopeprotocolmappersmodel) | **PUT** /{realm}/client-scopes/{id1}/protocol-mappers/models/{id2} | 
[**PutClientTemplateProtocolMappersModel**](ProtocolMappersApi.md#putclienttemplateprotocolmappersmodel) | **PUT** /{realm}/client-templates/{id1}/protocol-mappers/models/{id2} | 

<a name="deleteclientprotocolmappersmodel"></a>
# **DeleteClientProtocolMappersModel**
> void DeleteClientProtocolMappersModel (string realm, string id1, string id2)



Delete the mapper

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class DeleteClientProtocolMappersModelExample
    {
        public void main()
        {


            var apiInstance = new ProtocolMappersApi();
            var realm = realm_example;  // string | realm name (not id!)
            var id1 = id1_example;  // string | 
            var id2 = id2_example;  // string | 

            try
            {
                apiInstance.DeleteClientProtocolMappersModel(realm, id1, id2);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ProtocolMappersApi.DeleteClientProtocolMappersModel: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **realm** | **string**| realm name (not id!) | 
 **id1** | **string**|  | 
 **id2** | **string**|  | 

### Return type

void (empty response body)

### Authorization

[access_token](../README.md#access_token)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="deleteclientscopeprotocolmappersmodel"></a>
# **DeleteClientScopeProtocolMappersModel**
> void DeleteClientScopeProtocolMappersModel (string realm, string id1, string id2)



Delete the mapper

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class DeleteClientScopeProtocolMappersModelExample
    {
        public void main()
        {


            var apiInstance = new ProtocolMappersApi();
            var realm = realm_example;  // string | realm name (not id!)
            var id1 = id1_example;  // string | 
            var id2 = id2_example;  // string | 

            try
            {
                apiInstance.DeleteClientScopeProtocolMappersModel(realm, id1, id2);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ProtocolMappersApi.DeleteClientScopeProtocolMappersModel: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **realm** | **string**| realm name (not id!) | 
 **id1** | **string**|  | 
 **id2** | **string**|  | 

### Return type

void (empty response body)

### Authorization

[access_token](../README.md#access_token)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="deleteclienttemplateprotocolmappersmodel"></a>
# **DeleteClientTemplateProtocolMappersModel**
> void DeleteClientTemplateProtocolMappersModel (string realm, string id1, string id2)



Delete the mapper

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class DeleteClientTemplateProtocolMappersModelExample
    {
        public void main()
        {


            var apiInstance = new ProtocolMappersApi();
            var realm = realm_example;  // string | realm name (not id!)
            var id1 = id1_example;  // string | 
            var id2 = id2_example;  // string | 

            try
            {
                apiInstance.DeleteClientTemplateProtocolMappersModel(realm, id1, id2);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ProtocolMappersApi.DeleteClientTemplateProtocolMappersModel: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **realm** | **string**| realm name (not id!) | 
 **id1** | **string**|  | 
 **id2** | **string**|  | 

### Return type

void (empty response body)

### Authorization

[access_token](../README.md#access_token)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getclientprotocolmappersmodel"></a>
# **GetClientProtocolMappersModel**
> ProtocolMapperRepresentation GetClientProtocolMappersModel (string realm, string id1, string id2)



Get mapper by id

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class GetClientProtocolMappersModelExample
    {
        public void main()
        {


            var apiInstance = new ProtocolMappersApi();
            var realm = realm_example;  // string | realm name (not id!)
            var id1 = id1_example;  // string | 
            var id2 = id2_example;  // string | 

            try
            {
                ProtocolMapperRepresentation result = apiInstance.GetClientProtocolMappersModel(realm, id1, id2);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ProtocolMappersApi.GetClientProtocolMappersModel: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **realm** | **string**| realm name (not id!) | 
 **id1** | **string**|  | 
 **id2** | **string**|  | 

### Return type

[**ProtocolMapperRepresentation**](ProtocolMapperRepresentation.md)

### Authorization

[access_token](../README.md#access_token)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getclientprotocolmappersmodels"></a>
# **GetClientProtocolMappersModels**
> List<ProtocolMapperRepresentation> GetClientProtocolMappersModels (string realm, string id)



Get mappers

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class GetClientProtocolMappersModelsExample
    {
        public void main()
        {


            var apiInstance = new ProtocolMappersApi();
            var realm = realm_example;  // string | realm name (not id!)
            var id = id_example;  // string | 

            try
            {
                List&lt;ProtocolMapperRepresentation&gt; result = apiInstance.GetClientProtocolMappersModels(realm, id);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ProtocolMappersApi.GetClientProtocolMappersModels: " + e.Message );
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

[**List<ProtocolMapperRepresentation>**](ProtocolMapperRepresentation.md)

### Authorization

[access_token](../README.md#access_token)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getclientprotocolmappersprotocol"></a>
# **GetClientProtocolMappersProtocol**
> List<ProtocolMapperRepresentation> GetClientProtocolMappersProtocol (string realm, string id, string protocol)



Get mappers by name for a specific protocol

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class GetClientProtocolMappersProtocolExample
    {
        public void main()
        {


            var apiInstance = new ProtocolMappersApi();
            var realm = realm_example;  // string | realm name (not id!)
            var id = id_example;  // string | 
            var protocol = protocol_example;  // string | 

            try
            {
                List&lt;ProtocolMapperRepresentation&gt; result = apiInstance.GetClientProtocolMappersProtocol(realm, id, protocol);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ProtocolMappersApi.GetClientProtocolMappersProtocol: " + e.Message );
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
 **protocol** | **string**|  | 

### Return type

[**List<ProtocolMapperRepresentation>**](ProtocolMapperRepresentation.md)

### Authorization

[access_token](../README.md#access_token)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getclientscopeprotocolmappersmodel"></a>
# **GetClientScopeProtocolMappersModel**
> ProtocolMapperRepresentation GetClientScopeProtocolMappersModel (string realm, string id1, string id2)



Get mapper by id

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class GetClientScopeProtocolMappersModelExample
    {
        public void main()
        {


            var apiInstance = new ProtocolMappersApi();
            var realm = realm_example;  // string | realm name (not id!)
            var id1 = id1_example;  // string | 
            var id2 = id2_example;  // string | 

            try
            {
                ProtocolMapperRepresentation result = apiInstance.GetClientScopeProtocolMappersModel(realm, id1, id2);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ProtocolMappersApi.GetClientScopeProtocolMappersModel: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **realm** | **string**| realm name (not id!) | 
 **id1** | **string**|  | 
 **id2** | **string**|  | 

### Return type

[**ProtocolMapperRepresentation**](ProtocolMapperRepresentation.md)

### Authorization

[access_token](../README.md#access_token)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getclientscopeprotocolmappersmodels"></a>
# **GetClientScopeProtocolMappersModels**
> List<ProtocolMapperRepresentation> GetClientScopeProtocolMappersModels (string realm, string id)



Get mappers

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class GetClientScopeProtocolMappersModelsExample
    {
        public void main()
        {


            var apiInstance = new ProtocolMappersApi();
            var realm = realm_example;  // string | realm name (not id!)
            var id = id_example;  // string | 

            try
            {
                List&lt;ProtocolMapperRepresentation&gt; result = apiInstance.GetClientScopeProtocolMappersModels(realm, id);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ProtocolMappersApi.GetClientScopeProtocolMappersModels: " + e.Message );
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

[**List<ProtocolMapperRepresentation>**](ProtocolMapperRepresentation.md)

### Authorization

[access_token](../README.md#access_token)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getclientscopeprotocolmappersprotocol"></a>
# **GetClientScopeProtocolMappersProtocol**
> List<ProtocolMapperRepresentation> GetClientScopeProtocolMappersProtocol (string realm, string id, string protocol)



Get mappers by name for a specific protocol

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class GetClientScopeProtocolMappersProtocolExample
    {
        public void main()
        {


            var apiInstance = new ProtocolMappersApi();
            var realm = realm_example;  // string | realm name (not id!)
            var id = id_example;  // string | 
            var protocol = protocol_example;  // string | 

            try
            {
                List&lt;ProtocolMapperRepresentation&gt; result = apiInstance.GetClientScopeProtocolMappersProtocol(realm, id, protocol);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ProtocolMappersApi.GetClientScopeProtocolMappersProtocol: " + e.Message );
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
 **protocol** | **string**|  | 

### Return type

[**List<ProtocolMapperRepresentation>**](ProtocolMapperRepresentation.md)

### Authorization

[access_token](../README.md#access_token)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getclienttemplateprotocolmappersmodel"></a>
# **GetClientTemplateProtocolMappersModel**
> ProtocolMapperRepresentation GetClientTemplateProtocolMappersModel (string realm, string id1, string id2)



Get mapper by id

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class GetClientTemplateProtocolMappersModelExample
    {
        public void main()
        {


            var apiInstance = new ProtocolMappersApi();
            var realm = realm_example;  // string | realm name (not id!)
            var id1 = id1_example;  // string | 
            var id2 = id2_example;  // string | 

            try
            {
                ProtocolMapperRepresentation result = apiInstance.GetClientTemplateProtocolMappersModel(realm, id1, id2);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ProtocolMappersApi.GetClientTemplateProtocolMappersModel: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **realm** | **string**| realm name (not id!) | 
 **id1** | **string**|  | 
 **id2** | **string**|  | 

### Return type

[**ProtocolMapperRepresentation**](ProtocolMapperRepresentation.md)

### Authorization

[access_token](../README.md#access_token)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getclienttemplateprotocolmappersmodels"></a>
# **GetClientTemplateProtocolMappersModels**
> List<ProtocolMapperRepresentation> GetClientTemplateProtocolMappersModels (string realm, string id)



Get mappers

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class GetClientTemplateProtocolMappersModelsExample
    {
        public void main()
        {


            var apiInstance = new ProtocolMappersApi();
            var realm = realm_example;  // string | realm name (not id!)
            var id = id_example;  // string | 

            try
            {
                List&lt;ProtocolMapperRepresentation&gt; result = apiInstance.GetClientTemplateProtocolMappersModels(realm, id);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ProtocolMappersApi.GetClientTemplateProtocolMappersModels: " + e.Message );
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

[**List<ProtocolMapperRepresentation>**](ProtocolMapperRepresentation.md)

### Authorization

[access_token](../README.md#access_token)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getclienttemplateprotocolmappersprotocol"></a>
# **GetClientTemplateProtocolMappersProtocol**
> List<ProtocolMapperRepresentation> GetClientTemplateProtocolMappersProtocol (string realm, string id, string protocol)



Get mappers by name for a specific protocol

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class GetClientTemplateProtocolMappersProtocolExample
    {
        public void main()
        {


            var apiInstance = new ProtocolMappersApi();
            var realm = realm_example;  // string | realm name (not id!)
            var id = id_example;  // string | 
            var protocol = protocol_example;  // string | 

            try
            {
                List&lt;ProtocolMapperRepresentation&gt; result = apiInstance.GetClientTemplateProtocolMappersProtocol(realm, id, protocol);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ProtocolMappersApi.GetClientTemplateProtocolMappersProtocol: " + e.Message );
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
 **protocol** | **string**|  | 

### Return type

[**List<ProtocolMapperRepresentation>**](ProtocolMapperRepresentation.md)

### Authorization

[access_token](../README.md#access_token)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="postclientprotocolmappersaddmodels"></a>
# **PostClientProtocolMappersAddModels**
> void PostClientProtocolMappersAddModels (string realm, string id, ProtocolMapperRepresentation body)



Create multiple mappers

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class PostClientProtocolMappersAddModelsExample
    {
        public void main()
        {


            var apiInstance = new ProtocolMappersApi();
            var realm = realm_example;  // string | realm name (not id!)
            var id = id_example;  // string | 
            var body = new ProtocolMapperRepresentation(); // ProtocolMapperRepresentation | ProtocolMapperRepresentation (optional) 

            try
            {
                apiInstance.PostClientProtocolMappersAddModels(realm, id, body);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ProtocolMappersApi.PostClientProtocolMappersAddModels: " + e.Message );
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
 **body** | [**ProtocolMapperRepresentation**](ProtocolMapperRepresentation.md)| ProtocolMapperRepresentation | [optional] 

### Return type

void (empty response body)

### Authorization

[access_token](../README.md#access_token)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="postclientprotocolmappersmodels"></a>
# **PostClientProtocolMappersModels**
> void PostClientProtocolMappersModels (string realm, string id, ProtocolMapperRepresentation body)



Create a mapper

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class PostClientProtocolMappersModelsExample
    {
        public void main()
        {


            var apiInstance = new ProtocolMappersApi();
            var realm = realm_example;  // string | realm name (not id!)
            var id = id_example;  // string | 
            var body = new ProtocolMapperRepresentation(); // ProtocolMapperRepresentation | ProtocolMapperRepresentation (optional) 

            try
            {
                apiInstance.PostClientProtocolMappersModels(realm, id, body);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ProtocolMappersApi.PostClientProtocolMappersModels: " + e.Message );
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
 **body** | [**ProtocolMapperRepresentation**](ProtocolMapperRepresentation.md)| ProtocolMapperRepresentation | [optional] 

### Return type

void (empty response body)

### Authorization

[access_token](../README.md#access_token)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="postclientscopeprotocolmappersaddmodels"></a>
# **PostClientScopeProtocolMappersAddModels**
> void PostClientScopeProtocolMappersAddModels (string realm, string id, ProtocolMapperRepresentation body)



Create multiple mappers

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class PostClientScopeProtocolMappersAddModelsExample
    {
        public void main()
        {


            var apiInstance = new ProtocolMappersApi();
            var realm = realm_example;  // string | realm name (not id!)
            var id = id_example;  // string | 
            var body = new ProtocolMapperRepresentation(); // ProtocolMapperRepresentation | ProtocolMapperRepresentation (optional) 

            try
            {
                apiInstance.PostClientScopeProtocolMappersAddModels(realm, id, body);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ProtocolMappersApi.PostClientScopeProtocolMappersAddModels: " + e.Message );
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
 **body** | [**ProtocolMapperRepresentation**](ProtocolMapperRepresentation.md)| ProtocolMapperRepresentation | [optional] 

### Return type

void (empty response body)

### Authorization

[access_token](../README.md#access_token)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="postclientscopeprotocolmappersmodels"></a>
# **PostClientScopeProtocolMappersModels**
> void PostClientScopeProtocolMappersModels (string realm, string id, ProtocolMapperRepresentation body)



Create a mapper

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class PostClientScopeProtocolMappersModelsExample
    {
        public void main()
        {


            var apiInstance = new ProtocolMappersApi();
            var realm = realm_example;  // string | realm name (not id!)
            var id = id_example;  // string | 
            var body = new ProtocolMapperRepresentation(); // ProtocolMapperRepresentation | ProtocolMapperRepresentation (optional) 

            try
            {
                apiInstance.PostClientScopeProtocolMappersModels(realm, id, body);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ProtocolMappersApi.PostClientScopeProtocolMappersModels: " + e.Message );
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
 **body** | [**ProtocolMapperRepresentation**](ProtocolMapperRepresentation.md)| ProtocolMapperRepresentation | [optional] 

### Return type

void (empty response body)

### Authorization

[access_token](../README.md#access_token)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="postclienttemplateprotocolmappersaddmodels"></a>
# **PostClientTemplateProtocolMappersAddModels**
> void PostClientTemplateProtocolMappersAddModels (string realm, string id, ProtocolMapperRepresentation body)



Create multiple mappers

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class PostClientTemplateProtocolMappersAddModelsExample
    {
        public void main()
        {


            var apiInstance = new ProtocolMappersApi();
            var realm = realm_example;  // string | realm name (not id!)
            var id = id_example;  // string | 
            var body = new ProtocolMapperRepresentation(); // ProtocolMapperRepresentation | ProtocolMapperRepresentation (optional) 

            try
            {
                apiInstance.PostClientTemplateProtocolMappersAddModels(realm, id, body);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ProtocolMappersApi.PostClientTemplateProtocolMappersAddModels: " + e.Message );
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
 **body** | [**ProtocolMapperRepresentation**](ProtocolMapperRepresentation.md)| ProtocolMapperRepresentation | [optional] 

### Return type

void (empty response body)

### Authorization

[access_token](../README.md#access_token)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="postclienttemplateprotocolmappersmodels"></a>
# **PostClientTemplateProtocolMappersModels**
> void PostClientTemplateProtocolMappersModels (string realm, string id, ProtocolMapperRepresentation body)



Create a mapper

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class PostClientTemplateProtocolMappersModelsExample
    {
        public void main()
        {


            var apiInstance = new ProtocolMappersApi();
            var realm = realm_example;  // string | realm name (not id!)
            var id = id_example;  // string | 
            var body = new ProtocolMapperRepresentation(); // ProtocolMapperRepresentation | ProtocolMapperRepresentation (optional) 

            try
            {
                apiInstance.PostClientTemplateProtocolMappersModels(realm, id, body);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ProtocolMappersApi.PostClientTemplateProtocolMappersModels: " + e.Message );
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
 **body** | [**ProtocolMapperRepresentation**](ProtocolMapperRepresentation.md)| ProtocolMapperRepresentation | [optional] 

### Return type

void (empty response body)

### Authorization

[access_token](../README.md#access_token)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="putclientprotocolmappersmodel"></a>
# **PutClientProtocolMappersModel**
> void PutClientProtocolMappersModel (string realm, string id1, string id2, ProtocolMapperRepresentation body)



Update the mapper

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class PutClientProtocolMappersModelExample
    {
        public void main()
        {


            var apiInstance = new ProtocolMappersApi();
            var realm = realm_example;  // string | realm name (not id!)
            var id1 = id1_example;  // string | 
            var id2 = id2_example;  // string | 
            var body = new ProtocolMapperRepresentation(); // ProtocolMapperRepresentation | ProtocolMapperRepresentation (optional) 

            try
            {
                apiInstance.PutClientProtocolMappersModel(realm, id1, id2, body);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ProtocolMappersApi.PutClientProtocolMappersModel: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **realm** | **string**| realm name (not id!) | 
 **id1** | **string**|  | 
 **id2** | **string**|  | 
 **body** | [**ProtocolMapperRepresentation**](ProtocolMapperRepresentation.md)| ProtocolMapperRepresentation | [optional] 

### Return type

void (empty response body)

### Authorization

[access_token](../README.md#access_token)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="putclientscopeprotocolmappersmodel"></a>
# **PutClientScopeProtocolMappersModel**
> void PutClientScopeProtocolMappersModel (string realm, string id1, string id2, ProtocolMapperRepresentation body)



Update the mapper

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class PutClientScopeProtocolMappersModelExample
    {
        public void main()
        {


            var apiInstance = new ProtocolMappersApi();
            var realm = realm_example;  // string | realm name (not id!)
            var id1 = id1_example;  // string | 
            var id2 = id2_example;  // string | 
            var body = new ProtocolMapperRepresentation(); // ProtocolMapperRepresentation | ProtocolMapperRepresentation (optional) 

            try
            {
                apiInstance.PutClientScopeProtocolMappersModel(realm, id1, id2, body);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ProtocolMappersApi.PutClientScopeProtocolMappersModel: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **realm** | **string**| realm name (not id!) | 
 **id1** | **string**|  | 
 **id2** | **string**|  | 
 **body** | [**ProtocolMapperRepresentation**](ProtocolMapperRepresentation.md)| ProtocolMapperRepresentation | [optional] 

### Return type

void (empty response body)

### Authorization

[access_token](../README.md#access_token)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="putclienttemplateprotocolmappersmodel"></a>
# **PutClientTemplateProtocolMappersModel**
> void PutClientTemplateProtocolMappersModel (string realm, string id1, string id2, ProtocolMapperRepresentation body)



Update the mapper

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class PutClientTemplateProtocolMappersModelExample
    {
        public void main()
        {


            var apiInstance = new ProtocolMappersApi();
            var realm = realm_example;  // string | realm name (not id!)
            var id1 = id1_example;  // string | 
            var id2 = id2_example;  // string | 
            var body = new ProtocolMapperRepresentation(); // ProtocolMapperRepresentation | ProtocolMapperRepresentation (optional) 

            try
            {
                apiInstance.PutClientTemplateProtocolMappersModel(realm, id1, id2, body);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ProtocolMappersApi.PutClientTemplateProtocolMappersModel: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **realm** | **string**| realm name (not id!) | 
 **id1** | **string**|  | 
 **id2** | **string**|  | 
 **body** | [**ProtocolMapperRepresentation**](ProtocolMapperRepresentation.md)| ProtocolMapperRepresentation | [optional] 

### Return type

void (empty response body)

### Authorization

[access_token](../README.md#access_token)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

