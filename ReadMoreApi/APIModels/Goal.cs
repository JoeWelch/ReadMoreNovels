using System;

namespace READMOREAPI.APIModels
{
    public class Goal{
        //public int GoalID{get; set;}
        //public int UserID{get; set;}
        public int TargetNumber{get; set;}
        public DateTime GoalEndDate{get; set;}
        public int BooksCompleted{get; set;}
        public Boolean IsCompleted{get; set;}
        public DateTime CompletedDate{get; set;}
        public DateTime CreatedDate{get; set;}
    }
}


