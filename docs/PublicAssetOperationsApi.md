# Agravity.Public.Api.PublicAssetOperationsApi

All URIs are relative to *http://localhost:7072/api*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**HttpAssetImageEdit**](PublicAssetOperationsApi.md#httpassetimageedit) | **GET** /assets/{id}/imageedit |  |
| [**HttpAssetResize**](PublicAssetOperationsApi.md#httpassetresize) | **GET** /assets/{id}/resize |  |
| [**HttpAssetToCollection**](PublicAssetOperationsApi.md#httpassettocollection) | **POST** /assets/{id}/tocollection |  |
| [**HttpGetAssetBlob**](PublicAssetOperationsApi.md#httpgetassetblob) | **GET** /assets/{id}/blobs |  |
| [**HttpGetAssetCollectionsById**](PublicAssetOperationsApi.md#httpgetassetcollectionsbyid) | **GET** /assets/{id}/collections |  |
| [**HttpGetAssetDownload**](PublicAssetOperationsApi.md#httpgetassetdownload) | **GET** /assets/{id}/download |  |
| [**HttpGetSharedAssetBlob**](PublicAssetOperationsApi.md#httpgetsharedassetblob) | **GET** /assets/{id}/blob |  |
| [**HttpImageDynamicEdit**](PublicAssetOperationsApi.md#httpimagedynamicedit) | **POST** /assets/{id}/imageedit |  |
| [**HttpImageDynamicGetFromDownloadId**](PublicAssetOperationsApi.md#httpimagedynamicgetfromdownloadid) | **GET** /assets/{id}/imageedit/{download_format_id} |  |
| [**HttpPutAssetAvailability**](PublicAssetOperationsApi.md#httpputassetavailability) | **PUT** /assets/{id}/availability |  |

<a id="httpassetimageedit"></a>
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
| **400** | Asset has to be image! Not allowed on type (Code: ec482f52-0ec8-4a8b-89fd-65b9d6b624cd)&lt;br&gt;Asset does not have origsize or optimized blob reference. (Code: b6733be7 -8560-4b1a-8dfc-657ac668ffea) |  -  |
| **401** | Unauthorized. API Key not provided. |  -  |
| **404** | The requested item could not be found. |  -  |
| **500** | Internal server error. Please contact administrator. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="httpassetresize"></a>
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
| **404** | The requested item could not be found. |  -  |
| **500** | Internal server error. Please contact administrator. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="httpassettocollection"></a>
# **HttpAssetToCollection**
> void HttpAssetToCollection (string id, MoveCollectionBody moveCollectionBody)



This endpoint allows to move/assign from/to another collection with the given operation parameter.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Agravity.Public.Api;
using Agravity.Public.Client;
using Agravity.Public.Model;

namespace Example
{
    public class HttpAssetToCollectionExample
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
            var moveCollectionBody = new MoveCollectionBody(); // MoveCollectionBody | Contains information about this operation.

            try
            {
                apiInstance.HttpAssetToCollection(id, moveCollectionBody);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling PublicAssetOperationsApi.HttpAssetToCollection: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the HttpAssetToCollectionWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    apiInstance.HttpAssetToCollectionWithHttpInfo(id, moveCollectionBody);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling PublicAssetOperationsApi.HttpAssetToCollectionWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **string** | The ID of the asset. |  |
| **moveCollectionBody** | [**MoveCollectionBody**](MoveCollectionBody.md) | Contains information about this operation. |  |

### Return type

void (empty response body)

### Authorization

[function_key](../README.md#function_key)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **400** | Internal error. Request or Database client are null. (Code: 21814e91-379c-4c35-8ff9-974147ba6b76) |  -  |
| **401** | Unauthorized. API Key not provided. |  -  |
| **204** | Moves/assigns a single asset from/to collection with the given operation parameter. |  -  |
| **404** | The requested item could not be found. |  -  |
| **500** | Internal server error. Please contact administrator. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="httpgetassetblob"></a>
# **HttpGetAssetBlob**
> AssetBlob HttpGetAssetBlob (string id, string c, string portalId = null, string key = null)



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
            var c = "c_example";  // string | \"t\" for thumbnail (default); \"op\" for optimized; \"os\" for original size; \"o\" for original.
            var portalId = "portalId_example";  // string | If the request comes from portal this is the indicator. If used the \"key\" param becomes mandatory. (optional) 
            var key = "key_example";  // string | The key is the MD5 hash of the original blob of the asset. (optional) 

            try
            {
                AssetBlob result = apiInstance.HttpGetAssetBlob(id, c, portalId, key);
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
    ApiResponse<AssetBlob> response = apiInstance.HttpGetAssetBlobWithHttpInfo(id, c, portalId, key);
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
| **c** | **string** | \&quot;t\&quot; for thumbnail (default); \&quot;op\&quot; for optimized; \&quot;os\&quot; for original size; \&quot;o\&quot; for original. |  |
| **portalId** | **string** | If the request comes from portal this is the indicator. If used the \&quot;key\&quot; param becomes mandatory. | [optional]  |
| **key** | **string** | The key is the MD5 hash of the original blob of the asset. | [optional]  |

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
| **404** | The requested item could not be found. |  -  |
| **500** | Internal server error. Please contact administrator. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="httpgetassetcollectionsbyid"></a>
# **HttpGetAssetCollectionsById**
> List&lt;Collection&gt; HttpGetAssetCollectionsById (string id, string fields = null, bool? translations = null, string acceptLanguage = null)



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
            var acceptLanguage = "acceptLanguage_example";  // string | The requested language of the response. If not matching it falls back to default language. (optional) 

            try
            {
                List<Collection> result = apiInstance.HttpGetAssetCollectionsById(id, fields, translations, acceptLanguage);
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
    ApiResponse<List<Collection>> response = apiInstance.HttpGetAssetCollectionsByIdWithHttpInfo(id, fields, translations, acceptLanguage);
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
| **acceptLanguage** | **string** | The requested language of the response. If not matching it falls back to default language. | [optional]  |

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
| **404** | The requested item could not be found. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="httpgetassetdownload"></a>
# **HttpGetAssetDownload**
> AssetBlob HttpGetAssetDownload (string id, string c = null, string f = null, string portalId = null, string key = null)



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
            var c = "c_example";  // string | \"t\" for thumbnail (default); \"op\" for optimized; \"os\" for original size; \"o\" for original. (optional) 
            var f = "f_example";  // string | (optional) provide the id of any valid download format. (optional) 
            var portalId = "portalId_example";  // string | If the request comes from portal this is the indicator. It will be checked if the requested blob is valid for the portal. (optional) 
            var key = "key_example";  // string | The key is the MD5 hash of the original blob of the asset. (optional) 

            try
            {
                AssetBlob result = apiInstance.HttpGetAssetDownload(id, c, f, portalId, key);
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
    ApiResponse<AssetBlob> response = apiInstance.HttpGetAssetDownloadWithHttpInfo(id, c, f, portalId, key);
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
| **c** | **string** | \&quot;t\&quot; for thumbnail (default); \&quot;op\&quot; for optimized; \&quot;os\&quot; for original size; \&quot;o\&quot; for original. | [optional]  |
| **f** | **string** | (optional) provide the id of any valid download format. | [optional]  |
| **portalId** | **string** | If the request comes from portal this is the indicator. It will be checked if the requested blob is valid for the portal. | [optional]  |
| **key** | **string** | The key is the MD5 hash of the original blob of the asset. | [optional]  |

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
| **404** | The requested item could not be found. |  -  |
| **500** | Internal server error. Please contact administrator. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="httpgetsharedassetblob"></a>
# **HttpGetSharedAssetBlob**
> AssetBlob HttpGetSharedAssetBlob (string shareId, string id, string format, string ayPassword = null)



This endpoint checks, if an asset exists, is an image, has original blob, is status active, is part of the shared collection and returns the requested asset blob.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Agravity.Public.Api;
using Agravity.Public.Client;
using Agravity.Public.Model;

namespace Example
{
    public class HttpGetSharedAssetBlobExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost:7072/api";
            var apiInstance = new PublicAssetOperationsApi(config);
            var shareId = "shareId_example";  // string | This share ID is like an API key. Check on validy (format, expire, collection still availabe). Otherwise StatusCode 403 (Forbidden) is returned.
            var id = "id_example";  // string | The ID of the asset.
            var format = "format_example";  // string | Which download format the blob is requested.
            var ayPassword = "ayPassword_example";  // string | If shared collection has a password, this header is mandatory. Otherwise StatusCode 403 (Forbidden) is returned. (optional) 

            try
            {
                AssetBlob result = apiInstance.HttpGetSharedAssetBlob(shareId, id, format, ayPassword);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling PublicAssetOperationsApi.HttpGetSharedAssetBlob: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the HttpGetSharedAssetBlobWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<AssetBlob> response = apiInstance.HttpGetSharedAssetBlobWithHttpInfo(shareId, id, format, ayPassword);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling PublicAssetOperationsApi.HttpGetSharedAssetBlobWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **shareId** | **string** | This share ID is like an API key. Check on validy (format, expire, collection still availabe). Otherwise StatusCode 403 (Forbidden) is returned. |  |
| **id** | **string** | The ID of the asset. |  |
| **format** | **string** | Which download format the blob is requested. |  |
| **ayPassword** | **string** | If shared collection has a password, this header is mandatory. Otherwise StatusCode 403 (Forbidden) is returned. | [optional]  |

### Return type

[**AssetBlob**](AssetBlob.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Returns the asset blob (incl. URL) for the requested asset according to the input parameter(s) |  -  |
| **400** | Asset has to be image! Not allowed on type (Code: ec482f52-0ec8-4a8b-89fd-65b9d6b624cd) |  -  |
| **404** | The requested item could not be found. |  -  |
| **500** | Internal server error. Please contact administrator. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="httpimagedynamicedit"></a>
# **HttpImageDynamicEdit**
> System.IO.Stream HttpImageDynamicEdit (string id, List<DynamicImageOperation> dynamicImageOperation, string targetFilename = null)



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
            var targetFilename = "targetFilename_example";  // string | If the file should have a specific naming. (optional) 

            try
            {
                System.IO.Stream result = apiInstance.HttpImageDynamicEdit(id, dynamicImageOperation, targetFilename);
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
    ApiResponse<System.IO.Stream> response = apiInstance.HttpImageDynamicEditWithHttpInfo(id, dynamicImageOperation, targetFilename);
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
| **targetFilename** | **string** | If the file should have a specific naming. | [optional]  |

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
| **400** | Asset has to be image! Not allowed on type: {type} (Code: ec482f52-0ec8-4a8b-89fd-65b9d6b624cd)&lt;br&gt;Not a valid asset used. It has to be an asset, not deleted and from type {type} (Code: 320cda1c-7dd8-4b23-9b59-51ccee5e0a98)&lt;br&gt; |  -  |
| **401** | Unauthorized. API Key not provided. |  -  |
| **404** | The requested item could not be found. |  -  |
| **500** | Internal server error. Please contact administrator. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="httpimagedynamicgetfromdownloadid"></a>
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
| **400** | Asset has to be image! Not allowed on type: {type} (Code: ec482f52-0ec8-4a8b-89fd-65b9d6b624cd)&lt;br&gt;The ID given is missing or not a valid download format ID. (Code: 7ec8d75d-3da4-4dce-8ab2-e52f0cf5f1f1)&lt;br&gt;Not a valid asset used. It has to be an asset, not deleted and from type {type} (Code: 320cda1c-7dd8-4b23-9b59-51ccee5e0a98)&lt;br&gt;Could not find requested download format. (Code: 05985771-df5e-4620-9b58-785177a1b223)&lt;br&gt; |  -  |
| **401** | Unauthorized. API Key not provided. |  -  |
| **404** | The requested item could not be found. |  -  |
| **500** | Internal server error. Please contact administrator. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="httpputassetavailability"></a>
# **HttpPutAssetAvailability**
> AssetAvailability HttpPutAssetAvailability (string id, AssetAvailability assetAvailability)



This endpoint sets the availability of the asset. All properties are put on the asset and replace previous values.To make an asset unavailable set the `availability` property to 'locked' or set the `available_from` property below the current date. To make it available set empty string to `availability` property or `available_to` property into past.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Agravity.Public.Api;
using Agravity.Public.Client;
using Agravity.Public.Model;

namespace Example
{
    public class HttpPutAssetAvailabilityExample
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
            var assetAvailability = new AssetAvailability(); // AssetAvailability | The values are validated and put directly on the asset.

            try
            {
                AssetAvailability result = apiInstance.HttpPutAssetAvailability(id, assetAvailability);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling PublicAssetOperationsApi.HttpPutAssetAvailability: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the HttpPutAssetAvailabilityWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<AssetAvailability> response = apiInstance.HttpPutAssetAvailabilityWithHttpInfo(id, assetAvailability);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling PublicAssetOperationsApi.HttpPutAssetAvailabilityWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **string** | The ID of the asset. |  |
| **assetAvailability** | [**AssetAvailability**](AssetAvailability.md) | The values are validated and put directly on the asset. |  |

### Return type

[**AssetAvailability**](AssetAvailability.md)

### Authorization

[function_key](../README.md#function_key)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | The values are return which are put on the asset. |  -  |
| **400** | Could not parse the asset availability object. (Code: 85ba8328-9181-4d74-a326-4073b17346d8)&lt;br&gt;Object is not a valid asset availability object. (Code: 5515ebe5-2751-4760-a864-47812126b9a1)&lt;br&gt;Asset availability has a confusing state: {updated.Availability}. (Code: 5515ebe5-2751-4760-a864-47812126b9a1)&lt;br&gt;Ambiguous information: Asset available_from can not be greater or equal as available_to when asset should be available.(Code: 16338bcd-614c-4322-a164-e3112d622392 )&lt;br&gt;Ambiguous information: Asset available_from can not be less or equal as available_to when asset should be locked and is not in the future. (Code: 092ddb50-2af8-49a1-b005-68c9d5c600d1)&lt;br&gt;Error on upsert asset availability in database - max retry count is reached. (Code: 98a80b23-bf8d-4cc1-ad6c-08cd69214dcd) &lt;br&gt; |  -  |
| **401** | Unauthorized. API Key not provided. |  -  |
| **500** | Internal server error. Please contact administrator. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

