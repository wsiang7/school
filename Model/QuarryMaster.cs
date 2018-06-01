using System;
using System.Collections.Generic;

namespace school.Model
{
    public partial class QuarryMaster
    {
        public int Id { get; set; }
        public string Description { get; set; }
        public string Createdby { get; set; }
        public DateTime? Createddate { get; set; }
        public string Modifiedby { get; set; }
        public DateTime? Modifieddate { get; set; }
        public bool? Isdeleted { get; set; }
    }
}
