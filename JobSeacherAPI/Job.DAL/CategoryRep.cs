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
        public CategoryRep()
        {

        }
        #region --Overrides--
        public override JobsCategory Read(int id)
        {
            var res = All.FirstOrDefault(c => c.Id == id);
            return res;
        }

        #endregion
    }
}
