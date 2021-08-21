using DAL.Entities;
using DAL.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace LOGIC.UserLogic
{
    public class UserLogic
    {
        private IUser _users = new DAL.Functions.UserFunctions();

        public async Task<Boolean> CreateNewUser(string username, string emailAddress, string password, int authLevelId)
        {
            try
            {
                var result = await _users.Adduser(username, emailAddress, password, authLevelId);
                if (result.Id > 0)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch (Exception error)
            {
                return false;
            }
        }
        public async Task<List<User>> GetAllUsers()
        {
            List<User> users = await _users.GetAllUsers();
            return users;
        }
    }
}
