
namespace RafahiaBlazorApp.Models
{
    [Table("Booking", Schema = "RH")]
    public class TPBooking
    {
        [Key]
        [Display(Name = "IDBooking")]
        public int IDBooking { get; set; }

        //public int IDActivity { get; set; }
        //[ForeignKey("IDActivity")]
        //public ActivityRegister? activityRegister { get; set; }

        public int IDContent { get; set; }
        [ForeignKey("IDContent")]
        public ActivityContent? activityContent { get; set; }

        // public string? Token { get; set; }
        public string? UserID { get; set; }
        [ForeignKey("UserID")]
        public ApplicationUser? User { get; set; }

        [Display(Name = "StateBooking")]
        [Column(TypeName = "varchar(250)")]
        public bool? StateBooking { get; set; }

        [Display(Name = "TimeIN")]
        [DataType(DataType.Date)]
        public DateTime? TimeIN { get; set; }

        [Display(Name = "TimeOUT")]
        [DataType(DataType.Date)]
        public DateTime? TimeOUT { get; set; }

        [Display(Name = "PriceBooking")]
        [Column(TypeName = "varchar(250)")]
        public double? PriceBooking { get; set; }
    }
}
