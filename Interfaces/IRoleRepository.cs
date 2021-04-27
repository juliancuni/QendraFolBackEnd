using System.Collections.Generic;
using System.Threading.Tasks;
using Entities;
using Helpers;

namespace Interfaces
{
    public interface IRoleRepository
    {
        void Update(ApiRole user);
        Task<bool> SaveAllAsync();
        Task<IEnumerable<ApiRole>> GetRolesAsync();
        Task<ApiUser> GetRoleByIdAsync(int id);
        Task<ApiUser> GetRoleByNameAsync(string name);
        void Delete(int id);
    }
}