using System;
using System.Collections.Generic;
using Amazon.DynamoDBv2.DataModel;

namespace DatabaseCompare.DynamoExample
{
    [DynamoDBTable("brstTest")]
    public class User
    {
        [DynamoDBHashKey]
        public Guid UserId { get; set; }

        public string Name { get; set; }

        public DateTime CreatedDateTime { get; set; }
        public DateTime ModifiedDateTime { get; set; }

        public List<Role> Roles { get; set; }
    }
}
