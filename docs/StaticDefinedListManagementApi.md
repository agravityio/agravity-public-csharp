# Agravity.Public.Api.StaticDefinedListManagementApi

All URIs are relative to *http://localhost:7071/api*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**HttpStaticDefinedListsCreate**](StaticDefinedListManagementApi.md#httpstaticdefinedlistscreate) | **POST** /staticdefinedlists |  |
| [**HttpStaticDefinedListsDeleteById**](StaticDefinedListManagementApi.md#httpstaticdefinedlistsdeletebyid) | **DELETE** /staticdefinedlists/{id} |  |
| [**HttpStaticDefinedListsGetAll**](StaticDefinedListManagementApi.md#httpstaticdefinedlistsgetall) | **GET** /staticdefinedlists |  |
| [**HttpStaticDefinedListsGetById**](StaticDefinedListManagementApi.md#httpstaticdefinedlistsgetbyid) | **GET** /staticdefinedlists/{id} |  |
| [**HttpStaticDefinedListsUpdateById**](StaticDefinedListManagementApi.md#httpstaticdefinedlistsupdatebyid) | **POST** /staticdefinedlists/{id} |  |

<a id="httpstaticdefinedlistscreate"></a>
# **HttpStaticDefinedListsCreate**
> StaticDefinedList HttpStaticDefinedListsCreate (StaticDefinedList staticDefinedList, bool? translations = null, string acceptLanguage = null)



This endpoint creates one static defined list entry in the database.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Agravity.Public.Api;
using Agravity.Public.Client;
using Agravity.Public.Model;

namespace Example
{
    public class HttpStaticDefinedListsCreateExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost:7071/api";
            // Configure OAuth2 access token for authorization: msal_auth
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new StaticDefinedListManagementApi(config);
            var staticDefinedList = new StaticDefinedList(); // StaticDefinedList | This endpoint creates an unique static defined list ID and adds the information to the database.
            var translations = true;  // bool? | When default language should be returned and the translation dictionary is delivered. (Ignores the \"Accept-Language\" header) (optional) 
            var acceptLanguage = "acceptLanguage_example";  // string | The requested language of the response. If not matching it falls back to default language. (optional) 

            try
            {
                StaticDefinedList result = apiInstance.HttpStaticDefinedListsCreate(staticDefinedList, translations, acceptLanguage);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling StaticDefinedListManagementApi.HttpStaticDefinedListsCreate: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the HttpStaticDefinedListsCreateWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<StaticDefinedList> response = apiInstance.HttpStaticDefinedListsCreateWithHttpInfo(staticDefinedList, translations, acceptLanguage);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling StaticDefinedListManagementApi.HttpStaticDefinedListsCreateWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **staticDefinedList** | [**StaticDefinedList**](StaticDefinedList.md) | This endpoint creates an unique static defined list ID and adds the information to the database. |  |
| **translations** | **bool?** | When default language should be returned and the translation dictionary is delivered. (Ignores the \&quot;Accept-Language\&quot; header) | [optional]  |
| **acceptLanguage** | **string** | The requested language of the response. If not matching it falls back to default language. | [optional]  |

### Return type

[**StaticDefinedList**](StaticDefinedList.md)

### Authorization

[msal_auth](../README.md#msal_auth)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **201** | Returns the created static defined list. |  -  |
| **400** | Object is not a valid static_defined_list. (Code: 438e21fd-72f5-4c98-93fe-1e86e43476e5)&lt;br&gt;No input object given. (Code: b2c2610e-c67e-41a8-a353-c0b6d7f43039) |  -  |
| **401** | Unauthorized. Bearer Token not provided. |  -  |
| **500** | Internal server error. Please contact administrator. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="httpstaticdefinedlistsdeletebyid"></a>
# **HttpStaticDefinedListsDeleteById**
> void HttpStaticDefinedListsDeleteById (string id)



This endpoint deletes a single static defined list.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Agravity.Public.Api;
using Agravity.Public.Client;
using Agravity.Public.Model;

namespace Example
{
    public class HttpStaticDefinedListsDeleteByIdExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost:7071/api";
            // Configure OAuth2 access token for authorization: msal_auth
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new StaticDefinedListManagementApi(config);
            var id = "id_example";  // string | The ID of the static defined list.

            try
            {
                apiInstance.HttpStaticDefinedListsDeleteById(id);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling StaticDefinedListManagementApi.HttpStaticDefinedListsDeleteById: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the HttpStaticDefinedListsDeleteByIdWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    apiInstance.HttpStaticDefinedListsDeleteByIdWithHttpInfo(id);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling StaticDefinedListManagementApi.HttpStaticDefinedListsDeleteByIdWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **string** | The ID of the static defined list. |  |

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
| **400** | Error trying to delete the static defined list with the given ID. |  -  |
| **204** | The delete operation of the static defined list with the given ID was successful. |  -  |
| **404** | If the static defined list with the ID was not found. |  -  |
| **401** | Unauthorized. Bearer Token not provided. |  -  |
| **500** | Internal server error. Please contact administrator. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="httpstaticdefinedlistsgetall"></a>
# **HttpStaticDefinedListsGetAll**
> List&lt;StaticDefinedList&gt; HttpStaticDefinedListsGetAll (bool? translations = null, string acceptLanguage = null)



This endpoint lists all static defined lists in database.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Agravity.Public.Api;
using Agravity.Public.Client;
using Agravity.Public.Model;

namespace Example
{
    public class HttpStaticDefinedListsGetAllExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost:7071/api";
            // Configure OAuth2 access token for authorization: msal_auth
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new StaticDefinedListManagementApi(config);
            var translations = true;  // bool? | When default language should be returned and the translation dictionary is delivered. (Ignores the \"Accept-Language\" header) (optional) 
            var acceptLanguage = "acceptLanguage_example";  // string | The requested language of the response. If not matching it falls back to default language. (optional) 

            try
            {
                List<StaticDefinedList> result = apiInstance.HttpStaticDefinedListsGetAll(translations, acceptLanguage);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling StaticDefinedListManagementApi.HttpStaticDefinedListsGetAll: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the HttpStaticDefinedListsGetAllWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<List<StaticDefinedList>> response = apiInstance.HttpStaticDefinedListsGetAllWithHttpInfo(translations, acceptLanguage);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling StaticDefinedListManagementApi.HttpStaticDefinedListsGetAllWithHttpInfo: " + e.Message);
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

[**List&lt;StaticDefinedList&gt;**](StaticDefinedList.md)

### Authorization

[msal_auth](../README.md#msal_auth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Returns all static defined lists in database. |  -  |
| **401** | Unauthorized. Bearer Token not provided. |  -  |
| **500** | Internal server error. Please contact administrator. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="httpstaticdefinedlistsgetbyid"></a>
# **HttpStaticDefinedListsGetById**
> StaticDefinedList HttpStaticDefinedListsGetById (string id, bool? translations = null, string acceptLanguage = null)



This endpoint gets a static defined list from database.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Agravity.Public.Api;
using Agravity.Public.Client;
using Agravity.Public.Model;

namespace Example
{
    public class HttpStaticDefinedListsGetByIdExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost:7071/api";
            // Configure OAuth2 access token for authorization: msal_auth
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new StaticDefinedListManagementApi(config);
            var id = "id_example";  // string | The ID of the static defined list.
            var translations = true;  // bool? | When default language should be returned and the translation dictionary is delivered. (Ignores the \"Accept-Language\" header) (optional) 
            var acceptLanguage = "acceptLanguage_example";  // string | The requested language of the response. If not matching it falls back to default language. (optional) 

            try
            {
                StaticDefinedList result = apiInstance.HttpStaticDefinedListsGetById(id, translations, acceptLanguage);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling StaticDefinedListManagementApi.HttpStaticDefinedListsGetById: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the HttpStaticDefinedListsGetByIdWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<StaticDefinedList> response = apiInstance.HttpStaticDefinedListsGetByIdWithHttpInfo(id, translations, acceptLanguage);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling StaticDefinedListManagementApi.HttpStaticDefinedListsGetByIdWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **string** | The ID of the static defined list. |  |
| **translations** | **bool?** | When default language should be returned and the translation dictionary is delivered. (Ignores the \&quot;Accept-Language\&quot; header) | [optional]  |
| **acceptLanguage** | **string** | The requested language of the response. If not matching it falls back to default language. | [optional]  |

### Return type

[**StaticDefinedList**](StaticDefinedList.md)

### Authorization

[msal_auth](../README.md#msal_auth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Returns a static defined list with the given id. |  -  |
| **404** | The requested item could not be found. |  -  |
| **401** | Unauthorized. Bearer Token not provided. |  -  |
| **500** | Internal server error. Please contact administrator. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="httpstaticdefinedlistsupdatebyid"></a>
# **HttpStaticDefinedListsUpdateById**
> StaticDefinedList HttpStaticDefinedListsUpdateById (string id, string updatemode, StaticDefinedList staticDefinedList, bool? translations = null, string acceptLanguage = null)



Updates a static defined list in database.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Agravity.Public.Api;
using Agravity.Public.Client;
using Agravity.Public.Model;

namespace Example
{
    public class HttpStaticDefinedListsUpdateByIdExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost:7071/api";
            // Configure OAuth2 access token for authorization: msal_auth
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new StaticDefinedListManagementApi(config);
            var id = "id_example";  // string | The ID of the static defined list.
            var updatemode = "updatemode_example";  // string | The mode how the list should be updated. Available values are: add, delete and replace.
            var staticDefinedList = new StaticDefinedList(); // StaticDefinedList | Body has to be a valid static defined list item.
            var translations = true;  // bool? | When default language should be returned and the translation dictionary is delivered. (Ignores the \"Accept-Language\" header) (optional) 
            var acceptLanguage = "acceptLanguage_example";  // string | The requested language of the response. If not matching it falls back to default language. (optional) 

            try
            {
                StaticDefinedList result = apiInstance.HttpStaticDefinedListsUpdateById(id, updatemode, staticDefinedList, translations, acceptLanguage);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling StaticDefinedListManagementApi.HttpStaticDefinedListsUpdateById: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the HttpStaticDefinedListsUpdateByIdWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<StaticDefinedList> response = apiInstance.HttpStaticDefinedListsUpdateByIdWithHttpInfo(id, updatemode, staticDefinedList, translations, acceptLanguage);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling StaticDefinedListManagementApi.HttpStaticDefinedListsUpdateByIdWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **string** | The ID of the static defined list. |  |
| **updatemode** | **string** | The mode how the list should be updated. Available values are: add, delete and replace. |  |
| **staticDefinedList** | [**StaticDefinedList**](StaticDefinedList.md) | Body has to be a valid static defined list item. |  |
| **translations** | **bool?** | When default language should be returned and the translation dictionary is delivered. (Ignores the \&quot;Accept-Language\&quot; header) | [optional]  |
| **acceptLanguage** | **string** | The requested language of the response. If not matching it falls back to default language. | [optional]  |

### Return type

[**StaticDefinedList**](StaticDefinedList.md)

### Authorization

[msal_auth](../README.md#msal_auth)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Returns the updated static defined list for values only the updated, deleted, added |  -  |
| **400** | Object is not a valid static_defined_list. (Code: 0970b102-0d79-4c1c-8144-2d6576234b5a) &lt;br&gt;No input object given. (Code: 4d2f5034-bf4f-4f19-8f3d-56e3d88b833a)Update mode: {given-update-mode} is not a valid update mode. Allowed modes are: Add, Delete, Replace (Code: cb08ff14-4c6b-4d88-a1d7-7b39897d78e6)Error on create collection type item group in database - max retry count is reached. (Code: a524c4cf-392e-4e37-9597-12cdce014757) |  -  |
| **404** | If the static defined list with the ID was not found. |  -  |
| **401** | Unauthorized. Bearer Token not provided. |  -  |
| **500** | Internal server error. Please contact administrator. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

