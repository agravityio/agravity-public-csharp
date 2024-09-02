# Agravity.Public.Api.PortalManagementApi

All URIs are relative to *http://localhost:7071/api*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**HttpPortalGetAllAssetIdsById**](PortalManagementApi.md#httpportalgetallassetidsbyid) | **GET** /portals/{id}/assetids |  |
| [**HttpPortalGetStatusZipById**](PortalManagementApi.md#httpportalgetstatuszipbyid) | **GET** /portals/{id}/zip/{zipId} |  |
| [**HttpPortalRequestZipById**](PortalManagementApi.md#httpportalrequestzipbyid) | **POST** /portals/{id}/zip |  |
| [**HttpPortalsConfigurationGetById**](PortalManagementApi.md#httpportalsconfigurationgetbyid) | **GET** /portals/{id}/config |  |
| [**HttpPortalsCreate**](PortalManagementApi.md#httpportalscreate) | **POST** /portals |  |
| [**HttpPortalsDeleteById**](PortalManagementApi.md#httpportalsdeletebyid) | **DELETE** /portals/{id} |  |
| [**HttpPortalsGetAll**](PortalManagementApi.md#httpportalsgetall) | **GET** /portals |  |
| [**HttpPortalsGetById**](PortalManagementApi.md#httpportalsgetbyid) | **GET** /portals/{id} |  |

<a id="httpportalgetallassetidsbyid"></a>
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
            config.BasePath = "http://localhost:7071/api";
            // Configure OAuth2 access token for authorization: msal_auth
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new PortalManagementApi(config);
            var id = "id_example";  // string | The ID of the portal.

            try
            {
                List<string> result = apiInstance.HttpPortalGetAllAssetIdsById(id);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling PortalManagementApi.HttpPortalGetAllAssetIdsById: " + e.Message);
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
    Debug.Print("Exception when calling PortalManagementApi.HttpPortalGetAllAssetIdsByIdWithHttpInfo: " + e.Message);
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

[msal_auth](../README.md#msal_auth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Returns all Asset IDs in scope of the portal. |  -  |
| **400** | Portal ID is mandatory and not valid. (Code: f2817cb8-8573-4205-b45d-1b9a7f3d8cbb) |  -  |
| **401** | Unauthorized. Bearer Token not provided. |  -  |
| **404** | The requested item could not be found. |  -  |
| **500** | Internal server error. Please contact administrator. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="httpportalgetstatuszipbyid"></a>
# **HttpPortalGetStatusZipById**
> PortalZipRequest HttpPortalGetStatusZipById (string id, string zipId, string ayPassword = null)



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
            config.BasePath = "http://localhost:7071/api";
            // Configure OAuth2 access token for authorization: msal_auth
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new PortalManagementApi(config);
            var id = "id_example";  // string | The ID of the zip request collection.
            var zipId = "zipId_example";  // string | The ID of the requested zip.
            var ayPassword = "ayPassword_example";  // string | If portal has a password, this header is mandatory. Otherwise StatusCode 401 (Unauthorized) is returned. (optional) 

            try
            {
                PortalZipRequest result = apiInstance.HttpPortalGetStatusZipById(id, zipId, ayPassword);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling PortalManagementApi.HttpPortalGetStatusZipById: " + e.Message);
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
    ApiResponse<PortalZipRequest> response = apiInstance.HttpPortalGetStatusZipByIdWithHttpInfo(id, zipId, ayPassword);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling PortalManagementApi.HttpPortalGetStatusZipByIdWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **string** | The ID of the zip request collection. |  |
| **zipId** | **string** | The ID of the requested zip. |  |
| **ayPassword** | **string** | If portal has a password, this header is mandatory. Otherwise StatusCode 401 (Unauthorized) is returned. | [optional]  |

### Return type

[**PortalZipRequest**](PortalZipRequest.md)

### Authorization

[msal_auth](../README.md#msal_auth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Returns the zip request for a portal with the given ID. |  -  |
| **400** | Not valid zip request id! (Code: 15331af9-82d6-41ba-a015-47c23f864eec)&lt;br&gt;Zip request is no longer available! (Code: 18b7b4aa-6b4a-4da4-b8b3-c7ab1381e28c) |  -  |
| **401** | Unauthorized. Bearer Token not provided. |  -  |
| **500** | Internal server error. Please contact administrator. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="httpportalrequestzipbyid"></a>
# **HttpPortalRequestZipById**
> PortalZipRequest HttpPortalRequestZipById (string id, PortalZipRequest portalZipRequest, string ayPassword = null)



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
            config.BasePath = "http://localhost:7071/api";
            // Configure OAuth2 access token for authorization: msal_auth
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new PortalManagementApi(config);
            var id = "id_example";  // string | The ID of the portal.
            var portalZipRequest = new PortalZipRequest(); // PortalZipRequest | The allowed formats are the input which could be added.
            var ayPassword = "ayPassword_example";  // string | The password is a XOR combination of all asset MD5 hashes. Otherwise StatusCode 403 (Forbidden) is returned. (optional) 

            try
            {
                PortalZipRequest result = apiInstance.HttpPortalRequestZipById(id, portalZipRequest, ayPassword);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling PortalManagementApi.HttpPortalRequestZipById: " + e.Message);
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
    ApiResponse<PortalZipRequest> response = apiInstance.HttpPortalRequestZipByIdWithHttpInfo(id, portalZipRequest, ayPassword);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling PortalManagementApi.HttpPortalRequestZipByIdWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **string** | The ID of the portal. |  |
| **portalZipRequest** | [**PortalZipRequest**](PortalZipRequest.md) | The allowed formats are the input which could be added. |  |
| **ayPassword** | **string** | The password is a XOR combination of all asset MD5 hashes. Otherwise StatusCode 403 (Forbidden) is returned. | [optional]  |

### Return type

[**PortalZipRequest**](PortalZipRequest.md)

### Authorization

[msal_auth](../README.md#msal_auth)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **201** | Returns the portal with the given ID. |  -  |
| **400** | Not valid portal id! (Code: 00b410fe-97d1-4952-ba0b-327d22514934)&lt;br&gt;Object is not a valid PortalZipRequest. (Code: a51d1697-f56e-4fa3-bde8-3ab44e6cbb0a)&lt;br&gt;No allowed formats are given! (Code: 684df4b1-e0c5-4b07-8c81-cb9835e0bd00)&lt;br&gt;No asset ids are given! (Code: e8361816-fcc9-48b9-99d4-2133dfed7721)&lt;br&gt;Not all asset ids are valid! (Code: 0619480f-fa10-4c45-a60d-cb269d8be7b4)&lt;br&gt;Portal not found in database! (Code: 50a49113-cbcf-470c-ab8c-098dcd23cd0f)&lt;br&gt;Not all allowed formats are in the portal allowed formats! (Code: c679981e-fbaa-4941-90aa-3b99b1d5a748)&lt;br&gt;Not all asset ids are valid for this portal! (Code: 01e22b3a-13f9-4d5a-a777-2c69ce7b5b05)&lt;br&gt;No matching allowed formats for requested assets. (Code: bd27176f-9a4d-44ac-9055-9359b405558e)&lt;br&gt;Not all asset types have an allowed format in this request! (Code: 2289c7b1-0351-4815-b280-ce4628bdb3dd)&lt;br&gt;Error on upsert zipRequest in database - max retry count is reached. (Code:7a627b8f-11f8-4bbb-bcbd-9f6f5726557a) |  -  |
| **404** | Portal not found. (Code: 87d09a21-14d6-4da4-ab69-01e6c87f108c)&lt;br&gt; |  -  |
| **401** | Unauthorized. Bearer Token not provided. |  -  |
| **500** | Internal server error. Please contact administrator. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="httpportalsconfigurationgetbyid"></a>
# **HttpPortalsConfigurationGetById**
> Portal HttpPortalsConfigurationGetById (string id)



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
            config.BasePath = "http://localhost:7071/api";
            // Configure OAuth2 access token for authorization: msal_auth
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new PortalManagementApi(config);
            var id = "id_example";  // string | The ID of the portal.

            try
            {
                Portal result = apiInstance.HttpPortalsConfigurationGetById(id);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling PortalManagementApi.HttpPortalsConfigurationGetById: " + e.Message);
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
    ApiResponse<Portal> response = apiInstance.HttpPortalsConfigurationGetByIdWithHttpInfo(id);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling PortalManagementApi.HttpPortalsConfigurationGetByIdWithHttpInfo: " + e.Message);
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

[msal_auth](../README.md#msal_auth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Returns a full configuration of a portal |  -  |
| **401** | Unauthorized. Bearer Token not provided. |  -  |
| **500** | Internal server error. Please contact administrator. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="httpportalscreate"></a>
# **HttpPortalsCreate**
> Portal HttpPortalsCreate (Portal portal)



This endpoint creates one portal entry in the database.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Agravity.Public.Api;
using Agravity.Public.Client;
using Agravity.Public.Model;

namespace Example
{
    public class HttpPortalsCreateExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost:7071/api";
            // Configure OAuth2 access token for authorization: msal_auth
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new PortalManagementApi(config);
            var portal = new Portal(); // Portal | This endpoint creates an unique portal ID and adds the information to the database.

            try
            {
                Portal result = apiInstance.HttpPortalsCreate(portal);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling PortalManagementApi.HttpPortalsCreate: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the HttpPortalsCreateWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<Portal> response = apiInstance.HttpPortalsCreateWithHttpInfo(portal);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling PortalManagementApi.HttpPortalsCreateWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **portal** | [**Portal**](Portal.md) | This endpoint creates an unique portal ID and adds the information to the database. |  |

### Return type

[**Portal**](Portal.md)

### Authorization

[msal_auth](../README.md#msal_auth)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **201** | The freshly created portal with unique ID, which is the indicator for search index, indexer, etc. |  -  |
| **400** | Object is not a valid portal. (Code: 63990d5b-a117-4892-a034-5673c40ea2f1)&lt;br&gt;Not valid portal id! (Code: e122fe64-5a6f-4bb8-9342-79203e3740a6)&lt;br&gt;CosmosDbQuery is not a valid CosmosDB SQL WHERE statement. (Code: ed0e4ea3-875f-44a3-97e5-58373086c3d1)&lt;br&gt;Can not create portal with id {ID}. Portal already exists. Delete first. (Code: 9b2040b1-d824-45ab-8f37-d6463e0cb421)&lt;br&gt;Some of the metadata languages are not valid! Allowed values: {allMetadataLanguages}. (Code: 52da1027-02be-4f16-a7c0-98ba111e6ab9)&lt;br&gt;Some of the UI languages are not valid! Allowed values: {allUiLanguages}. (Code: 95caabeb-ddec-45f6-9526-e84e81e89328)&lt;br&gt;No valid metadata fields are given. (Code: ba312165-1501-443d-9da0-545eb6994aa4) |  -  |
| **401** | Unauthorized. Bearer Token not provided. |  -  |
| **500** | Internal server error. Please contact administrator. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="httpportalsdeletebyid"></a>
# **HttpPortalsDeleteById**
> void HttpPortalsDeleteById (string id)



This endpoint deletes a single portal.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Agravity.Public.Api;
using Agravity.Public.Client;
using Agravity.Public.Model;

namespace Example
{
    public class HttpPortalsDeleteByIdExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost:7071/api";
            // Configure OAuth2 access token for authorization: msal_auth
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new PortalManagementApi(config);
            var id = "id_example";  // string | The ID of the portal.

            try
            {
                apiInstance.HttpPortalsDeleteById(id);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling PortalManagementApi.HttpPortalsDeleteById: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the HttpPortalsDeleteByIdWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    apiInstance.HttpPortalsDeleteByIdWithHttpInfo(id);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling PortalManagementApi.HttpPortalsDeleteByIdWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **string** | The ID of the portal. |  |

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
| **400** | Error on deleting portal ({id}) database - max retry count is reached. (Code: 8f0d22db-7be1-4d88-8f5f-918e06b7ce2f) |  -  |
| **204** | The delete operation of the portal with the given ID was successful. |  -  |
| **404** | If the portal with the ID was not found. |  -  |
| **401** | Unauthorized. Bearer Token not provided. |  -  |
| **500** | Internal server error. Please contact administrator. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="httpportalsgetall"></a>
# **HttpPortalsGetAll**
> List&lt;Portal&gt; HttpPortalsGetAll ()



This endpoint show the portal from database.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Agravity.Public.Api;
using Agravity.Public.Client;
using Agravity.Public.Model;

namespace Example
{
    public class HttpPortalsGetAllExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost:7071/api";
            // Configure OAuth2 access token for authorization: msal_auth
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new PortalManagementApi(config);

            try
            {
                List<Portal> result = apiInstance.HttpPortalsGetAll();
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling PortalManagementApi.HttpPortalsGetAll: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the HttpPortalsGetAllWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<List<Portal>> response = apiInstance.HttpPortalsGetAllWithHttpInfo();
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling PortalManagementApi.HttpPortalsGetAllWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters
This endpoint does not need any parameter.
### Return type

[**List&lt;Portal&gt;**](Portal.md)

### Authorization

[msal_auth](../README.md#msal_auth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Returns all portals from database. |  -  |
| **401** | Unauthorized. Bearer Token not provided. |  -  |
| **500** | Internal server error. Please contact administrator. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="httpportalsgetbyid"></a>
# **HttpPortalsGetById**
> Portal HttpPortalsGetById (string id)



This endpoint show the portal from database.

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
            config.BasePath = "http://localhost:7071/api";
            // Configure OAuth2 access token for authorization: msal_auth
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new PortalManagementApi(config);
            var id = "id_example";  // string | The ID of the portal.

            try
            {
                Portal result = apiInstance.HttpPortalsGetById(id);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling PortalManagementApi.HttpPortalsGetById: " + e.Message);
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
    Debug.Print("Exception when calling PortalManagementApi.HttpPortalsGetByIdWithHttpInfo: " + e.Message);
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

[msal_auth](../README.md#msal_auth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Returns the portal from database. |  -  |
| **401** | Unauthorized. Bearer Token not provided. |  -  |
| **500** | Internal server error. Please contact administrator. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

