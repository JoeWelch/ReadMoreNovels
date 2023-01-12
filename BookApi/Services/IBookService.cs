using BookApi.Models;

namespace BookApi.Services;

public interface IBookService {
    Task<List<Book>> SearchBooks(string authorFilter, string titleFilter);
    Task<Book> FindBook(string bookId);
}