# Agravity.Public.Api.HelperToolsApi

All URIs are relative to *http://localhost:7071/api*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**HttpCalculateMD5HashForAsset**](HelperToolsApi.md#httpcalculatemd5hashforasset) | **GET** /helper/md5/{id} |  |
| [**HttpGetAllThumbnailBlobsList**](HelperToolsApi.md#httpgetallthumbnailblobslist) | **GET** /helper/placeholderblobs |  |
| [**HttpGetAllUserDefinedLists**](HelperToolsApi.md#httpgetalluserdefinedlists) | **GET** /helper/userdefinedlists |  |
| [**HttpGetAllVimeoVideos**](HelperToolsApi.md#httpgetallvimeovideos) | **GET** /helper/vimeo-videos |  |
| [**HttpGetAllowedFilterableItems**](HelperToolsApi.md#httpgetallowedfilterableitems) | **GET** /helper/filterableitems |  |
| [**HttpGetAllowedItemTypes**](HelperToolsApi.md#httpgetalloweditemtypes) | **GET** /helper/collitemtypes |  |
| [**HttpGetAllowedSearchableItemNames**](HelperToolsApi.md#httpgetallowedsearchableitemnames) | **GET** /helper/searchableitemnames |  |
| [**HttpGetAllowedSearchableItems**](HelperToolsApi.md#httpgetallowedsearchableitems) | **GET** /helper/searchableitems |  |
| [**HttpGetAssetSkillEnhancer**](HelperToolsApi.md#httpgetassetskillenhancer) | **GET** /helper/skillenhancer/{id} |  |
| [**HttpGetImageEditFilters**](HelperToolsApi.md#httpgetimageeditfilters) | **GET** /helper/imageeditfilters |  |
| [**HttpInboxPoke**](HelperToolsApi.md#httpinboxpoke) | **GET** /helper/inboxpoke |  |
| [**HttpPatchClearConfigCache**](HelperToolsApi.md#httppatchclearconfigcache) | **PATCH** /helper/clearconfigcache |  |
| [**HttpPatchUpdateCachedUserDefinedLists**](HelperToolsApi.md#httppatchupdatecacheduserdefinedlists) | **PATCH** /helper/userdefinedlists |  |
| [**HttpQueuesAgain**](HelperToolsApi.md#httpqueuesagain) | **GET** /helper/queueagain |  |

<a id="httpcalculatemd5hashforasset"></a>
# **HttpCalculateMD5HashForAsset**
> AgravityInfoResponse HttpCalculateMD5HashForAsset (string id)



This endpoint calculates the md5 hash of an asset.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Agravity.Public.Api;
using Agravity.Public.Client;
using Agravity.Public.Model;

namespace Example
{
    public class HttpCalculateMD5HashForAssetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost:7071/api";
            // Configure OAuth2 access token for authorization: msal_auth
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new HelperToolsApi(config);
            var id = "id_example";  // string | The ID of the asset.

            try
            {
                AgravityInfoResponse result = apiInstance.HttpCalculateMD5HashForAsset(id);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling HelperToolsApi.HttpCalculateMD5HashForAsset: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the HttpCalculateMD5HashForAssetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<AgravityInfoResponse> response = apiInstance.HttpCalculateMD5HashForAssetWithHttpInfo(id);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling HelperToolsApi.HttpCalculateMD5HashForAssetWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **string** | The ID of the asset. |  |

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
| **200** | The md5 hash of the asset. |  -  |
| **400** | The asset {id} doesn&#39;t exist! (Code: 55724727-7c2e-45a6-89fc-ed9aa1a31c0d) |  -  |
| **401** | Unauthorized. Bearer Token not provided. |  -  |
| **500** | Internal server error. Please contact administrator. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="httpgetallthumbnailblobslist"></a>
# **HttpGetAllThumbnailBlobsList**
> List&lt;AssetBlob&gt; HttpGetAllThumbnailBlobsList ()



Returns all thumbnail blob types incl. URLs

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Agravity.Public.Api;
using Agravity.Public.Client;
using Agravity.Public.Model;

namespace Example
{
    public class HttpGetAllThumbnailBlobsListExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost:7071/api";
            var apiInstance = new HelperToolsApi(config);

            try
            {
                List<AssetBlob> result = apiInstance.HttpGetAllThumbnailBlobsList();
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling HelperToolsApi.HttpGetAllThumbnailBlobsList: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the HttpGetAllThumbnailBlobsListWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<List<AssetBlob>> response = apiInstance.HttpGetAllThumbnailBlobsListWithHttpInfo();
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling HelperToolsApi.HttpGetAllThumbnailBlobsListWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters
This endpoint does not need any parameter.
### Return type

[**List&lt;AssetBlob&gt;**](AssetBlob.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | A list of all placeholder / thumbnail blob types incl. URLs. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="httpgetalluserdefinedlists"></a>
# **HttpGetAllUserDefinedLists**
> List&lt;CollectionUDL&gt; HttpGetAllUserDefinedLists (bool? translations = null, string acceptLanguage = null)



Returns all user defined lists of all collection types

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Agravity.Public.Api;
using Agravity.Public.Client;
using Agravity.Public.Model;

namespace Example
{
    public class HttpGetAllUserDefinedListsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost:7071/api";
            var apiInstance = new HelperToolsApi(config);
            var translations = true;  // bool? | When default language should be returned and the translation dictionary is delivered. (Ignores the \"Accept-Language\" header) (optional) 
            var acceptLanguage = "acceptLanguage_example";  // string | The requested language of the response. If not matching it falls back to default language. (optional) 

            try
            {
                List<CollectionUDL> result = apiInstance.HttpGetAllUserDefinedLists(translations, acceptLanguage);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling HelperToolsApi.HttpGetAllUserDefinedLists: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the HttpGetAllUserDefinedListsWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<List<CollectionUDL>> response = apiInstance.HttpGetAllUserDefinedListsWithHttpInfo(translations, acceptLanguage);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling HelperToolsApi.HttpGetAllUserDefinedListsWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **translations** | **bool?** | When default language should be returned and the translation dictionary is delivered. (Ignores the \&quot;Accept-Language\&quot; header) | [optional]  |
| **acceptLanguage** | **string** | The requested language of the response. If not matching it falls back to default language. | [optional]  |

### Return type

[**List&lt;CollectionUDL&gt;**](CollectionUDL.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | A list of all user defined list entries. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="httpgetallvimeovideos"></a>
# **HttpGetAllVimeoVideos**
> PublishedAsset HttpGetAllVimeoVideos ()



This Endpoint fetches all videos that are published on vimeo (to get their video id for error handling) [admin only]

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Agravity.Public.Api;
using Agravity.Public.Client;
using Agravity.Public.Model;

namespace Example
{
    public class HttpGetAllVimeoVideosExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost:7071/api";
            // Configure OAuth2 access token for authorization: msal_auth
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new HelperToolsApi(config);

            try
            {
                PublishedAsset result = apiInstance.HttpGetAllVimeoVideos();
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling HelperToolsApi.HttpGetAllVimeoVideos: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the HttpGetAllVimeoVideosWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<PublishedAsset> response = apiInstance.HttpGetAllVimeoVideosWithHttpInfo();
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling HelperToolsApi.HttpGetAllVimeoVideosWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters
This endpoint does not need any parameter.
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
| **200** | Returns the video data of all videos stored at vimeo |  -  |
| **401** | Unauthorized. Bearer Token not provided. |  -  |
| **500** | Internal server error. Please contact administrator. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="httpgetallowedfilterableitems"></a>
# **HttpGetAllowedFilterableItems**
> List&lt;string&gt; HttpGetAllowedFilterableItems (string portalId = null)



Returns all filterable items directly from the search index

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Agravity.Public.Api;
using Agravity.Public.Client;
using Agravity.Public.Model;

namespace Example
{
    public class HttpGetAllowedFilterableItemsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost:7071/api";
            var apiInstance = new HelperToolsApi(config);
            var portalId = "portalId_example";  // string | If the search should be redirected to a specific portal. (optional) 

            try
            {
                List<string> result = apiInstance.HttpGetAllowedFilterableItems(portalId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling HelperToolsApi.HttpGetAllowedFilterableItems: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the HttpGetAllowedFilterableItemsWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<List<string>> response = apiInstance.HttpGetAllowedFilterableItemsWithHttpInfo(portalId);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling HelperToolsApi.HttpGetAllowedFilterableItemsWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **portalId** | **string** | If the search should be redirected to a specific portal. | [optional]  |

### Return type

**List<string>**

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | A string list of all filterable items. |  -  |
| **400** | Argument is null. (Code: e12181d0-371e-47c4-88cc-1d2453a7d9a6)&lt;br&gt;Argument exception: {message} (Code: e109ada5-d770-43f3-a6e0-7d869b0bb8e1)&lt;br&gt;Request failed:  {message} (Code: 2da00496-7e74-4c11-8bd0-1e92cbc8875a)&lt;br&gt;General error:  {message} ({typeOfException}) (Code: 8c14ca12-da21-4a87-9bcd-9958407f102d) |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="httpgetalloweditemtypes"></a>
# **HttpGetAllowedItemTypes**
> List&lt;string&gt; HttpGetAllowedItemTypes ()



Returns all allowed (currently supported) collection item types

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Agravity.Public.Api;
using Agravity.Public.Client;
using Agravity.Public.Model;

namespace Example
{
    public class HttpGetAllowedItemTypesExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost:7071/api";
            var apiInstance = new HelperToolsApi(config);

            try
            {
                List<string> result = apiInstance.HttpGetAllowedItemTypes();
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling HelperToolsApi.HttpGetAllowedItemTypes: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the HttpGetAllowedItemTypesWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<List<string>> response = apiInstance.HttpGetAllowedItemTypesWithHttpInfo();
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling HelperToolsApi.HttpGetAllowedItemTypesWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters
This endpoint does not need any parameter.
### Return type

**List<string>**

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | All allowed collection type items. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="httpgetallowedsearchableitemnames"></a>
# **HttpGetAllowedSearchableItemNames**
> List&lt;string&gt; HttpGetAllowedSearchableItemNames (string portalId = null)



Returns all searchable items directly from the search index

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Agravity.Public.Api;
using Agravity.Public.Client;
using Agravity.Public.Model;

namespace Example
{
    public class HttpGetAllowedSearchableItemNamesExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost:7071/api";
            var apiInstance = new HelperToolsApi(config);
            var portalId = "portalId_example";  // string | If the search should be redirected to a specific portal. (optional) 

            try
            {
                List<string> result = apiInstance.HttpGetAllowedSearchableItemNames(portalId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling HelperToolsApi.HttpGetAllowedSearchableItemNames: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the HttpGetAllowedSearchableItemNamesWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<List<string>> response = apiInstance.HttpGetAllowedSearchableItemNamesWithHttpInfo(portalId);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling HelperToolsApi.HttpGetAllowedSearchableItemNamesWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **portalId** | **string** | If the search should be redirected to a specific portal. | [optional]  |

### Return type

**List<string>**

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | A string list of all searchable items. |  -  |
| **400** | Argument is null. (Code: 7e0e127f-d12d-441d-8405-25d91f2b32d6)&lt;br&gt;Argument exception: {message} (Code: 35c2fd8d-30ca-4c72-80fd-de91973b9c99)&lt;br&gt;Request failed:  {message} (Code: fb5e9c1b-1206-4488-9240-3cc949c23646)&lt;br&gt;General error:  {message} ({typeOfException}) (Code: e0289b2f-7a44-4cc6-a552-f025e5cdad3e) |  -  |
| **401** | Unauthorized. Bearer Token not provided. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="httpgetallowedsearchableitems"></a>
# **HttpGetAllowedSearchableItems**
> List&lt;SearchableItem&gt; HttpGetAllowedSearchableItems (string portalId = null)



Returns all searchable items directly from the search index

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Agravity.Public.Api;
using Agravity.Public.Client;
using Agravity.Public.Model;

namespace Example
{
    public class HttpGetAllowedSearchableItemsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost:7071/api";
            var apiInstance = new HelperToolsApi(config);
            var portalId = "portalId_example";  // string | If the search should be redirected to a specific portal. (optional) 

            try
            {
                List<SearchableItem> result = apiInstance.HttpGetAllowedSearchableItems(portalId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling HelperToolsApi.HttpGetAllowedSearchableItems: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the HttpGetAllowedSearchableItemsWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<List<SearchableItem>> response = apiInstance.HttpGetAllowedSearchableItemsWithHttpInfo(portalId);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling HelperToolsApi.HttpGetAllowedSearchableItemsWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **portalId** | **string** | If the search should be redirected to a specific portal. | [optional]  |

### Return type

[**List&lt;SearchableItem&gt;**](SearchableItem.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | A list of all searchable items. |  -  |
| **400** | Argument is null. (Code: 5e87014c-7ac4-4487-b91d-ce03438d5d45)&lt;br&gt;Argument exception: {message} (Code: 1f7fb1e7-dbf4-41a8-b89c-9829067a1ca6)&lt;br&gt;Request failed:  {message} (Code: b66c90a6-482e-40ee-b77d-06e001803ae0)&lt;br&gt;General error:  {message} ({typeOfException}) (Code: 4ff25dc7-47dd-4bec-bcce-6ecdb11b01c8) |  -  |
| **401** | Unauthorized. Bearer Token not provided. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="httpgetassetskillenhancer"></a>
# **HttpGetAssetSkillEnhancer**
> InfoEntitySkillEnhanced HttpGetAssetSkillEnhancer (string id)



This is a helper method to see the result when an entity (Asset or Collection) is enhanced with the skill-enhancer (for search indexer).

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Agravity.Public.Api;
using Agravity.Public.Client;
using Agravity.Public.Model;

namespace Example
{
    public class HttpGetAssetSkillEnhancerExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost:7071/api";
            // Configure OAuth2 access token for authorization: msal_auth
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new HelperToolsApi(config);
            var id = "id_example";  // string | The ID of the entity (Asset or Collection).

            try
            {
                InfoEntitySkillEnhanced result = apiInstance.HttpGetAssetSkillEnhancer(id);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling HelperToolsApi.HttpGetAssetSkillEnhancer: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the HttpGetAssetSkillEnhancerWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<InfoEntitySkillEnhanced> response = apiInstance.HttpGetAssetSkillEnhancerWithHttpInfo(id);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling HelperToolsApi.HttpGetAssetSkillEnhancerWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **string** | The ID of the entity (Asset or Collection). |  |

### Return type

[**InfoEntitySkillEnhanced**](InfoEntitySkillEnhanced.md)

### Authorization

[msal_auth](../README.md#msal_auth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | The enhanced object of the entity. |  -  |
| **404** | The entity was not found (wrong ID or not in database). |  -  |
| **401** | Unauthorized. Bearer Token not provided. |  -  |
| **500** | Internal server error. Please contact administrator. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="httpgetimageeditfilters"></a>
# **HttpGetImageEditFilters**
> List&lt;string&gt; HttpGetImageEditFilters ()



Returns all allowed (currently supported) filter names for image edit endpoint.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Agravity.Public.Api;
using Agravity.Public.Client;
using Agravity.Public.Model;

namespace Example
{
    public class HttpGetImageEditFiltersExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost:7071/api";
            var apiInstance = new HelperToolsApi(config);

            try
            {
                List<string> result = apiInstance.HttpGetImageEditFilters();
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling HelperToolsApi.HttpGetImageEditFilters: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the HttpGetImageEditFiltersWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<List<string>> response = apiInstance.HttpGetImageEditFiltersWithHttpInfo();
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling HelperToolsApi.HttpGetImageEditFiltersWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters
This endpoint does not need any parameter.
### Return type

**List<string>**

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | This lists all filters which are available for the filter query of the /api/assets/{assetId}/imageedit endpoint. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="httpinboxpoke"></a>
# **HttpInboxPoke**
> AgravityInfoResponse HttpInboxPoke ()



This sets metadata from all blobs inside inbox container on storage. This should re-trigger the inbox trigger.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Agravity.Public.Api;
using Agravity.Public.Client;
using Agravity.Public.Model;

namespace Example
{
    public class HttpInboxPokeExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost:7071/api";
            var apiInstance = new HelperToolsApi(config);

            try
            {
                AgravityInfoResponse result = apiInstance.HttpInboxPoke();
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling HelperToolsApi.HttpInboxPoke: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the HttpInboxPokeWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<AgravityInfoResponse> response = apiInstance.HttpInboxPokeWithHttpInfo();
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling HelperToolsApi.HttpInboxPokeWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters
This endpoint does not need any parameter.
### Return type

[**AgravityInfoResponse**](AgravityInfoResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Gets a message with a list of all poked assets in inbox. (Code: a4b81a40-e62a-4613-bf50-09b04d1c9eaf) |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="httppatchclearconfigcache"></a>
# **HttpPatchClearConfigCache**
> AgravityInfoResponse HttpPatchClearConfigCache ()



This method starts queues in all functions to clear the config cache.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Agravity.Public.Api;
using Agravity.Public.Client;
using Agravity.Public.Model;

namespace Example
{
    public class HttpPatchClearConfigCacheExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost:7071/api";
            var apiInstance = new HelperToolsApi(config);

            try
            {
                AgravityInfoResponse result = apiInstance.HttpPatchClearConfigCache();
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling HelperToolsApi.HttpPatchClearConfigCache: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the HttpPatchClearConfigCacheWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<AgravityInfoResponse> response = apiInstance.HttpPatchClearConfigCacheWithHttpInfo();
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling HelperToolsApi.HttpPatchClearConfigCacheWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters
This endpoint does not need any parameter.
### Return type

[**AgravityInfoResponse**](AgravityInfoResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Gets a message with that the launch of the clearing was successful. (Code: 407fcf8b-527c-4626-87fc-45f9d2ed86c6) |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="httppatchupdatecacheduserdefinedlists"></a>
# **HttpPatchUpdateCachedUserDefinedLists**
> CollectionUDLListEntity HttpPatchUpdateCachedUserDefinedLists ()



This updates the cached user defined lists and store it in the system

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Agravity.Public.Api;
using Agravity.Public.Client;
using Agravity.Public.Model;

namespace Example
{
    public class HttpPatchUpdateCachedUserDefinedListsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost:7071/api";
            var apiInstance = new HelperToolsApi(config);

            try
            {
                CollectionUDLListEntity result = apiInstance.HttpPatchUpdateCachedUserDefinedLists();
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling HelperToolsApi.HttpPatchUpdateCachedUserDefinedLists: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the HttpPatchUpdateCachedUserDefinedListsWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<CollectionUDLListEntity> response = apiInstance.HttpPatchUpdateCachedUserDefinedListsWithHttpInfo();
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling HelperToolsApi.HttpPatchUpdateCachedUserDefinedListsWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters
This endpoint does not need any parameter.
### Return type

[**CollectionUDLListEntity**](CollectionUDLListEntity.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | A full list of all UDLs and the collection types they are in and their permissions. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="httpqueuesagain"></a>
# **HttpQueuesAgain**
> List&lt;string&gt; HttpQueuesAgain (string queue)



Re-queue poisoned messages.  It takes the only one argument and tries to find the poisoned queue.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Agravity.Public.Api;
using Agravity.Public.Client;
using Agravity.Public.Model;

namespace Example
{
    public class HttpQueuesAgainExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost:7071/api";
            var apiInstance = new HelperToolsApi(config);
            var queue = "queue_example";  // string | Enter queue name which has to take messages from poison to regular queue.

            try
            {
                List<string> result = apiInstance.HttpQueuesAgain(queue);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling HelperToolsApi.HttpQueuesAgain: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the HttpQueuesAgainWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<List<string>> response = apiInstance.HttpQueuesAgainWithHttpInfo(queue);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling HelperToolsApi.HttpQueuesAgainWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **queue** | **string** | Enter queue name which has to take messages from poison to regular queue. |  |

### Return type

**List<string>**

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | A string list of all searchable items. |  -  |
| **400** | If no queue name was given. |  -  |
| **404** | If the requested queue was not found. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

