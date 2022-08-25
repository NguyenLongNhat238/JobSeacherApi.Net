using Job.Common.DAL;
using Job.DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Job.DAL
{
    public class JobsMajorRep : GenericRep<jobdbContext, JobsMajor>
    {
        public JobsMajorRep()
        {

        }

        #region -- overrides --
        public override JobsMajor Read(int id)
        {
            var res = All.FirstOrDefault(p => p.Id == id);
            return res;
        }

        //public int Remove(int id)
        //{
        //    var m = base.All.First(i => i.Id == id);
        //    m = base.Delete(m);
        //}
        #endregion

        #region --Method--
        public List<JobsMajor> Read(string keyword)
        {
            return All.Where(i => i.Name.Contains(keyword)).ToList();
        }

        public List<JobsMajor> ReadCate(int cateID)
        {
            return All.Where(i => i.CategoryId == cateID).ToList();
        }
        #endregion
    }
}
