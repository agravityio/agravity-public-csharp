# Agravity.Public.Api.StockImportApi

All URIs are relative to *http://localhost:7071/api*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**HttpStockImportPixabay**](StockImportApi.md#httpstockimportpixabay) | **GET** /stockimport/pixabay |  |
| [**HttpStockImportUnsplash**](StockImportApi.md#httpstockimportunsplash) | **GET** /stockimport/unsplash |  |

<a id="httpstockimportpixabay"></a>
# **HttpStockImportPixabay**
> GroupAllAppData HttpStockImportPixabay (string q, int? count = null, string mediaType = null)



This imports 10 images from Pixabay into new collection type with specific id: t111111111111

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Agravity.Public.Api;
using Agravity.Public.Client;
using Agravity.Public.Model;

namespace Example
{
    public class HttpStockImportPixabayExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost:7071/api";
            // Configure OAuth2 access token for authorization: msal_auth
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new StockImportApi(config);
            var q = "q_example";  // string | The query term which should be found on Pixabay.
            var count = 56;  // int? | The maximum count of images which should be imported (Default 10). (optional) 
            var mediaType = "mediaType_example";  // string | This optional parameter indicates if it should be video (default: image) (optional) 

            try
            {
                GroupAllAppData result = apiInstance.HttpStockImportPixabay(q, count, mediaType);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling StockImportApi.HttpStockImportPixabay: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the HttpStockImportPixabayWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<GroupAllAppData> response = apiInstance.HttpStockImportPixabayWithHttpInfo(q, count, mediaType);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling StockImportApi.HttpStockImportPixabayWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **q** | **string** | The query term which should be found on Pixabay. |  |
| **count** | **int?** | The maximum count of images which should be imported (Default 10). | [optional]  |
| **mediaType** | **string** | This optional parameter indicates if it should be video (default: image) | [optional]  |

### Return type

[**GroupAllAppData**](GroupAllAppData.md)

### Authorization

[msal_auth](../README.md#msal_auth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | The full collection type with collection and all assets. |  -  |
| **400** | A parameter is null. (Code: ed625bbd-334e-4364-ae73-6051008db6ca)&lt;br&gt;Provide at least parameter \&quot;q&#x3D;\&quot; with search string (url encoded). (Code: c0d2fd6b-df06-46a4-b2ec-0f76abbc292e)&lt;br&gt;Minimum count of pixabay items is 3! (Code: 86c47422-f123-453a-934a-ee72d0817396)&lt;br&gt;Pixabay key not set!. (Code: ede6dc8a-96eb-40c9-a104-dd8808d7f35e)&lt;br&gt;No parameter \&quot;q&#x3D;\&quot; was found or search string is too short (min 3 characters) or too long (max 100 characters). (Code: 5a7ca31b-5f12-40bd-a832-1b07358cf8d8) |  -  |
| **401** | Unauthorized. Bearer Token not provided. |  -  |
| **500** | Internal server error. Please contact administrator. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="httpstockimportunsplash"></a>
# **HttpStockImportUnsplash**
> GroupAllAppData HttpStockImportUnsplash (string q, int? count = null)



This imports 10 images from Unsplash into new collection type with specific id: t10000000-0000-0000-0000-000000000000

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Agravity.Public.Api;
using Agravity.Public.Client;
using Agravity.Public.Model;

namespace Example
{
    public class HttpStockImportUnsplashExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost:7071/api";
            // Configure OAuth2 access token for authorization: msal_auth
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new StockImportApi(config);
            var q = "q_example";  // string | The query term which should be found on Unsplash.
            var count = 56;  // int? | The maximum count of images which should be imported (Default 10). (optional) 

            try
            {
                GroupAllAppData result = apiInstance.HttpStockImportUnsplash(q, count);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling StockImportApi.HttpStockImportUnsplash: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the HttpStockImportUnsplashWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<GroupAllAppData> response = apiInstance.HttpStockImportUnsplashWithHttpInfo(q, count);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling StockImportApi.HttpStockImportUnsplashWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **q** | **string** | The query term which should be found on Unsplash. |  |
| **count** | **int?** | The maximum count of images which should be imported (Default 10). | [optional]  |

### Return type

[**GroupAllAppData**](GroupAllAppData.md)

### Authorization

[msal_auth](../README.md#msal_auth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | The full collection type with collection and all assets. |  -  |
| **400** | A parameter is null. (Code: ed625bbd-334e-4364-ae73-6051008db6ca)&lt;br&gt;Provide at least parameter \&quot;q&#x3D;\&quot; with search string (url encoded). (Code: 9ef3e3d2-c9d8-11ea-87d0-0242ac130003)&lt;br&gt;Unsplash key or secret not set!. (Code: 56a258c4-b0ee-484d-a91e-0724c406095e)&lt;br&gt;Status of Unsplash API unknown. (Code: 5b0af618-71a5-4ae6-95aa-3f5f249f0e6c)&lt;br&gt;Currently the Unsplash API is busy! Please wait a few moments! Max. 50 requests per hour allowed.. (Code: cdc550d3-089d-459e-a99d-d18b91609656)&lt;br&gt;No parameter \&quot;q&#x3D;\&quot; was found or search string is too short (min 3 characters) or too long (max 100 characters). (Code: a3ce4154-c9d8-11ea-87d0-0242ac130003) |  -  |
| **401** | Unauthorized. Bearer Token not provided. |  -  |
| **500** | Internal server error. Please contact administrator. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

