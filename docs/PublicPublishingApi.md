# Agravity.Public.Api.PublicPublishingApi

All URIs are relative to *http://localhost:7072/api*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**HttpPublishedAssetsGetAll**](PublicPublishingApi.md#httppublishedassetsgetall) | **GET** /publish |  |

<a name="httppublishedassetsgetall"></a>
# **HttpPublishedAssetsGetAll**
> PublishEntity HttpPublishedAssetsGetAll (string cid = null, bool? incldescendants = null)



This endpoint lists all the published assets which are stored in the database

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Agravity.Public.Api;
using Agravity.Public.Client;
using Agravity.Public.Model;

namespace Example
{
    public class HttpPublishedAssetsGetAllExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost:7072/api";
            // Configure API key authorization: function_key
            config.AddApiKey("x-functions-key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("x-functions-key", "Bearer");

            var apiInstance = new PublicPublishingApi(config);
            var cid = "cid_example";  // string | Filter response for collection (optional) 
            var incldescendants = true;  // bool? | Include collections further down in hierarchy (optional) 

            try
            {
                PublishEntity result = apiInstance.HttpPublishedAssetsGetAll(cid, incldescendants);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling PublicPublishingApi.HttpPublishedAssetsGetAll: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the HttpPublishedAssetsGetAllWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<PublishEntity> response = apiInstance.HttpPublishedAssetsGetAllWithHttpInfo(cid, incldescendants);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling PublicPublishingApi.HttpPublishedAssetsGetAllWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **cid** | **string** | Filter response for collection | [optional]  |
| **incldescendants** | **bool?** | Include collections further down in hierarchy | [optional]  |

### Return type

[**PublishEntity**](PublishEntity.md)

### Authorization

[function_key](../README.md#function_key)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Returns the all published assets as . |  -  |
| **401** | Unauthorized. API Key not provided. |  -  |
| **500** | Internal server error. Please contact administrator. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

