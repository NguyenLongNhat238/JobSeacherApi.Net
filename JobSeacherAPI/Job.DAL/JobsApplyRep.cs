using Job.Common.DAL;
using Job.DAL.Models;
using System;
using System.Collections.Generic;
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
        public int Remove(int id)
        {
            var m = base.All.First(i => i.Id == id);
            m = base.Delete(m);
            return (int)m.Id;
        }
    }
}
