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
    [Route("api/[controller]")]
    [ApiController]
    public class CommentController : ControllerBase
    {
        private CommentSvc commentSvc;
        public CommentController()
        {
            commentSvc = new CommentSvc();
        }

        [HttpGet("get-by-user-id")]
        public IActionResult GetCommentsByUSerId([FromQuery] SimpleReq simpleReq)
        {
            var res = new SingleRsp();
            res = commentSvc.Read(simpleReq.Id);
            return Ok(res);
        }
        [HttpPost("post-comment-on-user-id")]
        public IActionResult GetCommentByID([FromBody] CommentPostRequest commentPostRequest)
        {
            var res = new SingleRsp();
            res = commentSvc.CreateComment(commentPostRequest.CreatorId, commentPostRequest.TargetId, commentPostRequest.Content);
            return Ok(res);
        }
    }
}
