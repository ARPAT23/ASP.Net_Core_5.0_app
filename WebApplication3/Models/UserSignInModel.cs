using System.ComponentModel.DataAnnotations;

namespace WebApplication3.Models
{
    public class UserSignInModel
    {
        [Required(ErrorMessage ="Lütfen kullanıcı adını girin")]
        public string username { get; set; }

        [Required(ErrorMessage = "Lütfen şifrenizi girin")]
        public string password { get; set; }
    }
}
