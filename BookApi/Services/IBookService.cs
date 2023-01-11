using BookApi.Models;

namespace BookApi.Services;

public interface IBookService {
    Task<List<Book>> SearchBooks(string author);
}