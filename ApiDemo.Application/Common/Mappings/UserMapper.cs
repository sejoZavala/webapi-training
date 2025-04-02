using ApiDemo.Domain.Entities;
using ApiDemo.Application.Features.Users.DTOs;
using Riok.Mapperly.Abstractions;

namespace ApiDemo.Application.Common.Mappings;

[Mapper]
public partial class UserMapper
{
    [MapperIgnoreSource(nameof(User.Email))]
    public partial UserDto ToDto(User user);
    public partial List<UserDto> ToDtoList(List<User> users);

}