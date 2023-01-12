using System;
using System.IO;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Azure.WebJobs;
using Microsoft.Azure.WebJobs.Extensions.Http;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Logging;
using Newtonsoft.Json;

namespace READMOREAPI
{
    public class UserController
    {
        [FunctionName("UserGet")]
        public  async Task<IActionResult> UserGet(
            [HttpTrigger(AuthorizationLevel.Anonymous, "get", Route = "user/{userid}")] HttpRequest req, int userid,
            ILogger log)
        {
            log.LogInformation($"Getting User: {userid}");

            var result = "Testing";
            return new OkObjectResult(await Task.FromResult(result));
        }

        [FunctionName("UserCreate")]
        public  async Task<IActionResult> UserCreate(
            [HttpTrigger(AuthorizationLevel.Anonymous, "post", Route = "user")] HttpRequest req,
            ILogger log)
        {
            log.LogInformation("Creating New User Item");

            var result = "Testing";
            return new OkObjectResult(await Task.FromResult(result));
        }

        [FunctionName("UserGetList")]
        public  async Task<IActionResult> UserGetList(
            [HttpTrigger(AuthorizationLevel.Anonymous, "get", Route = "user")] HttpRequest req,
            ILogger log)
        {
            log.LogInformation("Getting User Item List");

            var result = "Testing";
            return new OkObjectResult(await Task.FromResult(result));
        }

        [FunctionName("UserDelete")]
        public  async Task<IActionResult> UserDelete(
            [HttpTrigger(AuthorizationLevel.Anonymous, "delete", Route = "user/{userid}")] HttpRequest req, int userid,
            ILogger log)
        {
            log.LogInformation($"Deleting User: {userid}");

            var result = "Testing";
            return new OkObjectResult(await Task.FromResult(result));
        }

        [FunctionName("UserUpdate")]
        public  async Task<IActionResult> UserUpdate(
            [HttpTrigger(AuthorizationLevel.Anonymous, "put", Route = "user/{userid}")] HttpRequest req, int userid,
            ILogger log)
        {
            log.LogInformation($"Updating User: {userid}");
            
            var result = "Testing";
            return new OkObjectResult(await Task.FromResult(result));
        }
    }
}
    
