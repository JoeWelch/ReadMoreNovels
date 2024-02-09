// just sketching out ideas here, no need to keep these models if the end up not being what we want

namespace ReadMoreNovels.Models.DomainModels
{
    public class Book
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public Author Author { get; set; }
        public string Genre { get; set; }
        public string Description { get; set; }
        public string ImageUrl { get; set; }
        public string Isbn { get; set; }
        public string Publisher { get; set; }
        public string PublishedDate { get; set; }
        public int PageCount { get; set; }
        public string Language { get; set; }
        public string Country { get; set; }
         public string CreatedAt { get; set; }
        public string UpdatedAt { get; set; }
        public List<string> Tags { get; set;}
    }
}