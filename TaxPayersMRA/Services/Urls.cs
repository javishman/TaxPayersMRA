using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TaxPayersMRA.Services
{
    public class Urls
    {
        private readonly IConfiguration _configuration;
        public Urls(IConfiguration configuration)
        {
            _configuration = configuration;
        }
        public string BaseUrl() 
        {
            try
            {
                return _configuration.GetValue<string>("BaseUrl");
            }
            catch (Exception)
            {
                return "https://www.mra.mw/sandbox/";
            }
        }

        public string LoginUrl()
        {
            try
            {
                return _configuration.GetValue<string>("LoginUrl");
            }
            catch (Exception)
            {
                return "programming/challenge/webservice/auth/login";
            }
        }

        public string LogoutUrl()
        {
            try
            {
                return _configuration.GetValue<string>("LogoutUrl");
            }
            catch (Exception)
            {
                return "programming/challenge/webservice/auth/logout";
            }
        }

        public string AddTaxPayerUrl()
        {
            try
            {
                return _configuration.GetValue<string>("AddTaxPayerUrl");
            }
            catch (Exception)
            {
                return "programming/challenge/webservice/Taxpayers/add";
            }            
        }

        public string GetAllTaxPayersUrl()
        {
            try
            {
                return _configuration.GetValue<string>("GetAllTaxPayersUrl");
            }
            catch (Exception)
            {
                return "programming/challenge/webservice/Taxpayers/getAll";
            }
        }

        public string EditTaxPayerUrl()
        {
            try
            {
                return _configuration.GetValue<string>("EditTaxPayerUrl");
            }
            catch (Exception)
            {
                return "programming/challenge/webservice/Taxpayers/edit";
            }            
        }

        public string DeleteTaxPayerUrl()
        {
            try
            {
                return _configuration.GetValue<string>("DeleteTaxPayerUrl");
            }
            catch (Exception)
            {
                return "programming/challenge/webservice/Taxpayers/delete";
            }
        }
    }
}
