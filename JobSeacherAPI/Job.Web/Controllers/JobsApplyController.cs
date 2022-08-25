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
    public class JobsApplyController : ControllerBase
    {
        private JobsApplySvc jobsApplySvc;
        public JobsApplyController()
        {
            jobsApplySvc = new JobsApplySvc();
        }
        [HttpGet("{id:int}")]
        public IActionResult GetApplyByID(int id)
        {
            var res = new SingleRsp();
            res = jobsApplySvc.Read(id);
            return Ok(res);
        }

        [HttpDelete("delete")]
        public IActionResult DeleteApply([FromBody] SimpleReq simpleReq)
        {
            var res = new SingleRsp();
            res = jobsApplySvc.Remove(simpleReq.Id);
            if (res.Data == null)
            {
                return BadRequest();
            }
            return NoContent();
        }

        [HttpGet("get-all")]
        public IActionResult GetAllApply()
        {
            var res = new SingleRsp();
            res.Data = jobsApplySvc.All;
            return Ok(res);
        }
    }
}
