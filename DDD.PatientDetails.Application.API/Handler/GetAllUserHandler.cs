using DDD.PatientDetails.Application.API.Queries;
using DDD.PatientDetails.Domain.Interfaces.Services;
using DDD.PatientDetails.Infrastructure.Models;
using MediatR;
using Microsoft.EntityFrameworkCore;

namespace DDD.PatientDetails.Application.API.Handler
{
    public class GetAllUserHandler : IRequestHandler<GetAllUserQuery, List<User>>
    {
        private IUserService _userService;
        public GetAllUserHandler(IUserService userService)
        {
            _userService = userService;
        }

        public async Task<List<User>> Handle(GetAllUserQuery request, CancellationToken cancellationToken)
        {
            return await _userService.GetAllUser();
        }
    }
}
