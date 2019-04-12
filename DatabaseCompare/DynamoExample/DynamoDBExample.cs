using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Amazon.DynamoDBv2;
using Amazon.DynamoDBv2.DataModel;
using Amazon.DynamoDBv2.DocumentModel;

namespace DatabaseCompare.DynamoExample
{
    public class DynamoDBExample
    {
        private Random rando = new Random();
        private IDynamoDBContext context;
        private IAmazonDynamoDB client;

        public DynamoDBExample()
        {
            client = new AmazonDynamoDBClient();
            context = new DynamoDBContext(client);
        }


        public async Task<User> GetAUserAsync(Guid userId)
        {
            var condition = new ScanCondition("UserId", ScanOperator.Equal, userId);
            var user = await context.ScanAsync<User>(new List<ScanCondition>() { condition }).GetRemainingAsync();

            return user.First();

        }

        public async Task<Guid> AddAUserAsync()
        {


            var userToAdd = new User
            {
                CreatedDateTime = DateTime.Now,
                Name = $"User{rando.Next(1000)}",
                UserId = Guid.NewGuid(),
                Roles = new List<Role>
                {
                    new Role()
                    {
                        RoleName = $"TestRole{rando.Next(1000)}"
                    },
                    new Role()
                    {
                        RoleName = $"TestRole{rando.Next(1000)}"
                    },
                    new Role()
                    {
                        RoleName = $"TestRole{rando.Next(1000)}"
                    }
                }
            };


            await context.SaveAsync(userToAdd);
            return userToAdd.UserId;

        }

    }
}
