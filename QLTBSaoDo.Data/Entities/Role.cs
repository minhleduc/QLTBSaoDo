using System;
using System.Collections.Generic;
using System.Text;

namespace QLTBSaoDo.Data.Entities
{
    public partial class Role
    {
        public Role()
        {
            UserRoles = new HashSet<UserRoles>();
            Permission = new HashSet<Permission>();
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public string Detail { get; set; }

        public virtual ICollection<Permission> Permission { get; set; }
        public virtual ICollection<UserRoles> UserRoles { get; set; }
    }
}
