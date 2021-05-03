using System.Threading.Tasks;
using BackEnd.Entities;

namespace Interfaces
{
    public interface ITokenService
    {
        Task<string> CreateToken(ApiUser user);
    }
}