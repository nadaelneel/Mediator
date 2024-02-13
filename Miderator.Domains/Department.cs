﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Miderator.Domains
{
    public class Department
    {
        public Guid Id { get; set; }
        public string Name { get; set; }

        public bool IsDeleted { get; set; }
        public ICollection<User> Users { get; set; }
    }
}
