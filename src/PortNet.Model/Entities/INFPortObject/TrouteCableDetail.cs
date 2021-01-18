using PortNet.Model.Common;

namespace PortNet.Model.Entities.INFPortObject
{
    public partial class TrouteCableDetail : AuditableEntity
    {
        public long Id { get; set; }
        public string CableName { get; set; }
        public string TubeName { get; set; }
        public int? PiFullFlag { get; set; }
        public string Length { get; set; }
        public int? RowNumber { get; set; }
        public long? CableId { get; set; }
        public long? ContractId { get; set; }
    }
}