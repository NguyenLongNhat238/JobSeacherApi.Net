using System;
using System.Collections.Generic;

#nullable disable

namespace Job.DAL.Models
{
    public partial class JobsUserGroup
    {
        public long Id { get; set; }
        public long UserId { get; set; }
        public int GroupId { get; set; }

        public virtual AuthGroup Group { get; set; }
        public virtual JobsUser User { get; set; }
    }
}
