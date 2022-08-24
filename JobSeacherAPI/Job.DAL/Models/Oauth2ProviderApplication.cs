using System;
using System.Collections.Generic;

#nullable disable

namespace Job.DAL.Models
{
    public partial class Oauth2ProviderApplication
    {
        public Oauth2ProviderApplication()
        {
            Oauth2ProviderAccesstokens = new HashSet<Oauth2ProviderAccesstoken>();
            Oauth2ProviderGrants = new HashSet<Oauth2ProviderGrant>();
            Oauth2ProviderIdtokens = new HashSet<Oauth2ProviderIdtoken>();
            Oauth2ProviderRefreshtokens = new HashSet<Oauth2ProviderRefreshtoken>();
        }

        public long Id { get; set; }
        public string ClientId { get; set; }
        public string RedirectUris { get; set; }
        public string ClientType { get; set; }
        public string AuthorizationGrantType { get; set; }
        public string ClientSecret { get; set; }
        public string Name { get; set; }
        public long? UserId { get; set; }
        public short SkipAuthorization { get; set; }
        public DateTime Created { get; set; }
        public DateTime Updated { get; set; }
        public string Algorithm { get; set; }

        public virtual JobsUser User { get; set; }
        public virtual ICollection<Oauth2ProviderAccesstoken> Oauth2ProviderAccesstokens { get; set; }
        public virtual ICollection<Oauth2ProviderGrant> Oauth2ProviderGrants { get; set; }
        public virtual ICollection<Oauth2ProviderIdtoken> Oauth2ProviderIdtokens { get; set; }
        public virtual ICollection<Oauth2ProviderRefreshtoken> Oauth2ProviderRefreshtokens { get; set; }
    }
}
