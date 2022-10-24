# AgravityPublic - the C# library for the Agravity OpenAPI Documentation - Public Functions

<h1>Agravity API Reference</h1>This is the public API description of Agravity GmbH.<br/><h2>Resources</h2><ul> <li>Collection type management</li> <li>Collections management</li> <li>Assets management</li> <li>Assets operations</li> <li>Assets publishing</li> <li>Collection Sharing (consume share)</li> <li>Secure Upload (validate + upload file)</li> <li>Download ZIP</li> <li>Search</li> <li>General management</li></ul><h2> Operations</h2>Agravity API performs the following operations:<ul> <li>List / get single collection types</li> <li>List / get single collections</li> <li>List / get single  assets</li> <li>Operations on assets like: blobs, rotate, resize, similar, collections, customfields, download</li> <li>List / get single published asset</li> <li>Search for assets or collections</li> <li>Get version of deployment</li></ul><br/><b>API key is needed to access these endpoints.</b><br/><br/>Copyright © Agravity GmbH 2022. All Rights Reserved

This C# SDK is automatically generated by the [OpenAPI Generator](https://openapi-generator.tech) project:

- API version: 4.6.0
- SDK version: 1.0.0
- Build package: org.openapitools.codegen.languages.CSharpClientCodegen
    For more information, please visit [https://agravity.io](https://agravity.io)

## Frameworks supported


- .NET 4.0 or later
- Windows Phone 7.1 (Mango)

## Dependencies


- [RestSharp](https://www.nuget.org/packages/RestSharp) - 105.1.0 or later
- [Json.NET](https://www.nuget.org/packages/Newtonsoft.Json/) - 7.0.0 or later
- [JsonSubTypes](https://www.nuget.org/packages/JsonSubTypes/) - 1.2.0 or later

The DLLs included in the package may not be the latest version. We recommend using [NuGet](https://docs.nuget.org/consume/installing-nuget) to obtain the latest version of the packages:

```
Install-Package RestSharp
Install-Package Newtonsoft.Json
Install-Package JsonSubTypes
```

NOTE: RestSharp versions greater than 105.1.0 have a bug which causes file uploads to fail. See [RestSharp#742](https://github.com/restsharp/RestSharp/issues/742)

## Installation

Run the following command to generate the DLL

- [Mac/Linux] `/bin/sh build.sh`
- [Windows] `build.bat`

Then include the DLL (under the `bin` folder) in the C# project, and use the namespaces:

```csharp
using AgravityPublic.Api;
using AgravityPublic.Client;
using AgravityPublic.Model;

```


## Packaging

A `.nuspec` is included with the project. You can follow the Nuget quickstart to [create](https://docs.microsoft.com/en-us/nuget/quickstart/create-and-publish-a-package#create-the-package) and [publish](https://docs.microsoft.com/en-us/nuget/quickstart/create-and-publish-a-package#publish-the-package) packages.

This `.nuspec` uses placeholders from the `.csproj`, so build the `.csproj` directly:

```
nuget pack -Build -OutputDirectory out AgravityPublic.csproj
```

Then, publish to a [local feed](https://docs.microsoft.com/en-us/nuget/hosting-packages/local-feeds) or [other host](https://docs.microsoft.com/en-us/nuget/hosting-packages/overview) and consume the new package via Nuget as usual.


## Getting Started

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using AgravityPublic.Api;
using AgravityPublic.Client;
using AgravityPublic.Model;

namespace Example
{
    public class Example
    {
        public static void Main()
        {

            Configuration.Default.BasePath = "http://localhost:7072/api";
            // Configure API key authorization: function_key
            Configuration.Default.ApiKey.Add("x-functions-key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("x-functions-key", "Bearer");

            var apiInstance = new PublicAssetManagementApi(Configuration.Default);
            var name = "name_example";  // string |  (optional) 
            var collectionId = "collectionId_example";  // string |  (optional) 
            var file = new System.IO.MemoryStream(System.IO.File.ReadAllBytes("/path/to/file.txt"));  // System.IO.Stream |  (optional) 

            try
            {
                Asset result = apiInstance.HttpAssetUploadFile(name, collectionId, file);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling PublicAssetManagementApi.HttpAssetUploadFile: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }

        }
    }
}
```

## Documentation for API Endpoints

All URIs are relative to *http://localhost:7072/api*

Class | Method | HTTP request | Description
------------ | ------------- | ------------- | -------------
*PublicAssetManagementApi* | [**HttpAssetUploadFile**](docs/PublicAssetManagementApi.md#httpassetuploadfile) | **POST** /assetsupload | 
*PublicAssetManagementApi* | [**HttpAssetsGet**](docs/PublicAssetManagementApi.md#httpassetsget) | **GET** /assets | 
*PublicAssetManagementApi* | [**HttpAssetsGetById**](docs/PublicAssetManagementApi.md#httpassetsgetbyid) | **GET** /assets/{id} | 
*PublicAssetOperationsApi* | [**HttpAssetImageEdit**](docs/PublicAssetOperationsApi.md#httpassetimageedit) | **GET** /assets/{id}/imageedit | 
*PublicAssetOperationsApi* | [**HttpAssetImageRotateClockwise**](docs/PublicAssetOperationsApi.md#httpassetimagerotateclockwise) | **POST** /assets/{id}/rotate | 
*PublicAssetOperationsApi* | [**HttpAssetResize**](docs/PublicAssetOperationsApi.md#httpassetresize) | **GET** /assets/{id}/resize | 
*PublicAssetOperationsApi* | [**HttpAssetsGetSimilarById**](docs/PublicAssetOperationsApi.md#httpassetsgetsimilarbyid) | **GET** /assets/{id}/similar | 
*PublicAssetOperationsApi* | [**HttpGetAssetBlob**](docs/PublicAssetOperationsApi.md#httpgetassetblob) | **GET** /assets/{id}/blobs | 
*PublicAssetOperationsApi* | [**HttpGetAssetCollectionsById**](docs/PublicAssetOperationsApi.md#httpgetassetcollectionsbyid) | **GET** /assets/{id}/collections | 
*PublicAssetOperationsApi* | [**HttpGetAssetDownload**](docs/PublicAssetOperationsApi.md#httpgetassetdownload) | **GET** /assets/{id}/download | 
*PublicAssetPublishingApi* | [**HttpPublishedAssetsGet**](docs/PublicAssetPublishingApi.md#httppublishedassetsget) | **GET** /assets/{id}/publish | 
*PublicAssetPublishingApi* | [**HttpPublishedAssetsGetById**](docs/PublicAssetPublishingApi.md#httppublishedassetsgetbyid) | **GET** /assets/{id}/publish/{pid} | 
*PublicCollectionManagementApi* | [**HttpCollectionsCreate**](docs/PublicCollectionManagementApi.md#httpcollectionscreate) | **POST** /collections | 
*PublicCollectionManagementApi* | [**HttpCollectionsGet**](docs/PublicCollectionManagementApi.md#httpcollectionsget) | **GET** /collections | 
*PublicCollectionManagementApi* | [**HttpCollectionsGetById**](docs/PublicCollectionManagementApi.md#httpcollectionsgetbyid) | **GET** /collections/{id} | 
*PublicCollectionManagementApi* | [**HttpCollectionsGetDescendantsTreeOfId**](docs/PublicCollectionManagementApi.md#httpcollectionsgetdescendantstreeofid) | **GET** /collections/{id}/descendants | 
*PublicCollectionManagementApi* | [**HttpCollectionsGetTreeAncestorsOfId**](docs/PublicCollectionManagementApi.md#httpcollectionsgettreeancestorsofid) | **GET** /collections/{id}/ancestors | 
*PublicCollectionManagementApi* | [**HttpGetCollectionPreviewsById**](docs/PublicCollectionManagementApi.md#httpgetcollectionpreviewsbyid) | **GET** /collections/{id}/previews | 
*PublicCollectionSecureUploadApi* | [**HttpSecureUploadEntityCheckById**](docs/PublicCollectionSecureUploadApi.md#httpsecureuploadentitycheckbyid) | **GET** /secureupload/{id} | 
*PublicCollectionSecureUploadApi* | [**HttpSecureUploadFileById**](docs/PublicCollectionSecureUploadApi.md#httpsecureuploadfilebyid) | **POST** /secureupload/{id}/upload | 
*PublicCollectionSharingApi* | [**HttpSharedCollectionsGetById**](docs/PublicCollectionSharingApi.md#httpsharedcollectionsgetbyid) | **GET** /shared/{id} | 
*PublicCollectionTypeManagementApi* | [**HttpCollectionTypesGet**](docs/PublicCollectionTypeManagementApi.md#httpcollectiontypesget) | **GET** /collectiontypes | 
*PublicCollectionTypeManagementApi* | [**HttpCollectionTypesGetById**](docs/PublicCollectionTypeManagementApi.md#httpcollectiontypesgetbyid) | **GET** /collectiontypes/{id} | 
*PublicCollectionTypeManagementApi* | [**HttpGetCollectionTypeItems**](docs/PublicCollectionTypeManagementApi.md#httpgetcollectiontypeitems) | **GET** /collectiontypesitems | 
*PublicConfigurationManagementApi* | [**HttpConfigGetFrontendAll**](docs/PublicConfigurationManagementApi.md#httpconfiggetfrontendall) | **GET** /config/frontend | 
*PublicGeneralManagementApi* | [**HttpAgravityVersionInfo**](docs/PublicGeneralManagementApi.md#httpagravityversioninfo) | **GET** /version | 
*PublicGeneralManagementApi* | [**HttpTriggerDurableContinue**](docs/PublicGeneralManagementApi.md#httptriggerdurablecontinue) | **GET** /durable/{instanceId} | 
*PublicGeneralManagementApi* | [**HttpTriggerDurableScchTrainingDone**](docs/PublicGeneralManagementApi.md#httptriggerdurablescchtrainingdone) | **GET** /durable/scch/{instanceId} | 
*PublicHelperToolsApi* | [**HttpGetAllUserDefinedLists**](docs/PublicHelperToolsApi.md#httpgetalluserdefinedlists) | **GET** /helper/userdefinedlists | 
*PublicHelperToolsApi* | [**HttpGetAllowedFilterableItems**](docs/PublicHelperToolsApi.md#httpgetallowedfilterableitems) | **GET** /helper/filterableitems | 
*PublicHelperToolsApi* | [**HttpGetAllowedSearchableItemNames**](docs/PublicHelperToolsApi.md#httpgetallowedsearchableitemnames) | **GET** /helper/searchableitemnames | 
*PublicHelperToolsApi* | [**HttpGetAllowedSearchableItems**](docs/PublicHelperToolsApi.md#httpgetallowedsearchableitems) | **GET** /helper/searchableitems | 
*PublicPublishingApi* | [**HttpPublishedAssetsGetAll**](docs/PublicPublishingApi.md#httppublishedassetsgetall) | **GET** /publish | 
*PublicSearchManagementApi* | [**HttpGlobalSearch**](docs/PublicSearchManagementApi.md#httpglobalsearch) | **GET** /search | 
*PublicStaticDefinedListManagementApi* | [**HttpStaticDefinedListsGetAll**](docs/PublicStaticDefinedListManagementApi.md#httpstaticdefinedlistsgetall) | **GET** /staticdefinedlists | 
*PublicStaticDefinedListManagementApi* | [**HttpStaticDefinedListsGetById**](docs/PublicStaticDefinedListManagementApi.md#httpstaticdefinedlistsgetbyid) | **GET** /staticdefinedlists/{id} | 
*PublicTranslationManagementApi* | [**HttpTranslationsById**](docs/PublicTranslationManagementApi.md#httptranslationsbyid) | **GET** /translations/{id} | 
*PublicTranslationManagementApi* | [**HttpTranslationsByIdFilterByCustomField**](docs/PublicTranslationManagementApi.md#httptranslationsbyidfilterbycustomfield) | **GET** /translations/{id}/custom/{customField} | 
*PublicTranslationManagementApi* | [**HttpTranslationsByIdFilterByProperty**](docs/PublicTranslationManagementApi.md#httptranslationsbyidfilterbyproperty) | **GET** /translations/{id}/{property} | 
*PublicWebAppDataApi* | [**HttpGetDataCollectionType**](docs/PublicWebAppDataApi.md#httpgetdatacollectiontype) | **GET** /data/collectiontype/{id} | 
*PublicWebAppDataApi* | [**HttpGetWebAppData**](docs/PublicWebAppDataApi.md#httpgetwebappdata) | **GET** /webappdata/{id} | 
*PublicWorkspaceManagementApi* | [**HttpWorkspacesGet**](docs/PublicWorkspaceManagementApi.md#httpworkspacesget) | **GET** /workspaces | 
*PublicWorkspaceManagementApi* | [**HttpWorkspacesGetById**](docs/PublicWorkspaceManagementApi.md#httpworkspacesgetbyid) | **GET** /workspaces/{id} | 


## Documentation for Models

 - [Model.AgravityErrorResponse](docs/AgravityErrorResponse.md)
 - [Model.AgravityVersion](docs/AgravityVersion.md)
 - [Model.AllWebAppData](docs/AllWebAppData.md)
 - [Model.ArtificialIntelligenceGroup](docs/ArtificialIntelligenceGroup.md)
 - [Model.Asset](docs/Asset.md)
 - [Model.AssetBlob](docs/AssetBlob.md)
 - [Model.AssetPageResult](docs/AssetPageResult.md)
 - [Model.BadRequestResult](docs/BadRequestResult.md)
 - [Model.CollTypeItem](docs/CollTypeItem.md)
 - [Model.Collection](docs/Collection.md)
 - [Model.CollectionPermission](docs/CollectionPermission.md)
 - [Model.CollectionType](docs/CollectionType.md)
 - [Model.CollectionUDL](docs/CollectionUDL.md)
 - [Model.CreateSftpUserResult](docs/CreateSftpUserResult.md)
 - [Model.DataResult](docs/DataResult.md)
 - [Model.DistZipResponse](docs/DistZipResponse.md)
 - [Model.EntityIdName](docs/EntityIdName.md)
 - [Model.FrontendAppConfig](docs/FrontendAppConfig.md)
 - [Model.GroupAllAppData](docs/GroupAllAppData.md)
 - [Model.Metadata](docs/Metadata.md)
 - [Model.OkResult](docs/OkResult.md)
 - [Model.PerHashResult](docs/PerHashResult.md)
 - [Model.PublishEntity](docs/PublishEntity.md)
 - [Model.PublishedAsset](docs/PublishedAsset.md)
 - [Model.ReasonResult](docs/ReasonResult.md)
 - [Model.SearchFacet](docs/SearchFacet.md)
 - [Model.SearchFacetEntity](docs/SearchFacetEntity.md)
 - [Model.SearchResult](docs/SearchResult.md)
 - [Model.SearchableItem](docs/SearchableItem.md)
 - [Model.SecureUploadEntity](docs/SecureUploadEntity.md)
 - [Model.SharedAsset](docs/SharedAsset.md)
 - [Model.SharedCollectionFull](docs/SharedCollectionFull.md)
 - [Model.StaticDefinedList](docs/StaticDefinedList.md)
 - [Model.WhereParam](docs/WhereParam.md)
 - [Model.Workspace](docs/Workspace.md)


## Documentation for Authorization


### function_key

- **Type**: API key

- **API key parameter name**: x-functions-key
- **Location**: HTTP header

