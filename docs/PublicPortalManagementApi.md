# Agravity.Public.Api.PublicPortalManagementApi

All URIs are relative to *http://localhost:7072/api*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**HttpPortalGetAllAssetIdsById**](PublicPortalManagementApi.md#httpportalgetallassetidsbyid) | **GET** /portals/{id}/assetids |  |
| [**HttpPortalGetStatusZipById**](PublicPortalManagementApi.md#httpportalgetstatuszipbyid) | **GET** /portals/{id}/zip/{zipId} |  |
| [**HttpPortalRequestZipById**](PublicPortalManagementApi.md#httpportalrequestzipbyid) | **POST** /portals/{id}/zip |  |
| [**HttpPortalsConfigurationGetById**](PublicPortalManagementApi.md#httpportalsconfigurationgetbyid) | **GET** /portals/{id}/config |  |
| [**HttpPortalsGetById**](PublicPortalManagementApi.md#httpportalsgetbyid) | **GET** /portals/{id} |  |

<a name="httpportalgetallassetidsbyid"></a>
# **HttpPortalGetAllAssetIdsById**
> List&lt;string&gt; HttpPortalGetAllAssetIdsById (string id)



This endpoint gets all Asset IDs in portal scope.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Agravity.Public.Api;
using Agravity.Public.Client;
using Agravity.Public.Model;

namespace Example
{
    public class HttpPortalGetAllAssetIdsByIdExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost:7072/api";
            // Configure API key authorization: function_key
            config.AddApiKey("x-functions-key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("x-functions-key", "Bearer");

            var apiInstance = new PublicPortalManagementApi(config);
            var id = "id_example";  // string | The ID of the portal.

            try
            {
                List<string> result = apiInstance.HttpPortalGetAllAssetIdsById(id);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling PublicPortalManagementApi.HttpPortalGetAllAssetIdsById: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the HttpPortalGetAllAssetIdsByIdWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<List<string>> response = apiInstance.HttpPortalGetAllAssetIdsByIdWithHttpInfo(id);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling PublicPortalManagementApi.HttpPortalGetAllAssetIdsByIdWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **string** | The ID of the portal. |  |

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
| **200** | Returns all Asset IDs in scope of the portal. |  -  |
| **400** | Portal ID is mandatory and not valid. (Code: f2817cb8-8573-4205-b45d-1b9a7f3d8cbb) |  -  |
| **401** | Unauthorized. API Key not provided. |  -  |
| **404** | The requested item could not be found. |  -  |
| **500** | Internal server error. Please contact administrator. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="httpportalgetstatuszipbyid"></a>
# **HttpPortalGetStatusZipById**
> PortalZipRequest HttpPortalGetStatusZipById (string id, string zipId)



This endpoint gets the progress/status of the ZIP creation of a portal.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Agravity.Public.Api;
using Agravity.Public.Client;
using Agravity.Public.Model;

namespace Example
{
    public class HttpPortalGetStatusZipByIdExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost:7072/api";
            // Configure API key authorization: function_key
            config.AddApiKey("x-functions-key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("x-functions-key", "Bearer");

            var apiInstance = new PublicPortalManagementApi(config);
            var id = "id_example";  // string | The ID of the zip request collection.
            var zipId = "zipId_example";  // string | The ID of the requested zip.

            try
            {
                PortalZipRequest result = apiInstance.HttpPortalGetStatusZipById(id, zipId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling PublicPortalManagementApi.HttpPortalGetStatusZipById: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the HttpPortalGetStatusZipByIdWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<PortalZipRequest> response = apiInstance.HttpPortalGetStatusZipByIdWithHttpInfo(id, zipId);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling PublicPortalManagementApi.HttpPortalGetStatusZipByIdWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **string** | The ID of the zip request collection. |  |
| **zipId** | **string** | The ID of the requested zip. |  |

### Return type

[**PortalZipRequest**](PortalZipRequest.md)

### Authorization

[function_key](../README.md#function_key)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Returns the zip request for a portal with the given ID. |  -  |
| **400** | Not valid zip request id! (Code: 15331af9-82d6-41ba-a015-47c23f864eec)&lt;br&gt;Zip request is no longer available! (Code: 18b7b4aa-6b4a-4da4-b8b3-c7ab1381e28c) |  -  |
| **401** | Unauthorized. API Key not provided. |  -  |
| **500** | Internal server error. Please contact administrator. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="httpportalrequestzipbyid"></a>
# **HttpPortalRequestZipById**
> PortalZipRequest HttpPortalRequestZipById (string id, PortalZipRequest portalZipRequest)



Initiates the ZIP creation of an asset basket from an portal.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Agravity.Public.Api;
using Agravity.Public.Client;
using Agravity.Public.Model;

namespace Example
{
    public class HttpPortalRequestZipByIdExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost:7072/api";
            // Configure API key authorization: function_key
            config.AddApiKey("x-functions-key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("x-functions-key", "Bearer");

            var apiInstance = new PublicPortalManagementApi(config);
            var id = "id_example";  // string | The ID of the portal.
            var portalZipRequest = new PortalZipRequest(); // PortalZipRequest | The allowed formats are the input which could be added.

            try
            {
                PortalZipRequest result = apiInstance.HttpPortalRequestZipById(id, portalZipRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling PublicPortalManagementApi.HttpPortalRequestZipById: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the HttpPortalRequestZipByIdWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<PortalZipRequest> response = apiInstance.HttpPortalRequestZipByIdWithHttpInfo(id, portalZipRequest);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling PublicPortalManagementApi.HttpPortalRequestZipByIdWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **string** | The ID of the portal. |  |
| **portalZipRequest** | [**PortalZipRequest**](PortalZipRequest.md) | The allowed formats are the input which could be added. |  |

### Return type

[**PortalZipRequest**](PortalZipRequest.md)

### Authorization

[function_key](../README.md#function_key)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **201** | Returns the portal with the given ID. |  -  |
| **400** | Not valid portal id! (Code: 00b410fe-97d1-4952-ba0b-327d22514934)&lt;br&gt;Object is not a valid PortalZipRequest. (Code: a51d1697-f56e-4fa3-bde8-3ab44e6cbb0a)&lt;br&gt;No allowed formats are given! (Code: 684df4b1-e0c5-4b07-8c81-cb9835e0bd00)&lt;br&gt;No asset ids are given! (Code: e8361816-fcc9-48b9-99d4-2133dfed7721)&lt;br&gt;Not all asset ids are valid! (Code: 0619480f-fa10-4c45-a60d-cb269d8be7b4)&lt;br&gt;Portal not found in database! (Code: 50a49113-cbcf-470c-ab8c-098dcd23cd0f)&lt;br&gt;Not all allowed formats are in the portal allowed formats! (Code: c679981e-fbaa-4941-90aa-3b99b1d5a748)&lt;br&gt;Not all asset ids are valid for this portal! (Code: 01e22b3a-13f9-4d5a-a777-2c69ce7b5b05)&lt;br&gt;No matching allowed formats for requested assets. (Code: bd27176f-9a4d-44ac-9055-9359b405558e)&lt;br&gt;Not all asset types have an allowed format in this request! (Code: 2289c7b1-0351-4815-b280-ce4628bdb3dd)&lt;br&gt;Error on upsert zipRequest in database - max retry count is reached. (Code:7a627b8f-11f8-4bbb-bcbd-9f6f5726557a) |  -  |
| **404** | Portal not found. (Code: 87d09a21-14d6-4da4-ab69-01e6c87f108c)&lt;br&gt; |  -  |
| **401** | Unauthorized. API Key not provided. |  -  |
| **500** | Internal server error. Please contact administrator. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="httpportalsconfigurationgetbyid"></a>
# **HttpPortalsConfigurationGetById**
> PortalConfiguration HttpPortalsConfigurationGetById (string id)



This endpoint returns a full configuration of the portal. Incl. download formats, SDLs, UDLs, etc.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Agravity.Public.Api;
using Agravity.Public.Client;
using Agravity.Public.Model;

namespace Example
{
    public class HttpPortalsConfigurationGetByIdExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost:7072/api";
            // Configure API key authorization: function_key
            config.AddApiKey("x-functions-key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("x-functions-key", "Bearer");

            var apiInstance = new PublicPortalManagementApi(config);
            var id = "id_example";  // string | The ID of the portal.

            try
            {
                PortalConfiguration result = apiInstance.HttpPortalsConfigurationGetById(id);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling PublicPortalManagementApi.HttpPortalsConfigurationGetById: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the HttpPortalsConfigurationGetByIdWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<PortalConfiguration> response = apiInstance.HttpPortalsConfigurationGetByIdWithHttpInfo(id);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling PublicPortalManagementApi.HttpPortalsConfigurationGetByIdWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **string** | The ID of the portal. |  |

### Return type

[**PortalConfiguration**](PortalConfiguration.md)

### Authorization

[function_key](../README.md#function_key)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Returns a full configuration of a portal. |  -  |
| **401** | Unauthorized. API Key not provided. |  -  |
| **500** | Internal server error. Please contact administrator. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="httpportalsgetbyid"></a>
# **HttpPortalsGetById**
> Portal HttpPortalsGetById (string id)



This endpoint return the created portal by ID.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Agravity.Public.Api;
using Agravity.Public.Client;
using Agravity.Public.Model;

namespace Example
{
    public class HttpPortalsGetByIdExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost:7072/api";
            // Configure API key authorization: function_key
            config.AddApiKey("x-functions-key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("x-functions-key", "Bearer");

            var apiInstance = new PublicPortalManagementApi(config);
            var id = "id_example";  // string | The ID of the portal.

            try
            {
                Portal result = apiInstance.HttpPortalsGetById(id);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling PublicPortalManagementApi.HttpPortalsGetById: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the HttpPortalsGetByIdWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<Portal> response = apiInstance.HttpPortalsGetByIdWithHttpInfo(id);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling PublicPortalManagementApi.HttpPortalsGetByIdWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **string** | The ID of the portal. |  |

### Return type

[**Portal**](Portal.md)

### Authorization

[function_key](../README.md#function_key)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Returns on portal from database. |  -  |
| **401** | Unauthorized. API Key not provided. |  -  |
| **500** | Internal server error. Please contact administrator. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

