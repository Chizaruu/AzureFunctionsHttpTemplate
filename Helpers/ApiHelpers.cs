using Microsoft.Azure.Functions.Worker.Http;
using System.Net;

namespace AzureFunctionsHttpTemplate.Helpers
{
    public static class ApiHelpers
    {
        public static HttpResponseData CreateResponseText(HttpRequestData req, string message, HttpStatusCode statusCode)
        {
            var response = req.CreateResponse(statusCode);
            response.WriteString(message);
            response.Headers.Add("Content-Type", "text/plain; charset=utf-8");
            return response;
        }

        public static HttpResponseData CreateResponseJson(HttpRequestData req, string message, HttpStatusCode statusCode)
        {
            var response = req.CreateResponse(statusCode);
            response.WriteString(message);
            response.Headers.Add("Content-Type", "application/json; charset=utf-8");
            return response;
        }
    }
}
