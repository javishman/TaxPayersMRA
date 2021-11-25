using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TaxPayersMRA.ViewModels;

namespace TaxPayersMRA.Responses
{
    public class LoginResponse : BaseResponse
    {
        public UserToken Token { get; set; }
        public bool Authenticated { get; set; }
        public UserDetails UserDetails { get; set; }
    }
}
