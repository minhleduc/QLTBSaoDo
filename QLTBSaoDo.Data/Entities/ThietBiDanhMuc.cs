using System;
using System.Collections.Generic;
using System.Text;

namespace QLTBSaoDo.Data.Entities
{
    public class ThietBiDanhMuc
    {
        public int ThietBiId { get; set; }
        public ThietBi ThietBi { get; set; }
        public int DanhMucId { get; set; }
        public DanhMuc DanhMuc { get; set; }
    }
}
