# Agravity.Public.Api.AssetPublishingApi

All URIs are relative to *http://localhost:7071/api*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**GetPublishedAssetById**](AssetPublishingApi.md#getpublishedassetbyid) | **GET** /assets/{id}/publish/{pid} |  |
| [**GetPublishedAssetDetails**](AssetPublishingApi.md#getpublishedassetdetails) | **GET** /assets/{id}/publish/{pid}/info |  |
| [**HttpPublishedAssetsCheckStatus**](AssetPublishingApi.md#httppublishedassetscheckstatus) | **GET** /assets/{id}/publish/{pid}/status |  |
| [**HttpPublishedAssetsCreate**](AssetPublishingApi.md#httppublishedassetscreate) | **POST** /assets/{id}/publish |  |
| [**HttpPublishedAssetsDeleteAll**](AssetPublishingApi.md#httppublishedassetsdeleteall) | **DELETE** /assets/{id}/publish |  |
| [**HttpPublishedAssetsDeleteById**](AssetPublishingApi.md#httppublishedassetsdeletebyid) | **DELETE** /assets/{id}/publish/{pid} |  |
| [**HttpPublishedAssetsGet**](AssetPublishingApi.md#httppublishedassetsget) | **GET** /assets/{id}/publish |  |
| [**HttpPublishedAssetsRepublishById**](AssetPublishingApi.md#httppublishedassetsrepublishbyid) | **PATCH** /assets/{id}/publish/{pid}/republish |  |
| [**HttpPublishedAssetsUpdateById**](AssetPublishingApi.md#httppublishedassetsupdatebyid) | **POST** /assets/{id}/publish/{pid} |  |

<a id="getpublishedassetbyid"></a>
# **GetPublishedAssetById**
> PublishedAsset GetPublishedAssetById (string id, string pid)



This endpoint returns one single published asset (from ID)

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Agravity.Public.Api;
using Agravity.Public.Client;
using Agravity.Public.Model;

namespace Example
{
    public class GetPublishedAssetByIdExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost:7071/api";
            // Configure OAuth2 access token for authorization: msal_auth
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new AssetPublishingApi(config);
            var id = "id_example";  // string | The ID of the asset.
            var pid = "pid_example";  // string | The published asset ID.

            try
            {
                PublishedAsset result = apiInstance.GetPublishedAssetById(id, pid);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AssetPublishingApi.GetPublishedAssetById: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetPublishedAssetByIdWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<PublishedAsset> response = apiInstance.GetPublishedAssetByIdWithHttpInfo(id, pid);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling AssetPublishingApi.GetPublishedAssetByIdWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **string** | The ID of the asset. |  |
| **pid** | **string** | The published asset ID. |  |

### Return type

[**PublishedAsset**](PublishedAsset.md)

### Authorization

[msal_auth](../README.md#msal_auth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Returns the published asset with the given ID. |  -  |
| **404** | If the asset or published asset with the IDs were not found. |  -  |
| **401** | Unauthorized. Bearer Token not provided. |  -  |
| **500** | Internal server error. Please contact administrator. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="getpublishedassetdetails"></a>
# **GetPublishedAssetDetails**
> Dictionary&lt;string, Object&gt; GetPublishedAssetDetails (string id, string pid)



This endpoint fetches specific information (e.g. statistics) of the published asset (from ID) from the target platform

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Agravity.Public.Api;
using Agravity.Public.Client;
using Agravity.Public.Model;

namespace Example
{
    public class GetPublishedAssetDetailsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost:7071/api";
            // Configure OAuth2 access token for authorization: msal_auth
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new AssetPublishingApi(config);
            var id = "id_example";  // string | The ID of the asset.
            var pid = "pid_example";  // string | The published asset ID.

            try
            {
                Dictionary<string, Object> result = apiInstance.GetPublishedAssetDetails(id, pid);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AssetPublishingApi.GetPublishedAssetDetails: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetPublishedAssetDetailsWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<Dictionary<string, Object>> response = apiInstance.GetPublishedAssetDetailsWithHttpInfo(id, pid);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling AssetPublishingApi.GetPublishedAssetDetailsWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **string** | The ID of the asset. |  |
| **pid** | **string** | The published asset ID. |  |

### Return type

**Dictionary<string, Object>**

### Authorization

[msal_auth](../README.md#msal_auth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Returns the detail information of the published asset with the given ID. |  -  |
| **404** | If the asset or published asset with the IDs were not found. |  -  |
| **401** | Unauthorized. Bearer Token not provided. |  -  |
| **500** | Internal server error. Please contact administrator. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="httppublishedassetscheckstatus"></a>
# **HttpPublishedAssetsCheckStatus**
> AgravityInfoResponse HttpPublishedAssetsCheckStatus (string id, string pid)



This endpoint retrieves the status of the published entity i.e. vimeo video upload

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Agravity.Public.Api;
using Agravity.Public.Client;
using Agravity.Public.Model;

namespace Example
{
    public class HttpPublishedAssetsCheckStatusExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost:7071/api";
            // Configure OAuth2 access token for authorization: msal_auth
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new AssetPublishingApi(config);
            var id = "id_example";  // string | The ID of translation export
            var pid = "pid_example";  // string | The published asset ID.

            try
            {
                AgravityInfoResponse result = apiInstance.HttpPublishedAssetsCheckStatus(id, pid);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AssetPublishingApi.HttpPublishedAssetsCheckStatus: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the HttpPublishedAssetsCheckStatusWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<AgravityInfoResponse> response = apiInstance.HttpPublishedAssetsCheckStatusWithHttpInfo(id, pid);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling AssetPublishingApi.HttpPublishedAssetsCheckStatusWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **string** | The ID of translation export |  |
| **pid** | **string** | The published asset ID. |  |

### Return type

[**AgravityInfoResponse**](AgravityInfoResponse.md)

### Authorization

[msal_auth](../README.md#msal_auth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Indicates that the upload process is finished for the given published asset. Code: 187ada36-4cc7-4e55-912d-8fd5158e42d3 |  -  |
| **202** | The upload status of the published asset - Code: a0d0c3da-1b37-4981-aaaa-f6028e1af714 |  -  |
| **404** | The requested item could not be found. |  -  |
| **401** | Unauthorized. Bearer Token not provided. |  -  |
| **500** | Internal server error. Please contact administrator. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="httppublishedassetscreate"></a>
# **HttpPublishedAssetsCreate**
> PublishedAsset HttpPublishedAssetsCreate (string id, PublishedAsset publishedAsset)



This endpoint creates an additional published asset

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Agravity.Public.Api;
using Agravity.Public.Client;
using Agravity.Public.Model;

namespace Example
{
    public class HttpPublishedAssetsCreateExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost:7071/api";
            // Configure OAuth2 access token for authorization: msal_auth
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new AssetPublishingApi(config);
            var id = "id_example";  // string | The ID of the asset.
            var publishedAsset = new PublishedAsset(); // PublishedAsset | This creates / adds an unique published asset ID and adds the information to the asset (in DB).

            try
            {
                PublishedAsset result = apiInstance.HttpPublishedAssetsCreate(id, publishedAsset);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AssetPublishingApi.HttpPublishedAssetsCreate: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the HttpPublishedAssetsCreateWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<PublishedAsset> response = apiInstance.HttpPublishedAssetsCreateWithHttpInfo(id, publishedAsset);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling AssetPublishingApi.HttpPublishedAssetsCreateWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **string** | The ID of the asset. |  |
| **publishedAsset** | [**PublishedAsset**](PublishedAsset.md) | This creates / adds an unique published asset ID and adds the information to the asset (in DB). |  |

### Return type

[**PublishedAsset**](PublishedAsset.md)

### Authorization

[msal_auth](../README.md#msal_auth)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **201** | Returns the created published-asset entity if the publish target was cdn. |  -  |
| **202** | Returns the created published-asset entity and a redirection where the status can be checked if the publish target was not cdn |  -  |
| **400** | Could not publish asset because asset or original blob could not be found. (Code: 0da83425-da4e-4586-ae31-ba51e2c84f2c)&lt;br&gt;Could not publish an asset which is not active. (Code: be0b47c9-cf24-4cb8-a4ab-f17cdfe6dc4e)&lt;br&gt;Could not publish an asset which is locked. (Code: 16dbd27d-51f8-4556-a874-6cd7ddd7a1a8)&lt;br&gt;Could not resize asset &lt;assedId&gt; for publishing. (Code: 2d9187ac-dc37-4365-a633-7ef90a326d0f)&lt;br&gt;Could not find optimized asset &lt;assetId&gt; for publishing. (Code: e59e01cb-3f39-4c36-9c71-3d28bcabe486)&lt;br&gt;Tried to access not existion blob: &lt;assetId&gt; does not exists.... (Code: a96e079b-61b3-492a-8adb-93b399287b46)&lt;br&gt;Publishing of asset &lt;assetId&gt; failed. Blob could not be created. (Code: 43089864-d2a4-4a42-a2c2-1a9a2048bb58)&lt;br&gt;Publish to this target is not supported. (Code: 8136f041-60e4-40de-b534-71a7250095cc)&lt;br&gt;Could not update asset with ID &lt;assedId&gt; (Code: 87429a31-01cd-4a62-9afb-81d0a56a59d2)&lt;br&gt;Given Publishing Target is not supported (Code: 9c21501f-eabe-43b3-acfa-98a168606d93) |  -  |
| **500** | Internal server error. Please contact administrator. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="httppublishedassetsdeleteall"></a>
# **HttpPublishedAssetsDeleteAll**
> void HttpPublishedAssetsDeleteAll (string id)



This endpoint deletes the published asset with the given ID.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Agravity.Public.Api;
using Agravity.Public.Client;
using Agravity.Public.Model;

namespace Example
{
    public class HttpPublishedAssetsDeleteAllExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost:7071/api";
            // Configure OAuth2 access token for authorization: msal_auth
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new AssetPublishingApi(config);
            var id = "id_example";  // string | The ID of the asset.

            try
            {
                apiInstance.HttpPublishedAssetsDeleteAll(id);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AssetPublishingApi.HttpPublishedAssetsDeleteAll: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the HttpPublishedAssetsDeleteAllWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    apiInstance.HttpPublishedAssetsDeleteAllWithHttpInfo(id);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling AssetPublishingApi.HttpPublishedAssetsDeleteAllWithHttpInfo: " + e.Message);
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

[msal_auth](../README.md#msal_auth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **400** | If the asset with the ID was not found (or active). |  -  |
| **204** | The delete operation of all the published assets from a specific asset. |  -  |
| **401** | Unauthorized. Bearer Token not provided. |  -  |
| **500** | Internal server error. Please contact administrator. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="httppublishedassetsdeletebyid"></a>
# **HttpPublishedAssetsDeleteById**
> void HttpPublishedAssetsDeleteById (string id, string pid, bool? force = null)



This endpoint deletes the published asset with the given ID.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Agravity.Public.Api;
using Agravity.Public.Client;
using Agravity.Public.Model;

namespace Example
{
    public class HttpPublishedAssetsDeleteByIdExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost:7071/api";
            // Configure OAuth2 access token for authorization: msal_auth
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new AssetPublishingApi(config);
            var id = "id_example";  // string | The ID of the asset.
            var pid = "pid_example";  // string | The published asset ID.
            var force = true;  // bool? | Even if the unpublish in the third party system is not successful, the published asset should be removed. (optional) 

            try
            {
                apiInstance.HttpPublishedAssetsDeleteById(id, pid, force);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AssetPublishingApi.HttpPublishedAssetsDeleteById: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the HttpPublishedAssetsDeleteByIdWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    apiInstance.HttpPublishedAssetsDeleteByIdWithHttpInfo(id, pid, force);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling AssetPublishingApi.HttpPublishedAssetsDeleteByIdWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **string** | The ID of the asset. |  |
| **pid** | **string** | The published asset ID. |  |
| **force** | **bool?** | Even if the unpublish in the third party system is not successful, the published asset should be removed. | [optional]  |

### Return type

void (empty response body)

### Authorization

[msal_auth](../README.md#msal_auth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **400** | A parameter is null. (Code: ad82aabc-da2e-4c41-89fd-920fd8a5aea1)&lt;br&gt;Could not delete document with id {pid} because of {e.Message} (Code: 1c8fb0a2-dccb-46ac-92e9-c3ac50c053c2)&lt;br&gt;Deleting the video with the vimeo api results in an error (Code: 53f5dfcb-c938-476d-9d6b-72b6b7953e47) |  -  |
| **204** | The delete operation of the published asset with the given ID was successful. |  -  |
| **404** | If the published asset with the ID was not found. |  -  |
| **401** | Unauthorized. Bearer Token not provided. |  -  |
| **500** | Internal server error. Please contact administrator. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="httppublishedassetsget"></a>
# **HttpPublishedAssetsGet**
> PublishEntity HttpPublishedAssetsGet (string id)



This endpoint lists all the published assets which are stored in the database if asset is still valid.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Agravity.Public.Api;
using Agravity.Public.Client;
using Agravity.Public.Model;

namespace Example
{
    public class HttpPublishedAssetsGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost:7071/api";
            // Configure OAuth2 access token for authorization: msal_auth
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new AssetPublishingApi(config);
            var id = "id_example";  // string | The ID of the asset.

            try
            {
                PublishEntity result = apiInstance.HttpPublishedAssetsGet(id);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AssetPublishingApi.HttpPublishedAssetsGet: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the HttpPublishedAssetsGetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<PublishEntity> response = apiInstance.HttpPublishedAssetsGetWithHttpInfo(id);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling AssetPublishingApi.HttpPublishedAssetsGetWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **string** | The ID of the asset. |  |

### Return type

[**PublishEntity**](PublishEntity.md)

### Authorization

[msal_auth](../README.md#msal_auth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Returns the all published assets as . |  -  |
| **404** | If the asset with the ID was not found. |  -  |
| **401** | Unauthorized. Bearer Token not provided. |  -  |
| **500** | Internal server error. Please contact administrator. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="httppublishedassetsrepublishbyid"></a>
# **HttpPublishedAssetsRepublishById**
> PublishedAsset HttpPublishedAssetsRepublishById (string id, string pid, PublishedAsset publishedAsset)



This endpoint currently republished the published asset with the given ID.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Agravity.Public.Api;
using Agravity.Public.Client;
using Agravity.Public.Model;

namespace Example
{
    public class HttpPublishedAssetsRepublishByIdExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost:7071/api";
            // Configure OAuth2 access token for authorization: msal_auth
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new AssetPublishingApi(config);
            var id = "id_example";  // string | The ID of the asset.
            var pid = "pid_example";  // string | The published asset ID.
            var publishedAsset = new PublishedAsset(); // PublishedAsset | The body has to contain a valid PublishedAsset in json format. Not fitting properties are ignored.

            try
            {
                PublishedAsset result = apiInstance.HttpPublishedAssetsRepublishById(id, pid, publishedAsset);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AssetPublishingApi.HttpPublishedAssetsRepublishById: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the HttpPublishedAssetsRepublishByIdWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<PublishedAsset> response = apiInstance.HttpPublishedAssetsRepublishByIdWithHttpInfo(id, pid, publishedAsset);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling AssetPublishingApi.HttpPublishedAssetsRepublishByIdWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **string** | The ID of the asset. |  |
| **pid** | **string** | The published asset ID. |  |
| **publishedAsset** | [**PublishedAsset**](PublishedAsset.md) | The body has to contain a valid PublishedAsset in json format. Not fitting properties are ignored. |  |

### Return type

[**PublishedAsset**](PublishedAsset.md)

### Authorization

[msal_auth](../README.md#msal_auth)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Returns the updated published-asset entity. |  -  |
| **400** | Could not republish with id {pid} because of {e.Message} (Code: bcd93044-1373-438e-8a4f-251b0d18cdfb)&lt;br&gt;Could not republish an asset which is not active. (Code: 3a391d2f-6992-45dc-8768-e32542f30c04)&lt;br&gt;Could not republish an asset which is locked. (Code: f7dfdaa5-cfb1-4e17-a8df-d082563159f7) |  -  |
| **404** | If the published asset with the ID was not found. |  -  |
| **401** | Unauthorized. Bearer Token not provided. |  -  |
| **500** | Internal server error. Please contact administrator. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="httppublishedassetsupdatebyid"></a>
# **HttpPublishedAssetsUpdateById**
> PublishedAsset HttpPublishedAssetsUpdateById (string id, string pid, PublishedAsset publishedAsset)



This endpoint currently updates only the description of the published asset with the given ID.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Agravity.Public.Api;
using Agravity.Public.Client;
using Agravity.Public.Model;

namespace Example
{
    public class HttpPublishedAssetsUpdateByIdExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost:7071/api";
            // Configure OAuth2 access token for authorization: msal_auth
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new AssetPublishingApi(config);
            var id = "id_example";  // string | The ID of the asset.
            var pid = "pid_example";  // string | The published asset ID.
            var publishedAsset = new PublishedAsset(); // PublishedAsset | The body has to contain a valid PublishedAsset in json format. Not fitting properties are ignored.

            try
            {
                PublishedAsset result = apiInstance.HttpPublishedAssetsUpdateById(id, pid, publishedAsset);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AssetPublishingApi.HttpPublishedAssetsUpdateById: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the HttpPublishedAssetsUpdateByIdWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<PublishedAsset> response = apiInstance.HttpPublishedAssetsUpdateByIdWithHttpInfo(id, pid, publishedAsset);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling AssetPublishingApi.HttpPublishedAssetsUpdateByIdWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **string** | The ID of the asset. |  |
| **pid** | **string** | The published asset ID. |  |
| **publishedAsset** | [**PublishedAsset**](PublishedAsset.md) | The body has to contain a valid PublishedAsset in json format. Not fitting properties are ignored. |  |

### Return type

[**PublishedAsset**](PublishedAsset.md)

### Authorization

[msal_auth](../README.md#msal_auth)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Returns the updated published-asset entity. |  -  |
| **400** | Could not update document with id {pid} because of {e.Message} (Code: bcd93044-1373-438e-8a4f-251b0d18cdfb)&lt;br&gt;Could not update an asset which is not active. (Code: 82b244df-275b-4434-b2f8-218561993d90)&lt;br&gt;Could not update an asset which is locked. (Code: 78e91aa8-078d-40ef-a107-94a6807a1f22)&lt;br&gt;Update video metadata to vimeo failed (8ca4d9f2-f305-471e-88b5-118fff960f8c) |  -  |
| **404** | If the published asset with the ID was not found. |  -  |
| **401** | Unauthorized. Bearer Token not provided. |  -  |
| **500** | Internal server error. Please contact administrator. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

