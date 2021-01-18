using System;

namespace PortNet.Model.Entities.INFPortObject
{
    public partial class Cmlist
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Code { get; set; }
        public int? Type { get; set; }
        public DateTime? CreateDate { get; set; }
        public int? IndexR { get; set; }
    }
}