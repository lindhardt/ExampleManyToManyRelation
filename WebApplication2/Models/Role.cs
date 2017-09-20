using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication2.Models
{
    public class Role
    {
        public Role()
        {
            Members = new List<Member>();
        }

        public int RoleID { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }

        public ICollection<Member> Members { get; set; }
    }
}