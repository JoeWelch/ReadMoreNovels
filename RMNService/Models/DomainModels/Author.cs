// just sketching out ideas here, no need to keep these models if the end up not being what we want

namespace ReadMoreNovels.Models.DomainModels
{
    public class Author
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Bio { get; set; }
        public string ImageUrl { get; set; }
        public string CreatedAt { get; set; }
        public string UpdatedAt { get; set; }
    }
}