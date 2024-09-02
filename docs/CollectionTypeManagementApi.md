# Agravity.Public.Api.CollectionTypeManagementApi

All URIs are relative to *http://localhost:7071/api*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**HttpCollectionTypesCreate**](CollectionTypeManagementApi.md#httpcollectiontypescreate) | **POST** /collectiontypes |  |
| [**HttpCollectionTypesDelete**](CollectionTypeManagementApi.md#httpcollectiontypesdelete) | **DELETE** /collectiontypes/{id} |  |
| [**HttpCollectionTypesGet**](CollectionTypeManagementApi.md#httpcollectiontypesget) | **GET** /collectiontypes |  |
| [**HttpCollectionTypesGetById**](CollectionTypeManagementApi.md#httpcollectiontypesgetbyid) | **GET** /collectiontypes/{id} |  |
| [**HttpCollectionTypesUpdate**](CollectionTypeManagementApi.md#httpcollectiontypesupdate) | **POST** /collectiontypes/{id} |  |
| [**HttpCollectionTypesUpdatePermissionsById**](CollectionTypeManagementApi.md#httpcollectiontypesupdatepermissionsbyid) | **POST** /collectiontypes/{id}/permissions |  |
| [**HttpGetCollectionTypeItems**](CollectionTypeManagementApi.md#httpgetcollectiontypeitems) | **GET** /collectiontypesitems |  |
| [**HttpUpdateCollectionTypeItems**](CollectionTypeManagementApi.md#httpupdatecollectiontypeitems) | **POST** /collectiontypesitems |  |

<a id="httpcollectiontypescreate"></a>
# **HttpCollectionTypesCreate**
> CollectionType HttpCollectionTypesCreate (CollectionType collectionType, string workspaceid = null, bool? translations = null, string acceptLanguage = null)



This endpoint creates a unique collection type ID and adds the information to the database.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Agravity.Public.Api;
using Agravity.Public.Client;
using Agravity.Public.Model;

namespace Example
{
    public class HttpCollectionTypesCreateExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost:7071/api";
            // Configure OAuth2 access token for authorization: msal_auth
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new CollectionTypeManagementApi(config);
            var collectionType = new CollectionType(); // CollectionType | This endpoint creates a unique collection type ID and adds the information to the database.
            var workspaceid = "workspaceid_example";  // string | (optional) The ID of the workspace where this collection type should be assigned. (optional) 
            var translations = true;  // bool? | When default language should be returned and the translation dictionary is delivered. (Ignores the \"Accept-Language\" header) (optional) 
            var acceptLanguage = "acceptLanguage_example";  // string | The requested language of the response. If not matching it falls back to default language. (optional) 

            try
            {
                CollectionType result = apiInstance.HttpCollectionTypesCreate(collectionType, workspaceid, translations, acceptLanguage);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling CollectionTypeManagementApi.HttpCollectionTypesCreate: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the HttpCollectionTypesCreateWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<CollectionType> response = apiInstance.HttpCollectionTypesCreateWithHttpInfo(collectionType, workspaceid, translations, acceptLanguage);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling CollectionTypeManagementApi.HttpCollectionTypesCreateWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **collectionType** | [**CollectionType**](CollectionType.md) | This endpoint creates a unique collection type ID and adds the information to the database. |  |
| **workspaceid** | **string** | (optional) The ID of the workspace where this collection type should be assigned. | [optional]  |
| **translations** | **bool?** | When default language should be returned and the translation dictionary is delivered. (Ignores the \&quot;Accept-Language\&quot; header) | [optional]  |
| **acceptLanguage** | **string** | The requested language of the response. If not matching it falls back to default language. | [optional]  |

### Return type

[**CollectionType**](CollectionType.md)

### Authorization

[msal_auth](../README.md#msal_auth)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **201** | Returns the created collection type. |  -  |
| **400** | Invalid parameter \&quot;workspaceid\&quot;. (Code: 0ddcece3-2a70-438f-b05c-94188d3de591)&lt;br&gt;Object is not a valid collection type. (Code: e8732a28-b5c9-432a-afbd-5bc10b152682)&lt;br&gt;Collection type name must not be empty. (Code: 309fc1db-4030-491f-8c39-92590a55c6749)&lt;br&gt;Workspace with ID {workspaceId} does not exists. (Code: 019ad047-4bfa-4d98-a2b9-ad9dfeb4a954)&lt;br&gt;Item with ID {item.Id} not found. Needs to be created first. (Code: 75b56878-22a1-4abb-9662-98a98b84ef23)&lt;br&gt;Not valid collectiontype id. (Code: ea15a44c-0dc8-45e5-bb5a-f8f34edc2ef4)&lt;br&gt;Can not create collectiontype with id {input.Id}. CollectionType already exists. Delete first. (Code: 1b5722c7-23f6-4dd3-b693-459822e46f12)&lt;br&gt;errorMessage: Items malformed. Name empty, item already exists with different properties, default value wrong or type not of following types (Code: d7e89527-28fe-4a2c-8458-1db4894c1d03) |  -  |
| **401** | Unauthorized. Bearer Token not provided. |  -  |
| **500** | Internal server error. Please contact administrator. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="httpcollectiontypesdelete"></a>
# **HttpCollectionTypesDelete**
> void HttpCollectionTypesDelete (string id)



This endpoint deletes the collection type with the given ID.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Agravity.Public.Api;
using Agravity.Public.Client;
using Agravity.Public.Model;

namespace Example
{
    public class HttpCollectionTypesDeleteExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost:7071/api";
            // Configure OAuth2 access token for authorization: msal_auth
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new CollectionTypeManagementApi(config);
            var id = "id_example";  // string | The ID of the collection type.

            try
            {
                apiInstance.HttpCollectionTypesDelete(id);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling CollectionTypeManagementApi.HttpCollectionTypesDelete: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the HttpCollectionTypesDeleteWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    apiInstance.HttpCollectionTypesDeleteWithHttpInfo(id);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling CollectionTypeManagementApi.HttpCollectionTypesDeleteWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **string** | The ID of the collection type. |  |

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
| **400** | General error occured (See message)! (Code: df4fb84c-2974-4c3d-8ac9-2ff424bd11b0)Collection with ID {id} is set as default import collection. Change the DEFAULT_IMPORT_COLLECTION_ID to another collection or DV (Default Value). (Code: 31d0c6d3-4483-4e19-ad60-ad7515a4741a)&lt;br&gt; |  -  |
| **204** | The delete operation of the collection type with the given ID was successful. |  -  |
| **404** | If the collection type with the ID was not found. |  -  |
| **401** | Unauthorized. Bearer Token not provided. |  -  |
| **500** | Internal server error. Please contact administrator. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="httpcollectiontypesget"></a>
# **HttpCollectionTypesGet**
> List&lt;CollectionType&gt; HttpCollectionTypesGet (bool? translations = null, string acceptLanguage = null)



This endpoint lists all available collection types, which are stored in the database and not deleted (status \"A\").

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
            config.BasePath = "http://localhost:7071/api";
            // Configure OAuth2 access token for authorization: msal_auth
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new CollectionTypeManagementApi(config);
            var translations = true;  // bool? | When default language should be returned and the translation dictionary is delivered. (Ignores the \"Accept-Language\" header) (optional) 
            var acceptLanguage = "acceptLanguage_example";  // string | The requested language of the response. If not matching it falls back to default language. (optional) 

            try
            {
                List<CollectionType> result = apiInstance.HttpCollectionTypesGet(translations, acceptLanguage);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling CollectionTypeManagementApi.HttpCollectionTypesGet: " + e.Message);
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
    ApiResponse<List<CollectionType>> response = apiInstance.HttpCollectionTypesGetWithHttpInfo(translations, acceptLanguage);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling CollectionTypeManagementApi.HttpCollectionTypesGetWithHttpInfo: " + e.Message);
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

[**List&lt;CollectionType&gt;**](CollectionType.md)

### Authorization

[msal_auth](../README.md#msal_auth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Returns all collection types as array. |  -  |
| **400** | (Code: e244cef3-2665-4757-ba34-0d4d0e71bb9d) |  -  |
| **401** | Unauthorized. Bearer Token not provided. |  -  |
| **500** | Internal server error. Please contact administrator. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="httpcollectiontypesgetbyid"></a>
# **HttpCollectionTypesGetById**
> CollectionType HttpCollectionTypesGetById (string id, bool? translations = null, string acceptLanguage = null)



This endpoint returns one single collection type (from ID).

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
            config.BasePath = "http://localhost:7071/api";
            // Configure OAuth2 access token for authorization: msal_auth
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new CollectionTypeManagementApi(config);
            var id = "id_example";  // string | The ID of the collection type.
            var translations = true;  // bool? | When default language should be returned and the translation dictionary is delivered. (Ignores the \"Accept-Language\" header) (optional) 
            var acceptLanguage = "acceptLanguage_example";  // string | The requested language of the response. If not matching it falls back to default language. (optional) 

            try
            {
                CollectionType result = apiInstance.HttpCollectionTypesGetById(id, translations, acceptLanguage);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling CollectionTypeManagementApi.HttpCollectionTypesGetById: " + e.Message);
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
    ApiResponse<CollectionType> response = apiInstance.HttpCollectionTypesGetByIdWithHttpInfo(id, translations, acceptLanguage);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling CollectionTypeManagementApi.HttpCollectionTypesGetByIdWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **string** | The ID of the collection type. |  |
| **translations** | **bool?** | When default language should be returned and the translation dictionary is delivered. (Ignores the \&quot;Accept-Language\&quot; header) | [optional]  |
| **acceptLanguage** | **string** | The requested language of the response. If not matching it falls back to default language. | [optional]  |

### Return type

[**CollectionType**](CollectionType.md)

### Authorization

[msal_auth](../README.md#msal_auth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Returns the collection type with the requested ID. |  -  |
| **404** | The collection type with the ID was not found. |  -  |
| **401** | Unauthorized. Bearer Token not provided. |  -  |
| **500** | Internal server error. Please contact administrator. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="httpcollectiontypesupdate"></a>
# **HttpCollectionTypesUpdate**
> CollectionType HttpCollectionTypesUpdate (string id, CollectionType collectionType, bool? translations = null, string acceptLanguage = null)



This endpoint updates the collection type. Null fields will be ignored. If 'items' are set they are fully reset (like PUT).

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Agravity.Public.Api;
using Agravity.Public.Client;
using Agravity.Public.Model;

namespace Example
{
    public class HttpCollectionTypesUpdateExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost:7071/api";
            // Configure OAuth2 access token for authorization: msal_auth
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new CollectionTypeManagementApi(config);
            var id = "id_example";  // string | The ID of the collection type.
            var collectionType = new CollectionType(); // CollectionType | The body has to be a valid collection type json. Not fitting properties are ignored.
            var translations = true;  // bool? | When default language should be returned and the translation dictionary is delivered. (Ignores the \"Accept-Language\" header) (optional) 
            var acceptLanguage = "acceptLanguage_example";  // string | The requested language of the response. If not matching it falls back to default language. (optional) 

            try
            {
                CollectionType result = apiInstance.HttpCollectionTypesUpdate(id, collectionType, translations, acceptLanguage);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling CollectionTypeManagementApi.HttpCollectionTypesUpdate: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the HttpCollectionTypesUpdateWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<CollectionType> response = apiInstance.HttpCollectionTypesUpdateWithHttpInfo(id, collectionType, translations, acceptLanguage);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling CollectionTypeManagementApi.HttpCollectionTypesUpdateWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **string** | The ID of the collection type. |  |
| **collectionType** | [**CollectionType**](CollectionType.md) | The body has to be a valid collection type json. Not fitting properties are ignored. |  |
| **translations** | **bool?** | When default language should be returned and the translation dictionary is delivered. (Ignores the \&quot;Accept-Language\&quot; header) | [optional]  |
| **acceptLanguage** | **string** | The requested language of the response. If not matching it falls back to default language. | [optional]  |

### Return type

[**CollectionType**](CollectionType.md)

### Authorization

[msal_auth](../README.md#msal_auth)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Returns the updated full collection type incl. items. |  -  |
| **400** | A parameter is null. (Code: 079acaea-b257-4669-9621-99566889231e)&lt;br&gt;Object is not a valid collection type. (Code: 10e088c7-3ea1-4141-902a-4b5f6fad90ae)&lt;br&gt;Item {updated.Items[i].Name} malformed. Name empty, item already exists with different properties or type not of following types (Code: 4d6dcd3e-fb61-462b-b862-372968d6a768) |  -  |
| **401** | Unauthorized. Bearer Token not provided. |  -  |
| **404** | The requested item could not be found. |  -  |
| **500** | Internal server error. Please contact administrator. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="httpcollectiontypesupdatepermissionsbyid"></a>
# **HttpCollectionTypesUpdatePermissionsById**
> AgravityInfoResponse HttpCollectionTypesUpdatePermissionsById (string id, PermissionChange permissionChange)



This endpoint updates the permissions of the collection type. The modifier tells the system what to do with the list of ids.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Agravity.Public.Api;
using Agravity.Public.Client;
using Agravity.Public.Model;

namespace Example
{
    public class HttpCollectionTypesUpdatePermissionsByIdExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost:7071/api";
            // Configure OAuth2 access token for authorization: msal_auth
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new CollectionTypeManagementApi(config);
            var id = "id_example";  // string | The ID of the collection type.
            var permissionChange = new PermissionChange(); // PermissionChange | The changes which ids and how they should be added / removed / replaced / etc.

            try
            {
                AgravityInfoResponse result = apiInstance.HttpCollectionTypesUpdatePermissionsById(id, permissionChange);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling CollectionTypeManagementApi.HttpCollectionTypesUpdatePermissionsById: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the HttpCollectionTypesUpdatePermissionsByIdWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<AgravityInfoResponse> response = apiInstance.HttpCollectionTypesUpdatePermissionsByIdWithHttpInfo(id, permissionChange);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling CollectionTypeManagementApi.HttpCollectionTypesUpdatePermissionsByIdWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **string** | The ID of the collection type. |  |
| **permissionChange** | [**PermissionChange**](PermissionChange.md) | The changes which ids and how they should be added / removed / replaced / etc. |  |

### Return type

[**AgravityInfoResponse**](AgravityInfoResponse.md)

### Authorization

[msal_auth](../README.md#msal_auth)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Returns the info about the updated permissions. |  -  |
| **400** | Body is not a valid permission change object. (Code: 4a048f4b-c557-402d-a4ef-bd8558d58d75)&lt;br&gt;Object needs an body. (Code: 4f200eca-593b-4a1c-bc6e-9b9ad99bec8e)&lt;br&gt;The default collection type can not have any permissions. (Code: b4676c1d-3916-4e63-8322-52b589bec773) |  -  |
| **401** | Unauthorized. Bearer Token not provided. |  -  |
| **404** | The requested item could not be found. |  -  |
| **500** | Internal server error. Please contact administrator. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="httpgetcollectiontypeitems"></a>
# **HttpGetCollectionTypeItems**
> List&lt;CollTypeItem&gt; HttpGetCollectionTypeItems (bool? includeblueprint = null, bool? translations = null, string acceptLanguage = null)



This method returns a list of all collection types items. (Regardless of the permissions)

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
            config.BasePath = "http://localhost:7071/api";
            // Configure OAuth2 access token for authorization: msal_auth
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new CollectionTypeManagementApi(config);
            var includeblueprint = true;  // bool? | True if the blueprint items should be included. (optional) 
            var translations = true;  // bool? | When default language should be returned and the translation dictionary is delivered. (Ignores the \"Accept-Language\" header) (optional) 
            var acceptLanguage = "acceptLanguage_example";  // string | The requested language of the response. If not matching it falls back to default language. (optional) 

            try
            {
                List<CollTypeItem> result = apiInstance.HttpGetCollectionTypeItems(includeblueprint, translations, acceptLanguage);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling CollectionTypeManagementApi.HttpGetCollectionTypeItems: " + e.Message);
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
    ApiResponse<List<CollTypeItem>> response = apiInstance.HttpGetCollectionTypeItemsWithHttpInfo(includeblueprint, translations, acceptLanguage);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling CollectionTypeManagementApi.HttpGetCollectionTypeItemsWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **includeblueprint** | **bool?** | True if the blueprint items should be included. | [optional]  |
| **translations** | **bool?** | When default language should be returned and the translation dictionary is delivered. (Ignores the \&quot;Accept-Language\&quot; header) | [optional]  |
| **acceptLanguage** | **string** | The requested language of the response. If not matching it falls back to default language. | [optional]  |

### Return type

[**List&lt;CollTypeItem&gt;**](CollTypeItem.md)

### Authorization

[msal_auth](../README.md#msal_auth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | The collection types items for this item. |  -  |
| **401** | Unauthorized. Bearer Token not provided. |  -  |
| **404** | If the no collection type items were not found. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="httpupdatecollectiontypeitems"></a>
# **HttpUpdateCollectionTypeItems**
> List&lt;CollectionType&gt; HttpUpdateCollectionTypeItems (List<CollTypeItem> collTypeItem)



This endpoint updates all collection type items in all collection types regarding: Label, Order, Translations and Group

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Agravity.Public.Api;
using Agravity.Public.Client;
using Agravity.Public.Model;

namespace Example
{
    public class HttpUpdateCollectionTypeItemsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost:7071/api";
            // Configure OAuth2 access token for authorization: msal_auth
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new CollectionTypeManagementApi(config);
            var collTypeItem = new List<CollTypeItem>(); // List<CollTypeItem> | Items which should be updated.

            try
            {
                List<CollectionType> result = apiInstance.HttpUpdateCollectionTypeItems(collTypeItem);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling CollectionTypeManagementApi.HttpUpdateCollectionTypeItems: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the HttpUpdateCollectionTypeItemsWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<List<CollectionType>> response = apiInstance.HttpUpdateCollectionTypeItemsWithHttpInfo(collTypeItem);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling CollectionTypeManagementApi.HttpUpdateCollectionTypeItemsWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **collTypeItem** | [**List&lt;CollTypeItem&gt;**](CollTypeItem.md) | Items which should be updated. |  |

### Return type

[**List&lt;CollectionType&gt;**](CollectionType.md)

### Authorization

[msal_auth](../README.md#msal_auth)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | All affected collection types. |  -  |
| **401** | Unauthorized. Bearer Token not provided. |  -  |
| **404** | If the no collection type items were not found. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

