
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Azure.WebJobs;
using Microsoft.Azure.WebJobs.Extensions.Http;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Logging;

namespace ReadMoreApi.Controllers;

public class GoalController
{
    [FunctionName("GoalGet")]
    public  async Task<IActionResult> GoalGet(
        [HttpTrigger(AuthorizationLevel.Anonymous, "get", Route = "goal/{goalid}")] HttpRequest req, int goalid,
        ILogger log)
    {
        log.LogInformation($"Getting Goal: {goalid}");

        var result = "Testing";
        return new OkObjectResult(await Task.FromResult(result));
    }

    [FunctionName("GoalCreate")]
    public  async Task<IActionResult> GoalCreate(
        [HttpTrigger(AuthorizationLevel.Anonymous, "post", Route = "Goal")] HttpRequest req,
        ILogger log)
    {
        log.LogInformation("Creating New Goal Item");

        var result = "Testing";
        return new OkObjectResult(await Task.FromResult(result));
    }

    [FunctionName("GoalGetList")]
    public  async Task<IActionResult> GoalGetList(
        [HttpTrigger(AuthorizationLevel.Anonymous, "get", Route = "goal/{userid}")] HttpRequest req, int userid,
        ILogger log)
    {
        log.LogInformation("Getting Goal Item List");

        var result = "Testing";
        return new OkObjectResult(await Task.FromResult(result));
    }

    [FunctionName("GoalDelete")]
    public  async Task<IActionResult> GoalDelete(
        [HttpTrigger(AuthorizationLevel.Anonymous, "delete", Route = "goal/{goalid}")] HttpRequest req, int goalid,
        ILogger log)
    {
        log.LogInformation($"Deleting Goal: {goalid}");

        var result = "Testing";
        return new OkObjectResult(await Task.FromResult(result));
    }

    [FunctionName("GoalUpdate")]
    public  async Task<IActionResult> GoalUpdate(
        [HttpTrigger(AuthorizationLevel.Anonymous, "put", Route = "goal/{goalid}")] HttpRequest req, int goalid,
        ILogger log)
    {
        log.LogInformation($"Updating Goal: {goalid}");
        
        var result = "Testing";
        return new OkObjectResult(await Task.FromResult(result));
    }
}
