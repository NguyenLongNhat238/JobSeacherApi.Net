using System;
using System.Collections.Generic;

#nullable disable

namespace Job.DAL.Models
{
    public partial class JobsApply
    {
        public long Id { get; set; }
        public short Active { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime UpdatedDate { get; set; }
        public string Description { get; set; }
        public long PostId { get; set; }
        public long UserId { get; set; }
        public string Cv { get; set; }

        public virtual JobsPost Post { get; set; }
        public virtual JobsUser User { get; set; }
    }
}
