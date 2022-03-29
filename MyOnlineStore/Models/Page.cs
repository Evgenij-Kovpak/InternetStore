using System.ComponentModel.DataAnnotations;

namespace MyOnlineStore.Models
{
    public class Page
    {
        public int Id { get; set; }
        [Required, MinLength(2, ErrorMessage = "Введите не менее двух символов")]
        public string Title { get; set; }
        public string Slug { get; set; }
        [Required, MinLength(4, ErrorMessage = "Введите не менее четырех символов")]
        public string Content { get; set; }
        public int Sorting { get; set; }
    }
}
