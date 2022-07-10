namespace Foodie.Application.Services.Auth
{
    public class AuthService : IAuthService
    {
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
            return new AuthResponse(
                request.FirstName,
                request.LastName,
                request.Email,
                request.FirstName + "token",
                new Guid()
            );
        }
    }
}