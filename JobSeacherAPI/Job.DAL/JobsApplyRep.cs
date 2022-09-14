using Job.Common.DAL;
using Job.Common.Rsp;
using Job.DAL.Models;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;

namespace Job.DAL
{
    public class JobsApplyRep : GenericRep<jobdbContext, JobsApply>
    {
        public override JobsApply Read(int id)
        {
            return All.FirstOrDefault(a => a.Id == id);
        }
        public bool CheckPostUser(int postID, int userID)
        {
            int count = All.Where(i => i.PostId == postID && i.UserId == userID).Count();
            if (count > 0) return true;
            return false;
        }
        public int Remove(int id)
        {
            var m = base.All.First(i => i.Id == id);
            m = base.Delete(m);
            return (int)m.Id;
        }

        public SingleRsp Delete(int id)
        {
            //id comment item
            var res = new SingleRsp();
            using (var context = new jobdbContext())
            {
                using (var tran = context.Database.BeginTransaction())
                {
                    try
                    {
                        var p = context.JobsApplies.Where(c => c.Id == id).First();
                        context.Remove(res);
                        context.SaveChanges();
                        tran.Commit();
                        res.Data = p;

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
        public JobsApply Create(JobsApply jobsApply)
        {
            //try
            //{
            //    Context.Add(jobsApply);
            //    Context.SaveChanges();
            //    return jobsApply;
            //    //return base.Read(id);       
            //}
            //catch (Exception ex)
            //{
            //    Console.WriteLine(ex.Message);
            //    return null;
            //}
            try
            {
                var exists = new SqlParameter("@create", -1);
                Context.Database.ExecuteSqlRawAsync("exec CreateApply {0},  {1}, {2}, {3}, {4} output", jobsApply.Description, jobsApply.PostId, jobsApply.UserId, jobsApply.Cv, exists);
                int ret = Convert.ToInt32(exists.Value);
                //await _context.Database.ExecuteSqlRawAsync("exec CreateApply {0},  {1}, {2}, {3}, {4} output", jobsApply.Description, jobsApply.PostID, jobsApply.UserId, jobsApply.Cv);
                if (ret == 0)
                    return null;
                return jobsApply;
            }
            catch (Exception ex)
            {
                Console.Error.WriteLine(ex.Message);
                return null;
                //throw;
            }
        }

        public SingleRsp Update(JobsApply jobsApply)
        {
            var res = new SingleRsp();
            using (var context = new jobdbContext())
            {
                using (var tran = context.Database.BeginTransaction())
                {
                    try
                    {
                        var entity = context.JobsApplies.FirstOrDefault(i => i.Id == jobsApply.Id);
                        if (entity != null)
                        {
                            entity.Description = jobsApply.Description;
                            entity.Cv = jobsApply.Cv;
                            entity.UpdatedDate = DateTime.Now;
                            context.SaveChanges();
                            tran.Commit();
                            res.Data = jobsApply;
                        }
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
    }
}
