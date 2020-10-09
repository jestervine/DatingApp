using System.ComponentModel.DataAnnotations;

namespace API.DTOs
{
    public class RegisterDto
    {
        [Required]
        [Display(Name="User Name", AutoGenerateFilter=false)]
        public string UserName { get; set; }

        [Required]
        public string Password { get; set; }
    }
}