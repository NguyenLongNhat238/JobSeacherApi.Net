using System;
using Job.Common.Rsp;
using Job.DAL;
using Job.DAL.Models;

namespace Job.BLL
{
    public class CommentSvc: Common.BLL.GenericSvc<CommentRep, JobsComment>
    {
        private CommentRep commentRep;
        public CommentSvc()
        {
            commentRep = new CommentRep();
        }
        public override SingleRsp Read(int id)
        {
            var res = new SingleRsp();
            res.Data = _rep.Read(id);
            return base.Read(id);
        }
        public SingleRsp CreateComment(int creatorId, int targetId, string content)
        {
            JobsComment jobsComment = new JobsComment();
            jobsComment.CreatorId = creatorId;
            jobsComment.HirerId = targetId;
            jobsComment.Content = content;
            jobsComment.CreatedDate = new DateTime();
            jobsComment.Active = 1;

            return Create(jobsComment);
        }
        public override SingleRsp Create(JobsComment c)
        {
            var res = new SingleRsp();
            res.Data = _rep.Create(c);
            return base.Create(c);
        }


    }
}
