using BookApi.Models;
using Microsoft.AspNetCore.Mvc;

namespace BookApi.Controllers;

[ApiController]
public class BookController : ControllerBase
{
    private readonly ILogger<BookController> _logger;

    public BookController(ILogger<BookController> logger)
    {
        _logger = logger;
    }

    [HttpGet]
    [Route("api/book/search")]
    public async Task<List<Book>> SearchBooks()
    {
        var book = new Book{
            Author = new List<string> { "Frank N. Stein", "SecondAuthor"},
            Category = new List<string> { "Horror", "Comedy"},
            Description = "This is a great book!",
            Id = "107",
            Title = "How I came to life"
        };
        return new List<Book> { book };
    }

}
