# Agravity.Public.Api.PublicSearchManagementApi

All URIs are relative to *http://localhost:7072/api*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**HttpGlobalSearch**](PublicSearchManagementApi.md#httpglobalsearch) | **GET** /search |  |

<a name="httpglobalsearch"></a>
# **HttpGlobalSearch**
> SearchResult HttpGlobalSearch (string s, int? limit = null, int? skip = null, string collectiontypeid = null, string collectionid = null, string mode = null, bool? expose = null, string filter = null, string orderby = null, string ids = null, bool? translations = null)



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
            config.BasePath = "http://localhost:7072/api";
            // Configure API key authorization: function_key
            config.AddApiKey("x-functions-key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("x-functions-key", "Bearer");

            var apiInstance = new PublicSearchManagementApi(config);
            var s = "s_example";  // string | The search string which should be found.
            var limit = 56;  // int? | How many results should be returend. 0 is backend configuration limit. (optional) 
            var skip = 56;  // int? | (default: 0) - Used for paging - how many items should be skipped before next limit results will be fetched. (optional) 
            var collectiontypeid = "collectiontypeid_example";  // string | Limits the result on all collections from the given collectiontypeid parameter. (optional) 
            var collectionid = "collectionid_example";  // string | Limits the result on collection id (and siblings). Will be overwritten by collectiontypeid parameter. (optional) 
            var mode = "mode_example";  // string | Two modes supported: \"any\" or \"all\" search terms should be applied. (Only if Azure Search is enabled) (optional) 
            var expose = true;  // bool? | This will expose the thumbnail asset blob incl. URL with SAS Token. (optional) 
            var filter = "filter_example";  // string | Colon separated key value filter for filterable strings and string collections. For date or numbers \"<\", \"=\" and \">\" are possible. Mode influences AND (all) and OR (any) of all filters. Multiple filters are separated by semicolons. (Only if Azure Search is enabled) (optional) 
            var orderby = "orderby_example";  // string | Sortable fields can be used. For descendant sorting use leading \"!\". (Only if Azure Search is enabled) (optional) 
            var ids = "ids_example";  // string | Comma separated values list with all ids which should be returned. (optional) 
            var translations = true;  // bool? | When default language should be returned and the translation dictionary is delivered. (Ignores the \"Accept-Language\" header) (optional) 

            try
            {
                SearchResult result = apiInstance.HttpGlobalSearch(s, limit, skip, collectiontypeid, collectionid, mode, expose, filter, orderby, ids, translations);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling PublicSearchManagementApi.HttpGlobalSearch: " + e.Message);
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
    ApiResponse<SearchResult> response = apiInstance.HttpGlobalSearchWithHttpInfo(s, limit, skip, collectiontypeid, collectionid, mode, expose, filter, orderby, ids, translations);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling PublicSearchManagementApi.HttpGlobalSearchWithHttpInfo: " + e.Message);
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
| **filter** | **string** | Colon separated key value filter for filterable strings and string collections. For date or numbers \&quot;&lt;\&quot;, \&quot;&#x3D;\&quot; and \&quot;&gt;\&quot; are possible. Mode influences AND (all) and OR (any) of all filters. Multiple filters are separated by semicolons. (Only if Azure Search is enabled) | [optional]  |
| **orderby** | **string** | Sortable fields can be used. For descendant sorting use leading \&quot;!\&quot;. (Only if Azure Search is enabled) | [optional]  |
| **ids** | **string** | Comma separated values list with all ids which should be returned. | [optional]  |
| **translations** | **bool?** | When default language should be returned and the translation dictionary is delivered. (Ignores the \&quot;Accept-Language\&quot; header) | [optional]  |

### Return type

[**SearchResult**](SearchResult.md)

### Authorization

[function_key](../README.md#function_key)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Returns the search result |  -  |
| **400** | A required parameter is null. (Code: 870f62fe-827a-4ef3-98e7-7f309244ee00)&lt;br&gt;or provide at least parameter \&quot;s&#x3D;\&quot; with search string (url encoded) (Code: de39bfb1-42e3-4edf-9651-5c4952524e69)&lt;br&gt;or limit is not a valid number! Can use 0 for defined limit. (Code: 7115dc96-99e3-47a4-827a-8cc63cc1ab68 or skip is not a valid number! Can use 0 for defined skip. (Code: ad8237e0-236c-4404-8eaa-d81a9fa4e41c or parameter \&quot;collectiontypeid&#x3D;\&quot; is not valid (not in correct format or not found in system). (Code: 330e6abb-e77e-4193-9aa0-9dfce168c674)&lt;br&gt;or parameter \&quot;collectionid&#x3D;\&quot; is not valid (not in correct format or not found in system). (Code: c20f1dfb-0d19-419e-96eb-f5dee44576fe) |  -  |
| **401** | Unauthorized. API Key not provided. |  -  |
| **500** | Internal server error. Please contact administrator. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

