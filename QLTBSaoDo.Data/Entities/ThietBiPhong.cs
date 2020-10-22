using System;
using System.Collections.Generic;
using System.Text;

namespace QLTBSaoDo.Data.Entities
{
    public class ThietBiPhong
    {
        public int Id { get; set; }
        public int ThietBiId { get; set; }
        public int PhongId { get; set; }
        public string TenThietBi { get; set; }

        public ThietBi ThietBi { get; set; }
        public Phong Phong { get; set; }

        public IList<TinhTrang> TinhTrangs { get; set; }
        public TSThanhLy TSThanhLy { get; set; }
    }
}
