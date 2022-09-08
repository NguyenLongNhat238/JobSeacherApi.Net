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
        public override JobsComment Read(int id)
        {
            return All.FirstOrDefault(a => a.Id == id);
        }

        public List<JobsComment> ReadById(int id)
        {
            //id hirer
            try
            {
                var list = All.Where(c => c.HirerId == id).ToList();
                System.Diagnostics.Debug.WriteLine(list);
                return list;
            }
            catch (Exception ex)
            {
                Console.Error.WriteLine(ex.Message);
                return null;

            }
    
         
            //return base.Read(id);
        }
        public  JobsComment Delete(int id)
        {
            //id comment item
            try
            {
                var res = Context.JobsComments.Where(c => c.Id == id).First();
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
        public JobsComment Create(JobsComment c)
        {
            try
            {
            
                Context.Add(c);
                Context.SaveChanges();
                return c;
                //return base.Read(id);
            }
            catch (Exception ex)
            {
                Console.Error.WriteLine(ex.Message);
                return null;

            }
        }
        public JobsComment Update(JobsComment c)
        {
            var entity = Context.JobsComments.FirstOrDefault(i => i.Id == c.Id);
            if (entity != null)
            {
                entity.Content = c.Content;
                entity.UpdatedDate = DateTime.Now;
                Context.SaveChanges();
                return entity;
            }
            return null;
        }

    }
}
