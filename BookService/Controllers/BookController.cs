using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using BookService.Services;
using BookService.ApiModels;
namespace BookService.Controllers;

[ApiController]
[Route("[controller]")]
public class BookController : ControllerBase
{
    

    private readonly ILogger<BookController> _logger;

    private readonly IGoogleBook _bookService;

    public BookController(ILogger<BookController> logger, IGoogleBook bookService)
    {
        _logger = logger;
        _bookService = bookService;
    }
    

    [HttpGet]
    [Route("API/book/{id}")]
    public Book GetBook(int id)
    {
        return _bookService.GetBook(id);
    }
    

    [HttpGet]
    [Route("api/book/search/{query}")]
    public List<Book> BookSearch(string query)
    {
        return _bookService.BookSearch(query);
    }
}
