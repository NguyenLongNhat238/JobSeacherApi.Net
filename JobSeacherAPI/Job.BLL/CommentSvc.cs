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
            res.Data = _rep.ReadById(id);
            return res;
        }
        public SingleRsp ReadCommentId(int id)
        {
            var res = new SingleRsp();
            res.Data = _rep.Read(id);
            return res;
        }
        public SingleRsp CreateComment(int creatorId, int targetId, string content)
        {
            JobsComment jobsComment = new JobsComment();
            jobsComment.CreatorId = creatorId;
            jobsComment.HirerId = targetId;
            jobsComment.Content = content;
            jobsComment.CreatedDate = DateTime.Now;
            jobsComment.UpdatedDate = DateTime.Now;
            jobsComment.Active = 1;

            return Create(jobsComment);
        }
        public override SingleRsp Create(JobsComment c)
        {
            var res = new SingleRsp();
            res.Data = _rep.Create(c);
            return res;
        }

        public SingleRsp Remove(int id)
        {
            var res = new SingleRsp();
            res.Data = _rep.Delete(id);
            if (res.Data == null)
            {
                res.SetMessage(@"Không tìm thấy dữ liệu để xóa!!!");
            }
            else
            {
                res.SetMessage(@"Xóa thành công!!!");
            }
            return res;
        }
        public SingleRsp UpdateComment(int id, string content)
        {
            var res = new SingleRsp();

            JobsComment jobsComment = new JobsComment();
            jobsComment.Content = content;
            jobsComment.Id = id;
            jobsComment.UpdatedDate = DateTime.Now;
            res.Data = _rep.Update(jobsComment);


            return res;
        }



    }
}
