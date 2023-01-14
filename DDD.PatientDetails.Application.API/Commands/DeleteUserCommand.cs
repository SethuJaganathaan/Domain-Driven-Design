using DDD.PatientDetails.Infrastructure.Models;
using MediatR;

namespace DDD.PatientDetails.Application.API.Commands
{
    public record DeleteUserCommand(int id) : IRequest<List<User>>;
}
