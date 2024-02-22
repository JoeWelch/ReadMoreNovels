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
    [Route("api/book/{id}")]
    public Book GetBook(int id)
    {
        return _bookService.GetBook(id);
    }
    

    [HttpPost]
    [Route("api/book/search")]
    public List<Book> BookSearch([FromBody]string query)
    {
        return _bookService.BookSearch(query);
    }
}
