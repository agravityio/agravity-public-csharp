# Agravity.Public.Api.PublicDownloadFormatManagementApi

All URIs are relative to *http://localhost:7072/api*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**HttpDownloadFormatsGetAll**](PublicDownloadFormatManagementApi.md#httpdownloadformatsgetall) | **GET** /downloadformats |  |
| [**HttpDownloadFormatsGetAllFromShared**](PublicDownloadFormatManagementApi.md#httpdownloadformatsgetallfromshared) | **GET** /downloadformats-shared |  |

<a name="httpdownloadformatsgetall"></a>
# **HttpDownloadFormatsGetAll**
> List&lt;DownloadFormat&gt; HttpDownloadFormatsGetAll ()



This endpoint lists all download formats in database.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Agravity.Public.Api;
using Agravity.Public.Client;
using Agravity.Public.Model;

namespace Example
{
    public class HttpDownloadFormatsGetAllExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost:7072/api";
            // Configure API key authorization: function_key
            config.AddApiKey("x-functions-key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("x-functions-key", "Bearer");

            var apiInstance = new PublicDownloadFormatManagementApi(config);

            try
            {
                List<DownloadFormat> result = apiInstance.HttpDownloadFormatsGetAll();
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling PublicDownloadFormatManagementApi.HttpDownloadFormatsGetAll: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the HttpDownloadFormatsGetAllWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<List<DownloadFormat>> response = apiInstance.HttpDownloadFormatsGetAllWithHttpInfo();
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling PublicDownloadFormatManagementApi.HttpDownloadFormatsGetAllWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters
This endpoint does not need any parameter.
### Return type

[**List&lt;DownloadFormat&gt;**](DownloadFormat.md)

### Authorization

[function_key](../README.md#function_key)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Returns all download formats in database. |  -  |
| **401** | Unauthorized. API Key not provided. |  -  |
| **500** | Internal server error. Please contact administrator. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="httpdownloadformatsgetallfromshared"></a>
# **HttpDownloadFormatsGetAllFromShared**
> List&lt;DownloadFormat&gt; HttpDownloadFormatsGetAllFromShared (string shareId, string ayPassword = null)



This endpoint lists all download formats for a specific shared collections in database.Needs a valid shared collection ID to be authenticated.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Agravity.Public.Api;
using Agravity.Public.Client;
using Agravity.Public.Model;

namespace Example
{
    public class HttpDownloadFormatsGetAllFromSharedExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost:7072/api";
            var apiInstance = new PublicDownloadFormatManagementApi(config);
            var shareId = "shareId_example";  // string | This share ID is like an API key. Check on validy (format, expire, collection still availabe). Otherwise StatusCode 403 (Forbidden) is returned.
            var ayPassword = "ayPassword_example";  // string | If shared collection has a password, this header is mandatory. Otherwise StatusCode 403 (Forbidden) is returned. (optional) 

            try
            {
                List<DownloadFormat> result = apiInstance.HttpDownloadFormatsGetAllFromShared(shareId, ayPassword);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling PublicDownloadFormatManagementApi.HttpDownloadFormatsGetAllFromShared: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the HttpDownloadFormatsGetAllFromSharedWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<List<DownloadFormat>> response = apiInstance.HttpDownloadFormatsGetAllFromSharedWithHttpInfo(shareId, ayPassword);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling PublicDownloadFormatManagementApi.HttpDownloadFormatsGetAllFromSharedWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **shareId** | **string** | This share ID is like an API key. Check on validy (format, expire, collection still availabe). Otherwise StatusCode 403 (Forbidden) is returned. |  |
| **ayPassword** | **string** | If shared collection has a password, this header is mandatory. Otherwise StatusCode 403 (Forbidden) is returned. | [optional]  |

### Return type

[**List&lt;DownloadFormat&gt;**](DownloadFormat.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Returns download formats for the shared collection in database. |  -  |
| **403** | Not enough privileges to access item. |  -  |
| **500** | Internal server error. Please contact administrator. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

