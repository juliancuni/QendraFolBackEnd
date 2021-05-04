using System.Collections.Generic;
using System.Threading.Tasks;
using BackEnd.Entities;
using BackEnd.Interfaces;
using BackEnd.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Http;
using System.Security.Claims;

namespace BackEnd.Data.Repositories
{
    public class OldCeshtjaRepository : IOldCeshtjaRepository
    {
        private readonly DataContext _context;
        private readonly IHttpContextAccessor _httpContext;
        public OldCeshtjaRepository(IHttpContextAccessor httpContext, DataContext dataContext)
        {
            this._context = dataContext;
            this._httpContext = httpContext;
        }

        public async Task<BulkCreateReport> BulkCreateOldCeshtjeAsync(IEnumerable<OldCeshtja> oldCeshtjet)
        {
            var report = new BulkCreateReport();
            report.ImportFailedIds += "[";
            report.NrImportFailure = 0;
            report.NrImportSuccess = 0;
            report.User = _httpContext.HttpContext.User.FindFirstValue(ClaimTypes.Name);

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
                    report.ImportFailedIds += findResult.OldId.ToString() + ", ";
                }
                else
                {
                    report.NrImportSuccess += 1;
                    _context.OldCeshtja.Add(oldCeshtja);

                }
            }
            report.ImportFailedIds += "]";
            await _context.BulkCreateReport.AddAsync(report);
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