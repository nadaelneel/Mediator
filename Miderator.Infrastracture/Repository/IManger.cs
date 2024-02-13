using Microsoft.EntityFrameworkCore.ChangeTracking;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mediator.Infrastracture.Repository
{
    public interface IManger<T> where T : class
    {
        Task<T> GetById(int id);
        IQueryable<T> GetAll();
        EntityEntry<T> AddAync(T entity);
        EntityEntry<T> UpdateAync(T entity);
        EntityEntry<T> DeleteAync(T entity);
    }
}
