# Agravity.Public.Api.AssetIconRuleManagementApi

All URIs are relative to *http://localhost:7071/api*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**HttpAssetIconRuleCreate**](AssetIconRuleManagementApi.md#httpasseticonrulecreate) | **POST** /asseticonrules |  |
| [**HttpAssetIconRuleDeleteById**](AssetIconRuleManagementApi.md#httpasseticonruledeletebyid) | **DELETE** /asseticonrules/{id} |  |
| [**HttpAssetIconRuleUpdateById**](AssetIconRuleManagementApi.md#httpasseticonruleupdatebyid) | **POST** /asseticonrules/{id} |  |
| [**HttpAssetIconRulesGetAll**](AssetIconRuleManagementApi.md#httpasseticonrulesgetall) | **GET** /asseticonrules |  |
| [**HttpAssetIconRulesGetById**](AssetIconRuleManagementApi.md#httpasseticonrulesgetbyid) | **GET** /asseticonrules/{id} |  |

<a id="httpasseticonrulecreate"></a>
# **HttpAssetIconRuleCreate**
> AssetIconRule HttpAssetIconRuleCreate (AssetIconRule assetIconRule, bool? translations = null, string acceptLanguage = null)



This endpoint creates one asset icon rule entry in the database.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Agravity.Public.Api;
using Agravity.Public.Client;
using Agravity.Public.Model;

namespace Example
{
    public class HttpAssetIconRuleCreateExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost:7071/api";
            // Configure OAuth2 access token for authorization: msal_auth
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new AssetIconRuleManagementApi(config);
            var assetIconRule = new AssetIconRule(); // AssetIconRule | This endpoint creates an asset icon rule ID and adds the information to the database. Color is a hex value. Operator has to be one of the following: 'EQUALS', 'NOT EQUALS', 'CONTAINS', 'STARTSWITH'
            var translations = true;  // bool? | When default language should be returned and the translation dictionary is delivered. (Ignores the \"Accept-Language\" header) (optional) 
            var acceptLanguage = "acceptLanguage_example";  // string | The requested language of the response. If not matching it falls back to default language. (optional) 

            try
            {
                AssetIconRule result = apiInstance.HttpAssetIconRuleCreate(assetIconRule, translations, acceptLanguage);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AssetIconRuleManagementApi.HttpAssetIconRuleCreate: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the HttpAssetIconRuleCreateWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<AssetIconRule> response = apiInstance.HttpAssetIconRuleCreateWithHttpInfo(assetIconRule, translations, acceptLanguage);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling AssetIconRuleManagementApi.HttpAssetIconRuleCreateWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **assetIconRule** | [**AssetIconRule**](AssetIconRule.md) | This endpoint creates an asset icon rule ID and adds the information to the database. Color is a hex value. Operator has to be one of the following: &#39;EQUALS&#39;, &#39;NOT EQUALS&#39;, &#39;CONTAINS&#39;, &#39;STARTSWITH&#39; |  |
| **translations** | **bool?** | When default language should be returned and the translation dictionary is delivered. (Ignores the \&quot;Accept-Language\&quot; header) | [optional]  |
| **acceptLanguage** | **string** | The requested language of the response. If not matching it falls back to default language. | [optional]  |

### Return type

[**AssetIconRule**](AssetIconRule.md)

### Authorization

[msal_auth](../README.md#msal_auth)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **201** | Returns the created asset icon rule. |  -  |
| **400** | Object is not a valid asset_icon_rule. (Code: faf85491-3b37-4687-9522-43f1b94228b8)&lt;br&gt;No input object given. (Code: b84012a8-9987-4bc8-980f-053828357d5e) &lt;br&gt;Property name can not be empty. (Code: b1cc383e-c993-4c3a-8fc9-c8ce57d6310c) &lt;br&gt;Object given is not a valid asset icon rule: Property(ies) ... is/are not valid. (Code: f50c4f14-801d-4a3b-a4a6-f93145bb56d9) |  -  |
| **401** | Unauthorized. Bearer Token not provided. |  -  |
| **500** | Internal server error. Please contact administrator. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="httpasseticonruledeletebyid"></a>
# **HttpAssetIconRuleDeleteById**
> void HttpAssetIconRuleDeleteById (string id)



This endpoint deletes a single asset icon rule.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Agravity.Public.Api;
using Agravity.Public.Client;
using Agravity.Public.Model;

namespace Example
{
    public class HttpAssetIconRuleDeleteByIdExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost:7071/api";
            // Configure OAuth2 access token for authorization: msal_auth
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new AssetIconRuleManagementApi(config);
            var id = "id_example";  // string | The ID of the asset icon rule.

            try
            {
                apiInstance.HttpAssetIconRuleDeleteById(id);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AssetIconRuleManagementApi.HttpAssetIconRuleDeleteById: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the HttpAssetIconRuleDeleteByIdWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    apiInstance.HttpAssetIconRuleDeleteByIdWithHttpInfo(id);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling AssetIconRuleManagementApi.HttpAssetIconRuleDeleteByIdWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **string** | The ID of the asset icon rule. |  |

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
| **400** | Error on deleting asset icon rule ({id}) database - max retry count is reached. (Code: d38499b7-046c-4837-b92c-0afd8fb88f0c) |  -  |
| **204** | The delete operation of the icon rule with the given ID was successful. |  -  |
| **404** | If the asset icon rule with the ID was not found. |  -  |
| **401** | Unauthorized. Bearer Token not provided. |  -  |
| **500** | Internal server error. Please contact administrator. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="httpasseticonruleupdatebyid"></a>
# **HttpAssetIconRuleUpdateById**
> AssetIconRule HttpAssetIconRuleUpdateById (string id, AssetIconRule assetIconRule, bool? translations = null, string acceptLanguage = null)



This endpoint updates a single asset icon rule. Color is a hex value. Operator has to be one of the following: 'EQUALS', 'NOT EQUALS', 'CONTAINS', 'STARTSWITH'

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Agravity.Public.Api;
using Agravity.Public.Client;
using Agravity.Public.Model;

namespace Example
{
    public class HttpAssetIconRuleUpdateByIdExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost:7071/api";
            // Configure OAuth2 access token for authorization: msal_auth
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new AssetIconRuleManagementApi(config);
            var id = "id_example";  // string | The ID of the asset icon rule.
            var assetIconRule = new AssetIconRule(); // AssetIconRule | This endpoint updates an asset icon rule and adds the information to the database. Color is a hex value. Operator has to be one of the following: 'EQUALS', 'NOT EQUALS', 'CONTAINS', 'STARTSWITH'
            var translations = true;  // bool? | When default language should be returned and the translation dictionary is delivered. (Ignores the \"Accept-Language\" header) (optional) 
            var acceptLanguage = "acceptLanguage_example";  // string | The requested language of the response. If not matching it falls back to default language. (optional) 

            try
            {
                AssetIconRule result = apiInstance.HttpAssetIconRuleUpdateById(id, assetIconRule, translations, acceptLanguage);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AssetIconRuleManagementApi.HttpAssetIconRuleUpdateById: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the HttpAssetIconRuleUpdateByIdWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<AssetIconRule> response = apiInstance.HttpAssetIconRuleUpdateByIdWithHttpInfo(id, assetIconRule, translations, acceptLanguage);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling AssetIconRuleManagementApi.HttpAssetIconRuleUpdateByIdWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **string** | The ID of the asset icon rule. |  |
| **assetIconRule** | [**AssetIconRule**](AssetIconRule.md) | This endpoint updates an asset icon rule and adds the information to the database. Color is a hex value. Operator has to be one of the following: &#39;EQUALS&#39;, &#39;NOT EQUALS&#39;, &#39;CONTAINS&#39;, &#39;STARTSWITH&#39; |  |
| **translations** | **bool?** | When default language should be returned and the translation dictionary is delivered. (Ignores the \&quot;Accept-Language\&quot; header) | [optional]  |
| **acceptLanguage** | **string** | The requested language of the response. If not matching it falls back to default language. | [optional]  |

### Return type

[**AssetIconRule**](AssetIconRule.md)

### Authorization

[msal_auth](../README.md#msal_auth)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **201** | Returns the asset icon rule. |  -  |
| **400** | Error on update asset icon rule in ({id}) database - max retry count is reached. (Code: ac5357ab-7912-4985-9839-16b68ff6c815)&lt;/br&gt;Invalid asset icon rule ID. (Code: d83d22c3-03fc-41ba-a182-acbbd9060f01)&lt;br&gt;Object is not a valid asset icon rule json. Parse error. (Code: f8a9ead1-6e7c-41d0-9f45-cb2e803da3e0)&lt;br&gt;Property name can not be empty. (Code: 98a80b23-bf8d-4cc1-ad6c-08cd69214dcd)&lt;br&gt;Object can not be empty if you want to update this asset icon rule. (Code: aef8837e-973a-44e0-9fd8-4495683f8673)&lt;br&gt;Object given is not a valid asset icon rule: Property(ies) ... is/are not valid. (Code: 12cc2b31-90b8-4319-95d9-d63aaa3cf7e7) |  -  |
| **404** | If the asset icon rule with the ID was not found. |  -  |
| **401** | Unauthorized. Bearer Token not provided. |  -  |
| **500** | Internal server error. Please contact administrator. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="httpasseticonrulesgetall"></a>
# **HttpAssetIconRulesGetAll**
> List&lt;AssetIconRule&gt; HttpAssetIconRulesGetAll (bool? translations = null, string acceptLanguage = null)



This endpoint lists all asset icon rules in database.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Agravity.Public.Api;
using Agravity.Public.Client;
using Agravity.Public.Model;

namespace Example
{
    public class HttpAssetIconRulesGetAllExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost:7071/api";
            // Configure OAuth2 access token for authorization: msal_auth
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new AssetIconRuleManagementApi(config);
            var translations = true;  // bool? | When default language should be returned and the translation dictionary is delivered. (Ignores the \"Accept-Language\" header) (optional) 
            var acceptLanguage = "acceptLanguage_example";  // string | The requested language of the response. If not matching it falls back to default language. (optional) 

            try
            {
                List<AssetIconRule> result = apiInstance.HttpAssetIconRulesGetAll(translations, acceptLanguage);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AssetIconRuleManagementApi.HttpAssetIconRulesGetAll: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the HttpAssetIconRulesGetAllWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<List<AssetIconRule>> response = apiInstance.HttpAssetIconRulesGetAllWithHttpInfo(translations, acceptLanguage);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling AssetIconRuleManagementApi.HttpAssetIconRulesGetAllWithHttpInfo: " + e.Message);
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

[**List&lt;AssetIconRule&gt;**](AssetIconRule.md)

### Authorization

[msal_auth](../README.md#msal_auth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Returns all asset icon rules in database. |  -  |
| **401** | Unauthorized. Bearer Token not provided. |  -  |
| **500** | Internal server error. Please contact administrator. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="httpasseticonrulesgetbyid"></a>
# **HttpAssetIconRulesGetById**
> AssetIconRule HttpAssetIconRulesGetById (string id, bool? translations = null, string acceptLanguage = null)



This endpoint gets a single asset icon rule from the database.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Agravity.Public.Api;
using Agravity.Public.Client;
using Agravity.Public.Model;

namespace Example
{
    public class HttpAssetIconRulesGetByIdExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost:7071/api";
            // Configure OAuth2 access token for authorization: msal_auth
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new AssetIconRuleManagementApi(config);
            var id = "id_example";  // string | The ID of the asset icon rule.
            var translations = true;  // bool? | When default language should be returned and the translation dictionary is delivered. (Ignores the \"Accept-Language\" header) (optional) 
            var acceptLanguage = "acceptLanguage_example";  // string | The requested language of the response. If not matching it falls back to default language. (optional) 

            try
            {
                AssetIconRule result = apiInstance.HttpAssetIconRulesGetById(id, translations, acceptLanguage);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AssetIconRuleManagementApi.HttpAssetIconRulesGetById: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the HttpAssetIconRulesGetByIdWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<AssetIconRule> response = apiInstance.HttpAssetIconRulesGetByIdWithHttpInfo(id, translations, acceptLanguage);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling AssetIconRuleManagementApi.HttpAssetIconRulesGetByIdWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **string** | The ID of the asset icon rule. |  |
| **translations** | **bool?** | When default language should be returned and the translation dictionary is delivered. (Ignores the \&quot;Accept-Language\&quot; header) | [optional]  |
| **acceptLanguage** | **string** | The requested language of the response. If not matching it falls back to default language. | [optional]  |

### Return type

[**AssetIconRule**](AssetIconRule.md)

### Authorization

[msal_auth](../README.md#msal_auth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Returns a single asset icon rule with the specified id. |  -  |
| **400** | Invalid asset icon rule ID. (Code: f9e6e0e1-3aa6-440b-a9e2-a99d874bde62) |  -  |
| **401** | Unauthorized. Bearer Token not provided. |  -  |
| **500** | Internal server error. Please contact administrator. |  -  |
| **404** | If the asset icon rule with the ID was not found. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

