# Agravity.Public.Api.StructureImportApi

All URIs are relative to *http://localhost:7071/api*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**HttpStructureCreateCollections**](StructureImportApi.md#httpstructurecreatecollections) | **PUT** /structure |  |

<a id="httpstructurecreatecollections"></a>
# **HttpStructureCreateCollections**
> List&lt;BlobInfoObj&gt; HttpStructureCreateCollections ()



This endpoint reads and creates structure elements for subfolders in the database based on container folder structure

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Agravity.Public.Api;
using Agravity.Public.Client;
using Agravity.Public.Model;

namespace Example
{
    public class HttpStructureCreateCollectionsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost:7071/api";
            // Configure OAuth2 access token for authorization: msal_auth
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new StructureImportApi(config);

            try
            {
                List<BlobInfoObj> result = apiInstance.HttpStructureCreateCollections();
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling StructureImportApi.HttpStructureCreateCollections: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the HttpStructureCreateCollectionsWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<List<BlobInfoObj>> response = apiInstance.HttpStructureCreateCollectionsWithHttpInfo();
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling StructureImportApi.HttpStructureCreateCollectionsWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters
This endpoint does not need any parameter.
### Return type

[**List&lt;BlobInfoObj&gt;**](BlobInfoObj.md)

### Authorization

[msal_auth](../README.md#msal_auth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Creates structure elements in the database. |  -  |
| **400** | The given collection parameter \&quot;parent\&quot; is not found in database. (Code:0aa8b943-c2ba-4694-83e2-c42b8f2738aa)&lt;br&gt;The given collection parameter \&quot;parent\&quot; is not found in database. (Code: 0aa8b943-c2ba-4694-83e2-c42b8f2738aa)&lt;br&gt;The given collectiontypeid parameter \&quot;collectiontypeid\&quot; is not a valid collection-type. (Code: 7534dc53-d54b-40c1-9d04-d8aa305030a4) |  -  |
| **401** | Unauthorized. Bearer Token not provided. |  -  |
| **404** | The requested item could not be found. |  -  |
| **500** | Internal server error. Please contact administrator. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

