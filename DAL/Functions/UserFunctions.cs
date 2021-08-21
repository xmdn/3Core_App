using DAL.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using DAL.DataContext;
using DAL.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace DAL.Functions
{
    public class UserFunctions: IUser
    {
        public async Task<User> Adduser(string username, string emailAddress, string password, int authLevelId)
        {
            User newUser = new User
            {
                Email = emailAddress,
                Password = password,
                Username = username,
                AuthLevelRefId = authLevelId
            };
            using (var context = new DatabaseContext(DatabaseContext.ops.dbOptions))
            {
                await context.User.AddAsync(newUser);
                await context.SaveChangesAsync();
            }
            return newUser;
        }

        public async Task<List<User>> GetAllUsers()
        {
            List<User> users = new List<User>();
            using (var context = new DatabaseContext(DatabaseContext.ops.dbOptions))
            {
                users = await context.User.ToListAsync();
            }
            return users;
        }
    }
}
