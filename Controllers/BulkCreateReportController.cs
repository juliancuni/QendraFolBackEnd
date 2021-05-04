using BackEnd.Entities;
using BackEnd.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace BackEnd.Controllers
{
    public class BulkCreateReportController : BaseController
    {
        private readonly IBulkCreateReportRepository _repository;
        public BulkCreateReportController(IBulkCreateReportRepository repository)
        {
            this._repository = repository;
        }

        [HttpPost]
        public ActionResult CreateBulkReport(BulkCreateReport bulkCreateReport)
        {
            _repository.CreateBulkReport(bulkCreateReport);
            return Ok();
        }
    }
}