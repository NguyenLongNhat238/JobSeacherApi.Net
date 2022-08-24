using System;
using System.Collections.Generic;

#nullable disable

namespace Job.DAL.Models
{
    public partial class AuthGroup
    {
        public AuthGroup()
        {
            AuthGroupPermissions = new HashSet<AuthGroupPermission>();
            JobsUserGroups = new HashSet<JobsUserGroup>();
        }

        public int Id { get; set; }
        public string Name { get; set; }

        public virtual ICollection<AuthGroupPermission> AuthGroupPermissions { get; set; }
        public virtual ICollection<JobsUserGroup> JobsUserGroups { get; set; }
    }
}
