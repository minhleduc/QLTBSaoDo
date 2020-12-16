using QLTBSaoDo.ViewModels.Common;
using System;
using System.Collections.Generic;
using System.Text;

namespace QLTBSaoDo.ViewModels.System
{
    public class GetUserPagingRequest : PagingRequestBase
    {
        public string Keyword { get; set; }
    }
}
