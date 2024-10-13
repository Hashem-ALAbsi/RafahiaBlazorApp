namespace RafahiaBlazorApp.Data.DTO
{
    public class BookingDto
    {

        public int IDContent { get; set; }
        public string? UserID { get; set; }
        public bool? StateBooking { get; set; }
        public DateTime? TimeIN { get; set; }
        public DateTime? TimeOUT { get; set; }
        public double? PriceBooking { get; set; }
    }
}
