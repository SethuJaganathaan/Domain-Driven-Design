using DDD.PatientDetails.Infrastructure.Models;
using MediatR;

namespace DDD.PatientDetails.Application.API.Commands
{
    public record UpdateUserCommand(int id, User user) : IRequest<User>;
}
