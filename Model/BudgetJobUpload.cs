using System;
using System.Collections.Generic;

namespace school.Model
{
    public partial class BudgetJobUpload
    {
        public int Id { get; set; }
        public string Type { get; set; }
        public int Budgetjobid { get; set; }
        public int Budgetjobrevision { get; set; }
        public int Budgetjobyear { get; set; }
        public string Filename { get; set; }
        public string Filepath { get; set; }
        public string Status { get; set; }
        public DateTime? Starttime { get; set; }
        public DateTime? Endtime { get; set; }
        public string Createdby { get; set; }
        public DateTime? Createddate { get; set; }
        public string Modifiedby { get; set; }
        public DateTime? Modifieddate { get; set; }
        public bool? Isdeleted { get; set; }
    }
}
