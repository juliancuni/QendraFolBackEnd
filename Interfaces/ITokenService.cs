using System.Threading.Tasks;
using BackEnd.Entities;

namespace BackEnd.Interfaces
{
    public interface ITokenService
    {
        Task<string> CreateToken(ApiUser user);
    }
}