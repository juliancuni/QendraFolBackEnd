using Entities;

namespace Interfaces
{
    public interface ITokenService
    {
        string CreateToken(ApiUser user);
    }
}