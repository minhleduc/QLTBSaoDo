using System;
using System.Collections.Generic;
using System.Text;

namespace QLTBSaoDo.Data.Entities
{
    public partial class ThietBiDanhMuc
    {
        public int ThietBiId { get; set; }
        public int DanhMucId { get; set; }

        public virtual DanhMuc DanhMuc { get; set; }
        public virtual ThietBi ThietBi { get; set; }
    }
}
