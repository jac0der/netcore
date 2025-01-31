using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.Persistence
{
    public class AppDbContext : DbContext
    {      
        public AppDbContext(DbContextOptions<AppDbContext> options) 
            : base(options) 
        { 
            
        }

        public DbSet<Reminder> Reminders { get; set; }
    }
}