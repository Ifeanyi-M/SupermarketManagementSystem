using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using WebApp.Data;

[assembly: HostingStartup(typeof(WebApp.Areas.Identity.IdentityHostingStartup))]
namespace WebApp.Areas.Identity
{
    public class IdentityHostingStartup : IHostingStartup
    {
        public void Configure(IWebHostBuilder builder)
        {
            builder.ConfigureServices((context, services) => {
                services.AddDbContext<AccountContext>(options =>
                    options.UseSqlServer(
                        context.Configuration.GetConnectionString("AccountContextConnection")));

                services.AddDefaultIdentity<IdentityUser>(options => options.SignIn.RequireConfirmedAccount = true)
                    .AddEntityFrameworkStores<AccountContext>();
            });
        }
    }
}
