using DDD.PatientDetails.Infrastructure.Models;
using MediatR;

namespace DDD.PatientDetails.Application.API.Commands
{
    public record AddUserCommand(User user) : IRequest<User>;
}
