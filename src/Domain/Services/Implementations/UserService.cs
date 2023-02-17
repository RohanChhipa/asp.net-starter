using Domain.Dtos;
using Domain.Repositories;
using Domain.Services.Interfaces;

namespace Domain.Services.Implementations;

public class UserService : IUserService
{
    private readonly IUserRepository _userRepository;

    public UserService(IUserRepository userRepository)
    {
        _userRepository = userRepository;
    }

    public async Task<IEnumerable<UserDto>> GetUsersAsync(CancellationToken cancellationToken)
    {
        var users = await _userRepository.GetUsersAsync(cancellationToken);
        return users.Select(user => new UserDto
        (
            user.Id,
            user.Email,
            user.FirstName,
            user.Lastname,
            user.Avatar
        ));
    }
}