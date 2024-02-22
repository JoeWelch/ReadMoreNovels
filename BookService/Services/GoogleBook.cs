using System.Text.Json;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using BookService.ApiModels;


namespace BookService.Services
{
    public class GoogleBook : IGoogleBook
    {
        public Book GetBook(int id)
        {
            return new Book
            {
                Id = id,
                Title = "The Hobbit",
                Author = "J.R.R. Tolkien",
                Year = 1937,
                Publisher = "Allen & Unwin",
                PublishedDate = "1937-09-21",
                Description = "The Hobbit, or There and Back Again, is a children's fantasy novel by English author J. R. R. Tolkien. It was published on 21 September 1937 to wide critical acclaim, being nominated for the Carnegie Medal and awarded a prize from the New York Herald Tribune for best juvenile fiction. The book remains popular and is recognized as a classic in children's literature.",
                PageCount = 310,
                Genres = ["Fantasy"],
                SmallThumbnail = "https://books.google.com/books/content?id=9f1oAAAAMAAJ&printsec=frontcover&img=1&zoom=5&edge=curl&source=gbs_api",
                Thumbnail = "https://books.google.com/books/content?id=9f1oAAAAMAAJ&printsec=frontcover&img=1&zoom=1&edge=curl&source=gbs_api",
                Language = "en",
                ISBN_13 = "9780547928227",
                ISBN_10 = "054792822X",
                SearchInfo = "The Hobbit"
            };
        }

        public List<Book> BookSearch(string query)
        {
            return new List<Book>
            {
                new Book
                {
                    Id = 1,
                    Title = "The Hobbit",
                    Author = "J.R.R. Tolkien",
                    Year = 1937,
                    Publisher = "Allen & Unwin",
                    PublishedDate = "1937-09-21",
                    Description = "The Hobbit, or There and Back Again, is a children's fantasy novel by English author J. R. R. Tolkien. It was published on 21 September 1937 to wide critical acclaim, being nominated for the Carnegie Medal and awarded a prize from the New York Herald Tribune for best juvenile fiction. The book remains popular and is recognized as a classic in children's literature.",
                    PageCount = 310,
                    Genres = ["Fantasy"],
                    SmallThumbnail = "https://books.google.com/books/content?id=9f1oAAAAMAAJ&printsec=frontcover&img=1&zoom=5&edge=curl&source=gbs_api",
                    Thumbnail = "https://books.google.com/books/content?id=9f1oAAAAMAAJ&printsec=frontcover&img=1&zoom=1&edge=curl&source=gbs_api",
                    Language = "en",
                    ISBN_13 = "9780547928227",
                    ISBN_10 = "054792822X",
                    SearchInfo = "The Hobbit"
                }
            };
        }

        
    }
}