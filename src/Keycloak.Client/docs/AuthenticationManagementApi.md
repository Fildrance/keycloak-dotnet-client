# IO.Swagger.Api.AuthenticationManagementApi

All URIs are relative to *https://keycloak.example.com/admin/realms*

Method | HTTP request | Description
------------- | ------------- | -------------
[**DeleteConfig**](AuthenticationManagementApi.md#deleteconfig) | **Delete** /{realm}/authentication/config/{id} | 
[**DeleteExecution**](AuthenticationManagementApi.md#deleteexecution) | **Delete** /{realm}/authentication/executions/{executionId} | 
[**DeleteFlow**](AuthenticationManagementApi.md#deleteflow) | **Delete** /{realm}/authentication/flows/{id} | 
[**DeleteRequiredAction**](AuthenticationManagementApi.md#deleterequiredaction) | **Delete** /{realm}/authentication/required-actions/{alias} | 
[**GetAuthenticationConfig**](AuthenticationManagementApi.md#getauthenticationconfig) | **Get** /{realm}/authentication/config/{id} | 
[**GetAuthenticatorProviders**](AuthenticationManagementApi.md#getauthenticatorproviders) | **Get** /{realm}/authentication/authenticator-providers | 
[**GetClientAuthenticatorProviders**](AuthenticationManagementApi.md#getclientauthenticatorproviders) | **Get** /{realm}/authentication/client-authenticator-providers | 
[**GetConfigDescription**](AuthenticationManagementApi.md#getconfigdescription) | **Get** /{realm}/authentication/config-description/{providerId} | 
[**GetExecution**](AuthenticationManagementApi.md#getexecution) | **Get** /{realm}/authentication/executions/{executionId} | 
[**GetExecutionConfig**](AuthenticationManagementApi.md#getexecutionconfig) | **Get** /{realm}/authentication/executions/{executionId}/config/{id} | 
[**GetExecutions**](AuthenticationManagementApi.md#getexecutions) | **Get** /{realm}/authentication/flows/{flowAlias}/executions | 
[**GetFlow**](AuthenticationManagementApi.md#getflow) | **Get** /{realm}/authentication/flows/{id} | 
[**GetFlows**](AuthenticationManagementApi.md#getflows) | **Get** /{realm}/authentication/flows | 
[**GetFormActionProviders**](AuthenticationManagementApi.md#getformactionproviders) | **Get** /{realm}/authentication/form-action-providers | 
[**GetFormProviders**](AuthenticationManagementApi.md#getformproviders) | **Get** /{realm}/authentication/form-providers | 
[**GetPerClientConfigDescription**](AuthenticationManagementApi.md#getperclientconfigdescription) | **Get** /{realm}/authentication/per-client-config-description | 
[**GetRequiredAction**](AuthenticationManagementApi.md#getrequiredaction) | **Get** /{realm}/authentication/required-actions/{alias} | 
[**GetRequiredActions**](AuthenticationManagementApi.md#getrequiredactions) | **Get** /{realm}/authentication/required-actions | 
[**GetUnregisteredRequiredActions**](AuthenticationManagementApi.md#getunregisteredrequiredactions) | **Get** /{realm}/authentication/unregistered-required-actions | 
[**PostAuthenticationConfig**](AuthenticationManagementApi.md#postauthenticationconfig) | **Post** /{realm}/authentication/config | 
[**PostCopy**](AuthenticationManagementApi.md#postcopy) | **Post** /{realm}/authentication/flows/{flowAlias}/copy | 
[**PostExecution**](AuthenticationManagementApi.md#postexecution) | **Post** /{realm}/authentication/flows/{flowAlias}/executions/execution | 
[**PostExecutionConfig**](AuthenticationManagementApi.md#postexecutionconfig) | **Post** /{realm}/authentication/executions/{executionId}/config | 
[**PostExecutionLowerPriority**](AuthenticationManagementApi.md#postexecutionlowerpriority) | **Post** /{realm}/authentication/executions/{executionId}/lower-priority | 
[**PostExecutionRaisePriority**](AuthenticationManagementApi.md#postexecutionraisepriority) | **Post** /{realm}/authentication/executions/{executionId}/raise-priority | 
[**PostExecutions**](AuthenticationManagementApi.md#postexecutions) | **Post** /{realm}/authentication/executions | 
[**PostFlow**](AuthenticationManagementApi.md#postflow) | **Post** /{realm}/authentication/flows/{flowAlias}/executions/flow | 
[**PostFlows**](AuthenticationManagementApi.md#postflows) | **Post** /{realm}/authentication/flows | 
[**PostRegisterRequiredAction**](AuthenticationManagementApi.md#postregisterrequiredaction) | **Post** /{realm}/authentication/register-required-action | 
[**PostRequiredActionLowerPriority**](AuthenticationManagementApi.md#postrequiredactionlowerpriority) | **Post** /{realm}/authentication/required-actions/{alias}/lower-priority | 
[**PostRequiredActionRaisePriority**](AuthenticationManagementApi.md#postrequiredactionraisepriority) | **Post** /{realm}/authentication/required-actions/{alias}/raise-priority | 
[**PutAuthenticationConfig**](AuthenticationManagementApi.md#putauthenticationconfig) | **Put** /{realm}/authentication/config/{id} | 
[**PutExecutions**](AuthenticationManagementApi.md#putexecutions) | **Put** /{realm}/authentication/flows/{flowAlias}/executions | 
[**PutFlow**](AuthenticationManagementApi.md#putflow) | **Put** /{realm}/authentication/flows/{id} | 
[**PutRequiredAction**](AuthenticationManagementApi.md#putrequiredaction) | **Put** /{realm}/authentication/required-actions/{alias} | 


<a name="deleteconfig"></a>
# **DeleteConfig**
> void DeleteConfig (string realm, string id, CancellationToken ct)



Delete authenticator configuration

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class DeleteConfigExample
    {
        public void main()
        {
            

            var apiInstance = new AuthenticationManagementApi();
            var realm = realm_example;  // string | realm name (not id!)
            var id = id_example;  // string | Configuration id
            var ct = new CancellationToken(); // CancellationToken |  (optional) 

            try
            {
                apiInstance.DeleteConfig(realm, id, ct);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AuthenticationManagementApi.DeleteConfig: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **realm** | **string**| realm name (not id!) | 
 **id** | **string**| Configuration id | 
 **ct** | [**CancellationToken**](.md)|  | [optional] 

### Return type

void (empty response body)

### Authorization

[access_token](../README.md#access_token)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="deleteexecution"></a>
# **DeleteExecution**
> void DeleteExecution (string realm, string executionId, CancellationToken ct)



Delete execution

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class DeleteExecutionExample
    {
        public void main()
        {
            

            var apiInstance = new AuthenticationManagementApi();
            var realm = realm_example;  // string | realm name (not id!)
            var executionId = executionId_example;  // string | 
            var ct = new CancellationToken(); // CancellationToken |  (optional) 

            try
            {
                apiInstance.DeleteExecution(realm, executionId, ct);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AuthenticationManagementApi.DeleteExecution: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **realm** | **string**| realm name (not id!) | 
 **executionId** | **string**|  | 
 **ct** | [**CancellationToken**](.md)|  | [optional] 

### Return type

void (empty response body)

### Authorization

[access_token](../README.md#access_token)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="deleteflow"></a>
# **DeleteFlow**
> void DeleteFlow (string realm, string id, CancellationToken ct)



Delete an authentication flow

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class DeleteFlowExample
    {
        public void main()
        {
            

            var apiInstance = new AuthenticationManagementApi();
            var realm = realm_example;  // string | realm name (not id!)
            var id = id_example;  // string | 
            var ct = new CancellationToken(); // CancellationToken |  (optional) 

            try
            {
                apiInstance.DeleteFlow(realm, id, ct);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AuthenticationManagementApi.DeleteFlow: " + e.Message );
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

<a name="deleterequiredaction"></a>
# **DeleteRequiredAction**
> void DeleteRequiredAction (string realm, string alias, CancellationToken ct)



Delete required action

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class DeleteRequiredActionExample
    {
        public void main()
        {
            

            var apiInstance = new AuthenticationManagementApi();
            var realm = realm_example;  // string | realm name (not id!)
            var alias = alias_example;  // string | Alias of required action
            var ct = new CancellationToken(); // CancellationToken |  (optional) 

            try
            {
                apiInstance.DeleteRequiredAction(realm, alias, ct);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AuthenticationManagementApi.DeleteRequiredAction: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **realm** | **string**| realm name (not id!) | 
 **alias** | **string**| Alias of required action | 
 **ct** | [**CancellationToken**](.md)|  | [optional] 

### Return type

void (empty response body)

### Authorization

[access_token](../README.md#access_token)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getauthenticationconfig"></a>
# **GetAuthenticationConfig**
> AuthenticatorConfigRepresentation GetAuthenticationConfig (string realm, string id, CancellationToken ct)



Get authenticator configuration

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class GetAuthenticationConfigExample
    {
        public void main()
        {
            

            var apiInstance = new AuthenticationManagementApi();
            var realm = realm_example;  // string | realm name (not id!)
            var id = id_example;  // string | Configuration id
            var ct = new CancellationToken(); // CancellationToken |  (optional) 

            try
            {
                AuthenticatorConfigRepresentation result = apiInstance.GetAuthenticationConfig(realm, id, ct);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AuthenticationManagementApi.GetAuthenticationConfig: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **realm** | **string**| realm name (not id!) | 
 **id** | **string**| Configuration id | 
 **ct** | [**CancellationToken**](.md)|  | [optional] 

### Return type

[**AuthenticatorConfigRepresentation**](AuthenticatorConfigRepresentation.md)

### Authorization

[access_token](../README.md#access_token)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getauthenticatorproviders"></a>
# **GetAuthenticatorProviders**
> List<Object> GetAuthenticatorProviders (string realm, CancellationToken ct)



Get authenticator providers Returns a stream of authenticator providers.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class GetAuthenticatorProvidersExample
    {
        public void main()
        {
            

            var apiInstance = new AuthenticationManagementApi();
            var realm = realm_example;  // string | realm name (not id!)
            var ct = new CancellationToken(); // CancellationToken |  (optional) 

            try
            {
                List&lt;Object&gt; result = apiInstance.GetAuthenticatorProviders(realm, ct);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AuthenticationManagementApi.GetAuthenticatorProviders: " + e.Message );
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

**List<Object>**

### Authorization

[access_token](../README.md#access_token)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getclientauthenticatorproviders"></a>
# **GetClientAuthenticatorProviders**
> List<Object> GetClientAuthenticatorProviders (string realm, CancellationToken ct)



Get client authenticator providers Returns a stream of client authenticator providers.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class GetClientAuthenticatorProvidersExample
    {
        public void main()
        {
            

            var apiInstance = new AuthenticationManagementApi();
            var realm = realm_example;  // string | realm name (not id!)
            var ct = new CancellationToken(); // CancellationToken |  (optional) 

            try
            {
                List&lt;Object&gt; result = apiInstance.GetClientAuthenticatorProviders(realm, ct);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AuthenticationManagementApi.GetClientAuthenticatorProviders: " + e.Message );
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

**List<Object>**

### Authorization

[access_token](../README.md#access_token)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getconfigdescription"></a>
# **GetConfigDescription**
> AuthenticatorConfigInfoRepresentation GetConfigDescription (string realm, string providerId, CancellationToken ct)



Get authenticator provider’s configuration description

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class GetConfigDescriptionExample
    {
        public void main()
        {
            

            var apiInstance = new AuthenticationManagementApi();
            var realm = realm_example;  // string | realm name (not id!)
            var providerId = providerId_example;  // string | 
            var ct = new CancellationToken(); // CancellationToken |  (optional) 

            try
            {
                AuthenticatorConfigInfoRepresentation result = apiInstance.GetConfigDescription(realm, providerId, ct);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AuthenticationManagementApi.GetConfigDescription: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **realm** | **string**| realm name (not id!) | 
 **providerId** | **string**|  | 
 **ct** | [**CancellationToken**](.md)|  | [optional] 

### Return type

[**AuthenticatorConfigInfoRepresentation**](AuthenticatorConfigInfoRepresentation.md)

### Authorization

[access_token](../README.md#access_token)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getexecution"></a>
# **GetExecution**
> void GetExecution (string realm, string executionId, CancellationToken ct)



Get Single Execution

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class GetExecutionExample
    {
        public void main()
        {
            

            var apiInstance = new AuthenticationManagementApi();
            var realm = realm_example;  // string | realm name (not id!)
            var executionId = executionId_example;  // string | 
            var ct = new CancellationToken(); // CancellationToken |  (optional) 

            try
            {
                apiInstance.GetExecution(realm, executionId, ct);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AuthenticationManagementApi.GetExecution: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **realm** | **string**| realm name (not id!) | 
 **executionId** | **string**|  | 
 **ct** | [**CancellationToken**](.md)|  | [optional] 

### Return type

void (empty response body)

### Authorization

[access_token](../README.md#access_token)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getexecutionconfig"></a>
# **GetExecutionConfig**
> AuthenticatorConfigRepresentation GetExecutionConfig (string realm, string executionId, string id, CancellationToken ct)



Get execution’s configuration

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class GetExecutionConfigExample
    {
        public void main()
        {
            

            var apiInstance = new AuthenticationManagementApi();
            var realm = realm_example;  // string | realm name (not id!)
            var executionId = executionId_example;  // string | Execution id
            var id = id_example;  // string | Configuration id
            var ct = new CancellationToken(); // CancellationToken |  (optional) 

            try
            {
                AuthenticatorConfigRepresentation result = apiInstance.GetExecutionConfig(realm, executionId, id, ct);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AuthenticationManagementApi.GetExecutionConfig: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **realm** | **string**| realm name (not id!) | 
 **executionId** | **string**| Execution id | 
 **id** | **string**| Configuration id | 
 **ct** | [**CancellationToken**](.md)|  | [optional] 

### Return type

[**AuthenticatorConfigRepresentation**](AuthenticatorConfigRepresentation.md)

### Authorization

[access_token](../README.md#access_token)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getexecutions"></a>
# **GetExecutions**
> void GetExecutions (string realm, string flowAlias, CancellationToken ct)



Get authentication executions for a flow

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class GetExecutionsExample
    {
        public void main()
        {
            

            var apiInstance = new AuthenticationManagementApi();
            var realm = realm_example;  // string | realm name (not id!)
            var flowAlias = flowAlias_example;  // string | Flow alias
            var ct = new CancellationToken(); // CancellationToken |  (optional) 

            try
            {
                apiInstance.GetExecutions(realm, flowAlias, ct);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AuthenticationManagementApi.GetExecutions: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **realm** | **string**| realm name (not id!) | 
 **flowAlias** | **string**| Flow alias | 
 **ct** | [**CancellationToken**](.md)|  | [optional] 

### Return type

void (empty response body)

### Authorization

[access_token](../README.md#access_token)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getflow"></a>
# **GetFlow**
> AuthenticationFlowRepresentation GetFlow (string realm, string id, CancellationToken ct)



Get authentication flow for id

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class GetFlowExample
    {
        public void main()
        {
            

            var apiInstance = new AuthenticationManagementApi();
            var realm = realm_example;  // string | realm name (not id!)
            var id = id_example;  // string | 
            var ct = new CancellationToken(); // CancellationToken |  (optional) 

            try
            {
                AuthenticationFlowRepresentation result = apiInstance.GetFlow(realm, id, ct);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AuthenticationManagementApi.GetFlow: " + e.Message );
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

[**AuthenticationFlowRepresentation**](AuthenticationFlowRepresentation.md)

### Authorization

[access_token](../README.md#access_token)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getflows"></a>
# **GetFlows**
> List<AuthenticationFlowRepresentation> GetFlows (string realm, CancellationToken ct)



Get authentication flows Returns a stream of authentication flows.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class GetFlowsExample
    {
        public void main()
        {
            

            var apiInstance = new AuthenticationManagementApi();
            var realm = realm_example;  // string | realm name (not id!)
            var ct = new CancellationToken(); // CancellationToken |  (optional) 

            try
            {
                List&lt;AuthenticationFlowRepresentation&gt; result = apiInstance.GetFlows(realm, ct);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AuthenticationManagementApi.GetFlows: " + e.Message );
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

[**List<AuthenticationFlowRepresentation>**](AuthenticationFlowRepresentation.md)

### Authorization

[access_token](../README.md#access_token)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getformactionproviders"></a>
# **GetFormActionProviders**
> List<Object> GetFormActionProviders (string realm, CancellationToken ct)



Get form action providers Returns a stream of form action providers.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class GetFormActionProvidersExample
    {
        public void main()
        {
            

            var apiInstance = new AuthenticationManagementApi();
            var realm = realm_example;  // string | realm name (not id!)
            var ct = new CancellationToken(); // CancellationToken |  (optional) 

            try
            {
                List&lt;Object&gt; result = apiInstance.GetFormActionProviders(realm, ct);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AuthenticationManagementApi.GetFormActionProviders: " + e.Message );
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

**List<Object>**

### Authorization

[access_token](../README.md#access_token)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getformproviders"></a>
# **GetFormProviders**
> List<Object> GetFormProviders (string realm, CancellationToken ct)



Get form providers Returns a stream of form providers.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class GetFormProvidersExample
    {
        public void main()
        {
            

            var apiInstance = new AuthenticationManagementApi();
            var realm = realm_example;  // string | realm name (not id!)
            var ct = new CancellationToken(); // CancellationToken |  (optional) 

            try
            {
                List&lt;Object&gt; result = apiInstance.GetFormProviders(realm, ct);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AuthenticationManagementApi.GetFormProviders: " + e.Message );
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

**List<Object>**

### Authorization

[access_token](../README.md#access_token)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getperclientconfigdescription"></a>
# **GetPerClientConfigDescription**
> Dictionary<string, ConfigPropertyRepresentation> GetPerClientConfigDescription (string realm, CancellationToken ct)



Get configuration descriptions for all clients

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class GetPerClientConfigDescriptionExample
    {
        public void main()
        {
            

            var apiInstance = new AuthenticationManagementApi();
            var realm = realm_example;  // string | realm name (not id!)
            var ct = new CancellationToken(); // CancellationToken |  (optional) 

            try
            {
                Dictionary&lt;string, ConfigPropertyRepresentation&gt; result = apiInstance.GetPerClientConfigDescription(realm, ct);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AuthenticationManagementApi.GetPerClientConfigDescription: " + e.Message );
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

[**Dictionary<string, ConfigPropertyRepresentation>**](ConfigPropertyRepresentation.md)

### Authorization

[access_token](../README.md#access_token)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getrequiredaction"></a>
# **GetRequiredAction**
> RequiredActionProviderRepresentation GetRequiredAction (string realm, string alias, CancellationToken ct)



Get required action for alias

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class GetRequiredActionExample
    {
        public void main()
        {
            

            var apiInstance = new AuthenticationManagementApi();
            var realm = realm_example;  // string | realm name (not id!)
            var alias = alias_example;  // string | Alias of required action
            var ct = new CancellationToken(); // CancellationToken |  (optional) 

            try
            {
                RequiredActionProviderRepresentation result = apiInstance.GetRequiredAction(realm, alias, ct);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AuthenticationManagementApi.GetRequiredAction: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **realm** | **string**| realm name (not id!) | 
 **alias** | **string**| Alias of required action | 
 **ct** | [**CancellationToken**](.md)|  | [optional] 

### Return type

[**RequiredActionProviderRepresentation**](RequiredActionProviderRepresentation.md)

### Authorization

[access_token](../README.md#access_token)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getrequiredactions"></a>
# **GetRequiredActions**
> List<RequiredActionProviderRepresentation> GetRequiredActions (string realm, CancellationToken ct)



Get required actions Returns a stream of required actions.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class GetRequiredActionsExample
    {
        public void main()
        {
            

            var apiInstance = new AuthenticationManagementApi();
            var realm = realm_example;  // string | realm name (not id!)
            var ct = new CancellationToken(); // CancellationToken |  (optional) 

            try
            {
                List&lt;RequiredActionProviderRepresentation&gt; result = apiInstance.GetRequiredActions(realm, ct);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AuthenticationManagementApi.GetRequiredActions: " + e.Message );
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

[**List<RequiredActionProviderRepresentation>**](RequiredActionProviderRepresentation.md)

### Authorization

[access_token](../README.md#access_token)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getunregisteredrequiredactions"></a>
# **GetUnregisteredRequiredActions**
> List<string> GetUnregisteredRequiredActions (string realm, CancellationToken ct)



Get unregistered required actions Returns a stream of unregistered required actions.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class GetUnregisteredRequiredActionsExample
    {
        public void main()
        {
            

            var apiInstance = new AuthenticationManagementApi();
            var realm = realm_example;  // string | realm name (not id!)
            var ct = new CancellationToken(); // CancellationToken |  (optional) 

            try
            {
                List&lt;string&gt; result = apiInstance.GetUnregisteredRequiredActions(realm, ct);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AuthenticationManagementApi.GetUnregisteredRequiredActions: " + e.Message );
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

**List<string>**

### Authorization

[access_token](../README.md#access_token)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="postauthenticationconfig"></a>
# **PostAuthenticationConfig**
> void PostAuthenticationConfig (string realm, AuthenticatorConfigRepresentation body, CancellationToken ct)



Create new authenticator configuration

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class PostAuthenticationConfigExample
    {
        public void main()
        {
            

            var apiInstance = new AuthenticationManagementApi();
            var realm = realm_example;  // string | realm name (not id!)
            var body = new AuthenticatorConfigRepresentation(); // AuthenticatorConfigRepresentation | AuthenticatorConfigRepresentation (optional) 
            var ct = new CancellationToken(); // CancellationToken |  (optional) 

            try
            {
                apiInstance.PostAuthenticationConfig(realm, body, ct);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AuthenticationManagementApi.PostAuthenticationConfig: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **realm** | **string**| realm name (not id!) | 
 **body** | [**AuthenticatorConfigRepresentation**](AuthenticatorConfigRepresentation.md)| AuthenticatorConfigRepresentation | [optional] 
 **ct** | [**CancellationToken**](.md)|  | [optional] 

### Return type

void (empty response body)

### Authorization

[access_token](../README.md#access_token)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="postcopy"></a>
# **PostCopy**
> void PostCopy (string realm, string flowAlias, string body, CancellationToken ct)



Copy existing authentication flow under a new name The new name is given as 'newName' attribute of the passed JSON object

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class PostCopyExample
    {
        public void main()
        {
            

            var apiInstance = new AuthenticationManagementApi();
            var realm = realm_example;  // string | realm name (not id!)
            var flowAlias = flowAlias_example;  // string | name of the existing authentication flow
            var body = new string(); // string | [string] (optional) 
            var ct = new CancellationToken(); // CancellationToken |  (optional) 

            try
            {
                apiInstance.PostCopy(realm, flowAlias, body, ct);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AuthenticationManagementApi.PostCopy: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **realm** | **string**| realm name (not id!) | 
 **flowAlias** | **string**| name of the existing authentication flow | 
 **body** | [**string**](string.md)| [string] | [optional] 
 **ct** | [**CancellationToken**](.md)|  | [optional] 

### Return type

void (empty response body)

### Authorization

[access_token](../README.md#access_token)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="postexecution"></a>
# **PostExecution**
> void PostExecution (string realm, string flowAlias, string body, CancellationToken ct)



Add new authentication execution to a flow

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class PostExecutionExample
    {
        public void main()
        {
            

            var apiInstance = new AuthenticationManagementApi();
            var realm = realm_example;  // string | realm name (not id!)
            var flowAlias = flowAlias_example;  // string | Alias of parent flow
            var body = new string(); // string | [string] (optional) 
            var ct = new CancellationToken(); // CancellationToken |  (optional) 

            try
            {
                apiInstance.PostExecution(realm, flowAlias, body, ct);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AuthenticationManagementApi.PostExecution: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **realm** | **string**| realm name (not id!) | 
 **flowAlias** | **string**| Alias of parent flow | 
 **body** | [**string**](string.md)| [string] | [optional] 
 **ct** | [**CancellationToken**](.md)|  | [optional] 

### Return type

void (empty response body)

### Authorization

[access_token](../README.md#access_token)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="postexecutionconfig"></a>
# **PostExecutionConfig**
> void PostExecutionConfig (string realm, string executionId, AuthenticatorConfigRepresentation body, CancellationToken ct)



Update execution with new configuration

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class PostExecutionConfigExample
    {
        public void main()
        {
            

            var apiInstance = new AuthenticationManagementApi();
            var realm = realm_example;  // string | realm name (not id!)
            var executionId = executionId_example;  // string | Execution id
            var body = new AuthenticatorConfigRepresentation(); // AuthenticatorConfigRepresentation | AuthenticatorConfigRepresentation (optional) 
            var ct = new CancellationToken(); // CancellationToken |  (optional) 

            try
            {
                apiInstance.PostExecutionConfig(realm, executionId, body, ct);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AuthenticationManagementApi.PostExecutionConfig: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **realm** | **string**| realm name (not id!) | 
 **executionId** | **string**| Execution id | 
 **body** | [**AuthenticatorConfigRepresentation**](AuthenticatorConfigRepresentation.md)| AuthenticatorConfigRepresentation | [optional] 
 **ct** | [**CancellationToken**](.md)|  | [optional] 

### Return type

void (empty response body)

### Authorization

[access_token](../README.md#access_token)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="postexecutionlowerpriority"></a>
# **PostExecutionLowerPriority**
> void PostExecutionLowerPriority (string realm, string executionId, CancellationToken ct)



Lower execution’s priority

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class PostExecutionLowerPriorityExample
    {
        public void main()
        {
            

            var apiInstance = new AuthenticationManagementApi();
            var realm = realm_example;  // string | realm name (not id!)
            var executionId = executionId_example;  // string | Execution id
            var ct = new CancellationToken(); // CancellationToken |  (optional) 

            try
            {
                apiInstance.PostExecutionLowerPriority(realm, executionId, ct);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AuthenticationManagementApi.PostExecutionLowerPriority: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **realm** | **string**| realm name (not id!) | 
 **executionId** | **string**| Execution id | 
 **ct** | [**CancellationToken**](.md)|  | [optional] 

### Return type

void (empty response body)

### Authorization

[access_token](../README.md#access_token)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="postexecutionraisepriority"></a>
# **PostExecutionRaisePriority**
> void PostExecutionRaisePriority (string realm, string executionId, CancellationToken ct)



Raise execution’s priority

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class PostExecutionRaisePriorityExample
    {
        public void main()
        {
            

            var apiInstance = new AuthenticationManagementApi();
            var realm = realm_example;  // string | realm name (not id!)
            var executionId = executionId_example;  // string | Execution id
            var ct = new CancellationToken(); // CancellationToken |  (optional) 

            try
            {
                apiInstance.PostExecutionRaisePriority(realm, executionId, ct);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AuthenticationManagementApi.PostExecutionRaisePriority: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **realm** | **string**| realm name (not id!) | 
 **executionId** | **string**| Execution id | 
 **ct** | [**CancellationToken**](.md)|  | [optional] 

### Return type

void (empty response body)

### Authorization

[access_token](../README.md#access_token)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="postexecutions"></a>
# **PostExecutions**
> void PostExecutions (string realm, AuthenticationExecutionRepresentation body, CancellationToken ct)



Add new authentication execution

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class PostExecutionsExample
    {
        public void main()
        {
            

            var apiInstance = new AuthenticationManagementApi();
            var realm = realm_example;  // string | realm name (not id!)
            var body = new AuthenticationExecutionRepresentation(); // AuthenticationExecutionRepresentation | AuthenticationExecutionRepresentation (optional) 
            var ct = new CancellationToken(); // CancellationToken |  (optional) 

            try
            {
                apiInstance.PostExecutions(realm, body, ct);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AuthenticationManagementApi.PostExecutions: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **realm** | **string**| realm name (not id!) | 
 **body** | [**AuthenticationExecutionRepresentation**](AuthenticationExecutionRepresentation.md)| AuthenticationExecutionRepresentation | [optional] 
 **ct** | [**CancellationToken**](.md)|  | [optional] 

### Return type

void (empty response body)

### Authorization

[access_token](../README.md#access_token)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="postflow"></a>
# **PostFlow**
> void PostFlow (string realm, string flowAlias, string body, CancellationToken ct)



Add new flow with new execution to existing flow

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class PostFlowExample
    {
        public void main()
        {
            

            var apiInstance = new AuthenticationManagementApi();
            var realm = realm_example;  // string | realm name (not id!)
            var flowAlias = flowAlias_example;  // string | Alias of parent authentication flow
            var body = new string(); // string | [string] (optional) 
            var ct = new CancellationToken(); // CancellationToken |  (optional) 

            try
            {
                apiInstance.PostFlow(realm, flowAlias, body, ct);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AuthenticationManagementApi.PostFlow: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **realm** | **string**| realm name (not id!) | 
 **flowAlias** | **string**| Alias of parent authentication flow | 
 **body** | [**string**](string.md)| [string] | [optional] 
 **ct** | [**CancellationToken**](.md)|  | [optional] 

### Return type

void (empty response body)

### Authorization

[access_token](../README.md#access_token)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="postflows"></a>
# **PostFlows**
> void PostFlows (string realm, AuthenticationFlowRepresentation body, CancellationToken ct)



Create a new authentication flow

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class PostFlowsExample
    {
        public void main()
        {
            

            var apiInstance = new AuthenticationManagementApi();
            var realm = realm_example;  // string | realm name (not id!)
            var body = new AuthenticationFlowRepresentation(); // AuthenticationFlowRepresentation | AuthenticationFlowRepresentation (optional) 
            var ct = new CancellationToken(); // CancellationToken |  (optional) 

            try
            {
                apiInstance.PostFlows(realm, body, ct);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AuthenticationManagementApi.PostFlows: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **realm** | **string**| realm name (not id!) | 
 **body** | [**AuthenticationFlowRepresentation**](AuthenticationFlowRepresentation.md)| AuthenticationFlowRepresentation | [optional] 
 **ct** | [**CancellationToken**](.md)|  | [optional] 

### Return type

void (empty response body)

### Authorization

[access_token](../README.md#access_token)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="postregisterrequiredaction"></a>
# **PostRegisterRequiredAction**
> void PostRegisterRequiredAction (string realm, string body, CancellationToken ct)



Register a new required actions

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class PostRegisterRequiredActionExample
    {
        public void main()
        {
            

            var apiInstance = new AuthenticationManagementApi();
            var realm = realm_example;  // string | realm name (not id!)
            var body = new string(); // string | [string] (optional) 
            var ct = new CancellationToken(); // CancellationToken |  (optional) 

            try
            {
                apiInstance.PostRegisterRequiredAction(realm, body, ct);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AuthenticationManagementApi.PostRegisterRequiredAction: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **realm** | **string**| realm name (not id!) | 
 **body** | [**string**](string.md)| [string] | [optional] 
 **ct** | [**CancellationToken**](.md)|  | [optional] 

### Return type

void (empty response body)

### Authorization

[access_token](../README.md#access_token)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="postrequiredactionlowerpriority"></a>
# **PostRequiredActionLowerPriority**
> void PostRequiredActionLowerPriority (string realm, string alias, CancellationToken ct)



Lower required action’s priority

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class PostRequiredActionLowerPriorityExample
    {
        public void main()
        {
            

            var apiInstance = new AuthenticationManagementApi();
            var realm = realm_example;  // string | realm name (not id!)
            var alias = alias_example;  // string | Alias of required action
            var ct = new CancellationToken(); // CancellationToken |  (optional) 

            try
            {
                apiInstance.PostRequiredActionLowerPriority(realm, alias, ct);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AuthenticationManagementApi.PostRequiredActionLowerPriority: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **realm** | **string**| realm name (not id!) | 
 **alias** | **string**| Alias of required action | 
 **ct** | [**CancellationToken**](.md)|  | [optional] 

### Return type

void (empty response body)

### Authorization

[access_token](../README.md#access_token)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="postrequiredactionraisepriority"></a>
# **PostRequiredActionRaisePriority**
> void PostRequiredActionRaisePriority (string realm, string alias, CancellationToken ct)



Raise required action’s priority

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class PostRequiredActionRaisePriorityExample
    {
        public void main()
        {
            

            var apiInstance = new AuthenticationManagementApi();
            var realm = realm_example;  // string | realm name (not id!)
            var alias = alias_example;  // string | Alias of required action
            var ct = new CancellationToken(); // CancellationToken |  (optional) 

            try
            {
                apiInstance.PostRequiredActionRaisePriority(realm, alias, ct);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AuthenticationManagementApi.PostRequiredActionRaisePriority: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **realm** | **string**| realm name (not id!) | 
 **alias** | **string**| Alias of required action | 
 **ct** | [**CancellationToken**](.md)|  | [optional] 

### Return type

void (empty response body)

### Authorization

[access_token](../README.md#access_token)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="putauthenticationconfig"></a>
# **PutAuthenticationConfig**
> void PutAuthenticationConfig (string realm, string id, AuthenticatorConfigRepresentation body, CancellationToken ct)



Update authenticator configuration

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class PutAuthenticationConfigExample
    {
        public void main()
        {
            

            var apiInstance = new AuthenticationManagementApi();
            var realm = realm_example;  // string | realm name (not id!)
            var id = id_example;  // string | Configuration id
            var body = new AuthenticatorConfigRepresentation(); // AuthenticatorConfigRepresentation | AuthenticatorConfigRepresentation (optional) 
            var ct = new CancellationToken(); // CancellationToken |  (optional) 

            try
            {
                apiInstance.PutAuthenticationConfig(realm, id, body, ct);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AuthenticationManagementApi.PutAuthenticationConfig: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **realm** | **string**| realm name (not id!) | 
 **id** | **string**| Configuration id | 
 **body** | [**AuthenticatorConfigRepresentation**](AuthenticatorConfigRepresentation.md)| AuthenticatorConfigRepresentation | [optional] 
 **ct** | [**CancellationToken**](.md)|  | [optional] 

### Return type

void (empty response body)

### Authorization

[access_token](../README.md#access_token)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="putexecutions"></a>
# **PutExecutions**
> void PutExecutions (string realm, string flowAlias, AuthenticationExecutionInfoRepresentation body, CancellationToken ct)



Update authentication executions of a Flow

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class PutExecutionsExample
    {
        public void main()
        {
            

            var apiInstance = new AuthenticationManagementApi();
            var realm = realm_example;  // string | realm name (not id!)
            var flowAlias = flowAlias_example;  // string | Flow alias
            var body = new AuthenticationExecutionInfoRepresentation(); // AuthenticationExecutionInfoRepresentation | AuthenticationExecutionInfoRepresentation (optional) 
            var ct = new CancellationToken(); // CancellationToken |  (optional) 

            try
            {
                apiInstance.PutExecutions(realm, flowAlias, body, ct);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AuthenticationManagementApi.PutExecutions: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **realm** | **string**| realm name (not id!) | 
 **flowAlias** | **string**| Flow alias | 
 **body** | [**AuthenticationExecutionInfoRepresentation**](AuthenticationExecutionInfoRepresentation.md)| AuthenticationExecutionInfoRepresentation | [optional] 
 **ct** | [**CancellationToken**](.md)|  | [optional] 

### Return type

void (empty response body)

### Authorization

[access_token](../README.md#access_token)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="putflow"></a>
# **PutFlow**
> void PutFlow (string realm, string id, AuthenticationFlowRepresentation body, CancellationToken ct)



Update an authentication flow

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class PutFlowExample
    {
        public void main()
        {
            

            var apiInstance = new AuthenticationManagementApi();
            var realm = realm_example;  // string | realm name (not id!)
            var id = id_example;  // string | 
            var body = new AuthenticationFlowRepresentation(); // AuthenticationFlowRepresentation | AuthenticationFlowRepresentation (optional) 
            var ct = new CancellationToken(); // CancellationToken |  (optional) 

            try
            {
                apiInstance.PutFlow(realm, id, body, ct);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AuthenticationManagementApi.PutFlow: " + e.Message );
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
 **body** | [**AuthenticationFlowRepresentation**](AuthenticationFlowRepresentation.md)| AuthenticationFlowRepresentation | [optional] 
 **ct** | [**CancellationToken**](.md)|  | [optional] 

### Return type

void (empty response body)

### Authorization

[access_token](../README.md#access_token)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="putrequiredaction"></a>
# **PutRequiredAction**
> void PutRequiredAction (string realm, string alias, RequiredActionProviderRepresentation body, CancellationToken ct)



Update required action

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class PutRequiredActionExample
    {
        public void main()
        {
            

            var apiInstance = new AuthenticationManagementApi();
            var realm = realm_example;  // string | realm name (not id!)
            var alias = alias_example;  // string | Alias of required action
            var body = new RequiredActionProviderRepresentation(); // RequiredActionProviderRepresentation | RequiredActionProviderRepresentation (optional) 
            var ct = new CancellationToken(); // CancellationToken |  (optional) 

            try
            {
                apiInstance.PutRequiredAction(realm, alias, body, ct);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AuthenticationManagementApi.PutRequiredAction: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **realm** | **string**| realm name (not id!) | 
 **alias** | **string**| Alias of required action | 
 **body** | [**RequiredActionProviderRepresentation**](RequiredActionProviderRepresentation.md)| RequiredActionProviderRepresentation | [optional] 
 **ct** | [**CancellationToken**](.md)|  | [optional] 

### Return type

void (empty response body)

### Authorization

[access_token](../README.md#access_token)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

