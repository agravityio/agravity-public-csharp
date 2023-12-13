# Agravity.Public.Api.PublicAssetPublishingApi

All URIs are relative to *http://localhost:7072/api*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**HttpPublishedAssetsCreate**](PublicAssetPublishingApi.md#httppublishedassetscreate) | **POST** /assets/{id}/publish |  |
| [**HttpPublishedAssetsGet**](PublicAssetPublishingApi.md#httppublishedassetsget) | **GET** /assets/{id}/publish |  |
| [**HttpPublishedAssetsGetById**](PublicAssetPublishingApi.md#httppublishedassetsgetbyid) | **GET** /assets/{id}/publish/{pid} |  |

<a name="httppublishedassetscreate"></a>
# **HttpPublishedAssetsCreate**
> PublishedAsset HttpPublishedAssetsCreate (string id, PublishedAsset publishedAsset)



This endpoint creates an additional published asset

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Agravity.Public.Api;
using Agravity.Public.Client;
using Agravity.Public.Model;

namespace Example
{
    public class HttpPublishedAssetsCreateExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost:7072/api";
            // Configure API key authorization: function_key
            config.AddApiKey("x-functions-key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("x-functions-key", "Bearer");

            var apiInstance = new PublicAssetPublishingApi(config);
            var id = "id_example";  // string | The ID of the asset.
            var publishedAsset = new PublishedAsset(); // PublishedAsset | This creates / adds an unique published asset ID and adds the information to the asset (in DB).

            try
            {
                PublishedAsset result = apiInstance.HttpPublishedAssetsCreate(id, publishedAsset);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling PublicAssetPublishingApi.HttpPublishedAssetsCreate: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the HttpPublishedAssetsCreateWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<PublishedAsset> response = apiInstance.HttpPublishedAssetsCreateWithHttpInfo(id, publishedAsset);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling PublicAssetPublishingApi.HttpPublishedAssetsCreateWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **string** | The ID of the asset. |  |
| **publishedAsset** | [**PublishedAsset**](PublishedAsset.md) | This creates / adds an unique published asset ID and adds the information to the asset (in DB). |  |

### Return type

[**PublishedAsset**](PublishedAsset.md)

### Authorization

[function_key](../README.md#function_key)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **201** | Returns the created published-asset entity. |  -  |
| **400** | Could not publish asset because asset or original blob could not be found. (Code: 0da83425-da4e-4586-ae31-ba51e2c84f2c)&lt;br&gt;Could not publish an asset which is not active. (Code: be0b47c9-cf24-4cb8-a4ab-f17cdfe6dc4e)&lt;br&gt;Could not publish an asset which is locked. (Code: 16dbd27d-51f8-4556-a874-6cd7ddd7a1a8)&lt;br&gt;Could not resize asset &lt;assedId&gt; for publishing. (Code: 2d9187ac-dc37-4365-a633-7ef90a326d0f)&lt;br&gt;Could not find optimized asset &lt;assetId&gt; for publishing. (Code: e59e01cb-3f39-4c36-9c71-3d28bcabe486)&lt;br&gt;Tried to access not existion blob: &lt;assetId&gt; does not exists.... (Code: a96e079b-61b3-492a-8adb-93b399287b46)&lt;br&gt;Publish to this target is not supported. (Code: 8136f041-60e4-40de-b534-71a7250095cc)&lt;br&gt;Publishing of asset &lt;assetId&gt; failed. Blob could not be created. (Code: 43089864-d2a4-4a42-a2c2-1a9a2048bb58)&lt;br&gt;Could not update asset with ID &lt;assedId&gt; (Code: 87429a31-01cd-4a62-9afb-81d0a56a59d2) |  -  |
| **401** | Unauthorized. API Key not provided. |  -  |
| **500** | Internal server error. Please contact administrator. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="httppublishedassetsget"></a>
# **HttpPublishedAssetsGet**
> PublishEntity HttpPublishedAssetsGet (string id)



This endpoint lists all the published assets which are stored in the database if asset is still valid.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Agravity.Public.Api;
using Agravity.Public.Client;
using Agravity.Public.Model;

namespace Example
{
    public class HttpPublishedAssetsGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost:7072/api";
            // Configure API key authorization: function_key
            config.AddApiKey("x-functions-key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("x-functions-key", "Bearer");

            var apiInstance = new PublicAssetPublishingApi(config);
            var id = "id_example";  // string | The ID of the asset.

            try
            {
                PublishEntity result = apiInstance.HttpPublishedAssetsGet(id);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling PublicAssetPublishingApi.HttpPublishedAssetsGet: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the HttpPublishedAssetsGetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<PublishEntity> response = apiInstance.HttpPublishedAssetsGetWithHttpInfo(id);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling PublicAssetPublishingApi.HttpPublishedAssetsGetWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **string** | The ID of the asset. |  |

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

<a name="httppublishedassetsgetbyid"></a>
# **HttpPublishedAssetsGetById**
> PublishedAsset HttpPublishedAssetsGetById (string id, string pid)



This endpoint returns one single published asset (from ID). Not checked if assetId is not deleted!

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Agravity.Public.Api;
using Agravity.Public.Client;
using Agravity.Public.Model;

namespace Example
{
    public class HttpPublishedAssetsGetByIdExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost:7072/api";
            // Configure API key authorization: function_key
            config.AddApiKey("x-functions-key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("x-functions-key", "Bearer");

            var apiInstance = new PublicAssetPublishingApi(config);
            var id = "id_example";  // string | The ID of the asset.
            var pid = "pid_example";  // string | The published asset ID.

            try
            {
                PublishedAsset result = apiInstance.HttpPublishedAssetsGetById(id, pid);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling PublicAssetPublishingApi.HttpPublishedAssetsGetById: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the HttpPublishedAssetsGetByIdWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<PublishedAsset> response = apiInstance.HttpPublishedAssetsGetByIdWithHttpInfo(id, pid);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling PublicAssetPublishingApi.HttpPublishedAssetsGetByIdWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **string** | The ID of the asset. |  |
| **pid** | **string** | The published asset ID. |  |

### Return type

[**PublishedAsset**](PublishedAsset.md)

### Authorization

[function_key](../README.md#function_key)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Returns the published asset with the given ID. |  -  |
| **401** | Unauthorized. API Key not provided. |  -  |
| **404** | If the asset or published asset with the IDs were not found. |  -  |
| **500** | Internal server error. Please contact administrator. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

