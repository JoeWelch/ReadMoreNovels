using System;

namespace READMOREAPI.DBModels
{
    public class DBFriends{
        public int FriendID{get; set;}
        public int UserID{get; set;}
        public int FriendUserID{get; set;}
        public DateTime CreatedDate{get; set;}
    }
}
