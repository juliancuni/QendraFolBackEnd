using System;
using System.Collections.Generic;

namespace BackEnd.Entities
{
    public class BulkCreateReport
    {
        public int Id { get; set; }
        public int NrImportSuccess { get; set; }
        public int NrImportFailure { get; set; }
        public List<int> ImportFailedIds { get; set; }
        public string User { get; set; }
        public DateTime DateOfImport { get; set; } = DateTime.Now;
    }
}