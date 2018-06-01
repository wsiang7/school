using System;
using System.Collections.Generic;

namespace school.Model
{
    public partial class BudgetJobHeader
    {
        public int Budgetjobid { get; set; }
        public string Costcenterid { get; set; }
        public int? Year { get; set; }
        public int? Revision { get; set; }
        public string Description { get; set; }
        public string Costcenterdescription { get; set; }
        public string Subsegmentid { get; set; }
        public string Functionid { get; set; }
        public string Cat1 { get; set; }
        public string Cat2 { get; set; }
        public string Cat3 { get; set; }
        public string Cat4 { get; set; }
        public string Cat5 { get; set; }
        public string Cat6 { get; set; }
        public string Cat7 { get; set; }
        public string Cat8 { get; set; }
        public string Cat9 { get; set; }
        public string Cat10 { get; set; }
        public string Createdby { get; set; }
        public DateTime? Createddate { get; set; }
        public string Modifiedby { get; set; }
        public DateTime? Modifieddate { get; set; }
        public bool? Isdeleted { get; set; }
    }
}
