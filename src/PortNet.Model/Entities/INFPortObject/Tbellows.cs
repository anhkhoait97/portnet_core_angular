using PortNet.Model.Common;
using System;

namespace PortNet.Model.Entities.INFPortObject
{
    public partial class Tbellows : AuditableEntity
    {
        public long Id { get; set; }
        public string Name { get; set; }
        public int? LocationId { get; set; }
        public int? BranchId { get; set; }
        public long? TacitId { get; set; }
        public string Plans { get; set; }
        public long? PointConnectId { get; set; }
        public string PointConnectName { get; set; }
        public int? TypeConnect { get; set; }
        public int? ShapeBellowsId { get; set; }
        public int? ShapeLidId { get; set; }
        public int? CapacityLid { get; set; }
        public int? MaterialId { get; set; }
        public int? CapacityTube { get; set; }
        public string Size { get; set; }
        public string Xcoordinate { get; set; }
        public string Ycoordinate { get; set; }
        public string Street { get; set; }
        public int? District { get; set; }
        public int? Ward { get; set; }
        public string Description { get; set; }
        public int? Status { get; set; }
        public int? OwnedId { get; set; }
        public DateTime? DateUse { get; set; }
        public string DifferentName { get; set; }
        public int? TypeObject { get; set; }
        public int? TypeDevice { get; set; }
    }
}