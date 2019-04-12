using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace DatabaseCompare.ArouraDB
{
    public class ArouraDBExample
    {

        private Random rando = new Random();

        public User GetAUser(Guid userId)
        {
            using (var context = new ArouraContext())
            {
                return context.Users.First(x => x.UserId == userId);
            }
        }
        
        public Guid AddAUser()
        {
            using (var context = new ArouraContext())
            {
                var userToAdd = new User
                {
                    CreatedDate = DateTime.Now,
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


                context.Users.Add(userToAdd);
                context.SaveChanges();

                return userToAdd.UserId;
            }
        }
    }
}
