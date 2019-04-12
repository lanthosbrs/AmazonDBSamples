using System;
using System.Collections.Generic;
using Amazon.DynamoDBv2.DataModel;

namespace DatabaseCompare.ArouraDB
{
   
    public class User : BaseModel
    {     
        public Guid UserId { get; set; }

        public string Name { get; set; }

        public ICollection<Role> Roles { get; set; }
    }
}
