using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TaxPayersMRA.Responses
{
    public class BaseResponse
    {
        public int ResultCode { get; set; }
        public string Remark { get; set; }

    }
}
