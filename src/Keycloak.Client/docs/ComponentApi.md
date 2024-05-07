# IO.Swagger.Api.ComponentApi

All URIs are relative to *https://keycloak.example.com/admin/realms*

Method | HTTP request | Description
------------- | ------------- | -------------
[**DeleteComponent**](ComponentApi.md#deletecomponent) | **Delete** /{realm}/components/{id} | 
[**GetComponent**](ComponentApi.md#getcomponent) | **Get** /{realm}/components/{id} | 
[**GetComponents**](ComponentApi.md#getcomponents) | **Get** /{realm}/components | 
[**GetSubComponentTypes**](ComponentApi.md#getsubcomponenttypes) | **Get** /{realm}/components/{id}/sub-component-types | 
[**PostComponents**](ComponentApi.md#postcomponents) | **Post** /{realm}/components | 
[**PutComponent**](ComponentApi.md#putcomponent) | **Put** /{realm}/components/{id} | 


<a name="deletecomponent"></a>
# **DeleteComponent**
> void DeleteComponent (string realm, string id, CancellationToken ct)



### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class DeleteComponentExample
    {
        public void main()
        {
            

            var apiInstance = new ComponentApi();
            var realm = realm_example;  // string | realm name (not id!)
            var id = id_example;  // string | 
            var ct = new CancellationToken(); // CancellationToken |  (optional) 

            try
            {
                apiInstance.DeleteComponent(realm, id, ct);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ComponentApi.DeleteComponent: " + e.Message );
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

<a name="getcomponent"></a>
# **GetComponent**
> ComponentRepresentation GetComponent (string realm, string id, CancellationToken ct)



### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class GetComponentExample
    {
        public void main()
        {
            

            var apiInstance = new ComponentApi();
            var realm = realm_example;  // string | realm name (not id!)
            var id = id_example;  // string | 
            var ct = new CancellationToken(); // CancellationToken |  (optional) 

            try
            {
                ComponentRepresentation result = apiInstance.GetComponent(realm, id, ct);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ComponentApi.GetComponent: " + e.Message );
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

[**ComponentRepresentation**](ComponentRepresentation.md)

### Authorization

[access_token](../README.md#access_token)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getcomponents"></a>
# **GetComponents**
> List<ComponentRepresentation> GetComponents (string realm, string name, string parent, string type, CancellationToken ct)



### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class GetComponentsExample
    {
        public void main()
        {
            

            var apiInstance = new ComponentApi();
            var realm = realm_example;  // string | realm name (not id!)
            var name = name_example;  // string |  (optional) 
            var parent = parent_example;  // string |  (optional) 
            var type = type_example;  // string |  (optional) 
            var ct = new CancellationToken(); // CancellationToken |  (optional) 

            try
            {
                List&lt;ComponentRepresentation&gt; result = apiInstance.GetComponents(realm, name, parent, type, ct);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ComponentApi.GetComponents: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **realm** | **string**| realm name (not id!) | 
 **name** | **string**|  | [optional] 
 **parent** | **string**|  | [optional] 
 **type** | **string**|  | [optional] 
 **ct** | [**CancellationToken**](.md)|  | [optional] 

### Return type

[**List<ComponentRepresentation>**](ComponentRepresentation.md)

### Authorization

[access_token](../README.md#access_token)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getsubcomponenttypes"></a>
# **GetSubComponentTypes**
> List<ComponentTypeRepresentation> GetSubComponentTypes (string realm, string id, string type, CancellationToken ct)



List of subcomponent types that are available to configure for a particular parent component.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class GetSubComponentTypesExample
    {
        public void main()
        {
            

            var apiInstance = new ComponentApi();
            var realm = realm_example;  // string | realm name (not id!)
            var id = id_example;  // string | 
            var type = type_example;  // string |  (optional) 
            var ct = new CancellationToken(); // CancellationToken |  (optional) 

            try
            {
                List&lt;ComponentTypeRepresentation&gt; result = apiInstance.GetSubComponentTypes(realm, id, type, ct);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ComponentApi.GetSubComponentTypes: " + e.Message );
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
 **type** | **string**|  | [optional] 
 **ct** | [**CancellationToken**](.md)|  | [optional] 

### Return type

[**List<ComponentTypeRepresentation>**](ComponentTypeRepresentation.md)

### Authorization

[access_token](../README.md#access_token)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="postcomponents"></a>
# **PostComponents**
> void PostComponents (string realm, ComponentRepresentation body, CancellationToken ct)



### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class PostComponentsExample
    {
        public void main()
        {
            

            var apiInstance = new ComponentApi();
            var realm = realm_example;  // string | realm name (not id!)
            var body = new ComponentRepresentation(); // ComponentRepresentation | ComponentRepresentation (optional) 
            var ct = new CancellationToken(); // CancellationToken |  (optional) 

            try
            {
                apiInstance.PostComponents(realm, body, ct);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ComponentApi.PostComponents: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **realm** | **string**| realm name (not id!) | 
 **body** | [**ComponentRepresentation**](ComponentRepresentation.md)| ComponentRepresentation | [optional] 
 **ct** | [**CancellationToken**](.md)|  | [optional] 

### Return type

void (empty response body)

### Authorization

[access_token](../README.md#access_token)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="putcomponent"></a>
# **PutComponent**
> void PutComponent (string realm, string id, ComponentRepresentation body, CancellationToken ct)



### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class PutComponentExample
    {
        public void main()
        {
            

            var apiInstance = new ComponentApi();
            var realm = realm_example;  // string | realm name (not id!)
            var id = id_example;  // string | 
            var body = new ComponentRepresentation(); // ComponentRepresentation | ComponentRepresentation (optional) 
            var ct = new CancellationToken(); // CancellationToken |  (optional) 

            try
            {
                apiInstance.PutComponent(realm, id, body, ct);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ComponentApi.PutComponent: " + e.Message );
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
 **body** | [**ComponentRepresentation**](ComponentRepresentation.md)| ComponentRepresentation | [optional] 
 **ct** | [**CancellationToken**](.md)|  | [optional] 

### Return type

void (empty response body)

### Authorization

[access_token](../README.md#access_token)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

