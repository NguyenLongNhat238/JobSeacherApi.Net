using System;
using System.Collections.Generic;
using System.Text;

namespace Job.Common.Req
{
    public  class CommentPostRequest
    {



        /// <summary>
        /// CreatorId
        /// </summary>
        public int CreatorId { get; set; }

        /// <summary>
        /// TargetId
        /// </summary>
        public int TargetId { get; set; }

        /// <summary>
        /// Content
        /// </summary>
        public string Content { get; set; }

    }
}
