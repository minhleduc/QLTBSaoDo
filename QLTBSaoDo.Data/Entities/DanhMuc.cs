using QLTBSaoDo.Data.Enums;
using System;
using System.Collections.Generic;
using System.Security.Principal;
using System.Text;

namespace QLTBSaoDo.Data.Entities
{
    public partial class DanhMuc
    {
        public DanhMuc()
        {
            ThietBiDanhMuc = new HashSet<ThietBiDanhMuc>();
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public string Details { get; set; }

        public virtual ICollection<ThietBiDanhMuc> ThietBiDanhMuc { get; set; }
    }
}
