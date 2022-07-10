namespace Foodie.Application.Services.Auth
{
    public record AuthRequest(
        string FirstName,
        string LastName,
        string Email,
        string Password
    );
}