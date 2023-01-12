using System;
using System.Collections.Generic;

namespace ReadMoreApi.APIModels;

public class BookDetail
{
    public string Id { get; set; }
    public string Title { get; set; }
    public List<string> Author { get; set; }
    public List<string> Category { get; set; }
    public string Description { get; set; }
}
