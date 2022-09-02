using System;
using System.Collections.Generic;
using System.Text;

namespace Job.Common.Req
{
    public class CreateApplyReq
    {
        public string Description { get; set; }
        public int PostId { get; set; }
        public int UserId { get; set; }
        public string Cv { get; set; }
    }
}
