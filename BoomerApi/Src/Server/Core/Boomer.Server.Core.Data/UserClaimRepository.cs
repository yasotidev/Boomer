using System.Data.Entity;
using Boomer.Server.Core.Contract;
using Boomer.Server.Core.Model;

namespace Boomer.Server.Core.Data
{
    public class UserClaimRepository : EFRepository<UserClaim> , IUserClaimRepository
    {
        public UserClaimRepository(DbContext dbContext) 
            : base(dbContext)
        {
        }
    }
}
