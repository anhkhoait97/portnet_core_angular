using PortNet.Model.Common;
using System;

namespace PortNet.Model.Entities.INFPortObject
{
    public partial class TnumberPayHistory : AuditableEntity
    {
        public long Id { get; set; }
        public long? TcontractId { get; set; }
        public long? NumberPayId { get; set; }
        public string ContractName { get; set; }
        public DateTime? PayDate { get; set; }
        public string StatusString { get; set; }
        public int? NumberType { get; set; }
    }
}