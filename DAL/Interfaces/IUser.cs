using DAL.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Interfaces
{
    public interface IUser
    {
        Task<User> Adduser(string username, string emailAddress, string password, int authLevelId);

        Task<List<User>> GetAllUsers();
    }
}
