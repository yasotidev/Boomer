using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Boomer.Server.Core.Model
{
    public class UserLogin
    {
        public UserLogin()
        {
            
        }

        public string Id { get; set; }
        public string LoginProvider { get; set; }
        public string ProviderKey { get; set; }
        public string UserId { get; set; }
        public virtual User User { get; set; }
    }
}
