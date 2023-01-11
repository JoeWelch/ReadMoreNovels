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
    public class UserController
    {
        [FunctionName("UserGet")]
        public  async Task<IActionResult> UserGet(
            [HttpTrigger(AuthorizationLevel.Anonymous, "get", Route = "user/{email}")] HttpRequest req, string email,
            ILogger log)
        {
            log.LogInformation("Creating New User Item");

            var result = email;
            
            //var result = "New Item";//_stockService.CreateProfile(profile);
           return new OkObjectResult(await Task.FromResult(result));
        }

       [FunctionName("UserCreate")]
        public async Task<IActionResult> UserCreate(
            [HttpTrigger(AuthorizationLevel.Anonymous, "post", Route = "user")] HttpRequest req,
            ILogger log)
        {
           
           log.LogInformation("Creating a new profile item");
           var requestBody = await new StreamReader(req.Body).ReadToEndAsync();
          // UserProfile profile = System.Text.Json.JsonSerializer.Deserialize<UserProfile>(requestBody, GlobalEnv.jsonOptions);
           var result = "New Item";//_stockService.CreateProfile(profile);
           return new OkObjectResult(await Task.FromResult(result));
       }
    }
}
