using Castle.Core.Logging;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using Moq;
using PortNet.Data.Infrastructure;
using PortNet.Data.Migrations.INFPortObjectDbContext;
using PortNet.Model.Entities.INFPortObject;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Web.BackendServer.UndergroundWorks.Controllers;
using Web.BackendServer.UndergroundWorks.Repositories;
using Xunit;

namespace Web.BackendServer.UnitTest.INFPortObject.Controllers
{
    public class UndergroundWorksControllerTest
    {
        private INFPortObjectDbContext _context;
        private Mock<ITacitRepository> _mockTacitObject;

        public UndergroundWorksControllerTest()
        {
            _mockTacitObject = new Mock<ITacitRepository>();
            _context = new InMemoryDbContextFactory().GetApplicationDbContext();
        }

        [Fact]
        public void ShouldCreateInstance_NotNull_Success()
        {
            //Arrange  
            var controller = new UndergroundWorksController(_mockTacitObject.Object);
            Assert.NotNull(controller);
        }

        [Fact]
        public async void Tacit_GetTacitById_Return_OkResult()
        {
            //Arrange
            var controller = new UndergroundWorksController(_mockTacitObject.Object);
            long tacitId = 2;

            //Act
            var result = await controller.GetTacitById(tacitId);

            //Assert
            Assert.IsType<OkObjectResult>(result);
        }

        [Fact]
        public async void Tacit_GetTacitById_Return_NotFoundResult()
        {
            //Arrange  
            //var controller = new UndergroundWorksController(_mockTacitObject.Object);
            //long tacitId = 2;

            //Act
            //var data = await controller.GetTacitById(tacitId);

            _mockTacitObject.Setup(x => x.GetSingleById(2)).ReturnsAsync(new Tacit());
            var controller = new UndergroundWorksController(_mockTacitObject.Object);


            var data = await controller.GetTacitById(2);
            //Assert
            Assert.IsType<NotFoundResult>(data);
        }


        [Fact]
        public async void Tacit_GetTacit_Return_OkResult()
        {
            //Arrange  
            var controller = new UndergroundWorksController(_mockTacitObject.Object);

            //Act
            var result = await controller.GetTacitAll();

            //Assert
            Assert.IsType<OkObjectResult>(result);
        }
    }
}
