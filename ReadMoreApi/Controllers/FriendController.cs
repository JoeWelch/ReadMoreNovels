using System.Threading.Tasks;
using Microsoft.Azure.WebJobs;
using Microsoft.Azure.WebJobs.Extensions.Http;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Logging;
using ReadMoreApi.Services;
using System.Collections.Generic;
using ReadMoreApi.APIModels;

namespace ReadMoreApi.Controllers;

public class FriendController
{

    private readonly INovelService _novelService;

    public FriendController(INovelService novelService)
    {
        _novelService = novelService;
    }

    [FunctionName("GetFriends")]
    public List<User> GetFriends(
        [HttpTrigger(AuthorizationLevel.Anonymous, "get", Route = "friend/{userId}")] HttpRequest req, 
        int userId,
        ILogger log)
    {
        log.LogInformation($"Getting friend: User = {userId}");
        return _novelService.GetFriends(userId);
    }

    [FunctionName("FriendAdd")]
    public  async Task<int> FriendAdd(
        [HttpTrigger(AuthorizationLevel.Anonymous, "post", Route = "friend/{userId}/{friendId}")] HttpRequest req, 
        int userId,
        int friendId,
        ILogger log)
    {
        log.LogInformation($"Adding friend: User = {userId}, friend = {friendId}");
        return await _novelService.AddFriend(userId, friendId);
    }

    [FunctionName("FriendRemove")]
    public  async Task<int> FriendRemove(
        [HttpTrigger(AuthorizationLevel.Anonymous, "delete", Route = "friend/{userId}/{friendId}")] HttpRequest req, 
        int userId,
        int friendId,
        ILogger log)
    {
        log.LogInformation($"Removing friend: User = {userId}, friend = {friendId}");
        return await _novelService.RemoveFriend(userId, friendId);
    }

}
