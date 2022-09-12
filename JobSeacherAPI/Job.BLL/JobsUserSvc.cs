using Job.Common.Req;
using Job.Common.Rsp;
using Job.DAL;
using Job.DAL.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Job.BLL
{
    public class JobsUserSvc : Common.BLL.GenericSvc<UserRep, JobsUser>
    {
        private UserRep userRep;
        public JobsUserSvc()
        {
            userRep = new UserRep();
        }
        public override SingleRsp Read(int id)
        {
            var res = new SingleRsp();
            res.Data = _rep.Read(id);
            return base.Read(id);
        }
        public override SingleRsp Create(JobsUser c)
        {
            var res = new SingleRsp();
            res.Data = _rep.Create(c);
            return base.Create(c);
        }
        public SingleRsp CreateUser(UserRequest userRequest)
        {
            //JobsUser jobsUser = new JobsUser();
            //jobsUser.Id = id;
            //jobsUser.Username = Username;
            //jobsUser.FirstName = FirstName;
            //jobsUser.LastName = LastName;
            //jobsUser.Email = Email;
            //jobsUser.Password = Password;
            //return Create(jobsUser);
            var res = new SingleRsp();
            JobsUser jobsUser = new JobsUser();
            jobsUser.Username = userRequest.Username;
            jobsUser.FirstName = userRequest.FirstName;
            jobsUser.LastName = userRequest.LastName;
            jobsUser.Email = userRequest.Email;
            jobsUser.Password = userRequest.Password;
            jobsUser.IsStaff =0;
            jobsUser.IsActive = 1;
            jobsUser.UserRole = 2;
            res.Data = _rep.Create(jobsUser);
            return res;
        }
        
        public SingleRsp RemoveUser(int id)
        {
            var res = new SingleRsp();
            res.Data = _rep.Delete(id);
            if (res.Data == null)
            {
                res.SetMessage(@"Không tìm thấy dữ liệu người dùng để xóa!!!");
            }
            else
            {
                res.SetMessage(@"Xóa thành công!!!");
            }
            return res;
        }
        public SingleRsp UpdateUser(int id, string FirstName, string Username, string LastName, string Email,string Password)
        {
            var res = new SingleRsp();

            JobsUser jobsUser = new JobsUser();
            jobsUser.Id = id;
            jobsUser.Username = Username;
            jobsUser.FirstName = FirstName;
            jobsUser.LastName = LastName;
            jobsUser.Email = Email;
            jobsUser.Password = Password;
            return res;
        }
    }
}
