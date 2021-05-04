using System.Collections.Generic;
using System.Threading.Tasks;
using BackEnd.Entities;

namespace BackEnd.Interfaces
{
    public interface IOldCeshtjaRepository
    {
        Task<IEnumerable<OldCeshtja>> GetOldCeshtjetAsync();
        Task<OldCeshtja> GetOldCeshtjaByIdAsync(int id);
        Task<BulkCreateReport> BulkCreateOldCeshtjeAsync(IEnumerable<OldCeshtja> oldCeshtje);
        Task<OldCeshtja> CreateOldCeshtjaAsync(OldCeshtja oldCeshtja);
        Task<bool> SaveAllAsync();
        void UpdateOldCeshtja(OldCeshtja oldCeshtja);
        void DeleteOldCeshtja(OldCeshtja oldCeshtja);

    }
}