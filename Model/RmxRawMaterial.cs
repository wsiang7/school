using System;
using System.Collections.Generic;

namespace school.Model
{
    public partial class RmxRawMaterial
    {
        public int Budgetjobid { get; set; }
        public int Rmxcomponentid { get; set; }
        public string Batchingplantid { get; set; }
        public string Batchingplantdesc { get; set; }
        public string Batchingplanttype { get; set; }
        public string Prodcostcenterid { get; set; }
        public string Distcostcenterid { get; set; }
        public int? Regionid { get; set; }
        public string Regiondesc { get; set; }
        public string Rmxcomponentdescription { get; set; }
        public decimal? VolUsage1 { get; set; }
        public decimal? VolUsage2 { get; set; }
        public decimal? VolUsage3 { get; set; }
        public decimal? CostPrice1 { get; set; }
        public decimal? CostTransport1 { get; set; }
        public decimal? CostPrice2 { get; set; }
        public decimal? CostTransport2 { get; set; }
        public decimal? CostPrice3 { get; set; }
        public decimal? CostTransport3 { get; set; }
        public string Createdby { get; set; }
        public DateTime? Createddate { get; set; }
        public string Modifiedby { get; set; }
        public DateTime? Modifieddate { get; set; }
        public bool? Isdeleted { get; set; }
    }
}
