using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mediator.Infrastracture.Repository
{
    public interface IUniteOfWork
    {
        void Commit();
    }
}
