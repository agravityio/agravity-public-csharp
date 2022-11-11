# Agravity.Public.Api.PublicCollectionSharingApi

All URIs are relative to *http://localhost:7072/api*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**HttpSharedCollectionsGetById**](PublicCollectionSharingApi.md#httpsharedcollectionsgetbyid) | **GET** /shared/{id} |  |

<a name="httpsharedcollectionsgetbyid"></a>
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
            config.BasePath = "http://localhost:7072/api";
            var apiInstance = new PublicCollectionSharingApi(config);
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
                Debug.Print("Exception when calling PublicCollectionSharingApi.HttpSharedCollectionsGetById: " + e.Message);
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
    Debug.Print("Exception when calling PublicCollectionSharingApi.HttpSharedCollectionsGetByIdWithHttpInfo: " + e.Message);
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

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Returns the shared collection with the given ID. |  -  |
| **400** | A parameter is null (Code: e61dfb16-e486-4c15-8b55-276bd85d291e) or not valid shared id! (Code: e1eb7b29-e501-4727-bec3-26f5099b7418) |  -  |
| **404** | Collection on which this share is based, doesn&#39;t exist. (Code: 79dde226-ae08-4f4b-b334-de0cad89c994)  or Shared collection date expired! (Code: 6758d66e-0ce6-4770-a497-01a578eac12c)  or Shared collection not found. (Code: 87d09a21-14d6-4da4-ab69-01e6c87f108c)  or User null or shared collection of user not found. (Code: 5a1ea520-377d-43f1-b2c3-506443056561)   |  -  |
| **500** | Internal server error. Please contact administrator. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

