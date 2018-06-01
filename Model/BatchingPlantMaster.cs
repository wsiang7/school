using System;
using System.Collections.Generic;

namespace school.Model
{
    public partial class BatchingPlantMaster
    {
        public string Id { get; set; }
        public string Description { get; set; }
        public string Type { get; set; }
        public string Prodcostcenterid { get; set; }
        public string Distcostcenterid { get; set; }
        public int? Regionid { get; set; }
        public string Createdby { get; set; }
        public DateTime? Createddate { get; set; }
        public string Modifiedby { get; set; }
        public DateTime? Modifieddate { get; set; }
        public bool? Isdeleted { get; set; }
        public string Cementregionid { get; set; }
    }
}
