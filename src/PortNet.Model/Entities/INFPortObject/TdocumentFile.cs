using PortNet.Model.Common;

namespace PortNet.Model.Entities.INFPortObject
{
    public partial class TdocumentFile : AuditableEntity
    {
        public long Id { get; set; }
        public long? TdocumentId { get; set; }
        public string FileName { get; set; }
        public string LinkFile { get; set; }
    }
}