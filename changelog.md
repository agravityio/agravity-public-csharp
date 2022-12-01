## <a name="recommended-version"></a> Recommended version

The **minimum recommended version is [4.9.1](#4.9.1)**.

Any known issues detected on that version are listed in the [known issues](#known-issues) section.

## Release notes

Preview features are treated as a separate branch and will not be included in the official release until the feature is ready. Each preview release lists all the additional features that are enabled.

The format is based on [Keep a Changelog](https://keepachangelog.com/en/1.0.0/),
and this project adheres to [Semantic Versioning](https://semver.org/spec/v2.0.0.html).

---

## AgravityAPI <a name="4.9.1"/> [4.9.1](https://www.nuget.org/packages/Agravity.Public/4.9.1) (2022-12-01)

- Add `ids` param to search endpoint (private and public) to limit the results to given ids (comma separated);
- introduce new `options` property to searchResult which reflect all filter params given
- deprecation properties announced (all are included in `options`):
  - `max_sum_results` => `options.limit`
  - `search_query` => `options.searchstring`
  - `search_filter` => `options.filter`
  - `search_order_by` => `options.orderby`
  - `search_mode` => `options.mode`

---

## AgravityAPI <a name="4.9.0"/> [4.9.0](https://www.nuget.org/packages/Agravity.Public/4.9.0) (2022-11-28)

Add `translations` param in nearly all endpoints which receives translateable objects
Add missing `items` as param PublicAssetManagement
Add missing `fields` as param PublicAssetOperations and PublicCollectionManagement
Add Saved Search Management:
- POST `/savedsearches` (editor + admin) This endpoint creates one saved search entry in the database.
- GET `/savedsearches` (all + public) This endpoint lists all saved searchs in database.
- DELETE `/savedsearches/{id}` (editor + admin) This endpoint deletes a single saved search.

---
## AgravityAPI <a name="4.8.1"/> [4.8.1](https://www.nuget.org/packages/Agravity.Public/4.8.1) (2022-11-14)
- Change GET `/assetsenhancer/{id}` to GET `/helper/skillenhancer/{id}` - Show the result of the SkillEnhancer for assets and collections

---
## AgravityAPI 4.8.0 (2022-11-13)
- Add methods to public functions:
  - Update GET `/assets/{id}` - Add "uncomplete" flag return uncomplete
  - Add POST `/assets/{id}` - Update asset via API key
  - Add POST `/collections/{id}` - Update collection via API
  - Fix return value from HttpStaticDefinedListsGetById

---
## AgravityAPI <a name="4.7.3"/> [4.7.3](https://www.nuget.org/packages/Agravity.Public/4.7.3) (2022-10-31)
> Just version upgrade to match backend

---
## AgravityAPI 4.7.2 (2022-11-02)
> Just version upgrade to match backend
---
## AgravityAPI 4.7.1 (2022-10-31)
> Just version upgrade to match backend

---
## AgravityAPI 4.7.0 (2022-10-30)

### New Features (in public):
- Add helper methods to public functions:
  - Add POST `/assetsupload` - Upload asset via API key 
  - Add POST `/collections` - Create collection via API key

### Improvements:
- Changed publish asset - removed "original" and replaced with "format";
- Add origin to downloadFormat (where this format is based on);

---
## AgravityAPI 4.6.0 (2022-10-18)
### New Features (in public):
- Repair `/collections` endpoint (level and parentid are now optional);
- Add GET `/collectiontypeitems` - This method returns a list of collection types items.
- Add helper methods to public functions:
  - Add GET `/helper/userdefinedlists` - Returns all user defined lists of all collection types
  - Add GET `/helper/filterableitems` - Returns all filterable items directly from the search index
  - Add GET `/helper/searchableitemnames` - Returns all searchable items directly from the search index
  - Add GET `/helper/searchableitems` - Returns all searchable items directly from the search index
- Add Translations Management to public functions;
  - Add GET  `/translations/{id}` - Get all the translations of a whole entity (Asset, Collection, Collection Type, Download Format)
  - Add GET `/translations/{id]}/custom/{customProperty}` - Get the translation of custom field on the entity (Asset, Collection)
  - Add GET `/translations/{id}/{property}` -  Get the translations of a specific field on the entity (Asset, Collection, Collection Type, Download Format)


---
## AgravityAPI 4.5.5 (2022-10-14)
> Just version upgrade to match backend

---
## AgravityAPI 4.5.4 (2022-09-28)
### Improvements:
- PublishAsset body now allows 
  - "usecases" (string list) (also to be updated)
  - "original" (boolean) to publish original asset (with new name)


---
## AgravityAPI 4.5.3 (2022-09-21)
> Just version upgrade to match backend

---
## AgravityAPI 4.5.2 (2022-09-12)
> Just version upgrade to match backend

---
## AgravityAPI 4.5.1 (2022-09-11)
### New Features:
- Add new endpoint POST ```/translations``` which takes a list of string (assetIds) to return all translations of these assets;
  - Has optional ```property``` query param where it can be filtered down to a specific property;


###Improvements:
- Make ```includeblueprint``` in ```/collectiontypeitems``` as query parameter (not path param);

> Others: Just reordering of properties (no changes on content) - because C# source based on new base classes

---
## AgravityAPI 4.5.0 (2022-09-04)
### New Features:
- Add endpoint PUT ```/assets/{id}/availability``` to set the availibility of the asset (asset operation);
  - Add availability properties to asset (only set, when asset is locked or availability is timed);
  -  Add assetAvailability as separate model;
- Add Ordering of entities in Workspace/CollectionType and Items of CollectionTypes and CollTypeItemBlueprints
- Add AssetIconRuleManagement CRUD ```/asseticonrules``` to have asset icon rules which are displayed on assets;
- Add ```includeBlueprint``` parameter at GET ```/collectiontypeitems``` (to get even the items of blueprints)


> Not possible to update the asset availability asset update  (asset mangement) endpoint;

###Improvements:
- Add param for body POST ```/colltypeitemgroup``` (was missing)
- Add security annotation to GET ```/collectiontypeitems``` (was missing in openAPI)

---
## AgravityAPI 4.4.2 (2022-08-29)
### New Features:
- Add ICC Profile Management:
  - GET ```/iccprofiles``` This endpoint lists all icc profiles in blob container.
- POST ```/colltypeitemgroups/{{collTypeItemGroupId}}``` (editor, admin) This endpoint updates a single collection type item group. (Roles: Editor, Admin)
- Add new endpoint GET ```/searchableitems``` which now returns full items with lots of new information;

###Improvements:
 - Change items of translationManagement.agravity.ts to optional and type bool
 - Changed endpoint ```/searchableitems``` to ```/searchableitemnames```

---
## AgravityAPI 4.4.1 (2022-08-11)
###Improvements:
 - Add missing OpenApiHeader at sdl update
 - Extend WhereParam
 - Update the agravityuser to save name/email/roles/groups
   - add tutorial list (without any function yet)

---
## AgravityAPI 4.4.0 (2022-07-22)
Add Static Defined List Management:
- POST `/staticdefinedlists` (admin) This endpoint creates one static defined list entry in the database.
- GET `/staticdefinedlists` (all) This endpoint lists all static defined lists in database.
- GET `/staticdefinedlists/{id}` (all) This endpoint gets a static defined list from database.
- UPDATE `/staticdefinedlists/{id}` (admin) Updates a static defined list in database.
- DELETE `/staticdefinedlists/{id}` (admin) This endpoint deletes a single static defined list.

Add AssetOperations with new endpoints:
 - PATCH `assets/{id}/runqueue/{queue}` (editor/admin) This endpoint execute a specific queue of the asset. E.g. Recreation of previews, AI recognition, hash values, ...
 - PATCH `assets/{id}/purgecdn` (editor/admin) This endpoint purges all published assets of this asset when CDN is enabled

Add AssetPublishing with new endpoint:
 - POST `assets/{id}/publish/{pid}` (editor/admin) This endpoint currently updates only the description of the published asset with the given ID.

Add HelperTools with new endpoint:
 - POST `helper/excel/export` (admin)  This endpoint creates an excel export of the db

---
## AgravityAPI 4.3.0 (2022-06-27)
Add GeneralManagement with new endpoint:
- POST `/cleanup` (admin) to check all original blobs if all elements are set correctly in database
  - will be removed if not found in database
  - will be moved to archive if found in database but set as deleted (status "D")

Add AssetOperations with new endpoint:
 - GET `assets/{id}/repair` (editor/admin) which refills (or corrects) the collection type items based on collections


Improvements:
- Remove the assets on collections
- Replaced PublishEntity with PublishedAssets
- Add param `workspaceid` to create collection type;
- Add param `sftpenabled` to create secure upload for user;
- Add `name` and `email` to user info;
- Add `region` to version, versionEntity, publishEntity, asset;

---
## AgravityAPI 4.2.0 (2022-06-15)
Add CollTypeItemGroups Management with new endpoints:
  - POST `/colltypeitemgroups` (editor/admin) : This endpoint creates a item collection type group with a subset of items as preparation
  - GET `/colltypeitemgroups` (editor/admin) : This endpoint delivers a list all item collection type groups.
  - DELETE `/colltypeitemgroups/{id}` (editor/admin) : This endpoint deletes a specific item collection type group.

> A CollTypeItemGroup is a collection of prepared items which could be assigned to collection types. These items don't have any relation to collection types, collections or assets. 

Improvements:
- Add `items` parameter to assets and collection to expand all items (with corresponding language);
- CollTypeItem boolean fields are now nullable (mandatory, searchable, onlyasset,multi)
- Add `group` (translateable label of grouping items within a collection type) and `order` (bring the items in order) properties to CollTypeItem which can be filled.

---
## AgravityAPI 4.1.1 (2022-05-26)
- Add publicCollectionTypeManagement and updated routes in publicWorkspaceManagement;

---
## AgravityAPI 4.1.0 (2022-05-15)
- #441
  - POST `/workspaces` (editor/admin) : This endpoint creates a unique workspace ID and adds the information to the database.
  - GET `/workspaces` (all - private & public) : This endpoint lists all available workspaces, which are stored in the database and not deleted (status "A"). It will never be empty. If no workspace is stored in the database, one is constructed (id: "w0000") with all available collection types.
  - GET `/workspaces/{id}` (all - private & public) : This endpoint returns one single workspace (from ID).
  - POST `/workspaces/{id}` (editor/admin) : This endpoint updates the workspace with name, description and collection_types
  - DELETE `/workspaces/{id}` (editor/admin) : This endpoint deletes the workspace with the given ID.
  - DELETE `/workspaces` (admin) : This endpoint deletes all workspaces

---
## AgravityAPI 4.0.1 (2022-05-05)
- Add `filter` query param to GET `/assets` endpoint;
  - extended assetPageResult with filter criterion;
  - new "WhereParam" model

---
## AgravityAPI 4.0.0 V4 .NET6 UPGRADE (2022-04-27)
- Add new private ConfigurationManagementService with new endpoints:
  - GET `/config` (only admin) : Lists all config values stored in config table
  - GET `/config/frontend` (all) : Lists config value only for frontend stored in config table
  - POST `/config` (only admin) : This initializes all configurations and write them into appconfig table.
  - POST `/ config/key` (only admin) : Update an existing config value with the given key. (Only value, content-type and description)
- Add new public ConfigurationManagementService with new endpoint:
  - GET `/config/frontend` (all) : Lists config value only for frontend stored in config table
- Add optional `addconfigqueues` query param to setup (if custom queues have to be initialized)
- SasToken now contains full token incl. URL
- Add upgrade v3tov4 endpoint `/upgrade/V3toV4`

---
##AgravityAPI 3.4.5: Just version update
---
##AgravityAPI 3.4.4: Translations Custom Fields
###API:
- `/translations/{id}/custom/{customField}` GET Get the translation of custom field on the entity (Asset, Collection)
- `/collections/{id}/repair` PATCH This endpoint checks if collection and assets from collection are the same. If not, the collection is corrected.
---
##AgravityAPI 3.4.3: Just version update
---
##AgravityAPI 3.4.2: Translation Management (Bulk)
###API:
- `/translations/{id}` GET all the translations of a whole entity (Asset, Collection, Collection Type, Download Format)
- `/translations/{id}/{property}` GET the translations of a specific field on the entity (Asset, Collection, Collection Type, Download Format)
- `/translations/{id}` POST Updates the translations of a whole entity (Asset, Collection, Collection Type, Download Format)
---
##AgravityAPI 3.4.0: Translations / Download Formats / Search Improvement
###Model:
- `pageResultAsset` was refactored to `assetPageResult`
- `downloadFormat` has now `operations` and `asset_type` instead of `image_operations` to be more flexible
- `shareCollectionFull` has `page` instead of `assets` and `page_size` in return model;
- Translations added to asset, collection, collectionType, collTypeItem and downloadFormat
###API:
- `/assets` POST has now collection id as mandatory parameter
- `/assets` GET has now new assetPageResult return value
- `/shared` GET has now continuous token + limit + order by parameter
- `/deletesearchresources` _[admin]_ can now delete the index, indexer, data-sources and skills - have to be recreated after that.

---

## <a name="known-issues"></a> Known issues

Below is a list of any know issues affecting the [recommended minimum version](#recommended-version):

| Issue | Impact | Mitigation | Tracking link |
| --- | --- | --- | --- |