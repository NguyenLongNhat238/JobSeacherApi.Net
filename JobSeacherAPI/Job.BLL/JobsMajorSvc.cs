using Job.Common.BLL;
using Job.Common.Rsp;
using Job.DAL;
using Job.DAL.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Job.BLL
{
    public class JobsMajorSvc: GenericSvc<JobsMajorRep, JobsMajor>
    {
        private JobsMajorRep jobsMajorRep;
        public JobsMajorSvc()
        {
            jobsMajorRep = new JobsMajorRep();
        }

        #region
        public override SingleRsp Read(int id)
        {
            var res = new SingleRsp();
            res.Data = _rep.Read(id);
            return res;
        }
        #endregion

        public SingleRsp Read(string keyword)
        {
            var res = new SingleRsp();
            res.Data = _rep.Read(keyword);
            return res;
        }
    }
}
