using Microsoft.EntityFrameworkCore;
using MVC_Project.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVC_Project.EF
{
    public class ApplicationDbContext:DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options):base(options)
        {

        }

        public DbSet<menu> menus { get; set; }
        public DbSet<gust> gusts { get; set; }

    }
}
