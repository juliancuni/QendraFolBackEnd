using System.Collections.Generic;
using System.Threading.Tasks;
using BackEnd.Entities;
using BackEnd.Interfaces;
using Data;

namespace BackEnd.Data.Repositories
{
    public class OldCeshtjaRepository : IOldCeshtjaRepository
    {
        private readonly DataContext _dataContext;
        public OldCeshtjaRepository(DataContext dataContext)
        {
            this._dataContext = dataContext;
        }

        public async Task<bool> CreateOldCeshtjaAsync(OldCeshtja oldCeshtja)
        {
            throw new System.NotImplementedException();
        }

        public Task<IEnumerable<OldCeshtja>> GetOldCeshtjaAsync()
        {
            throw new System.NotImplementedException();
        }

        public Task<OldCeshtja> GetOldCeshtjaByIdAsync(int id)
        {
            throw new System.NotImplementedException();
        }

        public Task<bool> SaveAllOlDCeshtjaAsync(IEnumerable<OldCeshtja> oldCeshtjet)
        {
            throw new System.NotImplementedException();
        }
    }
}