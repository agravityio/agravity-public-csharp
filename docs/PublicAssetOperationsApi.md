# AgravityPublic.Api.PublicAssetOperationsApi

All URIs are relative to *http://localhost:7072/api*

Method | HTTP request | Description
------------- | ------------- | -------------
[**HttpAssetImageEdit**](PublicAssetOperationsApi.md#httpassetimageedit) | **GET** /assets/{id}/imageedit | 
[**HttpAssetImageRotateClockwise**](PublicAssetOperationsApi.md#httpassetimagerotateclockwise) | **POST** /assets/{id}/rotate | 
[**HttpAssetResize**](PublicAssetOperationsApi.md#httpassetresize) | **GET** /assets/{id}/resize | 
[**HttpAssetsGetSimilarById**](PublicAssetOperationsApi.md#httpassetsgetsimilarbyid) | **GET** /assets/{id}/similar | 
[**HttpGetAssetBlob**](PublicAssetOperationsApi.md#httpgetassetblob) | **GET** /assets/{id}/blobs | 
[**HttpGetAssetCollectionsById**](PublicAssetOperationsApi.md#httpgetassetcollectionsbyid) | **GET** /assets/{id}/collections | 
[**HttpGetAssetDownload**](PublicAssetOperationsApi.md#httpgetassetdownload) | **GET** /assets/{id}/download | 



## HttpAssetImageEdit

> System.IO.Stream HttpAssetImageEdit (string id)



This endpoint lets you resize/modify the image asset according to the given parameter(s).

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using AgravityPublic.Api;
using AgravityPublic.Client;
using AgravityPublic.Model;

namespace Example
{
    public class HttpAssetImageEditExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "http://localhost:7072/api";
            // Configure API key authorization: function_key
            Configuration.Default.AddApiKey("x-functions-key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("x-functions-key", "Bearer");

            var apiInstance = new PublicAssetOperationsApi(Configuration.Default);
            var id = "id_example";  // string | The ID of the asset.

            try
            {
                System.IO.Stream result = apiInstance.HttpAssetImageEdit(id);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling PublicAssetOperationsApi.HttpAssetImageEdit: " + e.Message );
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

**System.IO.Stream**

### Authorization

[function_key](../README.md#function_key)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: image/xyz, application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Returns the resized/modified image according to the input parameter(s) |  -  |
| **400** | Asset has to be image! Not allowed on type (Code: ec482f52-0ec8-4a8b-89fd-65b9d6b624cd) Asset does not have origsize or optimized blob reference. (Code: b6733be7 -8560-4b1a-8dfc-657ac668ffea) |  -  |
| **401** | Unauthorized. API Key not provided. |  -  |
| **404** | The requested item could not be found |  -  |
| **500** | Internal server error. Please contact administrator. |  -  |

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## HttpAssetImageRotateClockwise

> Asset HttpAssetImageRotateClockwise (string id)



This endpoint lets you rotate an image or video clockwise in 90 degrees steps.

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using AgravityPublic.Api;
using AgravityPublic.Client;
using AgravityPublic.Model;

namespace Example
{
    public class HttpAssetImageRotateClockwiseExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "http://localhost:7072/api";
            // Configure API key authorization: function_key
            Configuration.Default.AddApiKey("x-functions-key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("x-functions-key", "Bearer");

            var apiInstance = new PublicAssetOperationsApi(Configuration.Default);
            var id = "id_example";  // string | The ID of the asset.

            try
            {
                Asset result = apiInstance.HttpAssetImageRotateClockwise(id);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling PublicAssetOperationsApi.HttpAssetImageRotateClockwise: " + e.Message );
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

[**Asset**](Asset.md)

### Authorization

[function_key](../README.md#function_key)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Rotates the image (including configured formats e.g. thumbnail, optimized) in 90 degree steps clockwise and returns the full asset including exposed blobs. |  -  |
| **400** | Please include a valid UUID (Code: 1e4b5087-fa0c-489d-ba18-b25ffa41d6ab)&lt;br/&gt;The document is not valid asset of type image or video or already deleted. (Code: eaa36577-c5de-4bd3-8572-eef7ed407b74)&lt;br/&gt;Blob not found with UUID: {id} (Code: 1523618d-4705-4efb-9409-03c791f4380e)&lt;br/&gt;Something went wrong on rotating thumbnail ({id}) rotate: {error message} - Type: ({exception type}) (Code: f28ec238-66b3-405c-b84e-27b691e6e4d9)&lt;br/&gt;Something went wrong on rotating optimized video ({id}) rotate: {error message} - Type: ({exception type}) (Code: d166322c-bf98-46b5-b2cc-ab1112fcc5d1)&lt;br/&gt;Something went wrong on rotate origsize image (&lt;id&gt;) rotate: &lt;error message&gt; - Type: (&lt;exception type&gt;) (Code: b501b995-6c87-4459-b8b0-82f6a09f6f73)&lt;br/&gt;Something went wrong on rotate optimized image ({id}) rotate: {error message} - Type: ({exception type}) (Code: 022ea0e8-b4b3-4988-a001-a88aea7362ce) |  -  |
| **404** | The requested item could not be found |  -  |
| **401** | Unauthorized. API Key not provided. |  -  |
| **500** | Internal server error. Please contact administrator. |  -  |

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## HttpAssetResize

> System.IO.Stream HttpAssetResize (string id)



This endpoint lets you resize/modify the image asset according to the given parameter(s).

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using AgravityPublic.Api;
using AgravityPublic.Client;
using AgravityPublic.Model;

namespace Example
{
    public class HttpAssetResizeExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "http://localhost:7072/api";
            // Configure API key authorization: function_key
            Configuration.Default.AddApiKey("x-functions-key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("x-functions-key", "Bearer");

            var apiInstance = new PublicAssetOperationsApi(Configuration.Default);
            var id = "id_example";  // string | The ID of the asset.

            try
            {
                System.IO.Stream result = apiInstance.HttpAssetResize(id);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling PublicAssetOperationsApi.HttpAssetResize: " + e.Message );
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

**System.IO.Stream**

### Authorization

[function_key](../README.md#function_key)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: image/xyz, application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Returns the resized/modified image according to the input parameter(s) |  -  |
| **400** | Asset has to be image! Not allowed on type (Code: ec482f52-0ec8-4a8b-89fd-65b9d6b624cd) |  -  |
| **401** | Unauthorized. API Key not provided. |  -  |
| **404** | The requested item could not be found |  -  |
| **500** | Internal server error. Please contact administrator. |  -  |

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## HttpAssetsGetSimilarById

> List&lt;PerHashResult&gt; HttpAssetsGetSimilarById (string id)



This endpoint is only for active image-assets (asset-type=image) and given perhash property. It compares against all other image assets and calculates distances for similar images.

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using AgravityPublic.Api;
using AgravityPublic.Client;
using AgravityPublic.Model;

namespace Example
{
    public class HttpAssetsGetSimilarByIdExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "http://localhost:7072/api";
            // Configure API key authorization: function_key
            Configuration.Default.AddApiKey("x-functions-key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("x-functions-key", "Bearer");

            var apiInstance = new PublicAssetOperationsApi(Configuration.Default);
            var id = "id_example";  // string | The ID of the asset.

            try
            {
                List<PerHashResult> result = apiInstance.HttpAssetsGetSimilarById(id);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling PublicAssetOperationsApi.HttpAssetsGetSimilarById: " + e.Message );
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

[**List&lt;PerHashResult&gt;**](PerHashResult.md)

### Authorization

[function_key](../README.md#function_key)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Returns similar images (based on a configurable perceptual hash distance). |  -  |
| **401** | Unauthorized. API Key not provided. |  -  |
| **404** | The requested item could not be found |  -  |
| **422** | The requested item does not have a value |  -  |

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## HttpGetAssetBlob

> AssetBlob HttpGetAssetBlob (string id, string c)



This endpoint checks, if an asset exists and returns the url for the requested blob.

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using AgravityPublic.Api;
using AgravityPublic.Client;
using AgravityPublic.Model;

namespace Example
{
    public class HttpGetAssetBlobExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "http://localhost:7072/api";
            // Configure API key authorization: function_key
            Configuration.Default.AddApiKey("x-functions-key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("x-functions-key", "Bearer");

            var apiInstance = new PublicAssetOperationsApi(Configuration.Default);
            var id = "id_example";  // string | The ID of the asset.
            var c = "c_example";  // string | \"t\" for thumbnail (default); \"o\" for optimized; \"i\" for internal.

            try
            {
                AssetBlob result = apiInstance.HttpGetAssetBlob(id, c);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling PublicAssetOperationsApi.HttpGetAssetBlob: " + e.Message );
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
 **c** | **string**| \&quot;t\&quot; for thumbnail (default); \&quot;o\&quot; for optimized; \&quot;i\&quot; for internal. | 

### Return type

[**AssetBlob**](AssetBlob.md)

### Authorization

[function_key](../README.md#function_key)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | This function checks if asset exist on storage and returns the asset blob (incl. url). |  -  |
| **401** | Unauthorized. API Key not provided. |  -  |
| **404** | The requested item could not be found |  -  |
| **500** | Internal server error. Please contact administrator. |  -  |

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## HttpGetAssetCollectionsById

> List&lt;Collection&gt; HttpGetAssetCollectionsById (string id)



Returns all collections of a specific asset.

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using AgravityPublic.Api;
using AgravityPublic.Client;
using AgravityPublic.Model;

namespace Example
{
    public class HttpGetAssetCollectionsByIdExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "http://localhost:7072/api";
            // Configure API key authorization: function_key
            Configuration.Default.AddApiKey("x-functions-key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("x-functions-key", "Bearer");

            var apiInstance = new PublicAssetOperationsApi(Configuration.Default);
            var id = "id_example";  // string | The ID of the asset.

            try
            {
                List<Collection> result = apiInstance.HttpGetAssetCollectionsById(id);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling PublicAssetOperationsApi.HttpGetAssetCollectionsById: " + e.Message );
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

**List<Collection>**

### Authorization

[function_key](../README.md#function_key)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Returns all collections of a specific asset. |  -  |
| **401** | Unauthorized. API Key not provided. |  -  |
| **404** | The requested item could not be found |  -  |

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## HttpGetAssetDownload

> AssetBlob HttpGetAssetDownload (string id, string c = null)



This endpoint is similar to GetAssetBlob but with ContentDistribution and filename to let browser download the content.

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using AgravityPublic.Api;
using AgravityPublic.Client;
using AgravityPublic.Model;

namespace Example
{
    public class HttpGetAssetDownloadExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "http://localhost:7072/api";
            // Configure API key authorization: function_key
            Configuration.Default.AddApiKey("x-functions-key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("x-functions-key", "Bearer");

            var apiInstance = new PublicAssetOperationsApi(Configuration.Default);
            var id = "id_example";  // string | The ID of the asset.
            var c = "c_example";  // string | \"t\" for thumbnail (default); \"o\" for optimized; \"i\" for internal. (optional) 

            try
            {
                AssetBlob result = apiInstance.HttpGetAssetDownload(id, c);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling PublicAssetOperationsApi.HttpGetAssetDownload: " + e.Message );
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
 **c** | **string**| \&quot;t\&quot; for thumbnail (default); \&quot;o\&quot; for optimized; \&quot;i\&quot; for internal. | [optional] 

### Return type

[**AssetBlob**](AssetBlob.md)

### Authorization

[function_key](../README.md#function_key)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | This function checks if asset exist on storage and returns the asset blob (incl. url to download). |  -  |
| **401** | Unauthorized. API Key not provided. |  -  |
| **404** | The requested item could not be found |  -  |
| **500** | Internal server error. Please contact administrator. |  -  |

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)

