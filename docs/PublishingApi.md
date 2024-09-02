# Agravity.Public.Api.PublishingApi

All URIs are relative to *http://localhost:7071/api*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**HttpPublishedAssetsGetAll**](PublishingApi.md#httppublishedassetsgetall) | **GET** /publish |  |

<a id="httppublishedassetsgetall"></a>
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
            config.BasePath = "http://localhost:7071/api";
            // Configure OAuth2 access token for authorization: msal_auth
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new PublishingApi(config);
            var cid = "cid_example";  // string | Filter response for collection (optional) 
            var incldescendants = true;  // bool? | Include collections further down in hierarchy (optional) 

            try
            {
                PublishEntity result = apiInstance.HttpPublishedAssetsGetAll(cid, incldescendants);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling PublishingApi.HttpPublishedAssetsGetAll: " + e.Message);
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
    Debug.Print("Exception when calling PublishingApi.HttpPublishedAssetsGetAllWithHttpInfo: " + e.Message);
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

[msal_auth](../README.md#msal_auth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Returns the all published assets as . |  -  |
| **401** | Unauthorized. Bearer Token not provided. |  -  |
| **500** | Internal server error. Please contact administrator. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

