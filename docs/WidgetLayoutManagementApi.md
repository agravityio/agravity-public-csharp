# Agravity.Public.Api.WidgetLayoutManagementApi

All URIs are relative to *http://localhost:7071/api*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**HttpWidgetLayoutGet**](WidgetLayoutManagementApi.md#httpwidgetlayoutget) | **GET** /dashboard/layout |  |
| [**HttpWidgetLayoutUpdate**](WidgetLayoutManagementApi.md#httpwidgetlayoutupdate) | **POST** /dashboard/layout |  |

<a id="httpwidgetlayoutget"></a>
# **HttpWidgetLayoutGet**
> WidgetLayout HttpWidgetLayoutGet ()



This endpoint gets the dashboard layout in database.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Agravity.Public.Api;
using Agravity.Public.Client;
using Agravity.Public.Model;

namespace Example
{
    public class HttpWidgetLayoutGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost:7071/api";
            // Configure OAuth2 access token for authorization: msal_auth
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new WidgetLayoutManagementApi(config);

            try
            {
                WidgetLayout result = apiInstance.HttpWidgetLayoutGet();
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling WidgetLayoutManagementApi.HttpWidgetLayoutGet: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the HttpWidgetLayoutGetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<WidgetLayout> response = apiInstance.HttpWidgetLayoutGetWithHttpInfo();
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling WidgetLayoutManagementApi.HttpWidgetLayoutGetWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters
This endpoint does not need any parameter.
### Return type

[**WidgetLayout**](WidgetLayout.md)

### Authorization

[msal_auth](../README.md#msal_auth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Returns the widget layout in database |  -  |
| **401** | Unauthorized. Bearer Token not provided. |  -  |
| **500** | Internal server error. Please contact administrator. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="httpwidgetlayoutupdate"></a>
# **HttpWidgetLayoutUpdate**
> WidgetLayout HttpWidgetLayoutUpdate (WidgetLayout widgetLayout)



Updates the widget layout in database.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Agravity.Public.Api;
using Agravity.Public.Client;
using Agravity.Public.Model;

namespace Example
{
    public class HttpWidgetLayoutUpdateExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost:7071/api";
            // Configure OAuth2 access token for authorization: msal_auth
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new WidgetLayoutManagementApi(config);
            var widgetLayout = new WidgetLayout(); // WidgetLayout | Body has to be a valid widget layout item.

            try
            {
                WidgetLayout result = apiInstance.HttpWidgetLayoutUpdate(widgetLayout);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling WidgetLayoutManagementApi.HttpWidgetLayoutUpdate: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the HttpWidgetLayoutUpdateWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<WidgetLayout> response = apiInstance.HttpWidgetLayoutUpdateWithHttpInfo(widgetLayout);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling WidgetLayoutManagementApi.HttpWidgetLayoutUpdateWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **widgetLayout** | [**WidgetLayout**](WidgetLayout.md) | Body has to be a valid widget layout item. |  |

### Return type

[**WidgetLayout**](WidgetLayout.md)

### Authorization

[msal_auth](../README.md#msal_auth)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Returns the updated widget layout |  -  |
| **400** | Object is not a valid widget_layout. (Code: 33de1d45-02c1-454d-ba37-49b864f0f783) &lt;br&gt;No input object given. (Code: 27108715-a00e-4d0b-842b-76cb36d03c25)Error on create widget layout in database - max retry count is reached. (Code: e69f7351-531c-463e-95c8-1f913dfaa437) |  -  |
| **401** | Unauthorized. Bearer Token not provided. |  -  |
| **500** | Internal server error. Please contact administrator. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

