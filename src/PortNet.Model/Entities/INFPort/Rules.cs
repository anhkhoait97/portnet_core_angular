namespace PortNet.Model.Entities.INFPort
{
    public class Rules
    {
        public int Id { get; set; }
        public int FunctionId { get; set; }
        public int GroupId { get; set; }
        public int AUpdate { get; set; }
        public int AInsert { get; set; }
        public int ARemove { get; set; }
        public int ADetail { get; set; }
    }
}