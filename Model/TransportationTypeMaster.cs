﻿using System;
using System.Collections.Generic;

namespace school.Model
{
    public partial class TransportationTypeMaster
    {
        public int Id { get; set; }
        public string Description { get; set; }
        public string VehicleType { get; set; }
        public bool? Subcont { get; set; }
        public string Createdby { get; set; }
        public DateTime? Createddate { get; set; }
        public string Modifiedby { get; set; }
        public DateTime? Modifieddate { get; set; }
        public bool? Isdeleted { get; set; }
        public string Costelementid { get; set; }
    }
}
