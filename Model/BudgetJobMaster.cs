using System;
using System.Collections.Generic;

namespace school.Model
{
    public partial class BudgetJobMaster
    {
        public int Id { get; set; }
        public int Revision { get; set; }
        public string Description { get; set; }
        public int? Year { get; set; }
        public bool? Year1 { get; set; }
        public bool? Year2 { get; set; }
        public bool? Year3 { get; set; }
        public string Status { get; set; }
        public string Createdby { get; set; }
        public DateTime? Createddate { get; set; }
        public string Modifiedby { get; set; }
        public DateTime? Modifieddate { get; set; }
        public bool? Isdeleted { get; set; }
        public string Rmxdistother0 { get; set; }
        public string Rmxdistother1 { get; set; }
        public string Rmxdistother2 { get; set; }
        public string Rmxdistother3 { get; set; }
        public string Rmxdistother4 { get; set; }
        public string Rmxdistother5 { get; set; }
        public string Rmxdistother6 { get; set; }
        public string Rmxdistother7 { get; set; }
        public string Rmxdistother8 { get; set; }
        public string Rmxdistother9 { get; set; }
    }
}
