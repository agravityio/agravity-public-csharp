# AgravityPublic.Api.PublicHelperToolsApi

All URIs are relative to *http://localhost:7072/api*

Method | HTTP request | Description
------------- | ------------- | -------------
[**HttpGetAllUserDefinedLists**](PublicHelperToolsApi.md#httpgetalluserdefinedlists) | **GET** /helper/userdefinedlists | 
[**HttpGetAllowedFilterableItems**](PublicHelperToolsApi.md#httpgetallowedfilterableitems) | **GET** /helper/filterableitems | 
[**HttpGetAllowedSearchableItemNames**](PublicHelperToolsApi.md#httpgetallowedsearchableitemnames) | **GET** /helper/searchableitemnames | 
[**HttpGetAllowedSearchableItems**](PublicHelperToolsApi.md#httpgetallowedsearchableitems) | **GET** /helper/searchableitems | 



## HttpGetAllUserDefinedLists

> List&lt;CollectionUDL&gt; HttpGetAllUserDefinedLists ()



Returns all user defined lists of all collection types

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using AgravityPublic.Api;
using AgravityPublic.Client;
using AgravityPublic.Model;

namespace Example
{
    public class HttpGetAllUserDefinedListsExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "http://localhost:7072/api";
            // Configure API key authorization: function_key
            Configuration.Default.AddApiKey("x-functions-key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("x-functions-key", "Bearer");

            var apiInstance = new PublicHelperToolsApi(Configuration.Default);

            try
            {
                List<CollectionUDL> result = apiInstance.HttpGetAllUserDefinedLists();
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling PublicHelperToolsApi.HttpGetAllUserDefinedLists: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

This endpoint does not need any parameter.

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

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## HttpGetAllowedFilterableItems

> List&lt;string&gt; HttpGetAllowedFilterableItems ()



Returns all filterable items directly from the search index

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using AgravityPublic.Api;
using AgravityPublic.Client;
using AgravityPublic.Model;

namespace Example
{
    public class HttpGetAllowedFilterableItemsExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "http://localhost:7072/api";
            // Configure API key authorization: function_key
            Configuration.Default.AddApiKey("x-functions-key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("x-functions-key", "Bearer");

            var apiInstance = new PublicHelperToolsApi(Configuration.Default);

            try
            {
                List<string> result = apiInstance.HttpGetAllowedFilterableItems();
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling PublicHelperToolsApi.HttpGetAllowedFilterableItems: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

This endpoint does not need any parameter.

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
| **401** | Unauthorized. API Key not provided. |  -  |

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## HttpGetAllowedSearchableItemNames

> List&lt;string&gt; HttpGetAllowedSearchableItemNames ()



Returns all searchable items directly from the search index

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using AgravityPublic.Api;
using AgravityPublic.Client;
using AgravityPublic.Model;

namespace Example
{
    public class HttpGetAllowedSearchableItemNamesExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "http://localhost:7072/api";
            // Configure API key authorization: function_key
            Configuration.Default.AddApiKey("x-functions-key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("x-functions-key", "Bearer");

            var apiInstance = new PublicHelperToolsApi(Configuration.Default);

            try
            {
                List<string> result = apiInstance.HttpGetAllowedSearchableItemNames();
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling PublicHelperToolsApi.HttpGetAllowedSearchableItemNames: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

This endpoint does not need any parameter.

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
| **200** | A string list of all searchable items. |  -  |
| **401** | Unauthorized. API Key not provided. |  -  |

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## HttpGetAllowedSearchableItems

> List&lt;SearchableItem&gt; HttpGetAllowedSearchableItems ()



Returns all searchable items directly from the search index

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using AgravityPublic.Api;
using AgravityPublic.Client;
using AgravityPublic.Model;

namespace Example
{
    public class HttpGetAllowedSearchableItemsExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "http://localhost:7072/api";
            // Configure API key authorization: function_key
            Configuration.Default.AddApiKey("x-functions-key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("x-functions-key", "Bearer");

            var apiInstance = new PublicHelperToolsApi(Configuration.Default);

            try
            {
                List<SearchableItem> result = apiInstance.HttpGetAllowedSearchableItems();
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling PublicHelperToolsApi.HttpGetAllowedSearchableItems: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

This endpoint does not need any parameter.

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
| **401** | Unauthorized. API Key not provided. |  -  |

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)

