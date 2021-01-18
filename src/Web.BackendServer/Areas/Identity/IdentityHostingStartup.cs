using Microsoft.AspNetCore.Hosting;

[assembly: HostingStartup(typeof(Web.BackendServer.Areas.Identity.IdentityHostingStartup))]

namespace Web.BackendServer.Areas.Identity
{
    public class IdentityHostingStartup : IHostingStartup
    {
        public void Configure(IWebHostBuilder builder)
        {
            builder.ConfigureServices((context, services) =>
            {
            });
        }
    }
}