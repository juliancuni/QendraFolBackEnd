using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace BackEnd.Entities
{
    public class BulkCreateReport
    {
        public int Id { get; set; }
        public int NrImportSuccess { get; set; }
        public int NrImportFailure { get; set; }
        public string ImportFailedIds { get; set; }
        public string User { get; set; }
        public DateTime DateOfImport { get; set; } = DateTime.Now;
    }
}