using Microsoft.AspNetCore.Mvc;
using PortNet.Model.Entities.INFPortObject;
using PortNet.Service.Helpers;
using System;
using System.Threading.Tasks;
using Web.BackendServer.UndergroundWorks.Repositories;
using Web.BackendServer.UndergroundWorks.ViewModels.CreateRequest;
using Web.BackendServer.UndergroundWorks.ViewModels.UpdateRequest;

namespace Web.BackendServer.UndergroundWorks.Controllers
{
    public class UndergroundWorksController : BaseController
    {
        private readonly ITacitRepository _tacitRepository;

        public UndergroundWorksController(ITacitRepository tacitRepository)
        {
            _tacitRepository = tacitRepository;
        }

        [HttpGet("/tacits")]
        [ApiValidationFilter]
        public async Task<IActionResult> GetTacitAll()
        {
            var result = await _tacitRepository.TacitGetAll();
            return Ok(result);
        }

        [HttpGet("/tacits/{id}")]
        [ApiValidationFilter]
        public async Task<IActionResult> GetTacitById([FromRoute] long id)
        {
            var result = await _tacitRepository.TacitGetById(id);
            return Ok(result);
        }

        [HttpGet("/tacits/filter")]
        [ApiValidationFilter]
        public async Task<IActionResult> GetTacitPaging(string filter, int pageIndex, int pageSize)
        {
            var result = await _tacitRepository.TacitGetPaging(filter, pageIndex, pageSize);
            return Ok(result);
        }

        [HttpPost("/tacits")]
        [ApiValidationFilter]
        public async Task<IActionResult> InsertTacit([FromForm] TacitCreateRequest request)
        {
            var user = User.Identity.Name;
            request.CreateBy = user;
            request.UpdateBy = user;
            request.CreateDate = DateTime.Now;
            var result = await _tacitRepository.AddTacit(request);
            return Ok(result);
        }

        [HttpPut("/tacits/{id}")]
        [ApiValidationFilter]
        public async Task<Tacit> UpdateTacit([FromForm] TacitUpdateRequest request)
        {
            return await _tacitRepository.UpdateTacit(request);
        }

        [HttpDelete("/tacits/{id}")]
        [ApiValidationFilter]
        public async Task<Tacit> DeleteTacit(long id)
        {
            return await _tacitRepository.DeleteTacit(id);
        }
    }
}