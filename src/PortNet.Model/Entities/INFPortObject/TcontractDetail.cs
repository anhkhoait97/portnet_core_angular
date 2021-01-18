using PortNet.Model.Common;

namespace PortNet.Model.Entities.INFPortObject
{
    public partial class TcontractDetail : AuditableEntity
    {
        public long Id { get; set; }
        public long? TcontractId { get; set; }
        public long? TacitId { get; set; }
        public string CodeTacit { get; set; }
    }
}