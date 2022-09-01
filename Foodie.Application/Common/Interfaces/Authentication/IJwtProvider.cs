namespace Foodie.Application.Common.Interfaces.Authentication;
public interface IJwtProvider{
    string GenerateToken(Guid userId, string FirstName, string LastName);
}