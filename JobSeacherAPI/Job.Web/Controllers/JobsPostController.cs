using Job.BLL;
using Job.Common.Req;
using Job.Common.Rsp;
using Job.DAL.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Job.Web.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class JobsPostController : ControllerBase
    {
        private JobsPostSvc jobsPostSvc;
        public JobsPostController()
        {
            jobsPostSvc = new JobsPostSvc();

        }
        [HttpPost("get-by-id")]
        public IActionResult GetJobsPostById([FromBody] SimpleReq simpleReq)
        {
            var res = new SingleRsp();
            res = jobsPostSvc.Read(simpleReq.Id);
            return Ok(res);
        }

        [HttpPost("create-jobsPost")]
        public IActionResult CreateJobsPost([FromBody] JobsPostReq jobsPostReq)
        {
            try
            {
                var res = new SingleRsp();
                res = jobsPostSvc.CreateJobsPost(jobsPostReq);
                return Ok(res);

            }
            catch
            {
                return BadRequest();
            }
            
        }

        [HttpPost("search-jobsPost")]
        public IActionResult SearchJobsPost([FromBody] SearchJobsPost searchJobsPost)
        {
            var res = new SingleRsp();
            res = jobsPostSvc.SearchJobsPost(searchJobsPost);
            return Ok(res);
        }

        [HttpPost("{id:int}/remove-jobsPost")]
        public IActionResult RemoveJobsPost(int id)
        {
            var res = new SingleRsp();
            res = jobsPostSvc.RemoveJobsPost(id);
            return Ok(res);
        }

        [HttpPost("update-jobsPost")]
        public IActionResult UpdateJobsPost([FromBody] JobsPost jobsPost)
        {
            try
            {
                var res = new SingleRsp();
                res = jobsPostSvc.Update(jobsPost);
                return Ok(res);

            }
            catch
            {
                return BadRequest();
            }
          
        }
    }
}
