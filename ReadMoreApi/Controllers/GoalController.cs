using System;
using System.IO;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Azure.WebJobs;
using Microsoft.Azure.WebJobs.Extensions.Http;
using Microsoft.AspNetCore.Http;
//using Microsoft.Extensions.Logging;
using Newtonsoft.Json;

namespace ReadMoreApi
{
    public class GoalController
    {
        [FunctionName("GoalGet")]
        public  async Task<IActionResult> GoalGet(
            [HttpTrigger(AuthorizationLevel.Anonymous, "get", Route = "goal")] HttpRequest req)
           // ILogger log)
        {
            //log.LogInformation("Creating New Goal Item");

            var result = "Testing";
            return new OkObjectResult(await Task.FromResult(result));
        }
    }
}
