using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Azure.WebJobs;
using Microsoft.Azure.WebJobs.Extensions.Http;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Logging;
using ReadMoreApi.Services;
using ReadMoreApi.APIModels;
using System.IO;
using System.Collections.Generic;

namespace ReadMoreApi.Controllers;

public class UserController
{
    private readonly INovelService _novelService;

    public UserController(INovelService novelService)
    // public UserController
    {
        _novelService = novelService;
        // _novelService = new NovelService(new AppDbContext());
    }

    [FunctionName("LoginUser")]
    public  async Task<User> LoginUser(
        [HttpTrigger(AuthorizationLevel.Anonymous, "post", Route = "user/login/{emailName}")] HttpRequest req, string emailName,
        ILogger log)
    {
        log.LogInformation($"Logging in User: {emailName}");
        return await _novelService.LoginUser(emailName);
    }

    [FunctionName("ModifyUser")]
    public  async Task<User> ModifyUser(
        [HttpTrigger(AuthorizationLevel.Anonymous, "post", Route = "user/{userId}")] HttpRequest req, int userId,
        ILogger log)
    {
        log.LogInformation($"Modifying User: {userId}");
        var user = await GetUserFromRequest(req, log);
        return await _novelService.ModifyUser(userId, user);
    }

    [FunctionName("DeleteUser")]
    public  async Task<int> DeleteUser(
        [HttpTrigger(AuthorizationLevel.Anonymous, "delete", Route = "user/{userId}")] HttpRequest req, int userId,
        ILogger log)
    {
        log.LogInformation($"Deleting User: {userId}");
        return await _novelService.DeleteUser(userId);
    }

    [FunctionName("GetUser")]
    public  async Task<User> GetUser(
        [HttpTrigger(AuthorizationLevel.Anonymous, "get", Route = "user/{userId}")] HttpRequest req, int userId,
        ILogger log)
    {
        log.LogInformation($"Getting User: {userId}");
        return await _novelService.GetUser(userId);
    }

    [FunctionName("FindUsers")]
    public  async Task<List<User>> FindUsers(
        [HttpTrigger(AuthorizationLevel.Anonymous, "get", Route = "user/search")] HttpRequest req, ILogger log)
    {
        string nameFilter = (req.Query["nameFilter"]);
        nameFilter ??= "";  // If namefilter is null, make it the empty string

        string emailFilter = req.Query["emailFilter"];
        emailFilter ??= ""; // If emailfilter is null, make it the empty string

        log.LogInformation($"Finding Users: emailFilter = {emailFilter}, nameFilter = {nameFilter}");
        return await _novelService.FindUsers(emailFilter, nameFilter);
    }

    private async Task<User> GetUserFromRequest(HttpRequest req, ILogger log)
    {
        string requestBody = string.Empty;
        using (StreamReader streamReader = new StreamReader(req.Body))
        {
            requestBody = await streamReader.ReadToEndAsync();
        }
        log.LogInformation($"Read User from body: {requestBody}");

        var userBody = System.Text.Json.JsonSerializer.Deserialize<User>(requestBody, GlobalEnv.jsonOptions);
        return userBody;    
    }

}

    
