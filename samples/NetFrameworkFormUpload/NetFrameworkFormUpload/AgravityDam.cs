using Agravity.Public.Api;
using Agravity.Public.Client;
using Agravity.Public.Model;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;

namespace AgravityPublicLib
{
    public class AgravityDam
    {
        /*
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
        */

        private string CollectionTypeId { get; set; }
        private Agravity.Public.Client.Configuration Config { get; set; }
        public AgravityDam(string baseUrl, string apiKey, string collectionTypeId)
        {
            Config = new Agravity.Public.Client.Configuration()
            {
                BasePath = baseUrl
            };
            Config.ApiKey.Add("x-functions-key", apiKey);

            CollectionTypeId = collectionTypeId;
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
            var apiInstance = new PublicAssetManagementApi(Config);

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
        public string CreateAsset(string assetName, string collectionId)
        {
            var apiInstance = new PublicAssetManagementApi(Config);

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

            return result?.Id;
        }

        /// <summary>
        /// This creates the collection in the specified collection type;
        /// </summary>
        /// <param name="collectionName">How the name of the collection should be.</param>
        /// <returns></returns>
        public (string Id, string Name) CreateCollection(string collectionName)
        {
            var apiInstance = new PublicCollectionManagementApi(Config);

            Collection coll = new Collection()
            {
                Name = collectionName
            };
            try
            {
                var result = apiInstance.HttpCollectionsCreate(CollectionTypeId, coll);
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
        public List<(string Id, string Name)> GetAllCollections()
        {
            var apiInstance = new PublicCollectionManagementApi(Config);

            try
            {
                var result = apiInstance.HttpCollectionsGet(CollectionTypeId);
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
            var apiInstance = new PublicAuthenticationManagementApi(Config);

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
    }
}
