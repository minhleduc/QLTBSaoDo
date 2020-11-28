using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using QLTBSaoDo.Application.Catalog.ThietBis;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace QLTBSaoDo.BackendApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
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
    }
}
