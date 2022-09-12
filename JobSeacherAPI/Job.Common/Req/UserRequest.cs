using System;
using System.Collections.Generic;
using System.Text;

namespace Job.Common.Req
{
   public class UserRequest
    {
        public int Id { get; set; }
        public string Password { get; set; }
        public DateTime? LastLogin { get; set; }
        public short IsSuperuser { get; set; }
        public string Username { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public short IsStaff { get; set; }
        public short IsActive { get; set; }
        public DateTime DateJoined { get; set; }
        public string Avatar { get; set; }
        public int UserRole { get; set; }
    }
}
