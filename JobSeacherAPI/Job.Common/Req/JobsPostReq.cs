using System;
using System.Collections.Generic;
using System.Text;

namespace Job.Common.Req
{
    public class JobsPostReq
    {
        public int Id { get; set; }
        public bool Active { get; set; }
        public DateTime CreateDate { get; set; }

        public DateTime UpdateDate { get; set; }
        public string Title { get; set; }
        public string Company { get; set; }
        public string Location { get; set; }
        public decimal FromSalary { get; set; }
        public decimal ToSalary { get; set; }
        public string Gender { get; set; }
        public int Quantity { get; set; }
        public string Type { get; set; }
        public string TimeWork { get; set; }
        public DateTime Due { get; set; }
        public string Description { get; set; }

        public int MajorId { get; set; }
        public int UserId { get; set; }



    }
}
