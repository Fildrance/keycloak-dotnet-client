# IO.Swagger.Api.ClientScopesApi

All URIs are relative to *https://keycloak.example.com/admin/realms*

Method | HTTP request | Description
------------- | ------------- | -------------
[**DeleteClientScope**](ClientScopesApi.md#deleteclientscope) | **DELETE** /{realm}/client-scopes/{id} | 
[**DeleteClientTemplate**](ClientScopesApi.md#deleteclienttemplate) | **DELETE** /{realm}/client-templates/{id} | 
[**GetClientScope**](ClientScopesApi.md#getclientscope) | **GET** /{realm}/client-scopes/{id} | 
[**GetClientScopes**](ClientScopesApi.md#getclientscopes) | **GET** /{realm}/client-scopes | 
[**GetClientTemplate**](ClientScopesApi.md#getclienttemplate) | **GET** /{realm}/client-templates/{id} | 
[**GetClientTemplates**](ClientScopesApi.md#getclienttemplates) | **GET** /{realm}/client-templates | 
[**PostClientScopes**](ClientScopesApi.md#postclientscopes) | **POST** /{realm}/client-scopes | 
[**PostClientTemplates**](ClientScopesApi.md#postclienttemplates) | **POST** /{realm}/client-templates | 
[**PutClientScope**](ClientScopesApi.md#putclientscope) | **PUT** /{realm}/client-scopes/{id} | 
[**PutClientTemplate**](ClientScopesApi.md#putclienttemplate) | **PUT** /{realm}/client-templates/{id} | 

<a name="deleteclientscope"></a>
# **DeleteClientScope**
> void DeleteClientScope (string realm, string id)



Delete the client scope

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class DeleteClientScopeExample
    {
        public void main()
        {


            var apiInstance = new ClientScopesApi();
            var realm = realm_example;  // string | realm name (not id!)
            var id = id_example;  // string | 

            try
            {
                apiInstance.DeleteClientScope(realm, id);
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

### Return type

void (empty response body)

### Authorization

[access_token](../README.md#access_token)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="deleteclienttemplate"></a>
# **DeleteClientTemplate**
> void DeleteClientTemplate (string realm, string id)



Delete the client scope

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class DeleteClientTemplateExample
    {
        public void main()
        {


            var apiInstance = new ClientScopesApi();
            var realm = realm_example;  // string | realm name (not id!)
            var id = id_example;  // string | 

            try
            {
                apiInstance.DeleteClientTemplate(realm, id);
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

### Return type

void (empty response body)

### Authorization

[access_token](../README.md#access_token)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getclientscope"></a>
# **GetClientScope**
> ClientScopeRepresentation GetClientScope (string realm, string id)



Get representation of the client scope

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class GetClientScopeExample
    {
        public void main()
        {


            var apiInstance = new ClientScopesApi();
            var realm = realm_example;  // string | realm name (not id!)
            var id = id_example;  // string | 

            try
            {
                ClientScopeRepresentation result = apiInstance.GetClientScope(realm, id);
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

### Return type

[**ClientScopeRepresentation**](ClientScopeRepresentation.md)

### Authorization

[access_token](../README.md#access_token)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getclientscopes"></a>
# **GetClientScopes**
> List<ClientScopeRepresentation> GetClientScopes (string realm)



Get client scopes belonging to the realm Returns a list of client scopes belonging to the realm

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class GetClientScopesExample
    {
        public void main()
        {


            var apiInstance = new ClientScopesApi();
            var realm = realm_example;  // string | realm name (not id!)

            try
            {
                List&lt;ClientScopeRepresentation&gt; result = apiInstance.GetClientScopes(realm);
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

### Return type

[**List<ClientScopeRepresentation>**](ClientScopeRepresentation.md)

### Authorization

[access_token](../README.md#access_token)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getclienttemplate"></a>
# **GetClientTemplate**
> ClientScopeRepresentation GetClientTemplate (string realm, string id)



Get representation of the client scope

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class GetClientTemplateExample
    {
        public void main()
        {


            var apiInstance = new ClientScopesApi();
            var realm = realm_example;  // string | realm name (not id!)
            var id = id_example;  // string | 

            try
            {
                ClientScopeRepresentation result = apiInstance.GetClientTemplate(realm, id);
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

### Return type

[**ClientScopeRepresentation**](ClientScopeRepresentation.md)

### Authorization

[access_token](../README.md#access_token)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getclienttemplates"></a>
# **GetClientTemplates**
> List<ClientScopeRepresentation> GetClientTemplates (string realm)



Get client scopes belonging to the realm Returns a list of client scopes belonging to the realm

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class GetClientTemplatesExample
    {
        public void main()
        {


            var apiInstance = new ClientScopesApi();
            var realm = realm_example;  // string | realm name (not id!)

            try
            {
                List&lt;ClientScopeRepresentation&gt; result = apiInstance.GetClientTemplates(realm);
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

### Return type

[**List<ClientScopeRepresentation>**](ClientScopeRepresentation.md)

### Authorization

[access_token](../README.md#access_token)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="postclientscopes"></a>
# **PostClientScopes**
> void PostClientScopes (string realm, ClientScopeRepresentation body)



Create a new client scope Client Scope’s name must be unique!

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class PostClientScopesExample
    {
        public void main()
        {


            var apiInstance = new ClientScopesApi();
            var realm = realm_example;  // string | realm name (not id!)
            var body = new ClientScopeRepresentation(); // ClientScopeRepresentation | ClientScopeRepresentation (optional) 

            try
            {
                apiInstance.PostClientScopes(realm, body);
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

### Return type

void (empty response body)

### Authorization

[access_token](../README.md#access_token)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="postclienttemplates"></a>
# **PostClientTemplates**
> void PostClientTemplates (string realm, ClientScopeRepresentation body)



Create a new client scope Client Scope’s name must be unique!

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class PostClientTemplatesExample
    {
        public void main()
        {


            var apiInstance = new ClientScopesApi();
            var realm = realm_example;  // string | realm name (not id!)
            var body = new ClientScopeRepresentation(); // ClientScopeRepresentation | ClientScopeRepresentation (optional) 

            try
            {
                apiInstance.PostClientTemplates(realm, body);
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

### Return type

void (empty response body)

### Authorization

[access_token](../README.md#access_token)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="putclientscope"></a>
# **PutClientScope**
> void PutClientScope (string realm, string id, ClientScopeRepresentation body)



Update the client scope

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class PutClientScopeExample
    {
        public void main()
        {


            var apiInstance = new ClientScopesApi();
            var realm = realm_example;  // string | realm name (not id!)
            var id = id_example;  // string | 
            var body = new ClientScopeRepresentation(); // ClientScopeRepresentation | ClientScopeRepresentation (optional) 

            try
            {
                apiInstance.PutClientScope(realm, id, body);
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

### Return type

void (empty response body)

### Authorization

[access_token](../README.md#access_token)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="putclienttemplate"></a>
# **PutClientTemplate**
> void PutClientTemplate (string realm, string id, ClientScopeRepresentation body)



Update the client scope

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class PutClientTemplateExample
    {
        public void main()
        {


            var apiInstance = new ClientScopesApi();
            var realm = realm_example;  // string | realm name (not id!)
            var id = id_example;  // string | 
            var body = new ClientScopeRepresentation(); // ClientScopeRepresentation | ClientScopeRepresentation (optional) 

            try
            {
                apiInstance.PutClientTemplate(realm, id, body);
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

### Return type

void (empty response body)

### Authorization

[access_token](../README.md#access_token)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

