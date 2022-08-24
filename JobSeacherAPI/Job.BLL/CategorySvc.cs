using Job.Common.BLL;
using Job.Common.Rsp;
using Job.DAL;
using Job.DAL.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Job.BLL
{
    public class CategorySvc : GenericSvc<CategoryRep, JobsCategory>
    {
        private CategoryRep categoryRep;
        public CategorySvc()
        {
            categoryRep = new CategoryRep();
        }
        #region
        public override SingleRsp Read(int id)
        {
            var res = new SingleRsp();
            res.Data = _rep.Read(id);
            return res;
        }
        #endregion
    }
}
