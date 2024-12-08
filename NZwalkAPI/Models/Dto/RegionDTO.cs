namespace NZwalkAPI.Models.Dto
{
    public class RegionDTO
    {
        public Guid Id { get; set; }
        public string code { get; set; }
        public string name { get; set; }
        public string? RegionImageUrl { get; set; }//?->we can give null
    }
}
