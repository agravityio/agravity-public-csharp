using Agravity.Public.Api;
using Agravity.Public.Client;
using Agravity.Public.Model;
using RestSharp;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace AgravityPublicLib
{
    public class AgravityDam
    {

        // Create a dictionary to map file extensions to their corresponding content types
        public static Dictionary<string, string> ContentTypesDict = new Dictionary<string, string>
        {
            {".txt", "text/plain"},
            {".html", "text/html"},
            {".jpg", "image/jpeg"},
            {".jpeg", "image/jpeg"},
            {".png", "image/png"},
            {".tif", "image/tiff"},
            {".tiff", "image/tiff"},
            {".pdf", "application/pdf"},
            {".doc", "application/msword"},
            {".docx", "application/vnd.openxmlformats-officedocument.wordprocessingml.document"}
        };

        private Configuration config;
        public Configuration Config
        {
            get
            {
                if (config == null)
                {
                    throw new System.Exception("Agravity GlobalDAM SDK not initialized!");
                }
                return config;
            }
            private set
            {
                config = value;
            }
        }
        public AgravityDam(string baseUrl, string apiKey)
        {
            config = new Configuration()
            {
                BasePath = baseUrl
            };
            config.ApiKey.Add("x-functions-key", apiKey);
        }

        /// <summary>
        /// The HTTP method to update asset. It's a "all-in-one" package which creates an asset in a collection and uploads the file.
        /// </summary>
        /// <param name="assetName">How the name of file should be.</param>
        /// <param name="collectionId">The Agravity collection ID where the asset should be created.</param>
        /// <param name="filePath">The path of the corresponding file.</param>
        /// <returns></returns>
        public string UploadAssetFile(string assetName, string collectionId, string filePath)
        {
            var apiInstance = new PublicAssetManagementApi(config);

            var file = new System.IO.MemoryStream(System.IO.File.ReadAllBytes(filePath));  // System.IO.Stream |  (optional) 

            Asset result = null;
            try
            {
                result = apiInstance.HttpAssetUploadFile(assetName, collectionId, file);
                Debug.WriteLine(result.Name);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling PublicAssetManagementApi.HttpAssetUploadFile: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }

            return result?.Id;

        }

        /// <summary>
        /// This method just create a asset and adds it to a collection. It will return the ID of the asset.
        /// </summary>
        /// <param name="assetName">How the assets name should be (must not be file name).</param>
        /// <param name="collectionId">The Agravity collection ID where the asset should be created.</param>
        /// <returns></returns>
        public Asset CreateAsset(string assetName, string collectionId)
        {
            var apiInstance = new PublicAssetManagementApi(config);

            Asset result = null;
            try
            {
                result = apiInstance.HttpAssetsCreate(collectionId, new Asset() { Name = assetName });
                Debug.WriteLine(result.Name);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling PublicAssetManagementApi.HttpAssetUploadFile: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }

            return result;
        }

        /// <summary>
        /// This creates the collection in the specified collection type;
        /// </summary>
        /// <param name="collectionName">How the name of the collection should be.</param>
        /// <returns></returns>
        public (string Id, string Name) CreateCollection(string collectionName, string collTypeId)
        {
            var apiInstance = new PublicCollectionManagementApi(config);

            Collection coll = new Collection()
            {
                Name = collectionName
            };
            try
            {
                var result = apiInstance.HttpCollectionsCreate(collTypeId, coll);
                if (result?.Id != null)
                {
                    coll = result;
                }
                Debug.WriteLine(result.Name);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling PublicAssetManagementApi.HttpAssetUploadFile: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }

            return (coll.Id, coll.Name);

        }

        /// <summary>
        /// Method which gets all collections from API
        /// </summary>
        /// <returns>A tuple of collection id and collection name</returns>
        public List<(string Id, string Name)> GetAllCollections(string collTypeId)
        {
            var apiInstance = new PublicCollectionManagementApi(config);

            try
            {
                var result = apiInstance.HttpCollectionsGet(collTypeId);
                return result?.Select(c => (c.Id, c.Name)).ToList();
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling PublicCollectionManagementApi.HttpCollectionsGet: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }

            return null;
        }

        /// <summary>
        /// Get the inbox token to upload assets
        /// </summary>
        /// <returns>The SasToken which contains information about storage and access to it.</returns>
        public SasToken GetInboxToken()
        {
            var apiInstance = new PublicAuthenticationManagementApi(config);

            try
            {
                return apiInstance.HttpAuthGetInboxContainerWriteSasToken();
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling PublicCollectionManagementApi.HttpCollectionsGet: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }

            return null;
        }


        /// <summary>
        /// Returns the current version of Agravity
        /// </summary>
        /// <returns></returns>
        public async Task<AgravityVersion> GetAgravityVersion()
        {
            var apiInstance = new PublicGeneralManagementApi(config);
            return await apiInstance.HttpAgravityVersionInfoAsync();
        }

        /// <summary>
        /// Return all workspaces
        /// </summary>
        /// <returns></returns>
        public async Task<List<Workspace>> GetWorkspaces()
        {
            var apiInstance = new PublicWorkspaceManagementApi(config);
            List<Workspace> workspaces = (await apiInstance.HttpWorkspacesGetAsync()).ToList() ?? new List<Workspace>();
            return workspaces;
        }

        /// <summary>
        /// This returns the collection type from the collection id stored in properties.
        /// </summary>
        /// <returns></returns>
        public async Task<CollectionType> GetCollectionType(string collTypeId)
        {
            var apiInstance = new PublicCollectionTypeManagementApi(config);
            return await apiInstance.HttpCollectionTypesGetByIdAsync(collTypeId);
        }

        /// <summary>
        /// This returns the asset from the given ID.
        /// </summary>
        /// <returns></returns>
        public Asset GetAsset(string assetId)
        {
            var apiInstance = new PublicAssetManagementApi(config);
            return apiInstance.HttpAssetsGetById(assetId);
        }

        /// <summary>
        /// Create empty asset version
        /// </summary>
        /// <returns></returns>
        public VersionedAsset CreateVersionedAsset(string assetId)
        {
            var apiInstance = new PublicAssetVersioningApi(config);
            return apiInstance.HttpAssetCreateVersion(assetId, new VersionedAsset());
        }


        /* Upload using Azure.Storage.Blobs, Version=12.14.1.0 (working - but big bloat on packages
        /// <summary>
        /// Set all the metadata of the dictionary on a blob and sync them.
        /// </summary>
        /// <param name="blob">The blob on which the metadata is written on.</param>
        /// <param name="keyValue">The dictionary containing all the metadata.</param>
        /// <returns></returns>
        private static async Task SetBlobMetadataAsync(BlobClient blob, Dictionary<string, string> keyValue)
        {
            var metadata = new Dictionary<string, string>();

            foreach (var item in keyValue)
            {
                if (!metadata.ContainsKey(item.Key))
                {
                    // Add Metadata to blob
                    metadata.Add(item.Key, item.Value);
                }
                else
                {
                    // simply set value to existing
                    metadata[item.Key] = item.Value;
                }
            }

            await blob.SetMetadataAsync(metadata);

        }

        /// <summary>
        /// Set all the metadata of the key and value on a blob and sync them.
        /// </summary>
        /// <param name="blob">The blob on which the metadata is written on.</param>
        /// <param name="key">The metadata key.</param>
        /// <param name="value">The metadata value.</param>
        /// <returns></returns>

       private static async Task SetBlobMetadataSingleAsync(BlobClient blob, string key, string value)
       {
           var metadata = blob.GetProperties().Value.Metadata;
           metadata[key] = value;
           await blob.SetMetadataAsync(metadata);

           / *
           IDictionary<string, string> metadata = (await blob.GetPropertiesAsync()).Value.Metadata;
           if (!metadata.ContainsKey(key))
           {
               // Add Metadata to blob
               metadata.Add(key, value);
           }
           else
           {
               // simply set value to existing
               metadata[key] = value;
           }

           // Set the blob's metadata
           await blob.SetMetadataAsync(metadata).ConfigureAwait(false);
           * /
       }

       /* Upload using Azure.Storage.Blobs, Version=12.14.1.0 (working - but big bloat on packages
       internal bool UploadAssetStorage(string assetName, string filePath, string collectionId)
       {
           var assetId = CreateAsset(assetName, collectionId);
           if (!string.IsNullOrEmpty(assetId))
           {
               var inboxToken = GetInboxToken();

               var inboxContainer = new BlobContainerClient(new Uri(inboxToken.FullToken));
               var fileName = Path.GetFileName(filePath);
               var blobClient = inboxContainer.GetBlobClient(fileName);

               IDictionary<string, string> metadata = new Dictionary<string, string>
               {
                   { "assetId", assetId }
               };
               BlobHttpHeaders httpHeaders = new BlobHttpHeaders()
               {
                   ContentType = "image/tiff"
               };
               // metadata.Add(ModelHelper.JSON_PROPERTY_DOWNLOAD_ID, downloadId);

               var uploadSucceded = blobClient.Upload(filePath, new BlobUploadOptions() { Metadata = metadata, HttpHeaders = httpHeaders });

               // var uploadSucceded = inboxContainer.UploadBlob(fileName, new BinaryData(File.ReadAllBytes(currentFile)));

               return uploadSucceded.GetRawResponse().Status == (int)System.Net.HttpStatusCode.Created;
           }
           return false;
       }
       */
        internal Asset UploadCreateAssetStorageRest(string assetName, string filePath, string collectionId)
        {
            var asset = CreateAsset(assetName, collectionId);
            if (asset != null)
            {
                var metaDict = new Dictionary<string, string>()
                {
                    {"assetId", asset.Id }
                };
                if (UploadFileToStorageRest(filePath, metaDict))
                {
                    return asset;
                }
            }
            return null;
        }

        internal VersionedAsset UploadAssetVersionToStorageRest(string assetId, string filePath)
        {
            if (!string.IsNullOrEmpty(assetId))
            {
                var asset = GetAsset(assetId);
                if (asset == null)
                {
                    return null;
                }
                var versionedAsset = CreateVersionedAsset(assetId);

                var metaDict = new Dictionary<string, string>()
                {
                    {"assetId", assetId },
                    { "versionNr", $"{versionedAsset.VersionNr}" }
                    // {"assetversion", assetId+"_"+versionedAsset.VersionNr},
                };

                if (UploadFileToStorageRest(filePath, metaDict))
                {
                    return versionedAsset;
                }
            }
            return null;
        }


        internal Asset UploadAssetOverwriteToStorageRest(string assetId, string filePath)
        {
            if (!string.IsNullOrEmpty(assetId))
            {
                var asset = GetAsset(assetId);
                if (asset == null)
                {
                    return null;
                }

                var metaDict = new Dictionary<string, string>()
                {
                    {"assetId", assetId },
                    {"overwrite", "true" }
                };

                if (UploadFileToStorageRest(filePath, metaDict))
                {
                    return asset;
                }
            }
            return null;
        }

        internal bool UploadFileToStorageRest(string filePath, Dictionary<string, string> metaDataDict = null)
        {
            var inboxToken = GetInboxToken();

            // var client = new RestClient(inboxToken.Url);

            string fileName = Path.GetFileName(filePath);
            string fileExtension = Path.GetExtension(filePath);

            string contentType;
            if (AgravityDam.ContentTypesDict.TryGetValue(fileExtension, out string cT))
            {
                contentType = cT;
            }
            else
            {
                // Content type was not found, default to "application/octet-stream"
                contentType = "application/octet-stream";
            }

            var uploadFileUrl = inboxToken.Url + inboxToken.Container + $"/{fileName}" + inboxToken.Token;

            var client = new RestClient(uploadFileUrl);

            var request = new RestRequest();
            request.Method = Method.Put;
            request.AddHeader("x-ms-version", "2021-06-08");
            request.AddHeader("x-ms-date", DateTimeOffset.Now.ToUnixTimeMilliseconds());
            request.AddHeader("x-ms-blob-type", "BlockBlob");
            if (metaDataDict != null && metaDataDict.Count > 0)
            {
                foreach (var kv in metaDataDict)
                {
                    var key = kv.Key.StartsWith("x-ms-meta-") ? kv.Key : "x-ms-meta-" + kv.Key;
                    request.AddHeader(key, kv.Value);
                }
            }
            request.AddHeader("Content-Type", contentType);
            request.AddParameter(contentType, File.ReadAllBytes(filePath), ParameterType.RequestBody);

            var response = client.Execute(request);
            return response.StatusCode == System.Net.HttpStatusCode.Created;
        }

    }
}
