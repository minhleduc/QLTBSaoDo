using System;
using System.Collections.Generic;
using System.Text;

namespace QLTBSaoDo.Data.Entities
{
    public partial class Khoa
    {
        public Khoa()
        {
            GVQuanLy = new HashSet<GVQuanLy>();
            Phong = new HashSet<Phong>();
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }

        public virtual ICollection<GVQuanLy> GVQuanLy { get; set; }
        public virtual ICollection<Phong> Phong { get; set; }
    }
}
