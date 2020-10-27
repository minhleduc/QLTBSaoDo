using System;
using System.Collections.Generic;
using System.Text;

namespace QLTBSaoDo.Data.Entities
{
    public partial class User
    {
        public int Id { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public string FullName { get; set; }
        public string PhoneNumber { get; set; }
        public string Email { get; set; }
        public DateTime? DOB { get; set; }

        public virtual GVQuanLy GVQuanLy { get; set; }
        public virtual UserRoles UserRoles { get; set; }
    }
}
