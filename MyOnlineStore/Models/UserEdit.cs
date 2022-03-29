using System.ComponentModel.DataAnnotations;

namespace MyOnlineStore.Models
{
    public class UserEdit
    {
        [Required, EmailAddress]
        public string Email { get; set; }
        [DataType(DataType.Password), MinLength(4, ErrorMessage = "Введите не менее четырех символов")]
        public string Password { get; set; }

        public UserEdit() { }

        public UserEdit(AppUser appUser)
        {
            Email = appUser.Email;
            Password = appUser.PasswordHash;
        }
    }
}
