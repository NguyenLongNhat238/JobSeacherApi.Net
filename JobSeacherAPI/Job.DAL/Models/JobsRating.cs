using System;
using System.Collections.Generic;

#nullable disable

namespace Job.DAL.Models
{
    public partial class JobsRating
    {
        public long Id { get; set; }
        public short Active { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime UpdatedDate { get; set; }
        public short Rate { get; set; }
        public long CreatorId { get; set; }
        public long HirerId { get; set; }

        public virtual JobsUser Creator { get; set; }
        public virtual JobsUser Hirer { get; set; }
    }
}
