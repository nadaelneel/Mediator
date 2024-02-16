using Mediator.Domains;
using Mediator.Infrastracture.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mediator.Application.Interface
{
    public class UserManger : IManger<User> 
    {
        private MyDbContext _db ;
        private DbSet<User> Set;
        public UserManger(MyDbContext db)
        {
            _db = db;
            Set = _db.Set<User>();
        }
        public EntityEntry<User> Add(User entity)
        {
            return  Set.Add(entity);
        }

        public EntityEntry<User> Delete(User entity)
        {
            return Set.Remove(entity);
        }

        public IQueryable<User> GetAll()
        {
            return Set.Where(i => i.IsDeleted == false).Include(i=>i.Department);
        }

        public async Task<User> GetById(int id)
        {
            return Set.Where(i => i.Id == id).AsNoTracking().Include(i=>i.Department).FirstOrDefault();
        }

        public EntityEntry<User> Update(User entity)
        {
            return Set.Update(entity);
        }
    }
}
