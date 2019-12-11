using System;
using EChargerInternational.Areas.Identity.Data;
using EChargerInternational.Models;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.UI;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

[assembly: HostingStartup(typeof(EChargerInternational.Areas.Identity.IdentityHostingStartup))]
namespace EChargerInternational.Areas.Identity
{
    public class IdentityHostingStartup : IHostingStartup
    {
        public void Configure(IWebHostBuilder builder)
        {
            builder.ConfigureServices((context, services) => {
                services.AddDbContext<EChargerInternationalContext>(options =>
                    options.UseMySQL("server=localhost;database=EChargerInternational;uid=root;password="));

                services.AddDefaultIdentity<EChargerInternationalUser>()
                    .AddEntityFrameworkStores<EChargerInternationalContext>();
            });
        }
    }
}