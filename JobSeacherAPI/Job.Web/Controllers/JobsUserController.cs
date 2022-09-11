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

        public static List<JobsUser> Users = new List<JobsUser>();
        [HttpGet]
        //public List<JobsUser> GeAlltUsers()
        //{
        //    var db = new jobdbContext();
        //    return db.JobsUsers.ToList();
        //}
        public IActionResult GetAllUser()
        {
            var res = new SingleRsp();
            res.Data = jobsUserSvc.All;
            return Ok(res);
        }
        [HttpGet("get-by-{id}")]
        public IActionResult GetIdUser(long id)
        {
            try
            {
                var user = Users.SingleOrDefault(idd => idd.Id == id);
                if (user == null)
                {
                    return NotFound();
                }
                else
                {
                    return Ok(user);
                }
            }
            catch
            {
                return BadRequest();
            }
        }
        [HttpGet("get-by-{Username}")]
        public IActionResult GetUserNameUser(string Username)
        {
            try
            {
                var user = Users.SingleOrDefault(name => name.Username == Username);
                if (user == null)
                {
                    return NotFound();
                }

                else
                {
                    return Ok(user);
                }
            }
            catch
            {
                return BadRequest();
            }
        }

        [HttpPost]
        public IActionResult Create(JobsUser jobsUser)
        {
            var user = new JobsUser
            {
                Id = jobsUser.Id,
                Username = jobsUser.Username,
                FirstName = jobsUser.FirstName,
                LastName = jobsUser.LastName

            };
            Users.Add(user);

            return Ok("them thanh cong");
        }
        [HttpPut("{id}")]
        public IActionResult Edit(long id, JobsUser editUser)
        {
            try
            {
                var user = Users.SingleOrDefault(idd => idd.Id == id);
                if (user == null)
                {
                    return NotFound();
                }
                else//tiến hành update
                {
                    user.Username = editUser.Username;
                    user.FirstName = editUser.FirstName;
                    user.LastName = editUser.LastName;
                    user.Email = editUser.Email;
                    user.Password = editUser.Password;
                    return Ok();

                }
            }
            catch
            {
                return BadRequest();
            }
        }
        [HttpDelete("{id}")]
        public IActionResult RemoveId(long id)
        {
            try
            {
                var user = Users.SingleOrDefault(idd => idd.Id == id);
                if (user == null)
                {
                    return NotFound();
                }
                Users.Remove(user);
                return Ok();
            }
            catch
            {
                return BadRequest();
            }
        }


    }
}