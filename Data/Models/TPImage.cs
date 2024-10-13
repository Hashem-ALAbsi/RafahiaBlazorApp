
namespace RafahiaBlazorApp.Models
{
    [Table("Image", Schema = "RH")]
    public class TPImage
    {
        [Key]
        [Display(Name = "IDImage")]
        public int IDImage { get; set; }

        //public int IDActivity { get; set; }
        //[ForeignKey("IDActivity")]
        //public ActivityRegister? activityRegister { get; set; }

        public int IDContent { get; set; }
        [ForeignKey("IDContent")]
        public ActivityContent? activityContent { get; set; }

        [Display(Name = "URLImage")]
        public string? URLImage { get; set; }

        [Display(Name = "Extention")]
        public string? Extention { get; set; }

        [Display(Name = "Typeiamge")]
        public string? Typeiamge { get; set; }

        [Display(Name = "NameImage")]
        public string? NameImage { get; set; }

        [Display(Name = "SizeImage")]
        public long? SizeImage { get; set; }

        [Display(Name = "NoteImage")]
        public string? NoteImage { get; set; }
    }
}
