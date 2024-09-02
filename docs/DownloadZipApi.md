# Agravity.Public.Api.DownloadZipApi

All URIs are relative to *http://localhost:7071/api*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**HttpDownloadZip**](DownloadZipApi.md#httpdownloadzip) | **POST** /downloadzip |  |

<a id="httpdownloadzip"></a>
# **HttpDownloadZip**
> DownloadObject HttpDownloadZip (DownloadZipRequest downloadZipRequest)



This endpoint queues assets in a defined download format for ZIP generation. Queues will deliver an email with a download link.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Agravity.Public.Api;
using Agravity.Public.Client;
using Agravity.Public.Model;

namespace Example
{
    public class HttpDownloadZipExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost:7071/api";
            // Configure OAuth2 access token for authorization: msal_auth
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new DownloadZipApi(config);
            var downloadZipRequest = new DownloadZipRequest(); // DownloadZipRequest | This endpoint queues assets in a defined download format for ZIP generation. Queues will deliver an email with a download link.

            try
            {
                DownloadObject result = apiInstance.HttpDownloadZip(downloadZipRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DownloadZipApi.HttpDownloadZip: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the HttpDownloadZipWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<DownloadObject> response = apiInstance.HttpDownloadZipWithHttpInfo(downloadZipRequest);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling DownloadZipApi.HttpDownloadZipWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **downloadZipRequest** | [**DownloadZipRequest**](DownloadZipRequest.md) | This endpoint queues assets in a defined download format for ZIP generation. Queues will deliver an email with a download link. |  |

### Return type

[**DownloadObject**](DownloadObject.md)

### Authorization

[msal_auth](../README.md#msal_auth)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | The download object which contains all information about the download request. |  -  |
| **400** | Could not create zip from empty reponse (Code: 50952e11-2046-4e10-8128-a291669c5a9d)&lt;br/&gt;Object is not a valid download zip request. (Code: 436ea7ba-c5e1-447c-bfb1-c739fee9434e)&lt;br/&gt;Not a valid request - missing assets. (Code: dff233a8-6f69-4871-8adf-4f55c529a28c)&lt;br/&gt;Not a valid request - missing assets. (Code: 4b5ca4c2-d404-4f70-ac10-2b22f28fa0b2)&lt;br/&gt;Could not be less than 5 min valid. Increase the time span between valid_from and valid_until. (Code: 94107307-b14d-4e19-98c5-e86b09014684)&lt;br/&gt;No email address could be extracted from author - will not create share. (Code: 50da783c-3b79-4638-9fbd-27bd5c581def) |  -  |
| **401** | Unauthorized. Bearer Token not provided. |  -  |
| **404** | The requested item could not be found. |  -  |
| **500** | Internal server error. Please contact administrator. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

