# Agravity.Public.Api.SavedSearchManagementApi

All URIs are relative to *http://localhost:7071/api*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**HttpSavedSearchesCreate**](SavedSearchManagementApi.md#httpsavedsearchescreate) | **POST** /savedsearches |  |
| [**HttpSavedSearchesDeleteById**](SavedSearchManagementApi.md#httpsavedsearchesdeletebyid) | **DELETE** /savedsearches/{id} |  |
| [**HttpSavedSearchesGetAll**](SavedSearchManagementApi.md#httpsavedsearchesgetall) | **GET** /savedsearches |  |

<a id="httpsavedsearchescreate"></a>
# **HttpSavedSearchesCreate**
> SavedSearch HttpSavedSearchesCreate (SavedSearch savedSearch, bool? translations = null, string acceptLanguage = null)



This endpoint creates one saved search entry in the database.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Agravity.Public.Api;
using Agravity.Public.Client;
using Agravity.Public.Model;

namespace Example
{
    public class HttpSavedSearchesCreateExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost:7071/api";
            // Configure OAuth2 access token for authorization: msal_auth
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new SavedSearchManagementApi(config);
            var savedSearch = new SavedSearch(); // SavedSearch | This endpoint creates an unique saved search ID and adds the information to the database.
            var translations = true;  // bool? | When default language should be returned and the translation dictionary is delivered. (Ignores the \"Accept-Language\" header) (optional) 
            var acceptLanguage = "acceptLanguage_example";  // string | The requested language of the response. If not matching it falls back to default language. (optional) 

            try
            {
                SavedSearch result = apiInstance.HttpSavedSearchesCreate(savedSearch, translations, acceptLanguage);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling SavedSearchManagementApi.HttpSavedSearchesCreate: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the HttpSavedSearchesCreateWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<SavedSearch> response = apiInstance.HttpSavedSearchesCreateWithHttpInfo(savedSearch, translations, acceptLanguage);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling SavedSearchManagementApi.HttpSavedSearchesCreateWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **savedSearch** | [**SavedSearch**](SavedSearch.md) | This endpoint creates an unique saved search ID and adds the information to the database. |  |
| **translations** | **bool?** | When default language should be returned and the translation dictionary is delivered. (Ignores the \&quot;Accept-Language\&quot; header) | [optional]  |
| **acceptLanguage** | **string** | The requested language of the response. If not matching it falls back to default language. | [optional]  |

### Return type

[**SavedSearch**](SavedSearch.md)

### Authorization

[msal_auth](../README.md#msal_auth)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **201** | Returns the created saved search. |  -  |
| **400** | Object is not a valid saved_search. (Code: 63990d5b-a117-4892-a034-5673c40ea2f1)&lt;br&gt;Saved search must have search string with search parameters (\&quot;q&#x3D;\&quot;). (Code: c992de93-5e63-41c9-a554-7e8c8cc27e0c)&lt;br&gt;Saved search must not have more than one &#39;?&#39; in the parameters! (Code: fb352c88-d52c-4c1f-b89e-958decb72558)&lt;br&gt;No input object given. (Code: eedd25fd-cb43-4cb4-94b9-f024081f5cca) |  -  |
| **401** | Unauthorized. Bearer Token not provided. |  -  |
| **500** | Internal server error. Please contact administrator. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="httpsavedsearchesdeletebyid"></a>
# **HttpSavedSearchesDeleteById**
> void HttpSavedSearchesDeleteById (string id)



This endpoint deletes a single saved search.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Agravity.Public.Api;
using Agravity.Public.Client;
using Agravity.Public.Model;

namespace Example
{
    public class HttpSavedSearchesDeleteByIdExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost:7071/api";
            // Configure OAuth2 access token for authorization: msal_auth
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new SavedSearchManagementApi(config);
            var id = "id_example";  // string | The ID of the saved search.

            try
            {
                apiInstance.HttpSavedSearchesDeleteById(id);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling SavedSearchManagementApi.HttpSavedSearchesDeleteById: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the HttpSavedSearchesDeleteByIdWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    apiInstance.HttpSavedSearchesDeleteByIdWithHttpInfo(id);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling SavedSearchManagementApi.HttpSavedSearchesDeleteByIdWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **string** | The ID of the saved search. |  |

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
| **400** | Error on deleting saved search ({id}) database - max retry count is reached. (Code: 8f0d22db-7be1-4d88-8f5f-918e06b7ce2f) |  -  |
| **204** | The delete operation of the saved search with the given ID was successful. |  -  |
| **404** | If the saved search with the ID was not found. |  -  |
| **401** | Unauthorized. Bearer Token not provided. |  -  |
| **500** | Internal server error. Please contact administrator. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="httpsavedsearchesgetall"></a>
# **HttpSavedSearchesGetAll**
> List&lt;SavedSearch&gt; HttpSavedSearchesGetAll (bool? external = null, bool? translations = null, string acceptLanguage = null)



This endpoint lists all saved searches in database.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Agravity.Public.Api;
using Agravity.Public.Client;
using Agravity.Public.Model;

namespace Example
{
    public class HttpSavedSearchesGetAllExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost:7071/api";
            // Configure OAuth2 access token for authorization: msal_auth
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new SavedSearchManagementApi(config);
            var external = true;  // bool? | This parameter filters out all saved searches on basis this boolean. (optional) 
            var translations = true;  // bool? | When default language should be returned and the translation dictionary is delivered. (Ignores the \"Accept-Language\" header) (optional) 
            var acceptLanguage = "acceptLanguage_example";  // string | The requested language of the response. If not matching it falls back to default language. (optional) 

            try
            {
                List<SavedSearch> result = apiInstance.HttpSavedSearchesGetAll(external, translations, acceptLanguage);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling SavedSearchManagementApi.HttpSavedSearchesGetAll: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the HttpSavedSearchesGetAllWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<List<SavedSearch>> response = apiInstance.HttpSavedSearchesGetAllWithHttpInfo(external, translations, acceptLanguage);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling SavedSearchManagementApi.HttpSavedSearchesGetAllWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **external** | **bool?** | This parameter filters out all saved searches on basis this boolean. | [optional]  |
| **translations** | **bool?** | When default language should be returned and the translation dictionary is delivered. (Ignores the \&quot;Accept-Language\&quot; header) | [optional]  |
| **acceptLanguage** | **string** | The requested language of the response. If not matching it falls back to default language. | [optional]  |

### Return type

[**List&lt;SavedSearch&gt;**](SavedSearch.md)

### Authorization

[msal_auth](../README.md#msal_auth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Returns all saved searches in database. |  -  |
| **401** | Unauthorized. Bearer Token not provided. |  -  |
| **500** | Internal server error. Please contact administrator. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

