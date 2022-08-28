using Job.Common.DAL;
using System;
using System.Collections.Generic;
using System.Text;
using Job.DAL.Models;
using System.Linq;

namespace Job.DAL
{
    public class CommentRep: GenericRep<jobdbContext,JobsComment>
    {
        public CommentRep()
        {

        }
        public List<JobsComment> GetAll()
        {

            var all = Context.JobsComments.Select(x=>x).ToList();
            return all;

        }
        public List<JobsComment> ReadById(int id)
        {
            //id hirer
            try
            {
                var list = Context.JobsComments.Where(c => c.HirerId == id).ToList();
                System.Diagnostics.Debug.WriteLine(list);
                return list;
            }
            catch (Exception)
            {

                throw;
            }
    
         
            //return base.Read(id);
        }
        public  JobsComment Delete(int id)
        {
            //id comment item
         
            var res = Context.JobsComments.Where(c => c.Id == id).First();
            Context.Remove(res);
            Context.SaveChanges();
            return res;
        }
        public JobsComment Create(JobsComment c)
        {
            try
            {
            
                Context.Add(c);
                Context.SaveChanges();
                return c;
                //return base.Read(id);
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
