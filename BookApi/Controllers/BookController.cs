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
    [Route("api/book/search")]
    public async Task<List<Book>> SearchBooks(string authorFilter, string titleFilter)
    {
        authorFilter ??= "";
        titleFilter ??= "";

        return await _bookService.SearchBooks(authorFilter, titleFilter);
    }

    [HttpGet]
    [Route("api/book/find/{bookId}")]
    public async Task<Book> FindBook(string bookId)
    {
        return await _bookService.FindBook(bookId);
    }

}
