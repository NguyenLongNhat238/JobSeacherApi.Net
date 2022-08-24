using System;
using System.Collections.Generic;

#nullable disable

namespace Job.DAL.Models
{
    public partial class JobsUserUserPermission
    {
        public long Id { get; set; }
        public long UserId { get; set; }
        public int PermissionId { get; set; }

        public virtual AuthPermission Permission { get; set; }
        public virtual JobsUser User { get; set; }
    }
}
