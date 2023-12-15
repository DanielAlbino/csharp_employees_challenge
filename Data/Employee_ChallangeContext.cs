using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Employee_Challange.Model;

namespace Employee_Challange.Data
{
    public class Employee_ChallangeContext : DbContext
    {
        public Employee_ChallangeContext (DbContextOptions<Employee_ChallangeContext> options)
            : base(options)
        {
        }

        public DbSet<Employee_Challange.Model.Employees> Employees { get; set; } = default!;
    }
}
