using System;
using System.Collections.Generic;

#nullable disable

namespace Job.DAL.Models
{
    public partial class Oauth2ProviderGrant
    {
        public long Id { get; set; }
        public string Code { get; set; }
        public DateTime Expires { get; set; }
        public string RedirectUri { get; set; }
        public string Scope { get; set; }
        public long ApplicationId { get; set; }
        public long UserId { get; set; }
        public DateTime Created { get; set; }
        public DateTime Updated { get; set; }
        public string CodeChallenge { get; set; }
        public string CodeChallengeMethod { get; set; }
        public string Nonce { get; set; }
        public string Claims { get; set; }

        public virtual Oauth2ProviderApplication Application { get; set; }
        public virtual JobsUser User { get; set; }
    }
}
