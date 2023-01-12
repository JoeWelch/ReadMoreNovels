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
    public class FriendController
    {
        [FunctionName("FriendGet")]
        public  async Task<IActionResult> FriendGet(
            [HttpTrigger(AuthorizationLevel.Anonymous, "get", Route = "friend/{friendid}")] HttpRequest req, int friendid,
            ILogger log)
        {
            log.LogInformation("Getting Friend Item");

            var result = "Testing";
            return new OkObjectResult(await Task.FromResult(result));
        }

        [FunctionName("FriendCreate")]
        public  async Task<IActionResult> FriendCreate(
            [HttpTrigger(AuthorizationLevel.Anonymous, "post", Route = "friend")] HttpRequest req,
            ILogger log)
        {
            log.LogInformation("Creating New Friend Item");

            var result = "Testing";
            return new OkObjectResult(await Task.FromResult(result));
        }

        [FunctionName("FriendGetList")]
        public  async Task<IActionResult> FriendGetList(
            [HttpTrigger(AuthorizationLevel.Anonymous, "get", Route = "friend/{userid}")] HttpRequest req, int userid,
            ILogger log)
        {
            log.LogInformation("Creating New Friend Item");

            var result = "Testing";
            return new OkObjectResult(await Task.FromResult(result));
        }

        [FunctionName("FriendDelete")]
        public  async Task<IActionResult> FriendDelete(
            [HttpTrigger(AuthorizationLevel.Anonymous, "delete", Route = "friend/{friendid}")] HttpRequest req, int friendid,
            ILogger log)
        {
            log.LogInformation("Creating New Friend Item");

            var result = "Testing";
            return new OkObjectResult(await Task.FromResult(result));
        }

        [FunctionName("FriendUpdate")]
        public  async Task<IActionResult> FriendUpdate(
            [HttpTrigger(AuthorizationLevel.Anonymous, "put", Route = "friend/{friendid}")] HttpRequest req, int friendid,
            ILogger log)
        {
            log.LogInformation("Creating New Friend Item");

            var result = "Testing";
            return new OkObjectResult(await Task.FromResult(result));
        }
    }
}
