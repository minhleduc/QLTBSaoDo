using System;
using System.Collections.Generic;
using System.Reflection.Metadata.Ecma335;
using System.Text;

namespace QLTBSaoDo.Data.Entities
{
    public partial class Phong
    {
        public Phong()
        {
            ThietBiPhong = new HashSet<ThietBiPhong>();
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public int KhoaId { get; set; }

        public virtual Khoa Khoa { get; set; }
        public virtual GVQuanLy GVQuanLy { get; set; }
        public virtual ICollection<ThietBiPhong> ThietBiPhong { get; set; }
    }
}
