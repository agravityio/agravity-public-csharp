# AgravityPublic.Api.PublicWorkspaceManagementApi

All URIs are relative to *http://localhost:7072/api*

Method | HTTP request | Description
------------- | ------------- | -------------
[**HttpWorkspacesGet**](PublicWorkspaceManagementApi.md#httpworkspacesget) | **GET** /workspaces | 
[**HttpWorkspacesGetById**](PublicWorkspaceManagementApi.md#httpworkspacesgetbyid) | **GET** /workspaces/{id} | 



## HttpWorkspacesGet

> List&lt;Workspace&gt; HttpWorkspacesGet ()



This lists all available workspaces which are stored in the database and not deleted (status \"A\").

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using AgravityPublic.Api;
using AgravityPublic.Client;
using AgravityPublic.Model;

namespace Example
{
    public class HttpWorkspacesGetExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "http://localhost:7072/api";
            // Configure API key authorization: function_key
            Configuration.Default.AddApiKey("x-functions-key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("x-functions-key", "Bearer");

            var apiInstance = new PublicWorkspaceManagementApi(Configuration.Default);

            try
            {
                List<Workspace> result = apiInstance.HttpWorkspacesGet();
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling PublicWorkspaceManagementApi.HttpWorkspacesGet: " + e.Message );
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

[**List&lt;Workspace&gt;**](Workspace.md)

### Authorization

[function_key](../README.md#function_key)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Returns the all workspaces as array. |  -  |
| **400** | Could not create connection to CosmosDB (Code: e244cef3-2665-4757-ba34-0d4d0e71bb9d) |  -  |
| **401** | Unauthorized. API Key not provided. |  -  |
| **500** | Internal server error. Please contact administrator. |  -  |

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## HttpWorkspacesGetById

> Workspace HttpWorkspacesGetById (string id)



Returns one single workspace (from ID).

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using AgravityPublic.Api;
using AgravityPublic.Client;
using AgravityPublic.Model;

namespace Example
{
    public class HttpWorkspacesGetByIdExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "http://localhost:7072/api";
            // Configure API key authorization: function_key
            Configuration.Default.AddApiKey("x-functions-key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("x-functions-key", "Bearer");

            var apiInstance = new PublicWorkspaceManagementApi(Configuration.Default);
            var id = id_example;  // string | The ID of the workspace.

            try
            {
                Workspace result = apiInstance.HttpWorkspacesGetById(id);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling PublicWorkspaceManagementApi.HttpWorkspacesGetById: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| The ID of the workspace. | 

### Return type

[**Workspace**](Workspace.md)

### Authorization

[function_key](../README.md#function_key)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Returns the workspace with the given ID. |  -  |
| **404** | If the workspace with the ID was not found. |  -  |
| **401** | Unauthorized. API Key not provided. |  -  |
| **500** | Internal server error. Please contact administrator. |  -  |

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)

