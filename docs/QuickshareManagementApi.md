# Agravity.Public.Api.QuickshareManagementApi

All URIs are relative to *http://localhost:7071/api*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**HttpQuickShareGetById**](QuickshareManagementApi.md#httpquicksharegetbyid) | **GET** /quickshares/{id} |  |
| [**HttpQuickSharesCreate**](QuickshareManagementApi.md#httpquicksharescreate) | **POST** /quickshares |  |
| [**HttpQuickSharesDelete**](QuickshareManagementApi.md#httpquicksharesdelete) | **DELETE** /quickshares |  |
| [**HttpQuickSharesDeleteById**](QuickshareManagementApi.md#httpquicksharesdeletebyid) | **DELETE** /quickshares/{id} |  |
| [**HttpQuickSharesGet**](QuickshareManagementApi.md#httpquicksharesget) | **GET** /quickshares |  |

<a id="httpquicksharegetbyid"></a>
# **HttpQuickShareGetById**
> QuickShareFull HttpQuickShareGetById (string id, string continuationToken = null, int? limit = null, string orderby = null)



Returns one single quick share (from ID)

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Agravity.Public.Api;
using Agravity.Public.Client;
using Agravity.Public.Model;

namespace Example
{
    public class HttpQuickShareGetByIdExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost:7071/api";
            // Configure OAuth2 access token for authorization: msal_auth
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new QuickshareManagementApi(config);
            var id = "id_example";  // string | The ID of the quick share.
            var continuationToken = "continuationToken_example";  // string | Each result returns the continous token if more results are available than requested. With this token, the next page could be fetched. (URL encoded!) (optional) 
            var limit = 56;  // int? | This number limits the page result of assets. (optional) 
            var orderby = "orderby_example";  // string | How the return assets are sorted. Default is property: created_date (newest first). (optional) 

            try
            {
                QuickShareFull result = apiInstance.HttpQuickShareGetById(id, continuationToken, limit, orderby);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling QuickshareManagementApi.HttpQuickShareGetById: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the HttpQuickShareGetByIdWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<QuickShareFull> response = apiInstance.HttpQuickShareGetByIdWithHttpInfo(id, continuationToken, limit, orderby);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling QuickshareManagementApi.HttpQuickShareGetByIdWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **string** | The ID of the quick share. |  |
| **continuationToken** | **string** | Each result returns the continous token if more results are available than requested. With this token, the next page could be fetched. (URL encoded!) | [optional]  |
| **limit** | **int?** | This number limits the page result of assets. | [optional]  |
| **orderby** | **string** | How the return assets are sorted. Default is property: created_date (newest first). | [optional]  |

### Return type

[**QuickShareFull**](QuickShareFull.md)

### Authorization

[msal_auth](../README.md#msal_auth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Returns the quick share with the given ID. |  -  |
| **400** | Not valid quick share id! (Code: 02141b45-97dd-4474-aefb-a7774f8b538e) |  -  |
| **404** | Quick share date expired! (Code: 6758d66e-0ce6-4770-a497-01a578eac12c)&lt;br&gt;or Quick share was not found. (Code: 412f11e3-5606-4075-a319-74ff1cee6a3e)&lt;br&gt;or Quick share date expired! (Code: da53b1d3-83eb-4fec-9f7c-56b571f117b2)&lt;br&gt; |  -  |
| **401** | Unauthorized. Bearer Token not provided. |  -  |
| **500** | Internal server error. Please contact administrator. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="httpquicksharescreate"></a>
# **HttpQuickSharesCreate**
> QuickShare HttpQuickSharesCreate (QuickShare quickShare)



Creates an additional quick share

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Agravity.Public.Api;
using Agravity.Public.Client;
using Agravity.Public.Model;

namespace Example
{
    public class HttpQuickSharesCreateExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost:7071/api";
            // Configure OAuth2 access token for authorization: msal_auth
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new QuickshareManagementApi(config);
            var quickShare = new QuickShare(); // QuickShare | This creates / adds an unique quick share ID and adds the information to the collection (in DB).

            try
            {
                QuickShare result = apiInstance.HttpQuickSharesCreate(quickShare);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling QuickshareManagementApi.HttpQuickSharesCreate: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the HttpQuickSharesCreateWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<QuickShare> response = apiInstance.HttpQuickSharesCreateWithHttpInfo(quickShare);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling QuickshareManagementApi.HttpQuickSharesCreateWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **quickShare** | [**QuickShare**](QuickShare.md) | This creates / adds an unique quick share ID and adds the information to the collection (in DB). |  |

### Return type

[**QuickShare**](QuickShare.md)

### Authorization

[msal_auth](../README.md#msal_auth)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **201** | Returns the created quick share. |  -  |
| **400** | Quick share has no assets attached.  (Code: fccfb8fb-48be-4c97-9285-208cef71498c)&lt;br&gt;or quick share has assets with invalid IDs.  (Code: 13429a96-a87c-4928-981d-f5a76e724432)&lt;br&gt;or quick share could not be created when not in state &#39;A&#39;. (Code: 1cdd8574-734f-4f52-8da2-cecb8bfe3809)&lt;br&gt;or no quick share can be created without valid assets. (Code: 35d271b2-f807-4948-b3c3-508ab3802cca)or quick share could not be created in the past. (Code: 09cf3839-889d-4ff3-a29f-20b964a63df8) |  -  |
| **401** | Unauthorized. Bearer Token not provided. |  -  |
| **500** | Internal server error. Please contact administrator. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="httpquicksharesdelete"></a>
# **HttpQuickSharesDelete**
> void HttpQuickSharesDelete (string userid = null)



Dele tes all the quick shares of a specific user. If no userid is added, the user from the OAuth2 token is used.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Agravity.Public.Api;
using Agravity.Public.Client;
using Agravity.Public.Model;

namespace Example
{
    public class HttpQuickSharesDeleteExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost:7071/api";
            // Configure OAuth2 access token for authorization: msal_auth
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new QuickshareManagementApi(config);
            var userid = "userid_example";  // string | (Optional): The ID of the user. Only admins can query other users quick shares. (optional) 

            try
            {
                apiInstance.HttpQuickSharesDelete(userid);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling QuickshareManagementApi.HttpQuickSharesDelete: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the HttpQuickSharesDeleteWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    apiInstance.HttpQuickSharesDeleteWithHttpInfo(userid);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling QuickshareManagementApi.HttpQuickSharesDeleteWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **userid** | **string** | (Optional): The ID of the user. Only admins can query other users quick shares. | [optional]  |

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
| **400** | Could not determine user from token!  (Code: 9b845f08-76cd-47a1-a6bc-c6b90a3c260f)&lt;br&gt;Give user parameter is not a valid user ID!  (Code: b0af5400-a6a1-4bc2-92b5-c646d6686c3f)&lt;br&gt;Only admins are allowed to query quickshares of other users.  (Code: 8636819b-e190-4fb8-a25e-3ce771ab6baf) |  -  |
| **204** | The delete operation of the quick shares was successful. |  -  |
| **404** | If the quick share with the ID was not found. |  -  |
| **401** | Unauthorized. Bearer Token not provided. |  -  |
| **500** | Internal server error. Please contact administrator. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="httpquicksharesdeletebyid"></a>
# **HttpQuickSharesDeleteById**
> void HttpQuickSharesDeleteById (string id)



Deletes the quick share with the given ID.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Agravity.Public.Api;
using Agravity.Public.Client;
using Agravity.Public.Model;

namespace Example
{
    public class HttpQuickSharesDeleteByIdExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost:7071/api";
            // Configure OAuth2 access token for authorization: msal_auth
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new QuickshareManagementApi(config);
            var id = "id_example";  // string | The ID of the quick share.

            try
            {
                apiInstance.HttpQuickSharesDeleteById(id);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling QuickshareManagementApi.HttpQuickSharesDeleteById: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the HttpQuickSharesDeleteByIdWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    apiInstance.HttpQuickSharesDeleteByIdWithHttpInfo(id);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling QuickshareManagementApi.HttpQuickSharesDeleteByIdWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **string** | The ID of the quick share. |  |

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
| **404** | QuickShare does not exist (Code: a83dd9bb-7109-449a-b29f-bdc5caed9110) |  -  |
| **400** | Could not determine user from token!  (Code: cb61e00d-5305-47af-97a1-332380b7cdb2)&lt;br&gt;Given ID is not valid quick share ID!  (Code: a76f93b4-dbe1-461d-b7c2-818dc5aa537f)&lt;br&gt;Only admins are allowed to query quickshares of other users.  (Code: 8636819b-e190-4fb8-a25e-3ce771ab6baf) |  -  |
| **204** | The delete operation of the quick share with the given ID was successful. |  -  |
| **401** | Unauthorized. Bearer Token not provided. |  -  |
| **500** | Internal server error. Please contact administrator. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="httpquicksharesget"></a>
# **HttpQuickSharesGet**
> List&lt;QuickShare&gt; HttpQuickSharesGet (string userid = null)



This lists all the quick shares which are stored in the database for a specific user.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Agravity.Public.Api;
using Agravity.Public.Client;
using Agravity.Public.Model;

namespace Example
{
    public class HttpQuickSharesGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost:7071/api";
            // Configure OAuth2 access token for authorization: msal_auth
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new QuickshareManagementApi(config);
            var userid = "userid_example";  // string | (Optional): The ID of the user. Only admins can query other users quick shares. (optional) 

            try
            {
                List<QuickShare> result = apiInstance.HttpQuickSharesGet(userid);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling QuickshareManagementApi.HttpQuickSharesGet: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the HttpQuickSharesGetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<List<QuickShare>> response = apiInstance.HttpQuickSharesGetWithHttpInfo(userid);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling QuickshareManagementApi.HttpQuickSharesGetWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **userid** | **string** | (Optional): The ID of the user. Only admins can query other users quick shares. | [optional]  |

### Return type

[**List&lt;QuickShare&gt;**](QuickShare.md)

### Authorization

[msal_auth](../README.md#msal_auth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Returns the all quick shares as array. |  -  |
| **400** | Could not determine user from token!  (Code: 4960d570-ddc5-40f2-9d72-c9df89184a4d)&lt;br&gt;or Only admins are allowed to query quickshares of other users.  (Code: ffd27641-9afd-4585-99cc-4e951833a0fa)&lt;br&gt;or given collectionid parameter is not valid collection id!  (Code: ec16ac3b-92f4-4a14-a70e-0a53fecc9679) |  -  |
| **401** | Unauthorized. Bearer Token not provided. |  -  |
| **500** | Internal server error. Please contact administrator. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

