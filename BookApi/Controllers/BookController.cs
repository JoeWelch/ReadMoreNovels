using BookApi.Models;
using BookApi.Services;
using Microsoft.AspNetCore.Mvc;

namespace BookApi.Controllers;

[ApiController]
public class BookController : ControllerBase
{
    private readonly ILogger<BookController> _logger;
    private readonly IBookService _bookService;

    private HttpClient _httpClient = new HttpClient();

    public BookController(ILogger<BookController> logger, IBookService bookService)
    {
        _logger = logger;
        _bookService = bookService;
    }

    [HttpGet]
    [Route("api/book/search/{author}")]
    public async Task<List<Book>> SearchBooks(string author)
    // public async Task<string> SearchBooks(string author)
    {
        return await _bookService.SearchBooks(author);
        // var book = new Book{
        //     Author = new List<string> { "Frank N. Stein", "SecondAuthor"},
        //     Category = new List<string> { "Horror", "Comedy"},
        //     Description = "This is a great book!",
        //     Id = "107",
        //     Title = "How I came to life"
        // };
        // return new List<Book> { book };
    }
}
