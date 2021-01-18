using System;

namespace PortNet.Model.Entities.INFPortObject
{
    public partial class Tarray
    {
        public int Id { get; set; }
        public int? ValuesId { get; set; }
        public string Name { get; set; }
        public int? Type { get; set; }
        public int? Parent { get; set; }
        public string Description { get; set; }
        public DateTime? CreateDate { get; set; }
    }
}