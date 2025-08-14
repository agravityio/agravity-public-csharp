# Agravity.Public.Api.PublicAIOperationsApi

All URIs are relative to *http://localhost:7072/api*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**HttpReverseAssetSearch**](PublicAIOperationsApi.md#httpreverseassetsearch) | **POST** /ai/reverseassetsearch |  |

<a id="httpreverseassetsearch"></a>
# **HttpReverseAssetSearch**
> SearchResult HttpReverseAssetSearch (string acceptLanguage = null, string name = null, string collectionid = null, System.IO.Stream file = null, string filename = null, string previewof = null)



This endpoint allows to use one asset which is used for searching similar assets.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Agravity.Public.Api;
using Agravity.Public.Client;
using Agravity.Public.Model;

namespace Example
{
    public class HttpReverseAssetSearchExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost:7072/api";
            // Configure API key authorization: function_key
            config.AddApiKey("x-functions-key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("x-functions-key", "Bearer");

            var apiInstance = new PublicAIOperationsApi(config);
            var acceptLanguage = "acceptLanguage_example";  // string | The requested language of the response. If not matching it falls back to default language. (optional) 
            var name = "name_example";  // string |  (optional) 
            var collectionid = "collectionid_example";  // string |  (optional) 
            var file = new System.IO.MemoryStream(System.IO.File.ReadAllBytes("/path/to/file.txt"));  // System.IO.Stream |  (optional) 
            var filename = "filename_example";  // string |  (optional) 
            var previewof = "previewof_example";  // string |  (optional) 

            try
            {
                SearchResult result = apiInstance.HttpReverseAssetSearch(acceptLanguage, name, collectionid, file, filename, previewof);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling PublicAIOperationsApi.HttpReverseAssetSearch: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the HttpReverseAssetSearchWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<SearchResult> response = apiInstance.HttpReverseAssetSearchWithHttpInfo(acceptLanguage, name, collectionid, file, filename, previewof);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling PublicAIOperationsApi.HttpReverseAssetSearchWithHttpInfo: " + e.Message);
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

[**SearchResult**](SearchResult.md)

### Authorization

[function_key](../README.md#function_key)

### HTTP request headers

 - **Content-Type**: multipart/form-data
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Returns a list of similar Assets. |  -  |
| **400** | Reverse Asset search failed. Query Asset Content length is insuffient (0 or too big). (Code: 76695187-7ace-4a2e-9fd2-7f0170a998d9)&lt;br&gt;Wrong content media type for Query Asset.Please upload file with multipart/form-data. (Code: 5ab68591-c21e-4cd7-8d00-01c13bfbb384)&lt;br&gt;Could not find file in multi-part data. (Code: cbdb4838-fab5-48b3-a8de-ac591316c904)&lt;br&gt;File type is not supported for reverse Asset search. (Code: 1dba4d87-6162-40b9-9076-2d56af6bcdbe)&lt;br&gt; |  -  |
| **401** | Unauthorized. API Key not provided. |  -  |
| **403** | Not enough privileges to access item. |  -  |
| **500** | Internal server error. Please contact administrator. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

