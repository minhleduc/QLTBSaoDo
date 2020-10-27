using System;
using System.Collections.Generic;
using System.Text;

namespace QLTBSaoDo.Data.Entities
{
    public partial class TSThanhLy
    {
        public int Id { get; set; }
        public int ThietBiPhongId { get; set; }
        public decimal Gia { get; set; }
        public DateTime? NgayThanhLy { get; set; }

        public virtual ThietBiPhong ThietBiPhong { get; set; }
    }
}
