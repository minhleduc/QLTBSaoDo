using QLTBSaoDo.Data.EF;
using QLTBSaoDo.Data.Entities;
using QLTBSaoDo.ViewModels.Catalog.ThietBis;
using QLTBSaoDo.ViewModels.Common;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using System.Linq;
using Microsoft.EntityFrameworkCore;

namespace QLTBSaoDo.Application.Catalog.ThietBis
{
    public class ThietBiService : IThietBiService
    {
        private QLTBDbContext _context;
        public ThietBiService(QLTBDbContext context)
        {
            _context = context;
        }
        public async Task<int> Create(ThietBiCreateRequest request)
        {
            var thietbi = new ThietBi()
            {
                Name = request.Name,
                Price = request.Price,
                Stock = request.Stock,
                Details = request.Details,
                DateCreated = request.DateCreated,

            };
            _context.ThietBi.Add(thietbi);
            return await _context.SaveChangesAsync();
        }

        public async Task<int> Delete(int thietbiId)
        {
            var thietbi = await _context.ThietBi.FindAsync(thietbiId);
            if (thietbi == null)
            {
                throw new Exception($"Không tìm thấy thiết bị có mã: {thietbiId}");
            }
            _context.ThietBi.Remove(thietbi);
            return await _context.SaveChangesAsync();
        }

        public async Task<List<ThietBiViewModel>> GetAll()
        {
            //1. select join
            var query = from tb in _context.ThietBi
                        select new { tb };

            var data = await query.Select(x => new ThietBiViewModel()
            {
                Id = x.tb.Id,
                Name = x.tb.Name,
                DateCreated = x.tb.DateCreated,
                Price = x.tb.Price,
                Stock = x.tb.Stock,
                Details = x.tb.Details
            }).ToListAsync();
            return data;
        }

        public async Task<PageResult<ThietBiViewModel>> GetAllByDanhMucId(GetThietBiPagingRequest request)
        {
            //1. select join
            var query = from tb in _context.ThietBi
                        join tbl in _context.ThietBiLoai on tb.Id equals tbl.ThietBiId
                        join loai in _context.Loai on tbl.LoaiId equals loai.Id
                        join tbdm in _context.ThietBiDanhMuc on tb.Id equals tbdm.ThietBiId
                        join dm in _context.DanhMuc on tbdm.DanhMucId equals dm.Id
                        select new { tb, tbl, loai, tbdm, dm };

            //2.filter
            if (!string.IsNullOrEmpty(request.Keyword))
            {
                query = query.Where(x => x.tb.Name.Contains(request.Keyword));
            }
            if (request.DanhMucId != null && request.DanhMucId != 0)
            {
                query = query.Where(tb => tb.dm.Id == request.DanhMucId);
            }

            //3. Paging
            int totalRow = await query.CountAsync();

            var data = await query.Skip((request.PageIndex - 1) * request.PageSize)
                .Take(request.PageSize)
                .Select(x => new ThietBiViewModel()
                {
                    Id = x.tb.Id,
                    Name = x.tb.Name,
                    DateCreated = x.tb.DateCreated,
                    Price = x.tb.Price,
                    Stock = x.tb.Stock,
                    Details = x.tb.Details,
                    //Loai = x.loai.Name,
                    //DanhMuc = x.dm.Name
                }).ToListAsync();

            //4. Select and projection
            var pagedResult = new PageResult<ThietBiViewModel>()
            {
                TotalRecords = totalRow,
                PageSize = request.PageSize,
                PageIndex = request.PageIndex,
                Items = data
            };
            return pagedResult;
        }

        public async Task<PageResult<ThietBiViewModel>> GetAllByLoaiId(GetThietBiPagingRequest request)
        {
            //1. select join
            var query = from tb in _context.ThietBi
                        join tbl in _context.ThietBiLoai on tb.Id equals tbl.ThietBiId
                        join loai in _context.Loai on tbl.LoaiId equals loai.Id
                        join tbdm in _context.ThietBiDanhMuc on tb.Id equals tbdm.ThietBiId
                        join dm in _context.DanhMuc on tbdm.DanhMucId equals dm.Id
                        select new { tb, tbl, loai, tbdm, dm };

            //2.filter
            if (!string.IsNullOrEmpty(request.Keyword))
            {
                query = query.Where(x => x.tb.Name.Contains(request.Keyword));
            }
            if (request.LoaiId != null && request.LoaiId != 0)
            {
                query = query.Where(tb => tb.loai.Id == request.LoaiId);
            }

            //3. Paging
            int totalRow = await query.CountAsync();

            var data = await query.Skip((request.PageIndex - 1) * request.PageSize)
                .Take(request.PageSize)
                .Select(x => new ThietBiViewModel()
                {
                    Id = x.tb.Id,
                    Name = x.tb.Name,
                    DateCreated = x.tb.DateCreated,
                    Price = x.tb.Price,
                    Stock = x.tb.Stock,
                    Details = x.tb.Details,
                    //Loai = x.loai.Name,
                    //DanhMuc = x.dm.Name
                }).ToListAsync();

            //4. Select and projection
            var pagedResult = new PageResult<ThietBiViewModel>()
            {
                TotalRecords = totalRow,
                PageSize = request.PageSize,
                PageIndex = request.PageIndex,
                Items = data
            };
            return pagedResult;
        }

        public async Task<PageResult<ThietBiViewModel>> GetAllPaging(GetThietBiPagingRequest request)
        {
            //1. select join
            var query = from tb in _context.ThietBi
                        join tbl in _context.ThietBiLoai on tb.Id equals tbl.ThietBiId
                        join loai in _context.Loai on tbl.LoaiId equals loai.Id
                        join tbdm in _context.ThietBiDanhMuc on tb.Id equals tbdm.ThietBiId
                        join dm in _context.DanhMuc on tbdm.DanhMucId equals dm.Id
                        select new { tb, tbl, loai, tbdm, dm };

            //2.filter
            if (!string.IsNullOrEmpty(request.Keyword))
            {
                query = query.Where(x => x.tb.Name.Contains(request.Keyword));
            }
            if (request.LoaiId != null && request.LoaiId != 0)
            {
                query = query.Where(tb => tb.loai.Id == request.LoaiId);
            }
            if (request.DanhMucId != null && request.DanhMucId != 0)
            {
                query = query.Where(tb => tb.dm.Id == request.DanhMucId);
            }

            //3. Paging
            int totalRow = await query.CountAsync();

            var data = await query.Skip((request.PageIndex - 1) * request.PageSize)
                .Take(request.PageSize)
                .Select(x => new ThietBiViewModel()
                {
                    Id = x.tb.Id,
                    Name = x.tb.Name,
                    DateCreated = x.tb.DateCreated,
                    Price = x.tb.Price,
                    Stock = x.tb.Stock,
                    Details = x.tb.Details,
                    //Loai = x.loai.Name,
                    //DanhMuc = x.dm.Name
                }).ToListAsync();

            //4. Select and projection
            var pagedResult = new PageResult<ThietBiViewModel>()
            {
                TotalRecords = totalRow,
                PageSize = request.PageSize,
                PageIndex = request.PageIndex,
                Items = data
            };
            return pagedResult;
        }

        public async Task<int> Update(ThietBiUpdateRequest request)
        {
            var thietbi = _context.ThietBi.FindAsync(request.Id);
            if (thietbi == null)
            {
                throw new Exception($"Không tìm thấy thiết bị có mã: {request.Id}");
            }
            return await _context.SaveChangesAsync();
        }
    }
}
