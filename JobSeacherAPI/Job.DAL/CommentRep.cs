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
        public override JobsComment Read(int id)
        {
            //id hirer
            var res = All.FirstOrDefault(c => c.HirerId == id);
            return res;
            //return base.Read(id);
        }
        public JobsComment Create(JobsComment c)
        {
            try
            {
                //id hirer
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
