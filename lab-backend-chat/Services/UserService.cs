using lab_backend_chat.Models;

namespace lab_backend_chat.Services;

public class UserService : IUserService
{
    private List<User> users;

    public UserService()
    {
        users = new List<User>();
    }
    
    public void Add(string connectionId, string username)
    {
        users.Add(new User() { ConnectionId = connectionId, Username = username });
    }

    public void RemoveByName(string username)
    {
        var user = users.Find(u => u.Username == username);
        users.Remove(user);
    }

    public string GetConnectionIdByName(string username)
    {
        return users.Find(u => u.Username == username).ConnectionId;
    }

    public IEnumerable<User> GetAll()
    {
        return users;
    }
}