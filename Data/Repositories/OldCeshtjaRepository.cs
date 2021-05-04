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

        public async Task<BulkCreateReport> BulkCreateOldCeshtjeAsync(IEnumerable<OldCeshtja> oldCeshtjet)
        {
            var report = new BulkCreateReport();
            report.ImportFailedIds = new List<int> { };
            report.NrImportFailure = 0;
            report.NrImportSuccess = 0;
            report.User = "";
            foreach (OldCeshtja oldCeshtja in oldCeshtjet)
            {
                var findResult = await _context.OldCeshtja.FirstOrDefaultAsync(
                        o =>
                        o.OldId == oldCeshtja.OldId &&
                        o.Emri == oldCeshtja.Emri &&
                        o.Mbiemri == oldCeshtja.Mbiemri &&
                        o.Data_e_ngjarjes == oldCeshtja.Data_e_ngjarjes
                    );
                if (findResult != null)
                {
                    report.NrImportFailure += 1;
                    report.ImportFailedIds.Add(findResult.OldId);
                }
                else
                {
                    report.NrImportSuccess += 1;
                    _context.OldCeshtja.Add(oldCeshtja);

                }
            }
            await _context.SaveChangesAsync();

            return report;
        }

        public async Task<IEnumerable<OldCeshtja>> GetOldCeshtjetAsync()
        {
            return await _context.OldCeshtja.ToListAsync();
        }

        public async Task<OldCeshtja> GetOldCeshtjaByIdAsync(int id)
        {
            return await _context.OldCeshtja.FindAsync(id);
        }

        public async Task<bool> SaveAllAsync()
        {
            return await _context.SaveChangesAsync() > 0;
        }

        public void UpdateOldCeshtja(OldCeshtja oldCeshtja)
        {
            _context.OldCeshtja.Update(oldCeshtja);
            _context.SaveChanges();
        }

        public void DeleteOldCeshtja(OldCeshtja oldCeshtja)
        {
            _context.OldCeshtja.Remove(oldCeshtja);
            _context.SaveChanges();
        }

        public async Task<OldCeshtja> CreateOldCeshtjaAsync(OldCeshtja oldCeshtja)
        {
            var result = await _context.OldCeshtja.AddAsync(oldCeshtja);
            await _context.SaveChangesAsync();
            return oldCeshtja;
        }
    }
}