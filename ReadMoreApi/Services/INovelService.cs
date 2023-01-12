using System.Collections.Generic;
using System.Threading.Tasks;
using ReadMoreApi.APIModels;

namespace ReadMoreApi.Services;

public interface INovelService
{
    // User functions
    Task<User> LoginUser(string emailName);
    Task<User> ModifyUser(int userId, User user);
    Task<int> DeleteUser(int userId);
    Task<User> GetUser(int userId);
    Task<List<User>> FindUsers(string emailName, string name);
    
    // Friend functions
    List<User> GetFriends(int userId);
    Task<int> AddFriend(int userId, int friendId);
    Task<int> RemoveFriend(int userId, int friendId);

    // Goal functions


    // Book functions
    Book SetBookStatus(int bookId, int userId, Book book);
    Book GetBookStatus(int bookId, int userId);
    List<Book> GetUserBooks(int userId);

    // Book Detail functions (calls external service)
    Task<BookDetail> GetBookDetail(int bookId);
    Task<List<BookDetail>> SearchBookDetails(string authorFilter, string titleFilter);
}