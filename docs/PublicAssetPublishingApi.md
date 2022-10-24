# AgravityPublic.Api.PublicAssetPublishingApi

All URIs are relative to *http://localhost:7072/api*

Method | HTTP request | Description
------------- | ------------- | -------------
[**HttpPublishedAssetsGet**](PublicAssetPublishingApi.md#httppublishedassetsget) | **GET** /assets/{id}/publish | 
[**HttpPublishedAssetsGetById**](PublicAssetPublishingApi.md#httppublishedassetsgetbyid) | **GET** /assets/{id}/publish/{pid} | 



## HttpPublishedAssetsGet

> PublishEntity HttpPublishedAssetsGet (string id)



This endpoint lists all the published assets which are stored in the database if asset is still valid.

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using AgravityPublic.Api;
using AgravityPublic.Client;
using AgravityPublic.Model;

namespace Example
{
    public class HttpPublishedAssetsGetExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "http://localhost:7072/api";
            // Configure API key authorization: function_key
            Configuration.Default.AddApiKey("x-functions-key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("x-functions-key", "Bearer");

            var apiInstance = new PublicAssetPublishingApi(Configuration.Default);
            var id = id_example;  // string | The ID of the asset.

            try
            {
                PublishEntity result = apiInstance.HttpPublishedAssetsGet(id);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling PublicAssetPublishingApi.HttpPublishedAssetsGet: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| The ID of the asset. | 

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

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## HttpPublishedAssetsGetById

> PublishedAsset HttpPublishedAssetsGetById (string id, string pid)



This endpoint returns one single published asset (from ID). Not checked if assetId is not deleted!

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using AgravityPublic.Api;
using AgravityPublic.Client;
using AgravityPublic.Model;

namespace Example
{
    public class HttpPublishedAssetsGetByIdExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "http://localhost:7072/api";
            // Configure API key authorization: function_key
            Configuration.Default.AddApiKey("x-functions-key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("x-functions-key", "Bearer");

            var apiInstance = new PublicAssetPublishingApi(Configuration.Default);
            var id = id_example;  // string | The ID of the asset.
            var pid = pid_example;  // string | The published asset ID.

            try
            {
                PublishedAsset result = apiInstance.HttpPublishedAssetsGetById(id, pid);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling PublicAssetPublishingApi.HttpPublishedAssetsGetById: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| The ID of the asset. | 
 **pid** | **string**| The published asset ID. | 

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

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)

