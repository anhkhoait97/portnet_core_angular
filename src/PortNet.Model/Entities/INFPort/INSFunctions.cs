using System;

namespace PortNet.Model.Entities.INFPort
{
    public class INSFunctions
    {
        public int Id { get; set; }
        public DateTime Date { get; set; }
        public string Description { get; set; }
        public int Visible { get; set; }
        public string RefPath { get; set; }
        public int Parent { get; set; }
        public int Type { get; set; }
        public int Level { get; set; }
        public int? Level_1 { get; set; }
        public string Param { get; set; }
        public int? IsType { get; set; }
        public string RefPathNew { get; set; }
    }
}