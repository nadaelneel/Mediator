using Miderator.Infrastracture.Context;
using Miderator.Infrastracture.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Miderator.Infrastracture.UniteOfWork
{
    public class UniteOfWork : IUniteOfWork
    {
        private MyDbContext dbContext;

        public UniteOfWork(MyDbContext dbContext)
        {
            this.dbContext = dbContext;
        }

        public void Commit()
        {
            this.dbContext.SaveChanges();
        }
    }
}
