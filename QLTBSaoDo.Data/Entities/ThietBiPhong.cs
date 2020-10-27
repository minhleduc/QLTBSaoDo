using System;
using System.Collections.Generic;
using System.Text;

namespace QLTBSaoDo.Data.Entities
{
    public partial class ThietBiPhong
    {
        public ThietBiPhong()
        {
            TinhTrang = new HashSet<TinhTrang>();
        }

        public int Id { get; set; }
        public int ThietBiId { get; set; }
        public int PhongId { get; set; }
        public string TenThietBi { get; set; }
        public DateTime? NgayLapDat { get; set; }

        public virtual Phong Phong { get; set; }
        public virtual ThietBi ThietBi { get; set; }
        public virtual TSThanhLy TSThanhLy { get; set; }
        public virtual ICollection<TinhTrang> TinhTrang { get; set; }
    }
}
