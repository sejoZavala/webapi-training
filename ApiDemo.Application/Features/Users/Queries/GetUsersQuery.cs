using ApiDemo.Application.Common.Mappings;
using ApiDemo.Application.Features.Users.DTOs;
using ApiDemo.Domain.Entities;
using ApiDemo.Infrastructure.Data;
using MediatR;

namespace ApiDemo.Application.Features.Users.Queries;

public record GetUsersQuery() : IRequest<List<UserDto>>;

public class GetUsersQueryHandler(UserMapper mapper) : IRequestHandler<GetUsersQuery, List<UserDto>>
{
    private readonly UserMapper _mapper = mapper;

    public Task<List<UserDto>> Handle(GetUsersQuery request, CancellationToken cancellationToken)
    {
        return Task.FromResult( _mapper.ToDtoList(InMemoryDb.Users));
    }
}