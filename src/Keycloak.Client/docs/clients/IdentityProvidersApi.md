# .IdentityProvidersApi

All URIs are relative to *https://keycloak.example.com/admin/realms*

Method | HTTP request | Description
------------- | ------------- | -------------
[**DeleteInstance**](IdentityProvidersApi.md#deleteinstance) | **Delete** /{realm}/identity-provider/instances/{alias} | 
[**DeleteMapper**](IdentityProvidersApi.md#deletemapper) | **Delete** /{realm}/identity-provider/instances/{alias}/mappers/{id} | 
[**GetExport**](IdentityProvidersApi.md#getexport) | **Get** /{realm}/identity-provider/instances/{alias}/export | 
[**GetIdentityProviderProvider**](IdentityProvidersApi.md#getidentityproviderprovider) | **Get** /{realm}/identity-provider/providers/{provider_id} | 
[**GetInstance**](IdentityProvidersApi.md#getinstance) | **Get** /{realm}/identity-provider/instances/{alias} | 
[**GetInstanceManagementPermissions**](IdentityProvidersApi.md#getinstancemanagementpermissions) | **Get** /{realm}/identity-provider/instances/{alias}/management/permissions | 
[**GetInstances**](IdentityProvidersApi.md#getinstances) | **Get** /{realm}/identity-provider/instances | 
[**GetMapper**](IdentityProvidersApi.md#getmapper) | **Get** /{realm}/identity-provider/instances/{alias}/mappers/{id} | 
[**GetMapperTypes**](IdentityProvidersApi.md#getmappertypes) | **Get** /{realm}/identity-provider/instances/{alias}/mapper-types | 
[**GetMappers**](IdentityProvidersApi.md#getmappers) | **Get** /{realm}/identity-provider/instances/{alias}/mappers | 
[**PostImportConfig**](IdentityProvidersApi.md#postimportconfig) | **Post** /{realm}/identity-provider/import-config | 
[**PostInstances**](IdentityProvidersApi.md#postinstances) | **Post** /{realm}/identity-provider/instances | 
[**PostMappers**](IdentityProvidersApi.md#postmappers) | **Post** /{realm}/identity-provider/instances/{alias}/mappers | 
[**PutInstance**](IdentityProvidersApi.md#putinstance) | **Put** /{realm}/identity-provider/instances/{alias} | 
[**PutInstanceManagementPermissions**](IdentityProvidersApi.md#putinstancemanagementpermissions) | **Put** /{realm}/identity-provider/instances/{alias}/management/permissions | 
[**PutMapper**](IdentityProvidersApi.md#putmapper) | **Put** /{realm}/identity-provider/instances/{alias}/mappers/{id} | 


<a name="deleteinstance"></a>
# **DeleteInstance**
> void DeleteInstance (string realm, string alias, CancellationToken ct)



Delete the identity provider

### Example
```csharp
using System;
using System.Diagnostics;
using ;
using Keycloak.Client;
using Keycloak.Client.Models;

namespace Example
{
    public class DeleteInstanceExample
    {
        public void main()
        {
            var apiInstance = new IdentityProvidersApi(new HttpClient(), "http://my-service.srv");
            var realm = realm_example;  // string | realm name (not id!)
            var alias = alias_example;  // string | 
            var ct = new CancellationToken(); // CancellationToken |  (optional) 

            try
            {
                apiInstance.DeleteInstance(realm, alias, ct);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling IdentityProvidersApi.DeleteInstance: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **realm** | **string**| realm name (not id!) | 
 **alias** | **string**|  | 
 **ct** | [**CancellationToken**](.md)|  | [optional] 

### Return type

void (empty response body)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="deletemapper"></a>
# **DeleteMapper**
> void DeleteMapper (string realm, string alias, string id, CancellationToken ct)



Delete a mapper for the identity provider

### Example
```csharp
using System;
using System.Diagnostics;
using ;
using Keycloak.Client;
using Keycloak.Client.Models;

namespace Example
{
    public class DeleteMapperExample
    {
        public void main()
        {
            var apiInstance = new IdentityProvidersApi(new HttpClient(), "http://my-service.srv");
            var realm = realm_example;  // string | realm name (not id!)
            var alias = alias_example;  // string | 
            var id = id_example;  // string | Mapper id
            var ct = new CancellationToken(); // CancellationToken |  (optional) 

            try
            {
                apiInstance.DeleteMapper(realm, alias, id, ct);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling IdentityProvidersApi.DeleteMapper: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **realm** | **string**| realm name (not id!) | 
 **alias** | **string**|  | 
 **id** | **string**| Mapper id | 
 **ct** | [**CancellationToken**](.md)|  | [optional] 

### Return type

void (empty response body)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getexport"></a>
# **GetExport**
> void GetExport (string realm, string alias, string format, CancellationToken ct)



Export public broker configuration for identity provider

### Example
```csharp
using System;
using System.Diagnostics;
using ;
using Keycloak.Client;
using Keycloak.Client.Models;

namespace Example
{
    public class GetExportExample
    {
        public void main()
        {
            var apiInstance = new IdentityProvidersApi(new HttpClient(), "http://my-service.srv");
            var realm = realm_example;  // string | realm name (not id!)
            var alias = alias_example;  // string | 
            var format = format_example;  // string | Format to use (optional) 
            var ct = new CancellationToken(); // CancellationToken |  (optional) 

            try
            {
                apiInstance.GetExport(realm, alias, format, ct);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling IdentityProvidersApi.GetExport: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **realm** | **string**| realm name (not id!) | 
 **alias** | **string**|  | 
 **format** | **string**| Format to use | [optional] 
 **ct** | [**CancellationToken**](.md)|  | [optional] 

### Return type

void (empty response body)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getidentityproviderprovider"></a>
# **GetIdentityProviderProvider**
> Object GetIdentityProviderProvider (string realm, string providerId, CancellationToken ct)



Get the identity provider factory for that provider id

### Example
```csharp
using System;
using System.Diagnostics;
using ;
using Keycloak.Client;
using Keycloak.Client.Models;

namespace Example
{
    public class GetIdentityProviderProviderExample
    {
        public void main()
        {
            var apiInstance = new IdentityProvidersApi(new HttpClient(), "http://my-service.srv");
            var realm = realm_example;  // string | realm name (not id!)
            var providerId = providerId_example;  // string | The provider id to get the factory
            var ct = new CancellationToken(); // CancellationToken |  (optional) 

            try
            {
                Object result = apiInstance.GetIdentityProviderProvider(realm, providerId, ct);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling IdentityProvidersApi.GetIdentityProviderProvider: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **realm** | **string**| realm name (not id!) | 
 **providerId** | **string**| The provider id to get the factory | 
 **ct** | [**CancellationToken**](.md)|  | [optional] 

### Return type

**Object**

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getinstance"></a>
# **GetInstance**
> IdentityProviderRepresentation GetInstance (string realm, string alias, CancellationToken ct)



Get the identity provider

### Example
```csharp
using System;
using System.Diagnostics;
using ;
using Keycloak.Client;
using Keycloak.Client.Models;

namespace Example
{
    public class GetInstanceExample
    {
        public void main()
        {
            var apiInstance = new IdentityProvidersApi(new HttpClient(), "http://my-service.srv");
            var realm = realm_example;  // string | realm name (not id!)
            var alias = alias_example;  // string | 
            var ct = new CancellationToken(); // CancellationToken |  (optional) 

            try
            {
                IdentityProviderRepresentation result = apiInstance.GetInstance(realm, alias, ct);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling IdentityProvidersApi.GetInstance: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **realm** | **string**| realm name (not id!) | 
 **alias** | **string**|  | 
 **ct** | [**CancellationToken**](.md)|  | [optional] 

### Return type

[**IdentityProviderRepresentation**](IdentityProviderRepresentation.md)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getinstancemanagementpermissions"></a>
# **GetInstanceManagementPermissions**
> ManagementPermissionReference GetInstanceManagementPermissions (string realm, string alias, CancellationToken ct)



Return object stating whether client Authorization permissions have been initialized or not and a reference

### Example
```csharp
using System;
using System.Diagnostics;
using ;
using Keycloak.Client;
using Keycloak.Client.Models;

namespace Example
{
    public class GetInstanceManagementPermissionsExample
    {
        public void main()
        {
            var apiInstance = new IdentityProvidersApi(new HttpClient(), "http://my-service.srv");
            var realm = realm_example;  // string | realm name (not id!)
            var alias = alias_example;  // string | 
            var ct = new CancellationToken(); // CancellationToken |  (optional) 

            try
            {
                ManagementPermissionReference result = apiInstance.GetInstanceManagementPermissions(realm, alias, ct);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling IdentityProvidersApi.GetInstanceManagementPermissions: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **realm** | **string**| realm name (not id!) | 
 **alias** | **string**|  | 
 **ct** | [**CancellationToken**](.md)|  | [optional] 

### Return type

[**ManagementPermissionReference**](ManagementPermissionReference.md)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getinstances"></a>
# **GetInstances**
> List<IdentityProviderRepresentation> GetInstances (string realm, string briefRepresentation, string first, string max, string search, CancellationToken ct)



List identity providers

### Example
```csharp
using System;
using System.Diagnostics;
using ;
using Keycloak.Client;
using Keycloak.Client.Models;

namespace Example
{
    public class GetInstancesExample
    {
        public void main()
        {
            var apiInstance = new IdentityProvidersApi(new HttpClient(), "http://my-service.srv");
            var realm = realm_example;  // string | realm name (not id!)
            var briefRepresentation = briefRepresentation_example;  // string | Boolean which defines whether brief representations are returned (default: false) (optional) 
            var first = first_example;  // string | Pagination offset (optional) 
            var max = max_example;  // string | Maximum results size (defaults to 100) (optional) 
            var search = search_example;  // string | Filter specific providers by name. Search can be prefix (name*), contains (name) or exact (&quot;name&quot;). Default prefixed. (optional) 
            var ct = new CancellationToken(); // CancellationToken |  (optional) 

            try
            {
                List&lt;IdentityProviderRepresentation&gt; result = apiInstance.GetInstances(realm, briefRepresentation, first, max, search, ct);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling IdentityProvidersApi.GetInstances: " + e.Message );
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
 **first** | **string**| Pagination offset | [optional] 
 **max** | **string**| Maximum results size (defaults to 100) | [optional] 
 **search** | **string**| Filter specific providers by name. Search can be prefix (name*), contains (name) or exact (&amp;quot;name&amp;quot;). Default prefixed. | [optional] 
 **ct** | [**CancellationToken**](.md)|  | [optional] 

### Return type

[**List<IdentityProviderRepresentation>**](IdentityProviderRepresentation.md)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getmapper"></a>
# **GetMapper**
> IdentityProviderMapperRepresentation GetMapper (string realm, string alias, string id, CancellationToken ct)



Get mapper by id for the identity provider

### Example
```csharp
using System;
using System.Diagnostics;
using ;
using Keycloak.Client;
using Keycloak.Client.Models;

namespace Example
{
    public class GetMapperExample
    {
        public void main()
        {
            var apiInstance = new IdentityProvidersApi(new HttpClient(), "http://my-service.srv");
            var realm = realm_example;  // string | realm name (not id!)
            var alias = alias_example;  // string | 
            var id = id_example;  // string | Mapper id
            var ct = new CancellationToken(); // CancellationToken |  (optional) 

            try
            {
                IdentityProviderMapperRepresentation result = apiInstance.GetMapper(realm, alias, id, ct);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling IdentityProvidersApi.GetMapper: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **realm** | **string**| realm name (not id!) | 
 **alias** | **string**|  | 
 **id** | **string**| Mapper id | 
 **ct** | [**CancellationToken**](.md)|  | [optional] 

### Return type

[**IdentityProviderMapperRepresentation**](IdentityProviderMapperRepresentation.md)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getmappertypes"></a>
# **GetMapperTypes**
> Dictionary<string, IdentityProviderMapperTypeRepresentation> GetMapperTypes (string realm, string alias, CancellationToken ct)



Get mapper types for identity provider

### Example
```csharp
using System;
using System.Diagnostics;
using ;
using Keycloak.Client;
using Keycloak.Client.Models;

namespace Example
{
    public class GetMapperTypesExample
    {
        public void main()
        {
            var apiInstance = new IdentityProvidersApi(new HttpClient(), "http://my-service.srv");
            var realm = realm_example;  // string | realm name (not id!)
            var alias = alias_example;  // string | 
            var ct = new CancellationToken(); // CancellationToken |  (optional) 

            try
            {
                Dictionary&lt;string, IdentityProviderMapperTypeRepresentation&gt; result = apiInstance.GetMapperTypes(realm, alias, ct);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling IdentityProvidersApi.GetMapperTypes: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **realm** | **string**| realm name (not id!) | 
 **alias** | **string**|  | 
 **ct** | [**CancellationToken**](.md)|  | [optional] 

### Return type

[**Dictionary<string, IdentityProviderMapperTypeRepresentation>**](IdentityProviderMapperTypeRepresentation.md)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: */*

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getmappers"></a>
# **GetMappers**
> List<IdentityProviderMapperRepresentation> GetMappers (string realm, string alias, CancellationToken ct)



Get mappers for identity provider

### Example
```csharp
using System;
using System.Diagnostics;
using ;
using Keycloak.Client;
using Keycloak.Client.Models;

namespace Example
{
    public class GetMappersExample
    {
        public void main()
        {
            var apiInstance = new IdentityProvidersApi(new HttpClient(), "http://my-service.srv");
            var realm = realm_example;  // string | realm name (not id!)
            var alias = alias_example;  // string | 
            var ct = new CancellationToken(); // CancellationToken |  (optional) 

            try
            {
                List&lt;IdentityProviderMapperRepresentation&gt; result = apiInstance.GetMappers(realm, alias, ct);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling IdentityProvidersApi.GetMappers: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **realm** | **string**| realm name (not id!) | 
 **alias** | **string**|  | 
 **ct** | [**CancellationToken**](.md)|  | [optional] 

### Return type

[**List<IdentityProviderMapperRepresentation>**](IdentityProviderMapperRepresentation.md)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="postimportconfig"></a>
# **PostImportConfig**
> Dictionary<string, string> PostImportConfig (string realm, Object body, CancellationToken ct)



Import identity provider from JSON body

### Example
```csharp
using System;
using System.Diagnostics;
using ;
using Keycloak.Client;
using Keycloak.Client.Models;

namespace Example
{
    public class PostImportConfigExample
    {
        public void main()
        {
            var apiInstance = new IdentityProvidersApi(new HttpClient(), "http://my-service.srv");
            var realm = realm_example;  // string | realm name (not id!)
            var body = new Object(); // Object | [AnyType] (optional) 
            var ct = new CancellationToken(); // CancellationToken |  (optional) 

            try
            {
                Dictionary&lt;string, string&gt; result = apiInstance.PostImportConfig(realm, body, ct);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling IdentityProvidersApi.PostImportConfig: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **realm** | **string**| realm name (not id!) | 
 **body** | [**Object**](Object.md)| [AnyType] | [optional] 
 **ct** | [**CancellationToken**](.md)|  | [optional] 

### Return type

**Dictionary<string, string>**

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="postinstances"></a>
# **PostInstances**
> void PostInstances (string realm, IdentityProviderRepresentation body, CancellationToken ct)



Create a new identity provider

### Example
```csharp
using System;
using System.Diagnostics;
using ;
using Keycloak.Client;
using Keycloak.Client.Models;

namespace Example
{
    public class PostInstancesExample
    {
        public void main()
        {
            var apiInstance = new IdentityProvidersApi(new HttpClient(), "http://my-service.srv");
            var realm = realm_example;  // string | realm name (not id!)
            var body = new IdentityProviderRepresentation(); // IdentityProviderRepresentation | IdentityProviderRepresentation (optional) 
            var ct = new CancellationToken(); // CancellationToken |  (optional) 

            try
            {
                apiInstance.PostInstances(realm, body, ct);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling IdentityProvidersApi.PostInstances: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **realm** | **string**| realm name (not id!) | 
 **body** | [**IdentityProviderRepresentation**](IdentityProviderRepresentation.md)| IdentityProviderRepresentation | [optional] 
 **ct** | [**CancellationToken**](.md)|  | [optional] 

### Return type

void (empty response body)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="postmappers"></a>
# **PostMappers**
> void PostMappers (string realm, string alias, IdentityProviderMapperRepresentation body, CancellationToken ct)



Add a mapper to identity provider

### Example
```csharp
using System;
using System.Diagnostics;
using ;
using Keycloak.Client;
using Keycloak.Client.Models;

namespace Example
{
    public class PostMappersExample
    {
        public void main()
        {
            var apiInstance = new IdentityProvidersApi(new HttpClient(), "http://my-service.srv");
            var realm = realm_example;  // string | realm name (not id!)
            var alias = alias_example;  // string | 
            var body = new IdentityProviderMapperRepresentation(); // IdentityProviderMapperRepresentation | IdentityProviderMapperRepresentation (optional) 
            var ct = new CancellationToken(); // CancellationToken |  (optional) 

            try
            {
                apiInstance.PostMappers(realm, alias, body, ct);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling IdentityProvidersApi.PostMappers: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **realm** | **string**| realm name (not id!) | 
 **alias** | **string**|  | 
 **body** | [**IdentityProviderMapperRepresentation**](IdentityProviderMapperRepresentation.md)| IdentityProviderMapperRepresentation | [optional] 
 **ct** | [**CancellationToken**](.md)|  | [optional] 

### Return type

void (empty response body)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="putinstance"></a>
# **PutInstance**
> void PutInstance (string realm, string alias, IdentityProviderRepresentation body, CancellationToken ct)



Update the identity provider

### Example
```csharp
using System;
using System.Diagnostics;
using ;
using Keycloak.Client;
using Keycloak.Client.Models;

namespace Example
{
    public class PutInstanceExample
    {
        public void main()
        {
            var apiInstance = new IdentityProvidersApi(new HttpClient(), "http://my-service.srv");
            var realm = realm_example;  // string | realm name (not id!)
            var alias = alias_example;  // string | 
            var body = new IdentityProviderRepresentation(); // IdentityProviderRepresentation | IdentityProviderRepresentation (optional) 
            var ct = new CancellationToken(); // CancellationToken |  (optional) 

            try
            {
                apiInstance.PutInstance(realm, alias, body, ct);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling IdentityProvidersApi.PutInstance: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **realm** | **string**| realm name (not id!) | 
 **alias** | **string**|  | 
 **body** | [**IdentityProviderRepresentation**](IdentityProviderRepresentation.md)| IdentityProviderRepresentation | [optional] 
 **ct** | [**CancellationToken**](.md)|  | [optional] 

### Return type

void (empty response body)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="putinstancemanagementpermissions"></a>
# **PutInstanceManagementPermissions**
> ManagementPermissionReference PutInstanceManagementPermissions (string realm, string alias, ManagementPermissionReference body, CancellationToken ct)



Return object stating whether client Authorization permissions have been initialized or not and a reference

### Example
```csharp
using System;
using System.Diagnostics;
using ;
using Keycloak.Client;
using Keycloak.Client.Models;

namespace Example
{
    public class PutInstanceManagementPermissionsExample
    {
        public void main()
        {
            var apiInstance = new IdentityProvidersApi(new HttpClient(), "http://my-service.srv");
            var realm = realm_example;  // string | realm name (not id!)
            var alias = alias_example;  // string | 
            var body = new ManagementPermissionReference(); // ManagementPermissionReference | ManagementPermissionReference (optional) 
            var ct = new CancellationToken(); // CancellationToken |  (optional) 

            try
            {
                ManagementPermissionReference result = apiInstance.PutInstanceManagementPermissions(realm, alias, body, ct);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling IdentityProvidersApi.PutInstanceManagementPermissions: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **realm** | **string**| realm name (not id!) | 
 **alias** | **string**|  | 
 **body** | [**ManagementPermissionReference**](ManagementPermissionReference.md)| ManagementPermissionReference | [optional] 
 **ct** | [**CancellationToken**](.md)|  | [optional] 

### Return type

[**ManagementPermissionReference**](ManagementPermissionReference.md)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="putmapper"></a>
# **PutMapper**
> void PutMapper (string realm, string alias, string id, IdentityProviderMapperRepresentation body, CancellationToken ct)



Update a mapper for the identity provider

### Example
```csharp
using System;
using System.Diagnostics;
using ;
using Keycloak.Client;
using Keycloak.Client.Models;

namespace Example
{
    public class PutMapperExample
    {
        public void main()
        {
            var apiInstance = new IdentityProvidersApi(new HttpClient(), "http://my-service.srv");
            var realm = realm_example;  // string | realm name (not id!)
            var alias = alias_example;  // string | 
            var id = id_example;  // string | Mapper id
            var body = new IdentityProviderMapperRepresentation(); // IdentityProviderMapperRepresentation | IdentityProviderMapperRepresentation (optional) 
            var ct = new CancellationToken(); // CancellationToken |  (optional) 

            try
            {
                apiInstance.PutMapper(realm, alias, id, body, ct);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling IdentityProvidersApi.PutMapper: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **realm** | **string**| realm name (not id!) | 
 **alias** | **string**|  | 
 **id** | **string**| Mapper id | 
 **body** | [**IdentityProviderMapperRepresentation**](IdentityProviderMapperRepresentation.md)| IdentityProviderMapperRepresentation | [optional] 
 **ct** | [**CancellationToken**](.md)|  | [optional] 

### Return type

void (empty response body)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

