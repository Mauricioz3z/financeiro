using System;
using financeiro.UI.Web.Data;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.UI;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

[assembly: HostingStartup(typeof(financeiro.UI.Web.Areas.Identity.IdentityHostingStartup))]
namespace financeiro.UI.Web.Areas.Identity
{
    public class IdentityHostingStartup : IHostingStartup
    {
        public void Configure(IWebHostBuilder builder)
        {
            //builder.ConfigureServices((context, services) => {
            //    services.AddDbContext<financeiroUIWebContext>(options =>
            //        options.UseSqlServer(
            //            context.Configuration.GetConnectionString("financeiroUIWebContextConnection")));

            //    //services.AddDefaultIdentity<IdentityUser>(options => options.SignIn.RequireConfirmedAccount = true)
            //    //    .AddEntityFrameworkStores<financeiroUIWebContext>();
            //});
        }
    }
}