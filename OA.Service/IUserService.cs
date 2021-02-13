using System;
using System.Collections.Generic;
using System.Text;
using OA.Data;

namespace OA.Service
{
    public interface IUserService
    {
        IEnumerable<User> GetUsers();
        User GetUser(int id);
        void InsertUser(User u);
        void UpdateUser(User u);
        void DeleteUser(User u);

    }
}
