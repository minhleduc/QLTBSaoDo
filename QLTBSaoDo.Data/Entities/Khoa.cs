using System;
using System.Collections.Generic;
using System.Text;

namespace QLTBSaoDo.Data.Entities
{
    public class Khoa
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }

        public IList<Phong> Phongs { get; set; }
        public IList<GVQuanLy> GVQuanLys { get; set; }
    }
}
