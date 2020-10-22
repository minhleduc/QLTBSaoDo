using System;
using System.Collections.Generic;
using System.Text;

namespace QLTBSaoDo.Data.Entities
{
    public class ThietBiLoai
    {
        public int ThietBiId { get; set; }
        public ThietBi ThietBi { get; set; }
        public int LoaiId { get; set; }
        public Loai Loai { get; set; }
    }
}
