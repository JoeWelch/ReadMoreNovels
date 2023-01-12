using Microsoft.EntityFrameworkCore;
using ReadMoreApi.DBModels;

namespace ReadMoreApi.Database;

public class AppDbContext : DbContext
{
    public AppDbContext(DbContextOptions<AppDbContext> options): base(options)
    {}        
    public DbSet<DBUser> Users {get; set;}
    public DbSet<DBGoal> Goals {get; set;}
    public DbSet<DBFriends> Friends {get; set;}
    public DbSet<DBBook> Books {get; set;}

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<DBUser>()
            .ToTable("users").HasKey(nameof(DBUser.UserID));

        modelBuilder.Entity<DBGoal>()
            .ToTable("goal").HasKey(nameof(DBGoal.GoalID));

        modelBuilder.Entity<DBFriends>()
            .ToTable("friends").HasKey(nameof(DBFriends.FriendID));

        modelBuilder.Entity<DBBook>()
            .ToTable("books").HasKey(nameof(DBBook.BookID));
    }
}
