using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using RazorPagesComputer.Models;

    public class RazorPagesComputerContext : DbContext
    {
        public RazorPagesComputerContext (DbContextOptions<RazorPagesComputerContext> options)
            : base(options)
        {
        }

        public DbSet<RazorPagesComputer.Models.Computer> Computer { get; set; }
    }
