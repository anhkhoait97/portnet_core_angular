using PortNet.Model.Common;

namespace PortNet.Model.Entities.INFPortObject
{
    public partial class Tprice : AuditableEntity
    {
        public long Id { get; set; }
        public string Name { get; set; }
        public int? LocationId { get; set; }
        public int? BranchId { get; set; }
        public string NameBranch { get; set; }
        public long? TdocumentId { get; set; }
        public int? FormalityRent { get; set; }
        public string Diameter { get; set; }
        public int? Unit { get; set; }
        public string Price { get; set; }
        public int? Type { get; set; }
        public int? Position { get; set; }
        public string Size { get; set; }
        public int? Capacity { get; set; }
        public string Description { get; set; }
        public string PenaltPrice { get; set; }
    }
}