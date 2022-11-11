# Agravity.Public.Api.PublicGeneralManagementApi

All URIs are relative to *http://localhost:7072/api*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**HttpAgravityVersionInfo**](PublicGeneralManagementApi.md#httpagravityversioninfo) | **GET** /version |  |
| [**HttpTriggerDurableContinue**](PublicGeneralManagementApi.md#httptriggerdurablecontinue) | **GET** /durable/{instanceId} |  |
| [**HttpTriggerDurableScchTrainingDone**](PublicGeneralManagementApi.md#httptriggerdurablescchtrainingdone) | **GET** /durable/scch/{instanceId} |  |

<a name="httpagravityversioninfo"></a>
# **HttpAgravityVersionInfo**
> AgravityVersion HttpAgravityVersionInfo ()



Get the current version of the backend. To see if backend was updated or not.

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
            config.BasePath = "http://localhost:7072/api";
            var apiInstance = new PublicGeneralManagementApi(config);

            try
            {
                AgravityVersion result = apiInstance.HttpAgravityVersionInfo();
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling PublicGeneralManagementApi.HttpAgravityVersionInfo: " + e.Message);
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
    Debug.Print("Exception when calling PublicGeneralManagementApi.HttpAgravityVersionInfoWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters
This endpoint does not need any parameter.
### Return type

[**AgravityVersion**](AgravityVersion.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | All information about backend. |  -  |
| **400** | Only if any of the input variable are null (Code: 9a6fb6f2-4b7b-4253-a4f3-5a46b7ba0ca8) |  -  |
| **404** | Only if assembly could not found (?) |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="httptriggerdurablecontinue"></a>
# **HttpTriggerDurableContinue**
> OkResult HttpTriggerDurableContinue (string instanceId)



Trigger the durable execution to continue

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Agravity.Public.Api;
using Agravity.Public.Client;
using Agravity.Public.Model;

namespace Example
{
    public class HttpTriggerDurableContinueExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost:7072/api";
            var apiInstance = new PublicGeneralManagementApi(config);
            var instanceId = "instanceId_example";  // string | The instance ID of the durable function.

            try
            {
                OkResult result = apiInstance.HttpTriggerDurableContinue(instanceId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling PublicGeneralManagementApi.HttpTriggerDurableContinue: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the HttpTriggerDurableContinueWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<OkResult> response = apiInstance.HttpTriggerDurableContinueWithHttpInfo(instanceId);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling PublicGeneralManagementApi.HttpTriggerDurableContinueWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **instanceId** | **string** | The instance ID of the durable function. |  |

### Return type

[**OkResult**](OkResult.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Operation successfull |  -  |
| **400** | Only if instaceId is null |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="httptriggerdurablescchtrainingdone"></a>
# **HttpTriggerDurableScchTrainingDone**
> OkResult HttpTriggerDurableScchTrainingDone (string instanceId)



Trigger the durable execution to continue

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Agravity.Public.Api;
using Agravity.Public.Client;
using Agravity.Public.Model;

namespace Example
{
    public class HttpTriggerDurableScchTrainingDoneExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost:7072/api";
            var apiInstance = new PublicGeneralManagementApi(config);
            var instanceId = "instanceId_example";  // string | The instance ID of the durable function.

            try
            {
                OkResult result = apiInstance.HttpTriggerDurableScchTrainingDone(instanceId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling PublicGeneralManagementApi.HttpTriggerDurableScchTrainingDone: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the HttpTriggerDurableScchTrainingDoneWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<OkResult> response = apiInstance.HttpTriggerDurableScchTrainingDoneWithHttpInfo(instanceId);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling PublicGeneralManagementApi.HttpTriggerDurableScchTrainingDoneWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **instanceId** | **string** | The instance ID of the durable function. |  |

### Return type

[**OkResult**](OkResult.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Operation successfull |  -  |
| **400** | Only if instaceId is null |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

