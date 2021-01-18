using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using PortNet.Data.Migrations.INFPortObjectDbContext;
using System;
using System.Collections.Generic;
using System.Text;

namespace Web.BackendServer.UnitTest.INFPortObject
{
    public class DbFixture
    {
        public DbFixture()
        {
            var serviceCollection = new ServiceCollection();
            serviceCollection.AddDbContext<INFPortObjectDbContext>(options => options.UseSqlServer("Data Source=172.27.62.7;Initial Catalog=INFPortObject;Persist Security Info=True;User ID=isc;Password=rnd1280rnd"),
                    ServiceLifetime.Transient);

            ServiceProvider = serviceCollection.BuildServiceProvider();
        }

        public ServiceProvider ServiceProvider { get; private set; }
    }
}
