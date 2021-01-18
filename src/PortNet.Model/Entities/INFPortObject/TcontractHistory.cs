using PortNet.Model.Common;
using System;

namespace PortNet.Model.Entities.INFPortObject
{
    public partial class TcontractHistory : AuditableEntity
    {
        public long Id { get; set; }
        public long? TcontractId { get; set; }
        public DateTime? Date { get; set; }
        public string ContractName { get; set; }
        public int? LocationId { get; set; }
        public int? BranchId { get; set; }
        public string NameBranch { get; set; }
        public string TacitName { get; set; }
        public DateTime? SignDate { get; set; }
        public DateTime? EndDate { get; set; }
        public int? Type { get; set; }
        public int? PartnerId { get; set; }
        public int? StatusContract { get; set; }
        public int? StatusPay { get; set; }
        public long? DocumentId { get; set; }
        public string IsFile { get; set; }
        public string Appendices { get; set; }
        public string SumValuesReal { get; set; }
        public string SumValuesRefer { get; set; }
        public int? Vat { get; set; }
        public int? CyclePay { get; set; }
        public int? NumberPay { get; set; }
        public string Description { get; set; }
        public int? HandleType { get; set; }
        public string DeleteBy { get; set; }
        public DateTime? DeleteDate { get; set; }
        public int? IsPi { get; set; }
    }
}