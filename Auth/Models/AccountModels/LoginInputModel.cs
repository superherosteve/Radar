using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Auth.Models.AccountModels
{
    public class LoginInputModel
    {
        [Required(ErrorMessage = "emailRequired")]
        public string Email { get; set; }
        [Required(ErrorMessage = "passwordRequired")]
        public string Password { get; set; }
        public bool RememberLogin { get; set; }
        public string ReturnUrl { get; set; }
    }
}
