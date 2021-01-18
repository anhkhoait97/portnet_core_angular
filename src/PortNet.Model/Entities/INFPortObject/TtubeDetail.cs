using PortNet.Model.Common;

namespace PortNet.Model.Entities.INFPortObject
{
    public partial class TtubeDetail : AuditableEntity
    {
        public long Id { get; set; }
        public int? Type { get; set; }
        public string Name { get; set; }
        public long? DeviceId { get; set; }
        public int? Number { get; set; }
        public int? Capacity { get; set; }
        public int? SiteId { get; set; }
        public int? TypeTube { get; set; }
        public int? Status { get; set; }
        public int? MaterialId { get; set; }
        public int? ColorId { get; set; }
        public string Description { get; set; }
        public int? PiFullFlag { get; set; }
        public string CoordinatesXsectionStart { get; set; }
        public string CoordinatesYsectionStart { get; set; }
        public string CoordinatesXsectionEnd { get; set; }
        public string CoordinatesYsectionEnd { get; set; }
    }
}