# Agravity.Public.Api.PublicConfigurationManagementApi

All URIs are relative to *http://localhost:7072/api*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**HttpConfigGetFrontendAll**](PublicConfigurationManagementApi.md#httpconfiggetfrontendall) | **GET** /config/frontend |  |

<a id="httpconfiggetfrontendall"></a>
# **HttpConfigGetFrontendAll**
> List&lt;FrontendAppConfig&gt; HttpConfigGetFrontendAll (bool? customonly = null)



Lists config value only for frontend stored in config table. Optional to filter for custom values only.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Agravity.Public.Api;
using Agravity.Public.Client;
using Agravity.Public.Model;

namespace Example
{
    public class HttpConfigGetFrontendAllExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost:7072/api";
            var apiInstance = new PublicConfigurationManagementApi(config);
            var customonly = true;  // bool? | This returns only the custom created configurations. (optional) 

            try
            {
                List<FrontendAppConfig> result = apiInstance.HttpConfigGetFrontendAll(customonly);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling PublicConfigurationManagementApi.HttpConfigGetFrontendAll: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the HttpConfigGetFrontendAllWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<List<FrontendAppConfig>> response = apiInstance.HttpConfigGetFrontendAllWithHttpInfo(customonly);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling PublicConfigurationManagementApi.HttpConfigGetFrontendAllWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **customonly** | **bool?** | This returns only the custom created configurations. | [optional]  |

### Return type

[**List&lt;FrontendAppConfig&gt;**](FrontendAppConfig.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Returns the frontend configations values in store |  -  |
| **500** | Internal server error. Please contact administrator. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

