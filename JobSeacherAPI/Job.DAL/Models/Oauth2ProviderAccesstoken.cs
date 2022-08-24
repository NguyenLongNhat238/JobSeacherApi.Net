using System;
using System.Collections.Generic;

#nullable disable

namespace Job.DAL.Models
{
    public partial class Oauth2ProviderAccesstoken
    {
        public long Id { get; set; }
        public string Token { get; set; }
        public DateTime Expires { get; set; }
        public string Scope { get; set; }
        public long? ApplicationId { get; set; }
        public long? UserId { get; set; }
        public DateTime Created { get; set; }
        public DateTime Updated { get; set; }
        public long? SourceRefreshTokenId { get; set; }
        public long? IdTokenId { get; set; }

        public virtual Oauth2ProviderApplication Application { get; set; }
        public virtual Oauth2ProviderIdtoken IdToken { get; set; }
        public virtual Oauth2ProviderRefreshtoken SourceRefreshToken { get; set; }
        public virtual JobsUser User { get; set; }
        public virtual Oauth2ProviderRefreshtoken Oauth2ProviderRefreshtoken { get; set; }
    }
}
