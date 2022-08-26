using Job.Common.DAL;
using Job.DAL.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace Job.DAL
{
    public class CategoryRep:GenericRep<jobdbContext, JobsCategory>
    {
        private JobsMajorRep jobsMajorRep;
        public CategoryRep()
        {
            jobsMajorRep = new JobsMajorRep();
        }
        #region --Overrides--
        public override JobsCategory Read(int id)
        {
            var res = All.FirstOrDefault(c => c.Id == id);
            res.JobsMajors = jobsMajorRep.All.Where(i => i.CategoryId == id).ToList();
            return res;
        }

        #endregion
        #region --Method--
        public List<JobsCategory> Read(string keyword)
        {
            return All.Where(i => i.Name.Contains(keyword)).ToList();
        }
        #endregion
    }
}
