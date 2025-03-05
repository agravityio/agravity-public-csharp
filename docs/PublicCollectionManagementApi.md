# Agravity.Public.Api.PublicCollectionManagementApi

All URIs are relative to *http://localhost:7072/api*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**HttpCollectionsCreate**](PublicCollectionManagementApi.md#httpcollectionscreate) | **POST** /collections |  |
| [**HttpCollectionsGet**](PublicCollectionManagementApi.md#httpcollectionsget) | **GET** /collections |  |
| [**HttpCollectionsGetById**](PublicCollectionManagementApi.md#httpcollectionsgetbyid) | **GET** /collections/{id} |  |
| [**HttpCollectionsGetDescendantsTreeOfId**](PublicCollectionManagementApi.md#httpcollectionsgetdescendantstreeofid) | **GET** /collections/{id}/descendants |  |
| [**HttpCollectionsGetTreeAncestorsOfId**](PublicCollectionManagementApi.md#httpcollectionsgettreeancestorsofid) | **GET** /collections/{id}/ancestors |  |
| [**HttpGetCollectionPreviewsById**](PublicCollectionManagementApi.md#httpgetcollectionpreviewsbyid) | **GET** /collections/{id}/previews |  |
| [**HttpPublicCollectionsDeleteById**](PublicCollectionManagementApi.md#httppubliccollectionsdeletebyid) | **DELETE** /collections/{id} |  |
| [**HttpPublicCollectionsUpdateById**](PublicCollectionManagementApi.md#httppubliccollectionsupdatebyid) | **POST** /collections/{id} |  |
| [**HttpPublicPostCollectionsGetByNames**](PublicCollectionManagementApi.md#httppublicpostcollectionsgetbynames) | **POST** /collectionsbynames |  |

<a id="httpcollectionscreate"></a>
# **HttpCollectionsCreate**
> Collection HttpCollectionsCreate (string collectiontypeid, Collection collection, string acceptLanguage = null)



This endpoint creates a unique collection ID and adds the information to the database.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Agravity.Public.Api;
using Agravity.Public.Client;
using Agravity.Public.Model;

namespace Example
{
    public class HttpCollectionsCreateExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost:7072/api";
            // Configure API key authorization: function_key
            config.AddApiKey("x-functions-key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("x-functions-key", "Bearer");

            var apiInstance = new PublicCollectionManagementApi(config);
            var collectiontypeid = "collectiontypeid_example";  // string | The ID of the collection type where this collections should be assigned.
            var collection = new Collection(); // Collection | This endpoint creates a unique collection ID and adds the information to the database.
            var acceptLanguage = "acceptLanguage_example";  // string | The requested language of the response. If not matching it falls back to default language. (optional) 

            try
            {
                Collection result = apiInstance.HttpCollectionsCreate(collectiontypeid, collection, acceptLanguage);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling PublicCollectionManagementApi.HttpCollectionsCreate: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the HttpCollectionsCreateWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<Collection> response = apiInstance.HttpCollectionsCreateWithHttpInfo(collectiontypeid, collection, acceptLanguage);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling PublicCollectionManagementApi.HttpCollectionsCreateWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **collectiontypeid** | **string** | The ID of the collection type where this collections should be assigned. |  |
| **collection** | [**Collection**](Collection.md) | This endpoint creates a unique collection ID and adds the information to the database. |  |
| **acceptLanguage** | **string** | The requested language of the response. If not matching it falls back to default language. | [optional]  |

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
| **400** | A parameter is null. (Code: 7dac18af-04ef-4da6-8b6e-e13dd8b027ae)&lt;br&gt;Missing or invalid parameter \&quot;collectiontypeid\&quot;. (Code: 42a54d68-8a33-4a71-9545-7460f7a1339d)&lt;br&gt;The collection type \&quot;&lt;collectiontypeid&gt;\&quot; was not found.. (Code: 203b1950-d942-4692-8e55-0ec5c137167f)&lt;br&gt;Not valid collection id. (Code: 61a99ef3-c212-4171-8b37-290d8db4af3c)&lt;br&gt;Can not create collection with id {input.Id}. Collection already exists. Delete first. (Code: 321c4f48-7cc9-4ece-af88-89e95031dfde)&lt;br&gt;Object is not a valid collection. (Code: 67dd9a9f-b899-4607-bce8-0b0c4b4eec66) |  -  |
| **401** | Unauthorized. API Key not provided. |  -  |
| **500** | Internal server error. Please contact administrator. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="httpcollectionsget"></a>
# **HttpCollectionsGet**
> List&lt;Collection&gt; HttpCollectionsGet (string collectiontypeid, int? level = null, string parentid = null, string fields = null, bool? items = null, bool? translations = null, string acceptLanguage = null)



This lists all the collections which are stored in the database and not deleted (status \"A\"). This will include all specific properties from collection type.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Agravity.Public.Api;
using Agravity.Public.Client;
using Agravity.Public.Model;

namespace Example
{
    public class HttpCollectionsGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost:7072/api";
            // Configure API key authorization: function_key
            config.AddApiKey("x-functions-key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("x-functions-key", "Bearer");

            var apiInstance = new PublicCollectionManagementApi(config);
            var collectiontypeid = "collectiontypeid_example";  // string | The ID of the collection type where these collections should come from.
            var level = 56;  // int? | The hierarchy level of collections which should be returned. (optional) 
            var parentid = "parentid_example";  // string | The ID of the parent collection which should be queried. (No collectiontypeid is required) (optional) 
            var fields = "fields_example";  // string | This limits the fields which are returned, separated by comma (','). (optional) 
            var items = true;  // bool? | The items can be extended to fully filled items. (optional) 
            var translations = true;  // bool? | When default language should be returned and the translation dictionary is delivered. (Ignores the \"Accept-Language\" header) (optional) 
            var acceptLanguage = "acceptLanguage_example";  // string | The requested language of the response. If not matching it falls back to default language. (optional) 

            try
            {
                List<Collection> result = apiInstance.HttpCollectionsGet(collectiontypeid, level, parentid, fields, items, translations, acceptLanguage);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling PublicCollectionManagementApi.HttpCollectionsGet: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the HttpCollectionsGetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<List<Collection>> response = apiInstance.HttpCollectionsGetWithHttpInfo(collectiontypeid, level, parentid, fields, items, translations, acceptLanguage);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling PublicCollectionManagementApi.HttpCollectionsGetWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **collectiontypeid** | **string** | The ID of the collection type where these collections should come from. |  |
| **level** | **int?** | The hierarchy level of collections which should be returned. | [optional]  |
| **parentid** | **string** | The ID of the parent collection which should be queried. (No collectiontypeid is required) | [optional]  |
| **fields** | **string** | This limits the fields which are returned, separated by comma (&#39;,&#39;). | [optional]  |
| **items** | **bool?** | The items can be extended to fully filled items. | [optional]  |
| **translations** | **bool?** | When default language should be returned and the translation dictionary is delivered. (Ignores the \&quot;Accept-Language\&quot; header) | [optional]  |
| **acceptLanguage** | **string** | The requested language of the response. If not matching it falls back to default language. | [optional]  |

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

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="httpcollectionsgetbyid"></a>
# **HttpCollectionsGetById**
> Collection HttpCollectionsGetById (string id, string fields = null, bool? items = null, bool? translations = null, string acceptLanguage = null)



Returns one single collection (from ID). This will include all specific properties from collection type.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Agravity.Public.Api;
using Agravity.Public.Client;
using Agravity.Public.Model;

namespace Example
{
    public class HttpCollectionsGetByIdExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost:7072/api";
            // Configure API key authorization: function_key
            config.AddApiKey("x-functions-key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("x-functions-key", "Bearer");

            var apiInstance = new PublicCollectionManagementApi(config);
            var id = "id_example";  // string | The ID of the collection.
            var fields = "fields_example";  // string | This limits the fields which are returned, separated by comma (','). (optional) 
            var items = true;  // bool? | The items can be extended to fully filled items. (optional) 
            var translations = true;  // bool? | When default language should be returned and the translation dictionary is delivered. (Ignores the \"Accept-Language\" header) (optional) 
            var acceptLanguage = "acceptLanguage_example";  // string | The requested language of the response. If not matching it falls back to default language. (optional) 

            try
            {
                Collection result = apiInstance.HttpCollectionsGetById(id, fields, items, translations, acceptLanguage);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling PublicCollectionManagementApi.HttpCollectionsGetById: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the HttpCollectionsGetByIdWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<Collection> response = apiInstance.HttpCollectionsGetByIdWithHttpInfo(id, fields, items, translations, acceptLanguage);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling PublicCollectionManagementApi.HttpCollectionsGetByIdWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **string** | The ID of the collection. |  |
| **fields** | **string** | This limits the fields which are returned, separated by comma (&#39;,&#39;). | [optional]  |
| **items** | **bool?** | The items can be extended to fully filled items. | [optional]  |
| **translations** | **bool?** | When default language should be returned and the translation dictionary is delivered. (Ignores the \&quot;Accept-Language\&quot; header) | [optional]  |
| **acceptLanguage** | **string** | The requested language of the response. If not matching it falls back to default language. | [optional]  |

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

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="httpcollectionsgetdescendantstreeofid"></a>
# **HttpCollectionsGetDescendantsTreeOfId**
> List&lt;Collection&gt; HttpCollectionsGetDescendantsTreeOfId (string id, bool? translations = null, string acceptLanguage = null)



Get the complete tree of descendants from a single collection.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Agravity.Public.Api;
using Agravity.Public.Client;
using Agravity.Public.Model;

namespace Example
{
    public class HttpCollectionsGetDescendantsTreeOfIdExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost:7072/api";
            // Configure API key authorization: function_key
            config.AddApiKey("x-functions-key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("x-functions-key", "Bearer");

            var apiInstance = new PublicCollectionManagementApi(config);
            var id = "id_example";  // string | The ID of the collection.
            var translations = true;  // bool? | When default language should be returned and the translation dictionary is delivered. (Ignores the \"Accept-Language\" header) (optional) 
            var acceptLanguage = "acceptLanguage_example";  // string | The requested language of the response. If not matching it falls back to default language. (optional) 

            try
            {
                List<Collection> result = apiInstance.HttpCollectionsGetDescendantsTreeOfId(id, translations, acceptLanguage);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling PublicCollectionManagementApi.HttpCollectionsGetDescendantsTreeOfId: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the HttpCollectionsGetDescendantsTreeOfIdWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<List<Collection>> response = apiInstance.HttpCollectionsGetDescendantsTreeOfIdWithHttpInfo(id, translations, acceptLanguage);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling PublicCollectionManagementApi.HttpCollectionsGetDescendantsTreeOfIdWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **string** | The ID of the collection. |  |
| **translations** | **bool?** | When default language should be returned and the translation dictionary is delivered. (Ignores the \&quot;Accept-Language\&quot; header) | [optional]  |
| **acceptLanguage** | **string** | The requested language of the response. If not matching it falls back to default language. | [optional]  |

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

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="httpcollectionsgettreeancestorsofid"></a>
# **HttpCollectionsGetTreeAncestorsOfId**
> List&lt;Collection&gt; HttpCollectionsGetTreeAncestorsOfId (string id, bool? translations = null, string acceptLanguage = null)



Get the complete tree of ancestors from a single collection.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Agravity.Public.Api;
using Agravity.Public.Client;
using Agravity.Public.Model;

namespace Example
{
    public class HttpCollectionsGetTreeAncestorsOfIdExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost:7072/api";
            // Configure API key authorization: function_key
            config.AddApiKey("x-functions-key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("x-functions-key", "Bearer");

            var apiInstance = new PublicCollectionManagementApi(config);
            var id = "id_example";  // string | The ID of the collection.
            var translations = true;  // bool? | When default language should be returned and the translation dictionary is delivered. (Ignores the \"Accept-Language\" header) (optional) 
            var acceptLanguage = "acceptLanguage_example";  // string | The requested language of the response. If not matching it falls back to default language. (optional) 

            try
            {
                List<Collection> result = apiInstance.HttpCollectionsGetTreeAncestorsOfId(id, translations, acceptLanguage);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling PublicCollectionManagementApi.HttpCollectionsGetTreeAncestorsOfId: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the HttpCollectionsGetTreeAncestorsOfIdWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<List<Collection>> response = apiInstance.HttpCollectionsGetTreeAncestorsOfIdWithHttpInfo(id, translations, acceptLanguage);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling PublicCollectionManagementApi.HttpCollectionsGetTreeAncestorsOfIdWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **string** | The ID of the collection. |  |
| **translations** | **bool?** | When default language should be returned and the translation dictionary is delivered. (Ignores the \&quot;Accept-Language\&quot; header) | [optional]  |
| **acceptLanguage** | **string** | The requested language of the response. If not matching it falls back to default language. | [optional]  |

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

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="httpgetcollectionpreviewsbyid"></a>
# **HttpGetCollectionPreviewsById**
> string HttpGetCollectionPreviewsById (string id)



This endpoint returns a generated thumbnail as a preview of the containing assets.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Agravity.Public.Api;
using Agravity.Public.Client;
using Agravity.Public.Model;

namespace Example
{
    public class HttpGetCollectionPreviewsByIdExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost:7072/api";
            // Configure API key authorization: function_key
            config.AddApiKey("x-functions-key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("x-functions-key", "Bearer");

            var apiInstance = new PublicCollectionManagementApi(config);
            var id = "id_example";  // string | The ID of the collection.

            try
            {
                string result = apiInstance.HttpGetCollectionPreviewsById(id);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling PublicCollectionManagementApi.HttpGetCollectionPreviewsById: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the HttpGetCollectionPreviewsByIdWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<string> response = apiInstance.HttpGetCollectionPreviewsByIdWithHttpInfo(id);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling PublicCollectionManagementApi.HttpGetCollectionPreviewsByIdWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **string** | The ID of the collection. |  |

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

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="httppubliccollectionsdeletebyid"></a>
# **HttpPublicCollectionsDeleteById**
> void HttpPublicCollectionsDeleteById (string id, bool? deleteassets = null)



This endpoint deletes the collection with the given ID (and their siblings).

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Agravity.Public.Api;
using Agravity.Public.Client;
using Agravity.Public.Model;

namespace Example
{
    public class HttpPublicCollectionsDeleteByIdExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost:7072/api";
            // Configure API key authorization: function_key
            config.AddApiKey("x-functions-key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("x-functions-key", "Bearer");

            var apiInstance = new PublicCollectionManagementApi(config);
            var id = "id_example";  // string | The ID of the collection.
            var deleteassets = true;  // bool? | If this is true the assigned assets are set to delete as well. (optional) 

            try
            {
                apiInstance.HttpPublicCollectionsDeleteById(id, deleteassets);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling PublicCollectionManagementApi.HttpPublicCollectionsDeleteById: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the HttpPublicCollectionsDeleteByIdWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    apiInstance.HttpPublicCollectionsDeleteByIdWithHttpInfo(id, deleteassets);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling PublicCollectionManagementApi.HttpPublicCollectionsDeleteByIdWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **string** | The ID of the collection. |  |
| **deleteassets** | **bool?** | If this is true the assigned assets are set to delete as well. | [optional]  |

### Return type

void (empty response body)

### Authorization

[function_key](../README.md#function_key)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **400** | Collection with ID {id} is null or not a well formated collection id! (Code: 6e59a8c1-564a-411b-ad3b-3b0b78d80644)Collection with ID {id} is set as default import collection. Change the DEFAULT_IMPORT_COLLECTION_ID to another collection or DV (Default Value). (Code: c0c98df2-6f3d-481b-ae1d-89f60a86be68)&lt;br&gt; |  -  |
| **401** | Unauthorized. API Key not provided. |  -  |
| **204** | The delete operation of the collection with the given ID was successful. |  -  |
| **404** | If the collection with the ID was not found. |  -  |
| **403** | Not enough privileges to access item. |  -  |
| **500** | Internal server error. Please contact administrator. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="httppubliccollectionsupdatebyid"></a>
# **HttpPublicCollectionsUpdateById**
> Collection HttpPublicCollectionsUpdateById (string id, Collection collection, string acceptLanguage = null)



This endpoint updates the collection. Specific properties could be updated.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Agravity.Public.Api;
using Agravity.Public.Client;
using Agravity.Public.Model;

namespace Example
{
    public class HttpPublicCollectionsUpdateByIdExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost:7072/api";
            // Configure API key authorization: function_key
            config.AddApiKey("x-functions-key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("x-functions-key", "Bearer");

            var apiInstance = new PublicCollectionManagementApi(config);
            var id = "id_example";  // string | The ID of the collection.
            var collection = new Collection(); // Collection | The body has to be a valid collection json.Not fitting properties are ignored.
            var acceptLanguage = "acceptLanguage_example";  // string | The requested language of the response. If not matching it falls back to default language. (optional) 

            try
            {
                Collection result = apiInstance.HttpPublicCollectionsUpdateById(id, collection, acceptLanguage);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling PublicCollectionManagementApi.HttpPublicCollectionsUpdateById: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the HttpPublicCollectionsUpdateByIdWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<Collection> response = apiInstance.HttpPublicCollectionsUpdateByIdWithHttpInfo(id, collection, acceptLanguage);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling PublicCollectionManagementApi.HttpPublicCollectionsUpdateByIdWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **string** | The ID of the collection. |  |
| **collection** | [**Collection**](Collection.md) | The body has to be a valid collection json.Not fitting properties are ignored. |  |
| **acceptLanguage** | **string** | The requested language of the response. If not matching it falls back to default language. | [optional]  |

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
| **200** | Returns the updated collection and it includes all specific properties from collection type. |  -  |
| **400** | Object is not a valid collection json. Parse error. (Code: 6910ae7e-6aea-4f15-8773-1c168a66d61d)&lt;br&gt;Can not update. Item value of \&quot;{item.name}\&quot; is not of the correct type \&quot;{item.type}\&quot;. (Code: ec1aa2cd-65be-48b9-8972-002561bbe8ef)&lt;br&gt;Can not update. The item \&quot;{item.name}\&quot; is marked as mandatory but no value was given. (Code: 2955994d-010d-4b5c-88e0-af35da5f357f)&lt;br&gt;Validation error parent \&quot;{collection.parent}\&quot; not a collection GUID. (Code: d72d01f0-1809-41fe-85ea-0e423fc8e6f6)&lt;br&gt;Parent \&quot;{collection.parent}\&quot; is not allowed because it has different collection type. (Code: 7dadb5e1-6b2f-4649-bddc-e3bed033d79b)&lt;br&gt;Parent \&quot;{collection.parent}\&quot; for collection not found (Code: 7dadb5e1-6b2f-4649-bddc-e3bed033d79b)&lt;br&gt;Parent \&quot;{collection.parent}\&quot; must not be the same as the child. (Code: fb629d4f-4b1c-41e7-a589-f5da1e6fcaff)&lt;br&gt; |  -  |
| **401** | Unauthorized. API Key not provided. |  -  |
| **404** | If the asset with the ID was not found. |  -  |
| **403** | Not enough privileges to access item. |  -  |
| **500** | Internal server error. Please contact administrator. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="httppublicpostcollectionsgetbynames"></a>
# **HttpPublicPostCollectionsGetByNames**
> EntityListResult HttpPublicPostCollectionsGetByNames (EntityNamesRequest entityNamesRequest)



This endpoint fetches all collections based on names which comes from an array inside the POST request body and return another list of EntityIdName objects and an array of strings with the names which could not be found.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Agravity.Public.Api;
using Agravity.Public.Client;
using Agravity.Public.Model;

namespace Example
{
    public class HttpPublicPostCollectionsGetByNamesExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost:7072/api";
            // Configure API key authorization: function_key
            config.AddApiKey("x-functions-key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("x-functions-key", "Bearer");

            var apiInstance = new PublicCollectionManagementApi(config);
            var entityNamesRequest = new EntityNamesRequest(); // EntityNamesRequest | An object with the array of strings with names of the collections to fetch.

            try
            {
                EntityListResult result = apiInstance.HttpPublicPostCollectionsGetByNames(entityNamesRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling PublicCollectionManagementApi.HttpPublicPostCollectionsGetByNames: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the HttpPublicPostCollectionsGetByNamesWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<EntityListResult> response = apiInstance.HttpPublicPostCollectionsGetByNamesWithHttpInfo(entityNamesRequest);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling PublicCollectionManagementApi.HttpPublicPostCollectionsGetByNamesWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **entityNamesRequest** | [**EntityNamesRequest**](EntityNamesRequest.md) | An object with the array of strings with names of the collections to fetch. |  |

### Return type

[**EntityListResult**](EntityListResult.md)

### Authorization

[function_key](../README.md#function_key)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Returns an array of EntityIdName objects with the found collections and an array of strings with the names which could not be found. |  -  |
| **401** | Unauthorized. API Key not provided. |  -  |
| **400** | The request body is not a valid array of strings. |  -  |
| **500** | Internal server error. Please contact administrator. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

