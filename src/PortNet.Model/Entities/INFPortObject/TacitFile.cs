using PortNet.Model.Common;

namespace PortNet.Model.Entities.INFPortObject
{
    public partial class TacitFile : AuditableEntity
    {
        public long Id { get; set; }
        public long? TacitId { get; set; }
        public string FileName { get; set; }
        public string LinkFile { get; set; }
    }
}