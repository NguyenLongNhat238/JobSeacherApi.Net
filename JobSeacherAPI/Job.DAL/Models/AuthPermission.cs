using System;
using System.Collections.Generic;

#nullable disable

namespace Job.DAL.Models
{
    public partial class AuthPermission
    {
        public AuthPermission()
        {
            AuthGroupPermissions = new HashSet<AuthGroupPermission>();
            JobsUserUserPermissions = new HashSet<JobsUserUserPermission>();
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public int ContentTypeId { get; set; }
        public string Codename { get; set; }

        public virtual DjangoContentType ContentType { get; set; }
        public virtual ICollection<AuthGroupPermission> AuthGroupPermissions { get; set; }
        public virtual ICollection<JobsUserUserPermission> JobsUserUserPermissions { get; set; }
    }
}
