using System;
using System.Collections.Generic;
using System.Text;

namespace QLTBSaoDo.Data.Entities
{
    public class GVQuanLy
    {

        public int UserId { get; set; }
        public int KhoaId { get; set; }
        public int PhongId { get; set; }

        public User User { get; set; }
        public Khoa Khoa { get; set; }
        public Phong Phong { get; set; }
    }
}
