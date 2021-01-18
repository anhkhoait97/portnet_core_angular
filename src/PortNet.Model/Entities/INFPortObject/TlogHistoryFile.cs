using System;

namespace PortNet.Model.Entities.INFPortObject
{
    public partial class TlogHistoryFile
    {
        public long Id { get; set; }
        public long? TacitId { get; set; }
        public string NameFile { get; set; }
        public string Description { get; set; }
        public string UpdateBy { get; set; }
        public DateTime? UpdateDate { get; set; }
    }
}