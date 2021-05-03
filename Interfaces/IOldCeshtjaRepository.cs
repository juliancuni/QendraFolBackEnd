using System.Collections.Generic;
using System.Threading.Tasks;
using BackEnd.Entities;

namespace BackEnd.Interfaces
{
    public interface IOldCeshtjaRepository
    {
        Task<IEnumerable<OldCeshtja>> GetOldCeshtjaAsync();
        Task<OldCeshtja> GetOldCeshtjaByIdAsync(int id);
        Task<bool> SaveAllOlDCeshtjaAsync(IEnumerable<OldCeshtja> oldCeshtjet);
        Task<bool> CreateOldCeshtjaAsync(OldCeshtja oldCeshtja);

    }
}