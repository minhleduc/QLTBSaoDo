using QLTBSaoDo.ViewModels.Catalog.ThietBis;
using QLTBSaoDo.ViewModels.Common;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace QLTBSaoDo.Application.Catalog.ThietBis
{
    public interface IThietBiService
    {
        Task<int> Create(ThietBiCreateRequest request);
        Task<int> Update(ThietBiUpdateRequest request);
        Task<int> Delete(int thietbiId);
        Task<List<ThietBiViewModel>> GetAll();
        Task<ThietBiViewModel> GetById(int thietBiId);
        Task<PageResult<ThietBiViewModel>> GetAllPaging(GetThietBiPagingRequest request);
        Task<PageResult<ThietBiViewModel>> GetAllByLoaiId(GetThietBiPagingRequest request);
        Task<PageResult<ThietBiViewModel>> GetAllByDanhMucId(GetThietBiPagingRequest request);
    }
}
