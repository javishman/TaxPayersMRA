using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TaxPayersMRA.Responses
{
    public class GenericResponse<T> : BaseResponse
    {
        public T data { get; set; }
    }
}
