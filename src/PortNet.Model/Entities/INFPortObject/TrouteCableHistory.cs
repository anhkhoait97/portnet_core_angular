using PortNet.Model.Common;
using System;

namespace PortNet.Model.Entities.INFPortObject
{
    public partial class TrouteCableHistory : AuditableEntity
    {
        public long Id { get; set; }
        public int? LocationId { get; set; }
        public int? BranchId { get; set; }
        public int? Type { get; set; }
        public int? PartnerNameId { get; set; }
        public int? TypeCable { get; set; }
        public int? Capacity { get; set; }
        public int? TypeDevice { get; set; }
        public string DeviceName { get; set; }
        public long? DeviceId { get; set; }
        public string CableName { get; set; }
        public long? CableId { get; set; }
        public string Description { get; set; }
        public long? TacitId { get; set; }
        public string TacitName { get; set; }
        public int? TypeObject { get; set; }
        public string NameObject { get; set; }
        public string EndName { get; set; }
        public string OdccableType { get; set; }
        public string CableLength { get; set; }
        public int? Direction { get; set; }
        public int? PiFullFlag { get; set; }
        public long? TrouteCableId { get; set; }
        public DateTime? DeletedDate { get; set; }
        public long? ContractId { get; set; }
    }
}