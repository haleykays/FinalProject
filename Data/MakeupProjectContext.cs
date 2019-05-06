using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using MakeupProject.Models;

    public class MakeupProjectContext : DbContext
    {
        public MakeupProjectContext (DbContextOptions<MakeupProjectContext> options)
            : base(options)
        {
        }

        public DbSet<MakeupProject.Models.Products> Products { get; set; }
    }
