using System.Text.Json;
using Microsoft.AspNetCore.Mvc;

using BookApi.Models;
using System.Text.Json.Nodes;

namespace BookApi.Services;

public class BookService : IBookService
{
    private HttpClient _httpClient = new HttpClient();

    public async Task<List<Book>> SearchBooks(string authorFilter, string titleFilter)
    {
        var filters = (authorFilter.Length > 0) ? $"+inauthor:{authorFilter}" : "";
        filters += (titleFilter.Length > 0) ? $"+intitle:{titleFilter}" : "";
        if (filters.Length > 0)
            filters = filters.Substring(1);

        if (filters.Length == 0)
            throw new Exception("Search Books requires either authorFilter or titleFilter");

        var getUrl = $"{GlobalEnv.GOOGLE_URL}/volumes?q={filters}&key={GlobalEnv.GOOGLE_API_KEY}";
        var jsonData = await _httpClient.GetStringAsync(getUrl);

        var bookList = new List<Book>();

        var document = JsonNode.Parse(jsonData);
        var root = document.Root;
        var bookArray = root["items"];
        if (bookArray != null)
        {
            foreach (JsonNode volume in bookArray.AsArray())
            {
                var book = PopulateFromJson(volume);
                bookList.Add(book);
            }
        }

        return bookList;
    }

    public async Task<Book> FindBook(string bookId)
    {
        var getUrl = $"{GlobalEnv.GOOGLE_URL}/volumes/{bookId}";
        var jsonData = await _httpClient.GetStringAsync(getUrl);
        var document = JsonNode.Parse(jsonData);
        var volume = document.Root;
        var book = PopulateFromJson(volume);
        return book;
    }

    private Book PopulateFromJson(JsonNode volume)
    {
        var jsonBook = volume["volumeInfo"];
        Book book = new Book();

        book.Id = ((string)volume["id"]);

        book.Author = jsonBook["authors"]?.AsArray().Deserialize<List<string>>();
        book.Category = jsonBook["categories"]?.AsArray().Deserialize<List<string>>();
        book.Description = (string) jsonBook["description"];
        book.Title = (string) jsonBook["title"];

        return book;
    }
}

