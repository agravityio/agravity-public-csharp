# AgravityPublic.Api.PublicCollectionSecureUploadApi

All URIs are relative to *http://localhost:7072/api*

Method | HTTP request | Description
------------- | ------------- | -------------
[**HttpSecureUploadEntityCheckById**](PublicCollectionSecureUploadApi.md#httpsecureuploadentitycheckbyid) | **GET** /secureupload/{id} | 
[**HttpSecureUploadFileById**](PublicCollectionSecureUploadApi.md#httpsecureuploadfilebyid) | **POST** /secureupload/{id}/upload | 



## HttpSecureUploadEntityCheckById

> SecureUploadEntity HttpSecureUploadEntityCheckById (string id, string code)



Searchs for one single secure upload entity of an user and returns simple OK if found.

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using AgravityPublic.Api;
using AgravityPublic.Client;
using AgravityPublic.Model;

namespace Example
{
    public class HttpSecureUploadEntityCheckByIdExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "http://localhost:7072/api";
            // Configure API key authorization: function_key
            Configuration.Default.AddApiKey("x-functions-key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("x-functions-key", "Bearer");

            var apiInstance = new PublicCollectionSecureUploadApi(Configuration.Default);
            var id = "id_example";  // string | The ID of the secure upload collection.
            var code = "code_example";  // string | The API key to access this endpoint. (Alternative using header x-function-keys with same value)

            try
            {
                SecureUploadEntity result = apiInstance.HttpSecureUploadEntityCheckById(id, code);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling PublicCollectionSecureUploadApi.HttpSecureUploadEntityCheckById: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| The ID of the secure upload collection. | 
 **code** | **string**| The API key to access this endpoint. (Alternative using header x-function-keys with same value) | 

### Return type

[**SecureUploadEntity**](SecureUploadEntity.md)

### Authorization

[function_key](../README.md#function_key)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Returns 200 (OK) and returns the element - if this still exists, is valid and API Key is accepted. |  -  |
| **400** | Not a valid secure upload id! (Code: f233ecb7-9f4e-43df-a6b6-172aa9ee66d0)&lt;br&gt;or No API key was provided. Please use &#39;code&#39; param or &#39;x-functions-key&#39; header property. (Code: a8843706-c481-4859-9555-2423dbdcc1a2)&lt;br&gt;or No matching API key or wrong password for this secure upload entity. (Code: e39a5c12-bbeb-4056-b717-2af89e21b319)&lt;br&gt;or Provided API key seems to be valid for authorization, but not to access this secure upload. (Code: ec38934a-43be-48ba-bf6f-b2e3b505812c)&lt;br&gt;or Secure upload entity date expired! (Code: c7ec0d4d-95e5-4211-b89e-c88a05d89571)}&lt;br&gt;or Provided API key seems to be valid for authentication, the ID does not match. (Code: d8e07922-173d-420c-a75c-539a5a182ad1) |  -  |
| **404** | Secure upload entity not found for this user. (Code: 27ccd9e4-f5aa-4826-8384-b59451987bb9)&lt;br&gt;or Secure upload entity not found. (Code: 639ec439-2ec0-4c4e-9d5b-688be06e2234)&lt;br&gt;or Collection on which this secure upload is based, doesn&#39;t exist or is invalid! (Code: 3adffb93-800d-46a2-9bde-341216fc5f01) |  -  |
| **401** | Unauthorized. API Key not provided. |  -  |
| **500** | Internal server error. Please contact administrator. |  -  |

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## HttpSecureUploadFileById

> Asset HttpSecureUploadFileById (string id, string code, Object body)



This endpoint allows to securly upload one asset which is put onto the storage (INBOX). Object has to be FormData (Add file).

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using AgravityPublic.Api;
using AgravityPublic.Client;
using AgravityPublic.Model;

namespace Example
{
    public class HttpSecureUploadFileByIdExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "http://localhost:7072/api";
            // Configure API key authorization: function_key
            Configuration.Default.AddApiKey("x-functions-key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("x-functions-key", "Bearer");

            var apiInstance = new PublicCollectionSecureUploadApi(Configuration.Default);
            var id = "id_example";  // string | The ID of the secure upload collection.
            var code = "code_example";  // string | The API key to access this endpoint. (Alternative using header x-function-keys with same value)
            var body = null;  // Object | This endpoint allows to upload one asset which is put onto the storage (INBOX). Object has to be FormData (Add file).

            try
            {
                Asset result = apiInstance.HttpSecureUploadFileById(id, code, body);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling PublicCollectionSecureUploadApi.HttpSecureUploadFileById: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| The ID of the secure upload collection. | 
 **code** | **string**| The API key to access this endpoint. (Alternative using header x-function-keys with same value) | 
 **body** | **Object**| This endpoint allows to upload one asset which is put onto the storage (INBOX). Object has to be FormData (Add file). | 

### Return type

[**Asset**](Asset.md)

### Authorization

[function_key](../README.md#function_key)

### HTTP request headers

- **Content-Type**: application/json
- **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **201** | Returns the asset which was created. |  -  |
| **400** | Secure upload failed. Content length is insuffient (0 or defined limit - default and maximum: 25MB) (Code: bf2bdfc4-de75-42e4-add7-6cf7a546a3c0)&lt;br&gt;or Not a valid secure upload id! (Code: f233ecb7-9f4e-43df-a6b6-172aa9ee66d0)&lt;br&gt;or No API key was provided. Please use &#39;code&#39; param or &#39;x-functions-key&#39; header property. (Code: a8843706-c481-4859-9555-2423dbdcc1a2)&lt;br&gt;or No matching API key or wrong password for this secure upload entity. (Code: e39a5c12-bbeb-4056-b717-2af89e21b319)&lt;br&gt;or Provided API key seems to be valid for authorization, but not to access this secure upload. (Code: ec38934a-43be-48ba-bf6f-b2e3b505812c)&lt;br&gt;or Secure upload entity date expired! (Code: c7ec0d4d-95e5-4211-b89e-c88a05d89571)&lt;br&gt;or Provided API key seems to be valid for authentication, the ID does not match. (Code: d8e07922-173d-420c-a75c-539a5a182ad1)&lt;br&gt;or Wrong content media type. Please upload file with multipart/form-data. (Code: 4cdc8bde-e79f-4f52-a4cc-7b7c4d967b3c)&lt;br&gt;or Could not find file in multi-part data. (Code: 00440233-ef4a-48a1-ad7d-824232d7a17f)&lt;br&gt;or This file is not supported. (Code: 4b086d7e-dda3-4530-9d23-41a32a91b0fe) |  -  |
| **404** | Secure upload entity not found for this user. (Code: 27ccd9e4-f5aa-4826-8384-b59451987bb9)&lt;br&gt;or Secure upload entity not found. (Code: 639ec439-2ec0-4c4e-9d5b-688be06e2234)&lt;br&gt;or Collection on which this secure upload is based, doesn&#39;t exist or is invalid! (Code: 3adffb93-800d-46a2-9bde-341216fc5f01)&lt;br&gt;or If the collection where this secure upload points to is not found. |  -  |
| **401** | Unauthorized. API Key not provided. |  -  |
| **500** | Internal server error. Please contact administrator. |  -  |

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)

