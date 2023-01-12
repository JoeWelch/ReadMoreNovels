using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace ReadMoreApi.DBModels;

public class DBFriend{
    [Column("friendid")]
    public int FriendID{get; set;}
    [Column("userid")]
    public int UserID{get; set;}
    [Column("frienduserid")]
    public int FriendUserID{get; set;}
}
