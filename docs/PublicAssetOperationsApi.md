# Agravity.Public.Api.PublicAssetOperationsApi

All URIs are relative to *http://localhost:7072/api*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**HttpAssetImageEdit**](PublicAssetOperationsApi.md#httpassetimageedit) | **GET** /assets/{id}/imageedit |  |
| [**HttpAssetResize**](PublicAssetOperationsApi.md#httpassetresize) | **GET** /assets/{id}/resize |  |
| [**HttpGetAssetBlob**](PublicAssetOperationsApi.md#httpgetassetblob) | **GET** /assets/{id}/blobs |  |
| [**HttpGetAssetCollectionsById**](PublicAssetOperationsApi.md#httpgetassetcollectionsbyid) | **GET** /assets/{id}/collections |  |
| [**HttpGetAssetDownload**](PublicAssetOperationsApi.md#httpgetassetdownload) | **GET** /assets/{id}/download |  |
| [**HttpImageDynamicEdit**](PublicAssetOperationsApi.md#httpimagedynamicedit) | **POST** /assets/{id}/imageedit |  |
| [**HttpImageDynamicGetFromDownloadId**](PublicAssetOperationsApi.md#httpimagedynamicgetfromdownloadid) | **GET** /assets/{id}/imageedit/{download_format_id} |  |

<a name="httpassetimageedit"></a>
# **HttpAssetImageEdit**
> System.IO.Stream HttpAssetImageEdit (string id, int? width = null, int? height = null, string mode = null, string target = null, string bgcolor = null, int? dpi = null, int? depth = null, int? quality = null, string colorspace = null, int? cropX = null, int? cropY = null, int? cropWidth = null, int? cropHeight = null, string filter = null, bool? original = null)



This endpoint lets you resize/modify the image asset according to the given parameter(s).

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Agravity.Public.Api;
using Agravity.Public.Client;
using Agravity.Public.Model;

namespace Example
{
    public class HttpAssetImageEditExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost:7072/api";
            // Configure API key authorization: function_key
            config.AddApiKey("x-functions-key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("x-functions-key", "Bearer");

            var apiInstance = new PublicAssetOperationsApi(config);
            var id = "id_example";  // string | The ID of the asset.
            var width = 56;  // int? | The width of the final image. (optional) 
            var height = 56;  // int? | The height of the final image. (optional) 
            var mode = "mode_example";  // string | The supported modes: contain (default), cover, fill, crop, none (optional) 
            var target = "target_example";  // string | The file type which the image should be (i.e. webp, png, jpg, gif) (optional) 
            var bgcolor = "bgcolor_example";  // string | The color of the background color if background is visible (crop outside, png). RGB(A) in hex code (i.e. 00FFAA or with alpha channel: 44AABB77) and color names (i.e. lightgray) supported - default: transparent (optional) 
            var dpi = 56;  // int? | The density (counts for X and Y) of the target image. (optional) 
            var depth = 56;  // int? | The bit depth of the target image. (optional) 
            var quality = 56;  // int? | The quality of the target image (1-100). (optional) 
            var colorspace = "colorspace_example";  // string | The color space of the image (Default: sRGB). (optional) 
            var cropX = 56;  // int? | If mode is crop: The x coordinate of the point (if image is extended (outside) it is negative) (optional) 
            var cropY = 56;  // int? | If mode is crop: The y coordinate of the point (if image is extended (outside) it is negative) (optional) 
            var cropWidth = 56;  // int? | If mode=crop: The width of the cropping rectangle (from original pixel) (optional) 
            var cropHeight = 56;  // int? | If mode=crop: The height of the cropping rectangle (from original pixel) (optional) 
            var filter = "filter_example";  // string | Which filter should be applied. To get all filters available use: /api/helper/imageeditfilters (optional) 
            var original = true;  // bool? | If set to true the internal image is used instead of the default original (optional) 

            try
            {
                System.IO.Stream result = apiInstance.HttpAssetImageEdit(id, width, height, mode, target, bgcolor, dpi, depth, quality, colorspace, cropX, cropY, cropWidth, cropHeight, filter, original);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling PublicAssetOperationsApi.HttpAssetImageEdit: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the HttpAssetImageEditWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<System.IO.Stream> response = apiInstance.HttpAssetImageEditWithHttpInfo(id, width, height, mode, target, bgcolor, dpi, depth, quality, colorspace, cropX, cropY, cropWidth, cropHeight, filter, original);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling PublicAssetOperationsApi.HttpAssetImageEditWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **string** | The ID of the asset. |  |
| **width** | **int?** | The width of the final image. | [optional]  |
| **height** | **int?** | The height of the final image. | [optional]  |
| **mode** | **string** | The supported modes: contain (default), cover, fill, crop, none | [optional]  |
| **target** | **string** | The file type which the image should be (i.e. webp, png, jpg, gif) | [optional]  |
| **bgcolor** | **string** | The color of the background color if background is visible (crop outside, png). RGB(A) in hex code (i.e. 00FFAA or with alpha channel: 44AABB77) and color names (i.e. lightgray) supported - default: transparent | [optional]  |
| **dpi** | **int?** | The density (counts for X and Y) of the target image. | [optional]  |
| **depth** | **int?** | The bit depth of the target image. | [optional]  |
| **quality** | **int?** | The quality of the target image (1-100). | [optional]  |
| **colorspace** | **string** | The color space of the image (Default: sRGB). | [optional]  |
| **cropX** | **int?** | If mode is crop: The x coordinate of the point (if image is extended (outside) it is negative) | [optional]  |
| **cropY** | **int?** | If mode is crop: The y coordinate of the point (if image is extended (outside) it is negative) | [optional]  |
| **cropWidth** | **int?** | If mode&#x3D;crop: The width of the cropping rectangle (from original pixel) | [optional]  |
| **cropHeight** | **int?** | If mode&#x3D;crop: The height of the cropping rectangle (from original pixel) | [optional]  |
| **filter** | **string** | Which filter should be applied. To get all filters available use: /api/helper/imageeditfilters | [optional]  |
| **original** | **bool?** | If set to true the internal image is used instead of the default original | [optional]  |

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

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="httpassetresize"></a>
# **HttpAssetResize**
> System.IO.Stream HttpAssetResize (string id)



This endpoint lets you resize/modify the image asset according to the given parameter(s).

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Agravity.Public.Api;
using Agravity.Public.Client;
using Agravity.Public.Model;

namespace Example
{
    public class HttpAssetResizeExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost:7072/api";
            // Configure API key authorization: function_key
            config.AddApiKey("x-functions-key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("x-functions-key", "Bearer");

            var apiInstance = new PublicAssetOperationsApi(config);
            var id = "id_example";  // string | The ID of the asset.

            try
            {
                System.IO.Stream result = apiInstance.HttpAssetResize(id);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling PublicAssetOperationsApi.HttpAssetResize: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the HttpAssetResizeWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<System.IO.Stream> response = apiInstance.HttpAssetResizeWithHttpInfo(id);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling PublicAssetOperationsApi.HttpAssetResizeWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **string** | The ID of the asset. |  |

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

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="httpgetassetblob"></a>
# **HttpGetAssetBlob**
> AssetBlob HttpGetAssetBlob (string id, string c)



This endpoint checks, if an asset exists and returns the url for the requested blob.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Agravity.Public.Api;
using Agravity.Public.Client;
using Agravity.Public.Model;

namespace Example
{
    public class HttpGetAssetBlobExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost:7072/api";
            // Configure API key authorization: function_key
            config.AddApiKey("x-functions-key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("x-functions-key", "Bearer");

            var apiInstance = new PublicAssetOperationsApi(config);
            var id = "id_example";  // string | The ID of the asset.
            var c = "c_example";  // string | \"t\" for thumbnail (default); \"o\" for optimized; \"i\" for internal.

            try
            {
                AssetBlob result = apiInstance.HttpGetAssetBlob(id, c);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling PublicAssetOperationsApi.HttpGetAssetBlob: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the HttpGetAssetBlobWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<AssetBlob> response = apiInstance.HttpGetAssetBlobWithHttpInfo(id, c);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling PublicAssetOperationsApi.HttpGetAssetBlobWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **string** | The ID of the asset. |  |
| **c** | **string** | \&quot;t\&quot; for thumbnail (default); \&quot;o\&quot; for optimized; \&quot;i\&quot; for internal. |  |

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

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="httpgetassetcollectionsbyid"></a>
# **HttpGetAssetCollectionsById**
> List&lt;Collection&gt; HttpGetAssetCollectionsById (string id, string fields = null, bool? translations = null)



Returns all collections of a specific asset.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Agravity.Public.Api;
using Agravity.Public.Client;
using Agravity.Public.Model;

namespace Example
{
    public class HttpGetAssetCollectionsByIdExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost:7072/api";
            // Configure API key authorization: function_key
            config.AddApiKey("x-functions-key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("x-functions-key", "Bearer");

            var apiInstance = new PublicAssetOperationsApi(config);
            var id = "id_example";  // string | The ID of the asset.
            var fields = "fields_example";  // string | This limits the fields which are returned, separated by comma (','). (optional) 
            var translations = true;  // bool? | When default language should be returned and the translation dictionary is delivered. (Ignores the \"Accept-Language\" header) (optional) 

            try
            {
                List<Collection> result = apiInstance.HttpGetAssetCollectionsById(id, fields, translations);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling PublicAssetOperationsApi.HttpGetAssetCollectionsById: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the HttpGetAssetCollectionsByIdWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<List<Collection>> response = apiInstance.HttpGetAssetCollectionsByIdWithHttpInfo(id, fields, translations);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling PublicAssetOperationsApi.HttpGetAssetCollectionsByIdWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **string** | The ID of the asset. |  |
| **fields** | **string** | This limits the fields which are returned, separated by comma (&#39;,&#39;). | [optional]  |
| **translations** | **bool?** | When default language should be returned and the translation dictionary is delivered. (Ignores the \&quot;Accept-Language\&quot; header) | [optional]  |

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

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="httpgetassetdownload"></a>
# **HttpGetAssetDownload**
> AssetBlob HttpGetAssetDownload (string id, string c = null)



This endpoint is similar to GetAssetBlob but with ContentDistribution and filename to let browser download the content.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Agravity.Public.Api;
using Agravity.Public.Client;
using Agravity.Public.Model;

namespace Example
{
    public class HttpGetAssetDownloadExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost:7072/api";
            // Configure API key authorization: function_key
            config.AddApiKey("x-functions-key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("x-functions-key", "Bearer");

            var apiInstance = new PublicAssetOperationsApi(config);
            var id = "id_example";  // string | The ID of the asset.
            var c = "c_example";  // string | \"t\" for thumbnail (default); \"o\" for optimized; \"i\" for internal. (optional) 

            try
            {
                AssetBlob result = apiInstance.HttpGetAssetDownload(id, c);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling PublicAssetOperationsApi.HttpGetAssetDownload: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the HttpGetAssetDownloadWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<AssetBlob> response = apiInstance.HttpGetAssetDownloadWithHttpInfo(id, c);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling PublicAssetOperationsApi.HttpGetAssetDownloadWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **string** | The ID of the asset. |  |
| **c** | **string** | \&quot;t\&quot; for thumbnail (default); \&quot;o\&quot; for optimized; \&quot;i\&quot; for internal. | [optional]  |

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

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="httpimagedynamicedit"></a>
# **HttpImageDynamicEdit**
> System.IO.Stream HttpImageDynamicEdit (string id, List<DynamicImageOperation> dynamicImageOperation)



This endpoint lets you use the entire api of Imagemagick to edit the image.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Agravity.Public.Api;
using Agravity.Public.Client;
using Agravity.Public.Model;

namespace Example
{
    public class HttpImageDynamicEditExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost:7072/api";
            // Configure API key authorization: function_key
            config.AddApiKey("x-functions-key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("x-functions-key", "Bearer");

            var apiInstance = new PublicAssetOperationsApi(config);
            var id = "id_example";  // string | The ID of the asset.
            var dynamicImageOperation = new List<DynamicImageOperation>(); // List<DynamicImageOperation> | Operations to be performed on the image directly mapped to c# imagemagick sdk

            try
            {
                System.IO.Stream result = apiInstance.HttpImageDynamicEdit(id, dynamicImageOperation);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling PublicAssetOperationsApi.HttpImageDynamicEdit: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the HttpImageDynamicEditWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<System.IO.Stream> response = apiInstance.HttpImageDynamicEditWithHttpInfo(id, dynamicImageOperation);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling PublicAssetOperationsApi.HttpImageDynamicEditWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **string** | The ID of the asset. |  |
| **dynamicImageOperation** | [**List&lt;DynamicImageOperation&gt;**](DynamicImageOperation.md) | Operations to be performed on the image directly mapped to c# imagemagick sdk |  |

### Return type

**System.IO.Stream**

### Authorization

[function_key](../README.md#function_key)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: image/xyz, application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Returns the resized/modified image according to the input parameter(s) |  -  |
| **400** | Asset has to be image! Not allowed on type: {type} (Code: ec482f52-0ec8-4a8b-89fd-65b9d6b624cd) Not a valid asset used. It has to be an asset, not deleted and from type {type} (Code: 320cda1c-7dd8-4b23-9b59-51ccee5e0a98)  |  -  |
| **401** | Unauthorized. API Key not provided. |  -  |
| **404** | The requested item could not be found |  -  |
| **500** | Internal server error. Please contact administrator. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="httpimagedynamicgetfromdownloadid"></a>
# **HttpImageDynamicGetFromDownloadId**
> System.IO.Stream HttpImageDynamicGetFromDownloadId (string id, string downloadFormatId)



This endpoint returns an image with the requested download format applied.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Agravity.Public.Api;
using Agravity.Public.Client;
using Agravity.Public.Model;

namespace Example
{
    public class HttpImageDynamicGetFromDownloadIdExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost:7072/api";
            // Configure API key authorization: function_key
            config.AddApiKey("x-functions-key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("x-functions-key", "Bearer");

            var apiInstance = new PublicAssetOperationsApi(config);
            var id = "id_example";  // string | The ID of the asset.
            var downloadFormatId = "downloadFormatId_example";  // string | The ID of the download format.

            try
            {
                System.IO.Stream result = apiInstance.HttpImageDynamicGetFromDownloadId(id, downloadFormatId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling PublicAssetOperationsApi.HttpImageDynamicGetFromDownloadId: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the HttpImageDynamicGetFromDownloadIdWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<System.IO.Stream> response = apiInstance.HttpImageDynamicGetFromDownloadIdWithHttpInfo(id, downloadFormatId);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling PublicAssetOperationsApi.HttpImageDynamicGetFromDownloadIdWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **string** | The ID of the asset. |  |
| **downloadFormatId** | **string** | The ID of the download format. |  |

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
| **400** | Asset has to be image! Not allowed on type: {type} (Code: ec482f52-0ec8-4a8b-89fd-65b9d6b624cd) The ID given is missing or not a valid download format ID. (Code: 7ec8d75d-3da4-4dce-8ab2-e52f0cf5f1f1) Not a valid asset used. It has to be an asset, not deleted and from type {type} (Code: 320cda1c-7dd8-4b23-9b59-51ccee5e0a98) Could not find requested download format. (Code: 05985771-df5e-4620-9b58-785177a1b223)  |  -  |
| **401** | Unauthorized. API Key not provided. |  -  |
| **404** | The requested item could not be found |  -  |
| **500** | Internal server error. Please contact administrator. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

