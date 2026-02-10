using MyfirstApp.Model;
using MyfirstApp.services.Intersface;

namespace MyfirstApp.services
{
    public class UserService : IUserService
    {
        private static readonly List<UserDto> _users = new()
        {
            new UserDto{Id = 1, Name = "Harsh"},
            new UserDto{Id = 2, Name = "Demo"}
        };

        public UserDto GetUserById(int id)
        {
            return _users.FirstOrDefault(user => user.Id == id);

        }
        public List<UserDto> GetAllUsers()
        {
            return _users;
        }
    }
}