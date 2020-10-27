using System;
using System.Collections.Generic;
using System.Text;

namespace QLTBSaoDo.Data.Entities
{
    public partial class ThietBi
    {
        public ThietBi()
        {
            ChiTietDonNhap = new HashSet<ChiTietDonNhap>();
            ThietBiDanhMuc = new HashSet<ThietBiDanhMuc>();
            ThietBiLoai = new HashSet<ThietBiLoai>();
            ThietBiPhong = new HashSet<ThietBiPhong>();
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }
        public int Stock { get; set; }
        public string Details { get; set; }
        public DateTime? DateCreated { get; set; }

        public virtual ICollection<ChiTietDonNhap> ChiTietDonNhap { get; set; }
        public virtual ICollection<ThietBiDanhMuc> ThietBiDanhMuc { get; set; }
        public virtual ICollection<ThietBiLoai> ThietBiLoai { get; set; }
        public virtual ICollection<ThietBiPhong> ThietBiPhong { get; set; }
    }
}
