using System;
using System.Collections.Generic;

#nullable disable

namespace Job.DAL.Models
{
    public partial class Oauth2ProviderRefreshtoken
    {
        public long Id { get; set; }
        public string Token { get; set; }
        public long? AccessTokenId { get; set; }
        public long ApplicationId { get; set; }
        public long UserId { get; set; }
        public DateTime Created { get; set; }
        public DateTime Updated { get; set; }
        public DateTime? Revoked { get; set; }

        public virtual Oauth2ProviderAccesstoken AccessToken { get; set; }
        public virtual Oauth2ProviderApplication Application { get; set; }
        public virtual JobsUser User { get; set; }
        public virtual Oauth2ProviderAccesstoken Oauth2ProviderAccesstoken { get; set; }
    }
}
