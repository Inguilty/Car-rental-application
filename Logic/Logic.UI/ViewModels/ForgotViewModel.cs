using System.ComponentModel.DataAnnotations;

namespace Logic.UI.ViewModels
{
    public class ForgotViewModel
    {
        [Required]
        [Display(Name = "Email")]
        public string Email { get; set; }
    }
}
