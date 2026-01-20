# Agravity.Public - the C# library for the Agravity OpenAPI Documentation - Public Functions

<p>The Agravity Public API provides comprehensive access to digital asset management functionality for technical integrations, portals, and third-party applications. These endpoints are designed for programmatic access with API key authentication.</p><br/><h2>Access &amp; Security</h2><br/><b>API key is required to access these endpoints.</b><br/><ul><li>API Key Authentication - Each request requires a valid API key in headers or parameters</li><li>Portal-Aware - Many endpoints support portal context for multi-tenant scenarios</li><li>Service-to-Service Communication - Designed for backend-to-backend integrations</li><li>Stable &amp; Versioned - Public API versioning ensures backward compatibility</li></ul><h2>Core Features &amp; Operations</h2><ul><li><strong>Asset Management</strong> - Create, retrieve, update assets with full metadata support; manage versions and publish assets</li><li><strong>Collection Management</strong> - Create and organize collections hierarchically; retrieve collection type definitions and structures</li><li><strong>Asset Operations</strong> - Retrieve asset blobs (thumbnails, optimized, original); rotate and resize images; find similar assets using AI reverse search</li><li><strong>Image Editing</strong> - Apply transformations to images with advanced parameters (resize, crop, filter, color space, DPI, quality, depth)</li><li><strong>Asset Publishing</strong> - Publish assets to various targets (Vimeo, CDN); manage published asset information</li><li><strong>Asset Versioning</strong> - Create, restore, and manage asset versions; track version history with descriptions</li><li><strong>Asset Relations</strong> - Create and manage relationships between assets with hierarchical or standard relations</li><li><strong>Full-Text Search</strong> - Search assets and collections with advanced filtering, facets, and sorting capabilities</li><li><strong>Collection Sharing</strong> - Create shared collections with expiration dates, password protection, and download limits</li><li><strong>Quick Shares</strong> - Create quick share links for rapid asset sharing with expiration management</li><li><strong>Portals</strong> - Full portal management with authentication, custom theming, and asset filtering</li><li><strong>Secure Upload</strong> - Secure file upload endpoints with validation and SAS token generation</li><li><strong>Download Management</strong> - Create ZIP packages of assets with format specifications; track download progress</li><li><strong>Download Formats</strong> - Define and apply custom image transformations and optimizations for downloads</li><li><strong>Authentication</strong> - Generate SAS tokens for container write access; retrieve user information</li><li><strong>Configuration</strong> - Access frontend configuration values and system settings</li><li><strong>Helper Tools</strong> - Get searchable items, filterable items, user-defined lists, and static defined lists</li><li><strong>Translations</strong> - Retrieve translations for all entities in multiple languages</li><li><strong>Deleted Entities Tracking</strong> - Track deleted assets, collections, and other entities by date</li></ul><h2>Available Endpoints by Category</h2><ul><li><strong>Asset Management</strong> - /assets, /assets/{id}, /assetsupload, /assetrelations</li><li><strong>Asset Operations</strong> - /assets/{id}/blobs, /assets/{id}/collections, /assets/{id}/tocollection, /assets/{id}/download, /assets/{id}/resize, /assets/{id}/imageedit, /assets/{id}/availability</li><li><strong>Asset Publishing</strong> - /assets/{id}/publish, /assets/{id}/publish/{pid}</li><li><strong>Asset Versioning</strong> - /assets/{id}/versions, /assets/{id}/versionsupload, /assets/{id}/versions/{vNr}/restore</li><li><strong>AI Operations</strong> - /ai/reverseassetsearch (find similar assets using image)</li><li><strong>Collection Management</strong> - /collections, /collections/{id}, /collections/{id}/ancestors, /collections/{id}/descendants, /collections/{id}/previews, /collectionsbynames</li><li><strong>Collection Types</strong> - /collectiontypes, /collectiontypes/{id}, /collectiontypesitems</li><li><strong>Search</strong> - /search, /search/facette, /searchadmin/status</li><li><strong>Saved Searches</strong> - /savedsearches</li><li><strong>Collection Sharing</strong> - /shared/{id}, /shared/{id}/zip, /quickshares/{id}</li><li><strong>Secure Upload</strong> - /secureupload/{id}, /secureupload/{id}/upload</li><li><strong>Portal Management</strong> - /portals/{id}, /portals/{id}/config, /portals/{id}/zip, /portals/{id}/assetids, /portalsenhancetoken, /portalssaveuserattributes</li><li><strong>Authentication</strong> - /auth/containerwrite/{containerName}, /auth/inbox, /auth/users/{id}</li><li><strong>Download Formats</strong> - /downloadformats, /downloadformats-shared</li><li><strong>Configuration</strong> - /config/frontend</li><li><strong>Static Defined Lists</strong> - /staticdefinedlists, /staticdefinedlists/{id}</li><li><strong>User-Defined Lists</strong> - /helper/userdefinedlists</li><li><strong>Helper Tools</strong> - /helper/searchableitemnames, /helper/searchableitems, /helper/filterableitems</li><li><strong>Translations</strong> - /translations/{id}, /translations/{id}/{property}, /translations/{id}/custom/{customField}</li><li><strong>Web App Data</strong> - /webappdata/{id}, /data/collectiontype/{id}</li><li><strong>Workspace Management</strong> - /workspaces, /workspaces/{id}</li><li><strong>General</strong> - /version, /deleted, /durable/{instanceId}, /public/view, /signalr/negotiate</li></ul><h2>Typical Use Cases</h2><ul><li>E-commerce platforms - Product image management and dynamic optimization</li><li>Marketing automation - Asset distribution across channels with version control</li><li>Portal systems - Multi-tenant asset galleries with custom theming and permissions</li><li>Headless CMS integration - Content delivery with dynamic transformations</li><li>Mobile applications - Asset retrieval with mobile-optimized formats</li><li>AI-powered workflows - Reverse image search and automatic metadata generation</li><li>Asset sharing platforms - Secure sharing with expiration and password protection</li><li>Digital distribution - ZIP creation and bulk download management</li><li>Multi-language content - Translation management across all assets and collections</li><li>Real-time monitoring - Deletion tracking and version history auditing</li></ul><h2>Key Capabilities</h2><ul><li>Full CRUD operations on assets, collections, and related entities</li><li>Advanced image transformation with ImageMagick integration</li><li>AI-powered reverse image search for asset discovery</li><li>Multi-language support with translation dictionaries</li><li>Granular permission control and role-based access</li><li>Portal creation with custom authentication and theming</li><li>Hierarchical collection organization with dynamic filtering</li><li>Real-time search with faceted navigation and advanced filtering</li><li>Secure sharing with expiration and password protection</li><li>Blob storage integration with SAS token generation</li><li>Comprehensive asset versioning and restoration</li><li>SignalR support for real-time notifications</li></ul><h2>Authentication &amp; Authorization</h2><p>All endpoints (except public share endpoints) require API key authentication. The API key can be provided:</p><ul><li>As query parameter: ?code=YOUR_API_KEY</li><li>As header: x-functions-key: YOUR_API_KEY</li></ul><p>Portal endpoints may have additional authentication methods (OAuth, Azure AD, Auth0, password) depending on portal configuration.</p><h2>Support</h2><p>For technical support or integration questions, contact <a href=\"mailto:support@agravity.io\">support@agravity.io</a> or visit <a href=\"https://agravity.io\">https://agravity.io</a>.</p><br/><p>Copyright © Agravity GmbH 2026. All Rights Reserved</p>

