# Agravity.Public.Api.CollectionShareManagementApi

All URIs are relative to *http://localhost:7071/api*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**HttpSharedCollectionsCreate**](CollectionShareManagementApi.md#httpsharedcollectionscreate) | **POST** /shared |  |
| [**HttpSharedCollectionsDeleteById**](CollectionShareManagementApi.md#httpsharedcollectionsdeletebyid) | **DELETE** /shared/{id} |  |
| [**HttpSharedCollectionsGet**](CollectionShareManagementApi.md#httpsharedcollectionsget) | **GET** /shared |  |
| [**HttpSharedCollectionsGetById**](CollectionShareManagementApi.md#httpsharedcollectionsgetbyid) | **GET** /shared/{id} |  |

<a id="httpsharedcollectionscreate"></a>
# **HttpSharedCollectionsCreate**
> SharedCollection HttpSharedCollectionsCreate (SharedCollection sharedCollection)



Creates an additional shared collection

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Agravity.Public.Api;
using Agravity.Public.Client;
using Agravity.Public.Model;

namespace Example
{
    public class HttpSharedCollectionsCreateExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost:7071/api";
            // Configure OAuth2 access token for authorization: msal_auth
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new CollectionShareManagementApi(config);
            var sharedCollection = new SharedCollection(); // SharedCollection | This creates / adds an unique shared collection ID and adds the information to the collection (in DB).

            try
            {
                SharedCollection result = apiInstance.HttpSharedCollectionsCreate(sharedCollection);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling CollectionShareManagementApi.HttpSharedCollectionsCreate: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the HttpSharedCollectionsCreateWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<SharedCollection> response = apiInstance.HttpSharedCollectionsCreateWithHttpInfo(sharedCollection);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling CollectionShareManagementApi.HttpSharedCollectionsCreateWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **sharedCollection** | [**SharedCollection**](SharedCollection.md) | This creates / adds an unique shared collection ID and adds the information to the collection (in DB). |  |

### Return type

[**SharedCollection**](SharedCollection.md)

### Authorization

[msal_auth](../README.md#msal_auth)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **201** | Returns the created shared collection. |  -  |
| **404** | Shared collection has not valid id.  (Code: e13fb61c-f67f-440c-84da-3d48c9344c3d)&lt;br&gt;or collection &lt;collectionid&gt; was not found in the database.  (Code: 61b2fe4a-4b4f-4b87-b928-eb38ffa4f314) |  -  |
| **400** | Passed request body could not be processed.  (Code: 6061feb4-cac8-4f9c-8d2e-bf4239bdac4b)&lt;br&gt;or shared collection must have a target url.  (Code: d045b732-2b5e-48cc-9423-a6d59ce1f17d)&lt;br&gt;or collection is not in state &#39;A&#39;.  (Code: 2496209a-e3f0-4f6d-8535-7a7312557967)&lt;br&gt;or shared collection could not be created in the past.  (Code: 09cf3839-889d-4ff3-a29f-20b964a63df8) |  -  |
| **401** | Unauthorized. Bearer Token not provided. |  -  |
| **500** | Internal server error. Please contact administrator. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="httpsharedcollectionsdeletebyid"></a>
# **HttpSharedCollectionsDeleteById**
> void HttpSharedCollectionsDeleteById (string id)



Deletes the shared collection with the given ID.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Agravity.Public.Api;
using Agravity.Public.Client;
using Agravity.Public.Model;

namespace Example
{
    public class HttpSharedCollectionsDeleteByIdExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost:7071/api";
            // Configure OAuth2 access token for authorization: msal_auth
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new CollectionShareManagementApi(config);
            var id = "id_example";  // string | The ID of the shared collection.

            try
            {
                apiInstance.HttpSharedCollectionsDeleteById(id);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling CollectionShareManagementApi.HttpSharedCollectionsDeleteById: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the HttpSharedCollectionsDeleteByIdWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    apiInstance.HttpSharedCollectionsDeleteByIdWithHttpInfo(id);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling CollectionShareManagementApi.HttpSharedCollectionsDeleteByIdWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **string** | The ID of the shared collection. |  |

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
| **400** | This user is not allowed to delete a global shared collection.  (Code: 984122f6-9d57-47eb-9b87-9c3a8af0b74b)&lt;br&gt;Not valid shared id!  (Code: e1eb7b29-e501-4727-bec3-26f5099b7418) |  -  |
| **204** | The delete operation of the shared collection with the given ID was successful. |  -  |
| **404** | If the shared collection with the ID was not found. |  -  |
| **401** | Unauthorized. Bearer Token not provided. |  -  |
| **500** | Internal server error. Please contact administrator. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="httpsharedcollectionsget"></a>
# **HttpSharedCollectionsGet**
> List&lt;SharedCollection&gt; HttpSharedCollectionsGet (string collectionid = null)



This lists all the shared collections which are stored in the database for a specific user.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Agravity.Public.Api;
using Agravity.Public.Client;
using Agravity.Public.Model;

namespace Example
{
    public class HttpSharedCollectionsGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost:7071/api";
            // Configure OAuth2 access token for authorization: msal_auth
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new CollectionShareManagementApi(config);
            var collectionid = "collectionid_example";  // string | Filter all shared collections with given ID. (optional) 

            try
            {
                List<SharedCollection> result = apiInstance.HttpSharedCollectionsGet(collectionid);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling CollectionShareManagementApi.HttpSharedCollectionsGet: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the HttpSharedCollectionsGetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<List<SharedCollection>> response = apiInstance.HttpSharedCollectionsGetWithHttpInfo(collectionid);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling CollectionShareManagementApi.HttpSharedCollectionsGetWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **collectionid** | **string** | Filter all shared collections with given ID. | [optional]  |

### Return type

[**List&lt;SharedCollection&gt;**](SharedCollection.md)

### Authorization

[msal_auth](../README.md#msal_auth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Returns the all shared collections as array. |  -  |
| **400** | Could not determine user from token!  (Code: e1eb7b29-e501-4727-bec3-26f5099b7418)&lt;br&gt;or given collectionid parameter is not valid collection id!  (Code: ec16ac3b-92f4-4a14-a70e-0a53fecc9679) |  -  |
| **401** | Unauthorized. Bearer Token not provided. |  -  |
| **500** | Internal server error. Please contact administrator. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="httpsharedcollectionsgetbyid"></a>
# **HttpSharedCollectionsGetById**
> SharedCollectionFull HttpSharedCollectionsGetById (string id, string continuationToken = null, int? limit = null, string orderby = null)



Returns one single shared collection (from ID)

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Agravity.Public.Api;
using Agravity.Public.Client;
using Agravity.Public.Model;

namespace Example
{
    public class HttpSharedCollectionsGetByIdExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost:7071/api";
            // Configure OAuth2 access token for authorization: msal_auth
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new CollectionShareManagementApi(config);
            var id = "id_example";  // string | The ID of the shared collection.
            var continuationToken = "continuationToken_example";  // string | Each result returns the continous token if more results are available than requested. With this token, the next page could be fetched. (URL encoded!) (optional) 
            var limit = 56;  // int? | This number limits the page result of assets. (optional) 
            var orderby = "orderby_example";  // string | How the return assets are sorted. Default is property: created_date (newest first). (optional) 

            try
            {
                SharedCollectionFull result = apiInstance.HttpSharedCollectionsGetById(id, continuationToken, limit, orderby);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling CollectionShareManagementApi.HttpSharedCollectionsGetById: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the HttpSharedCollectionsGetByIdWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<SharedCollectionFull> response = apiInstance.HttpSharedCollectionsGetByIdWithHttpInfo(id, continuationToken, limit, orderby);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling CollectionShareManagementApi.HttpSharedCollectionsGetByIdWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **string** | The ID of the shared collection. |  |
| **continuationToken** | **string** | Each result returns the continous token if more results are available than requested. With this token, the next page could be fetched. (URL encoded!) | [optional]  |
| **limit** | **int?** | This number limits the page result of assets. | [optional]  |
| **orderby** | **string** | How the return assets are sorted. Default is property: created_date (newest first). | [optional]  |

### Return type

[**SharedCollectionFull**](SharedCollectionFull.md)

### Authorization

[msal_auth](../README.md#msal_auth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Returns the shared collection with the given ID. |  -  |
| **400** | A parameter is null (Code: e61dfb16-e486-4c15-8b55-276bd85d291e)&lt;br&gt;or not valid shared id! (Code: e1eb7b29-e501-4727-bec3-26f5099b7418) |  -  |
| **404** | Collection on which this share is based, doesn&#39;t exist. (Code: 79dde226-ae08-4f4b-b334-de0cad89c994)&lt;br&gt;or Shared collection date expired! (Code: 6758d66e-0ce6-4770-a497-01a578eac12c)&lt;br&gt;or Shared collection not found. (Code: 87d09a21-14d6-4da4-ab69-01e6c87f108c)&lt;br&gt;or User null or shared collection of user not found. (Code: 5a1ea520-377d-43f1-b2c3-506443056561) |  -  |
| **401** | Unauthorized. Bearer Token not provided. |  -  |
| **500** | Internal server error. Please contact administrator. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

