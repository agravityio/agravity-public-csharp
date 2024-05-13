using Agravity.Public.Api;
using Agravity.Public.Client;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Azure.Functions.Worker;
using Microsoft.Extensions.Logging;
using System.Diagnostics;

namespace AzureFunction4
{
    public class HttpGetCollectionTypeItems
    {
        private readonly ILogger<HttpGetCollectionTypeItems> _logger;

        public HttpGetCollectionTypeItems(ILogger<HttpGetCollectionTypeItems> logger)
        {
            _logger = logger;
        }

        [Function(nameof(HttpGetCollectionTypeItems))]
        public IActionResult Run([HttpTrigger(AuthorizationLevel.Anonymous, "get", Route = "collectiontypeitems")] HttpRequest req)
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
                try
                {
                    var result = apiInstance.HttpGetCollectionTypeItems(true, true);
                    if (result != null)
                    {
                        return new OkObjectResult(result);
                    }
                }
                catch (ApiException e)
                {
                    Debug.Print("Exception when calling PublicCollectionTypeManagementApi.HttpGetCollectionTypeItems: " + e.Message);
                    Debug.Print("Status Code: " + e.ErrorCode);
                    Debug.Print(e.StackTrace);
                    return new BadRequestObjectResult(new { message = e.Message, status_code = e.ErrorCode });
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
