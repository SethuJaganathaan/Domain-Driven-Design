using DDD.PatientDetails.Application.API.Queries;
using DDD.PatientDetails.Domain.Interfaces.Services;
using DDD.PatientDetails.Infrastructure.Models;
using MediatR;

namespace DDD.PatientDetails.Application.API.Handler
{
    public class GetUserByIdHandler : IRequestHandler<GetUserByIdQuery,User>
    {
        private IUserService _userService;
        public GetUserByIdHandler(IUserService userService)
        {
            _userService = userService;
        }

        public async Task<User> Handle(GetUserByIdQuery request, CancellationToken cancellationToken)
        {
            return await _userService.GetUserById(request.id);
        }
    }
}
