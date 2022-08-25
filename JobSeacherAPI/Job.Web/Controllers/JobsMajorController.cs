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
    public class JobsMajorController : ControllerBase
    {
        private JobsMajorSvc jobsMajorSvc;
        public JobsMajorController()
        {
            jobsMajorSvc = new JobsMajorSvc();
        }

        [HttpGet("{id:int}")]
        public IActionResult GetJobsMajorByID(int id)
        {
            var res = new SingleRsp();
            res = jobsMajorSvc.Read(id);
            return Ok(res);
        }
        [HttpGet("get-by-name")]
        public IActionResult GetJobsMajorByName([FromQuery] SimpleReq simpleReq)
        {
            var res = new SingleRsp();
            res = jobsMajorSvc.Read(simpleReq.Keyword);
            return Ok(res);
        }
    }
}
