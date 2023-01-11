using System.Text.Json;
using Microsoft.AspNetCore.Mvc;

using BookApi.Models;
using System.Text.Json.Nodes;

namespace BookApi.Services;

public class BookService : IBookService
{
    private HttpClient _httpClient = new HttpClient();

    public async Task<List<Book>> SearchBooks(string author)
    {
        var getUrl = $"{GlobalEnv.GOOGLE_URL}/volumes?q=inauthor:{author}&key={GlobalEnv.GOOGLE_API_KEY}";
        var jsonData = await _httpClient.GetStringAsync(getUrl);

        var bookList = new List<Book>();

        var document = JsonNode.Parse(jsonData);
        var root = document.Root;
        var bookArray = root["items"];
        foreach (JsonNode volume in bookArray!.AsArray())
        {
            var jsonBook = volume["volumeInfo"];
            Book book = new Book();

            book.Id = ((string)volume["id"]);
            // book.Author = volume["authors"];
            book.Description = (string) jsonBook["description"];
            
            
            // jsonVolume.GetProperty("id").GetString();
            // book.Author = jsonBook.GetProperty("authors").Deserialize<List<string>>();
            // book.Category = jsonBook.GetProperty("categories").Deserialize<List<string>>();

            // string description = "No description available";
            // jsonBook.TryGetProperty("description", out description)

            // book.Description = jsonBook.GetProperty("description").GetString();
            // book.Title = jsonBook.GetProperty("title").GetString();

            bookList.Add(book);
        }

        return bookList;
    }
}

