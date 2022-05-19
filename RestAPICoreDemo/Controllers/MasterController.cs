using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using RestAPICoreDemo.Model;
using RestAPICoreDemo.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RestAPICoreDemo.Controllers
{

    [Route("api/[controller]")]
    [ApiController]
    public class MasterController : ControllerBase
    {
        private readonly IMaster _CityService;
        public MasterController(IMaster oCityService)
        {
            _CityService = oCityService;
        }

        [HttpGet]
        [Route("[action]")]
        [Route("api/Master/GetAllCity")]
        public IEnumerable<CityMaster> GetAllCity()
        {
          return _CityService.GetAllCity();
        }

        [HttpPost]
        [Route("[action]")]
        [Route("api/Master/AddCity")]
        public IActionResult AddCity(CityMaster info)
        {
            _CityService.AddCity(info);
            return Ok();
        }
    }
}
