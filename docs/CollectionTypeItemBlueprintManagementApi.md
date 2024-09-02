# Agravity.Public.Api.CollectionTypeItemBlueprintManagementApi

All URIs are relative to *http://localhost:7071/api*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**HttpCollTypeItemBlueprintsCreate**](CollectionTypeItemBlueprintManagementApi.md#httpcolltypeitemblueprintscreate) | **POST** /colltypeitemblueprints |  |
| [**HttpCollTypeItemBlueprintsDeleteById**](CollectionTypeItemBlueprintManagementApi.md#httpcolltypeitemblueprintsdeletebyid) | **DELETE** /colltypeitemblueprints/{id} |  |
| [**HttpCollTypeItemBlueprintsGetAll**](CollectionTypeItemBlueprintManagementApi.md#httpcolltypeitemblueprintsgetall) | **GET** /colltypeitemblueprints |  |
| [**HttpCollTypeItemBlueprintsUpdateById**](CollectionTypeItemBlueprintManagementApi.md#httpcolltypeitemblueprintsupdatebyid) | **POST** /colltypeitemblueprints/{id} |  |

<a id="httpcolltypeitemblueprintscreate"></a>
# **HttpCollTypeItemBlueprintsCreate**
> CollTypeItemBlueprint HttpCollTypeItemBlueprintsCreate (CollTypeItemBlueprint collTypeItemBlueprint, bool? translations = null, string acceptLanguage = null)



This endpoint creates one collection type item blueprint entry in the database.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Agravity.Public.Api;
using Agravity.Public.Client;
using Agravity.Public.Model;

namespace Example
{
    public class HttpCollTypeItemBlueprintsCreateExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost:7071/api";
            // Configure OAuth2 access token for authorization: msal_auth
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new CollectionTypeItemBlueprintManagementApi(config);
            var collTypeItemBlueprint = new CollTypeItemBlueprint(); // CollTypeItemBlueprint | This endpoint creates an unique blueprint and adds the information to the database.
            var translations = true;  // bool? | When default language should be returned and the translation dictionary is delivered. (Ignores the \"Accept-Language\" header) (optional) 
            var acceptLanguage = "acceptLanguage_example";  // string | The requested language of the response. If not matching it falls back to default language. (optional) 

            try
            {
                CollTypeItemBlueprint result = apiInstance.HttpCollTypeItemBlueprintsCreate(collTypeItemBlueprint, translations, acceptLanguage);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling CollectionTypeItemBlueprintManagementApi.HttpCollTypeItemBlueprintsCreate: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the HttpCollTypeItemBlueprintsCreateWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<CollTypeItemBlueprint> response = apiInstance.HttpCollTypeItemBlueprintsCreateWithHttpInfo(collTypeItemBlueprint, translations, acceptLanguage);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling CollectionTypeItemBlueprintManagementApi.HttpCollTypeItemBlueprintsCreateWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **collTypeItemBlueprint** | [**CollTypeItemBlueprint**](CollTypeItemBlueprint.md) | This endpoint creates an unique blueprint and adds the information to the database. |  |
| **translations** | **bool?** | When default language should be returned and the translation dictionary is delivered. (Ignores the \&quot;Accept-Language\&quot; header) | [optional]  |
| **acceptLanguage** | **string** | The requested language of the response. If not matching it falls back to default language. | [optional]  |

### Return type

[**CollTypeItemBlueprint**](CollTypeItemBlueprint.md)

### Authorization

[msal_auth](../README.md#msal_auth)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **201** | Returns the created blueprint. |  -  |
| **400** | A parameter is null. (Code: 22095cba-af4d-4c10-8ed0-4edf8f3cc6dc)&lt;br&gt;Object is not a valid collection type item blueprint (cti_blueprint). (Code: 20c226e2-18ad-4a48-a92b-572070d2e051)&lt;br&gt;Not valid colltypeitemblueprint id. (Code: 4dd2da34-b120-43a0-8160-fbc30bf35214)&lt;br&gt;Can not create colltypeitemblueprint with id {input.Id}. CollTypeItemBlueprint already exists. Delete first. (Code: 65597316-f283-4c6f-939a-c586b448c462)&lt;br&gt;No input object given. (Code: 27d5b414-1ca6-47c1-b963-e48f9b8b9f2a) |  -  |
| **401** | Unauthorized. Bearer Token not provided. |  -  |
| **500** | Internal server error. Please contact administrator. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="httpcolltypeitemblueprintsdeletebyid"></a>
# **HttpCollTypeItemBlueprintsDeleteById**
> void HttpCollTypeItemBlueprintsDeleteById (string id)



This endpoint deletes a single collection type item blueprint.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Agravity.Public.Api;
using Agravity.Public.Client;
using Agravity.Public.Model;

namespace Example
{
    public class HttpCollTypeItemBlueprintsDeleteByIdExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost:7071/api";
            // Configure OAuth2 access token for authorization: msal_auth
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new CollectionTypeItemBlueprintManagementApi(config);
            var id = "id_example";  // string | The ID of the blueprint.

            try
            {
                apiInstance.HttpCollTypeItemBlueprintsDeleteById(id);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling CollectionTypeItemBlueprintManagementApi.HttpCollTypeItemBlueprintsDeleteById: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the HttpCollTypeItemBlueprintsDeleteByIdWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    apiInstance.HttpCollTypeItemBlueprintsDeleteByIdWithHttpInfo(id);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling CollectionTypeItemBlueprintManagementApi.HttpCollTypeItemBlueprintsDeleteByIdWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **string** | The ID of the blueprint. |  |

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
| **400** | Error on deleting collection type item blueprint ({id}) database - max retry count is reached. (Code: 8f0d22db-7be1-4d88-8f5f-918e06b7ce2f) |  -  |
| **204** | The delete operation of the blueprint with the given ID was successful. |  -  |
| **404** | If the blueprint with the ID was not found. |  -  |
| **401** | Unauthorized. Bearer Token not provided. |  -  |
| **500** | Internal server error. Please contact administrator. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="httpcolltypeitemblueprintsgetall"></a>
# **HttpCollTypeItemBlueprintsGetAll**
> List&lt;CollTypeItemBlueprint&gt; HttpCollTypeItemBlueprintsGetAll (bool? translations = null, string acceptLanguage = null)



This endpoint lists all collection type item blueprint in database.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Agravity.Public.Api;
using Agravity.Public.Client;
using Agravity.Public.Model;

namespace Example
{
    public class HttpCollTypeItemBlueprintsGetAllExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost:7071/api";
            // Configure OAuth2 access token for authorization: msal_auth
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new CollectionTypeItemBlueprintManagementApi(config);
            var translations = true;  // bool? | When default language should be returned and the translation dictionary is delivered. (Ignores the \"Accept-Language\" header) (optional) 
            var acceptLanguage = "acceptLanguage_example";  // string | The requested language of the response. If not matching it falls back to default language. (optional) 

            try
            {
                List<CollTypeItemBlueprint> result = apiInstance.HttpCollTypeItemBlueprintsGetAll(translations, acceptLanguage);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling CollectionTypeItemBlueprintManagementApi.HttpCollTypeItemBlueprintsGetAll: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the HttpCollTypeItemBlueprintsGetAllWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<List<CollTypeItemBlueprint>> response = apiInstance.HttpCollTypeItemBlueprintsGetAllWithHttpInfo(translations, acceptLanguage);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling CollectionTypeItemBlueprintManagementApi.HttpCollTypeItemBlueprintsGetAllWithHttpInfo: " + e.Message);
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

[**List&lt;CollTypeItemBlueprint&gt;**](CollTypeItemBlueprint.md)

### Authorization

[msal_auth](../README.md#msal_auth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Returns all collection type item blueprint in database. |  -  |
| **401** | Unauthorized. Bearer Token not provided. |  -  |
| **500** | Internal server error. Please contact administrator. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="httpcolltypeitemblueprintsupdatebyid"></a>
# **HttpCollTypeItemBlueprintsUpdateById**
> CollTypeItemBlueprint HttpCollTypeItemBlueprintsUpdateById (string id, CollTypeItemBlueprint collTypeItemBlueprint, bool? translations = null, string acceptLanguage = null)



This endpoint updates a single collection type item blueprint.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Agravity.Public.Api;
using Agravity.Public.Client;
using Agravity.Public.Model;

namespace Example
{
    public class HttpCollTypeItemBlueprintsUpdateByIdExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost:7071/api";
            // Configure OAuth2 access token for authorization: msal_auth
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new CollectionTypeItemBlueprintManagementApi(config);
            var id = "id_example";  // string | The ID of the blueprint.
            var collTypeItemBlueprint = new CollTypeItemBlueprint(); // CollTypeItemBlueprint | This endpoint updates an the given blueprint with ID and adds the information to the database.
            var translations = true;  // bool? | When default language should be returned and the translation dictionary is delivered. (Ignores the \"Accept-Language\" header) (optional) 
            var acceptLanguage = "acceptLanguage_example";  // string | The requested language of the response. If not matching it falls back to default language. (optional) 

            try
            {
                CollTypeItemBlueprint result = apiInstance.HttpCollTypeItemBlueprintsUpdateById(id, collTypeItemBlueprint, translations, acceptLanguage);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling CollectionTypeItemBlueprintManagementApi.HttpCollTypeItemBlueprintsUpdateById: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the HttpCollTypeItemBlueprintsUpdateByIdWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<CollTypeItemBlueprint> response = apiInstance.HttpCollTypeItemBlueprintsUpdateByIdWithHttpInfo(id, collTypeItemBlueprint, translations, acceptLanguage);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling CollectionTypeItemBlueprintManagementApi.HttpCollTypeItemBlueprintsUpdateByIdWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **string** | The ID of the blueprint. |  |
| **collTypeItemBlueprint** | [**CollTypeItemBlueprint**](CollTypeItemBlueprint.md) | This endpoint updates an the given blueprint with ID and adds the information to the database. |  |
| **translations** | **bool?** | When default language should be returned and the translation dictionary is delivered. (Ignores the \&quot;Accept-Language\&quot; header) | [optional]  |
| **acceptLanguage** | **string** | The requested language of the response. If not matching it falls back to default language. | [optional]  |

### Return type

[**CollTypeItemBlueprint**](CollTypeItemBlueprint.md)

### Authorization

[msal_auth](../README.md#msal_auth)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **201** | Returns the updated blueprint. |  -  |
| **400** | Error on update collection type item blueprint ({id}) database - max retry count is reached. (Code: 8f0d22db-7be1-4d88-8f5f-918e06b7ce2f) |  -  |
| **404** | If the blueprint with the ID was not found. |  -  |
| **401** | Unauthorized. Bearer Token not provided. |  -  |
| **500** | Internal server error. Please contact administrator. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

