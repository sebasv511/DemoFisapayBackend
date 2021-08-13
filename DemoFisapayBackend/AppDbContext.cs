using DemoFisapayBackend.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DemoFisapayBackend
{
    public class AppDbContext : DbContext
    {
        public DbSet<Empleado> empleado { get; set; }
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {

        }
    }
}
