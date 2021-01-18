using System;

namespace PortNet.Model.Entities.INFPortObject
{
    public partial class Tlist
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Type { get; set; }
        public DateTime? CreateDate { get; set; }
        public string Description { get; set; }
        public string Code { get; set; }
    }
}