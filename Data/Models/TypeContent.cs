
namespace RafahiaBlazorApp.Models
{
    [Table("TypeContent", Schema = "RH")]
    public class TypeContent
    {
        [Key]
        [Display(Name = "IDType")]
        public int TypeId { get; set; }

        [Display(Name = "Type Name")]
        [Column(TypeName = "varchar(250)")]
        public string TypeName { get; set; } = string.Empty;
    }
}
