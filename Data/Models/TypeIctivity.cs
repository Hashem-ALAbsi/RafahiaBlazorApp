

namespace RafahiaBlazorApp.Models
{
    [Table("TypeActivity", Schema = "RH")]
    public class TypeIctivity
    {
        [Key]
        [Display(Name = "IDType")]
        public int TypeId { get; set; }

        [Display(Name = "Type Name")]
        [Column(TypeName = "varchar(250)")]
        public string TypeName { get; set; } = string.Empty;
    }
}
