using System;
using System.Collections.Generic;
using System.Text;

namespace QLTBSaoDo.Data.Entities
{
    public class ChiTietDonNhap
    {
        public int Id { get; set; }
        public int DonNhapId { get; set; }
        public int ThietBiId { get; set; }
        public int SoLuong { get; set; }
        public decimal Gia { get; set; }
        public int NhaCungCapId { get; set; }

        public DonNhap DonNhap { get; set; }
        public ThietBi ThietBi { get; set; }
        public NhaCungCap NhaCungCap { get; set; }
    }
}
