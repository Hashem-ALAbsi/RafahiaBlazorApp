namespace RafahiaBlazorApp.Data.DTO
{
    public class ActivityContentDto
    {
        public string? NumberContent { get; set; }
        public int IDActivity { get; set; }
        public int TypeId { get; set; }
        public string? DescriptionContent { get; set; }
        public string? StateContent { get; set; }
        public double? PriceContent { get; set; }
        public string? NumberRoom { get; set; }
        public string? NumberBathRoom { get; set; }
        public bool? TV { get; set; }
        public bool? Internet { get; set; }
    }
}
