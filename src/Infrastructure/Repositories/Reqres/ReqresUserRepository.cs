using Domain.Models;
using Domain.Repositories;
using Flurl.Http;
using Infrastructure.Repositories.Reqres.Models;

namespace Infrastructure.Repositories.Reqres;

public class ReqresUserRepository : IUserRepository
{
    public async Task<IEnumerable<User>> GetUsersAsync(CancellationToken cancellationToken)
    {
        var response = await "https://reqres.in/api/users"
            .GetJsonAsync<ReqresResponse>(cancellationToken);

        return response.Data
            .Select(user => new User()
            {
                Id = user.Id,
                Avatar = user.Avatar,
                Email = user.Email,
                FirstName = user.FirstName,
                Lastname = user.Lastname
            });
    }
}