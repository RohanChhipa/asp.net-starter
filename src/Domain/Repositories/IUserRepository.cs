using Domain.Models;

namespace Domain.Repositories;

public interface IUserRepository
{
    Task<IEnumerable<User>> GetUsersAsync(CancellationToken cancellationToken);
}