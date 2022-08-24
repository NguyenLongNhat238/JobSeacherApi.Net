using System;
using System.Collections.Generic;

#nullable disable

namespace Job.DAL.Models
{
    public partial class JobsCategory
    {
        public JobsCategory()
        {
            JobsMajors = new HashSet<JobsMajor>();
        }

        public long Id { get; set; }
        public short Active { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime UpdatedDate { get; set; }
        public string Name { get; set; }

        public virtual ICollection<JobsMajor> JobsMajors { get; set; }
    }
}
