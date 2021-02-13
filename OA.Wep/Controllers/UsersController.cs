using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using OA.Data;
using OA.Service;
using OA.Wep.Models;

namespace OA.Wep.Controllers
{
    public class UsersController : Controller
    {
        private IUserService _userService;
        private IUserProfileService _userProfileService;

        public UsersController(IUserService userService, IUserProfileService userProfileService)
        {
            _userService = userService;
            _userProfileService = userProfileService;
        }

        public IActionResult Index()
        {
            List<UserViewModel> model = new List<UserViewModel>();
            foreach (var u in _userService.GetUsers().ToList())
            {
                UserProfile up = _userProfileService.GetUserProfile(u.ID);
                UserViewModel vm = new UserViewModel()
                {
                    ID = u.ID,
                    UserName = u.UserName,
                    Email = u.Email,
                    FirstName = up.FirstName ,
                     LastName = up.LastName ,
                     Address = up.Address 
                };
                model.Add(vm);
            }  
            return View(model);
        }
        [HttpGet]
        public IActionResult AddUser()
        {
            return View();
        }
        [HttpPost]
        public IActionResult AddUser(UserViewModel model)
        {
            User u = new User()
            {
                UserName = model.UserName,
                Email = model.Email,
                Password = "@123Test",
                IPAddress = Request.HttpContext.Connection.RemoteIpAddress.ToString(),
                CreatedAt = DateTime.UtcNow,
                ModifiedAt = DateTime.UtcNow,
                IsDeleted = false,
                UserProfile = new UserProfile()
                {
                    FirstName = model.FirstName,
                    LastName = model.LastName,
                    Address = model.Address,
                    IPAddress = Request.HttpContext.Connection.RemoteIpAddress.ToString(),
                    CreatedAt = DateTime.UtcNow,
                    ModifiedAt = DateTime.UtcNow,
                    IsDeleted = false
                }
            };
            _userService.InsertUser(u);
            if (u.ID > 0)
            {
                return RedirectToAction("Index");
            }
            return View(model);
        }
        [HttpGet]
        public IActionResult Delete(int id)
        {
            User u= _userService.GetUser(id);           
            _userService.DeleteUser(u);
            return RedirectToAction("Index");
        }
    }
}
