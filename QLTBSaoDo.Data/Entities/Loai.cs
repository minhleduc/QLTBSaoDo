using System;
using System.Collections.Generic;
using System.Text;

namespace QLTBSaoDo.Data.Entities
{
    public partial class Loai
    {
        public Loai()
        {
            ThietBiLoai = new HashSet<ThietBiLoai>();
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }

        public virtual ICollection<ThietBiLoai> ThietBiLoai { get; set; }
    }
}
