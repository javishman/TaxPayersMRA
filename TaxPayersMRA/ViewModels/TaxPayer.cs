using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace TaxPayersMRA.ViewModels
{
    public class TaxPayer
    {
        [Required]
        [StringLength(45, ErrorMessage = "{0} is too long.")]
        public string TPIN { get; set; }
        [Required]
        [StringLength(45, ErrorMessage = "{0} is too long.")]
        public string BusinessCertificateNumber { get; set; }
        [Required]
        [StringLength(45, ErrorMessage = "{0} is too long.")]
        public string TradingName { get; set; }
        [Required]
        [StringLength(45, ErrorMessage = "{0} is too long.")]
        public string BusinessRegistrationDate { get; set; }
        [Required]
        [StringLength(45, ErrorMessage = "{0} is too long.")]
        public string MobileNumber { get; set; }
        [Required]
        [StringLength(45, ErrorMessage = "{0} is too long.")]
        public string Email { get; set; }
        [Required]
        [StringLength(45, ErrorMessage = "{0} is too long.")]
        public string PhysicalLocation { get; set; }
        [Required]
        [StringLength(45, ErrorMessage = "{0} is too long.")]
        public string Username { get; set; }
    }
}
