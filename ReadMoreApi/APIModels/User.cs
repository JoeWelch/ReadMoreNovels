using System;
using System.Collections.Generic;

namespace ReadMoreApi.APIModels;

public class User{
    public int UserID{get; set;}
    public string DisplayName {get; set;}
    public string EmailAddress{get; set;}
    public DateTime CreatedDate{get; set;}
}


