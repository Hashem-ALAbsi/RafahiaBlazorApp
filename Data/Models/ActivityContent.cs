
namespace RafahiaBlazorApp.Models
{
    [Table("ActivityContent", Schema = "RH")]
    public class ActivityContent
    {
        [Key]
        [Display(Name = "IDContent")]
        public int IDContent { get; set; }

        [Display(Name = "NumberContent")]
        [Column(TypeName = "varchar(250)")]
        public string? NumberContent { get; set; }


        public int IDActivity { get; set; }
        [ForeignKey("IDActivity")]
        public ActivityRegister? activityRegister { get; set; }


        public int TypeId { get; set; }
        [ForeignKey("TypeId")]
        public TypeContent? type { get; set; }


        [Display(Name = "DescriptionContent")]
        [Column(TypeName = "varchar(250)")]
        public string? DescriptionContent { get; set; }



        [Display(Name = "StateContent")]
        [Column(TypeName = "varchar(250)")]
        public string? StateContent { get; set; }


        [Display(Name = "PriceContent")]
        [Column(TypeName = "varchar(250)")]
        public double? PriceContent { get; set; }


        [Display(Name = "NumberRoom")]
        [Column(TypeName = "varchar(250)")]
        public string? NumberRoom { get; set; }


        [Display(Name = "NumberBathRoom")]
        [Column(TypeName = "varchar(250)")]
        public string? NumberBathRoom { get; set; }


        [Display(Name = "TV")]
        [Column(TypeName = "varchar(250)")]
        public bool? TV { get; set; }


        [Display(Name = "Internet")]
        [Column(TypeName = "varchar(250)")]
        public bool? Internet { get; set; }

        //public int? IDImage { get; set; }
        //[ForeignKey("IDImage")]
        //public TPImage? image { get; set; }
    }
}
