using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using HotelsHost.Models;

namespace HotelsHost.Data
{
    public class HotelsHostContext : DbContext
    {
        public HotelsHostContext (DbContextOptions<HotelsHostContext> options)
            : base(options)
        {
        }

        public DbSet<HotelsHost.Models.Hotel> Hotels { get; set; }

        public DbSet<HotelsHost.Models.User> Users { get; set; }
    }
}
