using MedinaStation.Business.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace MedinaStation.API.Controllers;

[ApiController]
[Route("api/[controller]")]
public class AuthController : ControllerBase
{
    private readonly IIdentityService _identityService;

    public AuthController(IIdentityService identityService)
    {
        _identityService = identityService;
    }

    [HttpPost("register")]
    public async Task<IActionResult> Register(RegisterRequest request)
    {
        var token = await _identityService.RegisterAsync(request.Username, request.Password, request.Role);
        if (token is null)
            return BadRequest("Registration failed");

        return Ok(new { token });
    }

    [HttpPost("login")]
    public async Task<IActionResult> Login(LoginRequest request)
    {
        var token = await _identityService.LoginAsync(request.Username, request.Password);
        if (token is null)
            return Unauthorized();

        return Ok(new { token });
    }
}

public record RegisterRequest(string Username, string Password, string Role);
public record LoginRequest(string Username, string Password);