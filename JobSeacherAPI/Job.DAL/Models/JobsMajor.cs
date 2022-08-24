using System;
using System.Collections.Generic;

#nullable disable

namespace Job.DAL.Models
{
    public partial class JobsMajor
    {
        public JobsMajor()
        {
            JobsPosts = new HashSet<JobsPost>();
        }

        public long Id { get; set; }
        public short Active { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime UpdatedDate { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public long? CategoryId { get; set; }

        public virtual JobsCategory Category { get; set; }
        public virtual ICollection<JobsPost> JobsPosts { get; set; }
    }
}