This C# SDK is automatically generated by the [OpenAPI Generator](https://openapi-generator.tech) project:

- API version: 10.2.3
- SDK version: 10.2.3
- Generator version: 7.15.0
- Build package: org.openapitools.codegen.languages.CSharpClientCodegen
    For more information, please visit [https://agravity.io](https://agravity.io)

<a id="frameworks-supported"></a>
## Frameworks supported
- .NET Core >=1.0
- .NET Framework >=4.6
- Mono/Xamarin >=vNext

<a id="dependencies"></a>
## Dependencies

- [RestSharp](https://www.nuget.org/packages/RestSharp) - 112.0.0 or later
- [Json.NET](https://www.nuget.org/packages/Newtonsoft.Json/) - 13.0.2 or later
- [JsonSubTypes](https://www.nuget.org/packages/JsonSubTypes/) - 1.8.0 or later
- [System.ComponentModel.Annotations](https://www.nuget.org/packages/System.ComponentModel.Annotations) - 5.0.0 or later

The DLLs included in the package may not be the latest version. We recommend using [NuGet](https://docs.nuget.org/consume/installing-nuget) to obtain the latest version of the packages:
```
Install-Package RestSharp
Install-Package Newtonsoft.Json
Install-Package JsonSubTypes
Install-Package System.ComponentModel.Annotations
```

NOTE: RestSharp versions greater than 105.1.0 have a bug which causes file uploads to fail. See [RestSharp#742](https://github.com/restsharp/RestSharp/issues/742).
NOTE: RestSharp for .Net Core creates a new socket for each api call, which can lead to a socket exhaustion problem. See [RestSharp#1406](https://github.com/restsharp/RestSharp/issues/1406).

<a id="installation"></a>
## Installation
Generate the DLL using your preferred tool (e.g. `dotnet build`)

Then include the DLL (under the `bin` folder) in the C# project, and use the namespaces:
```csharp
using Agravity.Public.Api;
using Agravity.Public.Client;
using Agravity.Public.Model;
```
<a id="usage"></a>
## Usage

To use the API client with a HTTP proxy, setup a `System.Net.WebProxy`
```csharp
Configuration c = new Configuration();
System.Net.WebProxy webProxy = new System.Net.WebProxy("http://myProxyUrl:80/");
webProxy.Credentials = System.Net.CredentialCache.DefaultCredentials;
c.Proxy = webProxy;
```

<a id="getting-started"></a>
## Getting Started

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Agravity.Public.Api;
using Agravity.Public.Client;
using Agravity.Public.Model;

namespace Example
{
    public class Example
    {
        public static void Main()
        {

            Configuration config = new Configuration();
            config.BasePath = "http://localhost:7072/api";
            // Configure API key authorization: function_key
            config.ApiKey.Add("x-functions-key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.ApiKeyPrefix.Add("x-functions-key", "Bearer");

            var apiInstance = new PublicAIOperationsApi(config);
            var acceptLanguage = "acceptLanguage_example";  // string | The requested language of the response. If not matching it falls back to default language. (optional) 
            var name = "name_example";  // string |  (optional) 
            var collectionid = "collectionid_example";  // string |  (optional) 
            var file = new System.IO.MemoryStream(System.IO.File.ReadAllBytes("/path/to/file.txt"));  // System.IO.Stream |  (optional) 
            var filename = "filename_example";  // string |  (optional) 
            var previewof = "previewof_example";  // string |  (optional) 

            try
            {
                SearchResult result = apiInstance.HttpReverseAssetSearch(acceptLanguage, name, collectionid, file, filename, previewof);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling PublicAIOperationsApi.HttpReverseAssetSearch: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }

        }
    }
}
```

<a id="documentation-for-api-endpoints"></a>
## Documentation for API Endpoints

All URIs are relative to *http://localhost:7072/api*

Class | Method | HTTP request | Description
------------ | ------------- | ------------- | -------------
*PublicAIOperationsApi* | [**HttpReverseAssetSearch**](docs/PublicAIOperationsApi.md#httpreverseassetsearch) | **POST** /ai/reverseassetsearch | 
*PublicAssetManagementApi* | [**HttpAssetUploadFile**](docs/PublicAssetManagementApi.md#httpassetuploadfile) | **POST** /assetsupload | 
*PublicAssetManagementApi* | [**HttpAssetsCreate**](docs/PublicAssetManagementApi.md#httpassetscreate) | **POST** /assets | 
*PublicAssetManagementApi* | [**HttpAssetsGet**](docs/PublicAssetManagementApi.md#httpassetsget) | **GET** /assets | 
*PublicAssetManagementApi* | [**HttpAssetsGetById**](docs/PublicAssetManagementApi.md#httpassetsgetbyid) | **GET** /assets/{id} | 
*PublicAssetManagementApi* | [**HttpPublicAssetsUpdateById**](docs/PublicAssetManagementApi.md#httppublicassetsupdatebyid) | **POST** /assets/{id} | 
*PublicAssetOperationsApi* | [**HttpAssetImageEdit**](docs/PublicAssetOperationsApi.md#httpassetimageedit) | **GET** /assets/{id}/imageedit | 
*PublicAssetOperationsApi* | [**HttpAssetResize**](docs/PublicAssetOperationsApi.md#httpassetresize) | **GET** /assets/{id}/resize | 
*PublicAssetOperationsApi* | [**HttpAssetToCollection**](docs/PublicAssetOperationsApi.md#httpassettocollection) | **POST** /assets/{id}/tocollection | 
*PublicAssetOperationsApi* | [**HttpGetAssetBlob**](docs/PublicAssetOperationsApi.md#httpgetassetblob) | **GET** /assets/{id}/blobs | 
*PublicAssetOperationsApi* | [**HttpGetAssetCollectionsById**](docs/PublicAssetOperationsApi.md#httpgetassetcollectionsbyid) | **GET** /assets/{id}/collections | 
*PublicAssetOperationsApi* | [**HttpGetAssetDownload**](docs/PublicAssetOperationsApi.md#httpgetassetdownload) | **GET** /assets/{id}/download | 
*PublicAssetOperationsApi* | [**HttpGetSharedAssetBlob**](docs/PublicAssetOperationsApi.md#httpgetsharedassetblob) | **GET** /assets/{id}/blob | 
*PublicAssetOperationsApi* | [**HttpImageDynamicEdit**](docs/PublicAssetOperationsApi.md#httpimagedynamicedit) | **POST** /assets/{id}/imageedit | 
*PublicAssetOperationsApi* | [**HttpImageDynamicGetFromDownloadId**](docs/PublicAssetOperationsApi.md#httpimagedynamicgetfromdownloadid) | **GET** /assets/{id}/imageedit/{download_format_id} | 
*PublicAssetOperationsApi* | [**HttpPutAssetAvailability**](docs/PublicAssetOperationsApi.md#httpputassetavailability) | **PUT** /assets/{id}/availability | 
*PublicAssetPublishingApi* | [**HttpPublishedAssetsCreate**](docs/PublicAssetPublishingApi.md#httppublishedassetscreate) | **POST** /assets/{id}/publish | 
*PublicAssetPublishingApi* | [**HttpPublishedAssetsGet**](docs/PublicAssetPublishingApi.md#httppublishedassetsget) | **GET** /assets/{id}/publish | 
*PublicAssetPublishingApi* | [**HttpPublishedAssetsGetById**](docs/PublicAssetPublishingApi.md#httppublishedassetsgetbyid) | **GET** /assets/{id}/publish/{pid} | 
*PublicAssetRelationManagementApi* | [**HttpAssetRelationCreate**](docs/PublicAssetRelationManagementApi.md#httpassetrelationcreate) | **POST** /assetrelations | 
*PublicAssetRelationManagementApi* | [**HttpAssetRelationDeleteById**](docs/PublicAssetRelationManagementApi.md#httpassetrelationdeletebyid) | **DELETE** /assetrelations/{id} | 
*PublicAssetRelationManagementApi* | [**HttpAssetRelationGetAll**](docs/PublicAssetRelationManagementApi.md#httpassetrelationgetall) | **GET** /assetrelations | 
*PublicAssetRelationManagementApi* | [**HttpAssetRelationGetById**](docs/PublicAssetRelationManagementApi.md#httpassetrelationgetbyid) | **GET** /assetrelations/{id} | 
*PublicAssetRelationManagementApi* | [**HttpAssetRelationUpdateById**](docs/PublicAssetRelationManagementApi.md#httpassetrelationupdatebyid) | **POST** /assetrelations/{id} | 
*PublicAssetVersioningApi* | [**HttpAssetCreateUploadVersion**](docs/PublicAssetVersioningApi.md#httpassetcreateuploadversion) | **POST** /assets/{id}/versionsupload | 
*PublicAssetVersioningApi* | [**HttpAssetCreateVersion**](docs/PublicAssetVersioningApi.md#httpassetcreateversion) | **POST** /assets/{id}/versions | 
*PublicAssetVersioningApi* | [**HttpDeleteVersionedAssetsById**](docs/PublicAssetVersioningApi.md#httpdeleteversionedassetsbyid) | **DELETE** /assets/{id}/versions/{vNr} | 
*PublicAssetVersioningApi* | [**HttpGetVersionedAssetBlobById**](docs/PublicAssetVersioningApi.md#httpgetversionedassetblobbyid) | **GET** /assets/{id}/versions/{vNr}/blobs | 
*PublicAssetVersioningApi* | [**HttpRestoreVersionedAssetsById**](docs/PublicAssetVersioningApi.md#httprestoreversionedassetsbyid) | **POST** /assets/{id}/versions/{vNr}/restore | 
*PublicAssetVersioningApi* | [**HttpUpdateVersionedAssetsById**](docs/PublicAssetVersioningApi.md#httpupdateversionedassetsbyid) | **POST** /assets/{id}/versions/{vNr} | 
*PublicAssetVersioningApi* | [**HttpVersionedAssetsGet**](docs/PublicAssetVersioningApi.md#httpversionedassetsget) | **GET** /assets/{id}/versions | 
*PublicAuthenticationManagementApi* | [**HttpAuthGetAgravityUserById**](docs/PublicAuthenticationManagementApi.md#httpauthgetagravityuserbyid) | **GET** /auth/users/{id} | 
*PublicAuthenticationManagementApi* | [**HttpAuthGetContainerWriteSasToken**](docs/PublicAuthenticationManagementApi.md#httpauthgetcontainerwritesastoken) | **GET** /auth/containerwrite/{containerName} | 
*PublicAuthenticationManagementApi* | [**HttpAuthGetInboxContainerWriteSasToken**](docs/PublicAuthenticationManagementApi.md#httpauthgetinboxcontainerwritesastoken) | **GET** /auth/inbox | 
*PublicCollectionManagementApi* | [**HttpCollectionsCreate**](docs/PublicCollectionManagementApi.md#httpcollectionscreate) | **POST** /collections | 
*PublicCollectionManagementApi* | [**HttpCollectionsGet**](docs/PublicCollectionManagementApi.md#httpcollectionsget) | **GET** /collections | 
*PublicCollectionManagementApi* | [**HttpCollectionsGetById**](docs/PublicCollectionManagementApi.md#httpcollectionsgetbyid) | **GET** /collections/{id} | 
*PublicCollectionManagementApi* | [**HttpCollectionsGetDescendantsTreeOfId**](docs/PublicCollectionManagementApi.md#httpcollectionsgetdescendantstreeofid) | **GET** /collections/{id}/descendants | 
*PublicCollectionManagementApi* | [**HttpCollectionsGetTreeAncestorsOfId**](docs/PublicCollectionManagementApi.md#httpcollectionsgettreeancestorsofid) | **GET** /collections/{id}/ancestors | 
*PublicCollectionManagementApi* | [**HttpGetCollectionPreviewsById**](docs/PublicCollectionManagementApi.md#httpgetcollectionpreviewsbyid) | **GET** /collections/{id}/previews | 
*PublicCollectionManagementApi* | [**HttpPublicCollectionsDeleteById**](docs/PublicCollectionManagementApi.md#httppubliccollectionsdeletebyid) | **DELETE** /collections/{id} | 
*PublicCollectionManagementApi* | [**HttpPublicCollectionsUpdateById**](docs/PublicCollectionManagementApi.md#httppubliccollectionsupdatebyid) | **POST** /collections/{id} | 
*PublicCollectionManagementApi* | [**HttpPublicPostCollectionsGetByNames**](docs/PublicCollectionManagementApi.md#httppublicpostcollectionsgetbynames) | **POST** /collectionsbynames | 
*PublicCollectionSecureUploadApi* | [**HttpSecureUploadEntityCheckById**](docs/PublicCollectionSecureUploadApi.md#httpsecureuploadentitycheckbyid) | **GET** /secureupload/{id} | 
*PublicCollectionSecureUploadApi* | [**HttpSecureUploadFileById**](docs/PublicCollectionSecureUploadApi.md#httpsecureuploadfilebyid) | **POST** /secureupload/{id}/upload | 
*PublicCollectionTypeManagementApi* | [**HttpCollectionTypesGet**](docs/PublicCollectionTypeManagementApi.md#httpcollectiontypesget) | **GET** /collectiontypes | 
*PublicCollectionTypeManagementApi* | [**HttpCollectionTypesGetById**](docs/PublicCollectionTypeManagementApi.md#httpcollectiontypesgetbyid) | **GET** /collectiontypes/{id} | 
*PublicCollectionTypeManagementApi* | [**HttpGetCollectionTypeItems**](docs/PublicCollectionTypeManagementApi.md#httpgetcollectiontypeitems) | **GET** /collectiontypesitems | 
*PublicConfigurationManagementApi* | [**HttpConfigGetFrontendAll**](docs/PublicConfigurationManagementApi.md#httpconfiggetfrontendall) | **GET** /config/frontend | 
*PublicDownloadFormatManagementApi* | [**HttpDownloadFormatsGetAll**](docs/PublicDownloadFormatManagementApi.md#httpdownloadformatsgetall) | **GET** /downloadformats | 
*PublicDownloadFormatManagementApi* | [**HttpDownloadFormatsGetAllFromShared**](docs/PublicDownloadFormatManagementApi.md#httpdownloadformatsgetallfromshared) | **GET** /downloadformats-shared | 
*PublicEndpointsApi* | [**HttpAssetGetViewForPortal**](docs/PublicEndpointsApi.md#httpassetgetviewforportal) | **GET** /public/view | 
*PublicGeneralManagementApi* | [**HttpAgravityVersionInfo**](docs/PublicGeneralManagementApi.md#httpagravityversioninfo) | **GET** /version | 
*PublicGeneralManagementApi* | [**HttpGetDeletedEntities**](docs/PublicGeneralManagementApi.md#httpgetdeletedentities) | **GET** /deleted | 
*PublicGeneralManagementApi* | [**HttpTriggerDurableContinue**](docs/PublicGeneralManagementApi.md#httptriggerdurablecontinue) | **GET** /durable/{instanceId} | 
*PublicGeneralManagementApi* | [**HttpTriggerDurableScchTrainingDone**](docs/PublicGeneralManagementApi.md#httptriggerdurablescchtrainingdone) | **GET** /durable/scch/{instanceId} | 
*PublicHelperToolsApi* | [**HttpGetAllUserDefinedLists**](docs/PublicHelperToolsApi.md#httpgetalluserdefinedlists) | **GET** /helper/userdefinedlists | 
*PublicHelperToolsApi* | [**HttpGetAllowedFilterableItems**](docs/PublicHelperToolsApi.md#httpgetallowedfilterableitems) | **GET** /helper/filterableitems | 
*PublicHelperToolsApi* | [**HttpGetAllowedSearchableItemNames**](docs/PublicHelperToolsApi.md#httpgetallowedsearchableitemnames) | **GET** /helper/searchableitemnames | 
*PublicHelperToolsApi* | [**HttpGetAllowedSearchableItems**](docs/PublicHelperToolsApi.md#httpgetallowedsearchableitems) | **GET** /helper/searchableitems | 
*PublicHelperToolsApi* | [**HttpPatchUpdateCachedUserDefinedLists**](docs/PublicHelperToolsApi.md#httppatchupdatecacheduserdefinedlists) | **PATCH** /helper/userdefinedlists | 
*PublicPortalManagementApi* | [**HttpPortalGetAllAssetIdsById**](docs/PublicPortalManagementApi.md#httpportalgetallassetidsbyid) | **GET** /portals/{id}/assetids | 
*PublicPortalManagementApi* | [**HttpPortalGetStatusZipById**](docs/PublicPortalManagementApi.md#httpportalgetstatuszipbyid) | **GET** /portals/{id}/zip/{zipId} | 
*PublicPortalManagementApi* | [**HttpPortalRequestZipById**](docs/PublicPortalManagementApi.md#httpportalrequestzipbyid) | **POST** /portals/{id}/zip | 
*PublicPortalManagementApi* | [**HttpPortalsConfigurationGetById**](docs/PublicPortalManagementApi.md#httpportalsconfigurationgetbyid) | **GET** /portals/{id}/config | 
*PublicPortalManagementApi* | [**HttpPortalsEnhanceToken**](docs/PublicPortalManagementApi.md#httpportalsenhancetoken) | **POST** /portalsenhancetoken | 
*PublicPortalManagementApi* | [**HttpPortalsGetById**](docs/PublicPortalManagementApi.md#httpportalsgetbyid) | **GET** /portals/{id} | 
*PublicPortalManagementApi* | [**HttpPortalsSavePortalUserAttributes**](docs/PublicPortalManagementApi.md#httpportalssaveportaluserattributes) | **POST** /portalssaveuserattributes | 
*PublicPublishingApi* | [**HttpPublishedAssetsGetAll**](docs/PublicPublishingApi.md#httppublishedassetsgetall) | **GET** /publish | 
*PublicSavedSearchApi* | [**HttpSavedSearchesGetAll**](docs/PublicSavedSearchApi.md#httpsavedsearchesgetall) | **GET** /savedsearches | 
*PublicSearchManagementApi* | [**HttpGetSearchFacetteByName**](docs/PublicSearchManagementApi.md#httpgetsearchfacettebyname) | **GET** /search/facette | 
*PublicSearchManagementApi* | [**HttpGlobalSearch**](docs/PublicSearchManagementApi.md#httpglobalsearch) | **GET** /search | 
*PublicSearchManagementApi* | [**HttpSearchAdminGetStatus**](docs/PublicSearchManagementApi.md#httpsearchadmingetstatus) | **GET** /searchadmin/status | 
*PublicSharingManagementApi* | [**HttpQuickShareGetById**](docs/PublicSharingManagementApi.md#httpquicksharegetbyid) | **GET** /quickshares/{id} | 
*PublicSharingManagementApi* | [**HttpSharedCollectionsGetById**](docs/PublicSharingManagementApi.md#httpsharedcollectionsgetbyid) | **GET** /shared/{id} | 
*PublicSharingManagementApi* | [**HttpSharedCollectionsGetStatusZipById**](docs/PublicSharingManagementApi.md#httpsharedcollectionsgetstatuszipbyid) | **GET** /shared/{id}/zip/{zipId} | 
*PublicSharingManagementApi* | [**HttpSharedCollectionsRequestZipById**](docs/PublicSharingManagementApi.md#httpsharedcollectionsrequestzipbyid) | **POST** /shared/{id}/zip | 
*PublicSignalRConnectionManagementApi* | [**HttpSignalRNegotiate**](docs/PublicSignalRConnectionManagementApi.md#httpsignalrnegotiate) | **POST** /signalr/negotiate | 
*PublicStaticDefinedListManagementApi* | [**HttpStaticDefinedListsGetAll**](docs/PublicStaticDefinedListManagementApi.md#httpstaticdefinedlistsgetall) | **GET** /staticdefinedlists | 
*PublicStaticDefinedListManagementApi* | [**HttpStaticDefinedListsGetById**](docs/PublicStaticDefinedListManagementApi.md#httpstaticdefinedlistsgetbyid) | **GET** /staticdefinedlists/{id} | 
*PublicStaticDefinedListManagementApi* | [**HttpStaticDefinedListsUpdateById**](docs/PublicStaticDefinedListManagementApi.md#httpstaticdefinedlistsupdatebyid) | **POST** /staticdefinedlists/{id} | 
*PublicTranslationManagementApi* | [**HttpTranslationsById**](docs/PublicTranslationManagementApi.md#httptranslationsbyid) | **GET** /translations/{id} | 
*PublicTranslationManagementApi* | [**HttpTranslationsByIdFilterByCustomField**](docs/PublicTranslationManagementApi.md#httptranslationsbyidfilterbycustomfield) | **GET** /translations/{id}/custom/{customField} | 
*PublicTranslationManagementApi* | [**HttpTranslationsByIdFilterByProperty**](docs/PublicTranslationManagementApi.md#httptranslationsbyidfilterbyproperty) | **GET** /translations/{id}/{property} | 
*PublicWebAppDataApi* | [**HttpGetDataCollectionType**](docs/PublicWebAppDataApi.md#httpgetdatacollectiontype) | **GET** /data/collectiontype/{id} | 
*PublicWebAppDataApi* | [**HttpGetWebAppData**](docs/PublicWebAppDataApi.md#httpgetwebappdata) | **GET** /webappdata/{id} | 
*PublicWorkspaceManagementApi* | [**HttpWorkspacesGet**](docs/PublicWorkspaceManagementApi.md#httpworkspacesget) | **GET** /workspaces | 
*PublicWorkspaceManagementApi* | [**HttpWorkspacesGetById**](docs/PublicWorkspaceManagementApi.md#httpworkspacesgetbyid) | **GET** /workspaces/{id} | 


<a id="documentation-for-models"></a>
## Documentation for Models

 - [Model.AgravityErrorResponse](docs/AgravityErrorResponse.md)
 - [Model.AgravityInfoResponse](docs/AgravityInfoResponse.md)
 - [Model.AgravityUser](docs/AgravityUser.md)
 - [Model.AgravityUserOnlineStatus](docs/AgravityUserOnlineStatus.md)
 - [Model.AgravityVersion](docs/AgravityVersion.md)
 - [Model.AllWebAppData](docs/AllWebAppData.md)
 - [Model.Asset](docs/Asset.md)
 - [Model.AssetAvailability](docs/AssetAvailability.md)
 - [Model.AssetBlob](docs/AssetBlob.md)
 - [Model.AssetIconRule](docs/AssetIconRule.md)
 - [Model.AssetIdFormat](docs/AssetIdFormat.md)
 - [Model.AssetPageResult](docs/AssetPageResult.md)
 - [Model.AssetRelation](docs/AssetRelation.md)
 - [Model.AzSearchOptions](docs/AzSearchOptions.md)
 - [Model.CollTypeItem](docs/CollTypeItem.md)
 - [Model.Collection](docs/Collection.md)
 - [Model.CollectionType](docs/CollectionType.md)
 - [Model.CollectionUDL](docs/CollectionUDL.md)
 - [Model.CollectionUDLListEntity](docs/CollectionUDLListEntity.md)
 - [Model.CollectionUDLReference](docs/CollectionUDLReference.md)
 - [Model.CreateSftpUserResult](docs/CreateSftpUserResult.md)
 - [Model.CustomClaimsProviderResponseActionAttributeCollectionSubmit](docs/CustomClaimsProviderResponseActionAttributeCollectionSubmit.md)
 - [Model.CustomClaimsProviderResponseActionTokenIssuanceStart](docs/CustomClaimsProviderResponseActionTokenIssuanceStart.md)
 - [Model.CustomClaimsProviderResponseClaims](docs/CustomClaimsProviderResponseClaims.md)
 - [Model.CustomClaimsProviderResponseContentAttributeCollectionSubmit](docs/CustomClaimsProviderResponseContentAttributeCollectionSubmit.md)
 - [Model.CustomClaimsProviderResponseContentTokenIssuanceStart](docs/CustomClaimsProviderResponseContentTokenIssuanceStart.md)
 - [Model.CustomClaimsProviderResponseDataAttributeCollectionSubmit](docs/CustomClaimsProviderResponseDataAttributeCollectionSubmit.md)
 - [Model.CustomClaimsProviderResponseDataTokenIssuanceStart](docs/CustomClaimsProviderResponseDataTokenIssuanceStart.md)
 - [Model.DataResult](docs/DataResult.md)
 - [Model.DeletedEntities](docs/DeletedEntities.md)
 - [Model.DistZipResponse](docs/DistZipResponse.md)
 - [Model.DownloadFormat](docs/DownloadFormat.md)
 - [Model.DownloadZipRequest](docs/DownloadZipRequest.md)
 - [Model.DownloadZipStatus](docs/DownloadZipStatus.md)
 - [Model.DynamicImageOperation](docs/DynamicImageOperation.md)
 - [Model.EntityId](docs/EntityId.md)
 - [Model.EntityIdName](docs/EntityIdName.md)
 - [Model.EntityListResult](docs/EntityListResult.md)
 - [Model.EntityNamesRequest](docs/EntityNamesRequest.md)
 - [Model.FrontendAppConfig](docs/FrontendAppConfig.md)
 - [Model.GroupAllAppData](docs/GroupAllAppData.md)
 - [Model.MoveCollectionBody](docs/MoveCollectionBody.md)
 - [Model.PermissionEntity](docs/PermissionEntity.md)
 - [Model.Portal](docs/Portal.md)
 - [Model.PortalAuthentication](docs/PortalAuthentication.md)
 - [Model.PortalConfiguration](docs/PortalConfiguration.md)
 - [Model.PortalFields](docs/PortalFields.md)
 - [Model.PortalLinks](docs/PortalLinks.md)
 - [Model.PortalTheme](docs/PortalTheme.md)
 - [Model.PortalUserContext](docs/PortalUserContext.md)
 - [Model.PublishEntity](docs/PublishEntity.md)
 - [Model.PublishedAsset](docs/PublishedAsset.md)
 - [Model.QuickShareFull](docs/QuickShareFull.md)
 - [Model.RelatedAsset](docs/RelatedAsset.md)
 - [Model.SasToken](docs/SasToken.md)
 - [Model.SavedSearch](docs/SavedSearch.md)
 - [Model.SearchAdminDataSourceStatus](docs/SearchAdminDataSourceStatus.md)
 - [Model.SearchAdminIndexStatus](docs/SearchAdminIndexStatus.md)
 - [Model.SearchAdminIndexerLastRun](docs/SearchAdminIndexerLastRun.md)
 - [Model.SearchAdminIndexerStatus](docs/SearchAdminIndexerStatus.md)
 - [Model.SearchAdminSkillStatus](docs/SearchAdminSkillStatus.md)
 - [Model.SearchAdminStatistics](docs/SearchAdminStatistics.md)
 - [Model.SearchAdminStatus](docs/SearchAdminStatus.md)
 - [Model.SearchFacet](docs/SearchFacet.md)
 - [Model.SearchFacetEntity](docs/SearchFacetEntity.md)
 - [Model.SearchResult](docs/SearchResult.md)
 - [Model.SearchableItem](docs/SearchableItem.md)
 - [Model.SecureUploadEntity](docs/SecureUploadEntity.md)
 - [Model.SharedAllowedFormat](docs/SharedAllowedFormat.md)
 - [Model.SharedAsset](docs/SharedAsset.md)
 - [Model.SharedCollectionFull](docs/SharedCollectionFull.md)
 - [Model.SignalRConnectionInfo](docs/SignalRConnectionInfo.md)
 - [Model.StaticDefinedList](docs/StaticDefinedList.md)
 - [Model.VersionEntity](docs/VersionEntity.md)
 - [Model.VersionedAsset](docs/VersionedAsset.md)
 - [Model.WhereParam](docs/WhereParam.md)
 - [Model.Workspace](docs/Workspace.md)


<a id="documentation-for-authorization"></a>
## Documentation for Authorization


Authentication schemes defined for the API:
<a id="function_key"></a>
### function_key

- **Type**: API key
- **API key parameter name**: x-functions-key
- **Location**: HTTP header

