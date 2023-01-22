# Agravity.Public.Api.PublicAssetVersioningApi

All URIs are relative to *http://localhost:7072/api*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**HttpAssetCreateUploadVersion**](PublicAssetVersioningApi.md#httpassetcreateuploadversion) | **POST** /assets/{id}/versionsupload |  |
| [**HttpAssetCreateVersion**](PublicAssetVersioningApi.md#httpassetcreateversion) | **POST** /assets/{id}/versions |  |
| [**HttpDeleteVersionedAssetsById**](PublicAssetVersioningApi.md#httpdeleteversionedassetsbyid) | **DELETE** /assets/{id}/versions/{vNr} |  |
| [**HttpGetVersionedAssetBlobById**](PublicAssetVersioningApi.md#httpgetversionedassetblobbyid) | **GET** /assets/{id}/versions/{vNr}/blobs |  |
| [**HttpRestoreVersionedAssetsById**](PublicAssetVersioningApi.md#httprestoreversionedassetsbyid) | **POST** /assets/{id}/versions/{vNr}/restore |  |
| [**HttpVersionedAssetsGet**](PublicAssetVersioningApi.md#httpversionedassetsget) | **GET** /assets/{id}/versions |  |

<a name="httpassetcreateuploadversion"></a>
# **HttpAssetCreateUploadVersion**
> VersionedAsset HttpAssetCreateUploadVersion (string id, string name = null, string collectionId = null, System.IO.Stream file = null)



This endpoint allows to upload one asset which replaces the asset with given id and creates a version which is returned.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Agravity.Public.Api;
using Agravity.Public.Client;
using Agravity.Public.Model;

namespace Example
{
    public class HttpAssetCreateUploadVersionExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost:7072/api";
            // Configure API key authorization: function_key
            config.AddApiKey("x-functions-key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("x-functions-key", "Bearer");

            var apiInstance = new PublicAssetVersioningApi(config);
            var id = "id_example";  // string | The ID of the asset.
            var name = "name_example";  // string |  (optional) 
            var collectionId = "collectionId_example";  // string |  (optional) 
            var file = new System.IO.MemoryStream(System.IO.File.ReadAllBytes("/path/to/file.txt"));  // System.IO.Stream |  (optional) 

            try
            {
                VersionedAsset result = apiInstance.HttpAssetCreateUploadVersion(id, name, collectionId, file);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling PublicAssetVersioningApi.HttpAssetCreateUploadVersion: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the HttpAssetCreateUploadVersionWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<VersionedAsset> response = apiInstance.HttpAssetCreateUploadVersionWithHttpInfo(id, name, collectionId, file);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling PublicAssetVersioningApi.HttpAssetCreateUploadVersionWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **string** | The ID of the asset. |  |
| **name** | **string** |  | [optional]  |
| **collectionId** | **string** |  | [optional]  |
| **file** | **System.IO.Stream****System.IO.Stream** |  | [optional]  |

### Return type

[**VersionedAsset**](VersionedAsset.md)

### Authorization

[function_key](../README.md#function_key)

### HTTP request headers

 - **Content-Type**: multipart/form-data
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **201** | Returns the created version of the asset. |  -  |
| **400** | Asset is not active yet. Wait until process is finished. (Code: 2e1fbeb0-b405-4985-8bac-aa604d5cd125) &lt;br&gt;or Asset upload failed. Content length is insuffient (0 or too big) (Code: b9fd835c-5456-4101-a643-ed5c1d5e5335) &lt;br&gt;or Wrong content media type. Please upload file with multipart/form-data. (Code: 553ccca6-c06f-4a1d-9b1e-ff140fbcd389) &lt;br&gt;or Could not find file in multi-part data. (Code: 0a66cf65-8926-44f3-9e7e-89de614828ad) &lt;br&gt;or This file is not supported. (Code: 214ef18f-0dca-4128-8543-e20339114e11) &lt;br&gt;or This file has to be from same file type! (Code: 0bcf2586-ac2a-426f-b757-2352f50b53ef) &lt;br&gt;or AgravityProcessingException occured (see message). (Code: 37eb0897-6c1b-4147-9b6d-d0e756180623) |  -  |
| **404** | Asset could not be found in database. (Code: 9a84addc-14b7-4a29-9f33-6f8f35e16bf3) |  -  |
| **401** | Unauthorized. API Key not provided. |  -  |
| **500** | Internal server error. Please contact administrator. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="httpassetcreateversion"></a>
# **HttpAssetCreateVersion**
> VersionedAsset HttpAssetCreateVersion (string id, VersionedAsset versionedAsset)



This endpoint allows to create empty version or upload one asset which replaces the asset with given id and creates version.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Agravity.Public.Api;
using Agravity.Public.Client;
using Agravity.Public.Model;

namespace Example
{
    public class HttpAssetCreateVersionExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost:7072/api";
            // Configure API key authorization: function_key
            config.AddApiKey("x-functions-key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("x-functions-key", "Bearer");

            var apiInstance = new PublicAssetVersioningApi(config);
            var id = "id_example";  // string | The ID of the asset.
            var versionedAsset = new VersionedAsset(); // VersionedAsset | This VersionedAsset to create empty version (need to upload file with metadata to blob storage)

            try
            {
                VersionedAsset result = apiInstance.HttpAssetCreateVersion(id, versionedAsset);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling PublicAssetVersioningApi.HttpAssetCreateVersion: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the HttpAssetCreateVersionWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<VersionedAsset> response = apiInstance.HttpAssetCreateVersionWithHttpInfo(id, versionedAsset);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling PublicAssetVersioningApi.HttpAssetCreateVersionWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **string** | The ID of the asset. |  |
| **versionedAsset** | [**VersionedAsset**](VersionedAsset.md) | This VersionedAsset to create empty version (need to upload file with metadata to blob storage) |  |

### Return type

[**VersionedAsset**](VersionedAsset.md)

### Authorization

[function_key](../README.md#function_key)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **201** | Returns the created version of the asset. |  -  |
| **400** | Asset is not active yet. Wait until process is finished. (Code: 2e1fbeb0-b405-4985-8bac-aa604d5cd125) &lt;br&gt;or AgravityProcessingException occured (see message). (Code: 37eb0897-6c1b-4147-9b6d-d0e756180623) |  -  |
| **404** | Asset could not be found in database. (Code: 9a84addc-14b7-4a29-9f33-6f8f35e16bf3) |  -  |
| **401** | Unauthorized. API Key not provided. |  -  |
| **500** | Internal server error. Please contact administrator. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="httpdeleteversionedassetsbyid"></a>
# **HttpDeleteVersionedAssetsById**
> void HttpDeleteVersionedAssetsById (string id, string vNr)



This endpoint deletes a version of an asset.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Agravity.Public.Api;
using Agravity.Public.Client;
using Agravity.Public.Model;

namespace Example
{
    public class HttpDeleteVersionedAssetsByIdExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost:7072/api";
            // Configure API key authorization: function_key
            config.AddApiKey("x-functions-key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("x-functions-key", "Bearer");

            var apiInstance = new PublicAssetVersioningApi(config);
            var id = "id_example";  // string | The ID of the asset.
            var vNr = "vNr_example";  // string | The version number of the asset.

            try
            {
                apiInstance.HttpDeleteVersionedAssetsById(id, vNr);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling PublicAssetVersioningApi.HttpDeleteVersionedAssetsById: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the HttpDeleteVersionedAssetsByIdWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    apiInstance.HttpDeleteVersionedAssetsByIdWithHttpInfo(id, vNr);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling PublicAssetVersioningApi.HttpDeleteVersionedAssetsByIdWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **string** | The ID of the asset. |  |
| **vNr** | **string** | The version number of the asset. |  |

### Return type

void (empty response body)

### Authorization

[function_key](../README.md#function_key)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **400** | Given version of this asset is not a number (Code: 10fb9f76-1ee5-4b58-a642-bf37efa6c230) |  -  |
| **401** | Unauthorized. API Key not provided. |  -  |
| **204** | No description |  -  |
| **404** | If the asset or versioned asset with the IDs were not found. |  -  |
| **500** | Internal server error. Please contact administrator. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="httpgetversionedassetblobbyid"></a>
# **HttpGetVersionedAssetBlobById**
> AssetBlob HttpGetVersionedAssetBlobById (string id, int vNr, string c = null)



This endpoint checks if assets and version exists and returns the url for the requested blob.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Agravity.Public.Api;
using Agravity.Public.Client;
using Agravity.Public.Model;

namespace Example
{
    public class HttpGetVersionedAssetBlobByIdExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost:7072/api";
            // Configure API key authorization: function_key
            config.AddApiKey("x-functions-key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("x-functions-key", "Bearer");

            var apiInstance = new PublicAssetVersioningApi(config);
            var id = "id_example";  // string | The ID of the asset.
            var vNr = 56;  // int | The version number of the asset.
            var c = "c_example";  // string | \"t\" for thumbnail (default); \"o\" for optimized (optional) 

            try
            {
                AssetBlob result = apiInstance.HttpGetVersionedAssetBlobById(id, vNr, c);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling PublicAssetVersioningApi.HttpGetVersionedAssetBlobById: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the HttpGetVersionedAssetBlobByIdWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<AssetBlob> response = apiInstance.HttpGetVersionedAssetBlobByIdWithHttpInfo(id, vNr, c);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling PublicAssetVersioningApi.HttpGetVersionedAssetBlobByIdWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **string** | The ID of the asset. |  |
| **vNr** | **int** | The version number of the asset. |  |
| **c** | **string** | \&quot;t\&quot; for thumbnail (default); \&quot;o\&quot; for optimized | [optional]  |

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
| **400** | Given version of this asset is not a number (Code: 7a60606d-764f-4e12-9bc1-ba8512de158a) |  -  |
| **401** | Unauthorized. API Key not provided. |  -  |
| **404** | The requested item could not be found |  -  |
| **500** | Internal server error. Please contact administrator. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="httprestoreversionedassetsbyid"></a>
# **HttpRestoreVersionedAssetsById**
> VersionedAsset HttpRestoreVersionedAssetsById (string id, string vNr, VersionedAsset versionedAsset)



This endpoint restores a version nr to be the current version and saves the current asset as version.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Agravity.Public.Api;
using Agravity.Public.Client;
using Agravity.Public.Model;

namespace Example
{
    public class HttpRestoreVersionedAssetsByIdExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost:7072/api";
            // Configure API key authorization: function_key
            config.AddApiKey("x-functions-key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("x-functions-key", "Bearer");

            var apiInstance = new PublicAssetVersioningApi(config);
            var id = "id_example";  // string | The ID of the asset.
            var vNr = "vNr_example";  // string | The version number of the asset.
            var versionedAsset = new VersionedAsset(); // VersionedAsset | Only the version_info is used and will be added to the current version which is archived (before the old version is restored).

            try
            {
                VersionedAsset result = apiInstance.HttpRestoreVersionedAssetsById(id, vNr, versionedAsset);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling PublicAssetVersioningApi.HttpRestoreVersionedAssetsById: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the HttpRestoreVersionedAssetsByIdWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<VersionedAsset> response = apiInstance.HttpRestoreVersionedAssetsByIdWithHttpInfo(id, vNr, versionedAsset);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling PublicAssetVersioningApi.HttpRestoreVersionedAssetsByIdWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **string** | The ID of the asset. |  |
| **vNr** | **string** | The version number of the asset. |  |
| **versionedAsset** | [**VersionedAsset**](VersionedAsset.md) | Only the version_info is used and will be added to the current version which is archived (before the old version is restored). |  |

### Return type

[**VersionedAsset**](VersionedAsset.md)

### Authorization

[function_key](../README.md#function_key)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Returns the versioned asset. |  -  |
| **400** | If the version is not a number.&lt;br&gt;If blobs or internal, thumbs or optimized are missing. Only assets can be restored which are complete processed. |  -  |
| **401** | Unauthorized. API Key not provided. |  -  |
| **404** | If the asset or versioned asset with the IDs were not found. |  -  |
| **500** | Internal server error. Please contact administrator. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="httpversionedassetsget"></a>
# **HttpVersionedAssetsGet**
> VersionEntity HttpVersionedAssetsGet (string id)



This endpoint lists all the versioned assets which are stored in the database if asset is still valid.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Agravity.Public.Api;
using Agravity.Public.Client;
using Agravity.Public.Model;

namespace Example
{
    public class HttpVersionedAssetsGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost:7072/api";
            // Configure API key authorization: function_key
            config.AddApiKey("x-functions-key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("x-functions-key", "Bearer");

            var apiInstance = new PublicAssetVersioningApi(config);
            var id = "id_example";  // string | The ID of the asset.

            try
            {
                VersionEntity result = apiInstance.HttpVersionedAssetsGet(id);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling PublicAssetVersioningApi.HttpVersionedAssetsGet: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the HttpVersionedAssetsGetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<VersionEntity> response = apiInstance.HttpVersionedAssetsGetWithHttpInfo(id);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling PublicAssetVersioningApi.HttpVersionedAssetsGetWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **string** | The ID of the asset. |  |

### Return type

[**VersionEntity**](VersionEntity.md)

### Authorization

[function_key](../README.md#function_key)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Returns the VersionEntity where all versioned assets are included. |  -  |
| **401** | Unauthorized. API Key not provided. |  -  |
| **404** | If the version of the asset is not found. |  -  |
| **500** | Internal server error. Please contact administrator. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

