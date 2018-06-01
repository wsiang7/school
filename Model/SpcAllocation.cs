using System;
using System.Collections.Generic;

namespace school.Model
{
    public partial class SpcAllocation
    {
        public int Budgetjobid { get; set; }
        public string Costcenterid { get; set; }
        public string Costcenterdesc { get; set; }
        public string Subsegmentid { get; set; }
        public string Functionid { get; set; }
        public decimal? Rmx1 { get; set; }
        public decimal? Rmx2 { get; set; }
        public decimal? Rmx3 { get; set; }
        public decimal? Agg1 { get; set; }
        public decimal? Agg2 { get; set; }
        public decimal? Agg3 { get; set; }
        public decimal? Cop1 { get; set; }
        public decimal? Cop2 { get; set; }
        public decimal? Cop3 { get; set; }
        public string Createdby { get; set; }
        public DateTime? Createddate { get; set; }
        public string Modifiedby { get; set; }
        public DateTime? Modifieddate { get; set; }
        public bool? Isdeleted { get; set; }
    }
}
