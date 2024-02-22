using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using BookService.ApiModels;

namespace BookService.Services{

    public interface IBookService
    {
        List<Book> BookSearch(string query);
        Book GetBook(int id);
    
    }
}