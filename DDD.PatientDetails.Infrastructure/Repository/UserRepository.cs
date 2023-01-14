using DDD.PatientDetails.Domain.Interfaces.Repository;
using DDD.PatientDetails.Infrastructure.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DDD.PatientDetails.Infrastructure.Repository
{
    public class UserRepository : IUserRepository
    {
        private userDbContext _userContext;
        public UserRepository(userDbContext userContext)
        {
            _userContext = userContext;
        }
        public async Task<List<User>> GetAllUser()
        {
            return await _userContext.Users.ToListAsync();
        }
        public async Task<User> AddUser(User user)
        {
            _userContext.Add(user);
            var result = await _userContext.SaveChangesAsync();
            if (result > 0) return user;
            else throw new Exception("failed");
        }

        public async Task<User> GetUserById(int id)
        {
            return await _userContext.Users.FindAsync(id);
        }

        public async Task<User> UpdateUser(int id, User user)
        {
            _userContext.Entry(user).State = EntityState.Modified;
            var result = await _userContext.SaveChangesAsync();
            if (result > 0) return user;
            else throw new Exception("failed");
        }
        public async Task<List<User>> DeleteUser(int id)
        {
            var result = await GetUserById(id);
            _userContext.Users.Remove(result);
            _userContext.SaveChanges();
            if (result != null)
            {
                return await GetAllUser();
            }
            else throw new Exception("failed");
        }
    }
}
