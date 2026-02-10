using MyfirstApp.Model;

namespace MyfirstApp.services.Intersface
{
    public interface IUserService
    {
        UserDto GetUserById(int id);
        List<UserDto> GetAllUsers();
    }
}