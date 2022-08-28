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
        public IActionResult GetAllCategories()
        {
            var res = new SingleRsp();
            res.Data = commentSvc.All;
            return Ok(res);
        }
    

        [HttpGet("get-by-user-id")]
        public IActionResult GetCommentsByUSerId([FromQuery] IdReq idReq)
        {
            var res = new SingleRsp();
            res.Data = commentSvc.Read(idReq.Id);
            //System.Diagnostics.Debug.WriteLine(res);
            return Ok(res);
        }
        [HttpPost("post-comment-on-user-id")]
        public IActionResult CreateComment([FromBody] CommentPostRequest commentPostRequest)
        {
            var res = new SingleRsp();
            res = commentSvc.CreateComment(commentPostRequest.CreatorId, commentPostRequest.TargetId, commentPostRequest.Content);
            return Ok(res);
        }
        [HttpDelete("delete-comment-id")]
        public IActionResult DeleteCommentByID([FromBody] IdReq idReq)
        {
            var res = new SingleRsp();
            res.Data = commentSvc.Delete(idReq.Id);
            return Ok(res);
        }
    }
}
