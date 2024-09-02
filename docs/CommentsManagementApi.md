# Agravity.Public.Api.CommentsManagementApi

All URIs are relative to *http://localhost:7071/api*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**HttpCommentsCreate**](CommentsManagementApi.md#httpcommentscreate) | **POST** /assets/{id}/comments |  |
| [**HttpCommentsDeleteById**](CommentsManagementApi.md#httpcommentsdeletebyid) | **DELETE** /comments/{id} |  |
| [**HttpCommentsGetAllForAsset**](CommentsManagementApi.md#httpcommentsgetallforasset) | **GET** /assets/{id}/comments |  |
| [**HttpCommentsUpdateById**](CommentsManagementApi.md#httpcommentsupdatebyid) | **POST** /comments/{id} |  |

<a id="httpcommentscreate"></a>
# **HttpCommentsCreate**
> Comment HttpCommentsCreate (string id, Comment comment)



This endpoint creates a comment for an asset and adds the information to the database.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Agravity.Public.Api;
using Agravity.Public.Client;
using Agravity.Public.Model;

namespace Example
{
    public class HttpCommentsCreateExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost:7071/api";
            // Configure OAuth2 access token for authorization: msal_auth
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new CommentsManagementApi(config);
            var id = "id_example";  // string | The ID of the asset.
            var comment = new Comment(); // Comment | The comment to create.

            try
            {
                Comment result = apiInstance.HttpCommentsCreate(id, comment);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling CommentsManagementApi.HttpCommentsCreate: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the HttpCommentsCreateWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<Comment> response = apiInstance.HttpCommentsCreateWithHttpInfo(id, comment);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling CommentsManagementApi.HttpCommentsCreateWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **string** | The ID of the asset. |  |
| **comment** | [**Comment**](Comment.md) | The comment to create. |  |

### Return type

[**Comment**](Comment.md)

### Authorization

[msal_auth](../README.md#msal_auth)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **201** | Returns the created comment. |  -  |
| **400** | Object is not a valid comment. (Code: 62c08aac-cd20-4146-bf96-44163e53c3f3)&lt;br&gt;No input object given. (Code: 0eeb7df8-d928-44a3-8f8b-32d8ceb7808a) |  -  |
| **404** | The requested item could not be found. |  -  |
| **401** | Unauthorized. Bearer Token not provided. |  -  |
| **500** | Internal server error. Please contact administrator. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="httpcommentsdeletebyid"></a>
# **HttpCommentsDeleteById**
> void HttpCommentsDeleteById (string id)



This endpoint deletes a single comment.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Agravity.Public.Api;
using Agravity.Public.Client;
using Agravity.Public.Model;

namespace Example
{
    public class HttpCommentsDeleteByIdExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost:7071/api";
            // Configure OAuth2 access token for authorization: msal_auth
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new CommentsManagementApi(config);
            var id = "id_example";  // string | The ID of the comment.

            try
            {
                apiInstance.HttpCommentsDeleteById(id);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling CommentsManagementApi.HttpCommentsDeleteById: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the HttpCommentsDeleteByIdWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    apiInstance.HttpCommentsDeleteByIdWithHttpInfo(id);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling CommentsManagementApi.HttpCommentsDeleteByIdWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **string** | The ID of the comment. |  |

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
| **400** | Error trying to delete the comment with the given ID. |  -  |
| **204** | The delete operation of the comment with the given ID was successful. |  -  |
| **404** | If the comment with the ID was not found. |  -  |
| **401** | Unauthorized. Bearer Token not provided. |  -  |
| **500** | Internal server error. Please contact administrator. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="httpcommentsgetallforasset"></a>
# **HttpCommentsGetAllForAsset**
> List&lt;Comment&gt; HttpCommentsGetAllForAsset (string id)



This endpoint lists all comments for an asset in database.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Agravity.Public.Api;
using Agravity.Public.Client;
using Agravity.Public.Model;

namespace Example
{
    public class HttpCommentsGetAllForAssetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost:7071/api";
            // Configure OAuth2 access token for authorization: msal_auth
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new CommentsManagementApi(config);
            var id = "id_example";  // string | The ID of the asset.

            try
            {
                List<Comment> result = apiInstance.HttpCommentsGetAllForAsset(id);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling CommentsManagementApi.HttpCommentsGetAllForAsset: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the HttpCommentsGetAllForAssetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<List<Comment>> response = apiInstance.HttpCommentsGetAllForAssetWithHttpInfo(id);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling CommentsManagementApi.HttpCommentsGetAllForAssetWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **string** | The ID of the asset. |  |

### Return type

[**List&lt;Comment&gt;**](Comment.md)

### Authorization

[msal_auth](../README.md#msal_auth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Returns all comments for an asset in database. |  -  |
| **404** | The requested item could not be found. |  -  |
| **401** | Unauthorized. Bearer Token not provided. |  -  |
| **500** | Internal server error. Please contact administrator. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="httpcommentsupdatebyid"></a>
# **HttpCommentsUpdateById**
> Comment HttpCommentsUpdateById (string id, Comment comment)



Updates a comment in database.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Agravity.Public.Api;
using Agravity.Public.Client;
using Agravity.Public.Model;

namespace Example
{
    public class HttpCommentsUpdateByIdExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost:7071/api";
            // Configure OAuth2 access token for authorization: msal_auth
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new CommentsManagementApi(config);
            var id = "id_example";  // string | The ID of the comment.
            var comment = new Comment(); // Comment | Body has to be a valid comment item.

            try
            {
                Comment result = apiInstance.HttpCommentsUpdateById(id, comment);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling CommentsManagementApi.HttpCommentsUpdateById: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the HttpCommentsUpdateByIdWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<Comment> response = apiInstance.HttpCommentsUpdateByIdWithHttpInfo(id, comment);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling CommentsManagementApi.HttpCommentsUpdateByIdWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **string** | The ID of the comment. |  |
| **comment** | [**Comment**](Comment.md) | Body has to be a valid comment item. |  |

### Return type

[**Comment**](Comment.md)

### Authorization

[msal_auth](../README.md#msal_auth)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Returns the updated comment |  -  |
| **400** | Object is not a valid comment. (Code: 79339381-133a-4d5f-9bbe-9d256ab0ab9b) &lt;br&gt;No input object given. (Code: 74f2b98d-a40f-4ce4-b50d-272b8ac57427)Error on create collection type item group in database - max retry count is reached. (Code: 0e315213-9a9a-4ac4-9036-4e928c44161d) |  -  |
| **404** | If the comment with the ID was not found. |  -  |
| **401** | Unauthorized. Bearer Token not provided. |  -  |
| **500** | Internal server error. Please contact administrator. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

