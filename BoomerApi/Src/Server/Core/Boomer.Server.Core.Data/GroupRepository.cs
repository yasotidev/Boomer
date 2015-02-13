using System.Data.Entity;
using Boomer.Server.Core.Contract;
using Boomer.Server.Core.Model;

namespace Boomer.Server.Core.Data
{
    public class GroupRepository : EFRepository<Group>, IGroupRepository
    {
        public GroupRepository(DbContext dbContext) 
            : base(dbContext)
        {
        }
    }
}
