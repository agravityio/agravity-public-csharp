# Agravity.Public.Api.CollectionManagementApi

All URIs are relative to *http://localhost:7071/api*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**HttpCollectionsCreate**](CollectionManagementApi.md#httpcollectionscreate) | **POST** /collections |  |
| [**HttpCollectionsDeleteById**](CollectionManagementApi.md#httpcollectionsdeletebyid) | **DELETE** /collections/{id} |  |
| [**HttpCollectionsGet**](CollectionManagementApi.md#httpcollectionsget) | **GET** /collections |  |
| [**HttpCollectionsGetById**](CollectionManagementApi.md#httpcollectionsgetbyid) | **GET** /collections/{id} |  |
| [**HttpCollectionsGetDescendantsTreeOfId**](CollectionManagementApi.md#httpcollectionsgetdescendantstreeofid) | **GET** /collections/{id}/descendants |  |
| [**HttpCollectionsGetTreeAncestorsOfId**](CollectionManagementApi.md#httpcollectionsgettreeancestorsofid) | **GET** /collections/{id}/ancestors |  |
| [**HttpCollectionsUpdateById**](CollectionManagementApi.md#httpcollectionsupdatebyid) | **POST** /collections/{id} |  |
| [**HttpGetCollectionPreviewsById**](CollectionManagementApi.md#httpgetcollectionpreviewsbyid) | **GET** /collections/{id}/previews |  |
| [**HttpPatchCollectionRepair**](CollectionManagementApi.md#httppatchcollectionrepair) | **PATCH** /collections/{id}/repair |  |

<a id="httpcollectionscreate"></a>
# **HttpCollectionsCreate**
> Collection HttpCollectionsCreate (string collectiontypeid, Collection collection, bool? translations = null, string acceptLanguage = null)



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
            config.BasePath = "http://localhost:7071/api";
            // Configure OAuth2 access token for authorization: msal_auth
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new CollectionManagementApi(config);
            var collectiontypeid = "collectiontypeid_example";  // string | The ID of the collection type where this collections should be assigned.
            var collection = new Collection(); // Collection | This endpoint creates a unique collection ID and adds the information to the database.
            var translations = true;  // bool? | When default language should be returned and the translation dictionary is delivered. (Ignores the \"Accept-Language\" header) (optional) 
            var acceptLanguage = "acceptLanguage_example";  // string | The requested language of the response. If not matching it falls back to default language. (optional) 

            try
            {
                Collection result = apiInstance.HttpCollectionsCreate(collectiontypeid, collection, translations, acceptLanguage);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling CollectionManagementApi.HttpCollectionsCreate: " + e.Message);
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
    ApiResponse<Collection> response = apiInstance.HttpCollectionsCreateWithHttpInfo(collectiontypeid, collection, translations, acceptLanguage);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling CollectionManagementApi.HttpCollectionsCreateWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **collectiontypeid** | **string** | The ID of the collection type where this collections should be assigned. |  |
| **collection** | [**Collection**](Collection.md) | This endpoint creates a unique collection ID and adds the information to the database. |  |
| **translations** | **bool?** | When default language should be returned and the translation dictionary is delivered. (Ignores the \&quot;Accept-Language\&quot; header) | [optional]  |
| **acceptLanguage** | **string** | The requested language of the response. If not matching it falls back to default language. | [optional]  |

### Return type

**Collection**

### Authorization

[msal_auth](../README.md#msal_auth)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **201** | Returns the created collection. |  -  |
| **400** | A parameter is null. (Code: 7dac18af-04ef-4da6-8b6e-e13dd8b027ae)&lt;br&gt;Missing or invalid parameter \&quot;collectiontypeid\&quot;. (Code: 42a54d68-8a33-4a71-9545-7460f7a1339d)&lt;br&gt;The collection type \&quot;collectiontypeid\&quot; was not found. (Code: 203b1950-d942-4692-8e55-0ec5c137167f)&lt;/br&gt;Property &#39;&lt;item_name&gt;&#39; is not of defined type: &lt;type&gt; (Code: 1e9a1470-cfba-4a56-97b0-c44f77671880)&lt;br&gt;Not valid collection id. (Code: 61a99ef3-c212-4171-8b37-290d8db4af3c)&lt;br&gt;Can not create collection with id {input.Id}. Collection already exists. Delete first. (Code: 321c4f48-7cc9-4ece-af88-89e95031dfde)&lt;br&gt;Object is not a valid collection. (Code: 67dd9a9f-b899-4607-bce8-0b0c4b4eec66) |  -  |
| **500** | Internal server error. Please contact administrator. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="httpcollectionsdeletebyid"></a>
# **HttpCollectionsDeleteById**
> void HttpCollectionsDeleteById (string id, bool? deleteassets = null)



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
    public class HttpCollectionsDeleteByIdExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost:7071/api";
            // Configure OAuth2 access token for authorization: msal_auth
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new CollectionManagementApi(config);
            var id = "id_example";  // string | The ID of the collection.
            var deleteassets = true;  // bool? | If this is true the assigned assets are set to delete as well. (optional) 

            try
            {
                apiInstance.HttpCollectionsDeleteById(id, deleteassets);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling CollectionManagementApi.HttpCollectionsDeleteById: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the HttpCollectionsDeleteByIdWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    apiInstance.HttpCollectionsDeleteByIdWithHttpInfo(id, deleteassets);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling CollectionManagementApi.HttpCollectionsDeleteByIdWithHttpInfo: " + e.Message);
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

[msal_auth](../README.md#msal_auth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **400** | Collection with ID {id} is null or not a well formated collection id! (Code: 6e59a8c1-564a-411b-ad3b-3b0b78d80644)Collection with ID {id} is set as default import collection. Change the DEFAULT_IMPORT_COLLECTION_ID to another collection or DV (Default Value). (Code: c0c98df2-6f3d-481b-ae1d-89f60a86be68)&lt;br&gt; |  -  |
| **204** | The delete operation of the collection with the given ID was successful. |  -  |
| **404** | If the collection with the ID was not found. |  -  |
| **401** | Unauthorized. Bearer Token not provided. |  -  |
| **403** | Not enough privileges to access item. |  -  |
| **500** | Internal server error. Please contact administrator. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="httpcollectionsget"></a>
# **HttpCollectionsGet**
> List&lt;Collection&gt; HttpCollectionsGet (string collectiontypeid = null, int? level = null, string parentid = null, string fields = null, bool? items = null, bool? translations = null, string acceptLanguage = null)



This endpoint lists all the collections, which are stored in the database and not deleted (status \"A\")

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
            config.BasePath = "http://localhost:7071/api";
            // Configure OAuth2 access token for authorization: msal_auth
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new CollectionManagementApi(config);
            var collectiontypeid = "collectiontypeid_example";  // string | The ID of the collection type, where these collections should come from. (optional) 
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
                Debug.Print("Exception when calling CollectionManagementApi.HttpCollectionsGet: " + e.Message);
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
    Debug.Print("Exception when calling CollectionManagementApi.HttpCollectionsGetWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **collectiontypeid** | **string** | The ID of the collection type, where these collections should come from. | [optional]  |
| **level** | **int?** | The hierarchy level of collections which should be returned. | [optional]  |
| **parentid** | **string** | The ID of the parent collection which should be queried. (No collectiontypeid is required) | [optional]  |
| **fields** | **string** | This limits the fields which are returned, separated by comma (&#39;,&#39;). | [optional]  |
| **items** | **bool?** | The items can be extended to fully filled items. | [optional]  |
| **translations** | **bool?** | When default language should be returned and the translation dictionary is delivered. (Ignores the \&quot;Accept-Language\&quot; header) | [optional]  |
| **acceptLanguage** | **string** | The requested language of the response. If not matching it falls back to default language. | [optional]  |

### Return type

**List<Collection>**

### Authorization

[msal_auth](../README.md#msal_auth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Returns all collections as array, except deleted collections. |  -  |
| **400** | Level {level} not a positive number. (Code: 757f7df3-3556-4c59-b5ac-9c7bfda6c3d4)&lt;br&gt;Level {levelQuery} not a number. (Code: 37959658-2201-4d4a-9bb5-f59870f4ec26)&lt;br&gt;Parent &#39;{parentQuery}&#39; not a valid collection ID. (Code: 6bac9ba8-d021-4b87-aba3-70faec968838) |  -  |
| **401** | Unauthorized. Bearer Token not provided. |  -  |
| **500** | Internal server error. Please contact administrator. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="httpcollectionsgetbyid"></a>
# **HttpCollectionsGetById**
> Collection HttpCollectionsGetById (string id, string fields = null, bool? items = null, bool? translations = null, string acceptLanguage = null)



This endpoint returns one single collection (from ID). This will include all specific properties from collection type.

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
            config.BasePath = "http://localhost:7071/api";
            // Configure OAuth2 access token for authorization: msal_auth
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new CollectionManagementApi(config);
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
                Debug.Print("Exception when calling CollectionManagementApi.HttpCollectionsGetById: " + e.Message);
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
    Debug.Print("Exception when calling CollectionManagementApi.HttpCollectionsGetByIdWithHttpInfo: " + e.Message);
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

[msal_auth](../README.md#msal_auth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Returns the collection with the given ID. |  -  |
| **404** | If the collection with the ID was not found. |  -  |
| **401** | Unauthorized. Bearer Token not provided. |  -  |
| **500** | Internal server error. Please contact administrator. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="httpcollectionsgetdescendantstreeofid"></a>
# **HttpCollectionsGetDescendantsTreeOfId**
> List&lt;Collection&gt; HttpCollectionsGetDescendantsTreeOfId (string id, bool? translations = null, string acceptLanguage = null)



This endpoint returns the complete tree of descendants from a single collection.

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
            config.BasePath = "http://localhost:7071/api";
            // Configure OAuth2 access token for authorization: msal_auth
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new CollectionManagementApi(config);
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
                Debug.Print("Exception when calling CollectionManagementApi.HttpCollectionsGetDescendantsTreeOfId: " + e.Message);
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
    Debug.Print("Exception when calling CollectionManagementApi.HttpCollectionsGetDescendantsTreeOfIdWithHttpInfo: " + e.Message);
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

[msal_auth](../README.md#msal_auth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Returns the array of descendants collections from the given collection in order by path. |  -  |
| **400** | Given collection id is not valid! (Code: 3f9fda3a-8911-45de-a4a0-34ea9e71e72d) |  -  |
| **404** | If the collection with the ID was not found. |  -  |
| **401** | Unauthorized. Bearer Token not provided. |  -  |
| **403** | Not enough privileges to access item. |  -  |
| **500** | Internal server error. Please contact administrator. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="httpcollectionsgettreeancestorsofid"></a>
# **HttpCollectionsGetTreeAncestorsOfId**
> List&lt;Collection&gt; HttpCollectionsGetTreeAncestorsOfId (string id, bool? translations = null, string acceptLanguage = null)



This endpoint returns the complete tree of ancestors from a single collection.

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
            config.BasePath = "http://localhost:7071/api";
            // Configure OAuth2 access token for authorization: msal_auth
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new CollectionManagementApi(config);
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
                Debug.Print("Exception when calling CollectionManagementApi.HttpCollectionsGetTreeAncestorsOfId: " + e.Message);
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
    Debug.Print("Exception when calling CollectionManagementApi.HttpCollectionsGetTreeAncestorsOfIdWithHttpInfo: " + e.Message);
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

[msal_auth](../README.md#msal_auth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Returns the array of ancestors collections from the given collection in order by path. |  -  |
| **400** | Given collection id is not valid! (Code: 1f07346f-25a5-4338-9f83-cf96cc7af67d) |  -  |
| **404** | If the collection with the ID was not found. |  -  |
| **401** | Unauthorized. Bearer Token not provided. |  -  |
| **403** | Not enough privileges to access item. |  -  |
| **500** | Internal server error. Please contact administrator. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="httpcollectionsupdatebyid"></a>
# **HttpCollectionsUpdateById**
> Collection HttpCollectionsUpdateById (string id, Collection collection, bool? translations = null, string acceptLanguage = null)



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
    public class HttpCollectionsUpdateByIdExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost:7071/api";
            // Configure OAuth2 access token for authorization: msal_auth
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new CollectionManagementApi(config);
            var id = "id_example";  // string | The ID of the collection.
            var collection = new Collection(); // Collection | The body has to be a valid collection json.Not fitting properties are ignored.
            var translations = true;  // bool? | When default language should be returned and the translation dictionary is delivered. (Ignores the \"Accept-Language\" header) (optional) 
            var acceptLanguage = "acceptLanguage_example";  // string | The requested language of the response. If not matching it falls back to default language. (optional) 

            try
            {
                Collection result = apiInstance.HttpCollectionsUpdateById(id, collection, translations, acceptLanguage);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling CollectionManagementApi.HttpCollectionsUpdateById: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the HttpCollectionsUpdateByIdWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<Collection> response = apiInstance.HttpCollectionsUpdateByIdWithHttpInfo(id, collection, translations, acceptLanguage);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling CollectionManagementApi.HttpCollectionsUpdateByIdWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **string** | The ID of the collection. |  |
| **collection** | [**Collection**](Collection.md) | The body has to be a valid collection json.Not fitting properties are ignored. |  |
| **translations** | **bool?** | When default language should be returned and the translation dictionary is delivered. (Ignores the \&quot;Accept-Language\&quot; header) | [optional]  |
| **acceptLanguage** | **string** | The requested language of the response. If not matching it falls back to default language. | [optional]  |

### Return type

**Collection**

### Authorization

[msal_auth](../README.md#msal_auth)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Returns the updated collection and it includes all specific properties from collection type. |  -  |
| **400** | Object is not a valid collection json. Parse error. (Code: 6910ae7e-6aea-4f15-8773-1c168a66d61d)&lt;br&gt;Can not update. Item value of \&quot;{item.name}\&quot; is not of the correct type \&quot;{item.type}\&quot;. (Code: ec1aa2cd-65be-48b9-8972-002561bbe8ef)&lt;br&gt;Can not update. The item \&quot;{item.name}\&quot; is marked as mandatory but no value was given. (Code: 2955994d-010d-4b5c-88e0-af35da5f357f)&lt;br&gt;Validation error parent \&quot;{collection.parent}\&quot; not a collection GUID. (Code: d72d01f0-1809-41fe-85ea-0e423fc8e6f6)&lt;br&gt;Parent \&quot;{collection.parent}\&quot; is not allowed because it has different collection type. (Code: 7dadb5e1-6b2f-4649-bddc-e3bed033d79b)&lt;br&gt;Parent \&quot;{collection.parent}\&quot; for collection not found (Code: 7dadb5e1-6b2f-4649-bddc-e3bed033d79b)&lt;br&gt;Parent \&quot;{collection.parent}\&quot; must not be the same as the child. (Code: fb629d4f-4b1c-41e7-a589-f5da1e6fcaff)&lt;br&gt; |  -  |
| **404** | If the asset with the ID was not found. |  -  |
| **401** | Unauthorized. Bearer Token not provided. |  -  |
| **403** | Not enough privileges to access item. |  -  |
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
            config.BasePath = "http://localhost:7071/api";
            // Configure OAuth2 access token for authorization: msal_auth
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new CollectionManagementApi(config);
            var id = "id_example";  // string | The ID of the collection.

            try
            {
                string result = apiInstance.HttpGetCollectionPreviewsById(id);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling CollectionManagementApi.HttpGetCollectionPreviewsById: " + e.Message);
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
    Debug.Print("Exception when calling CollectionManagementApi.HttpGetCollectionPreviewsByIdWithHttpInfo: " + e.Message);
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

[msal_auth](../README.md#msal_auth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: image/png


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Returns a generated png image as byte array. |  -  |
| **404** | If the collection with the ID was not found. |  -  |
| **401** | Unauthorized. Bearer Token not provided. |  -  |
| **403** | Not enough privileges to access item. |  -  |
| **500** | Internal server error. Please contact administrator. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="httppatchcollectionrepair"></a>
# **HttpPatchCollectionRepair**
> AgravityInfoResponse HttpPatchCollectionRepair (string id)



This endpoint repairs the items of an collection. Checks all collection type items and assign it to collection.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Agravity.Public.Api;
using Agravity.Public.Client;
using Agravity.Public.Model;

namespace Example
{
    public class HttpPatchCollectionRepairExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost:7071/api";
            // Configure OAuth2 access token for authorization: msal_auth
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new CollectionManagementApi(config);
            var id = "id_example";  // string | The ID of the collection.

            try
            {
                AgravityInfoResponse result = apiInstance.HttpPatchCollectionRepair(id);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling CollectionManagementApi.HttpPatchCollectionRepair: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the HttpPatchCollectionRepairWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<AgravityInfoResponse> response = apiInstance.HttpPatchCollectionRepairWithHttpInfo(id);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling CollectionManagementApi.HttpPatchCollectionRepairWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **string** | The ID of the collection. |  |

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
| **200** | The successful message which collection was repaired. (Code: b251f6c8-20ac-482b-a578-76ca209c3b22)&lt;br&gt;Or the message that this collection does not needed to be repaired (Code: b82055c4-f072-49e4-822f-7d226cb1c899) |  -  |
| **400** | A parameter is null. (Code: 49dc9df4-926a-49af-a718-807f8018d0cb) |  -  |
| **401** | Unauthorized. Bearer Token not provided. |  -  |
| **404** | The requested item could not be found |  -  |
| **500** | Internal server error. Please contact administrator. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

