using System.Collections.Generic;
using Logic.DTO;

namespace Logic.Managers.Interfaces
{
    public interface IUser
    {
        void AddUser(string login, string password);
        int CheckUser(string login, string password);
        UserDTO GetInfoUser(int id);
        void EditUser(UserDTO userDTO);
        List<UserDTO> GetIAllInfoUser();
    }
}
