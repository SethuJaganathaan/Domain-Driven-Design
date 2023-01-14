using DDD.PatientDetails.Infrastructure.Models;
using MediatR;

namespace DDD.PatientDetails.Application.API.Queries
{
    public record GetUserByIdQuery(int id) :IRequest<User>;
}
