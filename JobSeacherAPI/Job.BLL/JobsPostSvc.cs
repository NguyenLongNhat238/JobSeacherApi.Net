using Job.Common.BLL;
using Job.Common.Req;
using Job.Common.Rsp;
using Job.DAL;
using Job.DAL.Models;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Job.BLL
{
    public class JobsPostSvc : GenericSvc<JobsPostRep, JobsPost>
    {
        private JobsPostRep jobsPostRep;
        public JobsPostSvc()
        {
            jobsPostRep = new JobsPostRep();

        }
        public override SingleRsp Read(int id)
        {
            var res = new SingleRsp();
            res.Data = _rep.Read(id);
            return res;
        }
        public SingleRsp RemoveJobsPost(int id)
        {
            var res = new SingleRsp();
            res.Data = _rep.Remove(id);
            if (res.Data == null)
            {
                res.SetMessage(@"Không tìm thấy!!!");
            }
            else
            {
                res.SetMessage(@"Xóa thành công!!!");
            }
            return res;
        }
        public override SingleRsp Update(JobsPost p)
        {
            var res = new SingleRsp();
            var p1 = p.Id > 0 ? _rep.Read((int)p.Id) : _rep.Read((int)p.Id);
            if (p1 == null)
            {
                res.SetError("EZ103", "No Data.");

            }
            else
            {
                res.Data = jobsPostRep.Update(p);
                res.Data = p;
            }
            return res;

            
          
           
           
          
        }
        public SingleRsp CreateJobsPost(JobsPostReq jobsPostReq)
        {
            var res = new SingleRsp();
            JobsPost jobsPost = new JobsPost();
            // jobsPost.Id
            jobsPost.Active = 1;
            jobsPost.CreatedDate = DateTime.Now;
            jobsPost.UpdatedDate = DateTime.Now;
            jobsPost.Title = jobsPostReq.Title;
            jobsPost.Company = jobsPostReq.Company;
            jobsPost.Location = jobsPostReq.Location;
            //   jobsPost.FromSalary = jobsPostReq.FromSalary;
            //  jobsPost.ToSalary = jobsPostReq.ToSalary;
            jobsPost.Gender = jobsPostReq.Gender;
            // jobsPost.Quantity = jobsPostReq.Quantity;
            jobsPost.Type = jobsPostReq.Type;
            jobsPost.TimeWork = jobsPostReq.TimeWork;
            jobsPost.Due = DateTime.Now;
            jobsPost.Description = jobsPostReq.Description;
            jobsPost.MajorId = jobsPostReq.MajorId;
            jobsPost.UserId = jobsPostReq.UserId;
            res = jobsPostRep.CreateJobsPost(jobsPost);
            return res;

        }
        public SingleRsp SearchJobsPost(SearchJobsPost s)
        {
            var res = new SingleRsp();
            var jobsPosts = jobsPostRep.SearchJobsPost(s.Keyword, s.Type);

            int start = (s.Page - 1) * s.Size;
            int count, totalPages;
            count = jobsPosts.Count;
            totalPages = (count % s.Size) == 0 ? count / s.Size : 1 + (count / s.Size);
            var o = new
            {
                Data = jobsPosts.Skip(start).Take(s.Size).ToList(),
                Page = s.Page,
                Size = s.Size,
                Type = s.Type
            };
            res.Data = o;
            return res;
        }


    }
}
