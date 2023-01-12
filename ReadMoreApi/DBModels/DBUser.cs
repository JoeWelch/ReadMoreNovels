using System;

namespace READMOREAPI.DBModels
{
    public class DBUser{
        public int UserID{get; set;}
        public string DisplayName {get; set;}
        public string Email{get; set;}
        public DateTime CreatedDate{get; set;}
    }
}


