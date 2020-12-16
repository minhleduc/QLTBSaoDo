using System;
using System.Collections.Generic;
using System.Text;

namespace QLTBSaoDo.Data.Entities
{
    public partial class GVQuanLy
    {
        public Guid UserId { get; set; }
        public int KhoaId { get; set; }
        public int PhongId { get; set; }

        public virtual Khoa Khoa { get; set; }
        public virtual Phong Phong { get; set; }
        public virtual AppUser AppUser { get; set; }
    }
}
