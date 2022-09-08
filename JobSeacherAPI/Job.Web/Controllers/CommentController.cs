using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Job.BLL;
using Job.Common.Req;
using Job.Common.Rsp;

namespace Job.Web.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class CommentController : ControllerBase
    {
        private CommentSvc commentSvc;


        public CommentController()
        {
            commentSvc = new CommentSvc();
        }

        [HttpGet]
        public IActionResult GetAllJobsComment()
        {
            var res = new SingleRsp();
            res.Data = commentSvc.All;
            if (res.Data == null)
            {
                res.SetMessage("Lỗi hệ thống!!!");
                return NotFound();
            }

            return Ok(res);
     
        }
    

        [HttpGet("get-by-user-id")]
        public IActionResult GetCommentsByUSerId([FromQuery] IdReq idReq)
        {
            var res = new SingleRsp();
            res.Data = commentSvc.Read(idReq.Id);
            //System.Diagnostics.Debug.WriteLine(res);
            if (res.Data == null)
            {
                res.SetMessage("Lỗi hệ thống!!!");
                return NotFound();
            }
      
            return Ok(res);
        }
        [HttpPost("post-comment-on-user-id")]
        public IActionResult CreateComment([FromBody] CommentPostRequest commentPostRequest)
        {
            var res = new SingleRsp();
            res = commentSvc.CreateComment(commentPostRequest.CreatorId, commentPostRequest.TargetId, commentPostRequest.Content);
            if (res.Data == null)
                return BadRequest();
            return CreatedAtAction("Get Conmment ID", res.Data);
        }

        [HttpDelete("delete")]
        public IActionResult DeleteComment([FromBody] IdReq idReq)
        {
            var res = new SingleRsp();
            res = commentSvc.Remove(idReq.Id);
            if (res.Data == null)
            {
                res.SetMessage("Không tìm thấy dữ liệu comment!!!");
                return NotFound(res);
            }
            return Ok(res);
        }

        [HttpPatch("{id:int}/update-comment")]
        public IActionResult UpdateComment(int id, [FromBody] string content)
        {
            var res = new SingleRsp();
            if (commentSvc.ReadCommentId(id).Data == null)
            {
                res.SetMessage("Không có comment!!!");
                res.SetError("Không tìm thấy dữ liệu comment!!!");
                return BadRequest(res);
            }
            res = commentSvc.UpdateComment(id, content);
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
