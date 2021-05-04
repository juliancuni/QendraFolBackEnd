using BackEnd.Entities;

namespace BackEnd.Interfaces
{
    public interface IBulkCreateReportRepository
    {
        void CreateBulkReport(BulkCreateReport bulk);
    }
}