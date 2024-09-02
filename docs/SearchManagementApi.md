# Agravity.Public.Api.SearchManagementApi

All URIs are relative to *http://localhost:7071/api*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**HttpAzureDeleteSearchCompletely**](SearchManagementApi.md#httpazuredeletesearchcompletely) | **PATCH** /searchadmin/delete |  |
| [**HttpAzureRecreateGlobalIndex**](SearchManagementApi.md#httpazurerecreateglobalindex) | **PATCH** /searchadmin/recreate |  |
| [**HttpGetSearchFacetteByName**](SearchManagementApi.md#httpgetsearchfacettebyname) | **GET** /search/facette |  |
| [**HttpGlobalSearch**](SearchManagementApi.md#httpglobalsearch) | **GET** /search |  |
| [**HttpPatchCleanSearchFromDeletedAssets**](SearchManagementApi.md#httppatchcleansearchfromdeletedassets) | **PATCH** /searchadmin/clean |  |
| [**HttpPatchReIndexAssets**](SearchManagementApi.md#httppatchreindexassets) | **PATCH** /searchadmin/reindex/{id} |  |
| [**HttpSearchAdminGetStatus**](SearchManagementApi.md#httpsearchadmingetstatus) | **GET** /searchadmin/status |  |

<a id="httpazuredeletesearchcompletely"></a>
# **HttpAzureDeleteSearchCompletely**
> AgravityInfoResponse HttpAzureDeleteSearchCompletely (string portalId = null)



This endpoint deletes the index, indexes and data source connection. Has to be recreated with recreate endpoint.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Agravity.Public.Api;
using Agravity.Public.Client;
using Agravity.Public.Model;

namespace Example
{
    public class HttpAzureDeleteSearchCompletelyExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost:7071/api";
            // Configure OAuth2 access token for authorization: msal_auth
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new SearchManagementApi(config);
            var portalId = "portalId_example";  // string | If the search should be redirected to a specific portal. (optional) 

            try
            {
                AgravityInfoResponse result = apiInstance.HttpAzureDeleteSearchCompletely(portalId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling SearchManagementApi.HttpAzureDeleteSearchCompletely: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the HttpAzureDeleteSearchCompletelyWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<AgravityInfoResponse> response = apiInstance.HttpAzureDeleteSearchCompletelyWithHttpInfo(portalId);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling SearchManagementApi.HttpAzureDeleteSearchCompletelyWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **portalId** | **string** | If the search should be redirected to a specific portal. | [optional]  |

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
| **201** | This gives the info if deletion was successful. (Code: e9287de2-a5e0-405c-83a8-618b5092c708) |  -  |
| **401** | Unauthorized. Bearer Token not provided. |  -  |
| **500** | Internal server error. Please contact administrator. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="httpazurerecreateglobalindex"></a>
# **HttpAzureRecreateGlobalIndex**
> AgravityInfoResponse HttpAzureRecreateGlobalIndex (string portalId = null)



This endpoint recreates the index and creates the indexes, skillset and data source connection if not existing

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Agravity.Public.Api;
using Agravity.Public.Client;
using Agravity.Public.Model;

namespace Example
{
    public class HttpAzureRecreateGlobalIndexExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost:7071/api";
            // Configure OAuth2 access token for authorization: msal_auth
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new SearchManagementApi(config);
            var portalId = "portalId_example";  // string | If the search should be redirected to a specific portal. (optional) 

            try
            {
                AgravityInfoResponse result = apiInstance.HttpAzureRecreateGlobalIndex(portalId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling SearchManagementApi.HttpAzureRecreateGlobalIndex: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the HttpAzureRecreateGlobalIndexWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<AgravityInfoResponse> response = apiInstance.HttpAzureRecreateGlobalIndexWithHttpInfo(portalId);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling SearchManagementApi.HttpAzureRecreateGlobalIndexWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **portalId** | **string** | If the search should be redirected to a specific portal. | [optional]  |

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
| **201** | This gives the info if (re-)creation was successful. (Code: 538e9a29-4ff7-4944-a616-873c3fb54263) |  -  |
| **401** | Unauthorized. Bearer Token not provided. |  -  |
| **500** | Internal server error. Please contact administrator. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="httpgetsearchfacettebyname"></a>
# **HttpGetSearchFacetteByName**
> SearchFacet HttpGetSearchFacetteByName (string name, string s, string collectiontypeid = null, string collectionid = null, string mode = null, string filter = null, string ids = null, string portalId = null)



This endpoint returns one facette based on the search parameters.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Agravity.Public.Api;
using Agravity.Public.Client;
using Agravity.Public.Model;

namespace Example
{
    public class HttpGetSearchFacetteByNameExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost:7071/api";
            // Configure OAuth2 access token for authorization: msal_auth
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new SearchManagementApi(config);
            var name = "name_example";  // string | The name of the facette.
            var s = "s_example";  // string | The search string which should be found.
            var collectiontypeid = "collectiontypeid_example";  // string | Limits the result on all collections from the given collectiontypeid parameter. (optional) 
            var collectionid = "collectionid_example";  // string | Limits the result on collection id (and siblings). Will be overwritten by collectiontypeid parameter. (optional) 
            var mode = "mode_example";  // string | Two modes supported: \"any\" or \"all\" search terms should be applied. (Only if Azure Search is enabled) (optional) 
            var filter = "filter_example";  // string | Key value filter for filterable strings and string collections separated by special ',,,'. For date or numbers \"<\", \"=\" and \">\" are possible. Mode influences AND (all) and OR (any) of all filters. Multiple filters are separated by semicolons. (Only if Azure Search is enabled) (optional) 
            var ids = "ids_example";  // string | Comma separated values list with all ids which should be returned. (optional) 
            var portalId = "portalId_example";  // string | If the search should be redirected to a specific portal. (optional) 

            try
            {
                SearchFacet result = apiInstance.HttpGetSearchFacetteByName(name, s, collectiontypeid, collectionid, mode, filter, ids, portalId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling SearchManagementApi.HttpGetSearchFacetteByName: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the HttpGetSearchFacetteByNameWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<SearchFacet> response = apiInstance.HttpGetSearchFacetteByNameWithHttpInfo(name, s, collectiontypeid, collectionid, mode, filter, ids, portalId);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling SearchManagementApi.HttpGetSearchFacetteByNameWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **name** | **string** | The name of the facette. |  |
| **s** | **string** | The search string which should be found. |  |
| **collectiontypeid** | **string** | Limits the result on all collections from the given collectiontypeid parameter. | [optional]  |
| **collectionid** | **string** | Limits the result on collection id (and siblings). Will be overwritten by collectiontypeid parameter. | [optional]  |
| **mode** | **string** | Two modes supported: \&quot;any\&quot; or \&quot;all\&quot; search terms should be applied. (Only if Azure Search is enabled) | [optional]  |
| **filter** | **string** | Key value filter for filterable strings and string collections separated by special &#39;,,,&#39;. For date or numbers \&quot;&lt;\&quot;, \&quot;&#x3D;\&quot; and \&quot;&gt;\&quot; are possible. Mode influences AND (all) and OR (any) of all filters. Multiple filters are separated by semicolons. (Only if Azure Search is enabled) | [optional]  |
| **ids** | **string** | Comma separated values list with all ids which should be returned. | [optional]  |
| **portalId** | **string** | If the search should be redirected to a specific portal. | [optional]  |

### Return type

[**SearchFacet**](SearchFacet.md)

### Authorization

[msal_auth](../README.md#msal_auth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Returns the search result |  -  |
| **400** | A required parameter is null. (Code: 870f62fe-827a-4ef3-98e7-7f309244ee00)&lt;br&gt;or provide at least parameter \&quot;s&#x3D;\&quot; with search string (url encoded) (Code: 180db53c-9789-4588-ac4b-23d0c1eb1c06)&lt;br&gt;or limit is not a valid number! Can use 0 for defined limit. (Code: 7115dc96-99e3-47a4-827a-8cc63cc1ab68&lt;br&gt;or skip is not a valid number! Can use 0 for defined skip. (Code: ad8237e0-236c-4404-8eaa-d81a9fa4e41c&lt;br&gt;Parameter \&quot;portal_id&#x3D;\&quot; is not valid.(Code: 2ef46a2f-07a5-4ee3-acef-5b421c3f493a)&lt;br&gt;Parameter \&quot;portal_id&#x3D;\&quot; is not found in system. (Code: d0ed0426-9c08-4490-b43c-660093f63db9)&lt;br&gt;Azure Search is not enabled! (Code: ddeb49b9-9574-4682-a7bd-b2946033983f)&lt;br&gt;or parameter \&quot;collectiontypeid&#x3D;\&quot; is not valid (not in correct format or not found in system). (Code: 330e6abb-e77e-4193-9aa0-9dfce168c674)&lt;br&gt;or parameter \&quot;collectionid&#x3D;\&quot; is not valid (not in correct format or not found in system). (Code: c20f1dfb-0d19-419e-96eb-f5dee44576fe) |  -  |
| **401** | Unauthorized. Bearer Token not provided. |  -  |
| **500** | Internal server error. Please contact administrator. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="httpglobalsearch"></a>
# **HttpGlobalSearch**
> SearchResult HttpGlobalSearch (string s, int? limit = null, int? skip = null, string collectiontypeid = null, string collectionid = null, string mode = null, bool? expose = null, string filter = null, string orderby = null, string ids = null, string portalId = null, bool? translations = null, string acceptLanguage = null)



This endpoint returns a configured max amount of results for search terms.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Agravity.Public.Api;
using Agravity.Public.Client;
using Agravity.Public.Model;

namespace Example
{
    public class HttpGlobalSearchExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost:7071/api";
            // Configure OAuth2 access token for authorization: msal_auth
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new SearchManagementApi(config);
            var s = "s_example";  // string | The search string which should be found.
            var limit = 56;  // int? | How many results should be returend. 0 is backend configuration limit. (optional) 
            var skip = 56;  // int? | (default: 0) - Used for paging - how many items should be skipped before next limit results will be fetched. (optional) 
            var collectiontypeid = "collectiontypeid_example";  // string | Limits the result on all collections from the given collectiontypeid parameter. (optional) 
            var collectionid = "collectionid_example";  // string | Limits the result on collection id (and siblings). Will be overwritten by collectiontypeid parameter. (optional) 
            var mode = "mode_example";  // string | Two modes supported: \"any\" or \"all\" search terms should be applied. (Only if Azure Search is enabled) (optional) 
            var expose = true;  // bool? | This will expose the thumbnail asset blob incl. URL with SAS Token. (optional) 
            var filter = "filter_example";  // string | Key value filter for filterable strings and string collections separated by special ',,,'. For date or numbers \"<\", \"=\" and \">\" are possible. Mode influences AND (all) and OR (any) of all filters. Multiple filters are separated by semicolons. (Only if Azure Search is enabled) (optional) 
            var orderby = "orderby_example";  // string | Sortable fields can be used. For descendant sorting use leading \"!\". (Only if Azure Search is enabled) (optional) 
            var ids = "ids_example";  // string | Comma separated values list with all ids which should be returned. (optional) 
            var portalId = "portalId_example";  // string | If the search should be redirected to a specific portal. (optional) 
            var translations = true;  // bool? | When default language should be returned and the translation dictionary is delivered. (Ignores the \"Accept-Language\" header) (optional) 
            var acceptLanguage = "acceptLanguage_example";  // string | The requested language of the response. If not matching it falls back to default language. (optional) 

            try
            {
                SearchResult result = apiInstance.HttpGlobalSearch(s, limit, skip, collectiontypeid, collectionid, mode, expose, filter, orderby, ids, portalId, translations, acceptLanguage);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling SearchManagementApi.HttpGlobalSearch: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the HttpGlobalSearchWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<SearchResult> response = apiInstance.HttpGlobalSearchWithHttpInfo(s, limit, skip, collectiontypeid, collectionid, mode, expose, filter, orderby, ids, portalId, translations, acceptLanguage);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling SearchManagementApi.HttpGlobalSearchWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **s** | **string** | The search string which should be found. |  |
| **limit** | **int?** | How many results should be returend. 0 is backend configuration limit. | [optional]  |
| **skip** | **int?** | (default: 0) - Used for paging - how many items should be skipped before next limit results will be fetched. | [optional]  |
| **collectiontypeid** | **string** | Limits the result on all collections from the given collectiontypeid parameter. | [optional]  |
| **collectionid** | **string** | Limits the result on collection id (and siblings). Will be overwritten by collectiontypeid parameter. | [optional]  |
| **mode** | **string** | Two modes supported: \&quot;any\&quot; or \&quot;all\&quot; search terms should be applied. (Only if Azure Search is enabled) | [optional]  |
| **expose** | **bool?** | This will expose the thumbnail asset blob incl. URL with SAS Token. | [optional]  |
| **filter** | **string** | Key value filter for filterable strings and string collections separated by special &#39;,,,&#39;. For date or numbers \&quot;&lt;\&quot;, \&quot;&#x3D;\&quot; and \&quot;&gt;\&quot; are possible. Mode influences AND (all) and OR (any) of all filters. Multiple filters are separated by semicolons. (Only if Azure Search is enabled) | [optional]  |
| **orderby** | **string** | Sortable fields can be used. For descendant sorting use leading \&quot;!\&quot;. (Only if Azure Search is enabled) | [optional]  |
| **ids** | **string** | Comma separated values list with all ids which should be returned. | [optional]  |
| **portalId** | **string** | If the search should be redirected to a specific portal. | [optional]  |
| **translations** | **bool?** | When default language should be returned and the translation dictionary is delivered. (Ignores the \&quot;Accept-Language\&quot; header) | [optional]  |
| **acceptLanguage** | **string** | The requested language of the response. If not matching it falls back to default language. | [optional]  |

### Return type

[**SearchResult**](SearchResult.md)

### Authorization

[msal_auth](../README.md#msal_auth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Returns the search result |  -  |
| **400** | A required parameter is null. (Code: 870f62fe-827a-4ef3-98e7-7f309244ee00)&lt;br&gt;or provide at least parameter \&quot;s&#x3D;\&quot; with search string (url encoded) (Code: de39bfb1-42e3-4edf-9651-5c4952524e69)&lt;br&gt;or limit is not a valid number! Can use 0 for defined limit. (Code: 7115dc96-99e3-47a4-827a-8cc63cc1ab68&lt;br&gt;or skip is not a valid number! Can use 0 for defined skip. (Code: ad8237e0-236c-4404-8eaa-d81a9fa4e41c&lt;br&gt;Parameter \&quot;portal_id&#x3D;\&quot; is not valid.(Code: 0eeba89a-7fa6-44c4-bfaf-0548050e6e82)&lt;br&gt;Parameter \&quot;portal_id&#x3D;\&quot; is not found in system. (Code: b79314cc-a344-47a0-b144-356f4dfe4df8)&lt;br&gt;Azure Search is not enabled! (Code: b285af21-e4a3-47cd-a71c-f6445d81a906)&lt;br&gt;or parameter \&quot;collectiontypeid&#x3D;\&quot; is not valid (not in correct format or not found in system). (Code: 330e6abb-e77e-4193-9aa0-9dfce168c674)&lt;br&gt;or parameter \&quot;collectionid&#x3D;\&quot; is not valid (not in correct format or not found in system). (Code: c20f1dfb-0d19-419e-96eb-f5dee44576fe) |  -  |
| **401** | Unauthorized. Bearer Token not provided. |  -  |
| **500** | Internal server error. Please contact administrator. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="httppatchcleansearchfromdeletedassets"></a>
# **HttpPatchCleanSearchFromDeletedAssets**
> AgravityInfoResponse HttpPatchCleanSearchFromDeletedAssets (string portalId = null)



This endpoint removes all assets which are not longer available in the database from the search index.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Agravity.Public.Api;
using Agravity.Public.Client;
using Agravity.Public.Model;

namespace Example
{
    public class HttpPatchCleanSearchFromDeletedAssetsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost:7071/api";
            // Configure OAuth2 access token for authorization: msal_auth
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new SearchManagementApi(config);
            var portalId = "portalId_example";  // string | If the search should be redirected to a specific portal. (optional) 

            try
            {
                AgravityInfoResponse result = apiInstance.HttpPatchCleanSearchFromDeletedAssets(portalId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling SearchManagementApi.HttpPatchCleanSearchFromDeletedAssets: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the HttpPatchCleanSearchFromDeletedAssetsWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<AgravityInfoResponse> response = apiInstance.HttpPatchCleanSearchFromDeletedAssetsWithHttpInfo(portalId);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling SearchManagementApi.HttpPatchCleanSearchFromDeletedAssetsWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **portalId** | **string** | If the search should be redirected to a specific portal. | [optional]  |

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
| **201** | This gives the info which assets was removed successful. (Code: 813341e0-f10f-4760-bac2-e203569f8c6c) |  -  |
| **401** | Unauthorized. Bearer Token not provided. |  -  |
| **500** | Internal server error. Please contact administrator. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="httppatchreindexassets"></a>
# **HttpPatchReIndexAssets**
> AgravityInfoResponse HttpPatchReIndexAssets (string id)



This endpoint takes the ID and check if it is a collection type, collection or asset and re-index it in search.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Agravity.Public.Api;
using Agravity.Public.Client;
using Agravity.Public.Model;

namespace Example
{
    public class HttpPatchReIndexAssetsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost:7071/api";
            // Configure OAuth2 access token for authorization: msal_auth
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new SearchManagementApi(config);
            var id = "id_example";  // string | The ID of the entity (collection type, collection or asset).

            try
            {
                AgravityInfoResponse result = apiInstance.HttpPatchReIndexAssets(id);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling SearchManagementApi.HttpPatchReIndexAssets: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the HttpPatchReIndexAssetsWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<AgravityInfoResponse> response = apiInstance.HttpPatchReIndexAssetsWithHttpInfo(id);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling SearchManagementApi.HttpPatchReIndexAssetsWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **string** | The ID of the entity (collection type, collection or asset). |  |

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
| **201** | This gives the info which assets was removed successful. (Code: 813341e0-f10f-4760-bac2-e203569f8c6c) |  -  |
| **401** | Unauthorized. Bearer Token not provided. |  -  |
| **500** | Internal server error. Please contact administrator. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="httpsearchadmingetstatus"></a>
# **HttpSearchAdminGetStatus**
> SearchAdminStatus HttpSearchAdminGetStatus (string portalId = null, bool? full = null)



This endpoint gives the status about the index and indexer. Skill and data source connection only when 'full' is set to true.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Agravity.Public.Api;
using Agravity.Public.Client;
using Agravity.Public.Model;

namespace Example
{
    public class HttpSearchAdminGetStatusExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost:7071/api";
            // Configure OAuth2 access token for authorization: msal_auth
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new SearchManagementApi(config);
            var portalId = "portalId_example";  // string | If the search should be redirected to a specific portal. (optional) 
            var full = true;  // bool? | If all information is needed (incl. datasource, etc.). (optional) 

            try
            {
                SearchAdminStatus result = apiInstance.HttpSearchAdminGetStatus(portalId, full);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling SearchManagementApi.HttpSearchAdminGetStatus: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the HttpSearchAdminGetStatusWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<SearchAdminStatus> response = apiInstance.HttpSearchAdminGetStatusWithHttpInfo(portalId, full);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling SearchManagementApi.HttpSearchAdminGetStatusWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **portalId** | **string** | If the search should be redirected to a specific portal. | [optional]  |
| **full** | **bool?** | If all information is needed (incl. datasource, etc.). | [optional]  |

### Return type

[**SearchAdminStatus**](SearchAdminStatus.md)

### Authorization

[msal_auth](../README.md#msal_auth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | This gives status about the search. |  -  |
| **401** | Unauthorized. Bearer Token not provided. |  -  |
| **500** | Internal server error. Please contact administrator. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

