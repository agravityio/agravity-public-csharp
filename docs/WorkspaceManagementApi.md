# Agravity.Public.Api.WorkspaceManagementApi

All URIs are relative to *http://localhost:7071/api*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**HttpWorkspacesCreate**](WorkspaceManagementApi.md#httpworkspacescreate) | **POST** /workspaces |  |
| [**HttpWorkspacesDelete**](WorkspaceManagementApi.md#httpworkspacesdelete) | **DELETE** /workspaces |  |
| [**HttpWorkspacesDeleteById**](WorkspaceManagementApi.md#httpworkspacesdeletebyid) | **DELETE** /workspaces/{id} |  |
| [**HttpWorkspacesGet**](WorkspaceManagementApi.md#httpworkspacesget) | **GET** /workspaces |  |
| [**HttpWorkspacesGetById**](WorkspaceManagementApi.md#httpworkspacesgetbyid) | **GET** /workspaces/{id} |  |
| [**HttpWorkspacesUpdateById**](WorkspaceManagementApi.md#httpworkspacesupdatebyid) | **POST** /workspaces/{id} |  |
| [**HttpWorkspacesUpdatePermissionsById**](WorkspaceManagementApi.md#httpworkspacesupdatepermissionsbyid) | **POST** /workspaces/{id}/permissions |  |

<a id="httpworkspacescreate"></a>
# **HttpWorkspacesCreate**
> Workspace HttpWorkspacesCreate (Workspace workspace, bool? translations = null, string acceptLanguage = null)



This endpoint creates a unique workspace ID and adds the information to the database.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Agravity.Public.Api;
using Agravity.Public.Client;
using Agravity.Public.Model;

namespace Example
{
    public class HttpWorkspacesCreateExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost:7071/api";
            // Configure OAuth2 access token for authorization: msal_auth
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new WorkspaceManagementApi(config);
            var workspace = new Workspace(); // Workspace | This endpoint creates a unique workspace ID and adds the information to the database.
            var translations = true;  // bool? | When default language should be returned and the translation dictionary is delivered. (Ignores the \"Accept-Language\" header) (optional) 
            var acceptLanguage = "acceptLanguage_example";  // string | The requested language of the response. If not matching it falls back to default language. (optional) 

            try
            {
                Workspace result = apiInstance.HttpWorkspacesCreate(workspace, translations, acceptLanguage);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling WorkspaceManagementApi.HttpWorkspacesCreate: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the HttpWorkspacesCreateWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<Workspace> response = apiInstance.HttpWorkspacesCreateWithHttpInfo(workspace, translations, acceptLanguage);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling WorkspaceManagementApi.HttpWorkspacesCreateWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **workspace** | [**Workspace**](Workspace.md) | This endpoint creates a unique workspace ID and adds the information to the database. |  |
| **translations** | **bool?** | When default language should be returned and the translation dictionary is delivered. (Ignores the \&quot;Accept-Language\&quot; header) | [optional]  |
| **acceptLanguage** | **string** | The requested language of the response. If not matching it falls back to default language. | [optional]  |

### Return type

[**Workspace**](Workspace.md)

### Authorization

[msal_auth](../README.md#msal_auth)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **201** | Returns the created workspace. |  -  |
| **400** | A parameter is null. (Code: db5cf052-8736-48c6-9a20-cf6e47671029)&lt;br&gt;Object is not a valid workspace object type. (Code: cf904fef-d162-4a04-9b06-83cf8f4e54e4)&lt;br&gt;Not valid workspace id. (Code: c901ae91-9A99-4DF2-BF4A-51cf6ceaca23)&lt;br&gt;Can not create workspace with id {input.Id}. Workspace already exists. Delete first. (Code: efed3557-5533-4943-815d-b0d7c9dbc35c)&lt;br&gt;workspace name must not be empty. (Code: dd3981aa-903c-405b-8de7-74f0f04d4988)&lt;br&gt; |  -  |
| **401** | Unauthorized. Bearer Token not provided. |  -  |
| **500** | Internal server error. Please contact administrator. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="httpworkspacesdelete"></a>
# **HttpWorkspacesDelete**
> void HttpWorkspacesDelete ()



This endpoint deletes all workspaces on the system.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Agravity.Public.Api;
using Agravity.Public.Client;
using Agravity.Public.Model;

namespace Example
{
    public class HttpWorkspacesDeleteExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost:7071/api";
            // Configure OAuth2 access token for authorization: msal_auth
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new WorkspaceManagementApi(config);

            try
            {
                apiInstance.HttpWorkspacesDelete();
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling WorkspaceManagementApi.HttpWorkspacesDelete: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the HttpWorkspacesDeleteWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    apiInstance.HttpWorkspacesDeleteWithHttpInfo();
}
catch (ApiException e)
{
    Debug.Print("Exception when calling WorkspaceManagementApi.HttpWorkspacesDeleteWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters
This endpoint does not need any parameter.
### Return type

void (empty response body)

### Authorization

[msal_auth](../README.md#msal_auth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **204** | The delete operation of all the workspaces on the system. |  -  |
| **401** | Unauthorized. Bearer Token not provided. |  -  |
| **500** | Internal server error. Please contact administrator. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="httpworkspacesdeletebyid"></a>
# **HttpWorkspacesDeleteById**
> void HttpWorkspacesDeleteById (string id)



This endpoint deletes the workspace with the given ID.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Agravity.Public.Api;
using Agravity.Public.Client;
using Agravity.Public.Model;

namespace Example
{
    public class HttpWorkspacesDeleteByIdExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost:7071/api";
            // Configure OAuth2 access token for authorization: msal_auth
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new WorkspaceManagementApi(config);
            var id = "id_example";  // string | The ID of the workspace.

            try
            {
                apiInstance.HttpWorkspacesDeleteById(id);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling WorkspaceManagementApi.HttpWorkspacesDeleteById: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the HttpWorkspacesDeleteByIdWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    apiInstance.HttpWorkspacesDeleteByIdWithHttpInfo(id);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling WorkspaceManagementApi.HttpWorkspacesDeleteByIdWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **string** | The ID of the workspace. |  |

### Return type

void (empty response body)

### Authorization

[msal_auth](../README.md#msal_auth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **204** | The delete operation of the workspace with the given ID was successful. |  -  |
| **404** | If the workspace with the ID was not found. |  -  |
| **401** | Unauthorized. Bearer Token not provided. |  -  |
| **500** | Internal server error. Please contact administrator. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="httpworkspacesget"></a>
# **HttpWorkspacesGet**
> List&lt;Workspace&gt; HttpWorkspacesGet (bool? translations = null, string acceptLanguage = null)



This endpoint lists all available workspaces, which are stored in the database and not deleted (status \"A\").

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Agravity.Public.Api;
using Agravity.Public.Client;
using Agravity.Public.Model;

namespace Example
{
    public class HttpWorkspacesGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost:7071/api";
            // Configure OAuth2 access token for authorization: msal_auth
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new WorkspaceManagementApi(config);
            var translations = true;  // bool? | When default language should be returned and the translation dictionary is delivered. (Ignores the \"Accept-Language\" header) (optional) 
            var acceptLanguage = "acceptLanguage_example";  // string | The requested language of the response. If not matching it falls back to default language. (optional) 

            try
            {
                List<Workspace> result = apiInstance.HttpWorkspacesGet(translations, acceptLanguage);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling WorkspaceManagementApi.HttpWorkspacesGet: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the HttpWorkspacesGetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<List<Workspace>> response = apiInstance.HttpWorkspacesGetWithHttpInfo(translations, acceptLanguage);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling WorkspaceManagementApi.HttpWorkspacesGetWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **translations** | **bool?** | When default language should be returned and the translation dictionary is delivered. (Ignores the \&quot;Accept-Language\&quot; header) | [optional]  |
| **acceptLanguage** | **string** | The requested language of the response. If not matching it falls back to default language. | [optional]  |

### Return type

[**List&lt;Workspace&gt;**](Workspace.md)

### Authorization

[msal_auth](../README.md#msal_auth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Returns all workspaces as array. |  -  |
| **400** | (Code: e244cef3-2665-4757-ba34-0d4d0e71bb9d) |  -  |
| **401** | Unauthorized. Bearer Token not provided. |  -  |
| **500** | Internal server error. Please contact administrator. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="httpworkspacesgetbyid"></a>
# **HttpWorkspacesGetById**
> Workspace HttpWorkspacesGetById (string id, bool? translations = null, string acceptLanguage = null)



This endpoint returns one single workspace (from ID).

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Agravity.Public.Api;
using Agravity.Public.Client;
using Agravity.Public.Model;

namespace Example
{
    public class HttpWorkspacesGetByIdExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost:7071/api";
            // Configure OAuth2 access token for authorization: msal_auth
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new WorkspaceManagementApi(config);
            var id = "id_example";  // string | The ID of the workspace.
            var translations = true;  // bool? | When default language should be returned and the translation dictionary is delivered. (Ignores the \"Accept-Language\" header) (optional) 
            var acceptLanguage = "acceptLanguage_example";  // string | The requested language of the response. If not matching it falls back to default language. (optional) 

            try
            {
                Workspace result = apiInstance.HttpWorkspacesGetById(id, translations, acceptLanguage);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling WorkspaceManagementApi.HttpWorkspacesGetById: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the HttpWorkspacesGetByIdWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<Workspace> response = apiInstance.HttpWorkspacesGetByIdWithHttpInfo(id, translations, acceptLanguage);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling WorkspaceManagementApi.HttpWorkspacesGetByIdWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **string** | The ID of the workspace. |  |
| **translations** | **bool?** | When default language should be returned and the translation dictionary is delivered. (Ignores the \&quot;Accept-Language\&quot; header) | [optional]  |
| **acceptLanguage** | **string** | The requested language of the response. If not matching it falls back to default language. | [optional]  |

### Return type

[**Workspace**](Workspace.md)

### Authorization

[msal_auth](../README.md#msal_auth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Returns the workspace with the requested ID. |  -  |
| **404** | The workspace with the ID was not found. |  -  |
| **401** | Unauthorized. Bearer Token not provided. |  -  |
| **500** | Internal server error. Please contact administrator. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="httpworkspacesupdatebyid"></a>
# **HttpWorkspacesUpdateById**
> Workspace HttpWorkspacesUpdateById (string id, Workspace workspace, bool? translations = null, string acceptLanguage = null)



This endpoint updates the workspace. Null fields will be ignored. If 'items' are set they are fully reset (like PUT).

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Agravity.Public.Api;
using Agravity.Public.Client;
using Agravity.Public.Model;

namespace Example
{
    public class HttpWorkspacesUpdateByIdExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost:7071/api";
            // Configure OAuth2 access token for authorization: msal_auth
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new WorkspaceManagementApi(config);
            var id = "id_example";  // string | The ID of the workspace.
            var workspace = new Workspace(); // Workspace | The body has to be a valid workspace json. Not fitting properties are ignored.
            var translations = true;  // bool? | When default language should be returned and the translation dictionary is delivered. (Ignores the \"Accept-Language\" header) (optional) 
            var acceptLanguage = "acceptLanguage_example";  // string | The requested language of the response. If not matching it falls back to default language. (optional) 

            try
            {
                Workspace result = apiInstance.HttpWorkspacesUpdateById(id, workspace, translations, acceptLanguage);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling WorkspaceManagementApi.HttpWorkspacesUpdateById: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the HttpWorkspacesUpdateByIdWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<Workspace> response = apiInstance.HttpWorkspacesUpdateByIdWithHttpInfo(id, workspace, translations, acceptLanguage);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling WorkspaceManagementApi.HttpWorkspacesUpdateByIdWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **string** | The ID of the workspace. |  |
| **workspace** | [**Workspace**](Workspace.md) | The body has to be a valid workspace json. Not fitting properties are ignored. |  |
| **translations** | **bool?** | When default language should be returned and the translation dictionary is delivered. (Ignores the \&quot;Accept-Language\&quot; header) | [optional]  |
| **acceptLanguage** | **string** | The requested language of the response. If not matching it falls back to default language. | [optional]  |

### Return type

[**Workspace**](Workspace.md)

### Authorization

[msal_auth](../README.md#msal_auth)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Returns the updated full workspace incl. items. |  -  |
| **400** | A parameter is null. (Code: 079acaea-b257-4669-9621-99566889231e)&lt;br&gt;Object is not a valid workspace. (Code: 10e088c7-3ea1-4141-902a-4b5f6fad90ae)&lt;br&gt; |  -  |
| **401** | Unauthorized. Bearer Token not provided. |  -  |
| **404** | The requested item could not be found. |  -  |
| **500** | Internal server error. Please contact administrator. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="httpworkspacesupdatepermissionsbyid"></a>
# **HttpWorkspacesUpdatePermissionsById**
> AgravityInfoResponse HttpWorkspacesUpdatePermissionsById (string id, PermissionChange permissionChange)



This endpoint updates the permissions of the workspace. The modifier tells the system what to do with the list of ids.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Agravity.Public.Api;
using Agravity.Public.Client;
using Agravity.Public.Model;

namespace Example
{
    public class HttpWorkspacesUpdatePermissionsByIdExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost:7071/api";
            // Configure OAuth2 access token for authorization: msal_auth
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new WorkspaceManagementApi(config);
            var id = "id_example";  // string | The ID of the workspace.
            var permissionChange = new PermissionChange(); // PermissionChange | The changes which ids and how they should be added / removed / replaced / etc.

            try
            {
                AgravityInfoResponse result = apiInstance.HttpWorkspacesUpdatePermissionsById(id, permissionChange);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling WorkspaceManagementApi.HttpWorkspacesUpdatePermissionsById: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the HttpWorkspacesUpdatePermissionsByIdWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<AgravityInfoResponse> response = apiInstance.HttpWorkspacesUpdatePermissionsByIdWithHttpInfo(id, permissionChange);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling WorkspaceManagementApi.HttpWorkspacesUpdatePermissionsByIdWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **string** | The ID of the workspace. |  |
| **permissionChange** | [**PermissionChange**](PermissionChange.md) | The changes which ids and how they should be added / removed / replaced / etc. |  |

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
| **200** | Returns the info about the updated permissions. |  -  |
| **400** | Body is not a valid permission change object. (Code: 4a048f4b-c557-402d-a4ef-bd8558d58d75)&lt;br&gt;Object needs an body. (Code: 4f200eca-593b-4a1c-bc6e-9b9ad99bec8e)&lt;br&gt;The default workspace can not have any permissions. (Code: b4676c1d-3916-4e63-8322-52b589bec773) |  -  |
| **401** | Unauthorized. Bearer Token not provided. |  -  |
| **404** | The requested item could not be found. |  -  |
| **500** | Internal server error. Please contact administrator. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

