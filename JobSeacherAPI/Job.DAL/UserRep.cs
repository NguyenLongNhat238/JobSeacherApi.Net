using Job.Common.DAL;
using Job.DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Job.DAL
{
    public class UserRep : GenericRep<jobdbContext, JobsUser>
    {
        public UserRep()
        {

        }
        public List<JobsUser> GetAll()
        {

            var all = Context.JobsUsers.Select(x => x).ToList();
            return all;

        }
        public List<JobsUser> ReadById(int id)
        {

            try
            {
                var list = Context.JobsUsers.Where(c => c.Id == id).ToList();
                System.Diagnostics.Debug.WriteLine(list);
                return list;
            }
            catch (Exception)
            {

                throw;
            }



        }
        public JobsUser Delete(int id)
        {


            var res = Context.JobsUsers.Where(c => c.Id == id).First();
            Context.Remove(res);
            Context.SaveChanges();
            return res;
        }
        public JobsUser Create(JobsUser c)
        {
            try
            {

                Context.Add(c);
                Context.SaveChanges();
                return c;

            }
            catch (Exception)
            {

                throw;
            }
        }
        public JobsUser UpdateUser(JobsUser c)
        {
            var entity = Context.JobsUsers.FirstOrDefault(i => i.Id == c.Id);
            if (entity != null)
            {
                entity.Username = c.Username;
                entity.FirstName = c.FirstName;
                entity.LastName = c.LastName;
                entity.Email = c.Email;
                Context.SaveChanges();
                return entity;
            }
            return null;
        }

    }
}
