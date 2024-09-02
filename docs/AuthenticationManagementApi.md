# Agravity.Public.Api.AuthenticationManagementApi

All URIs are relative to *http://localhost:7071/api*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**HttpAuthCreatePublicApiKey**](AuthenticationManagementApi.md#httpauthcreatepublicapikey) | **POST** /auth/apikey |  |
| [**HttpAuthDeleteImpersonateUser**](AuthenticationManagementApi.md#httpauthdeleteimpersonateuser) | **DELETE** /auth/impersonate |  |
| [**HttpAuthDeletePublicApiKey**](AuthenticationManagementApi.md#httpauthdeletepublicapikey) | **DELETE** /auth/apikey/{id} |  |
| [**HttpAuthGetAgravityUser**](AuthenticationManagementApi.md#httpauthgetagravityuser) | **GET** /auth/user |  |
| [**HttpAuthGetAgravityUserById**](AuthenticationManagementApi.md#httpauthgetagravityuserbyid) | **GET** /auth/users/{id} |  |
| [**HttpAuthGetAgravityUsers**](AuthenticationManagementApi.md#httpauthgetagravityusers) | **GET** /auth/users |  |
| [**HttpAuthGetAppClientId**](AuthenticationManagementApi.md#httpauthgetappclientid) | **GET** /auth/clientid |  |
| [**HttpAuthGetBlobReadSasToken**](AuthenticationManagementApi.md#httpauthgetblobreadsastoken) | **GET** /auth/blob/{blobName} |  |
| [**HttpAuthGetContainerReadSasToken**](AuthenticationManagementApi.md#httpauthgetcontainerreadsastoken) | **GET** /auth/container/{containerName} |  |
| [**HttpAuthGetInboxContainerWriteSasToken**](AuthenticationManagementApi.md#httpauthgetinboxcontainerwritesastoken) | **GET** /auth/inbox |  |
| [**HttpAuthGetUserId**](AuthenticationManagementApi.md#httpauthgetuserid) | **GET** /auth/userid |  |
| [**HttpAuthPatchImpersonateUser**](AuthenticationManagementApi.md#httpauthpatchimpersonateuser) | **PATCH** /auth/impersonate/{id} |  |

<a id="httpauthcreatepublicapikey"></a>
# **HttpAuthCreatePublicApiKey**
> AgravityUser HttpAuthCreatePublicApiKey (AgravityUserDto agravityUserDto)



This endpoint creates a new api key user in database and registers it on the public function

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Agravity.Public.Api;
using Agravity.Public.Client;
using Agravity.Public.Model;

namespace Example
{
    public class HttpAuthCreatePublicApiKeyExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost:7071/api";
            // Configure OAuth2 access token for authorization: msal_auth
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new AuthenticationManagementApi(config);
            var agravityUserDto = new AgravityUserDto(); // AgravityUserDto | The user to create.

            try
            {
                AgravityUser result = apiInstance.HttpAuthCreatePublicApiKey(agravityUserDto);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AuthenticationManagementApi.HttpAuthCreatePublicApiKey: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the HttpAuthCreatePublicApiKeyWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<AgravityUser> response = apiInstance.HttpAuthCreatePublicApiKeyWithHttpInfo(agravityUserDto);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling AuthenticationManagementApi.HttpAuthCreatePublicApiKeyWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **agravityUserDto** | [**AgravityUserDto**](AgravityUserDto.md) | The user to create. |  |

### Return type

[**AgravityUser**](AgravityUser.md)

### Authorization

[msal_auth](../README.md#msal_auth)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **201** | Returns the created Agravity user. |  -  |
| **400** | Object is not a valid user. (Code: 1e5f4c39-4d65-4f3b-9f14-11b08c744313)No input object given. (Code: 89966343-700c-439f-8bf6-0659f4585002)Error on upsert user in database - max retry count is reached. (Code: 81927067-6bf0-42da-9efd-c7d7507878dc) |  -  |
| **401** | Unauthorized. Bearer Token not provided. |  -  |
| **500** | Internal server error. Please contact administrator. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="httpauthdeleteimpersonateuser"></a>
# **HttpAuthDeleteImpersonateUser**
> AgravityInfoResponse HttpAuthDeleteImpersonateUser ()



This endpoint to end impersonation an Agravity user.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Agravity.Public.Api;
using Agravity.Public.Client;
using Agravity.Public.Model;

namespace Example
{
    public class HttpAuthDeleteImpersonateUserExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost:7071/api";
            // Configure OAuth2 access token for authorization: msal_auth
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new AuthenticationManagementApi(config);

            try
            {
                AgravityInfoResponse result = apiInstance.HttpAuthDeleteImpersonateUser();
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AuthenticationManagementApi.HttpAuthDeleteImpersonateUser: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the HttpAuthDeleteImpersonateUserWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<AgravityInfoResponse> response = apiInstance.HttpAuthDeleteImpersonateUserWithHttpInfo();
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling AuthenticationManagementApi.HttpAuthDeleteImpersonateUserWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters
This endpoint does not need any parameter.
### Return type

[**AgravityInfoResponse**](AgravityInfoResponse.md)

### Authorization

[msal_auth](../README.md#msal_auth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Displays &#39;Impersonation deactived.&#39;. (Code: e6c6d39b-f2c5-44b5-bc6c-59dd48e069bb) |  -  |
| **400** | Impersonation is not enabled. (Code: d6d44933-b155-44db-b823-b2af13f2a735) |  -  |
| **401** | Unauthorized. Bearer Token not provided. |  -  |
| **500** | Internal server error. Please contact administrator. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="httpauthdeletepublicapikey"></a>
# **HttpAuthDeletePublicApiKey**
> void HttpAuthDeletePublicApiKey (string id)



This endpoint deletes an api key user and removed the key from public functions.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Agravity.Public.Api;
using Agravity.Public.Client;
using Agravity.Public.Model;

namespace Example
{
    public class HttpAuthDeletePublicApiKeyExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost:7071/api";
            // Configure OAuth2 access token for authorization: msal_auth
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new AuthenticationManagementApi(config);
            var id = "id_example";  // string | The ID of api key user

            try
            {
                apiInstance.HttpAuthDeletePublicApiKey(id);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AuthenticationManagementApi.HttpAuthDeletePublicApiKey: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the HttpAuthDeletePublicApiKeyWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    apiInstance.HttpAuthDeletePublicApiKeyWithHttpInfo(id);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling AuthenticationManagementApi.HttpAuthDeletePublicApiKeyWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **string** | The ID of api key user |  |

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
| **400** | Error trying to delete the api key user with the given ID. |  -  |
| **204** | The delete operation of the api key user with the given ID was successful. |  -  |
| **404** | If the api key user with the ID was not found. |  -  |
| **401** | Unauthorized. Bearer Token not provided. |  -  |
| **500** | Internal server error. Please contact administrator. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="httpauthgetagravityuser"></a>
# **HttpAuthGetAgravityUser**
> AgravityUser HttpAuthGetAgravityUser ()



This endpoint returns the user from database of the HTTP request.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Agravity.Public.Api;
using Agravity.Public.Client;
using Agravity.Public.Model;

namespace Example
{
    public class HttpAuthGetAgravityUserExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost:7071/api";
            // Configure OAuth2 access token for authorization: msal_auth
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new AuthenticationManagementApi(config);

            try
            {
                AgravityUser result = apiInstance.HttpAuthGetAgravityUser();
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AuthenticationManagementApi.HttpAuthGetAgravityUser: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the HttpAuthGetAgravityUserWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<AgravityUser> response = apiInstance.HttpAuthGetAgravityUserWithHttpInfo();
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling AuthenticationManagementApi.HttpAuthGetAgravityUserWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters
This endpoint does not need any parameter.
### Return type

[**AgravityUser**](AgravityUser.md)

### Authorization

[msal_auth](../README.md#msal_auth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Returns the Agravity user incl. his role. |  -  |
| **401** | Unauthorized. Bearer Token not provided. |  -  |
| **500** | Internal server error. Please contact administrator. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="httpauthgetagravityuserbyid"></a>
# **HttpAuthGetAgravityUserById**
> AgravityUser HttpAuthGetAgravityUserById (string id, bool? limit = null)



This endpoint returns the Agravity user from database.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Agravity.Public.Api;
using Agravity.Public.Client;
using Agravity.Public.Model;

namespace Example
{
    public class HttpAuthGetAgravityUserByIdExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost:7071/api";
            // Configure OAuth2 access token for authorization: msal_auth
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new AuthenticationManagementApi(config);
            var id = "id_example";  // string | The ID of the requested Agravity user.
            var limit = true;  // bool? | (Optional): If the reponse should be limited to name and email. (optional) 

            try
            {
                AgravityUser result = apiInstance.HttpAuthGetAgravityUserById(id, limit);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AuthenticationManagementApi.HttpAuthGetAgravityUserById: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the HttpAuthGetAgravityUserByIdWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<AgravityUser> response = apiInstance.HttpAuthGetAgravityUserByIdWithHttpInfo(id, limit);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling AuthenticationManagementApi.HttpAuthGetAgravityUserByIdWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **string** | The ID of the requested Agravity user. |  |
| **limit** | **bool?** | (Optional): If the reponse should be limited to name and email. | [optional]  |

### Return type

[**AgravityUser**](AgravityUser.md)

### Authorization

[msal_auth](../README.md#msal_auth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Returns the Agravity user. Only if role agravity.admin or user itself get all roles, permissions, shares etc.  |  -  |
| **404** | The given ID was not found in the database.. (Code: 0c50f853-9368-477f-8b36-f176ad8eb18e) |  -  |
| **400** | The given ID is not a valid Agravity user ID. (Code: 6fdb9e67-d178-4038-b9c8-552fa9ef2a74) |  -  |
| **401** | Unauthorized. Bearer Token not provided. |  -  |
| **500** | Internal server error. Please contact administrator. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="httpauthgetagravityusers"></a>
# **HttpAuthGetAgravityUsers**
> List&lt;AgravityUser&gt; HttpAuthGetAgravityUsers (bool? limit = null, bool? apikey = null)



This endpoint returns all the Agravity users from database.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Agravity.Public.Api;
using Agravity.Public.Client;
using Agravity.Public.Model;

namespace Example
{
    public class HttpAuthGetAgravityUsersExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost:7071/api";
            // Configure OAuth2 access token for authorization: msal_auth
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new AuthenticationManagementApi(config);
            var limit = true;  // bool? | (Optional): If the reponse should be limited to name and email. (optional) 
            var apikey = true;  // bool? | (Optional): If the response should be limited to api key users (optional) 

            try
            {
                List<AgravityUser> result = apiInstance.HttpAuthGetAgravityUsers(limit, apikey);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AuthenticationManagementApi.HttpAuthGetAgravityUsers: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the HttpAuthGetAgravityUsersWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<List<AgravityUser>> response = apiInstance.HttpAuthGetAgravityUsersWithHttpInfo(limit, apikey);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling AuthenticationManagementApi.HttpAuthGetAgravityUsersWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **limit** | **bool?** | (Optional): If the reponse should be limited to name and email. | [optional]  |
| **apikey** | **bool?** | (Optional): If the response should be limited to api key users | [optional]  |

### Return type

[**List&lt;AgravityUser&gt;**](AgravityUser.md)

### Authorization

[msal_auth](../README.md#msal_auth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Returns all Agravity user. |  -  |
| **401** | Unauthorized. Bearer Token not provided. |  -  |
| **500** | Internal server error. Please contact administrator. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="httpauthgetappclientid"></a>
# **HttpAuthGetAppClientId**
> AgravityInfoResponse HttpAuthGetAppClientId ()



This endpoint gets the ID of the application client.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Agravity.Public.Api;
using Agravity.Public.Client;
using Agravity.Public.Model;

namespace Example
{
    public class HttpAuthGetAppClientIdExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost:7071/api";
            // Configure OAuth2 access token for authorization: msal_auth
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new AuthenticationManagementApi(config);

            try
            {
                AgravityInfoResponse result = apiInstance.HttpAuthGetAppClientId();
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AuthenticationManagementApi.HttpAuthGetAppClientId: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the HttpAuthGetAppClientIdWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<AgravityInfoResponse> response = apiInstance.HttpAuthGetAppClientIdWithHttpInfo();
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling AuthenticationManagementApi.HttpAuthGetAppClientIdWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters
This endpoint does not need any parameter.
### Return type

[**AgravityInfoResponse**](AgravityInfoResponse.md)

### Authorization

[msal_auth](../README.md#msal_auth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Could extract application client id in object &#39;client_id. (Code: 82c31da4-202d-400c-aed6-d1d5c82271db) |  -  |
| **400** | Could not determine application client from token! (Code: c2c5da9e-5fe2-4ecb-bca9-8792b54b29fe) |  -  |
| **401** | Unauthorized. Bearer Token not provided. |  -  |
| **500** | Internal server error. Please contact administrator. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="httpauthgetblobreadsastoken"></a>
# **HttpAuthGetBlobReadSasToken**
> SasToken HttpAuthGetBlobReadSasToken (string blobName)



This endpoint creates and returns a SAS token for a single blob inside the optimized OR thumbnails container.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Agravity.Public.Api;
using Agravity.Public.Client;
using Agravity.Public.Model;

namespace Example
{
    public class HttpAuthGetBlobReadSasTokenExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost:7071/api";
            // Configure OAuth2 access token for authorization: msal_auth
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new AuthenticationManagementApi(config);
            var blobName = "blobName_example";  // string | The name of the blob (aka the ID of the asset)

            try
            {
                SasToken result = apiInstance.HttpAuthGetBlobReadSasToken(blobName);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AuthenticationManagementApi.HttpAuthGetBlobReadSasToken: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the HttpAuthGetBlobReadSasTokenWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<SasToken> response = apiInstance.HttpAuthGetBlobReadSasTokenWithHttpInfo(blobName);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling AuthenticationManagementApi.HttpAuthGetBlobReadSasTokenWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **blobName** | **string** | The name of the blob (aka the ID of the asset) |  |

### Return type

[**SasToken**](SasToken.md)

### Authorization

[msal_auth](../README.md#msal_auth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Returns SAS-Token for read only access for a blob. |  -  |
| **400** | Container name missing in query! (Code: 36c5841c-15a1-4419-b467-9c099e5a4bc3)&lt;br&gt;Not valid asset name! (Code: 71470409-c8c4-41ef-aab0-33c8936dfd54)&lt;br&gt;No allowed to access containing {blobName}! (Code: defca664-0460-415f-b946-587644157b9b) |  -  |
| **401** | Unauthorized. Bearer Token not provided. |  -  |
| **404** | The requested item could not be found. |  -  |
| **500** | Internal server error. Please contact administrator. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="httpauthgetcontainerreadsastoken"></a>
# **HttpAuthGetContainerReadSasToken**
> SasToken HttpAuthGetContainerReadSasToken (string containerName)



This endpoint creates and returns a SAS token for a single container with read only access

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Agravity.Public.Api;
using Agravity.Public.Client;
using Agravity.Public.Model;

namespace Example
{
    public class HttpAuthGetContainerReadSasTokenExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost:7071/api";
            // Configure OAuth2 access token for authorization: msal_auth
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new AuthenticationManagementApi(config);
            var containerName = "containerName_example";  // string | The name of the requested storage container.

            try
            {
                SasToken result = apiInstance.HttpAuthGetContainerReadSasToken(containerName);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AuthenticationManagementApi.HttpAuthGetContainerReadSasToken: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the HttpAuthGetContainerReadSasTokenWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<SasToken> response = apiInstance.HttpAuthGetContainerReadSasTokenWithHttpInfo(containerName);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling AuthenticationManagementApi.HttpAuthGetContainerReadSasTokenWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **containerName** | **string** | The name of the requested storage container. |  |

### Return type

[**SasToken**](SasToken.md)

### Authorization

[msal_auth](../README.md#msal_auth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Returns SAS-Token for read only access for a container. |  -  |
| **400** | A parameter is null. (Code: d7764a19-584f-47c2-85db-93e5840328fc)&lt;br&gt;No allowed to access container {containerName}! (Code: ec33a6bf-d8bf-4728-8156-f7ead3e1d880) |  -  |
| **401** | Unauthorized. Bearer Token not provided. |  -  |
| **404** | The requested item could not be found. |  -  |
| **500** | Internal server error. Please contact administrator. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="httpauthgetinboxcontainerwritesastoken"></a>
# **HttpAuthGetInboxContainerWriteSasToken**
> SasToken HttpAuthGetInboxContainerWriteSasToken ()



This endpoint creates and returns a SAS-Token with write access for the inbox container

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Agravity.Public.Api;
using Agravity.Public.Client;
using Agravity.Public.Model;

namespace Example
{
    public class HttpAuthGetInboxContainerWriteSasTokenExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost:7071/api";
            // Configure OAuth2 access token for authorization: msal_auth
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new AuthenticationManagementApi(config);

            try
            {
                SasToken result = apiInstance.HttpAuthGetInboxContainerWriteSasToken();
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AuthenticationManagementApi.HttpAuthGetInboxContainerWriteSasToken: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the HttpAuthGetInboxContainerWriteSasTokenWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<SasToken> response = apiInstance.HttpAuthGetInboxContainerWriteSasTokenWithHttpInfo();
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling AuthenticationManagementApi.HttpAuthGetInboxContainerWriteSasTokenWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters
This endpoint does not need any parameter.
### Return type

[**SasToken**](SasToken.md)

### Authorization

[msal_auth](../README.md#msal_auth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Returns SAS-Token for write access for the inbox. |  -  |
| **400** | A parameter is null. (Code: 0554451e-dcc9-4bef-a221-029bc3d77120)&lt;br&gt;Could not generate token for inbox. (Code: 3f19d7be-9d70-4268-93e6-de387daadd54) |  -  |
| **401** | Unauthorized. Bearer Token not provided. |  -  |
| **404** | The requested item could not be found. |  -  |
| **500** | Internal server error. Please contact administrator. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="httpauthgetuserid"></a>
# **HttpAuthGetUserId**
> AgravityInfoResponse HttpAuthGetUserId ()



This endpoint gets the ID of the user.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Agravity.Public.Api;
using Agravity.Public.Client;
using Agravity.Public.Model;

namespace Example
{
    public class HttpAuthGetUserIdExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost:7071/api";
            // Configure OAuth2 access token for authorization: msal_auth
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new AuthenticationManagementApi(config);

            try
            {
                AgravityInfoResponse result = apiInstance.HttpAuthGetUserId();
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AuthenticationManagementApi.HttpAuthGetUserId: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the HttpAuthGetUserIdWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<AgravityInfoResponse> response = apiInstance.HttpAuthGetUserIdWithHttpInfo();
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling AuthenticationManagementApi.HttpAuthGetUserIdWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters
This endpoint does not need any parameter.
### Return type

[**AgravityInfoResponse**](AgravityInfoResponse.md)

### Authorization

[msal_auth](../README.md#msal_auth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Returns the user ID from access token in object &#39;user_id&#39;. (Code: 09b9dffa-f57d-467a-95cc-d823683483a0) |  -  |
| **400** | Could not determine user from token! (Code: 886f22e2-d6cb-4d15-a4ca-c0e7fb8070d6) |  -  |
| **401** | Unauthorized. Bearer Token not provided. |  -  |
| **500** | Internal server error. Please contact administrator. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="httpauthpatchimpersonateuser"></a>
# **HttpAuthPatchImpersonateUser**
> AgravityInfoResponse HttpAuthPatchImpersonateUser (string id)



This endpoint to impersonate an Agravity user.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Agravity.Public.Api;
using Agravity.Public.Client;
using Agravity.Public.Model;

namespace Example
{
    public class HttpAuthPatchImpersonateUserExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost:7071/api";
            // Configure OAuth2 access token for authorization: msal_auth
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new AuthenticationManagementApi(config);
            var id = "id_example";  // string | The ID of the user which should be impersonated.

            try
            {
                AgravityInfoResponse result = apiInstance.HttpAuthPatchImpersonateUser(id);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AuthenticationManagementApi.HttpAuthPatchImpersonateUser: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the HttpAuthPatchImpersonateUserWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<AgravityInfoResponse> response = apiInstance.HttpAuthPatchImpersonateUserWithHttpInfo(id);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling AuthenticationManagementApi.HttpAuthPatchImpersonateUserWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **string** | The ID of the user which should be impersonated. |  |

### Return type

[**AgravityInfoResponse**](AgravityInfoResponse.md)

### Authorization

[msal_auth](../README.md#msal_auth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Displays &#39;Impersonation active&#39;. (Code: 0c0ad3ee-1b79-4b92-940e-e3d4e6397017) |  -  |
| **400** | {id} is not a valid GUID. (Code: a6c19af1-42d9-46b3-8dca-bd849d9c59a9)&lt;br&gt;Impersonation is not enabled. (Code: d6d44933-b155-44db-b823-b2af13f2a735)&lt;br&gt;Not allowed to self-impersonate. (Code: cbaa3d2a-e206-4af3-b56f-8b9a8cd2a828) |  -  |
| **404** | User with id {id} not found. User needs to _logger in first to be impersonated. (Code: 0c0ad3ee-1b79-4b92-940e-e3d4e6397017) |  -  |
| **401** | Unauthorized. Bearer Token not provided. |  -  |
| **500** | Internal server error. Please contact administrator. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

