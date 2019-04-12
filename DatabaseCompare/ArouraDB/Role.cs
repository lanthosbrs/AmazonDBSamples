using System;
using System.Collections.Generic;
using System.Text;

namespace DatabaseCompare.ArouraDB
{
    public class Role : BaseModel
    {
        public string RoleName { get; set; }
        public string RoleId { get; set; }
        public virtual User User { get; set; }
    }
}
