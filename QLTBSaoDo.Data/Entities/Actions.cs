using System;
using System.Collections.Generic;
using System.Text;

namespace QLTBSaoDo.Data.Entities
{
    public partial class Actions
    {
        public Actions()
        {
            Permission = new HashSet<Permission>();
        }

        public int Id { get; set; }
        public string Name { get; set; }

        public virtual ICollection<Permission> Permission { get; set; }
    }
}
