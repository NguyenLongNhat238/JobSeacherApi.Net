using System;
using System.Collections.Generic;

#nullable disable

namespace Job.DAL.Models
{
    public partial class JobsToken
    {
        public long Id { get; set; }
        public string Token { get; set; }
        public long UserId { get; set; }

        public virtual JobsUser User { get; set; }
    }
}
