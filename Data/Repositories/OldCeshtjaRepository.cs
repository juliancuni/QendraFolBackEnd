using System.Collections.Generic;
using System.Threading.Tasks;
using BackEnd.Entities;
using BackEnd.Interfaces;
using BackEnd.Data;
using Microsoft.EntityFrameworkCore;

namespace BackEnd.Data.Repositories
{
    public class OldCeshtjaRepository : IOldCeshtjaRepository
    {
        private readonly DataContext _context;
        public OldCeshtjaRepository(DataContext dataContext)
        {
            this._context = dataContext;
        }

        public bool CreateOldCeshtjaAsync(OldCeshtja oldCeshtja)
        {

            throw new System.NotImplementedException();
        }

        public async Task<IEnumerable<OldCeshtja>> GetOldCeshtjetAsync()
        {
            return await _context.OldCeshtja.ToListAsync();
        }

        public Task<OldCeshtja> GetOldCeshtjaByIdAsync(int id)
        {
            throw new System.NotImplementedException();
        }

        public Task<bool> SaveAllOlDCeshtjaAsync(IEnumerable<OldCeshtja> oldCeshtjet)
        {
            throw new System.NotImplementedException();
        }

        public async Task<bool> SaveAllAsync()
        {
            return await _context.SaveChangesAsync() > 0;
        }
    }
}