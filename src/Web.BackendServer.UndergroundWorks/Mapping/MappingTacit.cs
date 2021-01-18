using AutoMapper;
using PortNet.Model.Entities.INFPortObject;
using Web.BackendServer.UndergroundWorks.ViewModels.CreateRequest;

namespace Web.BackendServer.UndergroundWorks.Mapping
{
    public class MappingTacit : Profile
    {
        public MappingTacit()
        {
            CreateMap<Tacit, TacitCreateRequest>();
            CreateMap<TacitCreateRequest, Tacit>();
        }
    }
}