using PortNet.Model.Common;

namespace PortNet.Model.Entities.INFPortObject
{
    public partial class TcontractFile : AuditableEntity
    {
        public long Id { get; set; }
        public long? TcontractId { get; set; }
        public string FileName { get; set; }
        public string LinkFile { get; set; }
        public int? Type { get; set; }
        public string Description { get; set; }
    }
}