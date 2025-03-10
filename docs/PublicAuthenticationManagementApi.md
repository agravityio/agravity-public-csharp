# Agravity.Public.Api.PublicAuthenticationManagementApi

All URIs are relative to *http://localhost:7072/api*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**HttpAuthGetContainerWriteSasToken**](PublicAuthenticationManagementApi.md#httpauthgetcontainerwritesastoken) | **GET** /auth/containerwrite/{containerName} |  |
| [**HttpAuthGetInboxContainerWriteSasToken**](PublicAuthenticationManagementApi.md#httpauthgetinboxcontainerwritesastoken) | **GET** /auth/inbox |  |

<a id="httpauthgetcontainerwritesastoken"></a>
# **HttpAuthGetContainerWriteSasToken**
> SasToken HttpAuthGetContainerWriteSasToken (string containerName, string code)



This endpoint creates and returns a SAS-Token with write access for the requested container

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Agravity.Public.Api;
using Agravity.Public.Client;
using Agravity.Public.Model;

namespace Example
{
    public class HttpAuthGetContainerWriteSasTokenExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost:7072/api";
            // Configure API key authorization: function_key
            config.AddApiKey("x-functions-key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("x-functions-key", "Bearer");

            var apiInstance = new PublicAuthenticationManagementApi(config);
            var containerName = "containerName_example";  // string | The name of the blob container
            var code = "code_example";  // string | The API key to access this endpoint. (Alternative using header x-function-keys with same value)

            try
            {
                SasToken result = apiInstance.HttpAuthGetContainerWriteSasToken(containerName, code);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling PublicAuthenticationManagementApi.HttpAuthGetContainerWriteSasToken: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the HttpAuthGetContainerWriteSasTokenWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<SasToken> response = apiInstance.HttpAuthGetContainerWriteSasTokenWithHttpInfo(containerName, code);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling PublicAuthenticationManagementApi.HttpAuthGetContainerWriteSasTokenWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **containerName** | **string** | The name of the blob container |  |
| **code** | **string** | The API key to access this endpoint. (Alternative using header x-function-keys with same value) |  |

### Return type

[**SasToken**](SasToken.md)

### Authorization

[function_key](../README.md#function_key)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Returns SAS-Token for write access for the requested container. |  -  |
| **401** | Unauthorized. API Key not provided. |  -  |
| **400** | A parameter is null. (Code: 0554451e-dcc9-4bef-a221-029bc3d77120)&lt;br&gt;Could not generate token for {containerName}. (Code: 3f19d7be-9d70-4268-93e6-de387daadd54)&lt;br&gt;No allowed to access containing {containerName}! (Code: fe2097fd-0370-4e30-8260-4a1d7f0e83e0) |  -  |
| **404** | The requested item could not be found. |  -  |
| **500** | Internal server error. Please contact administrator. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="httpauthgetinboxcontainerwritesastoken"></a>
# **HttpAuthGetInboxContainerWriteSasToken**
> SasToken HttpAuthGetInboxContainerWriteSasToken ()



This endpoint creates and returns a SAS-Token with write access for the inbox container. Do not use this any longer. Use HttpAuthGetContainerWriteSasToken with inbox as container name.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Agravity.Public.Api;
using Agravity.Public.Client;
using Agravity.Public.Model;

namespace Example
{
    public class HttpAuthGetInboxContainerWriteSasTokenExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost:7072/api";
            // Configure API key authorization: function_key
            config.AddApiKey("x-functions-key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("x-functions-key", "Bearer");

            var apiInstance = new PublicAuthenticationManagementApi(config);

            try
            {
                SasToken result = apiInstance.HttpAuthGetInboxContainerWriteSasToken();
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling PublicAuthenticationManagementApi.HttpAuthGetInboxContainerWriteSasToken: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the HttpAuthGetInboxContainerWriteSasTokenWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<SasToken> response = apiInstance.HttpAuthGetInboxContainerWriteSasTokenWithHttpInfo();
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling PublicAuthenticationManagementApi.HttpAuthGetInboxContainerWriteSasTokenWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters
This endpoint does not need any parameter.
### Return type

[**SasToken**](SasToken.md)

### Authorization

[function_key](../README.md#function_key)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Returns SAS-Token for write access for the inbox. |  -  |
| **401** | Unauthorized. API Key not provided. |  -  |
| **400** | A parameter is null. (Code: e30b767a-79e0-41f0-b3fd-dcb621fad0f1)&lt;br&gt;Could not generate token for inbox. (Code: 25b3843e-dbe2-4fc2-946f-3af17943c500) |  -  |
| **404** | The requested item could not be found. |  -  |
| **500** | Internal server error. Please contact administrator. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

