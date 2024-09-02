# Agravity.Public.Api.SecureUploadApi

All URIs are relative to *http://localhost:7071/api*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**HttpGetSecureUploadApiKeyById**](SecureUploadApi.md#httpgetsecureuploadapikeybyid) | **GET** /secureupload/{id}/apikey |  |
| [**HttpGetSecureUploadListOfUser**](SecureUploadApi.md#httpgetsecureuploadlistofuser) | **GET** /secureupload |  |
| [**HttpSecureUploadCreateForUser**](SecureUploadApi.md#httpsecureuploadcreateforuser) | **POST** /secureupload |  |
| [**HttpSecureUploadEntityCheckById**](SecureUploadApi.md#httpsecureuploadentitycheckbyid) | **GET** /secureupload/{id} |  |
| [**HttpSecureUploadToCollectionsDeleteById**](SecureUploadApi.md#httpsecureuploadtocollectionsdeletebyid) | **DELETE** /secureupload/{id} |  |

<a id="httpgetsecureuploadapikeybyid"></a>
# **HttpGetSecureUploadApiKeyById**
> ApiKeyResponse HttpGetSecureUploadApiKeyById (string id)



Returns the API Key of a secure upload

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Agravity.Public.Api;
using Agravity.Public.Client;
using Agravity.Public.Model;

namespace Example
{
    public class HttpGetSecureUploadApiKeyByIdExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost:7071/api";
            // Configure OAuth2 access token for authorization: msal_auth
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new SecureUploadApi(config);
            var id = "id_example";  // string | The ID of the secure upload collection.

            try
            {
                ApiKeyResponse result = apiInstance.HttpGetSecureUploadApiKeyById(id);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling SecureUploadApi.HttpGetSecureUploadApiKeyById: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the HttpGetSecureUploadApiKeyByIdWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<ApiKeyResponse> response = apiInstance.HttpGetSecureUploadApiKeyByIdWithHttpInfo(id);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling SecureUploadApi.HttpGetSecureUploadApiKeyByIdWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **string** | The ID of the secure upload collection. |  |

### Return type

[**ApiKeyResponse**](ApiKeyResponse.md)

### Authorization

[msal_auth](../README.md#msal_auth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Returns the API key of the given ID. |  -  |
| **400** | Not a valid secure upload id! (Code: f233ecb7-9f4e-43df-a6b6-172aa9ee66d0) |  -  |
| **404** | Secure upload entity not found for this user. (Code: 27ccd9e4-f5aa-4826-8384-b59451987bb9)&lt;br&gt;or secure upload entity not found. (Code: 639ec439-2ec0-4c4e-9d5b-688be06e2234)&lt;br&gt;or collection on which this secure upload is based, doesn&#39;t exist or is invalid! (Code: 3adffb93-800d-46a2-9bde-341216fc5f01) |  -  |
| **401** | Unauthorized. Bearer Token not provided. |  -  |
| **500** | Internal server error. Please contact administrator. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="httpgetsecureuploadlistofuser"></a>
# **HttpGetSecureUploadListOfUser**
> List&lt;SecureUploadEntity&gt; HttpGetSecureUploadListOfUser (string collectionid = null)



This lists the secure upload collection which are stored in the database for a specific user (Taken from Bearer token).

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Agravity.Public.Api;
using Agravity.Public.Client;
using Agravity.Public.Model;

namespace Example
{
    public class HttpGetSecureUploadListOfUserExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost:7071/api";
            // Configure OAuth2 access token for authorization: msal_auth
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new SecureUploadApi(config);
            var collectionid = "collectionid_example";  // string | (optional) The ID of the collection where this secure upload should be filtered. (optional) 

            try
            {
                List<SecureUploadEntity> result = apiInstance.HttpGetSecureUploadListOfUser(collectionid);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling SecureUploadApi.HttpGetSecureUploadListOfUser: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the HttpGetSecureUploadListOfUserWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<List<SecureUploadEntity>> response = apiInstance.HttpGetSecureUploadListOfUserWithHttpInfo(collectionid);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling SecureUploadApi.HttpGetSecureUploadListOfUserWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **collectionid** | **string** | (optional) The ID of the collection where this secure upload should be filtered. | [optional]  |

### Return type

[**List&lt;SecureUploadEntity&gt;**](SecureUploadEntity.md)

### Authorization

[msal_auth](../README.md#msal_auth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Returns the list of secure upload entities for a user. |  -  |
| **400** | If collection id is given but not in right format (valid). (Code: 287ed737-9adc-41c5-aaf1-bbb333ff9808)&lt;br&gt;Could not determine user from token. (Code: e1eb7b29-e501-4727-bec3-26f5099b7418) |  -  |
| **401** | Unauthorized. Bearer Token not provided. |  -  |
| **500** | Internal server error. Please contact administrator. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="httpsecureuploadcreateforuser"></a>
# **HttpSecureUploadCreateForUser**
> SecureUploadEntity HttpSecureUploadCreateForUser (SecureUploadEntity secureUploadEntity, bool? sftpenabled = null)



Creates an secure upload entry point for a collection

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Agravity.Public.Api;
using Agravity.Public.Client;
using Agravity.Public.Model;

namespace Example
{
    public class HttpSecureUploadCreateForUserExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost:7071/api";
            // Configure OAuth2 access token for authorization: msal_auth
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new SecureUploadApi(config);
            var secureUploadEntity = new SecureUploadEntity(); // SecureUploadEntity | This creates / adds an unique secure upload collection ID and adds the information to the collection (in DB).
            var sftpenabled = true;  // bool? | Used to enable sftp secure file upload (optional) 

            try
            {
                SecureUploadEntity result = apiInstance.HttpSecureUploadCreateForUser(secureUploadEntity, sftpenabled);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling SecureUploadApi.HttpSecureUploadCreateForUser: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the HttpSecureUploadCreateForUserWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<SecureUploadEntity> response = apiInstance.HttpSecureUploadCreateForUserWithHttpInfo(secureUploadEntity, sftpenabled);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling SecureUploadApi.HttpSecureUploadCreateForUserWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **secureUploadEntity** | [**SecureUploadEntity**](SecureUploadEntity.md) | This creates / adds an unique secure upload collection ID and adds the information to the collection (in DB). |  |
| **sftpenabled** | **bool?** | Used to enable sftp secure file upload | [optional]  |

### Return type

[**SecureUploadEntity**](SecureUploadEntity.md)

### Authorization

[msal_auth](../README.md#msal_auth)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **201** | Returns the created secure upload entity for a collection. |  -  |
| **400** | Secure Upload password is mandatory, but missing or empty. (Code: 824279e8-53d8-4b51-959e-96fa21d5f781)&lt;br&gt;or length not sufficient (min. 6 characters). (Code: 5f539832-3d5f-41ed-ad63-81b850044011)&lt;br&gt;or password contains not allowed characters. Allowed: a..z A..Z 0..9 !?@\&quot;$% &amp;/|\\&#x3D; +*#-_.:,;&lt;&gt;()[]{}&#39;  (Code: 68435cd1-7845-4b4a-b189-64cdb474780e)&lt;br&gt;or must have a target url. (Code: ae9c8f1d-72e6-44c9-81f8-bc6f86a30aa7)&lt;br&gt;Secure Upload collection must be active. Code: f2c7db9b-4a22-4159-9e08-bce795d79d48)&lt;br&gt;or could not be created in the past.  (Code: e44d1017-2a6c-4285-b532-869d9ced11cd)&lt;br&gt;or could not extract user from Bearer token.  (Code: 168a9d0d-d12d-4a58-b143-76c20dab36ac)&lt;br&gt;or could not create api keys for azure public functions.  (Code: 575e1542-b440-4495-8db3-2b684f6d11dd) |  -  |
| **401** | Unauthorized. Bearer Token not provided. |  -  |
| **404** | Secure Upload collection is not valid or could not be found.  (Code: a2ee7e44-7577-4a90-ba86-80a5db404cfa) |  -  |
| **500** | Internal server error. Please contact administrator. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="httpsecureuploadentitycheckbyid"></a>
# **HttpSecureUploadEntityCheckById**
> SecureUploadEntity HttpSecureUploadEntityCheckById (string id)



Returns one single secure upload entity from ID

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Agravity.Public.Api;
using Agravity.Public.Client;
using Agravity.Public.Model;

namespace Example
{
    public class HttpSecureUploadEntityCheckByIdExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost:7071/api";
            // Configure OAuth2 access token for authorization: msal_auth
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new SecureUploadApi(config);
            var id = "id_example";  // string | The ID of the secure upload collection.

            try
            {
                SecureUploadEntity result = apiInstance.HttpSecureUploadEntityCheckById(id);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling SecureUploadApi.HttpSecureUploadEntityCheckById: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the HttpSecureUploadEntityCheckByIdWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<SecureUploadEntity> response = apiInstance.HttpSecureUploadEntityCheckByIdWithHttpInfo(id);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling SecureUploadApi.HttpSecureUploadEntityCheckByIdWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **string** | The ID of the secure upload collection. |  |

### Return type

[**SecureUploadEntity**](SecureUploadEntity.md)

### Authorization

[msal_auth](../README.md#msal_auth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Returns one single secure upload entity from ID. |  -  |
| **400** | Not a valid secure upload id! (Code: f233ecb7-9f4e-43df-a6b6-172aa9ee66d0) |  -  |
| **401** | Unauthorized. Bearer Token not provided. |  -  |
| **404** | Secure upload entity not found for this user. (Code: 27ccd9e4-f5aa-4826-8384-b59451987bb9)&lt;br&gt;or secure upload entity not found. (Code: 639ec439-2ec0-4c4e-9d5b-688be06e2234)&lt;br&gt;or collection on which this secure upload is based, doesn&#39;t exist or is invalid! (Code: 3adffb93-800d-46a2-9bde-341216fc5f01) |  -  |
| **500** | Internal server error. Please contact administrator. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="httpsecureuploadtocollectionsdeletebyid"></a>
# **HttpSecureUploadToCollectionsDeleteById**
> void HttpSecureUploadToCollectionsDeleteById (string id)



Deletes (= disables) the secure upload to collection with the given ID.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Agravity.Public.Api;
using Agravity.Public.Client;
using Agravity.Public.Model;

namespace Example
{
    public class HttpSecureUploadToCollectionsDeleteByIdExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost:7071/api";
            // Configure OAuth2 access token for authorization: msal_auth
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new SecureUploadApi(config);
            var id = "id_example";  // string | The ID of the secure upload collection.

            try
            {
                apiInstance.HttpSecureUploadToCollectionsDeleteById(id);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling SecureUploadApi.HttpSecureUploadToCollectionsDeleteById: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the HttpSecureUploadToCollectionsDeleteByIdWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    apiInstance.HttpSecureUploadToCollectionsDeleteByIdWithHttpInfo(id);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling SecureUploadApi.HttpSecureUploadToCollectionsDeleteByIdWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **string** | The ID of the secure upload collection. |  |

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
| **400** | Not a valid secure upload id! (Code: f233ecb7-9f4e-43df-a6b6-172aa9ee66d0)&lt;br&gt;Could not delete api keys for azure public functions. (Code: 98a76e1d-15d2-460f-85db-7f74cac0d7e6) |  -  |
| **204** | The delete operation of the secure upload to collection with the given ID was successful. |  -  |
| **401** | Unauthorized. Bearer Token not provided. |  -  |
| **404** | Secure upload entity not found for this user. (Code: 27ccd9e4-f5aa-4826-8384-b59451987bb9)&lt;br&gt;Secure upload entity not found. (Code: 639ec439-2ec0-4c4e-9d5b-688be06e2234)&lt;br&gt;Collection on which this secure upload is based, doesn&#39;t exist or is invalid! (Code: 3adffb93-800d-46a2-9bde-341216fc5f01) |  -  |
| **500** | Internal server error. Please contact administrator. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

