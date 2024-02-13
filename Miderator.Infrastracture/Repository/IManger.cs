using Microsoft.EntityFrameworkCore.ChangeTracking;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Miderator.Infrastracture.Repository
{
    public interface IManger<T> where T : class
    {
        Task<T> GetById(Guid id);
        IQueryable<T> GetAll();
        Task<T> AddAync(T entity);
        Task<T> UpdateAync(T entity);
        Task<T> DeleteAync(T entity);
    }
}
