using System.Collections.Generic;
using System.Threading.Tasks;
using BackEnd.DTOs;
using BackEnd.Entities;
using BackEnd.Helpers;

namespace BackEnd.Interfaces
{
    public interface IUserRepository
    {
        void Update(ApiUser user);
        Task<bool> SaveAllAsync();
        Task<IEnumerable<ApiUser>> GetUsersAsync();
        Task<ApiUser> GetUserByIdAsync(int id);
        Task<ApiUser> GetUserByUserNameAsync(string username);
        Task<PagedList<MemberDto>> GetMembersAsync(UserParams userParams);
        Task<MemberDto> GetMemberByIdAsync(int id);
        Task<MemberDto> GetMemberByUsernameAsync(string username);
    }
}