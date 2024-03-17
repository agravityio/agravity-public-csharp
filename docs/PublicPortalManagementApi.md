# Agravity.Public.Api.PublicPortalManagementApi

All URIs are relative to *http://localhost:7072/api*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**HttpPortalsConfigurationGetById**](PublicPortalManagementApi.md#httpportalsconfigurationgetbyid) | **GET** /portals/{id}/config |  |
| [**HttpPortalsGetById**](PublicPortalManagementApi.md#httpportalsgetbyid) | **GET** /portals/{id} |  |

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

