using System.Data.Entity;
using Boomer.Server.Core.Contract;
using Boomer.Server.Core.Model;

namespace Boomer.Server.Core.Data
{
    public class RoleGroupRepository  : EFRepository<RoleGroup>, IRoleGroupRepository
    {
        public RoleGroupRepository(DbContext dbContext) 
            : base(dbContext)
        {
        }
    }
}
