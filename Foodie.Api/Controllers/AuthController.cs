using Foodie.Application.Services.Auth;
using Foodie.Contracts.Authentication;
using Microsoft.AspNetCore.Mvc;

namespace Foodie.Api.Authentication{

    [ApiController]
    [Route("[controller]")]
    public class AuthController : ControllerBase{

        private readonly IAuthService authService;

        public AuthController(IAuthService authService)
        {
            this.authService = authService;
        }

        [HttpPost("register")]
        public IActionResult Register(RegisterRequest request){
            var authResut = authService.Register(new AuthRequest(
                request.FirstName,
                request.LastName,
                request.Email,
                request.Password
            ));

            return Ok(new AuthResponse(
                authResut.FirstName,
                authResut.LastName,
                authResut.Email,
                authResut.Token,
                authResut.Guid
            ));
        }

        [HttpPost("login")]
        public IActionResult Login(LoginRequest request){

            var loginResult = authService.Login(
                request.Email,
                request.Password
            );

            return Ok(new AuthResponse(
                loginResult.FirstName,
                loginResult.LastName,
                loginResult.Email,
                loginResult.Token,
                loginResult.Guid
            ));
        }
    }
}