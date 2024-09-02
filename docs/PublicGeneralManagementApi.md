# Agravity.Public.Api.PublicGeneralManagementApi

All URIs are relative to *http://localhost:7072/api*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**HttpAgravityVersionInfo**](PublicGeneralManagementApi.md#httpagravityversioninfo) | **GET** /version |  |
| [**HttpGetDeletedEntities**](PublicGeneralManagementApi.md#httpgetdeletedentities) | **GET** /deleted |  |
| [**HttpTriggerDurableContinue**](PublicGeneralManagementApi.md#httptriggerdurablecontinue) | **GET** /durable/{instanceId} |  |
| [**HttpTriggerDurableScchTrainingDone**](PublicGeneralManagementApi.md#httptriggerdurablescchtrainingdone) | **GET** /durable/scch/{instanceId} |  |

<a id="httpagravityversioninfo"></a>
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

<a id="httpgetdeletedentities"></a>
# **HttpGetDeletedEntities**
> List&lt;DeletedEntities&gt; HttpGetDeletedEntities (string entityType = null, string since = null, string until = null, string portalId = null)



This endpoint checks all deleted entities in the database until a specific date and returns the elements which are deleted.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Agravity.Public.Api;
using Agravity.Public.Client;
using Agravity.Public.Model;

namespace Example
{
    public class HttpGetDeletedEntitiesExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost:7072/api";
            // Configure API key authorization: function_key
            config.AddApiKey("x-functions-key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("x-functions-key", "Bearer");

            var apiInstance = new PublicGeneralManagementApi(config);
            var entityType = "entityType_example";  // string | The type of the entity (e.g. 'asset', 'collection_type', 'collection_type' (optional) 
            var since = "since_example";  // string | The date in the past since the entities are marked as deleted in the database. (optional) 
            var until = "until_example";  // string | The date in the past until the entities are marked as deleted in the database. (optional) 
            var portalId = "portalId_example";  // string | If the request comes from portal this is the indicator. (optional) 

            try
            {
                List<DeletedEntities> result = apiInstance.HttpGetDeletedEntities(entityType, since, until, portalId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling PublicGeneralManagementApi.HttpGetDeletedEntities: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the HttpGetDeletedEntitiesWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<List<DeletedEntities>> response = apiInstance.HttpGetDeletedEntitiesWithHttpInfo(entityType, since, until, portalId);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling PublicGeneralManagementApi.HttpGetDeletedEntitiesWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **entityType** | **string** | The type of the entity (e.g. &#39;asset&#39;, &#39;collection_type&#39;, &#39;collection_type&#39; | [optional]  |
| **since** | **string** | The date in the past since the entities are marked as deleted in the database. | [optional]  |
| **until** | **string** | The date in the past until the entities are marked as deleted in the database. | [optional]  |
| **portalId** | **string** | If the request comes from portal this is the indicator. | [optional]  |

### Return type

[**List&lt;DeletedEntities&gt;**](DeletedEntities.md)

### Authorization

[function_key](../README.md#function_key)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | A list of entities which are deleted since the given date (last modified date &#x3D; deleted date). |  -  |
| **400** | Since date could not be more in the future than until date. (Code: d362e2d4-b6b1-4547-a97c-058d2f46acfc)&lt;br&gt;Entity type &#39;{entityType}&#39; is not valid. (Code: 79abc89e-e072-4cf5-a63a-1573764975c6)&lt;br&gt;Entity type &#39;{entityType}&#39; is not allowed for this user. (Code: b00efbb5-faeb-4758-9ea3-44b5435a2311)&lt;br&gt;Error on getting deleted entities. (Code: 71fad553-4c82-423a-807e-ba272bfd3404)&lt;br&gt; |  -  |
| **401** | Unauthorized. API Key not provided. |  -  |
| **404** | When the portal_id could not be found. |  -  |
| **500** | Internal server error. Please contact administrator. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="httptriggerdurablecontinue"></a>
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

<a id="httptriggerdurablescchtrainingdone"></a>
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

