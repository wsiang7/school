using System;
using System.Collections.Generic;

namespace school.Model
{
    public partial class UsersDetail
    {
        public string Userid { get; set; }
        public string Costcenterid { get; set; }
        public bool? Readonly { get; set; }
        public string Createdby { get; set; }
        public DateTime? Createddate { get; set; }
        public string Modifiedby { get; set; }
        public DateTime? Modifieddate { get; set; }
        public bool? Isdeleted { get; set; }
    }
}
