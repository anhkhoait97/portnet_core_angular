using PortNet.Model.Common;

namespace PortNet.Model.Entities.INFPortObject
{
    public partial class TrouteCableLink : AuditableEntity
    {
        public int Id { get; set; }
        public long? BellowId { get; set; }
        public string DataArray { get; set; }
        public string DataLink { get; set; }
        public int? Length { get; set; }
        public string Custom { get; set; }
    }
}