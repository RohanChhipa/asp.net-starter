using Domain.Dtos;
using Domain.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace WebAPI.V1.Controllers;

[ApiController]
[Route("[controller]")]
public class UserController : ControllerBase
{
    private readonly IUserService _userService;

    public UserController(IUserService userService)
    {
        _userService = userService;
    }
    
    [HttpGet]
    public async Task<IEnumerable<UserDto>> GetUsers(CancellationToken cancellationToken)
    {
        return await _userService.GetUsersAsync(cancellationToken);
    }
}