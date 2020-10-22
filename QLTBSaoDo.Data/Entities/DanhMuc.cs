using QLTBSaoDo.Data.Enums;
using System;
using System.Collections.Generic;
using System.Security.Principal;
using System.Text;

namespace QLTBSaoDo.Data.Entities
{
    public class DanhMuc
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Details { get; set; }
        public IList<ThietBiDanhMuc> ThietBiDanhMucs { get; set; }
    }
}
