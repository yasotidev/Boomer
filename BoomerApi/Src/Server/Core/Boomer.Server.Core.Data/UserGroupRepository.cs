using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Boomer.Server.Core.Contract;
using Boomer.Server.Core.Model;

namespace Boomer.Server.Core.Data
{
    public class UserGroupRepository   : EFRepository<Group> , IGroupRepository
    {
        public UserGroupRepository(DbContext dbContext) 
            : base(dbContext)
        {
        }
    }
}
