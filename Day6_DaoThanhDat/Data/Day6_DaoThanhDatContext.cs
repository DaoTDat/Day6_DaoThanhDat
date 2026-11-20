using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Day6_DaoThanhDat.Models;

namespace Day6_DaoThanhDat.Data
{
    public class Day6_DaoThanhDatContext : DbContext
    {
        public Day6_DaoThanhDatContext (DbContextOptions<Day6_DaoThanhDatContext> options)
            : base(options)
        {
        }

        public DbSet<Day6_DaoThanhDat.Models.Product> Product { get; set; } = default!;
    }
}
