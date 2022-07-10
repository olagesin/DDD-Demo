namespace Foodie.Contracts.Authentication
{
    public record ResponseDto(
        Guid guid,
        string FirstName,
        string LastName,
        string Email, 
        string Token
    );
}