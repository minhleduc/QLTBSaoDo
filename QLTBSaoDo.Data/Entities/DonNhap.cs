using System;
using System.Collections.Generic;
using System.Text;

namespace QLTBSaoDo.Data.Entities
{
    public class DonNhap
    {
        public int Id { get; set; }
        public DateTime NgayNhap { get; set; }
        public string NguoiNhap { get; set; }
        public string PhoneNumber { get; set; }

        public IList<ChiTietDonNhap> ChiTietDonNhaps { get; set; }
    }
}
