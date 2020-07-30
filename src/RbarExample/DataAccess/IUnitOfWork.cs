using System;
using System.Collections.Generic;
using System.Text;

namespace RbarExample.DataAccess
{
    public interface IUnitOfWork
    {
        void Commit();
    }
}
