using System.Collections.Generic;
using System.Threading.Tasks;
using DTOs;
using Entities;

namespace Interfaces
{
    public interface IUserRepository
    {
        void Update(ApiUser user);
        Task<bool> SaveAllAsync();
        Task<IEnumerable<ApiUser>> GetUsersAsync();
        Task<ApiUser> GetUserByIdAsync(int id);
        Task<ApiUser> GetUserByUserNameAsync(string username);
        Task<IEnumerable<MemberDto>> GetMembersAsync();
        Task<MemberDto> GetMemberByIdAsync(int id);
        Task<MemberDto> GetMemberByUsernameAsync(string username);
    }
}