using System;
using System.Collections.Generic;
using System.Text;

namespace QLTBSaoDo.Data.Entities
{
    public partial class Permission
    {
        public int RoleId { get; set; }
        public int FunctionId { get; set; }
        public int ActionId { get; set; }

        public virtual Actions Actions { get; set; }
        public virtual Function Function { get; set; }
        public virtual Role Role { get; set; }
    }
}
