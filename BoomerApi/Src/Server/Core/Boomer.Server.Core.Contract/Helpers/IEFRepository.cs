using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Boomer.Server.Core.Contract.Helpers;

namespace Boomer.Server.Core.Contract
{
    public interface IEFRepository<T> : IRepository<T> where T : class
    {
    }
}
