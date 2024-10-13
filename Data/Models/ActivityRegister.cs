
namespace RafahiaBlazorApp.Models
{
    [Table("ActivityRegister", Schema = "RH")]
    public class ActivityRegister
    {
        [Key]
        [Display(Name = "IDActivity")]
        public int IDActivity { get; set; }

        // public string? Token { get; set; }
        public string? UserID { get; set; }
        [ForeignKey("UserID")]
        public ApplicationUser? User { get; set; }


        [Display(Name = "NameIctivity")]
        [Column(TypeName = "varchar(250)")]
        public string NameIctivity { get; set; } = string.Empty;

        [Display(Name = "PhoneIctivity")]
        [Column(TypeName = "varchar(250)")]
        public string? PhoneIctivity { get; set; }

        [Display(Name = "ContryIctivity")]
        [Column(TypeName = "varchar(250)")]
        public string? ContryIctivity { get; set; }

        [Display(Name = "AddressIctivity")]
        [Column(TypeName = "varchar(250)")]
        public string? AddressIctivity { get; set; }


        //public string  { get; set; } forCurs


        //public string  { get; set; } forType
        public int TypeId { get; set; }
        [ForeignKey("TypeId")]
        public TypeIctivity? type { get; set; }

        [Display(Name = "DescriptionIctivity")]
        [Column(TypeName = "varchar(250)")]
        public string? DescriptionIctivity { get; set; }

        [Display(Name = "StarsIctivity")]
        [Column(TypeName = "varchar(250)")]
        public string? StarsIctivity { get; set; }

        [Display(Name = "restaurant")]
        [Column(TypeName = "varchar(250)")]
        public bool? restaurant { get; set; }

        [Display(Name = "parking")]
        [Column(TypeName = "varchar(250)")]
        public bool? parking { get; set; }

        [Display(Name = "swimmingpool")]
        [Column(TypeName = "varchar(250)")]
        public bool? swimmingpool { get; set; }

        [Display(Name = "ImageActivity")]
        [Column(TypeName = "varchar(250)")]
        public string? ImageActivity { get; set; }
    }
}
