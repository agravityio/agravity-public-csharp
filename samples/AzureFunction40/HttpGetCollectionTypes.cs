using Agravity.Public.Api;
using Agravity.Public.Client;
using Agravity.Public.Model;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Azure.WebJobs;
using Microsoft.Azure.WebJobs.Extensions.Http;
using Microsoft.Azure.WebJobs.Extensions.OpenApi.Core.Attributes;
using Microsoft.Azure.WebJobs.Extensions.OpenApi.Core.Enums;
using Microsoft.Extensions.Logging;
using Microsoft.OpenApi.Models;
using System.Diagnostics;
using System.Net;

namespace TestFunctionDLL
{
    public class HttpGetCollectionTypes
    {
        private readonly ILogger<HttpGetCollectionTypes> _logger;

        public HttpGetCollectionTypes(ILogger<HttpGetCollectionTypes> log)
        {
            _logger = log;
        }

        [FunctionName(nameof(HttpGetCollectionTypes))]
        [OpenApiOperation(operationId: "Run", tags: new[] { "id" })]
        [OpenApiSecurity("function_key", SecuritySchemeType.ApiKey, Name = "code", In = OpenApiSecurityLocationType.Query)]
        [OpenApiParameter(name: "id", In = ParameterLocation.Query, Required = true, Type = typeof(string), Description = "Get a specific **CollectionType**")]
        [OpenApiResponseWithBody(statusCode: HttpStatusCode.OK, contentType: "text/plain", bodyType: typeof(string), Description = "The OK response")]
        public IActionResult Run(
            [HttpTrigger(AuthorizationLevel.Function, "get", Route = "collectiontypes")] HttpRequest req)
        {
            _logger.LogInformation("C# HTTP trigger function processed a request.");

            string id = req.Query["id"];

            var config = new Configuration
            {
                BasePath = "http://localhost:7072/api"
            };
            config.ApiKey.Add("x-functions-key", "YOUR_API_KEY");

            var apiInstance = new PublicCollectionTypeManagementApi(config);


            try
            {
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

