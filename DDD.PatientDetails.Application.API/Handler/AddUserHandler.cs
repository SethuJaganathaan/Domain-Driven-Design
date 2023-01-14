using DDD.PatientDetails.Application.API.Commands;
using DDD.PatientDetails.Domain.Interfaces.Services;
using DDD.PatientDetails.Infrastructure.Models;
using MediatR;

namespace DDD.PatientDetails.Application.API.Handler
{
    public class AddUserHandler : IRequestHandler<AddUserCommand, User>
    {
        private IUserService _userService;
        public AddUserHandler(IUserService userService)
        {
            _userService = userService;
        }

        public async Task<User> Handle(AddUserCommand request, CancellationToken cancellationToken)
        {
           return await _userService.AddUser(request.user);
        }
    }
}
