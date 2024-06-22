using System.ComponentModel.DataAnnotations;

namespace lab7.Model.authentication.signUp
{
    public class RegisterUser
    {
        [Required(ErrorMessage = "Vui lòng nhập tên người dùng.")]
        public string? UserName { get; set; }
        [Required(ErrorMessage = "Vui lòng nhập mật khẩu người dùng.")]
        public string? Password { get; set; }
        [EmailAddress]
        public string? Email { get; set; }
    }
}
