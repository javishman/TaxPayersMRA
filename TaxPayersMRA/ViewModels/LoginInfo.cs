using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace TaxPayersMRA.ViewModels
{
    public class LoginInfo
    {
        [Required]
        [StringLength(50, ErrorMessage = "{0} is too long.")]
        public string Email { get; set; }
        [Required]
        [StringLength(50, ErrorMessage = "{0} is too long.")]
        public string Password { get; set; }
    }
}
