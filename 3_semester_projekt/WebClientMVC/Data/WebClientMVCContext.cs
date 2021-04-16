using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using WebClientMVC.Models;

namespace WebClientMVC.Data
{
    public class WebClientMVCContext : DbContext
    {
        public WebClientMVCContext (DbContextOptions<WebClientMVCContext> options)
            : base(options)
        {
        }

        public DbSet<WebClientMVC.Models.Booking> Booking { get; set; }
    }
}
