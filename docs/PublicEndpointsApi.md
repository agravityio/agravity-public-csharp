# Agravity.Public.Api.PublicEndpointsApi

All URIs are relative to *http://localhost:7072/api*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**HttpAssetGetBlobDownload**](PublicEndpointsApi.md#httpassetgetblobdownload) | **GET** /public/download |  |
| [**HttpAssetGetViewForPortal**](PublicEndpointsApi.md#httpassetgetviewforportal) | **GET** /public/view |  |

<a id="httpassetgetblobdownload"></a>
# **HttpAssetGetBlobDownload**
> System.IO.Stream HttpAssetGetBlobDownload (string assetId, string format, string portalId = null, bool? locked = null, bool? uncompleted = null)



This endpoint returns the binary data of an asset to be downloaded.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Agravity.Public.Api;
using Agravity.Public.Client;
using Agravity.Public.Model;

namespace Example
{
    public class HttpAssetGetBlobDownloadExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost:7072/api";
            var apiInstance = new PublicEndpointsApi(config);
            var assetId = "assetId_example";  // string | The ID of the asset.
            var format = "format_example";  // string | The name of the format (download format) or container.
            var portalId = "portalId_example";  // string | If the request comes from portal this is the indicator. (optional) 
            var locked = true;  // bool? | Returns assets on permissions which are locked and accessable (User needs editor permissions). Default: false (optional) 
            var uncompleted = true;  // bool? | Returns assets which are not in state ACTIVE (User needs editor permissions). Default: false (optional) 

            try
            {
                System.IO.Stream result = apiInstance.HttpAssetGetBlobDownload(assetId, format, portalId, locked, uncompleted);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling PublicEndpointsApi.HttpAssetGetBlobDownload: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the HttpAssetGetBlobDownloadWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<System.IO.Stream> response = apiInstance.HttpAssetGetBlobDownloadWithHttpInfo(assetId, format, portalId, locked, uncompleted);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling PublicEndpointsApi.HttpAssetGetBlobDownloadWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **assetId** | **string** | The ID of the asset. |  |
| **format** | **string** | The name of the format (download format) or container. |  |
| **portalId** | **string** | If the request comes from portal this is the indicator. | [optional]  |
| **locked** | **bool?** | Returns assets on permissions which are locked and accessable (User needs editor permissions). Default: false | [optional]  |
| **uncompleted** | **bool?** | Returns assets which are not in state ACTIVE (User needs editor permissions). Default: false | [optional]  |

### Return type

**System.IO.Stream**

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/octet-stream, application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Returns the direct blob for download. |  -  |
| **400** | Asset ID is mandatory and not valid. (Code: 4cfcbea2-e8ce-40b2-a020-63b940850646)&lt;br&gt;A valid Portal ID is mandatory. (Code: 984f8a38-308a-4fc2-a705-2ddc4939f9b7)&lt;br&gt;Downloadformat with id &#39;{format}&#39; not found. (Code: f915aa41-8b93-4ab9-9806-89196e83dc59)&lt;br&gt;Downloadformat is not allowed on other asset type than image. (Code: d0e12349-f98b-499c-a6cb-082e18af4852)&lt;br&gt;Error on preparing downloadformat &#39;{format}&#39; for asset ({asset.Id}). (Code: 0dc61246-574e-45da-99c9-e3ada771579c)&lt;br&gt;Downloadformat with id &#39;{format}&#39; for asset ({asset.Id}) not found. (Code: 57490ca4-7a92-41fb-96e2-59327b04865f)&lt;br&gt;Blob with format &#39;{format}&#39; not found. (Code: 597ac315-4c5d-4b26-90d0-0e2e8d30b0b3)&lt;br&gt;Get download from asset {asset.Id} failed. Format &#39;{format}&#39; not found. (Code: bf00d12f-15a1-4222-a347-77c5b601e506)&lt;br&gt; |  -  |
| **404** | The requested item could not be found. |  -  |
| **500** | Internal server error. Please contact administrator. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="httpassetgetviewforportal"></a>
# **HttpAssetGetViewForPortal**
> System.IO.Stream HttpAssetGetViewForPortal (string assetId, string portalId, string format, string download = null)



This endpoint returns the content of an asset which is available in a specific portal (portal_id is \"key\") and returns the blob directly.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Agravity.Public.Api;
using Agravity.Public.Client;
using Agravity.Public.Model;

namespace Example
{
    public class HttpAssetGetViewForPortalExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost:7072/api";
            var apiInstance = new PublicEndpointsApi(config);
            var assetId = "assetId_example";  // string | The ID of the asset.
            var portalId = "portalId_example";  // string | If the request comes from portal this is the indicator.
            var format = "format_example";  // string | The name of the format (download format) or container.
            var download = "download_example";  // string | True if a direct download with file name should be started. (optional) 

            try
            {
                System.IO.Stream result = apiInstance.HttpAssetGetViewForPortal(assetId, portalId, format, download);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling PublicEndpointsApi.HttpAssetGetViewForPortal: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the HttpAssetGetViewForPortalWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<System.IO.Stream> response = apiInstance.HttpAssetGetViewForPortalWithHttpInfo(assetId, portalId, format, download);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling PublicEndpointsApi.HttpAssetGetViewForPortalWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **assetId** | **string** | The ID of the asset. |  |
| **portalId** | **string** | If the request comes from portal this is the indicator. |  |
| **format** | **string** | The name of the format (download format) or container. |  |
| **download** | **string** | True if a direct download with file name should be started. | [optional]  |

### Return type

**System.IO.Stream**

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/octet-stream, application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Returns the direct blob for download. |  -  |
| **400** | Asset ID is mandatory and not valid. (Code: df5f7d40-6333-4501-b3b0-5f0332bb13f6)&lt;br&gt;A valid Portal ID is mandatory. (Code: be59e94a-0f76-415f-a6b7-065e3abfc64e)&lt;br&gt;Downloadformat with id &#39;{format}&#39; not found. (Code: eb70a990-6a28-40b1-8631-63a085fd8ac3)&lt;br&gt;Downloadformat is not allowed on other asset type than image. (Code: e77d141b-a2b4-4746-8910-5b97b2623cc4)&lt;br&gt;Error on preparing downloadformat &#39;{format}&#39; for asset ({asset.Id}). (Code: 9c5f1f3e-2b6a-4f0c-8b3f-3e2f4a4d5e6f)Downloadformat with id &#39;{format}&#39; for asset ({asset.Id}) not found. (Code: 44cc4dde-d95d-4814-a566-0cfca2d48d1b)&lt;br&gt;Blob with format &#39;{format}&#39; not found. (Code: 02327d00-d614-4cfd-924e-61024d1eef4b)&lt;br&gt;Get view from asset {asset.Id} failed. Format &#39;{format}&#39; not found. (Code: b396ed17-7153-45f4-881e-05ed560bf6ba)&lt;br&gt; |  -  |
| **404** | The requested item could not be found. |  -  |
| **500** | Internal server error. Please contact administrator. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

