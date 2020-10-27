using System;
using System.Collections.Generic;
using System.Text;

namespace QLTBSaoDo.Data.Entities
{
    public partial class NhaCungCap
    {
        public NhaCungCap()
        {
            ChiTietDonNhap = new HashSet<ChiTietDonNhap>();
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public string PhoneNumber { get; set; }
        public string Address { get; set; }
        public string Email { get; set; }
        public string NguoiDaiDien { get; set; }

        public virtual ICollection<ChiTietDonNhap> ChiTietDonNhap { get; set; }
    }
}
