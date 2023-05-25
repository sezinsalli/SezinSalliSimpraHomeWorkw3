using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpraHomeWork.Core.UnitOfWork
{
    public interface IUnitofWork
    {
        Task CompleteAsync();
        Task CompleteWithTransactionAsync();
        void Dispose();


    }
}
