using System.Data.Entity;
using Boomer.Server.Core.Contract;
using Boomer.Server.Core.Model;

namespace Boomer.Server.Core.Data
{
    public class UserLoginRepository  : EFRepository<UserLogin>, IUserLoginRepository
    {
        public UserLoginRepository(DbContext dbContext) 
            : base(dbContext)
        {
        }
    }
}
