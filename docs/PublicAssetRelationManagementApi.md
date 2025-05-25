# Agravity.Public.Api.PublicAssetRelationManagementApi

All URIs are relative to *http://localhost:7072/api*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**HttpAssetRelationCreate**](PublicAssetRelationManagementApi.md#httpassetrelationcreate) | **POST** /assetrelations |  |
| [**HttpAssetRelationDeleteById**](PublicAssetRelationManagementApi.md#httpassetrelationdeletebyid) | **DELETE** /assetrelations/{id} |  |
| [**HttpAssetRelationGetAll**](PublicAssetRelationManagementApi.md#httpassetrelationgetall) | **GET** /assetrelations |  |
| [**HttpAssetRelationGetById**](PublicAssetRelationManagementApi.md#httpassetrelationgetbyid) | **GET** /assetrelations/{id} |  |
| [**HttpAssetRelationUpdateById**](PublicAssetRelationManagementApi.md#httpassetrelationupdatebyid) | **POST** /assetrelations/{id} |  |

<a id="httpassetrelationcreate"></a>
# **HttpAssetRelationCreate**
> AssetRelation HttpAssetRelationCreate (bool? translations = null, string acceptLanguage = null, string assetrelationtypeid = null)



This endpoint creates one asset relation entry in the database.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Agravity.Public.Api;
using Agravity.Public.Client;
using Agravity.Public.Model;

namespace Example
{
    public class HttpAssetRelationCreateExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost:7072/api";
            // Configure API key authorization: function_key
            config.AddApiKey("x-functions-key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("x-functions-key", "Bearer");

            var apiInstance = new PublicAssetRelationManagementApi(config);
            var translations = true;  // bool? | When default language should be returned and the translation dictionary is delivered. (Ignores the \"Accept-Language\" header) (optional) 
            var acceptLanguage = "acceptLanguage_example";  // string | The requested language of the response. If not matching it falls back to default language. (optional) 
            var assetrelationtypeid = "assetrelationtypeid_example";  // string | The ID of the asset relation type, where these asset relations should come from. (optional) 

            try
            {
                AssetRelation result = apiInstance.HttpAssetRelationCreate(translations, acceptLanguage, assetrelationtypeid);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling PublicAssetRelationManagementApi.HttpAssetRelationCreate: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the HttpAssetRelationCreateWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<AssetRelation> response = apiInstance.HttpAssetRelationCreateWithHttpInfo(translations, acceptLanguage, assetrelationtypeid);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling PublicAssetRelationManagementApi.HttpAssetRelationCreateWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **translations** | **bool?** | When default language should be returned and the translation dictionary is delivered. (Ignores the \&quot;Accept-Language\&quot; header) | [optional]  |
| **acceptLanguage** | **string** | The requested language of the response. If not matching it falls back to default language. | [optional]  |
| **assetrelationtypeid** | **string** | The ID of the asset relation type, where these asset relations should come from. | [optional]  |

### Return type

[**AssetRelation**](AssetRelation.md)

### Authorization

[function_key](../README.md#function_key)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **201** | Returns the created asset relation. |  -  |
| **400** | Object is not a valid asset_relation. (Code: db336702-2654-4c87-8a17-38994ef5f812)&lt;br&gt;No input object given. (Code: 24897b5c-4322-4303-af28-578f374a17a0)&lt;br&gt;Missing or invalid parameter \&quot;assetrelationtypeid\&quot; (Code: a0a5b486-972b-44c2-9378-96fc437c91ad)&lt;br&gt;Asset relation type not found. (Code: 33766cf4-d135-452b-9767-eb2171c5f258)&lt;br&gt;Asset relation must have at least two different assets. (Code: 5519ac52-aac3-49e4-9cde-925b1ac4e691)&lt;br&gt;Asset with ID {assetId} not found. (Code: 4fc224fb-6e5f-4ca0-b93d-f693a223a740)&lt;br&gt;The user does not have editor permission on all assets in the relation. (Code: 5179e72a-a72e-4731-a476-2de784703315)&lt;br&gt;For hierarchical relations, exactly one asset must be marked as parent. (Code: 1a9d8c7b-6e5f-3a2d-1b8c-7e6f5d4a3b2c)&lt;br&gt;Error on create asset relation in database - max retry count is reached. (Code: 7af65a99-32d8-4e98-b96b-00cd8649fc53)&lt;br&gt;The user does not have editor permission on the relation type. (Code: 63cad31c-ed36-4e1e-add4-349782019b68)&lt;br&gt;The asset relation contains assets that are already part of another relation of the same type. (Code: d3a34fc8-e658-487f-b224-5da2d0843ee1) |  -  |
| **401** | Unauthorized. API Key not provided. |  -  |
| **500** | Internal server error. Please contact administrator. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="httpassetrelationdeletebyid"></a>
# **HttpAssetRelationDeleteById**
> void HttpAssetRelationDeleteById (string id)



This endpoint deletes a single asset relation.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Agravity.Public.Api;
using Agravity.Public.Client;
using Agravity.Public.Model;

namespace Example
{
    public class HttpAssetRelationDeleteByIdExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost:7072/api";
            // Configure API key authorization: function_key
            config.AddApiKey("x-functions-key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("x-functions-key", "Bearer");

            var apiInstance = new PublicAssetRelationManagementApi(config);
            var id = "id_example";  // string | The ID of the asset relation.

            try
            {
                apiInstance.HttpAssetRelationDeleteById(id);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling PublicAssetRelationManagementApi.HttpAssetRelationDeleteById: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the HttpAssetRelationDeleteByIdWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    apiInstance.HttpAssetRelationDeleteByIdWithHttpInfo(id);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling PublicAssetRelationManagementApi.HttpAssetRelationDeleteByIdWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **string** | The ID of the asset relation. |  |

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
| **400** | Error on deleting asset relation ({id}) database - max retry count is reached. (Code: 9d8c7b6a-5e4f-3a2d-1b8c-7e6f5d4a3b2c)&lt;br&gt;Asset relation type not found. (Code: 33766cf4-d135-452b-9767-eb2171c5f258)&lt;br&gt;The user does not have editor permission on the relation type. (Code: 3da4bd72-e810-46e5-a4ee-8fa2bd2dce32) |  -  |
| **401** | Unauthorized. API Key not provided. |  -  |
| **204** | The delete operation of the asset relation with the given ID was successful. |  -  |
| **404** | The requested item could not be found. |  -  |
| **500** | Internal server error. Please contact administrator. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="httpassetrelationgetall"></a>
# **HttpAssetRelationGetAll**
> List&lt;AssetRelation&gt; HttpAssetRelationGetAll (string assetrelationtypeid = null, string acceptLanguage = null, bool? translations = null)



This endpoint lists all asset relations in database.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Agravity.Public.Api;
using Agravity.Public.Client;
using Agravity.Public.Model;

namespace Example
{
    public class HttpAssetRelationGetAllExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost:7072/api";
            // Configure API key authorization: function_key
            config.AddApiKey("x-functions-key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("x-functions-key", "Bearer");

            var apiInstance = new PublicAssetRelationManagementApi(config);
            var assetrelationtypeid = "assetrelationtypeid_example";  // string | The ID of the asset relation type, where these asset relations should come from. (optional) 
            var acceptLanguage = "acceptLanguage_example";  // string | The requested language of the response. If not matching it falls back to default language. (optional) 
            var translations = true;  // bool? | When default language should be returned and the translation dictionary is delivered. (Ignores the \"Accept-Language\" header) (optional) 

            try
            {
                List<AssetRelation> result = apiInstance.HttpAssetRelationGetAll(assetrelationtypeid, acceptLanguage, translations);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling PublicAssetRelationManagementApi.HttpAssetRelationGetAll: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the HttpAssetRelationGetAllWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<List<AssetRelation>> response = apiInstance.HttpAssetRelationGetAllWithHttpInfo(assetrelationtypeid, acceptLanguage, translations);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling PublicAssetRelationManagementApi.HttpAssetRelationGetAllWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **assetrelationtypeid** | **string** | The ID of the asset relation type, where these asset relations should come from. | [optional]  |
| **acceptLanguage** | **string** | The requested language of the response. If not matching it falls back to default language. | [optional]  |
| **translations** | **bool?** | When default language should be returned and the translation dictionary is delivered. (Ignores the \&quot;Accept-Language\&quot; header) | [optional]  |

### Return type

[**List&lt;AssetRelation&gt;**](AssetRelation.md)

### Authorization

[function_key](../README.md#function_key)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Returns all asset relations in database. |  -  |
| **400** | Invalid parameter \&quot;assetrelationtypeid\&quot;. (Code: 16e4697f-5ba6-4dea-a51a-c2e08eff5faa)&lt;br&gt;Asset relation type not found. (Code: 33766cf4-d135-452b-9767-eb2171c5f258) |  -  |
| **401** | Unauthorized. API Key not provided. |  -  |
| **500** | Internal server error. Please contact administrator. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="httpassetrelationgetbyid"></a>
# **HttpAssetRelationGetById**
> AssetRelation HttpAssetRelationGetById (string id, bool? translations = null)



This endpoint gets a single asset relation.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Agravity.Public.Api;
using Agravity.Public.Client;
using Agravity.Public.Model;

namespace Example
{
    public class HttpAssetRelationGetByIdExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost:7072/api";
            // Configure API key authorization: function_key
            config.AddApiKey("x-functions-key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("x-functions-key", "Bearer");

            var apiInstance = new PublicAssetRelationManagementApi(config);
            var id = "id_example";  // string | The ID of the asset relation.
            var translations = true;  // bool? | When default language should be returned and the translation dictionary is delivered. (Ignores the \"Accept-Language\" header) (optional) 

            try
            {
                AssetRelation result = apiInstance.HttpAssetRelationGetById(id, translations);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling PublicAssetRelationManagementApi.HttpAssetRelationGetById: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the HttpAssetRelationGetByIdWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<AssetRelation> response = apiInstance.HttpAssetRelationGetByIdWithHttpInfo(id, translations);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling PublicAssetRelationManagementApi.HttpAssetRelationGetByIdWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **string** | The ID of the asset relation. |  |
| **translations** | **bool?** | When default language should be returned and the translation dictionary is delivered. (Ignores the \&quot;Accept-Language\&quot; header) | [optional]  |

### Return type

[**AssetRelation**](AssetRelation.md)

### Authorization

[function_key](../README.md#function_key)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Returns the requested asset relation. |  -  |
| **400** | Asset relation type not found. (Code: 33766cf4-d135-452b-9767-eb2171c5f258)&lt;br&gt;The user does not have editor permission on the relation type. (Code: 63cad31c-ed36-4e1e-add4-349782019b68) |  -  |
| **401** | Unauthorized. API Key not provided. |  -  |
| **404** | The requested item could not be found. |  -  |
| **500** | Internal server error. Please contact administrator. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="httpassetrelationupdatebyid"></a>
# **HttpAssetRelationUpdateById**
> AssetRelation HttpAssetRelationUpdateById (string id, AssetRelation assetRelation, bool? translations = null, string acceptLanguage = null)



This endpoint updates an asset relation entry in the database.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Agravity.Public.Api;
using Agravity.Public.Client;
using Agravity.Public.Model;

namespace Example
{
    public class HttpAssetRelationUpdateByIdExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost:7072/api";
            // Configure API key authorization: function_key
            config.AddApiKey("x-functions-key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("x-functions-key", "Bearer");

            var apiInstance = new PublicAssetRelationManagementApi(config);
            var id = "id_example";  // string | The ID of the asset relation.
            var assetRelation = new AssetRelation(); // AssetRelation | This endpoint updates an asset relation with ID in the database.
            var translations = true;  // bool? | When default language should be returned and the translation dictionary is delivered. (Ignores the \"Accept-Language\" header) (optional) 
            var acceptLanguage = "acceptLanguage_example";  // string | The requested language of the response. If not matching it falls back to default language. (optional) 

            try
            {
                AssetRelation result = apiInstance.HttpAssetRelationUpdateById(id, assetRelation, translations, acceptLanguage);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling PublicAssetRelationManagementApi.HttpAssetRelationUpdateById: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the HttpAssetRelationUpdateByIdWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<AssetRelation> response = apiInstance.HttpAssetRelationUpdateByIdWithHttpInfo(id, assetRelation, translations, acceptLanguage);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling PublicAssetRelationManagementApi.HttpAssetRelationUpdateByIdWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **string** | The ID of the asset relation. |  |
| **assetRelation** | [**AssetRelation**](AssetRelation.md) | This endpoint updates an asset relation with ID in the database. |  |
| **translations** | **bool?** | When default language should be returned and the translation dictionary is delivered. (Ignores the \&quot;Accept-Language\&quot; header) | [optional]  |
| **acceptLanguage** | **string** | The requested language of the response. If not matching it falls back to default language. | [optional]  |

### Return type

[**AssetRelation**](AssetRelation.md)

### Authorization

[function_key](../README.md#function_key)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Returns the updated asset relation. |  -  |
| **400** | Object is not a valid asset_relation. (Code: 6c5b4a9d-8e7f-3a2d-1b8c-7e6f5d4a3b2c)&lt;br&gt;No input object given. (Code: 5b4a9d8c-7e6f-3a2d-1b8c-7e6f5d4a3b2c)&lt;br&gt;Asset relation must have at least two different assets. (Code: 4a9d8c7b-6e5f-3a2d-1b8c-7e6f5d4a3b2c)&lt;br&gt;Asset with ID {assetId} not found. (Code: 3a9d8c7b-6e5f-3a2d-1b8c-7e6f5d4a3b2c)&lt;br&gt;The user does not have editor permission on all assets in the relation. (Code: 2a9d8c7b-6e5f-3a2d-1b8c-7e6f5d4a3b2c)&lt;br&gt;For hierarchical relations, exactly one asset must be marked as parent. (Code: 1a9d8c7b-6e5f-3a2d-1b8c-7e6f5d4a3b2c)&lt;br&gt;The user does not have editor permission on the relation type. (Code: 63cad31c-ed36-4e1e-add4-349782019b68)&lt;br&gt;The asset relation contains assets that are already part of another relation of the same type. (Code: b08c7606-ff7d-4b81-90ad-5d94f32cb7be) |  -  |
| **401** | Unauthorized. API Key not provided. |  -  |
| **404** | The requested item could not be found. |  -  |
| **500** | Internal server error. Please contact administrator. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

