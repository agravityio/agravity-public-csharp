# AgravityPublic.Api.PublicAssetManagementApi

All URIs are relative to *http://localhost:7072/api*

Method | HTTP request | Description
------------- | ------------- | -------------
[**HttpAssetUploadFile**](PublicAssetManagementApi.md#httpassetuploadfile) | **POST** /assetsupload | 
[**HttpAssetsGet**](PublicAssetManagementApi.md#httpassetsget) | **GET** /assets | 
[**HttpAssetsGetById**](PublicAssetManagementApi.md#httpassetsgetbyid) | **GET** /assets/{id} | 



## HttpAssetUploadFile

> Asset HttpAssetUploadFile (string name = null, string collectionId = null, System.IO.Stream file = null)



### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using AgravityPublic.Api;
using AgravityPublic.Client;
using AgravityPublic.Model;

namespace Example
{
    public class HttpAssetUploadFileExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "http://localhost:7072/api";
            // Configure API key authorization: function_key
            Configuration.Default.AddApiKey("x-functions-key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("x-functions-key", "Bearer");

            var apiInstance = new PublicAssetManagementApi(Configuration.Default);
            var name = "name_example";  // string |  (optional) 
            var collectionId = "collectionId_example";  // string |  (optional) 
            var file = new System.IO.MemoryStream(System.IO.File.ReadAllBytes("/path/to/file.txt"));  // System.IO.Stream |  (optional) 

            try
            {
                Asset result = apiInstance.HttpAssetUploadFile(name, collectionId, file);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling PublicAssetManagementApi.HttpAssetUploadFile: " + e.Message );
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
 **name** | **string**|  | [optional] 
 **collectionId** | **string**|  | [optional] 
 **file** | **System.IO.Stream**|  | [optional] 

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
| **201** | Returns the created simple asset. |  -  |
| **400** | Request or Database client is null. (Code: feda1ab0-1477-4a76-abdd-3fa6fbdd0def)&lt;br&gt;Could not find file in multi-part data. (Code: b473c560-3ea1-4065-92e6-607973af9d9c)&lt;br&gt;This file is not supported. (Code: 12ac8746-349a-42c0-b73c-33257b73c728) |  -  |
| **401** | Unauthorized. API Key not provided. |  -  |
| **500** | Internal server error. Please contact administrator. |  -  |

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## HttpAssetsGet

> AssetPageResult HttpAssetsGet (string collectionid, string fields = null, bool? expose = null, string continuationToken = null, int? limit = null, string orderby = null, bool? techdata = null)



This endpoint lists all the assets, which are stored in the database and not deleted (status \"A\")

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using AgravityPublic.Api;
using AgravityPublic.Client;
using AgravityPublic.Model;

namespace Example
{
    public class HttpAssetsGetExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "http://localhost:7072/api";
            // Configure API key authorization: function_key
            Configuration.Default.AddApiKey("x-functions-key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("x-functions-key", "Bearer");

            var apiInstance = new PublicAssetManagementApi(Configuration.Default);
            var collectionid = "collectionid_example";  // string | The ID of the collection where these assets should come from. (\"empty\" is allowed)
            var fields = "fields_example";  // string | This limits the fields which are returned, separated by comma (','). Blobs can be limited with '.' on their container. (i.e. fields=blobs.thumbnails). Only if 'thumbnails' is set, the placeholder of this asset type are returned if no thumbnail blob is found. (optional) 
            var expose = true;  // bool? | This indicates if the given blobs should have URLs where these can be requested. (If not limited through 'fields' parameter it will expose all URLs of all blobs.) (optional) 
            var continuationToken = "continuationToken_example";  // string | Each result returns the continous token if more results are available than requested. With this token, the next page could be fetched. (URL encoded!) (optional) 
            var limit = 56;  // int? | This number limits the page result of assets. (optional) 
            var orderby = "orderby_example";  // string | How the return assets are sorted. Default is property: created_date (newest first). (optional) 
            var techdata = true;  // bool? | This parameter will include the techdata property inside orig_blob. (optional) 

            try
            {
                AssetPageResult result = apiInstance.HttpAssetsGet(collectionid, fields, expose, continuationToken, limit, orderby, techdata);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling PublicAssetManagementApi.HttpAssetsGet: " + e.Message );
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
 **collectionid** | **string**| The ID of the collection where these assets should come from. (\&quot;empty\&quot; is allowed) | 
 **fields** | **string**| This limits the fields which are returned, separated by comma (&#39;,&#39;). Blobs can be limited with &#39;.&#39; on their container. (i.e. fields&#x3D;blobs.thumbnails). Only if &#39;thumbnails&#39; is set, the placeholder of this asset type are returned if no thumbnail blob is found. | [optional] 
 **expose** | **bool?**| This indicates if the given blobs should have URLs where these can be requested. (If not limited through &#39;fields&#39; parameter it will expose all URLs of all blobs.) | [optional] 
 **continuationToken** | **string**| Each result returns the continous token if more results are available than requested. With this token, the next page could be fetched. (URL encoded!) | [optional] 
 **limit** | **int?**| This number limits the page result of assets. | [optional] 
 **orderby** | **string**| How the return assets are sorted. Default is property: created_date (newest first). | [optional] 
 **techdata** | **bool?**| This parameter will include the techdata property inside orig_blob. | [optional] 

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

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## HttpAssetsGetById

> Asset HttpAssetsGetById (string id, string fields = null, bool? expose = null)



This endpoint returns one single asset (from ID). If the returned asset is from a special asset type (e.g. \"AssetImage\") it returns the full entity.

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using AgravityPublic.Api;
using AgravityPublic.Client;
using AgravityPublic.Model;

namespace Example
{
    public class HttpAssetsGetByIdExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "http://localhost:7072/api";
            // Configure API key authorization: function_key
            Configuration.Default.AddApiKey("x-functions-key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("x-functions-key", "Bearer");

            var apiInstance = new PublicAssetManagementApi(Configuration.Default);
            var id = "id_example";  // string | The ID of the asset.
            var fields = "fields_example";  // string | Which fields are need to be filled out with comma separated. If one is set all non mandatory fields are left out. No validation if field exist. (optional) 
            var expose = true;  // bool? | This indicates if the given blobs should have URLs where these can be requested. It will expose placeholder blobs if no 'thumbnail' is found.) (optional) 

            try
            {
                Asset result = apiInstance.HttpAssetsGetById(id, fields, expose);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling PublicAssetManagementApi.HttpAssetsGetById: " + e.Message );
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
 **fields** | **string**| Which fields are need to be filled out with comma separated. If one is set all non mandatory fields are left out. No validation if field exist. | [optional] 
 **expose** | **bool?**| This indicates if the given blobs should have URLs where these can be requested. It will expose placeholder blobs if no &#39;thumbnail&#39; is found.) | [optional] 

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

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)

