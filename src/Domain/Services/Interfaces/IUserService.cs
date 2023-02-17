using Domain.Dtos;

namespace Domain.Services.Interfaces;

public interface IUserService
{
    Task<IEnumerable<UserDto>> GetUsersAsync(CancellationToken cancellationToken);
}