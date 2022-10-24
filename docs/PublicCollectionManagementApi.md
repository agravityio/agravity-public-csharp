# AgravityPublic.Api.PublicCollectionManagementApi

All URIs are relative to *http://localhost:7072/api*

Method | HTTP request | Description
------------- | ------------- | -------------
[**HttpCollectionsCreate**](PublicCollectionManagementApi.md#httpcollectionscreate) | **POST** /collections | 
[**HttpCollectionsGet**](PublicCollectionManagementApi.md#httpcollectionsget) | **GET** /collections | 
[**HttpCollectionsGetById**](PublicCollectionManagementApi.md#httpcollectionsgetbyid) | **GET** /collections/{id} | 
[**HttpCollectionsGetDescendantsTreeOfId**](PublicCollectionManagementApi.md#httpcollectionsgetdescendantstreeofid) | **GET** /collections/{id}/descendants | 
[**HttpCollectionsGetTreeAncestorsOfId**](PublicCollectionManagementApi.md#httpcollectionsgettreeancestorsofid) | **GET** /collections/{id}/ancestors | 
[**HttpGetCollectionPreviewsById**](PublicCollectionManagementApi.md#httpgetcollectionpreviewsbyid) | **GET** /collections/{id}/previews | 



## HttpCollectionsCreate

> Collection HttpCollectionsCreate (string collectiontypeid, Collection collection)



This endpoint creates a unique collection ID and adds the information to the database.

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using AgravityPublic.Api;
using AgravityPublic.Client;
using AgravityPublic.Model;

namespace Example
{
    public class HttpCollectionsCreateExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "http://localhost:7072/api";
            // Configure API key authorization: function_key
            Configuration.Default.AddApiKey("x-functions-key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("x-functions-key", "Bearer");

            var apiInstance = new PublicCollectionManagementApi(Configuration.Default);
            var collectiontypeid = "collectiontypeid_example";  // string | The ID of the collection type where this collections should be assigned.
            var collection = new Collection(); // Collection | This endpoint creates a unique collection ID and adds the information to the database.

            try
            {
                Collection result = apiInstance.HttpCollectionsCreate(collectiontypeid, collection);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling PublicCollectionManagementApi.HttpCollectionsCreate: " + e.Message );
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
 **collectiontypeid** | **string**| The ID of the collection type where this collections should be assigned. | 
 **collection** | [**Collection**](Collection.md)| This endpoint creates a unique collection ID and adds the information to the database. | 

### Return type

**Collection**

### Authorization

[function_key](../README.md#function_key)

### HTTP request headers

- **Content-Type**: application/json
- **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **201** | Returns the created collection. |  -  |
| **400** | A parameter is null. (Code: 7dac18af-04ef-4da6-8b6e-e13dd8b027ae)&lt;br&gt;Missing or invalid parameter \&quot;collectiontypeid\&quot;. (Code: 42a54d68-8a33-4a71-9545-7460f7a1339d)&lt;br&gt;The collection type \&quot;&lt;collectiontypeid&gt;\&quot; was not found.. (Code: 203b1950-d942-4692-8e55-0ec5c137167f)&lt;br&gt;Object is not a valid collection. (Code: 67dd9a9f-b899-4607-bce8-0b0c4b4eec66) |  -  |
| **401** | Unauthorized. API Key not provided. |  -  |
| **500** | Internal server error. Please contact administrator. |  -  |

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## HttpCollectionsGet

> List&lt;Collection&gt; HttpCollectionsGet (string collectiontypeid, int? level = null, string parentid = null, string fields = null)



This lists all the collections which are stored in the database and not deleted (status \"A\"). This will include all specific properties from collection type.

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using AgravityPublic.Api;
using AgravityPublic.Client;
using AgravityPublic.Model;

namespace Example
{
    public class HttpCollectionsGetExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "http://localhost:7072/api";
            // Configure API key authorization: function_key
            Configuration.Default.AddApiKey("x-functions-key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("x-functions-key", "Bearer");

            var apiInstance = new PublicCollectionManagementApi(Configuration.Default);
            var collectiontypeid = "collectiontypeid_example";  // string | The ID of the collection type where these collections should come from.
            var level = 56;  // int? | The hierarchy level of collections which should be returned. (optional) 
            var parentid = "parentid_example";  // string | The ID of the parent collection which should be queried. (No collectiontypeid is required) (optional) 
            var fields = "fields_example";  // string | This limits the fields which are returned, separated by comma (','). (optional) 

            try
            {
                List<Collection> result = apiInstance.HttpCollectionsGet(collectiontypeid, level, parentid, fields);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling PublicCollectionManagementApi.HttpCollectionsGet: " + e.Message );
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
 **collectiontypeid** | **string**| The ID of the collection type where these collections should come from. | 
 **level** | **int?**| The hierarchy level of collections which should be returned. | [optional] 
 **parentid** | **string**| The ID of the parent collection which should be queried. (No collectiontypeid is required) | [optional] 
 **fields** | **string**| This limits the fields which are returned, separated by comma (&#39;,&#39;). | [optional] 

### Return type

**List<Collection>**

### Authorization

[function_key](../README.md#function_key)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Returns the all collections as array. |  -  |
| **400** | Level not a positive number (Code: 757f7df3-3556-4c59-b5ac-9c7bfda6c3d4) |  -  |
| **401** | Unauthorized. API Key not provided. |  -  |
| **500** | Internal server error. Please contact administrator. |  -  |

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## HttpCollectionsGetById

> Collection HttpCollectionsGetById (string id, string fields = null)



Returns one single collection (from ID). This will include all specific properties from collection type.

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using AgravityPublic.Api;
using AgravityPublic.Client;
using AgravityPublic.Model;

namespace Example
{
    public class HttpCollectionsGetByIdExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "http://localhost:7072/api";
            // Configure API key authorization: function_key
            Configuration.Default.AddApiKey("x-functions-key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("x-functions-key", "Bearer");

            var apiInstance = new PublicCollectionManagementApi(Configuration.Default);
            var id = "id_example";  // string | The ID of the collection.
            var fields = "fields_example";  // string | This limits the fields which are returned, separated by comma (','). (optional) 

            try
            {
                Collection result = apiInstance.HttpCollectionsGetById(id, fields);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling PublicCollectionManagementApi.HttpCollectionsGetById: " + e.Message );
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
 **id** | **string**| The ID of the collection. | 
 **fields** | **string**| This limits the fields which are returned, separated by comma (&#39;,&#39;). | [optional] 

### Return type

**Collection**

### Authorization

[function_key](../README.md#function_key)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Returns the collection with the given ID. |  -  |
| **401** | Unauthorized. API Key not provided. |  -  |
| **404** | If the collection with the ID was not found. |  -  |
| **500** | Internal server error. Please contact administrator. |  -  |

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## HttpCollectionsGetDescendantsTreeOfId

> List&lt;Collection&gt; HttpCollectionsGetDescendantsTreeOfId (string id)



Get the complete tree of descendants from a single collection.

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using AgravityPublic.Api;
using AgravityPublic.Client;
using AgravityPublic.Model;

namespace Example
{
    public class HttpCollectionsGetDescendantsTreeOfIdExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "http://localhost:7072/api";
            // Configure API key authorization: function_key
            Configuration.Default.AddApiKey("x-functions-key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("x-functions-key", "Bearer");

            var apiInstance = new PublicCollectionManagementApi(Configuration.Default);
            var id = "id_example";  // string | The ID of the collection.

            try
            {
                List<Collection> result = apiInstance.HttpCollectionsGetDescendantsTreeOfId(id);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling PublicCollectionManagementApi.HttpCollectionsGetDescendantsTreeOfId: " + e.Message );
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
 **id** | **string**| The ID of the collection. | 

### Return type

**List<Collection>**

### Authorization

[function_key](../README.md#function_key)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Returns the array of descendants collections from the given collection in order by path. |  -  |
| **400** | Given collection id is not valid! (Code: 1f07346f-25a5-4338-9f83-cf96cc7af67d) |  -  |
| **404** | If the collection with the ID was not found. |  -  |
| **401** | Unauthorized. API Key not provided. |  -  |
| **500** | Internal server error. Please contact administrator. |  -  |

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## HttpCollectionsGetTreeAncestorsOfId

> List&lt;Collection&gt; HttpCollectionsGetTreeAncestorsOfId (string id)



Get the complete tree of ancestors from a single collection.

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using AgravityPublic.Api;
using AgravityPublic.Client;
using AgravityPublic.Model;

namespace Example
{
    public class HttpCollectionsGetTreeAncestorsOfIdExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "http://localhost:7072/api";
            // Configure API key authorization: function_key
            Configuration.Default.AddApiKey("x-functions-key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("x-functions-key", "Bearer");

            var apiInstance = new PublicCollectionManagementApi(Configuration.Default);
            var id = "id_example";  // string | The ID of the collection.

            try
            {
                List<Collection> result = apiInstance.HttpCollectionsGetTreeAncestorsOfId(id);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling PublicCollectionManagementApi.HttpCollectionsGetTreeAncestorsOfId: " + e.Message );
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
 **id** | **string**| The ID of the collection. | 

### Return type

**List<Collection>**

### Authorization

[function_key](../README.md#function_key)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Returns the array of ancestors collections from the given collection in order by path. |  -  |
| **400** | Given collection id is not valid! (Code: 3f9fda3a-8911-45de-a4a0-34ea9e71e72d) |  -  |
| **404** | If the collection with the ID was not found. |  -  |
| **401** | Unauthorized. API Key not provided. |  -  |
| **500** | Internal server error. Please contact administrator. |  -  |

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## HttpGetCollectionPreviewsById

> string HttpGetCollectionPreviewsById (string id)



This endpoint returns a generated thumbnail as a preview of the containing assets.

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using AgravityPublic.Api;
using AgravityPublic.Client;
using AgravityPublic.Model;

namespace Example
{
    public class HttpGetCollectionPreviewsByIdExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "http://localhost:7072/api";
            // Configure API key authorization: function_key
            Configuration.Default.AddApiKey("x-functions-key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("x-functions-key", "Bearer");

            var apiInstance = new PublicCollectionManagementApi(Configuration.Default);
            var id = "id_example";  // string | The ID of the collection.

            try
            {
                string result = apiInstance.HttpGetCollectionPreviewsById(id);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling PublicCollectionManagementApi.HttpGetCollectionPreviewsById: " + e.Message );
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
 **id** | **string**| The ID of the collection. | 

### Return type

**string**

### Authorization

[function_key](../README.md#function_key)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: image/png, application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Returns a generated png image as byte array. |  -  |
| **404** | If the collection with the ID was not found. |  -  |
| **401** | Unauthorized. API Key not provided. |  -  |
| **500** | Internal server error. Please contact administrator. |  -  |

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)

