using System;
using System.IO;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Azure.WebJobs;
using Microsoft.Azure.WebJobs.Extensions.Http;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Logging;
using Newtonsoft.Json;

namespace ReadMoreApi.Controllers;

public class BookController
{
    [FunctionName("BookGet")]
    public  async Task<IActionResult> BookGet(
        [HttpTrigger(AuthorizationLevel.Anonymous, "get", Route = "book/{bookid}")] HttpRequest req, int bookid,
        ILogger log)
    {
        log.LogInformation("Creating New Book Item");

        var result = "Testing";
        return new OkObjectResult(await Task.FromResult(result));
    }

    [FunctionName("BookCreate")]
    public  async Task<IActionResult> BookCreate(
        [HttpTrigger(AuthorizationLevel.Anonymous, "post", Route = "book")] HttpRequest req,
        ILogger log)
    {
        log.LogInformation("Creating New Book Item");

        var result = "Testing";
        return new OkObjectResult(await Task.FromResult(result));
    }

    [FunctionName("BookGetList")]
    public  async Task<IActionResult> BookGetList(
        [HttpTrigger(AuthorizationLevel.Anonymous, "get", Route = "book")] HttpRequest req,
        ILogger log)
    {
        log.LogInformation("Creating New Book Item");

        var result = "Testing";
        return new OkObjectResult(await Task.FromResult(result));
    }

    [FunctionName("BookDelete")]
    public  async Task<IActionResult> BookDelete(
        [HttpTrigger(AuthorizationLevel.Anonymous, "delete", Route = "book")] HttpRequest req,
        ILogger log)
    {
        log.LogInformation("Creating New Book Item");

        var result = "Testing";
        return new OkObjectResult(await Task.FromResult(result));
    }

    [FunctionName("BookUpdate")]
    public  async Task<IActionResult> BookUpdate(
        [HttpTrigger(AuthorizationLevel.Anonymous, "put", Route = "book")] HttpRequest req,
        ILogger log)
    {
        log.LogInformation("Creating New Book Item");

        var result = "Testing";
        return new OkObjectResult(await Task.FromResult(result));
    }
    
}
