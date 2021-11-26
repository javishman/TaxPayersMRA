using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace TaxPayersMRA.Services
{
    public class HttpContentCreator
    {
        public HttpContentCreator()
        {
        }

        public HttpContent createStringContent<E>(E entity) 
        {
            var json = JsonSerializer.Serialize(entity);
            Debug.WriteLine(json);
            HttpContent content = new StringContent(json, Encoding.UTF8, "application/json");
            return content;
        }
    }
}
