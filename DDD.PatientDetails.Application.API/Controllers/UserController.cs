using DDD.PatientDetails.Application.API.Commands;
using DDD.PatientDetails.Application.API.Queries;
using DDD.PatientDetails.Domain.Interfaces.Services;
using DDD.PatientDetails.Infrastructure.Models;
using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace DDD.PatientDetails.Application.API.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private IMediator _mediator;
        public UserController(IMediator mediator)
        {
            _mediator = mediator;
        }
        [HttpGet]
        public async Task<List<User>> GetAllUser()
        {
            return await _mediator.Send(new GetAllUserQuery());
        }
        [HttpPost("Add")]
        public async Task<User> AddUser(User user)
        {
            return await _mediator.Send(new AddUserCommand(user));
        }
        [HttpGet("Id")]
        public async Task<User> GetByUserId(int id)
        {
            return await _mediator.Send(new GetUserByIdQuery(id));
        }
        [HttpPut("UpdateUser")]
        public async Task<User> UpdateUser(int id, User user)
        {
            return await _mediator.Send(new UpdateUserCommand(id,user));
        }
        [HttpDelete]
        public async Task<List<User>> DeleteUser(int id)
        {
            return await _mediator.Send(new DeleteUserCommand(id));
        }
    }
}
