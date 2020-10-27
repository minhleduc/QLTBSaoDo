using System;
using System.Collections.Generic;
using System.Reflection.Metadata.Ecma335;
using System.Text;

namespace QLTBSaoDo.Data.Entities
{
    public class Phong
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }

        public int KhoaId { get; set; }
        public Khoa Khoa { get; set; }
        public GVQuanLy GVQuanLy { get; set; }
        public IList<ThietBiPhong> ThietBiPhongs { get; set; }
    }
}
