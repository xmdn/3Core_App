using _3Core_App.Models;
using LOGIC.UserLogic;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace _3Core_App.API
{
    [Route("api/user/")]
    [ApiController]
    public class UserAPI_Controller : ControllerBase
    {
        private UserLogic userLogic = new UserLogic();


        [Route("add")]
        [HttpGet]
        public async Task<Boolean> AddUser(string username, string emailAddress, string password, int authLevelId)
        {
            bool result = await userLogic.CreateNewUser(username, emailAddress, password, authLevelId);
            return result;
        }
        [Route("all")]
        [HttpGet]
        public async Task<List<UserViewModel>> GetAllUsers()
        {
            List<UserViewModel> userList = new List<UserViewModel>();
            var users = await userLogic.GetAllUsers();
            if(users.Count>0)
            {
                foreach(var user in users)
                {
                    UserViewModel currentUser = new UserViewModel
                    {
                        AuthLevel = user.AuthLevelRefId,
                        EmailAddress = user.Email,
                        UserId = user.Id,
                        Username = user.Username
                    };
                    userList.Add(currentUser);
                }
            }
            return userList;
        }
    }
}
