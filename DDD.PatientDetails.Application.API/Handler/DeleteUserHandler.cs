using DDD.PatientDetails.Application.API.Commands;
using DDD.PatientDetails.Domain.Interfaces.Services;
using DDD.PatientDetails.Infrastructure.Models;
using MediatR;

namespace DDD.PatientDetails.Application.API.Handler
{
    public class DeleteUserHandler : IRequestHandler<DeleteUserCommand,List<User>>
    {
        private IUserService _userService;
        public DeleteUserHandler(IUserService userService)
        {
            _userService = userService;
        }

        public async Task<List<User>> Handle(DeleteUserCommand request, CancellationToken cancellationToken)
        {
            return await _userService.DeleteUser(request.id);
        }
    }
}
