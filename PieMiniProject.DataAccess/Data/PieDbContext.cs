using Microsoft.EntityFrameworkCore;
using PieMiniProject.ModelAccess.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PieMiniProject.DataAccess.Data
{
    public class PieDbContext:DbContext
    {
        public PieDbContext(DbContextOptions<PieDbContext> options) : base(options)
        {

        }

        public DbSet<Pie> Products { get; set; }
    }
}
