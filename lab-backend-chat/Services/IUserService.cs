using lab_backend_chat.Models;

namespace lab_backend_chat.Services;

public interface IUserService
{
    public void Add(string connectionId, string username);
    public void RemoveByName(string username);
    public string GetConnectionIdByName(string username);
    public IEnumerable<User> GetAll();
}