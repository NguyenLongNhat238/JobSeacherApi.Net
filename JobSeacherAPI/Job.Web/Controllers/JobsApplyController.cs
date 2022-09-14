using Job.BLL;
using Job.Common.Req;
using Job.Common.Rsp;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.IO;
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
            if (res.Data == null)
            {
                return NotFound();
            }
            return Ok(res);
        }
        [HttpGet("get-all")]
        public IActionResult GetAllApply()
        {
            var res = new SingleRsp();
            res.Data = jobsApplySvc.All;
            if (res.Data == null)
            {
                res.SetMessage("Lỗi hệ thống!!!");
                return NotFound();
            }
  
            return Ok(res);
        }

        [HttpDelete("delete")]
        public IActionResult DeleteApply([FromBody] SimpleReq simpleReq)
        {
            var res = new SingleRsp();
            res = jobsApplySvc.Remove(simpleReq.Id);
            if (res.Data == null)
            {
                res.Data = "Không tìm thấy dữ liệu bài ứng tuyển!!!";
                return NotFound(res);
            }
            return Ok(res);
        }
        [HttpPost("create-apply")]
        public IActionResult CreateApply([FromBody] CreateApplyReq createApplyReq)
        {
            var res = new SingleRsp();
            res = jobsApplySvc.CheckApply(createApplyReq);
            if (res.Data == null)
            {
                res.SetMessage("Bạn Đã Ứng Tuyển Trước Đó Rồi!!!");
                return BadRequest(res);
            }
            res = jobsApplySvc.CreateApply(createApplyReq);
            if (res.Data == null)
                return BadRequest();
            return CreatedAtAction("Get Apply ID",res.Data);
        }

        [HttpPatch("{id:int}/update-apply")]
        public IActionResult UpdateApply(int id ,[FromBody] CreateApplyReq createApplyReq)
        {
            var res = new SingleRsp();
            if(jobsApplySvc.Read(id).Data == null)
            {
                res.SetMessage("Không có bài ứng tuyển!!!");
                res.SetError("Không tìm thấy dữ liệu bài ứng tuyển!!!");
                return BadRequest(res);
            }
            res = jobsApplySvc.UpdateApply(id, createApplyReq);
            if (res.Data == null)
            {
                res.SetMessage("Lỗi hệ thống!!!");
                res.SetError("Lỗi từ hệ thống!!");
                return BadRequest(res);
            }
            return Ok(res);
        }
   
    }
}
