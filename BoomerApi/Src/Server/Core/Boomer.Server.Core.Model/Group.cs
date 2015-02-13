using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Boomer.Server.Core.Model
{
    public class Group
    {
        public Group()
        {
           RoleGroups = new List<RoleGroup>(); 
        }

        public string Id { get; set; }
        public string Name { get; set; }

        public virtual ICollection<RoleGroup> RoleGroups { get; set; }
    }
}
