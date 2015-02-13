using System.Data.Entity;
using Boomer.Server.Core.Contract;
using Boomer.Server.Core.Model;

namespace Boomer.Server.Core.Data
{
    public class UserRoleRepository : EFRepository<UserRole>  , IUserRoleRepository
    {
        public UserRoleRepository(DbContext dbContext) 
            : base(dbContext)
        {
        }
    }
}
