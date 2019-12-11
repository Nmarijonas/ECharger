using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EChargerInternational.Areas.Identity.Data;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace EChargerInternational.Models
{
    public class EChargerInternationalContext : IdentityDbContext<EChargerInternationalUser>
    {
        public EChargerInternationalContext(DbContextOptions<EChargerInternationalContext> options)
            : base(options)
        {
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseMySQL("server=localhost;database=EChargerInternational;uid=root;password=");
            }
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            // Customize the ASP.NET Identity model and override the defaults if needed.
            // For example, you can rename the ASP.NET Identity table names and more.
            // Add your customizations after calling base.OnModelCreating(builder);
        }
    }
}
