namespace Web.BackendServer.UndergroundWorks.ReadRequest.ViewModels
{
    public class TacitReadRequest
    {
        public long Id { get; set; }
        public string Code { get; set; }
        public string Name { get; set; }
        public int LocationId { get; set; }
        public int BranchId { get; set; }
        public string Plans { get; set; }
        public string Infmaintail { get; set; }
        public int TypeBuilding { get; set; }
        public long BuildingId { get; set; }
        public string BuildingName { get; set; }
        public string Street { get; set; }
        public int StreetDistrict { get; set; }
        public int StreetWard { get; set; }
        public string StartName { get; set; }
        public int StartNameDistrict { get; set; }
        public int StartNameWard { get; set; }
        public string EndName { get; set; }
        public int EndNameDistrict { get; set; }
        public int EndNameWard { get; set; }
        public string Length { get; set; }
        public string InvestCosts { get; set; }
        public string RentalCost { get; set; }
        public int StartUpQuarter { get; set; }
        public int StartUpYear { get; set; }
        public int FinishQuarter { get; set; }
        public int FinishYear { get; set; }
        public int InvestId { get; set; }
        public int ManagerUnitId { get; set; }
        public string LinkDesign { get; set; }
        public string Description { get; set; }
        public string IsFile { get; set; }
        public int Flag { get; set; }
        public int TypeTacit { get; set; }
    }
}