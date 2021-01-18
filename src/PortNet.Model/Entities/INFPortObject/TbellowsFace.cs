using PortNet.Model.Common;

namespace PortNet.Model.Entities.INFPortObject
{
    public partial class TbellowsFace : AuditableEntity
    {
        public long Id { get; set; }
        public long? BellowsId { get; set; }
        public string NameFace { get; set; }
        public int? Size { get; set; }
        public string Description { get; set; }
        public int? Type { get; set; }
        public int? FaceId { get; set; }
    }
}