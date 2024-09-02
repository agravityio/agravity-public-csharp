# Agravity.Public.Api.ConfigurationManagementApi

All URIs are relative to *http://localhost:7071/api*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**HttpConfigDeleteSingle**](ConfigurationManagementApi.md#httpconfigdeletesingle) | **DELETE** /config/{key} |  |
| [**HttpConfigGetAll**](ConfigurationManagementApi.md#httpconfiggetall) | **GET** /config |  |
| [**HttpConfigGetFrontendAll**](ConfigurationManagementApi.md#httpconfiggetfrontendall) | **GET** /config/frontend |  |
| [**HttpConfigUpdate**](ConfigurationManagementApi.md#httpconfigupdate) | **POST** /config |  |
| [**HttpConfigUpdateSingle**](ConfigurationManagementApi.md#httpconfigupdatesingle) | **POST** /config/{key} |  |

<a id="httpconfigdeletesingle"></a>
# **HttpConfigDeleteSingle**
> void HttpConfigDeleteSingle (string key)



Deletes an existing custom config value with the given key. It will also refresh the current application configuration cache for this key.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Agravity.Public.Api;
using Agravity.Public.Client;
using Agravity.Public.Model;

namespace Example
{
    public class HttpConfigDeleteSingleExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost:7071/api";
            // Configure OAuth2 access token for authorization: msal_auth
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new ConfigurationManagementApi(config);
            var key = "key_example";  // string | The key of the configuration.

            try
            {
                apiInstance.HttpConfigDeleteSingle(key);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ConfigurationManagementApi.HttpConfigDeleteSingle: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the HttpConfigDeleteSingleWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    apiInstance.HttpConfigDeleteSingleWithHttpInfo(key);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ConfigurationManagementApi.HttpConfigDeleteSingleWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **key** | **string** | The key of the configuration. |  |

### Return type

void (empty response body)

### Authorization

[msal_auth](../README.md#msal_auth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **204** | Returns no content anyway. |  -  |
| **401** | Unauthorized. Bearer Token not provided. |  -  |
| **500** | Internal server error. Please contact administrator. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="httpconfiggetall"></a>
# **HttpConfigGetAll**
> List&lt;AppConfigTableEntity&gt; HttpConfigGetAll ()



Lists all config values stored in config table

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Agravity.Public.Api;
using Agravity.Public.Client;
using Agravity.Public.Model;

namespace Example
{
    public class HttpConfigGetAllExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost:7071/api";
            // Configure OAuth2 access token for authorization: msal_auth
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new ConfigurationManagementApi(config);

            try
            {
                List<AppConfigTableEntity> result = apiInstance.HttpConfigGetAll();
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ConfigurationManagementApi.HttpConfigGetAll: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the HttpConfigGetAllWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<List<AppConfigTableEntity>> response = apiInstance.HttpConfigGetAllWithHttpInfo();
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ConfigurationManagementApi.HttpConfigGetAllWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters
This endpoint does not need any parameter.
### Return type

[**List&lt;AppConfigTableEntity&gt;**](AppConfigTableEntity.md)

### Authorization

[msal_auth](../README.md#msal_auth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Returns the config values in store |  -  |
| **401** | Unauthorized. Bearer Token not provided. |  -  |
| **500** | Internal server error. Please contact administrator. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="httpconfiggetfrontendall"></a>
# **HttpConfigGetFrontendAll**
> List&lt;FrontendAppConfig&gt; HttpConfigGetFrontendAll (bool? customonly = null)



Lists config value only for frontend stored in config table. Optional to filter for custom values only.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Agravity.Public.Api;
using Agravity.Public.Client;
using Agravity.Public.Model;

namespace Example
{
    public class HttpConfigGetFrontendAllExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost:7071/api";
            // Configure OAuth2 access token for authorization: msal_auth
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new ConfigurationManagementApi(config);
            var customonly = true;  // bool? | This returns only the custom created configurations. (optional) 

            try
            {
                List<FrontendAppConfig> result = apiInstance.HttpConfigGetFrontendAll(customonly);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ConfigurationManagementApi.HttpConfigGetFrontendAll: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the HttpConfigGetFrontendAllWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<List<FrontendAppConfig>> response = apiInstance.HttpConfigGetFrontendAllWithHttpInfo(customonly);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ConfigurationManagementApi.HttpConfigGetFrontendAllWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **customonly** | **bool?** | This returns only the custom created configurations. | [optional]  |

### Return type

[**List&lt;FrontendAppConfig&gt;**](FrontendAppConfig.md)

### Authorization

[msal_auth](../README.md#msal_auth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Returns the frontend configations values in store |  -  |
| **401** | Unauthorized. Bearer Token not provided. |  -  |
| **500** | Internal server error. Please contact administrator. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="httpconfigupdate"></a>
# **HttpConfigUpdate**
> AppConfigTableEntity HttpConfigUpdate (string key, string addconfigqueues = null)



This initializes all configurations and write them into appconfig table.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Agravity.Public.Api;
using Agravity.Public.Client;
using Agravity.Public.Model;

namespace Example
{
    public class HttpConfigUpdateExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost:7071/api";
            // Configure OAuth2 access token for authorization: msal_auth
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new ConfigurationManagementApi(config);
            var key = "key_example";  // string | The key of the configuration.
            var addconfigqueues = "addconfigqueues_example";  // string | Comma separated queue-names (have to start with 'setup-'). (optional) 

            try
            {
                AppConfigTableEntity result = apiInstance.HttpConfigUpdate(key, addconfigqueues);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ConfigurationManagementApi.HttpConfigUpdate: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the HttpConfigUpdateWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<AppConfigTableEntity> response = apiInstance.HttpConfigUpdateWithHttpInfo(key, addconfigqueues);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ConfigurationManagementApi.HttpConfigUpdateWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **key** | **string** | The key of the configuration. |  |
| **addconfigqueues** | **string** | Comma separated queue-names (have to start with &#39;setup-&#39;). | [optional]  |

### Return type

[**AppConfigTableEntity**](AppConfigTableEntity.md)

### Authorization

[msal_auth](../README.md#msal_auth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | This will init the configurations and add all default  |  -  |
| **401** | Unauthorized. Bearer Token not provided. |  -  |
| **500** | Internal server error. Please contact administrator. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="httpconfigupdatesingle"></a>
# **HttpConfigUpdateSingle**
> AppConfigTableEntity HttpConfigUpdateSingle (string key, AppConfigTableEntity appConfigTableEntity)



Update an existing (pre-generated) config value (only value, content-type and description) or creates/updates custom config with the given key (full). It will also refresh the current application configuration cache for this key.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Agravity.Public.Api;
using Agravity.Public.Client;
using Agravity.Public.Model;

namespace Example
{
    public class HttpConfigUpdateSingleExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost:7071/api";
            // Configure OAuth2 access token for authorization: msal_auth
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new ConfigurationManagementApi(config);
            var key = "key_example";  // string | The key of the configuration.
            var appConfigTableEntity = new AppConfigTableEntity(); // AppConfigTableEntity | The body has just to contain: value, content_type and/or description or full when custom config.

            try
            {
                AppConfigTableEntity result = apiInstance.HttpConfigUpdateSingle(key, appConfigTableEntity);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ConfigurationManagementApi.HttpConfigUpdateSingle: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the HttpConfigUpdateSingleWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<AppConfigTableEntity> response = apiInstance.HttpConfigUpdateSingleWithHttpInfo(key, appConfigTableEntity);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ConfigurationManagementApi.HttpConfigUpdateSingleWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **key** | **string** | The key of the configuration. |  |
| **appConfigTableEntity** | [**AppConfigTableEntity**](AppConfigTableEntity.md) | The body has just to contain: value, content_type and/or description or full when custom config. |  |

### Return type

[**AppConfigTableEntity**](AppConfigTableEntity.md)

### Authorization

[msal_auth](../README.md#msal_auth)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Returns the config value that was updated |  -  |
| **401** | Unauthorized. Bearer Token not provided. |  -  |
| **500** | Internal server error. Please contact administrator. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

