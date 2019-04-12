using System;
using System.Collections.Generic;
using System.Text;

namespace DatabaseCompare.ArouraDB
{
   public abstract class BaseModel
    {
        public DateTime CreatedDate { get; set; }
        public DateTime? ModifiedDate { get; set; }
    }
}
