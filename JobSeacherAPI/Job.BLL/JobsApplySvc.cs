using Job.Common.BLL;
using Job.Common.Rsp;
using Job.DAL;
using Job.DAL.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Job.BLL
{
    public class JobsApplySvc : GenericSvc<JobsApplyRep, JobsApply>
    {
        private JobsApplyRep jobsApplyRep;
        public JobsApplySvc()
        {
            jobsApplyRep = new JobsApplyRep();
        }

        public override SingleRsp Read(int id)
        {
            var res = new SingleRsp();
            res.Data = _rep.Read(id);
            return res;
        }

        public SingleRsp Remove(int id)
        {
            var res = new SingleRsp();
            res.Data = _rep.Remove(id);
            if (res.Data == null)
            {
                res.SetMessage(@"Không thể xóa do một lý do nào đó!!1");
            }
            else
            {
                res.SetMessage(@"Xóa thành công!!!");
            }
            return res;
        }
    }
}
