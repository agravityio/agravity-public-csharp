# Agravity.Public.Api.WebAppDataApi

All URIs are relative to *http://localhost:7071/api*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**HttpGetDataCollectionType**](WebAppDataApi.md#httpgetdatacollectiontype) | **GET** /data/collectiontype/{id} |  |
| [**HttpGetWebAppData**](WebAppDataApi.md#httpgetwebappdata) | **GET** /webappdata/{id} |  |
| [**HttpPostDataCollectionType**](WebAppDataApi.md#httppostdatacollectiontype) | **POST** /data/collectiontype/{id} |  |
| [**HttpPostWebAppData**](WebAppDataApi.md#httppostwebappdata) | **POST** /webappdata/{id} |  |

<a id="httpgetdatacollectiontype"></a>
# **HttpGetDataCollectionType**
> GroupAllAppData HttpGetDataCollectionType (string id)



This returns all collections and assets from the given collection type.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Agravity.Public.Api;
using Agravity.Public.Client;
using Agravity.Public.Model;

namespace Example
{
    public class HttpGetDataCollectionTypeExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost:7071/api";
            // Configure OAuth2 access token for authorization: msal_auth
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new WebAppDataApi(config);
            var id = "id_example";  // string | The ID of the collection type for which this web data should be prepared.

            try
            {
                GroupAllAppData result = apiInstance.HttpGetDataCollectionType(id);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling WebAppDataApi.HttpGetDataCollectionType: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the HttpGetDataCollectionTypeWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<GroupAllAppData> response = apiInstance.HttpGetDataCollectionTypeWithHttpInfo(id);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling WebAppDataApi.HttpGetDataCollectionTypeWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **string** | The ID of the collection type for which this web data should be prepared. |  |

### Return type

[**GroupAllAppData**](GroupAllAppData.md)

### Authorization

[msal_auth](../README.md#msal_auth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | This returns all collections and assets from the given collection type. |  -  |
| **400** | Unknown request method (Code: 2e7570d3-7667-4bc9-89ea-f5d6f5aa84c0) |  -  |
| **404** | Collection Type not found - Never existed, not a collection type or already deleted. (Code: 8f939f77-1ba9-40b7-905e-bef8ddc720a1)&lt;br&gt;or the web app data was never created (POST). (Code: 210910ed-68e8-4837-a58f-bfce0591cb49) |  -  |
| **401** | Unauthorized. Bearer Token not provided. |  -  |
| **500** | Internal server error. Please contact administrator. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="httpgetwebappdata"></a>
# **HttpGetWebAppData**
> AllWebAppData HttpGetWebAppData (string id)



This lists all elements of a given collection which can be used by the web frontend. It includes structure and all assets. All coming live from database.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Agravity.Public.Api;
using Agravity.Public.Client;
using Agravity.Public.Model;

namespace Example
{
    public class HttpGetWebAppDataExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost:7071/api";
            // Configure OAuth2 access token for authorization: msal_auth
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new WebAppDataApi(config);
            var id = "id_example";  // string | The ID of the collection for which this web data should be prepared.

            try
            {
                AllWebAppData result = apiInstance.HttpGetWebAppData(id);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling WebAppDataApi.HttpGetWebAppData: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the HttpGetWebAppDataWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<AllWebAppData> response = apiInstance.HttpGetWebAppDataWithHttpInfo(id);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling WebAppDataApi.HttpGetWebAppDataWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **string** | The ID of the collection for which this web data should be prepared. |  |

### Return type

[**AllWebAppData**](AllWebAppData.md)

### Authorization

[msal_auth](../README.md#msal_auth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | This lists all elements which should be used by the web frontend. |  -  |
| **400** | Update failed.(Code: e85183ec-6183-4329-a74f-6ceb963967a3)&lt;br&gt;Unknown request method (Code: d57e77a3-69d4-4060-9641-601ee1008fef) |  -  |
| **404** | Collection not found - Never existed, not a collection or already deleted. (Code: 1d6325bf-7c1c-41ae-ba95-e41dd037a29f) |  -  |
| **401** | Unauthorized. Bearer Token not provided. |  -  |
| **500** | Internal server error. Please contact administrator. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="httppostdatacollectiontype"></a>
# **HttpPostDataCollectionType**
> AgravityInfoResponse HttpPostDataCollectionType (string id)



This triggers an async action to publish the whole structure and puts it to public blob storage with collection type id with extension json.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Agravity.Public.Api;
using Agravity.Public.Client;
using Agravity.Public.Model;

namespace Example
{
    public class HttpPostDataCollectionTypeExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost:7071/api";
            // Configure OAuth2 access token for authorization: msal_auth
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new WebAppDataApi(config);
            var id = "id_example";  // string | The ID of the collection type for which this web data should be prepared.

            try
            {
                AgravityInfoResponse result = apiInstance.HttpPostDataCollectionType(id);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling WebAppDataApi.HttpPostDataCollectionType: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the HttpPostDataCollectionTypeWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<AgravityInfoResponse> response = apiInstance.HttpPostDataCollectionTypeWithHttpInfo(id);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling WebAppDataApi.HttpPostDataCollectionTypeWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **string** | The ID of the collection type for which this web data should be prepared. |  |

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
| **200** | The returns only the info that the request was created successfully. (Code: 031cb222-33a5-41fc-8aea-aa4a4fb8dbd2) |  -  |
| **400** | Payload of AgravityErrorResponse |  -  |
| **404** | Collection Type not found - Never existed, not a collection type or already deleted. (Code: 8f939f77-1ba9-40b7-905e-bef8ddc720a1) |  -  |
| **401** | Unauthorized. Bearer Token not provided. |  -  |
| **500** | Internal server error. Please contact administrator. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="httppostwebappdata"></a>
# **HttpPostWebAppData**
> AgravityInfoResponse HttpPostWebAppData (string id)



Takes whole structure and puts it to public blob storage with collection id with extension json.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Agravity.Public.Api;
using Agravity.Public.Client;
using Agravity.Public.Model;

namespace Example
{
    public class HttpPostWebAppDataExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost:7071/api";
            // Configure OAuth2 access token for authorization: msal_auth
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new WebAppDataApi(config);
            var id = "id_example";  // string | The ID of the collection for which this web data should be prepared.

            try
            {
                AgravityInfoResponse result = apiInstance.HttpPostWebAppData(id);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling WebAppDataApi.HttpPostWebAppData: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the HttpPostWebAppDataWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<AgravityInfoResponse> response = apiInstance.HttpPostWebAppDataWithHttpInfo(id);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling WebAppDataApi.HttpPostWebAppDataWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **string** | The ID of the collection for which this web data should be prepared. |  |

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
| **200** | The returns only the info that the update was successful. (Code: 468bdb1b-d3ac-4493-b775-3a7ae86be51f) |  -  |
| **400** | Update failed. (Code: e85183ec-6183-4329-a74f-6ceb963967a3) |  -  |
| **401** | Unauthorized. Bearer Token not provided. |  -  |
| **404** | Collection not found - Never existed, not a collection or already deleted. (Code: 1d6325bf-7c1c-41ae-ba95-e41dd037a29f) |  -  |
| **500** | Internal server error. Please contact administrator. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

