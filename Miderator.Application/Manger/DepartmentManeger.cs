using Mediator.Domains;
using Mediator.Infrastracture.Context;
using Mediator.Infrastracture.Repository;
using Microsoft.EntityFrameworkCore.ChangeTracking;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mediator.Application.Manger
{
    public class DepartmentManeger : IManger<Department>
    {
        private MyDbContext _db;
        private DbSet<Department> Set;
        public DepartmentManeger(MyDbContext db)
        {
            _db = db;
            Set = _db.Set<Department>();
        }
        public EntityEntry<Department> AddAync(Department entity)
        {
            return Set.Add(entity);
        }

        public EntityEntry<Department> DeleteAync(Department entity)
        {
            return Set.Remove(entity);
        }

        public IQueryable<Department> GetAll()
        {
            return Set;
        }

        public async Task<Department> GetById(int id)
        {
            return Set.Where(i => i.Id == id).AsNoTracking().FirstOrDefault();
        }

        public EntityEntry<Department> UpdateAync(Department entity)
        {
            return Set.Update(entity);
        }
    }
}
