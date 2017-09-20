using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace WebApplication2.Models
{
    public class MyTestDB : DbContext
    {
        public DbSet<Member> Members { get; set; }
        public DbSet<Role> Roles { get; set; }
    }
}