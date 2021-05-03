using System.Collections.Generic;
using System.Threading.Tasks;
using BackEnd.Entities;
using Interfaces;

namespace Data.Repositories
{
    public class RoleRepository : IRoleRepository
    {
        public RoleRepository()
        {
        }

        public void Delete(int id)
        {
            throw new System.NotImplementedException();
        }

        public Task<ApiUser> GetRoleByIdAsync(int id)
        {
            throw new System.NotImplementedException();
        }

        public Task<ApiUser> GetRoleByNameAsync(string name)
        {
            throw new System.NotImplementedException();
        }

        public Task<IEnumerable<ApiRole>> GetRolesAsync()
        {
            throw new System.NotImplementedException();
        }

        public Task<bool> SaveAllAsync()
        {
            throw new System.NotImplementedException();
        }

        public void Update(ApiRole user)
        {
            throw new System.NotImplementedException();
        }
    }
}