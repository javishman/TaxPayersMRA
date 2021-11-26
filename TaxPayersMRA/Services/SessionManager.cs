using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TaxPayersMRA.Responses;
using TaxPayersMRA.ViewModels;

namespace TaxPayersMRA.Services
{
    public class SessionManager
    {
        private readonly string LOGIN_KEY = "1";
        private readonly string TAX_PAYER_KEY = "2";

        private readonly Dictionary<String, LoginResponse> _loginDictionary;
        private readonly Dictionary<String, TaxPayer> _taxPayerDictionary;

        public SessionManager()
        {
            _loginDictionary = new Dictionary<String, LoginResponse>();
            _taxPayerDictionary = new Dictionary<String, TaxPayer>();
        }

        public LoginResponse GetLoginResponse()
        {
            return _loginDictionary.GetValueOrDefault(LOGIN_KEY, new LoginResponse());
        }

        public void SetLoginResponse(LoginResponse loginResponse)
        {
            _loginDictionary.Add(LOGIN_KEY, loginResponse);
        }

        public void SetTaxPayer(TaxPayer taxPayer)
        {
            _taxPayerDictionary.Add(TAX_PAYER_KEY, taxPayer);
        }

        public TaxPayer GetTaxPayer()
        {
            return _taxPayerDictionary.GetValueOrDefault(TAX_PAYER_KEY, new TaxPayer());
        }

        public void Remove()
        {
            _taxPayerDictionary.Remove(TAX_PAYER_KEY);
        }
    }
}
