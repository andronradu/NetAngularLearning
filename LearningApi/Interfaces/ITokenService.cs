using LearningApi.Entities;

namespace LearningApi.Interfaces
{
    public interface ITokenService
    {
        string CreateToken(AppUser user);
    }
}