using System;
using System.Collections.Generic;
using System.Text;

namespace QLTBSaoDo.Data.Entities
{
    public class Permission
    {
        public int RoleId { get; set; }
        public int FunctionId { get; set; }
        public int ActionId { get; set; }

        public Role Role { get; set; }
        public Function Function { get; set; }
        public Actions Action { get; set; }
    }
}
