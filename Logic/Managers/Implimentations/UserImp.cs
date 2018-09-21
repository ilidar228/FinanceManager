using Logic.DTO;
using Logic.Managers.Interfaces;
using Storage;
using System.Collections.Generic;
using System.Linq;
using Storage.Models;

namespace Logic.Managers.Implimentations
{
    public class UserImp : IUser
    {
        private readonly Context _db;
        public UserImp(Context context)
        {
            _db = context;
        }

        /// <summary>
        /// Edit user info.
        /// </summary>
        /// <param name="userDTO"></param>
        public void EditUser(UserDTO userDTO)
        {
            var user = _db.User.Find(userDTO.UserId);
            user.Name = userDTO.Name;
            user.Surname = userDTO.Surname;
            user.EMail = userDTO.EMail;
            _db.User.Update(user);
            _db.SaveChanges();
        }

        /// <summary>
        /// gell all users.
        /// </summary>
        /// <returns></returns>
        public List<UserDTO> GetIAllInfoUser()
        {
            var user = _db.User.
                Select(u => new UserDTO
                {
                    UserId = u.UserId,
                    Name = u.Name,
                    Surname = u.Surname,
                    EMail = u.EMail
                }).ToList();
            return user;
        }

        /// <summary>
        /// info about user.
        /// </summary>
        /// <param name="userId"></param>
        /// <returns> Name ,Surname , EMail</returns>
        public UserDTO GetInfoUser(int userId)
        {
            var user = _db.User.Find(userId);
            return new UserDTO { Name = user.Name, Surname = user.Surname, EMail = user.EMail };
        }

        /// <summary>
        /// Registration user
        /// </summary>
        /// <param name="login">some string</param>
        /// <param name="password">sime string</param>
        public void AddUser(string login, string password)
        {
            while (true)
            {
                var userRepeat = _db.User.Where(p => p.Login == login).Select(k => new UserDTO
                {
                    Login = k.Login
                }).ToList();
                if (userRepeat[0].Login != login) break;
            }

            var user = new User()
            {
                Login = login,
                Password = password
            };
            _db.User.Add(user);
            _db.SaveChanges();
        }


        public int CheckUser(string login, string password)
        {
            var user = _db.User.Where(p => p.Login == login && p.Password == password).Select(k => new UserDTO
            {
                Login = k.Login,
                UserId = k.UserId,
                Password = k.Password
            }).ToList();
            if (user[0].Login == "")
                return -1;
            return user[0].UserId;
        }
    }
}
