# Agravity.Public.Api.SignalRConnectionManagementApi

All URIs are relative to *http://localhost:7071/api*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**HttpSignalRNegotiate**](SignalRConnectionManagementApi.md#httpsignalrnegotiate) | **POST** /signalr/negotiate |  |
| [**HttpSignalRSendMessage**](SignalRConnectionManagementApi.md#httpsignalrsendmessage) | **POST** /signalr/messages |  |
| [**HttpSignalRSendMessageToUser**](SignalRConnectionManagementApi.md#httpsignalrsendmessagetouser) | **POST** /signalr/info/{id} |  |

<a id="httpsignalrnegotiate"></a>
# **HttpSignalRNegotiate**
> SignalRConnectionInfo HttpSignalRNegotiate ()



This endpoint delivers the connection data for a client.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Agravity.Public.Api;
using Agravity.Public.Client;
using Agravity.Public.Model;

namespace Example
{
    public class HttpSignalRNegotiateExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost:7071/api";
            var apiInstance = new SignalRConnectionManagementApi(config);

            try
            {
                SignalRConnectionInfo result = apiInstance.HttpSignalRNegotiate();
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling SignalRConnectionManagementApi.HttpSignalRNegotiate: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the HttpSignalRNegotiateWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<SignalRConnectionInfo> response = apiInstance.HttpSignalRNegotiateWithHttpInfo();
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling SignalRConnectionManagementApi.HttpSignalRNegotiateWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters
This endpoint does not need any parameter.
### Return type

[**SignalRConnectionInfo**](SignalRConnectionInfo.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | The signalr connection info for further processing. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="httpsignalrsendmessage"></a>
# **HttpSignalRSendMessage**
> AgravityInfoResponse HttpSignalRSendMessage ()



Allowes a client via rest to send messages to clients.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Agravity.Public.Api;
using Agravity.Public.Client;
using Agravity.Public.Model;

namespace Example
{
    public class HttpSignalRSendMessageExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost:7071/api";
            var apiInstance = new SignalRConnectionManagementApi(config);

            try
            {
                AgravityInfoResponse result = apiInstance.HttpSignalRSendMessage();
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling SignalRConnectionManagementApi.HttpSignalRSendMessage: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the HttpSignalRSendMessageWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<AgravityInfoResponse> response = apiInstance.HttpSignalRSendMessageWithHttpInfo();
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling SignalRConnectionManagementApi.HttpSignalRSendMessageWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters
This endpoint does not need any parameter.
### Return type

[**AgravityInfoResponse**](AgravityInfoResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Returns only a success message. (Code: 2ee40f9d-a645-426d-925c-a2e52e3ceb00) |  -  |
| **400** | Message is empty. (Code: 2cee7b2c-8123-4255-b773-65e0924d4855) |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="httpsignalrsendmessagetouser"></a>
# **HttpSignalRSendMessageToUser**
> AgravityInfoResponse HttpSignalRSendMessageToUser (string id)



Allowes a client via rest to send messages to one client (user)

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Agravity.Public.Api;
using Agravity.Public.Client;
using Agravity.Public.Model;

namespace Example
{
    public class HttpSignalRSendMessageToUserExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost:7071/api";
            var apiInstance = new SignalRConnectionManagementApi(config);
            var id = "id_example";  // string | The ID of the user to which the message should be sent to.

            try
            {
                AgravityInfoResponse result = apiInstance.HttpSignalRSendMessageToUser(id);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling SignalRConnectionManagementApi.HttpSignalRSendMessageToUser: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the HttpSignalRSendMessageToUserWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<AgravityInfoResponse> response = apiInstance.HttpSignalRSendMessageToUserWithHttpInfo(id);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling SignalRConnectionManagementApi.HttpSignalRSendMessageToUserWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **string** | The ID of the user to which the message should be sent to. |  |

### Return type

[**AgravityInfoResponse**](AgravityInfoResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Returns only a success message. (Code: 2ee40f9d-a645-426d-925c-a2e52e3ceb00) |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

