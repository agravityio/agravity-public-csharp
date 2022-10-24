# AgravityPublic.Api.PublicTranslationManagementApi

All URIs are relative to *http://localhost:7072/api*

Method | HTTP request | Description
------------- | ------------- | -------------
[**HttpTranslationsById**](PublicTranslationManagementApi.md#httptranslationsbyid) | **GET** /translations/{id} | 
[**HttpTranslationsByIdFilterByCustomField**](PublicTranslationManagementApi.md#httptranslationsbyidfilterbycustomfield) | **GET** /translations/{id}/custom/{customField} | 
[**HttpTranslationsByIdFilterByProperty**](PublicTranslationManagementApi.md#httptranslationsbyidfilterbyproperty) | **GET** /translations/{id}/{property} | 



## HttpTranslationsById

> Dictionary&lt;string, Dictionary&gt; HttpTranslationsById (string id, bool? items = null)



Get all the translations of a whole entity (Asset, Collection, Collection Type, Download Format)

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using AgravityPublic.Api;
using AgravityPublic.Client;
using AgravityPublic.Model;

namespace Example
{
    public class HttpTranslationsByIdExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "http://localhost:7072/api";
            // Configure API key authorization: function_key
            Configuration.Default.AddApiKey("x-functions-key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("x-functions-key", "Bearer");

            var apiInstance = new PublicTranslationManagementApi(Configuration.Default);
            var id = "id_example";  // string | The ID of any translateable entity (Asset, Collection, Collection Type, Download Format).
            var items = true;  // bool? | If the items should be included (only for entity type Collection and Asset). (optional) 

            try
            {
                Dictionary<string, Dictionary> result = apiInstance.HttpTranslationsById(id, items);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling PublicTranslationManagementApi.HttpTranslationsById: " + e.Message );
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
 **id** | **string**| The ID of any translateable entity (Asset, Collection, Collection Type, Download Format). | 
 **items** | **bool?**| If the items should be included (only for entity type Collection and Asset). | [optional] 

### Return type

**Dictionary<string, Dictionary>**

### Authorization

[function_key](../README.md#function_key)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Returns the dictionary of the dictionaries with all translations  |  -  |
| **400** | Could not get all translations from {id}! (Code: fd86fae5-1eed-4770-b519-d403b85fa1d0) &lt;br/&gt;Could not get entity {id} from database! (Code: eb42dc0d-78ee-4fc9-9a65-d5df472c7a03) |  -  |
| **404** | If the entity with that ID was not found. |  -  |
| **401** | Unauthorized. API Key not provided. |  -  |
| **500** | Internal server error. Please contact administrator. |  -  |

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## HttpTranslationsByIdFilterByCustomField

> Dictionary&lt;string, Dictionary&gt; HttpTranslationsByIdFilterByCustomField (string id, string customField)



Get the translation of custom field on the entity (Asset, Collection)

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using AgravityPublic.Api;
using AgravityPublic.Client;
using AgravityPublic.Model;

namespace Example
{
    public class HttpTranslationsByIdFilterByCustomFieldExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "http://localhost:7072/api";
            // Configure API key authorization: function_key
            Configuration.Default.AddApiKey("x-functions-key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("x-functions-key", "Bearer");

            var apiInstance = new PublicTranslationManagementApi(Configuration.Default);
            var id = "id_example";  // string | The ID of only translateable entities with custom fields (Asset, Collection).
            var customField = "customField_example";  // string | Limit the output to a specific custom field key.

            try
            {
                Dictionary<string, Dictionary> result = apiInstance.HttpTranslationsByIdFilterByCustomField(id, customField);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling PublicTranslationManagementApi.HttpTranslationsByIdFilterByCustomField: " + e.Message );
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
 **id** | **string**| The ID of only translateable entities with custom fields (Asset, Collection). | 
 **customField** | **string**| Limit the output to a specific custom field key. | 

### Return type

**Dictionary<string, Dictionary>**

### Authorization

[function_key](../README.md#function_key)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Returns the dictionary of the dictionaries with all translations  |  -  |
| **400** | Could not get all translations from {id}! (Code: fd86fae5-1eed-4770-b519-d403b85fa1d0) &lt;br/&gt;Could not get entity {id} from database! (Code: eb42dc0d-78ee-4fc9-9a65-d5df472c7a03) |  -  |
| **404** | If the entity with that ID was not found. |  -  |
| **401** | Unauthorized. API Key not provided. |  -  |
| **500** | Internal server error. Please contact administrator. |  -  |

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## HttpTranslationsByIdFilterByProperty

> Dictionary&lt;string, Dictionary&gt; HttpTranslationsByIdFilterByProperty (string id, string property, bool? items = null)



Get the translations of a specific field on the entity (Asset, Collection, Collection Type, Download Format)

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using AgravityPublic.Api;
using AgravityPublic.Client;
using AgravityPublic.Model;

namespace Example
{
    public class HttpTranslationsByIdFilterByPropertyExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "http://localhost:7072/api";
            // Configure API key authorization: function_key
            Configuration.Default.AddApiKey("x-functions-key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("x-functions-key", "Bearer");

            var apiInstance = new PublicTranslationManagementApi(Configuration.Default);
            var id = "id_example";  // string | The ID of any translateable entity (Asset, Collection, Collection Type, Download Format).
            var property = "property_example";  // string | Limit to one specific property (key)
            var items = true;  // bool? | If the items should be included (only for entity type Collection and Asset). (optional) 

            try
            {
                Dictionary<string, Dictionary> result = apiInstance.HttpTranslationsByIdFilterByProperty(id, property, items);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling PublicTranslationManagementApi.HttpTranslationsByIdFilterByProperty: " + e.Message );
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
 **id** | **string**| The ID of any translateable entity (Asset, Collection, Collection Type, Download Format). | 
 **property** | **string**| Limit to one specific property (key) | 
 **items** | **bool?**| If the items should be included (only for entity type Collection and Asset). | [optional] 

### Return type

**Dictionary<string, Dictionary>**

### Authorization

[function_key](../README.md#function_key)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Returns the dictionary of the dictionaries with all translations  |  -  |
| **400** | Could not get all translations from {id}! (Code: fd86fae5-1eed-4770-b519-d403b85fa1d0) &lt;br/&gt;Could not get entity {id} from database! (Code: eb42dc0d-78ee-4fc9-9a65-d5df472c7a03) |  -  |
| **404** | If the entity with that ID was not found. |  -  |
| **401** | Unauthorized. API Key not provided. |  -  |
| **500** | Internal server error. Please contact administrator. |  -  |

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)

