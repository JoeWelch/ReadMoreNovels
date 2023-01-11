using System;
using System.IO;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Azure.WebJobs;
using Microsoft.Azure.WebJobs.Extensions.Http;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Logging;
using Newtonsoft.Json;

namespace ReadMoreApi
{
    public class FriendController
    {
        [FunctionName("FriendGet")]
        public  async Task<IActionResult> FriendGet(
            [HttpTrigger(AuthorizationLevel.Anonymous, "get", Route = "friend")] HttpRequest req,
            ILogger log)
        {
            log.LogInformation("Creating New Friend Item");

            var result = "Testing";
            return new OkObjectResult(await Task.FromResult(result));
        }
    }
}
