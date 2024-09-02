# Agravity.Public.Api.PublicHelperToolsApi

All URIs are relative to *http://localhost:7072/api*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**HttpGetAllUserDefinedLists**](PublicHelperToolsApi.md#httpgetalluserdefinedlists) | **GET** /helper/userdefinedlists |  |
| [**HttpGetAllowedFilterableItems**](PublicHelperToolsApi.md#httpgetallowedfilterableitems) | **GET** /helper/filterableitems |  |
| [**HttpGetAllowedSearchableItemNames**](PublicHelperToolsApi.md#httpgetallowedsearchableitemnames) | **GET** /helper/searchableitemnames |  |
| [**HttpGetAllowedSearchableItems**](PublicHelperToolsApi.md#httpgetallowedsearchableitems) | **GET** /helper/searchableitems |  |

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
            config.BasePath = "http://localhost:7072/api";
            // Configure API key authorization: function_key
            config.AddApiKey("x-functions-key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("x-functions-key", "Bearer");

            var apiInstance = new PublicHelperToolsApi(config);
            var translations = true;  // bool? | When default language should be returned and the translation dictionary is delivered. (Ignores the \"Accept-Language\" header) (optional) 
            var acceptLanguage = "acceptLanguage_example";  // string | The requested language of the response. If not matching it falls back to default language. (optional) 

            try
            {
                List<CollectionUDL> result = apiInstance.HttpGetAllUserDefinedLists(translations, acceptLanguage);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling PublicHelperToolsApi.HttpGetAllUserDefinedLists: " + e.Message);
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
    Debug.Print("Exception when calling PublicHelperToolsApi.HttpGetAllUserDefinedListsWithHttpInfo: " + e.Message);
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

[function_key](../README.md#function_key)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | A list of all user defined list entries. |  -  |
| **401** | Unauthorized. API Key not provided. |  -  |
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
            config.BasePath = "http://localhost:7072/api";
            // Configure API key authorization: function_key
            config.AddApiKey("x-functions-key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("x-functions-key", "Bearer");

            var apiInstance = new PublicHelperToolsApi(config);
            var portalId = "portalId_example";  // string | If the search should be redirected to a specific portal. (optional) 

            try
            {
                List<string> result = apiInstance.HttpGetAllowedFilterableItems(portalId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling PublicHelperToolsApi.HttpGetAllowedFilterableItems: " + e.Message);
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
    Debug.Print("Exception when calling PublicHelperToolsApi.HttpGetAllowedFilterableItemsWithHttpInfo: " + e.Message);
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

[function_key](../README.md#function_key)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | A string list of all filterable items. |  -  |
| **400** | Argument is null. (Code: e12181d0-371e-47c4-88cc-1d2453a7d9a6)&lt;br&gt;Argument exception: {message} (Code: e109ada5-d770-43f3-a6e0-7d869b0bb8e1)&lt;br&gt;Request failed:  {message} (Code: 2da00496-7e74-4c11-8bd0-1e92cbc8875a)&lt;br&gt;General error:  {message} ({typeOfException}) (Code: 8c14ca12-da21-4a87-9bcd-9958407f102d) |  -  |
| **401** | Unauthorized. API Key not provided. |  -  |

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
            config.BasePath = "http://localhost:7072/api";
            // Configure API key authorization: function_key
            config.AddApiKey("x-functions-key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("x-functions-key", "Bearer");

            var apiInstance = new PublicHelperToolsApi(config);
            var portalId = "portalId_example";  // string | If the search should be redirected to a specific portal. (optional) 

            try
            {
                List<string> result = apiInstance.HttpGetAllowedSearchableItemNames(portalId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling PublicHelperToolsApi.HttpGetAllowedSearchableItemNames: " + e.Message);
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
    Debug.Print("Exception when calling PublicHelperToolsApi.HttpGetAllowedSearchableItemNamesWithHttpInfo: " + e.Message);
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

[function_key](../README.md#function_key)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **400** | Argument is null. (Code: 7e0e127f-d12d-441d-8405-25d91f2b32d6)&lt;br&gt;Argument exception: {message} (Code: 35c2fd8d-30ca-4c72-80fd-de91973b9c99)&lt;br&gt;Request failed:  {message} (Code: fb5e9c1b-1206-4488-9240-3cc949c23646)&lt;br&gt;General error:  {message} ({typeOfException}) (Code: e0289b2f-7a44-4cc6-a552-f025e5cdad3e) |  -  |
| **200** | A string list of all searchable items. |  -  |
| **401** | Unauthorized. API Key not provided. |  -  |

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
            config.BasePath = "http://localhost:7072/api";
            // Configure API key authorization: function_key
            config.AddApiKey("x-functions-key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("x-functions-key", "Bearer");

            var apiInstance = new PublicHelperToolsApi(config);
            var portalId = "portalId_example";  // string | If the search should be redirected to a specific portal. (optional) 

            try
            {
                List<SearchableItem> result = apiInstance.HttpGetAllowedSearchableItems(portalId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling PublicHelperToolsApi.HttpGetAllowedSearchableItems: " + e.Message);
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
    Debug.Print("Exception when calling PublicHelperToolsApi.HttpGetAllowedSearchableItemsWithHttpInfo: " + e.Message);
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

[function_key](../README.md#function_key)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | A list of all searchable items. |  -  |
| **400** | Argument is null. (Code: 5e87014c-7ac4-4487-b91d-ce03438d5d45)&lt;br&gt;Argument exception: {message} (Code: 1f7fb1e7-dbf4-41a8-b89c-9829067a1ca6)&lt;br&gt;Request failed:  {message} (Code: b66c90a6-482e-40ee-b77d-06e001803ae0)&lt;br&gt;General error:  {message} ({typeOfException}) (Code: 4ff25dc7-47dd-4bec-bcce-6ecdb11b01c8) |  -  |
| **401** | Unauthorized. API Key not provided. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

