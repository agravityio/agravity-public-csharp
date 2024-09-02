# Agravity.Public.Api.AssetOperationsApi

All URIs are relative to *http://localhost:7071/api*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**HttpAssetImageEdit**](AssetOperationsApi.md#httpassetimageedit) | **GET** /assets/{id}/imageedit |  |
| [**HttpAssetImageRotateClockwise**](AssetOperationsApi.md#httpassetimagerotateclockwise) | **POST** /assets/{id}/rotate |  |
| [**HttpAssetResize**](AssetOperationsApi.md#httpassetresize) | **GET** /assets/{id}/resize |  |
| [**HttpAssetToCollection**](AssetOperationsApi.md#httpassettocollection) | **POST** /assets/{id}/tocollection |  |
| [**HttpAssetsToCollection**](AssetOperationsApi.md#httpassetstocollection) | **POST** /assetsoperations/tocollection |  |
| [**HttpDeleteAlternativeThumb**](AssetOperationsApi.md#httpdeletealternativethumb) | **DELETE** /assets/{id}/alternative |  |
| [**HttpDeleteSpecificBlob**](AssetOperationsApi.md#httpdeletespecificblob) | **DELETE** /assets/{id}/blobs/{name} |  |
| [**HttpGetAllAssetsCheckOnCriteria**](AssetOperationsApi.md#httpgetallassetscheckoncriteria) | **GET** /assetscheck |  |
| [**HttpGetAssetBlob**](AssetOperationsApi.md#httpgetassetblob) | **GET** /assets/{id}/blobs |  |
| [**HttpGetAssetCollectionsById**](AssetOperationsApi.md#httpgetassetcollectionsbyid) | **GET** /assets/{id}/collections |  |
| [**HttpGetAssetDownload**](AssetOperationsApi.md#httpgetassetdownload) | **GET** /assets/{id}/download |  |
| [**HttpGetAssetTechDataById**](AssetOperationsApi.md#httpgetassettechdatabyid) | **GET** /assets/{id}/techdata |  |
| [**HttpGetAssetTextContentById**](AssetOperationsApi.md#httpgetassettextcontentbyid) | **GET** /assets/{id}/textcontent |  |
| [**HttpImageDynamicEdit**](AssetOperationsApi.md#httpimagedynamicedit) | **POST** /assets/{id}/imageedit |  |
| [**HttpImageDynamicGetFromDownloadId**](AssetOperationsApi.md#httpimagedynamicgetfromdownloadid) | **GET** /assets/{id}/imageedit/{download_format_id} |  |
| [**HttpPatchAssetPurgeCdn**](AssetOperationsApi.md#httppatchassetpurgecdn) | **PATCH** /assets/{id}/purgecdn |  |
| [**HttpPatchAssetReindex**](AssetOperationsApi.md#httppatchassetreindex) | **PATCH** /assets/{id}/reindex |  |
| [**HttpPatchAssetRenew**](AssetOperationsApi.md#httppatchassetrenew) | **PATCH** /assets/{id}/renew |  |
| [**HttpPatchAssetRepair**](AssetOperationsApi.md#httppatchassetrepair) | **PATCH** /assets/{id}/repair |  |
| [**HttpPatchAssetRunQueue**](AssetOperationsApi.md#httppatchassetrunqueue) | **PATCH** /assets/{id}/runqueue/{queueInput} |  |
| [**HttpPatchRenewAllAssets**](AssetOperationsApi.md#httppatchrenewallassets) | **PATCH** /assetsrenew!! |  |
| [**HttpPutAssetAvailability**](AssetOperationsApi.md#httpputassetavailability) | **PUT** /assets/{id}/availability |  |

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
            config.BasePath = "http://localhost:7071/api";
            // Configure OAuth2 access token for authorization: msal_auth
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new AssetOperationsApi(config);
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
                Debug.Print("Exception when calling AssetOperationsApi.HttpAssetImageEdit: " + e.Message);
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
    Debug.Print("Exception when calling AssetOperationsApi.HttpAssetImageEditWithHttpInfo: " + e.Message);
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

[msal_auth](../README.md#msal_auth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: image/xyz, application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Returns the resized/modified image according to the input parameter(s) |  -  |
| **400** | Asset has to be image! Not allowed on type: {type} (Code: ec482f52-0ec8-4a8b-89fd-65b9d6b624cd)&lt;br&gt;Not a valid asset used. It has to be an asset, not deleted and from type {type} (Code: 320cda1c-7dd8-4b23-9b59-51ccee5e0a98)&lt;br&gt;Asset does not have origsize or optimized blob reference. (Code: b6733be7 -8560-4b1a-8dfc-657ac668ffea) |  -  |
| **401** | Unauthorized. Bearer Token not provided. |  -  |
| **404** | The requested item could not be found. |  -  |
| **500** | Internal server error. Please contact administrator. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="httpassetimagerotateclockwise"></a>
# **HttpAssetImageRotateClockwise**
> Asset HttpAssetImageRotateClockwise (string id, bool? translations = null, string acceptLanguage = null)



This endpoint lets you rotate an image clockwise in 90 degree steps.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Agravity.Public.Api;
using Agravity.Public.Client;
using Agravity.Public.Model;

namespace Example
{
    public class HttpAssetImageRotateClockwiseExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost:7071/api";
            // Configure OAuth2 access token for authorization: msal_auth
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new AssetOperationsApi(config);
            var id = "id_example";  // string | The ID of the asset.
            var translations = true;  // bool? | When default language should be returned and the translation dictionary is delivered. (Ignores the \"Accept-Language\" header) (optional) 
            var acceptLanguage = "acceptLanguage_example";  // string | The requested language of the response. If not matching it falls back to default language. (optional) 

            try
            {
                Asset result = apiInstance.HttpAssetImageRotateClockwise(id, translations, acceptLanguage);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AssetOperationsApi.HttpAssetImageRotateClockwise: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the HttpAssetImageRotateClockwiseWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<Asset> response = apiInstance.HttpAssetImageRotateClockwiseWithHttpInfo(id, translations, acceptLanguage);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling AssetOperationsApi.HttpAssetImageRotateClockwiseWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **string** | The ID of the asset. |  |
| **translations** | **bool?** | When default language should be returned and the translation dictionary is delivered. (Ignores the \&quot;Accept-Language\&quot; header) | [optional]  |
| **acceptLanguage** | **string** | The requested language of the response. If not matching it falls back to default language. | [optional]  |

### Return type

[**Asset**](Asset.md)

### Authorization

[msal_auth](../README.md#msal_auth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Rotates the image (including configured formats e.g. thumbnail, optimized) in 90 degree steps clockwise and returns the full asset including exposed blobs. |  -  |
| **400** | Please include a valid UUID (Code: 1e4b5087-fa0c-489d-ba18-b25ffa41d6ab)&lt;br/&gt;The document is not valid asset of type image or video or already deleted. (Code: eaa36577-c5de-4bd3-8572-eef7ed407b74)&lt;br/&gt;Blob not found with UUID: {id} (Code: 1523618d-4705-4efb-9409-03c791f4380e)&lt;br/&gt;Something went wrong on rotating thumbnail ({id}) rotate: {error message} - Type: ({exception type}) (Code: f28ec238-66b3-405c-b84e-27b691e6e4d9)&lt;br/&gt;Something went wrong on rotating optimized video ({id}) rotate: {error message} - Type: ({exception type}) (Code: d166322c-bf98-46b5-b2cc-ab1112fcc5d1)&lt;br/&gt;Something went wrong on rotate origsize image (&lt;id&gt;) rotate: &lt;error message&gt; - Type: (&lt;exception type&gt;) (Code: b501b995-6c87-4459-b8b0-82f6a09f6f73)&lt;br/&gt;Something went wrong on rotate optimized image ({id}) rotate: {error message} - Type: ({exception type}) (Code: 022ea0e8-b4b3-4988-a001-a88aea7362ce) |  -  |
| **404** | Blob not found with UUID: {id}. (Code: 1523618d-4705-4efb-9409-03c791f4380e) |  -  |
| **401** | Unauthorized. Bearer Token not provided. |  -  |
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
            config.BasePath = "http://localhost:7071/api";
            // Configure OAuth2 access token for authorization: msal_auth
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new AssetOperationsApi(config);
            var id = "id_example";  // string | The ID of the asset.

            try
            {
                System.IO.Stream result = apiInstance.HttpAssetResize(id);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AssetOperationsApi.HttpAssetResize: " + e.Message);
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
    Debug.Print("Exception when calling AssetOperationsApi.HttpAssetResizeWithHttpInfo: " + e.Message);
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

[msal_auth](../README.md#msal_auth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: image/xyz, application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Returns the resized/modified image according to the input parameter(s) |  -  |
| **400** | Asset has to be image! Not allowed on type: {type} (Code: ec482f52-0ec8-4a8b-89fd-65b9d6b624cd)&lt;br&gt;Not a valid asset used. It has to be an asset, not deleted and from type {type} (Code: 320cda1c-7dd8-4b23-9b59-51ccee5e0a98) |  -  |
| **401** | Unauthorized. Bearer Token not provided. |  -  |
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
            config.BasePath = "http://localhost:7071/api";
            // Configure OAuth2 access token for authorization: msal_auth
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new AssetOperationsApi(config);
            var id = "id_example";  // string | The ID of the asset.
            var moveCollectionBody = new MoveCollectionBody(); // MoveCollectionBody | Contains information about this operation.

            try
            {
                apiInstance.HttpAssetToCollection(id, moveCollectionBody);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AssetOperationsApi.HttpAssetToCollection: " + e.Message);
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
    Debug.Print("Exception when calling AssetOperationsApi.HttpAssetToCollectionWithHttpInfo: " + e.Message);
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

[msal_auth](../README.md#msal_auth)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **400** | Internal error. Request or Database client are null.. (Code: 21814e91-379c-4c35-8ff9-974147ba6b76) |  -  |
| **204** | Moves/assigns a single asset from/to collection with the given operation parameter. |  -  |
| **401** | Unauthorized. Bearer Token not provided. |  -  |
| **404** | The requested item could not be found. |  -  |
| **500** | Internal server error. Please contact administrator. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="httpassetstocollection"></a>
# **HttpAssetsToCollection**
> void HttpAssetsToCollection (AssetsOperationBody assetsOperationBody)



This endpoint allows to move/assign multiple assets from/to another collection with the given operation parameter.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Agravity.Public.Api;
using Agravity.Public.Client;
using Agravity.Public.Model;

namespace Example
{
    public class HttpAssetsToCollectionExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost:7071/api";
            // Configure OAuth2 access token for authorization: msal_auth
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new AssetOperationsApi(config);
            var assetsOperationBody = new AssetsOperationBody(); // AssetsOperationBody | Contains information which assets should be assigned to collection.

            try
            {
                apiInstance.HttpAssetsToCollection(assetsOperationBody);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AssetOperationsApi.HttpAssetsToCollection: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the HttpAssetsToCollectionWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    apiInstance.HttpAssetsToCollectionWithHttpInfo(assetsOperationBody);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling AssetOperationsApi.HttpAssetsToCollectionWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **assetsOperationBody** | [**AssetsOperationBody**](AssetsOperationBody.md) | Contains information which assets should be assigned to collection. |  |

### Return type

void (empty response body)

### Authorization

[msal_auth](../README.md#msal_auth)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **400** | Internal error. Request or Database client are null.. (Code: 72b50042-afb9-43ca-a447-6c4c8393a3d1) |  -  |
| **204** | Moves/assigns multiple assets from/to collection with the given operation parameter. |  -  |
| **401** | Unauthorized. Bearer Token not provided. |  -  |
| **500** | Internal server error. Please contact administrator. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="httpdeletealternativethumb"></a>
# **HttpDeleteAlternativeThumb**
> AgravityInfoResponse HttpDeleteAlternativeThumb (string id)



This endpoint deletes the alternative thumbnail blob of an asset and renews it

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Agravity.Public.Api;
using Agravity.Public.Client;
using Agravity.Public.Model;

namespace Example
{
    public class HttpDeleteAlternativeThumbExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost:7071/api";
            // Configure OAuth2 access token for authorization: msal_auth
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new AssetOperationsApi(config);
            var id = "id_example";  // string | The ID of the asset.

            try
            {
                AgravityInfoResponse result = apiInstance.HttpDeleteAlternativeThumb(id);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AssetOperationsApi.HttpDeleteAlternativeThumb: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the HttpDeleteAlternativeThumbWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<AgravityInfoResponse> response = apiInstance.HttpDeleteAlternativeThumbWithHttpInfo(id);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling AssetOperationsApi.HttpDeleteAlternativeThumbWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **string** | The ID of the asset. |  |

### Return type

[**AgravityInfoResponse**](AgravityInfoResponse.md)

### Authorization

[msal_auth](../README.md#msal_auth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Deletes the alternative thumbnail blob and renews the asset |  -  |
| **401** | Unauthorized. Bearer Token not provided. |  -  |
| **404** | The requested item could not be found |  -  |
| **500** | Internal server error. Please contact administrator. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="httpdeletespecificblob"></a>
# **HttpDeleteSpecificBlob**
> AgravityInfoResponse HttpDeleteSpecificBlob (string id, string name)



 This endpoint deletes a specific blob from the asset (if exists)

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Agravity.Public.Api;
using Agravity.Public.Client;
using Agravity.Public.Model;

namespace Example
{
    public class HttpDeleteSpecificBlobExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost:7071/api";
            // Configure OAuth2 access token for authorization: msal_auth
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new AssetOperationsApi(config);
            var id = "id_example";  // string | The ID of the asset.
            var name = "name_example";  // string | The name of the container where this blob is.

            try
            {
                AgravityInfoResponse result = apiInstance.HttpDeleteSpecificBlob(id, name);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AssetOperationsApi.HttpDeleteSpecificBlob: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the HttpDeleteSpecificBlobWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<AgravityInfoResponse> response = apiInstance.HttpDeleteSpecificBlobWithHttpInfo(id, name);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling AssetOperationsApi.HttpDeleteSpecificBlobWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **string** | The ID of the asset. |  |
| **name** | **string** | The name of the container where this blob is. |  |

### Return type

[**AgravityInfoResponse**](AgravityInfoResponse.md)

### Authorization

[msal_auth](../README.md#msal_auth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Blob {name} of asset {id} deleted! - Code: 516587cf-8bc0-46a3-9eea-40ac2d90be60 |  -  |
| **400** | Could not find blob {name} on asset - but if it had existed on container it is deleted. (Code: 38f624aa-a466-4961-a2fa-fd1dfa0c78d0) |  -  |
| **401** | Unauthorized. Bearer Token not provided. |  -  |
| **404** | The requested asset could not be found |  -  |
| **500** | Internal server error. Please contact administrator. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="httpgetallassetscheckoncriteria"></a>
# **HttpGetAllAssetsCheckOnCriteria**
> List&lt;Asset&gt; HttpGetAllAssetsCheckOnCriteria (string md5)



This endpoint allows to check all assets in system elements with the given criteria are already in the system. Currently supported field: md5

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Agravity.Public.Api;
using Agravity.Public.Client;
using Agravity.Public.Model;

namespace Example
{
    public class HttpGetAllAssetsCheckOnCriteriaExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost:7071/api";
            // Configure OAuth2 access token for authorization: msal_auth
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new AssetOperationsApi(config);
            var md5 = "md5_example";  // string | Give the plain md5 string as parameter to be checked on all assets.

            try
            {
                List<Asset> result = apiInstance.HttpGetAllAssetsCheckOnCriteria(md5);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AssetOperationsApi.HttpGetAllAssetsCheckOnCriteria: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the HttpGetAllAssetsCheckOnCriteriaWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<List<Asset>> response = apiInstance.HttpGetAllAssetsCheckOnCriteriaWithHttpInfo(md5);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling AssetOperationsApi.HttpGetAllAssetsCheckOnCriteriaWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **md5** | **string** | Give the plain md5 string as parameter to be checked on all assets. |  |

### Return type

[**List&lt;Asset&gt;**](Asset.md)

### Authorization

[msal_auth](../README.md#msal_auth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Returns alls assets (only basic information) which are found on the given criteria. |  -  |
| **401** | Unauthorized. Bearer Token not provided. |  -  |
| **500** | Internal server error. Please contact administrator. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="httpgetassetblob"></a>
# **HttpGetAssetBlob**
> AssetBlob HttpGetAssetBlob (string id, string c = null)



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
            config.BasePath = "http://localhost:7071/api";
            // Configure OAuth2 access token for authorization: msal_auth
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new AssetOperationsApi(config);
            var id = "id_example";  // string | The ID of the asset.
            var c = "c_example";  // string | \"t\" for thumbnail (default); \"op\" for optimized; \"os\" for original size; \"o\" for original. (optional) 

            try
            {
                AssetBlob result = apiInstance.HttpGetAssetBlob(id, c);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AssetOperationsApi.HttpGetAssetBlob: " + e.Message);
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
    Debug.Print("Exception when calling AssetOperationsApi.HttpGetAssetBlobWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **string** | The ID of the asset. |  |
| **c** | **string** | \&quot;t\&quot; for thumbnail (default); \&quot;op\&quot; for optimized; \&quot;os\&quot; for original size; \&quot;o\&quot; for original. | [optional]  |

### Return type

[**AssetBlob**](AssetBlob.md)

### Authorization

[msal_auth](../README.md#msal_auth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | This function checks if asset(s) exists and returns the url for the requested blob. |  -  |
| **401** | Unauthorized. Bearer Token not provided. |  -  |
| **404** | The requested item could not be found. |  -  |
| **500** | Internal server error. Please contact administrator. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="httpgetassetcollectionsbyid"></a>
# **HttpGetAssetCollectionsById**
> List&lt;Collection&gt; HttpGetAssetCollectionsById (string id, string fields = null, bool? translations = null, string acceptLanguage = null)



This endpoint returns all collections of a specific asset.

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
            config.BasePath = "http://localhost:7071/api";
            // Configure OAuth2 access token for authorization: msal_auth
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new AssetOperationsApi(config);
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
                Debug.Print("Exception when calling AssetOperationsApi.HttpGetAssetCollectionsById: " + e.Message);
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
    Debug.Print("Exception when calling AssetOperationsApi.HttpGetAssetCollectionsByIdWithHttpInfo: " + e.Message);
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

[msal_auth](../README.md#msal_auth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Returns the collections of a specific asset. |  -  |
| **404** | The requested item could not be found. |  -  |
| **401** | Unauthorized. Bearer Token not provided. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="httpgetassetdownload"></a>
# **HttpGetAssetDownload**
> AssetBlob HttpGetAssetDownload (string id, string c = null, string f = null, string portalId = null)



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
            config.BasePath = "http://localhost:7071/api";
            // Configure OAuth2 access token for authorization: msal_auth
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new AssetOperationsApi(config);
            var id = "id_example";  // string | The ID of the asset.
            var c = "c_example";  // string | \"t\" for thumbnail (default); \"op\" for optimized; \"os\" for original size; \"o\" for original. (optional) 
            var f = "f_example";  // string | (optional) provide the id of any valid download format. (optional) 
            var portalId = "portalId_example";  // string | If the request comes from portal this is the indicator. It will be checked if the requested blob is valid for the portal. (optional) 

            try
            {
                AssetBlob result = apiInstance.HttpGetAssetDownload(id, c, f, portalId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AssetOperationsApi.HttpGetAssetDownload: " + e.Message);
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
    ApiResponse<AssetBlob> response = apiInstance.HttpGetAssetDownloadWithHttpInfo(id, c, f, portalId);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling AssetOperationsApi.HttpGetAssetDownloadWithHttpInfo: " + e.Message);
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

### Return type

[**AssetBlob**](AssetBlob.md)

### Authorization

[msal_auth](../README.md#msal_auth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | This function checks if asset exist on storage and returns the asset blob (incl. url to download). |  -  |
| **401** | Unauthorized. Bearer Token not provided. |  -  |
| **404** | The requested item could not be found. |  -  |
| **500** | Internal server error. Please contact administrator. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="httpgetassettechdatabyid"></a>
# **HttpGetAssetTechDataById**
> List&lt;Metadata&gt; HttpGetAssetTechDataById (string id)



This endpoint returns all technical metadata of an asset.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Agravity.Public.Api;
using Agravity.Public.Client;
using Agravity.Public.Model;

namespace Example
{
    public class HttpGetAssetTechDataByIdExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost:7071/api";
            // Configure OAuth2 access token for authorization: msal_auth
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new AssetOperationsApi(config);
            var id = "id_example";  // string | The ID of the asset.

            try
            {
                List<Metadata> result = apiInstance.HttpGetAssetTechDataById(id);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AssetOperationsApi.HttpGetAssetTechDataById: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the HttpGetAssetTechDataByIdWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<List<Metadata>> response = apiInstance.HttpGetAssetTechDataByIdWithHttpInfo(id);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling AssetOperationsApi.HttpGetAssetTechDataByIdWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **string** | The ID of the asset. |  |

### Return type

[**List&lt;Metadata&gt;**](Metadata.md)

### Authorization

[msal_auth](../README.md#msal_auth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Returns a list of technical metadata of the binary object of that asset. |  -  |
| **404** | The requested item could not be found. |  -  |
| **401** | Unauthorized. Bearer Token not provided. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="httpgetassettextcontentbyid"></a>
# **HttpGetAssetTextContentById**
> AssetTextContent HttpGetAssetTextContentById (string id)



This endpoint returns all textual content of an asset (i.e. text of PDF)

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Agravity.Public.Api;
using Agravity.Public.Client;
using Agravity.Public.Model;

namespace Example
{
    public class HttpGetAssetTextContentByIdExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost:7071/api";
            // Configure OAuth2 access token for authorization: msal_auth
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new AssetOperationsApi(config);
            var id = "id_example";  // string | The ID of the asset.

            try
            {
                AssetTextContent result = apiInstance.HttpGetAssetTextContentById(id);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AssetOperationsApi.HttpGetAssetTextContentById: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the HttpGetAssetTextContentByIdWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<AssetTextContent> response = apiInstance.HttpGetAssetTextContentByIdWithHttpInfo(id);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling AssetOperationsApi.HttpGetAssetTextContentByIdWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **string** | The ID of the asset. |  |

### Return type

[**AssetTextContent**](AssetTextContent.md)

### Authorization

[msal_auth](../README.md#msal_auth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Returns the text content of an asset. |  -  |
| **404** | The requested item could not be found. |  -  |
| **401** | Unauthorized. Bearer Token not provided. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="httpimagedynamicedit"></a>
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
            config.BasePath = "http://localhost:7071/api";
            // Configure OAuth2 access token for authorization: msal_auth
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new AssetOperationsApi(config);
            var id = "id_example";  // string | The ID of the asset.
            var dynamicImageOperation = new List<DynamicImageOperation>(); // List<DynamicImageOperation> | Operations to be performed on the image directly mapped to c# imagemagick sdk

            try
            {
                System.IO.Stream result = apiInstance.HttpImageDynamicEdit(id, dynamicImageOperation);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AssetOperationsApi.HttpImageDynamicEdit: " + e.Message);
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
    Debug.Print("Exception when calling AssetOperationsApi.HttpImageDynamicEditWithHttpInfo: " + e.Message);
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

[msal_auth](../README.md#msal_auth)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: image/xyz, application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Returns the resized/modified image according to the input parameter(s) |  -  |
| **400** | Asset has to be image! Not allowed on type: {type} (Code: ec482f52-0ec8-4a8b-89fd-65b9d6b624cd)&lt;br&gt;Not a valid asset used. It has to be an asset, not deleted and from type {type} (Code: 320cda1c-7dd8-4b23-9b59-51ccee5e0a98)&lt;br&gt; |  -  |
| **401** | Unauthorized. Bearer Token not provided. |  -  |
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
            config.BasePath = "http://localhost:7071/api";
            // Configure OAuth2 access token for authorization: msal_auth
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new AssetOperationsApi(config);
            var id = "id_example";  // string | The ID of the asset.
            var downloadFormatId = "downloadFormatId_example";  // string | The ID of the download format.

            try
            {
                System.IO.Stream result = apiInstance.HttpImageDynamicGetFromDownloadId(id, downloadFormatId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AssetOperationsApi.HttpImageDynamicGetFromDownloadId: " + e.Message);
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
    Debug.Print("Exception when calling AssetOperationsApi.HttpImageDynamicGetFromDownloadIdWithHttpInfo: " + e.Message);
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

[msal_auth](../README.md#msal_auth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: image/xyz, application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Returns the resized/modified image according to the input parameter(s) |  -  |
| **400** | Asset has to be image! Not allowed on type: {type} (Code: ec482f52-0ec8-4a8b-89fd-65b9d6b624cd)&lt;br&gt;The ID given is missing or not a valid download format ID. (Code: a9ca9269-8569-4c80-805f-ccbef4f0f278)&lt;br&gt;Not a valid asset used. It has to be an asset, not deleted and from type {type} (Code: 320cda1c-7dd8-4b23-9b59-51ccee5e0a98)&lt;br&gt;Could not find requested download format. (Code: 05985771-df5e-4620-9b58-785177a1b223)&lt;br&gt; |  -  |
| **401** | Unauthorized. Bearer Token not provided. |  -  |
| **404** | The requested item could not be found. |  -  |
| **500** | Internal server error. Please contact administrator. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="httppatchassetpurgecdn"></a>
# **HttpPatchAssetPurgeCdn**
> AgravityInfoResponse HttpPatchAssetPurgeCdn (string id)



This endpoint purges all published assets of this asset when CDN is enabled

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Agravity.Public.Api;
using Agravity.Public.Client;
using Agravity.Public.Model;

namespace Example
{
    public class HttpPatchAssetPurgeCdnExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost:7071/api";
            // Configure OAuth2 access token for authorization: msal_auth
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new AssetOperationsApi(config);
            var id = "id_example";  // string | The ID of the asset.

            try
            {
                AgravityInfoResponse result = apiInstance.HttpPatchAssetPurgeCdn(id);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AssetOperationsApi.HttpPatchAssetPurgeCdn: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the HttpPatchAssetPurgeCdnWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<AgravityInfoResponse> response = apiInstance.HttpPatchAssetPurgeCdnWithHttpInfo(id);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling AssetOperationsApi.HttpPatchAssetPurgeCdnWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **string** | The ID of the asset. |  |

### Return type

[**AgravityInfoResponse**](AgravityInfoResponse.md)

### Authorization

[msal_auth](../README.md#msal_auth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Purge of all published assets started. (Code: d8405c7c-bce6-491d-a63e-a232692349d4) |  -  |
| **400** | Given queue is not known. (Code: 4a852655-7a42-4710-84a3-e9f88fd7f102) |  -  |
| **401** | Unauthorized. Bearer Token not provided. |  -  |
| **404** | The requested item could not be found |  -  |
| **500** | Internal server error. Please contact administrator. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="httppatchassetreindex"></a>
# **HttpPatchAssetReindex**
> AgravityInfoResponse HttpPatchAssetReindex (string id)



This endpoint marks a asset as \"dirty\" (starts a queue to do that) - to trigger search index to re-index the asset

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Agravity.Public.Api;
using Agravity.Public.Client;
using Agravity.Public.Model;

namespace Example
{
    public class HttpPatchAssetReindexExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost:7071/api";
            // Configure OAuth2 access token for authorization: msal_auth
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new AssetOperationsApi(config);
            var id = "id_example";  // string | The ID of the asset.

            try
            {
                AgravityInfoResponse result = apiInstance.HttpPatchAssetReindex(id);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AssetOperationsApi.HttpPatchAssetReindex: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the HttpPatchAssetReindexWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<AgravityInfoResponse> response = apiInstance.HttpPatchAssetReindexWithHttpInfo(id);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling AssetOperationsApi.HttpPatchAssetReindexWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **string** | The ID of the asset. |  |

### Return type

[**AgravityInfoResponse**](AgravityInfoResponse.md)

### Authorization

[msal_auth](../README.md#msal_auth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Starts the queue for asset. - Code: 53942803-58c3-434f-9aa8-da10beab7c02 |  -  |
| **401** | Unauthorized. Bearer Token not provided. |  -  |
| **500** | Internal server error. Please contact administrator. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="httppatchassetrenew"></a>
# **HttpPatchAssetRenew**
> AgravityInfoResponse HttpPatchAssetRenew (string id)



This endpoint runs all configured queues of the asset again (requeue ID at beginning of queues). E.g. Recreation of previews, AI recognition, hash values, ...

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Agravity.Public.Api;
using Agravity.Public.Client;
using Agravity.Public.Model;

namespace Example
{
    public class HttpPatchAssetRenewExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost:7071/api";
            // Configure OAuth2 access token for authorization: msal_auth
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new AssetOperationsApi(config);
            var id = "id_example";  // string | The ID of the asset.

            try
            {
                AgravityInfoResponse result = apiInstance.HttpPatchAssetRenew(id);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AssetOperationsApi.HttpPatchAssetRenew: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the HttpPatchAssetRenewWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<AgravityInfoResponse> response = apiInstance.HttpPatchAssetRenewWithHttpInfo(id);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling AssetOperationsApi.HttpPatchAssetRenewWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **string** | The ID of the asset. |  |

### Return type

[**AgravityInfoResponse**](AgravityInfoResponse.md)

### Authorization

[msal_auth](../README.md#msal_auth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Runs all configured queues of the asset again (requeue ID at beginning of queues). E.g. Recreation of previews, AI recognition, hash values, ... - Code: 7054be72-9bb1-43b7-b400-bd86b6a15f1d |  -  |
| **400** | A parameter is null. (Code: 49dc9df4-926a-49af-a718-807f8018d0cb) |  -  |
| **401** | Unauthorized. Bearer Token not provided. |  -  |
| **404** | The requested item could not be found |  -  |
| **500** | Internal server error. Please contact administrator. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="httppatchassetrepair"></a>
# **HttpPatchAssetRepair**
> AgravityInfoResponse HttpPatchAssetRepair (string id)



This endpoint repairs the asset, it's items, custom fields and collections. It also checks the original blob and the blobs of the asset.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Agravity.Public.Api;
using Agravity.Public.Client;
using Agravity.Public.Model;

namespace Example
{
    public class HttpPatchAssetRepairExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost:7071/api";
            // Configure OAuth2 access token for authorization: msal_auth
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new AssetOperationsApi(config);
            var id = "id_example";  // string | The ID of the asset.

            try
            {
                AgravityInfoResponse result = apiInstance.HttpPatchAssetRepair(id);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AssetOperationsApi.HttpPatchAssetRepair: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the HttpPatchAssetRepairWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<AgravityInfoResponse> response = apiInstance.HttpPatchAssetRepairWithHttpInfo(id);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling AssetOperationsApi.HttpPatchAssetRepairWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **string** | The ID of the asset. |  |

### Return type

[**AgravityInfoResponse**](AgravityInfoResponse.md)

### Authorization

[msal_auth](../README.md#msal_auth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | The successful message which asset was repaired. (Code: 25d70c98-1bba-48dc-8606-a45a512a638b)&lt;br&gt;Or the message that this asset does not needed to be repaired (Code: 9275588d-2d23-4d5c-b55b-14d255db68a4) |  -  |
| **400** | A parameter is null. (Code: 49dc9df4-926a-49af-a718-807f8018d0cb) |  -  |
| **401** | Unauthorized. Bearer Token not provided. |  -  |
| **404** | The requested item could not be found |  -  |
| **500** | Internal server error. Please contact administrator. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="httppatchassetrunqueue"></a>
# **HttpPatchAssetRunQueue**
> AgravityInfoResponse HttpPatchAssetRunQueue (string id, string queueInput)



This endpoint execute a specific queues of the asset. E.g. Recreation of previews, AI recognition, hash values, ...

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Agravity.Public.Api;
using Agravity.Public.Client;
using Agravity.Public.Model;

namespace Example
{
    public class HttpPatchAssetRunQueueExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost:7071/api";
            // Configure OAuth2 access token for authorization: msal_auth
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new AssetOperationsApi(config);
            var id = "id_example";  // string | The ID of the asset.
            var queueInput = "queueInput_example";  // string | The name of the queue(s) which should be executed. (Comma separated)

            try
            {
                AgravityInfoResponse result = apiInstance.HttpPatchAssetRunQueue(id, queueInput);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AssetOperationsApi.HttpPatchAssetRunQueue: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the HttpPatchAssetRunQueueWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<AgravityInfoResponse> response = apiInstance.HttpPatchAssetRunQueueWithHttpInfo(id, queueInput);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling AssetOperationsApi.HttpPatchAssetRunQueueWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **string** | The ID of the asset. |  |
| **queueInput** | **string** | The name of the queue(s) which should be executed. (Comma separated) |  |

### Return type

[**AgravityInfoResponse**](AgravityInfoResponse.md)

### Authorization

[msal_auth](../README.md#msal_auth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Queue {queue} for asset {id} initialized! (Code: d032de7e-057c-4af1-9dba-57c7f7ca8117) |  -  |
| **400** | Given queue is not known. (Code: 4a852655-7a42-4710-84a3-e9f88fd7f102) |  -  |
| **401** | Unauthorized. Bearer Token not provided. |  -  |
| **404** | The requested item could not be found |  -  |
| **500** | Internal server error. Please contact administrator. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="httppatchrenewallassets"></a>
# **HttpPatchRenewAllAssets**
> AgravityInfoResponse HttpPatchRenewAllAssets ()



This endpoint allows the renewal of all assets (start over the trigger of asset type) with or without filtering.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Agravity.Public.Api;
using Agravity.Public.Client;
using Agravity.Public.Model;

namespace Example
{
    public class HttpPatchRenewAllAssetsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost:7071/api";
            // Configure OAuth2 access token for authorization: msal_auth
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new AssetOperationsApi(config);

            try
            {
                AgravityInfoResponse result = apiInstance.HttpPatchRenewAllAssets();
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AssetOperationsApi.HttpPatchRenewAllAssets: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the HttpPatchRenewAllAssetsWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<AgravityInfoResponse> response = apiInstance.HttpPatchRenewAllAssetsWithHttpInfo();
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling AssetOperationsApi.HttpPatchRenewAllAssetsWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters
This endpoint does not need any parameter.
### Return type

[**AgravityInfoResponse**](AgravityInfoResponse.md)

### Authorization

[msal_auth](../README.md#msal_auth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Runs all configured queues of all asset again (requeue ID at beginning of queues). E.g. Recreation of previews, AI recognition, hash values, ... - Code: 1464988b-41d9-443c-874a-43ac5a94df2f |  -  |
| **401** | Unauthorized. Bearer Token not provided. |  -  |
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
            config.BasePath = "http://localhost:7071/api";
            // Configure OAuth2 access token for authorization: msal_auth
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new AssetOperationsApi(config);
            var id = "id_example";  // string | The ID of the asset.
            var assetAvailability = new AssetAvailability(); // AssetAvailability | The values are validated and put directly on the asset.

            try
            {
                AssetAvailability result = apiInstance.HttpPutAssetAvailability(id, assetAvailability);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AssetOperationsApi.HttpPutAssetAvailability: " + e.Message);
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
    Debug.Print("Exception when calling AssetOperationsApi.HttpPutAssetAvailabilityWithHttpInfo: " + e.Message);
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

[msal_auth](../README.md#msal_auth)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | The values are return which are put on the asset. |  -  |
| **400** | Could not parse the asset availability object. (Code: 85ba8328-9181-4d74-a326-4073b17346d8)&lt;br&gt;Object is not a valid asset availability object. (Code: 5515ebe5-2751-4760-a864-47812126b9a1)&lt;br&gt;Asset availability has a confusing state: {updated.Availability}. (Code: 5515ebe5-2751-4760-a864-47812126b9a1)&lt;br&gt;Ambiguous information: Asset available_from can not be greater or equal as available_to when asset should be available.(Code: 16338bcd-614c-4322-a164-e3112d622392 )&lt;br&gt;Ambiguous information: Asset available_from can not be less or equal as available_to when asset should be locked and is not in the future. (Code: 092ddb50-2af8-49a1-b005-68c9d5c600d1)&lt;br&gt;Error on upsert asset availability in database - max retry count is reached. (Code: 98a80b23-bf8d-4cc1-ad6c-08cd69214dcd) &lt;br&gt; |  -  |
| **401** | Unauthorized. Bearer Token not provided. |  -  |
| **404** | The requested asset could not be found |  -  |
| **500** | Internal server error. Please contact administrator. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

