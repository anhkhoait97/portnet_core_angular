using PortNet.Model.Common;
using System;

namespace PortNet.Model.Entities.INFPortObject
{
    public partial class TnumberPay : AuditableEntity
    {
        public long Id { get; set; }
        public long? TcontractId { get; set; }
        public int? NumberPay { get; set; }
        public DateTime? PayDate { get; set; }
        public int? StatusNumber { get; set; }
        public string StatusString { get; set; }
        public string AppendicesName { get; set; }
        public string UserConfim { get; set; }
        public DateTime? DateConfim { get; set; }
        public long? AppendicesId { get; set; }
    }
}