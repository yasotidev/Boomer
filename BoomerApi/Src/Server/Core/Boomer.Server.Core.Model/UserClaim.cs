using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Boomer.Server.Core.Model
{
    public class UserClaim
    {
        public UserClaim()
        {
             Users = new List<User>();
        }

        public string Id { get; set; }
        public string ClaimValue { get; set; }
        public string ClaimType { get; set; }

        public virtual ICollection<User> Users { get; set; }
    }
}
