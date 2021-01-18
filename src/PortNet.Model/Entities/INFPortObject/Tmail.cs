using System;

namespace PortNet.Model.Entities.INFPortObject
{
    public partial class Tmail
    {
        public int Id { get; set; }
        public string Email { get; set; }
        public long? BranchId { get; set; }
        public long? LocationId { get; set; }
        public long? Type { get; set; }
        public long? TypeMail { get; set; }
        public string Note { get; set; }
        public int? PartnerId { get; set; }
        public DateTime? CreateDate { get; set; }
        public string CreateBy { get; set; }
    }
}