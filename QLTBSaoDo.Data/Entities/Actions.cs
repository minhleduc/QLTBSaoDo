using System;
using System.Collections.Generic;
using System.Text;

namespace QLTBSaoDo.Data.Entities
{
    public class Actions
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public IList<Permission> Permissions { get; set; }
    }
}
