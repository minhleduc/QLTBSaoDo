using System;
using System.Collections.Generic;
using System.Text;

namespace QLTBSaoDo.Data.Entities
{
    public partial class DonNhap
    {
        public DonNhap()
        {
            ChiTietDonNhap = new HashSet<ChiTietDonNhap>();
        }

        public int Id { get; set; }
        public DateTime NgayNhap { get; set; }
        public string NguoiNhap { get; set; }
        public string PhoneNumber { get; set; }

        public virtual ICollection<ChiTietDonNhap> ChiTietDonNhap { get; set; }
    }
}
