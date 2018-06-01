using System;
using System.Collections.Generic;

namespace school.Model
{
    public partial class AdditionalInfo
    {
        public string Filename { get; set; }
        public string Title { get; set; }
        public string Notes { get; set; }
        public string Createdby { get; set; }
        public DateTime? Createddate { get; set; }
        public string Modifiedby { get; set; }
        public DateTime? Modifieddate { get; set; }
        public bool? Isdeleted { get; set; }
    }
}
