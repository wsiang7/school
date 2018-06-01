using System;
using System.Collections.Generic;

namespace school.Model
{
    public partial class AggSalesInternal
    {
        public int Budgetjobid { get; set; }
        public int Quarryid { get; set; }
        public string Batchingplantid { get; set; }
        public string Quarrydesc { get; set; }
        public string Batchingplantdesc { get; set; }
        public int? Regionid { get; set; }
        public string Regiondesc { get; set; }
        public decimal? Portionpickedup { get; set; }
        public decimal? Portiondelivered { get; set; }
        public string Createdby { get; set; }
        public DateTime? Createddate { get; set; }
        public string Modifiedby { get; set; }
        public DateTime? Modifieddate { get; set; }
        public bool? Isdeleted { get; set; }
    }
}
