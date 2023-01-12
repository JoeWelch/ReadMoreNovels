using System;
using Microsoft.EntityFrameworkCore;
using READMOREAPI.DBModels;

namespace READMOREAPI.Database
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options): base(options)
        {}        
        public DbSet<DBUser> Users{get; set;}
        public DbSet<DBGoal> Goals{get; set;}
        public DbSet<DBFriends> Friends{get; set;}
        public DbSet<DBBook> Books{get; set;}

    

    protected override void OnModelCreating(ModelBuilder modelBuilder)

        {

            modelBuilder.Entity<DBUser>()
                .ToTable("users").HasKey(nameof(DBUser.Email));

             modelBuilder.Entity<DBGoal>()

                .ToTable("goal").HasKey(nameof(DBGoal.GoalID));

            modelBuilder.Entity<DBFriends>()

                .ToTable("friends").HasKey(nameof(DBFriends.FriendID));

            modelBuilder.Entity<DBBook>()

                .ToTable("books").HasKey(nameof(DBBook.BookID));
        }
    }
}