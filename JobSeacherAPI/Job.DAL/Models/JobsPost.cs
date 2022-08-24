using System;
using System.Collections.Generic;

#nullable disable

namespace Job.DAL.Models
{
    public partial class JobsPost
    {
        public JobsPost()
        {
            JobsApplies = new HashSet<JobsApply>();
        }

        public long Id { get; set; }
        public short Active { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime UpdatedDate { get; set; }
        public string Title { get; set; }
        public string Company { get; set; }
        public string Location { get; set; }
        public double? FromSalary { get; set; }
        public double? ToSalary { get; set; }
        public string Gender { get; set; }
        public int? Quantity { get; set; }
        public string Type { get; set; }
        public string TimeWork { get; set; }
        public DateTime? Due { get; set; }
        public string Description { get; set; }
        public long MajorId { get; set; }
        public long UserId { get; set; }

        public virtual JobsMajor Major { get; set; }
        public virtual JobsUser User { get; set; }
        public virtual ICollection<JobsApply> JobsApplies { get; set; }
    }
}
