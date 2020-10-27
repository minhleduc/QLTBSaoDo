using System;
using System.Collections.Generic;
using System.Text;

namespace QLTBSaoDo.Data.Entities
{
    public partial class ThietBiLoai
    {
        public int ThietBiId { get; set; }
        public int LoaiId { get; set; }

        public virtual Loai Loai { get; set; }
        public virtual ThietBi ThietBi { get; set; }
    }
}
