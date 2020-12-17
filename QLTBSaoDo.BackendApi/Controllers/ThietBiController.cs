using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using QLTBSaoDo.Application.Catalog.ThietBis;
using QLTBSaoDo.ViewModels.Catalog.ThietBis;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace QLTBSaoDo.BackendApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [Authorize]
    public class ThietBiController : ControllerBase
    {
        private IThietBiService _thietBiService;

        public ThietBiController(IThietBiService thietBiService)
        {
            _thietBiService = thietBiService;
        }
        
        [HttpGet]
        public async Task<IActionResult> Get()
        {
            var thietbi = await _thietBiService.GetAll();
            return Ok(thietbi);
        }

        [HttpGet("paging")]
        public async Task<IActionResult> Get([FromQuery] GetThietBiPagingRequest request)
        {
            var thietbi = await _thietBiService.GetAllByLoaiId(request);
            return Ok(thietbi);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetById(int id)
        {
            var thietbi = await _thietBiService.GetById(id);
            if (thietbi == null)
            {
                return BadRequest("Không tìm thấy thiết bị");
            }
            return Ok(thietbi);
        }

        [HttpPost]
        public async Task<IActionResult> Create([FromBody] ThietBiCreateRequest request)
        {
            var thietBiId = await _thietBiService.Create(request);
            if (thietBiId == 0)
            {
                return BadRequest();
            }

            var thietbi = await _thietBiService.GetById(thietBiId);

            return Created(nameof(GetById), thietbi);
        }

        [HttpPut]
        public async Task<IActionResult> Update([FromBody] ThietBiUpdateRequest request)
        {
            var result = await _thietBiService.Update(request);
            if (result == 0)
            {
                return BadRequest();
            }

            return Ok();
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            var result = await _thietBiService.Delete(id);
            if (result == 0)
            {
                return BadRequest();
            }

            return Ok();
        }
    }
}
