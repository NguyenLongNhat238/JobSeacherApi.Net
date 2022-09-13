
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Job.Common.DAL;
using Job.Common.Rsp;
using Job.DAL.Models;

namespace Job.DAL
{
    public class JobsPostRep : GenericRep<jobdbContext, JobsPost>
    {
        public JobsPostRep()
        {

        }
        public override JobsPost Read(int id)
        {
            var res = All.FirstOrDefault(j => j.Id == id);
            return res;

        }
        public JobsPost Remove(int id)
        {
            try
            {
                var res = Context.JobsPosts.Where(c => c.Id == id).First();
                Context.Remove(res);
                Context.SaveChanges();
                return res;
            }
            catch (Exception ex)
            {
                Console.Error.WriteLine(ex.Message);
                return null;
            }

        }
        public JobsPost Update(JobsPost p)
        {
            var jobsPost = Context.JobsPosts.FirstOrDefault(x => x.Id == p.Id);
            if (jobsPost != null)
            {
                jobsPost.Active = p.Active;
                jobsPost.UpdatedDate = DateTime.Now;
                jobsPost.Title = p.Title;
                jobsPost.Company = p.Company;
                jobsPost.Location = p.Location;
                jobsPost.FromSalary = p.FromSalary;
                jobsPost.ToSalary = p.ToSalary;
                jobsPost.Gender = p.Gender;
                jobsPost.Quantity = p.Quantity;
                jobsPost.Type = p.Type;
                jobsPost.TimeWork = p.TimeWork;
                jobsPost.Due = p.Due;
                jobsPost.Description = p.Description;
                jobsPost.MajorId = p.MajorId;
                jobsPost.UserId = p.UserId;

                Context.SaveChanges();
                return jobsPost;
            }
            return null;
        }

        public SingleRsp CreateJobsPost(JobsPost jobsPost)
        {
            var res = new SingleRsp();
            using (var context = new jobdbContext())
            {
                using (var tran = context.Database.BeginTransaction())
                {
                    try
                    {
                        var p = context.JobsPosts.Add(jobsPost);
                        context.SaveChanges();
                        tran.Commit();
                        res.Data = jobsPost;

                    }
                    catch (Exception ex)
                    {
                        tran.Rollback();
                        res.SetError(ex.StackTrace);
                    }
                }
            }
            return res;
        }


        public List<JobsPost> SearchJobsPost(string keyword, string type)
        {
            if (type == "Title")
                return All.Where(d => d.Title.Contains(keyword)).ToList();
            else
                if (type == "Company")
                return All.Where(d => d.Company.Contains(keyword)).ToList();
            else
                     if (type == "Location")
                return All.Where(d => d.Location.Contains(keyword)).ToList();
            else
                        if (type == "Major")
                return All.Where(d => d.Major.ToString().Contains(keyword)).ToList();
            else
                            if (type == "UserId")
                return All.Where(d => d.UserId.ToString().Contains(keyword)).ToList();
            return All.ToList();


        }


    }
}
