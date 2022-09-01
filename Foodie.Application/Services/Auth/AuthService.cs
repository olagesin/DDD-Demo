using Foodie.Application.Common.Interfaces.Authentication;

namespace Foodie.Application.Services.Auth
{
    public class AuthService : IAuthService
    {
        private readonly IJwtProvider provider;

        public AuthService(IJwtProvider provider)
        {
            this.provider = provider;
        }

        public AuthResponse Login(string email, string password)
        {
            return new AuthResponse(
                "Firstname",
                "Lasyname",
                email, 
                "token",
                new Guid()
            );
        }

        public AuthResponse Register(AuthRequest request)
        {
            //check if user already exists

            //create user with unique id

            //create JWt

            var userId = Guid.NewGuid();

            var token = provider.GenerateToken(userId, request.FirstName, request.LastName);

            return new AuthResponse(
                request.FirstName,
                request.LastName,
                request.Email,
                token,
                userId
            );
        }
    }
}