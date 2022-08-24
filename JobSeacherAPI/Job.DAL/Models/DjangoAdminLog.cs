using System;
using System.Collections.Generic;

#nullable disable

namespace Job.DAL.Models
{
    public partial class DjangoAdminLog
    {
        public int Id { get; set; }
        public DateTime ActionTime { get; set; }
        public string ObjectId { get; set; }
        public string ObjectRepr { get; set; }
        public int ActionFlag { get; set; }
        public string ChangeMessage { get; set; }
        public int? ContentTypeId { get; set; }
        public long UserId { get; set; }

        public virtual DjangoContentType ContentType { get; set; }
        public virtual JobsUser User { get; set; }
    }
}
