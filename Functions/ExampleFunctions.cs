using AzureFunctionsHttpTemplate.Data.Interfaces;
using AzureFunctionsHttpTemplate.Helpers;
using AzureFunctionsHttpTemplate.Models;
using Microsoft.Azure.Functions.Worker;
using Microsoft.Azure.Functions.Worker.Http;
using Microsoft.Extensions.Logging;
using System.Net;
using System.Text.Json;

namespace AzureFunctionsHttpTemplate.Functions
{
    public class ExampleFunctions(ILogger<ExampleFunctions> logger, ILogData logData)
    {
        private const string message = "Hello World!";
        private const string logMessage = "Someone wanted to say hello!";

        [Function("HelloWorldText")]
        public HttpResponseData ReplyHelloWorld([HttpTrigger(AuthorizationLevel.Function, "post")] HttpRequestData req)
        {
            logger.LogInformation("HelloWorldText function processed a request.");

            logData.CreateLog(new Log(logMessage));

            return ApiHelpers.CreateResponseText(req, message, HttpStatusCode.OK);
        }

        [Function("HelloWorldJson")]
        public HttpResponseData ReplyHelloWorldJson([HttpTrigger(AuthorizationLevel.Function, "post")] HttpRequestData req)
        {
            logger.LogInformation("HelloWorldJson function processed a request.");

            var helloWorld = new { message };

            logData.CreateLog(new Log(logMessage));

            return ApiHelpers.CreateResponseJson(req, JsonSerializer.Serialize(helloWorld), HttpStatusCode.OK);
        }
    }
}
