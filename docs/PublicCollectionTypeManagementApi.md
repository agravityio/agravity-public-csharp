# AgravityPublic.Api.PublicCollectionTypeManagementApi

All URIs are relative to *http://localhost:7072/api*

Method | HTTP request | Description
------------- | ------------- | -------------
[**HttpCollectionTypesGet**](PublicCollectionTypeManagementApi.md#httpcollectiontypesget) | **GET** /collectiontypes | 
[**HttpCollectionTypesGetById**](PublicCollectionTypeManagementApi.md#httpcollectiontypesgetbyid) | **GET** /collectiontypes/{id} | 
[**HttpGetCollectionTypeItems**](PublicCollectionTypeManagementApi.md#httpgetcollectiontypeitems) | **GET** /collectiontypesitems | 



## HttpCollectionTypesGet

> List&lt;CollectionType&gt; HttpCollectionTypesGet ()



This lists all available collection types which are stored in the database and not deleted (status \"A\").

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using AgravityPublic.Api;
using AgravityPublic.Client;
using AgravityPublic.Model;

namespace Example
{
    public class HttpCollectionTypesGetExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "http://localhost:7072/api";
            // Configure API key authorization: function_key
            Configuration.Default.AddApiKey("x-functions-key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("x-functions-key", "Bearer");

            var apiInstance = new PublicCollectionTypeManagementApi(Configuration.Default);

            try
            {
                List<CollectionType> result = apiInstance.HttpCollectionTypesGet();
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling PublicCollectionTypeManagementApi.HttpCollectionTypesGet: " + e.Message );
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

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## HttpCollectionTypesGetById

> CollectionType HttpCollectionTypesGetById (string id)



Returns one single collection type (from ID).

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using AgravityPublic.Api;
using AgravityPublic.Client;
using AgravityPublic.Model;

namespace Example
{
    public class HttpCollectionTypesGetByIdExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "http://localhost:7072/api";
            // Configure API key authorization: function_key
            Configuration.Default.AddApiKey("x-functions-key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("x-functions-key", "Bearer");

            var apiInstance = new PublicCollectionTypeManagementApi(Configuration.Default);
            var id = "id_example";  // string | The ID of the collection type.

            try
            {
                CollectionType result = apiInstance.HttpCollectionTypesGetById(id);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling PublicCollectionTypeManagementApi.HttpCollectionTypesGetById: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| The ID of the collection type. | 

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

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## HttpGetCollectionTypeItems

> List&lt;CollTypeItem&gt; HttpGetCollectionTypeItems (bool? includeblueprint = null)



This method returns a list of collection types items.

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using AgravityPublic.Api;
using AgravityPublic.Client;
using AgravityPublic.Model;

namespace Example
{
    public class HttpGetCollectionTypeItemsExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "http://localhost:7072/api";
            // Configure API key authorization: function_key
            Configuration.Default.AddApiKey("x-functions-key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("x-functions-key", "Bearer");

            var apiInstance = new PublicCollectionTypeManagementApi(Configuration.Default);
            var includeblueprint = true;  // bool? | True if the blueprint items should be included. (optional) 

            try
            {
                List<CollTypeItem> result = apiInstance.HttpGetCollectionTypeItems(includeblueprint);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling PublicCollectionTypeManagementApi.HttpGetCollectionTypeItems: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **includeblueprint** | **bool?**| True if the blueprint items should be included. | [optional] 

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

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)

