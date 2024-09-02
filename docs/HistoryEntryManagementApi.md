# Agravity.Public.Api.HistoryEntryManagementApi

All URIs are relative to *http://localhost:7071/api*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**HttpHistoryEntriesGetById**](HistoryEntryManagementApi.md#httphistoryentriesgetbyid) | **GET** /history/{id} |  |

<a id="httphistoryentriesgetbyid"></a>
# **HttpHistoryEntriesGetById**
> List&lt;HistoryEntry&gt; HttpHistoryEntriesGetById (string id, string include = null)



This endpoint gets the complete history of an entity.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Agravity.Public.Api;
using Agravity.Public.Client;
using Agravity.Public.Model;

namespace Example
{
    public class HttpHistoryEntriesGetByIdExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost:7071/api";
            // Configure OAuth2 access token for authorization: msal_auth
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new HistoryEntryManagementApi(config);
            var id = "id_example";  // string | The ID of the entity of which the history should be fetched.
            var include = "include_example";  // string | The fields (comma separate) which should be included in the result. (i.e. collections on asset) (optional) 

            try
            {
                List<HistoryEntry> result = apiInstance.HttpHistoryEntriesGetById(id, include);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling HistoryEntryManagementApi.HttpHistoryEntriesGetById: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the HttpHistoryEntriesGetByIdWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<List<HistoryEntry>> response = apiInstance.HttpHistoryEntriesGetByIdWithHttpInfo(id, include);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling HistoryEntryManagementApi.HttpHistoryEntriesGetByIdWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **string** | The ID of the entity of which the history should be fetched. |  |
| **include** | **string** | The fields (comma separate) which should be included in the result. (i.e. collections on asset) | [optional]  |

### Return type

[**List&lt;HistoryEntry&gt;**](HistoryEntry.md)

### Authorization

[msal_auth](../README.md#msal_auth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Returns a list with history entries for the given entity id. |  -  |
| **404** | The requested item could not be found. |  -  |
| **401** | Unauthorized. Bearer Token not provided. |  -  |
| **500** | Internal server error. Please contact administrator. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

