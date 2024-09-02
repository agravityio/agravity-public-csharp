# Agravity.Public.Api.DashboardWidgetManagementApi

All URIs are relative to *http://localhost:7071/api*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**HttpDashboardWidgetsCreate**](DashboardWidgetManagementApi.md#httpdashboardwidgetscreate) | **POST** /dashboard/widgets |  |
| [**HttpDashboardWidgetsDeleteById**](DashboardWidgetManagementApi.md#httpdashboardwidgetsdeletebyid) | **DELETE** /dashboard/widgets/{id} |  |
| [**HttpDashboardWidgetsGetAll**](DashboardWidgetManagementApi.md#httpdashboardwidgetsgetall) | **GET** /dashboard/widgets |  |
| [**HttpDashboardWidgetsGetById**](DashboardWidgetManagementApi.md#httpdashboardwidgetsgetbyid) | **GET** /dashboard/widgets/{id} |  |
| [**HttpDashboardWidgetsUpdateById**](DashboardWidgetManagementApi.md#httpdashboardwidgetsupdatebyid) | **POST** /dashboard/widgets/{id} |  |

<a id="httpdashboardwidgetscreate"></a>
# **HttpDashboardWidgetsCreate**
> DashboardWidget HttpDashboardWidgetsCreate (DashboardWidget dashboardWidget, string acceptLanguage = null)



This endpoint creates a dashboard widget in database.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Agravity.Public.Api;
using Agravity.Public.Client;
using Agravity.Public.Model;

namespace Example
{
    public class HttpDashboardWidgetsCreateExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost:7071/api";
            // Configure OAuth2 access token for authorization: msal_auth
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new DashboardWidgetManagementApi(config);
            var dashboardWidget = new DashboardWidget(); // DashboardWidget | The dashboard widget to create.
            var acceptLanguage = "acceptLanguage_example";  // string | The requested language of the response. If not matching it falls back to default language. (optional) 

            try
            {
                DashboardWidget result = apiInstance.HttpDashboardWidgetsCreate(dashboardWidget, acceptLanguage);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DashboardWidgetManagementApi.HttpDashboardWidgetsCreate: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the HttpDashboardWidgetsCreateWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<DashboardWidget> response = apiInstance.HttpDashboardWidgetsCreateWithHttpInfo(dashboardWidget, acceptLanguage);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling DashboardWidgetManagementApi.HttpDashboardWidgetsCreateWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **dashboardWidget** | [**DashboardWidget**](DashboardWidget.md) | The dashboard widget to create. |  |
| **acceptLanguage** | **string** | The requested language of the response. If not matching it falls back to default language. | [optional]  |

### Return type

[**DashboardWidget**](DashboardWidget.md)

### Authorization

[msal_auth](../README.md#msal_auth)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **201** | Returns the created dashboard widget. |  -  |
| **400** | Object is not a valid dashboard_widget. (Code: 4a37667f-3d1d-4527-a7b8-2ed7a7ddfc4c)&lt;br&gt;No input object given. (Code: b3e48905-1441-407f-801f-b9ea8b4bffb7)Error on create dashboard widget in database - max retry count is reached. (Code: 16e7e522-898e-4e93-ad78-4509a5de299d) |  -  |
| **401** | Unauthorized. Bearer Token not provided. |  -  |
| **500** | Internal server error. Please contact administrator. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="httpdashboardwidgetsdeletebyid"></a>
# **HttpDashboardWidgetsDeleteById**
> void HttpDashboardWidgetsDeleteById (string id)



This endpoint deletes a single dashboard widget.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Agravity.Public.Api;
using Agravity.Public.Client;
using Agravity.Public.Model;

namespace Example
{
    public class HttpDashboardWidgetsDeleteByIdExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost:7071/api";
            // Configure OAuth2 access token for authorization: msal_auth
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new DashboardWidgetManagementApi(config);
            var id = "id_example";  // string | The ID of the dashboard widget.

            try
            {
                apiInstance.HttpDashboardWidgetsDeleteById(id);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DashboardWidgetManagementApi.HttpDashboardWidgetsDeleteById: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the HttpDashboardWidgetsDeleteByIdWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    apiInstance.HttpDashboardWidgetsDeleteByIdWithHttpInfo(id);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling DashboardWidgetManagementApi.HttpDashboardWidgetsDeleteByIdWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **string** | The ID of the dashboard widget. |  |

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
| **400** | Error trying to delete the dashboard widget with the given ID. |  -  |
| **204** | The delete operation of the dashboard widget with the given ID was successful. |  -  |
| **404** | If the dashboard widget with the ID was not found. |  -  |
| **401** | Unauthorized. Bearer Token not provided. |  -  |
| **500** | Internal server error. Please contact administrator. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="httpdashboardwidgetsgetall"></a>
# **HttpDashboardWidgetsGetAll**
> List&lt;DashboardWidget&gt; HttpDashboardWidgetsGetAll (bool? populate = null, string acceptLanguage = null)



This endpoint lists all dashboard widgets in database.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Agravity.Public.Api;
using Agravity.Public.Client;
using Agravity.Public.Model;

namespace Example
{
    public class HttpDashboardWidgetsGetAllExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost:7071/api";
            // Configure OAuth2 access token for authorization: msal_auth
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new DashboardWidgetManagementApi(config);
            var populate = true;  // bool? | If widgetdata should be populated. (optional) 
            var acceptLanguage = "acceptLanguage_example";  // string | The requested language of the response. If not matching it falls back to default language. (optional) 

            try
            {
                List<DashboardWidget> result = apiInstance.HttpDashboardWidgetsGetAll(populate, acceptLanguage);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DashboardWidgetManagementApi.HttpDashboardWidgetsGetAll: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the HttpDashboardWidgetsGetAllWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<List<DashboardWidget>> response = apiInstance.HttpDashboardWidgetsGetAllWithHttpInfo(populate, acceptLanguage);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling DashboardWidgetManagementApi.HttpDashboardWidgetsGetAllWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **populate** | **bool?** | If widgetdata should be populated. | [optional]  |
| **acceptLanguage** | **string** | The requested language of the response. If not matching it falls back to default language. | [optional]  |

### Return type

[**List&lt;DashboardWidget&gt;**](DashboardWidget.md)

### Authorization

[msal_auth](../README.md#msal_auth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Returns all dashboard widgets in database. |  -  |
| **401** | Unauthorized. Bearer Token not provided. |  -  |
| **500** | Internal server error. Please contact administrator. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="httpdashboardwidgetsgetbyid"></a>
# **HttpDashboardWidgetsGetById**
> DashboardWidget HttpDashboardWidgetsGetById (string id, string acceptLanguage = null)



This endpoint gets a dashboard widget from database.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Agravity.Public.Api;
using Agravity.Public.Client;
using Agravity.Public.Model;

namespace Example
{
    public class HttpDashboardWidgetsGetByIdExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost:7071/api";
            // Configure OAuth2 access token for authorization: msal_auth
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new DashboardWidgetManagementApi(config);
            var id = "id_example";  // string | The ID of the dashboard widget.
            var acceptLanguage = "acceptLanguage_example";  // string | The requested language of the response. If not matching it falls back to default language. (optional) 

            try
            {
                DashboardWidget result = apiInstance.HttpDashboardWidgetsGetById(id, acceptLanguage);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DashboardWidgetManagementApi.HttpDashboardWidgetsGetById: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the HttpDashboardWidgetsGetByIdWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<DashboardWidget> response = apiInstance.HttpDashboardWidgetsGetByIdWithHttpInfo(id, acceptLanguage);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling DashboardWidgetManagementApi.HttpDashboardWidgetsGetByIdWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **string** | The ID of the dashboard widget. |  |
| **acceptLanguage** | **string** | The requested language of the response. If not matching it falls back to default language. | [optional]  |

### Return type

[**DashboardWidget**](DashboardWidget.md)

### Authorization

[msal_auth](../README.md#msal_auth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Returns a dashboard widget with the given id. |  -  |
| **404** | The requested item could not be found. |  -  |
| **401** | Unauthorized. Bearer Token not provided. |  -  |
| **500** | Internal server error. Please contact administrator. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="httpdashboardwidgetsupdatebyid"></a>
# **HttpDashboardWidgetsUpdateById**
> DashboardWidget HttpDashboardWidgetsUpdateById (string id, DashboardWidget dashboardWidget, string acceptLanguage = null)



Updates a dashboard widget in database.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Agravity.Public.Api;
using Agravity.Public.Client;
using Agravity.Public.Model;

namespace Example
{
    public class HttpDashboardWidgetsUpdateByIdExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost:7071/api";
            // Configure OAuth2 access token for authorization: msal_auth
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new DashboardWidgetManagementApi(config);
            var id = "id_example";  // string | The ID of the dashboard widget.
            var dashboardWidget = new DashboardWidget(); // DashboardWidget | Body has to be a valid dashboard widget item.
            var acceptLanguage = "acceptLanguage_example";  // string | The requested language of the response. If not matching it falls back to default language. (optional) 

            try
            {
                DashboardWidget result = apiInstance.HttpDashboardWidgetsUpdateById(id, dashboardWidget, acceptLanguage);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DashboardWidgetManagementApi.HttpDashboardWidgetsUpdateById: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the HttpDashboardWidgetsUpdateByIdWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<DashboardWidget> response = apiInstance.HttpDashboardWidgetsUpdateByIdWithHttpInfo(id, dashboardWidget, acceptLanguage);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling DashboardWidgetManagementApi.HttpDashboardWidgetsUpdateByIdWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **string** | The ID of the dashboard widget. |  |
| **dashboardWidget** | [**DashboardWidget**](DashboardWidget.md) | Body has to be a valid dashboard widget item. |  |
| **acceptLanguage** | **string** | The requested language of the response. If not matching it falls back to default language. | [optional]  |

### Return type

[**DashboardWidget**](DashboardWidget.md)

### Authorization

[msal_auth](../README.md#msal_auth)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Returns the updated dashboard widget |  -  |
| **400** | Object is not a valid dashboard_widget. (Code: aa18e99d-f4c2-4ac6-80fb-a18731d17119) &lt;br&gt;No input object given. (Code: e8f1056d-e86d-4cd2-8635-27d245946e93)Error on create dashboard widget in database - max retry count is reached. (Code: ec4d1d3e-daa7-47eb-be6b-04d94f4498c5) |  -  |
| **404** | If the dashboard widget with the ID was not found. |  -  |
| **401** | Unauthorized. Bearer Token not provided. |  -  |
| **500** | Internal server error. Please contact administrator. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

