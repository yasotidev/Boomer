using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Boomer.Server.Core.Contract
{
    public interface IEFRepository<T> : IRepository<T> where T : class
    {
    }
}
