

using System.ComponentModel.DataAnnotations;

namespace Entities
{
    public class Category : IEntity
    {
        public int Id { get; set; }
        [Display(Name="Üst Kategori")]
        public int ParentId { get; set; }
        [Display(Name = "Kategori Adı")]
        [Required(ErrorMessage = "Bu alan boş geçilmez")]
        public string Name { get; set; }
        [Display(Name = "Açıklama")]
        [Required(ErrorMessage = "Bu alan boş geçilmez")]
        [DataType(DataType.MultilineText)]
        public string Description { get; set; }
        [Display(Name = "Resim")]
        public string Image { get; set; }

    }
}
