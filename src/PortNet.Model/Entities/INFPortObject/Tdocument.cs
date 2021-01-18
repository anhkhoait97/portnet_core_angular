using PortNet.Model.Common;
using System;

namespace PortNet.Model.Entities.INFPortObject
{
    public partial class Tdocument : AuditableEntity
    {
        public long Id { get; set; }
        public string Name { get; set; }
        public string Code { get; set; }
        public int? LocationId { get; set; }
        public int? BranchId { get; set; }
        public string NameBranch { get; set; }
        public int? Status { get; set; }
        public DateTime? StartDate { get; set; }
        public DateTime? EndDate { get; set; }
        public string IsFile { get; set; }
        public int? Extension { get; set; }
        public string Description { get; set; }
    }
}