﻿using DDD.PatientDetails.Application.API.Commands;
using DDD.PatientDetails.Domain.Interfaces.Services;
using DDD.PatientDetails.Infrastructure.Models;
using MediatR;

namespace DDD.PatientDetails.Application.API.Handler
{
    public class UpdateUserHandler : IRequestHandler<UpdateUserCommand,User>
    {
        private IUserService _userService;
        public UpdateUserHandler(IUserService userService)
        {
            _userService = userService;
        }

        public async Task<User> Handle(UpdateUserCommand request, CancellationToken cancellationToken)
        {
            return await _userService.UpdateUser(request.id,request.user);
        }
    }
}
