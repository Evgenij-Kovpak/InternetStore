using System.ComponentModel.DataAnnotations;

namespace MyOnlineStore.Models
{
    public class User
    {
        [Required, MinLength(2, ErrorMessage = "Введите не менее двух символов")]
        public string UserName { get; set; }
        [Required, EmailAddress]
        public string Email { get; set; }
        [DataType(DataType.Password), Required, MinLength(4, ErrorMessage = "Введите не менее четырех символов")]
        public string Password { get; set; }

    }
}
