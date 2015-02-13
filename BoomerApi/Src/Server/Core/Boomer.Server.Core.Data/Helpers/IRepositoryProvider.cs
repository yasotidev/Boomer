using System;
using System.Data.Entity;
using Boomer.Server.Core.Contract;
using Boomer.Server.Core.Contract.Helpers;

namespace Boomer.Server.Core.Data.Helpers
{
    public interface IRepositoryProvider
    {
        DbContext DbContext { get; set; }

       
        IRepository<T> GetRepositoryForEntityType<T>() where T : class;

        
        T GetRepository<T>(Func<DbContext, object> factory = null) where T : class;


        
        void SetRepository<T>(T repository);
    }
}
