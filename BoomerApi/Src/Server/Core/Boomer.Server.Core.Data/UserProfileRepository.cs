using System.Data.Entity;
using Boomer.Server.Core.Contract;
using Boomer.Server.Core.Model;

namespace Boomer.Server.Core.Data
{
    public class UserProfileRepository : EFRepository<UserProfile>, IUserProfileRepository
    {
        public UserProfileRepository(DbContext dbContext) 
            : base(dbContext)
        {
        }
    }
}
