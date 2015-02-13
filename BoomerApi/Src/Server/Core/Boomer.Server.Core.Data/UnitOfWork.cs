using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Boomer.Server.Core.Contract;

namespace Boomer.Server.Core.Data
{
    public class UnitOfWork  : IUnitOfWork
    {
        public void Commit()
        {
            throw new NotImplementedException();
        }
    }
}
