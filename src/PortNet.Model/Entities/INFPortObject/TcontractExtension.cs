using PortNet.Model.Common;
using System;

namespace PortNet.Model.Entities.INFPortObject
{
    public partial class TcontractExtension : AuditableEntity
    {
        public long Id { get; set; }
        public long? TcontractId { get; set; }
        public DateTime? SignDate { get; set; }
        public DateTime? EndDate { get; set; }
        public int? Extension { get; set; }
    }
}