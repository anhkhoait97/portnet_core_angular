using System;

namespace PortNet.Model.Entities.INFPort
{
    public class Groups
    {
        public int ID { get; set; }
        public string GroupName { get; set; }
        public string FullName { get; set; }
        public short? LocationID { get; set; }
        public DateTime Date { get; set; }
        public byte Enabled { get; set; }
        public long? ID_GroupRight { get; set; }
    }
}