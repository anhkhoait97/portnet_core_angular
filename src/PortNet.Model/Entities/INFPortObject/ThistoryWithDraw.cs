using System;

namespace PortNet.Model.Entities.INFPortObject
{
    public partial class ThistoryWithDraw
    {
        public long Id { get; set; }
        public long? LocationId { get; set; }
        public string BranchId { get; set; }
        public string TacitName { get; set; }
        public string DeviceName { get; set; }
        public string CreateBy { get; set; }
        public DateTime? CreateDate { get; set; }
        public string Ip { get; set; }
    }
}