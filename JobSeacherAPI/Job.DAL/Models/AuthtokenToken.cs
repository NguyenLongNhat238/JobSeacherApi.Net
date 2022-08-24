using System;
using System.Collections.Generic;

#nullable disable

namespace Job.DAL.Models
{
    public partial class AuthtokenToken
    {
        public string Key { get; set; }
        public DateTime Created { get; set; }
        public long UserId { get; set; }

        public virtual JobsUser User { get; set; }
    }
}
