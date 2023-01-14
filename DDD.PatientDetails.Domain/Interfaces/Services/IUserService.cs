using DDD.PatientDetails.Infrastructure.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DDD.PatientDetails.Domain.Interfaces.Services
{
    public interface IUserService
    {
        Task<List<User>> GetAllUser();
        Task<User> AddUser(User user);
        Task<User> GetUserById(int id);
        Task<User> UpdateUser(int id,User user);
        Task<List<User>> DeleteUser(int id);
    }
}
