using System;
using System.Collections.Generic;
using System.Text;
using OA.Data;
using OA.Repo;

namespace OA.Service
{
    public class UserProfileService : IUserProfileService
    {
        private IRepository<UserProfile> _userProfileRepo;

        public UserProfileService(IRepository<UserProfile> userProfileRepo)
        {
            _userProfileRepo = userProfileRepo;
        }

        public UserProfile GetUserProfile(int id)
        {
            return _userProfileRepo.Get(id);
        }
    }
}
