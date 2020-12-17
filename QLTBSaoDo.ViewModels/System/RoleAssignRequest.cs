
using QLTBSaoDo.ViewModels.Common;
using System;
using System.Collections.Generic;
using System.Text;

namespace QLTBSaoDo.ViewModels.System
{
    public class RoleAssignRequest
    {
        public Guid Id { get; set; }
        public List<SelectItem> Roles { get; set; } = new List<SelectItem>();
    }
}
