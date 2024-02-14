using Microsoft.EntityFrameworkCore.ChangeTracking;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mediator.Application.Interface
{
    public interface IManger<T> where T : class
    {
        Task<T> GetById(int id);
        IQueryable<T> GetAll();
        EntityEntry<T> Add(T entity);
        EntityEntry<T> Update(T entity);
        EntityEntry<T> Delete(T entity);
    }
}
