using System;
using System.Collections.Generic;
using System.Text;

namespace Job.Common.Req
{
    public class SearchJobsPost
    {
        public string Keyword { get; set; }
        public int Page { get; set; }
        public int Size { get; set; }
        public string Type { get; set; }

    }
}
