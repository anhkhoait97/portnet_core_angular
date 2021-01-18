using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.DependencyInjection;
using PortNet.Data.Migrations.INFPortObjectDbContext;
using PortNet.Model.Entities.INFPortObject;
using System;
using System.Collections.Generic;
using System.Text;
using Web.BackendServer.UndergroundWorks.Controllers;
using Xunit;

namespace Web.BackendServer.UnitTest.INFPortObject.Controllers
{
    public class TacitControllerTest : IClassFixture<DbFixture>
    {
        private INFPortObjectDbContext _context;
        private ServiceProvider _serviceProvider;
        public TacitControllerTest(DbFixture fixture)
        {
            _context = new InMemoryDbContextFactory().GetApplicationDbContext();
            _serviceProvider = fixture.ServiceProvider;
        }


        [Fact]
        public async void Tacit_GetTacitById_Return_OkResult()
        {
            using INFPortObjectDbContext context = _serviceProvider.GetService<INFPortObjectDbContext>();
            //Arrange
            long tacitId = 2;

            //Act
            var result = await context.Tacit.FindAsync(tacitId);

            //Assert
            Assert.IsType<Tacit>(result);
        }
    }
}
