using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAL.ViewModels
{
    public class RegisterViewModel
    {
        [Required(ErrorMessage = "Email address is required.")]
        [Display(Name = "Email Address")]
        public string Email { get; set; }
        [Required]
        [DataType(DataType.Password)]
        public string Password { get; set; }
        [Display(Name ="Confirm Password")]
        [Compare("Password", ErrorMessage ="Password and confirm password do not match")]
        [DataType(DataType.Password)]
        public string ConfirmPassword { get; set; }
        public string NothiId { get; set; }
    }
}
