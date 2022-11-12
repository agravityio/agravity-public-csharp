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
        private string CollectionTypeId { get; set; }
        private Configuration Config { get; set; }
        public AgravityDam()
        {
            Config = new Configuration()
            {
                BasePath = "http://localhost:7072/api"
            };
            Config.ApiKey.Add("x-functions-key", "YOUR_API_KEY");

            //TODO: Get collection type id from config
            CollectionTypeId = "t000000000000";
        }

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
    }
}
