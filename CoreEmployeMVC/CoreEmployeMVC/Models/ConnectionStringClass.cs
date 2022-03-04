using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CoreEmployeMVC.Models
{
    public class ConnectionStringClass:DbContext
    {
        public ConnectionStringClass(DbContextOptions<ConnectionStringClass>options):base(options)
        {

        }

        public DbSet<EmployeClass> Employe { get; set; }


        public DbSet<ProjectClass> Project { get; set; }
    }
}
