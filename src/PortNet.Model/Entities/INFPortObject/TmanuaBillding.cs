using PortNet.Model.Common;

namespace PortNet.Model.Entities.INFPortObject
{
    public partial class TmanuaBillding : AuditableEntity
    {
        public long Id { get; set; }
        public string CableName { get; set; }
        public string TacitCode { get; set; }
        public string OdccableType { get; set; }
        public string NameTacit { get; set; }
        public string NameObject { get; set; }
        public string EndName { get; set; }
        public string TypeCable { get; set; }
        public string Capacity { get; set; }
        public string Formality { get; set; }
        public string CableLength { get; set; }
        public string Price { get; set; }
        public long? ContractId { get; set; }
    }
}