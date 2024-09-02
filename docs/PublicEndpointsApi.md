# Agravity.Public.Api.PublicEndpointsApi

All URIs are relative to *http://localhost:7072/api*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**HttpAssetGetViewForPortal**](PublicEndpointsApi.md#httpassetgetviewforportal) | **GET** /public/view |  |

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
| **400** | Portal ID is mandatory and not valid. {type} (Code: be59e94a-0f76-415f-a6b7-065e3abfc64e)&lt;br&gt;Downloadformat is not allowed on other asset type than image (Code: e77d141b-a2b4-4746-8910-5b97b2623cc4)&lt;br&gt;Downloadformat with id &#39;{format}&#39; not found. (Code: eb70a990-6a28-40b1-8631-63a085fd8ac3)&lt;br&gt;Tried to access not existion blob: {asset.Id} from container: {downloadFormat.OriginContainer}. (Code: 53683b61-67f4-47f9-9392-e7c651175854)&lt;br&gt;General error with message. (Code: 5cd6a8bd-2a53-4b6a-adef-efd898e8c248)&lt;br&gt;Blob with format &#39;{format}&#39; not found. (Code: 5a656869-4678-41dd-a311-af79e319d83f)&lt;br&gt;Get view from asset {asset?.Id} failed. Format &#39;{format}&#39; not found. (Code: 34473124-d3d4-4de0-8112-6798e4728e1f) |  -  |
| **404** | The requested item could not be found. |  -  |
| **500** | Internal server error. Please contact administrator. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

