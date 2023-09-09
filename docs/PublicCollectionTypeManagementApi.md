# Agravity.Public.Api.PublicCollectionTypeManagementApi

All URIs are relative to *http://localhost:7072/api*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**HttpCollectionTypesGet**](PublicCollectionTypeManagementApi.md#httpcollectiontypesget) | **GET** /collectiontypes |  |
| [**HttpCollectionTypesGetById**](PublicCollectionTypeManagementApi.md#httpcollectiontypesgetbyid) | **GET** /collectiontypes/{id} |  |
| [**HttpGetCollectionTypeItems**](PublicCollectionTypeManagementApi.md#httpgetcollectiontypeitems) | **GET** /collectiontypesitems |  |

<a name="httpcollectiontypesget"></a>
# **HttpCollectionTypesGet**
> List&lt;CollectionType&gt; HttpCollectionTypesGet (bool? translations = null)



This lists all available collection types which are stored in the database and not deleted (status \"A\").

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Agravity.Public.Api;
using Agravity.Public.Client;
using Agravity.Public.Model;

namespace Example
{
    public class HttpCollectionTypesGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost:7072/api";
            // Configure API key authorization: function_key
            config.AddApiKey("x-functions-key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("x-functions-key", "Bearer");

            var apiInstance = new PublicCollectionTypeManagementApi(config);
            var translations = true;  // bool? | When default language should be returned and the translation dictionary is delivered. (Ignores the \"Accept-Language\" header) (optional) 

            try
            {
                List<CollectionType> result = apiInstance.HttpCollectionTypesGet(translations);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling PublicCollectionTypeManagementApi.HttpCollectionTypesGet: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the HttpCollectionTypesGetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<List<CollectionType>> response = apiInstance.HttpCollectionTypesGetWithHttpInfo(translations);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling PublicCollectionTypeManagementApi.HttpCollectionTypesGetWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **translations** | **bool?** | When default language should be returned and the translation dictionary is delivered. (Ignores the \&quot;Accept-Language\&quot; header) | [optional]  |

### Return type

[**List&lt;CollectionType&gt;**](CollectionType.md)

### Authorization

[function_key](../README.md#function_key)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Returns the all collection types as array. |  -  |
| **400** | Could not create connection to CosmosDB (Code: e244cef3-2665-4757-ba34-0d4d0e71bb9d) |  -  |
| **401** | Unauthorized. API Key not provided. |  -  |
| **500** | Internal server error. Please contact administrator. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="httpcollectiontypesgetbyid"></a>
# **HttpCollectionTypesGetById**
> CollectionType HttpCollectionTypesGetById (string id, bool? translations = null)



Returns one single collection type (from ID).

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Agravity.Public.Api;
using Agravity.Public.Client;
using Agravity.Public.Model;

namespace Example
{
    public class HttpCollectionTypesGetByIdExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost:7072/api";
            // Configure API key authorization: function_key
            config.AddApiKey("x-functions-key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("x-functions-key", "Bearer");

            var apiInstance = new PublicCollectionTypeManagementApi(config);
            var id = "id_example";  // string | The ID of the collection type.
            var translations = true;  // bool? | When default language should be returned and the translation dictionary is delivered. (Ignores the \"Accept-Language\" header) (optional) 

            try
            {
                CollectionType result = apiInstance.HttpCollectionTypesGetById(id, translations);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling PublicCollectionTypeManagementApi.HttpCollectionTypesGetById: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the HttpCollectionTypesGetByIdWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<CollectionType> response = apiInstance.HttpCollectionTypesGetByIdWithHttpInfo(id, translations);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling PublicCollectionTypeManagementApi.HttpCollectionTypesGetByIdWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **string** | The ID of the collection type. |  |
| **translations** | **bool?** | When default language should be returned and the translation dictionary is delivered. (Ignores the \&quot;Accept-Language\&quot; header) | [optional]  |

### Return type

[**CollectionType**](CollectionType.md)

### Authorization

[function_key](../README.md#function_key)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Returns the collection type with the given ID. |  -  |
| **404** | If the collection type with the ID was not found. |  -  |
| **401** | Unauthorized. API Key not provided. |  -  |
| **500** | Internal server error. Please contact administrator. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="httpgetcollectiontypeitems"></a>
# **HttpGetCollectionTypeItems**
> List&lt;CollTypeItem&gt; HttpGetCollectionTypeItems (bool? includeblueprint = null, bool? translations = null)



This method returns a list of collection types items. (Regardless of the permissions)

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Agravity.Public.Api;
using Agravity.Public.Client;
using Agravity.Public.Model;

namespace Example
{
    public class HttpGetCollectionTypeItemsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost:7072/api";
            // Configure API key authorization: function_key
            config.AddApiKey("x-functions-key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("x-functions-key", "Bearer");

            var apiInstance = new PublicCollectionTypeManagementApi(config);
            var includeblueprint = true;  // bool? | True if the blueprint items should be included. (optional) 
            var translations = true;  // bool? | When default language should be returned and the translation dictionary is delivered. (Ignores the \"Accept-Language\" header) (optional) 

            try
            {
                List<CollTypeItem> result = apiInstance.HttpGetCollectionTypeItems(includeblueprint, translations);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling PublicCollectionTypeManagementApi.HttpGetCollectionTypeItems: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the HttpGetCollectionTypeItemsWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<List<CollTypeItem>> response = apiInstance.HttpGetCollectionTypeItemsWithHttpInfo(includeblueprint, translations);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling PublicCollectionTypeManagementApi.HttpGetCollectionTypeItemsWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **includeblueprint** | **bool?** | True if the blueprint items should be included. | [optional]  |
| **translations** | **bool?** | When default language should be returned and the translation dictionary is delivered. (Ignores the \&quot;Accept-Language\&quot; header) | [optional]  |

### Return type

[**List&lt;CollTypeItem&gt;**](CollTypeItem.md)

### Authorization

[function_key](../README.md#function_key)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | The collection types items for this item. |  -  |
| **401** | Unauthorized. API Key not provided. |  -  |
| **404** | If the no collection type items were not found. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

