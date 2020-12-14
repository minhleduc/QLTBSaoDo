using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Text;

namespace QLTBSaoDo.Data.Entities
{
    public class AppRole : IdentityRole<Guid>
    {
        public string ChiTiet { get; set; }
    }
}
