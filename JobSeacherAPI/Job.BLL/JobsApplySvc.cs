using Job.Common.BLL;
using Job.Common.Req;
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
            res.Data = _rep.Delete(id);
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
            
        public SingleRsp CreateApply(CreateApplyReq createApplyReq)
        {
            var res = new SingleRsp();
            JobsApply jobsApply = new JobsApply();
            jobsApply.Description = createApplyReq.Description;
            jobsApply.PostId = createApplyReq.PostId;
            jobsApply.UserId = createApplyReq.UserId;
            jobsApply.Cv = createApplyReq.Cv;
            res.Data = _rep.Create(jobsApply);
            return res;
        }

        public SingleRsp UpdateApply(int id, CreateApplyReq createApplyReq)
        {
            var res = new SingleRsp();
            JobsApply jobsApply = new JobsApply();
            jobsApply.Id = id;
            jobsApply.Description = createApplyReq.Description;
            jobsApply.Cv = createApplyReq.Cv;
            res.Data = _rep.Update(jobsApply);
            return res;
        }

        public SingleRsp CheckApply(CreateApplyReq createApplyReq)
        {
            var res = new SingleRsp();
            if (_rep.CheckPostUser(createApplyReq.PostId, createApplyReq.UserId) == true)
            {
                res.Data = null;
            }
            else res.Data = createApplyReq;
            return res;
        }
    }
}
