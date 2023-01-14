
using DDD.PatientDetails.Domain.Interfaces.Repository;
using DDD.PatientDetails.Domain.Interfaces.Services;
using DDD.PatientDetails.Infrastructure.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DDD.PatientDetails.Domain.Services
{
    public class UserService : IUserService
    {
        private IUserRepository _userRepository;
        public UserService(IUserRepository userRepository)
        {
            _userRepository = userRepository;
        }
        public async Task<List<User>> GetAllUser()
        {
            return await _userRepository.GetAllUser();
        }
        public async Task<User> AddUser(User user)
        {
            return await _userRepository.AddUser(user);
        }

        public async Task<User> GetUserById(int id)
        {
            return await _userRepository.GetUserById(id);
        }

        public Task<User> UpdateUser(int id, User user)
        {
            return _userRepository.UpdateUser(id,user);
        }

        public async Task<List<User>> DeleteUser(int id)
        {
            return await _userRepository.DeleteUser(id);
        }
    }
}
