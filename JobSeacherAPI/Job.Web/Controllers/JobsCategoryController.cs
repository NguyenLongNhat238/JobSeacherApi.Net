using Job.BLL;
using Job.Common.Req;
using Job.Common.Rsp;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Job.Web.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class JobsCategoryController : ControllerBase
    {
        private CategorySvc categorySvc;
        public JobsCategoryController()
        {
            categorySvc = new CategorySvc();
        }
        [HttpGet("{id:int}")]
        public IActionResult GetCategoryByID(int id)
        {
            var res = new SingleRsp();
            res = categorySvc.Read(id);
            return Ok(res);
        }

        [HttpGet("get-by-name")]
        public IActionResult GetJobsCategoryByName([FromQuery] SimpleReq simpleReq)
        {
            var res = new SingleRsp();
            res.Data = categorySvc.Read(simpleReq.Keyword);
            return Ok(res);
        }

        [HttpGet("get-all")]
        public IActionResult GetAllCategories()
        {
            var res = new SingleRsp();
            res.Data = categorySvc.All;
            return Ok(res);
        }
    }
}
