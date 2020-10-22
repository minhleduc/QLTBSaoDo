using System;
using System.Collections.Generic;
using System.Text;

namespace QLTBSaoDo.Data.Entities
{
    public class TSThanhLy
    {
        public int Id { get; set; }
        public int ThietBiPhongId { get; set; }
        public decimal Gia { get; set; }

        public ThietBiPhong ThietBiPhong { get; set; }
    }
}
