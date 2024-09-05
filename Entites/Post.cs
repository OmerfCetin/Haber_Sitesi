

using System.ComponentModel.DataAnnotations;

namespace Entities
{
    public class Post : IEntity
    {
        public int Id { get; set; }
        [Display(Name = "Başlık")]
        [Required(ErrorMessage = "Bu alan boş geçilmez")]
        public string Title { get; set; }
        [Display(Name = "İçerik")]
        [Required(ErrorMessage = "Bu alan boş geçilmez")]
        public string Content { get; set; }
        public string Image { get; set; }
        [Display(Name = "Eklenme Tarihi")]
        [ScaffoldColumn(false)]
        public DateTime CreateDate { get; set; } = DateTime.Now;
        public int CategoryId { get; set; }
        public virtual Category Category { get; set; } 

    }
}
