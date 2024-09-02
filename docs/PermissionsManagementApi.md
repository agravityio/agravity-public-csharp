# Agravity.Public.Api.PermissionsManagementApi

All URIs are relative to *http://localhost:7071/api*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**HttpPermissionSettingsAddIdentities**](PermissionsManagementApi.md#httppermissionsettingsaddidentities) | **POST** /permissions/settings/identities |  |
| [**HttpPermissionSettingsGet**](PermissionsManagementApi.md#httppermissionsettingsget) | **GET** /permissions/settings |  |
| [**HttpPermissionSettingsPut**](PermissionsManagementApi.md#httppermissionsettingsput) | **PUT** /permissions/settings |  |

<a id="httppermissionsettingsaddidentities"></a>
# **HttpPermissionSettingsAddIdentities**
> AgravityInfoResponse HttpPermissionSettingsAddIdentities (List<AzureIdentity> azureIdentity)



This endpoint creates one permission setting entry in the database.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Agravity.Public.Api;
using Agravity.Public.Client;
using Agravity.Public.Model;

namespace Example
{
    public class HttpPermissionSettingsAddIdentitiesExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost:7071/api";
            // Configure OAuth2 access token for authorization: msal_auth
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new PermissionsManagementApi(config);
            var azureIdentity = new List<AzureIdentity>(); // List<AzureIdentity> | This endpoint takes the AzureIdentity  and saves it to the allowed permissions in the cosmos db.

            try
            {
                AgravityInfoResponse result = apiInstance.HttpPermissionSettingsAddIdentities(azureIdentity);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling PermissionsManagementApi.HttpPermissionSettingsAddIdentities: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the HttpPermissionSettingsAddIdentitiesWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<AgravityInfoResponse> response = apiInstance.HttpPermissionSettingsAddIdentitiesWithHttpInfo(azureIdentity);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling PermissionsManagementApi.HttpPermissionSettingsAddIdentitiesWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **azureIdentity** | [**List&lt;AzureIdentity&gt;**](AzureIdentity.md) | This endpoint takes the AzureIdentity  and saves it to the allowed permissions in the cosmos db. |  |

### Return type

[**AgravityInfoResponse**](AgravityInfoResponse.md)

### Authorization

[msal_auth](../README.md#msal_auth)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **201** | Returns the info which identies were added to settings. |  -  |
| **400** | Object is not a valid permission_settings. (Code: cde7d429-b64d-4248-aaf4-3bfc343af518)&lt;br&gt;No input object given. (Code: 185f0c42-fda7-47c4-b574-d41bb84baac3) |  -  |
| **401** | Unauthorized. Bearer Token not provided. |  -  |
| **500** | Internal server error. Please contact administrator. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="httppermissionsettingsget"></a>
# **HttpPermissionSettingsGet**
> PermissionSetting HttpPermissionSettingsGet ()



This endpoint lists all permission settings in database.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Agravity.Public.Api;
using Agravity.Public.Client;
using Agravity.Public.Model;

namespace Example
{
    public class HttpPermissionSettingsGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost:7071/api";
            // Configure OAuth2 access token for authorization: msal_auth
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new PermissionsManagementApi(config);

            try
            {
                PermissionSetting result = apiInstance.HttpPermissionSettingsGet();
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling PermissionsManagementApi.HttpPermissionSettingsGet: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the HttpPermissionSettingsGetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<PermissionSetting> response = apiInstance.HttpPermissionSettingsGetWithHttpInfo();
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling PermissionsManagementApi.HttpPermissionSettingsGetWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters
This endpoint does not need any parameter.
### Return type

[**PermissionSetting**](PermissionSetting.md)

### Authorization

[msal_auth](../README.md#msal_auth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Returns all permission settings in database. |  -  |
| **401** | Unauthorized. Bearer Token not provided. |  -  |
| **500** | Internal server error. Please contact administrator. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="httppermissionsettingsput"></a>
# **HttpPermissionSettingsPut**
> PermissionSetting HttpPermissionSettingsPut (PermissionSetting permissionSetting)



This endpoint creates one permission setting entry in the database.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Agravity.Public.Api;
using Agravity.Public.Client;
using Agravity.Public.Model;

namespace Example
{
    public class HttpPermissionSettingsPutExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost:7071/api";
            // Configure OAuth2 access token for authorization: msal_auth
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new PermissionsManagementApi(config);
            var permissionSetting = new PermissionSetting(); // PermissionSetting | This endpoint overwrites the permission setting ID and adds the information to the database.

            try
            {
                PermissionSetting result = apiInstance.HttpPermissionSettingsPut(permissionSetting);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling PermissionsManagementApi.HttpPermissionSettingsPut: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the HttpPermissionSettingsPutWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<PermissionSetting> response = apiInstance.HttpPermissionSettingsPutWithHttpInfo(permissionSetting);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling PermissionsManagementApi.HttpPermissionSettingsPutWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **permissionSetting** | [**PermissionSetting**](PermissionSetting.md) | This endpoint overwrites the permission setting ID and adds the information to the database. |  |

### Return type

[**PermissionSetting**](PermissionSetting.md)

### Authorization

[msal_auth](../README.md#msal_auth)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **201** | Returns the created permission setting. |  -  |
| **400** | Object is not a valid permission_settings. (Code: 4f85d9e9-aa43-41d4-a34b-df2bfaf3095d)&lt;br&gt;No input object given. (Code: 52a4a0bb-7b89-4db0-9989-c886d9d9158a) |  -  |
| **401** | Unauthorized. Bearer Token not provided. |  -  |
| **500** | Internal server error. Please contact administrator. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

