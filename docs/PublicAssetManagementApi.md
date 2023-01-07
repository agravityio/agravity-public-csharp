# Agravity.Public.Api.PublicAssetManagementApi

All URIs are relative to *http://localhost:7072/api*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**HttpAssetUploadFile**](PublicAssetManagementApi.md#httpassetuploadfile) | **POST** /assetsupload |  |
| [**HttpAssetsCreate**](PublicAssetManagementApi.md#httpassetscreate) | **POST** /assets |  |
| [**HttpAssetsGet**](PublicAssetManagementApi.md#httpassetsget) | **GET** /assets |  |
| [**HttpAssetsGetById**](PublicAssetManagementApi.md#httpassetsgetbyid) | **GET** /assets/{id} |  |
| [**HttpPublicAssetsUpdateById**](PublicAssetManagementApi.md#httppublicassetsupdatebyid) | **POST** /assets/{id} |  |

<a name="httpassetuploadfile"></a>
# **HttpAssetUploadFile**
> Asset HttpAssetUploadFile (string name = null, string collectionId = null, System.IO.Stream file = null)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Agravity.Public.Api;
using Agravity.Public.Client;
using Agravity.Public.Model;

namespace Example
{
    public class HttpAssetUploadFileExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost:7072/api";
            // Configure API key authorization: function_key
            config.AddApiKey("x-functions-key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("x-functions-key", "Bearer");

            var apiInstance = new PublicAssetManagementApi(config);
            var name = "name_example";  // string |  (optional) 
            var collectionId = "collectionId_example";  // string |  (optional) 
            var file = new System.IO.MemoryStream(System.IO.File.ReadAllBytes("/path/to/file.txt"));  // System.IO.Stream |  (optional) 

            try
            {
                Asset result = apiInstance.HttpAssetUploadFile(name, collectionId, file);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling PublicAssetManagementApi.HttpAssetUploadFile: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the HttpAssetUploadFileWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<Asset> response = apiInstance.HttpAssetUploadFileWithHttpInfo(name, collectionId, file);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling PublicAssetManagementApi.HttpAssetUploadFileWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **name** | **string** |  | [optional]  |
| **collectionId** | **string** |  | [optional]  |
| **file** | **System.IO.Stream****System.IO.Stream** |  | [optional]  |

### Return type

[**Asset**](Asset.md)

### Authorization

[function_key](../README.md#function_key)

### HTTP request headers

 - **Content-Type**: multipart/form-data
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **201** | Returns the created uploaded asset. |  -  |
| **400** | Request or Database client is null. (Code: feda1ab0-1477-4a76-abdd-3fa6fbdd0def)&lt;br&gt;Could not find file in multi-part data. (Code: b473c560-3ea1-4065-92e6-607973af9d9c)&lt;br&gt;This file is not supported. (Code: 12ac8746-349a-42c0-b73c-33257b73c728) |  -  |
| **401** | Unauthorized. API Key not provided. |  -  |
| **500** | Internal server error. Please contact administrator. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="httpassetscreate"></a>
# **HttpAssetsCreate**
> Asset HttpAssetsCreate (string collectionid, Asset asset, bool? translations = null)



This endpoint creates one asset entry in the database.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Agravity.Public.Api;
using Agravity.Public.Client;
using Agravity.Public.Model;

namespace Example
{
    public class HttpAssetsCreateExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost:7072/api";
            // Configure API key authorization: function_key
            config.AddApiKey("x-functions-key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("x-functions-key", "Bearer");

            var apiInstance = new PublicAssetManagementApi(config);
            var collectionid = "collectionid_example";  // string | The ID of the collection where this assets should be assigned.
            var asset = new Asset(); // Asset | This endpoint creates an unique asset ID and adds the information to the database.
            var translations = true;  // bool? | When default language should be returned and the translation dictionary is delivered. (Ignores the \"Accept-Language\" header) (optional) 

            try
            {
                Asset result = apiInstance.HttpAssetsCreate(collectionid, asset, translations);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling PublicAssetManagementApi.HttpAssetsCreate: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the HttpAssetsCreateWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<Asset> response = apiInstance.HttpAssetsCreateWithHttpInfo(collectionid, asset, translations);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling PublicAssetManagementApi.HttpAssetsCreateWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **collectionid** | **string** | The ID of the collection where this assets should be assigned. |  |
| **asset** | [**Asset**](Asset.md) | This endpoint creates an unique asset ID and adds the information to the database. |  |
| **translations** | **bool?** | When default language should be returned and the translation dictionary is delivered. (Ignores the \&quot;Accept-Language\&quot; header) | [optional]  |

### Return type

[**Asset**](Asset.md)

### Authorization

[function_key](../README.md#function_key)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **201** | Returns the created simple asset. |  -  |
| **400** | A parameter is null. (Code: 8f9036ff-037d-49a1-aab2-57899e5d30e6)&lt;br&gt;Given asset body is not valid. (Code: a51d1697-f56e-4fa3-bde8-3ab44e6cbb0a)&lt;br&gt;Asset availability has a confusing state: {updated.Availability}. (Code: 5515ebe5-2751-4760-a864-47812126b9a1)&lt;br&gt;Ambiguous information: Asset available_from can not be greater or equal as available_to when asset should be available.(Code: 16338bcd-614c-4322-a164-e3112d622392 )&lt;br&gt;Ambiguous information: Asset available_from can not be less or equal as available_to when asset should be locked and is not in the future. (Code: 092ddb50-2af8-49a1-b005-68c9d5c600d1)&lt;br&gt;Error on creating custom items on asset. (Code: 4e780f21-17fc-4125-a9d8-2cf0c23d84d6) |  -  |
| **401** | Unauthorized. API Key not provided. |  -  |
| **500** | Internal server error. Please contact administrator. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="httpassetsget"></a>
# **HttpAssetsGet**
> AssetPageResult HttpAssetsGet (string collectionid, string fields = null, bool? expose = null, string continuationToken = null, int? limit = null, string orderby = null, bool? techdata = null, bool? items = null, bool? translations = null)



This endpoint lists all the assets, which are stored in the database and not deleted (status \"A\")

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Agravity.Public.Api;
using Agravity.Public.Client;
using Agravity.Public.Model;

namespace Example
{
    public class HttpAssetsGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost:7072/api";
            // Configure API key authorization: function_key
            config.AddApiKey("x-functions-key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("x-functions-key", "Bearer");

            var apiInstance = new PublicAssetManagementApi(config);
            var collectionid = "collectionid_example";  // string | The ID of the collection where these assets should come from. (\"empty\" is allowed)
            var fields = "fields_example";  // string | This limits the fields which are returned, separated by comma (','). Blobs can be limited with '.' on their container. (i.e. fields=blobs.thumbnails). Only if 'thumbnails' is set, the placeholder of this asset type are returned if no thumbnail blob is found. (optional) 
            var expose = true;  // bool? | This indicates if the given blobs should have URLs where these can be requested. (If not limited through 'fields' parameter it will expose all URLs of all blobs.) (optional) 
            var continuationToken = "continuationToken_example";  // string | Each result returns the continous token if more results are available than requested. With this token, the next page could be fetched. (URL encoded!) (optional) 
            var limit = 56;  // int? | This number limits the page result of assets. (optional) 
            var orderby = "orderby_example";  // string | How the return assets are sorted. Default is property: created_date (newest first). (optional) 
            var techdata = true;  // bool? | This parameter will include the techdata property inside orig_blob. (optional) 
            var items = true;  // bool? | The items can be extended to fully filled items. (optional) 
            var translations = true;  // bool? | When default language should be returned and the translation dictionary is delivered. (Ignores the \"Accept-Language\" header) (optional) 

            try
            {
                AssetPageResult result = apiInstance.HttpAssetsGet(collectionid, fields, expose, continuationToken, limit, orderby, techdata, items, translations);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling PublicAssetManagementApi.HttpAssetsGet: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the HttpAssetsGetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<AssetPageResult> response = apiInstance.HttpAssetsGetWithHttpInfo(collectionid, fields, expose, continuationToken, limit, orderby, techdata, items, translations);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling PublicAssetManagementApi.HttpAssetsGetWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **collectionid** | **string** | The ID of the collection where these assets should come from. (\&quot;empty\&quot; is allowed) |  |
| **fields** | **string** | This limits the fields which are returned, separated by comma (&#39;,&#39;). Blobs can be limited with &#39;.&#39; on their container. (i.e. fields&#x3D;blobs.thumbnails). Only if &#39;thumbnails&#39; is set, the placeholder of this asset type are returned if no thumbnail blob is found. | [optional]  |
| **expose** | **bool?** | This indicates if the given blobs should have URLs where these can be requested. (If not limited through &#39;fields&#39; parameter it will expose all URLs of all blobs.) | [optional]  |
| **continuationToken** | **string** | Each result returns the continous token if more results are available than requested. With this token, the next page could be fetched. (URL encoded!) | [optional]  |
| **limit** | **int?** | This number limits the page result of assets. | [optional]  |
| **orderby** | **string** | How the return assets are sorted. Default is property: created_date (newest first). | [optional]  |
| **techdata** | **bool?** | This parameter will include the techdata property inside orig_blob. | [optional]  |
| **items** | **bool?** | The items can be extended to fully filled items. | [optional]  |
| **translations** | **bool?** | When default language should be returned and the translation dictionary is delivered. (Ignores the \&quot;Accept-Language\&quot; header) | [optional]  |

### Return type

[**AssetPageResult**](AssetPageResult.md)

### Authorization

[function_key](../README.md#function_key)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Returns the all assets (from given collection) as array. |  -  |
| **400** | Could not query assets. Type: {type} (Code: 2744993d-fba5-4ae3-93df-ff95035c8af7)&lt;br&gt;Not allowed to query assets without valid collection id. (Code: 81515ce1-8e13-4a83-84e6-fe8057d55fc5)&lt;br&gt;Collection id {collectionId} not found. (Code: a3fe323c-6736-43e6-a9e9-49444f3f1406) |  -  |
| **401** | Unauthorized. API Key not provided. |  -  |
| **500** | Internal server error. Please contact administrator. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="httpassetsgetbyid"></a>
# **HttpAssetsGetById**
> Asset HttpAssetsGetById (string id, string fields = null, bool? expose = null, bool? translations = null)



This endpoint returns one single asset (from ID). If the returned asset is from a special asset type (e.g. \"AssetImage\") it returns the full entity.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Agravity.Public.Api;
using Agravity.Public.Client;
using Agravity.Public.Model;

namespace Example
{
    public class HttpAssetsGetByIdExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost:7072/api";
            // Configure API key authorization: function_key
            config.AddApiKey("x-functions-key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("x-functions-key", "Bearer");

            var apiInstance = new PublicAssetManagementApi(config);
            var id = "id_example";  // string | The ID of the asset.
            var fields = "fields_example";  // string | Which fields are need to be filled out with comma separated. If one is set all non mandatory fields are left out. No validation if field exist. (optional) 
            var expose = true;  // bool? | This indicates if the given blobs should have URLs where these can be requested. It will expose placeholder blobs if no 'thumbnail' is found. (optional) 
            var translations = true;  // bool? | When default language should be returned and the translation dictionary is delivered. (Ignores the \"Accept-Language\" header) (optional) 

            try
            {
                Asset result = apiInstance.HttpAssetsGetById(id, fields, expose, translations);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling PublicAssetManagementApi.HttpAssetsGetById: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the HttpAssetsGetByIdWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<Asset> response = apiInstance.HttpAssetsGetByIdWithHttpInfo(id, fields, expose, translations);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling PublicAssetManagementApi.HttpAssetsGetByIdWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **string** | The ID of the asset. |  |
| **fields** | **string** | Which fields are need to be filled out with comma separated. If one is set all non mandatory fields are left out. No validation if field exist. | [optional]  |
| **expose** | **bool?** | This indicates if the given blobs should have URLs where these can be requested. It will expose placeholder blobs if no &#39;thumbnail&#39; is found. | [optional]  |
| **translations** | **bool?** | When default language should be returned and the translation dictionary is delivered. (Ignores the \&quot;Accept-Language\&quot; header) | [optional]  |

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
| **200** | Returns the the asset with the given ID include type specific fields. |  -  |
| **404** | If the asset with the ID was not found. |  -  |
| **401** | Unauthorized. API Key not provided. |  -  |
| **500** | Internal server error. Please contact administrator. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="httppublicassetsupdatebyid"></a>
# **HttpPublicAssetsUpdateById**
> Asset HttpPublicAssetsUpdateById (string id, Asset asset, bool? translations = null)



This endpoint updates one single asset (from ID)

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Agravity.Public.Api;
using Agravity.Public.Client;
using Agravity.Public.Model;

namespace Example
{
    public class HttpPublicAssetsUpdateByIdExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost:7072/api";
            // Configure API key authorization: function_key
            config.AddApiKey("x-functions-key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("x-functions-key", "Bearer");

            var apiInstance = new PublicAssetManagementApi(config);
            var id = "id_example";  // string | The ID of the asset.
            var asset = new Asset(); // Asset | The body has to contain one of the mentioned elements and a valid json. Not fitting properties are ignored.
            var translations = true;  // bool? | When default language should be returned and the translation dictionary is delivered. (Ignores the \"Accept-Language\" header) (optional) 

            try
            {
                Asset result = apiInstance.HttpPublicAssetsUpdateById(id, asset, translations);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling PublicAssetManagementApi.HttpPublicAssetsUpdateById: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the HttpPublicAssetsUpdateByIdWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<Asset> response = apiInstance.HttpPublicAssetsUpdateByIdWithHttpInfo(id, asset, translations);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling PublicAssetManagementApi.HttpPublicAssetsUpdateByIdWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **string** | The ID of the asset. |  |
| **asset** | [**Asset**](Asset.md) | The body has to contain one of the mentioned elements and a valid json. Not fitting properties are ignored. |  |
| **translations** | **bool?** | When default language should be returned and the translation dictionary is delivered. (Ignores the \&quot;Accept-Language\&quot; header) | [optional]  |

### Return type

[**Asset**](Asset.md)

### Authorization

[function_key](../README.md#function_key)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Returns the updated full (depending on asset type) asset including custom fields. |  -  |
| **400** | A parameter is null. (Code: cea84d3b-ccb5-46c9-9768-11e1f81edf6c)&lt;br&gt;Object is not a valid asset. (Code: ea836a33-0d64-446f-8f67-2c3af564b18e)&lt;br&gt;Error on updating custom items. (Code: 9d044d04-53fb-4b6a-b629-554ad6ea19e2) |  -  |
| **401** | Unauthorized. API Key not provided. |  -  |
| **404** | If the asset with the ID was not found. |  -  |
| **500** | Internal server error. Please contact administrator. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

