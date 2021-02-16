using aspCrud.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace aspCrud.Data
{
    public class ApplicationDBContext:DbContext
    {
        public  ApplicationDBContext(DbContextOptions<ApplicationDBContext> options): base(options)
        {

        }
        public DbSet<Item> Items { get; set; }

    }
}
