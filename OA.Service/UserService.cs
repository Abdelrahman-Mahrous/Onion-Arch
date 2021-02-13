using System;
using System.Collections.Generic;
using System.Text;
using OA.Data;
using OA.Repo;

namespace OA.Service
{
    public class UserService : IUserService
    {
        private IRepository<User> _userRepo;
        private IRepository<UserProfile> _userProfileRepo;

        public UserService(IRepository<User> userRepo, IRepository<UserProfile> userProfileRepo)
        {
            _userRepo = userRepo;
            _userProfileRepo = userProfileRepo;
        }
        public IEnumerable<User> GetUsers()
        {
            return _userRepo.GetAll();
        }
        public User GetUser(int id)
        {
            return _userRepo.Get(id);
        }
        public void InsertUser(User u)
        {
             _userRepo.Insert(u);
        }
        public void UpdateUser(User u)
        {
            _userRepo.Update(u);
        }
        public void DeleteUser(User u)
        {
            var up = _userProfileRepo.Get(u.ID);
            _userProfileRepo.Delete(up);
            _userRepo.Delete(u);
        }      
    }
}
