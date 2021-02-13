using System;
using System.Collections.Generic;
using System.Text;
using OA.Data;

namespace OA.Service
{
    public interface IUserProfileService
    {
        UserProfile GetUserProfile(int id);
    }
}
