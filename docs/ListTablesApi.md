# Agravity.Public.Api.ListTablesApi

All URIs are relative to *http://localhost:7071/api*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**HttpDeleteAllTableEntities**](ListTablesApi.md#httpdeletealltableentities) | **DELETE** /tables |  |

<a id="httpdeletealltableentities"></a>
# **HttpDeleteAllTableEntities**
> AgravityInfoResponse HttpDeleteAllTableEntities ()



This HTTP trigger deletes all table entries.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Agravity.Public.Api;
using Agravity.Public.Client;
using Agravity.Public.Model;

namespace Example
{
    public class HttpDeleteAllTableEntitiesExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost:7071/api";
            // Configure OAuth2 access token for authorization: msal_auth
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new ListTablesApi(config);

            try
            {
                AgravityInfoResponse result = apiInstance.HttpDeleteAllTableEntities();
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ListTablesApi.HttpDeleteAllTableEntities: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the HttpDeleteAllTableEntitiesWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<AgravityInfoResponse> response = apiInstance.HttpDeleteAllTableEntitiesWithHttpInfo();
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ListTablesApi.HttpDeleteAllTableEntitiesWithHttpInfo: " + e.Message);
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
| **200** | JSON lists of deleted, stillExits and failed blob container. |  -  |
| **400** | It is not allowed to delete all table entries. This has to be explicit set in configuration (Code: 3f584e89-d73b-4a29-945e-4300ce12bf5f) |  -  |
| **401** | Unauthorized. Bearer Token not provided. |  -  |
| **404** | The requested item could not be found. |  -  |
| **500** | Internal server error. Please contact administrator. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

