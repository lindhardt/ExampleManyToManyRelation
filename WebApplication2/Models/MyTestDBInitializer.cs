using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace WebApplication2.Models
{
    public class MyTestDBInitializer : DropCreateDatabaseAlways<MyTestDB>
    {
        protected override void Seed(MyTestDB context)
        {
            var members = new List<Member>
            {
                new Member
                {
                    Name = "Member 1"
                },
                new Member
                {
                    Name = "Member 2"
                },
                new Member
                {
                    Name = "Member 3"
                },
            };

            members.ForEach(s => context.Members.Add(s));
            context.SaveChanges();

            var roles = new List<Role>
            {
                new Role
                {
                    Name = "Member",
                    Description = "Member"
                },
                new Role
                {
                    Name = "Admin",
                    Description = "Member"
                },
                new Role
                {
                    Name = "Trainer",
                    Description = "Member"
                }

            };

            roles.ForEach(s => context.Roles.Add(s));
            context.SaveChanges();

            context.Members.Find(1).Roles.Add(context.Roles.Find(1));
            context.Members.Find(1).Roles.Add(context.Roles.Find(2));
            context.Members.Find(1).Roles.Add(context.Roles.Find(3));
            context.Members.Find(2).Roles.Add(context.Roles.Find(1));
            context.Members.Find(3).Roles.Add(context.Roles.Find(1));
            context.Members.Find(3).Roles.Add(context.Roles.Find(3));

            context.SaveChanges();
        }
    }
}