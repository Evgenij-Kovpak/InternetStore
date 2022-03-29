using Microsoft.AspNetCore.Http;
using MyOnlineStore.Infrastructure;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MyOnlineStore.Models
{
    public class Product
    {
        public int Id { get; set; }
        [Required, MinLength(2, ErrorMessage = "Введите не менее двух символов")]
        public string Name { get; set; }
        public string Slug { get; set; }
        [Required, MinLength(4, ErrorMessage = "Введите не менее четырех символов")]
        public string Description { get; set; }
        [Column(TypeName = "decimal(18, 2)")]
        public decimal Price { get; set; }
        [Display(Name = "Category")]
        [Range(1, int.MaxValue, ErrorMessage = "Вы должны выбрать категорию")]
        public int CategoryId { get; set; }

        public string Image { get; set; }

        [ForeignKey("CategoryId")]
        public virtual Category Category { get; set; }
        [NotMapped]
        [FileExtension]
        public IFormFile ImageUpload { get; set; }

    }
}
