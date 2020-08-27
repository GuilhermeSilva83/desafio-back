using System;
using System.Collections.Generic;
using System.Text;

namespace Desafio.Seedwork.Domain
{
    public interface IUnitOfWork
    {
        void Commit();
    }
}
