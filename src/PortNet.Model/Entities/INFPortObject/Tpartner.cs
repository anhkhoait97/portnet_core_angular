using PortNet.Model.Common;

namespace PortNet.Model.Entities.INFPortObject
{
    public partial class Tpartner : AuditableEntity
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string Code { get; set; }
        public int? LocationId { get; set; }
        public int? OldId { get; set; }
        public string FullNameManager { get; set; }
        public string PositionManager { get; set; }
        public string PhoneManager { get; set; }
        public string EmailManager { get; set; }
        public string FullNameKey1 { get; set; }
        public string PositionKey1 { get; set; }
        public string PhoneKey1 { get; set; }
        public string EmailKey1 { get; set; }
        public string FullNameKey2 { get; set; }
        public string PositionKey2 { get; set; }
        public string PhoneKey2 { get; set; }
        public string EmailKey2 { get; set; }
    }
}