using System.ComponentModel.DataAnnotations;

namespace Entities
{
    public class Contact : IEntity
    {
        public int Id { get; set; }
        [Display(Name ="Adınız")]
        [Required(ErrorMessage="Bu alan boş geçilmez")]
        public string Name { get; set; }
        [Required(ErrorMessage = "Bu alan boş geçilmez")]
        public string Email { get; set; }
        [Display(Name = "Telefon NO")]
        [Required(ErrorMessage = "Bu alan boş geçilmez")]
        [StringLength(15)]
        public string Phone { get; set; }
        [Display(Name = "Mesajınız")]
        public string Message { get; set; }
        [Display(Name = "Oluşturma Tarihi")]
        [ScaffoldColumn(false)]
        public DateTime CreateDate { get; set; }

    }
}
