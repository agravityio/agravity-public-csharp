# Agravity.Public.Api.PublicSharingManagementApi

All URIs are relative to *http://localhost:7072/api*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**HttpQuickShareGetById**](PublicSharingManagementApi.md#httpquicksharegetbyid) | **GET** /quickshares/{id} |  |
| [**HttpSharedCollectionsGetById**](PublicSharingManagementApi.md#httpsharedcollectionsgetbyid) | **GET** /shared/{id} |  |
| [**HttpSharedCollectionsGetStatusZipById**](PublicSharingManagementApi.md#httpsharedcollectionsgetstatuszipbyid) | **GET** /shared/{id}/zip/{zipId} |  |
| [**HttpSharedCollectionsRequestZipById**](PublicSharingManagementApi.md#httpsharedcollectionsrequestzipbyid) | **POST** /shared/{id}/zip |  |

<a id="httpquicksharegetbyid"></a>
# **HttpQuickShareGetById**
> QuickShareFull HttpQuickShareGetById (string id, string continuationToken = null, int? limit = null, string orderby = null)



Returns one single quick share (from ID)

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Agravity.Public.Api;
using Agravity.Public.Client;
using Agravity.Public.Model;

namespace Example
{
    public class HttpQuickShareGetByIdExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost:7072/api";
            var apiInstance = new PublicSharingManagementApi(config);
            var id = "id_example";  // string | The ID of the quick share.
            var continuationToken = "continuationToken_example";  // string | Each result returns the continous token if more results are available than requested. With this token, the next page could be fetched. (URL encoded!) (optional) 
            var limit = 56;  // int? | This number limits the page result of assets. (optional) 
            var orderby = "orderby_example";  // string | How the return assets are sorted. Default is property: created_date (newest first). (optional) 

            try
            {
                QuickShareFull result = apiInstance.HttpQuickShareGetById(id, continuationToken, limit, orderby);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling PublicSharingManagementApi.HttpQuickShareGetById: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the HttpQuickShareGetByIdWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<QuickShareFull> response = apiInstance.HttpQuickShareGetByIdWithHttpInfo(id, continuationToken, limit, orderby);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling PublicSharingManagementApi.HttpQuickShareGetByIdWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **string** | The ID of the quick share. |  |
| **continuationToken** | **string** | Each result returns the continous token if more results are available than requested. With this token, the next page could be fetched. (URL encoded!) | [optional]  |
| **limit** | **int?** | This number limits the page result of assets. | [optional]  |
| **orderby** | **string** | How the return assets are sorted. Default is property: created_date (newest first). | [optional]  |

### Return type

[**QuickShareFull**](QuickShareFull.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Returns the quick share with the given ID. |  -  |
| **400** | Not valid quick share id! (Code: 02141b45-97dd-4474-aefb-a7774f8b538e) |  -  |
| **404** | Quick share date expired! (Code: 6758d66e-0ce6-4770-a497-01a578eac12c)&lt;br&gt;or Quick share was not found. (Code: 412f11e3-5606-4075-a319-74ff1cee6a3e)&lt;br&gt;or Quick share date expired! (Code: da53b1d3-83eb-4fec-9f7c-56b571f117b2)&lt;br&gt; |  -  |
| **500** | Internal server error. Please contact administrator. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="httpsharedcollectionsgetbyid"></a>
# **HttpSharedCollectionsGetById**
> SharedCollectionFull HttpSharedCollectionsGetById (string id, string ayPassword = null, string continuationToken = null, int? limit = null, string orderby = null, string acceptLanguage = null)



Returns one single shared collection (from ID)

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Agravity.Public.Api;
using Agravity.Public.Client;
using Agravity.Public.Model;

namespace Example
{
    public class HttpSharedCollectionsGetByIdExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost:7072/api";
            var apiInstance = new PublicSharingManagementApi(config);
            var id = "id_example";  // string | The ID of the shared collection.
            var ayPassword = "ayPassword_example";  // string | If shared collection has a password, this header is mandatory. Otherwise StatusCode 403 (Forbidden) is returned. (optional) 
            var continuationToken = "continuationToken_example";  // string | Each result returns the continous token if more results are available than requested. With this token, the next page could be fetched. (URL encoded!) (optional) 
            var limit = 56;  // int? | This number limits the page result of assets. (optional) 
            var orderby = "orderby_example";  // string | How the return assets are sorted. Default is property: created_date (newest first). (optional) 
            var acceptLanguage = "acceptLanguage_example";  // string | The requested language of the response. If not matching it falls back to default language. (optional) 

            try
            {
                SharedCollectionFull result = apiInstance.HttpSharedCollectionsGetById(id, ayPassword, continuationToken, limit, orderby, acceptLanguage);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling PublicSharingManagementApi.HttpSharedCollectionsGetById: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the HttpSharedCollectionsGetByIdWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<SharedCollectionFull> response = apiInstance.HttpSharedCollectionsGetByIdWithHttpInfo(id, ayPassword, continuationToken, limit, orderby, acceptLanguage);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling PublicSharingManagementApi.HttpSharedCollectionsGetByIdWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **string** | The ID of the shared collection. |  |
| **ayPassword** | **string** | If shared collection has a password, this header is mandatory. Otherwise StatusCode 403 (Forbidden) is returned. | [optional]  |
| **continuationToken** | **string** | Each result returns the continous token if more results are available than requested. With this token, the next page could be fetched. (URL encoded!) | [optional]  |
| **limit** | **int?** | This number limits the page result of assets. | [optional]  |
| **orderby** | **string** | How the return assets are sorted. Default is property: created_date (newest first). | [optional]  |
| **acceptLanguage** | **string** | The requested language of the response. If not matching it falls back to default language. | [optional]  |

### Return type

[**SharedCollectionFull**](SharedCollectionFull.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Returns the shared collection with the given ID. |  -  |
| **400** | A parameter is null (Code: e61dfb16-e486-4c15-8b55-276bd85d291e)&lt;br&gt;or not valid shared id! (Code: e1eb7b29-e501-4727-bec3-26f5099b7418) |  -  |
| **404** | Collection on which this share is based, doesn&#39;t exist. (Code: 79dde226-ae08-4f4b-b334-de0cad89c994)&lt;br&gt;or Shared collection date expired! (Code: 6758d66e-0ce6-4770-a497-01a578eac12c)&lt;br&gt;or Shared collection not found. (Code: 87d09a21-14d6-4da4-ab69-01e6c87f108c)&lt;br&gt;or User null or shared collection of user not found. (Code: 5a1ea520-377d-43f1-b2c3-506443056561)&lt;br&gt; |  -  |
| **401** | This share requires a password (Header: &#39;ay-password&#39;) to be accessed. |  -  |
| **500** | Internal server error. Please contact administrator. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="httpsharedcollectionsgetstatuszipbyid"></a>
# **HttpSharedCollectionsGetStatusZipById**
> DownloadZipStatus HttpSharedCollectionsGetStatusZipById (string id, string zipId, string ayPassword = null)



This endpoint gets the progress/status of the ZIP creation of a shared collection.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Agravity.Public.Api;
using Agravity.Public.Client;
using Agravity.Public.Model;

namespace Example
{
    public class HttpSharedCollectionsGetStatusZipByIdExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost:7072/api";
            var apiInstance = new PublicSharingManagementApi(config);
            var id = "id_example";  // string | The ID of the zip request.
            var zipId = "zipId_example";  // string | The ID of the requested zip.
            var ayPassword = "ayPassword_example";  // string | If shared collection has a password, this header is mandatory. Otherwise StatusCode 401 (Unauthorized) is returned. (optional) 

            try
            {
                DownloadZipStatus result = apiInstance.HttpSharedCollectionsGetStatusZipById(id, zipId, ayPassword);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling PublicSharingManagementApi.HttpSharedCollectionsGetStatusZipById: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the HttpSharedCollectionsGetStatusZipByIdWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<DownloadZipStatus> response = apiInstance.HttpSharedCollectionsGetStatusZipByIdWithHttpInfo(id, zipId, ayPassword);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling PublicSharingManagementApi.HttpSharedCollectionsGetStatusZipByIdWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **string** | The ID of the zip request. |  |
| **zipId** | **string** | The ID of the requested zip. |  |
| **ayPassword** | **string** | If shared collection has a password, this header is mandatory. Otherwise StatusCode 401 (Unauthorized) is returned. | [optional]  |

### Return type

[**DownloadZipStatus**](DownloadZipStatus.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Returns the status of the current zip request. |  -  |
| **400** | Not valid shared id! (Code: e1eb7b29-e501-4727-bec3-26f5099b7418) |  -  |
| **404** | Collection on which this share is based, doesn&#39;t exist. (Code: 79dde226-ae08-4f4b-b334-de0cad89c994)&lt;br&gt;or Shared collection date expired! (Code: 6758d66e-0ce6-4770-a497-01a578eac12c)&lt;br&gt;or Shared collection not found. (Code: 87d09a21-14d6-4da4-ab69-01e6c87f108c)&lt;br&gt;or User null or shared collection of user not found. (Code: 5a1ea520-377d-43f1-b2c3-506443056561)&lt;br&gt; |  -  |
| **401** | This share requires a password (Header: &#39;ay-password&#39;) to be accessed. |  -  |
| **500** | Internal server error. Please contact administrator. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="httpsharedcollectionsrequestzipbyid"></a>
# **HttpSharedCollectionsRequestZipById**
> DownloadZipRequest HttpSharedCollectionsRequestZipById (string id, string ayPassword = null, DownloadZipRequest downloadZipRequest = null)



Initiates the ZIP creation of a shared collection.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Agravity.Public.Api;
using Agravity.Public.Client;
using Agravity.Public.Model;

namespace Example
{
    public class HttpSharedCollectionsRequestZipByIdExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost:7072/api";
            var apiInstance = new PublicSharingManagementApi(config);
            var id = "id_example";  // string | The ID of the shared collection.
            var ayPassword = "ayPassword_example";  // string | If shared collection has a password, this header is mandatory. Otherwise StatusCode 403 (Forbidden) is returned. (optional) 
            var downloadZipRequest = new DownloadZipRequest(); // DownloadZipRequest | The request of which assets or download formats should be used.. (optional) 

            try
            {
                DownloadZipRequest result = apiInstance.HttpSharedCollectionsRequestZipById(id, ayPassword, downloadZipRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling PublicSharingManagementApi.HttpSharedCollectionsRequestZipById: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the HttpSharedCollectionsRequestZipByIdWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<DownloadZipRequest> response = apiInstance.HttpSharedCollectionsRequestZipByIdWithHttpInfo(id, ayPassword, downloadZipRequest);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling PublicSharingManagementApi.HttpSharedCollectionsRequestZipByIdWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **string** | The ID of the shared collection. |  |
| **ayPassword** | **string** | If shared collection has a password, this header is mandatory. Otherwise StatusCode 403 (Forbidden) is returned. | [optional]  |
| **downloadZipRequest** | [**DownloadZipRequest**](DownloadZipRequest.md) | The request of which assets or download formats should be used.. | [optional]  |

### Return type

[**DownloadZipRequest**](DownloadZipRequest.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **201** | Returns the requested download ZIP with created zip entity ID. |  -  |
| **400** | Not valid shared id! (Code: e1eb7b29-e501-4727-bec3-26f5099b7418) |  -  |
| **404** | Collection on which this share is based, doesn&#39;t exist. (Code: 79dde226-ae08-4f4b-b334-de0cad89c994)&lt;br&gt;or Shared collection date expired! (Code: 6758d66e-0ce6-4770-a497-01a578eac12c)&lt;br&gt;or Shared collection not found. (Code: 87d09a21-14d6-4da4-ab69-01e6c87f108c)&lt;br&gt;or User null or shared collection of user not found. (Code: 5a1ea520-377d-43f1-b2c3-506443056561)&lt;br&gt; |  -  |
| **401** | This share requires a password (Header: &#39;ay-password&#39;) to be accessed. |  -  |
| **500** | Internal server error. Please contact administrator. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

