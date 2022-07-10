namespace Foodie.Application.Services.Auth
{
    public interface IAuthService
    {
         AuthResponse Login(string email, string password);

         AuthResponse Register(AuthRequest request);
    }
}