using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace ReadMoreApi.DBModels;

public class DBUser{
    [Column("userid")]
    public int UserID{get; set;}
    [Column("displayname")]
    public string DisplayName {get; set;}

    [Column("emailaddress")]
    public string EmailAddress{get; set;}
    [Column("createddate")]
    public DateTime CreatedDate{get; set;}
}


