using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class Slider : IEntity
    {
        public int Id { get; set; }

        [Display(Name = "Başlık")]
        [Required(ErrorMessage = "Bu alan boş geçilmez")]
        public string Title { get; set; }
        [Display(Name = "İçerik")]
        [Required(ErrorMessage = "Bu alan boş geçilmez")]
        public string Description { get; set; }
        public string Link { get; set; }
        public string Image { get; set; }

    }
}
