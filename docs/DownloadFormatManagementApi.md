# Agravity.Public.Api.DownloadFormatManagementApi

All URIs are relative to *http://localhost:7071/api*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**HttpDownloadFormatsCreate**](DownloadFormatManagementApi.md#httpdownloadformatscreate) | **POST** /downloadformats |  |
| [**HttpDownloadFormatsDeleteById**](DownloadFormatManagementApi.md#httpdownloadformatsdeletebyid) | **DELETE** /downloadformats/{id} |  |
| [**HttpDownloadFormatsGetAll**](DownloadFormatManagementApi.md#httpdownloadformatsgetall) | **GET** /downloadformats |  |
| [**HttpDownloadFormatsGetById**](DownloadFormatManagementApi.md#httpdownloadformatsgetbyid) | **GET** /downloadformats/{id} |  |
| [**HttpDownloadFormatsUpdateWithId**](DownloadFormatManagementApi.md#httpdownloadformatsupdatewithid) | **POST** /downloadformats/{id} |  |

<a id="httpdownloadformatscreate"></a>
# **HttpDownloadFormatsCreate**
> DownloadFormat HttpDownloadFormatsCreate (DownloadFormat downloadFormat, bool? translations = null, string acceptLanguage = null)



This endpoint creates one download format entry in the database.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Agravity.Public.Api;
using Agravity.Public.Client;
using Agravity.Public.Model;

namespace Example
{
    public class HttpDownloadFormatsCreateExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost:7071/api";
            // Configure OAuth2 access token for authorization: msal_auth
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new DownloadFormatManagementApi(config);
            var downloadFormat = new DownloadFormat(); // DownloadFormat | This endpoint creates an unique download format ID and adds the information to the database.
            var translations = true;  // bool? | When default language should be returned and the translation dictionary is delivered. (Ignores the \"Accept-Language\" header) (optional) 
            var acceptLanguage = "acceptLanguage_example";  // string | The requested language of the response. If not matching it falls back to default language. (optional) 

            try
            {
                DownloadFormat result = apiInstance.HttpDownloadFormatsCreate(downloadFormat, translations, acceptLanguage);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DownloadFormatManagementApi.HttpDownloadFormatsCreate: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the HttpDownloadFormatsCreateWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<DownloadFormat> response = apiInstance.HttpDownloadFormatsCreateWithHttpInfo(downloadFormat, translations, acceptLanguage);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling DownloadFormatManagementApi.HttpDownloadFormatsCreateWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **downloadFormat** | [**DownloadFormat**](DownloadFormat.md) | This endpoint creates an unique download format ID and adds the information to the database. |  |
| **translations** | **bool?** | When default language should be returned and the translation dictionary is delivered. (Ignores the \&quot;Accept-Language\&quot; header) | [optional]  |
| **acceptLanguage** | **string** | The requested language of the response. If not matching it falls back to default language. | [optional]  |

### Return type

[**DownloadFormat**](DownloadFormat.md)

### Authorization

[msal_auth](../README.md#msal_auth)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **201** | Returns the created download format. |  -  |
| **400** | Object is not a valid download_format. (Code: cde7d429-b64d-4248-aaf4-3bfc343af518)&lt;br&gt;Not valid downloadformat id. (Code: fcbf788e-2525-4820-9267-8fac1a8e06f8)&lt;br&gt;Can not create downloadformat with id {input.Id}. DownloadFormat already exists. Delete first. (Code: 65597316-f283-4c6f-939a-c586b448c462)&lt;br&gt;No input object given. (Code: 185f0c42-fda7-47c4-b574-d41bb84baac3) |  -  |
| **401** | Unauthorized. Bearer Token not provided. |  -  |
| **500** | Internal server error. Please contact administrator. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="httpdownloadformatsdeletebyid"></a>
# **HttpDownloadFormatsDeleteById**
> void HttpDownloadFormatsDeleteById (string id)



This endpoint deletes a single download format.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Agravity.Public.Api;
using Agravity.Public.Client;
using Agravity.Public.Model;

namespace Example
{
    public class HttpDownloadFormatsDeleteByIdExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost:7071/api";
            // Configure OAuth2 access token for authorization: msal_auth
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new DownloadFormatManagementApi(config);
            var id = "id_example";  // string | The ID of the download format.

            try
            {
                apiInstance.HttpDownloadFormatsDeleteById(id);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DownloadFormatManagementApi.HttpDownloadFormatsDeleteById: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the HttpDownloadFormatsDeleteByIdWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    apiInstance.HttpDownloadFormatsDeleteByIdWithHttpInfo(id);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling DownloadFormatManagementApi.HttpDownloadFormatsDeleteByIdWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **string** | The ID of the download format. |  |

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
| **400** | Error on deleting download format ({id}) database - max retry count is reached. (Code: 8f0d22db-7be1-4d88-8f5f-918e06b7ce2f) |  -  |
| **204** | The delete operation of the download format with the given ID was successful. |  -  |
| **404** | If the download format with the ID was not found. |  -  |
| **401** | Unauthorized. Bearer Token not provided. |  -  |
| **500** | Internal server error. Please contact administrator. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="httpdownloadformatsgetall"></a>
# **HttpDownloadFormatsGetAll**
> List&lt;DownloadFormat&gt; HttpDownloadFormatsGetAll (bool? translations = null, string acceptLanguage = null)



This endpoint lists all download formats in database.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Agravity.Public.Api;
using Agravity.Public.Client;
using Agravity.Public.Model;

namespace Example
{
    public class HttpDownloadFormatsGetAllExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost:7071/api";
            // Configure OAuth2 access token for authorization: msal_auth
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new DownloadFormatManagementApi(config);
            var translations = true;  // bool? | When default language should be returned and the translation dictionary is delivered. (Ignores the \"Accept-Language\" header) (optional) 
            var acceptLanguage = "acceptLanguage_example";  // string | The requested language of the response. If not matching it falls back to default language. (optional) 

            try
            {
                List<DownloadFormat> result = apiInstance.HttpDownloadFormatsGetAll(translations, acceptLanguage);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DownloadFormatManagementApi.HttpDownloadFormatsGetAll: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the HttpDownloadFormatsGetAllWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<List<DownloadFormat>> response = apiInstance.HttpDownloadFormatsGetAllWithHttpInfo(translations, acceptLanguage);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling DownloadFormatManagementApi.HttpDownloadFormatsGetAllWithHttpInfo: " + e.Message);
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

[**List&lt;DownloadFormat&gt;**](DownloadFormat.md)

### Authorization

[msal_auth](../README.md#msal_auth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Returns all download formats in database. |  -  |
| **401** | Unauthorized. Bearer Token not provided. |  -  |
| **500** | Internal server error. Please contact administrator. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="httpdownloadformatsgetbyid"></a>
# **HttpDownloadFormatsGetById**
> void HttpDownloadFormatsGetById (string id, bool? translations = null, string acceptLanguage = null)



This endpoint get a single download format.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Agravity.Public.Api;
using Agravity.Public.Client;
using Agravity.Public.Model;

namespace Example
{
    public class HttpDownloadFormatsGetByIdExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost:7071/api";
            // Configure OAuth2 access token for authorization: msal_auth
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new DownloadFormatManagementApi(config);
            var id = "id_example";  // string | The ID of the download format.
            var translations = true;  // bool? | When default language should be returned and the translation dictionary is delivered. (Ignores the \"Accept-Language\" header) (optional) 
            var acceptLanguage = "acceptLanguage_example";  // string | The requested language of the response. If not matching it falls back to default language. (optional) 

            try
            {
                apiInstance.HttpDownloadFormatsGetById(id, translations, acceptLanguage);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DownloadFormatManagementApi.HttpDownloadFormatsGetById: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the HttpDownloadFormatsGetByIdWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    apiInstance.HttpDownloadFormatsGetByIdWithHttpInfo(id, translations, acceptLanguage);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling DownloadFormatManagementApi.HttpDownloadFormatsGetByIdWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **string** | The ID of the download format. |  |
| **translations** | **bool?** | When default language should be returned and the translation dictionary is delivered. (Ignores the \&quot;Accept-Language\&quot; header) | [optional]  |
| **acceptLanguage** | **string** | The requested language of the response. If not matching it falls back to default language. | [optional]  |

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
| **400** | Error on get download format ({id}) database - max retry count is reached. (Code: 8f0d22db-7be1-4d88-8f5f-918e06b7ce2f) |  -  |
| **204** | The delete operation of the download format with the given ID was successful. |  -  |
| **404** | If the download format with the ID was not found. |  -  |
| **401** | Unauthorized. Bearer Token not provided. |  -  |
| **500** | Internal server error. Please contact administrator. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="httpdownloadformatsupdatewithid"></a>
# **HttpDownloadFormatsUpdateWithId**
> DownloadFormat HttpDownloadFormatsUpdateWithId (string id, DownloadFormat downloadFormat, bool? translations = null, string acceptLanguage = null)



This endpoint updates a download format entry in the database.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Agravity.Public.Api;
using Agravity.Public.Client;
using Agravity.Public.Model;

namespace Example
{
    public class HttpDownloadFormatsUpdateWithIdExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost:7071/api";
            // Configure OAuth2 access token for authorization: msal_auth
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new DownloadFormatManagementApi(config);
            var id = "id_example";  // string | The ID of the download format.
            var downloadFormat = new DownloadFormat(); // DownloadFormat | This endpoint updates a download format with ID and adds the information to the database.
            var translations = true;  // bool? | When default language should be returned and the translation dictionary is delivered. (Ignores the \"Accept-Language\" header) (optional) 
            var acceptLanguage = "acceptLanguage_example";  // string | The requested language of the response. If not matching it falls back to default language. (optional) 

            try
            {
                DownloadFormat result = apiInstance.HttpDownloadFormatsUpdateWithId(id, downloadFormat, translations, acceptLanguage);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DownloadFormatManagementApi.HttpDownloadFormatsUpdateWithId: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the HttpDownloadFormatsUpdateWithIdWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<DownloadFormat> response = apiInstance.HttpDownloadFormatsUpdateWithIdWithHttpInfo(id, downloadFormat, translations, acceptLanguage);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling DownloadFormatManagementApi.HttpDownloadFormatsUpdateWithIdWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **string** | The ID of the download format. |  |
| **downloadFormat** | [**DownloadFormat**](DownloadFormat.md) | This endpoint updates a download format with ID and adds the information to the database. |  |
| **translations** | **bool?** | When default language should be returned and the translation dictionary is delivered. (Ignores the \&quot;Accept-Language\&quot; header) | [optional]  |
| **acceptLanguage** | **string** | The requested language of the response. If not matching it falls back to default language. | [optional]  |

### Return type

[**DownloadFormat**](DownloadFormat.md)

### Authorization

[msal_auth](../README.md#msal_auth)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Returns the updated download format. |  -  |
| **400** | Object is not a valid download_format. (Code: 8edcecf1-a843-4aa7-9218-d71484236902)&lt;br&gt;No input object given. (Code: 657b8e8c-20a4-4b3c-b218-7336e9453640)&lt;br&gt;No operations on download format found. (Code: 3f8acf59-a284-463e-94ab-fb7bd180069d)&lt;br&gt;The &#39;{ExtensionOperationFormat}&#39; operation contains not supported file format. (Code: dadcc9b5-f7b0-4ef9-af6f-e3057fd73de9)&lt;br&gt;No file extension is given. (Code: f85e9f3d-b9fb-4486-9b8a-205e7fb46dd9) |  -  |
| **404** | The requested item could not be found. |  -  |
| **401** | Unauthorized. Bearer Token not provided. |  -  |
| **500** | Internal server error. Please contact administrator. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

