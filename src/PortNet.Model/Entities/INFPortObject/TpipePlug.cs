﻿using PortNet.Model.Common;
using System;

namespace PortNet.Model.Entities.INFPortObject
{
    public partial class TpipePlug : AuditableEntity
    {
        public long Id { get; set; }
        public string Name { get; set; }
        public int? LocationId { get; set; }
        public int? BranchId { get; set; }
        public long? TacitId { get; set; }
        public string Plans { get; set; }
        public int? StartConnectType { get; set; }
        public long? StartDeviceId { get; set; }
        public string StartDeviceName { get; set; }
        public int? Capacity { get; set; }
        public string Length { get; set; }
        public int? Fulcrum { get; set; }
        public int? OwnedId { get; set; }
        public string Xcoordinate { get; set; }
        public string Ycoordinate { get; set; }
        public string Street { get; set; }
        public int? District { get; set; }
        public int? Ward { get; set; }
        public string Description { get; set; }
        public DateTime? DateUse { get; set; }
        public int? Type { get; set; }
        public int? EndBranchId { get; set; }
        public long? EndTacitId { get; set; }
        public string PopName { get; set; }
        public int? StartFaceId { get; set; }
        public int? TypeCount { get; set; }
    }
}