# Agravity.Public.Api.WordpressManagementApi

All URIs are relative to *http://localhost:7071/api*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**HttpWordpressPage**](WordpressManagementApi.md#httpwordpresspage) | **POST** /wordpresspage |  |
| [**HttpWordpressPost**](WordpressManagementApi.md#httpwordpresspost) | **POST** /wordpresspost |  |

<a id="httpwordpresspage"></a>
# **HttpWordpressPage**
> int HttpWordpressPage (string pageTitle, string pageContentBefore, string pageImage, string pageContentAfter, Asset asset)



This endpoint creates a Wordpress Page

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Agravity.Public.Api;
using Agravity.Public.Client;
using Agravity.Public.Model;

namespace Example
{
    public class HttpWordpressPageExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost:7071/api";
            // Configure OAuth2 access token for authorization: msal_auth
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new WordpressManagementApi(config);
            var pageTitle = "pageTitle_example";  // string | The title of the wordpress post.
            var pageContentBefore = "pageContentBefore_example";  // string | The excerpt of the wordpress page as well as the first part of the page.
            var pageImage = "pageImage_example";  // string | The URL where the image can be publically retrieved.
            var pageContentAfter = "pageContentAfter_example";  // string | The content of the wordpress page, which is shown below the image.
            var asset = new Asset(); // Asset | This endpoint creates a Wordpress Page

            try
            {
                int result = apiInstance.HttpWordpressPage(pageTitle, pageContentBefore, pageImage, pageContentAfter, asset);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling WordpressManagementApi.HttpWordpressPage: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the HttpWordpressPageWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<int> response = apiInstance.HttpWordpressPageWithHttpInfo(pageTitle, pageContentBefore, pageImage, pageContentAfter, asset);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling WordpressManagementApi.HttpWordpressPageWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **pageTitle** | **string** | The title of the wordpress post. |  |
| **pageContentBefore** | **string** | The excerpt of the wordpress page as well as the first part of the page. |  |
| **pageImage** | **string** | The URL where the image can be publically retrieved. |  |
| **pageContentAfter** | **string** | The content of the wordpress page, which is shown below the image. |  |
| **asset** | [**Asset**](Asset.md) | This endpoint creates a Wordpress Page |  |

### Return type

**int**

### Authorization

[msal_auth](../README.md#msal_auth)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **201** | Returns a id of the page, if the page was created successsfully. |  -  |
| **400** | Page title not valid. (Code: bad76cad-a85d-4edb-a4ab-0817bd168a4c) |  -  |
| **401** | Unauthorized. Bearer Token not provided. |  -  |
| **500** | Internal server error. Please contact administrator. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="httpwordpresspost"></a>
# **HttpWordpressPost**
> int HttpWordpressPost (string postTitle, string postContentBefore, string postImage, string postContentAfter, Asset asset)



This endpoint creates a Wordpress Post

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Agravity.Public.Api;
using Agravity.Public.Client;
using Agravity.Public.Model;

namespace Example
{
    public class HttpWordpressPostExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost:7071/api";
            // Configure OAuth2 access token for authorization: msal_auth
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new WordpressManagementApi(config);
            var postTitle = "postTitle_example";  // string | The title of the wordpress post.
            var postContentBefore = "postContentBefore_example";  // string | The excerpt of the wordpress post as well as the first part of the post.
            var postImage = "postImage_example";  // string | The URL where the image can be publically retrieved.
            var postContentAfter = "postContentAfter_example";  // string | The content of the wordpress post, which is shown below the image.
            var asset = new Asset(); // Asset | This endpoint creates a Wordpress Post

            try
            {
                int result = apiInstance.HttpWordpressPost(postTitle, postContentBefore, postImage, postContentAfter, asset);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling WordpressManagementApi.HttpWordpressPost: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the HttpWordpressPostWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<int> response = apiInstance.HttpWordpressPostWithHttpInfo(postTitle, postContentBefore, postImage, postContentAfter, asset);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling WordpressManagementApi.HttpWordpressPostWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **postTitle** | **string** | The title of the wordpress post. |  |
| **postContentBefore** | **string** | The excerpt of the wordpress post as well as the first part of the post. |  |
| **postImage** | **string** | The URL where the image can be publically retrieved. |  |
| **postContentAfter** | **string** | The content of the wordpress post, which is shown below the image. |  |
| **asset** | [**Asset**](Asset.md) | This endpoint creates a Wordpress Post |  |

### Return type

**int**

### Authorization

[msal_auth](../README.md#msal_auth)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **201** | Returns a id of the post, if the post was created successsfully. |  -  |
| **400** | Post title not valid. (Code: 2f7bac2d-9145-4098-9b88-0b2ae03c2553) |  -  |
| **401** | Unauthorized. Bearer Token not provided. |  -  |
| **500** | Internal server error. Please contact administrator. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

