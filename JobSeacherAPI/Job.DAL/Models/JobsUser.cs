using System;
using System.Collections.Generic;

#nullable disable

namespace Job.DAL.Models
{
    public partial class JobsUser
    {
        public JobsUser()
        {
            DjangoAdminLogs = new HashSet<DjangoAdminLog>();
            JobsApplies = new HashSet<JobsApply>();
            JobsCommentCreators = new HashSet<JobsComment>();
            JobsCommentHirers = new HashSet<JobsComment>();
            JobsPosts = new HashSet<JobsPost>();
            JobsRatingCreators = new HashSet<JobsRating>();
            JobsRatingHirers = new HashSet<JobsRating>();
            JobsTokens = new HashSet<JobsToken>();
            JobsUserGroups = new HashSet<JobsUserGroup>();
            JobsUserUserPermissions = new HashSet<JobsUserUserPermission>();
            JobsWaitings = new HashSet<JobsWaiting>();
            Oauth2ProviderAccesstokens = new HashSet<Oauth2ProviderAccesstoken>();
            Oauth2ProviderApplications = new HashSet<Oauth2ProviderApplication>();
            Oauth2ProviderGrants = new HashSet<Oauth2ProviderGrant>();
            Oauth2ProviderIdtokens = new HashSet<Oauth2ProviderIdtoken>();
            Oauth2ProviderRefreshtokens = new HashSet<Oauth2ProviderRefreshtoken>();
        }

        public long Id { get; set; }
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

        public virtual AuthtokenToken AuthtokenToken { get; set; }
        public virtual ICollection<DjangoAdminLog> DjangoAdminLogs { get; set; }
        public virtual ICollection<JobsApply> JobsApplies { get; set; }
        public virtual ICollection<JobsComment> JobsCommentCreators { get; set; }
        public virtual ICollection<JobsComment> JobsCommentHirers { get; set; }
        public virtual ICollection<JobsPost> JobsPosts { get; set; }
        public virtual ICollection<JobsRating> JobsRatingCreators { get; set; }
        public virtual ICollection<JobsRating> JobsRatingHirers { get; set; }
        public virtual ICollection<JobsToken> JobsTokens { get; set; }
        public virtual ICollection<JobsUserGroup> JobsUserGroups { get; set; }
        public virtual ICollection<JobsUserUserPermission> JobsUserUserPermissions { get; set; }
        public virtual ICollection<JobsWaiting> JobsWaitings { get; set; }
        public virtual ICollection<Oauth2ProviderAccesstoken> Oauth2ProviderAccesstokens { get; set; }
        public virtual ICollection<Oauth2ProviderApplication> Oauth2ProviderApplications { get; set; }
        public virtual ICollection<Oauth2ProviderGrant> Oauth2ProviderGrants { get; set; }
        public virtual ICollection<Oauth2ProviderIdtoken> Oauth2ProviderIdtokens { get; set; }
        public virtual ICollection<Oauth2ProviderRefreshtoken> Oauth2ProviderRefreshtokens { get; set; }
    }
}
