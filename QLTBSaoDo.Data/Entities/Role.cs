using System;
using System.Collections.Generic;
using System.Text;

namespace QLTBSaoDo.Data.Entities
{
    public class Role
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Detail { get; set; }

        public IList<Permission> Permissions { get; set; }
        public IList<UserRoles> UserRoles { get; set; }
    }
}
