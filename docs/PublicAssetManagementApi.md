# Agravity.Public.Api.PublicAssetManagementApi

All URIs are relative to *http://localhost:7072/api*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**HttpAssetUploadFile**](PublicAssetManagementApi.md#httpassetuploadfile) | **POST** /assetsupload |  |
| [**HttpAssetsBulkDeleteUpdate**](PublicAssetManagementApi.md#httpassetsbulkdeleteupdate) | **DELETE** /assetsbulkupdate |  |
| [**HttpAssetsBulkPostUpdate**](PublicAssetManagementApi.md#httpassetsbulkpostupdate) | **POST** /assetsbulkupdate |  |
| [**HttpAssetsBulkPutUpdate**](PublicAssetManagementApi.md#httpassetsbulkputupdate) | **PUT** /assetsbulkupdate |  |
| [**HttpAssetsCreate**](PublicAssetManagementApi.md#httpassetscreate) | **POST** /assets |  |
| [**HttpAssetsDeleteById**](PublicAssetManagementApi.md#httpassetsdeletebyid) | **DELETE** /assets/{id} |  |
| [**HttpAssetsGet**](PublicAssetManagementApi.md#httpassetsget) | **GET** /assets |  |
| [**HttpAssetsGetById**](PublicAssetManagementApi.md#httpassetsgetbyid) | **GET** /assets/{id} |  |
| [**HttpPublicAssetsUpdateById**](PublicAssetManagementApi.md#httppublicassetsupdatebyid) | **POST** /assets/{id} |  |

<a id="httpassetuploadfile"></a>
# **HttpAssetUploadFile**
> Asset HttpAssetUploadFile (string acceptLanguage = null, string name = null, string collectionid = null, System.IO.Stream file = null, string filename = null, string previewof = null)



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
            var acceptLanguage = "acceptLanguage_example";  // string | The requested language of the response. If not matching it falls back to default language. (optional) 
            var name = "name_example";  // string |  (optional) 
            var collectionid = "collectionid_example";  // string |  (optional) 
            var file = new System.IO.MemoryStream(System.IO.File.ReadAllBytes("/path/to/file.txt"));  // System.IO.Stream |  (optional) 
            var filename = "filename_example";  // string |  (optional) 
            var previewof = "previewof_example";  // string |  (optional) 

            try
            {
                Asset result = apiInstance.HttpAssetUploadFile(acceptLanguage, name, collectionid, file, filename, previewof);
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
    ApiResponse<Asset> response = apiInstance.HttpAssetUploadFileWithHttpInfo(acceptLanguage, name, collectionid, file, filename, previewof);
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
| **acceptLanguage** | **string** | The requested language of the response. If not matching it falls back to default language. | [optional]  |
| **name** | **string** |  | [optional]  |
| **collectionid** | **string** |  | [optional]  |
| **file** | **System.IO.Stream****System.IO.Stream** |  | [optional]  |
| **filename** | **string** |  | [optional]  |
| **previewof** | **string** |  | [optional]  |

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

<a id="httpassetsbulkdeleteupdate"></a>
# **HttpAssetsBulkDeleteUpdate**
> AgravityInfoResponse HttpAssetsBulkDeleteUpdate (AssetBulkUpdate assetBulkUpdate)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Agravity.Public.Api;
using Agravity.Public.Client;
using Agravity.Public.Model;

namespace Example
{
    public class HttpAssetsBulkDeleteUpdateExample
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
            var assetBulkUpdate = new AssetBulkUpdate(); // AssetBulkUpdate | This endpoint updates multiple assets. The containing keywords (tags) will removed if existing. Only custom values are removed on assets which have those items.

            try
            {
                AgravityInfoResponse result = apiInstance.HttpAssetsBulkDeleteUpdate(assetBulkUpdate);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling PublicAssetManagementApi.HttpAssetsBulkDeleteUpdate: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the HttpAssetsBulkDeleteUpdateWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<AgravityInfoResponse> response = apiInstance.HttpAssetsBulkDeleteUpdateWithHttpInfo(assetBulkUpdate);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling PublicAssetManagementApi.HttpAssetsBulkDeleteUpdateWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **assetBulkUpdate** | [**AssetBulkUpdate**](AssetBulkUpdate.md) | This endpoint updates multiple assets. The containing keywords (tags) will removed if existing. Only custom values are removed on assets which have those items. |  |

### Return type

[**AgravityInfoResponse**](AgravityInfoResponse.md)

### Authorization

[function_key](../README.md#function_key)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Returns the info that remove update (delete) was successful. (Code: 35e4ad14-969e-4687-83ca-51c6828b5234) |  -  |
| **400** | A parameter is null. (Code: 22edc392-b73c-4d89-9710-6aad5edb0c1a)&lt;br&gt;Object is not a valid AssetBulkUpdate object. (Code: 0112ebf9-45cd-4284-b728-2c809faa4e4b)&lt;br&gt;Object is empty and not a valid AssetBulkUpdate object. (Code: f81bee0b-6e4e-4b6e-8f5c-019e498ca845)&lt;br&gt;Not sure what to update. asset_ids is not given. (Code: 93218cdf-4511-46a7-b336-46757d788d74)&lt;br&gt;Not all asset_ids are valid. (Code: 07e041bd-236c-4e48-bfca-89f9f5d340af)&lt;br&gt;Could not find all  asset_ids in database. (Code: aa4e7de0-db79-431a-b684-76d157820775)&lt;br&gt;Could not find all  asset_ids relations in database. (Code: 100b3432-1a26-4618-ba84-b1ac72ab1ec8)&lt;br&gt;Error on updating custom items on asset {asset.Id}. Reason see inner exception.  (Code: 72faa784-ae94-49a9-a30e-1bad3674d432&lt;br&gt;Error on replacing custom items on asset {asset.Id}. Reason see inner exception. (Code: e83b9194-cbfe-43ec-bbfb-6d3fae5ad4d0)&lt;br&gt;The mandatory item &#39;&lt;item.Name&gt;&#39; can not be removed without having default value or is of type &#39;userdefinedlist&#39;. (Code: 85b9c37d-6c66-46c4-9107-f7acf198e68a)&lt;br&gt;Property &#39;&lt;item name&gt;&#39; is mandatory but no default value was set! (Code: 16822359-3639-4610-b075-b39aa9e106a8)&lt;br&gt;Property &#39;&lt;item name&gt;&#39; is not of defined type: &lt;item type&gt;  (Code: 1e9a1470-cfba-4a56-97b0-c44f77671880)&lt;br&gt;Property &#39;&lt;item name&gt;&#39; is mandatory but no value was given! (Code: c23f73ed-89cb-47c1-b653-3ec99c460707) |  -  |
| **401** | Unauthorized. API Key not provided. |  -  |
| **404** | If the asset with the ID was not found. |  -  |
| **403** | Not enough privileges to access item. |  -  |
| **500** | Internal server error. Please contact administrator. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="httpassetsbulkpostupdate"></a>
# **HttpAssetsBulkPostUpdate**
> AgravityInfoResponse HttpAssetsBulkPostUpdate (AssetBulkUpdate assetBulkUpdate, string acceptLanguage = null)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Agravity.Public.Api;
using Agravity.Public.Client;
using Agravity.Public.Model;

namespace Example
{
    public class HttpAssetsBulkPostUpdateExample
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
            var assetBulkUpdate = new AssetBulkUpdate(); // AssetBulkUpdate | This endpoint updates multiple assets. The containing keywords (tags) will be distinctly added (no removal). Only custom values are added on assets which have those items.
            var acceptLanguage = "acceptLanguage_example";  // string | The requested language of the response. If not matching it falls back to default language. (optional) 

            try
            {
                AgravityInfoResponse result = apiInstance.HttpAssetsBulkPostUpdate(assetBulkUpdate, acceptLanguage);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling PublicAssetManagementApi.HttpAssetsBulkPostUpdate: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the HttpAssetsBulkPostUpdateWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<AgravityInfoResponse> response = apiInstance.HttpAssetsBulkPostUpdateWithHttpInfo(assetBulkUpdate, acceptLanguage);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling PublicAssetManagementApi.HttpAssetsBulkPostUpdateWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **assetBulkUpdate** | [**AssetBulkUpdate**](AssetBulkUpdate.md) | This endpoint updates multiple assets. The containing keywords (tags) will be distinctly added (no removal). Only custom values are added on assets which have those items. |  |
| **acceptLanguage** | **string** | The requested language of the response. If not matching it falls back to default language. | [optional]  |

### Return type

[**AgravityInfoResponse**](AgravityInfoResponse.md)

### Authorization

[function_key](../README.md#function_key)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Returns the info that the post update was successful. (Code: 9f12848f-573a-45bb-89ed-c44c44c1cc97) |  -  |
| **400** | A parameter is null. (Code: 22edc392-b73c-4d89-9710-6aad5edb0c1a)&lt;br&gt;Object is not a valid AssetBulkUpdate object. (Code: 0112ebf9-45cd-4284-b728-2c809faa4e4b)&lt;br&gt;Object is empty and not a valid AssetBulkUpdate object. (Code: f81bee0b-6e4e-4b6e-8f5c-019e498ca845)&lt;br&gt;Not sure what to update. asset_ids is not given. (Code: 93218cdf-4511-46a7-b336-46757d788d74)&lt;br&gt;Not all asset_ids are valid. (Code: 07e041bd-236c-4e48-bfca-89f9f5d340af)&lt;br&gt;Could not find all  asset_ids in database. (Code: aa4e7de0-db79-431a-b684-76d157820775)&lt;br&gt;Could not find all  asset_ids relations in database. (Code: 100b3432-1a26-4618-ba84-b1ac72ab1ec8)&lt;br&gt;Error on updating custom items on asset {asset.Id}. Reason see inner exception.  (Code: 72faa784-ae94-49a9-a30e-1bad3674d432&lt;br&gt;Error on replacing custom items on asset {asset.Id}. Reason see inner exception. (Code: e83b9194-cbfe-43ec-bbfb-6d3fae5ad4d0)&lt;br&gt;The mandatory item &#39;&lt;item.Name&gt;&#39; can not be removed without having default value or is of type &#39;userdefinedlist&#39;. (Code: 85b9c37d-6c66-46c4-9107-f7acf198e68a)&lt;br&gt;Property &#39;&lt;item name&gt;&#39; is mandatory but no default value was set! (Code: 16822359-3639-4610-b075-b39aa9e106a8)&lt;br&gt;Property &#39;&lt;item name&gt;&#39; is not of defined type: &lt;item type&gt;  (Code: 1e9a1470-cfba-4a56-97b0-c44f77671880)&lt;br&gt;Property &#39;&lt;item name&gt;&#39; is mandatory but no value was given! (Code: c23f73ed-89cb-47c1-b653-3ec99c460707) |  -  |
| **401** | Unauthorized. API Key not provided. |  -  |
| **404** | If the asset with the ID was not found. |  -  |
| **403** | Not enough privileges to access item. |  -  |
| **500** | Internal server error. Please contact administrator. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="httpassetsbulkputupdate"></a>
# **HttpAssetsBulkPutUpdate**
> AgravityInfoResponse HttpAssetsBulkPutUpdate (AssetBulkUpdate assetBulkUpdate, string acceptLanguage = null)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Agravity.Public.Api;
using Agravity.Public.Client;
using Agravity.Public.Model;

namespace Example
{
    public class HttpAssetsBulkPutUpdateExample
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
            var assetBulkUpdate = new AssetBulkUpdate(); // AssetBulkUpdate | This endpoint updates multiple assets. The containing keywords (tags) will replace existing. Only custom values are replaced on assets which have those items.
            var acceptLanguage = "acceptLanguage_example";  // string | The requested language of the response. If not matching it falls back to default language. (optional) 

            try
            {
                AgravityInfoResponse result = apiInstance.HttpAssetsBulkPutUpdate(assetBulkUpdate, acceptLanguage);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling PublicAssetManagementApi.HttpAssetsBulkPutUpdate: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the HttpAssetsBulkPutUpdateWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<AgravityInfoResponse> response = apiInstance.HttpAssetsBulkPutUpdateWithHttpInfo(assetBulkUpdate, acceptLanguage);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling PublicAssetManagementApi.HttpAssetsBulkPutUpdateWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **assetBulkUpdate** | [**AssetBulkUpdate**](AssetBulkUpdate.md) | This endpoint updates multiple assets. The containing keywords (tags) will replace existing. Only custom values are replaced on assets which have those items. |  |
| **acceptLanguage** | **string** | The requested language of the response. If not matching it falls back to default language. | [optional]  |

### Return type

[**AgravityInfoResponse**](AgravityInfoResponse.md)

### Authorization

[function_key](../README.md#function_key)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Returns the info that the post update was successful. (Code: de2972b8-d3e3-42ff-8c2c-5bd9b088dfef) |  -  |
| **400** | A parameter is null. (Code: 22edc392-b73c-4d89-9710-6aad5edb0c1a)&lt;br&gt;Object is not a valid AssetBulkUpdate object. (Code: 0112ebf9-45cd-4284-b728-2c809faa4e4b)&lt;br&gt;Object is empty and not a valid AssetBulkUpdate object. (Code: f81bee0b-6e4e-4b6e-8f5c-019e498ca845)&lt;br&gt;Not sure what to update. asset_ids is not given. (Code: 93218cdf-4511-46a7-b336-46757d788d74)&lt;br&gt;Not all asset_ids are valid. (Code: 07e041bd-236c-4e48-bfca-89f9f5d340af)&lt;br&gt;Could not find all  asset_ids in database. (Code: aa4e7de0-db79-431a-b684-76d157820775)&lt;br&gt;Could not find all  asset_ids relations in database. (Code: 100b3432-1a26-4618-ba84-b1ac72ab1ec8)&lt;br&gt;Error on updating custom items on asset {asset.Id}. Reason see inner exception.  (Code: 72faa784-ae94-49a9-a30e-1bad3674d432&lt;br&gt;Error on replacing custom items on asset {asset.Id}. Reason see inner exception. (Code: e83b9194-cbfe-43ec-bbfb-6d3fae5ad4d0)&lt;br&gt;The mandatory item &#39;&lt;item.Name&gt;&#39; can not be removed without having default value or is of type &#39;userdefinedlist&#39;. (Code: 85b9c37d-6c66-46c4-9107-f7acf198e68a)&lt;br&gt;Property &#39;&lt;item name&gt;&#39; is mandatory but no default value was set! (Code: 16822359-3639-4610-b075-b39aa9e106a8)&lt;br&gt;Property &#39;&lt;item name&gt;&#39; is not of defined type: &lt;item type&gt;  (Code: 1e9a1470-cfba-4a56-97b0-c44f77671880)&lt;br&gt;Property &#39;&lt;item name&gt;&#39; is mandatory but no value was given! (Code: c23f73ed-89cb-47c1-b653-3ec99c460707) |  -  |
| **401** | Unauthorized. API Key not provided. |  -  |
| **404** | If the asset with the ID was not found. |  -  |
| **403** | Not enough privileges to access item. |  -  |
| **500** | Internal server error. Please contact administrator. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="httpassetscreate"></a>
# **HttpAssetsCreate**
> Asset HttpAssetsCreate (string collectionid, Asset asset, bool? translations = null, string acceptLanguage = null)



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
            var acceptLanguage = "acceptLanguage_example";  // string | The requested language of the response. If not matching it falls back to default language. (optional) 

            try
            {
                Asset result = apiInstance.HttpAssetsCreate(collectionid, asset, translations, acceptLanguage);
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
    ApiResponse<Asset> response = apiInstance.HttpAssetsCreateWithHttpInfo(collectionid, asset, translations, acceptLanguage);
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
| **acceptLanguage** | **string** | The requested language of the response. If not matching it falls back to default language. | [optional]  |

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
| **400** | A parameter is null. (Code: 8f9036ff-037d-49a1-aab2-57899e5d30e6)&lt;br&gt;Given asset body is not valid. (Code: a51d1697-f56e-4fa3-bde8-3ab44e6cbb0a)&lt;br&gt;Asset availability has a confusing state: {updated.Availability}. (Code: 5515ebe5-2751-4760-a864-47812126b9a1)&lt;br&gt;Ambiguous information: Asset available_from can not be greater or equal as available_to when asset should be available.(Code: 16338bcd-614c-4322-a164-e3112d622392 )&lt;br&gt;Ambiguous information: Asset available_from can not be less or equal as available_to when asset should be locked and is not in the future. (Code: 092ddb50-2af8-49a1-b005-68c9d5c600d1)&lt;br&gt;Not valid asset id. (Code: b2409333-b6d4-4efc-b21e-56c1db9e9d25)&lt;br&gt;Can not create asset with id {input.Id}. Asset already exists. Delete first. (Code: ef721e67-6d4b-4e60-81cf-4be8f14581eb)&lt;br&gt;Error on creating custom items on asset. (Code: 4e780f21-17fc-4125-a9d8-2cf0c23d84d6) |  -  |
| **401** | Unauthorized. API Key not provided. |  -  |
| **500** | Internal server error. Please contact administrator. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="httpassetsdeletebyid"></a>
# **HttpAssetsDeleteById**
> void HttpAssetsDeleteById (string id)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Agravity.Public.Api;
using Agravity.Public.Client;
using Agravity.Public.Model;

namespace Example
{
    public class HttpAssetsDeleteByIdExample
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

            try
            {
                apiInstance.HttpAssetsDeleteById(id);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling PublicAssetManagementApi.HttpAssetsDeleteById: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the HttpAssetsDeleteByIdWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    apiInstance.HttpAssetsDeleteByIdWithHttpInfo(id);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling PublicAssetManagementApi.HttpAssetsDeleteByIdWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **string** | The ID of the asset. |  |

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
| **400** | A parameter is null. (Code: 355e5695-2dcb-4495-87ff-580540ad6274) |  -  |
| **401** | Unauthorized. API Key not provided. |  -  |
| **204** | The delete operation of the asset with the given ID was successful. |  -  |
| **404** | If the asset with the ID was not found. |  -  |
| **403** | Not enough privileges to access item. |  -  |
| **500** | Internal server error. Please contact administrator. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="httpassetsget"></a>
# **HttpAssetsGet**
> AssetPageResult HttpAssetsGet (string collectionid = null, string collectiontypeid = null, string fields = null, bool? expose = null, string continuationToken = null, int? limit = null, string orderby = null, string filter = null, bool? items = null, bool? translations = null, string acceptLanguage = null)



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
            var collectionid = "collectionid_example";  // string | The ID of the collection where these assets should come from. (Is not required when 'collectiontypeid' is set.) (optional) 
            var collectiontypeid = "collectiontypeid_example";  // string | The ID of the collection type where these assets should come from. (Is not required when 'collectionid' is set.) CAUTION: The assets returned are not distinct => Duplicates are possible if assets are in multiple collections in this collection type! (optional) 
            var fields = "fields_example";  // string | This limits the fields which are returned, separated by comma (','). Blobs can be limited with '.' on their container. (i.e. fields=blobs.thumbnails). Only if 'thumbnails' is set, the placeholder of this asset type are returned if no thumbnail blob is found. (optional) 
            var expose = true;  // bool? | This indicates if the given blobs should have URLs where these can be requested. (If not limited through 'fields' parameter it will expose all URLs of all blobs.) (optional) 
            var continuationToken = "continuationToken_example";  // string | Each result returns the continous token if more results are available than requested. With this token, the next page could be fetched. (URL encoded!) (optional) 
            var limit = 56;  // int? | This number limits the page result of assets. (optional) 
            var orderby = "orderby_example";  // string | How the return assets are sorted. Default is property: modified_date (newest first). (optional) 
            var filter = "filter_example";  // string | This will limit the output on specific parameters which are separated by ':', '!:', '>', '>=', '<', '<=' (optional) 
            var items = true;  // bool? | The items can be extended to fully filled items. (optional) 
            var translations = true;  // bool? | When default language should be returned and the translation dictionary is delivered. (Ignores the \"Accept-Language\" header) (optional) 
            var acceptLanguage = "acceptLanguage_example";  // string | The requested language of the response. If not matching it falls back to default language. (optional) 

            try
            {
                AssetPageResult result = apiInstance.HttpAssetsGet(collectionid, collectiontypeid, fields, expose, continuationToken, limit, orderby, filter, items, translations, acceptLanguage);
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
    ApiResponse<AssetPageResult> response = apiInstance.HttpAssetsGetWithHttpInfo(collectionid, collectiontypeid, fields, expose, continuationToken, limit, orderby, filter, items, translations, acceptLanguage);
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
| **collectionid** | **string** | The ID of the collection where these assets should come from. (Is not required when &#39;collectiontypeid&#39; is set.) | [optional]  |
| **collectiontypeid** | **string** | The ID of the collection type where these assets should come from. (Is not required when &#39;collectionid&#39; is set.) CAUTION: The assets returned are not distinct &#x3D;&gt; Duplicates are possible if assets are in multiple collections in this collection type! | [optional]  |
| **fields** | **string** | This limits the fields which are returned, separated by comma (&#39;,&#39;). Blobs can be limited with &#39;.&#39; on their container. (i.e. fields&#x3D;blobs.thumbnails). Only if &#39;thumbnails&#39; is set, the placeholder of this asset type are returned if no thumbnail blob is found. | [optional]  |
| **expose** | **bool?** | This indicates if the given blobs should have URLs where these can be requested. (If not limited through &#39;fields&#39; parameter it will expose all URLs of all blobs.) | [optional]  |
| **continuationToken** | **string** | Each result returns the continous token if more results are available than requested. With this token, the next page could be fetched. (URL encoded!) | [optional]  |
| **limit** | **int?** | This number limits the page result of assets. | [optional]  |
| **orderby** | **string** | How the return assets are sorted. Default is property: modified_date (newest first). | [optional]  |
| **filter** | **string** | This will limit the output on specific parameters which are separated by &#39;:&#39;, &#39;!:&#39;, &#39;&gt;&#39;, &#39;&gt;&#x3D;&#39;, &#39;&lt;&#39;, &#39;&lt;&#x3D;&#39; | [optional]  |
| **items** | **bool?** | The items can be extended to fully filled items. | [optional]  |
| **translations** | **bool?** | When default language should be returned and the translation dictionary is delivered. (Ignores the \&quot;Accept-Language\&quot; header) | [optional]  |
| **acceptLanguage** | **string** | The requested language of the response. If not matching it falls back to default language. | [optional]  |

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

<a id="httpassetsgetbyid"></a>
# **HttpAssetsGetById**
> Asset HttpAssetsGetById (string id, string fields = null, bool? expose = null, bool? translations = null, string acceptLanguage = null)



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
            var acceptLanguage = "acceptLanguage_example";  // string | The requested language of the response. If not matching it falls back to default language. (optional) 

            try
            {
                Asset result = apiInstance.HttpAssetsGetById(id, fields, expose, translations, acceptLanguage);
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
    ApiResponse<Asset> response = apiInstance.HttpAssetsGetByIdWithHttpInfo(id, fields, expose, translations, acceptLanguage);
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
| **acceptLanguage** | **string** | The requested language of the response. If not matching it falls back to default language. | [optional]  |

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

<a id="httppublicassetsupdatebyid"></a>
# **HttpPublicAssetsUpdateById**
> Asset HttpPublicAssetsUpdateById (string id, Asset asset, bool? translations = null, string acceptLanguage = null)



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
            var acceptLanguage = "acceptLanguage_example";  // string | The requested language of the response. If not matching it falls back to default language. (optional) 

            try
            {
                Asset result = apiInstance.HttpPublicAssetsUpdateById(id, asset, translations, acceptLanguage);
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
    ApiResponse<Asset> response = apiInstance.HttpPublicAssetsUpdateByIdWithHttpInfo(id, asset, translations, acceptLanguage);
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
| **acceptLanguage** | **string** | The requested language of the response. If not matching it falls back to default language. | [optional]  |

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

