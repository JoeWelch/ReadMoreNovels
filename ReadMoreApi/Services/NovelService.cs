using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ReadMoreApi.APIModels;
using ReadMoreApi.DBModels;
using ReadMoreApi.Database;
using AutoMapper;
using Microsoft.EntityFrameworkCore;
using System.Net.Http;
using System.Text.Json;

namespace ReadMoreApi.Services;

public class NovelService : INovelService
{
    private readonly AppDbContext _context;
    private readonly IMapper _mapper;
    static HttpClient _httpClient = new HttpClient();

    public NovelService(AppDbContext context, IMapper mapper) 
    {
        _context = context;
        _mapper = mapper;
    }

    // User functions
    public async Task<User> LoginUser(string emailName)
    {
        var user = _context.Users.FirstOrDefault(user => user.EmailAddress.ToLower() == emailName.ToLower());
        if (user == null)
        {
            user = new DBUser{ EmailAddress = emailName };
            _context.Users.Add(user);
            await _context.SaveChangesAsync();
        }
        return _mapper.Map<User>(user);
    }

    public async Task<User> ModifyUser(int userId, User user)
    {
        if ((user.UserID > 0) && (user.UserID != userId))
            throw new System.Exception("User ID in path must match user ID passed in with object");

        user.UserID = userId;
        var dbUser = _mapper.Map<DBUser>(user);
        _context.Users.Update(dbUser);
        await _context.SaveChangesAsync();
        return user;
    }

    public async Task<int> DeleteUser(int userId)
    {
        int recordsModified;
        try {
            _context.Users.Remove(new DBUser { UserID = userId });
            recordsModified = await _context.SaveChangesAsync();
        }
        catch (DbUpdateConcurrencyException) {
            recordsModified = 0;
        }
        return recordsModified;
    }

    public async Task<User> GetUser(int userId)
    {
        var dbUser = await _context.Users.FindAsync(userId);
        if (dbUser == null)
            throw new System.Exception($"Didn't find user {userId}");

        return _mapper.Map<User>(dbUser);
    }

    public Task<List<User>> FindUsers(string emailName, string name)
    {
        List<User> userList = _context.Users
            .Where(u => u.EmailAddress.Contains(emailName) && u.DisplayName.Contains(name))
            .Select(dbUser => _mapper.Map<User>(dbUser)).ToList();

        return Task.FromResult(userList);
    }

    // Friend functions
    public async Task<int> AddFriend(int userId, int friendId)
    {
        int affectRecords = 0;
        var Friend = _context.Friends.FirstOrDefault(f => f.UserID == userId && f.FriendUserID == friendId);
        if (Friend == null)
        {
            _context.Friends.Add(new DBFriend { FriendUserID = friendId, UserID = userId});
            affectRecords = await _context.SaveChangesAsync();
        }
        return affectRecords;
    }

    public List<User> GetFriends(int userId)
    {
        List<int> friends = _context.Friends
            .Where(f => f.UserID == userId)
            .Select(f => f.FriendUserID).ToList<int>();

        var userList = _context.Users
            .Where(user => friends.Contains(user.UserID))
            .Select(dbUser => _mapper.Map<User>(dbUser)).ToList();

        return userList;
    }

    public async Task<int> RemoveFriend(int userId, int friendId)
    {
        int affectRecords = 0;

        var friendToDelete = _context.Friends.FirstOrDefault(f => f.UserID == userId && f.FriendUserID == friendId);
        if (friendToDelete != null)
        {
            _context.Friends.Remove(friendToDelete);
            affectRecords = await _context.SaveChangesAsync();
        }
        return affectRecords;
    }

    public Book GetBookStatus(int bookId, int userId)
    {
        throw new System.NotImplementedException();
    }

    public List<Book> GetUserBooks(int userId)
    {
        throw new System.NotImplementedException();
    }

    public Book SetBookStatus(int bookId, int userId, Book book)
    {
        throw new System.NotImplementedException();
    }

    // Book Detail Apis
    public async Task<List<BookDetail>> SearchBookDetails(string authorFilter, string titleFilter)
    {
        var searchUrl = $"{GlobalEnv.BOOKDETAILURL}/api/book/search?authorFilter={authorFilter}&titleFilter={titleFilter}";
        var jsonResponse = await _httpClient.GetStringAsync(searchUrl);
        List<BookDetail> bookDetails = JsonSerializer.Deserialize<List<BookDetail>>(jsonResponse,  GlobalEnv.jsonOptions);
        return bookDetails;
    }

    public async Task<BookDetail> GetBookDetail(int bookId)
    {
        var findUrl = $"{GlobalEnv.BOOKDETAILURL}/api/book/find/{bookId}";
        var jsonResponse = await _httpClient.GetStringAsync(findUrl);
        BookDetail bookDetail = JsonSerializer.Deserialize<BookDetail>(jsonResponse,  GlobalEnv.jsonOptions);
        return bookDetail;
    }

}
