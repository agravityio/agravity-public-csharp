# AgravityPublic.Api.PublicConfigurationManagementApi

All URIs are relative to *http://localhost:7072/api*

Method | HTTP request | Description
------------- | ------------- | -------------
[**HttpConfigGetFrontendAll**](PublicConfigurationManagementApi.md#httpconfiggetfrontendall) | **GET** /config/frontend | 



## HttpConfigGetFrontendAll

> List&lt;FrontendAppConfig&gt; HttpConfigGetFrontendAll ()



Lists config value only for frontend stored in config table

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using AgravityPublic.Api;
using AgravityPublic.Client;
using AgravityPublic.Model;

namespace Example
{
    public class HttpConfigGetFrontendAllExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "http://localhost:7072/api";
            var apiInstance = new PublicConfigurationManagementApi(Configuration.Default);

            try
            {
                List<FrontendAppConfig> result = apiInstance.HttpConfigGetFrontendAll();
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling PublicConfigurationManagementApi.HttpConfigGetFrontendAll: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

This endpoint does not need any parameter.

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

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)

