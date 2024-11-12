using System.ComponentModel.DataAnnotations;

namespace ARM_Assignment.Entities.Models
{
    public class LoginModel
    {
      
            [Required]
            [Display(Name = "Email")]
            [EmailAddress]
            public string Email { get; set; }

            [Required]
            [DataType(DataType.Password)]
            [Display(Name = "Password")]
            public string Password { get; set; }

        
    }
}
