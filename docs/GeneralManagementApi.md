# Agravity.Public.Api.GeneralManagementApi

All URIs are relative to *http://localhost:7071/api*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**HttpAgravityVersionInfo**](GeneralManagementApi.md#httpagravityversioninfo) | **GET** /version |  |
| [**HttpAssetsDeleteAllFast**](GeneralManagementApi.md#httpassetsdeleteallfast) | **DELETE** /cosmosdb!! |  |
| [**HttpCleanup**](GeneralManagementApi.md#httpcleanup) | **PATCH** /cleanup |  |
| [**HttpCleanupOrigAssets**](GeneralManagementApi.md#httpcleanuporigassets) | **POST** /cleanup |  |
| [**HttpGetDeletedEntities**](GeneralManagementApi.md#httpgetdeletedentities) | **GET** /deleted |  |
| [**HttpSetup**](GeneralManagementApi.md#httpsetup) | **POST** /setup |  |

<a id="httpagravityversioninfo"></a>
# **HttpAgravityVersionInfo**
> AgravityVersion HttpAgravityVersionInfo ()



This endpoint returns the current version of the backend.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Agravity.Public.Api;
using Agravity.Public.Client;
using Agravity.Public.Model;

namespace Example
{
    public class HttpAgravityVersionInfoExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost:7071/api";
            // Configure OAuth2 access token for authorization: msal_auth
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new GeneralManagementApi(config);

            try
            {
                AgravityVersion result = apiInstance.HttpAgravityVersionInfo();
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling GeneralManagementApi.HttpAgravityVersionInfo: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the HttpAgravityVersionInfoWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<AgravityVersion> response = apiInstance.HttpAgravityVersionInfoWithHttpInfo();
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling GeneralManagementApi.HttpAgravityVersionInfoWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters
This endpoint does not need any parameter.
### Return type

[**AgravityVersion**](AgravityVersion.md)

### Authorization

[msal_auth](../README.md#msal_auth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Returns backend version. |  -  |
| **400** | A parameter is null. (Code: 7063e8ca-c5c9-4f9a-beb5-d63d9b2064ec) |  -  |
| **401** | Unauthorized. Bearer Token not provided. |  -  |
| **404** | The requested item could not be found. |  -  |
| **500** | Internal server error. Please contact administrator. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="httpassetsdeleteallfast"></a>
# **HttpAssetsDeleteAllFast**
> AgravityInfoResponse HttpAssetsDeleteAllFast ()



This endpoint deletes the database completely in a \"fast\" way without querying all entities with this \"hidden\" stored procedure.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Agravity.Public.Api;
using Agravity.Public.Client;
using Agravity.Public.Model;

namespace Example
{
    public class HttpAssetsDeleteAllFastExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost:7071/api";
            // Configure OAuth2 access token for authorization: msal_auth
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new GeneralManagementApi(config);

            try
            {
                AgravityInfoResponse result = apiInstance.HttpAssetsDeleteAllFast();
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling GeneralManagementApi.HttpAssetsDeleteAllFast: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the HttpAssetsDeleteAllFastWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<AgravityInfoResponse> response = apiInstance.HttpAssetsDeleteAllFastWithHttpInfo();
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling GeneralManagementApi.HttpAssetsDeleteAllFastWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters
This endpoint does not need any parameter.
### Return type

[**AgravityInfoResponse**](AgravityInfoResponse.md)

### Authorization

[msal_auth](../README.md#msal_auth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Returns deletion information. Code: 5004f7f1-be5f-45c1-b9a5-a7777b62c24c |  -  |
| **400** | A parameter is null. (Code: d31bdf92-a5d2-4d3b-96d9-626459b47bdb)&lt;br&gt;It is not allowed to fully delete the database. This has to be explicit set in configuration (Code: 08e71165-68cc-4094-be75-59047e85a4af)&lt;br&gt;All entities deleted! (Code: 5004f7f1-be5f-45c1-b9a5-a7777b62c24c) |  -  |
| **401** | Unauthorized. Bearer Token not provided. |  -  |
| **404** | The requested item could not be found. |  -  |
| **500** | Internal server error. Please contact administrator. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="httpcleanup"></a>
# **HttpCleanup**
> AgravityInfoResponse HttpCleanup (int? olderThanDays = null)



This endpoint queries all entities from which are marked as status \"D\" and cleans internal archive container from that assets

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Agravity.Public.Api;
using Agravity.Public.Client;
using Agravity.Public.Model;

namespace Example
{
    public class HttpCleanupExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost:7071/api";
            // Configure OAuth2 access token for authorization: msal_auth
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new GeneralManagementApi(config);
            var olderThanDays = 56;  // int? | (Default 90 days) - How many days in the entity. (optional) 

            try
            {
                AgravityInfoResponse result = apiInstance.HttpCleanup(olderThanDays);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling GeneralManagementApi.HttpCleanup: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the HttpCleanupWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<AgravityInfoResponse> response = apiInstance.HttpCleanupWithHttpInfo(olderThanDays);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling GeneralManagementApi.HttpCleanupWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **olderThanDays** | **int?** | (Default 90 days) - How many days in the entity. | [optional]  |

### Return type

[**AgravityInfoResponse**](AgravityInfoResponse.md)

### Authorization

[msal_auth](../README.md#msal_auth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Returns cleanup information. |  -  |
| **401** | Unauthorized. Bearer Token not provided. |  -  |
| **404** | The requested item could not be found. |  -  |
| **500** | Internal server error. Please contact administrator. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="httpcleanuporigassets"></a>
# **HttpCleanupOrigAssets**
> AgravityInfoResponse HttpCleanupOrigAssets ()



This endpoint checks if all assets in original container exist in db otherwise they are deleted

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Agravity.Public.Api;
using Agravity.Public.Client;
using Agravity.Public.Model;

namespace Example
{
    public class HttpCleanupOrigAssetsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost:7071/api";
            // Configure OAuth2 access token for authorization: msal_auth
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new GeneralManagementApi(config);

            try
            {
                AgravityInfoResponse result = apiInstance.HttpCleanupOrigAssets();
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling GeneralManagementApi.HttpCleanupOrigAssets: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the HttpCleanupOrigAssetsWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<AgravityInfoResponse> response = apiInstance.HttpCleanupOrigAssetsWithHttpInfo();
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling GeneralManagementApi.HttpCleanupOrigAssetsWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters
This endpoint does not need any parameter.
### Return type

[**AgravityInfoResponse**](AgravityInfoResponse.md)

### Authorization

[msal_auth](../README.md#msal_auth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Returns cleanup information. |  -  |
| **401** | Unauthorized. Bearer Token not provided. |  -  |
| **404** | The requested item could not be found. |  -  |
| **500** | Internal server error. Please contact administrator. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="httpgetdeletedentities"></a>
# **HttpGetDeletedEntities**
> List&lt;DeletedEntities&gt; HttpGetDeletedEntities (string entityType = null, string since = null, string until = null, string portalId = null)



This endpoint checks all deleted entities in the database until a specific date and returns the elements which are deleted.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Agravity.Public.Api;
using Agravity.Public.Client;
using Agravity.Public.Model;

namespace Example
{
    public class HttpGetDeletedEntitiesExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost:7071/api";
            // Configure OAuth2 access token for authorization: msal_auth
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new GeneralManagementApi(config);
            var entityType = "entityType_example";  // string | The type of the entity (e.g. 'asset', 'collection_type', 'collection_type'. Admins are allowed to list the other types as well. (optional) 
            var since = "since_example";  // string | The date in the past since the entities are marked as deleted in the database. (optional) 
            var until = "until_example";  // string | The date in the past until the entities are marked as deleted in the database. (optional) 
            var portalId = "portalId_example";  // string | If the request comes from portal this is the indicator. (optional) 

            try
            {
                List<DeletedEntities> result = apiInstance.HttpGetDeletedEntities(entityType, since, until, portalId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling GeneralManagementApi.HttpGetDeletedEntities: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the HttpGetDeletedEntitiesWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<List<DeletedEntities>> response = apiInstance.HttpGetDeletedEntitiesWithHttpInfo(entityType, since, until, portalId);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling GeneralManagementApi.HttpGetDeletedEntitiesWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **entityType** | **string** | The type of the entity (e.g. &#39;asset&#39;, &#39;collection_type&#39;, &#39;collection_type&#39;. Admins are allowed to list the other types as well. | [optional]  |
| **since** | **string** | The date in the past since the entities are marked as deleted in the database. | [optional]  |
| **until** | **string** | The date in the past until the entities are marked as deleted in the database. | [optional]  |
| **portalId** | **string** | If the request comes from portal this is the indicator. | [optional]  |

### Return type

[**List&lt;DeletedEntities&gt;**](DeletedEntities.md)

### Authorization

[msal_auth](../README.md#msal_auth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | A list of entities which are deleted since the given date (last modified date &#x3D; deleted date). |  -  |
| **400** | Since date could not be more in the future than until date. (Code: d362e2d4-b6b1-4547-a97c-058d2f46acfc)&lt;br&gt;Entity type &#39;{entityType}&#39; is not valid. (Code: 79abc89e-e072-4cf5-a63a-1573764975c6)&lt;br&gt;Entity type &#39;{entityType}&#39; is not allowed for this user. (Code: b00efbb5-faeb-4758-9ea3-44b5435a2311)&lt;br&gt;Error on getting deleted entities. (Code: 71fad553-4c82-423a-807e-ba272bfd3404)&lt;br&gt; |  -  |
| **404** | When the portal_id could not be found. |  -  |
| **401** | Unauthorized. Bearer Token not provided. |  -  |
| **500** | Internal server error. Please contact administrator. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="httpsetup"></a>
# **HttpSetup**
> AgravityInfoResponse HttpSetup (bool createfolder, string addconfigqueues = null)



This endpoint runs the initial setup of an environment.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Agravity.Public.Api;
using Agravity.Public.Client;
using Agravity.Public.Model;

namespace Example
{
    public class HttpSetupExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost:7071/api";
            // Configure OAuth2 access token for authorization: msal_auth
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new GeneralManagementApi(config);
            var createfolder = true;  // bool | (Default true) - Set to false if base collections (Folder) should not be created.
            var addconfigqueues = "addconfigqueues_example";  // string | Comma separated queue-names (have to start with 'setup-'). (optional) 

            try
            {
                AgravityInfoResponse result = apiInstance.HttpSetup(createfolder, addconfigqueues);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling GeneralManagementApi.HttpSetup: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the HttpSetupWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<AgravityInfoResponse> response = apiInstance.HttpSetupWithHttpInfo(createfolder, addconfigqueues);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling GeneralManagementApi.HttpSetupWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **createfolder** | **bool** | (Default true) - Set to false if base collections (Folder) should not be created. |  |
| **addconfigqueues** | **string** | Comma separated queue-names (have to start with &#39;setup-&#39;). | [optional]  |

### Return type

[**AgravityInfoResponse**](AgravityInfoResponse.md)

### Authorization

[msal_auth](../README.md#msal_auth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Returns information about what it executes. (Code: 2989fe36-dafe-4365-aa96-5aa5eefa5be8) |  -  |
| **400** | A parameter is null. (Code: 4826f40a-d949-4783-bb4e-d95224ade236) |  -  |
| **401** | Unauthorized. Bearer Token not provided. |  -  |
| **404** | The requested item could not be found. |  -  |
| **500** | Internal server error. Please contact administrator. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

