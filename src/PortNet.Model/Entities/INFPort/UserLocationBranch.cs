namespace PortNet.Model.Entities.INFPort
{
    public partial class UserLocationBranch
    {
        public long Id { get; set; }
        public string UserId { get; set; }
        public long? LocationId { get; set; }
        public long? BranchId { get; set; }
    }
}