using Mediator.Domains;
using Mediator.Infrastracture.Context;
using Mediator.Application.Interface;
using Microsoft.EntityFrameworkCore.ChangeTracking;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mediator.Application.Interface
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
        public EntityEntry<Department> Add(Department entity)
        {
            return Set.Add(entity);
        }

        public EntityEntry<Department> Delete(Department entity)
        {
            return Set.Remove(entity);
        }

        public IQueryable<Department> GetAll()
        {
            return Set.Where(i=>i.IsDeleted == false).Include(i=>i.Users);
        }

        public async Task<Department> GetById(int id)
        {
            return Set.Where(i => i.Id == id).Include(i=>i.Users).FirstOrDefault();
        }

        public EntityEntry<Department> Update(Department entity)
        {
            return Set.Update(entity);
        }
    }
}
