using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Suites
{
    // used for Payment system
    public interface IUnitOfWork
    {
        void Commit();
        void Rollback();
    }
}
