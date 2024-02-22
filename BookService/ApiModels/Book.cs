namespace BookService.ApiModels{
    public class Book
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Author { get; set; }
        public int Year { get; set; }
        public string Publisher { get; set; }
        public string PublishedDate { get; set; }
        public string Description { get; set; }
        public int PageCount { get; set; }
        public string Genre { get; set; }
        public string SmallThumbnail { get; set; }
        public string Thumbnail { get; set; }
        public string Language { get; set; }
        public string ISBN_13 { get; set; }
        public string ISBN_10 { get; set; }
        public string SearchInfo { get; set; }
    }
}
