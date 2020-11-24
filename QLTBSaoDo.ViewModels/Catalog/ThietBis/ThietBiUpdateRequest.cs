using System;
using System.Collections.Generic;
using System.Text;

namespace QLTBSaoDo.ViewModels.Catalog.ThietBis
{
    public class ThietBiUpdateRequest
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }
        public int Stock { get; set; }
        public string Details { get; set; }
        public DateTime? DateCreated { get; set; }
    }
}
