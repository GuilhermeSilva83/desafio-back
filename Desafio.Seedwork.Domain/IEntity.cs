using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace Desafio.Seedwork.Domain
{
    public interface IEntity
    {
        bool IsTransient();
    }
}
