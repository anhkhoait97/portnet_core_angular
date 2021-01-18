using PortNet.Data.Infrastructure;
using PortNet.Data.Migrations.INFPortDbContext;
using PortNet.Data.Migrations.INFPortObjectDbContext;
using PortNet.Model.Entities.INFPort;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using System.Linq;

namespace PortNet.Data.Repositories
{
    public interface IGroupRepository : IRepository<Groups>
    {
        Task<IEnumerable<Groups>> GetAllGroups();
    }

    public class GroupRepository : RepositoryBase<Groups>, IGroupRepository
    {
        private readonly INFPortDbContext _portDbContext;
        public GroupRepository(INFPortDbContext portDbContext) : base (portDbContext)
        {
            _portDbContext = portDbContext;
        }
        public async Task<IEnumerable<Groups>> GetAllGroups()
        {
            return await (from p in _portDbContext.Groups select p).ToListAsync();
        }
    }
}
