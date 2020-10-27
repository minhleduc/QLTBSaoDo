using QLTBSaoDo.Data.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace QLTBSaoDo.Data.Entities
{
    public partial class TinhTrang
    {
        public int Id { get; set; }
        public int ThietBiPhongId { get; set; }
        public HienTrang HienTrang { get; set; }
        public string ChiTiet { get; set; }
        public DateTime? NgayCapNhat { get; set; }

        public virtual ThietBiPhong ThietBiPhong { get; set; }
    }
}
