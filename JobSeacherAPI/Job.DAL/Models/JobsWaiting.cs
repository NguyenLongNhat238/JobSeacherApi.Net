using System;
using System.Collections.Generic;

#nullable disable

namespace Job.DAL.Models
{
    public partial class JobsWaiting
    {
        public long Id { get; set; }
        public short Active { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime UpdatedDate { get; set; }
        public long? UserId { get; set; }

        public virtual JobsUser User { get; set; }
    }
}
