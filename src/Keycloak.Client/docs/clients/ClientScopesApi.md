# .ClientScopesApi

All URIs are relative to *https://keycloak.example.com/admin/realms*

Method | HTTP request | Description
------------- | ------------- | -------------
[**DeleteClientScope**](ClientScopesApi.md#deleteclientscope) | **Delete** /{realm}/client-scopes/{id} | 
[**DeleteClientTemplate**](ClientScopesApi.md#deleteclienttemplate) | **Delete** /{realm}/client-templates/{id} | 
[**GetClientScope**](ClientScopesApi.md#getclientscope) | **Get** /{realm}/client-scopes/{id} | 
[**GetClientScopes**](ClientScopesApi.md#getclientscopes) | **Get** /{realm}/client-scopes | 
[**GetClientTemplate**](ClientScopesApi.md#getclienttemplate) | **Get** /{realm}/client-templates/{id} | 
[**GetClientTemplates**](ClientScopesApi.md#getclienttemplates) | **Get** /{realm}/client-templates | 
[**PostClientScopes**](ClientScopesApi.md#postclientscopes) | **Post** /{realm}/client-scopes | 
[**PostClientTemplates**](ClientScopesApi.md#postclienttemplates) | **Post** /{realm}/client-templates | 
[**PutClientScope**](ClientScopesApi.md#putclientscope) | **Put** /{realm}/client-scopes/{id} | 
[**PutClientTemplate**](ClientScopesApi.md#putclienttemplate) | **Put** /{realm}/client-templates/{id} | 


<a name="deleteclientscope"></a>
# **DeleteClientScope**
> void DeleteClientScope (string realm, string id, CancellationToken ct)



Delete the client scope

### Example
```csharp
using System;
using System.Diagnostics;
using ;
using Keycloak.Client;
using Keycloak.Client.Models;

namespace Example
{
    public class DeleteClientScopeExample
    {
        public void main()
        {
            var apiInstance = new ClientScopesApi(new HttpClient(), "http://my-service.srv");
            var realm = realm_example;  // string | realm name (not id!)
            var id = id_example;  // string | 
            var ct = new CancellationToken(); // CancellationToken |  (optional) 

            try
            {
                apiInstance.DeleteClientScope(realm, id, ct);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ClientScopesApi.DeleteClientScope: " + e.Message );
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

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="deleteclienttemplate"></a>
# **DeleteClientTemplate**
> void DeleteClientTemplate (string realm, string id, CancellationToken ct)



Delete the client scope

### Example
```csharp
using System;
using System.Diagnostics;
using ;
using Keycloak.Client;
using Keycloak.Client.Models;

namespace Example
{
    public class DeleteClientTemplateExample
    {
        public void main()
        {
            var apiInstance = new ClientScopesApi(new HttpClient(), "http://my-service.srv");
            var realm = realm_example;  // string | realm name (not id!)
            var id = id_example;  // string | 
            var ct = new CancellationToken(); // CancellationToken |  (optional) 

            try
            {
                apiInstance.DeleteClientTemplate(realm, id, ct);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ClientScopesApi.DeleteClientTemplate: " + e.Message );
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

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getclientscope"></a>
# **GetClientScope**
> ClientScopeRepresentation GetClientScope (string realm, string id, CancellationToken ct)



Get representation of the client scope

### Example
```csharp
using System;
using System.Diagnostics;
using ;
using Keycloak.Client;
using Keycloak.Client.Models;

namespace Example
{
    public class GetClientScopeExample
    {
        public void main()
        {
            var apiInstance = new ClientScopesApi(new HttpClient(), "http://my-service.srv");
            var realm = realm_example;  // string | realm name (not id!)
            var id = id_example;  // string | 
            var ct = new CancellationToken(); // CancellationToken |  (optional) 

            try
            {
                ClientScopeRepresentation result = apiInstance.GetClientScope(realm, id, ct);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ClientScopesApi.GetClientScope: " + e.Message );
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

[**ClientScopeRepresentation**](ClientScopeRepresentation.md)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getclientscopes"></a>
# **GetClientScopes**
> List<ClientScopeRepresentation> GetClientScopes (string realm, CancellationToken ct)



Get client scopes belonging to the realm Returns a list of client scopes belonging to the realm

### Example
```csharp
using System;
using System.Diagnostics;
using ;
using Keycloak.Client;
using Keycloak.Client.Models;

namespace Example
{
    public class GetClientScopesExample
    {
        public void main()
        {
            var apiInstance = new ClientScopesApi(new HttpClient(), "http://my-service.srv");
            var realm = realm_example;  // string | realm name (not id!)
            var ct = new CancellationToken(); // CancellationToken |  (optional) 

            try
            {
                List&lt;ClientScopeRepresentation&gt; result = apiInstance.GetClientScopes(realm, ct);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ClientScopesApi.GetClientScopes: " + e.Message );
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

[**List<ClientScopeRepresentation>**](ClientScopeRepresentation.md)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getclienttemplate"></a>
# **GetClientTemplate**
> ClientScopeRepresentation GetClientTemplate (string realm, string id, CancellationToken ct)



Get representation of the client scope

### Example
```csharp
using System;
using System.Diagnostics;
using ;
using Keycloak.Client;
using Keycloak.Client.Models;

namespace Example
{
    public class GetClientTemplateExample
    {
        public void main()
        {
            var apiInstance = new ClientScopesApi(new HttpClient(), "http://my-service.srv");
            var realm = realm_example;  // string | realm name (not id!)
            var id = id_example;  // string | 
            var ct = new CancellationToken(); // CancellationToken |  (optional) 

            try
            {
                ClientScopeRepresentation result = apiInstance.GetClientTemplate(realm, id, ct);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ClientScopesApi.GetClientTemplate: " + e.Message );
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

[**ClientScopeRepresentation**](ClientScopeRepresentation.md)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getclienttemplates"></a>
# **GetClientTemplates**
> List<ClientScopeRepresentation> GetClientTemplates (string realm, CancellationToken ct)



Get client scopes belonging to the realm Returns a list of client scopes belonging to the realm

### Example
```csharp
using System;
using System.Diagnostics;
using ;
using Keycloak.Client;
using Keycloak.Client.Models;

namespace Example
{
    public class GetClientTemplatesExample
    {
        public void main()
        {
            var apiInstance = new ClientScopesApi(new HttpClient(), "http://my-service.srv");
            var realm = realm_example;  // string | realm name (not id!)
            var ct = new CancellationToken(); // CancellationToken |  (optional) 

            try
            {
                List&lt;ClientScopeRepresentation&gt; result = apiInstance.GetClientTemplates(realm, ct);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ClientScopesApi.GetClientTemplates: " + e.Message );
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

[**List<ClientScopeRepresentation>**](ClientScopeRepresentation.md)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="postclientscopes"></a>
# **PostClientScopes**
> void PostClientScopes (string realm, ClientScopeRepresentation body, CancellationToken ct)



Create a new client scope Client Scope’s name must be unique!

### Example
```csharp
using System;
using System.Diagnostics;
using ;
using Keycloak.Client;
using Keycloak.Client.Models;

namespace Example
{
    public class PostClientScopesExample
    {
        public void main()
        {
            var apiInstance = new ClientScopesApi(new HttpClient(), "http://my-service.srv");
            var realm = realm_example;  // string | realm name (not id!)
            var body = new ClientScopeRepresentation(); // ClientScopeRepresentation | ClientScopeRepresentation (optional) 
            var ct = new CancellationToken(); // CancellationToken |  (optional) 

            try
            {
                apiInstance.PostClientScopes(realm, body, ct);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ClientScopesApi.PostClientScopes: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **realm** | **string**| realm name (not id!) | 
 **body** | [**ClientScopeRepresentation**](ClientScopeRepresentation.md)| ClientScopeRepresentation | [optional] 
 **ct** | [**CancellationToken**](.md)|  | [optional] 

### Return type

void (empty response body)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="postclienttemplates"></a>
# **PostClientTemplates**
> void PostClientTemplates (string realm, ClientScopeRepresentation body, CancellationToken ct)



Create a new client scope Client Scope’s name must be unique!

### Example
```csharp
using System;
using System.Diagnostics;
using ;
using Keycloak.Client;
using Keycloak.Client.Models;

namespace Example
{
    public class PostClientTemplatesExample
    {
        public void main()
        {
            var apiInstance = new ClientScopesApi(new HttpClient(), "http://my-service.srv");
            var realm = realm_example;  // string | realm name (not id!)
            var body = new ClientScopeRepresentation(); // ClientScopeRepresentation | ClientScopeRepresentation (optional) 
            var ct = new CancellationToken(); // CancellationToken |  (optional) 

            try
            {
                apiInstance.PostClientTemplates(realm, body, ct);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ClientScopesApi.PostClientTemplates: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **realm** | **string**| realm name (not id!) | 
 **body** | [**ClientScopeRepresentation**](ClientScopeRepresentation.md)| ClientScopeRepresentation | [optional] 
 **ct** | [**CancellationToken**](.md)|  | [optional] 

### Return type

void (empty response body)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="putclientscope"></a>
# **PutClientScope**
> void PutClientScope (string realm, string id, ClientScopeRepresentation body, CancellationToken ct)



Update the client scope

### Example
```csharp
using System;
using System.Diagnostics;
using ;
using Keycloak.Client;
using Keycloak.Client.Models;

namespace Example
{
    public class PutClientScopeExample
    {
        public void main()
        {
            var apiInstance = new ClientScopesApi(new HttpClient(), "http://my-service.srv");
            var realm = realm_example;  // string | realm name (not id!)
            var id = id_example;  // string | 
            var body = new ClientScopeRepresentation(); // ClientScopeRepresentation | ClientScopeRepresentation (optional) 
            var ct = new CancellationToken(); // CancellationToken |  (optional) 

            try
            {
                apiInstance.PutClientScope(realm, id, body, ct);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ClientScopesApi.PutClientScope: " + e.Message );
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
 **body** | [**ClientScopeRepresentation**](ClientScopeRepresentation.md)| ClientScopeRepresentation | [optional] 
 **ct** | [**CancellationToken**](.md)|  | [optional] 

### Return type

void (empty response body)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="putclienttemplate"></a>
# **PutClientTemplate**
> void PutClientTemplate (string realm, string id, ClientScopeRepresentation body, CancellationToken ct)



Update the client scope

### Example
```csharp
using System;
using System.Diagnostics;
using ;
using Keycloak.Client;
using Keycloak.Client.Models;

namespace Example
{
    public class PutClientTemplateExample
    {
        public void main()
        {
            var apiInstance = new ClientScopesApi(new HttpClient(), "http://my-service.srv");
            var realm = realm_example;  // string | realm name (not id!)
            var id = id_example;  // string | 
            var body = new ClientScopeRepresentation(); // ClientScopeRepresentation | ClientScopeRepresentation (optional) 
            var ct = new CancellationToken(); // CancellationToken |  (optional) 

            try
            {
                apiInstance.PutClientTemplate(realm, id, body, ct);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ClientScopesApi.PutClientTemplate: " + e.Message );
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
 **body** | [**ClientScopeRepresentation**](ClientScopeRepresentation.md)| ClientScopeRepresentation | [optional] 
 **ct** | [**CancellationToken**](.md)|  | [optional] 

### Return type

void (empty response body)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

