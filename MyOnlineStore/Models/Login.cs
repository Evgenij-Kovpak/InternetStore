using System.ComponentModel.DataAnnotations;

namespace MyOnlineStore.Models
{
    public class Login
    {
        [Required, EmailAddress]
        public string Email { get; set; }
        [DataType(DataType.Password), Required, MinLength(4, ErrorMessage = "Введите не менее четырех символов")]
        public string Password { get; set; }
        public string ReturnUrl { get; set; }

    }
}
