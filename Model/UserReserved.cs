using System;
using System.Collections.Generic;

namespace school.Model
{
    public partial class UserReserved
    {
        public string Id { get; set; }
        public string Userid { get; set; }
        public DateTime Effective { get; set; }
        public DateTime Expired { get; set; }
    }
}
