using PortNet.Model.Common;

namespace PortNet.Model.Entities.INFPortObject
{
    public partial class TacitLog : AuditableEntity
    {
        public long Id { get; set; }
        public long? TacitId { get; set; }
        public string Code { get; set; }
        public string Name { get; set; }
        public string FileName { get; set; }
        public string Description { get; set; }
    }
}