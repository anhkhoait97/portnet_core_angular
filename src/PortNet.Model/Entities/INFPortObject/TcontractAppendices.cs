using System;

namespace PortNet.Model.Entities.INFPortObject
{
    public partial class TcontractAppendices
    {
        public long Id { get; set; }
        public long? TcontractId { get; set; }
        public string Name { get; set; }
        public long? PartnerId { get; set; }
        public DateTime? StartDate { get; set; }
        public DateTime? EndDate { get; set; }
        public int StatusPay { get; set; }
        public int? StatusContract { get; set; }
        public int? CyclePay { get; set; }
        public int? NumberPay { get; set; }
        public string TotalReal { get; set; }
        public DateTime? CreateDate { get; set; }
        public string CreateBy { get; set; }
        public DateTime? UpdateDate { get; set; }
        public string UpdateBy { get; set; }
    }
}