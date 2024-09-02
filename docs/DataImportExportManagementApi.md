# Agravity.Public.Api.DataImportExportManagementApi

All URIs are relative to *http://localhost:7071/api*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**HttpDataExportAssetsAsExcel**](DataImportExportManagementApi.md#httpdataexportassetsasexcel) | **GET** /data/excel/export/assets |  |
| [**HttpDataExportItemsAsExcel**](DataImportExportManagementApi.md#httpdataexportitemsasexcel) | **GET** /data/excel/export |  |
| [**HttpDataExportTranslationsAsExcel**](DataImportExportManagementApi.md#httpdataexporttranslationsasexcel) | **GET** /data/excel/export/translations |  |
| [**HttpDataExportTranslationsCancel**](DataImportExportManagementApi.md#httpdataexporttranslationscancel) | **DELETE** /data/excel/export/translations/{id} |  |
| [**HttpDataExportTranslationsCheckStatus**](DataImportExportManagementApi.md#httpdataexporttranslationscheckstatus) | **GET** /data/excel/export/translations/{id} |  |
| [**HttpDataImportTranslationsAsExcel**](DataImportExportManagementApi.md#httpdataimporttranslationsasexcel) | **POST** /data/excel/import/translations |  |

<a id="httpdataexportassetsasexcel"></a>
# **HttpDataExportAssetsAsExcel**
> ExcelExportTableEntity HttpDataExportAssetsAsExcel (string ids = null, string language = null)



This endpoint creates an excel export of an asset list.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Agravity.Public.Api;
using Agravity.Public.Client;
using Agravity.Public.Model;

namespace Example
{
    public class HttpDataExportAssetsAsExcelExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost:7071/api";
            // Configure OAuth2 access token for authorization: msal_auth
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new DataImportExportManagementApi(config);
            var ids = "ids_example";  // string | Used to specify what to be returned. Valid values are: collection_type_ids, collection_ids and asset_ids. When providing multiple values separate it with comma (','). (optional) 
            var language = "language_example";  // string | In which language the assets should be exported. (optional) 

            try
            {
                ExcelExportTableEntity result = apiInstance.HttpDataExportAssetsAsExcel(ids, language);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DataImportExportManagementApi.HttpDataExportAssetsAsExcel: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the HttpDataExportAssetsAsExcelWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<ExcelExportTableEntity> response = apiInstance.HttpDataExportAssetsAsExcelWithHttpInfo(ids, language);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling DataImportExportManagementApi.HttpDataExportAssetsAsExcelWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **ids** | **string** | Used to specify what to be returned. Valid values are: collection_type_ids, collection_ids and asset_ids. When providing multiple values separate it with comma (&#39;,&#39;). | [optional]  |
| **language** | **string** | In which language the assets should be exported. | [optional]  |

### Return type

[**ExcelExportTableEntity**](ExcelExportTableEntity.md)

### Authorization

[msal_auth](../README.md#msal_auth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | The result when the asset export was triggered successfully |  -  |
| **404** | The requested item could not be found. |  -  |
| **401** | Unauthorized. Bearer Token not provided. |  -  |
| **500** | Internal server error. Please contact administrator. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="httpdataexportitemsasexcel"></a>
# **HttpDataExportItemsAsExcel**
> AgravityInfoResponse HttpDataExportItemsAsExcel (string filter = null)



This endpoint creates an excel export of the db

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Agravity.Public.Api;
using Agravity.Public.Client;
using Agravity.Public.Model;

namespace Example
{
    public class HttpDataExportItemsAsExcelExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost:7071/api";
            // Configure OAuth2 access token for authorization: msal_auth
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new DataImportExportManagementApi(config);
            var filter = "filter_example";  // string | Used to specify what to be retured. Valid values are: asset, workspace, collection_type and/or only certain collection types (IDs) for exporting. When providing multiple values separate it with comma (','). (optional) 

            try
            {
                AgravityInfoResponse result = apiInstance.HttpDataExportItemsAsExcel(filter);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DataImportExportManagementApi.HttpDataExportItemsAsExcel: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the HttpDataExportItemsAsExcelWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<AgravityInfoResponse> response = apiInstance.HttpDataExportItemsAsExcelWithHttpInfo(filter);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling DataImportExportManagementApi.HttpDataExportItemsAsExcelWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **filter** | **string** | Used to specify what to be retured. Valid values are: asset, workspace, collection_type and/or only certain collection types (IDs) for exporting. When providing multiple values separate it with comma (&#39;,&#39;). | [optional]  |

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
| **200** | The md5 hash of the asset. |  -  |
| **404** | Could not find colltypes with the specified filter. |  -  |
| **401** | Unauthorized. Bearer Token not provided. |  -  |
| **500** | Internal server error. Please contact administrator. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="httpdataexporttranslationsasexcel"></a>
# **HttpDataExportTranslationsAsExcel**
> ExcelExportTableEntity HttpDataExportTranslationsAsExcel (string filter = null)



This endpoint creates an excel export of translations of db entities

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Agravity.Public.Api;
using Agravity.Public.Client;
using Agravity.Public.Model;

namespace Example
{
    public class HttpDataExportTranslationsAsExcelExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost:7071/api";
            // Configure OAuth2 access token for authorization: msal_auth
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new DataImportExportManagementApi(config);
            var filter = "filter_example";  // string | Used to specify what to be returned. Valid values are: asset, workspace, collection_type, collection, ct_item, download_format and/or only certain collection types (IDs) for exporting. When providing multiple values separate it with comma (','). (optional) 

            try
            {
                ExcelExportTableEntity result = apiInstance.HttpDataExportTranslationsAsExcel(filter);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DataImportExportManagementApi.HttpDataExportTranslationsAsExcel: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the HttpDataExportTranslationsAsExcelWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<ExcelExportTableEntity> response = apiInstance.HttpDataExportTranslationsAsExcelWithHttpInfo(filter);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling DataImportExportManagementApi.HttpDataExportTranslationsAsExcelWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **filter** | **string** | Used to specify what to be returned. Valid values are: asset, workspace, collection_type, collection, ct_item, download_format and/or only certain collection types (IDs) for exporting. When providing multiple values separate it with comma (&#39;,&#39;). | [optional]  |

### Return type

[**ExcelExportTableEntity**](ExcelExportTableEntity.md)

### Authorization

[msal_auth](../README.md#msal_auth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | The result when the export was triggered successfully |  -  |
| **404** | The requested item could not be found. |  -  |
| **401** | Unauthorized. Bearer Token not provided. |  -  |
| **500** | Internal server error. Please contact administrator. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="httpdataexporttranslationscancel"></a>
# **HttpDataExportTranslationsCancel**
> void HttpDataExportTranslationsCancel (string id)



This endpoint retrieves the status and if populated the url to the excel export

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Agravity.Public.Api;
using Agravity.Public.Client;
using Agravity.Public.Model;

namespace Example
{
    public class HttpDataExportTranslationsCancelExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost:7071/api";
            // Configure OAuth2 access token for authorization: msal_auth
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new DataImportExportManagementApi(config);
            var id = "id_example";  // string | The ID of translation export

            try
            {
                apiInstance.HttpDataExportTranslationsCancel(id);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DataImportExportManagementApi.HttpDataExportTranslationsCancel: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the HttpDataExportTranslationsCancelWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    apiInstance.HttpDataExportTranslationsCancelWithHttpInfo(id);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling DataImportExportManagementApi.HttpDataExportTranslationsCancelWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **string** | The ID of translation export |  |

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
| **404** | The requested item could not be found. |  -  |
| **204** | The response when the cancel request was issued successfully. |  -  |
| **401** | Unauthorized. Bearer Token not provided. |  -  |
| **500** | Internal server error. Please contact administrator. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="httpdataexporttranslationscheckstatus"></a>
# **HttpDataExportTranslationsCheckStatus**
> ExcelExportTableEntity HttpDataExportTranslationsCheckStatus (string id)



This endpoint retrieves the status and if populated the url to the excel export.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Agravity.Public.Api;
using Agravity.Public.Client;
using Agravity.Public.Model;

namespace Example
{
    public class HttpDataExportTranslationsCheckStatusExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost:7071/api";
            // Configure OAuth2 access token for authorization: msal_auth
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new DataImportExportManagementApi(config);
            var id = "id_example";  // string | The ID of translation export

            try
            {
                ExcelExportTableEntity result = apiInstance.HttpDataExportTranslationsCheckStatus(id);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DataImportExportManagementApi.HttpDataExportTranslationsCheckStatus: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the HttpDataExportTranslationsCheckStatusWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<ExcelExportTableEntity> response = apiInstance.HttpDataExportTranslationsCheckStatusWithHttpInfo(id);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling DataImportExportManagementApi.HttpDataExportTranslationsCheckStatusWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **string** | The ID of translation export |  |

### Return type

[**ExcelExportTableEntity**](ExcelExportTableEntity.md)

### Authorization

[msal_auth](../README.md#msal_auth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | The table entity which indicates the status of the export. |  -  |
| **404** | The requested item could not be found. |  -  |
| **401** | Unauthorized. Bearer Token not provided. |  -  |
| **500** | Internal server error. Please contact administrator. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="httpdataimporttranslationsasexcel"></a>
# **HttpDataImportTranslationsAsExcel**
> AgravityInfoResponse HttpDataImportTranslationsAsExcel ()



This endpoint puts a excel file on the translations import blob container

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Agravity.Public.Api;
using Agravity.Public.Client;
using Agravity.Public.Model;

namespace Example
{
    public class HttpDataImportTranslationsAsExcelExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost:7071/api";
            // Configure OAuth2 access token for authorization: msal_auth
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new DataImportExportManagementApi(config);

            try
            {
                AgravityInfoResponse result = apiInstance.HttpDataImportTranslationsAsExcel();
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DataImportExportManagementApi.HttpDataImportTranslationsAsExcel: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the HttpDataImportTranslationsAsExcelWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<AgravityInfoResponse> response = apiInstance.HttpDataImportTranslationsAsExcelWithHttpInfo();
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling DataImportExportManagementApi.HttpDataImportTranslationsAsExcelWithHttpInfo: " + e.Message);
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
| **200** | The response when the import was started successfully. |  -  |
| **400** | Excel upload failed. Content length is insuffient (0 or too big) (Code: b4c732dc-fc59-4abb-baf6-737acaf9e43c)Wrong content media type. Please upload file with multipart/form-data. (Code: e0a4df3e-abde-4d6e-878e-66cd10f2bc1e)Excel import configuration not set: IMPORT_EXCEL_ALLOWED has to be true. (Code: 2aa4bdf0-b638-4ca6-a7e7-8a5e643a8a3f)Could not find file in multi-part data. (Code: cb50b65d-7ad6-4f02-a8d0-0a9c591989a4)Files with this extension are not supported only .xlsx (Code: 06459547-6127-4393-9a7e-0e4a01460da7)File uploaded successfully (Code: 050aa174-a942-4efb-a805-87f9bbce5d09) |  -  |
| **401** | Unauthorized. Bearer Token not provided. |  -  |
| **500** | Internal server error. Please contact administrator. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

