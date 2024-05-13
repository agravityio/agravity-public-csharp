using Agravity.Public.Api;
using Agravity.Public.Client;
using Agravity.Public.Model;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Azure.Functions.Worker;
using Microsoft.Extensions.Logging;
using System.Diagnostics;

namespace AzureFunction4
{
    public class HttpGetCollectionTypes
    {
        private readonly ILogger<HttpGetCollectionTypes> _logger;

        public HttpGetCollectionTypes(ILogger<HttpGetCollectionTypes> logger)
        {
            _logger = logger;
        }

        [Function(nameof(HttpGetCollectionTypes))]
        public IActionResult Run([HttpTrigger(AuthorizationLevel.Anonymous, "get", Route = "collectiontypes")] HttpRequest req)
        {
            _logger.LogInformation("C# HTTP trigger function processed a request.");

            var config = new Configuration
            {
                BasePath = Environment.GetEnvironmentVariable("AgravityPublicUrl")
            };
            config.ApiKey.Add("x-functions-key", Environment.GetEnvironmentVariable("AgravityApiKey"));

            var apiInstance = new PublicCollectionTypeManagementApi(config);

            try
            {
                string id = req.Query["id"];
                if (!string.IsNullOrEmpty(id))
                {
                    try
                    {
                        var result = apiInstance.HttpCollectionTypesGetById(id);
                        if (result != null)
                        {
                            return new OkObjectResult(new CollectionType[] { result });
                        }
                    }
                    catch (ApiException e)
                    {
                        Debug.Print("Exception when calling PublicCollectionTypeManagementApi.HttpCollectionTypesGetById: " + e.Message);
                        Debug.Print("Status Code: " + e.ErrorCode);
                        Debug.Print(e.StackTrace);
                        return new BadRequestObjectResult(new { message = e.Message, status_code = e.ErrorCode });
                    }
                }
                else
                {
                    var result = apiInstance.HttpCollectionTypesGet();
                    Debug.WriteLine(result);
                    return new OkObjectResult(result);

                }
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling PublicAssetManagementApi.HttpAssetUploadFile: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
                return new BadRequestObjectResult(new { message = e.Message, status_code = e.ErrorCode });
            }

            return new NotFoundResult();
        }
    }
}
