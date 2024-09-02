# Agravity.Public.Api.TranslationManagementApi

All URIs are relative to *http://localhost:7071/api*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**HttpBulkTranslations**](TranslationManagementApi.md#httpbulktranslations) | **POST** /translations |  |
| [**HttpCognitiveTranslateText**](TranslationManagementApi.md#httpcognitivetranslatetext) | **POST** /translations-ai |  |
| [**HttpTranslationsById**](TranslationManagementApi.md#httptranslationsbyid) | **GET** /translations/{id} |  |
| [**HttpTranslationsByIdFilterByCustomField**](TranslationManagementApi.md#httptranslationsbyidfilterbycustomfield) | **GET** /translations/{id}/custom/{customField} |  |
| [**HttpTranslationsByIdFilterByProperty**](TranslationManagementApi.md#httptranslationsbyidfilterbyproperty) | **GET** /translations/{id}/{property} |  |
| [**HttpUpdateTranslationsById**](TranslationManagementApi.md#httpupdatetranslationsbyid) | **POST** /translations/{id} |  |

<a id="httpbulktranslations"></a>
# **HttpBulkTranslations**
> List&lt;EntityTranslations&gt; HttpBulkTranslations (List<string> requestBody, string property = null)



Get all the translations of a whole list of translatable entities.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Agravity.Public.Api;
using Agravity.Public.Client;
using Agravity.Public.Model;

namespace Example
{
    public class HttpBulkTranslationsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost:7071/api";
            // Configure OAuth2 access token for authorization: msal_auth
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new TranslationManagementApi(config);
            var requestBody = new List<string>(); // List<string> | A list of entity IDs (can be assets, collections, collection types, download formats, etc.
            var property = "property_example";  // string | If given the only translations of this property are returned. (optional) 

            try
            {
                List<EntityTranslations> result = apiInstance.HttpBulkTranslations(requestBody, property);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling TranslationManagementApi.HttpBulkTranslations: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the HttpBulkTranslationsWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<List<EntityTranslations>> response = apiInstance.HttpBulkTranslationsWithHttpInfo(requestBody, property);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling TranslationManagementApi.HttpBulkTranslationsWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **requestBody** | [**List&lt;string&gt;**](string.md) | A list of entity IDs (can be assets, collections, collection types, download formats, etc. |  |
| **property** | **string** | If given the only translations of this property are returned. | [optional]  |

### Return type

[**List&lt;EntityTranslations&gt;**](EntityTranslations.md)

### Authorization

[msal_auth](../README.md#msal_auth)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Returns a list of all requested entities and their translations. |  -  |
| **400** | Object is not a valid list of entity ids. (Code: 654ba96b-1dec-4696-b665-b942ab6074d3) &lt;br/&gt;Entity id list is empty. (Code: 3368271e-1666-4305-84d2-74fe143fd46c)Id is not of any known entity type. (Code: d2d397e6-ba9b-49ac-b1ef-fcd690c93870) |  -  |
| **404** | Could not find entity with id: {{id}}. (Code: 28e7abb6-d322-4262-93f3-b0f5cfa5ce97) |  -  |
| **401** | Unauthorized. Bearer Token not provided. |  -  |
| **500** | Internal server error. Please contact administrator. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="httpcognitivetranslatetext"></a>
# **HttpCognitiveTranslateText**
> List&lt;Translation&gt; HttpCognitiveTranslateText (TranslationRequest translationRequest)



Translates the given text into the requested languages by the Microsoft AI Translator. (only when enabled in settings)

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Agravity.Public.Api;
using Agravity.Public.Client;
using Agravity.Public.Model;

namespace Example
{
    public class HttpCognitiveTranslateTextExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost:7071/api";
            // Configure OAuth2 access token for authorization: msal_auth
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new TranslationManagementApi(config);
            var translationRequest = new TranslationRequest(); // TranslationRequest | This endpoint creates translations for the provided text

            try
            {
                List<Translation> result = apiInstance.HttpCognitiveTranslateText(translationRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling TranslationManagementApi.HttpCognitiveTranslateText: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the HttpCognitiveTranslateTextWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<List<Translation>> response = apiInstance.HttpCognitiveTranslateTextWithHttpInfo(translationRequest);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling TranslationManagementApi.HttpCognitiveTranslateTextWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **translationRequest** | [**TranslationRequest**](TranslationRequest.md) | This endpoint creates translations for the provided text |  |

### Return type

[**List&lt;Translation&gt;**](Translation.md)

### Authorization

[msal_auth](../README.md#msal_auth)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | The OK response |  -  |
| **400** | Object could not be parsed. Has to be of type {nameof(TranslationRequest)}. (Code: 3aab2c0f-7e61-43a3-90b8-858c0091bb41)&lt;br&gt;Object is not a valid {nameof(TranslationRequest)}. (Code: aaea8e3c-4613-43fa-8a24-9d4928596ddf)&lt;br&gt;Translation Service responded with an error. There is maybe an error in the translation parameter: {responseMessage}. (Code: 8e438b7b-4430-485a-b462-52ac9678b83)Translation Service responded with an error. There went something wrong with the provided API Key: {responseMessage}. (Code: 2e89feec-469a-46d4-a8d5-dfa17b8726ba) |  -  |
| **401** | Unauthorized. Bearer Token not provided. |  -  |
| **500** | Internal server error. Please contact administrator. |  -  |
| **503** | Service is not available. Please contact administrator. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="httptranslationsbyid"></a>
# **HttpTranslationsById**
> Dictionary&lt;string, Dictionary&lt;string, Object&gt;&gt; HttpTranslationsById (string id, bool? items = null)



Get all the translations of a whole entity (Asset, Collection, Collection Type, Download Format)

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Agravity.Public.Api;
using Agravity.Public.Client;
using Agravity.Public.Model;

namespace Example
{
    public class HttpTranslationsByIdExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost:7071/api";
            // Configure OAuth2 access token for authorization: msal_auth
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new TranslationManagementApi(config);
            var id = "id_example";  // string | The ID of any translateable entity (Asset, Collection, Collection Type, Download Format).
            var items = true;  // bool? | If the items should be included (only for entity type Collection and Asset). (optional) 

            try
            {
                Dictionary<string, Dictionary<string, Object>> result = apiInstance.HttpTranslationsById(id, items);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling TranslationManagementApi.HttpTranslationsById: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the HttpTranslationsByIdWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<Dictionary<string, Dictionary<string, Object>>> response = apiInstance.HttpTranslationsByIdWithHttpInfo(id, items);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling TranslationManagementApi.HttpTranslationsByIdWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **string** | The ID of any translateable entity (Asset, Collection, Collection Type, Download Format). |  |
| **items** | **bool?** | If the items should be included (only for entity type Collection and Asset). | [optional]  |

### Return type

**Dictionary<string, Dictionary<string, Object>>**

### Authorization

[msal_auth](../README.md#msal_auth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Returns the dictionary of the dictionaries with all translations  |  -  |
| **400** | Could not get all translations from {id}! (Code: fd86fae5-1eed-4770-b519-d403b85fa1d0) &lt;br/&gt;Could not get entity {id} from database! (Code: eb42dc0d-78ee-4fc9-9a65-d5df472c7a03) |  -  |
| **404** | If the entity with that ID was not found. |  -  |
| **401** | Unauthorized. Bearer Token not provided. |  -  |
| **500** | Internal server error. Please contact administrator. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="httptranslationsbyidfilterbycustomfield"></a>
# **HttpTranslationsByIdFilterByCustomField**
> Dictionary&lt;string, Dictionary&lt;string, Object&gt;&gt; HttpTranslationsByIdFilterByCustomField (string id, string customField)



Get the translation of custom field on the entity (Asset, Collection)

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Agravity.Public.Api;
using Agravity.Public.Client;
using Agravity.Public.Model;

namespace Example
{
    public class HttpTranslationsByIdFilterByCustomFieldExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost:7071/api";
            // Configure OAuth2 access token for authorization: msal_auth
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new TranslationManagementApi(config);
            var id = "id_example";  // string | The ID of only translateable entities with custom fields (Asset, Collection).
            var customField = "customField_example";  // string | Limit the output to a specific custom field key.

            try
            {
                Dictionary<string, Dictionary<string, Object>> result = apiInstance.HttpTranslationsByIdFilterByCustomField(id, customField);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling TranslationManagementApi.HttpTranslationsByIdFilterByCustomField: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the HttpTranslationsByIdFilterByCustomFieldWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<Dictionary<string, Dictionary<string, Object>>> response = apiInstance.HttpTranslationsByIdFilterByCustomFieldWithHttpInfo(id, customField);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling TranslationManagementApi.HttpTranslationsByIdFilterByCustomFieldWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **string** | The ID of only translateable entities with custom fields (Asset, Collection). |  |
| **customField** | **string** | Limit the output to a specific custom field key. |  |

### Return type

**Dictionary<string, Dictionary<string, Object>>**

### Authorization

[msal_auth](../README.md#msal_auth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Returns the dictionary of the dictionaries with all translations  |  -  |
| **400** | Could not get all translations from {id}! (Code: fd86fae5-1eed-4770-b519-d403b85fa1d0) &lt;br/&gt;Could not get entity {id} from database! (Code: eb42dc0d-78ee-4fc9-9a65-d5df472c7a03) |  -  |
| **404** | If the entity with that ID was not found. |  -  |
| **401** | Unauthorized. Bearer Token not provided. |  -  |
| **500** | Internal server error. Please contact administrator. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="httptranslationsbyidfilterbyproperty"></a>
# **HttpTranslationsByIdFilterByProperty**
> Dictionary&lt;string, Dictionary&lt;string, Object&gt;&gt; HttpTranslationsByIdFilterByProperty (string id, string property, bool? items = null)



Get the translations of a specific field on the entity (Asset, Collection, Collection Type, Download Format)

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Agravity.Public.Api;
using Agravity.Public.Client;
using Agravity.Public.Model;

namespace Example
{
    public class HttpTranslationsByIdFilterByPropertyExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost:7071/api";
            // Configure OAuth2 access token for authorization: msal_auth
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new TranslationManagementApi(config);
            var id = "id_example";  // string | The ID of any translateable entity (Asset, Collection, Collection Type, Download Format).
            var property = "property_example";  // string | Limit to one specific property (key)
            var items = true;  // bool? | If the items should be included (only for entity type Collection and Asset). (optional) 

            try
            {
                Dictionary<string, Dictionary<string, Object>> result = apiInstance.HttpTranslationsByIdFilterByProperty(id, property, items);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling TranslationManagementApi.HttpTranslationsByIdFilterByProperty: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the HttpTranslationsByIdFilterByPropertyWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<Dictionary<string, Dictionary<string, Object>>> response = apiInstance.HttpTranslationsByIdFilterByPropertyWithHttpInfo(id, property, items);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling TranslationManagementApi.HttpTranslationsByIdFilterByPropertyWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **string** | The ID of any translateable entity (Asset, Collection, Collection Type, Download Format). |  |
| **property** | **string** | Limit to one specific property (key) |  |
| **items** | **bool?** | If the items should be included (only for entity type Collection and Asset). | [optional]  |

### Return type

**Dictionary<string, Dictionary<string, Object>>**

### Authorization

[msal_auth](../README.md#msal_auth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Returns the dictionary of the dictionaries with all translations  |  -  |
| **400** | Could not get all translations from {id}! (Code: fd86fae5-1eed-4770-b519-d403b85fa1d0) &lt;br/&gt;Could not get entity {id} from database! (Code: eb42dc0d-78ee-4fc9-9a65-d5df472c7a03) |  -  |
| **404** | If the entity with that ID was not found. |  -  |
| **401** | Unauthorized. Bearer Token not provided. |  -  |
| **500** | Internal server error. Please contact administrator. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="httpupdatetranslationsbyid"></a>
# **HttpUpdateTranslationsById**
> Dictionary&lt;string, Dictionary&lt;string, Object&gt;&gt; HttpUpdateTranslationsById (string id, Dictionary<string, Dictionary> requestBody)



Updates the translations of a whole entity (Asset, Collection, Collection Type, Download Format)

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Agravity.Public.Api;
using Agravity.Public.Client;
using Agravity.Public.Model;

namespace Example
{
    public class HttpUpdateTranslationsByIdExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost:7071/api";
            // Configure OAuth2 access token for authorization: msal_auth
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new TranslationManagementApi(config);
            var id = "id_example";  // string | The ID of any translateable entity (Asset, Collection, Collection Type, Download Format).
            var requestBody = new Dictionary<string, Dictionary>(); // Dictionary<string, Dictionary> | The body has to contain the dictionary of the dictionaries with all translations. Not fitting properties are ignored.

            try
            {
                Dictionary<string, Dictionary<string, Object>> result = apiInstance.HttpUpdateTranslationsById(id, requestBody);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling TranslationManagementApi.HttpUpdateTranslationsById: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the HttpUpdateTranslationsByIdWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<Dictionary<string, Dictionary<string, Object>>> response = apiInstance.HttpUpdateTranslationsByIdWithHttpInfo(id, requestBody);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling TranslationManagementApi.HttpUpdateTranslationsByIdWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **string** | The ID of any translateable entity (Asset, Collection, Collection Type, Download Format). |  |
| **requestBody** | [**Dictionary&lt;string, Dictionary&gt;**](Dictionary.md) | The body has to contain the dictionary of the dictionaries with all translations. Not fitting properties are ignored. |  |

### Return type

**Dictionary<string, Dictionary<string, Object>>**

### Authorization

[msal_auth](../README.md#msal_auth)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Returns the dictionary of the dictionaries with all translations  |  -  |
| **400** | Could not get all translations from {id}! (Code: fd86fae5-1eed-4770-b519-d403b85fa1d0) &lt;br/&gt;Could not get entity {id} from database! (Code: eb42dc0d-78ee-4fc9-9a65-d5df472c7a03) |  -  |
| **404** | If the entity with that ID was not found. |  -  |
| **401** | Unauthorized. Bearer Token not provided. |  -  |
| **500** | Internal server error. Please contact administrator. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

