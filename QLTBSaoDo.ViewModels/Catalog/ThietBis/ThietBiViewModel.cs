using QLTBSaoDo.Data.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace QLTBSaoDo.ViewModels.Catalog.ThietBis
{
    public class ThietBiViewModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }
        public int Stock { get; set; }
        public string Details { get; set; }
        public DateTime? DateCreated { get; set; }

        //public string Loai { get; set; }
        //public string DanhMuc { get; set; }

        public virtual ICollection<ChiTietDonNhap> ChiTietDonNhap { get; set; }
        public virtual ICollection<ThietBiDanhMuc> ThietBiDanhMuc { get; set; }
        public virtual ICollection<ThietBiLoai> ThietBiLoai { get; set; }
        public virtual ICollection<ThietBiPhong> ThietBiPhong { get; set; }
    }
}
