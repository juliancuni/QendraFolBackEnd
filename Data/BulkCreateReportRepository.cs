using BackEnd.Entities;
using BackEnd.Interfaces;

namespace BackEnd.Data
{
    public class BulkCreateReportRepository : IBulkCreateReportRepository
    {
        private readonly DataContext _context;
        public BulkCreateReportRepository(DataContext context)
        {
            this._context = context;
        }

        public void CreateBulkReport(BulkCreateReport bulkReport)
        {
            _context.BulkCreateReport.Add(bulkReport);
        }
    }
}