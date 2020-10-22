using System;
using System.Collections.Generic;
using System.Text;

namespace QLTBSaoDo.Data.Entities
{
    public class ThietBi
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }
        public int Stock { get; set; }
        public string Details { get; set; }
        public DateTime? DateCreated { get; set; }

        public IList<ThietBiDanhMuc> ThietBiDanhMucs { get; set; }
        public IList<ThietBiLoai> ThietBiLoais { get; set; }
        public IList<ThietBiPhong> ThietBiPhongs { get; set; }
        public IList<ChiTietDonNhap> ChiTietDonNhaps { get; set; }
    }
}
