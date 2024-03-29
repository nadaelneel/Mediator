﻿using Microsoft.EntityFrameworkCore;
using Mediator.Domains;
using Mediator.Infrastracture.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mediator.Infrastracture.Context
{
    public class MyDbContext  : DbContext
    {
        public MyDbContext(DbContextOptions<MyDbContext> options): base(options) { }

        public DbSet<User> Users { get; set; }

        public DbSet<Department> Departments { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration<User>(new UserConfiguration());
            modelBuilder.ApplyConfiguration<Department>(new DepartmentConfiguration());
            base.OnModelCreating(modelBuilder);

        }
    }
}
