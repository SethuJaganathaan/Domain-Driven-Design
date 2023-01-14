using DDD.PatientDetails.Domain.Interfaces.Services;
using DDD.PatientDetails.Infrastructure.Models;
using MediatR;

namespace DDD.PatientDetails.Application.API.Queries
{
    public record GetAllUserQuery : IRequest<List<User>>;
}
