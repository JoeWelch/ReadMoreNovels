using System;
using System.IO;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Azure.WebJobs;
using Microsoft.Azure.WebJobs.Extensions.Http;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Logging;
using Newtonsoft.Json;
using ReadMoreApi.Services;
using ReadMoreApi.APIModels;
using System.Collections.Generic;

namespace ReadMoreApi.Controllers;

public class BookController
{
    private readonly INovelService _novelService;

    public BookController(INovelService novelService)
    {
        _novelService = novelService;
    }


    [FunctionName("GetBookDetail")]
    public async Task<BookDetail> GetBookDetail(
        [HttpTrigger(AuthorizationLevel.Anonymous, "get", Route = "book/detail/getbook/{bookId}")] HttpRequest req, int bookId,
        ILogger log)
    {
        log.LogInformation($"Get Book Detail for Id={bookId}");
        return await _novelService.GetBookDetail(bookId);
    }

    [FunctionName("SearchBookDetails")]
    public  async Task<List<BookDetail>> SearchBookDetails(
        [HttpTrigger(AuthorizationLevel.Anonymous, "get", Route = "book/detail/search")] HttpRequest req,
        ILogger log)
    {
        string authorFilter = (req.Query["authorFilter"]);
        authorFilter ??= "";  // If namefilter is null, make it the empty string

        string titleFilter = req.Query["titleFilter"];
        titleFilter ??= ""; // If titleFilter is null, make it the empty string

        log.LogInformation($"Searching books: authorFilter={authorFilter}, titleFilter={titleFilter}");
        return await _novelService.SearchBookDetails(authorFilter, titleFilter);
    }

    [FunctionName("GetBook")]
    public async Task<BookDetail> GetBook(
        [HttpTrigger(AuthorizationLevel.Anonymous, "get", Route = "book/{bookId}")] HttpRequest req, int bookId,
        ILogger log)
    {
        log.LogInformation($"Get Book Detail for Id={bookId}");
        return await _novelService.GetBookDetail(bookId);
    }

    [FunctionName("UpdateBook")]
    public async Task<Book> UpdateBook(
        [HttpTrigger(AuthorizationLevel.Anonymous, "put", Route = "book/{bookId}")] HttpRequest req, int bookId,
        ILogger log)
    {
        log.LogInformation($"Updating book {bookId}");
            var requestBody = await new StreamReader(req.Body).ReadToEndAsync();
            Book updated = System.Text.Json.JsonSerializer.Deserialize<Book>(requestBody, GlobalEnv.jsonOptions);
            var result = await _novelService.UpdateBook(bookId,updated);
            return result;
    }

    [FunctionName("GetUserBooks")]
    public List<Book> GetUserBooks(
        [HttpTrigger(AuthorizationLevel.Anonymous, "get", Route = "book/{userId}")] HttpRequest req, int userId,
        ILogger log)
    {
        log.LogInformation($"Getting books for User Id={userId}");
        return  _novelService.GetUserBooks(userId);
    }

    [FunctionName("CreateBook")]
    public async Task<int> CreateBook(
        [HttpTrigger(AuthorizationLevel.Anonymous, "post", Route = "book/{userId}")] HttpRequest req, int userId,
        ILogger log)
    {
        log.LogInformation($"Creating Book under User Id={userId}");
        return  await _novelService.CreateBook(userId);
    }

}
//[FunctionName("BookGet")]
    // public  async Task<IActionResult> BookGet(
    //     [HttpTrigger(AuthorizationLevel.Anonymous, "get", Route = "book/{bookid}")] HttpRequest req, int bookid,
    //     ILogger log)
    // {
    //     log.LogInformation($"Getting Book Item ID: {bookid}");

    //     var result = "Testing";
    //     return new OkObjectResult(await Task.FromResult(result));
    // }

    // [FunctionName("BookCreate")]
    // public  async Task<IActionResult> BookCreate(
    //     [HttpTrigger(AuthorizationLevel.Anonymous, "post", Route = "book")] HttpRequest req,
    //     ILogger log)
    // {
    //     log.LogInformation("Creating New Book Item");

    //     var result = "Testing";
    //     return new OkObjectResult(await Task.FromResult(result));
    // }

    // [FunctionName("BookGetList")]
    // public  async Task<IActionResult> BookGetList(
    //     [HttpTrigger(AuthorizationLevel.Anonymous, "get", Route = "book")] HttpRequest req,
    //     ILogger log)
    // {
    //     log.LogInformation("Creating New Book Item");

    //     var result = "Testing";
    //     return new OkObjectResult(await Task.FromResult(result));
    // }

    // [FunctionName("BookDelete")]
    // public  async Task<IActionResult> BookDelete(
    //     [HttpTrigger(AuthorizationLevel.Anonymous, "delete", Route = "book")] HttpRequest req,
    //     ILogger log)
    // {
    //     log.LogInformation("Creating New Book Item");

    //     var result = "Testing";
    //     return new OkObjectResult(await Task.FromResult(result));
    // }

    // [FunctionName("BookUpdate")]
    // public  async Task<IActionResult> BookUpdate(
    //     [HttpTrigger(AuthorizationLevel.Anonymous, "put", Route = "book")] HttpRequest req,
    //     ILogger log)
    // {
    //     log.LogInformation("Creating New Book Item");

    //     var result = "Testing";
    //     return new OkObjectResult(await Task.FromResult(result));
    // }
