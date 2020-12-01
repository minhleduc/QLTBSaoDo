using QLTBSaoDo.ViewModels.Common;
using System;
using System.Collections.Generic;
using System.Text;

namespace QLTBSaoDo.ViewModels.Catalog.ThietBis
{
    public class GetThietBiPagingRequest : PagingRequestBase
    {
        public string Keyword { get; set; }
        public int? LoaiId { get; set; }
        public int? DanhMucId { get; set; }
    }
}
