using Job.BLL;
using Job.Common.Req;
using Job.Common.Rsp;
using Job.DAL.Models;
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
    public class JobsUserController : ControllerBase
    {
        private JobsUserSvc jobsUserSvc;

        public JobsUserController()
        {
            jobsUserSvc = new JobsUserSvc();
        }
        [HttpGet]
       
        public IActionResult GetAllUser()
        {
            var res = new SingleRsp();
            res.Data = jobsUserSvc.All;
            return Ok(res);
        }
        [HttpGet("get-by-{id}")]
        public IActionResult GetByUSerId(int Id)
        {
            var res = new SingleRsp();
            res.Data = jobsUserSvc.Read(Id);
            if (res.Data == null)
            {
                res.SetMessage("Lỗi hệ thống!!!");
                return NotFound();
            }

            return Ok(res);
        }
        [HttpGet("get-by-{Username}")]
        public IActionResult GetUserNameUser(string Username)
        {
            var res = new SingleRsp();
            res.Data = jobsUserSvc.Read(Username);
            if (res.Data == null)
            {
                res.SetMessage("Lỗi hệ thống!!!");
                return NotFound();
            }

            return Ok(res);
        }

        [HttpPost]
        public IActionResult CreateUser([FromBody] UserRequest userRequest)
        {
            //var user = new JobsUser
            //{
            //    Id = jobsUser.Id,
            //    Username = jobsUser.Username,
            //    FirstName = jobsUser.FirstName,
            //    LastName = jobsUser.LastName

            //};
            //jobsUserSvc.Add(user);

            //return Ok("them thanh cong");
            var res = new SingleRsp();
            res = jobsUserSvc.CreateUser(userRequest);
            if (res.Data == null)
                return BadRequest();
            return CreatedAtAction("Get ID", res.Data);
        }
        [HttpPut("{id}")]
        public IActionResult Edit(int id, string FirstName, string Username, string LastName, string Email, string Password)
        {
            var res = new SingleRsp();
            if (jobsUserSvc.Read(id).Data == null)
            {
                res.SetMessage("Không có user!!!");
                res.SetError("Không tìm thấy dữ liệu user!!!");
                return BadRequest(res);
            }
            res = jobsUserSvc.UpdateUser(id, FirstName,Username,LastName,Email,Password );
            if (res.Data == null)
            {
                res.SetMessage("Lỗi hệ thống!!!");
                res.SetError("Lỗi từ hệ thống!!");
                return BadRequest(res);
            }
            return Ok(res);
        }
        [HttpDelete("delete")]
        public IActionResult DeleteUser([FromBody] IdReq idReq)
        {
            var res = new SingleRsp();
            res = jobsUserSvc.RemoveUser(idReq.Id);
            if (res.Data == null)
            {
                res.SetMessage("Không tìm thấy dữ liệu User!!!");
                return NotFound(res);
            }
            return Ok(res);
        }


    }
}