namespace Foodie.Application.Services.Auth
{
    public record AuthResponse(
        string FirstName,
        string LastName,
        string Email,
        string Token,
        Guid Guid
    );
}