using Agravity.Public.Api;
using Agravity.Public.Client;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Azure.Functions.Worker;
using Microsoft.Extensions.Logging;
using System.Diagnostics;

namespace AzureFunction4
{
    public class HttpGetSearchableItems
    {
        private readonly ILogger<HttpGetSearchableItems> _logger;

        public HttpGetSearchableItems(ILogger<HttpGetSearchableItems> logger)
        {
            _logger = logger;
        }

        [Function(nameof(HttpGetSearchableItems))]
        public IActionResult Run([HttpTrigger(AuthorizationLevel.Anonymous, "get", Route = "searchableitems")] HttpRequest req)
        {
            _logger.LogInformation("C# HTTP trigger function processed a request.");

            var config = new Configuration
            {
                BasePath = Environment.GetEnvironmentVariable("AgravityPublicUrl")
            };
            config.ApiKey.Add("x-functions-key", Environment.GetEnvironmentVariable("AgravityApiKey"));

            var apiInstance = new PublicHelperToolsApi(config);

            try
            {
                var result = apiInstance.HttpGetAllowedSearchableItemNames();
                Debug.WriteLine(result);
                return new OkObjectResult(result);
            }
            catch (ApiException e)
            {
                Debug.Print($"Exception when calling {nameof(PublicHelperToolsApi)}.{nameof(apiInstance.HttpGetAllowedSearchableItemNames)}: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
                return new BadRequestObjectResult(new { message = e.Message, status_code = e.ErrorCode });
            }

            return new NotFoundResult();
        }
    }
}
