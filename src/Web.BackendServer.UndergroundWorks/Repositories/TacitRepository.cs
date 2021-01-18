using AutoMapper;
using Dapper;
using PortNet.Data.Infrastructure;
using PortNet.Data.Migrations.INFPortObjectDbContext;
using PortNet.Model.Entities.INFPortObject;
using PortNet.Model.Models.Pagination;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Web.BackendServer.UndergroundWorks.ViewModels.CreateRequest;
using Web.BackendServer.UndergroundWorks.ViewModels.UpdateRequest;

namespace Web.BackendServer.UndergroundWorks.Repositories
{
    public interface ITacitRepository : IRepository<Tacit>
    {
        Task<IEnumerable<Tacit>> TacitGetAll();

        Task<Tacit> TacitGetById(long id);

        Task<PaginatedSt<Tacit>> TacitGetPaging(string keyword, int pageIndex, int pageSize);

        Task<Tacit> AddTacit(TacitCreateRequest request);

        Task<Tacit> UpdateTacit(TacitUpdateRequest request);

        Task<Tacit> DeleteTacit(long id);
    }

    public class TacitRepository : RepositoryBase<Tacit>, ITacitRepository
    {
        private readonly INFPortObjectDbContext _inFPortObjectDbContext;
        private readonly IMapper _mapper;
        private readonly IDapper _dapper;

        public TacitRepository(INFPortObjectDbContext inFPortObjectDbContext, IDapper dapper, IMapper mapper) : base(inFPortObjectDbContext)
        {
            _inFPortObjectDbContext = inFPortObjectDbContext;
            _dapper = dapper;
            _mapper = mapper;
        }

        public async Task<IEnumerable<Tacit>> TacitGetAll()
        {
            var paramaters = new DynamicParameters();
            return await Task.FromResult(_dapper.GetAll<Tacit>("fpt_sp_Get_Tacit_All", paramaters, System.Data.CommandType.StoredProcedure, _connInfPortObject)).Result;
        }

        public async Task<PaginatedSt<Tacit>> TacitGetPaging(string keyword, int pageIndex, int pageSize)
        {
            var paramaters = new DynamicParameters();
            paramaters.Add("@Keyword", keyword);
            paramaters.Add("@PageIndex", pageIndex);
            paramaters.Add("@PageSize", pageSize);
            var result = await Task.FromResult(_dapper.GetAll<Tacit>("fpt_sp_Get_Tacit_Paging", paramaters, System.Data.CommandType.StoredProcedure, _connInfPortObject));

            return new PaginatedSt<Tacit>()
            {
                Items = result.Result.ToList(),
                TotalRow = result.Result.ToList().Count,
                PageIndex = pageIndex,
                PageSize = pageSize
            };
        }

        public Task<Tacit> AddTacit(TacitCreateRequest request)
        {
            var model = _mapper.Map<Tacit>(request);
            return Add(model);
        }

        public Task<Tacit> UpdateTacit(TacitUpdateRequest request)
        {
            var model = _mapper.Map<Tacit>(request);
            return Update(model);
        }

        public Task<Tacit> DeleteTacit(long id)
        {
            return Delete(id);
        }

        public async Task<Tacit> TacitGetById(long id)
        {
            return await GetSingleById(id);
        }
    }
}