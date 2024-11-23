using Application.Dtos.Users;
using Domain.Entity;

namespace Application.Interfaces.Services
{
    public interface IUserServices
    {
        void AddUser(CreatedUserDto user);
        void RemoveUser(int Id);
        void UpdateUser(int Id, CreatedUserDto user);
        IEnumerable<User> GetUsers();
        User GetUser(int Id);
        User GetUser(string UserName);
    }
}
