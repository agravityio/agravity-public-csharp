# Agravity.Public.Api.PublicStaticDefinedListManagementApi

All URIs are relative to *http://localhost:7072/api*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**HttpStaticDefinedListsGetAll**](PublicStaticDefinedListManagementApi.md#httpstaticdefinedlistsgetall) | **GET** /staticdefinedlists |  |
| [**HttpStaticDefinedListsGetById**](PublicStaticDefinedListManagementApi.md#httpstaticdefinedlistsgetbyid) | **GET** /staticdefinedlists/{id} |  |
| [**HttpStaticDefinedListsUpdateById**](PublicStaticDefinedListManagementApi.md#httpstaticdefinedlistsupdatebyid) | **POST** /staticdefinedlists/{id} |  |

<a name="httpstaticdefinedlistsgetall"></a>
# **HttpStaticDefinedListsGetAll**
> List&lt;StaticDefinedList&gt; HttpStaticDefinedListsGetAll (bool? translations = null)



This endpoint lists all static defined lists in database.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Agravity.Public.Api;
using Agravity.Public.Client;
using Agravity.Public.Model;

namespace Example
{
    public class HttpStaticDefinedListsGetAllExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost:7072/api";
            // Configure API key authorization: function_key
            config.AddApiKey("x-functions-key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("x-functions-key", "Bearer");

            var apiInstance = new PublicStaticDefinedListManagementApi(config);
            var translations = true;  // bool? | When default language should be returned and the translation dictionary is delivered. (Ignores the \"Accept-Language\" header) (optional) 

            try
            {
                List<StaticDefinedList> result = apiInstance.HttpStaticDefinedListsGetAll(translations);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling PublicStaticDefinedListManagementApi.HttpStaticDefinedListsGetAll: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the HttpStaticDefinedListsGetAllWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<List<StaticDefinedList>> response = apiInstance.HttpStaticDefinedListsGetAllWithHttpInfo(translations);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling PublicStaticDefinedListManagementApi.HttpStaticDefinedListsGetAllWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **translations** | **bool?** | When default language should be returned and the translation dictionary is delivered. (Ignores the \&quot;Accept-Language\&quot; header) | [optional]  |

### Return type

[**List&lt;StaticDefinedList&gt;**](StaticDefinedList.md)

### Authorization

[function_key](../README.md#function_key)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Returns all static defined lists in database. |  -  |
| **401** | Unauthorized. API Key not provided. |  -  |
| **500** | Internal server error. Please contact administrator. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="httpstaticdefinedlistsgetbyid"></a>
# **HttpStaticDefinedListsGetById**
> StaticDefinedList HttpStaticDefinedListsGetById (string id, bool? translations = null)



This endpoint gets a static defined list from database.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Agravity.Public.Api;
using Agravity.Public.Client;
using Agravity.Public.Model;

namespace Example
{
    public class HttpStaticDefinedListsGetByIdExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost:7072/api";
            // Configure API key authorization: function_key
            config.AddApiKey("x-functions-key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("x-functions-key", "Bearer");

            var apiInstance = new PublicStaticDefinedListManagementApi(config);
            var id = "id_example";  // string | The ID of the static defined list.
            var translations = true;  // bool? | When default language should be returned and the translation dictionary is delivered. (Ignores the \"Accept-Language\" header) (optional) 

            try
            {
                StaticDefinedList result = apiInstance.HttpStaticDefinedListsGetById(id, translations);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling PublicStaticDefinedListManagementApi.HttpStaticDefinedListsGetById: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the HttpStaticDefinedListsGetByIdWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<StaticDefinedList> response = apiInstance.HttpStaticDefinedListsGetByIdWithHttpInfo(id, translations);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling PublicStaticDefinedListManagementApi.HttpStaticDefinedListsGetByIdWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **string** | The ID of the static defined list. |  |
| **translations** | **bool?** | When default language should be returned and the translation dictionary is delivered. (Ignores the \&quot;Accept-Language\&quot; header) | [optional]  |

### Return type

[**StaticDefinedList**](StaticDefinedList.md)

### Authorization

[function_key](../README.md#function_key)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Returns a static defined list with the given id. |  -  |
| **404** | The requested item could not be found |  -  |
| **401** | Unauthorized. API Key not provided. |  -  |
| **500** | Internal server error. Please contact administrator. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="httpstaticdefinedlistsupdatebyid"></a>
# **HttpStaticDefinedListsUpdateById**
> StaticDefinedList HttpStaticDefinedListsUpdateById (string id, string updatemode, StaticDefinedList staticDefinedList, bool? translations = null)



This endpoint update a static defined list in database (add, delete or replace values).

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Agravity.Public.Api;
using Agravity.Public.Client;
using Agravity.Public.Model;

namespace Example
{
    public class HttpStaticDefinedListsUpdateByIdExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost:7072/api";
            // Configure API key authorization: function_key
            config.AddApiKey("x-functions-key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("x-functions-key", "Bearer");

            var apiInstance = new PublicStaticDefinedListManagementApi(config);
            var id = "id_example";  // string | The ID of the static defined list.
            var updatemode = "updatemode_example";  // string | The mode how the list should be updated. Available values are: add, delete and replace.
            var staticDefinedList = new StaticDefinedList(); // StaticDefinedList | The values which should be updated.
            var translations = true;  // bool? | When default language should be returned and the translation dictionary is delivered. (Ignores the \"Accept-Language\" header) (optional) 

            try
            {
                StaticDefinedList result = apiInstance.HttpStaticDefinedListsUpdateById(id, updatemode, staticDefinedList, translations);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling PublicStaticDefinedListManagementApi.HttpStaticDefinedListsUpdateById: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the HttpStaticDefinedListsUpdateByIdWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<StaticDefinedList> response = apiInstance.HttpStaticDefinedListsUpdateByIdWithHttpInfo(id, updatemode, staticDefinedList, translations);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling PublicStaticDefinedListManagementApi.HttpStaticDefinedListsUpdateByIdWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **string** | The ID of the static defined list. |  |
| **updatemode** | **string** | The mode how the list should be updated. Available values are: add, delete and replace. |  |
| **staticDefinedList** | [**StaticDefinedList**](StaticDefinedList.md) | The values which should be updated. |  |
| **translations** | **bool?** | When default language should be returned and the translation dictionary is delivered. (Ignores the \&quot;Accept-Language\&quot; header) | [optional]  |

### Return type

[**StaticDefinedList**](StaticDefinedList.md)

### Authorization

[function_key](../README.md#function_key)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Returns the updated static defined list for values only the updated, deleted, added |  -  |
| **400** | Object is not a valid static_defined_list. (Code: 0970b102-0d79-4c1c-8144-2d6576234b5a) &lt;br&gt;No input object given. (Code: 4d2f5034-bf4f-4f19-8f3d-56e3d88b833a)Update mode: {given-update-mode} is not a valid update mode. Allowed modes are: add, delete, replace (Code: cb08ff14-4c6b-4d88-a1d7-7b39897d78e6)Error on create static defined list in database - max retry count is reached. (Code: a524c4cf-392e-4e37-9597-12cdce014757) |  -  |
| **404** | If the static defined list with the ID was not found. |  -  |
| **401** | Unauthorized. API Key not provided. |  -  |
| **500** | Internal server error. Please contact administrator. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

