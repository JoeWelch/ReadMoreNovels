using System;

namespace ReadMoreApi.DBModels;

public class DBBook{
    public int BookID{get; set;}
    public int UserID{get; set;}
    public string ExternalID{get; set;}
    public string Title{get; set;}
    public string Author {get; set;}
    public Boolean IsCompleted {get; set;}
    public DateTime CompletedDate {get; set;}
    public Boolean IsWishlist {get; set;}
    public int Rating{get; set;}
    public string Review{get; set;}
    public DateTime CreatedDate{get; set;}
}
